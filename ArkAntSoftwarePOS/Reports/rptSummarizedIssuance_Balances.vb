Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptSummarizedIssuance_Balances


    Private lbl2 As DataDynamics.ActiveReports.Label
    Private lbl3 As DataDynamics.ActiveReports.Label

    Private TotalFooter As DataDynamics.ActiveReports.TextBox
    Private TotalIssuanceFooter As DataDynamics.ActiveReports.TextBox


    Private MeFormControls As Hashtable

    Private DATEFROM As String
    Private DATETO As String
    Private MONTHOF As String
    Private PAYMENTGROUP As Integer

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal pdateFrom As String, ByVal pdateTo As String, ByVal month As String, ByVal paygrp As Integer)
        InitializeComponent()
        Me.PAYMENTGROUP = paygrp
        Me.DATEFROM = pdateFrom
        Me.DATETO = pdateTo
        Me.MONTHOF = month

        Me.txtReportTitle.Text = txtReportTitle.Text & " " & month
        MeFormControls = New Hashtable

    End Sub

    Private Sub rptMonthlySummaryIssuance_Balances_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS


    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        srEndingBalance.Report = New subrpt_SummarizedBalance
        srEndingBalance.Report.DataSource = report_summarized_balance
    End Sub
End Class
