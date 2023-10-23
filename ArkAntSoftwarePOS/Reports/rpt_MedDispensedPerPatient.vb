Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_MedDispensedPerPatient

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal patientName As String, ByVal age As String, ByVal sex As String, ByVal ward As String, ByVal DateFrom As String, ByVal DateTo As String)
        InitializeComponent()

        Me.txtPatienName.Text = patientName
        Me.txtAge.Text = age
        Me.txtSex.Text = sex
        Me.txtWard.Text = ward
        Me.txtDtpFrom.Text = DateFrom
        Me.txtDtpTo.Text = DateTo

    End Sub

    Private Sub Detail1_BeforePrint(sender As Object, e As EventArgs) Handles Detail1.BeforePrint
        If TextBox17.Height > 0.19 Then
            Dim height As Single = TextBox17.Height
            For Each iControl As DataDynamics.ActiveReports.ARControl In Detail1.Controls
                If TypeOf iControl Is DataDynamics.ActiveReports.TextBox Then
                    CType(iControl, DataDynamics.ActiveReports.TextBox).Height = height
                End If

            Next
        End If
    End Sub
End Class
