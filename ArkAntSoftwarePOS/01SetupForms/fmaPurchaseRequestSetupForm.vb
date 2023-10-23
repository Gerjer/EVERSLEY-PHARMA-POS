Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class fmaPurchaseRequestSetupForm

    Private PR_DATA_TABLE As DataTable

    Private row_Index_Click As Integer = -1
    Private col_Index_Click As Integer = -1
    Public OPERATION As String
    Public RIS_NO As String = ""
    Public PR_ID As String = ""
    Private PR_TOTAL As Double = 0



    Private Sub fmaRISSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        PR_TOTAL = 0
        txtReceiveDate.Value = Date.Now



        displayItems()

        loadComboBox()




        If OPERATION = "EDIT" Then

            ProcessEdit(RIS_NO)

        End If



    End Sub

    Private Sub ProcessEdit(RIS_NO As String)

        btnSaveRIS.Text = "UPDATE"

        Dim dt As New DataTable
        dt = getRISReceived(RIS_NO)
        If dt.Rows.Count > 0 Then

            ''FLL IN MAIN
            'txtRISNo.Text = dt(0)("RIS_No").ToString
            'txtReceiveDate.Value = dt(0)("date_received").ToString
            'txtFundCluster.Text = If(IsDBNull(dt(0)("fund_cluster").ToString), "", dt(0)("fund_cluster").ToString)
            'txtFundClusterCode.Text = If(IsDBNull(dt(0)("fund_cluster_code").ToString), "", dt(0)("fund_cluster_code").ToString)



            'FILL ITEM DETAILS

            'Dim item_details As New DataTable
            'item_details = getItemDetails(RIS_NO)
            'If item_details.Rows.Count > 0 Then

            '    For Each item As DataRow In item_details.Rows
            '        dgvFEES.Rows.Add(New String() {item("inv_master_Name").ToString, item("qty_received").ToString, item("price").ToString, item("expiry_date").ToString, item("location").ToString, item("remarks").ToString, item("a_code").ToString, item("location_id").ToString, "EDIT", item("delivery_status").ToString})
            '    Next

            'End If


        End If




    End Sub

    Private Function getItemDetails(rIS_NO As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
	            ris_details.inv_master_Name, 
	            ris_details.qty_received, 
	            ris_details.price, 
	            DATE_FORMAT(ris_details.expiry_date,'%Y-%m-%d')'expiry_date', 
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



        txtFundCluster.DataSource = DataSource(String.Format("SELECT 	id,`name`,`code` FROM fund_cluster"))
        txtFundCluster.ValueMember = "id"
        txtFundCluster.DisplayMember = "name"
        txtFundCluster.SelectedIndex = -1




    End Sub



    Private Sub displayItems()
        Dim MeData As New DataTable
        Dim SQL As String = ""

        MeData = Nothing
        SQL = "SELECT a_code,a_name FROM inventory_master order by a_name"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.cmbxItem.DataSource = MeData
        Me.cmbxItem.DisplayMember = "a_name"
        Me.cmbxItem.ValueMember = "a_code"
        Me.cmbxItem.Text = ""
        Me.cmbxItem.SelectedIndex = -1
        Me.txtItemCode.Text = ""
    End Sub






    Private Sub cmbxItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxItem.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbxItem.SelectedItem, DataRowView)
            Me.txtItemCode.Text = drv.Item("a_code").ToString
        Catch ex As Exception
            Me.txtItemCode.Text = ""
        End Try
    End Sub




    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click



        If txtItemCode.Text.Length = 0 Then
            MsgBox("Please select Item", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If diItemQty.Value <= 0 Then
            MsgBox("Item Quantity should be above Zero", MsgBoxStyle.Critical)
            Exit Sub
        End If


        ' add to list
        Dim total As Double = Me.diItemQty.Value * Me.diPrice.Value

        PR_TOTAL += total


        dgvFEES.Rows.Add(New String() {Me.cmbxItem.Text, Me.diItemQty.Text, Me.diPrice.Text, Format(total, "#,##0.00"), Me.txtItemCode.Text})
        txtPRTotal.Text = Format(PR_TOTAL, "#,##0.00")

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


    Private Sub recomputePRTotal()
        Dim total As Double = 0

        For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1
            total += CDbl(dgvFEES.Item(3, nCtr).Value)
        Next


        PR_TOTAL = total
        txtPRTotal.Text = Format(PR_TOTAL, "#,##0.00")
    End Sub

    Private Sub clearItems()
        cmbxItem.SelectedIndex = -1

        diItemQty.Value = 0

        txtPurpose.Text = ""
        diPrice.Value = 0


        txtItemCode.Text = ""
    End Sub

    Private Sub clearPR()
        txtPR_No.Text = ""


        txtFundCluster.Text = ""



    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        clearItems()
        clearPR()
        clearList()
    End Sub

    Private Sub clearList()
        dgvFEES.Rows.Clear()
    End Sub

    Private Sub btnSaveRIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRIS.Click

        If MessageBox.Show("Are you sure you want to SAVE Purchase Request?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            ' CHECK LIST


            If dgvFEES.Rows.Count = 0 Then
                MsgBox("Please add Item/s to PR.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If




            Dim SQLIN As String = ""

            If btnSaveRIS.Text = "SAVE" Then

                'save RISMaster

                SQLIN = "INSERT INTO pr_master(pr_number,pr_date,fund_cluster,fund_cluster_id,total, purpose)"
                SQLIN += " VALUES("
                SQLIN += String.Format("'{0}', '{1}',", txtPR_No.Text, Format(txtReceiveDate.Value, "yyyy-MM-dd"))
                SQLIN += String.Format("'{0}', '{1}',", txtFundCluster.Text, txtFundClusterCode.Text)
                SQLIN += String.Format("'{0}', '{1}')", CDbl(txtPRTotal.Text), txtPurpose.Text)

                If clsDBConn.Execute(SQLIN) Then
                    Dim PR_ID As Integer = 0

                    Dim SQLEX As String = "SELECT pr_id FROM pr_master ORDER BY pr_id DESC LIMIT 1 "

                    Dim tData As DataTable
                    tData = clsDBConn.ExecQuery(SQLEX)

                    If tData.Rows.Count > 0 Then

                        Try
                            PR_ID = CInt(tData.Rows(0).Item("pr_id"))
                            txtPR_id.Text = PR_ID
                        Catch ex As Exception

                        End Try
                    End If



                    insertPRDetails(PR_ID)


                End If

                MsgBox("This Purchase Request has been Saved.", MsgBoxStyle.Information)

                btnSaveRIS.Text = "UPDATE"

            Else

                'update RISMaster

            End If


        End If
    End Sub

    Private Sub insertPRDetails(ByVal PR_NO As Integer)

        If OPERATION = "EDIT" Then
            DataSource(String.Format("DELETE FROM pr_details WHERE pr_master_id = '" & PR_NO & "'"))
            txtPR_No.Text = RIS_NO
        End If


        For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1

            Dim inv_master_code As String = dgvFEES.Item(4, nCtr).Value.ToString
            Dim inv_master_Name As String = dgvFEES.Item(0, nCtr).Value.ToString
            Dim qty As Double = CDbl(dgvFEES.Item(1, nCtr).Value.ToString)
            Dim price As Double = CDbl(dgvFEES.Item(2, nCtr).Value.ToString)



            Dim SQLIN As String = "INSERT INTO pr_details(pr_master_id,inv_master_code,inv_name,qty,unit_cost)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}','{1}',", PR_NO, inv_master_code)
            SQLIN += String.Format("'{0}','{1}','{2}')", inv_master_Name, qty, price)



            clsDBConn.Execute(SQLIN)



        Next
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



    Private Sub btnSearchItem_Click(sender As Object, e As EventArgs) Handles btnSearchItem.Click

        Dim frm As New fmaInventoryMasterSetupForm
        frm.Tag = 1
        frm.BringToFront()
        frm.ShowDialog()
        displayItems()
    End Sub

    Dim rowIndex As Integer
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        dgvFEES.Rows.RemoveAt(rowIndex)
        recomputePRTotal()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        dgvFEES.Rows(rowIndex).ReadOnly = False

    End Sub



    Private Sub dgvFEES_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvFEES.CellMouseUp
        rowIndex = e.RowIndex
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btpPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click



        Dim SQLEX As String = "SELECT concat('PR No. : ', pr_master.pr_number) 'pr_number'
                                , pr_master.pr_date
                                , pr_master.fund_cluster
                                , pr_master.fund_cluster_id
                                , pr_master.total
                                , concat('PURPOSE : ', pr_master.purpose) 'purpose'
                                , pr_details.inv_master_code
                                , pr_details.inv_name
                                , pr_details.qty
                                , pr_details.unit_cost
                                , (pr_details.qty * pr_details.unit_cost) 'total_cost'
                                , inventory_master.uom
                            FROM  pr_details
                            INNER JOIN pr_master 
                                ON (pr_details.pr_master_id = pr_master.pr_id)
                            INNER JOIN inventory_master 
                                    ON (pr_details.inv_master_code = inventory_master.a_code)"
        SQLEX += " WHERE pr_master.pr_id='" & Me.txtPR_id.Text & "'"

        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Dim new_report As New fzzReportViewerForm
            Try

                new_report.AttachReport(SQLEX, "Purchase Request " & txtPR_id.Text) = New rpt_PurchaseRequest
                new_report.Show()
            Catch ex As Exception
                MsgBox("Exception Occured :", ex.Message)
            End Try
        Else
            Dim new_report As New fzzReportViewerForm
            Try

                new_report.AttachReportPreview(PR_DATA_TABLE, "Purchase Request " & txtPR_id.Text) = New rpt_PurchaseRequest
                new_report.Show()
            Catch ex As Exception
                MsgBox("Exception Occured :", ex.Message)
            End Try
        End If



    End Sub

    Private Sub txtPR_id_TextChanged(sender As Object, e As EventArgs) Handles txtPR_id.TextChanged
        If txtPR_id.Text.Length > 0 Then
            btnPrint.Visible = True
            btnPrint.Text = "Print"
        Else
            btnPrint.Visible = False
        End If
    End Sub

    Private Sub btnAutoPopulate_Click(sender As Object, e As EventArgs) Handles btnAutoPopulate.Click
        btnPrint.Visible = True
        btnPrint.Text = "Print Preview"

        PR_DATA_TABLE = New DataTable

        PR_DATA_TABLE.Columns.Add("uom")
        PR_DATA_TABLE.Columns.Add("inv_name")
        PR_DATA_TABLE.Columns.Add("qty")
        PR_DATA_TABLE.Columns.Add("unit_cost")
        PR_DATA_TABLE.Columns.Add("total_cost")


        PR_TOTAL = 0
        dgvFEES.Rows.Clear()

        Dim SQLEX As String = "SELECT  inventory_master.a_code , inventory_master.a_name"
        SQLEX += " , ris_details.price, inventory_master.uom"
        SQLEX += "  , IFNULL(ris_details.qty_remaining, '0') 'qty_remaining'"
        SQLEX += " , inventory_master.item_reordercount"
        SQLEX += " FROM  inventory_master"
        SQLEX += " LEFT JOIN ris_details "
        SQLEX += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
        SQLEX += " WHERE qty_remaining < item_reordercount OR qty_remaining <= 0"
        SQLEX += " GROUP BY a_code ORDER BY a_name"


        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then

            For jRows As Integer = 0 To (MeData.Rows.Count - 1)
                Dim a_code As String = ""
                Dim uom As String = ""
                Dim a_name As String = ""
                Dim price As Double = 0
                Dim reOrderQty As Double = 0

                a_code = MeData.Rows(jRows).Item("a_code").ToString
                a_name = MeData.Rows(jRows).Item("a_name").ToString
                uom = MeData.Rows(jRows).Item("uom").ToString

                price = MeData.Rows(jRows).Item("price")
                reOrderQty = MeData.Rows(jRows).Item("item_reordercount")

                ' add to list

                If reOrderQty = 0 Then
                    reOrderQty = 50
                End If


                Dim total As Double = price * reOrderQty

                PR_TOTAL += total


                dgvFEES.Rows.Add(New String() {a_name, reOrderQty, price, Format(total, "#,##0.00"), a_code})



                PR_DATA_TABLE.Rows.Add(uom, a_name, reOrderQty, price, Format(total, "#,##0.00"))

                txtPRTotal.Text = Format(PR_TOTAL, "#,##0.00")

            Next


        End If
    End Sub


End Class