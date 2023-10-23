Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_MonthlySummarizedTotal

    Private subTotalInHouse As Double = 0
    Private subTotalConsign As Double = 0

    Private reportDateFrom As String = ""
    Private reportDateTo As String = ""


    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal dateFrom As String, ByVal dateTo As String, ByVal monthOf As String)
        InitializeComponent()
        Me.txtMonthOf.Text = monthOf
        reportDateFrom = dateFrom
        reportDateTo = dateTo
    End Sub



    Private Sub rpt_MonthlySummaryIssuedToPatients_A_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub


    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim totalInHouse As Double = 0
        Dim totalConsign As Double = 0



        'Dim SQLEX As String = "SELECT consignee, SUM(daily_sales_detail.item_qty * inventory_master.item_buyprice) AS 'Itr_amount'  "
        'SQLEX += " FROM daily_sales_detail"
        'SQLEX += " INNER JOIN inventory_master  "
        'SQLEX += " ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`)  "
        'SQLEX += " INNER JOIN pharmaceuticals ON (`inventory_master`.`consignee_id` = `pharmaceuticals`.`SysPK`)  "
        'SQLEX += " INNER JOIN daily_sales_master ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK`) "
        'SQLEX += " WHERE chargingid='" & txtChargingID.Text & "'"
        'SQLEX += " AND `pharmaceuticals`.`type`='1'  "
        'SQLEX += " AND DATE(tr_date) BETWEEN'" & reportDateFrom & "'"
        'SQLEX += " AND '" & reportDateTo & "'"
        'SQLEX += " AND daily_sales_master.status <> 'VOID'"

        Dim SQLEX As String = "SELECT  issuance_summary_master.month"
        SQLEX += " , patient_type.a_name"
        SQLEX += " , issuance_summary_detail.paymentType"
        SQLEX += " , SUM(issuance_summary_detail.amount) 'amount'"
        SQLEX += " FROM  issuance_summary_detail"
        SQLEX += " INNER JOIN issuance_summary_master"
        SQLEX += " ON (issuance_summary_detail.masterSysPK = issuance_summary_master.sysPk)"
        SQLEX += " INNER JOIN patient_type "
        SQLEX += " ON (issuance_summary_detail.paymentType = patient_type.a_code)"
        SQLEX += " WHERE dateFrom ='" & reportDateFrom & "'"
        SQLEX += " AND dateTo ='" & reportDateTo & "'"
        SQLEX += " AND issuance_summary_detail.paymentType='" & txtChargingID.Text & "'"
        SQLEX += " AND type='1'"


        Dim MeData As DataTable

        MeData = clsDBConn.ExecLongQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            If Not IsDBNull(MeData.Rows(0).Item("amount")) Then
                totalInHouse = CDbl(MeData.Rows(0).Item("amount").ToString)
            Else
                totalInHouse = 0
            End If

            TextBox9.Text = Format(totalInHouse, "#,##.00")
            subTotalInHouse += totalInHouse
        Else
            TextBox9.Text = "-"

        End If


        'SQLEX = "SELECT consignee, SUM(daily_sales_detail.item_qty * inventory_master.item_buyprice) AS 'Itr_amount'  "
        'SQLEX += " FROM daily_sales_detail"
        'SQLEX += " INNER JOIN inventory_master  "
        'SQLEX += " ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`)  "
        'SQLEX += " INNER JOIN pharmaceuticals ON (`inventory_master`.`consignee_id` = `pharmaceuticals`.`SysPK`)  "
        'SQLEX += " INNER JOIN daily_sales_master ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK`) "
        'SQLEX += " WHERE chargingid='" & txtChargingID.Text & "'"
        'SQLEX += " AND `pharmaceuticals`.`type`='0'  "
        'SQLEX += " AND DATE(tr_date) BETWEEN'" & reportDateFrom & "'"
        'SQLEX += " AND '" & reportDateTo & "'"
        'SQLEX += " AND daily_sales_master.status <> 'VOID'"
        SQLEX = "SELECT  issuance_summary_master.month"
        SQLEX += " , patient_type.a_name"
        SQLEX += " , issuance_summary_detail.paymentType"
        SQLEX += " ,  SUM(issuance_summary_detail.amount) 'amount'"
        SQLEX += " FROM  issuance_summary_detail"
        SQLEX += " INNER JOIN issuance_summary_master"
        SQLEX += " ON (issuance_summary_detail.masterSysPK = issuance_summary_master.sysPk)"
        SQLEX += " INNER JOIN patient_type "
        SQLEX += " ON (issuance_summary_detail.paymentType = patient_type.a_code)"
        SQLEX += " WHERE dateFrom ='" & reportDateFrom & "'"
        SQLEX += " AND dateTo ='" & reportDateTo & "'"
        SQLEX += " AND issuance_summary_detail.paymentType='" & txtChargingID.Text & "'"
        SQLEX += " AND type='0'"

        MeData = Nothing

        MeData = clsDBConn.ExecLongQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            If Not IsDBNull(MeData.Rows(0).Item("amount")) Then
                totalConsign = CDbl(MeData.Rows(0).Item("amount").ToString)
            Else
                totalConsign = 0
            End If


            TextBox10.Text = Format(totalConsign, "#,##.00")
            subTotalConsign += totalConsign
        Else
            TextBox10.Text = "-"
        End If

        TextBox11.Text = Format(totalInHouse + totalConsign, "#,##.00")

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        Me.txtSubTotalInhouse.Text = Format(subTotalInHouse, "#,##0.00")
        Me.txtSubTotalConsign.Text = Format(subTotalConsign, "#,##0.00")
        Me.txtSubTotalTotal.Text = Format(subTotalConsign + subTotalInHouse, "#,##0.00")
    End Sub
End Class

