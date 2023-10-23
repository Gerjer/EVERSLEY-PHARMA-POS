Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document

Public Class rpt_InventoryCountPerSupplierFundsClass
    Dim TYPE As String = ""
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal supplier As String, ByVal asOfDate As String)

        InitializeComponent()
        txtFrom.Text = asOfDate
        TYPE = supplier
    End Sub

    Private Sub rpt_InventoryCountPerSupplier_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        'Me.txtAddress.Text = COMPANY_ADDRESS

        If TYPE = "IN-HOUSE" Or TYPE = "DOH DONATION" Or TYPE = "MISC." Then
            txtLevelName.Text = "FUNDS CLASSIFICATION"
            txtSupplier.Text = TYPE
            GroupHeader1.Visible = True
            GroupHeader1.DataField = "supplier"
            GroupFooter1.Visible = True
        Else
            txtLevelName.Text = "SUPPLIER"
            txtSupplier.Text = TYPE
            GroupHeader1.Visible = False
            GroupHeader1.DataField = ""
            GroupFooter1.Visible = False
        End If

    End Sub


End Class
