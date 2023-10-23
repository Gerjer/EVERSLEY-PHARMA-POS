Public Class ShowLoading

    Public Sub setMessage(ByVal message As String)

        Me.Label1.Text = message
    End Sub

   
    Private Sub ShowLoading_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Focus()
        Me.BringToFront()
    End Sub
End Class