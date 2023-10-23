Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Threading

Public Class fmaReport_DailyForm



    Private Sub fmaReport_DailyForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.dtpDate.Value = Date.Now
        cmbxReportType.SelectedIndex = 2
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If cmbxReportType.SelectedIndex = 0 Then
            rptDailyMedicineIssuance()
        ElseIf cmbxReportType.SelectedIndex = 1 Then
            rptDailyMedicineIssuanceConsign()
        ElseIf cmbxReportType.SelectedIndex = 2 Then
            rptDailyMedicineIssuancePerPatient()
        ElseIf cmbxReportType.SelectedIndex = 3 Then
            dailyInventoryReport()

        End If
    End Sub

    Private Sub rptDailyMedicineIssuance()
        'Dim SQLEX As String = "SELECT supplier.a_name 'consignee' "
        'SQLEX += " , `daily_sales_detail`.`item_descr`"
        'SQLEX += " , SUM(`daily_sales_detail`.`item_qty`) 'item_qty'"
        'SQLEX += " , `daily_sales_detail`.`item_price` 'item_price'"
        'SQLEX += " , SUM(`daily_sales_detail`.`item_total`) 'item_total'"
        'SQLEX += " , `daily_sales_master`.`charging`"
        'SQLEX += " , ris_details.price 'item_buyprice'"
        'SQLEX += " , (`ris_details.price * SUM(`daily_sales_detail`.`item_qty`)) 'total_cost'"
        'SQLEX += " ,(SUM(`daily_sales_detail`.`item_total`)) - "
        'SQLEX += " ((ris_details.price * SUM(`daily_sales_detail`.`item_qty`))) 'margin' "
        'SQLEX += " FROM .`daily_sales_master`"
        'SQLEX += " INNER JOIN .`daily_sales_detail` "
        'SQLEX += " ON (`daily_sales_master`.`SysPK` = `daily_sales_detail`.`sales_sys`)"
        'SQLEX += " INNER JOIN .`inventory_master` "
        'SQLEX += " ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`)"
        'SQLEX += " INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No"
        'SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No"
        'SQLEX += " INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code"
        'SQLEX += " WHERE DATE(tr_date)='" & Format(Me.dtpDate.Value, "yyyy-MM-dd") & "'"
        'SQLEX += " GROUP BY item_descr"
        'SQLEX += " ORDER BY consignee"

        Dim SQLEX As String = "SELECT
	                            supplier.a_name 'consignee',
	                            `daily_sales_detail`.`item_descr`,
	                            SUM( `daily_sales_detail`.`item_qty` ) 'item_qty',
	                            `inventory_master`.`selling_price` 'item_price',
	                            SUM( `daily_sales_detail`.`item_qty` ) * `inventory_master`.`selling_price` 'item_total',
	                            `daily_sales_master`.`charging`,
	                            inventory_master.selling_price 'item_buyprice',
	
	                            (
		                            ris_details.price * SUM( `daily_sales_detail`.`item_qty` )) 'total_cost',(
		                            SUM( `daily_sales_detail`.`item_total` )) - ((
		                            ris_details.price * SUM( `daily_sales_detail`.`item_qty` ))) 'margin' 
                            FROM
	                            .`daily_sales_master`
	                            INNER JOIN.`daily_sales_detail` ON ( `daily_sales_master`.`SysPK` = `daily_sales_detail`.`sales_sys` )
	                            INNER JOIN.`inventory_master` ON ( `daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code` ) 
	                            INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
	                            INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No
	                            INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code
                            WHERE
	                            DATE( tr_date )= '" & Format(Me.dtpDate.Value, "yyyy-MM-dd") & "' 
                            GROUP BY
	                            item_descr 
                            ORDER BY
	                            consignee"



        Dim RPTdate As String = Format(dtpDate.Value, "MMMM dd, yyyy")

        Dim new_report As New fzzReportViewerForm

        'new_report.TopLevel = False
        'new_report.TopMost = True
        'new_report.MinimizeBox = False
        'new_report.MaximizeBox = True
        'new_report.Dock = DockStyle.Fill
        'new_report.WindowState = FormWindowState.Maximized

        'panel.Controls.Add(new_report)


        Try
            new_report.AttachReport(SQLEX, "Medicine Issuance Report ( Per Item-Per Consignee") = New rpt_DailyRpt_Medicine_Issuance(RPTdate)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try

    End Sub

    Private Sub rptDailyMedicineIssuanceConsign()
        'Dim SQLEX As String = "SELECT `daily_sales_master`.`SysPK`"
        'SQLEX += " , `daily_sales_master`.`transactionno`"
        'SQLEX += " , `inventory_master`.`consignee`"
        'SQLEX += " , `daily_sales_master`.`charging`"
        'SQLEX += " ,SUM((daily_sales_detail.item_qty * inventory_master.item_buyprice)) 'TOTALCOST'"
        'SQLEX += " ,SUM((daily_sales_detail.item_qty * daily_sales_detail.item_price)) 'TOTALSALES'"
        'SQLEX += " ,(SUM((daily_sales_detail.item_qty * daily_sales_detail.item_price))) "
        'SQLEX += " - (SUM((daily_sales_detail.item_qty * inventory_master.item_buyprice))) 'REVENUE'   "
        'SQLEX += " FROM .`daily_sales_master`"
        'SQLEX += " INNER JOIN .`daily_sales_detail` "
        'SQLEX += " ON (`daily_sales_master`.`SysPK` = `daily_sales_detail`.`sales_sys`)"
        'SQLEX += " INNER JOIN .`inventory_master` "
        'SQLEX += " ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`)"
        'SQLEX += " WHERE DATE(tr_date)='" & Format(Me.dtpDate.Value, "yyyy-MM-dd") & "'"
        'SQLEX += " GROUP BY consignee,charging"
        'SQLEX += " ORDER BY consignee, charging"

        Dim SQLEX As String = "SELECT
	                            `daily_sales_master`.`SysPK`,
	                            `daily_sales_master`.`transactionno`,
  	                            supplier.a_name 'consignee',
	                            `daily_sales_master`.`charging`,
	                            SUM((
			                            daily_sales_detail.item_qty * ris_details.price 
		                            )) 'TOTALCOST',
	                            SUM((
			                            daily_sales_detail.item_qty * daily_sales_detail.item_price 
			                            )) 'TOTALSALES',(
		                            SUM((
				                            daily_sales_detail.item_qty * daily_sales_detail.item_price 
			                            ))) - (
		                            SUM((
				                            daily_sales_detail.item_qty * ris_details.price 
			                            ))) 'REVENUE' 
                            FROM
	                            .`daily_sales_master`
	                            INNER JOIN.`daily_sales_detail` ON ( `daily_sales_master`.`SysPK` = `daily_sales_detail`.`sales_sys` )
	                            INNER JOIN.`inventory_master` ON ( `daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code` )
	                            INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No 
	                            INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No
	                            INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code
                            WHERE
	                            DATE( tr_date )= '" & Format(Me.dtpDate.Value, "yyyy-MM-dd") & "'
                            GROUP BY
	                            consignee,
	                            charging 
                            ORDER BY
	                            consignee,
	                            charging"


        Dim RPTdate As String = Format(dtpDate.Value, "MMMM dd, yyyy")


        Dim new_report As New fzzReportViewerForm

        'new_report.TopLevel = False
        'new_report.TopMost = True
        'new_report.MinimizeBox = False
        'new_report.MaximizeBox = True
        'new_report.Dock = DockStyle.Fill
        'new_report.WindowState = FormWindowState.Maximized

        'panel.Controls.Add(new_report)


        Try
            new_report.AttachReport(SQLEX, "Medicine Issuance Report Per Consignee-Charging") = New rpt_DailyRpt_Medicine_Issuance_Consignee(RPTdate)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try
    End Sub


    Dim issued_patient As New List(Of IssuedPatient)
    Dim issued_charged As New List(Of IssuedCharging)

    Private Sub rptDailyMedicineIssuancePerPatient()

        'Issued Patient
        Dim dt As New DataTable
        dt = getIssuedPatient(Format(dtpDate.Value, "yyyy-MM-dd"))
        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
                Dim obj As New IssuedPatient
                With obj
                    .patient_id = row("patient_id").ToString
                    .patient_name = row("patient_name").ToString
                    .fund_class = row("fund_class").ToString
                    .tr_amnt = row("tr_amount").ToString
                    .paid_amt = row("paid_amount").ToString
                    .disc_amt = row("qfs_discount").ToString
                    .total = row("total").ToString
                End With
                issued_patient.Add(obj)
            Next

            dt = Nothing

            'Issued Charging


        End If



        Dim report As New xtrSummaryIssuedMedicinePerPatientCharging
        report.date_filter.Text = Format(dtpDate.Value, "MM/dd/yyyy")
        report.Report.DataSource = issued_patient

        dt = getIssuedCharging(Format(dtpDate.Value, "yyyy-MM-dd"))

        For Each row As DataRow In dt.Rows
            Dim obx As New IssuedCharging
            With obx
                .charging_id = row("chargingid").ToString
                .charging_type = row("charging").ToString
                .count = row("count").ToString
                .tr_amt = row("total").ToString
            End With
            issued_charged.Add(obx)
        Next

        Dim Subreport As XRSubreport = TryCast(report.GroupFooter2.Band().FindControl("XrSubreport1", True), XRSubreport)
        Subreport.ReportSource.DataSource = issued_charged

        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview

        '  DocumentViewer1.DocumentSource = report
        '   DocumentViewer1.InitiateDocumentCreation()

        '    document_viewer.DocumentSource = report
        '    document_viewer.InitiateDocumentCreation()

        issued_patient.Clear()
        issued_charged.Clear()

#Region "old"
        'Dim SQLEX As String = "SELECT
        '                 `daily_sales_master`.`tr_date`,
        '                 `daily_sales_master`.`patient_name`,
        '                 daily_sales_master.patient_id,
        '                 `daily_sales_detail`.`item_descr`,
        '                 supplier.a_name 'consignee',
        '                 `daily_sales_master`.`tr_amount`,
        '                 `daily_sales_master`.`charging`,
        '                 `daily_sales_master`.`chargingid`,
        '                  ris_master.fund_class 'fund_class',
        '                  '' AS 'type'
        '                FROM
        '                 daily_sales_master
        '                 INNER JOIN daily_sales_detail ON ( `daily_sales_master`.`SysPK` = `daily_sales_detail`.`sales_sys` )
        '                 INNER JOIN inventory_master ON ( `daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code` )
        '                 INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
        '                 INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No    
        '                 INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code
        '                WHERE
        '                 DATE( tr_date )= '" & Format(Me.dtpDate.Value, "yyyy-MM-dd") & "' 
        '                GROUP BY
        '                 chargingid,
        '                 patient_id 
        '                ORDER BY
        '                 charging,
        '                 patient_name"


        'Dim RPTdate As String = Format(dtpDate.Value, "yyyy-MM-dd")

        'Dim new_report As New fzzReportViewerForm
        'Try
        '    new_report.AttachReport(SQLEX, "SUMMARY OF DRUGS AND MEDICINE ISSUED( Per Patient)") = New rpt_DailyRpt_MedicineIssuance_ChargingSummary(RPTdate)
        '    new_report.Show()
        'Catch ex As Exception
        '    MsgBox("Exception Occured :", ex.Message)
        'End Try

#End Region



    End Sub

    Private Function getIssuedCharging(datefilter As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
	daily_sales_master.tr_date,
	daily_sales_master.charging,
	daily_sales_master.chargingid,
	count(daily_sales_master.chargingid)'count', 
  SUM(daily_sales_master.tr_amount) - SUM(IFNULL(daily_sales_master.qfs_discount,0)) 'total'
 	
FROM
	daily_sales_master
	INNER JOIN daily_sales_detail	ON daily_sales_master.SysPK = daily_sales_detail.sales_sys
	INNER JOIN patient_type ON daily_sales_master.chargingid = patient_type.a_code
	INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
	INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No
	WHERE DATE(tr_date) = '" & datefilter & "'
	GROUP BY chargingid
	ORDER BY daily_sales_master.chargingid"
        Return DataSource(sql)
    End Function

    Private Function getIssuedPatient(datefilter As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
  daily_sales_master.tr_date, 
	daily_sales_master.patient_id, 
	daily_sales_master.patient_name, 
	SUM(daily_sales_master.tr_amount) 'tr_amount', 
	SUM(IFNULL(daily_sales_master.paid_amount,0))'paid_amount', 
	SUM(IFNULL(daily_sales_master.qfs_discount,0))'qfs_discount',
  SUM(daily_sales_master.tr_amount) - SUM(IFNULL(daily_sales_master.qfs_discount,0)) 'total',
  ris_master.fund_class
	
FROM
	daily_sales_master
	INNER JOIN daily_sales_detail	ON daily_sales_master.SysPK = daily_sales_detail.sales_sys
	INNER JOIN patient_type ON daily_sales_master.chargingid = patient_type.a_code
	INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
	INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No
	WHERE DATE(tr_date) = '" & datefilter & "'
	GROUP BY 
	patient_id
	ORDER BY patient_id"
        Return DataSource(sql)
    End Function

    Private Sub dailyInventoryReport()
        Dim SQLEX As String = "SELECT  `daily_inventory_details`.`TRD_Date`"
        SQLEX += " , ris_master.supplier 'consignee'"
        SQLEX += " , CONCAT('    ',`daily_inventory_details`.`a_name`) 'a_name'"
        SQLEX += " , `daily_inventory_details`.`a_descr`"
        SQLEX += " , `daily_inventory_details`.`a_code`"
        SQLEX += " , `daily_inventory_details`.`item_unit`"
        SQLEX += " , `daily_inventory_details`.`initial_qty`"
        SQLEX += " , `daily_inventory_details`.`added`"
        SQLEX += " , `daily_inventory_details`.`sold`"
        SQLEX += " , `daily_inventory_details`.`pullout`"
        SQLEX += " , `daily_inventory_details`.`remaining_qty`"
        SQLEX += " FROM daily_inventory_details"
        SQLEX += " INNER JOIN inventory_master"
        SQLEX += " ON (`daily_inventory_details`.`SysPK_InvMaster` = `inventory_master`.`SysPK`)"
        SQLEX += " INNER JOIN ris_details ON inventory_master.a_code =  ris_details.inv_master_SysPK"
        SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No"
        SQLEX += " WHERE TRD_Date='" & Format(Me.dtpDate.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND ( added<>0  OR sold<>0 OR pullout<>0) "
        SQLEX += " GROUP BY a_code"
        SQLEX += " ORDER BY consignee, a_name"


        Dim RPTdate As String = Format(dtpDate.Value, "MMMM dd, yyyy")


        Dim new_report As New fzzReportViewerForm

        'new_report.TopLevel = False
        'new_report.TopMost = True
        'new_report.MinimizeBox = False
        'new_report.MaximizeBox = True
        'new_report.Dock = DockStyle.Fill
        'new_report.WindowState = FormWindowState.Maximized

        'panel.Controls.Add(new_report)


        Try
            new_report.AttachReport(SQLEX, "Daily Inventory Report : " & RPTdate) = New rpt_DailyInventory_Add_Sold(RPTdate)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try




    End Sub

    Dim panel As New Panel
    Dim document_viewer As New DevExpress.XtraPrinting.Preview.DocumentViewer


    Private Sub cmbxReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxReportType.SelectedIndexChanged


        'If cmbxReportType.SelectedIndex = 2 Then
        '    Me.GroupPanel2.Controls.Remove(panel)

        '    document_viewer.Dock = DockStyle.Fill
        '    document_viewer.BackColor = Color.DarkGray

        '    '    Me.DocumentViewer1.DocumentSource = Nothing
        '    Me.GroupPanel2.Controls.Add(Me.DocumentViewer1)
        '    Me.GroupPanel2.Controls.Add(Me.RibbonControl2)
        '    Me.GroupPanel2.Controls.Add(Me.RibbonStatusBar1)

        '    '     Me.GroupPanel2.Controls.Add(Me.document_viewer)

        'Else
        '    Me.GroupPanel2.Controls.Remove(Me.DocumentViewer1)
        '    Me.GroupPanel2.Controls.Remove(Me.RibbonControl2)
        '    Me.GroupPanel2.Controls.Remove(Me.RibbonStatusBar1)

        '    panel.Dock = DockStyle.Fill
        '    panel.BackColor = Color.DarkGray
        '    Me.GroupPanel2.Controls.Add(panel)
        'End If

    End Sub
End Class