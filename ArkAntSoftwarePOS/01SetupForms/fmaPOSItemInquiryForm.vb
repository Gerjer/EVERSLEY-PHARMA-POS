Public Class fmaPOSItemInquiryForm
    Public FormControls As Collection


    Public Event ITEM_SELECTED()
    Public Event WIN_CLOSED()

    Private WithEvents SETUPFORM As fmaInventoryMasterSetupForm


    Private Sub fmaPOSItemInquiryForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RaiseEvent WIN_CLOSED()
    End Sub


    Private Sub fmaPOSItemInquiryForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        displayItems()

        Me.txtSearchKey.Focus()
        Me.txtSearchKey.SelectAll()

    End Sub

    Private Sub displayItems()
        Dim SQL As String = "SELECT ris_details.RIS_Det_No, inventory_master.a_code"
        SQL += " , inventory_master.a_name, inventory_master.method"
        SQL += " , ris_details.price 'buy_price'"
        SQL += " , inventory_master.selling_price"
        SQL += " , ris_details.qty_received"
        SQL += " , ris_details.qty_remaining"
        SQL += " , ris_details.expiry_date"
        SQL += " , ris_details.location"
        SQL += " , ris_master.RIS_No"
        SQL += " , ris_master.date_received"
        SQL += " , ris_master.po_no"
        SQL += " , ris_master.si_no"
        SQL += " , ris_master.supplier"
        SQL += " , ris_master.fund_cluster"
        SQL += " , ris_master.received_by"
        SQL += " , FORMAT((DATEDIFF(ris_details.expiry_date,date_format(NOW(),'%Y-%m-%d'))/30),0) 'calculated_months'"
        SQL += " , ris_master.po_date"
        SQL += " , ris_master.procurement_mode"
        SQL += " , inventory_master.manufacturer"
        SQL += " , inventory_master.brand_name"
        SQL += " , inventory_master.indication"
        SQL += " , inventory_master.drug_interaction"
        SQL += " , (SELECT IFNULL(class_based.`name`,'') FROM medtype INNER JOIN	class_based ON medtype.class_based_id = class_based.id WHERE medtype.SysPK_Item = inventory_master.method_id)'class_based'"
        SQL += " , inventory_master.storage_requirement"
        SQL += " FROM inventory_master"
        SQL += " INNER JOIN ris_details "
        SQL += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
        SQL += " INNER JOIN ris_master "
        SQL += " ON (ris_details.RIS_Master_No = ris_master.RIS_No)"
        SQL += " ORDER BY expiry_date, a_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        arrangeGrid()


    End Sub

    Private Sub arrangeGrid()
        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("RIS_Det_No").Visible = False
                '.DisplayColumns("a_code").Visible = False
                'a_name, medtype, inv_qty, item_unit, item_price
                .DisplayColumns("a_code").DataColumn.Caption = "ITEM CODE"
                .DisplayColumns("a_code").Width = 150
                .DisplayColumns("a_code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("a_name").DataColumn.Caption = "DESCRIPTION"
                .DisplayColumns("a_name").Width = 400
                .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("method").DataColumn.Caption = "TYPE"
                .DisplayColumns("method").Width = 100
                .DisplayColumns("method").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("method").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("buy_price").DataColumn.Caption = "BUY PRICE"
                .DisplayColumns("buy_price").Width = 120
                .DisplayColumns("buy_price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("buy_price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
                .DisplayColumns("buy_price").DataColumn.NumberFormat = "###,###.00"

                .DisplayColumns("selling_price").DataColumn.Caption = "SELLING PRICE"
                .DisplayColumns("selling_price").Width = 150
                .DisplayColumns("selling_price").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("selling_price").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
                .DisplayColumns("buy_price").DataColumn.NumberFormat = "###,###.00"

                .DisplayColumns("qty_received").DataColumn.Caption = "QTY RECEIVED"
                .DisplayColumns("qty_received").Width = 150
                .DisplayColumns("qty_received").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("qty_received").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("qty_received").DataColumn.NumberFormat = "###,###"

                .DisplayColumns("qty_remaining").DataColumn.Caption = "QTY REMAINING"
                .DisplayColumns("qty_remaining").Width = 150
                .DisplayColumns("qty_remaining").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("qty_remaining").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("qty_remaining").DataColumn.NumberFormat = "###,###"

                .DisplayColumns("expiry_date").DataColumn.Caption = "EXPIRY DATE"
                .DisplayColumns("expiry_date").Width = 150
                .DisplayColumns("expiry_date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("expiry_date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("location").DataColumn.Caption = "LOCATION"
                .DisplayColumns("location").Width = 150
                .DisplayColumns("location").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("location").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("po_no").DataColumn.Caption = "P.O NO.#"
                .DisplayColumns("po_no").Width = 130
                .DisplayColumns("po_no").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("po_no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("si_no").DataColumn.Caption = "S.I NO.#"
                .DisplayColumns("si_no").Width = 130
                .DisplayColumns("si_no").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("si_no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("supplier").DataColumn.Caption = "SUPPLIER"
                .DisplayColumns("supplier").Width = 150
                .DisplayColumns("supplier").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("supplier").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("fund_cluster").DataColumn.Caption = "FUND CLUSTER"
                .DisplayColumns("fund_cluster").Width = 120
                .DisplayColumns("fund_cluster").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("fund_cluster").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("received_by").DataColumn.Caption = "RECEIVED BY"
                .DisplayColumns("received_by").Width = 150
                .DisplayColumns("received_by").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("received_by").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("calculated_months").Visible = False

            End With




            For x As Integer = 0 To tdbViewer.RowCount - 1


                Dim CalculateMonths As String = tdbViewer.Columns("calculated_months").CellText(x).ToString

                If CalculateMonths < 6 And (CalculateMonths < 4 And CalculateMonths >= 1) Then

                End If

            Next




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub tdbViewer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbViewer.KeyUp
        If e.KeyCode = Keys.Enter Then
            RaiseEvent ITEM_SELECTED()
            Me.Close()
        End If
    End Sub

  

    Private Sub txtSearchKey_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchKey.KeyDown
        Dim bHandled As Boolean = False
        Select Case e.KeyCode
            Case Keys.Up
                'do stuff
                e.Handled = True
                tdbViewer.MovePrevious()
            Case Keys.Down
                'do other stuff
                e.Handled = True
                tdbViewer.MoveNext()
            
        End Select
    End Sub

    Private Sub txtSearchKey_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchKey.KeyUp
        If e.KeyCode = Keys.Enter Then
            RaiseEvent ITEM_SELECTED()
            'Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

  
    Private Sub txtSearchKey_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchKey.TextChanged
        Dim SQL As String = "SELECT ris_details.RIS_Det_No, inventory_master.a_code"
        SQL += " , inventory_master.a_name, inventory_master.method"
        SQL += " , ris_details.price 'buy_price'"
        SQL += " , inventory_master.selling_price"
        SQL += " , ris_details.qty_received"
        SQL += " , ris_details.qty_remaining"
        SQL += " , ris_details.expiry_date"
        SQL += " , ris_details.location"
        SQL += " , ris_master.RIS_No"
        SQL += " , ris_master.date_received"
        SQL += " , ris_master.po_no"
        SQL += " , ris_master.si_no"
        SQL += " , ris_master.supplier"
        SQL += " , ris_master.fund_cluster"
        SQL += " , ris_master.received_by"
        SQL += " FROM inventory_master"
        SQL += " INNER JOIN ris_details "
        SQL += " ON (inventory_master.a_code = ris_details.inv_master_SysPK)"
        SQL += " INNER JOIN ris_master "
        SQL += " ON (ris_details.RIS_Master_No = ris_master.RIS_No)"


        If RadioButton1.Checked Then
            SQL += " WHERE supplier like '%" & Me.txtSearchKey.Text & "%'"
        ElseIf RadioButton2.Checked Then
            SQL += " WHERE a_name like '%" & Me.txtSearchKey.Text & "%'"
        ElseIf RadioButton3.Checked Then
            SQL += " WHERE method like '%" & Me.txtSearchKey.Text & "%'"
        End If

        SQL += " ORDER BY expiry_date, a_name"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        arrangeGrid()
        
    End Sub

    

    Private Sub SETUPFORM_DB_MODIFIED() Handles SETUPFORM.DB_MODIFIED
        displayItems()
    End Sub

    Private Sub SETUPFORM_SETUP_CLOSED() Handles SETUPFORM.SETUP_CLOSED
        SETUPFORM = Nothing
    End Sub

    

    Private Sub GridToTextboxes()
        For Each iControl As Control In FormControls
            Try
                iControl.Text = tdbViewer.Columns(iControl.Name.Replace("txt", "")).Text
            Catch ex As Exception
            End Try
        Next
        'Me.Close()
    End Sub

    
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaInventoryMasterSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim SQL As String = "SELECT SysPK,a_code,a_name, consignee, medtype, inv_qty, item_unit, item_buyprice, item_price,item_location, item_discount, item_reordercount "
        SQL += " FROM inventory_master"
        SQL += " WHERE SysPK='" & tdbViewer.Columns.Item("SysPK").Value & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdv1.DataSource = MeData



        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaInventoryMasterSetupForm
            SETUPFORM.OPERATION = "EDIT"
        End If

        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        RaiseEvent WIN_CLOSED()
        Me.Close()
    End Sub


End Class