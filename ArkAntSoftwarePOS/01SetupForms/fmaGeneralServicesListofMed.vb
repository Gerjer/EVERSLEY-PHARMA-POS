Public Class fmaGeneralServicesListofMed

    Dim isFirstLoad = True

    Private Sub fmaGeneralServicesListofMed_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpFrom.Value = Date.Now
        dtpTo.Value = Date.Now

        displayPatientList()
        isFirstLoad = False
    End Sub

    Private Sub displayPatientList()
        Dim SQLEX As String = "SELECT patient_name,patient_id, sex,DATE_FORMAT(FROM_DAYS(DATEDIFF(NOW(),dob)), '%Y') + 0 AS age, patienttype"
        SQLEX += " FROM   daily_sales_master "
        SQLEX += " INNER JOIN person_profile ON (daily_sales_master.patient_id = person_profile.a_code)"
        SQLEX += " WHERE chargingid ='3'"
        SQLEX += " AND DATE(tr_date) between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.txtPatient.DataSource = MeData
        Me.txtPatient.DisplayMember = "patient_name"
        Me.txtPatient.ValueMember = "patient_id"
        Me.txtPatient.Text = ""
        Me.txtPatient.SelectedIndex = -1


        txtPatientID.Text = ""
        txtSex.Text = ""
        txtAge.Text = ""
        txtWard.Text = ""


    End Sub

    Private Sub txtPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtPatient.SelectedIndexChanged
        Dim AGE As Integer = 0

        Try
            Dim drv As DataRowView = DirectCast(txtPatient.SelectedItem, DataRowView)
            txtPatientID.Text = drv.Item("patient_id").ToString
            txtSex.Text = drv.Item("sex").ToString
            txtAge.Text = drv.Item("age").ToString
            txtWard.Text = drv.Item("patienttype").ToString

        Catch ex As Exception
            txtPatientID.Text = ""
            txtSex.Text = ""
            txtAge.Text = ""
            txtWard.Text = ""
        End Try
    End Sub


    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        If isFirstLoad Then
            Exit Sub
        End If


        If dtpFrom.Value > dtpTo.Value Then
            dtpTo.Value = dtpFrom.Value
        End If

        displayPatientList()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SQLEX As String = "SELECT DATE(daily_sales_master.tr_date) 'tr_date'"
        SQLEX += " , daily_sales_detail.item_descr"
        SQLEX += " , daily_sales_detail.item_qty"
        SQLEX += " , daily_sales_detail.item_price"
        SQLEX += " , daily_sales_detail.item_total"
        SQLEX += " , inventory_master.method"
        SQLEX += " , daily_sales_detail.returned_qty"
        SQLEX += " , daily_sales_master.cashier"
        SQLEX += " , daily_sales_master.tr_date 'time_encoded'"
        SQLEX += " FROM  daily_sales_detail"
        SQLEX += " INNER JOIN daily_sales_master  ON (daily_sales_detail.sales_sys = daily_sales_master.SysPK)"
        SQLEX += " INNER JOIN inventory_master  ON (daily_sales_detail.item_invcode = inventory_master.a_code)"

        SQLEX += " WHERE chargingid ='3'"
        SQLEX += " AND DATE(tr_date) between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND patient_id='" & txtPatientID.Text & "'"


        tdbViewer.DataSource = Nothing
        Dim MeData As New DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)


                .DisplayColumns("tr_date").DataColumn.Caption = "DATE DISPENSED"
                .DisplayColumns("tr_date").Width = 150
                .DisplayColumns("tr_date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("tr_date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("item_descr").DataColumn.Caption = "MEDICINE"
                .DisplayColumns("item_descr").Width = 250
                .DisplayColumns("item_descr").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_descr").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("method").DataColumn.Caption = "TYPE"
                .DisplayColumns("method").Width = 200
                .DisplayColumns("method").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("method").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("item_qty").DataColumn.Caption = "QUANTITY"
                .DisplayColumns("item_qty").Width = 180
                .DisplayColumns("item_qty").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_qty").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("item_price").DataColumn.Caption = "SELLING PRICE"
                .DisplayColumns("item_price").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("item_price").Width = 190
                .DisplayColumns("item_price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("item_total").DataColumn.Caption = "AMOUNT"
                .DisplayColumns("item_total").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("item_total").Width = 190
                .DisplayColumns("item_total").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_total").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("returned_qty").DataColumn.Caption = "RETURNED"
                .DisplayColumns("returned_qty").Width = 180
                .DisplayColumns("returned_qty").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("returned_qty").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("cashier").DataColumn.Caption = "ENCODED BY"
                .DisplayColumns("cashier").Width = 250
                .DisplayColumns("cashier").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("cashier").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("time_encoded").DataColumn.Caption = "TIME ENCODED"
                .DisplayColumns("time_encoded").DataColumn.NumberFormat = "hh:mm:ss tt"
                .DisplayColumns("time_encoded").Width = 250
                .DisplayColumns("time_encoded").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("time_encoded").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center


            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged
        If txtPatientID.Text.Length > 0 Then
            btnSearch.Enabled = True
            btnPrint.Enabled = True
        Else
            btnSearch.Enabled = False
            btnPrint.Enabled = False
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim SQLEX As String = "SELECT DATE(daily_sales_master.tr_date) 'tr_date'"
        SQLEX += " , daily_sales_detail.item_descr"
        SQLEX += " , daily_sales_detail.item_qty"
        SQLEX += " , daily_sales_detail.item_price"
        SQLEX += " , daily_sales_detail.item_total"
        SQLEX += " , inventory_master.method"
        SQLEX += " , daily_sales_detail.returned_qty"
        SQLEX += " , daily_sales_master.cashier"
        SQLEX += " , daily_sales_master.tr_date 'time_encoded'"
        SQLEX += " FROM  daily_sales_detail"
        SQLEX += " INNER JOIN daily_sales_master  ON (daily_sales_detail.sales_sys = daily_sales_master.SysPK)"
        SQLEX += " INNER JOIN inventory_master  ON (daily_sales_detail.item_invcode = inventory_master.a_code)"

        SQLEX += " WHERE chargingid ='3'"
        SQLEX += " AND DATE(tr_date) between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND patient_id='" & txtPatientID.Text & "'"
        SQLEX += " ORDER BY tr_date"


        Dim new_report As New fzzReportViewerForm
        Try

            new_report.AttachReport(SQLEX, "SUMMARY OF MEDICINE DISPENSED PER PATIEND" & txtPatient.Text) = New rpt_MedDispensedPerPatient(txtPatient.Text, txtAge.Text, txtSex.Text, txtWard.Text, Format(dtpFrom.Value, "MMMM dd, yyyy"), Format(dtpTo.Value, "MMMM dd, yyyy"))
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try
    End Sub
End Class