Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class fmaRISSetupForm

    Public Event LOADLIST()
    Private row_Index_Click As Integer = -1
    Private col_Index_Click As Integer = -1
    Public OPERATION As String
    Public RIS_NO As String = ""

    Private WithEvents SETUPFORM As fmaInventoryMasterSetupForm

    Private Sub fmaRISSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtReceiveDate.Value = Date.Now
        txtPODate.Value = Date.Now
        dtExpiryDate.Value = Date.Now

        displaySuppliers()
        displayItems()
        displayLocation()
        loadComboBox()

        If isWithAttachment.Checked = False Then
            LabelX9.Visible = False
            btnAttachFile.Visible = False
            GroupBox1.Visible = False
        End If

        final_attach_file.Clear()

        If OPERATION = "EDIT" Then

            ProcessEdit(RIS_NO)

        End If



    End Sub

    Private Sub ProcessEdit(RIS_NO As String)

        btnSaveRIS.Text = "UPDATE"

        Dim dt As New DataTable
        dt = getRISReceived(RIS_NO)
        If dt.Rows.Count > 0 Then

            'FLL IN MAIN
            txtRISNo.Text = dt(0)("RIS_No").ToString
            txtReceiveDate.Value = dt(0)("date_received").ToString
            cmbBidding.Text = If(IsDBNull(dt(0)("date_received").ToString), "", dt(0)("date_received").ToString)
            txtProcurementMode.Text = If(IsDBNull(dt(0)("procurement_mode").ToString), "", dt(0)("procurement_mode").ToString)
            txtSupplierName.Text = dt(0)("supplier_name").ToString
            txtFundCluster.Text = If(IsDBNull(dt(0)("fund_cluster").ToString), "", dt(0)("fund_cluster").ToString)
            txtFundClusterCode.Text = If(IsDBNull(dt(0)("fund_cluster_code").ToString), "", dt(0)("fund_cluster_code").ToString)
            txtFundClass.Text = If(IsDBNull(dt(0)("fund_class").ToString), "", dt(0)("fund_class").ToString)
            txtPONo.Text = dt(0)("po_no").ToString
            txtPODate.Value = dt(0)("po_date").ToString
            txtSINo.Text = dt(0)("si_no").ToString
            txtReceivedBy.Text = If(IsDBNull(dt(0)("received_by").ToString), "", dt(0)("received_by").ToString)


            'FILL ATTACH FILE
            attach_file.Clear()

            Dim dt_attach As New DataTable
            dt_attach = getAttachFile(RIS_NO)
            If dt_attach.Rows.Count > 0 Then

                isWithAttachment.Checked = True

                For Each row As DataRow In dt_attach.Rows
                    Dim obj As New attach_file
                    With obj
                        Try
                            .attach_type = row("attach_type").ToString
                            .attach_file_name = row("FILE NAME").ToString
                            .attach_file_path = ""
                            .attach_file_dir = row("LINK PATH").ToString
                            .attach_image = Image.FromFile(row("LINK PATH").ToString)
                        Catch ex As Exception

                        End Try

                    End With
                    attach_file.Add(obj)
                Next

            End If

            gcLink.DataSource = dt_attach
            gvLink.Columns("RIS_Master_No").Visible = False
            gvLink.Columns("attach_type").Visible = False

            'FILL ITEM DETAILS

            Dim item_details As New DataTable
            item_details = getItemDetails(RIS_NO)
            If item_details.Rows.Count > 0 Then

                For Each item As DataRow In item_details.Rows
                    dgvFEES.Rows.Add(New String() {item("inv_master_Name").ToString, item("qty_received").ToString, item("price").ToString, item("expiry_date").ToString, item("batch_number").ToString, item("location").ToString, item("remarks").ToString, item("a_code").ToString, item("location_id").ToString, item("delivery_status").ToString})
                Next

            End If


        End If




    End Sub

    Private Function getItemDetails(rIS_NO As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
	            ris_details.inv_master_Name, 
	            ris_details.qty_received, 
	            ris_details.price, 
	            DATE_FORMAT(ris_details.expiry_date,'%Y-%m-%d')'expiry_date', 
                ris_details.batch_number, 
	            ris_details.location, 
	            ris_details.remarks, 
	            ris_details.location_id,
	            ris_details.delivery_status,
                a_code
            FROM
	            ris_details
                INNER JOIN inventory_master ON ris_details.inv_master_SysPK = inventory_master.a_code
            WHERE
	            ris_details.RIS_Master_No = '" & rIS_NO & "'"
        Return DataSource(sql)
    End Function

    Private Function getAttachFile(rIS_NO As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
	            ris_attachment.RIS_Master_No, 
	            ris_attachment.attach_type, 
	            ris_attachment.attach_filename'FILE NAME', 
	            ris_attachment.attach_dir 'LINK PATH'
            FROM
	            ris_attachment
            WHERE
	            ris_attachment.RIS_Master_No = '" & rIS_NO & "' "
        Return DataSource(sql)
    End Function

    Private Function getRISReceived(rIS_NO As String) As DataTable

        Dim SQL As String = " SELECT ris_master.date_received,ris_master.RIS_No"
        SQL += " ,	supplier.a_name 'supplier_name',ris_master.po_date,ris_master.po_no"
        SQL += " ,	ris_master.si_no,ris_master.received_by,ris_master.fund_cluster,ris_master.fund_cluster_code"
        SQL += " ,	ris_master.fund_class,ris_master.procurement_mode,ris_master.bid_attemp"
        SQL += " ,	ris_attachment.attach_dir"
        SQL += "  FROM 	ris_master"
        SQL += "  INNER JOIN supplier ON ris_master.supplier_SysPK = supplier.a_code"
        SQL += "  LEFT JOIN ris_attachment ON ris_master.RIS_No = ris_attachment.RIS_Master_No"
        SQL += "  WHERE  RIS_No = '" & rIS_NO & "'"

        Return DataSource(SQL)

    End Function

    Private Sub loadComboBox()

        cmbBidding.DataSource = DataSource(String.Format("SELECT DISTINCT   0 AS 'id',	bid_attemp 'name' FROM	ris_master 	WHERE bid_attemp is NOT NULL AND bid_attemp <> ''	"))
        cmbBidding.ValueMember = "id"
        cmbBidding.DisplayMember = "name"
        cmbBidding.SelectedIndex = -1

        txtReceivedBy.DataSource = DataSource(String.Format("SELECT DISTINCT   0 AS 'id',	received_by 'name' FROM	ris_master 	WHERE received_by is NOT NULL AND received_by <> ''	ORDER BY received_by"))
        txtReceivedBy.ValueMember = "id"
        txtReceivedBy.DisplayMember = "name"
        txtReceivedBy.SelectedIndex = -1

        cmbDeliveryStatus.DataSource = DataSource(String.Format("SELECT DISTINCT   0 AS 'id',	delivery_status 'name' FROM	ris_details 	WHERE delivery_status is NOT NULL AND delivery_status <> ''	"))
        cmbDeliveryStatus.ValueMember = "id"
        cmbDeliveryStatus.DisplayMember = "name"
        cmbDeliveryStatus.SelectedIndex = -1

        txtProcurementMode.DataSource = DataSource(String.Format("SELECT DISTINCT   0 AS 'id',	procurement_mode 'name' FROM	ris_master 	WHERE procurement_mode is NOT NULL"))
        txtProcurementMode.ValueMember = "id"
        txtProcurementMode.DisplayMember = "name"
        txtProcurementMode.SelectedIndex = -1

        txtFundCluster.DataSource = DataSource(String.Format("SELECT 	id,`name`,`code` FROM fund_cluster"))
        txtFundCluster.ValueMember = "id"
        txtFundCluster.DisplayMember = "name"
        txtFundCluster.SelectedIndex = -1

        txtFundClass.DataSource = DataSource(String.Format("SELECT SysPK 'id', a_name 'name' FROM pharmaceuticals ORDER BY a_name"))
        txtFundClass.ValueMember = "id"
        txtFundClass.DisplayMember = "name"
        txtFundClass.SelectedIndex = -1


    End Sub

    Private Sub displaySuppliers()
        Dim MeData As New DataTable
        Dim SQL As String = ""

        MeData = Nothing
        SQL = "SELECT a_code,a_name FROM supplier order by a_name"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtSupplierName.DataSource = MeData
        Me.txtSupplierName.DisplayMember = "a_name"
        Me.txtSupplierName.ValueMember = "a_code"
        Me.txtSupplierName.Text = ""
        Me.txtSupplierName.SelectedIndex = -1
        Me.txtSupplierCode.Text = ""
    End Sub

    Private Sub displayItems()


        Dim MeData As New DataTable
        Dim SQL As String = ""

        MeData = Nothing
        SQL = "SELECT a_code,CONCAT(a_name,' (',ROUND(selling_price,2),')',' ',IFNULL(brand_name,''))'display_name',a_name FROM inventory_master WHERE is_deleted <> 1  order by a_name"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.cmbxItem.DataSource = MeData
        Me.cmbxItem.DisplayMember = "display_name"
        Me.cmbxItem.ValueMember = "a_code"
        Me.cmbxItem.Text = ""
        Me.cmbxItem.SelectedIndex = -1
        Me.txtItemCode.Text = ""
    End Sub

    Private Sub displayLocation()
        Dim MeData As New DataTable
        Dim SQL As String = ""

        MeData = Nothing
        SQL = "SELECT a_code,location_name  FROM inventory_location"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.cmbxLocation.DataSource = MeData
        Me.cmbxLocation.DisplayMember = "location_name"
        Me.cmbxLocation.ValueMember = "a_code"
        Me.cmbxLocation.Text = ""
        Me.cmbxLocation.SelectedIndex = -1
        Me.txtLocationCode.Text = ""
    End Sub

    Private Sub txtSupplierName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierName.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtSupplierName.SelectedItem, DataRowView)
            Me.txtSupplierCode.Text = drv.Item("a_code").ToString
        Catch ex As Exception
            Me.txtSupplierCode.Text = ""
        End Try
    End Sub

    Dim item_name As String = ""
    Private Sub cmbxItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxItem.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbxItem.SelectedItem, DataRowView)
            Me.txtItemCode.Text = drv.Item("a_code").ToString
            item_name = drv.Item("a_name").ToString
        Catch ex As Exception
            Me.txtItemCode.Text = ""
        End Try
    End Sub


    Private Sub cmbxLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxLocation.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbxLocation.SelectedItem, DataRowView)
            Me.txtLocationCode.Text = drv.Item("a_code").ToString
        Catch ex As Exception
            Me.txtLocationCode.Text = ""
        End Try

    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click

        'check filter
        cmbDeliveryStatus.Text = DeliveryStatus

        If txtItemCode.Text.Length = 0 Then
            MsgBox("Please select Item", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If diItemQty.Value <= 0 Then
            MsgBox("Item Quantity should be above Zero", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If txtLocationCode.Text.Length = 0 Then
            MsgBox("Please select Location", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If dtExpiryDate.Text.Length = 0 Then
            MsgBox("Expiry Date Required", MsgBoxStyle.Critical)
            Exit Sub
        End If


        ' add to list
        'Me.cmbxItem.Text
        dgvFEES.Rows.Add(New String() {item_name, Me.diItemQty.Text, Me.diPrice.Text, Format(Me.dtExpiryDate.Value, "yyyy-MM-dd"), Me.txtbatchNo.Text, Me.cmbxLocation.Text, Me.txtRemarks.Text, Me.txtItemCode.Text, Me.txtLocationCode.Text, cmbDeliveryStatus.Text})

        clearItems()

        'For Each row In attach_file.ToList
        '    Dim obj As New attach_file
        '    With obj
        '        .attach_type = row.attach_type
        '        .attach_file_name = row.attach_file_name
        '        .attach_file_path = row.attach_file_path
        '        .attach_file_dir = row.attach_file_dir
        '        .attach_image = row.attach_image
        '    End With
        '    final_attach_file.Add(obj)
        'Next


    End Sub

    Private Sub clearItems()
        cmbxItem.SelectedIndex = -1
        diItemQty.Value = 0
        dtExpiryDate.Value = Date.Now
        cmbxLocation.SelectedIndex = -1
        txtRemarks.Text = ""
        diPrice.Value = 0

        txtLocationCode.Text = ""
        txtItemCode.Text = ""
    End Sub

    Private Sub clearRIS()
        txtRISNo.Text = ""
        txtProcurementMode.Text = ""
        txtSupplierName.SelectedIndex = -1
        txtSupplierCode.Text = ""

        txtFundCluster.Text = ""
        txtPONo.Text = ""
        txtPODate.Value = Date.Now
        txtReceiveDate.Value = Date.Now

        txtSINo.Text = ""
        isWithAttachment.CheckState = CheckState.Unchecked

        gvLink.Columns.Clear()

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        clearItems()
        clearRIS()
        clearList()
    End Sub

    Private Sub clearList()
        dgvFEES.Rows.Clear()
    End Sub

    Private Sub btnSaveRIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRIS.Click



        'check Transaction Day if already created
        Dim SQLEXTRDate As String = "SELECT TransactionDay FROM transaction_day WHERE TransactionDay = '" & Format(txtReceiveDate.Value, "yyyyy-MM-dd") & "'"


        Dim tData As DataTable
        tData = clsDBConn.ExecQuery(SQLEXTRDate)


        If tData.Rows.Count <= 0 Then


            Dim msgString As String = "Cannot Add RIS this time.."
            msgString += vbNewLine & "Please Create Transaction Day for the specified RIS Received Date."

            MsgBox(msgString, MsgBoxStyle.Information)

            Exit Sub
        End If

        Dim msg_box As String = ""
        If btnSaveRIS.Text = "SAVE" Then
            msg_box = "Are you sure you want to SAVE RIS?"
        Else
            msg_box = "Are you sure you want to UPDATE RIS?"
        End If


        If MessageBox.Show(msg_box, "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            ' CHECK LIST


            If txtRISNo.Text.Length = 0 Then
                MsgBox("Please enter RIS Number.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If txtProcurementMode.Text.Length = 0 Then
                MsgBox("Please enter Procurement Mode.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If txtSupplierName.Text.Length = 0 Then
                MsgBox("Please enter Supplier.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If txtFundCluster.Text.Length = 0 Then
                MsgBox("Please enter Fund Cluster.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If txtPONo.Text.Length = 0 Then
                MsgBox("Please enter PO Number.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If txtSINo.Text.Length = 0 Then
                MsgBox("Please enter SI Number.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            '    If btnSaveRIS.Text = "SAVE" Then
            If isWithAttachment.Checked = False Then
                    MsgBox("Please set Attachment.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            '       End If


            Dim SQLIN As String = ""

                If btnSaveRIS.Text = "SAVE" Then

                    'save RISMaster
                    SQLIN = "INSERT INTO ris_master(RIS_No,date_received,po_no,po_date,procurement_mode,"
                    SQLIN += " si_no,supplier,supplier_SysPK,fund_cluster,attached_PO_SI,received_by,bid_attemp,fund_cluster_id,fund_cluster_code,fund_class_id,fund_class)"
                    SQLIN += " VALUES("
                    SQLIN += String.Format("'{0}', '{1}', '{2}',", Me.txtRISNo.Text, Format(txtReceiveDate.Value, "yyyy-MM-dd"), Me.txtPONo.Text)
                    SQLIN += String.Format("'{0}', '{1}', '{2}',", Format(txtPODate.Value, "yyyy-MM-dd"), Me.txtProcurementMode.Text, Me.txtSINo.Text)
                    SQLIN += String.Format("'{0}', '{1}', '{2}',", Me.txtSupplierName.Text, Me.txtSupplierCode.Text, Me.txtFundCluster.Text)
                SQLIN += String.Format("'{0}', '{1}', '{2}',", IIf(isWithAttachment.Checked = True, 1, 0), Me.txtReceivedBy.Text, IIf(cmbBidding.Text = "", "", cmbBidding.Text))
                SQLIN += String.Format("'{0}', '{1}', '{2}', '{3}')", Me.txtFundCluster.SelectedValue, Me.txtFundClusterCode.Text, Me.txtFundClass.SelectedValue, Me.txtFundClass.Text)

                Else

                    'update RISMaster
                    SQLIN = "UPDATE ris_master SET date_received = '" & Format(txtReceiveDate.Value, "yyyy-MM-dd") & "',po_no = '" & Me.txtPONo.Text & "' "
                    SQLIN += " , po_date = '" & Format(txtPODate.Value, "yyyy-MM-dd") & "',procurement_mode = '" & Me.txtProcurementMode.Text & "',si_no = '" & Me.txtSINo.Text & "'"
                    SQLIN += " , supplier = '" & Me.txtSupplierName.Text & "',supplier_SysPK = '" & Me.txtSupplierCode.Text & "',fund_cluster = '" & Me.txtFundCluster.Text & "'"
                    SQLIN += " , attached_PO_SI = '" & IIf(isWithAttachment.Checked = True, 1, 0) & "',received_by = '" & Me.txtReceivedBy.Text & "',bid_attemp = '" & cmbBidding.Text & "'"
                    SQLIN += " , fund_cluster_id = '" & Me.txtFundCluster.SelectedValue & "',fund_cluster_code = '" & Me.txtFundClusterCode.Text & "',fund_class_id = '" & Me.txtFundClass.SelectedValue & "',fund_class= '" & Me.txtFundClass.Text & "'"
                    SQLIN += " WHERE RIS_No ='" & RIS_NO & "'"

                End If

                If clsDBConn.Execute(SQLIN) Then
                    insertRISDetails()

                    If isWithAttachment.Checked = True Then

                        SQLIN = ""
                    Dim lastPK As String = txtRISNo.Text
                    'Insert RIS Attachment
                    If OPERATION = "EDIT" Then
                        DataSource(String.Format("DELETE FROM ris_attachment WHERE RIS_Master_No = '" & txtRISNo.Text & "'"))
                        '         lastPK = txtRISNo.Text
                        '     Else
                        '        lastPK = 'DataObject(String.Format("SELECT max(RIS_No) FROM ris_master"))
                    End If


                    For Each row In attach_file.ToList

                            Dim new_dir As String = ""
                            If OPERATION = "EDIT" Then
                            new_dir = row.attach_file_dir + row.attach_file_name
                            new_dir = new_dir.Replace("\", "\\")
                        Else
                                new_dir = row.attach_file_dir
                                new_dir = System.IO.Path.Combine(new_dir, lastPK & "-" & row.attach_file_name).Replace("\", "\\")
                            End If

                            SQLIN = " INSERT INTO ris_attachment(RIS_Master_No,attach_type,attach_filename,attach_dir)"
                            SQLIN += " VALUES("
                            SQLIN += String.Format("'{0}',", lastPK)
                            SQLIN += String.Format("'{0}',", row.attach_type)
                            SQLIN += String.Format("'{0}',", row.attach_file_name)
                            SQLIN += String.Format("'{0}')", new_dir)

                            If clsDBConn.Execute(SQLIN) Then

                                Dim picbox As New PictureBox

                                Dim File1 As Image = row.attach_image
                                picbox.Image = File1
                                If Not File.Exists(new_dir) Then
                                    picbox.Image.Save(new_dir)
                                Else
                                    'remove existing photo
                                    '             File.Delete(new_dir)
                                    '            picbox.Image.Save(new_dir)
                                End If

                            End If

                        Next

                    End If
                End If

                MsgBox("This Requition Issue Slip has been Saved.", MsgBoxStyle.Information)

                btnSaveRIS.Text = "SAVE"
            End If
    End Sub

    Private Sub insertRISDetails()

        'Checking for ExpiryDate not null

        For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1
            Dim expiry_date As String = dgvFEES.Item(3, nCtr).Value.ToString
            If expiry_date = "" Then
                MsgBox("Please set Expiry Date on item...", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Next

        If OPERATION = "EDIT" Then
            DataSource(String.Format("DELETE FROM ris_details WHERE RIS_Master_No = '" & RIS_NO & "'"))
            txtRISNo.Text = RIS_NO
        End If


        For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1

            Dim inv_master_Name As String = dgvFEES.Item(0, nCtr).Value.ToString
            Dim qty_received As Double = CDbl(dgvFEES.Item(1, nCtr).Value.ToString)
            Dim price As Double = CDbl(dgvFEES.Item(2, nCtr).Value.ToString)
            Dim expiry_date As String = dgvFEES.Item(3, nCtr).Value.ToString
            Dim batch_number As String = dgvFEES.Item(4, nCtr).Value.ToString
            Dim location As String = dgvFEES.Item(5, nCtr).Value.ToString
            Dim remarks As String = dgvFEES.Item(6, nCtr).Value.ToString
            Dim inv_master_SysPK As String = dgvFEES.Item(7, nCtr).Value.ToString
            Dim location_id As String = dgvFEES.Item(8, nCtr).Value.ToString
            Dim delivery_status As String = dgvFEES.Item(9, nCtr).Value.ToString



            Dim SQLIN As String = "INSERT INTO ris_details(RIS_Master_No,inv_master_SysPK,inv_master_Name,"
            SQLIN += " qty_received, price, remarks, expiry_date, location, location_id,delivery_status,qty_remaining,batch_number)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}','{1}','{2}',", txtRISNo.Text, inv_master_SysPK, inv_master_Name)
            SQLIN += String.Format("'{0}','{1}','{2}','{3}',", qty_received, price, remarks, expiry_date)
            SQLIN += String.Format("'{0}','{1}','{2}','{3}','{4}')", location, location_id, delivery_status, qty_received, batch_number)


            If clsDBConn.Execute(SQLIN) Then

            End If

            'update daily_inventory_details "added"

            Dim UpdateInvDet As String = "UPDATE daily_inventory_details SET remaining_qty=initial_qty + (" & qty_received & "+added) - (sold+pullout)"
            UpdateInvDet += ", added=added+'" & qty_received & "'"
            UpdateInvDet += " WHERE a_code = '" & inv_master_SysPK & "'"
            UpdateInvDet += " And TRD_Date='" & Format(Me.txtReceiveDate.Value, "yyyy-MM-dd") & "'"


            clsDBConn.Execute(UpdateInvDet)

            'if not in daily_inventory_details, add it

            Dim SQLEX_Exist As String = "SELECT SysPK_TRD, SysPK_InvMaster,TRD_Date FROM daily_inventory_details WHERE "
            SQLEX_Exist += " a_code='" & inv_master_SysPK & "'"
            SQLEX_Exist += "AND TRD_Date='" & Format(Me.txtReceiveDate.Value, "yyyy-MM-dd") & "'"

            Dim MeData As DataTable

            MeData = clsDBConn.ExecQuery(SQLEX_Exist)

            If MeData.Rows.Count = 0 Then
                'insert to daily_sales_inventory
                Dim SQLEX As String = "SELECT TRD_SYSPK FROM transaction_day WHERE TransactionDay='" & Format(Me.txtReceiveDate.Value, "yyyy-MM-dd") & "'"


                MeData = clsDBConn.ExecQuery(SQLEX)

                Dim TRD_SYSPK As String = MeData.Rows(0).Item("TRD_SYSPK").ToString


                If MeData.Rows.Count > 0 Then
                    Dim SQLINVMaster As String = "select SysPK, uom from inventory_master where a_code='" & inv_master_SysPK & "'"

                    MeData = clsDBConn.ExecQuery(SQLINVMaster)

                    Dim invMasterSysPK As String = ""
                    Dim OUM As String = ""

                    If MeData.Rows.Count > 0 Then
                        invMasterSysPK = MeData.Rows(0).Item("SysPK").ToString
                        OUM = MeData.Rows(0).Item("uom").ToString
                    End If






                    Dim SQLINDID As String = "INSERT INTO daily_inventory_details(SysPK_TRD,SysPK_InvMaster,"
                    SQLINDID += " a_name,item_unit,initial_qty,a_descr,TRD_Date,a_code, remaining_qty)"
                    SQLINDID += "VALUES("
                    SQLINDID += String.Format("'{0}', '{1}',", TRD_SYSPK, invMasterSysPK)
                    SQLINDID += String.Format("'{0}', '{1}',", inv_master_Name, OUM)
                    SQLINDID += String.Format("'{0}', '{1}',", qty_received, inv_master_Name)
                    SQLINDID += String.Format("'{0}', '{1}', '{2}')", Format(Me.txtReceiveDate.Value, "yyyy-MM-dd"), inv_master_SysPK, qty_received)



                    If clsDBConn.Execute(SQLINDID) Then


                    End If
                End If


            End If



        Next
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        RaiseEvent LOADLIST()
        Me.Close()

    End Sub


    Private Sub isWithAttachment_CheckedChanged(sender As Object, e As EventArgs) Handles isWithAttachment.CheckedChanged
        If isWithAttachment.Checked = False Then
            LabelX9.Visible = False
            btnAttachFile.Visible = False
            GroupBox1.Visible = False
        Else
            LabelX9.Visible = True
            btnAttachFile.Visible = True
            GroupBox1.Visible = True
        End If
    End Sub

    Dim final_attach_file As New List(Of attach_file)
    Dim attach_file As New List(Of attach_file)

    Private Sub btnAttachFile_Click(sender As Object, e As EventArgs) Handles btnAttachFile.Click

        attach_file.Clear()

        Dim frm As New frmAttacheFile
        frm.RISNO = txtRISNo.Text
        frm.BringToFront()
        frm.ShowDialog()

        If frm.IfThereIsTransaction = True Then
            Dim dt As New DataTable
            dt.Columns.Add("FILE NAME")
            dt.Columns.Add("LINK PATH")
            For Each row In frm.file_attach.ToList
                dt.Rows.Add(row.attach_file_name, row.attach_file_path)
            Next
            gcLink.DataSource = dt
            attach_file = frm.file_attach
        End If

    End Sub

    Private Sub gvLink_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvLink.RowCellClick

        Dim LinkFile = gvLink.GetFocusedRowCellValue("LINK PATH").ToString
        If My.Computer.FileSystem.FileExists(LinkFile) Then
            Process.Start(LinkFile)
        Else
            MsgBox("File does not exist", MsgBoxStyle.Critical, "FIL NOT FOUND")
        End If

    End Sub

    Private Sub txtFundCluster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtFundCluster.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtFundCluster.SelectedItem, DataRowView)
            txtFundClusterCode.Text = drv.Item("code").ToString
        Catch ex As Exception
            txtFundClusterCode.Text = ""
        End Try
    End Sub

    Dim DeliveryStatus As String = ""
    Private Sub cmbDeliveryStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeliveryStatus.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbDeliveryStatus.SelectedItem, DataRowView)
            DeliveryStatus = drv.Item("name").ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearchItem_Click(sender As Object, e As EventArgs) Handles btnSearchItem.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaInventoryMasterSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()


        'Dim frm As New fmaInventoryMasterSetupForm
        'frm.Tag = 1
        'frm.BringToFront()
        'frm.ShowDialog()

        'displayItems()
    End Sub

    Dim rowIndex As Integer
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        dgvFEES.Rows.RemoveAt(rowIndex)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        dgvFEES.Rows(rowIndex).ReadOnly = False

    End Sub

    Private Sub cmbDeliveryStatus_TextChanged(sender As Object, e As EventArgs) Handles cmbDeliveryStatus.TextChanged
        DeliveryStatus = cmbDeliveryStatus.Text
    End Sub

    Private Sub dgvFEES_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvFEES.CellMouseUp
        rowIndex = e.RowIndex
    End Sub

    Private Sub SETUPFORM_SETUP_CLOSED() Handles SETUPFORM.SETUP_CLOSED
        displayItems()
    End Sub
End Class