Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_DailyRpt_MedicineIssuance_ChargingSummary
    Private reportDate As String = "'"

    Private subTotalInHouse As Double = 0
    Private subTotalConsign As Double = 0

    Private ModeTypeCollection As New List(Of String)

    Private ModeTypeName As String

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal dateFrom As String)
        InitializeComponent()
        Me.txtFrom.Text = dateFrom
        reportDate = dateFrom


        Dim SQLEX As String = "SELECT `daily_sales_master`.`charging` , "
        SQLEX += " `daily_sales_master`.`chargingid` "
        SQLEX += " FROM daily_sales_master"
        SQLEX += " INNER JOIN daily_sales_detail ON (`daily_sales_master`.`SysPK` = `daily_sales_detail`.`sales_sys`)"
        SQLEX += " INNER JOIN inventory_master ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`) "
  '      SQLEX += " INNER JOIN pharmaceuticals ON (`inventory_master`.`consignee_id` = `pharmaceuticals`.`SysPK`) "
        SQLEX += " WHERE DATE(tr_date)='" & reportDate & "'"

        SQLEX += " GROUP BY chargingid"


        Dim Medata As DataTable
        Medata = clsDBConn.ExecQuery(SQLEX)

        Dim xLoc1 As Single = 0
        Dim spacing As Single = TextBox9.Bounds.Bottom


        Dim footerHeaderTitle As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox9.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox9.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox9.Location.X, 0 + xLoc1)}

        TextBox9.Border.CopyTo(footerHeaderTitle.Border)
        footerHeaderTitle.Text = TextBox9.Text
        GroupFooter1.Controls.Add(footerHeaderTitle)

        xLoc1 += spacing

        Dim footerHeaderDescription As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox10.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox10.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox10.Location.X, 0 + xLoc1)}

        TextBox10.Border.CopyTo(footerHeaderDescription.Border)
        footerHeaderDescription.Text = "CHARGING"
        GroupFooter1.Controls.Add(footerHeaderDescription)

        Dim footerHeaderInhouse As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox11.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox11.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox11.Location.X, 0 + xLoc1)}

        TextBox11.Border.CopyTo(footerHeaderInhouse.Border)
        footerHeaderInhouse.Text = "IN-HOUSE"
        GroupFooter1.Controls.Add(footerHeaderInhouse)

        Dim footerHeaderConsign As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox13.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox13.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox13.Location.X, 0 + xLoc1)}

        TextBox13.Border.CopyTo(footerHeaderConsign.Border)
        footerHeaderConsign.Text = "CONSIGNMENT"
        GroupFooter1.Controls.Add(footerHeaderConsign)

        Dim footerHeaderTotal As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox15.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox13.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox15.Location.X, 0 + xLoc1)}

        TextBox15.Border.CopyTo(footerHeaderTotal.Border)
        footerHeaderTotal.Text = "TOTAL"
        GroupFooter1.Controls.Add(footerHeaderTotal)

        xLoc1 += spacing

        Dim totalInhouse As Double = 0
        Dim totalConsign As Double = 0
        Dim totalBoth As Double = 0


        'details
        For nCtr As Integer = 0 To Medata.Rows.Count - 1

            Dim ItemDescr As String = Medata.Rows(nCtr).Item("charging").ToString
            Dim chargingid As String = Medata.Rows(nCtr).Item("chargingid").ToString

            Dim detailDescription As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = txtgrpCharging.Size, .Text = "", .Style = FontStyle.Regular, .Font = txtgrpCharging.Font, .Alignment = TextAlignment.Left, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(txtgrpCharging.Location.X, 0 + xLoc1)}

            txtgrpCharging.Border.CopyTo(detailDescription.Border)

            detailDescription.Text = ItemDescr

            GroupFooter1.Controls.Add(detailDescription)

            'IN HOUSE DETAILS
            Dim detailInhouse As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = txtgrpInhouse.Size, .Text = "", .Style = FontStyle.Regular, .Font = txtgrpInhouse.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(txtgrpInhouse.Location.X, 0 + xLoc1)}

            txtgrpInhouse.Border.CopyTo(detailInhouse.Border)

            detailInhouse.Tag = chargingid

            detailInhouse.Text = Format(getTotalAmount(chargingid, "1"), "#,##0.00")
            totalInhouse += getTotalAmount(chargingid, "1")

            GroupFooter1.Controls.Add(detailInhouse)


            Dim detailConsign As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = txtgrpconsign.Size, .Text = "", .Style = FontStyle.Regular, .Font = txtgrpconsign.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(txtgrpconsign.Location.X, 0 + xLoc1)}

            txtgrpInhouse.Border.CopyTo(detailConsign.Border)
            detailConsign.Text = Format(getTotalAmount(chargingid, "0"), "#,##0.00")
            totalConsign += getTotalAmount(chargingid, "0")

            GroupFooter1.Controls.Add(detailConsign)

            Dim detailTotal As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = txtgrpTotal.Size, .Text = "", .Style = FontStyle.Regular, .Font = txtgrpTotal.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(txtgrpTotal.Location.X, 0 + xLoc1)}

            txtgrpInhouse.Border.CopyTo(detailTotal.Border)
            detailTotal.Text = Format(getTotalAmount(chargingid, "0") + getTotalAmount(chargingid, "1"), "#,##0.00")
            totalBoth += getTotalAmount(chargingid, "0") + getTotalAmount(chargingid, "1")

            GroupFooter1.Controls.Add(detailTotal)


            xLoc1 += spacing
        Next

        ' grand total
        Dim grandHeaderDescription As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox10.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox10.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox10.Location.X, 0 + xLoc1)}

        TextBox10.Border.CopyTo(grandHeaderDescription.Border)
        grandHeaderDescription.Text = "TOTAL"
        GroupFooter1.Controls.Add(grandHeaderDescription)


        Dim grandHeaderInhouse As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox11.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox11.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox11.Location.X, 0 + xLoc1)}

        TextBox11.Border.CopyTo(grandHeaderInhouse.Border)
        'grandHeaderInhouse.Text = "IN-HOUSE"
        grandHeaderInhouse.Text = Format(totalInhouse, "#,##0.00")

        GroupFooter1.Controls.Add(grandHeaderInhouse)

        Dim grandHeaderConsign As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox13.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox13.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox13.Location.X, 0 + xLoc1)}

        TextBox13.Border.CopyTo(grandHeaderConsign.Border)
        'grandHeaderConsign.Text = "CONSIGNMENT"
        grandHeaderConsign.Text = Format(totalConsign, "#,##0.00")
        GroupFooter1.Controls.Add(grandHeaderConsign)

        Dim grandHeaderTotal As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox15.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox13.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(TextBox15.Location.X, 0 + xLoc1)}

        TextBox15.Border.CopyTo(grandHeaderTotal.Border)
        'grandHeaderTotal.Text = "TOTAL"
        grandHeaderTotal.Text = Format(totalBoth, "#,##0.00")
        GroupFooter1.Controls.Add(grandHeaderTotal)


    End Sub

    Private Function getTotalAmount(ByVal chargingid As String, ByVal type As Integer) As Double
        Dim TOTALAMOUNT As Double = 0

        'Dim SQLEX As String = "SELECT sales_sys, daily_sales_master.patient_name, item_invcode, item_descr,consignee,item_qty,inventory_master.item_price,item_disc,SUM(item_total) AS 'tr_amount' "
        'SQLEX += " FROM daily_sales_detail"
        'SQLEX += " INNER JOIN inventory_master  ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`) "
        'SQLEX += " INNER JOIN pharmaceuticals ON (`inventory_master`.`consignee_id` = `pharmaceuticals`.`SysPK`) "
        'SQLEX += " INNER JOIN daily_sales_master ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK`)"
        'SQLEX += " WHERE item_qty>0"
        'SQLEX += " AND chargingid='" & chargingid & "'"
        'SQLEX += " AND `pharmaceuticals`.`type`='" & type & "'"
        'SQLEX += " AND DATE(tr_date)='" & reportDate & "'"

        Dim SQLEX As String = "SELECT
	                            sales_sys,
	                            daily_sales_master.patient_name,
	                            item_invcode,
	                            item_descr,
	                            supplier.a_name 'consignee',
	                            item_qty,
	                            inventory_master.selling_price 'item_price',
	                            item_disc,
	                            SUM( item_total ) AS 'tr_amount' 
                            FROM
	                            daily_sales_detail
	                            INNER JOIN inventory_master ON ( `daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code` )
	                            INNER JOIN daily_sales_master ON ( `daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK` )
	                            INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
	                            INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No
	                            INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code
	                            INNER JOIN pharmaceuticals ON ris_master.fund_class_id = pharmaceuticals.SysPK

                            WHERE
	                            item_qty > 0 
	                            AND chargingid = '" & chargingid & "'
	                            AND `pharmaceuticals`.`type` = '1' 
	                            AND DATE( tr_date )= '" & reportDate & "'"



        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                TOTALAMOUNT = CDbl(MeData.Rows(0).Item("tr_amount").ToString)
                
            Catch ex As Exception

            End Try
        Else

        End If

        Return TOTALAMOUNT

    End Function





    Private Sub rpt_DailyRpt_MedicineIssuance_ChargingSummary_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub

    Private Sub GroupHeader3_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader3.Format
        ' get In-house items first
        Dim chargingid As String = txtChargingID.Text
        Dim patient_id As String = txtPatient_id.Text
        Dim totalInHouse As Double = 0
        Dim totalConsign As Double = 0


        'Dim SQLEX As String = "SELECT sales_sys, daily_sales_master.patient_name, item_invcode, item_descr,consignee,item_qty,inventory_master.item_price,item_disc,SUM(item_total) AS 'tr_amount' "
        'SQLEX += " FROM daily_sales_detail"
        'SQLEX += " INNER JOIN inventory_master  ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`) "
        'SQLEX += " INNER JOIN pharmaceuticals ON (`inventory_master`.`consignee_id` = `pharmaceuticals`.`SysPK`) "
        'SQLEX += " INNER JOIN daily_sales_master ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK`)"
        'SQLEX += " WHERE daily_sales_master.patient_id='" & patient_id & "'"
        'SQLEX += " AND item_qty>0"
        'SQLEX += " AND chargingid='" & chargingid & "'"
        'SQLEX += " AND `pharmaceuticals`.`type`='1' "
        'SQLEX += " AND DATE(tr_date)='" & reportDate & "'"

        Dim SQLEX As String = "SELECT
	                            sales_sys,
	                            daily_sales_master.patient_name,
	                            item_invcode,
	                            item_descr,
	                            supplier.a_name 'consignee',
	                            item_qty,
	                            inventory_master.selling_price 'item_price',
	                            item_disc,
	                            SUM( item_total ) AS 'tr_amount' 
                            FROM
	                            daily_sales_detail
	                            INNER JOIN inventory_master ON ( `daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code` )
	                            INNER JOIN daily_sales_master ON ( `daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK` )
                              INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
                              INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No
                              INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code
                              INNER JOIN pharmaceuticals ON ris_master.fund_class_id = pharmaceuticals.SysPK

                            WHERE
	                            daily_sales_master.patient_id = '" & patient_id & "'
	                            AND item_qty > 0 
	                            AND chargingid = '" & chargingid & "'
	                            AND `pharmaceuticals`.`type` = '1' 
	                            AND DATE( tr_date )= '" & reportDate & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                totalInHouse = CDbl(MeData.Rows(0).Item("tr_amount").ToString)
                '         txtInhouseAmt.Text = Format(totalInHouse, "#,##.00")
                subTotalInHouse += totalInHouse
            Catch ex As Exception
                txtInhouseAmt.Text = "-"
            End Try
        Else
            txtInhouseAmt.Text = "-"
        End If



        ' CONSIGNMENT VALUES
        MeData = Nothing

        'SQLEX = "SELECT sales_sys, daily_sales_master.patient_name, item_invcode, item_descr,consignee,item_qty,inventory_master.item_price,item_disc,SUM(item_total) AS 'tr_amount' "
        'SQLEX += " FROM daily_sales_detail"
        'SQLEX += " INNER JOIN inventory_master  ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`) "
        'SQLEX += " INNER JOIN pharmaceuticals ON (`inventory_master`.`consignee_id` = `pharmaceuticals`.`SysPK`) "
        'SQLEX += " INNER JOIN daily_sales_master ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK`)"
        'SQLEX += " WHERE daily_sales_master.patient_id='" & patient_id & "'"
        'SQLEX += " AND item_qty>0"
        'SQLEX += " AND chargingid='" & chargingid & "'"
        'SQLEX += " AND `pharmaceuticals`.`type`='0' "
        'SQLEX += " AND DATE(tr_date)='" & reportDate & "'"

        SQLEX = "SELECT
	                            sales_sys,
	                            daily_sales_master.patient_name,
	                            item_invcode,
	                            item_descr,
	                            supplier.a_name 'consignee',
	                            item_qty,
	                            inventory_master.selling_price 'item_price',
	                            item_disc,
	                            SUM( item_total ) AS 'tr_amount' 
                            FROM
	                            daily_sales_detail
	                            INNER JOIN inventory_master ON ( `daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code` )
	                            INNER JOIN daily_sales_master ON ( `daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK` )
                              INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
                              INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No
                              INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code
                              INNER JOIN pharmaceuticals ON ris_master.fund_class_id = pharmaceuticals.SysPK

                            WHERE
	                            daily_sales_master.patient_id = '" & patient_id & "'
	                            AND item_qty > 0 
	                            AND chargingid = '" & chargingid & "'
	                            AND `pharmaceuticals`.`type` = '0' 
	                            AND DATE( tr_date )= '" & reportDate & "'"


        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                totalConsign = CDbl(MeData.Rows(0).Item("tr_amount").ToString)
                txtConsignAmt.Text = Format(totalConsign, "#,##.00")
                subTotalConsign += totalConsign
            Catch ex As Exception
                txtConsignAmt.Text = "-"
            End Try
        Else
            txtConsignAmt.Text = "-"
        End If

        txtTotalAmt.Text = Format(totalConsign + totalInHouse, "#,##0.00")

    End Sub

    Private Sub GroupFooter2_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter2.BeforePrint

        txtSubTotalAmt.Text = Format(subTotalConsign + subTotalInHouse, "#,##0.00")

        txtSubInhouse.Text = Format(subTotalInHouse, "#,##0.00")
        subTotalInHouse = 0

        txtSubConsig.Text = Format(subTotalConsign, "#,##0.00")
        subTotalConsign = 0

        TextBox14.Text = "GRAND TOTAL : " & ModeTypeName

    End Sub


    Private Sub GroupHeader2_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader2.Format
        ModeTypeName = TextBox12.Text
        ModeTypeCollection.Add(TextBox12.Text)
        TextBox12.Text = "DRUGS AND MEDICINES ISSUED TO : " & TextBox12.Text
    End Sub

End Class
