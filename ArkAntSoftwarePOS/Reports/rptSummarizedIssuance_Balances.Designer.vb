<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSummarizedIssuance_Balances
    Inherits DataDynamics.ActiveReports.ActiveReport3

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptSummarizedIssuance_Balances))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtReportTitle = New DataDynamics.ActiveReports.TextBox
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.srEndingBalance = New DataDynamics.ActiveReports.SubReport
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        CType(Me.txtReportTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtReportTitle, Me.txtAddress, Me.txtCmpName, Me.TextBox1})
        Me.PageHeader1.Height = 1.1875!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReportTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportTitle.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReportTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportTitle.Border.RightColor = System.Drawing.Color.Black
        Me.txtReportTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportTitle.Border.TopColor = System.Drawing.Color.Black
        Me.txtReportTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportTitle.Height = 0.1875!
        Me.txtReportTitle.Left = 0.0!
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Style = "ddo-char-set: 0; text-decoration: none; text-align: center; font-size: 9.75pt; "
        Me.txtReportTitle.Text = "SUMMARY REPORT OF ISSUANCES AND BALANCES OF DRUGS AND MEDICINES FOR THE MONTH OF"
        Me.txtReportTitle.Top = 0.75!
        Me.txtReportTitle.Width = 10.9375!
        '
        'txtAddress
        '
        Me.txtAddress.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAddress.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAddress.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Border.RightColor = System.Drawing.Color.Black
        Me.txtAddress.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Border.TopColor = System.Drawing.Color.Black
        Me.txtAddress.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Height = 0.1875!
        Me.txtAddress.Left = 0.0!
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Style = "text-align: center; "
        Me.txtAddress.Text = "Address"
        Me.txtAddress.Top = 0.1875!
        Me.txtAddress.Width = 10.9375!
        '
        'txtCmpName
        '
        Me.txtCmpName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCmpName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCmpName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCmpName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCmpName.Border.RightColor = System.Drawing.Color.Black
        Me.txtCmpName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCmpName.Border.TopColor = System.Drawing.Color.Black
        Me.txtCmpName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCmpName.Height = 0.1875!
        Me.txtCmpName.Left = 0.0!
        Me.txtCmpName.Name = "txtCmpName"
        Me.txtCmpName.Style = "ddo-char-set: 0; text-align: center; font-size: 12pt; "
        Me.txtCmpName.Text = "Company Name"
        Me.txtCmpName.Top = 0.0!
        Me.txtCmpName.Width = 10.9375!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "text-decoration: underline; ddo-char-set: 0; text-align: center; font-size: 9.75p" & _
            "t; "
        Me.TextBox1.Text = "PHARMACY UNIT"
        Me.TextBox1.Top = 0.5!
        Me.TextBox1.Width = 10.9375!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Height = 0.01041667!
        Me.Detail1.Name = "Detail1"
        Me.Detail1.Visible = False
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox28, Me.ReportInfo1})
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Height = 0.1979167!
        Me.TextBox28.Left = 0.0!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = ""
        Me.TextBox28.Text = "Date Printed :"
        Me.TextBox28.Top = 0.0!
        Me.TextBox28.Width = 1.0!
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "{RunDateTime:M/d/yyyy h:mm tt}"
        Me.ReportInfo1.Height = 0.1875!
        Me.ReportInfo1.Left = 1.0!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = ""
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 2.25!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6, Me.TextBox2, Me.srEndingBalance})
        Me.GroupHeader1.Height = 1.260417!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.CanGrow = False
        Me.TextBox6.DataField = "supplier"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 4.125!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
            "al-align: middle; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 3.8125!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.CanGrow = False
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 0.125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; vertical" & _
            "-align: middle; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 4.0!
        '
        'srEndingBalance
        '
        Me.srEndingBalance.Border.BottomColor = System.Drawing.Color.Black
        Me.srEndingBalance.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srEndingBalance.Border.LeftColor = System.Drawing.Color.Black
        Me.srEndingBalance.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srEndingBalance.Border.RightColor = System.Drawing.Color.Black
        Me.srEndingBalance.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srEndingBalance.Border.TopColor = System.Drawing.Color.Black
        Me.srEndingBalance.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srEndingBalance.CloseBorder = False
        Me.srEndingBalance.Height = 1.0!
        Me.srEndingBalance.Left = 0.125!
        Me.srEndingBalance.Name = "srEndingBalance"
        Me.srEndingBalance.Report = Nothing
        Me.srEndingBalance.ReportName = "SubReport1"
        Me.srEndingBalance.Top = 0.1979167!
        Me.srEndingBalance.Width = 7.9375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.Shape1})
        Me.GroupFooter1.Height = 2.114583!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label4.Text = "Certified Correct: DIANA JANE C. REGIS RPh"
        Me.Label4.Top = 1.6875!
        Me.Label4.Width = 3.625!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "text-align: center; "
        Me.Label5.Text = "Pharmacy Head"
        Me.Label5.Top = 1.875!
        Me.Label5.Width = 3.625!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label6.Text = "Noted: LOPE MA. P. CARABAÑA JR, MD, MHA, CSEE"
        Me.Label6.Top = 1.6875!
        Me.Label6.Width = 3.625!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.375!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: center; "
        Me.Label7.Text = "Medical Center Chief I"
        Me.Label7.Top = 1.875!
        Me.Label7.Width = 3.625!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 6.375!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.TextBox20.Text = "Document Code : PHARM-SUPP"
        Me.TextBox20.Top = 0.375!
        Me.TextBox20.Width = 3.625!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Height = 0.1875!
        Me.TextBox21.Left = 6.375!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.TextBox21.Text = "Revision: 00"
        Me.TextBox21.Top = 0.625!
        Me.TextBox21.Width = 3.625!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Height = 0.1875!
        Me.TextBox22.Left = 6.375!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.TextBox22.Text = "Effectivity Date: July 1, 2014"
        Me.TextBox22.Top = 0.875!
        Me.TextBox22.Width = 3.625!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.875!
        Me.Shape1.Left = 6.25!
        Me.Shape1.LineWeight = 4.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.3125!
        Me.Shape1.Width = 3.875!
        '
        'rptSummarizedIssuance_Balances
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.25!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.95833!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtReportTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtReportTitle As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCmpName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srEndingBalance As DataDynamics.ActiveReports.SubReport
End Class
