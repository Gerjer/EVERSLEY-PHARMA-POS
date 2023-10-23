<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptMonthlySalesReport 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptMonthlySalesReport))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.txtDayStat = New DataDynamics.ActiveReports.TextBox
        Me.txtDateRecord = New DataDynamics.ActiveReports.TextBox
        Me.txtNetSales = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDayStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCmpName, Me.txtAddress, Me.TextBox2, Me.TextBox1, Me.txtDate, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6})
        Me.PageHeader1.Height = 1.614583!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.txtCmpName.Width = 7.0!
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
        Me.txtAddress.Width = 7.0!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "text-decoration: underline; ddo-char-set: 0; text-align: center; font-weight: bol" & _
            "d; font-size: 12pt; "
        Me.TextBox2.Text = "MONTHLY SALES REPORT"
        Me.TextBox2.Top = 0.5!
        Me.TextBox2.Width = 7.0!
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
        Me.TextBox1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 12pt; "
        Me.TextBox1.Text = "MONTH :"
        Me.TextBox1.Top = 1.0!
        Me.TextBox1.Width = 0.8125!
        '
        'txtDate
        '
        Me.txtDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Height = 0.1875!
        Me.txtDate.Left = 0.875!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Style = "ddo-char-set: 0; font-weight: bold; font-size: 12pt; "
        Me.txtDate.Text = Nothing
        Me.txtDate.Top = 1.0!
        Me.txtDate.Width = 4.4375!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: center; "
        Me.TextBox3.Text = "DATE"
        Me.TextBox3.Top = 1.4375!
        Me.TextBox3.Width = 0.625!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 0.625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "text-align: center; "
        Me.TextBox4.Text = "DAY"
        Me.TextBox4.Top = 1.4375!
        Me.TextBox4.Width = 1.375!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 2.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "text-align: center; "
        Me.TextBox5.Text = "STATUS"
        Me.TextBox5.Top = 1.4375!
        Me.TextBox5.Width = 1.375!
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
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 3.375!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "text-align: center; "
        Me.TextBox6.Text = "NET SALES"
        Me.TextBox6.Top = 1.4375!
        Me.TextBox6.Width = 2.0!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox7, Me.TextBox8, Me.txtDayStat, Me.txtDateRecord, Me.txtNetSales})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.CanGrow = False
        Me.TextBox7.DataField = "day"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 0.0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "text-align: center; "
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.625!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.CanGrow = False
        Me.TextBox8.DataField = "calendar_day"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 0.625!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "text-align: left; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 1.375!
        '
        'txtDayStat
        '
        Me.txtDayStat.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDayStat.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDayStat.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDayStat.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDayStat.Border.RightColor = System.Drawing.Color.Black
        Me.txtDayStat.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDayStat.Border.TopColor = System.Drawing.Color.Black
        Me.txtDayStat.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDayStat.CanGrow = False
        Me.txtDayStat.Height = 0.1875!
        Me.txtDayStat.Left = 2.0!
        Me.txtDayStat.Name = "txtDayStat"
        Me.txtDayStat.Style = "text-align: center; "
        Me.txtDayStat.Text = Nothing
        Me.txtDayStat.Top = 0.0!
        Me.txtDayStat.Width = 1.375!
        '
        'txtDateRecord
        '
        Me.txtDateRecord.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDateRecord.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDateRecord.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDateRecord.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDateRecord.Border.RightColor = System.Drawing.Color.Black
        Me.txtDateRecord.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDateRecord.Border.TopColor = System.Drawing.Color.Black
        Me.txtDateRecord.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDateRecord.CanGrow = False
        Me.txtDateRecord.DataField = "dateRecord"
        Me.txtDateRecord.Height = 0.1875!
        Me.txtDateRecord.Left = 5.375!
        Me.txtDateRecord.Name = "txtDateRecord"
        Me.txtDateRecord.OutputFormat = resources.GetString("txtDateRecord.OutputFormat")
        Me.txtDateRecord.Style = "text-align: center; "
        Me.txtDateRecord.Text = Nothing
        Me.txtDateRecord.Top = 0.0!
        Me.txtDateRecord.Visible = False
        Me.txtDateRecord.Width = 1.5!
        '
        'txtNetSales
        '
        Me.txtNetSales.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNetSales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNetSales.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNetSales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNetSales.Border.RightColor = System.Drawing.Color.Black
        Me.txtNetSales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNetSales.Border.TopColor = System.Drawing.Color.Black
        Me.txtNetSales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNetSales.CanGrow = False
        Me.txtNetSales.Height = 0.1875!
        Me.txtNetSales.Left = 3.375!
        Me.txtNetSales.Name = "txtNetSales"
        Me.txtNetSales.Style = "text-align: right; "
        Me.txtNetSales.Text = Nothing
        Me.txtNetSales.Top = 0.0!
        Me.txtNetSales.Width = 2.0!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox11, Me.txtTotal, Me.TextBox9, Me.TextBox10})
        Me.GroupFooter1.Height = 1.729167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.CanGrow = False
        Me.TextBox11.Height = 0.3125!
        Me.TextBox11.Left = 0.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; vertic" & _
            "al-align: middle; "
        Me.TextBox11.Text = "TOTAL"
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 3.375!
        '
        'txtTotal
        '
        Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotal.CanGrow = False
        Me.txtTotal.Height = 0.3125!
        Me.txtTotal.Left = 3.375!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; vertica" & _
            "l-align: middle; "
        Me.txtTotal.Text = Nothing
        Me.txtTotal.Top = 0.0!
        Me.txtTotal.Width = 2.0!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-align: center; "
        Me.TextBox9.Text = "Prepared By : "
        Me.TextBox9.Top = 1.125!
        Me.TextBox9.Width = 2.5625!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 0.0!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: center; "
        Me.TextBox10.Text = "Signed"
        Me.TextBox10.Top = 0.875!
        Me.TextBox10.Width = 2.5625!
        '
        'rptMonthlySalesReport
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.03125!
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
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDayStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCmpName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDayStat As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDateRecord As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
End Class 
