Imports MySql.Data.MySqlClient

Public Class fmaSupplierSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""
    Public supplier As Integer
#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txta_code

        clsGroup.AttachControl = Me.txta_code
        clsGroup.AttachControl = Me.txta_name
        clsGroup.AttachControl = Me.txtsup_address
        clsGroup.AttachControl = Me.txtcontact_num
        clsGroup.AttachControl = Me.txtemail_add
        clsGroup.AttachControl = Me.txtsupplier_type

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

        'If supplier = 0 Then
        '    RadioButton1.Checked = True
        'ElseIf supplier = 1 Then
        '    RadioButton2.Checked = True
        'Else
        '    '          RadioButton1.Checked = False
        '    '        RadioButton2.CheckAlign = False
        'End If


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

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        Panel1.Enabled = False
        If Me.btnAdd.Visible = False Then
            Me.btnAdd.Visible = True
        End If
    End Sub

    Public Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtsupplier_type.Text = 0
        End If
        Panel1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtsupplier_type.Text = 1
        End If
        Panel1.Enabled = True
    End Sub
End Class