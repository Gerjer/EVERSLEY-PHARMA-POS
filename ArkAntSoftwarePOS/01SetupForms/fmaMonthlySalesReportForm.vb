Public Class fmaMonthlySalesReportForm

    Dim firstDayLastMonth As DateTime
    Dim lastDayLastMonth As DateTime

    Private Sub fmaDailySalesReportForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpDate.Value = Date.Now

        displaySales()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        displaySales()
    End Sub

    Private Sub displaySales()

        Dim thisMonth As New DateTime(dtpDate.Value.Year, dtpDate.Value.Month, 1)
        'firstDayLastMonth = thisMonth.AddMonths(-1)
        lastDayLastMonth = thisMonth.AddMonths(1).AddDays(-1)

        Dim SQLEX As String = "SELECT description, day_stat, sales FROM transaction_day"
        SQLEX += " WHERE TransactionDay between '" & Format(thisMonth, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(lastDayLastMonth, "yyyy-MM-dd") & "'"
        SQLEX += " GROUP BY TransactionDay"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)

                .DisplayColumns("description").DataColumn.Caption = "DATE"
                .DisplayColumns("description").Width = 200
                .DisplayColumns("description").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("description").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("day_stat").DataColumn.Caption = "SALES STATUS"
                .DisplayColumns("day_stat").Width = 250
                .DisplayColumns("day_stat").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("day_stat").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                .DisplayColumns("sales").DataColumn.Caption = "TOTAL SALES"
                .DisplayColumns("sales").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("sales").Width = 250
                .DisplayColumns("sales").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("sales").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

               

            End With
        Catch ex As Exception

        End Try

        getTotalSales()

    End Sub

   
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub getTotalSales()
        Dim thisMonth As New DateTime(dtpDate.Value.Year, dtpDate.Value.Month, 1)
        lastDayLastMonth = thisMonth.AddMonths(1).AddDays(-1)

        Dim SQLEX As String = "SELECT SUM(sales) AS 'totalSales' FROM transaction_day"
        SQLEX += " WHERE TransactionDay between '" & Format(thisMonth, "yyyy-MM-dd") & "'"
        SQLEX += " AND '" & Format(lastDayLastMonth, "yyyy-MM-dd") & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim Sales As Double = 0

        If MeData.Rows.Count > 0 Then
            Try
                Sales = CDbl(MeData.Rows(0).Item("totalSales").ToString)
            Catch ex As Exception

            End Try
        End If

        lblTotal.Text = "TOTAL : " & Format(Sales, "#,##0.00")

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        createCalendar()

        Dim SQLEX As String = "SELECT day, calendar_day, dateRecord FROM temp_calendar order by day"

        Dim MonthName As String = Format(dtpDate.Value, "MMMM yyyy")

        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "Monthly Sales Report") = New rptMonthlySalesReport(MonthName)
            new_report.Show()
        Catch ex As Exception

        End Try


    End Sub


    Private Sub createCalendar()
        Dim thisMonth As New DateTime(dtpDate.Value.Year, dtpDate.Value.Month, 1)
        lastDayLastMonth = thisMonth.AddMonths(1).AddDays(-1)

        Dim SQLTRUNC As String = "Truncate Table temp_calendar"
        clsDBConn.ExecuteSilence(SQLTRUNC)


        For dayOfMonth As Integer = 1 To lastDayLastMonth.Day

            Dim dayofWeek As New DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dayOfMonth)

            Dim dayName As String = Format(dayofWeek, "dddd")

            Dim SQLIN As String = "INSERT INTO temp_calendar(calendar_day,day, dateRecord)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}', '{2}')", dayName, dayOfMonth, Format(dayofWeek, "yyyy-MM-dd"))


            clsDBConn.Execute(SQLIN)




        Next


    End Sub
End Class