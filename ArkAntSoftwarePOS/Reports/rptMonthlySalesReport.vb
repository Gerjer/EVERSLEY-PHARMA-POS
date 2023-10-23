Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptMonthlySalesReport

    Dim TotalSales As Double = 0

    Sub New()
        InitializeComponent()

    End Sub

    Sub New(ByVal Month As String)
        InitializeComponent()

        txtDate.Text = Month
    End Sub

    Private Sub rptMonthlySalesReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS

        TotalSales = 0
    End Sub


    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim SQLEX As String = "SELECT day_stat, sales FROM transaction_day"
        SQLEX += " WHERE TransactionDay='" & txtDateRecord.Text & "'"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then

            Try
                Dim sales As Double = MeData.Rows(0).Item("sales")
                TotalSales += sales

                txtDayStat.Text = MeData.Rows(0).Item("day_stat").ToString
                txtNetSales.Text = Format(sales, "#,##0.00")

            Catch ex As Exception

            End Try

        Else
            txtDayStat.Text = ""
            txtNetSales.Text = ""
        End If

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        txtTotal.Text = Format(TotalSales, "#,##0.00")

        TextBox10.Text = FullUserName
    End Sub
End Class
