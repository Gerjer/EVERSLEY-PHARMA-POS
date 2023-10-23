Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export.Xls
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.Collections.Generic
'Imports SautinSoft
'Imports Spire.Pdf
'Imports Spire.Pdf.Conversion

Public Class fmaMonthlyInventoryPerSupplierListForm

    Public Event MIRS_CLOSING()

    Private WithEvents MeAR As ActiveReport3
    Private SQLCMD As String = ""
    Public DirectPrinting As Boolean = False
    Dim MonthlyInventory As New List(Of Monthly_Inventory)


    Private Sub fmaMonthlyInventoryPerSupplierListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        txtYear.Value = Date.Now
        dtpDateMonthof.DataSource = months
        dtpDateMonthof.SelectedIndex = Date.Now.Month - 1


        'dateFrom.Value = New DateTime(Date.Now.Year, Date.Now.Month - 1, 1)

        Dim SQLEX As String = "SELECT IF(paymentgroup='0','Private','Government') 'type',paymentgroup FROM pharmaceuticals"
        SQLEX += " GROUP BY type"
        SQLEX += " ORDER BY paymentgroup"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.cmbClassification.DataSource = MeData
        Me.cmbClassification.DisplayMember = "type"
        Me.cmbClassification.ValueMember = "paymentgroup"
        Me.cmbClassification.SelectedIndex = 0


        displaySuppliers()

        If RadioButton3.Checked = True Then
            TabItem13.Visible = True
            TabItem14.Visible = False
        Else
            TabItem13.Visible = False
            TabItem14.Visible = True
        End If


    End Sub


    Private Sub displaySuppliers()

        Dim SQLEX As String = ""
        If RadioButton1.Checked = True Then
            SQLEX = "SELECT	pharmaceuticals.SysPK 'a_code',pharmaceuticals.a_name 'name'"
            SQLEX += " FROM	pharmaceuticals"
        Else
            SQLEX = "SELECT DISTINCT  supplier.a_code,supplier 'name'"
            SQLEX += " FROM	ris_master"
            SQLEX += " INNER JOIN supplier on ris_master.supplier_SysPK = supplier.a_code AND supplier.supplier_type = 0"
            SQLEX += " ORDER BY `name`"
        End If


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try

                Me.txtSupplierList.DataSource = MeData
                Me.txtSupplierList.DisplayMember = "name"
                Me.txtSupplierList.ValueMember = "a_code"
                Me.txtSupplierList.SelectedIndex = -1
                Me.txtSupplierList.Text = ""
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            RaiseEvent MIRS_CLOSING()
            'Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbClassification_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClassification.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbClassification.SelectedItem, DataRowView)
            Me.txtClassificationCode.Text = drv.Item("paymentgroup").ToString
        Catch ex As Exception
            Me.txtClassificationCode.Text = ""
        End Try


        displaySuppliers()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim str As String = ""
        If RadioButton1.Checked = True Then
            str = "ris_master.fund_class_id = '" & txtSupplierList.SelectedValue & "'"
        Else
            str = "ris_master.supplier_SysPK = '" & txtSupplierCode.Text & "'"
        End If


        Dim Firstday As String = Format(dateFrom.Value, "yyyy-MM-dd")

        Dim SQLEX As String = "SELECT
	        daily_inventory_details.TRD_Date,
	        
	        ris_master.supplier_SysPK 'supcode',  
	        daily_inventory_details.a_code, 
	        inventory_master.a_name, 
	        daily_inventory_details.initial_qty 'begQty',
	        last_ris_details.price 'begPrice',
	        daily_inventory_details.initial_qty * last_ris_details.price 'begTotalCost', 
	        daily_inventory_details.initial_qty * last_ris_details.price 'balTotalCost', 
	        SUM(daily_inventory_details.added) 'recQty',
            last_ris_details.price 'recPrice',
	        SUM(daily_inventory_details.added) * last_ris_details.price 'recTotalCost',
	        SUM(daily_inventory_details.pullout) 'pullQty',
	        last_ris_details.price 'pullPrice',
            SUM(daily_inventory_details.pullout) * last_ris_details.price 'pullTotalCost',
 	        SUM(daily_inventory_details.sold) 'soldQty',
            last_ris_details.price 'soldPrice',
            SUM(daily_inventory_details.sold) * last_ris_details.price 'soldTotalCost',	
	        (daily_inventory_details.initial_qty + SUM(daily_inventory_details.added)) - (SUM(daily_inventory_details.pullout) + SUM(daily_inventory_details.sold) ) 'endQty', 
	        last_ris_details.price 'endPrice',
	        ((daily_inventory_details.initial_qty + SUM(daily_inventory_details.added)) - (SUM(daily_inventory_details.pullout) + SUM(daily_inventory_details.sold) )) * last_ris_details.price 'endTotalCost', 
	        ris_master.supplier,
            ris_master.fund_class

        FROM
	        daily_inventory_details
	        INNER JOIN  (
		     SELECT *
		     FROM ris_details
             
		     GROUP BY inv_master_SysPK
		     ORDER BY RIS_Det_No
		    ) AS last_ris_details
		
			        
	        
	        ON daily_inventory_details.a_code = last_ris_details.inv_master_SysPK
	        INNER JOIN ris_master	ON last_ris_details.RIS_Master_No = ris_master.RIS_No
	        INNER JOIN inventory_master	ON daily_inventory_details.a_code = inventory_master.a_code
        WHERE
	        daily_inventory_details.TRD_Date BETWEEN '" & Format(dateFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dateTo.Value, "yyyy-MM-dd") & "' AND  " & str & " 
            
            GROUP BY  a_code ORDER BY supplier,a_code"

        Dim reportTitle As String = txtSupplierList.Text & " DETAILED INVENTORY OF MEDICINES PER SUPPLIER FOR THE MONTH OF " _
                                    & dtpDateMonthof.Text.ToUpper & " " & txtYear.Text
        Dim paramdateFrom As String = Format(dateFrom.Value, "yyyy-MM-dd")
        Dim paramdateTo As String = Format(dateTo.Value, "yyyy-MM-dd")

        Dim monthOf As String = dtpDateMonthof.Text.ToUpper & " " & txtYear.Text


        If RadioButton3.Checked = True Then

            Dim dt As New DataTable
            dt = DataSource(String.Format(SQLEX))
            If dt.Rows.Count > 0 Then

                For Each rows As DataRow In dt.Rows
                    Dim obj As New Monthly_Inventory
                    With obj
                        .fund_classification = rows("fund_class")
                        .supplier = rows("supplier")
                        .trd_date = rows("TRD_Date")
                        .item_code = rows("a_code")
                        .item_name = rows("a_name")
                        .begQty = rows("begQty")
                        .begPrince = rows("begPrice")
                        .begTotalCost = rows("begTotalCost")
                        .balTotalCost = rows("balTotalCost")
                        .recQty = rows("recQty")
                        .recPrice = rows("recPrice")
                        .recTotalCost = rows("recTotalCost")
                        .pullQty = rows("pullQty")
                        .pullPrice = rows("pullPrice")
                        .pullTotalPrice = rows("pullTotalCost")
                        .soldQty = rows("soldQty")
                        .soldPrice = rows("soldPrice")
                        .soldTotalCost = rows("soldTotalCost")
                        .endQty = rows("endQty")
                        .endPrice = rows("endPrice")
                        .endTotalCost = rows("endTotalCost")
                        .fund_classification = rows("fund_class")
                        .supplier = rows("supplier")
                    End With
                    MonthlyInventory.Add(obj)
                Next

                Dim report As New xtrMonthlyActualInvenytory
                report.Title.Text = reportTitle
                report.dateHeader.Text = "DATE : " & monthOf
                report.DataSource = MonthlyInventory

                If RadioButton1.Checked = True Then
                    report.titleHeader.Text = "FUND CLASSIFICATION : " & txtSupplierList.Text
                    report.GroupHeader1.Visible = True
                Else
                    report.titleHeader.Text = "SUPPLIER : " & txtSupplierList.Text
                    report.GroupHeader1.Visible = False
                End If

                report.PrintingSystem.Document.AutoFitToPagesWidth = 1
                    report.CreateDocument()

                    DocumentViewer1.DocumentSource = report

                Else
                    MsgBox("Record Not Found!!!")
            End If

            MonthlyInventory.Clear()

            If cxboxPrintSummary.Checked = True Then
                printSummarizedFormat()
            End If


        Else
                Try
                If RadioButton1.Checked = True Then
                    AttachReport(SQLEX, reportTitle) = New rpt_MonthlyActualInventoryFundClassification(paramdateFrom, paramdateTo, monthOf)
                Else
                    AttachReport(SQLEX, reportTitle) = New rpt_MonthlyActualInventoryPerSupplier(paramdateFrom, paramdateTo, monthOf)
                End If
                Show()
            Catch ex As Exception

            End Try

            If cxboxPrintSummary.Checked = True Then
                printSummarizedFormat()
            End If
        End If

    End Sub

    Private Sub dtpDateMonthof_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateMonthof.SelectedIndexChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value.Year, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.ValueChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value.Year, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSupplierList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierList.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtSupplierList.SelectedItem, DataRowView)
            Me.txtSupplierCode.Text = drv.Item("a_code").ToString
        Catch ex As Exception
            Me.txtSupplierCode.Text = ""
        End Try
    End Sub


    Private Sub dateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged
        Try
            dateTo.Value = New DateTime(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.AddMonths(1).AddDays(-1).Day)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub printSummarizedFormat()

        Dim dt_MonthVal As New DataTable

        Dim reportTitle As String = "SUMMARY REPORT OF ISSUANCES AND BALANCES OF DRUGS AND MEDICINES FOR THE MONTH OF " _
                                    & dtpDateMonthof.Text & " " & txtYear.Text
        Dim paramdateFrom As String = Format(dateFrom.Value, "yyyy-MM-dd")
        Dim paramdateTo As String = Format(dateTo.Value, "yyyy-MM-dd")
        Dim monthOf As String = Format(dateFrom.Value, "MMMM dd, yyyy")


        dt_MonthVal.Columns.Add("COL_A")
        dt_MonthVal.Columns.Add("COL_B")


        Dim SQLEX As String = "SELECT sysPk,supplier, beginning_value,added,"
        SQLEX += " pulled_out, onhand_stock, ending_value,totalIssuance"
        SQLEX += " FROM issuance_summary_master"
        SQLEX += " WHERE dateFrom='" & Format(dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND dateTo='" & Format(dateTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND type='" & CInt(txtClassificationCode.Text) & "'"
        SQLEX += " AND supplier='" & txtSupplierList.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)


        If MeData.Rows.Count > 0 Then
            Dim ColA As String = ""
            Dim ColB As String = ""
            Dim sysPk As String = MeData.Rows(0).Item("sysPk").ToString

            ColA = "BEGINNING BALANCE " & monthOf
            ColB = Format(CDbl(MeData.Rows(0).Item("beginning_value").ToString), "#,##0.00")
            dt_MonthVal.Rows.Add(New String() {ColA, ColB})

            ColA = "       ADD :         DELIVERIES "
            ColB = Format(CDbl(MeData.Rows(0).Item("added").ToString), "#,##0.00")
            dt_MonthVal.Rows.Add(New String() {ColA, ColB})

            ColA = "       LESS:         PULL-OUT STOCKS "
            ColB = Format(CDbl(MeData.Rows(0).Item("pulled_out").ToString), "#,##0.00")
            dt_MonthVal.Rows.Add(New String() {ColA, ColB})

            ColA = "TOTAL STOCKS ON HAND "
            ColB = Format(CDbl(MeData.Rows(0).Item("onhand_stock").ToString), "#,##0.00")
            dt_MonthVal.Rows.Add(New String() {ColA, ColB})

            dt_MonthVal.Rows.Add(New String() {"LESS: COST OF SALES", ""})

            ' GET IN PATIENT
            dt_MonthVal.Rows.Add(New String() {"IN-PATIENT:", ""})

            Dim SQLEX_INPATIENT As String = "SELECT a_code, a_name, payment_type,patient_type FROM patient_type"
            SQLEX_INPATIENT += " WHERE patient_type='0'"
            SQLEX_INPATIENT += " ORDER BY patient_type, a_code"

            Dim DT_INPATIENT As DataTable
            DT_INPATIENT = clsDBConn.ExecQuery(SQLEX_INPATIENT)

            If DT_INPATIENT.Rows.Count > 0 Then
                For index As Integer = 0 To DT_INPATIENT.Rows.Count - 1
                    Dim type As String = DT_INPATIENT.Rows(index).Item("a_code").ToString
                    Dim ColName As String = DT_INPATIENT.Rows(index).Item("payment_type").ToString

                    ColA = "     " & ColName
                    ColB = getValueByPaymentType(type, sysPk)

                    dt_MonthVal.Rows.Add(New String() {ColA, ColB})

                Next

            End If

            dt_MonthVal.Rows.Add(New String() {"OUT-PATIENT:", ""})
            ' out-patient
            SQLEX_INPATIENT = "SELECT a_code, a_name, payment_type,patient_type FROM patient_type"
            SQLEX_INPATIENT += " WHERE patient_type='1'"
            SQLEX_INPATIENT += " ORDER BY patient_type, a_code"

            DT_INPATIENT = Nothing
            DT_INPATIENT = clsDBConn.ExecQuery(SQLEX_INPATIENT)

            If DT_INPATIENT.Rows.Count > 0 Then
                For index As Integer = 0 To DT_INPATIENT.Rows.Count - 1
                    Dim type As String = DT_INPATIENT.Rows(index).Item("a_code").ToString
                    Dim ColName As String = DT_INPATIENT.Rows(index).Item("payment_type").ToString

                    ColA = "     " & ColName
                    ColB = getValueByPaymentType(type, sysPk)

                    dt_MonthVal.Rows.Add(New String() {ColA, ColB})

                Next

            End If

            ColA = "TOTAL ISSUANCES "
            ColB = Format(CDbl(MeData.Rows(0).Item("totalIssuance").ToString), "#,##0.00")
            dt_MonthVal.Rows.Add(New String() {ColA, ColB})

            ColA = "INVENTORY " & Format(dateTo.Value, "MMMM dd, yyyy")
            ColB = Format(CDbl(MeData.Rows(0).Item("ending_value").ToString), "#,##0.00")
            dt_MonthVal.Rows.Add(New String() {ColA, ColB})



        End If

        report_summarized_balance = New DataTable
        report_summarized_balance = dt_MonthVal


        Dim new_report As New fzzReportViewerForm

        Try
            new_report.AttachReport(SQLEX, reportTitle) = New rptSummarizedIssuance_Balances(paramdateFrom, paramdateTo, monthOf, CInt(txtClassificationCode.Text))
            new_report.Show()
        Catch ex As Exception

        End Try


    End Sub

    Private Function getValueByPaymentType(ByVal pType As String, ByVal masterSysPK As String) As String
        Dim RETVALUE As Double = 0
        Dim formatStr As String = "-"

        Dim SQLDetail As String = "SELECT  `issuance_summary_detail`.`amount`"
        SQLDetail += " , `patient_type`.`payment_type`"
        SQLDetail += " , `patient_type`.`a_code`"
        SQLDetail += " FROM issuance_summary_detail"
        SQLDetail += " INNER JOIN patient_type"
        SQLDetail += " ON (`issuance_summary_detail`.`paymentType` = `patient_type`.`a_code`)"
        SQLDetail += " WHERE paymentType='" & pType & "'"
        SQLDetail += " AND masterSysPK='" & masterSysPK & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLDetail)


        If MeData.Rows.Count > 0 Then
            Try
                RETVALUE = CDbl(MeData.Rows(0).Item("amount").ToString)

            Catch ex As Exception

            End Try
        End If

        If RETVALUE > 0 Then
            formatStr = Format(RETVALUE, "#,##0.00")
        End If

        Return formatStr

    End Function

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        exportExcel()
    End Sub

    Dim FilePDF As String = ""
    Private Sub exportPDF_to_EXCELL()

        '      Dim FileName As String = Me.Text & ".pdf"

        '      Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        '      ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        '      'FileName += ".Pdf"
        ''      ExportPDF.Export(MeAR.Document, FileName)


        '      Dim pathToPdf As String = Path.GetFullPath("C:\Users\Roger  Petailan\OneDrive\Documents\IN-HOUSE DETAILED INVENTORY OF MEDICINES PER SUPPLIER FOR THE MONTH OF JULY 2023.pdf")
        '      Dim pathToExcel As String = "Result.xls"

        '      Dim f As New SautinSoft.PdfFocus()

        '      ' 'true' = Convert all data to spreadsheet (tabular and even textual).
        '      ' 'false' = Skip textual data and convert only tabular (tables) data.
        '      f.ExcelOptions.ConvertNonTabularDataToSpreadsheet = True

        '      ' 'true'  = Preserve original page layout.
        '      ' 'false' = Place tables before text.
        '      f.ExcelOptions.PreservePageLayout = False

        '      ' The information includes the names for the culture, the writing system, 
        '      ' the calendar used, the sort order of strings, and formatting for dates and numbers.
        '      Dim ci As New System.Globalization.CultureInfo("en-US")
        '      ci.NumberFormat.NumberDecimalSeparator = ","
        '      ci.NumberFormat.NumberGroupSeparator = "."
        '      f.ExcelOptions.CultureInfo = ci

        '      f.OpenPdf(pathToPdf)

        '      If f.PageCount > 0 Then
        '          Dim result As Integer = f.ToExcel(pathToExcel)

        '          'Open a produced Excel workbook
        '          If result = 0 Then
        '              System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(pathToExcel) With {.UseShellExecute = True})
        '          End If
        '      End If


    End Sub

    Private Sub btnrtf_Click(sender As Object, e As EventArgs) Handles btnrtf.Click
        exportRTF()
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        exportPDF()
    End Sub
    Private Sub exportExcel()
        Dim NewExport As New XlsExport
        Dim spath As String = Directory.GetCurrentDirectory
        Dim FileName As String = spath & "\" & Me.Text & ".xls"
        NewExport.FileFormat = FileFormat.Xls97Plus
        Try
            If System.IO.File.Exists(FileName) Then
                Try
                    My.Computer.FileSystem.DeleteFile(FileName)
                Catch ex As Exception
                End Try
            End If

            NewExport.Export(MeAR.Document, FileName)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub exportRTF()
        Dim spath As String = Directory.GetCurrentDirectory
        Dim FileName As String = spath & "\" & Me.Text

        Dim ExportRTF As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
        FileName += ".rtf"
        ExportRTF.Export(MeAR.Document, FileName)
        ExportRTF = Nothing

        Process.Start(FileName)
    End Sub
    Public Sub exportPDF()
        Dim spath As String = Directory.GetCurrentDirectory
        Dim FileName As String = spath & "\" & Me.Text & ".pdf"

        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        'FileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, FileName)
        ExportPDF = Nothing
        Process.Start(FileName)
    End Sub

    Public Property AttachReport(ByVal SQLstring As String, ByVal Title As String)
        Get
            Return MeAR
        End Get
        Set(ByVal value)
            MeAR = value

            If Title.Trim <> "" Then
                Me.Text = Title
            End If

            If SQLstring.Trim <> "" Then
                Me.SQLCMD = SQLstring
                Me.WindowState = FormWindowState.Maximized
                MeViewer.Document.Printer.PrinterName = ""
                MeViewer.Document = MeAR.Document

                MeAR.DataSource = clsDBConn.ExecQuery(SQLstring)
                MeAR.Run(True)

                MeViewer.ReportViewer.Zoom = -1
            End If
        End Set
    End Property

    Public Sub Print()
        If DirectPrinting Then
            MeAR.Document.Print(False, True, True)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        displaySuppliers()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        displaySuppliers()
    End Sub


End Class