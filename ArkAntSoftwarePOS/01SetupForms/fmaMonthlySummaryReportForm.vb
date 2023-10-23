Imports System.Data.SqlClient
Imports System.Threading

Public Class fmaMonthlySummaryReportForm

    


    Private Sub fmaARPAWorkSheetForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtYear.Value = Date.Now.Year
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        dtpDateMonthof.DataSource = months
        dtpDateMonthof.SelectedIndex = Date.Now.Month - 1


        'dateFrom.Value = New DateTime(Date.Now.Year, Date.Now.Month - 1, 1)

        'Dim SQLEX As String = "SELECT IF(paymentgroup='0','Private','Government') 'type',paymentgroup FROM pharmaceuticals"
        'SQLEX += " GROUP BY type"
        'SQLEX += " ORDER BY paymentgroup"

        'Dim MeData As DataTable
        'MeData = clsDBConn.ExecQuery(SQLEX)
        'Me.cmbClassification.DataSource = MeData
        'Me.cmbClassification.DisplayMember = "type"
        'Me.cmbClassification.ValueMember = "paymentgroup"
        'Me.cmbClassification.SelectedIndex = 0

        displayIncludeItems()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtpDateMonthof_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateMonthof.SelectedIndexChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged
        Try
            dateTo.Value = New DateTime(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.AddMonths(1).AddDays(-1).Day)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub displayIncludeItems()
        dgvBeginning.Rows.Clear()
        Dim SQLEX As String = "SELECT 0 AS 'checked',a_name, payment_type,a_code FROM patient_type"
        SQLEX += " WHERE `status` <> 0"
        SQLEX += " ORDER BY patient_type,a_code"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Try
            For cnt As Integer = 0 To MeData.Rows.Count - 1
                Dim supplierlist As New List(Of String)
                supplierlist.Add(CBool(MeData.Rows(cnt).Item("checked").ToString()))
                supplierlist.Add(MeData.Rows(cnt).Item("a_name").ToString())
                supplierlist.Add(MeData.Rows(cnt).Item("payment_type").ToString())
                supplierlist.Add(MeData.Rows(cnt).Item("a_code").ToString())
                dgvBeginning.Rows.Add(supplierlist.ToArray)
            Next

        Catch ex As Exception

        End Try



    End Sub

    
    Private Sub txtYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.ValueChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If cmbClassification.SelectedIndex = 0 Then
            Me.Cursor = Cursors.WaitCursor
            'printSummarizedTotalPerCharging()
            printSummarizedTotalPerChargingFast()
            Me.Cursor = Cursors.Default

        ElseIf cmbClassification.SelectedIndex = 1 Then
            Me.Cursor = Cursors.WaitCursor
            printSummaryPerPatient_PaymentType()
            Me.Cursor = Cursors.Default
        ElseIf cmbClassification.SelectedIndex = 2 Then
            Me.Cursor = Cursors.WaitCursor
            printSummaryPerPatient_MAPFormat()
            Me.Cursor = Cursors.Default

        ElseIf cmbClassification.SelectedIndex = 3 Then
            Me.Cursor = Cursors.WaitCursor
            printPatientCountPerCharging()
            Me.Cursor = Cursors.Default

        ElseIf cmbClassification.SelectedIndex = 4 Then
            Me.Cursor = Cursors.WaitCursor
            printIssuanceCountPerCharging()
            Me.Cursor = Cursors.Default

        ElseIf cmbClassification.SelectedIndex = 5 Then
            Me.Cursor = Cursors.WaitCursor
            printDeliveryPulloutItems()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub printSummaryPerPatient_PaymentType()


        Dim includeCharging As String = ""

        Dim rowcount As Integer = dgvBeginning.Rows.Count
        Dim hasChecked As Boolean = False

        Dim join_id As String = ""

        For jRows As Integer = 0 To (rowcount - 1)
            Dim is_included As Boolean = dgvBeginning.Item(0, jRows).Value.ToString()
            Dim chargeId As String = dgvBeginning.Item(3, jRows).Value.ToString()

            If is_included = True Then

                If hasChecked = False Then
                    includeCharging += " AND (chargingid='" & chargeId & "'"
                    hasChecked = True
                Else
                    includeCharging += " OR chargingid='" & chargeId & "'"
                    hasChecked = True

                    If join_id = "" Then
                        join_id = chargeId
                    Else
                        join_id += "," & chargeId
                    End If


                End If

                End If


        Next

        If hasChecked Then
            includeCharging += ")"
        Else
            MsgBox("Please check atleast one Charging Type.", MsgBoxStyle.Information)
            Exit Sub
        End If


        'Dim SQLEX As String = "SELECT patient_name, tr_amount,tr_date,"
        'SQLEX += " patient_id, charging, chargingid, transactionno"
        'SQLEX += " FROM daily_sales_master"
        'SQLEX += " WHERE DATE(tr_date) BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        'SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        'SQLEX += includeCharging
        'SQLEX += " AND daily_sales_master.status <> 'VOID'"
        'SQLEX += " GROUP BY chargingid, patient_id"
        'SQLEX += " ORDER BY chargingid,patient_name"

        Dim SQLEX As String = "SELECT DISTINCT
	patient_name,
	SUM(tr_amount)'tr_amount',
	IFNULL(paid_amount,0)'paid_amount',
	qfs_discount 'dis_amount',
	tr_date,
	patient_id,
	(SELECT header_template FROM	patient_type WHERE a_code = chargingid)'charging'

FROM
	daily_sales_master
	INNER JOIN daily_sales_detail ON daily_sales_master.SysPK =  daily_sales_detail.sales_sys

	WHERE	DATE( tr_date ) BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "' 
	AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "' AND daily_sales_master.STATUS <> 'VOID'
	AND chargingid IN (" & join_id & ")
	GROUP BY chargingid
	ORDER BY tr_date,patient_name "





        Dim RPTdateFrom As String = Format(Me.dateFrom.Value, "yyyy-MM-dd")
        Dim RPTdateTo As String = Format(Me.dateTo.Value, "yyyy-MM-dd")
        Dim MonthOf As String = dtpDateMonthof.Text & " " & txtYear.Value

        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "MONTHLY SUMMARY OF DRUGS AND MEDICINE ISSUED") = New rpt_MonthlyMedicineIssuance_ChargingSummary(RPTdateFrom, RPTdateTo, MonthOf)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try


    End Sub

    Private Sub printSummarizedTotalPerChargingFast()
        Dim includeCharging As String = ""

        Dim rowcount As Integer = dgvBeginning.Rows.Count
        Dim hasChecked As Boolean = False


        For jRows As Integer = 0 To (rowcount - 1)
            Dim is_included As Boolean = dgvBeginning.Item(0, jRows).Value.ToString()
            Dim chargeId As String = dgvBeginning.Item(3, jRows).Value.ToString()

            If is_included = True Then

                If hasChecked = False Then
                    includeCharging += " AND (chargingid='" & chargeId & "'"
                    hasChecked = True
                Else
                    includeCharging += " OR chargingid='" & chargeId & "'"
                    hasChecked = True
                End If

            End If


        Next

        If hasChecked Then
            includeCharging += ")"
        Else
            MsgBox("Please check atleast one Charging Type.", MsgBoxStyle.Information)
            Exit Sub
        End If



        Dim SQLEX As String = "SELECT patient_type.payment_type, charging, chargingid"
        SQLEX += " FROM daily_sales_master"
        SQLEX += " INNER JOIN patient_type "
        SQLEX += " ON (daily_sales_master.chargingid = patient_type.a_code)"
        SQLEX += " WHERE DATE(tr_date) BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += includeCharging
        SQLEX += " AND daily_sales_master.status <> 'VOID'"
        SQLEX += " GROUP BY chargingid"
        SQLEX += " ORDER BY chargingid"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count = 0 Then
            MsgBox("No Transactions Created.")
            Exit Sub
        End If


        Dim RPTdateFrom As String = Format(Me.dateFrom.Value, "yyyy-MM-dd")
        Dim RPTdateTo As String = Format(Me.dateTo.Value, "yyyy-MM-dd")
        Dim MonthOf As String = dtpDateMonthof.Text & " " & txtYear.Value



        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "SUMMARIZED TOTAL PER CHARGING FOR THE MONTH OF " & MonthOf) = New rpt_MonthlySummarizedTotal(RPTdateFrom, RPTdateTo, MonthOf)
            new_report.Show()
        Catch ex As Exception
            'MsgBox("Exception Occured :", ex.Message)
        End Try
    End Sub

    Private Sub printSummarizedTotalPerCharging()
        Dim includeCharging As String = ""

        Dim rowcount As Integer = dgvBeginning.Rows.Count
        Dim hasChecked As Boolean = False


        For jRows As Integer = 0 To (rowcount - 1)
            Dim is_included As Boolean = dgvBeginning.Item(0, jRows).Value.ToString()
            Dim chargeId As String = dgvBeginning.Item(3, jRows).Value.ToString()

            If is_included = True Then

                If hasChecked = False Then
                    includeCharging += " AND (chargingid='" & chargeId & "'"
                    hasChecked = True
                Else
                    includeCharging += " OR chargingid='" & chargeId & "'"
                    hasChecked = True
                End If

            End If


        Next

        If hasChecked Then
            includeCharging += ")"
        Else
            MsgBox("Please check atleast one Charging Type.", MsgBoxStyle.Information)
            Exit Sub
        End If



        Dim SQLEX As String = "SELECT patient_type.payment_type, charging, chargingid"
        SQLEX += " FROM daily_sales_master"
        SQLEX += " INNER JOIN patient_type "
        SQLEX += " ON (daily_sales_master.chargingid = patient_type.a_code)"
        SQLEX += " WHERE DATE(tr_date) BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += includeCharging
        SQLEX += " AND daily_sales_master.status <> 'VOID'"
        SQLEX += " GROUP BY chargingid"
        SQLEX += " ORDER BY chargingid"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count = 0 Then
            MsgBox("No Transactions Created.")
            Exit Sub
        End If


        Dim RPTdateFrom As String = Format(Me.dateFrom.Value, "yyyy-MM-dd")
        Dim RPTdateTo As String = Format(Me.dateTo.Value, "yyyy-MM-dd")
        Dim MonthOf As String = dtpDateMonthof.Text & " " & txtYear.Value



        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "SUMMARIZED TOTAL PER CHARGING FOR THE MONTH OF " & MonthOf) = New rpt_MonthlySummarizedTotal(RPTdateFrom, RPTdateTo, MonthOf)
            new_report.Show()
        Catch ex As Exception
            'MsgBox("Exception Occured :", ex.Message)
        End Try

    End Sub

    Private Sub printSummaryPerPatient_MAPFormat()
        Dim includeCharging As String = ""

        Dim rowcount As Integer = dgvBeginning.Rows.Count
        Dim hasChecked As Boolean = False


        For jRows As Integer = 0 To (rowcount - 1)
            Dim is_included As Boolean = dgvBeginning.Item(0, jRows).Value.ToString()
            Dim chargeId As String = dgvBeginning.Item(3, jRows).Value.ToString()

            If is_included = True Then

                If hasChecked = False Then
                    includeCharging += " AND (chargingid='" & chargeId & "'"
                    hasChecked = True
                Else
                    includeCharging += " OR chargingid='" & chargeId & "'"
                    hasChecked = True
                End If

            End If


        Next

        If hasChecked Then
            includeCharging += ")"
        Else
            MsgBox("Please check atleast one Charging Type.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim SQLEX As String = "SELECT ref_no,patient_name, tr_amount,tr_date,"
        SQLEX += " patient_id, charging, chargingid, transactionno"
        SQLEX += " , person_profile.age"
        SQLEX += " , person_profile.address"
        SQLEX += " FROM daily_sales_master"
        SQLEX += " INNER JOIN person_profile"
        SQLEX += " ON (daily_sales_master.patient_id = person_profile.a_code)"
        SQLEX += " WHERE DATE(tr_date) BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += includeCharging
        SQLEX += " AND daily_sales_master.status <> 'VOID'"
        SQLEX += " GROUP BY chargingid, patient_id"
        SQLEX += " ORDER BY chargingid,patient_name"

        Dim RPTdateFrom As String = Format(Me.dateFrom.Value, "yyyy-MM-dd")
        Dim RPTdateTo As String = Format(Me.dateTo.Value, "yyyy-MM-dd")
        Dim MonthOf As String = dtpDateMonthof.Text & " " & txtYear.Value

        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "MONTHLY SUMMARY OF DRUGS AND MEDICINE ISSUED") = New rpt_MonthlyMedicineIssuance_MAPFormat(RPTdateFrom, RPTdateTo, MonthOf)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try
    End Sub

    Private Sub cmbClassification_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClassification.SelectedIndexChanged
        If cmbClassification.SelectedIndex = 3 Or cmbClassification.SelectedIndex = 4 Then
            dgvBeginning.Enabled = False
        Else
            dgvBeginning.Enabled = True
        End If
    End Sub

    Private Sub printPatientCountPerCharging()
        Dim SQLEX As String = "SELECT TransactionDay FROM transaction_day"
        SQLEX += " WHERE TransactionDay BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += " ORDER BY TransactionDay"

        Dim RPTdateFrom As String = Format(Me.dateFrom.Value, "yyyy-MM-dd")
        Dim RPTdateTo As String = Format(Me.dateTo.Value, "yyyy-MM-dd")
        Dim MonthOf As String = dtpDateMonthof.Text & " " & txtYear.Value


        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "PATIENT COUNT PER CHARGING FOR THE MONTH OF " & MonthOf) = New rpt_MonthlyPatientCountPerCharging(RPTdateFrom, RPTdateTo, MonthOf)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try
    End Sub

    Private Sub printIssuanceCountPerCharging()
        Dim SQLEX As String = "SELECT TransactionDay FROM transaction_day"
        SQLEX += " WHERE TransactionDay BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += " ORDER BY TransactionDay"

        Dim RPTdateFrom As String = Format(Me.dateFrom.Value, "yyyy-MM-dd")
        Dim RPTdateTo As String = Format(Me.dateTo.Value, "yyyy-MM-dd")
        Dim MonthOf As String = dtpDateMonthof.Text & " " & txtYear.Value


        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "ISSUANCE COUNT PER CHARGING FOR THE MONTH OF " & MonthOf) = New rpt_MonthlyIssuanceCountPerCharging(RPTdateFrom, RPTdateTo, MonthOf)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try
    End Sub

    Private Sub printDeliveryPulloutItems()
        'Dim SQLEX As String = "SELECT DATE(date_added) 'date_added',item_name, consignee, added_qty,pullout_qty "
        'SQLEX += " from inventory_replenishment"
        'SQLEX += " INNER JOIN inventory_master"
        'SQLEX += " ON (`inventory_replenishment`.`SysPK_INVMaster` = `inventory_master`.`SysPK`)"
        'SQLEX += " WHERE date(date_added) BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        'SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        'SQLEX += " ORDER BY date_added,consignee,item_name"

        Dim SQLEX As String = "SELECT
  ris_details.RIS_Det_No,
	ris_details.inv_master_SysPK 'a_code', 
	ris_master.date_received 'date_added', 
	CONCAT('          ',ris_details.inv_master_Name) 'item_name', 
	ris_master.supplier 'consignee', 
	ris_details.qty_received 'added_qty', 
	SUM(ifnull(inventory_replenishment.pullout_qty,0)) 'pullout_qty'
FROM
	ris_master
	INNER JOIN ris_details ON ris_master.RIS_No = ris_details.RIS_Master_No
	LEFT JOIN inventory_replenishment	ON ris_details.RIS_Det_No = inventory_replenishment.SysPK_INVMaster
WHERE
	ris_master.date_received BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'
	GROUP BY ris_details.RIS_Det_No
	ORDER BY `date_added`,`a_code` "


        Dim RPTdateFrom As String = Format(Me.dateFrom.Value, "yyyy-MM-dd")
        Dim RPTdateTo As String = Format(Me.dateTo.Value, "yyyy-MM-dd")
        Dim MonthOf As String = dtpDateMonthof.Text & " " & txtYear.Value


        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "PULL-OUT AND DELIVERY FOR THE MONTH OF " & MonthOf.ToUpper) = New rptMonthlyDeliveryPullOut(RPTdateFrom, RPTdateTo, MonthOf.ToUpper)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try

    End Sub

End Class