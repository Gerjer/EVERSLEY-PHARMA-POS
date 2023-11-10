﻿Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.Utils.Win
Imports DevExpress.XtraBars.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports System.Threading
Imports System.Threading.Tasks
Imports System.ComponentModel

Public Class fmaStockCardForm
    Private WithEvents Progress As Windows.Forms.ProgressBar

    Private Sub fmaMonthlyInventoryPerSupplierListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtYear.Value = Date.Now.Year
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        dtpDateMonthof.DataSource = months
        dtpDateMonthof.SelectedIndex = Date.Now.Month - 1


        displaySuppliers()
        loadHanler

    End Sub

    Private Sub loadHanler()
        AddHandler cmbItemCheck.Click, AddressOf cmbItemCheck_Click
        AddHandler cmbItemCheck.Properties.Popup, AddressOf ItemPopUp
        AddHandler cmbItemCheck.Properties.Closed, AddressOf ItemClosedLoad
    End Sub

    Dim ListItem As String = ""
    Private Sub ItemClosedLoad(sender As Object, e As ClosedEventArgs)
        Dim Mode As PopupCloseMode = e.CloseMode
        Dim cmbItem As CheckedComboBoxEdit = DirectCast(sender, CheckedComboBoxEdit)

        If Mode = 0 Then
            Tag = 2
            Dim checkitem As Object = cmbItem.Properties.GetCheckedItems()
            ListItem = checkitem
            displayItemInventory()
            cmbItem.ClosePopup()

            Try

                For Each item As CheckedListBoxItem In cmbItem.Properties.GetItems()

                    If item.CheckState = CheckState.Checked Then
                        If item.Value = "16" Then
                            Dim ITEM_CODE As String = item.Description.ToString
                            Dim NEWCHAR As String = ""
                        End If
                        CodeList.Add(item.Value)
                    End If

                Next item
            Catch ex As Exception

            End Try



        End If
    End Sub

    Private subscribe As Boolean = True
    Private Sub ItemPopUp(sender As Object, e As EventArgs)

        Try
            subscribe = True
            If subscribe Then ' 1st approach
                Dim list As CheckedListBoxControl = (TryCast(sender, IPopupControl)).PopupWindow.Controls.OfType(Of PopupContainerControl)().First().Controls.OfType(Of CheckedListBoxControl)().First()
                subscribe = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Dim CodeList As List(Of String) = New List(Of String)
    Private Sub cmbItemCheck_Click(sender As Object, e As EventArgs)
        Dim control As CheckedComboBoxEdit = DirectCast(sender, CheckedComboBoxEdit)
        If control.IsPopupOpen Then
            '        tag = 1
            AddHandler(DirectCast(control, CheckedComboBoxEdit).Popup), AddressOf ItemPopUp
        End If

        Dim cmbItem As CheckedComboBoxEdit = DirectCast(sender, CheckedComboBoxEdit)
        Dim checkitem As Object = cmbItem.Properties.GetCheckedItems()
        ListItem = checkitem



    End Sub

    Private Sub displaySuppliers()

        'Dim SQLEX As String = "SELECT a_code, a_name FROM supplier"
        'SQLEX += " ORDER BY a_name"

        Dim SQLEX As String = "SELECT SysPK 'id',a_name 'name' FROM pharmaceuticals"

        Dim MeData As DataTable
        MeData = DataSource(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try

                Me.txtSupplierList.DataSource = MeData
                Me.txtSupplierList.DisplayMember = "name"
                Me.txtSupplierList.ValueMember = "id"
                Me.txtSupplierList.SelectedIndex = -1
                Me.txtSupplierList.Text = ""
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub displayItems()
        'Dim SQLEX As String = "SELECT inventory_master.a_name, inventory_master.a_code, inventory_master.item_buyprice, inventory_master.consignee"
        'SQLEX += " FROM inventory_master"
        'SQLEX += " INNER JOIN pharmaceuticals "
        'SQLEX += " ON (inventory_master.consignee_id = pharmaceuticals.SysPK)"
        'SQLEX += " WHERE pharmaceuticals.a_code='" & txtSupplierCode.Text & "'"
        'SQLEX += " ORDER BY inventory_master.a_name"

        Dim SQLEX As String = ""
        SQLEX = "SELECT
	                CAST(CONCAT(inventory_master.a_name, ' - ', ris_details.price) AS CHAR(125)) AS 'a_name', 
	                inventory_master.a_code, 
	                ris_details.price, 
	                inventory_master.consignee
                FROM
	                ris_master
	                INNER JOIN
	                ris_details
	                ON 
		                ris_master.RIS_No = ris_details.RIS_Master_No
	                INNER JOIN
	                inventory_master
	                ON 
		                ris_details.inv_master_SysPK = inventory_master.a_code
                WHERE
	                 -- ris_master.supplier_SysPK = '" & txtSupplierCode.Text & "'
                      ris_master.fund_class_id = '" & txtSupplierCode.Text & "'
                GROUP BY a_code
                ORDER BY
	                inventory_master.a_name"



        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim rows As Integer = MeData.Rows.Count + 1
        cmbItemCheck.Properties.Items.Clear()
        cmbItemCheck.Properties.DataSource = MeData
        cmbItemCheck.Properties.ValueMember = "a_code"
        cmbItemCheck.Properties.DisplayMember = "a_name"
        cmbItemCheck.Properties.DropDownRows = rows

        'Me.txtItemName.DataSource = MeData
        'Me.txtItemName.DisplayMember = "a_name"
        'Me.txtItemName.ValueMember = "a_code"
        'Me.txtItemName.SelectedIndex = -1
        'Me.txtItemName.Text = ""

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub txtSupplierList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierList.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtSupplierList.SelectedItem, DataRowView)
            Me.txtSupplierCode.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtSupplierCode.Text = ""
        End Try
        displayItems()
    End Sub

    Private Sub displayItemInventory()

        If ListItem = "" Then
            MsgBox("Please Select at least 1 Item.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim SQLEX As String = "SELECT TRD_Date,daily_inventory_details.initial_qty ,added,sold,pullout,remaining_qty "
        SQLEX += " ,CONCAT(inventory_master.a_name,' -(Php ',ris_details.price,')')'a_name'"
        SQLEX += " ,daily_inventory_details.a_code"
        SQLEX += " FROM daily_inventory_details"
        SQLEX += " INNER JOIN inventory_master "
        SQLEX += " ON (daily_inventory_details.SysPK_InvMaster = inventory_master.SysPK)"
        SQLEX += " INNER JOIN ris_details ON ( inventory_master.a_code = ris_details.inv_master_SysPK)"
        SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No      "
        '      SQLEX += " WHERE supplier_SysPK ='" & txtSupplierCode.Text & "'"
        SQLEX += " WHERE ris_master.fund_class_id ='" & txtSupplierCode.Text & "'"
        SQLEX += " AND TRD_Date BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        '     SQLEX += " AND daily_inventory_details.a_code='" & txtItemCode.Text & "'"
        SQLEX += " AND daily_inventory_details.a_code IN (" & ListItem & ")"
        SQLEX += " ORDER BY a_code,a_name,TRD_Date"

        Dim MeData As DataTable
        MeData = DataSource(SQLEX)

        If MeData.Rows.Count > 0 Then
            GridControl1.DataSource = Nothing
            GridControl1.DataSource = MeData
            DesignGridview(GridView1)

            Dim dt As DataTable = PopulateDatatable(MeData, CodeList)

            tdbViewer.DataSource = dt
            Me.tdbViewer.Rebind(True)


            Try
                With tdbViewer.Splits(0)

                    .DisplayColumns("TRD_Date").DataColumn.Caption = "DATE"
                    .DisplayColumns("TRD_Date").DataColumn.NumberFormat = "yyyy-MM-dd"
                    .DisplayColumns("TRD_Date").Width = 100
                    .DisplayColumns("TRD_Date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("TRD_Date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                    .DisplayColumns("initial_qty").DataColumn.Caption = "BEGINNING QTY"
                    .DisplayColumns("initial_qty").Width = 150
                    .DisplayColumns("initial_qty").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("initial_qty").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                    'added,sold,pullout,remaining_qty
                    .DisplayColumns("added").DataColumn.Caption = "DELIVERY"
                    .DisplayColumns("added").Width = 150
                    .DisplayColumns("added").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("added").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                    .DisplayColumns("sold").DataColumn.Caption = "ISSUANCE"
                    .DisplayColumns("sold").Width = 150
                    .DisplayColumns("sold").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("sold").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                    .DisplayColumns("pullout").DataColumn.Caption = "PULL-OUT"
                    .DisplayColumns("pullout").Width = 150
                    .DisplayColumns("pullout").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("pullout").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                    .DisplayColumns("remaining_qty").DataColumn.Caption = "ENDING QTY"
                    .DisplayColumns("remaining_qty").Width = 150
                    .DisplayColumns("remaining_qty").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("remaining_qty").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center


                End With
            Catch ex As Exception

            End Try

        Else
            MsgBox("No records found.....", MessageBoxIcon.Information, "NO DATA")
        End If

        CodeList.Clear()

    End Sub

    Private Function PopulateDatatable(dt As DataTable, codeList As List(Of String)) As DataTable
        Dim result = dt.Clone()

        For Each ItemCode In codeList.ToList
            For Each row As DataRow In From row1 As DataRow In dt.Rows Where (row1("a_code") = (ItemCode))
                result.ImportRow(row)
            Next

        Next

        Return result

    End Function

    Private Sub DesignGridview(gridView1 As GridView)
        Dim view As GridView = gridView1

        For i As Integer = 0 To view.Columns.Count - 1
            Select Case i
                Case 0
                    view.Columns(i).Caption = "DATE"
                    view.Columns(i).DisplayFormat.FormatString = "yyyy-MM-dd"
                    view.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 1
                    view.Columns(i).Caption = "BEGINNING QTY"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 2
                    view.Columns(i).Caption = "DELIVERY"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 3
                    view.Columns(i).Caption = "ISSUANCE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 4
                    view.Columns(i).Caption = "PULL-OUT"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 5
                    view.Columns(i).Caption = "ENDING QTY"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case Else
                    view.Columns(i).Visible = False
            End Select
        Next

        view.Columns("a_name").GroupIndex = 0
        '    view.ClearSorting()

    End Sub

    Private Sub txtItemName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemName.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtItemName.SelectedItem, DataRowView)
            Me.txtItemCode.Text = drv.Item("a_code").ToString
        Catch ex As Exception
            Me.txtItemCode.Text = ""
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        displayItemInventory()
    End Sub

    Private Sub dtpDateMonthof_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dateFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtpDateMonthof_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateMonthof.SelectedIndexChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dateFrom_ValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged
        Try
            dateTo.Value = New DateTime(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.AddMonths(1).AddDays(-1).Day)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtYear_ValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.ValueChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try
    End Sub


    Dim stock_card As New List(Of stock_card)

    Dim NewReport As Boolean = True
    Dim ctr As Double = 0
    Dim ctrvalue As Double = 0
    Dim cnt As Integer = 0
    Dim progressValue As Double = 0
    Dim dt As DataTable



    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        ProgressBar1.Refresh()
        lblpercent.BackColor = System.Drawing.SystemColors.ControlLight
        If Not BackgroundWorker1.IsBusy = True Then
            ProgressBar1.Visible = True
            lblpercent.Visible = True
            BackgroundWorker1.RunWorkerAsync()
        End If

#Region "old"
        'LoadBackGroundWorker()

        'If GridView1.RowCount < 0 Then

        '    Cursor = Cursors.WaitCursor


        '    If NewReport = True Then

        '        Try
        '            Dim dt As New DataTable
        '            'ProgressBar1.Visible = True
        '            'Timer1.Enabled = True

        '            ' ProgressBar1.Visible = True
        '            ' Dim slowStuff = Task(Of Integer).Factory.StartNew(
        '            'Function() ExceuteSlowStuff(AddressOf Me.ShowProgress))

        '            'ProgressBar1.Visible = True
        '            'bgw.WorkerReportsProgress = True
        '            'bgw.RunWorkerAsync()


        '            dt = getQueryStockCard(txtSupplierCode.Text, Format(Me.dateFrom.Value, "yyyy-MM-dd"), Format(Me.dateTo.Value, "yyyy-MM-dd"), ListItem)


        '            If dt.Rows.Count > 0 Then
        '                progressValue = 0
        '                cnt = 1
        '                ctr = dt.Rows.Count / 100
        '                ctrvalue = 100 / dt.Rows.Count
        '                'Dim current_row As Integer = dt.Rows.Count
        '                'Dim default_row As Integer = 0
        '                'If current_row <= 36 Then
        '                '    default_row = 36 - current_row
        '                'End If

        '                'Dim dummy_dt As DataTable = dt.Copy

        '                'Dim cnt As Integer = 1
        '                'Do While default_row > cnt
        '                '    dummy_dt.Rows.Add()
        '                '    cnt += 1
        '                'Loop

        '                'dt = Nothing
        '                'dt = dummy_dt.Copy

        '                'Dim x As Integer = 0

        '                For Each row As DataRow In dt.Rows

        '                    Dim obj As New stock_card

        '                    '     If current_row > x Then

        '                    With obj
        '                        .item_name = If(IsDBNull(row("a_name").ToString), "", row("a_name").ToString)
        '                        .item_desc = If(IsDBNull(row("desc").ToString), "", row("desc").ToString)
        '                        .item_code = If(IsDBNull(row("a_code").ToString), "", row("a_code").ToString)
        '                        .price = If(IsDBNull(row("price")), "", row("price"))
        '                        .uom = If(IsDBNull(row("uom").ToString), "", row("uom").ToString)
        '                        .brand_name = If(IsDBNull(row("brand_name").ToString), "", row("brand_name").ToString)
        '                        .re_order_cnt = If(IsDBNull(row("item_reordercount").ToString), "", row("item_reordercount").ToString)
        '                        .clusster = If(IsDBNull(row("fund_cluster").ToString), "", row("fund_cluster").ToString)
        '                        .initial_qty = If(IsDBNull(row("initial_qty").ToString), 0, row("initial_qty").ToString)
        '                        '  .sold = If(IsDBNull(row("sold").ToString), 0, row("sold").ToString)
        '                        '  .pullout = If(IsDBNull(row("pullout").ToString), 0, row("pullout").ToString)
        '                        .balance_qty = If(IsDBNull(row("balance_qty").ToString), 0, row("balance_qty").ToString)
        '                        .reference = If(IsDBNull(row("reference").ToString), "", row("reference").ToString)
        '                        .date_transaction = If(IsDBNull(row("TRD_Date").ToString), 0, row("TRD_Date").ToString)
        '                        .soldpullout = If(IsDBNull(row("soldpullout").ToString), 0, row("soldpullout").ToString)
        '                    End With

        '                    '    End If

        '                    stock_card.Add(obj)

        '                    '   x += 1
        '                Next


        '                Dim report As New xtrStockCard

        '                report.DataSource = stock_card
        '                report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        '                report.CreateDocument()
        '                report.ShowPreview
        '                stock_card.Clear()



        '            End If
        '        Catch ex As Exception

        '        End Try


        '    Else

        '        Dim SQLEX As String = "SELECT TRD_Date,daily_inventory_details.initial_qty ,added,(sold + pullout) 'isspull',remaining_qty "
        '        SQLEX += " ,inventory_master.consignee, inventory_master.a_name,inventory_master.a_code, inventory_master.item_unit  "
        '        SQLEX += " ,inventory_master.item_reordercount, inventory_master.item_buyprice"
        '        SQLEX += " FROM daily_inventory_details"
        '        SQLEX += " INNER JOIN inventory_master "
        '        SQLEX += " ON (daily_inventory_details.SysPK_InvMaster = inventory_master.SysPK)"
        '        SQLEX += " INNER JOIN pharmaceuticals"
        '        SQLEX += " ON (inventory_master.consignee_id = pharmaceuticals.SysPK)"
        '        SQLEX += " WHERE pharmaceuticals.a_code='" & txtSupplierCode.Text & "'"
        '        SQLEX += " AND TRD_Date BETWEEN '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
        '        SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
        '        SQLEX += " AND daily_inventory_details.a_code='" & txtItemCode.Text & "'"
        '        SQLEX += " ORDER BY TRD_Date"

        '        Dim new_report As New fzzReportViewerForm
        '        Dim reportTitle As String = "STOCK CARD HEADER"

        '        Try
        '            new_report.AttachReport(SQLEX, reportTitle) = New rpt_StockCardHeaderPrint
        '            new_report.Show()
        '        Catch ex As Exception

        '        End Try


        '    End If


        '    'ProgressBar1.Visible = True
        '    'Timer1.Enabled = True

        '    Cursor = Cursors.Default

        'Else
        '    'MsgBox("Load the data first...!!")
        'End If
#End Region


    End Sub

    Private Sub LoadBackGroundWorker()
        Finish = False
        ProgressBar1.Visible = True
        Dim slowStuff = Task(Of Integer).Factory.StartNew(
       Function() ExceuteSlowStuff(AddressOf Me.ShowProgress))


    End Sub

    Private Sub ShowProgress()
        If Finish = False Then

            If Me.ProgressBar1.InvokeRequired Then
                Dim cross As New Action(AddressOf Me.ShowProgress)
                Me.Invoke(cross)
            Else
                If Me.ProgressBar1.Value = 100 Then
                    Me.ProgressBar1.Value = 1
                    Me.ProgressBar1.Visible = False
                    LoadPrint(dt)
                    Finish = True
                Else
                    Me.ProgressBar1.Increment(1)
                End If

                '     Me.ProgressBar1.Refresh()
            End If

        End If
    End Sub
    Dim Finish As Boolean = False
    Private Function ExceuteSlowStuff(ByVal progress As Action) As Integer

        dt = getQueryStockCard(txtSupplierCode.Text, Format(Me.dateFrom.Value, "yyyy-MM-dd"), Format(Me.dateTo.Value, "yyyy-MM-dd"), ListItem)

        Dim result = 0

        For i = 0 To 10000
            result += i
            Thread.Sleep(200)
            progress()
        Next

        Return result
    End Function

    'Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw.DoWork

    '    dt = getQueryStockCard(txtSupplierCode.Text, Format(Me.dateFrom.Value, "yyyy-MM-dd"), Format(Me.dateTo.Value, "yyyy-MM-dd"), ListItem)

    '    For i As Integer = 0 To 10000
    '        If i Mod 1000 Then
    '            bgw.ReportProgress(i / 100)

    '        End If
    '    Next

    'End Sub





    Private Sub LoadPrint(dt As DataTable)

        For Each row As DataRow In dt.Rows

            Dim obj As New stock_card

            '     If current_row > x Then

            With obj
                .item_name = If(IsDBNull(row("a_name").ToString), "", row("a_name").ToString)
                .item_desc = If(IsDBNull(row("desc").ToString), "", row("desc").ToString)
                .item_code = If(IsDBNull(row("a_code").ToString), "", row("a_code").ToString)
                .price = If(IsDBNull(row("price")), "", row("price"))
                .uom = If(IsDBNull(row("uom").ToString), "", row("uom").ToString)
                .brand_name = If(IsDBNull(row("brand_name").ToString), "", row("brand_name").ToString)
                .re_order_cnt = If(IsDBNull(row("item_reordercount").ToString), "", row("item_reordercount").ToString)
                .clusster = If(IsDBNull(row("fund_cluster").ToString), "", row("fund_cluster").ToString)
                .initial_qty = If(IsDBNull(row("initial_qty").ToString), 0, row("initial_qty").ToString)
                '  .sold = If(IsDBNull(row("sold").ToString), 0, row("sold").ToString)
                '  .pullout = If(IsDBNull(row("pullout").ToString), 0, row("pullout").ToString)
                .balance_qty = If(IsDBNull(row("balance_qty").ToString), 0, row("balance_qty").ToString)
                .reference = If(IsDBNull(row("reference").ToString), "", row("reference").ToString)
                .date_transaction = If(IsDBNull(row("TRD_Date").ToString), 0, row("TRD_Date").ToString)
                .soldpullout = If(IsDBNull(row("soldpullout").ToString), 0, row("soldpullout").ToString)
            End With

            '    End If

            stock_card.Add(obj)

            '   x += 1
        Next


        Dim report As New xtrStockCard

        report.DataSource = stock_card
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview
        stock_card.Clear()

        ProgressBar1.Visible = False
        lblpercent.Visible = False
        lblpercent.Text = ""

        ProgressBar1.Value = 0
        System.Threading.Thread.Sleep(300)
        dt = Nothing


    End Sub

    Private Function getQueryStockCard(SupplierCode As String, DateForm As String, DateTo As String, ItemCode As String) As DataTable
        Dim sql As String = ""
        sql = "		SELECT
					TRD_Date,
					CASE WHEN total_amnt <> 0 THEN CAST(CONCAT('RIS No.#(',RIS_No,') , Php ',total_amnt) AS CHAR(125))
					ELSE CAST(CONCAT('RIS No.#(',RIS_No,')') AS CHAR(125)) END AS 'reference',
					initial_qty,
				    -- sold,
					-- pullout,
                    CAST(CASE WHEN sold IS NOT NULL AND pullout IS NOT NULL THEN CAST(CONCAT(sold + pullout) AS CHAR(50))
	    		     WHEN sold IS NOT NULL AND pullout IS NULL THEN sold
					 WHEN sold IS NULL AND pullout IS NOT NULL THEN  pullout
					 ELSE '0' END AS CHAR(50)) AS 'soldpullout',
					balance_qty,
					a_name,
					a_code,
                    price,
					consignee 'desc',
					uom,
					brand_name,
					item_reordercount,
					fund_cluster,
                    supplier
				
			    
		FROM(
							SELECT
							TRD_Date,
							daily_inventory_details.initial_qty + added 'initial_qty',
							ris_master.RIS_No,
		    				CASE WHEN sold = 0 THEN '0' ELSE sold END AS 'sold',
							CASE WHEN pullout = 0 THEN '0' ELSE CAST(CONCAT('(-',pullout,')') AS CHAR(50)) END AS 'pullout',
							remaining_qty 'balance_qty',
							ris_details.RIS_Det_No,
							ris_details.inv_master_SysPK,
							(SELECT
							ifNULL(sum(daily_sales_detail.item_total),0)
							FROM
							daily_sales_detail
							WHERE
							daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No AND daily_sales_detail.item_invcode = ris_details.inv_master_SysPK
							AND date_format(daily_sales_detail.date_created,'%Y-%m-%d') BETWEEN '" & DateForm & "' AND '" & DateTo & "') 'total_amnt',
							inventory_master.a_name,
							inventory_master.a_code,
                            ris_details.price,
							inventory_master.consignee,
							inventory_master.uom,
							inventory_master.brand_name,
							inventory_master.item_reordercount,
							ris_master.fund_cluster,
                            supplier

							FROM
							daily_inventory_details
							INNER JOIN inventory_master ON ( daily_inventory_details.SysPK_InvMaster = inventory_master.SysPK )
							INNER JOIN ris_details ON ( inventory_master.a_code = ris_details.inv_master_SysPK )
							INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No

							WHERE
							-- supplier_SysPK = '" & SupplierCode & "' 
                            ris_master.fund_class_id  = '" & SupplierCode & "' 
							AND TRD_Date BETWEEN '" & DateForm & "' AND '" & DateTo & "'
							AND daily_inventory_details.a_code IN (" & ItemCode & ") 
							ORDER BY
							a_name,a_code,TRD_Date ASC
							
							)A  ORDER BY a_code,a_name,TRD_Date"
        '    Return DataSource(sql)
        Return clsDBConn.ExecLongQuery(sql)

    End Function

    Private Sub btnPrint_Enter(sender As Object, e As EventArgs)




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            progressValue = (ctr * cnt) * ctrvalue
            ProgressBar1.Value += progressValue
        Else
            If ProgressBar1.Value = 100 Then
                Dim report As New xtrStockCard
                report.DataSource = stock_card
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1
                report.CreateDocument()
                report.ShowPreview
                stock_card.Clear()
                ProgressBar1.Visible = False
                Timer1.Enabled = False
                ProgressBar1.Value = 1
            End If


        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'For i = 0 To 100
        '    If BackgroundWorker1.CancellationPending = True Then
        '        e.Cancel = True
        '    Else
        '        DoHeavyWork()
        '        BackgroundWorker1.ReportProgress(i)
        '    End If
        'Next




        dt = getQueryStockCard(txtSupplierCode.Text, Format(Me.dateFrom.Value, "yyyy-MM-dd"), Format(Me.dateTo.Value, "yyyy-MM-dd"), ListItem)
        For i = 1 To ProgressBar1.Maximum

            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else
                DoHeavyWork()
                BackgroundWorker1.ReportProgress(i)
            End If
        Next


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Dim i As Integer = e.ProgressPercentage
        If i >= 51 Then
            lblpercent.BackColor = System.Drawing.Color.MediumSeaGreen
        Else
            lblpercent.BackColor = System.Drawing.SystemColors.ControlLight
        End If
        ProgressBar1.Value = e.ProgressPercentage
        lblpercent.Text = e.ProgressPercentage.ToString() + "%"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If e.Cancelled = True Then
            MessageBox.Show("Cancelled")
            ProgressBar1.Value = 0
            lblpercent.Text = ""
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
        Else
            '    MessageBox.Show("Finished")
            LoadPrint(dt)
        End If

    End Sub


    Private Sub DoHeavyWork()

        System.Threading.Thread.Sleep(300)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not BackgroundWorker1.WorkerSupportsCancellation = True Then
            BackgroundWorker1.CancelAsync()
        End If

    End Sub

    Private Sub fmaStockCardForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Button2.PerformClick()
        End If
    End Sub
End Class