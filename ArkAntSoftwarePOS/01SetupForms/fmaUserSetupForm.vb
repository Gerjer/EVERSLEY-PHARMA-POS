Public Class fmaUserSetupForm
    Private WithEvents clsGroup As clsData

    Public WithEvents LISTFORM As fmaUserSetupViewerListForm

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK_User, clsDBConn)
        clsGroup.AttachUserPK = Me.txtUserName_User
        clsGroup.AttachControl = Me.txtUserName_User
        clsGroup.AttachControl = Me.txtPassword_User
        clsGroup.AttachControl = Me.txtType_User
        clsGroup.AttachControl = Me.txtUserFull_name

        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachDeleteButton = Me.btnDelete

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......
    End Sub

    Private Sub DetachClasses()
        clsGroup = Nothing
    End Sub
#End Region

    Private Sub clsGroup_AfterRecordSave() Handles clsGroup.AfterRecordSave
        Me.Close()
        '      LISTFORM.Attach()
    End Sub

    Private Sub fmaWorkGroupSetupForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DetachClasses()
    End Sub

    Private Sub fmaWorkGroupSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AttachClasses()

    End Sub

    Private Sub txtList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtList.Click
        fmaUserSetupViewerListForm.FormControls = clsGroup.FormControls
        fmaUserSetupViewerListForm.ShowDialog()
    End Sub


    Private Sub txtType_User_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtType_User.TextChanged
        If txtType_User.Text = "SUPERUSER" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
    End Sub


End Class