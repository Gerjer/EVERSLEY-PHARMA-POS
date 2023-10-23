Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Threading


Public Class fmaDateRange_DailyViewer



    Private m_AsyncWorker As BackgroundWorker = New BackgroundWorker()

    Private Sub fmaReport_DailyForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpFrom.Value = Date.Now
        dtpTo.Value = Date.Now


        m_AsyncWorker.WorkerReportsProgress = True
        m_AsyncWorker.WorkerSupportsCancellation = True
        AddHandler m_AsyncWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf bwAsync_RunWorkerCompleted)
        AddHandler m_AsyncWorker.DoWork, New DoWorkEventHandler(AddressOf bwAsync_DoWork)


    End Sub

    Private Sub bwAsync_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim bwAsync As BackgroundWorker = TryCast(sender, BackgroundWorker)
        'printDailySalesReport()
        Dim n As Integer = 0

        While n < 1

            printDailySalesReport()

            If bwAsync.CancellationPending Then

                Thread.Sleep(100)

                e.Cancel = True
                Return
            End If
        End While

        'If bwAsync.CancellationPending Then

        '    Thread.Sleep(100)

        '    e.Cancel = True
        '    Return
        'End If
        'bwAsync.ReportProgress(100)
    End Sub

    Private Sub bwAsync_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        btnThread.Text = "Start"
        btnThread.Enabled = True


        If e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
            Return
        End If

        ' Check to see if the background process was cancelled.
        If e.Cancelled Then
            lblStatus.Text = "Cancelled..."
        Else
            ' Everything completed normally.
            ' process the response using e.Result

            lblStatus.Text = "Completed..."
        End If
    End Sub



    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If cxbxDailySales.Checked Then
            printDailySalesReport()
        End If

        If cxbxDailySalesItem.Checked Then
            printDailySalesReportItem()
        End If

        If cxbxDailyTransaction.Checked Then
            printDailyTransactions()
        End If

    End Sub



    Private Sub printDailySalesReport()
        If Not cxbxDirectPrinting.Checked Then

            Dim SQLEX As String = "SELECT dailysales_cashier, SUM(dailysales_net) AS 'netSales' "
            SQLEX += " FROM daily_sales_master"
            SQLEX += String.Format(" WHERE DATE(dailysales_date) between '{0}' and '{1}'", Format(dtpFrom.Value, "yyyy-MM-dd"), _
            Format(dtpTo.Value, "yyyy-MM-dd"))
            SQLEX += " GROUP BY dailysales_cashier"

            Dim RPTdate As String = "FROM " & Format(dtpFrom.Value, "yyyy-MM-dd") & " TO " & Format(dtpTo.Value, "yyyy-MM-dd")
            Dim new_report As New fzzReportViewerForm
            Try
                new_report.AttachReport(SQLEX, "Inventory Report") = New rpt_DailySalesReport(RPTdate)
                new_report.Show()
            Catch ex As Exception

            End Try
        Else

        End If




    End Sub


    Private Sub printDailyInventory()

        If Not cxbxDirectPrinting.Checked Then
            Dim SQLEX As String = "SELECT A.a_code, B.Item_Description, A.item_unit, A.item_price, A.inv_qty"
            SQLEX += " FROM  inventory_master AS A"
            SQLEX += " inner JOIN product_item B "
            SQLEX += " ON (A.a_code = B.Item_Code)"
            SQLEX += " GROUP BY a_code"


            Dim datefrom As String = Format(dtpFrom.Value, "yyyy-MM-dd")
            Dim dateto As String = Format(dtpFrom.Value, "yyyy-MM-dd")

            'Dim new_report As New fzzReportViewerForm
            Dim new_report As New fzzReportViewerForm
            Try
                new_report.AttachReport(SQLEX, "Inventory Report") = New rpt_ActualInventoryReport(datefrom, dateto)
                new_report.Show()

            Catch ex As Exception

            End Try
        Else

        End If


    End Sub


    Private Sub btnThread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThread.Click
        If m_AsyncWorker.IsBusy Then
            btnThread.Enabled = False
            lblStatus.Text = "Canceling..."

            m_AsyncWorker.CancelAsync()
            PictureBox1.Visible = False
            'progressDialog.Close()
        Else
            btnThread.Text = "Cancel"
            lblStatus.Text = "Running..."

            m_AsyncWorker.RunWorkerAsync()
            PictureBox1.Visible = True
            'progressDialog.Show()
        End If

    End Sub

    Private Sub printDailyTransactions()

        Dim SQLEX As String = "SELECT SysPK_dailysales,dailysales_date,system_gen_id, "
        SQLEX += " dailysales_amount,Discount,dailysales_net,"
        SQLEX += " Owner_Name,dailysales_cash, dailysales_change, Transaction_Type  FROM daily_sales_master"
        SQLEX += " WHERE DATE(dailysales_date) BETWEEN "
        SQLEX += String.Format("'{0}' AND '{1}'", Format(dtpFrom.Value, "yyyy-MM-dd"), Format(dtpTo.Value, "yyyy-MM-dd"))
        SQLEX += " ORDER BY dailysales_date DESC "

        Dim new_report As New fzzReportViewerForm
        Dim datefrom As String = Format(dtpFrom.Value, "yyyy-MM-dd")
        Dim dateto As String = Format(dtpTo.Value, "yyyy-MM-dd")


        Try
            new_report.AttachReport(SQLEX, "Transaction Report") = New rpt_DailyTransactionReport(datefrom, dateto)
            new_report.Show()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub printDailySalesReportItem()
        Dim SQLEX As String = "SELECT `daily_sales_master`.`dailysales_date`"
        SQLEX += " , `daily_sales_detail`.`item_invcode`"
        SQLEX += " , `daily_sales_detail`.`item_descr`"
        SQLEX += " , `inventory_master`.`item_buyprice`"
        SQLEX += " , `daily_sales_detail`.`item_price`"
        SQLEX += " , SUM(`daily_sales_detail`.`item_qty`) AS 'SOLD'"
        SQLEX += " , `daily_sales_detail`.`item_disc` AS 'DISC'"
        SQLEX += " , SUM(`daily_sales_detail`.`item_total`) AS 'GROSS'"
        SQLEX += " , (SUM(`daily_sales_detail`.`item_total`) - (`inventory_master`.`item_buyprice` * SUM(`daily_sales_detail`.`item_qty`))) AS 'NET'"
        SQLEX += " FROM `daily_sales_detail`"
        SQLEX += " INNER JOIN `daily_sales_master` "
        SQLEX += " ON (`daily_sales_detail`.`sales_sys` = `daily_sales_master`.`SysPK_dailysales`)"
        SQLEX += " INNER JOIN `inventory_master` "
        SQLEX += " ON (`inventory_master`.`a_code` = `daily_sales_detail`.`item_invcode`)"
        SQLEX += " WHERE DATE(dailysales_date) BETWEEN "
        SQLEX += String.Format("'{0}' AND '{1}'", Format(dtpFrom.Value, "yyyy-MM-dd"), Format(dtpTo.Value, "yyyy-MM-dd"))
        SQLEX += " AND `daily_sales_detail`.`sales_stat` <> '0'"
        SQLEX += " GROUP BY item_invcode"




        Dim datefrom As String = Format(dtpFrom.Value, "yyyy-MM-dd")
        Dim dateto As String = Format(dtpTo.Value, "yyyy-MM-dd")

        Dim new_report As New fzzReportViewerForm
        Try
            new_report.AttachReport(SQLEX, "Daily_Sales_Report_" & datefrom & "-" & dateto) = New rpt_DailySalesItemRange(datefrom, dateto)
            new_report.Show()
        Catch ex As Exception

        End Try
    End Sub

End Class