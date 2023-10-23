Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_DailyRpt_Medicine_Issuance

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal dateFrom As String)
        InitializeComponent()
        Me.txtFrom.Text = dateFrom

    End Sub



    Private Sub rpt_DailyRpt_Medicine_Issuance_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        '    Me.txtCmpName.Text = COMPANY_NAME
        '    Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub


   
End Class
