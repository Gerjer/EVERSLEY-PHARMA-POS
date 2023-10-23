Imports MySql.Data.MySqlClient

Public Class fmaInventoryReplenishmentForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

    Private Sub fmaInventoryReplenishmentForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent SETUP_CLOSED()
    End Sub



    Private Sub fmaInventoryReplenishmentForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If OPERATION <> "EDIT" Then
            getItemList()
        End If

    End Sub

    Private Sub getItemList()
        Dim MeData As New DataTable
        '      Dim SQL As String = "SELECT SysPK, a_code,a_name,inv_qty,consignee FROM inventory_master Where SysPK<>0 ORDER BY a_name ASC "
        Dim SQL As String = "SELECT  RIS_Det_No,inv_master_SysPK 'a_code',ris_details.inv_master_Name 'a_name',qty_remaining 'inv_qty'  FROM ris_details ORDER BY a_name ASC "

        MeData = clsDBConn.ExecQuery(SQL)
        Me.txta_name.DataSource = MeData
        Me.txta_name.DisplayMember = "a_name"
        Me.txta_name.ValueMember = "a_code"
        Me.txta_name.SelectedIndex = -1
        Me.txta_name.Text = ""
        Me.txta_code.Text = ""
        Me.txtRemStocks.Text = ""
        Me.txtInvSys.Text = ""
        Me.txtinv_qty.Text = "0.00"


        SQL = "SELECT SysPK,a_name FROM pharmaceuticals Where SysPK<>0 ORDER BY a_name ASC "
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtconsignee.DataSource = MeData
        Me.txtconsignee.DisplayMember = "a_name"
        Me.txtconsignee.ValueMember = "SysPK"
        Me.txtconsignee.Text = ""
        Me.txtconsignee.SelectedIndex = -1

    End Sub


    Private Sub txta_name_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txta_name.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txta_name.SelectedItem, DataRowView)
            Me.txta_code.Text = drv.Item("a_code").ToString 'Item_Code
            Me.txtRemStocks.Text = drv.Item("inv_qty").ToString 'Item_Code
            Me.txtInvSys.Text = drv.Item("SysPK").ToString
        Catch ex As Exception
            Me.txtRemStocks.Text = ""
        End Try

        Application.DoEvents()
        txtinv_qty.Focus()
        txtinv_qty.SelectAll()


    End Sub

    Private Sub txta_code_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txta_code.Click
        Application.DoEvents()
        txta_code.SelectAll()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CDbl(Me.txtinv_qty.Text) > 0 Then

        Else
            MsgBox("Please Modify number not less than or equal to zero.")
        End If

        Dim UpdateSQL As String = ""
        Me.txtSysPK.Text = System.Guid.NewGuid.GetHashCode

        If RadioButton1.Checked Then
            'UpdateSQL = "UPDATE inventory_master SET inv_qty=(inv_qty + " & CDbl(Me.txtinv_qty.Text) & ")"
            'UpdateSQL += " WHERE SysPK='" & Me.txtInvSys.Text & "'"
            UpdateSQL = "UPDATE ris_details SET qty_remaining=(qty_remaining + " & CDbl(Me.txtinv_qty.Text) & ")"
            UpdateSQL += " WHERE RIS_Det_No='" & Me.txtInvSys.Text & "'"


            If clsDBConn.Execute(UpdateSQL) Then
                'add record for replenished stocks
                Dim SQLADD As String = "INSERT INTO inventory_replenishment(SysPK,SysPK_INVMaster,item_code,"
                SQLADD += " item_name,added_qty,itemremarks,ris_no,supplier_id,supplier,fund_cluster)"
                SQLADD += " VALUES("
                SQLADD += String.Format("'{0}', '{1}', '{2}',", Me.txtSysPK.Text, Me.txtInvSys.Text, Me.txta_code.Text)
                SQLADD += String.Format("'{0}', '{1}','{2}',", Me.txta_name.Text, CDbl(Me.txtinv_qty.Text), txtitemremarks.Text)
                SQLADD += String.Format("'{0}', '{1}','{2}','{3}')", Me.txtRIS_no.Text, Me.txtconsignee_id.Text, Me.txtconsignee.Text, Me.txtFundClass_id.Text)

                If clsDBConn.Execute(SQLADD) Then
                    'daily_inventory_details
                    Dim SQLUP As String = "UPDATE daily_inventory_details SET added=added +'" & CDbl(Me.txtinv_qty.Text) & "', "
                    SQLUP += " remaining_qty = remaining_qty + '" & CDbl(Me.txtinv_qty.Text) & "'"
                    SQLUP += " WHERE a_code='" & txta_code.Text & "'"
                    SQLUP += " AND SysPK_TRD='" & DAILY_TRANSACTION_SYSPK & "'"

                    clsDBConn.Execute(SQLUP)

                    MsgBox("Item Replenishment Successful.")
                    getItemList()
                End If



            End If
        Else
            'PULL OUT
            'UpdateSQL = "UPDATE inventory_master SET inv_qty=(inv_qty - " & CDbl(Me.txtinv_qty.Text) & ")"
            'UpdateSQL += " WHERE SysPK='" & Me.txtInvSys.Text & "'"

            UpdateSQL = "UPDATE ris_details SET qty_remaining=(qty_remaining - " & CDbl(Me.txtinv_qty.Text) & ")"
            UpdateSQL += " WHERE RIS_Det_No='" & Me.txtInvSys.Text & "'"


            If clsDBConn.Execute(UpdateSQL) Then
                'add record for replenished stocks
                Dim SQLADD As String = "INSERT INTO inventory_replenishment(SysPK,SysPK_INVMaster,item_code,"
                SQLADD += " item_name,added_qty,itemremarks,ris_no,supplier_id,supplier,fund_cluster)"
                SQLADD += " VALUES("
                SQLADD += String.Format("'{0}', '{1}', '{2}',", Me.txtSysPK.Text, Me.txtInvSys.Text, Me.txta_code.Text)
                SQLADD += String.Format("'{0}', '{1}','{2}',", Me.txta_name.Text, CDbl(Me.txtinv_qty.Text), txtitemremarks.Text)
                SQLADD += String.Format("'{0}', '{1}','{2}','{3}')", Me.txtRIS_no.Text, Me.txtconsignee_id.Text, Me.txtconsignee.Text, Me.txtFundClass_id.Text)

                If clsDBConn.Execute(SQLADD) Then
                    'daily_inventory_details
                    Dim SQLUP As String = "UPDATE daily_inventory_details SET pullout=pullout +'" & CDbl(Me.txtinv_qty.Text) & "', "
                    SQLUP += " remaining_qty = remaining_qty - '" & CDbl(Me.txtinv_qty.Text) & "'"
                    SQLUP += " WHERE a_code='" & txta_code.Text & "'"
                    SQLUP += " AND SysPK_TRD='" & DAILY_TRANSACTION_SYSPK & "'"

                    clsDBConn.Execute(SQLUP)

                    MsgBox("Item PullOut Successful.")
                    getItemList()
                End If

            End If
        End If

    End Sub


    Private Sub txta_code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txta_code.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim MeData As New DataTable
            Dim SQL As String = "SELECT SysPK, a_code,a_name,inv_qty FROM inventory_master"
            SQL += " Where a_code ='" & Me.txta_code.Text & "'"
            MeData = clsDBConn.ExecQuery(SQL)

            Try
                If MeData.Rows.Count > 0 Then
                    Me.txta_name.Text = MeData.Rows(0).Item("a_name").ToString
                    'Me.txtinv_qty.Text = MeData.Rows(0).Item("inv_qty").ToString


                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub txtconsignee_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtconsignee.SelectedIndexChanged

        Try
            Dim drv As DataRowView = DirectCast(txtconsignee.SelectedItem, DataRowView)
            Me.txtconsignee_id.Text = drv.Item("SysPK").ToString
        Catch ex As Exception
            Me.txtconsignee_id.Text = ""
        End Try

        Dim MeData As New DataTable
        Dim SQL As String = "SELECT RIS_Det_No 'SysPK',inv_master_SysPK 'a_code',inv_master_Name 'a_name',	qty_remaining 'inv_qty',fund_class 'consignee'"
        SQL += " FROM ris_details INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_details.RIS_Master_No"
        SQL += " WHERE fund_class_id = '" & Me.txtconsignee_id.Text & "'"
        SQL += " ORDER BY a_name ASC "
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txta_name.DataSource = MeData
        Me.txta_name.DisplayMember = "a_name"
        Me.txta_name.ValueMember = "a_code"
        Me.txta_name.SelectedIndex = -1
        Me.txta_name.Text = ""
        Me.txta_code.Text = ""
        Me.txtRemStocks.Text = ""
        Me.txtInvSys.Text = ""
        Me.txtinv_qty.Text = "0.00"

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        LabelX4.Text = "Quantity Added"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        LabelX4.Text = "Quantity Less"
    End Sub
End Class