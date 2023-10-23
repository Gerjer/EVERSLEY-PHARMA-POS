Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptMonthlyDeliveryPullOut

    Private reportDateFrom As String = ""
    Private reportDateTo As String = ""


    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal dateFrom As String, ByVal dateTo As String, ByVal monthOf As String)
        InitializeComponent()
        Me.txtMonthOf.Text = monthOf
        reportDateFrom = dateFrom
        reportDateTo = dateTo
    End Sub


    Private Sub rptMonthlyDeliveryPullOut_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub


End Class
