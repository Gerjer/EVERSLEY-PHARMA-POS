Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class fmaReceivedByPopUpForm

    Public Event Form_OK()

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click


        txtReceiverName.Text = ReceivedBy
        If txtReceiverName.Text.Length = 0 Then
            MsgBox("Please Enter Proper Receiver Name..", MsgBoxStyle.Information)
            Exit Sub
        End If

        RaiseEvent Form_OK()
        Me.Close()
    End Sub

    Dim ReceivedBy As String = ""
    Private Sub fmaReceivedByPopUpForm_Load(sender As Object, e As EventArgs) Handles Me.Load



        txtReceiverName.DataSource = DataSource(String.Format("SELECT
                                          0 AS 'id',
	                                        daily_sales_master.recieved_by 'name'
                                        FROM
	                                        daily_sales_master
	                                        WHERE recieved_by IS NOT NULL AND recieved_by <> ''
	                                        GROUP BY recieved_by"))
        txtReceiverName.ValueMember = "id"
        txtReceiverName.DisplayMember = "name"
        txtReceiverName.SelectedIndex = -1

        txtReceiverName.Focus()
        txtReceiverName.SelectAll()

    End Sub

    Private Sub txtReceiverName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtReceiverName.SelectedIndexChanged

        Try
            Dim drv As DataRowView = DirectCast(txtReceiverName.SelectedItem, DataRowView)
            ReceivedBy = drv.Item("name").ToString
        Catch ex As Exception
            txtReceiverName.Text = ""
        End Try

    End Sub

    Private Sub txtReceiverName_TextChanged(sender As Object, e As EventArgs) Handles txtReceiverName.TextChanged
        ReceivedBy = txtReceiverName.Text
    End Sub


    Private Sub txtReceiverName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtReceiverName.KeyUp

        If e.KeyCode = Keys.Enter Then
                txtReceiverName.Text = ReceivedBy
                If txtReceiverName.Text.Length = 0 Then
                    MsgBox("Please Enter Proper Receiver Name..", MsgBoxStyle.Information)
                    Exit Sub
                End If

                RaiseEvent Form_OK()
                Me.Close()
            End If

    End Sub
End Class