Imports MySql.Data.MySqlClient

Public Class fmaPersonProfileSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txta_code

        clsGroup.AttachControl = Me.txta_code
        clsGroup.AttachControl = Me.txtpatienttype
        clsGroup.AttachControl = Me.txtpatienttype_id
        clsGroup.AttachControl = Me.txta_name
        clsGroup.AttachControl = Me.txtfname
        clsGroup.AttachControl = Me.txtmname
        clsGroup.AttachControl = Me.txtlname
        clsGroup.AttachControl = Me.txtage
        clsGroup.AttachControl = Me.txtSSS
        clsGroup.AttachControl = Me.txtPHILHEALTH
        clsGroup.AttachControl = Me.txtcontact_no
        clsGroup.AttachControl = Me.txtaddress
        clsGroup.AttachControl = Me.txtisEmp
        clsGroup.AttachControl = Me.txtempType
        clsGroup.AttachControl = Me.txtdob
        clsGroup.AttachControl = Me.txtsex
        clsGroup.AttachControl = Me.txtclass

        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......

        Dim SQLEX As String = "SELECT a_code, CONCAT(a_name ,'-', payment_type) AS 'PATIENTYPE'"
        SQLEX += " FROM patient_type ORDER BY patient_type,a_code"


        Dim Medata As DataTable
        Medata = clsDBConn.ExecQuery(SQLEX)

        Me.txtpatienttype.DataSource = Medata
        Me.txtpatienttype.DisplayMember = "PATIENTYPE"
        Me.txtpatienttype.ValueMember = "a_code"
        Me.txtpatienttype.Text = ""
        Me.txtpatienttype.SelectedIndex = -1
        Me.txtpatienttype_id.Text = ""

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




    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '     txta_code.Focus()
        'txtpatienttype.FocusCuesEnabled() = True
    End Sub


    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave
        Me.txta_name.Text = Me.txtlname.Text & ", " & Me.txtfname.Text & IIf(Me.txtmname.Text.Length = 0, "", " " & Me.txtmname.Text)
        If txtage.Text = "" Then
            txtage.Text = "0"
        End If
    End Sub

    Private Sub txtpatienttype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpatienttype.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtpatienttype.SelectedItem, DataRowView)
            Me.txtpatienttype_id.Text = drv.Item("a_code").ToString
        Catch ex As Exception
            Me.txtpatienttype_id.Text = ""
        End Try
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        If CheckBoxX1.Checked Then
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            txtisEmp.Text = 1
            txtempType.Text = 0
        Else
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            txtisEmp.Text = 0
            txtempType.Text = ""
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            txtempType.Text = 0
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            txtempType.Text = 1
        End If
    End Sub

    Private Sub txta_code_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txta_code.TextChanged
        If txta_code.Text.Length > 0 Then

            Dim SQLEX As String = "SELECT isEmp,empType FROM person_profile "
            SQLEX += " WHERE a_code='" & Me.txta_code.Text & "'"

            Dim MeData As DataTable

            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then
                Try
                    Dim isEmp As Boolean = CBool(MeData.Rows(0).Item("isEmp").ToString)
                    Dim empType As Boolean = CBool(MeData.Rows(0).Item("empType").ToString)

                    If isEmp Then
                        CheckBoxX1.Checked = True
                        RadioButton1.Visible = True
                        RadioButton2.Visible = True

                        If empType = 0 Then
                            RadioButton1.Checked = True
                        Else
                            RadioButton2.Checked = True
                        End If
                    End If


                Catch ex As Exception

                End Try
            End If

        End If
    End Sub


    Private Sub dtiBirthDate_TextChanged(sender As Object, e As EventArgs) Handles dtiBirthDate.TextChanged
        txtdob.Text = Format(dtiBirthDate.Value, "yyyy-MM-dd")
        txtage.Text = GetCurrentAge(Format(dtiBirthDate.Value, "yyyy-MM-dd"))
    End Sub
End Class