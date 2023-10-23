Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters
Public Class xtrStockCard

    Dim parameter1 As New Parameter()
    Private Sub xtrStockCard_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint


        parameter1.Name = "NULL"
        ' Specify other parameter properties.
        parameter1.Type = GetType(System.String)
        parameter1.Value = ""
        parameter1.Visible = True

    End Sub


    Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint

    End Sub


End Class