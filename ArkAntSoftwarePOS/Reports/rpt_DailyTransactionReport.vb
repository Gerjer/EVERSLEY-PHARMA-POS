Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_DailyTransactionReport

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal dateFrom As String, ByVal dateTo As String)
        InitializeComponent()


        Me.txtFrom.Text = dateFrom
        Me.txtTo.Text = dateTo
    End Sub

    Private Sub rpt_InventoryReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub

End Class
