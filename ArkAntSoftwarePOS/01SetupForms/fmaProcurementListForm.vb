Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base

Public Class fmaProcurementListForm

    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "units"

    Private WithEvents SETUPFORM As fmaUnitsTypeSetupForm


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaUnitsTypeSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

        End If
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaUnitsTypeSetupForm
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()

    End Sub

    Dim FirstLoad As Boolean

    Dim dt_details As DataTable
    Private Sub fmaProcurementListForm_Load(sender As Object, e As EventArgs) Handles Me.Load


        FirstLoad = True

        Label1.Visible = False
        dtpTo.Visible = False



        PanelEx2.Text = "LIST OF PROCURED MEDICINES"
        cmbMode.SelectedIndex = 1

        btnAdd.Visible = False
            btnEdit.Visible = False
            btnDelete.Visible = False


        lblDate.Text = "MONTHLY"
        Label1.Visible = False
        dtpTo.Visible = False

        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMMM"
        dtpFrom.ShowUpDown = False



        LoadComboBox()

        LoadList()

        FirstLoad = False
    End Sub

    Dim dataSet11 As DataSet

    Private Sub LoadList()

        GridControl1.DataSource = Nothing

        Try
            cmbSupplier.SelectedValue = supplier_id
            cmbProcurement.Text = mode_procurement

            Dim SQL As String = " SELECT ris_master.date_received,ris_details.inv_master_Name 'item_name' "
            SQL += " ,	inventory_master.method 'dosage_form',inventory_master.brand_name "
            SQL += " ,	ris_details.price 'cost_perunit',ris_details.qty_received 'qty' "
            SQL += " ,	FORMAT(ris_details.price * ris_details.qty_received,2) 'total_cost',supplier.a_name 'supplier_name' "
            SQL += " ,	inventory_master.manufacturer,ris_master.procurement_mode "
            SQL += " ,	ris_details.delivery_status,ris_master.bid_attemp "
            SQL += "  FROM 	ris_master"
            SQL += "  INNER JOIN ris_details ON ris_master.RIS_No = ris_details.RIS_Master_No"
            SQL += "  INNER JOIN inventory_master ON ris_details.inv_master_SysPK = inventory_master.a_code "
            SQL += "  INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code AND supplier.supplier_type = 0"

            If cmbMode.SelectedIndex = 0 Then
                SQL += " WHERE DATE_FORMAT(ris_master.date_received,'%Y') = '" & Format(dtpFrom.Value, "yyyy") & "' "
                date_name = Format(dtpFrom.Value, "yyyy") & " - "
            ElseIf cmbMode.SelectedIndex = 1 Then
                SQL += " WHERE DATE_FORMAT(ris_master.date_received,'%M') = '" & Format(dtpFrom.Value, "MMMM") & "' "
                date_name = "Month of  " & Format(dtpFrom.Value, "MMMM") & " - "
            Else
                SQL += " WHERE ris_master.date_received BETWEEN '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND  '" & Format(dtpTo.Value, "yyyy-MM-dd") & "' "
                date_name = "From " & Format(dtpFrom.Value, "MMMM") & " To " & Format(dtpTo.Value, "yyyy-MM-dd") & " - "
            End If

            If cmbSupplier.Text <> "" And cmbSupplier.Text <> "-- ALL --" Then
                SQL += " AND supplier.a_code = '" & cmbSupplier.SelectedValue & "'"
            End If

            If cmbProcurement.Text <> "" And cmbProcurement.Text <> "-- ALL --" Then
                SQL += " AND procurement_mode = '" & cmbProcurement.Text & "'"
            End If

            SQL += " ORDER BY date_received DESC,RIS_Det_No "

            Dim dt As New DataTable
            dt = DataSource(SQL)

            GridControl1.DataSource = dt
            DesigGRidView2(GridView1)
        Catch ex As Exception

        End Try



    End Sub

    Private Function getNodeItem(str As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
                  ris_master.RIS_No, 
	                inventory_master.a_code AS `ITEM CODE`, 
	                inventory_master.a_name AS `GENERIC NAME OF MEDICINE`, 
	                ris_details.qty_received AS `QTY RECEIVED`, 
	                ris_details.price AS `COST PER UNIT`, 
	                ris_details.price * ris_details.qty_received AS `TOTAL COST`, 
	                ris_details.qty_remaining AS `REMAINING QTY`, 
	                DATE_FORMAT(ris_details.expiry_date,'%m/%d/%Y') AS `EXPIRTY DATE`, 
	                ris_details.delivery_status AS `DELIVERY STATUS`, 
	                ris_details.location AS `STORAGE LOCATION`, 
	                ris_details.remarks AS REMARKS
                FROM
	                ris_master
	                INNER JOIN 	ris_details	ON 	ris_master.RIS_No = ris_details.RIS_Master_No
	                INNER JOIN	inventory_master	ON 	ris_details.inv_master_SysPK = inventory_master.a_code
	                INNER JOIN	supplier	ON	ris_master.supplier_SysPK = supplier.SysPK


                " & str & "


                ORDER BY date_received DESC
                     

                     "
        Return DataSource(sql)
    End Function

    Private Function getNodeReceived(str As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
  	            ris_master.RIS_No, 
                DATE_FORMAT(ris_master.date_received,'%m/%d/%Y') 'DATE RECEIVED', 
		            ris_master.si_no 'S.I No.#', 
		            DATE_FORMAT(ris_master.po_date,'%m/%d/%Y') 'P.O Date', 
		            ris_master.po_no 'P.O No.#', 
		            ris_master.received_by 'RECEIVED BY',
		            CASE WHEN  ris_master.approved_status = 0 THEN ''
				             WHEN  ris_master.approved_status = 1 THEN 'APPROVED'
				             ELSE 'REJECTED' END AS 'RIS STATUS',
		            procurement_mode 'MODE OF PROCUREMENT',
		            fund_cluster 'FUND CLUSTER',
		            bid_attemp 'BID ATTEMP'

            FROM
	            ris_master
	            INNER JOIN 	ris_details	ON 	ris_master.RIS_No = ris_details.RIS_Master_No
	            INNER JOIN	inventory_master	ON 	ris_details.inv_master_SysPK = inventory_master.a_code
	            INNER JOIN	supplier	ON	ris_master.supplier_SysPK = supplier.SysPK


            " & str & "


            ORDER BY date_received DESC	
	
            "
        Return DataSource(sql)
    End Function

    Private Function getNodeSupplier(str As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
  	            ris_master.RIS_No, 
		            supplier.a_name 'SUPPLIER'

            FROM
	            ris_master
	            INNER JOIN 	ris_details	ON 	ris_master.RIS_No = ris_details.RIS_Master_No
	            INNER JOIN	inventory_master	ON 	ris_details.inv_master_SysPK = inventory_master.a_code
	            INNER JOIN	supplier	ON	ris_master.supplier_SysPK = supplier.SysPK

            " & str & "


            ORDER BY date_received DESC	"
        Return DataSource(sql)
    End Function

    Private Sub DesigGRidView1(gridview As GridView)

        Dim View As GridView = DirectCast(gridview, GridView)

        '     View.BeginUpdate()
        View.OptionsBehavior.Editable = False
        View.OptionsFind.AlwaysVisible = True
        View.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search
        View.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always

        For i As Integer = 0 To View.Columns.Count - 1

            Select Case i
                Case 1
                    View.Columns(i).Caption = "SUPPLIER"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                '    View.Columns(i).Width = 350
                Case 2
                    View.Columns(i).Caption = "RECEIVED DETAILS"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
              '      View.Columns(i).Width = 100
                Case 5
                    View.Columns(i).Caption = "GENERIC NAME OF MEDICINE"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 400
                Case 6
                    View.Columns(i).Caption = "QTY RECEIVED"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).DisplayFormat.FormatString = "###,###.00"
                    View.Columns(i).Width = 120
                Case 7
                    View.Columns(i).Caption = "PRICE PER UNIT"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    View.Columns(i).DisplayFormat.FormatString = "###,###.00"
                    View.Columns(i).Width = 120
                Case 8
                    View.Columns(i).Caption = "QTY REMAINING"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).DisplayFormat.FormatString = "###,###.00"
                    View.Columns(i).Width = 120
                Case 9
                    View.Columns(i).Caption = "DELIVERY STATUS"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 100
                Case 10
                    View.Columns(i).Caption = "STORAGE LOCATION"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 200
                Case 11
                    View.Columns(i).Caption = "EXPIRY DATE"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 120
                Case 12
                    View.Columns(i).Caption = "REMARKS"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 400
                Case Else
                    View.Columns(i).Visible = False
            End Select

        Next

        View.GroupFormat = "{1}"
        View.Columns("supplier").GroupIndex = 0
        View.Columns("ReceiveDetails").GroupIndex = 1
        View.ExpandAllGroups()

    End Sub

    Private Sub DesigGRidView2(gridview As GridView)

        Dim View As GridView = DirectCast(gridview, GridView)
        View.OptionsBehavior.Editable = False

        View.BeginUpdate()

        For i As Integer = 0 To View.Columns.Count - 1

            Select Case i
                Case 1
                    View.Columns(i).Caption = "GENERIC NAME OF MEDICINE"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 350
                Case 2
                    View.Columns(i).Caption = "DOSAGE FORM"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 100
                Case 3
                    View.Columns(i).Caption = "BRAND NAME"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 100
                Case 4
                    View.Columns(i).Caption = "COST PER UNIT"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).DisplayFormat.FormatString = "###,###.00"
                    View.Columns(i).Width = 100
                Case 5
                    View.Columns(i).Caption = "QUANTITY"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 80
                Case 6
                    View.Columns(i).Caption = "TOTAL COST"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    View.Columns(i).Width = 80
                Case 7
                    View.Columns(i).Caption = "SUPPLIER"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 200
                Case 8
                    View.Columns(i).Caption = "MANUFACTURER"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 180
                Case 9
                    View.Columns(i).Caption = "MODE OF PROCUREMENT"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 150
                Case 10
                    View.Columns(i).Caption = "DELIVERY STATUS"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 100
                Case 11
                    View.Columns(i).Caption = "BID ATTEMP"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 80
                Case Else
                    View.Columns(i).Visible = False
            End Select

        Next

        View.EndUpdate()

    End Sub

    Private Sub LoadComboBox()

        cmbSupplier.DataSource = getSupplier()
        cmbSupplier.ValueMember = "id"
        cmbSupplier.DisplayMember = "name"
        cmbSupplier.SelectedIndex = -1


        cmbProcurement.DataSource = getProcurementMode()
        cmbProcurement.ValueMember = "id"
        cmbProcurement.DisplayMember = "name"
        cmbProcurement.SelectedIndex = -1



    End Sub

    Private Function getProcurementMode() As Object
        Dim sql As String = ""
        sql = "SELECT
                id,
               `name`
              FROM(
			SELECT DISTINCT  1 AS 'id',	procurement_mode 'name' FROM	ris_master 	WHERE procurement_mode is NOT NULL AND received_by <> ''

			UNION

			SELECT 0 AS 'id','-- ALL --' AS 'name'
			)A ORDER BY id"
        Return DataSource(sql)
    End Function

    Private Function getSupplier() As Object
        Dim sql As String = ""
        sql = "SELECT
                `id`,
                `name`
                FROM(
		                SELECT DISTINCT   supplier_SysPK as 'id',	supplier 'name' 
		                FROM	ris_master
		                INNER JOIN supplier on ris_master.supplier_SysPK = supplier.a_code AND supplier.supplier_type = 0

		                UNION

		                SELECT 0 AS 'id','-- ALL --' AS 'name'
                    )A
                ORDER BY `name`"
        Return DataSource(sql)
    End Function

    Dim Mode As String = ""
    Private Sub cmbMode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMode.SelectionChangeCommitted
        'Try
        '    Mode = cmbMode.Text
        '    If Mode = "YEAR" Then
        '        lblDate.Text = "YELAR"
        '        Label1.Visible = False
        '        dtpTo.Visible = False

        '        dtpFrom.Format = DateTimePickerFormat.Custom
        '        dtpFrom.CustomFormat = "yyyy"
        '        dtpFrom.ShowUpDown = True


        '    ElseIf Mode = "MONTHLY" Then
        '        lblDate.Text = "MONTHLY"
        '        Label1.Visible = False
        '        dtpTo.Visible = False

        '        dtpFrom.Format = DateTimePickerFormat.Custom
        '        dtpFrom.CustomFormat = "MMMM"
        '        dtpFrom.ShowUpDown = False

        '    Else

        '        lblDate.Text = "DATE FROM"
        '        Label1.Visible = True
        '        dtpTo.Visible = True

        '        dtpFrom.Format = DateTimePickerFormat.Custom
        '        dtpFrom.CustomFormat = "MMM dd, yyyy"
        '        dtpFrom.ShowUpDown = False

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        LoadList()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        LoadList()
    End Sub

    Dim supplier_id As Integer = 0
    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbSupplier.SelectedItem, DataRowView)
            supplier_id = drv.Item("id").ToString
            LoadList()
        Catch ex As Exception

        End Try
    End Sub
    Dim mode_procurement As String = ""
    Private Sub cmbProcurement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProcurement.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbProcurement.SelectedItem, DataRowView)
            mode_procurement = drv.Item("name").ToString
            LoadList()
        Catch ex As Exception

        End Try
    End Sub

    Dim date_name As String = ""
    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged

        If FirstLoad = False Then
            Try
                Mode = cmbMode.Text
                If Mode = "YEAR" Then
                    lblDate.Text = "YEAR"
                    Label1.Visible = False
                    dtpTo.Visible = False

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "yyyy"
                    dtpFrom.ShowUpDown = True


                ElseIf Mode = "MONTHLY" Then
                    lblDate.Text = "MONTHLY"
                    Label1.Visible = False
                    dtpTo.Visible = False

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "MMMM"
                    dtpFrom.ShowUpDown = False

                Else

                    lblDate.Text = "DATE FROM"
                    Label1.Visible = True
                    dtpTo.Visible = True

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "MMM dd, yyyy"
                    dtpFrom.ShowUpDown = False

                End If
            Catch ex As Exception

            End Try
        End If


    End Sub

    Dim procurement_medicine As New List(Of procured_medicine)

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        For i As Integer = 0 To GridView1.DataRowCount - 1

            Dim obj As New procured_medicine
            With obj
                .generic_name = GridView1.GetRowCellValue(i, "item_name")
                .dosage_form = If(IsDBNull(GridView1.GetRowCellValue(i, "dosage_form")), "", GridView1.GetRowCellValue(i, "dosage_form")) ''GridView1.GetRowCellValue(i, "dosage_form")
                .brand_name = If(IsDBNull(GridView1.GetRowCellValue(i, "brand_name")), "", GridView1.GetRowCellValue(i, "brand_name")) ' GridView1.GetRowCellValue(i, "brand_name")
                .cost_per_unit = GridView1.GetRowCellValue(i, "cost_perunit")
                .qty = GridView1.GetRowCellValue(i, "qty")
                .total_cost = GridView1.GetRowCellValue(i, "total_cost")
                .supplier = If(IsDBNull(GridView1.GetRowCellValue(i, "supplier_name")), "", GridView1.GetRowCellValue(i, "supplier_name")) 'GridView1.GetRowCellValue(i, "supplier_name")
                .manufacturer = If(IsDBNull(GridView1.GetRowCellValue(i, "manufacturer")), "", GridView1.GetRowCellValue(i, "manufacturer")) ''GridView1.GetRowCellValue(i, "manufacturer")
                .mode_procurement = If(IsDBNull(GridView1.GetRowCellValue(i, "procurement_mode")), "", GridView1.GetRowCellValue(i, "procurement_mode")) 'GridView1.GetRowCellValue(i, "procurement_mode")
                .delivery_status = If(IsDBNull(GridView1.GetRowCellValue(i, "delivery_status")), "", GridView1.GetRowCellValue(i, "delivery_status"))
                .bid_attemp = If(IsDBNull(GridView1.GetRowCellValue(i, "bid_attemp")), "", GridView1.GetRowCellValue(i, "bid_attemp"))
            End With
            procurement_medicine.Add(obj)

        Next

        Dim str As String = ""
        If (cmbSupplier.Text = "" Or cmbSupplier.Text = "-- ALL --") And (cmbProcurement.Text = "" Or cmbProcurement.Text = "-- ALL --") Then
            str = date_name & " LIST OF PROCUREMENT AND CONSIGNED MEDICINES"
        ElseIf (cmbSupplier.Text <> "" Or cmbSupplier.Text <> "-- ALL --") And (cmbProcurement.Text = "" Or cmbProcurement.Text = "-- ALL --") Then
            str = date_name & " LIST OF CONSIGNED MEDICINES"
        ElseIf (cmbSupplier.Text <> "" Or cmbSupplier.Text <> "-- ALL --") And (cmbProcurement.Text <> "" Or cmbProcurement.Text <> "-- ALL --") Then
            str = date_name & " LIST OF PROCUREMENT MEDICINES IN " & cmbProcurement.Text.ToUpper
        End If

        Dim report As New xtrProcurementList
        report.header.Text = str
        report.Report.DataSource = procurement_medicine
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview


        procurement_medicine.Clear()

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick

        If Me.Tag = 1 Then

            btnAdd.Visible = True
            btnEdit.Visible = True
            btnDelete.Visible = True

        End If


    End Sub



End Class