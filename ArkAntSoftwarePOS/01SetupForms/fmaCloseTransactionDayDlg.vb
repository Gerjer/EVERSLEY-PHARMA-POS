Imports System.Windows.Forms
Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports System.Net.Mail



Public Class fmaCloseTransactionDayDlg
    Private NETSALES As Double = 0

    Dim WithEvents new_report As New fzzReportViewerForm



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private m_AsyncWorker As New BackgroundWorker()


    Private Sub fmaCloseTransactionDayDlg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim RPTdate As String = Format(Date.Now, "yyyy-MM-dd")

        'Dim SQLEX As String = "SELECT dailysales_cashier, SUM(dailysales_net) AS 'netSales' "
        'SQLEX += " FROM daily_sales_master"
        'SQLEX += " WHERE DATE(dailysales_date)='" & RPTdate & "'"
        'SQLEX += " AND Transaction_Type <> 'VOID'"
        'SQLEX += " GROUP BY dailysales_cashier"

        'Dim path As String = ""

        'Try
        '    new_report.AttachReport(SQLEX, "Daily_Sales_Report_" & RPTdate) = New rpt_DailySalesReport(RPTdate)
        '    path = Directory.GetCurrentDirectory()
        '    path = path & "\" & new_report.Text

        '    'Dim FileToDelete As String = path + ".Pdf"

        '    'If System.IO.File.Exists(FileToDelete) = True Then

        '    '    System.IO.File.Delete(FileToDelete)
        '    'End If


        '    new_report.exportPDF(path)

        'Catch ex As Exception

        'End Try

        'NETSALES = GET_DAILY_SALES()


        m_AsyncWorker.WorkerReportsProgress = True
        m_AsyncWorker.WorkerSupportsCancellation = True
        AddHandler m_AsyncWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf bwAsync_RunWorkerCompleted)
        AddHandler m_AsyncWorker.DoWork, New DoWorkEventHandler(AddressOf bwAsync_DoWork)

        lblStatus.Text = "Creating Report..."
        ' Kickoff the worker thread to begin it's DoWork function.
        OK_Button.Enabled = False
        m_AsyncWorker.RunWorkerAsync()

    End Sub

#Region "Asynchronous BackgroundWorker Thread"


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        lblStatus.Text = "Canceling..."

        ' Notify the worker thread that a cancel has been requested.
        ' The cancel will not actually happen until the thread in the 
        ' DoWork checks the bwAsync.CancellationPending flag, for this
        ' reason we set the label to "Canceling...", because we haven't 
        ' actually cancelled yet.
        m_AsyncWorker.CancelAsync()
    End Sub


    Private Sub bwAsync_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        ' The Sender is the BackgroundWorker object we need it to
        ' report progress and check for cancellation.
        Dim bwAsync As BackgroundWorker = TryCast(sender, BackgroundWorker)

        'SetLabel1Text("Sending Email..")
        Thread.Sleep(1200)


        Dim SQLEX As String = "SELECT TransactionDay,day_stat FROM transaction_day "
        SQLEX += " WHERE TransactionDay='" & Format(Date.Now, "yyyy-MM-dd") & "'"
        'SQLEX += " AND Transaction_Type <> 'VOID'"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim status As String = ""

        If MeData.Rows.Count > 0 Then
            status = MeData.Rows(0).Item("day_stat").ToString
        Else
            'MsgBox("Please Create Transaction Day for this Date." & vbNewLine & _
            '       "Transactions->Create Transaction Day", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Dim netCashSales As Double = GET_DAILY_SALES()

        'If modCommon.GET_CASH_COUNT_AMOUNT <> modCommon.GET_DAILY_SALES Then
        '    MsgBox("Please Check Cash Count of the Day before Closing.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        If status = "OPEN" Then
            'If MessageBox.Show("Are you sure you want to CLOSE TRANSACTION DAY?" & vbNewLine & _
            '               "You Cannot make a Transaction after Closing", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then



            Dim SQLUP As String = "UPDATE transaction_day SET day_stat='CLOSE'"
            SQLUP += " WHERE TransactionDay='" & Format(Date.Now, "yyyy-MM-dd") & "'"
            SQLUP += " AND day_stat='OPEN'"
            'SQLUP += " AND Transaction_Type <> 'VOID'"


            If clsDBConn.Execute(SQLUP) Then

                SQLUP = "UPDATE daily_sales_master"
                SQLUP += " SET status='CLOSED'"
                SQLUP += " WHERE DATE(tr_date)='" & Format(Date.Now, "yyyy-MM-dd") & "'"
                SQLUP += " AND status <> 'VOID'"
                If clsDBConn.Execute(SQLUP) Then
                    SetLabel1Text("Closing Transactions..")
                    'sendMail_DSR()
                End If

            End If


        End If
        'Else
        'MsgBox("Cannot Transaction Day is already Closed.", MsgBoxStyle.Critical)
        'End If

        setProgressBar(0)
        bwAsync.ReportProgress(100)
        'MsgBox("Transaction Day is Closed. You cannot do any transactions.", MsgBoxStyle.Information)
    End Sub

    Private Sub bwAsync_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        ' The background process is complete. We need to inspect 
        ' our response to see if an error occured, a cancel was 
        ' requested or if we completed succesfully.

        'bnAsync.Text = "Start Long Running Asychronous Process"
        'bnAsync.Enabled = True

        ' Check to see if an error occured in the 
        ' background process.
        If e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
            Return
        End If

        ' Check to see if the background process was cancelled.
        If e.Cancelled Then
            lblStatus.Text = "Cancelled..."
            ProgressBar1.Style = ProgressBarStyle.Blocks
        Else
            ' Everything completed normally.
            ' process the response using e.Result

            lblStatus.Text = "Transaction Day Closed." & vbNewLine & "You cannot do Transactions Anymore.."
            OK_Button.Enabled = True
            Cancel_Button.Enabled = False
            ProgressBar1.Style = ProgressBarStyle.Blocks
            Me.Text = "Transaction Day Created."
        End If
    End Sub

    Private Sub bwAsync_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        ' This function fires on the UI thread so it's safe to edit
        ' the UI control directly, no funny business with Control.Invoke.
        ' Update the progressBar with the integer supplide to us from the 
        ' ReportProgress() function.  Note, e.UserState is a "tag" property
        ' that can be used to send other information from the BackgroundThread
        ' to the UI thread.

        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Delegate Sub setProgressBarInvoker(ByVal progressStyle As Integer)

    Public Sub setProgressBar(ByVal progressStyle As Integer)


        If ProgressBar1.InvokeRequired Then
            ProgressBar1.Invoke(New setProgressBarInvoker(AddressOf setProgressBar), New Object() {progressStyle})
        Else
            If progressStyle = 0 Then
                ProgressBar1.Style = ProgressBarStyle.Blocks
            End If
        End If
    End Sub



    Delegate Sub SetLabel1TextInvoker(ByVal TextToDisplay As String)

    Public Sub SetLabel1Text(ByVal TextToDisplay As String)
        If lblStatus.InvokeRequired Then
            lblStatus.Invoke(New SetLabel1TextInvoker(AddressOf SetLabel1Text), New Object() {TextToDisplay})
        Else
            lblStatus.Text = TextToDisplay
        End If
    End Sub


    Private Sub sendMail_DSR()
        'Dim RPTdate As String = Format(Date.Now, "yyyy-MM-dd")

        'Dim SQLEX As String = "SELECT dailysales_cashier, SUM(dailysales_net) AS 'netSales' "
        'SQLEX += " FROM daily_sales_master"
        'SQLEX += " WHERE DATE(dailysales_date)='" & RPTdate & "'"
        'SQLEX += " AND Transaction_Type <> 'VOID'"
        'SQLEX += " GROUP BY dailysales_cashier"

        Dim path As String = ""

        'Try
        '    new_report.AttachReport(SQLEX, "Daily_Sales_Report_" & RPTdate) = New rpt_DailySalesReport(RPTdate)
        '    path = Directory.GetCurrentDirectory()
        '    path = path & "\" & new_report.Text

        '    'Dim FileToDelete As String = path + ".Pdf"

        '    'If System.IO.File.Exists(FileToDelete) = True Then

        '    '    System.IO.File.Delete(FileToDelete)
        '    'End If


        '    new_report.exportPDF(path)

        'Catch ex As Exception

        'End Try



        ' create sales report as pdf

        ' create inventory report as pdf

        ' email it with attachment
        path = Directory.GetCurrentDirectory()
        path = path & "\" & new_report.Text & ".Pdf"


        



        ' send as email
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential("nexusnetadvance@gmail.com", "N3xusN3t4dvance130666")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True

            mail = New MailMessage()
            Try
                mail.Attachments.Add(New Attachment(path))
            Catch ex As Exception
                MsgBox("Fail to attach Report. Please see net sales as Email Content.")
            End Try

            mail.From = New MailAddress("nexusnetadvance@gmail.com", "Nexus Net", System.Text.Encoding.UTF8)
            mail.To.Add("trashfin@gmail.com")
            'mail.To.Add("arius101@yahoo.com")
            'mail.To.Add("fely_cuizon@ymail.com")
            mail.Subject = "DSR: " & new_report.Text & ".Pdf"
            mail.Body = "Please see attached file/s for your perusal." & vbNewLine & "No Need to reply in this email." _
            & vbNewLine & "NET SALES : " & Format(NETSALES, "#,##0.00")
            SmtpServer.Send(mail)
            MsgBox("Report has been Sent.", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub



#End Region



End Class
