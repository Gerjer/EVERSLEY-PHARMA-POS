Public Class fmaUpdateBegBalForm

    Private Event EditAllowed()

    Dim ROW_INDEX As Integer = 0
    Dim COL_INDEX As Integer = 0

    Private editedColumnList As New List(Of Integer)

    Private Sub fmaUpdateBegBalForm_EditAllowed() Handles Me.EditAllowed
        btnSave.Enabled = True
    End Sub

    Private Sub fmaMonthlyInventoryPerSupplierListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        txtYear.Value = Date.Now
        dtpDateMonthof.DataSource = months
        dtpDateMonthof.SelectedIndex = Date.Now.Month - 1


        'dateFrom.Value = New DateTime(Date.Now.Year, Date.Now.Month - 1, 1)

        Dim SQLEX As String = "SELECT IF(paymentgroup='0','Private','Government') 'type',paymentgroup FROM pharmaceuticals"
        SQLEX += " GROUP BY type"
        SQLEX += " ORDER BY paymentgroup"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.cmbClassification.DataSource = MeData
        Me.cmbClassification.DisplayMember = "type"
        Me.cmbClassification.ValueMember = "paymentgroup"
        Me.cmbClassification.SelectedIndex = 0


        displaySuppliers()
    End Sub


    Private Sub displaySuppliers()

        Dim SQLEX As String = "SELECT SysPK, a_name FROM pharmaceuticals"
        SQLEX += " WHERE paymentgroup='" & txtClassificationCode.Text & "'"
        SQLEX += " ORDER BY a_name"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)



        If MeData.Rows.Count > 0 Then
            Try

                Me.txtSupplierList.DataSource = MeData
                Me.txtSupplierList.DisplayMember = "a_name"
                Me.txtSupplierList.ValueMember = "SysPK"
                Me.txtSupplierList.SelectedIndex = -1
                Me.txtSupplierList.Text = ""
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbClassification_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClassification.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbClassification.SelectedItem, DataRowView)
            Me.txtClassificationCode.Text = CInt(drv.Item("paymentgroup").ToString)
        Catch ex As Exception
            Me.txtClassificationCode.Text = ""
        End Try


        displaySuppliers()
    End Sub



    Private Sub dtpDateMonthof_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateMonthof.SelectedIndexChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value.Year, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.ValueChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value.Year, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try
    End Sub

    Dim SysPK As String
    Private Sub txtSupplierList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierList.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtSupplierList.SelectedItem, DataRowView)
            SysPK = drv.Item("SysPK").ToString
            Me.txtSupplierCode.Text = drv.Item("SysPK").ToString
        Catch ex As Exception
            Me.txtSupplierCode.Text = ""
        End Try
    End Sub


    Private Sub dateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged
        Try
            dateTo.Value = New DateTime(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.AddMonths(1).AddDays(-1).Day)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        displayData()

        btnxUpdate.Enabled = True
    End Sub

    Private Sub displayData()
        dgvBeginning.Rows.Clear()


        Dim SQLEX As String = "SELECT a.TRD_Date, a.SysPK_TRD,a.SysPK_InvMaster, a.a_code, "
        SQLEX += " a.a_name,a.item_unit,initial_qty,IFNULL(ris_details.price,0) 'item_buyprice' "
        SQLEX += " FROM daily_inventory_details a"
        'SQLEX += " INNER JOIN ("
        'SQLEX += " SELECT  SysPK_TRD, a_code,a_name, TRD_Date minDate"
        'SQLEX += " FROM daily_inventory_details"
        'SQLEX += " WHERE YEAR(TRD_Date)='" & Format(New Date(dateFrom.Value.Year, dateFrom.Value.Month, 1), "yyyy") & "'"
        'SQLEX += " AND MONTH(TRD_Date)='" & Format(New Date(dateFrom.Value.Year, dateFrom.Value.Month, 1), "MM") & "'"
        'SQLEX += " ORDER BY TRD_Date ASC LIMIT 1"
        'SQLEX += " ) b ON a.SysPK_TRD = b.SysPK_TRD AND a.TRD_Date = b.minDate "
        SQLEX += " INNER JOIN inventory_master  ON (a.SysPK_InvMaster = inventory_master.SysPK) "
        SQLEX += " LEFT JOIN ris_details ON  a.a_code = ris_details.inv_master_SysPK "
        SQLEX += " INNER JOIN ris_master ON  ris_details.RIS_Master_No = ris_master.RIS_No "
        SQLEX += " WHERE ris_master.fund_class_id = '" & txtSupplierCode.Text & "' "
        SQLEX += " AND YEAR(a.TRD_Date)='" & Format(New Date(dateFrom.Value.Year, dateFrom.Value.Month, 1), "yyyy") & "'"
        SQLEX += " AND MONTH(a.TRD_Date)='" & Format(New Date(dateFrom.Value.Year, dateFrom.Value.Month, 1), "MM") & "'"
        SQLEX += " And ris_details.qty_remaining > 0"

        SQLEX += " GROUP BY a.a_code"
        SQLEX += " order by a.a_name"

        Me.txtSupplierCode.Text = SysPK







        Dim MeData As DataTable
        MeData = clsDBConn.ExecLongQuery(SQLEX)

        If MeData.Rows.Count > 0 Then


            Try
                For cnt As Integer = 0 To MeData.Rows.Count - 1
                    'SysPK_TRD,SysPK_InvMaster, a_code, a_name,item_unit,initial_qty
                    Dim dateString As String = MeData.Rows(cnt).Item("TRD_Date").ToString()
                    Dim dateFromString As DateTime = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture)
                    Dim filterDate As Date = New Date(dateFromString.Year, dateFromString.Month, dateFromString.Day)
                    Dim buyPrice As Double = 0

                    buyPrice = CDbl(MeData.Rows(cnt).Item("item_buyprice").ToString())


                    Dim supplierlist As New List(Of String)
                    supplierlist.Add(Format(filterDate, "yyyy-MM-dd"))
                    supplierlist.Add(MeData.Rows(cnt).Item("SysPK_TRD").ToString())
                    supplierlist.Add(MeData.Rows(cnt).Item("SysPK_InvMaster").ToString())
                    supplierlist.Add(MeData.Rows(cnt).Item("a_code").ToString())
                    supplierlist.Add(MeData.Rows(cnt).Item("a_name").ToString())
                    supplierlist.Add(MeData.Rows(cnt).Item("item_unit").ToString())
                    supplierlist.Add(MeData.Rows(cnt).Item("initial_qty").ToString())
                    supplierlist.Add(Format(buyPrice, "#,##0.00"))

                    dgvBeginning.Rows.Add(supplierlist.ToArray)



                Next

            Catch ex As Exception

            End Try


        End If
    End Sub

    
    Private Sub dgvBeginning_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBeginning.CellEndEdit
        Dim cellvalue As Integer = 0
        ROW_INDEX = e.RowIndex
        COL_INDEX = e.ColumnIndex


        If Not editedColumnList.Contains(ROW_INDEX) Then


            Try
                cellvalue = CInt(dgvBeginning.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value)
                editedColumnList.Add(ROW_INDEX)
                RaiseEvent EditAllowed()
            Catch ex As Exception
                MsgBox("Please Enter Number only.")
                dgvBeginning.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                btnSave.Enabled = False
            End Try



        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Cursor = Cursors.WaitCursor

        For rownumber As Integer = 0 To dgvBeginning.Rows.Count - 1
            'For Each val As String In editedColumnList
            '    Dim rownumber As Integer = CInt(val)

            'SysPK_TRD, SysPK_InvMaster, daily_inventory_details.a_code, ""
            'daily_inventory_details.a_name,daily_inventory_details.item_unit,initial_qty"
            Dim TRD_Date As String = dgvBeginning.Rows.Item(rownumber).Cells(0).Value.ToString
            Dim SysPK_TRD As String = dgvBeginning.Rows.Item(rownumber).Cells(1).Value.ToString
            Dim SysPK_InvMaster As String = dgvBeginning.Rows.Item(rownumber).Cells(2).Value.ToString
            'Dim TRD_DATE As String = Format(New Date(dateFrom.Value.Year, dateFrom.Value.Month, 1), "yyyy-MM-dd")
            Dim a_code As String = dgvBeginning.Rows.Item(rownumber).Cells(3).Value.ToString
            Dim initial_qty As String = dgvBeginning.Rows.Item(rownumber).Cells(6).Value.ToString




            Dim UPDATESQL As String = "UPDATE daily_inventory_details"
            UPDATESQL += " SET initial_qty='" & initial_qty & "'"
            UPDATESQL += " ,remaining_qty=(initial_qty + added) - (sold+pullout)"
            UPDATESQL += " WHERE SysPK_TRD='" & SysPK_TRD & "'"
            UPDATESQL += " AND SysPK_InvMaster='" & SysPK_InvMaster & "'"
            UPDATESQL += " AND TRD_Date='" & TRD_Date & "'"
            UPDATESQL += " AND a_code='" & a_code & "'"


            clsDBConn.ExecuteSilence(UPDATESQL)



        Next

        btnSave.Enabled = False
        editedColumnList.Clear()

        displayData()
        Cursor = Cursors.Default
    End Sub

    Private Sub btnxUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxUpdate.Click
        Cursor = Cursors.WaitCursor
        Dim dateFromstr As Date = New DateTime(txtYear.Value.Year, dtpDateMonthof.SelectedIndex, 1)
        Dim dateTostr As Date = New DateTime(dateFromstr.Year, dateFromstr.Month, dateFromstr.AddMonths(1).AddDays(-1).Day)

        For rownumber As Integer = 0 To dgvBeginning.Rows.Count - 1

            Dim TRD_Date As String = dgvBeginning.Rows.Item(rownumber).Cells(0).Value.ToString
            Dim SysPK_TRD As String = dgvBeginning.Rows.Item(rownumber).Cells(1).Value.ToString
            Dim SysPK_InvMaster As String = dgvBeginning.Rows.Item(rownumber).Cells(2).Value.ToString
            'Dim TRD_DATE As String = Format(New Date(dateFrom.Value.Year, dateFrom.Value.Month, 1), "yyyy-MM-dd")
            Dim a_code As String = dgvBeginning.Rows.Item(rownumber).Cells(3).Value.ToString
            Dim initial_qty As String = dgvBeginning.Rows.Item(rownumber).Cells(6).Value.ToString


            Dim runningBeg As Integer = 0
            Dim runningRec As Integer = 0
            Dim runningPO As Integer = 0
            Dim runningIssued As Integer = 0
            Dim MeData As DataTable

            Dim SQLEXBEGIN As String = "SELECT `daily_inventory_details`.`initial_qty` 'initial_qty' "
            SQLEXBEGIN += " FROM daily_inventory_details"
            SQLEXBEGIN += " INNER JOIN inventory_master"
            SQLEXBEGIN += " ON (`daily_inventory_details`.`SysPK_InvMaster` = `inventory_master`.`SysPK`)"
            SQLEXBEGIN += " WHERE daily_inventory_details.a_code='" & a_code & "'"
            SQLEXBEGIN += " AND TRD_Date BETWEEN '" & Format(dateFromstr, "yyyy-MM-dd") & "'"
            SQLEXBEGIN += " AND '" & Format(dateTostr, "yyyy-MM-dd") & "'"
            SQLEXBEGIN += " ORDER BY TRD_Date ASC"
            SQLEXBEGIN += " LIMIT 1"


            MeData = Nothing
            MeData = clsDBConn.ExecQuery(SQLEXBEGIN)

            Dim txtBegC1 As Integer = 0
            Dim txtRecC1 As Integer = 0
            Dim txtPOC1 As Integer = 0
            Dim txtIssueC1 As Integer = 0




            If MeData.Rows.Count > 0 Then



                Dim totalAdd As Integer = 0

                Dim invCode As String = a_code
                Try
                    If MeData.Rows(0).Item("initial_qty").ToString <> "" Then
                        totalAdd = CInt(MeData.Rows(0).Item("initial_qty").ToString)
                        runningBeg += totalAdd
                    End If


                Catch ex As Exception
                    totalAdd = 0
                End Try

                If totalAdd > 0 Then
                    txtBegC1 = totalAdd

                Else
                    txtBegC1 = 0
                End If
            Else
                txtBegC1 = 0
            End If




            ' Recieved
            Dim SQLEX As String = "SELECT  SUM(added_qty) 'ADDEDQTY' FROM inventory_replenishment"
            SQLEX += " WHERE item_code ='" & a_code & "'"
            SQLEX += " AND DATE(date_added) BETWEEN'" & Format(dateFromstr, "yyyy-MM-dd") & "'"
            SQLEX += " AND '" & Format(dateTostr, "yyyy-MM-dd") & "'"


            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then

                Dim totalAdd As Integer = 0

                Try

                    If MeData.Rows(0).Item("ADDEDQTY").ToString <> "" Then
                        totalAdd = CInt(MeData.Rows(0).Item("ADDEDQTY").ToString)
                        runningRec += totalAdd
                    End If

                Catch ex As Exception

                End Try

                If totalAdd > 0 Then
                    txtRecC1 = totalAdd

                    
                Else
                    txtRecC1 = 0
                End If
            End If


            ' pull-out
            SQLEX = "SELECT  SUM(pullout_qty) 'POQTY' FROM inventory_replenishment"
            SQLEX += " WHERE item_code ='" & a_code & "'"
            SQLEX += " AND DATE(date_added) BETWEEN'" & Format(dateFromstr, "yyyy-MM-dd") & "'"
            SQLEX += " AND '" & Format(dateTostr, "yyyy-MM-dd") & "'"

            MeData = Nothing
            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then

                Dim totalAdd As Integer = 0

                Try
                    If MeData.Rows(0).Item("POQTY").ToString <> "" Then
                        totalAdd = CInt(MeData.Rows(0).Item("POQTY").ToString)
                        runningPO += totalAdd
                    End If

                Catch ex As Exception

                End Try

                If totalAdd > 0 Then
                    txtPOC1 = totalAdd

                Else
                    txtPOC1 = 0

                End If
            End If


            'ISSUED
            SQLEX = "SELECT  SUM(item_qty) 'issuedQty'  FROM daily_sales_detail "
            SQLEX += " INNER JOIN inventory_master "
            SQLEX += "  ON (daily_sales_detail.item_invcode = inventory_master.a_code)"
            SQLEX += "  INNER JOIN daily_sales_master "
            SQLEX += "  ON (daily_sales_detail.sales_sys = daily_sales_master.SysPK)"
            SQLEX += " WHERE item_invcode='" & a_code & "'"
            SQLEX += " AND DATE(daily_sales_detail.date_created) BETWEEN '" & Format(dateFromstr, "yyyy-MM-dd") & "'"
            SQLEX += " AND '" & Format(dateTostr, "yyyy-MM-dd") & "'"
            SQLEX += " AND daily_sales_master.status <> 'VOID'"



            MeData = Nothing
            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then

                Dim totalAdd As Integer = 0

                Try
                    If MeData.Rows(0).Item("issuedQty").ToString <> "" Then
                        totalAdd = CInt(MeData.Rows(0).Item("issuedQty").ToString)
                        runningIssued += totalAdd
                    End If

                Catch ex As Exception

                End Try

                If totalAdd > 0 Then
                    txtIssueC1 = totalAdd

                    
                Else
                    txtIssueC1 = 0

                End If
            End If


            Dim totalEndC1 As Integer = (runningBeg + runningRec) - (runningPO + runningIssued)

            dgvBeginning.Rows.Item(rownumber).Cells(6).Value = totalEndC1

        Next

        Cursor = Cursors.Default
        MsgBox("BEGINNING BALANCE VALUE UPDATED. CLICK SAVE BUTTON TO REFLECT CHANGES.", MsgBoxStyle.Information)

        btnSave.Enabled = True
    End Sub
End Class