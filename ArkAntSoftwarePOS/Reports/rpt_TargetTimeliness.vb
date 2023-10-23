Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_TargetTimeliness

    Private totalRX As Integer = 0

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal rpt_date As String)


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtMonthOf.Text = rpt_date
    End Sub

    Private Sub Detail1_Format(sender As Object, e As EventArgs) Handles Detail1.Format
        Dim totalIP As Integer = 0
        Dim totalOP As Integer = 0


        Try
            totalIP = CInt(TextBox10.Text)
        Catch ex As Exception

        End Try

        Try
            totalOP = CInt(TextBox13.Text)
        Catch ex As Exception

        End Try

        TextBox16.Text = totalIP + totalOP

        totalRX += totalIP + totalOP
    End Sub

    Private Sub GroupFooter1_Format(sender As Object, e As EventArgs) Handles GroupFooter1.Format
        TextBox24.Text = totalRX
    End Sub
End Class
