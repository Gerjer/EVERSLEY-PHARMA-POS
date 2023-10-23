Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_StockCardHeaderPrint 

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim SQLEX As String = "SELECT itemremarks FROM inventory_replenishment"
        SQLEX += " WHERE item_code='" & txtStockNo.Text & "'"
        SQLEX += " AND DATE(date_added) = '" & txtDate.Text & "'"
        SQLEX += " AND added_qty > 0"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                Me.txtReference.Text = MeData.Rows(0).Item("itemremarks").ToString
            Catch ex As Exception
                Me.txtReference.Text = ""
            End Try
        Else
            Me.txtReference.Text = ""
        End If

        ' receipt
        Try
            If CInt(txtRcvdQty.Text) > 0 Then
                Dim rcvAmount As Double = CInt(txtRcvdQty.Text) * CDbl(txtItemBuyPrice.Text)
                txtRcvdAmount.Text = Format(rcvAmount, "#,##0.00")
            Else
                txtRcvdQty.Text = "-"
                txtRcvdAmount.Text = "-"
            End If

        Catch ex As Exception

        End Try

        'pullout
        Try
            If CInt(txtIssPullQTY.Text) > 0 Then
                Dim rcvAmount As Double = CInt(txtIssPullQTY.Text) * CDbl(txtItemBuyPrice.Text)
                txtIssPullAmt.Text = Format(rcvAmount, "#,##0.00")
            Else
                txtIssPullQTY.Text = "-"
                txtIssPullAmt.Text = "-"
            End If

        Catch ex As Exception

        End Try

        'balance
        Try
            If CInt(txtBalQTY.Text) > 0 Then
                Dim rcvAmount As Double = CInt(txtBalQTY.Text) * CDbl(txtItemBuyPrice.Text)
                txtBalanceAmt.Text = Format(rcvAmount, "#,##0.00")
            Else
                txtBalQTY.Text = "-"
                txtBalanceAmt.Text = "-"
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class
