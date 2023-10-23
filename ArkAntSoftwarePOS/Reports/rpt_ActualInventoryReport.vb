Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_ActualInventoryReport

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

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim sYSpk As String = txtCode.Text

        Me.txtAdded.Text = getAdded(sYSpk)
        Me.txtSold.Text = getSold(sYSpk)

        Try
            If CDbl(TextBox16.Text) <= CDbl(TextBox27.Text) Then
                txtCode.ForeColor = Color.Red
                TextBox12.ForeColor = Color.Red
                TextBox24.ForeColor = Color.Red
                TextBox15.ForeColor = Color.Red
                TextBox13.ForeColor = Color.Red
                txtAdded.ForeColor = Color.Red
                txtSold.ForeColor = Color.Red
                TextBox16.ForeColor = Color.Red
                TextBox27.ForeColor = Color.Red
            Else
                txtCode.ForeColor = Color.Black
                TextBox12.ForeColor = Color.Black
                TextBox24.ForeColor = Color.Black
                TextBox15.ForeColor = Color.Black
                TextBox13.ForeColor = Color.Black
                txtAdded.ForeColor = Color.Black
                txtSold.ForeColor = Color.Black
                TextBox16.ForeColor = Color.Black
                TextBox27.ForeColor = Color.Black

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function getAdded(ByVal itemSysPK As String) As String

        Dim SQLEX As String = "SELECT SUM(added_qty) 'added' FROM inventory_replenishment"
        SQLEX += " WHERE item_code='" & itemSysPK & "'"
        SQLEX += String.Format(" AND DATE(date_added) BETWEEN '{0}' and '{1}'", Me.txtFrom.Text, Me.txtTo.Text)

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        Dim count As Double = 0

        If MeData.Rows.Count > 0 Then

            Try
                count = MeData.Rows(0).Item("added")
            Catch ex As Exception

            End Try

        End If

        Return Format(count, "#,##0.00")
    End Function

    Private Function getSold(ByVal itemSysPK As String) As String

        Dim SQLEX As String = "SELECT SUM(item_qty) 'sold' FROM daily_sales_detail"
        SQLEX += " WHERE item_invcode='" & itemSysPK & "'"
        SQLEX += " AND sales_stat=1"
        SQLEX += String.Format(" AND DATE(date_created) BETWEEN '{0}' and '{1}'", Me.txtFrom.Text, Me.txtTo.Text)

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        Dim count As Double = 0

        If MeData.Rows.Count > 0 Then

            Try
                count = MeData.Rows(0).Item("sold")
            Catch ex As Exception

            End Try

        End If

        Return Format(count, "#,##0.00")
    End Function


End Class
