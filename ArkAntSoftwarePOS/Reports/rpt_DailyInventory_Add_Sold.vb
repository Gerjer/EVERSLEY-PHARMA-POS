Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_DailyInventory_Add_Sold


    Sub New()
        InitializeComponent()

    End Sub

    Sub New(ByVal SINGLEDATE As String)
        InitializeComponent()


        Me.txtFrom.Text = SINGLEDATE
       
        lblTo.Visible = False
        lblTO_.Visible = False
        txtTo.Visible = False
        lblDateFrom.Text = "DATE"

    End Sub

    Sub New(ByVal dateFrom As String, ByVal dateTo As String, ByVal SINGLEDATE As Boolean)
        InitializeComponent()


        Me.txtFrom.Text = dateFrom
        Me.txtTo.Text = dateTo

        If SINGLEDATE Then
            lblTo.Visible = False
            lblTO_.Visible = False
            txtTo.Visible = False
            lblDateFrom.Text = "DATE"
        End If
    End Sub

    Private Sub rpt_InventoryReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub

End Class
