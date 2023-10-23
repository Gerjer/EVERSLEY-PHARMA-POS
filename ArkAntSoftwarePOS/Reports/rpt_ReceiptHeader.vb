Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_ReceiptHeader

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub



    Private Sub rpt_ReceiptPrint_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim SQLEX As String = "SELECT company_name, address FROM FILE"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                Me.txtCompname.Text = MeData.Rows(0).Item("company_name").ToString
                Me.txtAddress.Text = MeData.Rows(0).Item("address").ToString
            Catch ex As Exception

            End Try
        End If


    End Sub
End Class
