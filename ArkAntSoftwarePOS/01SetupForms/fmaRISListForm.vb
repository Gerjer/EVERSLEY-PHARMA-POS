Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class fmaRISListForm

    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "units"

    Private WithEvents SETUPFORM As fmaRISSetupForm
    Private WithEvents REPLENISHFORM As fmaInventoryReplenishmentForm = Nothing

    Dim item_received As New List(Of item_received)



    Private Sub SETUPFORM_LOADLIST() Handles SETUPFORM.LOADLIST
        LoadRISList()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaRISSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()
        LoadRISList()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If GridControl1.FocusedView.IsDetailView = True Then


            If CheckDailySalesDetails(RIS_Det_No) Then
                MsgBox("Item cannot Delete..!!!, Because the item had already been generated.")
            Else
                If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    DataSource(String.Format("DELETE FROM ris_details WHERE RIS_Det_No = '" & RIS_Det_No & "'"))
                    MsgBox("Item has been Deleted...!!!, Successfully.", MsgBoxStyle.Information, "DELETE ITEM")
                    '                LoadList()
                    LoadRISList()
                    GridView1.OptionsBehavior.AutoExpandAllGroups = True
                End If

            End If

        Else
            MsgBox("Please..!!!, Select the row details RIS Master List " & vbCrLf &
                   "To use the Delete Function")
        End If



    End Sub

    Private Function CheckDailySalesDetails(rIS_Det_No As String) As Boolean

        Dim sql As String = DataObject(String.Format("SELECT sales_sys FROM `daily_sales_detail` WHERE RIS_Det_No = '" & rIS_Det_No & "'"))
        If sql <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaRISSetupForm
            SETUPFORM.OPERATION = "EDIT"
            SETUPFORM.RIS_NO = RIS_NO
        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        LoadRISList()
    End Sub

    Dim FirstLoad As Boolean

    Dim dt_details As DataTable
    Private Sub fmaRISListForm_Load(sender As Object, e As EventArgs) Handles Me.Load


        FirstLoad = True

        Label1.Visible = False
        dtpTo.Visible = False


        PanelEx2.Text = "LIST OF REQUISITION ISSUED SLIP"
        cmbMode.SelectedIndex = 1

        'btnAdd.Visible = True
        'btnEdit.Visible = True
        'btnDelete.Visible = True

        lblDate.Text = "MONTHLY"
        Label1.Visible = False
        dtpTo.Visible = False

        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMMM"
        dtpFrom.ShowUpDown = False

        Label2.Visible = False
        cmbSupplier.Visible = False

        Label3.Visible = False
        cmbProcurement.Visible = False


        '   LoadComboBox()

        LoadRISList()

        FirstLoad = False
    End Sub


    Private Sub LoadRISList()

        item_received.Clear()
        GridControl1.DataSource = Nothing

        Try

            Dim SQL As String = " SELECT ris_master.date_received,ris_master.RIS_No 'RIS_No'"
            SQL += " ,	supplier.a_name 'supplier_name',ris_master.po_date,ris_master.po_no"
            SQL += " ,	ris_master.si_no,ris_master.received_by,ris_master.fund_cluster_code"
            SQL += " ,	ris_master.fund_class,ris_master.procurement_mode,ris_master.bid_attemp"
            SQL += " ,  (SELECT attach_dir FROM ris_attachment WHERE RIS_Master_No = ris_master.RIS_No LIMIT 1)'attach_dir',supplier_SysPK,fund_class_id"
            SQL += "  FROM 	ris_master"
            SQL += "  INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code"

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
                SQL += " AND supplier.SysPK = '" & cmbSupplier.SelectedValue & "'"
            End If

            If cmbProcurement.Text <> "" And cmbProcurement.Text <> "-- ALL --" Then
                SQL += " AND procurement_mode = '" & cmbProcurement.Text & "'"
            End If

            SQL += " ORDER BY date_received DESC "

            Dim dt As New DataTable
            dt = DataSource(SQL)

            If dt.Rows.Count > 0 Then

                Dim param As String = ""
                For Each rows As DataRow In dt.Rows
                    If param = "" Then
                        param = "'" & rows("RIS_No").ToString & "'"
                    Else
                        param += "," & "'" & rows("RIS_No").ToString & "'"
                    End If

                Next

                Dim item_details As New DataTable
                item_details = getItemDetails(param)
                If item_details.Rows.Count > 0 Then

                    For Each row As DataRow In item_details.Rows
                        Dim obj As New item_received
                        With obj
                            .RIS_No = row("RIS_No").ToString
                            .item_code = row("a_code").ToString
                            .item_name = row("inv_master_Name").ToString
                            .dosag_form = row("method").ToString
                            .brand_name = row("brand_name").ToString
                            .uom = row("uom").ToString
                            .price = row("price").ToString
                            .qty = row("qty_received").ToString
                            .total_cost = row("total_cost").ToString
                            .expiry_date = row("expiry_date").ToString
                            .manufacturer = If(IsDBNull(row("manufacturer").ToString), "", row("manufacturer").ToString)
                            .delivery_status = If(IsDBNull(row("delivery_status").ToString), "", row("delivery_status").ToString)
                        End With

                        item_received.Add(obj)

                    Next

                End If

                Dim dataset As New DataSet()
                GridControl1.DataSource = Nothing

                Dim supplier As DataTable
                supplier = dt.Copy
                supplier.TableName = "Supplier"

                Dim itemDtls As DataTable
                itemDtls = item_details.Copy
                itemDtls.TableName = "ItemDetails"

                dataset.Tables.Add(supplier)
                dataset.Tables.Add(itemDtls)

                dataset.Relations.Add("ITEM DETAIL", supplier.Columns("RIS_No"), itemDtls.Columns("RIS_No"))

                GridControl1.DataSource = dataset
                GridControl1.DataMember = "supplier"

                GridView1.OptionsBehavior.Editable = False


                GridView1.Columns("date_received").GroupIndex = 0
                GridView1.GroupFormat = "{0} : {1}"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Function getItemDetails(RIS_No As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
    ris_details.RIS_Master_No 'RIS_No',
	inventory_master.a_code,
	ris_details.inv_master_Name,
    inventory_master.uom,
    ris_details.qty_received,
    FORMAT(ris_details.price,2) 'price',
    FORMAT( ris_details.price * ris_details.qty_received, 2 ) 'total_cost',
	-- q(SELECT remaining_qty FROM	daily_inventory_details WHERE	a_code = ris_details.inv_master_SysPK  ORDER BY TRD_Date DESC LIMIT 1) 'remaining_qty',
    ris_details.qty_remaining,
    DATE_FORMAT(ris_details.expiry_date,'%m-%d-%Y')'expiry_date',
    inventory_master.method,
	inventory_master.brand_name,
	inventory_master.manufacturer,
	ris_details.delivery_status,
    RIS_Det_No
FROM
	ris_details
	INNER JOIN inventory_master ON ris_details.inv_master_SysPK = inventory_master.a_code

 WHERE
     RIS_Master_No IN(" & RIS_No & ")
ORDER BY
	RIS_No desc"
        Return DataSource(sql)
    End Function

    Dim dataSet11 As DataSet


    Private Sub LoadList()


        GridControl1.DataSource = Nothing

        If Me.Tag = 1 Then
            Try



                Dim str As String = ""
                If cmbMode.SelectedIndex = 0 Then
                    str += " WHERE supplier_type = 0 AND DATE_FORMAT(date_received,'%Y') = '" & Format(dtpFrom.Value, "yyyy") & "' "
                ElseIf cmbMode.SelectedIndex = 1 Then
                    str += " WHERE supplier_type = 0 AND DATE_FORMAT(date_received,'%M') = '" & Format(dtpFrom.Value, "MMMM") & "' "
                Else
                    str += " WHERE supplier_type = 0 AND date_received BETWEEN '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND  '" & Format(dtpTo.Value, "yyyy-MM-dd") & "' "
                End If


                Dim dataset As New DataSet()

                Dim dt_supplier As DataTable = getNodeSupplier(str)
                GridControl1.DataSource = dt_supplier
                Dim supplier As DataTable = dt_supplier.Copy
                supplier.TableName = "SUPPLIER"
                dataset.Tables.Add(supplier)

                Dim dt_received As DataTable = getNodeReceived(str)
                Dim received As DataTable = dt_received.Copy
                received.TableName = "RECEIVED DETAILS"
                dataset.Tables.Add(received)

                Dim dt_item As DataTable = getNodeItem(str)
                Dim item As DataTable = dt_item.Copy
                item.TableName = "ITEM DETAILS"
                dataset.Tables.Add(item)

                dataset.Relations.Add("RECEIVED DETAILS", supplier.Columns("RIS_No"), received.Columns("RIS_No"))
                dataset.Relations("RECEIVED DETAILS").Nested = True

                dataset.Relations.Add("ITEM DETAILS", received.Columns("RIS_No"), item.Columns("RIS_No"))
                dataset.Relations("ITEM DETAILS").Nested = True


                '   GridView1.OptionsBehavior.Editable = False
                '  GridView1.OptionsView.ShowGroupPanel = False


                'Dim GridView2 As New GridView
                'GridView2.GridControl = gcControl
                'GridView2.Name = "GridView2"
                'GridView2.OptionsBehavior.Editable = False
                'GridView2.OptionsView.ShowGroupPanel = False

                'Dim GridView3 As New GridView
                'GridView3.GridControl = gcControl
                'GridView3.Name = "GridView3"
                'GridView3.OptionsBehavior.Editable = False

                'Dim CardView1 As New CardView
                'CardView1.GridControl = gcControl
                'CardView1.Name = "CardView1"


                'Dim myGridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
                'myGridLevelNode1.LevelTemplate = GridView2
                'myGridLevelNode1.RelationName = "RECEIVED DETAILS"

                'Dim myGridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
                'myGridLevelNode2.LevelTemplate = GridView3
                'myGridLevelNode2.RelationName = "RIS_No"

                'Dim myGridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
                'myGridLevelNode2.LevelTemplate = CardView1
                'myGridLevelNode2.RelationName = "ITEM DETAILS"


                '      GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
                '     GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {GridView1, GridView2, CardView1}) ' GridView3

                '    Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
                '     Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2, Me.CardView1})


                'CardView1.ViewCaption = "PO Details"
                'CardView1.PopulateColumns(dataset.Tables("ITEM DETAILS"))


                GridControl1.DataSource = dataset
                GridView1.Columns("RIS_No").VisibleIndex = -1



                Dim view As ColumnView = CType(GridControl1.FocusedView, ColumnView)
                Dim editingValue As String = Nothing
                If view IsNot Nothing And view.IsEditing Then
                    editingValue = view.EditingValue.ToString()
                End If


                Dim rowHandle As Integer = 0
                'Create the first detail by expanding a master row
                Dim gView As GridView = CType(GridControl1.MainView, GridView)
                gView.SetMasterRowExpanded(rowHandle, True)



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
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
                SQL += "  INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.SysPK AND supplier.supplier_type = 0"

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
                    SQL += " AND supplier.SysPK = '" & cmbSupplier.SelectedValue & "'"
                End If

                If cmbProcurement.Text <> "" And cmbProcurement.Text <> "-- ALL --" Then
                    SQL += " AND procurement_mode = '" & cmbProcurement.Text & "'"
                End If

                SQL += " ORDER BY `item_name` "

                Dim dt As New DataTable
                dt = DataSource(SQL)

                GridControl1.DataSource = dt
                DesigGRidView2(GridView1)
            Catch ex As Exception

            End Try
        End If



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
		                INNER JOIN supplier on ris_master.supplier_SysPK = supplier.SysPK AND supplier.supplier_type = 0

		                UNION

		                SELECT 0 AS 'id','-- ALL --' AS 'name'
                    )A
                ORDER BY `name`"
        Return DataSource(sql)
    End Function

    Dim Mode As String = ""



    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        LoadRISList()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        LoadRISList()
    End Sub

    Dim supplier_id As String = ""
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

    Dim RIS_NO As String = ""
    Dim Supplier As String = ""
    Dim FundClass_id As String = ""


    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim view As GridView = DirectCast(sender, GridView)

        If view.RowCount > 0 Then

            btnAdd.Visible = True
            btnEdit.Visible = True
            btnDelete.Visible = True

            If e.Column.FieldName = "attach_dir" Then
                Dim path = view.GetFocusedRowCellValue("attach_dir").ToString
                If path <> "" Then

                    If My.Computer.FileSystem.FileExists(path) Then
                        Process.Start(path)
                    Else
                        MsgBox("File does not exist", MsgBoxStyle.Critical, "FIL NOT FOUND")
                    End If

                End If

            Else

                RIS_NO = view.GetFocusedRowCellValue("RIS_No").ToString
                Supplier = view.GetFocusedRowCellValue("supplier_name").ToString
                supplier_id = view.GetFocusedRowCellValue("supplier_SysPK").ToString
                FundClass_id = view.GetFocusedRowCellValue("fund_class_id").ToString
            End If
        End If


    End Sub

    Private Sub GridView1_MasterRowExpanded(sender As Object, e As CustomMasterRowEventArgs) Handles GridView1.MasterRowExpanded
        Dim master As GridView = TryCast(sender, GridView)

        RIS_NO = master.GetFocusedRowCellValue("RIS_No").ToString

        Dim details As GridView = TryCast(master.GetDetailView(e.RowHandle, e.RelationIndex), GridView)
        Dim row = details.GetChildRowHandle(e.RowHandle, e.RelationIndex)

        details.OptionsBehavior.Editable = False
        details.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
        details.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False

        For i As Integer = 0 To details.Columns.Count - 1

            Select Case i
                Case 1
                    details.Columns(i).Caption = "ITEM CODE"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).Width = 100
                Case 2
                    details.Columns(i).Caption = "ITEM NAME"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    details.Columns(i).Width = 400
                Case 3
                    details.Columns(i).Caption = "UNIT"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).Width = 80
                Case 4
                    details.Columns(i).Caption = "QTY RECEIVED"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).Width = 100
                Case 5
                    details.Columns(i).Caption = "PRICE PER UNIT"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    details.Columns(i).DisplayFormat.FormatString = "###,###.00"
                    details.Columns(i).Width = 120
                Case 6
                    details.Columns(i).Caption = "TOTAL COST"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    details.Columns(i).DisplayFormat.FormatString = "###,###.00"
                    details.Columns(i).Width = 120
                Case 7
                    details.Columns(i).Caption = "QTY REMAINING"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).Width = 100
                Case 8
                    details.Columns(i).Caption = "EXPIRY DATE"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).DisplayFormat.FormatString = "MM/dd/yyyy"
                    details.Columns(i).Width = 120
                Case 9
                    details.Columns(i).Caption = "DOSAGE FORM"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).Width = 100
                Case 10
                    details.Columns(i).Caption = "BRAND NAME"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    details.Columns(i).Width = 130
                Case 11
                    details.Columns(i).Caption = "MANUFACTURER"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    details.Columns(i).Width = 130
                Case 12
                    details.Columns(i).Caption = "DELIVERY STATUS"
                    details.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    details.Columns(i).Width = 100
                Case Else
                    details.Columns(i).Visible = False
            End Select

        Next


    End Sub

    Private Sub PullOutItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PullOutItemToolStripMenuItem.Click


        Dim GETTRD_SYSPK As String = "Select TRD_SYSPK from transaction_day "
        GETTRD_SYSPK += " WHERE TransactionDay='" & Format(Date.Now, "yyyy-MM-dd") & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(GETTRD_SYSPK)

        If Not MeData.Rows.Count > 0 Then
            MsgBox("PLEASE CREATE TRANSACTION DAY FIRST BEFORE MAKING ITEM PULL-OUT OR DELIVERY.", MsgBoxStyle.Information)
            Exit Sub
        End If


        If REPLENISHFORM Is Nothing Then
            REPLENISHFORM = New fmaInventoryReplenishmentForm
            REPLENISHFORM.OPERATION = "EDIT"
        End If

        With REPLENISHFORM

            .txtInvSys.Text = RIS_Det_No
            .txtRIS_no.Text = RIS_NO
            .txta_code.Text = Item_code
            .txtconsignee_id.Text = supplier_id
            .txtconsignee.Text = Supplier
            .txta_name.Text = Item_name
            .txtRemStocks.Text = Item_qty_rm
            .txtFundClass_id.Text = FundClass_id
        End With

        REPLENISHFORM.Show()
        REPLENISHFORM.BringToFront()

    End Sub


    Dim Item_code As String = ""
    Dim Item_name As String = ""
    Dim Item_qty_rm As Integer
    Dim RIS_Det_No As String = ""

    Private Sub GridControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseUp

        Dim childView As GridView = Nothing
        Dim parentView As GridView = Nothing

        If GridControl1.FocusedView.IsDetailView = False Then
            Return
        Else
            childView = (TryCast(GridControl1.FocusedView, GridView))
        End If

        parentView = (TryCast(childView.ParentView, GridView))
        Dim ParentRowHandle As Integer = childView.GetParentRowHandle(childView.FocusedRowHandle)
        Dim parentRow As DataRow = parentView.GetDataRow(ParentRowHandle)

        childView.Appearance.FocusedRow.BackColor = Color.Navy
        childView.Appearance.FocusedRow.ForeColor = Color.White
        childView.Appearance.FocusedCell.BackColor = Color.Navy
        childView.Appearance.FocusedCell.ForeColor = Color.White
        childView.Appearance.SelectedRow.BackColor = Color.Navy
        childView.Appearance.SelectedRow.ForeColor = Color.White


        RIS_NO = childView.GetFocusedRowCellValue("RIS_No").ToString
        Item_code = childView.GetFocusedRowCellValue("a_code").ToString
        Item_name = childView.GetFocusedRowCellValue("inv_master_Name").ToString
        Item_qty_rm = childView.GetFocusedRowCellValue("qty_remaining").ToString
        RIS_Det_No = childView.GetFocusedRowCellValue("RIS_Det_No").ToString


    End Sub

    Private Sub SETUPFORM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles SETUPFORM.FormClosing
        SETUPFORM = Nothing
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click

        If CheckRISDetails(RIS_NO) Then
            Dim msgTitle As String = "Cannot delete RIS Master..."
            msgTitle += vbNewLine & "RIS Details need to be clear"
            MsgBox(msgTitle, MsgBoxStyle.Information)
            Exit Sub
        ElseIf MessageBox.Show("Are you sure you want to DELETE RIS MASTER?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            DataSource(String.Format("DELETE FROM ris_master WHERE RIS_No = '" & RIS_NO & "'"))
            MsgBox("RIS MASTER has been Deleted...!!!, Successfully.", MsgBoxStyle.Information, "DELETE RIS")
            '      LoadList()
            GridView1.OptionsBehavior.AutoExpandAllGroups = True

            LoadRISList()
        End If

    End Sub

    Private Function CheckRISDetails(rIS_NO As String) As Boolean
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT 	* FROM ris_details WHERE ris_details.RIS_Master_No = '" & rIS_NO & "'"))
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class