Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_DailySalesReport

    Sub New()
        InitializeComponent()

    End Sub

    Sub New(ByVal RPTdate As String)
        InitializeComponent()


        Me.txtFrom.Text = RPTdate
    End Sub

    Private Sub rpt_InventoryReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub

End Class
