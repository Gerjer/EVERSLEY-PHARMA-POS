<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_MonthlyPatientCountPerCharging 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_MonthlyPatientCountPerCharging))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox()
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.txtMonthOf = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.Picture2 = New DataDynamics.ActiveReports.Picture()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.txtTrDay = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.txtSIHeader = New DataDynamics.ActiveReports.Label()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonthOf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSIHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.txtAddress, Me.txtCmpName, Me.TextBox1, Me.TextBox4, Me.txtMonthOf, Me.TextBox3, Me.Label7, Me.Label8, Me.Picture1, Me.Picture2})
        Me.PageHeader1.Height = 1.15!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.TextBox2.Left = 0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 9.75pt; text-decoration: underlin" &
    "e; "
        Me.TextBox2.Text = "PATIENT COUNT PER CHARGING"
        Me.TextBox2.Top = 0.6625!
        Me.TextBox2.Width = 10.9375!
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
        Me.txtAddress.Left = 0!
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Style = "text-align: center; "
        Me.txtAddress.Text = "Address"
        Me.txtAddress.Top = 0.1875!
        Me.txtAddress.Visible = False
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
        Me.txtCmpName.Left = 0!
        Me.txtCmpName.Name = "txtCmpName"
        Me.txtCmpName.Style = "ddo-char-set: 0; text-align: center; font-size: 12pt; "
        Me.txtCmpName.Text = "Company Name"
        Me.txtCmpName.Top = 0!
        Me.txtCmpName.Visible = False
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
        Me.TextBox1.Left = 0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = ""
        Me.TextBox1.Text = "MONTH OF "
        Me.TextBox1.Top = 0.9125!
        Me.TextBox1.Width = 0.875!
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
        Me.TextBox4.Left = 0.9375!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = ""
        Me.TextBox4.Text = ":"
        Me.TextBox4.Top = 0.9125!
        Me.TextBox4.Width = 0.0625!
        '
        'txtMonthOf
        '
        Me.txtMonthOf.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMonthOf.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMonthOf.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMonthOf.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMonthOf.Border.RightColor = System.Drawing.Color.Black
        Me.txtMonthOf.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMonthOf.Border.TopColor = System.Drawing.Color.Black
        Me.txtMonthOf.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMonthOf.Height = 0.1875!
        Me.txtMonthOf.Left = 1.0625!
        Me.txtMonthOf.Name = "txtMonthOf"
        Me.txtMonthOf.Style = ""
        Me.txtMonthOf.Text = Nothing
        Me.txtMonthOf.Top = 0.9125!
        Me.txtMonthOf.Width = 2.5!
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
        Me.TextBox3.Left = 1.4375!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: center; "
        Me.TextBox3.Text = "Address"
        Me.TextBox3.Top = 0.0625!
        Me.TextBox3.Visible = False
        Me.TextBox3.Width = 7.9375!
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
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.3125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.4375!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; vertical" &
    "-align: middle; "
        Me.Label7.Text = "EVERSLEY CHILDS SANITARIUM AND GENERAL HOSPITAL"
        Me.Label7.Top = 0!
        Me.Label7.Width = 7.8125!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1.4375!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 9.75pt; "
        Me.Label8.Text = "North Road, Jagobiao, Mandaue City, Cebu 6014"
        Me.Label8.Top = 0.3125!
        Me.Label8.Width = 7.8125!
        '
        'Picture1
        '
        Me.Picture1.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.RightColor = System.Drawing.Color.Black
        Me.Picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.TopColor = System.Drawing.Color.Black
        Me.Picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Height = 0.875!
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.ImageData = CType(resources.GetObject("Picture1.ImageData"), System.IO.Stream)
        Me.Picture1.Left = 1.6875!
        Me.Picture1.LineWeight = 0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture1.Top = 0!
        Me.Picture1.Width = 0.8125!
        '
        'Picture2
        '
        Me.Picture2.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.RightColor = System.Drawing.Color.Black
        Me.Picture2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.TopColor = System.Drawing.Color.Black
        Me.Picture2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Height = 0.875!
        Me.Picture2.Image = CType(resources.GetObject("Picture2.Image"), System.Drawing.Image)
        Me.Picture2.ImageData = CType(resources.GetObject("Picture2.ImageData"), System.IO.Stream)
        Me.Picture2.Left = 8.125!
        Me.Picture2.LineWeight = 0!
        Me.Picture2.Name = "Picture2"
        Me.Picture2.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture2.Top = 0!
        Me.Picture2.Width = 0.8125!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTrDay, Me.TextBox14, Me.Label1})
        Me.Detail1.Height = 0.1458333!
        Me.Detail1.Name = "Detail1"
        '
        'txtTrDay
        '
        Me.txtTrDay.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTrDay.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTrDay.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTrDay.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTrDay.Border.RightColor = System.Drawing.Color.Black
        Me.txtTrDay.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTrDay.Border.TopColor = System.Drawing.Color.Black
        Me.txtTrDay.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTrDay.DataField = "TransactionDay"
        Me.txtTrDay.Height = 0.1875!
        Me.txtTrDay.Left = 0!
        Me.txtTrDay.Name = "txtTrDay"
        Me.txtTrDay.OutputFormat = resources.GetString("txtTrDay.OutputFormat")
        Me.txtTrDay.Style = "ddo-char-set: 0; text-align: center; font-size: 6pt; vertical-align: middle; "
        Me.txtTrDay.Text = Nothing
        Me.txtTrDay.Top = 0!
        Me.txtTrDay.Width = 0.8125!
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
        Me.TextBox14.Left = 0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: right; background-color: Gainsboro; font-size: 6pt; " &
    "vertical-align: middle; "
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0!
        Me.TextBox14.Visible = False
        Me.TextBox14.Width = 0.8125!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.8125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-size: 6pt; vertical-align: middle; "
        Me.Label1.Text = "Amount"
        Me.Label1.Top = 0!
        Me.Label1.Visible = False
        Me.Label1.Width = 0.625!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6, Me.txtSIHeader})
        Me.GroupHeader1.Height = 0.3125!
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
        Me.TextBox6.Height = 0.3125!
        Me.TextBox6.Left = 0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: center; background-color: DarkGray; font-size: 6pt; " &
    "vertical-align: middle; "
        Me.TextBox6.Text = "DATE"
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 0.8125!
        '
        'txtSIHeader
        '
        Me.txtSIHeader.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSIHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSIHeader.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSIHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSIHeader.Border.RightColor = System.Drawing.Color.Black
        Me.txtSIHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSIHeader.Border.TopColor = System.Drawing.Color.Black
        Me.txtSIHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSIHeader.Height = 0.3125!
        Me.txtSIHeader.HyperLink = Nothing
        Me.txtSIHeader.Left = 0.1875!
        Me.txtSIHeader.Name = "txtSIHeader"
        Me.txtSIHeader.Style = "ddo-char-set: 0; text-align: center; font-size: 6pt; vertical-align: middle; "
        Me.txtSIHeader.Text = "txtSIHeader"
        Me.txtSIHeader.Top = 0!
        Me.txtSIHeader.Visible = False
        Me.txtSIHeader.Width = 0.625!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.40625!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rpt_MonthlyPatientCountPerCharging
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.25!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.98958!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonthOf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSIHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCmpName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtMonthOf As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTrDay As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSIHeader As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Picture2 As DataDynamics.ActiveReports.Picture
End Class
