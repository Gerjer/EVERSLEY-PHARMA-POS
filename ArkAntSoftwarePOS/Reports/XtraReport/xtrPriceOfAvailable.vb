Imports System.Drawing.Printing

Public Class xtrPriceOfAvailable
    Private Sub xtrPriceOfAvailable_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        If XrLabel16.Text = "0.00" Then
            XrLabel16.Text = ""
        End If
        If XrLabel17.Text = "0.00" Then
            XrLabel17.Text = ""
        End If
        If XrLabel18.Text = "0.00" Then
            XrLabel18.Text = ""
        End If
        If XrLabel19.Text = "0.00" Then
            XrLabel19.Text = ""
        End If


    End Sub
End Class