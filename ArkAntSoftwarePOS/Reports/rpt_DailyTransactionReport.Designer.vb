<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_DailyTransactionReport 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rpt_DailyTransactionReport))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.txtFrom = New DataDynamics.ActiveReports.TextBox
        Me.txtTo = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCmpName, Me.txtAddress, Me.TextBox2, Me.TextBox1, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.txtFrom, Me.txtTo})
        Me.PageHeader1.Height = 1.333!
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
        Me.TextBox2.Style = "text-decoration: underline; ddo-char-set: 0; text-align: center; font-size: 9.75p" & _
            "t; "
        Me.TextBox2.Text = "TRANSACTION REPORT"
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
        Me.TextBox1.Style = ""
        Me.TextBox1.Text = "FROM"
        Me.TextBox1.Top = 0.875!
        Me.TextBox1.Width = 0.4375!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = ""
        Me.TextBox3.Text = "TO"
        Me.TextBox3.Top = 1.0625!
        Me.TextBox3.Width = 0.4375!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 0.4375!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = ""
        Me.TextBox4.Text = ":"
        Me.TextBox4.Top = 0.875!
        Me.TextBox4.Width = 0.0625!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 0.4375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = ""
        Me.TextBox5.Text = ":"
        Me.TextBox5.Top = 1.0625!
        Me.TextBox5.Width = 0.0625!
        '
        'txtFrom
        '
        Me.txtFrom.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFrom.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFrom.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFrom.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFrom.Border.RightColor = System.Drawing.Color.Black
        Me.txtFrom.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFrom.Border.TopColor = System.Drawing.Color.Black
        Me.txtFrom.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFrom.Height = 0.1875!
        Me.txtFrom.Left = 0.5625!
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Style = ""
        Me.txtFrom.Text = Nothing
        Me.txtFrom.Top = 0.875!
        Me.txtFrom.Width = 2.5!
        '
        'txtTo
        '
        Me.txtTo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTo.Border.RightColor = System.Drawing.Color.Black
        Me.txtTo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTo.Border.TopColor = System.Drawing.Color.Black
        Me.txtTo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTo.Height = 0.1875!
        Me.txtTo.Left = 0.5625!
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Style = ""
        Me.txtTo.Text = Nothing
        Me.txtTo.Top = 1.0625!
        Me.txtTo.Width = 2.5!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21})
        Me.Detail1.Height = 0.15625!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.CanGrow = False
        Me.TextBox14.DataField = "dailysales_date"
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 0.0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "text-align: left; "
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 1.3125!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.CanGrow = False
        Me.TextBox15.DataField = "system_gen_id"
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 1.3125!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "text-align: center; "
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.8125!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.CanGrow = False
        Me.TextBox16.DataField = "dailysales_amount"
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 2.125!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "text-align: right; "
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 0.8125!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.CanGrow = False
        Me.TextBox17.DataField = "Discount"
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 2.9375!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "text-align: right; "
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 0.8125!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.CanGrow = False
        Me.TextBox18.DataField = "dailysales_net"
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 3.75!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.OutputFormat = resources.GetString("TextBox18.OutputFormat")
        Me.TextBox18.Style = "text-align: right; "
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 0.8125!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.CanGrow = False
        Me.TextBox19.DataField = "dailysales_cash"
        Me.TextBox19.Height = 0.1875!
        Me.TextBox19.Left = 4.5625!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
        Me.TextBox19.Style = "text-align: right; "
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.0!
        Me.TextBox19.Width = 0.8125!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.CanGrow = False
        Me.TextBox20.DataField = "dailysales_change"
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 5.375!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.OutputFormat = resources.GetString("TextBox20.OutputFormat")
        Me.TextBox20.Style = "text-align: right; "
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.0!
        Me.TextBox20.Width = 0.8125!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.CanGrow = False
        Me.TextBox21.DataField = "Transaction_Type"
        Me.TextBox21.Height = 0.1875!
        Me.TextBox21.Left = 6.1875!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "text-align: center; "
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 0.0!
        Me.TextBox21.Width = 0.75!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1, Me.TextBox28})
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
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
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13})
        Me.GroupHeader1.Height = 0.1875!
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
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 0.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "text-align: center; "
        Me.TextBox6.Text = "SALES DATE/TIME"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 1.3125!
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
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 1.3125!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "text-align: center; "
        Me.TextBox7.Text = "TRNS #"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.8125!
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
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 2.125!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "text-align: center; "
        Me.TextBox8.Text = "AMOUNT"
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.8125!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.CanGrow = False
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 2.9375!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-align: center; "
        Me.TextBox9.Text = "DISCOUNT"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.8125!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.CanGrow = False
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 3.75!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: center; "
        Me.TextBox10.Text = "TOTAL"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.8125!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.CanGrow = False
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 4.5625!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "text-align: center; "
        Me.TextBox11.Text = "CASH"
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.8125!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.CanGrow = False
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 5.375!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "text-align: center; "
        Me.TextBox12.Text = "CHANGE"
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.8125!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.CanGrow = False
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 6.1875!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "text-align: center; "
        Me.TextBox13.Text = "STATUS"
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.75!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27})
        Me.GroupFooter1.Height = 0.1979167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.CanGrow = False
        Me.TextBox22.DataField = "dailysales_amount"
        Me.TextBox22.Height = 0.1875!
        Me.TextBox22.Left = 2.125!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.OutputFormat = resources.GetString("TextBox22.OutputFormat")
        Me.TextBox22.Style = "text-align: right; "
        Me.TextBox22.SummaryGroup = "GroupHeader1"
        Me.TextBox22.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox22.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox22.Text = Nothing
        Me.TextBox22.Top = 0.0!
        Me.TextBox22.Width = 0.8125!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.CanGrow = False
        Me.TextBox23.DataField = "Discount"
        Me.TextBox23.Height = 0.1875!
        Me.TextBox23.Left = 2.9375!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.OutputFormat = resources.GetString("TextBox23.OutputFormat")
        Me.TextBox23.Style = "text-align: right; "
        Me.TextBox23.SummaryGroup = "GroupHeader1"
        Me.TextBox23.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox23.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.8125!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.CanGrow = False
        Me.TextBox24.DataField = "dailysales_net"
        Me.TextBox24.Height = 0.1875!
        Me.TextBox24.Left = 3.75!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.OutputFormat = resources.GetString("TextBox24.OutputFormat")
        Me.TextBox24.Style = "text-align: right; "
        Me.TextBox24.SummaryGroup = "GroupHeader1"
        Me.TextBox24.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox24.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 0.0!
        Me.TextBox24.Width = 0.8125!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.CanGrow = False
        Me.TextBox25.DataField = "dailysales_cash"
        Me.TextBox25.Height = 0.1875!
        Me.TextBox25.Left = 4.5625!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.OutputFormat = resources.GetString("TextBox25.OutputFormat")
        Me.TextBox25.Style = "text-align: right; "
        Me.TextBox25.SummaryGroup = "GroupHeader1"
        Me.TextBox25.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox25.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 0.8125!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.CanGrow = False
        Me.TextBox26.DataField = "dailysales_change"
        Me.TextBox26.Height = 0.1875!
        Me.TextBox26.Left = 5.375!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.OutputFormat = resources.GetString("TextBox26.OutputFormat")
        Me.TextBox26.Style = "text-align: right; "
        Me.TextBox26.SummaryGroup = "GroupHeader1"
        Me.TextBox26.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox26.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox26.Text = Nothing
        Me.TextBox26.Top = 0.0!
        Me.TextBox26.Width = 0.8125!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.CanGrow = False
        Me.TextBox27.Height = 0.1875!
        Me.TextBox27.Left = 6.1875!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "text-align: center; "
        Me.TextBox27.Text = Nothing
        Me.TextBox27.Top = 0.0!
        Me.TextBox27.Width = 0.75!
        '
        'rpt_DailyTransactionReport
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.989583!
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
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCmpName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFrom As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
End Class 
