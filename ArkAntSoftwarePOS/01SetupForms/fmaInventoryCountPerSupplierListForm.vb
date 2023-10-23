Public Class fmaInventoryCountPerSupplierListForm


    Private Sub fmaMonthlyInventoryPerSupplierListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames

        'dateFrom.Value = New DateTime(Date.Now.Year, Date.Now.Month - 1, 1)

        '      Dim SQLEX As String = "SELECT IF(paymentgroup='0','Private','Government') 'type',paymentgroup FROM pharmaceuticals"

        'Dim SQLEX As String = "SELECT  supplier_type 'id',	case when supplier_type = 0 then 'Private' else 'Government' end as 'name'	FROM	supplier "
        'SQLEX += " GROUP BY supplier_type"
        'SQLEX += " ORDER BY name"

        If RadioButton1.Checked = True Then
            displayFundsClass()
        Else
            displaySuppliers()
        End If

        tdbViewer.DataSource = Nothing
    End Sub

    Private Sub displayFundsClass()

        Dim SQLEX As String = "SELECT SysPK 'id',a_name'name'  FROM pharmaceuticals"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.cmbClassification.DataSource = MeData
        Me.cmbClassification.DisplayMember = "name"
        Me.cmbClassification.ValueMember = "id"
        Me.cmbClassification.SelectedIndex = -1
    End Sub

    Private Sub displaySuppliers()


        Dim SQLEX As String = "SELECT DISTINCT supplier_SysPK 'id',supplier 'name'"
        SQLEX += " FROM ris_master ORDER BY supplier"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try

                'Me.txtSupplierList.DataSource = MeData
                'Me.txtSupplierList.DisplayMember = "name"
                'Me.txtSupplierList.ValueMember = "id"
                'Me.txtSupplierList.SelectedIndex = -1
                'Me.txtSupplierList.Text = ""
                Me.cmbClassification.DataSource = MeData
                Me.cmbClassification.DisplayMember = "name"
                Me.cmbClassification.ValueMember = "id"
                Me.cmbClassification.SelectedIndex = -1

            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbClassification_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClassification.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbClassification.SelectedItem, DataRowView)
            Me.txtClassificationCode.Text = drv.Item("id").ToString
            Me.txtSupplierList.Text = drv.Item("name").ToString
        Catch ex As Exception
            Me.txtClassificationCode.Text = ""
        End Try

        tdbViewer.DataSource = Nothing
        loadListView
    End Sub

    Private Sub loadListView()

        Dim str As String = ""
        If RadioButton1.Checked = True Then
            str = " WHERE ris_master.fund_class_id = '" & cmbClassification.SelectedValue & "'"
        Else
            str = " WHERE ris_master.supplier_SysPK = '" & Me.txtClassificationCode.Text & "'"
        End If

        Dim SQLEX As String = ""
        SQLEX = "SELECT
	                inventory_master.a_code, 
	                inventory_master.a_name, 
	                inventory_master.method,
	                inventory_master.uom,
	                ris_details.price,
	                inventory_master.selling_price,
	                ris_details.qty_received,
 	                round(inventory_master.item_reordercount,0)'item_reordercount',
	                ris_master.supplier_SysPK,
                    ris_details.qty_remaining,
                    ris_master.supplier,
                    ris_master.fund_class
                FROM
	                inventory_master
	                INNER JOIN
	                ris_details
	                ON 
		                inventory_master.a_code = ris_details.inv_master_SysPK
	                INNER JOIN
	                ris_master
	                ON 
		                ris_details.RIS_Master_No = ris_master.RIS_No
		                
                        " & str & "		                

		                ORDER BY a_name"

        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)

                '.DisplayColumns("a_code").Visible = False

                .DisplayColumns("a_code").DataColumn.Caption = "ITEM CODE"
                .DisplayColumns("a_code").Width = 100
                .DisplayColumns("a_code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("a_name").DataColumn.Caption = "ITEM NAME"
                .DisplayColumns("a_name").Width = 400
                .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("method").DataColumn.Caption = "MED TYPE"
                .DisplayColumns("method").Width = 150
                .DisplayColumns("method").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("method").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("uom").DataColumn.Caption = "UNIT"
                .DisplayColumns("uom").Width = 150
                .DisplayColumns("uom").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("uom").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("price").DataColumn.Caption = "BUYING PRICE PRICE"
                .DisplayColumns("price").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("price").Width = 170
                .DisplayColumns("price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("selling_price").DataColumn.Caption = "SELLING PRICE PRICE"
                .DisplayColumns("selling_price").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("selling_price").Width = 170
                .DisplayColumns("selling_price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("selling_price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("qty_received").DataColumn.Caption = "ACTUAL COUNT"
                .DisplayColumns("qty_received").DataColumn.NumberFormat = "00"
                .DisplayColumns("qty_received").Width = 150
                .DisplayColumns("qty_received").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("qty_received").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("item_reordercount").DataColumn.Caption = "RE-ORDER LEVEL"
                ''     .DisplayColumns("item_reordercount").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("item_reordercount").Width = 120
                .DisplayColumns("item_reordercount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_reordercount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("supplier_SysPK").Visible = False

                .DisplayColumns("qty_remaining").DataColumn.Caption = "REMAINING QTY"
                .DisplayColumns("qty_remaining").Width = 100
                .DisplayColumns("qty_remaining").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("qty_remaining").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If RadioButton1.Checked = True Then
                    .DisplayColumns("supplier").DataColumn.Caption = "SUPPLIER"
                    .DisplayColumns("supplier").Width = 150
                    .DisplayColumns("supplier").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("supplier").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("fund_class").Visible = False

                Else
                    .DisplayColumns("supplier").Visible = False
                    .DisplayColumns("fund_class").Visible = False
                End If


            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim SQLEX As String = "SELECT a_code, a_name,medtype,item_unit,item_buyprice,item_price,inv_qty,item_reordercount"
        'SQLEX += " FROM  inventory_master "
        'SQLEX += " WHERE consignee_id ='" & txtSupplierCode.Text & "'"
        'SQLEX += " order by a_name"

        Dim str As String = ""
        If RadioButton1.Checked = True Then
            str = " WHERE ris_master.fund_class_id = '" & cmbClassification.SelectedValue & "'"
        Else
            str = " WHERE ris_master.supplier_SysPK = '" & Me.txtClassificationCode.Text & "'"
        End If

        Dim SQLEX As String = ""
        SQLEX = "SELECT
	                inventory_master.a_code, 
	                inventory_master.a_name, 
	                inventory_master.method,
	                inventory_master.uom,
	                ris_details.price,
	                inventory_master.selling_price,
	                ris_details.qty_received,
 	                round(inventory_master.item_reordercount,0)'item_reordercount',
	                ris_master.supplier_SysPK,
                    ris_details.qty_remaining,
                    ris_master.supplier,
                    ris_master.fund_class,ris_details.batch_number, ris_details.expiry_date
                FROM
	                inventory_master
	                INNER JOIN
	                ris_details
	                ON 
		                inventory_master.a_code = ris_details.inv_master_SysPK
	                INNER JOIN
	                ris_master
	                ON 
		                ris_details.RIS_Master_No = ris_master.RIS_No
		                
                        " & str & "		                

		                ORDER BY  a_name"

        Dim new_report As New fzzReportViewerForm
        Dim AsOF As String = Format(Date.Now, "yyyy, MMMM-dd")


        Me.Cursor = Cursors.WaitCursor
        Try
            new_report.AttachReport(SQLEX, "Actual Inventory Count For  " & txtSupplierList.Text) = New rpt_InventoryCountPerSupplierFundsClass(txtSupplierList.Text, AsOF)
            new_report.Show()

        Catch ex As Exception

        End Try

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub txtSupplierList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierList.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtSupplierList.SelectedItem, DataRowView)
            Me.txtSupplierCode.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtSupplierCode.Text = ""
        End Try
    End Sub


    Private Sub txtSupplierCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierCode.TextChanged

        'Dim SQLEX As String = "SELECT a_code, a_name,medtype,item_unit,item_buyprice,item_price,inv_qty,item_reordercount"
        'SQLEX += " FROM  inventory_master "
        'SQLEX += " WHERE consignee_id ='" & txtSupplierCode.Text & "'"
        'SQLEX += " order by a_name"

        Dim SQLEX As String = ""
        SQLEX = "SELECT
	                inventory_master.a_code, 
	                inventory_master.a_name, 
	                inventory_master.method,
	                inventory_master.uom,
	                ris_details.price,
	                inventory_master.selling_price,
	                ris_details.qty_received,
 	                inventory_master.item_reordercount,
	                ris_master.supplier_SysPK
                FROM
	                inventory_master
	                INNER JOIN
	                ris_details
	                ON 
		                inventory_master.a_code = ris_details.inv_master_SysPK
	                INNER JOIN
	                ris_master
	                ON 
		                ris_details.RIS_Master_No = ris_master.RIS_No
		                WHERE ris_master.supplier_SysPK = '" & txtSupplierCode.Text & "'
		
		                ORDER BY a_name"


        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)

                '.DisplayColumns("a_code").Visible = False

                .DisplayColumns("a_code").DataColumn.Caption = "ITEM CODE"
                .DisplayColumns("a_code").Width = 100
                .DisplayColumns("a_code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("a_name").DataColumn.Caption = "ITEM NAME"
                .DisplayColumns("a_name").Width = 400
                .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("method").DataColumn.Caption = "MED TYPE"
                .DisplayColumns("method").Width = 150
                .DisplayColumns("method").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("method").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("uom").DataColumn.Caption = "UNIT"
                .DisplayColumns("uom").Width = 150
                .DisplayColumns("uom").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("uom").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("price").DataColumn.Caption = "BUYING PRICE PRICE"
                .DisplayColumns("price").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("price").Width = 170
                .DisplayColumns("price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("selling_price").DataColumn.Caption = "SELLING PRICE PRICE"
                .DisplayColumns("selling_price").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("selling_price").Width = 170
                .DisplayColumns("selling_price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("selling_price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("qty_received").DataColumn.Caption = "ACTUAL COUNT"
                .DisplayColumns("qty_received").DataColumn.NumberFormat = "00"
                .DisplayColumns("qty_received").Width = 150
                .DisplayColumns("qty_received").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("qty_received").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("item_reordercount").DataColumn.Caption = "RE-ORDER LEVEL"
                ''     .DisplayColumns("item_reordercount").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("item_reordercount").Width = 120
                .DisplayColumns("item_reordercount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_reordercount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("supplier_SysPK").Visible = False

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        displaySuppliers()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        displayFundsClass()
    End Sub
End Class