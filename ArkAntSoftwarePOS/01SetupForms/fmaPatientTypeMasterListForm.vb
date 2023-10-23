Imports DevExpress.XtraGrid.Views.Grid

Public Class fmaPatientTypeMasterListForm
    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "patient_type"

    Private WithEvents SETUPFORM As fmaPatientTypeMasterSetupForm

#Region "Viewers Info"
    Private Sub Attach()


        tdbViewer.DataSource = Nothing
        Dim LimitValue As Integer = PgCount.Value


        Dim SQL As String = "SELECT SysPK,a_code,a_name, payment_type, patient_type,CASE WHEN `status` = 1 then 'ACTIVE' ELSE 'INACTIVE' END AS 'status'"
        SQL += " FROM " & TABLENAME
        SQL += " ORDER BY patient_type"
        SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        GridControl1.DataSource = MeData
        DesignGridview(GridView1)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("SysPK").Visible = False
                '.DisplayColumns("a_code").Visible = False

                .DisplayColumns("a_code").DataColumn.Caption = "CODE"
                .DisplayColumns("a_code").Width = 100
                .DisplayColumns("a_code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("a_name").DataColumn.Caption = "DESCRIPTION"
                .DisplayColumns("a_name").Width = 200
                .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("payment_type").DataColumn.Caption = "PAYMENT TYPE"
                .DisplayColumns("payment_type").Width = 100
                .DisplayColumns("payment_type").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("payment_type").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("patient_type").Visible = False

                .DisplayColumns("status").DataColumn.Caption = "STATUS"
                .DisplayColumns("status").Width = 100
                .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center


            End With
        Catch ex As Exception

        End Try

        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "SELECT count(SysPK) as count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        End If


        MeData = Nothing
        Me.txtFilterText.Text = ""
    End Sub

    Private Sub DesignGridview(gridView1 As GridView)
        Dim view As GridView = gridView1

        For i As Integer = 0 To view.Columns.Count - 1
            Select Case i
                Case 1
                    view.Columns(i).Caption = "CODE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 2
                    view.Columns(i).Caption = "DESCRIPTION"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case 3
                    view.Columns(i).Caption = "PAYMENT TYPE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case 4
                    view.Columns(i).Caption = "STATUS"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case Else
                    view.Columns(i).Visible = False
            End Select
        Next
    End Sub

    Private Sub Detach()

    End Sub
#End Region

    Private Sub fmaDepartmentViewerListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Detach()
        RaiseEvent FORM_CLOSING()
    End Sub

    Private Sub fmaDepartmentViewerListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Attach()
    End Sub

    Private Sub tdbViewer_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbViewer.FilterChange
        ' Build our filter expression.


        Dim sb As New System.Text.StringBuilder()
        Dim dc As C1.Win.C1TrueDBGrid.C1DataColumn

        For Each dc In Me.tdbViewer.Columns

            If dc.FilterText.Length > 0 Then

                If sb.Length > 0 Then

                    sb.Append(" AND ")

                End If
                If Me.RadioButton1.Checked Then
                    sb.Append((dc.DataField + " = " + "'" + dc.FilterText + "'"))
                Else
                    sb.Append((dc.DataField + " like " + "'%" + dc.FilterText + "%'"))
                End If

                Me.txtFilterText.Text = sb.ToString
            End If

        Next dc



    End Sub

    Private Sub searchFilterText()
        If Me.txtFilterText.Text = "" Then
            Attach()
            Exit Sub
        End If


        tdbViewer.DataSource = Nothing
        Dim LimitValue As Integer = PgCount.Value


        Dim SQL As String = "SELECT SysPK,a_code,a_name, payment_type, patient_type,CASE WHEN `status` = 1 then 'ACTIVE' ELSE 'INACTIVE' END AS 'status'"
        SQL += " FROM " & TABLENAME
        SQL += " ORDER BY patient_type"
        SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("SysPK").Visible = False
                '.DisplayColumns("a_code").Visible = False

                .DisplayColumns("a_code").DataColumn.Caption = "CODE"
                .DisplayColumns("a_code").Width = 100
                .DisplayColumns("a_code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("a_name").DataColumn.Caption = "DESCRIPTION"
                .DisplayColumns("a_name").Width = 200
                .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("payment_type").DataColumn.Caption = "PAYMENT TYPE"
                .DisplayColumns("payment_type").Width = 100
                .DisplayColumns("payment_type").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("payment_type").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("patient_type").Visible = False

                .DisplayColumns("status").DataColumn.Caption = "STATUS"
                .DisplayColumns("status").Width = 100
                .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            End With
        Catch ex As Exception

        End Try

        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "SELECT count(SysPK) as count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        End If


        MeData = Nothing
        Me.txtFilterText.Text = ""
    End Sub

    Private Sub tdbViewer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbViewer.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtFilterText.Text.Length > 0 Then
                btnSearchCondition.PerformClick()
            End If
        End If
    End Sub

    Private Sub GridToTextboxes()
        For Each iControl As Control In FormControls
            Try
                iControl.Text = tdbViewer.Columns(iControl.Name.Replace("txt", "")).Text
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.tdbViewer.FilterBar Then
            Me.tdbViewer.FilterBar = False
        Else
            Me.tdbViewer.FilterBar = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaPatientTypeMasterSetupForm
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

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Me.tdbViewer.FilterBar Then
            Me.tdbViewer.FilterBar = False
            grpBoxSearch.Visible = False
            btnSearch.Text = "Show Filter Bar"
        Else
            Me.tdbViewer.FilterBar = True
            grpBoxSearch.Visible = True
            btnSearch.Text = "Hide Filter Bar"
            Try
                Me.tdbViewer.Col = 1
                With tdbViewer.Splits(0)
                    .FilterActive = True
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
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
            ITEMSYSPK = GridView1.GetFocusedRowCellValue("SysPK").ToString 'tdbViewer.Columns.Item(0).Value
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
            SETUPFORM = New fmaPatientTypeMasterSetupForm
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()

    End Sub

    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click
        searchFilterText()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim SQLEX As String = "SELECT A.a_code, B.Item_Description, A.item_unit, A.item_price, A.inv_qty"
        'SQLEX += " FROM  inventory_master AS A"
        'SQLEX += " inner JOIN product_item B "
        'SQLEX += " ON (A.a_code = B.Item_Code)"
        'SQLEX += " GROUP BY a_code"


        'Dim new_report As New fzzReportViewerForm
        'Dim datefrom As String = Format(Date.Now, "yyyy-MM-dd")
        'Dim dateto As String = Format(Date.Now, "yyyy-MM-dd")


        'Try
        '    new_report.AttachReport(SQLEX, "Inventory Report") = New rpt_ActualInventoryReport(datefrom, dateto)
        '    new_report.Show()

        'Catch ex As Exception

        'End Try

        'MsgBox("Please Close Drawer.")
    End Sub

    Private Sub ActiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to ACTIVATE this ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Active()
        End If
    End Sub

    Private Sub Active()


        Dim ITEMSYSPK As String = ""

        Try
            ITEMSYSPK = GridView1.GetFocusedRowCellValue("SysPK").ToString 'tdbViewer.Columns.Item(0).Value
        Catch ex As Exception

        End Try

        If ITEMSYSPK <> "" Then

            DataSource(String.Format("UPDATE patient_type SET status = 1 WHERE SysPK = '" & ITEMSYSPK & "'"))
            MsgBox("ITEM HAS BEEN ACTIVATED", MsgBoxStyle.Information)
            Attach()
            End If


    End Sub

    Private Sub InActiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InActiveToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to DEACTIVATE this ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Inactive
        End If
    End Sub

    Private Sub Inactive()
        Dim ITEMSYSPK As String = ""

        Try
            ITEMSYSPK = GridView1.GetFocusedRowCellValue("SysPK").ToString 'tdbViewer.Columns.Item(0).Value
        Catch ex As Exception

        End Try

        If ITEMSYSPK <> "" Then

            DataSource(String.Format("UPDATE patient_type SET status = 0 WHERE SysPK = '" & ITEMSYSPK & "'"))
            MsgBox("ITEM HAS BEEN DE-ACTIVATED", MsgBoxStyle.Information)
            Attach()
        End If
    End Sub

    Private Sub GridControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = GridControl1.PointToClient(point1)
            CMenuStripOperations.Show(GridControl1, pt)
        End If

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        btnDelete.PerformClick()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem1.Click
        btnEdit.PerformClick()
    End Sub
End Class