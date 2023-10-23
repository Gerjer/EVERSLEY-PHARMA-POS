Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_MonthlyMedicineIssuance_ChargingSummary
    Private reportDateFrom As String = "'"
    Private reportDateTo As String = "'"

    Private subTotalInHouse As Double = 0
    Private subTotalConsign As Double = 0


    Private ModeTypeCollection As New List(Of String)

    Private ModeTypeName As String

    Private COUNTER As Integer = 1

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal dateFrom As String, ByVal dateTo As String, ByVal monthOf As String)
        InitializeComponent()
        Me.txtMonthOf.Text = monthOf
        reportDateFrom = dateFrom
        reportDateTo = dateTo
    End Sub

    

    Private Sub rpt_DailyRpt_MedicineIssuance_ChargingSummary_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
        Me.TextBox2.Text = "DRUGS AND MEDICINES ISSUED TO " & TextBox16.Text.ToUpper & " FOR THE MONTH OF " & txtMonthOf.Text.ToUpper
    End Sub

    

   

    Private Sub GroupHeader3_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader3.Format
        'txtCounter.Text = COUNTER
        'COUNTER += 1

        'Dim chargingid As String = txtchargingid.Text
        'Dim patient_id As String = txtpatient_id.Text
        'Dim totalInHouse As Double = 0
        'Dim totalConsign As Double = 0


        'Dim SQLEX As String = "SELECT sales_sys, daily_sales_master.patient_name, item_invcode, item_descr,ris_master.supplier 'consignee',item_qty,inventory_master.selling_price 'item_price',item_disc,SUM(daily_sales_detail.item_qty * inventory_master.selling_price) AS 'Itr_amount'  "
        'SQLEX += " FROM daily_sales_detail"
        'SQLEX += " INNER JOIN inventory_master  ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`) "
        'SQLEX += " INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No "
        'SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No "
        'SQLEX += " INNER JOIN daily_sales_master ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK`)"
        'SQLEX += " WHERE daily_sales_master.patient_id='" & patient_id & "'"
        'SQLEX += " AND item_qty>0"
        'SQLEX += " AND chargingid='" & chargingid & "'"
        ''      SQLEX += " AND `pharmaceuticals`.`type`='1' "
        'SQLEX += " AND DATE(tr_date) BETWEEN'" & reportDateFrom & "'"
        'SQLEX += " AND '" & reportDateTo & "'"
        'SQLEX += " AND daily_sales_master.status <> 'VOID'"



        'Dim MeData As DataTable
        'MeData = clsDBConn.ExecQuery(SQLEX)

        'If MeData.Rows.Count > 0 Then
        '    Try
        '        totalInHouse = CDbl(MeData.Rows(0).Item("Itr_amount").ToString)
        '        txtInhouseAmt.Text = Format(totalInHouse, "#,##.00")
        '        subTotalInHouse += totalInHouse
        '    Catch ex As Exception
        '        txtInhouseAmt.Text = "-"
        '    End Try
        'Else
        '    txtInhouseAmt.Text = "-"
        'End If



        '' CONSIGNMENT VALUES
        'MeData = Nothing

        'SQLEX = "SELECT sales_sys, daily_sales_master.patient_name, item_invcode, item_descr,consignee,item_qty,inventory_master.item_price,item_disc,SUM(daily_sales_detail.item_qty * inventory_master.item_buyprice) AS  'tr_amount' "
        'SQLEX += " FROM daily_sales_detail"
        'SQLEX += " INNER JOIN inventory_master  ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`) "
        'SQLEX += " INNER JOIN pharmaceuticals ON (`inventory_master`.`consignee_id` = `pharmaceuticals`.`SysPK`) "
        'SQLEX += " INNER JOIN daily_sales_master ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK`)"
        'SQLEX += " WHERE daily_sales_master.patient_id='" & patient_id & "'"
        'SQLEX += " AND item_qty>0"
        'SQLEX += " AND chargingid='" & chargingid & "'"
        'SQLEX += " AND `pharmaceuticals`.`type`='0' "
        'SQLEX += " AND DATE(tr_date) BETWEEN'" & reportDateFrom & "'"
        'SQLEX += " AND '" & reportDateTo & "'"
        'SQLEX += " AND daily_sales_master.status <> 'VOID'"



        'MeData = clsDBConn.ExecQuery(SQLEX)

        'If MeData.Rows.Count > 0 Then
        '    Try
        '        totalConsign = CDbl(MeData.Rows(0).Item("tr_amount").ToString)
        '        txtConsignAmt.Text = Format(totalConsign, "#,##.00")
        '        subTotalConsign += totalConsign
        '    Catch ex As Exception
        '        txtConsignAmt.Text = "-"
        '    End Try
        'Else
        '    txtConsignAmt.Text = "-"
        'End If

        'txtTotalAmt.Text = Format(totalConsign + totalInHouse, "#,##0.00")
    End Sub

    Private Sub GroupHeader2_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader2.Format
        '   txtHeaderText.Text = "DRUGS AND MEDICINES ISSUED TO " & TextBox16.Text & " FOR THE MONTH OF " & txtMonthOf.Text
    End Sub

    Private Sub GroupFooter2_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter2.Format
        'COUNTER = 1
        'TextBox5.Text = "TOTAL " & TextBox16.Text
        'Me.txtSubTotalInhouse.Text = Format(subTotalInHouse, "#,##.00")
        'Me.txtSubTotalConsign.Text = Format(subTotalConsign, "#,##.00")
        'Me.txtSubTotalTOTAL.Text = Format(subTotalConsign + subTotalInHouse, "#,##.00")

        'subTotalInHouse = 0
        'subTotalConsign = 0

    End Sub

    
End Class
