Imports System.Windows.Forms

Public Class fmaReturnedItemDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

   
    Private Sub txtReturnedQty_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReturnedQty.ValueChanged
        If txtReturnedQty.Value > CInt(txtQtyIssued.Text) Then
            txtReturnedQty.Value = CInt(txtQtyIssued.Text)
        End If
    End Sub
End Class
