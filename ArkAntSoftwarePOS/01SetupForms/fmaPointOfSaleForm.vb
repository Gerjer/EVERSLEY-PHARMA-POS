Imports System.ComponentModel
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient

Public Class fmaPointOfSaleForm

    Public Event WIN_CLOSED()


    Dim WithEvents numericKey As New fmzNumericKeysForm
    Dim WithEvents removeItemForm As fmaPOS_RemoveItemForm

    Private SHOWSYSMSG As Boolean = False
    Private PROFILEVALIDATION As Boolean = False

    Dim mprinterName As String

    Dim WithEvents itemInquiry As fmaItemIssuanceList   'fmaPOSItemInquiryForm
    Private WithEvents SETUPFORM As fmaPersonProfileSetupForm

    Private ISSUEDTO As String = "PATIENT"

    Dim WithEvents ReceiverPopUp As New fmaReceivedByPopUpForm

    Private RECEIVED_BY As String = ""

    Private isRowsAdded As Boolean = False
    Private startTime As String = ""
    Private endTime As String = ""


#Region "Property Code"
    Public Property PrinterName() As String
        Get
            Return mprinterName
        End Get
        Set(ByVal value As String)
            mprinterName = value
        End Set
    End Property
#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub fmaPointOfSaleForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RaiseEvent WIN_CLOSED()

    End Sub

    Private Sub fmaPointOfSaleForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '    NEW_TRANS = True
        ITEM_LIST = Nothing

        Me.Show()
        Application.DoEvents()
        getPatientList()
        getPatientType()

        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()
        clearItems()


        'Me.btnNewSale.PerformClick()



    End Sub

    Private Sub getPatientList()
        Dim SQLEX As String = "SELECT person_profile.a_code 'pp_code',person_profile.a_name 'pp_aname',patienttype_id, patient_type.a_name 'PATIENTTYPE' "
        SQLEX += "FROM person_profile"
        SQLEX += " INNER JOIN patient_type"
        SQLEX += " ON (`person_profile`.`patienttype_id` = `patient_type`.`a_code`)"
        SQLEX += "  ORDER BY pp_aname"


        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.txtPatientProfile.DataSource = MeData
        Me.txtPatientProfile.DisplayMember = "pp_aname"
        Me.txtPatientProfile.ValueMember = "pp_code"
        Me.txtPatientProfile.Text = ""
        Me.txtPatientProfile.SelectedIndex = -1

        Me.txtPatientTypeID.Text = ""
        Me.txtChargeTo.Text = ""
    End Sub


    Private Sub getWardList()
        Dim SQLEX As String = "SELECT a_code,a_name "
        SQLEX += "FROM ward"
        SQLEX += "  ORDER BY a_name"


        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.txtPatientProfile.DataSource = MeData
        Me.txtPatientProfile.DisplayMember = "a_name"
        Me.txtPatientProfile.ValueMember = "a_code"
        Me.txtPatientProfile.Text = ""
        Me.txtPatientProfile.SelectedIndex = -1

        Me.txtPatientTypeID.Text = ""
        Me.txtChargeTo.Text = ""
    End Sub



    Private Sub getPatientType()
        Dim SQLEX As String = "SELECT a_code, CONCAT(a_name ,'-', payment_type) AS 'PATIENTYPE', display_cost"
        SQLEX += " FROM patient_type "
        SQLEX += " WHERE patient_type <> '2'"
        SQLEX += " ORDER BY patient_type,a_code"


        Dim Medata As DataTable
        Medata = clsDBConn.ExecQuery(SQLEX)

        Me.txtCharging.DataSource = Medata
        Me.txtCharging.DisplayMember = "PATIENTYPE"
        Me.txtCharging.ValueMember = "a_code"
        Me.txtCharging.Text = ""
        Me.txtCharging.SelectedIndex = -1
        Me.txtChargingID.Text = ""
        txtDisplayCost.Text = ""
    End Sub

    Private Sub btnNewSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSale.Click
        If Me.dtgvOrderList.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to CANCEL this transaction?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                clearItems()
            End If

        Else
            Me.txtQty.Text = "1"
            clearItems()
            'Me.dtgvOrderList.Rows.Clear()
            Application.DoEvents()
            Me.txtItemCode.Focus()
            Me.txtItemCode.SelectAll()
            getTransactionNumber()
        End If




    End Sub

    Private Sub clearItems()
        Me.txtQty.Text = "1"

        Me.dtgvOrderList.Rows.Clear()
        Me.txtItemCode.Text = "Enter Item Code ..."
        Me.txtTotalAmt.Text = "0.00"



        Application.DoEvents()
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()

        Me.txtAmtDue.Text = "<>"

        txtPatientProfile.SelectedItem = -1
        'txtPatientProfile.Text = "[F1] - Select Patient Name"
        txtPatientCode.Text = ""
        txtChargeTo.Enabled = True
        txtPatientProfile.Enabled = True
        txtCharging.Enabled = True
        txtCharging.SelectedIndex = -1

        txtChargeTo.Text = ""
        txtPatientTypeID.Text = ""
        txtCharging.SelectedIndex = -1
        txtCharging.Text = ""
        txtChargingID.Text = ""
        txtDisplayCost.Text = ""

        qty_unfilled.Value = 0
        qty_unfilled.Enabled = False
        txtDiscount.Enabled = False

        PROFILEVALIDATION = False
        cxbxSCDiscount.CheckState = CheckState.Unchecked
        cxbxUnfilledPrx.CheckState = CheckState.Unchecked
        'rbtnPatient.Checked = True
        cxbxDiscounted.CheckState = CheckState.Unchecked

        getTransactionNumber()



        isRowsAdded = False
        startTime = ""
        endTime = ""
    End Sub

    Private Sub txtItemCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.Click
        Application.DoEvents()
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()
    End Sub

    Private Sub btnSetQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetQty.Click
        If Me.txtQty.ReadOnly Then
            Me.txtQty.ReadOnly = False
            Me.txtQty.Focus()
            Me.txtQty.SelectAll()
        End If
    End Sub

    Private Sub txtQty_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txtQty.ReadOnly = True
            Me.txtItemCode.Focus()
            Me.txtItemCode.SelectAll()
        End If
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        If Not Me.txtQty.ReadOnly Then
            Me.txtQty.ReadOnly = True
        End If
    End Sub

    Private Sub txtItemCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.GotFocus
        lblSysMsg.Text = "Scan Item BarCode."
        SHOWSYSMSG = True
    End Sub

    Private Sub txtItemCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyUp
        If e.KeyCode = Keys.Enter Then


            If itemInquiry Is Nothing Then
                itemInquiry = New fmaItemIssuanceList  'fmaPOSItemInquiryForm
                itemInquiry.txtSearchKey.Text = Me.txtItemCode.Text
                itemInquiry.ShowDialog()
            End If
            Exit Sub

            Dim SQLEX As String = ""
            If txtDisplayCost.Text = "1" Then
                SQLEX = "SELECT a_name, selling_price 'item_price', ris_details.qty_remaining,ris_master.supplier 'consignee',ris_master.supplier_SysPK 'consignee_id',SysPK,RIS_Det_No FROM inventory_master"
                SQLEX += " INNER JOIN ris_details "
                SQLEX += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
                SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No =  ris_details.RIS_Master_No "
                SQLEX += " WHERE a_code='" & Me.txtItemCode.Text & "' AND qty_remaining >= '" & Me.txtQty.Text & "'"
                SQLEX += " GROUP BY RIS_Det_No"
                SQLEX += " ORDER BY expiry_date"
                SQLEX += " LIMIT 1"

                Dim Medata As DataTable
                Medata = clsDBConn.ExecQuery(SQLEX)

                If Medata.Rows.Count > 0 Then
                    Try
                        Dim remainingItemCount As Double = 0

                        remainingItemCount = CDbl(Medata.Rows(0).Item("qty_remaining").ToString)

                        Dim rowcount As Integer = dtgvOrderList.Rows.Count
                        Dim duplicateItemQty As Integer = 0
                        For jRows As Integer = 0 To (rowcount - 1)

                            Try
                                Dim duplicate As String = dtgvOrderList.Item(0, jRows).Value.ToString
                                If duplicate = Me.txtItemCode.Text Then
                                    duplicateItemQty += CInt(dtgvOrderList.Item(2, jRows).Value)
                                End If

                            Catch ex As Exception

                            End Try
                        Next


                        If remainingItemCount < CDbl(Me.txtQty.Text + duplicateItemQty) Then
                            MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                                    "Inventory Count is Low." & vbNewLine &
                                    "Press [ESC] To Cancel", MsgBoxStyle.Critical)
                            Exit Sub
                        End If


                        Dim n As Integer = dtgvOrderList.Rows.Add()

                        dtgvOrderList.Rows.Item(n).Cells(0).Value = Me.txtItemCode.Text
                        dtgvOrderList.Rows.Item(n).Cells(1).Value = Medata.Rows(0).Item("a_name").ToString
                        dtgvOrderList.Rows.Item(n).Cells(2).Value = CDbl(Me.txtQty.Text)
                        dtgvOrderList.Rows.Item(n).Cells(3).Value = CDbl(Medata.Rows(0).Item("item_price").ToString)

                        Dim totalItemPrice As Double = CDbl(Me.txtQty.Text) * CDbl(Medata.Rows(0).Item("item_price").ToString)

                        Dim totalAmt As Double = totalItemPrice
                        dtgvOrderList.Rows.Item(n).Cells(4).Value = totalAmt

                        dtgvOrderList.Rows.Item(n).Cells(5).Value = Medata.Rows(0).Item("consignee").ToString
                        'consignee_id
                        dtgvOrderList.Rows.Item(n).Cells(6).Value = Medata.Rows(0).Item("consignee_id").ToString
                        dtgvOrderList.Rows.Item(n).Cells(7).Value = Medata.Rows(0).Item("SysPK").ToString
                        dtgvOrderList.Rows.Item(n).Cells(8).Value = Medata.Rows(0).Item("RIS_Det_No").ToString
                        Me.txtRIS_Det_No.Text = Medata.Rows(0).Item("RIS_Det_No").ToString
                    Catch ex As Exception

                    End Try

                Else
                    MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                             "Inventory Count is Low." & vbNewLine &
                             "Press [ESC] To Cancel", MsgBoxStyle.Critical)
                    Exit Sub
                End If

            ElseIf txtDisplayCost.Text = "0" Then
                SQLEX = "SELECT a_name, ris_details.price 'item_price', ris_details.qty_remaining,ris_master.supplier 'consignee',ris_master.supplier_SysPK 'consignee_id',SysPK,RIS_Det_No FROM inventory_master"
                SQLEX += " INNER JOIN ris_details "
                SQLEX += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
                SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No =  ris_details.RIS_Master_No "
                SQLEX += " WHERE a_code='" & Me.txtItemCode.Text & "' AND qty_remaining >= '" & Me.txtQty.Text & "'"
                SQLEX += " GROUP BY RIS_Det_No"
                SQLEX += " ORDER BY expiry_date"
                SQLEX += " LIMIT 1"

                Dim Medata As DataTable
                Medata = clsDBConn.ExecQuery(SQLEX)

                If Medata.Rows.Count > 0 Then
                    Try
                        Dim remainingItemCount As Double = 0

                        remainingItemCount = CDbl(Medata.Rows(0).Item("qty_remaining").ToString)

                        Dim rowcount As Integer = dtgvOrderList.Rows.Count
                        Dim duplicateItemQty As Integer = 0
                        For jRows As Integer = 0 To (rowcount - 1)

                            Try
                                Dim duplicate As String = dtgvOrderList.Item(0, jRows).Value.ToString
                                If duplicate = Me.txtItemCode.Text Then
                                    duplicateItemQty += CInt(dtgvOrderList.Item(2, jRows).Value)
                                End If

                            Catch ex As Exception

                            End Try
                        Next



                        If remainingItemCount < CDbl(Me.txtQty.Text + duplicateItemQty) Then
                            MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                                       "Inventory Count is Low." & vbNewLine &
                                       "Press [ESC] To Cancel", MsgBoxStyle.Critical)
                            Exit Sub
                        End If


                        Dim n As Integer = dtgvOrderList.Rows.Add()

                        dtgvOrderList.Rows.Item(n).Cells(0).Value = Me.txtItemCode.Text
                        dtgvOrderList.Rows.Item(n).Cells(1).Value = Medata.Rows(0).Item("a_name").ToString
                        dtgvOrderList.Rows.Item(n).Cells(2).Value = CDbl(Me.txtQty.Text)
                        dtgvOrderList.Rows.Item(n).Cells(3).Value = CDbl(Medata.Rows(0).Item("item_price").ToString)

                        Dim totalItemPrice As Double = CDbl(Me.txtQty.Text) * CDbl(Medata.Rows(0).Item("item_price").ToString)

                        Dim totalAmt As Double = totalItemPrice
                        dtgvOrderList.Rows.Item(n).Cells(4).Value = totalAmt

                        dtgvOrderList.Rows.Item(n).Cells(5).Value = Medata.Rows(0).Item("consignee").ToString
                        'consignee_id
                        dtgvOrderList.Rows.Item(n).Cells(6).Value = Medata.Rows(0).Item("consignee_id").ToString
                        dtgvOrderList.Rows.Item(n).Cells(7).Value = Medata.Rows(0).Item("SysPK").ToString
                        dtgvOrderList.Rows.Item(n).Cells(8).Value = Medata.Rows(0).Item("RIS_Det_No").ToString
                    Catch ex As Exception

                    End Try

                Else
                    'MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                    '         "Inventory Count is Low." & vbNewLine &
                    '         "Press [ESC] To Cancel", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If



            displayComputation()

            Me.txtItemCode.Text = "Enter Item Code ..."
            Me.txtItemCode.Focus()
            Me.txtItemCode.SelectAll()

            Me.txtQty.Text = "1"
        End If
    End Sub


    Private Sub displayComputation()
        Dim totalBillRate As Double = 0
        Dim isContainsTotal As Boolean = False
        Dim total_as_row As Integer = 0

        Dim rowcount As Integer = dtgvOrderList.Rows.Count

        For jRows As Integer = 0 To (rowcount - 1)

            Try
                Dim val As Double = CDbl(dtgvOrderList.Item(4, jRows).Value)
                totalBillRate += val
            Catch ex As Exception

            End Try
        Next


        If rowcount > 0 Then
            'Dim n As Integer = dtgvOrderList.Rows.Add()
            'dtgvOrderList.Rows.Item(n).Cells(3).Value = "TOTAL"
            'dtgvOrderList.Rows.Item(n).Cells(4).Value = totalBillRate
            'dtgvOrderList.Rows.Item(n).Cells(5).Value = "-"

            'dtgvOrderList.CurrentCell = dtgvOrderList.Item(0, n)
            ''dtgvOrderList.BeginEdit(True)
            If cxbxSCDiscount.Checked = True Then
                Dim discountedVal As Double = totalBillRate - (totalBillRate * 0.2)

                Me.txtTotalAmt.Text = Format(totalBillRate, "#,##0.00")
                Me.txtAmtDue.Text = Format(discountedVal, "#,##0.00")
            Else
                Me.txtTotalAmt.Text = Format(totalBillRate, "#,##0.00")
                Me.txtAmtDue.Text = Format(totalBillRate, "#,##0.00")
            End If


        End If
    End Sub




    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        lblSysMsg.Text = "Tender Amount"
        Dim totalItemPrice As Double = CDbl(Me.txtTotalAmt.Text)
        Dim totalDisc As Double = 0



        Dim totalAmt As Double = totalItemPrice - totalDisc
        txtAmtDue.Text = Format(totalAmt, "#,##0.00")


        If numericKey Is Nothing Then
            numericKey = New fmzNumericKeysForm
        End If
        With numericKey
            .lblAmtDue.Text = txtTotalAmt.Text
            .ShowDialog()
        End With

        'txtCustomerName.Focus()
        btnPostPayment.Focus()
    End Sub



    Private Sub txtCash_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If numericKey Is Nothing Then
            numericKey = New fmzNumericKeysForm
        End If
        With numericKey
            .ShowDialog()

        End With
    End Sub




    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If SHOWSYSMSG = True Then
            lblSysMsg.Visible = Not lblSysMsg.Visible
        End If


    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()

        Me.txtAmtDue.Text = "<>"

    End Sub

    Private Sub btnPostPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPostPayment.Click
        If txtPatientCode.Text = "" Then
            MsgBox("Please Fill In Fields Properly.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If txtPatientTypeID.Text = "" Then
            MsgBox("Please Fill In Fields Properly.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If txtChargingID.Text = "" Then
            MsgBox("Please Fill In Fields Properly.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If rbtnPatient.Checked Then
            If txtPatientCode.Text.Length = 0 Or txtChargingID.Text.Length = 0 Then
                MsgBox("Please Fill In Patient Name and Charging Properly.", MsgBoxStyle.Information)
                Me.txtPatientProfile.Focus()
                Exit Sub
            End If
        End If

        postTransaction()
    End Sub

    Private Sub txtCustomerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        lblSysMsg.Text = "Press Enter or F10 to Post Transactions."
    End Sub


    Private Sub postTransaction()


        lblSysMsg.Text = "Press Yes to Post Payment" & vbNewLine & "Press No to Cancel Payment"

        If MessageBox.Show("Are you sure you want to POST this Transaction?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then


            If ReceiverPopUp Is Nothing Then
                ReceiverPopUp = New fmaReceivedByPopUpForm

            End If
            ReceiverPopUp.ShowDialog()

            saveTransactions()
        Else
            Me.txtItemCode.Focus()
            Me.txtItemCode.SelectAll()
        End If
    End Sub

    Private Sub saveTransactions()

        endTime = Format(Date.Now, "yyyy-MM-dd hh:mm:ss")

        Dim SysPK As String = System.Guid.NewGuid.GetHashCode
        Dim tr_amount As Double = CDbl(Me.txtTotalAmt.Text)

        Dim dailysales_cashier As String = FullUserName
        Dim system_gen_id As String = getTransactionNumber()

        Dim tr_date As String = Format(Date.Now, "yyyy-MM-dd HH:mm:ss")

        Dim SQLIN As String = ""

        If cxbxUnfilledPrx.Checked = True Then

            If cxbxDiscounted.Checked = True Then
                SQLIN = "INSERT INTO daily_sales_master("
                SQLIN += " SysPK,transactionno,"
                SQLIN += " tr_amount,patient_id,patient_name,"
                SQLIN += " or_no, ref_no, osca_no, cashier,"
                SQLIN += " charging,chargingid,tr_date,unfilled,recieved_by, start_time,end_time, paid_amount, qfs_discount)"
                SQLIN += " VALUES("
                SQLIN += String.Format("'{0}', '{1}',", SysPK, system_gen_id)
                SQLIN += String.Format("'{0}', '{1}', '{2}',", tr_amount, txtPatientCode.Text, txtPatientProfile.Text)
                SQLIN += String.Format("'{0}', '{1}', '{2}', '{3}',", txtORNo.Text, txtRefNo.Text, txtOSCA.Text, FullUserName)
                SQLIN += String.Format("'{0}','{1}','{2}',", txtCharging.Text, txtChargingID.Text, tr_date)
                SQLIN += String.Format("'{0}', '{1}',", qty_unfilled.Value, RECEIVED_BY)
                SQLIN += String.Format("'{0}', '{1}',", startTime, endTime)
                SQLIN += String.Format("'{0}', '{1}')", txtAmtDue.Text, txtDiscount.Value)
            Else
                SQLIN = "INSERT INTO daily_sales_master("
                SQLIN += " SysPK,transactionno,"
                SQLIN += " tr_amount,patient_id,patient_name,"
                SQLIN += " or_no, ref_no, osca_no, cashier,"
                SQLIN += " charging,chargingid,tr_date,unfilled,recieved_by, start_time,end_time)"
                SQLIN += " VALUES("
                SQLIN += String.Format("'{0}', '{1}',", SysPK, system_gen_id)
                SQLIN += String.Format("'{0}', '{1}', '{2}',", tr_amount, txtPatientCode.Text, txtPatientProfile.Text)
                SQLIN += String.Format("'{0}', '{1}', '{2}', '{3}',", txtORNo.Text, txtRefNo.Text, txtOSCA.Text, FullUserName)
                SQLIN += String.Format("'{0}','{1}','{2}',", txtCharging.Text, txtChargingID.Text, tr_date)
                SQLIN += String.Format("'{0}', '{1}',", qty_unfilled.Value, RECEIVED_BY)
                SQLIN += String.Format("'{0}', '{1}')", startTime, endTime)
            End If

        Else
            If cxbxDiscounted.Checked = True Then
                SQLIN = "INSERT INTO daily_sales_master("
                SQLIN += " SysPK,transactionno,"
                SQLIN += " tr_amount,patient_id,patient_name,"
                SQLIN += " or_no, ref_no, osca_no, cashier,"
                SQLIN += " charging,chargingid,tr_date, recieved_by,start_time,end_time,paid_amount, qfs_discount)"
                SQLIN += " VALUES("
                SQLIN += String.Format("'{0}', '{1}',", SysPK, system_gen_id)
                SQLIN += String.Format("'{0}', '{1}', '{2}',", tr_amount, txtPatientCode.Text, txtPatientProfile.Text)
                SQLIN += String.Format("'{0}', '{1}', '{2}', '{3}',", txtORNo.Text, txtRefNo.Text, txtOSCA.Text, FullUserName)
                SQLIN += String.Format("'{0}','{1}','{2}','{3}',", txtCharging.Text, txtChargingID.Text, tr_date, RECEIVED_BY)
                SQLIN += String.Format("'{0}', '{1}',", startTime, endTime)
                SQLIN += String.Format("'{0}', '{1}')", txtAmtDue.Text, txtDiscount.Value)
            Else
                SQLIN = "INSERT INTO daily_sales_master("
                SQLIN += " SysPK,transactionno,"
                SQLIN += " tr_amount,patient_id,patient_name,"
                SQLIN += " or_no, ref_no, osca_no, cashier,"
                SQLIN += " charging,chargingid,tr_date, recieved_by,start_time,end_time)"
                SQLIN += " VALUES("
                SQLIN += String.Format("'{0}', '{1}',", SysPK, system_gen_id)
                SQLIN += String.Format("'{0}', '{1}', '{2}',", tr_amount, txtPatientCode.Text, txtPatientProfile.Text)
                SQLIN += String.Format("'{0}', '{1}', '{2}', '{3}',", txtORNo.Text, txtRefNo.Text, txtOSCA.Text, FullUserName)
                SQLIN += String.Format("'{0}','{1}','{2}','{3}',", txtCharging.Text, txtChargingID.Text, tr_date, RECEIVED_BY)
                SQLIN += String.Format("'{0}', '{1}')", startTime, endTime)
            End If

        End If


        If clsDBConn.Execute(SQLIN) Then
            updateInventory(SysPK)
            printReceipt(SysPK)

            '      NEW_TRANS = True
            ITEM_LIST = Nothing
            clearItems()
            rbtnPatient.Checked = True
        End If


        '      itemInquiry.Close()
        itemInquiry = Nothing


    End Sub

    Private Sub btnPostPayment_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPostPayment.GotFocus
        lblSysMsg.Text = "Press Enter Again or [F10] to Post Transaction."
    End Sub



    Private Sub updateInventory(Optional ByVal SysPK_dailysales As String = "")

        Dim rowcount As Integer = dtgvOrderList.Rows.Count

        Dim tr_date As String = Format(Date.Now, "yyyy-MM-dd HH:mm:ss")


        For jRows As Integer = 0 To (rowcount - 1)
            Dim sales_sys As String = SysPK_dailysales
            Dim a_code As String = dtgvOrderList.Item(0, jRows).Value.ToString
            Dim item_descr As String = dtgvOrderList.Item(1, jRows).Value.ToString
            Dim Qty As Double = dtgvOrderList.Item(2, jRows).Value
            Dim item_price As Double = dtgvOrderList.Item(3, jRows).Value
            Dim item_total As Double = dtgvOrderList.Item(4, jRows).Value
            Dim RIS_Det_No As Double = dtgvOrderList.Item(8, jRows).Value

            ' 
            'Dim SQLUP As String = "UPDATE inventory_master SET inv_qty=inv_qty-'" & Qty & "'"
            'SQLUP += " WHERE a_code='" & a_code & "'"
            'clsDBConn.Execute(SQLUP)

            Dim SQLUP As String = "UPDATE ris_details SET qty_remaining=qty_remaining-'" & Qty & "'"
            SQLUP += " WHERE RIS_Det_No='" & RIS_Det_No & "'"
            clsDBConn.Execute(SQLUP)




            'daily_inventory_details
            SQLUP = "UPDATE daily_inventory_details SET sold=sold +'" & Qty & "', "
            SQLUP += " remaining_qty = remaining_qty - '" & Qty & "'"
            SQLUP += " WHERE a_code='" & a_code & "'"
            SQLUP += " AND SysPK_TRD='" & DAILY_TRANSACTION_SYSPK & "'"
            clsDBConn.Execute(SQLUP)


            If sales_sys <> "" Then
                Dim SQLIN As String = "INSERT INTO daily_sales_detail(sales_sys,item_invcode,"
                SQLIN += " item_descr,item_qty,"
                SQLIN += " item_price,"
                SQLIN += " item_total,date_created, RIS_Det_No)"
                SQLIN += " VALUES("
                SQLIN += String.Format("'{0}', '{1}'", sales_sys, a_code)
                SQLIN += String.Format(",'{0}', '{1}'", item_descr, Qty)
                SQLIN += String.Format(",'{0}'", item_price)
                SQLIN += String.Format(",'{0}','{1}','{2}')", item_total, tr_date, RIS_Det_No)

                clsDBConn.Execute(SQLIN)
            End If




        Next


    End Sub

    Private Function getTransactionNumber() As String

        Dim transDate As String = Format(Date.Now, "yyMMdd")
        Dim transnum As Integer = 0

        Dim SQLEX As String = "SELECT COUNT(SysPK) 'count' FROM daily_sales_master"
        SQLEX += " WHERE DATE(tr_date) = '" & Format(Date.Now, "yyyy/MM/dd") & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)


        If MeData.Rows.Count > 0 Then
            transnum = CInt(MeData.Rows(0).Item("count").ToString)
            transnum += 1
        End If

        transDate += Format(transnum, "00")


        txtTransNum.Text = transDate

        Return transDate
    End Function

    Private Function getSystemTr() As String

        Dim transDate As String = Format(Date.Now, "yyMMdd")
        Dim transnum As Integer = 0

        Dim SQLEX As String = "SELECT COUNT(SysPK_dailysales) 'count' FROM daily_sales_master"
        SQLEX += " WHERE DATE(dailysales_date) = '" & Format(Date.Now, "yyyy/MM/dd") & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)


        If MeData.Rows.Count > 0 Then
            transnum = CInt(MeData.Rows(0).Item("count").ToString)
            transnum += 1
        End If



        transDate += Format(transnum, "00")

        Return transDate
    End Function


    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblDate.Text = Format(DateTime.Now, "MMMM dd, yyyy hh:mm:ss tt")
    End Sub



    Private Sub btnInq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInq.Click
        btnInq.Focus()
        If itemInquiry Is Nothing Then
            itemInquiry = New fmaItemIssuanceList  'fmaPOSItemInquiryForm
            itemInquiry.txtQty.Text = txtQty.Text
            itemInquiry.ShowDialog()
        End If
        '       itemInquiry.ShowDialog()
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        Try
            fmaTransactionMasterListForm.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub printReceipt(ByVal TransactionSysPK As String)



        If cxbxdirectPrinting.Checked Then
            verifyOR()

            Dim SQLEX As String = "SELECT SysPK,transactionno FROM daily_sales_master"
            SQLEX += " WHERE SysPK='" & TransactionSysPK & "'"

            'txtTransNum
            Dim new_report As New fzzReportViewerForm
            new_report.DirectPrinting = True
            Try
                new_report.AttachReport(SQLEX, "barcode") = New rpt_tr_barcode()
                new_report.Print()
            Catch ex As Exception

            End Try

        Else
            'Dim new_report As New fzzReportViewerForm
            'Dim SQLEX As String = "SELECT"
            'SQLEX += " `daily_sales_master`.`SysPK_dailysales`"
            'SQLEX += " , `daily_sales_master`.`dailysales_amount`"
            'SQLEX += " , `daily_sales_master`.`Discount`"
            'SQLEX += " , `daily_sales_master`.`dailysales_net`"
            'SQLEX += " , `daily_sales_master`.`dailysales_cash`"
            'SQLEX += " , `daily_sales_master`.`dailysales_change`"
            'SQLEX += " , `daily_sales_master`.`dailysales_cashier`"
            'SQLEX += " , `daily_sales_master`.`dailysales_date`"
            'SQLEX += " , system_gen_id"
            'SQLEX += String.Format(" ,'{0}' as 'FullUserName'", FullUserName)
            'SQLEX += " , `daily_sales_master`.`Owner_Name`"
            'SQLEX += " , `daily_sales_master`.`Transaction_ID`"
            'SQLEX += " , `daily_sales_detail`.`item_descr`"
            'SQLEX += " , `daily_sales_detail`.`item_qty`"
            'SQLEX += " , `daily_sales_detail`.`item_price`"
            'SQLEX += " , `daily_sales_detail`.`item_disc`"
            'SQLEX += " , `daily_sales_detail`.`item_total`"
            'SQLEX += " FROM daily_sales_detail"
            'SQLEX += " INNER JOIN daily_sales_master"
            'SQLEX += " ON (`daily_sales_detail`.`sales_sys` = "
            'SQLEX += " `daily_sales_master`.`SysPK_dailysales`)"
            'SQLEX += " WHERE SysPK_dailysales='" & TransactionSysPK & " '"

            'Try
            '    new_report.AttachReport(SQLEX, "Service  Invoice") = New rpt_ReceiptHeader
            '    new_report.DirectPrinting = True
            '    new_report.Print()

            'Catch ex As Exception

            'End Try

            'MsgBox("Please Close Drawer.")
        End If

    End Sub


    Private Sub verifyOR()
        Dim prn As New Printing.PrintDocument
        Dim margins As Printing.Margins = New Printing.Margins(1, 1, 20, 10)
        ' Select the PDF Printer
        'prn.PrinterSettings.DefaultPageSettings.PaperSize = New Printing.PaperSize("custom format", 58, 300)
        prn.PrinterSettings.DefaultPageSettings.Margins = margins
        prn.PrinterSettings.PrinterName = PrinterName


        ' Handle the page events
        AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
        ' Do the print (Printing handled by the print page handler)
        prn.Print()
        ' Remove the page handler
        RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Static i As Integer = 0
        i = i + 1

        'Dim Bounds As New Rectangle(args.PageSettings.PrintableArea.X, args.PageSettings.PrintableArea.Y, args.MarginBounds.Width, args.MarginBounds.Height)
        'args.Graphics.DrawRectangle(Pens.Black, Bounds)

        Dim displayString As String
        Dim rows As String = ControlChars.NewLine

        ' compnay name
        displayString = rows _
                     + "    EVERSLEY CHILD SANITARIUM PHARMACY"
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows _
                     + "              JAGOBIAO, MANDAUE CEBU"
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine + ControlChars.NewLine
        displayString = rows _
                     + ""
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)



        rows += ControlChars.NewLine
        displayString = rows _
                     + "PHARMACIST : " + FullUserName
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows _
                     + "DATE   : " + Format(DateTime.Now, "MM-dd-yyyy hh:mm tt")
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows _
                     + "CUSTOMER: " + txtPatientProfile.Text
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows _
                     + "TRNS # : " + txtTransNum.Text
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows _
                     + " "
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows _
                     + "  DESCR            QTY      PRICE      AMT"
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows _
                     + "------------------------------------------------------------"
        args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        Dim rowcount As Integer = dtgvOrderList.Rows.Count
        For jRows As Integer = 0 To (rowcount - 1)

            Dim item_descr As String = dtgvOrderList.Item(1, jRows).Value.ToString
            Dim Qty As Double = dtgvOrderList.Item(2, jRows).Value
            Dim item_price As Double = dtgvOrderList.Item(3, jRows).Value
            'Dim item_disc As Double = dtgvOrderList.Item(4, jRows).Value
            Dim item_total As Double = dtgvOrderList.Item(4, jRows).Value


            item_descr = item_descr.Substring(0, 10)
            'item description
            displayString = rows + item_descr
            args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

            ' quantity
            displayString = rows + "                          " & " x " & Format(Qty, "00")
            args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)
            'unit price
            displayString = rows + "                                    " & "@ " & formatString(Format(item_price, "#,##0.00").ToString, 8)
            args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)
            ' total
            displayString = rows + "                                                      " & "- " & formatString(Format(item_total, "#,##0.00").ToString, 8)
            args.Graphics.DrawString(displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)
            rows += ControlChars.NewLine
        Next

        displayString = rows + ControlChars.NewLine +
                       "------------------------------------------------------------"
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)


        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       "TOTAL       : " + formatString(txtTotalAmt.Text, 10)
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               6,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine

        If cxbxSCDiscount.CheckState = CheckState.Checked Then

            displayString = rows + ControlChars.NewLine +
                      "DISCOUNT   : 20%"
            args.Graphics.DrawString(" " & displayString, New Font("Arial",
                                   7,
                                   FontStyle.Regular), Brushes.Black, 0, 10)
            rows += ControlChars.NewLine
        End If

        If cxbxDiscounted.CheckState = CheckState.Checked Then

            displayString = rows + ControlChars.NewLine +
                      "DISCOUNT   : " & txtDiscount.Value & "%"
            args.Graphics.DrawString(" " & displayString, New Font("Arial",
                                   7,
                                   FontStyle.Regular), Brushes.Black, 0, 10)
            rows += ControlChars.NewLine
        End If


        displayString = rows + ControlChars.NewLine +
                       "AMT DUE   : " + formatString(txtAmtDue.Text, 10)
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)


        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       ""
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       "     PLS PAY DIRECTLY AT THE CASHIER!!"
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       "NOTE: This is not an Official Receipt."
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)
        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       "            For Inventory Purpose Only."
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)
        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       "                     ---------------------"
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       ""
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)

        rows += ControlChars.NewLine
        displayString = rows + ControlChars.NewLine +
                       "."
        args.Graphics.DrawString(" " & displayString, New Font("Arial",
                               7,
                               FontStyle.Regular), Brushes.Black, 0, 10)

    End Sub


    Function formatString(ByRef strValue As String, ByRef size As Integer)
        Dim retString As String = strValue

        For j As Integer = strValue.Length To size - 1
            retString = " " + retString
        Next

        Return retString
    End Function

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        dtgvOrderList.Enabled = True

        If removeItemForm Is Nothing Then
            removeItemForm = New fmaPOS_RemoveItemForm(dtgvOrderList)
            removeItemForm.ShowDialog()
        End If

    End Sub

    Private Sub removeItemForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles removeItemForm.FormClosed
        removeItemForm = Nothing
    End Sub




    Private Sub removeItemForm_ITEM_DELETED() Handles removeItemForm.ITEM_DELETED
        With removeItemForm.dtgvOrderList
            Me.dtgvOrderList.Rows.Clear()

            Dim rowcount As Integer = .Rows.Count

            For jRows As Integer = 0 To (rowcount - 1)
                Dim n As Integer = dtgvOrderList.Rows.Add()
                dtgvOrderList.Rows.Item(n).Cells(0).Value = .Item(0, jRows).Value.ToString
                dtgvOrderList.Rows.Item(n).Cells(1).Value = .Item(1, jRows).Value.ToString
                dtgvOrderList.Rows.Item(n).Cells(2).Value = .Item(2, jRows).Value.ToString
                dtgvOrderList.Rows.Item(n).Cells(3).Value = .Item(3, jRows).Value.ToString
                dtgvOrderList.Rows.Item(n).Cells(4).Value = .Item(4, jRows).Value.ToString
                dtgvOrderList.Rows.Item(n).Cells(5).Value = .Item(5, jRows).Value.ToString

            Next
        End With
        displayComputation()
    End Sub


    Private Sub itemInquiry_ITEM_SELECTED() Handles itemInquiry.ITEM_SELECTED
        With itemInquiry
            Me.txtItemCode.Focus()
            Me.txtItemCode.Text = .GridView1.GetFocusedRowCellValue("a_code").ToString   '.tdbViewer.Columns.Item("a_code").Value
            Me.txtRIS_Det_No.Text = .GridView1.GetFocusedRowCellValue("RIS_Det_No").ToString      '.tdbViewer.Columns.Item("RIS_Det_No").Value

            '      qty_ItemInquiry = .GridView1.GetFocusedRowCellValue("qty_remaining").ToString
            '     qty_ItemInquiry = .Qty_remaining
            If .txtQty.Text <> "0" Then
                Me.txtQty.Text = .txtQty.Text
            End If

            Me.txtItemCode.SelectAll()
            Me.btnSelectItem.PerformClick()

            .txtQty.Text = ""

            'Call Me.txtItemCode_Click(txtItemCode, Nothing)


            'txtItemCode_Click(Me, EventArgs.Empty)
            'txtItemCode(Me, EventArgs.Empty)
        End With

        itemInquiry.Close()
        itemInquiry = Nothing

    End Sub

    Dim qty_ItemInquiry As Double = 0
    Private Sub btnSelectItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectItem.Click
        Dim SQLEX As String = ""

        Dim row_duplicate As Integer

        If txtDisplayCost.Text = "1" Then
            SQLEX = "SELECT a_name, selling_price 'item_price', ris_details.qty_remaining,ris_master.supplier 'consignee',ris_master.supplier_SysPK 'consignee_id',SysPK,RIS_Det_No FROM inventory_master"
            SQLEX += " INNER JOIN ris_details "
            SQLEX += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
            SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No =  ris_details.RIS_Master_No "
            SQLEX += " WHERE RIS_Det_No='" & Me.txtRIS_Det_No.Text & "'"
            SQLEX += " ORDER BY expiry_date"
            SQLEX += " LIMIT 1"

            Dim Medata As DataTable
            Medata = clsDBConn.ExecQuery(SQLEX)

            If Medata.Rows.Count > 0 Then
                Try

                    Dim remainingItemCount As Double = 0
                    remainingItemCount = CDbl(Medata.Rows(0).Item("qty_remaining").ToString) 'qty_ItemInquiry

                    Dim rowcount As Integer = dtgvOrderList.Rows.Count
                    Dim duplicateItemQty As Integer = 0
                    For jRows As Integer = 0 To (rowcount - 1)

                        Try
                            Dim duplicate As String = dtgvOrderList.Item(8, jRows).Value.ToString
                            If duplicate = Me.txtRIS_Det_No.Text Then
                                row_duplicate = jRows
                                duplicateItemQty += CInt(dtgvOrderList.Item(2, jRows).Value)
                            End If

                        Catch ex As Exception

                        End Try
                    Next

                    If remainingItemCount < CDbl(Me.txtQty.Text + duplicateItemQty) Then
                        MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                                   "Inventory Count is Low." & vbNewLine &
                                   "Press [ESC] To Cancel", MsgBoxStyle.Critical)
                        Exit Sub
                    End If


                    Dim n As Integer '= dtgvOrderList.Rows.Add()
                    If duplicateItemQty > 0 Then
                        n = row_duplicate
                        Me.txtQty.Text = CDbl(Me.txtQty.Text) + duplicateItemQty
                    Else
                        n = dtgvOrderList.Rows.Add()
                    End If

                    dtgvOrderList.Rows.Item(n).Cells(0).Value = Me.txtItemCode.Text
                    dtgvOrderList.Rows.Item(n).Cells(1).Value = Medata.Rows(0).Item("a_name").ToString
                    dtgvOrderList.Rows.Item(n).Cells(2).Value = CDbl(Me.txtQty.Text)
                    dtgvOrderList.Rows.Item(n).Cells(3).Value = CDbl(Medata.Rows(0).Item("item_price").ToString)

                    Dim totalItemPrice As Double = CDbl(Me.txtQty.Text) * CDbl(Medata.Rows(0).Item("item_price").ToString)

                    Dim totalAmt As Double = totalItemPrice
                    dtgvOrderList.Rows.Item(n).Cells(4).Value = totalAmt

                    dtgvOrderList.Rows.Item(n).Cells(5).Value = Medata.Rows(0).Item("consignee").ToString
                    'consignee_id
                    dtgvOrderList.Rows.Item(n).Cells(6).Value = Medata.Rows(0).Item("consignee_id").ToString
                    dtgvOrderList.Rows.Item(n).Cells(7).Value = Medata.Rows(0).Item("SysPK").ToString
                    dtgvOrderList.Rows.Item(n).Cells(8).Value = Medata.Rows(0).Item("RIS_Det_No").ToString
                Catch ex As Exception

                End Try
            End If

        ElseIf txtDisplayCost.Text = "0" Then
            SQLEX = "SELECT a_name, ris_details.price 'item_price', ris_details.qty_remaining,ris_master.supplier 'consignee',ris_master.supplier_SysPK 'consignee_id',SysPK,RIS_Det_No FROM inventory_master"
            SQLEX += " INNER JOIN ris_details "
            SQLEX += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
            SQLEX += " INNER JOIN ris_master ON ris_details.RIS_Master_No =  ris_details.RIS_Master_No "
            SQLEX += " WHERE RIS_Det_No='" & Me.txtRIS_Det_No.Text & "'"
            SQLEX += " ORDER BY expiry_date"
            SQLEX += " LIMIT 1"

            Dim Medata As DataTable
            Medata = clsDBConn.ExecQuery(SQLEX)

            If Medata.Rows.Count > 0 Then
                Try
                    Dim remainingItemCount As Double = 0

                    remainingItemCount = CDbl(Medata.Rows(0).Item("qty_remaining").ToString) 'qty_ItemInquiry '

                    Dim rowcount As Integer = dtgvOrderList.Rows.Count
                    Dim duplicateItemQty As Integer = 0
                    For jRows As Integer = 0 To (rowcount - 1)

                        Try
                            Dim duplicate As String = dtgvOrderList.Item(8, jRows).Value.ToString
                            If duplicate = Me.txtRIS_Det_No.Text Then
                                row_duplicate = jRows
                                duplicateItemQty += CInt(dtgvOrderList.Item(2, jRows).Value)
                            End If

                        Catch ex As Exception

                        End Try
                    Next



                    '            If remainingItemCount < CDbl(Me.txtQty.Text + duplicateItemQty) Then
                    If remainingItemCount < duplicateItemQty Then
                        MsgBox("Please Check Inventory count for this Item" & vbNewLine &
                                   "Inventory Count is Low." & vbNewLine &
                                   "Press [ESC] To Cancel", MsgBoxStyle.Critical)
                        Exit Sub
                    End If


                    Dim n As Integer '= dtgvOrderList.Rows.Add()
                    If duplicateItemQty > 0 Then
                        n = row_duplicate
                        Me.txtQty.Text = CDbl(Me.txtQty.Text) + duplicateItemQty
                    Else
                        n = dtgvOrderList.Rows.Add()
                    End If

                    dtgvOrderList.Rows.Item(n).Cells(0).Value = Me.txtItemCode.Text
                    dtgvOrderList.Rows.Item(n).Cells(1).Value = Medata.Rows(0).Item("a_name").ToString
                    dtgvOrderList.Rows.Item(n).Cells(2).Value = CDbl(Me.txtQty.Text)
                    dtgvOrderList.Rows.Item(n).Cells(3).Value = CDbl(Medata.Rows(0).Item("item_price").ToString)

                    Dim totalItemPrice As Double = CDbl(Me.txtQty.Text) * CDbl(Medata.Rows(0).Item("item_price").ToString)

                    Dim totalAmt As Double = totalItemPrice
                    dtgvOrderList.Rows.Item(n).Cells(4).Value = totalAmt

                    dtgvOrderList.Rows.Item(n).Cells(5).Value = Medata.Rows(0).Item("consignee").ToString
                    'consignee_id
                    dtgvOrderList.Rows.Item(n).Cells(6).Value = Medata.Rows(0).Item("consignee_id").ToString
                    dtgvOrderList.Rows.Item(n).Cells(7).Value = Medata.Rows(0).Item("SysPK").ToString
                    dtgvOrderList.Rows.Item(n).Cells(8).Value = Medata.Rows(0).Item("RIS_Det_No").ToString
                Catch ex As Exception

                End Try
            End If
        End If



        displayComputation()

        Me.txtItemCode.Text = "Enter Item Code ..."
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()

        Me.txtQty.Text = "1"
    End Sub

    Private Sub dtgvOrderList_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dtgvOrderList.RowsAdded
        isRowsAdded = True

        If startTime = "" Then
            startTime = Format(Date.Now, "yyyy-MM-dd hh:mm:ss")
        End If


    End Sub

    Private Sub dtgvOrderList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvOrderList.SelectionChanged
        Me.dtgvOrderList.ClearSelection()
    End Sub


    Private Sub itemInquiry_WIN_CLOSED() Handles itemInquiry.WIN_CLOSED
        itemInquiry = Nothing
    End Sub

    Private Sub txtPatientProfile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientProfile.GotFocus
        PROFILEVALIDATION = False
    End Sub

    Private Sub txtPatientProfile_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientProfile.KeyUp
        'If e.KeyCode = Keys.Enter Then
        '    txtCharging.Focus()
        'End If
    End Sub


    Private Sub txtPatientProfile_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientProfile.SelectedIndexChanged
        If ISSUEDTO = "PATIENT" Then
            'a_code,a_name,patienttype,patienttype_id
            Try
                Dim drv As DataRowView = DirectCast(txtPatientProfile.SelectedItem, DataRowView)
                Me.txtPatientCode.Text = drv.Item("pp_code").ToString
                Me.txtChargeTo.Text = drv.Item("PATIENTTYPE").ToString
                Me.txtPatientTypeID.Text = drv.Item("patienttype_id").ToString


                PROFILEVALIDATION = True
            Catch ex As Exception
                Me.txtPatientCode.Text = ""
                PROFILEVALIDATION = False

            End Try
        ElseIf ISSUEDTO = "WARD" Then
            'a_code,a_name,patienttype,patienttype_id
            Try
                Dim drv As DataRowView = DirectCast(txtPatientProfile.SelectedItem, DataRowView)
                Me.txtPatientCode.Text = drv.Item("a_code").ToString
                Me.txtChargeTo.Text = ""
                Me.txtPatientTypeID.Text = "0"


                PROFILEVALIDATION = True
            Catch ex As Exception
                Me.txtPatientCode.Text = ""
                PROFILEVALIDATION = False

            End Try
        End If
        txtCharging.Focus()
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAddPatient.LinkClicked
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaPersonProfileSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()
    End Sub

    Private Sub SETUPFORM_DB_MODIFIED() Handles SETUPFORM.DB_MODIFIED
        getPatientList()
    End Sub

    Private Sub SETUPFORM_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles SETUPFORM.FormClosed
        SETUPFORM = Nothing
        getPatientList()
    End Sub

    Private Sub txtPatientCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientCode.TextChanged
        If txtPatientCode.Text.Length > 0 Then
            btnPostPayment.Enabled = True
        End If
    End Sub

    Private Sub txtCharging_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCharging.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtCharging.SelectedItem, DataRowView)
            Me.txtChargingID.Text = drv.Item("a_code").ToString
            Me.txtDisplayCost.Text = drv.Item("display_cost").ToString 'display_cost
        Catch ex As Exception
            Me.txtChargingID.Text = ""
        End Try
    End Sub

    Private Sub rbtnWard_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnWard.CheckedChanged

        clearItems()
        Me.txtQty.Text = "1"

        'Me.dtgvOrderList.Rows.Clear()
        Application.DoEvents()
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()
        getTransactionNumber()



        If rbtnWard.Checked Then
            ISSUEDTO = "WARD"
            lblPatientWard.Text = "WARD :"
            getWardList()

            txtPatientProfile.SelectedIndex = -1

            'txtChargeTo.Enabled = False
            'txtPatientProfile.Enabled = False
            txtCharging.Enabled = False
            txtCharging.Text = "WARD"
            txtChargingID.Text = "10"
            txtPatientCode.Text = "0"
            txtChargeTo.Text = "0"
            txtPatientTypeID.Text = "0"
            txtDisplayCost.Text = "0"


        Else
            lblPatientWard.Text = "PATIENT NAME :"
            getPatientList()
            ISSUEDTO = "PATIENT"
            txtPatientProfile.SelectedItem = -1
            txtChargeTo.Enabled = True
            txtPatientProfile.Enabled = True
            txtCharging.Enabled = True
            txtCharging.SelectedIndex = -1

            txtChargeTo.Text = ""
            txtPatientTypeID.Text = ""
        End If
    End Sub

    Private Sub rbtnPatient_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnPatient.CheckedChanged
        If rbtnPatient.Checked Then
            ISSUEDTO = "PATIENT"
            clearItems()

        End If
    End Sub

    Private Sub txtPatientProfile_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientProfile.Validated
        If rbtnPatient.Checked Then
            If PROFILEVALIDATION = False Then
                If MessageBox.Show("PATIENT DOES NOT EXIST ON RECORD." & vbNewLine & "DO YOU WANT TO ADD PATIENT?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    If SETUPFORM Is Nothing Then
                        SETUPFORM = New fmaPersonProfileSetupForm
                        SETUPFORM.OPERATION = "ADD"
                    End If

                    SETUPFORM.ShowDialog()
                End If
            End If
        End If


    End Sub


    Private Sub btnSetPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPatient.Click
        txtPatientProfile.Focus()
        txtPatientProfile.DroppedDown = True
    End Sub

    Private Sub txtORNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtORNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtRefNo.Focus()
        End If
    End Sub

    Private Sub txtRefNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtOSCA.Focus()
        End If
    End Sub

    Private Sub txtOSCA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOSCA.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtItemCode.Focus()
        End If
    End Sub


    Private Sub btnAddPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPatient.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaPersonProfileSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()
    End Sub

    Private Sub cxbxDiscounted_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cxbxDiscounted.CheckedChanged



        If cxbxDiscounted.Checked Then
            If cxbxSCDiscount.CheckState = CheckState.Checked Then
                MsgBox("Please Select Only One Discount Category.", MsgBoxStyle.Critical)
                cxbxDiscounted.CheckState = CheckState.Unchecked
                Exit Sub
            End If

            'txtDiscount.Visible = True
            'txtDiscount.Focus()

            'Dim discountedPrice As Double = CDbl(txtTotalAmt.Text) * (txtDiscount.Value / 100)

            'txtAmtDue.Text = Format(CDbl(txtTotalAmt.Text) - discountedPrice, "#,##0.00")

            ' QFS Discount BEGIN ****************
            lblPayableAmount.Text = "Amount Paid"
            '      txtDiscount.Visible = True
            txtDiscount.Enabled = True
            txtAmtDue.ReadOnly = False
            txtAmtDue.Focus()
            ' QFS Discount END   ****************
        Else
            '        txtDiscount.Visible = False
            txtDiscount.Enabled = False
            lblPayableAmount.Text = "TOTAL AMOUNT"
            txtAmtDue.ReadOnly = True
        End If
    End Sub

    Private Sub txtDiscount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.Validated
        Dim discountedPrice As Double = CDbl(txtTotalAmt.Text) * (txtDiscount.Value / 100)

        txtAmtDue.Text = Format(CDbl(txtTotalAmt.Text) - discountedPrice, "#,##0.00")
    End Sub

    Private Sub ReceiverPopUp_Form_OK() Handles ReceiverPopUp.Form_OK

        With ReceiverPopUp
            RECEIVED_BY = .txtReceiverName.Text
        End With

        ReceiverPopUp = Nothing
    End Sub

    Private Sub txtAmtDue_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAmtDue.KeyUp




        If e.KeyCode = Keys.Enter Then

            txtAmtDue.Text = Format(CDbl(txtAmtDue.Text), "#,##0.00")
            Dim payable As Double = 0


            payable = CDbl(txtTotalAmt.Text) - CDbl(txtAmtDue.Text)
            txtDiscount.Value = payable

            btnPostPayment.Focus()

        End If
    End Sub

    Private Sub txtAmtDue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmtDue.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then

            e.Handled = True
            MsgBox("Please Enter Numeric Only.", MsgBoxStyle.Exclamation)
            txtAmtDue.Focus()
        End If
    End Sub

    Private Sub cxbxUnfilledPrx_CheckedChanged(sender As Object, e As EventArgs) Handles cxbxUnfilledPrx.CheckedChanged
        If cxbxUnfilledPrx.Checked = True Then
            qty_unfilled.Enabled = True
            qty_unfilled.Focus()
        Else
            qty_unfilled.Enabled = False
        End If
    End Sub

    Private Sub txtAmtDue_TextChanged(sender As Object, e As EventArgs) Handles txtAmtDue.TextChanged
        If txtAmtDue.Text.Contains("<>") Then

        Else
            If cxbxDiscounted.Checked = True Then
                Dim AmtDue As Double = CDbl(txtAmtDue.Text)
                Dim TotalAmt As Double = CDbl(txtTotalAmt.Text)
                txtDiscount.Value = TotalAmt - AmtDue
            End If
        End If

    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs)
        txtPatientProfile.Focus()
    End Sub

    Private Sub btnNewSales_Click(sender As Object, e As EventArgs)
        If Me.dtgvOrderList.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to CANCEL this transaction?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                clearItems()
            End If

        Else
            Me.txtQty.Text = "1"
            clearItems()
            'Me.dtgvOrderList.Rows.Clear()
            Application.DoEvents()
            Me.txtItemCode.Focus()
            Me.txtItemCode.SelectAll()
            getTransactionNumber()
        End If
    End Sub

    Private Sub btnNewViewttrans_Click(sender As Object, e As EventArgs)
        Try
            fmaTransactionMasterListForm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNewSetQty_Click(sender As Object, e As EventArgs)
        If Me.txtQty.ReadOnly Then
            Me.txtQty.ReadOnly = False
            Me.txtQty.Focus()
            Me.txtQty.SelectAll()
        End If
    End Sub

    Private Sub btnNewRemove_Click(sender As Object, e As EventArgs)
        dtgvOrderList.Enabled = True

        If removeItemForm Is Nothing Then
            removeItemForm = New fmaPOS_RemoveItemForm(dtgvOrderList)
            removeItemForm.ShowDialog()
        End If
    End Sub

    Private Sub btnNewAddItem_Click(sender As Object, e As EventArgs)
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()

        Me.txtAmtDue.Text = "<>"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        itemInquiry = Nothing
        Me.Close()
    End Sub

    Private Sub btnSetPatient_MouseHover(sender As Object, e As EventArgs) Handles btnSetPatient.MouseHover
        setMouseHoverColor(btnSetPatient)
    End Sub

    Private Sub setMouseHoverColor(btn As ButtonX)
        btn.ForeColor = Color.Black
    End Sub

    Private Sub btnSetPatient_MouseLeave(sender As Object, e As EventArgs) Handles btnSetPatient.MouseLeave
        setMouseLeaveColor(btnSetPatient)
    End Sub

    Private Sub setMouseLeaveColor(btn As ButtonX)
        btn.ForeColor = Color.Cyan
    End Sub

    Private Sub btnInq_MouseHover(sender As Object, e As EventArgs) Handles btnInq.MouseHover
        setMouseHoverColor(btnInq)
    End Sub

    Private Sub btnInq_MouseLeave(sender As Object, e As EventArgs) Handles btnInq.MouseLeave
        setMouseLeaveColor(btnInq)
    End Sub

    Private Sub btnNewSale_MouseHover(sender As Object, e As EventArgs) Handles btnNewSale.MouseHover
        setMouseHoverColor(btnNewSale)
    End Sub

    Private Sub btnNewSale_MouseLeave(sender As Object, e As EventArgs) Handles btnNewSale.MouseLeave
        setMouseLeaveColor(btnNewSale)
    End Sub

    Private Sub btnVoid_MouseHover(sender As Object, e As EventArgs) Handles btnVoid.MouseHover
        setMouseHoverColor(btnVoid)
    End Sub

    Private Sub btnVoid_MouseLeave(sender As Object, e As EventArgs) Handles btnVoid.MouseLeave
        setMouseLeaveColor(btnVoid)
    End Sub

    Private Sub btnSetQty_MouseHover(sender As Object, e As EventArgs) Handles btnSetQty.MouseHover
        setMouseHoverColor(btnSetQty)
    End Sub

    Private Sub btnSetQty_MouseLeave(sender As Object, e As EventArgs) Handles btnSetQty.MouseLeave
        setMouseLeaveColor(btnSetQty)
    End Sub

    Private Sub btnRemoveItem_MouseHover(sender As Object, e As EventArgs) Handles btnRemoveItem.MouseHover
        setMouseHoverColor(btnRemoveItem)
    End Sub

    Private Sub btnRemoveItem_MouseLeave(sender As Object, e As EventArgs) Handles btnRemoveItem.MouseLeave
        setMouseLeaveColor(btnRemoveItem)
    End Sub

    Private Sub btnAddItem_MouseHover(sender As Object, e As EventArgs) Handles btnAddItem.MouseHover
        setMouseHoverColor(btnAddItem)
    End Sub

    Private Sub btnAddItem_MouseLeave(sender As Object, e As EventArgs) Handles btnAddItem.MouseLeave
        setMouseLeaveColor(btnAddItem)
    End Sub

    Private Sub btnAddPatient_MouseHover(sender As Object, e As EventArgs) Handles btnAddPatient.MouseHover
        setMouseHoverColor(btnAddPatient)
    End Sub

    Private Sub btnAddPatient_MouseLeave(sender As Object, e As EventArgs) Handles btnAddPatient.MouseLeave
        setMouseLeaveColor(btnAddPatient)
    End Sub

    Private Sub btnPostPayment_MouseHover(sender As Object, e As EventArgs) Handles btnPostPayment.MouseHover
        setMouseHoverColor(btnPostPayment)
    End Sub

    Private Sub btnPostPayment_MouseLeave(sender As Object, e As EventArgs) Handles btnPostPayment.MouseLeave
        setMouseLeaveColor(btnPostPayment)
    End Sub


End Class
