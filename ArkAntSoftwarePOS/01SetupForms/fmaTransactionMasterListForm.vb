Imports DevExpress.XtraGrid.Views.Grid

Public Class fmaTransactionMasterListForm

    Private WithEvents trDetails As fmaTransactionDetailsForm


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub fmaTransactionMasterListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.dtpFrom.Value = Date.Now
        Me.dtpTo.Value = Date.Now

        If rbtnPatient.Checked Then
            displayTransactionsPatient()
        Else
            displayTransactionsWARD()
        End If
        'displayTransactionsPatient()

        Application.DoEvents()
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()


    End Sub


    Private Sub displayTransactionsPatient()
        Dim SQLEX As String = "SELECT daily_sales_master.SysPK"
        SQLEX += " , tr_date , transactionno"
        SQLEX += " , a_name"
        SQLEX += " , Format(tr_amount,2)'tr_amount' , charging,or_no"
        SQLEX += " , status"
        SQLEX += " FROM daily_sales_master"
        SQLEX += " INNER JOIN person_profile"
        SQLEX += " ON (patient_id = a_code)"
        SQLEX += " WHERE DATE(tr_date) BETWEEN "
        SQLEX += String.Format("'{0}' AND '{1}'", Format(dtpFrom.Value, "yyyy-MM-dd"), Format(dtpTo.Value, "yyyy-MM-dd"))
        SQLEX += " ORDER BY tr_date DESC "


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        tdbViewer.DataSource = MeData

        GridControl1.DataSource = MeData
        DesignGridView1(GridView1)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("SysPK").Visible = False
                '.DisplayColumns("a_code").Visible = False

                .DisplayColumns("tr_date").DataColumn.Caption = "SALES DATE/TIME"
                .DisplayColumns("tr_date").DataColumn.NumberFormat = "yyyy-MM-dd hh:mm:ss tt"
                .DisplayColumns("tr_date").Width = 180
                .DisplayColumns("tr_date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("tr_date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("transactionno").DataColumn.Caption = "TR#"
                .DisplayColumns("transactionno").Width = 130
                .DisplayColumns("transactionno").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("transactionno").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("a_name").DataColumn.Caption = "PATIENT NAME"
                .DisplayColumns("a_name").Width = 300
                .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("tr_amount").DataColumn.Caption = "AMOUNT"
                .DisplayColumns("tr_amount").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("tr_amount").Width = 150
                .DisplayColumns("tr_amount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("tr_amount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("charging").DataColumn.Caption = "CHARGING"
                .DisplayColumns("charging").Width = 180
                .DisplayColumns("charging").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("charging").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("or_no").DataColumn.Caption = "OR NO."
                .DisplayColumns("or_no").Width = 150
                .DisplayColumns("or_no").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("or_no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("status").DataColumn.Caption = "STATUS"
                .DisplayColumns("status").Width = 150
                .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

            End With
        Catch ex As Exception

        End Try

        MeData = Nothing

    End Sub

    Private Sub displayTransactionsWARD()
        Dim SQLEX As String = "SELECT daily_sales_master.SysPK"
        SQLEX += " , tr_date , transactionno"
        SQLEX += " , a_name"
        SQLEX += " , tr_amount , charging,or_no"
        SQLEX += " , status"
        SQLEX += " FROM daily_sales_master"
        SQLEX += " INNER JOIN ward"
        SQLEX += " ON (patient_id = a_code)"
        SQLEX += " WHERE DATE(tr_date) BETWEEN "
        SQLEX += String.Format("'{0}' AND '{1}'", Format(dtpFrom.Value, "yyyy-MM-dd"), Format(dtpTo.Value, "yyyy-MM-dd"))
        SQLEX += " ORDER BY tr_date DESC "


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        tdbViewer.DataSource = MeData

        GridControl1.DataSource = MeData
        DesignGridView1(GridView1)


        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("SysPK").Visible = False
                '.DisplayColumns("a_code").Visible = False

                .DisplayColumns("tr_date").DataColumn.Caption = "SALES DATE/TIME"
                .DisplayColumns("tr_date").DataColumn.NumberFormat = "yyyy-MM-dd hh:mm:ss tt"
                .DisplayColumns("tr_date").Width = 200
                .DisplayColumns("tr_date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("tr_date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("transactionno").DataColumn.Caption = "TRANSACTION #"
                .DisplayColumns("transactionno").Width = 150
                .DisplayColumns("transactionno").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("transactionno").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("a_name").DataColumn.Caption = "WARD NAME"
                .DisplayColumns("a_name").Width = 200
                .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("tr_amount").DataColumn.Caption = "AMOUNT"
                .DisplayColumns("tr_amount").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("tr_amount").Width = 150
                .DisplayColumns("tr_amount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("tr_amount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("charging").DataColumn.Caption = "CHARGING"
                .DisplayColumns("charging").Width = 200
                .DisplayColumns("charging").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("charging").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("or_no").DataColumn.Caption = "OR NO."
                .DisplayColumns("or_no").Width = 200
                .DisplayColumns("or_no").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("or_no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("status").DataColumn.Caption = "STATUS"
                .DisplayColumns("status").Width = 150
                .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

            End With
        Catch ex As Exception

        End Try

        MeData = Nothing

    End Sub

    Private Sub DesignGridView1(gridView1 As GridView)

        Dim view As GridView = gridView1

        For i As Integer = 0 To view.Columns.Count - 1

            Select Case i
                Case 1
                    view.Columns(i).Caption = "SALES DATE/TIME"
                    view.Columns(i).DisplayFormat.FormatString = "yyyy-MM-dd hh:mm : ss tt"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 2
                    view.Columns(i).Caption = "TRANSACTION #"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 3
                    view.Columns(i).Caption = "WARD NAME"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case 4
                    view.Columns(i).Caption = "AMOUNT"
                    view.Columns(i).DisplayFormat.FormatString = "n2"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                Case 5
                    view.Columns(i).Caption = "CHARGING"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case 6
                    view.Columns(i).Caption = "OR NO."
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case 7
                    view.Columns(i).Caption = "STATUS"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case Else
                    view.Columns(i).Visible = False
            End Select
        Next


    End Sub

    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = tdbViewer.PointToClient(point1)
            CMenuStripOperations.Show(tdbViewer, pt)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDetails.Visible = True

        End If

    End Sub

    Private Sub GridControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = GridControl1.PointToClient(point1)
            CMenuStripOperations.Show(GridControl1, pt)
        End If

    End Sub


    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click

        'SysPK,tr_date,transactionno
        'Dim SysPK_dailysales As String = tdbViewer.Columns.Item("SysPK").Value
        'Dim system_gen_id As String = tdbViewer.Columns.Item("transactionno").Value
        'Dim dailysales_amount As Double = tdbViewer.Columns.Item("tr_amount").Value
        'Dim Transaction_Type As String = tdbViewer.Columns.Item("status").Value

        'Dim salesDate As String = Format(tdbViewer.Columns.Item("tr_date").Value, "yyyy-MM-dd")

        Dim SysPK_dailysales As String = GridView1.GetFocusedRowCellValue("SysPK").ToString
        Dim system_gen_id As String = GridView1.GetFocusedRowCellValue("transactionno").ToString
        Dim dailysales_amount As Double = GridView1.GetFocusedRowCellValue("tr_amount").ToString
        Dim Transaction_Type As String = GridView1.GetFocusedRowCellValue("status").ToString

        Dim salesDate As String = Format(GridView1.GetFocusedRowCellValue("tr_date"), "yyyy-MM-dd").ToString

        If trDetails Is Nothing Then
            trDetails = New fmaTransactionDetailsForm
        End If


        With trDetails
            .txtSysPK.Text = SysPK_dailysales
            .txtTrNum.Text = system_gen_id
            .txtAmount.Text = Format(dailysales_amount, "#,##0.00")
            .txtStatus.Text = Transaction_Type
            .lblDate.Text = salesDate
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        btnDetails.PerformClick()

        '     getRows()

    End Sub

    Private Sub getRows()
        Dim SysPK_dailysales As String = GridView1.GetFocusedRowCellValue("SysPK").ToString
        Dim system_gen_id As String = GridView1.GetFocusedRowCellValue("transactionno").ToString
        Dim dailysales_amount As Double = GridView1.GetFocusedRowCellValue("tr_amount").ToString
        Dim Transaction_Type As String = GridView1.GetFocusedRowCellValue("status").ToString

        Dim salesDate As String = Format(GridView1.GetFocusedRowCellValue("tr_date"), "yyyy-MM-dd").ToString

        If trDetails Is Nothing Then
            trDetails = New fmaTransactionDetailsForm
        End If


        With trDetails
            .txtSysPK.Text = SysPK_dailysales
            .txtTrNum.Text = system_gen_id
            .txtAmount.Text = Format(dailysales_amount, "#,##0.00")
            .txtStatus.Text = Transaction_Type
            .lblDate.Text = salesDate
            .ShowDialog()
        End With
    End Sub

    Private Sub trDetails_TRVOIDED() Handles trDetails.TRVOIDED
        trDetails = Nothing

        If rbtnPatient.Checked Then
            displayTransactionsPatient()
        Else
            displayTransactionsWARD()
        End If

        'displayTransactionsPatient()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If rbtnPatient.Checked Then
            displayTransactionsPatient()
        Else
            displayTransactionsWARD()
        End If
        'displayTransactionsPatient()
        Application.DoEvents()
        Me.txtItemCode.Focus()
        Me.txtItemCode.SelectAll()
    End Sub


    Private Sub txtItemCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            If rbtnPatient.Checked Then
                Dim SQLEX As String = "SELECT daily_sales_master.SysPK"
                SQLEX += " , tr_date , transactionno"
                SQLEX += " , a_name"
                SQLEX += " , tr_amount , charging,or_no"
                SQLEX += " , status"
                SQLEX += " FROM daily_sales_master"
                SQLEX += " INNER JOIN person_profile"
                SQLEX += " ON (patient_id = a_code)"
                SQLEX += " WHERE transactionno='" & Me.txtItemCode.Text & "'"
                SQLEX += " ORDER BY tr_date DESC "


                Dim MeData As DataTable
                MeData = clsDBConn.ExecQuery(SQLEX)
                tdbViewer.DataSource = MeData
                Try
                    With tdbViewer.Splits(0)
                        .DisplayColumns("SysPK").Visible = False
                        '.DisplayColumns("a_code").Visible = False

                        .DisplayColumns("tr_date").DataColumn.Caption = "SALES DATE/TIME"
                        .DisplayColumns("tr_date").DataColumn.NumberFormat = "yyyy-MM-dd hh:mm:ss tt"
                        .DisplayColumns("tr_date").Width = 150
                        .DisplayColumns("tr_date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("tr_date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("transactionno").DataColumn.Caption = "TR#"
                        .DisplayColumns("transactionno").Width = 100
                        .DisplayColumns("transactionno").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("transactionno").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                        .DisplayColumns("a_name").DataColumn.Caption = "PATIENT NAME"
                        .DisplayColumns("a_name").Width = 200
                        .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("tr_amount").DataColumn.Caption = "AMOUNT"
                        .DisplayColumns("tr_amount").DataColumn.NumberFormat = "#,##0.00"
                        .DisplayColumns("tr_amount").Width = 100
                        .DisplayColumns("tr_amount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("tr_amount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                        .DisplayColumns("charging").DataColumn.Caption = "CHARGING"
                        .DisplayColumns("charging").Width = 150
                        .DisplayColumns("charging").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("charging").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("or_no").DataColumn.Caption = "OR NO."
                        .DisplayColumns("or_no").Width = 150
                        .DisplayColumns("or_no").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("or_no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("status").DataColumn.Caption = "STATUS"
                        .DisplayColumns("status").Width = 150
                        .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    End With
                Catch ex As Exception

                End Try

                MeData = Nothing
            Else
                Dim SQLEX As String = "SELECT daily_sales_master.SysPK"
                SQLEX += " , tr_date , transactionno"
                SQLEX += " , a_name"
                SQLEX += " , tr_amount , charging,or_no"
                SQLEX += " , status"
                SQLEX += " FROM daily_sales_master"
                SQLEX += " INNER JOIN ward"
                SQLEX += " ON (patient_id = a_code)"
                SQLEX += " WHERE DATE(tr_date) BETWEEN "
                SQLEX += String.Format("'{0}' AND '{1}'", Format(dtpFrom.Value, "yyyy-MM-dd"), Format(dtpTo.Value, "yyyy-MM-dd"))
                SQLEX += " ORDER BY tr_date DESC "


                Dim MeData As DataTable
                MeData = clsDBConn.ExecQuery(SQLEX)
                tdbViewer.DataSource = MeData
                Try
                    With tdbViewer.Splits(0)
                        .DisplayColumns("SysPK").Visible = False
                        '.DisplayColumns("a_code").Visible = False

                        .DisplayColumns("tr_date").DataColumn.Caption = "SALES DATE/TIME"
                        .DisplayColumns("tr_date").DataColumn.NumberFormat = "yyyy-MM-dd hh:mm:ss tt"
                        .DisplayColumns("tr_date").Width = 150
                        .DisplayColumns("tr_date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("tr_date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("transactionno").DataColumn.Caption = "TR#"
                        .DisplayColumns("transactionno").Width = 100
                        .DisplayColumns("transactionno").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("transactionno").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                        .DisplayColumns("a_name").DataColumn.Caption = "WARD NAME"
                        .DisplayColumns("a_name").Width = 200
                        .DisplayColumns("a_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("a_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("tr_amount").DataColumn.Caption = "AMOUNT"
                        .DisplayColumns("tr_amount").DataColumn.NumberFormat = "#,##0.00"
                        .DisplayColumns("tr_amount").Width = 100
                        .DisplayColumns("tr_amount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("tr_amount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                        .DisplayColumns("charging").DataColumn.Caption = "CHARGING"
                        .DisplayColumns("charging").Width = 150
                        .DisplayColumns("charging").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("charging").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("or_no").DataColumn.Caption = "OR NO."
                        .DisplayColumns("or_no").Width = 150
                        .DisplayColumns("or_no").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("or_no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                        .DisplayColumns("status").DataColumn.Caption = "STATUS"
                        .DisplayColumns("status").Width = 150
                        .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                        .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    End With
                Catch ex As Exception

                End Try

                MeData = Nothing
            End If


            


        End If

        'Me.txtItemCode.Focus()
        'Me.txtItemCode.SelectAll()

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick

        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDetails.Visible = True

        End If


    End Sub
End Class