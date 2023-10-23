Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class fmaTimelinessForm

    Dim FirstLoad As Boolean
    Dim Mode As String = ""

    Private DT_TARGET As DataTable
    Private SQL_QUERY As String = ""

    Private Sub fmaTimelinessForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        FirstLoad = True

        lblDate.Text = "MONTHLY"
        Label1.Visible = False
        dtpTo.Visible = False

        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMMM"
        dtpFrom.ShowUpDown = False

        cmbMode.SelectedIndex = 0

        loadTargetSummary()

        FirstLoad = False


    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        If FirstLoad = False Then
            Try
                Mode = cmbMode.Text
                If Mode = "YEAR" Then
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
                    dtpFrom.CustomFormat = "MMMM"
                    dtpFrom.ShowUpDown = False

                Else

                    lblDate.Text = "DATE FROM"
                    Label1.Visible = True
                    dtpTo.Visible = True

                    dtpFrom.Format = DateTimePickerFormat.Custom
                    dtpFrom.CustomFormat = "MMM dd, yyyy"
                    dtpFrom.ShowUpDown = False

                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        loadTargetSummary()
    End Sub

    Private Sub loadTargetSummary()

        Dim SQLEX As String = "SELECT DATE(dsm.tr_date) 'date', 
                                ( SELECT COUNT(a.SysPK) 'count'
         
                                         FROM daily_sales_master a
                                                                INNER JOIN patient_type b
                                                                ON (a.chargingid = b.a_code)
                                                                WHERE b.patient_type='0' 
                                                                AND  DATE(a.tr_date) = DATE(dsm.tr_date)
                                                                GROUP BY DATE
                                 ) 'In_Patient_Counter', '105 Minutes' AS 'target_ip', 'Within 105 mins.' AS 'ServingTime_ip',
 
                                 
                                 ( SELECT COUNT(a.SysPK) 'count'
         
                                         FROM daily_sales_master a
                                                                INNER JOIN patient_type b
                                                                ON (a.chargingid = b.a_code)
                                                                WHERE b.patient_type='1' 
                                                                AND  DATE(a.tr_date) = DATE(dsm.tr_date)
                                                                GROUP BY DATE
                                 ) 'Out_Patient_Counter', '35 Minutes' AS 'target_op', 'Within 35 mins.' AS 'ServingTime_op'
 
                                                                                                 
                                 FROM daily_sales_master dsm"




        If cmbMode.SelectedIndex = 0 Then

            SQLEX += " WHERE DATE_FORMAT(tr_date,'%M') = '" & Format(dtpFrom.Value, "MMMM") & "' "

        Else
            SQLEX += " WHERE DATE(tr_date) BETWEEN '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' AND  '" & Format(dtpTo.Value, "yyyy-MM-dd") & "' "

        End If

        SQLEX += "group by date"

        SQL_QUERY = SQLEX


        tdbViewer.DataSource = Nothing

        DT_TARGET = Nothing

        '
        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        DT_TARGET = MeData.Copy

        Try
            With tdbViewer.Splits(0)


                .DisplayColumns("date").DataColumn.Caption = "PR DATE"
                .DisplayColumns("date").Width = 200
                .DisplayColumns("date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center


                .DisplayColumns("In_Patient_Counter").DataColumn.Caption = "Number of In-Patients RX Filled"
                .DisplayColumns("In_Patient_Counter").Width = 150
                .DisplayColumns("In_Patient_Counter").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("In_Patient_Counter").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("target_ip").DataColumn.Caption = "TARGET TIME(In-Patients)"
                .DisplayColumns("target_ip").Width = 300
                .DisplayColumns("target_ip").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("target_ip").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("ServingTime_ip").DataColumn.Caption = "SERVING TIME"
                .DisplayColumns("ServingTime_ip").Width = 200
                .DisplayColumns("ServingTime_ip").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("ServingTime_ip").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("Out_Patient_Counter").DataColumn.Caption = "Number of Out-Patients RX Filled"
                .DisplayColumns("Out_Patient_Counter").Width = 150
                .DisplayColumns("Out_Patient_Counter").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Out_Patient_Counter").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("target_op").DataColumn.Caption = "TARGET TIME(Out-Patients)"
                .DisplayColumns("target_op").Width = 300
                .DisplayColumns("target_op").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("target_op").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("ServingTime_op").DataColumn.Caption = "SERVING TIME"
                .DisplayColumns("ServingTime_op").Width = 200
                .DisplayColumns("ServingTime_op").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("ServingTime_op").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


            End With


        Catch ex As Exception

        End Try




    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        loadTargetSummary()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim RPTdate As String = Format(dtpFrom.Value, "MMMM yyyy")

        Dim new_report As New fzzReportViewerForm
        Try

            new_report.AttachReport(SQL_QUERY, "Summary Report of Target for Timeliness " & RPTdate) = New rpt_TargetTimeliness(RPTdate)
            new_report.Show()
        Catch ex As Exception
            MsgBox("Exception Occured :", ex.Message)
        End Try
    End Sub
End Class