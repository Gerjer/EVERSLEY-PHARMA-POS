Public Class fmaReplinishmentListForm
    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "inventory_replenishment"

    Private WithEvents SETUPFORM As fmaReplinishmentSetupForm

#Region "Viewers Info"
    Private Sub Attach()


        tdbViewer.DataSource = Nothing
        Dim LimitValue As Integer = PgCount.Value


        Dim SQL As String = "SELECT inventory_replenishment.SysPK, SysPK_INVMaster,consignee, item_code,item_name,added_qty,pullout_qty,date_added,itemremarks,date_modified "
        SQL += " FROM " & TABLENAME
        SQL += " INNER JOIN inventory_master"
        SQL += " ON (inventory_replenishment.SysPK_INVMaster = inventory_master.SysPK)"
        SQL += " WHERE DATE(date_added) BETWEEN '" & Format(dateFrom.Value, "yyyy-MM-dd") & "'"
        SQL += " AND '" & Format(dateTo.Value, "yyyy-MM-dd") & "'"
        SQL += " ORDER BY item_name "
        'SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("SysPK").Visible = False
                .DisplayColumns("SysPK_INVMaster").Visible = False


                .DisplayColumns("consignee").DataColumn.Caption = "SUPPLIER"
                .DisplayColumns("consignee").Width = 200
                .DisplayColumns("consignee").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("consignee").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near



                .DisplayColumns("item_code").DataColumn.Caption = "CODE"
                .DisplayColumns("item_code").Width = 150
                .DisplayColumns("item_code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("item_name").DataColumn.Caption = "ITEM NAME"
                .DisplayColumns("item_name").Width = 350
                .DisplayColumns("item_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("added_qty").DataColumn.Caption = "ADDED"
                .DisplayColumns("added_qty").Width = 200
                .DisplayColumns("added_qty").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("added_qty").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("pullout_qty").DataColumn.Caption = "PULLED-OUT"
                .DisplayColumns("pullout_qty").Width = 200
                .DisplayColumns("pullout_qty").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("pullout_qty").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("date_added").DataColumn.Caption = "DATE"
                .DisplayColumns("date_added").Width = 100
                .DisplayColumns("date_added").DataColumn.NumberFormat = "MMMM dd, yyyy"
                .DisplayColumns("date_added").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("date_added").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("itemremarks").DataColumn.Caption = "REFERENCE"
                .DisplayColumns("itemremarks").Width = 200
                .DisplayColumns("itemremarks").DataColumn.NumberFormat = "MMMM dd, yyyy"
                .DisplayColumns("itemremarks").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("itemremarks").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("date_modified").Visible = False
            End With
        Catch ex As Exception

        End Try

        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "SELECT count(SysPK_INVMaster) as count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        End If


        MeData = Nothing

    End Sub
    Private Sub Detach()

    End Sub
#End Region

    Private Sub fmaDepartmentViewerListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Detach()
        RaiseEvent FORM_CLOSING()
    End Sub

    Private Sub fmaDepartmentViewerListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.dateFrom.Value = New Date(Date.Now.Year, Date.Now.Month, 1)
        Me.dateTo.Value = New Date(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.AddMonths(1).AddDays(-1).Day)

        Me.Attach()
    End Sub



    Private Sub GridToTextboxes()
        Try
            For Each iControl As Control In FormControls
                Try
                    iControl.Text = tdbViewer.Columns(iControl.Name.Replace("txt", "")).Text
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception

        End Try

        'Me.Close()
    End Sub


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaReplinishmentSetupForm
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



    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = tdbViewer.PointToClient(point1)
            CMenuStripOperations.Show(tdbViewer, pt)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            deleteSelectedItem()
        End If
    End Sub

    Private Sub deleteSelectedItem()

        Dim ITEMSYSPK As String = ""

        Try
            ITEMSYSPK = tdbViewer.Columns.Item(0).Value
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
            SETUPFORM = New fmaReplinishmentSetupForm
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()



    End Sub

    Private Sub DeleteSelectedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaReplinishmentSetupForm
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            deleteSelectedItem()
        End If
    End Sub

    Private Sub dateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged
        dateFrom.Value = New Date(dateFrom.Value.Year, dateFrom.Value.Month, 1)
        Me.dateTo.Value = New Date(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.AddMonths(1).AddDays(-1).Day)

        Detach()
        Attach()
    End Sub

    Private Sub dateTo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTo.ValueChanged
        Try
            Detach()
            Attach()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        fmaInventoryMasterListForm.MdiParent = ftmdiMainForm
        fmaInventoryMasterListForm.Show()
        fmaInventoryMasterListForm.BringToFront()
    End Sub

    Private Sub tdbViewer_MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = tdbViewer.PointToClient(point1)
            CMenuStripOperations.Show(tdbViewer, pt)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True
        End If
    End Sub
End Class