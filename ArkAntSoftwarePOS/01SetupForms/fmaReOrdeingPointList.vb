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

Public Class fmaReOrdeingPointList

    Inherits System.Windows.Forms.Form
    Public Event ITEM_SELECTED()
    Public Event WIN_CLOSED()

    Private WithEvents SETUPFORM As fmaInventoryMasterSetupForm
    'Shared Sub New()
    '    Dim asm As Reflection.Assembly = GetType(DevExpress.UserSkins.SkinProject1).Assembly
    '    DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm)
    '    'Splash screens and wait forms created with the help of the SplashScreenManager component run in a separate thread.  
    '    'Information on custom skins registered in the main thread is not available in the splash screen thread  
    '    'until you call the SplashScreenManager.RegisterUserSkins method.  
    '    'To provide information on custom skins to the splash screen thread, uncomment the following line. 
    '    'DevExpress.XtraSplashScreen.SplashScreenManager.RegisterUserSkins(asm)
    'End Sub

    'Public Sub New()
    '    InitializeComponent()
    'End Sub

    Private Sub fmaReOrdeingPointList_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        loadList()

    End Sub

    Private Sub fmaReOrdeingPointList_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        RaiseEvent WIN_CLOSED()
    End Sub


    Private Sub loadList()

        Dim SQL As String = ""
        SQL = "SELECT
ris_details.RIS_Det_No,
ris_master.date_received,
inventory_master.a_code,
inventory_master.a_name,
inventory_master.uom,
ris_details.price 'buy_price',
inventory_master.selling_price,
ris_details.qty_received,
(SELECT
IFNULL(sum(daily_sales_detail.item_qty),0)
FROM
daily_sales_detail
WHERE
daily_sales_detail.item_invcode = inventory_master.a_code AND
DATE_FORMAT(daily_sales_detail.date_created,'%Y-%m-%d') BETWEEN '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' and '" & Format(dtpTo.Value, "yyyy-MM-dd") & "')'sold',
ris_details.qty_remaining,
ris_details.expiry_date,
CASE WHEN CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') >= 1 AND 
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') <= 30 THEN 
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%')
ELSE '' END AS 'SMM', 
CASE WHEN CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') >= 31 AND 	
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') <= 50 THEN 
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%')
ELSE '' END AS 'MM',
CASE WHEN CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') >= 51 AND 			
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') <= 100 THEN 
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%')
ELSE '' END AS 'FMM',
CASE WHEN CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') >= 70 AND 			
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%') <= 100 THEN
CONCAT(ROUND(((ris_details.qty_received - ris_details.qty_remaining) / ris_details.qty_received ) * 100 ),'%')
ELSE '' END AS 'EMM'								
			
	FROM inventory_master 
	INNER JOIN ris_details  ON (inventory_master.a_code = ris_details.inv_master_SysPK)
	INNER JOIN ris_master  ON (ris_details.RIS_Master_No = ris_master.RIS_No)
		
	WHERE date_received BETWEEN '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'
		 
	ORDER BY expiry_date, a_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQL)

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = MeData

        '   DesignView(GridView1)

    End Sub

    Private Sub DesignView(gridView1 As GridView)

        Dim view As GridView = DirectCast(gridView1, GridView)

        For i As Integer = 0 To gridView1.Columns.Count - 1

            Select Case i
                Case 10
                    view.Columns(i).AppearanceCell.ForeColor = Color.Red
                Case Else
                    view.Columns(i).Visible = False
            End Select
        Next


    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        '  loadList()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        '    loadList()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged

        Try

            If cmbMode.SelectedIndex = 0 Then
                grpRange.Visible = False
                cmbQuarterly.Visible = True
            Else
                grpRange.Visible = True
                cmbQuarterly.Visible = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        loadConsumption()

    End Sub

    Private Sub loadConsumption()

        GridControl2.DataSource = Nothing

        Dim str As String = ""
        If cmbMode.SelectedIndex = 0 Then

            Select Case cmbQuarterly.SelectedIndex
                Case 0
                    str = " QUARTER(daily_sales_detail.date_created) BETWEEN 1 AND 4"
                Case 1
                    str = " QUARTER(daily_sales_detail.date_created) = 1"
                Case 2
                    str = " QUARTER(daily_sales_detail.date_created) = 2"
                Case 3
                    str = " QUARTER(daily_sales_detail.date_created) = 3"
                Case 4
                    str = " QUARTER(daily_sales_detail.date_created) = 4"
            End Select

        Else

            str = " MONTH(daily_sales_detail.date_created) BETWEEN '" & Format(dtpFrom.Value, "MM") & "'  AND '" & Format(dtpTo.Value, "MM") & "'"

        End If

        '     Dim dt As DataTable = DataSource(String.Format("CALL monthly_consumption_ger2x(" & str & ")"))
        Dim dt As New DataTable

        dt = getMonthlyConsumption(str)
        If dt.Rows.Count > 0 Then
            Dim row As Integer = 1
            For x As Integer = 0 To dt.Rows.Count - 1
                dt(x)(0) = row
                row += 1
            Next
        End If

        GridControl2.DataSource = dt
        DesignGridview(BandedGridView1)

    End Sub

    Dim date_range As New List(Of String)
    Private Sub DesignGridview(bandedGridView1 As BandedGridView)

        Dim BView As BandedGridView = DirectCast(bandedGridView1, BandedGridView)
        BView.RefreshData()

        If cmbMode.SelectedIndex = 1 Then
            date_range = getDateRange(dtpFrom.Value, dtpTo.Value)
        End If

        BView.BeginUpdate()

        For i As Integer = 0 To BView.Columns.Count - 1

            Select Case i
                    Case 0, 19, 20
                        BView.Columns(i).Visible = False
                    Case 1
                        BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        BView.Columns(i).BestFit()
                Case 2, 18
                    BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    BView.Columns(i).BestFit()
                Case 15, 16, 17
                    BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    BView.Columns(i).BestFit()
                Case Else

                    Dim grdBand As GridBand = New GridBand()
                    grdBand = BView.Columns(i).OwnerBand
                    If cmbMode.SelectedIndex = 0 Then
                        'QUARTERLY FILTER
                        '      Dim grdBand As GridBand = BView.Columns(i).OwnerBand
                        If cmbQuarterly.SelectedIndex = 0 Then
                            BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                            BView.Columns(i).BestFit()
                            grdBand.Visible = True
                        Else

                            Select Case cmbQuarterly.SelectedIndex
                                Case 1
                                    Select Case BView.Columns(i).GetCaption
                                        Case "JAN", "FEB", "MAR"
                                            BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                            BView.Columns(i).BestFit()
                                            grdBand.Visible = True
                                        Case Else
                                            grdBand.Visible = False
                                    End Select

                                Case 2
                                    Select Case BView.Columns(i).GetCaption
                                        Case "APR", "MAY", "JUN"
                                            BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                            BView.Columns(i).BestFit()
                                            grdBand.Visible = True
                                        Case Else
                                            grdBand.Visible = False
                                    End Select
                                Case 3
                                    Select Case BView.Columns(i).GetCaption
                                        Case "JUL", "AUG", "SEP"
                                            BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                            BView.Columns(i).BestFit()
                                            grdBand.Visible = True
                                        Case Else
                                            grdBand.Visible = False
                                    End Select
                                Case Else
                                    Select Case BView.Columns(i).GetCaption
                                        Case "OCT", "NOV", "DEC"
                                            BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                            BView.Columns(i).BestFit()
                                            grdBand.Visible = True
                                        Case Else
                                            grdBand.Visible = False
                                    End Select
                            End Select
                        End If

                    Else
                        'DATE RANGE FILTER

                        Dim added As Boolean = False
                        Dim name = BView.Columns(i).GetCaption()

                        For Each months In date_range.ToList
                            If name = months Then

                                BView.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                BView.Columns(i).BestFit()
                                grdBand.Visible = True
                                added = True
                            End If
                        Next

                        If added = False Then
                            grdBand.Visible = False
                        End If

                    End If


            End Select

        Next

        BView.EndUpdate()

    End Sub

    Private Function getDateRange(datefrom As Date, dateto As Date) As List(Of String)

        Dim date_range As New List(Of String)
        Dim _from As DateTime = datefrom


        While _from <= dateto
            Dim Months = Format(_from.Date, "MMM").ToUpper
            date_range.Add(Months)
            _from = _from.AddMonths(1)
        End While

        Return date_range

    End Function

    Private Function getMonthlyConsumption(str As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
	                ''AS'No.',
	                a_code,
	                a_name,
	                `JAN`,
	                `FEB`,
	                `MAR`,
	                `APR`,
	                `MAY`,
	                `JUN`,
	                `JUL`,
	                `AUG`,
	                `SEP`,
	                `OCT`,
	                `NOV`,
	                `DEC`,
	                total_consumption,
	                total_consumption / `cnt` 'ave_consumption',
	                format(qty_received / (item_reordercount / 100),0) AS 're_order',
	                CASE WHEN percentage BETWEEN 1 AND 30 THEN 'Slow-Moving Medicine'
			                WHEN  percentage BETWEEN 31 AND 50 THEN 'Moving Medicines'
			                WHEN  percentage BETWEEN 51 AND 100 THEN 'Fast-Moving Medicines'
			                ELSE 'Non-Moving' END AS 'remarks',
	                qty_received,
	                item_reordercount,
	                CONCAT(percentage,'%')'percentage'

	                FROM(
		                SELECT
		                a_code,
		                a_name,
		                qty_received,
		                `consume`,
		                item_reordercount,
		                (`consume` / qty_received) * 100 'percentage',
		                CASE WHEN `JAN` = 0 THEN '' ELSE `JAN` END AS 'JAN',
		                CASE WHEN `FEB` = 0 THEN '' ELSE `FEB` END AS 'FEB',
		                CASE WHEN `MAR` = 0 THEN '' ELSE `MAR` END AS 'MAR',
		                CASE WHEN `APR` = 0 THEN '' ELSE `APR` END AS 'APR',
		                CASE WHEN `MAY` = 0 THEN '' ELSE `MAY` END AS 'MAY',
		                CASE WHEN `JUN` = 0 THEN '' ELSE `JUN` END AS 'JUN',
		                CASE WHEN `JUL` = 0 THEN '' ELSE `JUL` END AS 'JUL',
		                CASE WHEN `AUG` = 0 THEN '' ELSE `AUG` END AS 'AUG',
		                CASE WHEN `SEP` = 0 THEN '' ELSE `SEP` END AS 'SEP',
		                CASE WHEN `OCT` = 0 THEN '' ELSE `OCT` END AS 'OCT',
		                CASE WHEN `NOV` = 0 THEN '' ELSE `NOV` END AS 'NOV',
		                CASE WHEN `DEC` = 0 THEN '' ELSE `DEC` END AS 'DEC',
		                consume 'total_consumption',
		                -- (`JAN` + `FEB` + `MAR` + `APR` + `MAY` + `JUN` + `JUL` + `AUG` + `SEP` + `OCT` + `NOV` + `DEC`)'total_consume', 
		                (CASE WHEN `JAN` > 0 THEN 1 ELSE 0 END  + CASE WHEN `FEB` > 0 THEN 1 ELSE 0 END  + CASE WHEN `MAR` > 0 THEN 1 ELSE 0 END + CASE WHEN `APR` > 0 THEN 1 ELSE 0 END + CASE WHEN `MAY` > 0 THEN 1 ELSE 0 END + CASE WHEN `JUN` > 0 THEN 1 ELSE 0 END + CASE WHEN `JUL` > 0 THEN 1 ELSE 0 END + CASE WHEN `AUG` > 0 THEN 1 ELSE 0 END + CASE WHEN `SEP` > 0 THEN 1 ELSE 0 END + CASE WHEN `OCT` > 0 THEN 1 ELSE 0 END + CASE WHEN `NOV` > 0 THEN 1 ELSE 0 END + CASE WHEN `DEC` > 0 THEN 1 ELSE 0 END) 'cnt'
		
		                FROM(		
			                SELECT
			                a_code,
			                a_name,
			                (SELECT SUM(qty_received) FROM ris_details WHERE inv_master_SysPK = a_code)'qty_received',
			                SUM(`consume`)'consume',
			                item_reordercount,
					                SUM(CASE WHEN `month` = 1 THEN `consume` ELSE 0 END) AS 'JAN',
					                SUM(CASE WHEN `month` = 2 THEN `consume` ELSE 0 END) AS 'FEB',
					                SUM(CASE WHEN `month` = 3 THEN `consume` ELSE 0 END) AS 'MAR',
					                SUM(CASE WHEN `month` = 4 THEN `consume` ELSE 0 END) AS 'APR',
					                SUM(CASE WHEN `month` = 5 THEN `consume` ELSE 0 END) AS 'MAY',
					                SUM(CASE WHEN `month` = 6 THEN `consume` ELSE 0 END) AS 'JUN',
					                SUM(CASE WHEN `month` = 7 THEN `consume` ELSE 0 END) AS 'JUL',
					                SUM(CASE WHEN `month` = 8 THEN `consume` ELSE 0 END) AS 'AUG',
					                SUM(CASE WHEN `month` = 9 THEN `consume` ELSE 0 END) AS 'SEP',
					                SUM(CASE WHEN `month` = 10 THEN `consume` ELSE 0 END) AS 'OCT',
					                SUM(CASE WHEN `month` = 11 THEN `consume` ELSE 0 END) AS 'NOV',
					                SUM(CASE WHEN `month` = 12 THEN `consume` ELSE 0 END) AS 'DEC'			 
			
				                FROM(	
					                SELECT
						                daily_sales_detail.RIS_Det_No,
						                inventory_master.a_code, 
						                inventory_master.a_name, 
						                SUM(daily_sales_detail.item_qty)'consume', 
						                inventory_master.item_reordercount, 
						                MONTH(daily_sales_detail.date_created)'month'													
				
					                FROM
						                inventory_master
						                INNER JOIN 	daily_sales_detail ON inventory_master.a_code = daily_sales_detail.item_invcode AND daily_sales_detail.sales_stat = 1
																
						                WHERE  " & str & "
						
						                GROUP BY  `month`,a_code
						                ORDER BY `month` ASC,a_code
			                )A
			                GROUP BY a_code
		                        ORDER BY `month`
		                 )B
	                 )C
	                 ;"
        Return DataSource(sql)
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim report As New xtrMonthlyConsumption

        report.header.Text = "IN-HOUSE DRUGS MEDICINES CONSUMPTION REPORT FOR C.Y " & Year(Date.Now)
        report.PrintableComponentContainer1.PrintableComponent = GridControl2
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview

    End Sub
End Class