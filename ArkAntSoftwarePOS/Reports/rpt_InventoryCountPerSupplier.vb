Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_InventoryCountPerSupplier 
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal supplier As String, ByVal asOfDate As String)

        InitializeComponent()
        txtSupplier.Text = supplier
        txtFrom.Text = asOfDate
    End Sub

    Private Sub rpt_InventoryCountPerSupplier_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub
End Class
