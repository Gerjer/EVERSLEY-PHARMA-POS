Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_DailySalesItemRange

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal RPTdateFrom As String, ByVal RPTdateTo As String)
        InitializeComponent()


        Me.txtFrom.Text = RPTdateFrom
        Me.txtTo.Text = RPTdateTo
    End Sub


    Private Sub rpt_DailySalesReportItem_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub
End Class
