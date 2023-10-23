Imports MySql.Data.MySqlClient

Public Class fmaPharmaSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txta_code

        clsGroup.AttachControl = Me.txta_code
        clsGroup.AttachControl = Me.txta_name
        clsGroup.AttachControl = Me.txtaddress
        clsGroup.AttachControl = Me.txtcontactNum
        clsGroup.AttachControl = Me.txtpaymentgroup





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
            If txtpaymentgroup.Text = "0" Then
                RadioButton1.Checked = True
            ElseIf txtpaymentgroup.Text = "1" Then
                RadioButton2.Checked = True
            End If
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


    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            txtpaymentgroup.Text = 0
        End If
    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            txtpaymentgroup.Text = 1
        End If
    End Sub

    Private Sub txtpaymentgroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaymentgroup.TextChanged
        If Me.OPERATION = "EDIT" Then
            If txtpaymentgroup.Text = "0" Then
                RadioButton1.Checked = True
            ElseIf txtpaymentgroup.Text = "1" Then
                RadioButton2.Checked = True
            End If
        End If
    End Sub
End Class