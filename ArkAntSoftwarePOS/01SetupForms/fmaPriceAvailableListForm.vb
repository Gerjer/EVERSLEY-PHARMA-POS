Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class fmaPriceAvailableListForm
    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "units"

    Private WithEvents SETUPFORM As fmaUnitsTypeSetupForm


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'If SETUPFORM Is Nothing Then
        '    SETUPFORM = New fmaUnitsTypeSetupForm
        '    SETUPFORM.OPERATION = "ADD"
        'End If

        'SETUPFORM.ShowDialog()
        LoadList()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

        End If
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaUnitsTypeSetupForm
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()

    End Sub

    Dim FirstLoad As Boolean
    Private Sub fmaPriceAvailableListForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FirstLoad = True
        cmbMode.SelectedIndex = 3


        Label1.Visible = False
        dtpTo.Visible = False

        LoadComboBox()

        lblDate.Text = "DATE"
        Label1.Visible = False
        dtpTo.Visible = False

        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMMM dd, yyyy"
        dtpFrom.ShowUpDown = False

        LoadList()
        allowedit(BandedGridView1, cbxAllowEdit.CheckState)
        FirstLoad = False
    End Sub

    Private Sub LoadList()


        GridControl1.DataSource = Nothing

        'cmbSupplier.SelectedValue = supplier_id
        'cmbProcurement.Text = mode_procurement

        Dim SQL As String = " SELECT ris_master.date_received 'date_created',class_based.`name` 'class_based'"
        SQL += " ,	inventory_master.a_name 'item' "
        SQL += " ,	CASE WHEN ris_master.fund_class = 'DOH DONATION' THEN ris_details.price ELSE 0 END AS 'cost_doh'"
        SQL += " ,	CASE WHEN ris_master.fund_class = 'DOH DONATION' THEN inventory_master.selling_price ELSE 0 END AS 'selling_doh'"
        SQL += " ,	CASE WHEN ris_master.fund_class = 'IN-HOUSE' THEN ris_details.price ELSE 0 END AS 'cost_in'"
        SQL += " ,  CASE WHEN ris_master.fund_class = 'IN-HOUSE' THEN Inventory_master.selling_price ELSE 0 END AS 'selling_in'"

        SQL += "  FROM 	ris_master"
        SQL += "  INNER JOIN ris_details ON ris_master.RIS_No = ris_details.RIS_Master_No"
        SQL += "  INNER JOIN inventory_master ON ris_details.inv_master_SysPK = inventory_master.a_code"
        SQL += "  INNER JOIN medtype ON inventory_master.method_id = medtype.SysPK_Item"
        SQL += "  INNER JOIN class_based ON medtype.class_based_id = class_based.id "

        If cmbMode.SelectedIndex = 0 Then
            SQL += " WHERE DATE_FORMAT(ris_master.date_received,'%Y') = '" & Format(dtpFrom.Value, "yyyy") & "' "
            date_name = "Update as of year " & Format(dtpFrom.Value, "yyyy") & " (Based on administrative Order No. 2020-0043 'Guidelines On Ensuring the Affordability Of Essential Medicines In  DOH Facilities through the Requlation Of Price Mark-ups'.)"
        ElseIf cmbMode.SelectedIndex = 1 Then
            SQL += " WHERE DATE_FORMAT(ris_master.date_received,'%M') = '" & Format(dtpFrom.Value, "MMMM") & "' "
            date_name = "Update as of Month " & Format(dtpFrom.Value, "MMMM") & " (Based on administrative Order No. 2020-0043 'Guidelines On Ensuring the Affordability Of Essential Medicines In  DOH Facilities through the Requlation Of Price Mark-ups'.) "
        ElseIf cmbMode.SelectedIndex = 2 Then
            SQL += " WHERE ris_master.date_received BETWEEN '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "' "
            date_name = "Update as of Month " & Format(dtpFrom.Value, "MMMM") & " (Based on administrative Order No. 2020-0043 'Guidelines On Ensuring the Affordability Of Essential Medicines In  DOH Facilities through the Requlation Of Price Mark-ups'.) "
        Else
            SQL += " WHERE Date_format(ris_master.date_received,'%Y-%m-%d') = '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' "
            date_name = " Update as of " & Format(dtpFrom.Value, "MMMM dd, yyyy") & " (Based on administrative Order No. 2020-0043 'Guidelines On Ensuring the Affordability Of Essential Medicines In  DOH Facilities through the Requlation Of Price Mark-ups'.)"
        End If

        SQL += " ORDER BY class_based.`name`  ASC,inventory_master.a_name ASC "

        Dim dt As New DataTable
        dt = DataSource(SQL)

        GridControl1.DataSource = dt
        '    DesigGRidView(GridView1)

    End Sub

    Private Sub DesigGRidView(View As GridView)

        View.BeginUpdate()

        For i As Integer = 0 To View.Columns.Count - 1

            Select Case i
                Case 1
                    View.Columns(i).Caption = "GENERIC NAME OF MEDICINE"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 350
                Case 2
                    View.Columns(i).Caption = "DOSAGE FORM"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 100
                Case 3
                    View.Columns(i).Caption = "BRAND NAME"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 100
                Case 4
                    View.Columns(i).Caption = "COST PER UNIT"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).DisplayFormat.FormatString = "###,###.00"
                    View.Columns(i).Width = 100
                Case 5
                    View.Columns(i).Caption = "QUANTITY"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 80
                Case 6
                    View.Columns(i).Caption = "TOTAL COST"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    View.Columns(i).Width = 80
                Case 7
                    View.Columns(i).Caption = "SUPPLIER"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 200
                Case 8
                    View.Columns(i).Caption = "MANUFACTURER"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.Columns(i).Width = 180
                Case 9
                    View.Columns(i).Caption = "MODE OF PROCUREMENT"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 150
                Case 10
                    View.Columns(i).Caption = "DELIVERY STATUS"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 100
                Case 11
                    View.Columns(i).Caption = "BID ATTEMP"
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).Width = 80
                Case Else
                    View.Columns(i).Visible = False
            End Select

        Next

        View.EndUpdate()

    End Sub

    Private Sub LoadComboBox()

        'cmbSupplier.DataSource = getSupplier()
        'cmbSupplier.ValueMember = "id"
        'cmbSupplier.DisplayMember = "name"
        'cmbSupplier.SelectedIndex = -1


        'cmbProcurement.DataSource = getProcurementMode()
        'cmbProcurement.ValueMember = "id"
        'cmbProcurement.DisplayMember = "name"
        'cmbProcurement.SelectedIndex = -1



    End Sub

    Private Function getProcurementMode() As Object
        Dim sql As String = ""
        sql = "SELECT
                id,
               `name`
              FROM(
			SELECT DISTINCT  1 AS 'id',	procurement_mode 'name' FROM	ris_master 	WHERE procurement_mode is NOT NULL AND received_by <> ''

			UNION

			SELECT 0 AS 'id','-- ALL --' AS 'name'
			)A ORDER BY id"
        Return DataSource(sql)
    End Function

    Private Function getSupplier() As Object
        Dim sql As String = ""
        sql = "SELECT
                `id`,
                `name`
                FROM(
		                SELECT DISTINCT   supplier_SysPK as 'id',	supplier 'name' 
		                FROM	ris_master
		                INNER JOIN supplier on ris_master.supplier_SysPK = supplier.SysPK AND supplier.supplier_type = 0

		                UNION

		                SELECT 0 AS 'id','-- ALL --' AS 'name'
                    )A
                ORDER BY `name`"
        Return DataSource(sql)
    End Function

    Dim Mode As String = ""
    Private Sub cmbMode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMode.SelectionChangeCommitted
        'Try
        '    Mode = cmbMode.Text
        '    If Mode = "YEAR" Then
        '        lblDate.Text = "YELAR"
        '        Label1.Visible = False
        '        dtpTo.Visible = False

        '        dtpFrom.Format = DateTimePickerFormat.Custom
        '        dtpFrom.CustomFormat = "yyyy"
        '        dtpFrom.ShowUpDown = True


        '    ElseIf Mode = "MONTHLY" Then
        '        lblDate.Text = "MONTHLY"
        '        Label1.Visible = False
        '        dtpTo.Visible = False

        '        dtpFrom.Format = DateTimePickerFormat.Custom
        '        dtpFrom.CustomFormat = "MMMM"
        '        dtpFrom.ShowUpDown = False

        '    Else

        '        lblDate.Text = "DATE FROM"
        '        Label1.Visible = True
        '        dtpTo.Visible = True

        '        dtpFrom.Format = DateTimePickerFormat.Custom
        '        dtpFrom.CustomFormat = "MMM dd, yyyy"
        '        dtpFrom.ShowUpDown = False

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        '    LoadList()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        '    LoadList()
    End Sub

    Dim supplier_id As String = ""
    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbSupplier.SelectedItem, DataRowView)
            supplier_id = drv.Item("id").ToString
            LoadList()
        Catch ex As Exception

        End Try
    End Sub
    Dim mode_procurement As String = ""
    Private Sub cmbProcurement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProcurement.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbProcurement.SelectedItem, DataRowView)
            mode_procurement = drv.Item("name").ToString
            LoadList()
        Catch ex As Exception

        End Try
    End Sub

    Dim date_name As String = ""
    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged

        If FirstLoad = False Then
            Try
                Mode = cmbMode.Text
                If Mode = "YEARLY" Then
                    lblDate.Text = "YEAR"
                    Label1.Visible = False
                    dtpTo.Visible = False

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "yyyy"
                    dtpFrom.ShowUpDown = True


                ElseIf Mode = "MONTHLY" Then
                    lblDate.Text = "MONTHLY"
                    Label1.Visible = False
                    dtpTo.Visible = False

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "MMMM, yyyy"
                    dtpFrom.ShowUpDown = True

                ElseIf Mode = "DATE RANGE" Then

                    lblDate.Text = "DATE FROM"
                    Label1.Visible = True
                    dtpTo.Visible = True

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "MMMM dd, yyyy"
                    dtpFrom.ShowUpDown = False
                Else

                    lblDate.Text = "DATE"
                    Label1.Visible = False
                    dtpTo.Visible = False

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "MMMM dd, yyyy"
                    dtpFrom.ShowUpDown = False

                End If
            Catch ex As Exception

            End Try
        End If


    End Sub

    Dim price_available As New List(Of price_available)

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Cursor = Cursors.WaitCursor

        For i As Integer = 0 To BandedGridView1.DataRowCount - 1

            Dim obj As New price_available
            With obj
                .date_created = Format(CDate(BandedGridView1.GetRowCellValue(i, "date_created")).Date, "yyyy-MM-dd").ToString
                .class_base = If(IsDBNull(BandedGridView1.GetRowCellValue(i, "class_based")), "", BandedGridView1.GetRowCellValue(i, "class_based")) ''GridView1.GetRowCellValue(i, "dosage_form")
                .item = If(IsDBNull(BandedGridView1.GetRowCellValue(i, "item")), "", BandedGridView1.GetRowCellValue(i, "item")) ' GridView1.GetRowCellValue(i, "brand_name")
                .cost_doh = BandedGridView1.GetRowCellValue(i, "cost_doh")
                .selling_doh = BandedGridView1.GetRowCellValue(i, "selling_doh")
                .cost_in = BandedGridView1.GetRowCellValue(i, "cost_in")
                .selling_in = BandedGridView1.GetRowCellValue(i, "selling_in")
            End With
            price_available.Add(obj)
        Next



        Dim report As New xtrPriceOfAvailable
        report.header.Text = date_name
        report.Report.DataSource = price_available
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview


        price_available.Clear()

        Cursor = Cursors.Default
    End Sub

    Private Sub dtpFrom_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpFrom.KeyUp
        '      LoadList()
    End Sub

    Private Sub dtpTo_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpTo.KeyUp
        '     LoadList()
    End Sub

    Private Sub cxbxAll_CheckedChanged(sender As Object, e As EventArgs) Handles cxbxAll.CheckedChanged
        If cxbxAll.Checked = True Then

            cmbMode.SelectedIndex = 2

            Dim DateFromDB As Date = Date.Now

            lblDate.Text = "DATE FROM"
            Label1.Visible = True
            dtpTo.Visible = True

            dtpFrom.Format = DateTimePickerFormat.Custom
            dtpFrom.CustomFormat = "MMMM dd, yyyy"
            dtpFrom.ShowUpDown = False


            Dim SQLEX As String = "SELECT TransactionDay FROM transaction_day ORDER BY TransactionDay LIMIT 1"

            Dim MeData As DataTable
            MeData = clsDBConn.ExecQuery(SQLEX)


            If MeData.Rows.Count > 0 Then
                Try
                    DateFromDB = CDate(MeData.Rows(0).Item("TransactionDay"))


                Catch ex As Exception

                End Try
            End If

            dtpFrom.Value = DateFromDB
            dtpTo.Value = Date.Now

            cmbMode.Enabled = False
            dtpFrom.Enabled = False
            dtpTo.Enabled = False
        Else
            cmbMode.Enabled = True
            dtpFrom.Enabled = True
            dtpTo.Enabled = True
        End If
    End Sub

    Private Sub cbxAllowEdit_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAllowEdit.CheckedChanged

        allowedit(BandedGridView1, cbxAllowEdit.CheckState)


    End Sub

    Private Sub allowedit(bandedGridView1 As BandedGridView, CheckState As Integer)

        For i As Integer = 0 To bandedGridView1.Columns.Count - 1
            Select Case i
                Case 2, 3, 4, 5
                    If CheckState = 1 Then
                        bandedGridView1.Columns(i).OptionsColumn.AllowEdit = True
                    Else
                        bandedGridView1.Columns(i).OptionsColumn.AllowEdit = False
                    End If

            End Select
        Next


    End Sub

    Private Sub GridControl1_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.EditorKeyDown
        Dim view As GridView = DirectCast(TryCast(sender, DevExpress.XtraGrid.GridControl).FocusedView, GridView)

        If e.KeyCode = Keys.Enter Then

            If Not view.IsLastVisibleRow Then
                view.MoveNext()
            Else
                view.MoveFirst()
            End If
        End If

    End Sub

End Class