Imports MySql.Data.MySqlClient

Public Class fmaItemSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK_Item, clsDBConn)
        clsGroup.AttachUserPK = Me.txtItem_Code

        clsGroup.AttachControl = Me.txtItem_Code
        clsGroup.AttachControl = Me.txtItem_Display
        clsGroup.AttachControl = Me.txtItem_Description
        clsGroup.AttachControl = Me.txtbrand_name
        clsGroup.AttachControl = Me.txtmedtype



        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......

        Dim MeData As DataTable = Nothing
        Dim SQL As String = "SELECT a_name FROM pharmaceuticals Where SysPK<>0 ORDER BY a_name ASC "
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtbrand_name.DataSource = MeData
        Me.txtbrand_name.DisplayMember = "a_name"
        Me.txtbrand_name.ValueMember = "a_name"
        Me.txtbrand_name.Text = ""
        Me.txtbrand_name.SelectedIndex = -1


        SQL = "SELECT Item_Display FROM medtype Where SysPK_Item<>0 ORDER BY Item_Display ASC "
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtmedtype.DataSource = MeData
        Me.txtmedtype.DisplayMember = "Item_Display"
        Me.txtmedtype.ValueMember = "Item_Display"
        Me.txtmedtype.Text = ""
        Me.txtmedtype.SelectedIndex = -1

    End Sub

    Private Sub DetachClasses()
        clsGroup = Nothing
    End Sub
#End Region

    Private Sub fmaEmployeeSetupForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DetachClasses()
        RaiseEvent SETUP_CLOSED()
    End Sub

    Private Sub fmaEmployeeSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AttachClasses()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.btnModify.PerformClick()
        End If
        ''
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clsGroup_AfterDelete() Handles clsGroup.AfterDelete
        RaiseEvent DB_MODIFIED()

    End Sub

    Private Sub clsGroup_AfterRecordSave() Handles clsGroup.AfterRecordSave
        RaiseEvent DB_MODIFIED()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.Close()
        End If


        If Me.btnAdd.Visible = False Then
            Me.btnAdd.Visible = True
        End If
    End Sub


    Private Sub txtItem_Code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItem_Code.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtItem_Display.Focus()
            txtItem_Display.SelectAll()
        End If
    End Sub

    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave
        If txtItem_Display.Text.Length = 0 And txtItem_Description.Text.Length = 0 Then
            MsgBox("Display Name and Generic Name should not be blank.", MsgBoxStyle.Critical)
        End If

        txtItem_Description.Text = txtItem_Display.Text + " - " + txtbrand_name.Text
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtItem_Code.Focus()
    End Sub


End Class