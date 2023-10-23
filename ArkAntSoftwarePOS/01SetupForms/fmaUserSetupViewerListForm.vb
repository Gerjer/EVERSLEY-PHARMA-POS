Public Class fmaUserSetupViewerListForm
    Public FormControls As Collection
    Dim MeData As New DataTable
    Private WithEvents SETUPFORM As fmaUserSetupForm

    Private TABLENAME As String = "users"
#Region "Viewers Info"
    Public Sub Attach()
        Dim SQL As String = "SELECT SysPK_User,Password_User,UserName_User,Type_User,UserFull_name  FROM users WHERE SysPK_User<>0"
        SQL &= " ORDER BY UserName_User DESC"

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        With tdbViewer.Splits(0)
            .DisplayColumns("SysPK_User").DataColumn.Caption = "SysPK"
            .DisplayColumns("SysPK_User").Width = 0
            .DisplayColumns("Password_User").DataColumn.Caption = "Password"
            .DisplayColumns("Password_User").Width = 0

            .DisplayColumns("UserName_User").DataColumn.Caption = "User Name"
            .DisplayColumns("UserName_User").Width = 100
            .DisplayColumns("Type_User").DataColumn.Caption = "Type"
            .DisplayColumns("Type_User").Width = 150
            .DisplayColumns("UserFull_name").Width = 0
        End With

    End Sub
    Private Sub Detach()

    End Sub
#End Region

    Private Sub fmaUserSetupViewerListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Detach()
    End Sub

    Private Sub fmaUserSetupViewerListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Attach()
    End Sub

    Private Sub tdbViewer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbViewer.KeyUp
        If e.KeyCode = Keys.Enter Then
            If tdbViewer.RowCount > 0 Then
                Me.GridToTextboxes()
            End If
            ProcessFilterText(MeData, tdbViewer)
        End If
    End Sub

    Private Sub GridToTextboxes()
        Try
            For Each iControl As Control In FormControls
                iControl.Text = tdbViewer.Columns(iControl.Name.Replace("txt", "")).Text
            Next
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.GridToTextboxes()
    End Sub

    Public Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.Attach()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaUserSetupForm
        End If
        SETUPFORM.BringToFront()
        SETUPFORM.ShowDialog()

    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaUserSetupForm
            '    SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        'Me.FormControls = SETUPFORM.clsGroup.FormControls
        'SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click

        If MessageBox.Show("Are you sure you want to DELETE USER?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
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
            DELETESTR += " WHERE SysPK_User='" & ITEMSYSPK & "'"

            If clsDBConn.Execute(DELETESTR) Then
                MsgBox("USER HAS BEEN DELETED", MsgBoxStyle.Information)
                Attach()
            End If
        End If
    End Sub
End Class