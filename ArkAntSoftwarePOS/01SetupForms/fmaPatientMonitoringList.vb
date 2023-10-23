Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid


Public Class fmaPatientMonitoringList


    Public Event ITEM_SELECTED()
    Public Event WIN_CLOSED()

    Private WithEvents SETUPFORM As fmaInventoryMasterSetupForm

    Dim patient_transaction_details As New List(Of patient_transaction_trace)

    Private Sub fmaPatientMonitoringList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtSearchKey.TextAlign = HorizontalAlignment.Center
        Me.ActiveControl = Me.txtSearchKey



        GridView1.OptionsSelection.EnableAppearanceFocusedCell = True
        GridView1.OptionsSelection.EnableAppearanceFocusedRow = True
        GridView1.OptionsSelection.EnableAppearanceHideSelection = False

        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        For Each column As GridColumn In GridView1.Columns
            column.OptionsColumn.AllowFocus = False
        Next


        loadList()

    End Sub

    Private Sub loadList()

        Dim SQL As String = "SELECT	daily_sales_master.tr_date 'TRANSACTION DATE'"
        '   SQL += " ,TIME(daily_sales_master.start_time)'TIME-IN'"
        SQL += " ,CAST(TIME( daily_sales_master.start_time)AS char)'TIME-IN'"
        ' SQL += " ,time(daily_sales_master.end_time) 'TIME-OUT'"
        SQL += " ,CAST(TIME( daily_sales_master.end_time)AS char) 'TIME-OUT'"
        SQL += " ,person_profile.a_name 'PATIENT NAME'"
        SQL += " ,person_profile.age 'AGE'"
        SQL += " ,person_profile.sex 'GENDER'"
        SQL += " ,date_format(person_profile.dob,'%m-%d-%Y') 'DATE OF BIRTH'"
        SQL += " ,person_profile.contact_no 'CONTACT NO.#'"
        SQL += " ,daily_sales_master.charging 'CHARGE TO'"
        SQL += " ,daily_sales_master.SysPK"
        SQL += " ,unfilled,cashier,recieved_by"
        SQL += " ,qfs_discount"
        SQL += " ,transactionno,address"
        SQL += " FROM 	daily_sales_master"
        SQL += " INNER JOIN person_profile ON daily_sales_master.patient_id = person_profile.a_code"
        SQL += " WHERE YEAr(tr_date) = '" & Format(dtpFrom.Value, "yyyy") & "'"
        SQL += " ORDER BY daily_sales_master.tr_date"

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = DataSource(String.Format(SQL))
        DesignGridView(GridView1)

    End Sub

    Private Sub DesignGridView(gridView1 As GridView)

        Dim View As GridView = gridView1

        For i As Integer = 0 To View.Columns.Count - 1

            Select Case i
                Case 0, 1, 2
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.BestFitColumns()
                Case 3, 8
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    View.BestFitColumns()
                Case 4, 5, 6, 7
                    View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    View.BestFitColumns()
                Case Else
                    View.Columns(i).Visible = False
            End Select

        Next



    End Sub

    Private Sub fmaPatientMonitoringList_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        RaiseEvent WIN_CLOSED()
    End Sub



    Private Sub txtSearchKey_TextChanged(sender As Object, e As EventArgs) Handles txtSearchKey.TextChanged
        Me.txtSearchKey.TextAlign = HorizontalAlignment.Left
        GridView1.FindFilterText = txtSearchKey.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Dim daily_sales_master_id As String
    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick

        PreviewPrint(sender)

    End Sub

    Private Sub PreviewPrint(sender As Object)

        Cursor = Cursors.WaitCursor

        Dim view As GridView = DirectCast(sender, GridView)
        daily_sales_master_id = view.GetFocusedRowCellValue("SysPK")

        Dim transaction_date As String = Format(view.GetFocusedRowCellValue("TRANSACTION DATE").date, "MMM dd, yyyy").ToString
        Dim transactionNo As String = view.GetFocusedRowCellValue("transactionno").ToString
        Dim time_in As String = view.GetFocusedRowCellValue("TIME-IN").ToString
        Dim time_out As String = view.GetFocusedRowCellValue("TIME-OUT").ToString
        Dim patient_name As String = view.GetFocusedRowCellValue("PATIENT NAME").ToString
        Dim age As String = If(IsDBNull(view.GetFocusedRowCellValue("AGE").ToString), 0, view.GetFocusedRowCellValue("AGE").ToString)
        Dim gender As String = If(IsDBNull(view.GetFocusedRowCellValue("GENDER").ToString), "", view.GetFocusedRowCellValue("GENDER").ToString)

        Dim dob As String = ""
        Try
            Dim birthdate As Date = If(IsDBNull(view.GetFocusedRowCellValue("DATE OF BIRTH").ToString), "", view.GetFocusedRowCellValue("DATE OF BIRTH").ToString)
            dob = Format(birthdate.Date, "MM-dd-yyyy").ToString
        Catch ex As Exception
            dob = ""
        End Try

        Dim contact_no As String = If(IsDBNull(view.GetFocusedRowCellValue("CONTACT NO.#").ToString), "", view.GetFocusedRowCellValue("CONTACT NO.#").ToString)
        Dim address As String = If(IsDBNull(view.GetFocusedRowCellValue("address").ToString), "", view.GetFocusedRowCellValue("address").ToString)

        Dim chargedto As String = view.GetFocusedRowCellValue("CHARGE TO").ToString
        Dim unfilledQTy As Integer = If(IsDBNull(view.GetFocusedRowCellValue("unfilled").ToString), 0, view.GetFocusedRowCellValue("unfilled").ToString)
        Dim discounted As Double = If(IsDBNull(view.GetFocusedRowCellValue("qfs_discount").ToString), 0, view.GetFocusedRowCellValue("qfs_discount").ToString)
        Dim servedby As String = view.GetFocusedRowCellValue("cashier").ToString
        Dim receivedby As String = If(IsDBNull(view.GetFocusedRowCellValue("recieved_by").ToString), "", view.GetFocusedRowCellValue("recieved_by").ToString)


        Dim report As New xtrPatientTransactionMonitoring

        report.txtTranDate.Text = transaction_date
        report.txtTransNo.Text = transactionNo
        report.txtTimeIN.Text = time_in
        report.txtTimeOut.Text = time_out
        report.txtPatient.Text = patient_name
        report.txtAge.Text = age
        report.txtGender.Text = gender
        report.txtDOB.Text = dob
        report.txtContatNo.Text = contact_no
        report.txtAddress.Text = address
        report.txtCharging.Text = chargedto
        report.txtUnfilled.Text = IIf(unfilledQTy = 0, "", unfilledQTy)
        report.txtDiscounted.Text = IIf(discounted = 0, "", discounted)

        Dim dt As New DataTable
        dt = getPatientTransactionDetails(daily_sales_master_id)

        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
                Dim obj As New patient_transaction_trace
                With obj
                    .sales_master_id = daily_sales_master_id
                    .item_code = row("a_code").ToString
                    .item_name = row("a_name").ToString
                    .uom = row("uom").ToString
                    .qty = row("item_qty").ToString
                    .paid_price = row("item_price").ToString
                    .total_amt = row("item_total").ToString
                    .dosage_form = If(IsDBNull(row("method").ToString), "", row("method").ToString)
                    .brand_name = If(IsDBNull(row("brand_name").ToString), "", row("brand_name").ToString)
                    .manufacturer = If(IsDBNull(row("manufacturer").ToString), "", row("manufacturer").ToString)
                    .expiry_date = row("expiry_date").ToString
                    .procurement_mode = If(IsDBNull(row("procurement_mode").ToString), "", row("procurement_mode").ToString)
                    .clusster = If(IsDBNull(row("fund_cluster").ToString), "", row("fund_cluster").ToString)
                    .classification = If(IsDBNull(row("fund_class").ToString), "", row("fund_class").ToString)
                End With
                patient_transaction_details.Add(obj)
            Next

        End If

        Dim Subreport As XRSubreport = TryCast(report.Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
        Subreport.ReportSource.DataSource = patient_transaction_details

        report.txtServedby.Text = servedby
        report.txtReceivedby.Text = receivedby
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()

        DocumentViewer1.DocumentSource = report

        '      report.ShowPreview

        patient_transaction_details.Clear()

        view.Focus()

        Cursor = Cursors.Default


    End Sub

    Private Function getPatientTransactionDetails(daily_sales_master_id As String) As DataTable
        Dim sql As String = "SELECT
	inventory_master.a_code, 
	inventory_master.a_name, 
	inventory_master.uom, 
	daily_sales_detail.item_qty, 
	daily_sales_detail.item_price, 
	daily_sales_detail.item_total, 
	inventory_master.method, 
	inventory_master.brand_name, 
	inventory_master.manufacturer, 
	ris_details.expiry_date, 
	ris_master.procurement_mode, 
	ris_master.fund_cluster, 
	ris_master.fund_class
FROM
	daily_sales_detail
	INNER JOIN 	inventory_master ON daily_sales_detail.item_invcode = inventory_master.a_code
	INNER JOIN	ris_details	ON daily_sales_detail.RIS_Det_No = ris_details.RIS_Det_No
	INNER JOIN	ris_master	ON ris_details.RIS_Master_No = ris_master.RIS_No
WHERE
	daily_sales_detail.sales_sys = '" & daily_sales_master_id & "' "
        Return DataSource(sql)
    End Function

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = True
        GridView1.OptionsSelection.EnableAppearanceFocusedRow = True
        GridView1.OptionsSelection.EnableAppearanceHideSelection = False
    End Sub

    Private Sub txtSearchKey_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchKey.KeyUp
        Dim bHandled As Boolean = False
        Select Case e.KeyCode
            Case Keys.Up
                'do stuff
                e.Handled = True
                GridView1.Focus()
            Case Keys.Down
                'do other stuff
                e.Handled = True
                GridView1.Focus()
        End Select
    End Sub


    Private Sub GridControl1_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles GridControl1.ProcessGridKey
        Dim view As GridView = TryCast(TryCast(sender, GridControl).FocusedView, GridView)
        If view Is Nothing Then
            Return
        End If
        If e.KeyCode = Keys.Enter AndAlso view.SelectedRowsCount > 0 Then
            PreviewPrint(view)
        End If
    End Sub

End Class