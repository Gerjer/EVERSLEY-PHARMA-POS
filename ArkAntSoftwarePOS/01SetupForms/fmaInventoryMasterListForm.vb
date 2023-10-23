Imports C1.Win.C1TrueDBGrid
Imports DevExpress.Compatibility
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class fmaInventoryMasterListForm
    Public FormControls As Collection
    Dim MeData As New DataTable
    Dim RECORDCOUNTER As Integer = 0

    Public Event FetchScrollTips As FetchScrollTipsEventHandler

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "inventory_master"

    Private WithEvents SETUPFORM As fmaInventoryMasterSetupForm
    Private WithEvents REPLENISHFORM As fmaInventoryReplenishmentForm = Nothing

#Region "Viewers Info"
    Private Sub Attach()



        Dim LimitValue As Integer = PgCount.Value
#Region "OLD"
        'Dim SQL As String = "SELECT SysPK, date_created,inventory_master.a_code,inventory_master.a_name,uom,Format(selling_price,2)'selling_price',remaining_qty,storage_requirement,"
        'SQL += " method,method_id,generic_name,brand_name,manufacturer,indication,drug_interaction,item_reordercount, CASE WHEN is_deleted= 0 THEN 'ACTIVE'"
        'SQL += " ELSE 'IN-ACTIVE'"
        'SQL += " END AS 'is_deleted'"
        'SQL += " ,consignee,consignee_id"

        'SQL += " FROM " & TABLENAME
        'SQL += " left JOIN daily_inventory_details ON inventory_master.a_code = daily_inventory_details.a_code"
        'SQL += " AND daily_inventory_details.TRD_Date = '" & Format(Date.Now, "yyyy-MM-dd") & "'"
        'SQL += " ORDER BY date_created, remaining_qty DESC,a_name"
#End Region

        Dim SQL As String = ""
        SQL = "SELECT SysPK,date_created,expiry_date,inventory_master.a_code,inventory_master.a_name,uom"
        SQL += " ,IFNULL(selling_price,0)'selling_price',SUM(IFNULL(qty_remaining,0)) 'remaining_qty'"
        SQL += " ,IFNULL(storage_requirement,'') 'storage_requirement',method,method_id"
        SQL += " ,IFNULL(generic_name,'')'generic_name',IFNULL(brand_name,'')'brand_name'"
        SQL += " ,IFNULL(manufacturer,'')'manufacturer',IFNULL(indication,'')'indication'"
        SQL += " ,IFNULL(drug_interaction,'')'drug_interaction',IFNULL(item_reordercount,'')'item_reordercount'"
        SQL += " ,CASE WHEN is_deleted = 0 THEN 'ACTIVE' ELSE 'IN-ACTIVE' END AS 'is_deleted'"
        SQL += " ,consignee,consignee_id"
        SQL += " FROM inventory_master"
        If chkRISItem.Checked = True And chkAllItem.Checked = False And chkExpiryDate.Checked = False Then
            SQL += " INNER JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK"
            SQL += " WHERE ris_details.expiry_date >= '" & Format(Date.Now, "yyyy-MM-dd") & "'"
        ElseIf chkRISItem.Checked = True And chkAllItem.Checked = True And chkExpiryDate.Checked = False Then
            SQL += " LEFT JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK"
            SQL += " WHERE ris_details.expiry_date >= '" & Format(Date.Now, "yyyy-MM-dd") & "'"
        ElseIf chkRISItem.Checked = False And chkAllItem.Checked = True And chkExpiryDate.Checked = False Then
            SQL += " LEFT JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK AND qty_remaining = 0"
            SQL += " WHERE ris_details.expiry_date >= '" & Format(Date.Now, "yyyy-MM-dd") & "'"
        ElseIf chkRISItem.Checked = True And chkAllItem.Checked = False And chkExpiryDate.Checked = True Then
            SQL += " INNER JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK"
        ElseIf chkRISItem.Checked = True And chkAllItem.Checked = True And chkExpiryDate.Checked = True Then
            SQL += " LEFT JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK"
        ElseIf chkRISItem.Checked = False And chkAllItem.Checked = True And chkExpiryDate.Checked = True Then
            SQL += " LEFT JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK AND qty_remaining = 0"
        ElseIf chkRISItem.Checked = False And chkAllItem.Checked = False And chkExpiryDate.Checked = True Then
            SQL += " LEFT JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK"
            SQL += " WHERE ris_details.expiry_date < '" & Format(Date.Now, "yyyy-MM-dd") & "'"
        Else
            SQL += " INNER JOIN ris_details ON inventory_master.a_code = ris_details.inv_master_SysPK AND qty_remaining IS NULL"
        End If

        SQL += " GROUP BY a_code,price"
        SQL += " ORDER BY a_name,date_created"
        If CheckBoxShowALl.Checked = False Then
            SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)
        End If

        MeData = clsDBConn.ExecQuery(SQL)

        GridControl1.DataSource = MeData
        DesignGridView(GridView1)



        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "Select count(SysPK) As count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & GridView1.RowCount & " Of " & MeData.Rows(0).Item("count").ToString
            RECORDCOUNTER = CInt(MeData.Rows(0).Item("count").ToString)
        End If


        MeData = Nothing

    End Sub

    Private Sub DesignGridView(gridView1 As GridView)

        'Dim SQL As String = "Select SysPK, date_created,inventory_master.a_code,inventory_master.a_name,uom,Format(selling_price,2)'selling_price',remaining_qty,storage_requirement,"
        'SQL += " method,method_id,generic_name,brand_name,manufacturer,indication,drug_interaction,item_reordercount, CASE WHEN is_deleted= 0 THEN 'ACTIVE'"
        'SQL += " ELSE 'IN-ACTIVE'"
        'SQL += " END AS 'is_deleted'"
        'SQL += " ,consignee,consignee_id"

        Dim view As GridView = gridView1

        For i As Integer = 0 To view.Columns.Count - 1
            Select Case i

                Case 1
                    view.Columns(i).Caption = "ENTRY DATE"
                    view.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    view.Columns(i).DisplayFormat.FormatString = "yyyy-MM-dd hh:mm tt"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()
                Case 2
                    view.Columns(i).Caption = "EXPIRY DATE"
                    view.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    view.Columns(i).DisplayFormat.FormatString = "yyyy-MM-dd hh:mm tt"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()

                Case 3
                    view.Columns(i).Caption = "ITEM CODE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()
                Case 4
                    view.Columns(i).Caption = "GENERIC NAME OF MEDICINE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).BestFit()
                Case 5
                    view.Columns(i).Caption = "UNITS"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()
                Case 6
                    view.Columns(i).Caption = "SELLING PRICE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far
                    view.Columns(i).BestFit()
                Case 7
                    view.Columns(i).Caption = "BALANCE QTY"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()
                Case 8
                    view.Columns(i).Caption = "STORAGE REQUIRED"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).BestFit()
                Case 9
                    view.Columns(i).Caption = "DOSAGE FORM"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()
                Case 12
                    view.Columns(i).Caption = "BRAND NAME"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).BestFit()
                Case 13
                    view.Columns(i).Caption = "MANUFACTURER"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).BestFit()
                Case 14
                    view.Columns(i).Caption = "INDICATION"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).Width = 150
                Case 15
                    view.Columns(i).Caption = "INTERACTION"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).Width = 200
                Case 16
                    view.Columns(i).Caption = "RE-ORDER LEVEL"
                    view.Columns(i).DisplayFormat.FormatString = "n2"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()
                Case 17
                    view.Columns(i).Caption = "STATUS"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).BestFit()
                Case 18
                    view.Columns(i).Caption = "ITEM DESCRIPTION"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).BestFit()
                Case Else
                    view.Columns(i).Visible = False
            End Select
        Next

    End Sub


#End Region

    Private Sub fmaDepartmentViewerListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Detach()
        RaiseEvent FORM_CLOSING()
    End Sub


    '  Dim INTERACTION As C1.Win.C1TrueDBGrid.C1DataColumn

    Private Sub fmaDepartmentViewerListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkRISItem.Checked = True
        Me.Attach()

        '    INTERACTION = GridView1.Columns("INTERACTION").Caption

    End Sub


    Private Sub GridToTextboxes()
        For Each iControl As Control In FormControls
            Try
                iControl.Text = GridView1.GetFocusedRowCellDisplayText(iControl.Name.Replace("txt", "")).ToString
            Catch ex As Exception
            End Try
        Next
        'Me.Close()
    End Sub


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaInventoryMasterSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()
    End Sub

    Private Sub SETUPFORM_DB_MODIFIED() Handles SETUPFORM.DB_MODIFIED
        Attach()
    End Sub

    Private Sub SETUPFORM_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles SETUPFORM.Deactivate
        SETUPFORM.Show()
        SETUPFORM.BringToFront()
    End Sub


    Private Sub SETUPFORM_SETUP_CLOSED() Handles SETUPFORM.SETUP_CLOSED
        SETUPFORM = Nothing
    End Sub

    Private Sub PgCount_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PgCount.ValueChanged
        Attach()
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click

        txtFrom.Text = CInt(txtFrom.Text) + 10
        txtTo.Text = CInt(txtFrom.Text) + 10

    End Sub

    'Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Dim point1 As Point

    '    If e.Button = Windows.Forms.MouseButtons.Right Then

    '        point1 = Windows.Forms.Cursor.Position

    '        Dim pt As Point = tdbViewer.PointToClient(point1)
    '        CMenuStripOperations.Show(tdbViewer, pt)
    '    End If
    '    If e.Button = Windows.Forms.MouseButtons.Left Then

    '        btnDelete.Visible = True
    '        btnEdit.Visible = True

    '        Dim col As Integer = tdbViewer.DestinationCol
    '        Dim row As Integer = tdbViewer.Row

    '        If col = 13 Or col = 14 Then

    '            Dim frm As New fmaItemViewDiscription
    '            frm.Tag = 2
    '            frm.txtcode.Text = tdbViewer(row, "a_code").ToString
    '            frm.txtname.Text = tdbViewer(row, "a_name").ToString
    '            frm.txtuom.Text = tdbViewer(row, "uom").ToString
    '            frm.txtbrand_name.Text = tdbViewer(row, "brand_name").ToString
    '            frm.txtmanufacturer.Text = tdbViewer(row, "manufacturer").ToString
    '            frm.indication = tdbViewer(row, "indication").ToString
    '            frm.interaction = tdbViewer(row, "drug_interaction").ToString
    '            frm.BringToFront()
    '            frm.ShowDialog()

    '            If frm.DialogResult = DialogResult.OK Then

    '                Attach()

    '            End If
    '        End If

    '    End If

    'End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            deleteSelectedItem()
        End If
    End Sub

    Private Sub deleteSelectedItem()

        Dim ITEMSYSPK As String = ""

        Try
            ITEMSYSPK = SysPK
        Catch ex As Exception

        End Try

        If ITEMSYSPK <> "" Then
            Dim DELETESTR As String = "DELETE FROM " & TABLENAME
            DELETESTR += " WHERE SysPK='" & ITEMSYSPK & "'"

            If clsDBConn.Execute(DELETESTR) Then
                MsgBox("ITEM HAS BEEN DELETED", MsgBoxStyle.Information)
                Attach()
            End If
        End If


    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaInventoryMasterSetupForm
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim SQLEX As String = "SELECT A.a_code, B.Item_Display, A.item_unit, A.item_buyprice, A.item_price, A.inv_qty, A.item_reordercount"
        SQLEX += " FROM  inventory_master AS A"
        SQLEX += " inner JOIN product_item B "
        SQLEX += " ON (A.a_code = B.Item_Code)"
        SQLEX += " GROUP BY a_code"
        SQLEX += " ORDER BY B.Item_Display"


        Dim new_report As New fzzReportViewerForm
        Dim datefrom As String = Format(Date.Now, "yyyy-MM-dd")
        Dim dateto As String = Format(Date.Now, "yyyy-MM-dd")

        Me.Cursor = Cursors.WaitCursor
        Try
            new_report.AttachReport(SQLEX, "Inventory Report") = New rpt_ActualInventoryReport(datefrom, dateto)
            new_report.Show()

        Catch ex As Exception

        End Try

        Me.Cursor = Cursors.Default
        'MsgBox("Please Close Drawer.")
    End Sub



    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            deleteSelectedItem()
        End If
    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSelectedToolStripMenuItem.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaInventoryMasterSetupForm
            SETUPFORM.OPERATION = "EDIT"
        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()
    End Sub

    Private Sub ReplinishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplinishToolStripMenuItem.Click

        Dim GETTRD_SYSPK As String = "SELECT TRD_SYSPK from transaction_day "
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
            'SELECT SysPK,a_code,a_name, consignee, medtype, inv_qty, item_unit, item_buyprice, item_price,item_location, item_discount, item_reordercount 
            '.txtInvSys.Text = tdbViewer.Columns.Item("SysPK").Value
            '.txta_code.Text = tdbViewer.Columns.Item("a_code").Value
            '.txtconsignee.Text = tdbViewer.Columns.Item("consignee").Value
            '.txta_name.Text = tdbViewer.Columns.Item("a_name").Value
            '.txtRemStocks.Text = tdbViewer.Columns.Item("inv_qty").Value
        End With

        REPLENISHFORM.Show()
        REPLENISHFORM.BringToFront()
    End Sub

    Private Sub REPLENISHFORM_SETUP_CLOSED() Handles REPLENISHFORM.SETUP_CLOSED
        REPLENISHFORM = Nothing
        Attach()
    End Sub

    Private Sub CheckBoxShowALl_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxShowALl.CheckStateChanged
        Attach()
    End Sub

    Private Sub GridControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = GridControl1.PointToClient(point1)
            CMenuStripOperations.Show(GridControl1, pt)
        End If
    End Sub

    Dim SysPK As Object
    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim view As GridView = DirectCast(sender, GridView)

        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True

            Dim col As Integer = e.Column.ColumnHandle 'tdbViewer.DestinationCol
            Dim row As Integer = e.RowHandle

            SysPK = view.GetRowCellValue(row, view.Columns("SysPK").FieldName)

            If col = 12 Or col = 13 Then

                Dim frm As New fmaItemViewDiscription
                frm.Tag = 2
                frm.txtcode.Text = GridView1.GetFocusedRowCellValue("a_code").ToString   'tdbViewer(row, "a_code").ToString
                frm.txtname.Text = GridView1.GetFocusedRowCellValue("a_name").ToString
                frm.txtuom.Text = GridView1.GetFocusedRowCellValue("uom").ToString 'tdbViewer(row, "uom").ToString
                frm.txtbrand_name.Text = If(IsDBNull(GridView1.GetFocusedRowCellValue("brand_name").ToString), "", GridView1.GetFocusedRowCellValue("brand_name").ToString) 'tdbViewer(row, "brand_name").ToString
                frm.txtmanufacturer.Text = If(IsDBNull(GridView1.GetFocusedRowCellValue("manufacturer").ToString), "", GridView1.GetFocusedRowCellValue("manufacturer").ToString) 'tdbViewer(row, "manufacturer").ToString
                frm.indication = If(IsDBNull(GridView1.GetFocusedRowCellValue("indication").ToString), "", GridView1.GetFocusedRowCellValue("indication").ToString) 'tdbViewer(row, "indication").ToString
                frm.interaction = If(IsDBNull(GridView1.GetFocusedRowCellValue("drug_interaction").ToString), "", GridView1.GetFocusedRowCellValue("drug_interaction").ToString) ' tdbViewer(row, "drug_interaction").ToString
                frm.BringToFront()
                frm.ShowDialog()

                If frm.DialogResult = DialogResult.OK Then

                    Attach()

                End If
            End If

        End If
    End Sub

    Private Sub chkRISItem_CheckStateChanged(sender As Object, e As EventArgs) Handles chkRISItem.CheckStateChanged
        Attach()
    End Sub

    Private Sub chkExpiryDate_CheckStateChanged(sender As Object, e As EventArgs) Handles chkExpiryDate.CheckStateChanged
        Attach()
    End Sub

    Private Sub chkAllItem_CheckStateChanged(sender As Object, e As EventArgs) Handles chkAllItem.CheckStateChanged
        Attach()
    End Sub
End Class