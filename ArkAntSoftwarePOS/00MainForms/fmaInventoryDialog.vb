Imports System.Windows.Forms
Imports System.Threading
Imports System.ComponentModel


Public Class fmaInventoryDialog

    Private TRANSACTIONDAY_SYS As String = ""

    Sub New()
        InitializeComponent()

    End Sub

    Sub New(ByVal strParam As String)
        InitializeComponent()

        TRANSACTIONDAY_SYS = strParam
    End Sub


    Private m_AsyncWorker As New BackgroundWorker()



    Private Sub fmaInventoryDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        m_AsyncWorker.WorkerReportsProgress = True
        m_AsyncWorker.WorkerSupportsCancellation = True
        AddHandler m_AsyncWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf bwAsync_RunWorkerCompleted)
        AddHandler m_AsyncWorker.DoWork, New DoWorkEventHandler(AddressOf bwAsync_DoWork)

        lblStatus.Text = "Creating..."

        ' Kickoff the worker thread to begin it's DoWork function.
        btnOK.Enabled = False
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


        Dim SQLEX As String = "SELECT SysPK,a_name, a_code,uom,consignee"
        SQLEX += " FROM  inventory_master"


        'Dim SQLEX As String = "SELECT
        '                     inventory_master.SysPK,
        '                     inventory_master.a_code,  
        '                     inventory_master.a_name,
        '                     inventory_master.uom 'item_unit', 
        '                     IFNULL(ris_details.price,0) 'price', 
        '                     IFNULL(ris_details.qty_received,0) 'inv_qty',
        '                     IFNULL(consignee,'') 'description'
        '                    FROM inventory_master     LEFT JOIN 	ris_details 	ON	ris_details.inv_master_SysPK = inventory_master.a_code"



        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim nRows As Integer = 0
        If MeData.Rows.Count > 0 Then
            nRows = MeData.Rows.Count - 1


            For nCtr As Integer = 0 To nRows

                'Thread.Sleep(100)

                ' INSERT
                Dim SysPK_InvMaster As String = MeData.Rows(nCtr).Item("SysPK").ToString
                Dim a_name As String = MeData.Rows(nCtr).Item("a_name").ToString
                Dim a_code As String = MeData.Rows(nCtr).Item("a_code").ToString
                Dim item_unit As String = MeData.Rows(nCtr).Item("uom").ToString
                Dim Item_Description As String = MeData.Rows(nCtr).Item("consignee").ToString
                Dim initial_qty As Double = 0

                Dim TRDDate As String = Format(Date.Now, "yyyy-MM-dd")

                Dim loadedQty As String = "SELECT ds2.remaining_qty FROM daily_inventory_details ds2 WHERE a_code='" & a_code & "'"
                loadedQty += "ORDER BY TRD_Date DESC LIMIT 1"


                Dim tData As DataTable
                tData = clsDBConn.ExecQuery(loadedQty)

                If tData.Rows.Count > 0 Then
                    initial_qty = tData.Rows(0).Item("remaining_qty")
                End If

                Dim SQLIN As String = "INSERT INTO daily_inventory_details(SysPK_TRD,SysPK_InvMaster,"
                SQLIN += " a_name,item_unit,initial_qty,a_descr,TRD_Date,a_code, remaining_qty)"
                SQLIN += "VALUES("
                SQLIN += String.Format("'{0}', '{1}',", TRANSACTIONDAY_SYS, SysPK_InvMaster)
                SQLIN += String.Format("'{0}', '{1}',", a_name, item_unit)
                SQLIN += String.Format("'{0}', '{1}',", initial_qty, Item_Description)
                SQLIN += String.Format("'{0}', '{1}', '{2}')", TRDDate, a_code, initial_qty)



                If clsDBConn.Execute(SQLIN) Then
                    If nRows > 0 Then
                        bwAsync.ReportProgress(Convert.ToInt32(nCtr * (100.0 / nRows)))
                    End If

                    Dim labelSet As String = nCtr + 1 & " of " & nRows + 1
                    SetLabel1Text(labelSet)

                End If

                If bwAsync.CancellationPending Then
                    ' Pause for bit to demonstrate that there is time between 
                    ' "Cancelling..." and "Canceled".
                    Thread.Sleep(1200)

                    ' Set the e.Cancel flag so that the WorkerCompleted event
                    ' knows that the process was canceled.
                    e.Cancel = True
                    Return
                End If

            Next
            bwAsync.ReportProgress(100)
        End If

        
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

            lblStatus.Text = "Completed..."
            btnOK.Enabled = True
            Cancel_Button.Enabled = False
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 100
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


    Delegate Sub SetLabel1TextInvoker(ByVal TextToDisplay As String)

    Public Sub SetLabel1Text(ByVal TextToDisplay As String)
        If lblCount.InvokeRequired Then
            lblCount.Invoke(New SetLabel1TextInvoker(AddressOf SetLabel1Text), New Object() {TextToDisplay})
        Else
            lblCount.Text = TextToDisplay
        End If
    End Sub

    

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class
