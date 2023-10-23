Imports System.Data.SqlClient
Imports System.Threading
Imports System.ComponentModel

Public Class fmaIssuanceSummarySheetForm


    Dim ROW_INDEX As Integer = 0
    Dim COL_INDEX As Integer = 0

    Dim sql As String
    Dim reader As SqlDataReader
    Dim command As SqlCommand

    Private objFrmSearch As New ShowLoading
    Private objFrmGen As New ShowLoading

    Private thSearch As Threading.Thread
    Private thGen As Threading.Thread


    Private Event EditAllowed()




    Private searched As Boolean = False


    Private ColumnType As New List(Of String)
    Private PAYMENTTYPECOUNT As Integer = 0

    Private PTypeDic As New Dictionary(Of Integer, String)

    Private editedColumnList As New List(Of Integer)

    Private Sub fmaIssuanceSummarySheetForm_EditAllowed() Handles Me.EditAllowed
        btnSave.Enabled = True
    End Sub



    Private Sub fmaARPAWorkSheetForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        txtYear.Value = Date.Now
        dtpDateMonthof.DataSource = months
        dtpDateMonthof.SelectedIndex = Date.Now.Month - 1


        'dateFrom.Value = New DateTime(Date.Now.Year, Date.Now.Month - 1, 1)

        'Dim SQLEX As String = "SELECT IF(paymentgroup='0','Private','Government') 'type',paymentgroup FROM pharmaceuticals"
        'SQLEX += " GROUP BY type"
        'SQLEX += " ORDER BY paymentgroup"

        Dim SQLEX As String = "SELECT  supplier_type 'id',	case when supplier_type = 0 then 'Private' else 'Government' end as 'name'	FROM	supplier "
        SQLEX += " GROUP BY supplier_type"
        SQLEX += " ORDER BY name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.cmbClassification.DataSource = MeData
        Me.cmbClassification.DisplayMember = "name"
        Me.cmbClassification.ValueMember = "id"
        Me.cmbClassification.SelectedIndex = 0



        displayHeaders()
        displaySuppliers()

    End Sub

    Private Sub displayHeaders()

        Dim SQLEX As String = "SELECT a_code, a_name, payment_type FROM patient_type"
        SQLEX += " WHERE status <> 0  ORDER BY patient_type, a_code"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        PTypeDic.Add(3, "add")
        PTypeDic.Add(4, "pullout")
        PTypeDic.Add(5, "stock")

        dgvBeginning.Columns.Item(2).HeaderText = "BEGINNING BALANCE as of " & dtpDateMonthof.Text
        dgvBeginning.Columns.Item(2).ReadOnly = True


        Dim columnCount As Integer = dgvBeginning.Columns.Count
        'PAYMENTTYPECOUNT = MeData.Rows.Count
        If MeData.Rows.Count > 0 Then
            For cnt As Integer = 0 To MeData.Rows.Count - 1
                Dim columnHeader As String = MeData.Rows(cnt).Item("a_name").ToString + " " + MeData.Rows(cnt).Item("payment_type").ToString
                dgvBeginning.Columns.Add(MeData.Rows(cnt).Item("a_name").ToString, columnHeader)
                dgvBeginning.Columns.Item(columnCount).Width = 100
                dgvBeginning.Columns.Item(columnCount).DefaultCellStyle.Format = "#,##0.00"
                dgvBeginning.Columns.Item(columnCount).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvBeginning.Columns.Item(columnCount).ReadOnly = False
                dgvBeginning.Columns.Item(columnCount).Tag = MeData.Rows(cnt).Item("payment_type").ToString
                PTypeDic.Add(columnCount, MeData.Rows(cnt).Item("a_code").ToString)

                columnCount += 1
                'ColumnType.Add(MeData.Rows(cnt).Item("payment_type").ToString)
                ColumnType.Add("0.00")
            Next
        End If

        'total issuances
        dgvBeginning.Columns.Add("TOTAL ISSUANCES", "TOTAL ISSUACNES " & dtpDateMonthof.Text)

        dgvBeginning.Columns.Item(columnCount).Width = 100
        dgvBeginning.Columns.Item(columnCount).DefaultCellStyle.Format = "#,##0.00"
        dgvBeginning.Columns.Item(columnCount).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBeginning.Columns.Item(columnCount).ReadOnly = True

        PTypeDic.Add(columnCount, "TOTALISSUE")
        columnCount += 1

        'ending balance
        dgvBeginning.Columns.Add("TOTALINV", "END BALANCE as of " & dtpDateMonthof.Text)

        dgvBeginning.Columns.Item(columnCount).Width = 100
        dgvBeginning.Columns.Item(columnCount).DefaultCellStyle.Format = "#,##0.00"
        dgvBeginning.Columns.Item(columnCount).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBeginning.Columns.Item(columnCount).ReadOnly = True

        PTypeDic.Add(columnCount, "TOTALINV")
        columnCount += 1

        dgvBeginning.Columns.Add("SysPK", "SysPK")
        dgvBeginning.Columns.Item(columnCount).Width = 100
        dgvBeginning.Columns.Item(columnCount).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBeginning.Columns.Item(columnCount).ReadOnly = True
        dgvBeginning.Columns.Item(columnCount).Visible = False

        PTypeDic.Add(columnCount, "SysPK")


        'ColumnType.Add("")
        PAYMENTTYPECOUNT = columnCount
    End Sub

    Private Sub displaySuppliers()
        dgvBeginning.Rows.Clear()
        Dim SQLEX As String = "SELECT a_code, a_name 'name' FROM pharmaceuticals"
        'SQLEX += " WHERE paymentgroup='" & txtClassificationCode.Text & "'"
        SQLEX += " ORDER BY a_name"

        'Dim SQLEX As String = "SELECT 	SysPK 'id',	a_name 'name' FROM	supplier"
        'SQLEX += " WHERE supplier_type = '" & Me.txtClassificationCode.Text & "'"
        'SQLEX += " ORDER BY a_name"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)



        If MeData.Rows.Count > 0 Then
            Try
                For cnt As Integer = 0 To MeData.Rows.Count - 1
                    Dim supplierlist As New List(Of String)
                    supplierlist.Add(cnt + 1)
                    supplierlist.Add(MeData.Rows(cnt).Item("name").ToString())
                    supplierlist.Add("")
                    supplierlist.Add("")
                    supplierlist.Add("")
                    supplierlist.Add("")
                    supplierlist.AddRange(ColumnType)
                    dgvBeginning.Rows.Add(supplierlist.ToArray)
                Next

            Catch ex As Exception

            End Try
        End If

        Dim totalist As New List(Of String)

        totalist.Add("#")
        totalist.Add("TOTAL")
        totalist.Add("")
        totalist.Add("")
        totalist.Add("")
        totalist.Add("")
        totalist.AddRange(ColumnType)
        dgvBeginning.Rows.Add(totalist.ToArray)
        dgvBeginning.Rows.Item(MeData.Rows.Count).DefaultCellStyle.Font = New Font("Arial",
                               10,
                               FontStyle.Bold)
        dgvBeginning.Rows.Item(MeData.Rows.Count).ReadOnly = True
    End Sub

    Private Sub loadValues()
        Dim rowcount As Integer = dgvBeginning.Rows.Count

        For jRows As Integer = 0 To (rowcount - 1)
            Dim Supplier As String = ""
            Dim BeginninBalance As String = ""


            Supplier = dgvBeginning.Item(1, jRows).Value.ToString()

            ' get Last Ending Balance then put it as beginning balance
            BeginninBalance = getLastEndingBalance(Supplier)

            dgvBeginning.Item(2, jRows).Value = BeginninBalance

            Dim sysPK As String = getSysPK(Supplier)
            dgvBeginning.Item(dgvBeginning.ColumnCount - 1, jRows).Value = sysPK




            For pcount As Integer = 3 To 5
                Dim conditionString As String = ""
                'Dim rowName As Integer = dgvBeginning.Item(pcount, jRows).ColumnIndex
                'Dim selectCol As String = dgvBeginning

                conditionString = PTypeDic.Item(pcount).ToString
                ' added
                If conditionString = "add" Then

                    Dim SQLEX As String = "SELECT SUM(ris_details.qty_received * ris_details.price ) 'added'
                                            FROM ris_details
                                            INNER JOIN ris_master  ON (ris_details.RIS_Master_No = ris_master.RIS_No)"
                    SQLEX += " WHERE fund_class_id='" & sysPK & "'"
                    SQLEX += " AND DATE(date_received) BETWEEN '" & Format(dateFrom.Value, "yyyy-MM-dd") & "'"
                    SQLEX += " AND '" & Format(dateTo.Value, "yyyy-MM-dd") & "'"
                    SQLEX += " GROUP BY RIS_No"


                    Dim MeData As DataTable
                    MeData = clsDBConn.ExecQuery(SQLEX)

                    If MeData.Rows.Count > 0 Then
                        Dim value As Double = 0

                        For index As Integer = 0 To MeData.Rows.Count - 1
                            Dim rec_val As Double = 0
                            Try
                                rec_val = CDbl(MeData.Rows(index).Item("added"))
                            Catch ex As Exception

                            End Try
                            value += rec_val

                        Next

                        Try
                            'value = CDbl(MeData.Rows(0).Item("added").ToString)
                            dgvBeginning.Item(pcount, jRows).Value = Format(value, "#,##.00")
                        Catch ex As Exception
                            dgvBeginning.Item(pcount, jRows).Value = "-"
                        End Try
                    Else
                        dgvBeginning.Item(pcount, jRows).Value = "-"

                    End If

                End If

                ' pulled-out
                If conditionString = "pullout" Then

                    Dim SQLEX As String = "SELECT SUM(pullout_qty) 'pull-out' FROM inventory_replenishment WHERE fund_cluster='" & sysPK & "'"
                    SQLEX += " AND DATE(date_added) BETWEEN '" & Format(dateFrom.Value, "yyyy-MM-dd") & "'"
                    SQLEX += " AND '" & Format(dateTo.Value, "yyyy-MM-dd") & "'"

                    Dim MeData As DataTable
                    MeData = clsDBConn.ExecQuery(SQLEX)

                    If MeData.Rows.Count > 0 Then
                        Dim value As Double = 0
                        Try
                            value = CDbl(MeData.Rows(0).Item("pull-out").ToString)
                            dgvBeginning.Item(pcount, jRows).Value = Format(value, "#,##.00")
                        Catch ex As Exception
                            dgvBeginning.Item(pcount, jRows).Value = "-"
                        End Try
                    Else
                        dgvBeginning.Item(pcount, jRows).Value = "-"

                    End If

                End If

                If BeginninBalance <> "" Then

                End If
            Next

            ' valued

            For pcount As Integer = 6 To PAYMENTTYPECOUNT

                Dim conditionString As String = ""
                conditionString = PTypeDic.Item(pcount).ToString

                'TOTALINV
                If conditionString <> "TOTALINV" And conditionString <> "TOTALISSUE" Then

                    'Dim SQLEX As String = "SELECT `daily_sales_master`.`SysPK`"
                    'SQLEX += " , `daily_sales_master`.`transactionno`"
                    'SQLEX += " , `inventory_master`.`consignee`"
                    'SQLEX += " , `daily_sales_master`.`charging`"
                    'SQLEX += " ,SUM((daily_sales_detail.item_qty * inventory_master.item_buyprice)) 'TOTALCOST'"
                    'SQLEX += " ,SUM((daily_sales_detail.item_qty * daily_sales_detail.item_price)) 'TOTALSALES'"
                    'SQLEX += " ,(SUM((daily_sales_detail.item_qty * daily_sales_detail.item_price))) "
                    'SQLEX += " - (SUM((daily_sales_detail.item_qty * inventory_master.item_buyprice))) 'REVENUE'   "
                    'SQLEX += " FROM .`daily_sales_master`"
                    'SQLEX += " INNER JOIN .`daily_sales_detail` "
                    'SQLEX += " ON (`daily_sales_master`.`SysPK` = `daily_sales_detail`.`sales_sys`)"
                    'SQLEX += " INNER JOIN .`inventory_master` "
                    'SQLEX += " ON (`daily_sales_detail`.`item_invcode` = `inventory_master`.`a_code`)"
                    'SQLEX += " WHERE DATE(tr_date) Between '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
                    'SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
                    'SQLEX += " AND daily_sales_master.chargingid='" & conditionString & "'"
                    'SQLEX += " AND daily_sales_master.status <> 'VOID'"
                    'SQLEX += " AND consignee='" & Supplier & "'"
                    'SQLEX += " GROUP BY consignee,charging"
                    'SQLEX += " ORDER BY consignee, charging"
                    Dim SQLEX As String = "SELECT SUM(daily_sales_detail.item_qty)  'item_qty', 
                                            ris_details.price , 
                                            (SUM(daily_sales_detail.item_qty)  * ris_details.price ) 'totalcost' 
                                            FROM daily_sales_master 
                                            INNER JOIN daily_sales_detail ON (daily_sales_master.SysPK = daily_sales_detail.sales_sys)  
                                            INNER JOIN ris_details  ON (daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No)  
                                            INNER JOIN ris_master ON (ris_details.RIS_Master_No = ris_master.RIS_No)"

                    SQLEX += " WHERE DATE(tr_date) Between '" & Format(Me.dateFrom.Value, "yyyy-MM-dd") & "'"
                    SQLEX += " AND '" & Format(Me.dateTo.Value, "yyyy-MM-dd") & "'"
                    SQLEX += " AND daily_sales_master.chargingid='" & conditionString & "'"
                    SQLEX += " AND daily_sales_master.status <> 'VOID'"
                    SQLEX += " AND ris_master.fund_class_id='" & sysPK & "'"
                    SQLEX += " GROUP BY item_invcode"
                    SQLEX += " ORDER BY item_descr"

                    Dim MeDataTOTAL As DataTable
                    MeDataTOTAL = clsDBConn.ExecQuery(SQLEX)

                    If MeDataTOTAL.Rows.Count > 0 Then
                        Try
                            Dim totalPerCharging As Double = 0
                            For index As Integer = 0 To MeDataTOTAL.Rows.Count - 1

                                If MeDataTOTAL.Rows(index).Item("totalcost").ToString <> "" Then
                                    totalPerCharging += CDbl(MeDataTOTAL.Rows(index).Item("totalcost").ToString)
                                End If


                            Next


                            dgvBeginning.Item(pcount, jRows).Value = Format(totalPerCharging, "#,##0.00")
                        Catch ex As Exception
                            dgvBeginning.Item(pcount, jRows).Value = ""
                        End Try
                    End If

                Else
                    'get paymenttype


                End If

            Next



            'If sysPK <> "" Then
            '    ' get Beginning Balance
            '    Dim SQLBegBal As String = "SELECT beginning_value FROM issuance_summary_master"
            '    SQLBegBal += " WHERE sysPk='" & sysPK & "'"

            '    Dim begBalDTable As DataTable
            '    begBalDTable = clsDBConn.ExecQuery(SQLBegBal)

            '    If begBalDTable.Rows.Count > 0 Then
            '        Try
            '            Dim amount As Double = 0
            '            amount = CDbl(begBalDTable.Rows(0).Item("beginning_value").ToString)
            '            dgvBeginning.Item(2, jRows).Value = Format(amount, "#,##0.00")
            '            editStockOnHand(jRows)

            '        Catch ex As Exception

            '        End Try
            '    End If
            '    Continue For
            'End If

            'If BeginninBalance <> "" Then
            '    editStockOnHand(jRows)
            'End If


        Next
    End Sub


    Private Sub dgvBeginning_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBeginning.CellEndEdit

        Dim cellvalue As Double = 0

        ROW_INDEX = e.RowIndex
        COL_INDEX = e.ColumnIndex

        If Not editedColumnList.Contains(ROW_INDEX) Then
            editedColumnList.Add(ROW_INDEX)
            RaiseEvent EditAllowed()

        End If




        Try
            cellvalue = CDbl(dgvBeginning.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvBeginning.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value = Format(cellvalue, "#,##0.00")
        Catch ex As Exception
            MsgBox("Please Enter Number only.")
            dgvBeginning.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value = ""
        End Try

        editStockOnHand()
    End Sub

    Private Sub editStockOnHand()
        'displaySuppliers()

        If COL_INDEX <> 2 Then
            Exit Sub
        End If



        Dim beginningValue As Double = 0
        Dim AddedValue As Double = 0
        Dim PulledOutValue As Double = 0
        Dim totalStock As Double = 0

        Dim valuestring As String = ""
        If dgvBeginning.Rows.Item(ROW_INDEX).Cells(2).Value <> "" Then
            valuestring = dgvBeginning.Rows.Item(ROW_INDEX).Cells(2).Value
            valuestring = valuestring.Replace(",", "")

            beginningValue = CDbl(valuestring)
        End If

        If dgvBeginning.Rows.Item(ROW_INDEX).Cells(3).Value <> "-" Then
            AddedValue = CDbl(dgvBeginning.Rows.Item(ROW_INDEX).Cells(3).Value)
        End If

        If dgvBeginning.Rows.Item(ROW_INDEX).Cells(4).Value <> "-" Then
            PulledOutValue = CDbl(dgvBeginning.Rows.Item(ROW_INDEX).Cells(4).Value)
        End If


        totalStock = (beginningValue + AddedValue) - PulledOutValue

        dgvBeginning.Rows.Item(ROW_INDEX).Cells(5).Value = Format(totalStock, "#,##0.00")

        Dim totalIssued As Double = 0


        For pcount As Integer = 6 To PAYMENTTYPECOUNT

            Dim conditionString As String = ""
            conditionString = PTypeDic.Item(pcount).ToString

            If conditionString = "SysPK" Then
                Continue For
            End If

            'TOTALINV
            If conditionString = "TOTALINV" Then
                dgvBeginning.Rows.Item(ROW_INDEX).Cells(pcount).Value = Format(totalStock - totalIssued, "#,##0.00")
            ElseIf conditionString = "TOTALISSUE" Then
                dgvBeginning.Rows.Item(ROW_INDEX).Cells(pcount).Value = Format(totalIssued, "#,##0.00")
            Else
                Dim valuestr As String = dgvBeginning.Rows.Item(ROW_INDEX).Cells(pcount).Value
                totalIssued += CDbl(dgvBeginning.Rows.Item(ROW_INDEX).Cells(pcount).Value)
            End If

        Next


    End Sub

    Private Sub editStockOnHand(ByVal inRow_Index As Integer)
        'displaySuppliers()



        Dim beginningValue As Double = 0
        Dim AddedValue As Double = 0
        Dim PulledOutValue As Double = 0
        Dim totalStock As Double = 0

        Dim valuestring As String = ""
        If dgvBeginning.Rows.Item(inRow_Index).Cells(2).Value <> "" Then
            valuestring = dgvBeginning.Rows.Item(inRow_Index).Cells(2).Value
            valuestring = valuestring.Replace(",", "")
            If valuestring = "-" Then
                beginningValue = 0
            Else
                beginningValue = CDbl(valuestring)
            End If

        End If

        If dgvBeginning.Rows.Item(inRow_Index).Cells(3).Value <> "-" Then
            AddedValue = CDbl(dgvBeginning.Rows.Item(inRow_Index).Cells(3).Value)
        End If

        If dgvBeginning.Rows.Item(inRow_Index).Cells(4).Value <> "-" Then
            PulledOutValue = CDbl(dgvBeginning.Rows.Item(inRow_Index).Cells(4).Value)
        End If


        totalStock = (beginningValue + AddedValue) - PulledOutValue

        dgvBeginning.Rows.Item(inRow_Index).Cells(5).Value = Format(totalStock, "#,##0.00")

        Dim totalIssued As Double = 0


        For pcount As Integer = 6 To PAYMENTTYPECOUNT

            Dim conditionString As String = ""
            conditionString = PTypeDic.Item(pcount).ToString

            If conditionString = "SysPK" Then
                Continue For
            End If

            'TOTALINV
            If conditionString = "TOTALINV" Then
                dgvBeginning.Rows.Item(inRow_Index).Cells(pcount).Value = Format(totalStock - totalIssued, "#,##0.00")
            ElseIf conditionString = "TOTALISSUE" Then
                dgvBeginning.Rows.Item(inRow_Index).Cells(pcount).Value = Format(totalIssued, "#,##0.00")
            Else
                totalIssued += CDbl(dgvBeginning.Rows.Item(inRow_Index).Cells(pcount).Value)
            End If

        Next


    End Sub

    Private Sub dtpDateMonthof_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateMonthof.SelectedIndexChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value.Year, dtpDateMonthof.SelectedIndex + 1, 1)
            dgvBeginning.Columns.Item(2).HeaderText = "BEGINNING BALANCE as of " & dtpDateMonthof.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged
        Try
            dateTo.Value = New DateTime(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.AddMonths(1).AddDays(-1).Day)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'showLoadingSearch()
        dgvBeginning.Columns.Item(2).ReadOnly = False
        editedColumnList.Clear()
        btnSave.Enabled = False
        'dgvBeginning.Rows.Clear()
        'displayHeaders()
        displaySuppliers()

        loadValues()
        'Thread.Sleep(1000)


        'If Me.InvokeRequired Then
        '    thSearch.Abort()
        '    objFrmSearch.Close()
        'Else
        '    Me.Invoke(New _SubName(AddressOf stopThreadSearch))
        'End If

    End Sub


    Private Sub showLoadingSearch()
        If Me.InvokeRequired Then
            objFrmSearch.setMessage("Loading Summary Data...")
            If objFrmSearch.ShowDialog() = Windows.Forms.DialogResult.Abort Then

            End If

        Else
            'Start the thread that will execute this method
            thSearch = New Threading.Thread(AddressOf showLoadingSearch)
            thSearch.IsBackground = True
            thSearch.Start()

        End If



    End Sub

    Private Sub stopThreadSearch()
        thSearch.Abort()
        objFrmSearch.Close()
    End Sub

    Delegate Sub _SubName()

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Are you sure you want to SAVE CHANGES?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            SaveChanges()
            MsgBox("Changes Saved.", MsgBoxStyle.Information)
            btnSave.Enabled = False
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SaveChanges()

        For rownumber As Integer = 0 To dgvBeginning.Rows.Count - 1

            Dim SysPK As String = System.Guid.NewGuid.GetHashCode

            Dim inRowIndex As Integer = rownumber

            Dim beginningValue As Double = 0
            Dim AddedValue As Double = 0
            Dim PulledOutValue As Double = 0
            Dim totalStock As Double = 0
            Dim supplier As String = ""
            Dim totalIssuance As Double = 0

            If dgvBeginning.Rows.Item(inRowIndex).Cells(0).Value = "#" Then
                Continue For
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(1).Value <> "" Then
                supplier = dgvBeginning.Rows.Item(inRowIndex).Cells(1).Value.ToString
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(2).Value <> "" Then
                beginningValue = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(2).Value)
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(3).Value <> "-" Then
                AddedValue = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(3).Value)
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value <> "-" Then
                PulledOutValue = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value)
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value <> "-" Then
                totalIssuance = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value)
            End If


            totalStock = (beginningValue + AddedValue) - PulledOutValue

            'CHECK IF ALREADY IN DB.
            Dim ifExists As String = "SELECT sysPk FROM issuance_summary_master"
            ifExists += " WHERE supplier='" & supplier & "'"
            ifExists += " AND dateFrom='" & Format(dateFrom.Value, "yyyy-MM-dd") & "'"
            ifExists += " AND dateTo='" & Format(dateTo.Value, "yyyy-MM-dd") & "'"

            Dim dtExists As DataTable
            dtExists = clsDBConn.ExecQuery(ifExists)

            If dtExists.Rows.Count > 0 Then
                ' Existed, so Update data

                Dim oldSysPK As String = dtExists.Rows(0).Item("sysPk").ToString

                ' remove master first
                Dim SQLDEL As String = "DELETE FROM issuance_summary_master WHERE sysPk='" & oldSysPK & "'"
                clsDBConn.ExecuteSilence(SQLDEL)

                ' remove details
                SQLDEL = "DELETE FROM issuance_summary_detail"
                SQLDEL += " WHERE masterSysPK='" & oldSysPK & "'"
                clsDBConn.ExecuteSilence(SQLDEL)


                ' insert new record
                Dim ending_value As Double = 0

                For pcount As Integer = 6 To PAYMENTTYPECOUNT
                    Dim conditionString As String = ""
                    conditionString = PTypeDic.Item(pcount).ToString

                    If conditionString = "SysPK" Or conditionString = "TOTALINV" _
                    Or conditionString = "TOTALISSUE" Then
                        Continue For
                    End If

                    Dim amount As Double = 0

                    Try
                        amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        ending_value += amount

                    Catch ex As Exception

                    End Try

                Next



                Dim SQLIN As String = "INSERT INTO issuance_summary_master("
                SQLIN += " sysPk,dateFrom,dateTo,"
                SQLIN += " month,supplier,"
                SQLIN += " beginning_value,added,"
                SQLIN += " pulled_out,onhand_stock,ending_value,"
                SQLIN += " type,totalIssuance)"
                SQLIN += " VALUES("
                SQLIN += String.Format(" '{0}', '{1}','{2}',", SysPK, Format(dateFrom.Value, "yyyy-MM-dd"), Format(dateTo.Value, "yyyy-MM-dd"))
                SQLIN += String.Format(" '{0}', '{1}',", Format(dateFrom.Value, "MMMM"), supplier)
                SQLIN += String.Format(" '{0}', '{1}',", beginningValue, AddedValue)
                SQLIN += String.Format(" '{0}', '{1}', '{2}',", PulledOutValue, totalStock, totalStock - ending_value)
                SQLIN += String.Format(" '{0}','{1}')", 1, ending_value)


                If clsDBConn.Execute(SQLIN) Then
                    'MsgBox("Row Index " & inRowIndex & " Save", MsgBoxStyle.Information)

                    For pcount As Integer = 6 To PAYMENTTYPECOUNT
                        Dim conditionString As String = ""
                        conditionString = PTypeDic.Item(pcount).ToString

                        If conditionString = "SysPK" Or conditionString = "TOTALINV" Then
                            Continue For
                        End If

                        Dim amount As Double = 0

                        Try
                            amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        Catch ex As Exception

                        End Try

                        Dim SQLIN_Details As String = "INSERT INTO issuance_summary_detail("
                        SQLIN_Details += " masterSysPK,amount,paymentType)"
                        SQLIN_Details += " VALUES("
                        SQLIN_Details += String.Format(" '{0}', '{1}',", SysPK, amount)
                        SQLIN_Details += String.Format(" '{0}')", conditionString)

                        clsDBConn.Execute(SQLIN_Details)

                    Next
                End If


            Else
                ' new record
                Dim ending_value As Double = 0

                For pcount As Integer = 6 To PAYMENTTYPECOUNT
                    Dim conditionString As String = ""
                    conditionString = PTypeDic.Item(pcount).ToString

                    If conditionString = "SysPK" Or conditionString = "TOTALINV" _
                    Or conditionString = "TOTALISSUE" Then
                        Continue For
                    End If

                    Dim amount As Double = 0

                    Try
                        amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        ending_value += amount

                    Catch ex As Exception

                    End Try

                Next



                Dim SQLIN As String = "INSERT INTO issuance_summary_master("
                SQLIN += " sysPk,dateFrom,dateTo,"
                SQLIN += " month,supplier,"
                SQLIN += " beginning_value,added,"
                SQLIN += " pulled_out,onhand_stock,ending_value,"
                SQLIN += " type,totalIssuance)"
                SQLIN += " VALUES("
                SQLIN += String.Format(" '{0}', '{1}','{2}',", SysPK, Format(dateFrom.Value, "yyyy-MM-dd"), Format(dateTo.Value, "yyyy-MM-dd"))
                SQLIN += String.Format(" '{0}', '{1}',", Format(dateFrom.Value, "MMMM"), supplier)
                SQLIN += String.Format(" '{0}', '{1}',", beginningValue, AddedValue)
                SQLIN += String.Format(" '{0}', '{1}', '{2}',", PulledOutValue, totalStock, totalStock - ending_value)
                SQLIN += String.Format(" '{0}','{1}')", 1, ending_value)


                If clsDBConn.Execute(SQLIN) Then
                    'MsgBox("Row Index " & inRowIndex & " Save", MsgBoxStyle.Information)

                    For pcount As Integer = 6 To PAYMENTTYPECOUNT
                        Dim conditionString As String = ""
                        conditionString = PTypeDic.Item(pcount).ToString

                        If conditionString = "SysPK" Or conditionString = "TOTALINV" Then
                            Continue For
                        End If

                        Dim amount As Double = 0

                        Try
                            amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        Catch ex As Exception

                        End Try

                        Dim SQLIN_Details As String = "INSERT INTO issuance_summary_detail("
                        SQLIN_Details += " masterSysPK,amount,paymentType)"
                        SQLIN_Details += " VALUES("
                        SQLIN_Details += String.Format(" '{0}', '{1}',", SysPK, amount)
                        SQLIN_Details += String.Format(" '{0}')", conditionString)

                        clsDBConn.Execute(SQLIN_Details)

                    Next
                End If
            End If

        Next
    End Sub


    Private Function getSysPK(ByVal supplier As String) As String
        Dim sysPK As String = ""

        Dim SQLEX As String = "SELECT SysPK FROM pharmaceuticals WHERE a_name='" & supplier & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                sysPK = MeData.Rows(0).Item("SysPK").ToString
            Catch ex As Exception

            End Try
        End If


        Return sysPK
    End Function

    Private Sub cmbClassification_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClassification.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbClassification.SelectedItem, DataRowView)
            Me.txtClassificationCode.Text = drv.Item("paymentgroup").ToString
        Catch ex As Exception
            Me.txtClassificationCode.Text = ""
        End Try
    End Sub

    Private Sub txtClassificationCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClassificationCode.TextChanged
        If txtClassificationCode.Text <> "" Then
            displaySuppliers()
            dgvBeginning.Columns.Item(2).ReadOnly = True
        End If
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim SQLEX As String = "SELECT sysPk,supplier, beginning_value,added,"
        SQLEX += " pulled_out, onhand_stock, ending_value,totalIssuance"
        SQLEX += " FROM issuance_summary_master"
        SQLEX += " WHERE dateFrom='" & Format(dateFrom.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND dateTo='" & Format(dateTo.Value, "yyyy-MM-dd") & "'"
        SQLEX += " AND type='" & 1 & "'"
        SQLEX += " ORDER BY supplier"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count = 0 Then
            btnSave.Enabled = True
            If MessageBox.Show("DATA ON THE DATE SPECIFIED IS NOT YET SAVED. DO YOU WANT TO SAVE CHANGES?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                saveChangesAuto()
                Exit Sub
            Else
                Exit Sub
            End If
        End If


        Dim new_report As New fzzReportViewerForm

        Dim reportTitle As String = "SUMMARY REPORT OF ISSUANCES AND BALANCES OF DRUGS AND MEDICINES FOR THE MONTH OF " _
                                    & dtpDateMonthof.Text & " " & txtYear.Text
        Dim paramdateFrom As String = Format(dateFrom.Value, "yyyy-MM-dd")
        Dim paramdateTo As String = Format(dateTo.Value, "yyyy-MM-dd")

        Dim monthOf As String = dtpDateMonthof.Text & " " & txtYear.Text
        Try
            new_report.AttachReport(SQLEX, reportTitle) = New rptMonthlySummaryIssuance_Balances(paramdateFrom, paramdateTo, monthOf, 1)
            new_report.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.ValueChanged
        Try
            dateFrom.Value = New DateTime(txtYear.Value.Year, dtpDateMonthof.SelectedIndex + 1, 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Function getLastEndingBalance(ByVal supplier As String) As String
        Dim lastMonthDate As Date = New Date(dateFrom.Value.Year, dateFrom.Value.AddMonths(-1).Month, 1)
        Dim value As String = "-"
        Dim SQLEX As String = "SELECT ending_value FROM issuance_summary_master"
        SQLEX += " WHERE dateFrom='" & Format(lastMonthDate, "yyyy-MM-dd") & "'"
        SQLEX += " AND supplier='" & supplier & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                Dim endingBal As Double = 0
                endingBal = CDbl(MeData.Rows(0).Item("ending_value").ToString)
                value = Format(endingBal, "#,##0.00")
            Catch ex As Exception

            End Try
        End If

        Return value
    End Function

    Private Sub saveChangesAuto()
        Cursor = Cursors.WaitCursor



        For rownumber As Integer = 0 To dgvBeginning.Rows.Count - 1

            Dim SysPK As String = System.Guid.NewGuid.GetHashCode

            Dim inRowIndex As Integer = rownumber

            Dim beginningValue As Double = 0
            Dim AddedValue As Double = 0
            Dim PulledOutValue As Double = 0
            Dim totalStock As Double = 0
            Dim supplier As String = ""
            Dim totalIssuance As Double = 0

            If dgvBeginning.Rows.Item(inRowIndex).Cells(1).Value <> "" Then
                supplier = dgvBeginning.Rows.Item(inRowIndex).Cells(1).Value.ToString
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(2).Value <> "" And dgvBeginning.Rows.Item(inRowIndex).Cells(2).Value <> "-" Then
                beginningValue = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(2).Value)

            End If



            If dgvBeginning.Rows.Item(inRowIndex).Cells(3).Value <> "-" Then
                AddedValue = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(3).Value)
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value <> "-" Then
                PulledOutValue = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value)
            End If

            If dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value <> "-" Then
                totalIssuance = CDbl(dgvBeginning.Rows.Item(inRowIndex).Cells(4).Value)
            End If


            totalStock = (beginningValue + AddedValue) - PulledOutValue

            'CHECK IF ALREADY IN DB.
            Dim ifExists As String = "SELECT sysPk FROM issuance_summary_master"
            ifExists += " WHERE supplier='" & supplier & "'"
            ifExists += " AND dateFrom='" & Format(dateFrom.Value, "yyyy-MM-dd") & "'"
            ifExists += " AND dateTo='" & Format(dateTo.Value, "yyyy-MM-dd") & "'"

            Dim dtExists As DataTable
            dtExists = clsDBConn.ExecQuery(ifExists)

            If dtExists.Rows.Count > 0 Then
                ' Existed, so Update data

                Dim oldSysPK As String = dtExists.Rows(0).Item("sysPk").ToString

                ' remove master first
                Dim SQLDEL As String = "DELETE FROM issuance_summary_master WHERE sysPk='" & oldSysPK & "'"
                clsDBConn.ExecuteSilence(SQLDEL)

                ' remove details
                SQLDEL = "DELETE FROM issuance_summary_detail"
                SQLDEL += " WHERE masterSysPK='" & oldSysPK & "'"
                clsDBConn.ExecuteSilence(SQLDEL)


                ' insert new record
                Dim ending_value As Double = 0

                For pcount As Integer = 6 To PAYMENTTYPECOUNT
                    Dim conditionString As String = ""
                    conditionString = PTypeDic.Item(pcount).ToString

                    If conditionString = "SysPK" Or conditionString = "TOTALINV" _
                    Or conditionString = "TOTALISSUE" Then
                        Continue For
                    End If

                    Dim amount As Double = 0

                    Try
                        amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        ending_value += amount

                    Catch ex As Exception

                    End Try

                Next



                Dim SQLIN As String = "INSERT INTO issuance_summary_master("
                SQLIN += " sysPk,dateFrom,dateTo,"
                SQLIN += " month,supplier,"
                SQLIN += " beginning_value,added,"
                SQLIN += " pulled_out,onhand_stock,ending_value,"
                SQLIN += " type,totalIssuance)"
                SQLIN += " VALUES("
                SQLIN += String.Format(" '{0}', '{1}','{2}',", SysPK, Format(dateFrom.Value, "yyyy-MM-dd"), Format(dateTo.Value, "yyyy-MM-dd"))
                SQLIN += String.Format(" '{0}', '{1}',", Format(dateFrom.Value, "MMMM"), supplier)
                SQLIN += String.Format(" '{0}', '{1}',", beginningValue, AddedValue)
                SQLIN += String.Format(" '{0}', '{1}', '{2}',", PulledOutValue, totalStock, totalStock - ending_value)
                SQLIN += String.Format(" '{0}','{1}')", CInt(txtClassificationCode.Text), ending_value)


                If clsDBConn.Execute(SQLIN) Then
                    'MsgBox("Row Index " & inRowIndex & " Save", MsgBoxStyle.Information)

                    For pcount As Integer = 6 To PAYMENTTYPECOUNT
                        Dim conditionString As String = ""
                        conditionString = PTypeDic.Item(pcount).ToString

                        If conditionString = "SysPK" Or conditionString = "TOTALINV" Then
                            Continue For
                        End If

                        Dim amount As Double = 0

                        Try
                            amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        Catch ex As Exception

                        End Try

                        Dim SQLIN_Details As String = "INSERT INTO issuance_summary_detail("
                        SQLIN_Details += " masterSysPK,amount,paymentType)"
                        SQLIN_Details += " VALUES("
                        SQLIN_Details += String.Format(" '{0}', '{1}',", SysPK, amount)
                        SQLIN_Details += String.Format(" '{0}')", conditionString)

                        clsDBConn.Execute(SQLIN_Details)

                    Next
                End If


            Else
                ' new record
                Dim ending_value As Double = 0

                For pcount As Integer = 6 To PAYMENTTYPECOUNT
                    Dim conditionString As String = ""
                    conditionString = PTypeDic.Item(pcount).ToString

                    If conditionString = "SysPK" Or conditionString = "TOTALINV" _
                    Or conditionString = "TOTALISSUE" Then
                        Continue For
                    End If

                    Dim amount As Double = 0

                    Try
                        amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        ending_value += amount

                    Catch ex As Exception

                    End Try

                Next



                Dim SQLIN As String = "INSERT INTO issuance_summary_master("
                SQLIN += " sysPk,dateFrom,dateTo,"
                SQLIN += " month,supplier,"
                SQLIN += " beginning_value,added,"
                SQLIN += " pulled_out,onhand_stock,ending_value,"
                SQLIN += " type,totalIssuance)"
                SQLIN += " VALUES("
                SQLIN += String.Format(" '{0}', '{1}','{2}',", SysPK, Format(dateFrom.Value, "yyyy-MM-dd"), Format(dateTo.Value, "yyyy-MM-dd"))
                SQLIN += String.Format(" '{0}', '{1}',", Format(dateFrom.Value, "MMMM"), supplier)
                SQLIN += String.Format(" '{0}', '{1}',", beginningValue, AddedValue)
                SQLIN += String.Format(" '{0}', '{1}', '{2}',", PulledOutValue, totalStock, totalStock - ending_value)
                SQLIN += String.Format(" '{0}','{1}')", 1, ending_value)


                If clsDBConn.Execute(SQLIN) Then
                    'MsgBox("Row Index " & inRowIndex & " Save", MsgBoxStyle.Information)

                    For pcount As Integer = 6 To PAYMENTTYPECOUNT
                        Dim conditionString As String = ""
                        conditionString = PTypeDic.Item(pcount).ToString

                        If conditionString = "SysPK" Or conditionString = "TOTALINV" Then
                            Continue For
                        End If

                        Dim amount As Double = 0

                        Try
                            amount = dgvBeginning.Rows.Item(inRowIndex).Cells(pcount).Value
                        Catch ex As Exception

                        End Try

                        Dim SQLIN_Details As String = "INSERT INTO issuance_summary_detail("
                        SQLIN_Details += " masterSysPK,amount,paymentType)"
                        SQLIN_Details += " VALUES("
                        SQLIN_Details += String.Format(" '{0}', '{1}',", SysPK, amount)
                        SQLIN_Details += String.Format(" '{0}')", conditionString)

                        clsDBConn.Execute(SQLIN_Details)

                    Next
                End If
            End If

        Next
        MsgBox("Changes Saved.", MsgBoxStyle.Information)
        Cursor = Cursors.Default

    End Sub

End Class