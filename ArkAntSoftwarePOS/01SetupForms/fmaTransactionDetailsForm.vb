Imports DevExpress.XtraGrid.Views.Grid

Public Class fmaTransactionDetailsForm

    Public Event TRVOIDED()
    Private WithEvents RETURNED As fmaReturnedItemDialog

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub txtSysPK_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK.TextChanged
        If txtSysPK.Text.Length > 0 Then
            displayDetails()
        End If
    End Sub

    Private Sub displayDetails()
        Dim SQLEX As String = "SELECT sales_sys, item_invcode, item_descr,ris_master.supplier'consignee',item_qty,Format(inventory_master.selling_price,2)'selling_price',inventory_master.consignee 'item_disc',Format(item_total,2)'item_total',ris_details.RIS_Det_No 'risdtl_no' "
        SQLEX += " FROM daily_sales_detail "
        SQLEX += " INNER JOIN inventory_master "
        SQLEX += " ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`)"
        SQLEX += " INNER JOIN ris_details ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No   "
        SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No = ris_master.RIS_No "
        SQLEX += " WHERE sales_sys='" & Me.txtSysPK.Text & "'"
        SQLEX += " AND item_qty>0"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        tdbViewer.DataSource = MeData

        GridControl1.DataSource = MeData
        DesignGridView(GridView1)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("sales_sys").Visible = False
                .DisplayColumns("item_invcode").DataColumn.Caption = "ITEMCODE"
                .DisplayColumns("item_invcode").Width = 100
                .DisplayColumns("item_invcode").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_invcode").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                '.DisplayColumns("sales_sys").Visible = False

                .DisplayColumns("item_descr").DataColumn.Caption = "PRODUCT NAME"
                .DisplayColumns("item_descr").Width = 200
                .DisplayColumns("item_descr").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_descr").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("consignee").DataColumn.Caption = "CONSIGNEE"
                .DisplayColumns("consignee").Width = 200
                .DisplayColumns("consignee").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("consignee").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("item_qty").DataColumn.Caption = "QTY."
                .DisplayColumns("item_qty").Width = 100
                .DisplayColumns("item_qty").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_qty").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("selling_price").DataColumn.Caption = "PRICE"
                .DisplayColumns("selling_price").Width = 120
                .DisplayColumns("selling_price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("selling_price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("item_disc").DataColumn.Caption = "ITEM DISCOUNT"
                .DisplayColumns("item_disc").DataColumn.NumberFormat = "0.00"
                .DisplayColumns("item_disc").Width = 120
                .DisplayColumns("item_disc").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_disc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("item_total").DataColumn.Caption = "NET"
                .DisplayColumns("item_total").Width = 130
                .DisplayColumns("item_total").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("item_total").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("risdtl_no").Visible = False


            End With
        Catch ex As Exception

        End Try

        MeData = Nothing


    End Sub

    Private Sub DesignGridView(gridView1 As GridView)
        Dim view As GridView = gridView1

        For i As Integer = 0 To view.Columns.Count - 1
            Select Case i
                Case 1
                    view.Columns(i).Caption = "ITEMCODE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 2
                    view.Columns(i).Caption = "PRODUCT NAME"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case 3
                    view.Columns(i).Caption = "CONSIGNEE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case 4
                    view.Columns(i).Caption = "QTY."
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 5
                    view.Columns(i).Caption = "PRICE"
                    view.Columns(i).DisplayFormat.FormatString = "n2"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                Case 6
                    view.Columns(i).Caption = "ITEM DISCOUNT"
                    view.Columns(i).DisplayFormat.FormatString = "n2"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                Case 7
                    view.Columns(i).Caption = "NET"
                    view.Columns(i).DisplayFormat.FormatString = "n2"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                Case Else
                    view.Columns(i).Visible = False

            End Select
        Next

        view.BestFitColumns()

    End Sub

    Private Sub txtStatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStatus.TextChanged
        If txtStatus.Text.Length > 0 Then
            If txtStatus.Text = "VOID" Then
                Me.btnVoid.Enabled = False
                Me.btnPrint.Enabled = False
                'ElseIf txtStatus.Text = "CLOSED" Then
                '    Me.btnVoid.Enabled = False
                '    Me.btnPrint.Enabled = True
            ElseIf txtStatus.Text = "ISSUED" Then
                Me.btnIssue.Enabled = False
            ElseIf txtStatus.Text = "CLOSED" Then
                Me.btnVoid.Enabled = False
                Me.btnPrint.Enabled = True
                Me.btnIssue.Enabled = False
            End If
        End If
    End Sub

    Private Sub updateInventory()

        Dim rowCount As Integer = tdbViewer.RowCount

        For x As Integer = 0 To rowCount - 1
            Try
                Dim item_invcode As String = tdbViewer.Item(x, "item_invcode").ToString()
                Dim detQty As Double = CDbl(tdbViewer.Item(x, "item_qty").ToString())

                Dim sales_sys As Double = CDbl(tdbViewer.Item(x, "sales_sys").ToString())


                ''INV MASTER
                'Dim SQLUP As String = "UPDATE inventory_master SET inv_qty=inv_qty+'" & detQty & "'"
                'SQLUP += " WHERE a_code='" & item_invcode & "'"
                'clsDBConn.Execute(SQLUP)

                'RIS Detail
                Dim SQLUP As String = "UPDATE ris_details SET qty_remaining = qty_remaining + '" & detQty & "'"
                SQLUP += " WHERE RIS_Det_No= '" & risdtl_no & "'"
                clsDBConn.Execute(SQLUP)



                'DAILY INV LISTING
                SQLUP = "UPDATE daily_inventory_details SET sold=sold-'" & detQty & "'"
                SQLUP += " , remaining_qty=remaining_qty+'" & detQty & "'"
                SQLUP += " WHERE a_code='" & item_invcode & "'"
                SQLUP += " AND TRD_Date = '" & lblDate.Text & "'"
                clsDBConn.Execute(SQLUP)


                SQLUP = "UPDATE daily_sales_detail SET sales_stat=0"
                SQLUP += " WHERE sales_sys='" & sales_sys & "'"
                clsDBConn.Execute(SQLUP)




            Catch ex As Exception

            End Try


        Next


    End Sub


    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        If AuthUserType = "Cashier" Then
            If MessageBox.Show("Do you want to ByPass the security code...??" & vbNewLine & "", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                GoTo Pass
            End If

            MsgBox("PLEASE LOGIN AS ADMINISTRATOR TO VOID TRANSACTION", MsgBoxStyle.Critical)
            Exit Sub
        End If

Pass:
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""

                Exit Sub
            End If

            If MessageBox.Show("After Voiding Transaction, it cannot be Undone." _
                               & vbNewLine & "Are you sure you want to VOID this transaction?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ' VOID TRANSACTIONS. SET Transaction_Type= 'VOID'
                Dim SQLUP As String = "UPDATE daily_sales_master SET status='VOID'"
                SQLUP += " WHERE SysPK='" & Me.txtSysPK.Text & "'"

                If clsDBConn.Execute(SQLUP) Then
                    MsgBox("TRANSACTION IS NOW VOID.", MsgBoxStyle.Information)
                    updateInventory()
                    RaiseEvent TRVOIDED()
                End If

            Else
                MsgBox("TRANSACTION NOT VOIDED.", MsgBoxStyle.Information)
            End If


        End If

        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click
        Dim SQLEX As String = "Update daily_sales_master set status='ISSUED'"
        SQLEX += " WHERE SysPK='" & Me.txtSysPK.Text & "'"

        If clsDBConn.Execute(SQLEX) Then
            MsgBox("Transaction was changed to ISSUED.")
        End If
    End Sub

    Dim risdtl_no As String
    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            If txtStatus.Text = "OPEN" Then
                Exit Sub
            End If

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = tdbViewer.PointToClient(point1)
            CMenuStripOperations.Show(tdbViewer, pt)
        End If

        Dim row As Integer = tdbViewer.Row
        risdtl_no = tdbViewer(row, "risdtl_no")

    End Sub

    Private Sub ReturnSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnSelectedToolStripMenuItem.Click



        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""

                Exit Sub
            End If

            If RETURNED Is Nothing Then
                RETURNED = New fmaReturnedItemDialog
            End If


            With RETURNED
                .txtQtyIssued.Text = tdbViewer.Columns.Item("item_qty").Value
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    If MessageBox.Show("After You Returned This Item, it cannot be Undone." _
                               & vbNewLine & "Are you sure you want to Return this Item?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        ' VOID TRANSACTIONS. SET Transaction_Type= 'VOID'
                        'item_invcode
                        Dim item_invcode As String = tdbViewer.Columns.Item("item_invcode").Value
                        Dim detQty As Integer = .txtReturnedQty.Value
                        'sales_sys
                        Dim item_qty As Integer = CInt(tdbViewer.Columns.Item("item_qty").Value)
                        Dim sales_sys As String = tdbViewer.Columns.Item("sales_sys").Value

                        Dim new_item_total As Double = CDbl(tdbViewer.Columns.Item("selling_price").Value) * (item_qty - detQty)

                        'INV MASTER
                        Dim SQLUP As String = ""

                        'SQLUP = "UPDATE inventory_master SET inv_qty=inv_qty+'" & detQty & "'"
                        'SQLUP += " WHERE a_code='" & item_invcode & "'"
                        'clsDBConn.Execute(SQLUP)

                        'DAILY INV LISTING
                        SQLUP = "UPDATE daily_inventory_details SET sold=sold-'" & detQty & "'"
                        SQLUP += " , remaining_qty=remaining_qty+'" & detQty & "'"
                        SQLUP += " WHERE a_code='" & item_invcode & "'"
                        SQLUP += " AND TRD_Date = '" & lblDate.Text & "'"
                        clsDBConn.Execute(SQLUP)


                        SQLUP = "UPDATE daily_sales_detail SET sales_stat=2,item_qty=item_qty-'" & detQty & "'"
                        SQLUP += " ,item_total='" & new_item_total & "'"
                        SQLUP += " ,returned_qty='" & detQty & "'"
                        SQLUP += " WHERE sales_sys='" & sales_sys & "'"
                        SQLUP += " AND item_invcode='" & item_invcode & "'"
                        clsDBConn.Execute(SQLUP)


                        ' return item to RIS Details
                        Dim SQLDailySalesDet As String = "Select RIS_Det_No from daily_sales_detail where sales_sys='" & sales_sys & "'"

                        Dim MeData As DataTable

                        MeData = clsDBConn.ExecQuery(SQLDailySalesDet)

                        If MeData.Rows.Count > 0 Then
                            Dim RIS_Det_No As String = MeData.Rows(0).Item("RIS_Det_No").ToString


                            Dim SQLUP_RIS As String = "UPDATE ris_details SET qty_remaining=qty_remaining + '" & detQty & "'"

                            SQLUP_RIS += " WHERE RIS_Det_No='" & RIS_Det_No & "'"

                            clsDBConn.Execute(SQLUP_RIS)


                        End If


                        ' add initial quantity where date is current date.
                        'DAILY INV LISTING
                        Dim SQLEX As String = "SELECT TransactionDay FROM transaction_day  "
                        SQLEX += " ORDER BY TransactionDay DESC"
                        SQLEX += " LIMIT 1"

                        Dim DateData As DataTable
                        DateData = clsDBConn.ExecQuery(SQLEX)

                        If DateData.Rows.Count > 0 Then
                            Dim TransactionDay As String = DateData.Rows(0).Item("TransactionDay").ToString

                            SQLUP = "UPDATE daily_inventory_details SET sold=sold-'" & detQty & "'"
                            SQLUP += " , remaining_qty=remaining_qty+'" & detQty & "'"
                            SQLUP += " WHERE a_code='" & item_invcode & "'"
                            SQLUP += " AND TRD_Date = '" & TransactionDay & "'"

                            clsDBConn.Execute(SQLUP)

                        End If








                    Else
                        MsgBox("ITEM IS NOT MARKED AS RETURNED.", MsgBoxStyle.Information)
                    End If

                End If
            End With
            MsgBox("Item has been updated.", MsgBoxStyle.Information)
            displayDetails()
            RETURNED = Nothing
        End If
    End Sub

    Private Sub GridControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            If txtStatus.Text = "OPEN" Then
                Exit Sub
            End If

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = GridControl1.PointToClient(point1)
            CMenuStripOperations.Show(GridControl1, pt)
        End If
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick
        risdtl_no = GridView1.GetFocusedRowCellValue("risdtl_no").ToString '' tdbViewer(row, "risdtl_no")
    End Sub
End Class