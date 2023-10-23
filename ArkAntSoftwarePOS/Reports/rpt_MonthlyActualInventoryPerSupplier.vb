Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_MonthlyActualInventoryPerSupplier 
    Private DATEFROM As String
    Private DATETO As String
    Private MONTHOF As String


    Private TOTALBEGCOST As Double
    Private TOTALRECCOST As Double
    Private TOTALISSUEDCOST As Double
    Private TOTALPOCOST As Double
    Private TOTALENDCOST As Double


    Sub New()
        InitializeComponent()
    End Sub


    Sub New(ByVal pdateFrom As String, ByVal pdateTo As String, ByVal month As String)
        InitializeComponent()

        Me.DATEFROM = pdateFrom
        Me.DATETO = pdateTo
        Me.MONTHOF = month

        Me.txtFrom.Text = month

        TextBox2.Text = TextBox2.Text & month
    End Sub

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format


    End Sub



    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        'TextBox32.Text = Format(TOTALBEGCOST, "#,##0.00")
        'TextBox35.Text = Format(TOTALRECCOST, "#,##0.00")
        'TextBox38.Text = Format(TOTALPOCOST, "#,##0.00")
        'TextBox41.Text = Format(TOTALISSUEDCOST, "#,##0.00")

        'TextBox44.Text = Format(TOTALENDCOST, "#,##0.00")
    End Sub


    Private Sub rpt_MonthlyActualInventoryPerSupplier_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub

    Private Sub PageHeader1_Format(sender As Object, e As EventArgs) Handles PageHeader1.Format

    End Sub
End Class
