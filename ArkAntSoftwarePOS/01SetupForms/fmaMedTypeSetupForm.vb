Imports MySql.Data.MySqlClient

Public Class fmaMedTypeSetupForm

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
        clsGroup.AttachControl = Me.txtclass_based_id
        clsGroup.AttachControl = Me.txtdiscription

        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......


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

        loadComboBox

    End Sub

    Private Sub loadComboBox()
        cmbClassBased.DataSource = DataSource(String.Format("SELECT
	                    class_based.id, 
	                    class_based.`name`
                    FROM
	                    class_based"))
        cmbClassBased.ValueMember = "id"
        cmbClassBased.DisplayMember = "name"
        cmbClassBased.SelectedIndex = -1
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

  

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '     txtItem_Code.Focus()
        txtItem_Code.Focus()
    End Sub

    Private Sub cmbClassBased_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClassBased.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbClassBased.SelectedItem, DataRowView)
            txtclass_based_id.Text = drv.Item("id").ToString
        Catch ex As Exception

        End Try
    End Sub
End Class