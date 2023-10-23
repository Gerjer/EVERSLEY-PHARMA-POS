Imports System.Net.Mail
Imports System.Threading
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports DevExpress.UserSkins
Imports System.IO
Imports DevExpress.XtraTabbedMdi

Public Class ftmdiMainForm

    Inherits System.Windows.Forms.Form

    Dim WithEvents new_report As New fzzReportViewerForm

    Private WithEvents POS_FORM As fmaPointOfSaleForm = Nothing

    Private WithEvents MIRS_FORM As fmaMonthlyInventoryPerSupplierListForm

    Private invDiag As fmaInventoryDialog = Nothing
    Private TRANSACTIONDAY_SYS As String = ""

    Dim VersionNumber As Version

    Public tabbedMDIManager As XtraTabbedMdiManager = New XtraTabbedMdiManager()

    'Shared Sub New()

    '    DevExpress.UserSkins.BonusSkins.Register()

    'End Sub

    'Public Sub New()
    '    InitializeComponent()
    'End Sub


    Private Sub ftmdiMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed


        ftLoginForm.Show()

    End Sub


    Private Sub ftmdiMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        '     SkinManager.EnableFormSkins()
        '    SkinManager.EnableMdiFormSkins()
        '     DevExpress.UserSkins.BonusSkins.Register()

        tabbedMDIManager.MdiParent = Me
        tabbedMDIManager.AppearancePage.Header.BackColor = Color.Transparent
        tabbedMDIManager.AppearancePage.HeaderActive.BackColor = Color.Navy

        txtSystemText.Text = Format(DateTime.Now, "MMMM dd, yyyy")

        Dim SQLEX As String = "SELECT TRD_SYSPK, TransactionDay,day_stat FROM transaction_day "
        SQLEX += " WHERE TransactionDay='" & Format(Date.Now, "yyyy-MM-dd") & "'"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            CREATETRANSACTIONDAYToolStripMenuItem.Enabled = False
            DAILY_TRANSACTION_SYSPK = MeData.Rows(0).Item("TRD_SYSPK").ToString
        Else

            If AuthUserType = "Cashier" Then
                createTransactionDay()
            End If

        End If


        'Timer1.Interval = 100
        'AddHandler Timer1.Tick, AddressOf tim_Tick
        'Timer1.Start()

        If AuthUserType = "Cashier" Then
            Call loadPOSForm()
        End If


        VersionNumber = My.Application.Info.Version
        Dim vn = VersionNumber.Major & "." & VersionNumber.Minor & "." & VersionNumber.Build & "." & VersionNumber.Revision
        Dim VersionInfo As String = " v " & vn
        Me.Text = "EVERSLEY CHILD SANITARIUM PHARMACY MANAGEMENT " & VersionInfo



    End Sub

    Private Sub loadPOSForm()
        Dim SQLEX As String = "SELECT TransactionDay,day_stat FROM transaction_day "
        SQLEX += " WHERE TransactionDay='" & Format(Date.Now, "yyyy-MM-dd") & "'"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim status As String = ""

        If MeData.Rows.Count > 0 Then
            status = MeData.Rows(0).Item("day_stat").ToString

        Else
            MsgBox("Please Create Transaction Day for this Date." & vbNewLine &
                   "Transactions->Create Transaction Day", MsgBoxStyle.Critical)
            CLOSETRANSACTIONDAYToolStripMenuItem.Enabled = False
            VIEWTRANSACTIONSToolStripMenuItem.Enabled = False
            Exit Sub
        End If


        If status = "OPEN" Then
            CREATETRANSACTIONDAYToolStripMenuItem.Enabled = False
            VIEWTRANSACTIONSToolStripMenuItem.Enabled = True
            Me.Hide()
            'Mainloading.ShowDialog()
            'fmaPointOfSaleForm.MdiParent = Me
            If POS_FORM Is Nothing Then
                POS_FORM = New fmaPointOfSaleForm

                POS_FORM.Show()
                POS_FORM.BringToFront()
            End If

            'fmaPointOfSaleForm.Show()
            'fmaPointOfSaleForm.BringToFront()
        Else
            MsgBox("Cannot Make a transaction because Transaction Day is Closed.", MsgBoxStyle.Critical)
            CLOSETRANSACTIONDAYToolStripMenuItem.Enabled = False
            CREATETRANSACTIONDAYToolStripMenuItem.Enabled = False
        End If
    End Sub


    Private Structure LASTINPUTINFO
        Dim cbSize As Int32
        Dim dwTime As Int32
    End Structure

    Private Declare Function GetTickCount Lib "kernel32" () As Int32

    Private Declare Function GetLastInputInfo Lib "user32" (ByRef plii As LASTINPUTINFO) As Boolean


    'Private Sub tim_Tick(ByVal sender As Object, ByVal e As EventArgs)

    '    Dim lii As LASTINPUTINFO

    '    lii.cbSize = Len(lii)
    '    GetLastInputInfo(lii)

    '    Dim timeDelay As Integer = CInt(((GetTickCount() - lii.dwTime) / 1000.0).ToString)

    '    txttimer.Text = timeDelay


    '    If timeDelay > 120 Then
    '        Timer1.Stop()
    '        MsgBox("System Detects Inactivity for too long." & vbNewLine & _
    '               "Please Login Again.", MsgBoxStyle.Information)

    '        ftLoginForm.Show()
    '        ftLoginForm.btnBlank.PerformClick()
    '        Me.Close()
    '    End If
    'End Sub




    Private Sub ftmdiMainForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Dim SQLEX As String = "SELECT TransactionDay,day_stat FROM transaction_day "
        SQLEX += " WHERE TransactionDay='" & Format(Date.Now, "yyyy-MM-dd") & "'"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim status As String = ""

        If MeData.Rows.Count > 0 Then
            status = MeData.Rows(0).Item("day_stat").ToString
        Else
            MsgBox("Please Create Transaction Day for this Date." & vbNewLine &
                   "Transactions->Create Transaction Day", MsgBoxStyle.Critical)
            Exit Sub
        End If


        If status = "OPEN" Then

            Call loadPOSForm()

            'If AuthUserType = "Cashier" Then
            '    Call loadPOSForm()
            'Else
            '    MsgBox("You are Logged as Supervisor." & vbNewLine & "Please login as Staff to Open Point Of Sale", MsgBoxStyle.Information)
            'End If

            'Mainloading.ShowDialog()
            'fmaPointOfSaleForm.MdiParent = Me
            'fmaPointOfSaleForm.Show()
            'fmaPointOfSaleForm.BringToFront()
        Else
            MsgBox("Cannot Make a transaction because Transaction Day is Closed.", MsgBoxStyle.Critical)
        End If



    End Sub

    Private Sub DBConnectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBConnectionsToolStripMenuItem.Click
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""

                Exit Sub
            End If
            ftDatabaseConnectionForm.ShowDialog()
            'Else
            '    ftDatabaseConnectionForm.ShowDialog()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        ftLoginForm.Show()
    End Sub

    Private Sub VIEWTRANSACTIONSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWTRANSACTIONSToolStripMenuItem.Click

        fmaTransactionMasterListForm.MdiParent = Me
        fmaTransactionMasterListForm.Show()
        fmaTransactionMasterListForm.BringToFront()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub LISTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTINGSToolStripMenuItem.Click
        fmaInventoryMasterListForm.MdiParent = Me
        fmaInventoryMasterListForm.Show()
        fmaInventoryMasterListForm.BringToFront()
    End Sub

    Private Sub UserSetupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserSetupToolStripMenuItem1.Click
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""

                Exit Sub
            End If
            fmaUserSetupViewerListForm.MdiParent = Me
            fmaUserSetupViewerListForm.Show()
            fmaUserSetupViewerListForm.BringToFront()
            'fmaUserSetupForm.MdiParent = Me
            'fmaUserSetupForm.Show()
            'fmaUserSetupForm.BringToFront()
        End If



    End Sub

    Private Sub UnitSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitSettingsToolStripMenuItem.Click
        fmaUnitsTypeListForm.MdiParent = Me
        fmaUnitsTypeListForm.Show()
        fmaUnitsTypeListForm.BringToFront()
    End Sub

    Private Sub ProductSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductSetupToolStripMenuItem.Click
        fmaItemListForm.MdiParent = Me
        fmaItemListForm.Show()
        fmaItemListForm.BringToFront()
    End Sub

    Private Sub SupplierSetupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaSuppliesCustodianListForm.MdiParent = Me
        fmaSuppliesCustodianListForm.Show()
        fmaSuppliesCustodianListForm.BringToFront()
    End Sub

    Private Sub REPLENISHMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPLENISHMENTToolStripMenuItem.Click
        fmaReplinishmentListForm.MdiParent = Me
        fmaReplinishmentListForm.Show()
        fmaReplinishmentListForm.BringToFront()
    End Sub

    Private Sub DailySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailySalesReportToolStripMenuItem.Click
        fmaReport_DailyForm.ShowDialog()
    End Sub

    Private Sub CREATETRANSACTIONDAYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CREATETRANSACTIONDAYToolStripMenuItem.Click

        createTransactionDay()
    End Sub

    Private Sub createTransactionDay()
        Dim SQLEX As String = "SELECT description, day_stat FROM transaction_day "
        SQLEX += " ORDER BY date_created DESC LIMIT 1"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Dim Status As String = MeData.Rows(0).Item("day_stat").ToString
            Dim trDate As String = MeData.Rows(0).Item("description").ToString


            If Status = "OPEN" Then
                MsgBox("Please Close Last Transaction Day First." & vbNewLine & trDate)
                Exit Sub
            End If

        End If



        SQLEX = "SELECT TRD_SYSPK, TransactionDay,day_stat FROM transaction_day "
        SQLEX += " WHERE TransactionDay='" & Format(Date.Now, "yyyy-MM-dd") & "'"
        MeData = Nothing
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            DAILY_TRANSACTION_SYSPK = MeData.Rows(0).Item("TRD_SYSPK").ToString

            MsgBox("TRANSACTION DAY IS ALREADY CREATED." & vbNewLine &
                   "STATUS : " & MeData.Rows(0).Item("day_stat").ToString, MsgBoxStyle.Information)

            Exit Sub
        End If

        If MessageBox.Show("CREATE TRANSACTION DAY?" & vbNewLine &
                           "DATE : " & Format(Date.Now, "yyyy-MM-dd"), "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim TRD_SYSPK As String = System.Guid.NewGuid.GetHashCode


            Dim SQLIN = "INSERT INTO transaction_day(TransactionDay,description,TRD_SYSPK)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}', '{2}')", Format(Date.Now, "yyyy-MM-dd"), Format(Date.Now, "TRD: MMMM dd, yyyy"), TRD_SYSPK)

            If clsDBConn.Execute(SQLIN) Then
                DAILY_TRANSACTION_SYSPK = TRD_SYSPK
                createOpeningInventory(TRD_SYSPK)

                'MsgBox("TRANSACTION DAY CREATED.")
                'createDailyCashCount(TRD_SYSPK)
            End If

        End If
    End Sub

    Private Sub createDailyCashCount(ByVal TRD_SYSPK As String)
        Dim SQLIN As String = "INSERT INTO daily_cash_count(DCC_date,TRD_SYSPK)"
        SQLIN += String.Format(" VALUES('{0}', '{1}')", Format(Date.Now, "yyyy-MM-dd"), TRD_SYSPK)
        If clsDBConn.Execute(SQLIN) Then

        End If


    End Sub


    Private Sub CLOSETRANSACTIONDAYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSETRANSACTIONDAYToolStripMenuItem.Click

        Try
            fmaPointOfSaleForm.Close()
        Catch ex As Exception

        End Try

        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""

                Exit Sub
            End If

            Dim closeDlg As fmaCloseTransactionDayDlg

            closeDlg = New fmaCloseTransactionDayDlg

            closeDlg.ShowDialog()




        End If
    End Sub




    Private Sub createOpeningInventory(ByVal TRD_SYSPK As String)

        TRANSACTIONDAY_SYS = TRD_SYSPK
        If Not invDiag Is Nothing Then
            invDiag = Nothing
        End If

        invDiag = New fmaInventoryDialog(TRANSACTIONDAY_SYS)

        invDiag.ShowDialog(Me)

    End Sub


    'Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    '    txttimer.Text = Format(DateTime.Now, "hh:mm:ss") & ": "
    'End Sub

    Private Sub DAILYCASHCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAILYCASHCOUNTToolStripMenuItem.Click
        fmaDailyCashCountForm.ShowDialog(Me)


    End Sub

    Private Sub MembersSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembersSetupToolStripMenuItem.Click
        fmaPharmaMasterListForm.ShowDialog(Me)
    End Sub

    Private Sub MonthlySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaMonthlySalesReportForm.ShowDialog()
    End Sub

    Private Sub POS_FORM_WIN_CLOSED() Handles POS_FORM.WIN_CLOSED
        Me.Show()
        POS_FORM = Nothing
    End Sub

    Private Sub new_report_REPORTCLOSED() Handles new_report.REPORTCLOSED



    End Sub

    Private Sub new_report_REPORTSTARTS() Handles new_report.REPORTSTARTS

    End Sub

    Private Sub EmailReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim RPTdate As String = Format(Date.Now, "yyyy-MM-dd")

        Dim SQLEX As String = "SELECT dailysales_cashier, SUM(dailysales_net) AS 'netSales' "
        SQLEX += " FROM daily_sales_master"
        SQLEX += " WHERE DATE(dailysales_date)='" & RPTdate & "'"
        SQLEX += " AND Transaction_Type <> 'VOID'"
        SQLEX += " GROUP BY dailysales_cashier"

        Dim path As String = ""

        Try
            new_report.AttachReport(SQLEX, "Daily_Sales_Report_" & RPTdate) = New rpt_DailySalesReport(RPTdate)
            path = Directory.GetCurrentDirectory()
            path = path & "\" & new_report.Text

            Dim FileToDelete As String = path + ".Pdf"

            If System.IO.File.Exists(FileToDelete) = True Then

                System.IO.File.Delete(FileToDelete)
            End If


            new_report.exportPDF(path)

        Catch ex As Exception

        End Try



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
            mail.Attachments.Add(New Attachment(path))
            mail.From = New MailAddress("nexusnetadvance@gmail.com", "Nexus Net", System.Text.Encoding.UTF8)
            mail.To.Add("trashfin@gmail.com")
            'mail.To.Add("arius101@yahoo.com")
            'mail.To.Add("fely_cuizon@ymail.com")
            mail.Subject = "Daily Report"
            mail.Body = "Please see attached file/s for your perusal."
            SmtpServer.Send(mail)
            MsgBox("Report has been Sent.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub sendMail_DSR()
        Dim RPTdate As String = Format(Date.Now, "yyyy-MM-dd")

        Dim SQLEX As String = "SELECT dailysales_cashier, SUM(dailysales_net) AS 'netSales' "
        SQLEX += " FROM daily_sales_master"
        SQLEX += " WHERE DATE(dailysales_date)='" & RPTdate & "'"
        SQLEX += " AND Transaction_Type <> 'VOID'"
        SQLEX += " GROUP BY dailysales_cashier"

        Dim path As String = ""

        Try
            new_report.AttachReport(SQLEX, "Daily_Sales_Report_" & RPTdate) = New rpt_DailySalesReport(RPTdate)
            path = Directory.GetCurrentDirectory()
            path = path & "\" & new_report.Text

            Dim FileToDelete As String = path + ".Pdf"

            If System.IO.File.Exists(FileToDelete) = True Then

                System.IO.File.Delete(FileToDelete)
            End If


            new_report.exportPDF(path)

        Catch ex As Exception

        End Try



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
            mail.Attachments.Add(New Attachment(path))
            mail.From = New MailAddress("nexusnetadvance@gmail.com", "Nexus Net", System.Text.Encoding.UTF8)
            mail.To.Add("trashfin@gmail.com")
            'mail.To.Add("arius101@yahoo.com")
            'mail.To.Add("fely_cuizon@ymail.com")
            mail.Subject = "Daily Report"
            mail.Body = "Please see attached file/s for your perusal."
            SmtpServer.Send(mail)
            MsgBox("Report has been Sent.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EXITToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem2.Click
        Me.Close()
        ftLoginForm.Close()
    End Sub

    Private Sub SETUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaPharmaMasterListForm.MdiParent = Me
        fmaPharmaMasterListForm.Show()
        fmaPharmaMasterListForm.BringToFront()
    End Sub

    Private Sub MEDICINETYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEDICINETYPEToolStripMenuItem.Click
        fmaMedTypeListForm.MdiParent = Me
        fmaMedTypeListForm.Show()
        fmaMedTypeListForm.BringToFront()
    End Sub


    Private Sub PatientTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaPatientTypeMasterListForm.MdiParent = Me
        fmaPatientTypeMasterListForm.Show()
        fmaPatientTypeMasterListForm.BringToFront()
    End Sub

    Private Sub PatientProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaPersonProfileListForm.MdiParent = Me
        fmaPersonProfileListForm.Show()
        fmaPersonProfileListForm.BringToFront()
    End Sub


    Private Sub MONTHLYWORKSHEETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MONTHLYWORKSHEETToolStripMenuItem.Click
        fmaIssuanceSummarySheetForm.MdiParent = Me
        fmaIssuanceSummarySheetForm.Show()
        fmaIssuanceSummarySheetForm.BringToFront()
    End Sub

    Private Sub WARDSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaWardListForm.MdiParent = Me
        fmaWardListForm.Show()
        fmaWardListForm.BringToFront()
    End Sub

    Private Sub MonthlyReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyReportToolStripMenuItem.Click
        fmaMonthlySummaryReportForm.ShowDialog(Me)
    End Sub

    Private Sub DetailedInventoryPerSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailedInventoryPerSupplierToolStripMenuItem.Click

        If MIRS_FORM Is Nothing Then

            MIRS_FORM = New fmaMonthlyInventoryPerSupplierListForm()
            MIRS_FORM.MdiParent = Me
            MIRS_FORM.Show()
            MIRS_FORM.BringToFront()

        End If



    End Sub

    Private Sub STOCKCARDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKCARDToolStripMenuItem.Click
        fmaStockCardForm.MdiParent = Me
        fmaStockCardForm.Show()
        fmaStockCardForm.BringToFront()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtSystemText.Text = Format(DateTime.Now, "MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub UPDATEBEGINNINGBALANCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEBEGINNINGBALANCEToolStripMenuItem.Click
        fmaUpdateBegBalForm.MdiParent = Me
        fmaUpdateBegBalForm.Show()
        fmaUpdateBegBalForm.BringToFront()
    End Sub

    Private Sub INVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INVEToolStripMenuItem.Click
        fmaInventoryCountPerSupplierListForm.MdiParent = Me
        fmaInventoryCountPerSupplierListForm.Show()
        fmaInventoryCountPerSupplierListForm.BringToFront()
    End Sub

    Private Sub CASHCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASHCOUNTToolStripMenuItem.Click
        fmaDailyCashCountForm.ShowDialog()
    End Sub

    Private Sub RequisitionIssueSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequisitionIssueSlipToolStripMenuItem.Click
        fmaRISSetupForm.MdiParent = Me
        fmaRISSetupForm.Show()
        fmaRISSetupForm.BringToFront()
    End Sub

    Private Sub SUPPLIERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPPLIERToolStripMenuItem.Click
        fmaSupplierMasterListForm.MdiParent = Me
        fmaSupplierMasterListForm.Show()
        fmaSupplierMasterListForm.BringToFront()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        fmaStorageLocationListForm.MdiParent = Me
        fmaStorageLocationListForm.Show()
        fmaStorageLocationListForm.BringToFront()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        OpenFileEditor.MdiParent = Me
        OpenFileEditor.Show()
        OpenFileEditor.BringToFront()
    End Sub

    Private Sub REQUISITIONLISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REQUISITIONLISTToolStripMenuItem.Click

        Dim frm As New fmaRISListForm
        frm.MdiParent = Me
        frm.Tag = REQUISITIONLISTToolStripMenuItem.Tag
        frm.Show()
        frm.BringToFront()

    End Sub

    Private Sub LISTOFPRICEAVAILABLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTOFPRICEAVAILABLEToolStripMenuItem.Click

        fmaPriceAvailableListForm.MdiParent = Me
        fmaPriceAvailableListForm.Show()
        fmaPriceAvailableListForm.BringToFront()

    End Sub

    Private Sub ListOfProcuredMedicinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfProcuredMedicinesToolStripMenuItem.Click

        Dim frm As New fmaProcurementListForm
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

    End Sub

    Private Sub MasterDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDetailsToolStripMenuItem.Click

        Dim frm As New MasterDetails
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

    End Sub

    Private Sub PatientMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientMonitoringToolStripMenuItem.Click

        Dim frm As New fmaPatientMonitoringList
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

    End Sub

    Private Sub ListOfReOrderingPointToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfReOrderingPointToolStripMenuItem.Click

        Dim frm As New fmaReOrdeingPointList
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

    End Sub

    Private Sub CHARGINGTYPEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        fmaPatientTypeMasterListForm.MdiParent = Me
        fmaPatientTypeMasterListForm.Show()
        fmaPatientTypeMasterListForm.BringToFront()
    End Sub

    Private Sub PURCHASEREQUESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PURCHASEREQUESTToolStripMenuItem.Click


        Dim frm As New fmaPurchaseRequestSetupForm
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()


    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        fmaTimelinessForm.MdiParent = Me
        fmaTimelinessForm.Show()
        fmaTimelinessForm.BringToFront()
    End Sub

    Private Sub WARDSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WARDSToolStripMenuItem1.Click
        fmaWardListForm.MdiParent = Me
        fmaWardListForm.Show()
        fmaWardListForm.BringToFront()
    End Sub

    Private Sub PATIENTPROFILEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PATIENTPROFILEToolStripMenuItem1.Click
        fmaPersonProfileListForm.MdiParent = Me
        fmaPersonProfileListForm.Show()
        fmaPersonProfileListForm.BringToFront()
    End Sub

    Private Sub CHARGINGTYPEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CHARGINGTYPEToolStripMenuItem.Click
        fmaPatientTypeMasterListForm.MdiParent = Me
        fmaPatientTypeMasterListForm.Show()
        fmaPatientTypeMasterListForm.BringToFront()
    End Sub

    Private Sub FUNDCLASSIFICATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FUNDCLASSIFICATIONToolStripMenuItem.Click
        fmaPharmaMasterListForm.MdiParent = Me
        fmaPharmaMasterListForm.Show()
        fmaPharmaMasterListForm.BringToFront()
    End Sub

    Private Sub MEDICINETYPEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEDICINETYPEToolStripMenuItem1.Click
        fmaMedTypeListForm.MdiParent = Me
        fmaMedTypeListForm.Show()
        fmaMedTypeListForm.BringToFront()
    End Sub

    Private Sub UNITTYPEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNITTYPEToolStripMenuItem.Click
        fmaUnitsTypeListForm.MdiParent = Me
        fmaUnitsTypeListForm.Show()
        fmaUnitsTypeListForm.BringToFront()
    End Sub

    Private Sub SUPPLIERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SUPPLIERToolStripMenuItem1.Click
        fmaSupplierMasterListForm.MdiParent = Me
        fmaSupplierMasterListForm.Show()
        fmaSupplierMasterListForm.BringToFront()
    End Sub

    Private Sub STORAGELOCATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STORAGELOCATIONToolStripMenuItem.Click
        fmaStorageLocationListForm.MdiParent = Me
        fmaStorageLocationListForm.Show()
        fmaStorageLocationListForm.BringToFront()
    End Sub

    Private Sub REQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REQToolStripMenuItem.Click
        fmaRISSetupForm.MdiParent = Me
        fmaRISSetupForm.Show()
        fmaRISSetupForm.BringToFront()
    End Sub

    Private Sub REQUISITIONMASTERLISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REQUISITIONMASTERLISTToolStripMenuItem.Click
        Dim frm As New fmaRISListForm
        frm.MdiParent = Me
        frm.Tag = REQUISITIONLISTToolStripMenuItem.Tag
        frm.Show()
        frm.BringToFront()
    End Sub

    Private Sub PURCHASEREQUESTLISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PURCHASEREQUESTLISTToolStripMenuItem.Click
        Dim frm As New fmaPRListForm
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()
    End Sub

    Private Sub PRODUCTSETTINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTSETTINGSToolStripMenuItem.Click
        Dim frm As New MasterDetails
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()
    End Sub

    Private Sub ListOfDispensedMedicinesPerPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfDispensedMedicinesPerPatientToolStripMenuItem.Click

        Dim frm As New fmaGeneralServicesListofMed
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()
    End Sub

    Private Sub MIRS_FORM_MIRS_CLOSING() Handles MIRS_FORM.MIRS_CLOSING
        MIRS_FORM.Close()
    End Sub
End Class