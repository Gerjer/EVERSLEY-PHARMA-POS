Imports MySql.Data.MySqlClient

Public Class fmaReplinishmentSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()


        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txtitem_code


        clsGroup.AttachControl = Me.txtSysPK_INVMaster
        clsGroup.AttachControl = Me.txtitem_code
        clsGroup.AttachControl = Me.txtitem_name
        clsGroup.AttachControl = Me.txtdate_modified
        clsGroup.AttachControl = Me.txtpullout_qty
        clsGroup.AttachControl = Me.txtadded_qty
        clsGroup.AttachControl = Me.txtmodify_user
        clsGroup.AttachControl = Me.txtdate_added
        clsGroup.AttachControl = Me.txtitemremarks





        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......

        txtmodify_user.Text = FullUserName

        txtpullout_qty.Visible = True
        LabelX4.Visible = True
        txtadded_qty.Visible = True
        LabelX3.Visible = True
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

        txtitem_name.ReadOnly = True
        txtmodify_user.ReadOnly = True
        
        ''

        


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clsGroup_AddButtonClick() Handles clsGroup.AddButtonClick
        cpyDelQty.Text = txtadded_qty.Text
        cpyPulloutQty.Text = txtpullout_qty.Text
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


    Private Sub txtItem_Code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtitem_code.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtitem_name.Focus()
            txtitem_name.SelectAll()
        End If
    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtitem_code.Focus()
    End Sub

    
    Private Sub txtdate_modified_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate_modified.Click
        txtdate_modified.Value = Date.Now
        Me.txtdate_modified.MonthCalendar.DisplayMonth = New Date(txtdate_modified.Value.Year, txtdate_modified.Value.Month, 1, 0, 0, 0, 0)
    End Sub

    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave



        Dim UpdateSQL As String = ""
        Dim TRD_SYSPK As String = ""
        Dim GETTRD_SYSPK As String = "SELECT TRD_SYSPK from transaction_day "
        GETTRD_SYSPK += " WHERE TransactionDay='" & Format(txtdate_added.Value, "yyyy-MM-dd") & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(GETTRD_SYSPK)

        If MeData.Rows.Count > 0 Then
            Try
                TRD_SYSPK = MeData.Rows(0).Item("TRD_SYSPK").ToString
            Catch ex As Exception

            End Try

        End If




        ' 

        Try
            If CInt(txtadded_qty.Text) > CInt(cpyDelQty.Text) Then
                Dim addedQty As Integer = CInt(txtadded_qty.Text) - CInt(cpyDelQty.Text)

                UpdateSQL = "UPDATE inventory_master SET inv_qty=(inv_qty + " & addedQty & ")"
                UpdateSQL += " WHERE SysPK='" & Me.txtSysPK_INVMaster.Text & "'"

                If clsDBConn.Execute(UpdateSQL) Then



                    Dim SQLUP As String = "UPDATE daily_inventory_details SET added=added +'" & addedQty & "', "
                    SQLUP += " remaining_qty = remaining_qty + '" & addedQty & "'"
                    SQLUP += " WHERE a_code='" & txtitem_code.Text & "'"
                    SQLUP += " AND SysPK_TRD='" & TRD_SYSPK & "'"

                    clsDBConn.Execute(SQLUP)

                    MsgBox("Item Replenishment Edited.")
                End If

            ElseIf CInt(cpyDelQty.Text) > CInt(txtadded_qty.Text) Then
                Dim addedQty As Integer = CInt(cpyDelQty.Text) - CInt(txtadded_qty.Text)

                UpdateSQL = "UPDATE inventory_master SET inv_qty=(inv_qty - " & addedQty & ")"
                UpdateSQL += " WHERE SysPK='" & Me.txtSysPK_INVMaster.Text & "'"

                If clsDBConn.Execute(UpdateSQL) Then



                    Dim SQLUP As String = "UPDATE daily_inventory_details SET added=added -'" & addedQty & "', "
                    SQLUP += " remaining_qty = remaining_qty - '" & addedQty & "'"
                    SQLUP += " WHERE a_code='" & txtitem_code.Text & "'"
                    SQLUP += " AND SysPK_TRD='" & TRD_SYSPK & "'"

                    clsDBConn.Execute(SQLUP)

                    MsgBox("Item Replenishment Edited.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Enter Proper Number format.")
            DetachClasses()
            Exit Sub
        End Try

        ' pullout

        Try
            If CInt(txtpullout_qty.Text) > CInt(cpyPulloutQty.Text) Then
                Dim addedQty As Integer = CInt(txtpullout_qty.Text) - CInt(cpyPulloutQty.Text)

                UpdateSQL = "UPDATE inventory_master SET inv_qty=(inv_qty - " & addedQty & ")"
                UpdateSQL += " WHERE SysPK='" & Me.txtSysPK_INVMaster.Text & "'"

                If clsDBConn.Execute(UpdateSQL) Then

                    Dim SQLUP As String = "UPDATE daily_inventory_details SET pullout=pullout +'" & addedQty & "', "
                    SQLUP += " remaining_qty = remaining_qty - '" & addedQty & "'"
                    SQLUP += " WHERE a_code='" & txtitem_code.Text & "'"
                    SQLUP += " AND SysPK_TRD='" & TRD_SYSPK & "'"

                    clsDBConn.Execute(SQLUP)

                    MsgBox("Item Replenishment Edited.")
                End If

            ElseIf CInt(cpyPulloutQty.Text) > CInt(txtpullout_qty.Text) Then
                Dim addedQty As Integer = CInt(cpyPulloutQty.Text) - CInt(txtpullout_qty.Text)

                UpdateSQL = "UPDATE inventory_master SET inv_qty=(inv_qty + " & addedQty & ")"
                UpdateSQL += " WHERE SysPK='" & Me.txtSysPK_INVMaster.Text & "'"

                If clsDBConn.Execute(UpdateSQL) Then



                    Dim SQLUP As String = "UPDATE daily_inventory_details SET pullout=pullout -'" & addedQty & "', "
                    SQLUP += " remaining_qty = remaining_qty + '" & addedQty & "'"
                    SQLUP += " WHERE a_code='" & txtitem_code.Text & "'"
                    SQLUP += " AND SysPK_TRD='" & TRD_SYSPK & "'"

                    clsDBConn.Execute(SQLUP)

                    MsgBox("Item Replenishment Edited.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Enter Proper Number format.")
            DetachClasses()
            Exit Sub
        End Try



    End Sub

    
    Private Sub clsGroup_EditButtonClick() Handles clsGroup.EditButtonClick
        cpyDelQty.Text = txtadded_qty.Text
        cpyPulloutQty.Text = txtpullout_qty.Text
    End Sub

    Private Sub fmaReplinishmentSetupForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cpyDelQty.Text = txtadded_qty.Text
        cpyPulloutQty.Text = txtpullout_qty.Text
    End Sub

   

    Private Sub txtadded_qty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtadded_qty.TextChanged
        If CInt(txtadded_qty.Text) > 0 Then
            txtpullout_qty.Visible = False
            LabelX4.Visible = False
        End If

       
    End Sub

    Private Sub txtpullout_qty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpullout_qty.TextChanged
        If CInt(txtpullout_qty.Text) > 0 Then
            txtadded_qty.Visible = False
            LabelX3.Visible = False
        End If
    End Sub
End Class