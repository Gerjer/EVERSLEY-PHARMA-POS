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
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevComponents.DotNetBar

Public Class fmaItemIssuanceList

    Public Event ITEM_SELECTED()
    Public Event WIN_CLOSED()

    Private WithEvents SETUPFORM As fmaInventoryMasterSetupForm



    Private Sub fmaItemIssuanceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        GridControl1.LookAndFeel.SetSkinStyle("Dark Side")

        If ITEM_LIST IsNot Nothing Then
            GridControl1.DataSource = ITEM_LIST
        Else
            loadList()
        End If

        '     GridView1.BestFitColumns()

        Me.txtSearchKey.TextAlign = HorizontalAlignment.Center
        Me.txtSearchKey.Focus()
        Me.txtSearchKey.SelectAll()

        GridView1.Appearance.HeaderPanel.ForeColor = Color.Snow
        GridView1.Appearance.HeaderPanel.BorderColor = Color.Cyan
        GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True

        GridView1.OptionsSelection.EnableAppearanceFocusedCell = True
        GridView1.OptionsSelection.EnableAppearanceFocusedRow = True
        GridView1.OptionsSelection.EnableAppearanceHideSelection = False

        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim ActivateUpDown As Boolean = My.Settings.ActivateUpDownArrow
        If ActivateUpDown = True Then
            Panel7.Visible = True
        Else
            Panel7.Visible = False
        End If

        'For Each column As GridColumn In GridView1.Columns
        '    column.OptionsColumn.AllowFocus = False
        'Next

    End Sub

    Private Sub fmaItemIssuanceList_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        RaiseEvent WIN_CLOSED()

    End Sub


    Private Sub loadList()

        Dim SQL As String = "SELECT ris_details.RIS_Det_No, inventory_master.a_code"
        SQL += " , inventory_master.a_name, inventory_master.method"
        SQL += " , Format(ris_details.price,2) 'buy_price'"
        SQL += " , inventory_master.selling_price"
        SQL += " , ris_details.qty_received"
        SQL += " , ris_details.qty_remaining"
        SQL += " , CAST(Date_Format(ris_details.expiry_date,'%m/%d/%Y') AS Char) 'expiry_date'"
        SQL += " , ris_details.location"
        SQL += " , ris_master.RIS_No"
        SQL += " , CAST(Date_Format(ris_master.date_received,'%m/%d/%Y') AS Char) 'date_received'"
        SQL += " , ris_master.po_no"
        SQL += " , ris_master.si_no"
        SQL += " , ris_master.supplier"
        SQL += " , ris_master.fund_cluster"
        SQL += " , ris_master.received_by"
        '      SQL += " , FORMAT((DATEDIFF(ris_details.expiry_date,date_format(NOW(),'%Y-%m-%d'))/30),0) 'calculated_months'"
        SQL += " , TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date)'cnt_days'"
        SQL += " , CASE WHEN TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date) >= 1 
	                         AND TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date) <= 155 THEN 1
            			 WHEN TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date) >= 156
		     	             AND TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date) <= 341 THEN 2
		                 WHEN TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date) >= 342
						    AND TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date) <= 496 THEN 3
			             WHEN TIMESTAMPDIFF(DAY,date_format(NOW(),'%Y-%m-%d'),ris_details.expiry_date) >= 497 THEN 4
			                 ELSE 5 END AS 'calculated_months'"

        SQL += " , CAST(Date_Format(ris_master.po_date,'%m/%d/%Y') AS Char) 'po_date'"
        SQL += " , ris_master.procurement_mode"
        SQL += " , inventory_master.manufacturer"
        SQL += " , inventory_master.brand_name"
        SQL += " , inventory_master.indication"
        SQL += " , inventory_master.drug_interaction"
        SQL += " , (SELECT IFNULL(class_based.`name`,'') FROM medtype INNER JOIN	class_based ON medtype.class_based_id = class_based.id WHERE medtype.SysPK_Item = inventory_master.method_id)'class_based'"
        SQL += " , inventory_master.storage_requirement,inventory_master.uom,delivery_status,ris_master.fund_class,IFNULL(inventory_master.item_reordercount,0)'item_reordercount'  "
        SQL += " FROM inventory_master"
        SQL += " INNER JOIN ris_details "
        SQL += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
        SQL += " INNER JOIN ris_master "
        SQL += " ON (ris_details.RIS_Master_No = ris_master.RIS_No)"
        'SQL += " INNER JOIN daily_inventory_details "
        'SQL += " ON ( ris_details.inv_master_SysPK = daily_inventory_details.a_code)"

        SQL += " WHERE qty_remaining > 0 ORDER BY calculated_months,expiry_date, a_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQL)

        '        GridControl1.DataSource = Nothing
        GridControl1.DataSource = MeData

    End Sub

    Private Sub txtSearchKey_TextChanged(sender As Object, e As EventArgs) Handles txtSearchKey.TextChanged

        Me.txtSearchKey.TextAlign = HorizontalAlignment.Left
        GridView1.FindFilterText = txtSearchKey.Text


    End Sub

    Private Sub txtSearchKey_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchKey.KeyUp

        Dim bHandled As Boolean = False
        Select Case e.KeyCode
            Case Keys.Up
                'do stuff
                e.Handled = True
                GridView1.MovePrev()
            Case Keys.Down
                'do other stuff
                e.Handled = True
                GridView1.MoveNext()
        End Select


    End Sub


    Private Sub txtSearchKey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchKey.KeyDown
        If e.KeyCode = Keys.Enter Then
            '           Dim currentRow As Integer = GridView1.GetSelectedRows()

       '     Qty_remaining = GridView1.GetRowCellValue(0, "qty_remaining")
            CheckItem()
            '         RaiseEvent ITEM_SELECTED()
            '  Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GridControl1_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles GridControl1.ProcessGridKey
        Dim view As ColumnView = TryCast(TryCast(sender, GridControl).FocusedView, ColumnView)
        If view Is Nothing Then
            Return
        End If
        If e.KeyCode = Keys.Up AndAlso e.Control AndAlso view.Editable AndAlso view.SelectedRowsCount > 0 Then
            view.MovePrev()
        ElseIf e.KeyCode = Keys.Down AndAlso e.Control AndAlso view.Editable AndAlso view.SelectedRowsCount > 0 Then
            view.MoveNext()

        ElseIf e.KeyCode = Keys.Right AndAlso e.Control AndAlso view.Editable AndAlso view.SelectedRowsCount > 0 Then
            view.MoveLast()

        ElseIf e.KeyCode = Keys.Left AndAlso e.Control AndAlso view.Editable AndAlso view.SelectedRowsCount > 0 Then
            view.MoveFirst()

            If view.ActiveEditor IsNot Nothing Then
                Return
            End If
            e.Handled = True
        Else

            Dim disallowedKeys As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
            Dim disallowdKesyNumber As String = "0123456789"
            Dim disallowOperator As String = "-+/*"
            If Boolean.Parse(disallowedKeys.Contains(e.KeyCode.ToString)) Then
                e.SuppressKeyPress = True
                Dim length = txtSearchKey.TextLength
                txtSearchKey.SelectionStart = length + 1
                txtSearchKey.Focus()
            ElseIf Boolean.Parse(disallowdKesyNumber.Contains(e.KeyCode.ToString)) Then
                e.SuppressKeyPress = True
                Dim length = txtSearchKey.TextLength
                txtSearchKey.SelectionStart = length + 1
                txtSearchKey.Focus()
            ElseIf Boolean.Parse(disallowOperator.Contains(e.KeyCode.ToString)) Then
                e.SuppressKeyPress = True
                Dim length = txtSearchKey.TextLength
                txtSearchKey.SelectionStart = length + 1
                txtSearchKey.Focus()
            ElseIf e.KeyCode = Keys.Back AndAlso e.KeyCode = Keys.Delete Then
                e.SuppressKeyPress = True
                Dim length = txtSearchKey.TextLength
                txtSearchKey.SelectionStart = length - 1
                txtSearchKey.Focus()
            End If

        End If
    End Sub



    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown

        Dim view As GridView = DirectCast(sender, GridView)

        If e.KeyData = Keys.Left Then view.LeftCoord -= view.HorzScrollStep
        If e.KeyData = Keys.Right Then view.LeftCoord += view.HorzScrollStep

    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle

        Dim view As GridView = TryCast(sender, GridView)

        If e.RowHandle >= 0 Then
            Dim CalMonths = CType(view.GetRowCellValue(e.RowHandle, "calculated_months"), Integer)

            If CheckBox1.Checked = True Then

                Select Case CalMonths
                    Case 1
                        e.Appearance.ForeColor = Color.LightSalmon
                    Case 2
                        e.Appearance.ForeColor = Color.FromArgb(255, 255, 128)
                    Case 3
                        e.Appearance.ForeColor = Color.LightGreen
                    Case 4
                        e.Appearance.ForeColor = Color.Snow
                    Case Else
                        e.Appearance.ForeColor = Color.Black
                End Select


            End If


        Else

            e.Appearance.BackColor = Nothing

        End If

    End Sub

    Private Sub GridView1_CalcRowHeight(sender As Object, e As RowHeightEventArgs) Handles GridView1.CalcRowHeight
        e.RowHeight = 30
    End Sub



    Private Sub GridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles GridView1.KeyUp

        Dim view As GridView = DirectCast(sender, GridView)
        If e.KeyCode = Keys.Enter Then

            CheckItem()
            '       Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F2 Then
            Me.txtSearchKey.Focus()
        End If

    End Sub


    Private Sub CheckItem()


        If expiry_cheking > 0 Then

            Qty_remaining = GridView1.GetFocusedRowCellValue("qty_remaining")

            If Qty_remaining >= txtQty.Text Then

                If Qty_remaining = 0 And txtQty.Text = 0 Then
                    MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                            "Inventory Count is Low." & vbNewLine &
                            "Press [ESC] To Cancel", MessageBoxIcon.Warning, "OUT OF STOCK")
                    Exit Sub
                End If

                Qty_remaining = Qty_remaining - txtQty.Text

                    GridView1.SetRowCellValue(row_handle, "qty_remaining", Qty_remaining)


                    ITEM_LIST = GridControl1.DataSource

                    RaiseEvent ITEM_SELECTED()

                Else

                    MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                                "Inventory Count is Low." & vbNewLine &
                                "Press [ESC] To Cancel", MessageBoxIcon.Warning, "OUT OF STOCK")
                Exit Sub
            End If


            'Me.Close()
        Else

            MsgBox("Please Check the EXPIRY DATE for this Item" & vbNewLine &
                           "Press [ESC] To Cancel", MessageBoxIcon.Warning, "EXPIRED ITEM")
            Exit Sub
        End If




    End Sub

    Public Qty_remaining As Integer
    Dim expiry_cheking As Integer
    Dim row_handle As Integer
    Dim SetColumnView As ColumnView
    Dim focusView As New GridView

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        Dim row = e.FocusedRowHandle
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = True
        GridView1.OptionsSelection.EnableAppearanceFocusedRow = True
        GridView1.OptionsSelection.EnableAppearanceHideSelection = False

        Dim view As GridView = DirectCast(sender, GridView)

        If view.IsEmpty Then
            Exit Sub
        End If

        'If view.IsCellSelect = False Then
        '    Exit Sub
        'End If

        Qty_remaining = view.GetFocusedRowCellValue("qty_remaining").ToString
        expiry_cheking = view.GetFocusedRowCellValue("cnt_days").ToString
        row_handle = e.FocusedRowHandle

        'REFERENCES
        txtDateReceived.Text = view.GetFocusedRowCellValue("date_received").ToString
        txtRisno.Text = view.GetFocusedRowCellValue("RIS_No").ToString
        txtPODate.Text = view.GetFocusedRowCellValue("po_date").ToString
        txtPONo.Text = view.GetFocusedRowCellValue("po_no").ToString
        txtSiNo.Text = view.GetFocusedRowCellValue("si_no").ToString
        txtSupplier.Text = view.GetFocusedRowCellValue("supplier").ToString
        txtBuyingPrice.Text = view.GetFocusedRowCellValue("buy_price").ToString
        txtMode.Text = If(IsDBNull(view.GetFocusedRowCellValue("procurement_mode").ToString), "", view.GetFocusedRowCellValue("procurement_mode").ToString)
        txtCluster.Text = If(IsDBNull(view.GetFocusedRowCellValue("fund_cluster").ToString), "", view.GetFocusedRowCellValue("fund_cluster").ToString)
        txtClass.Text = If(IsDBNull(view.GetFocusedRowCellValue("fund_class").ToString), "", view.GetFocusedRowCellValue("fund_class").ToString)

        'MEDICINE DETAILS
        txtExpiryDate.Text = view.GetFocusedRowCellValue("expiry_date").ToString
        txtBrandName.Text = If(IsDBNull(view.GetFocusedRowCellValue("brand_name").ToString), "", view.GetFocusedRowCellValue("brand_name").ToString)
        txtManufacturer.Text = If(IsDBNull(view.GetFocusedRowCellValue("manufacturer").ToString), "", view.GetFocusedRowCellValue("manufacturer").ToString)
        txtDosageForm.Text = If(IsDBNull(view.GetFocusedRowCellValue("method").ToString), "", view.GetFocusedRowCellValue("method").ToString)
        txtClassBased.Text = If(IsDBNull(view.GetFocusedRowCellValue("class_based").ToString), "", view.GetFocusedRowCellValue("class_based").ToString)
        txtStorageLoc.Text = If(IsDBNull(view.GetFocusedRowCellValue("location").ToString), "", view.GetFocusedRowCellValue("location").ToString)
        txtStorageReq.Text = If(IsDBNull(view.GetFocusedRowCellValue("storage_requirement").ToString), "", view.GetFocusedRowCellValue("storage_requirement").ToString)
        txtDeliverStatus.Text = If(IsDBNull(view.GetFocusedRowCellValue("delivery_status").ToString), "", view.GetFocusedRowCellValue("delivery_status").ToString)
        txtReOrderPoint.Text = If(IsDBNull(view.GetFocusedRowCellValue("item_reordercount").ToString), 0, view.GetFocusedRowCellValue("item_reordercount").ToString)
        If txtReOrderPoint.Text <> "" Then
            txtReOrderPoint.Text = FormatNumber(txtReOrderPoint.Text, 0).ToLower & " % "
        End If
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles btnQty.Click
        txtQty.Focus()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnescape.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        CheckItem()
        '     RaiseEvent ITEM_SELECTED()
        '   Me.Close()
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQty.KeyUp
        Dim bHandled As Boolean = False
        Select Case e.KeyCode
            Case Keys.Up
                'do stuff
                e.Handled = True
                GridView1.MovePrev()

            Case Keys.Down
                'do other stuff
                e.Handled = True
                GridView1.MoveNext()

        End Select
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            CheckItem()
            '        RaiseEvent ITEM_SELECTED()
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Up Then
            e.Handled = True
            GridView1.MovePrev()
        ElseIf e.KeyCode = Keys.Down Then
            e.Handled = True
            GridView1.MoveNext()
        End If
    End Sub


    Public Sub expanded(Expand As DevComponents.DotNetBar.ExpandablePanel)
        If Expand.Expanded = False Then
            Expand.Expanded = True
        Else
            Expand.Expanded = False
        End If

    End Sub

    Private Sub btnExpand_Click(sender As Object, e As EventArgs) Handles btnExpand.Click
        expanded(expReasonChange)
    End Sub

    Private Sub ButtonX10_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        txtSearchKey.Focus()
        txtSearchKey.SelectAll()

    End Sub

    Private Sub setMouseHoverColor(btn As ButtonX)
        btn.ForeColor = Color.Black
    End Sub
    Private Sub setMouseLeaveColor(btn As ButtonX)
        btn.ForeColor = Color.Cyan
    End Sub

    Private Sub btnSelect_MouseHover(sender As Object, e As EventArgs) Handles btnSelect.MouseHover
        setMouseHoverColor(btnSelect)
    End Sub

    Private Sub btnSelect_MouseLeave(sender As Object, e As EventArgs) Handles btnSelect.MouseLeave
        setMouseLeaveColor(btnSelect)
    End Sub

    Private Sub btnSearch_MouseHover(sender As Object, e As EventArgs) Handles btnSearch.MouseHover
        setMouseHoverColor(btnSearch)
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        setMouseLeaveColor(btnSearch)
    End Sub

    Private Sub btnQty_MouseHover(sender As Object, e As EventArgs) Handles btnQty.MouseHover
        setMouseHoverColor(btnQty)
    End Sub

    Private Sub btnQty_MouseLeave(sender As Object, e As EventArgs) Handles btnQty.MouseLeave
        setMouseLeaveColor(btnQty)
    End Sub

    Private Sub btnExpand_MouseHover(sender As Object, e As EventArgs) Handles btnExpand.MouseHover
        setMouseHoverColor(btnExpand)
    End Sub

    Private Sub btnExpand_MouseLeave(sender As Object, e As EventArgs) Handles btnExpand.MouseLeave
        setMouseLeaveColor(btnExpand)
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        GridView1.MovePrev()
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        GridView1.MoveNext()
    End Sub

    Private Sub btnUpDown_Click(sender As Object, e As EventArgs) Handles btnUpDown.Click
        If Panel7.Visible = False Then
            Panel7.Visible = True
            My.Settings.ActivateUpDownArrow = True
            My.Settings.Save()
        Else
            Panel7.Visible = False
            My.Settings.ActivateUpDownArrow = False
            My.Settings.Save()
        End If
    End Sub
End Class