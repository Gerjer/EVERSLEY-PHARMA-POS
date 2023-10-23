<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_ActualInventoryReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rpt_ActualInventoryReport))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.txtFrom = New DataDynamics.ActiveReports.TextBox
        Me.txtTo = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCode = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.txtAdded = New DataDynamics.ActiveReports.TextBox
        Me.txtSold = New DataDynamics.ActiveReports.TextBox
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCmpName, Me.txtAddress, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.txtFrom, Me.txtTo})
        Me.PageHeader1.Height = 1.333333!
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
        Me.txtCmpName.Width = 9.9375!
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
        Me.txtAddress.Width = 9.9375!
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
        Me.TextBox1.Text = "DATE"
        Me.TextBox1.Top = 0.8125!
        Me.TextBox1.Width = 0.4375!
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
        Me.TextBox2.Text = "INVENTORY REPORT"
        Me.TextBox2.Top = 0.5!
        Me.TextBox2.Width = 9.9375!
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
        Me.TextBox3.Top = 1.0!
        Me.TextBox3.Visible = False
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
        Me.TextBox4.Top = 0.8125!
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
        Me.TextBox5.Top = 1.0!
        Me.TextBox5.Visible = False
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
        Me.txtFrom.Top = 0.8125!
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
        Me.txtTo.Top = 1.0!
        Me.txtTo.Visible = False
        Me.txtTo.Width = 2.5!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCode, Me.TextBox12, Me.TextBox13, Me.txtAdded, Me.txtSold, Me.TextBox16, Me.TextBox24, Me.TextBox15, Me.TextBox27})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
        '
        'txtCode
        '
        Me.txtCode.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtCode.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtCode.Border.RightColor = System.Drawing.Color.Black
        Me.txtCode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtCode.Border.TopColor = System.Drawing.Color.Black
        Me.txtCode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtCode.CanGrow = False
        Me.txtCode.DataField = "a_code"
        Me.txtCode.Height = 0.1875!
        Me.txtCode.Left = 0.0!
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtCode.Text = Nothing
        Me.txtCode.Top = 0.0!
        Me.txtCode.Width = 0.625!
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
        Me.TextBox12.DataField = "Item_Display"
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 0.625!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 2.8125!
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
        Me.TextBox13.DataField = "item_price"
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 4.8125!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.875!
        '
        'txtAdded
        '
        Me.txtAdded.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdded.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdded.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdded.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdded.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdded.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdded.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdded.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAdded.CanGrow = False
        Me.txtAdded.Height = 0.1875!
        Me.txtAdded.Left = 5.6875!
        Me.txtAdded.Name = "txtAdded"
        Me.txtAdded.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtAdded.Text = Nothing
        Me.txtAdded.Top = 0.0!
        Me.txtAdded.Width = 0.6875!
        '
        'txtSold
        '
        Me.txtSold.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSold.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSold.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSold.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSold.Border.RightColor = System.Drawing.Color.Black
        Me.txtSold.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSold.Border.TopColor = System.Drawing.Color.Black
        Me.txtSold.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSold.CanGrow = False
        Me.txtSold.Height = 0.1875!
        Me.txtSold.Left = 6.375!
        Me.txtSold.Name = "txtSold"
        Me.txtSold.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtSold.Text = Nothing
        Me.txtSold.Top = 0.0!
        Me.txtSold.Width = 0.6875!
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
        Me.TextBox16.DataField = "inv_qty"
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 7.0625!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 0.75!
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
        Me.TextBox24.DataField = "item_unit"
        Me.TextBox24.Height = 0.1875!
        Me.TextBox24.Left = 3.4375!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 0.0!
        Me.TextBox24.Width = 0.5!
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
        Me.TextBox15.DataField = "item_buyprice"
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 3.9375!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.875!
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
        Me.TextBox27.DataField = "item_reordercount"
        Me.TextBox27.Height = 0.1875!
        Me.TextBox27.Left = 7.8125!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox27.Text = Nothing
        Me.TextBox27.Top = 0.0!
        Me.TextBox27.Width = 1.125!
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
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox23, Me.TextBox14, Me.TextBox26})
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
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 0.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "text-align: center; "
        Me.TextBox6.Text = "CODE"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.625!
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
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 0.625!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "text-align: center; "
        Me.TextBox7.Text = "DESCRIPTION"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 2.8125!
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
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 6.375!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "text-align: center; "
        Me.TextBox8.Text = "SOLD"
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.6875!
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
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 5.6875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-align: center; "
        Me.TextBox9.Text = "ADDED"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.6875!
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
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 7.0625!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: center; "
        Me.TextBox10.Text = "REM. QTY"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.75!
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
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 4.8125!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "text-align: center; "
        Me.TextBox11.Text = "SELL PRICE"
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.875!
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
        Me.TextBox23.Height = 0.1875!
        Me.TextBox23.Left = 3.4375!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "text-align: center; "
        Me.TextBox23.Text = "UNIT"
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.5!
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
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 3.9375!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "text-align: center; "
        Me.TextBox14.Text = "BUY PRICE"
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 0.875!
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
        Me.TextBox26.Height = 0.1875!
        Me.TextBox26.Left = 7.8125!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "text-align: center; "
        Me.TextBox26.Text = "ORDER LVL"
        Me.TextBox26.Top = 0.0!
        Me.TextBox26.Width = 1.125!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox17, Me.TextBox18, Me.TextBox22, Me.TextBox25})
        Me.GroupFooter1.Height = 0.46875!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.CanGrow = False
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 0.625!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "text-align: left; "
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 2.8125!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.CanGrow = False
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 3.9375!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "text-align: right; "
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 5.0!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.CanGrow = False
        Me.TextBox22.Height = 0.1875!
        Me.TextBox22.Left = 0.0!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "text-align: center; "
        Me.TextBox22.Text = Nothing
        Me.TextBox22.Top = 0.0!
        Me.TextBox22.Width = 0.625!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.CanGrow = False
        Me.TextBox25.Height = 0.1875!
        Me.TextBox25.Left = 3.4375!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "text-align: right; "
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 0.5!
        '
        'rpt_ActualInventoryReport
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 8.5!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 11.0!
        Me.PrintWidth = 9.96875!
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
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCmpName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFrom As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtCode As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdded As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSold As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
End Class
