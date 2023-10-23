<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_MonthlyActualInventoryFundClassification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_MonthlyActualInventoryFundClassification))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.txtFrom = New DataDynamics.ActiveReports.TextBox()
        Me.txtConsigneeName = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.txtConsigneeID = New DataDynamics.ActiveReports.TextBox()
        Me.txtInvMaster = New DataDynamics.ActiveReports.TextBox()
        Me.txtInvMasterSysPK = New DataDynamics.ActiveReports.TextBox()
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox()
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtBegC1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtBegC2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtBegC3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRecC1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRecC2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRecC3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtPOC1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtPOC2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtPOC3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtIssueC1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtIssueC2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtIssueC3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEndC1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEndC2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEndC3 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox32 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox33 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox34 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox35 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox36 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox37 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox38 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox39 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox40 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox41 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox42 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox43 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox44 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtSupplier = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox45 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox46 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox47 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox48 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox49 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox50 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox51 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox52 = New DataDynamics.ActiveReports.TextBox()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.Picture2 = New DataDynamics.ActiveReports.Picture()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsigneeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsigneeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvMasterSysPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBegC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBegC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBegC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssueC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssueC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssueC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox4, Me.txtFrom, Me.txtConsigneeName, Me.TextBox13, Me.txtConsigneeID, Me.txtInvMaster, Me.txtInvMasterSysPK, Me.txtAddress, Me.txtCmpName, Me.TextBox2, Me.Label1, Me.Label2, Me.Picture1, Me.Picture2})
        Me.PageHeader1.Height = 1.933333!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.TextBox1.Text = "DATE"
        Me.TextBox1.Top = 1.4!
        Me.TextBox1.Width = 0.4375!
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
        Me.TextBox4.Left = 0.375!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = ""
        Me.TextBox4.Text = ":"
        Me.TextBox4.Top = 1.4!
        Me.TextBox4.Width = 0.0625!
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
        Me.txtFrom.Left = 0.5!
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Style = ""
        Me.txtFrom.Text = Nothing
        Me.txtFrom.Top = 1.4!
        Me.txtFrom.Width = 2.5!
        '
        'txtConsigneeName
        '
        Me.txtConsigneeName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtConsigneeName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtConsigneeName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeName.Border.RightColor = System.Drawing.Color.Black
        Me.txtConsigneeName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeName.Border.TopColor = System.Drawing.Color.Black
        Me.txtConsigneeName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeName.DataField = "fund_class"
        Me.txtConsigneeName.Height = 0.25!
        Me.txtConsigneeName.Left = 2.125!
        Me.txtConsigneeName.Name = "txtConsigneeName"
        Me.txtConsigneeName.Style = "font-weight: bold; font-size: 12pt; "
        Me.txtConsigneeName.Text = Nothing
        Me.txtConsigneeName.Top = 1.5625!
        Me.txtConsigneeName.Width = 4.125!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Height = 0.25!
        Me.TextBox13.Left = 0!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "text-align: left; font-size: 12pt; vertical-align: middle; "
        Me.TextBox13.Text = "FUND CLASSIFICATION : "
        Me.TextBox13.Top = 1.5625!
        Me.TextBox13.Width = 2.125!
        '
        'txtConsigneeID
        '
        Me.txtConsigneeID.Border.BottomColor = System.Drawing.Color.Black
        Me.txtConsigneeID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeID.Border.LeftColor = System.Drawing.Color.Black
        Me.txtConsigneeID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeID.Border.RightColor = System.Drawing.Color.Black
        Me.txtConsigneeID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeID.Border.TopColor = System.Drawing.Color.Black
        Me.txtConsigneeID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtConsigneeID.DataField = "supcode"
        Me.txtConsigneeID.Height = 0.1875!
        Me.txtConsigneeID.Left = 7.375!
        Me.txtConsigneeID.Name = "txtConsigneeID"
        Me.txtConsigneeID.Style = ""
        Me.txtConsigneeID.Text = Nothing
        Me.txtConsigneeID.Top = 1.3125!
        Me.txtConsigneeID.Visible = False
        Me.txtConsigneeID.Width = 1.75!
        '
        'txtInvMaster
        '
        Me.txtInvMaster.Border.BottomColor = System.Drawing.Color.Black
        Me.txtInvMaster.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMaster.Border.LeftColor = System.Drawing.Color.Black
        Me.txtInvMaster.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMaster.Border.RightColor = System.Drawing.Color.Black
        Me.txtInvMaster.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMaster.Border.TopColor = System.Drawing.Color.Black
        Me.txtInvMaster.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMaster.CanGrow = False
        Me.txtInvMaster.DataField = "a_code"
        Me.txtInvMaster.Height = 0.1875!
        Me.txtInvMaster.Left = 6.375!
        Me.txtInvMaster.Name = "txtInvMaster"
        Me.txtInvMaster.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; vertical-align: middle; "
        Me.txtInvMaster.Text = Nothing
        Me.txtInvMaster.Top = 1.65!
        Me.txtInvMaster.Visible = False
        Me.txtInvMaster.Width = 1.3125!
        '
        'txtInvMasterSysPK
        '
        Me.txtInvMasterSysPK.Border.BottomColor = System.Drawing.Color.Black
        Me.txtInvMasterSysPK.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMasterSysPK.Border.LeftColor = System.Drawing.Color.Black
        Me.txtInvMasterSysPK.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMasterSysPK.Border.RightColor = System.Drawing.Color.Black
        Me.txtInvMasterSysPK.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMasterSysPK.Border.TopColor = System.Drawing.Color.Black
        Me.txtInvMasterSysPK.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInvMasterSysPK.CanGrow = False
        Me.txtInvMasterSysPK.DataField = "SysPK"
        Me.txtInvMasterSysPK.Height = 0.1875!
        Me.txtInvMasterSysPK.Left = 7.8125!
        Me.txtInvMasterSysPK.Name = "txtInvMasterSysPK"
        Me.txtInvMasterSysPK.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; vertical-align: middle; "
        Me.txtInvMasterSysPK.Text = Nothing
        Me.txtInvMasterSysPK.Top = 1.65!
        Me.txtInvMasterSysPK.Visible = False
        Me.txtInvMasterSysPK.Width = 1.25!
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
        Me.txtAddress.Left = 2.625!
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Style = "text-align: center; "
        Me.txtAddress.Text = "Address"
        Me.txtAddress.Top = 0.0625!
        Me.txtAddress.Visible = False
        Me.txtAddress.Width = 0.0625!
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
        Me.txtCmpName.Left = 1.5625!
        Me.txtCmpName.Name = "txtCmpName"
        Me.txtCmpName.Style = "ddo-char-set: 0; text-align: center; font-size: 12pt; "
        Me.txtCmpName.Text = "Company Name"
        Me.txtCmpName.Top = 0.0625!
        Me.txtCmpName.Visible = False
        Me.txtCmpName.Width = 1.0!
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
        Me.TextBox2.Height = 0.375!
        Me.TextBox2.Left = 0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; text-dec" &
    "oration: underline; vertical-align: middle; "
        Me.TextBox2.Text = "DETAILED INVENTORY PER SUPPLIER FOR THE MONTH OF "
        Me.TextBox2.Top = 0.875!
        Me.TextBox2.Width = 10.875!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.3125!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.5625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; vertical" &
    "-align: middle; "
        Me.Label1.Text = "EVERSLEY CHILDS SANITARIUM AND GENERAL HOSPITAL"
        Me.Label1.Top = 0.125!
        Me.Label1.Width = 7.8125!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.5625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 9.75pt; "
        Me.Label2.Text = "North Road, Jagobiao, Mandaue City, Cebu 6014"
        Me.Label2.Top = 0.4375!
        Me.Label2.Width = 7.8125!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.txtBegC1, Me.txtBegC2, Me.txtBegC3, Me.txtRecC1, Me.txtRecC2, Me.txtRecC3, Me.txtPOC1, Me.txtPOC2, Me.txtPOC3, Me.txtIssueC1, Me.txtIssueC2, Me.txtIssueC3, Me.txtEndC1, Me.txtEndC2, Me.txtEndC3})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
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
        Me.TextBox3.CanGrow = False
        Me.TextBox3.DataField = "a_name"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 0!
        Me.TextBox3.MultiLine = False
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: left; font-size: 6.75pt; vertical-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 1.875!
        '
        'txtBegC1
        '
        Me.txtBegC1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBegC1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBegC1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC1.Border.RightColor = System.Drawing.Color.Black
        Me.txtBegC1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC1.Border.TopColor = System.Drawing.Color.Black
        Me.txtBegC1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC1.CanGrow = False
        Me.txtBegC1.DataField = "begQty"
        Me.txtBegC1.Height = 0.1875!
        Me.txtBegC1.Left = 1.875!
        Me.txtBegC1.Name = "txtBegC1"
        Me.txtBegC1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" &
    "tical-align: middle; "
        Me.txtBegC1.Text = Nothing
        Me.txtBegC1.Top = 0!
        Me.txtBegC1.Width = 0.4375!
        '
        'txtBegC2
        '
        Me.txtBegC2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBegC2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBegC2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC2.Border.RightColor = System.Drawing.Color.Black
        Me.txtBegC2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC2.Border.TopColor = System.Drawing.Color.Black
        Me.txtBegC2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC2.CanGrow = False
        Me.txtBegC2.DataField = "begPrice"
        Me.txtBegC2.Height = 0.1875!
        Me.txtBegC2.Left = 2.3125!
        Me.txtBegC2.Name = "txtBegC2"
        Me.txtBegC2.OutputFormat = resources.GetString("txtBegC2.OutputFormat")
        Me.txtBegC2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtBegC2.Text = Nothing
        Me.txtBegC2.Top = 0!
        Me.txtBegC2.Width = 0.6875!
        '
        'txtBegC3
        '
        Me.txtBegC3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBegC3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBegC3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC3.Border.RightColor = System.Drawing.Color.Black
        Me.txtBegC3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC3.Border.TopColor = System.Drawing.Color.Black
        Me.txtBegC3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBegC3.CanGrow = False
        Me.txtBegC3.DataField = "begTotalCost"
        Me.txtBegC3.Height = 0.1875!
        Me.txtBegC3.Left = 3.0!
        Me.txtBegC3.Name = "txtBegC3"
        Me.txtBegC3.OutputFormat = resources.GetString("txtBegC3.OutputFormat")
        Me.txtBegC3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtBegC3.Text = Nothing
        Me.txtBegC3.Top = 0!
        Me.txtBegC3.Width = 0.6875!
        '
        'txtRecC1
        '
        Me.txtRecC1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRecC1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRecC1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC1.Border.RightColor = System.Drawing.Color.Black
        Me.txtRecC1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC1.Border.TopColor = System.Drawing.Color.Black
        Me.txtRecC1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC1.CanGrow = False
        Me.txtRecC1.DataField = "recQty"
        Me.txtRecC1.Height = 0.1875!
        Me.txtRecC1.Left = 3.6875!
        Me.txtRecC1.Name = "txtRecC1"
        Me.txtRecC1.OutputFormat = resources.GetString("txtRecC1.OutputFormat")
        Me.txtRecC1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" &
    "tical-align: middle; "
        Me.txtRecC1.Text = Nothing
        Me.txtRecC1.Top = 0!
        Me.txtRecC1.Width = 0.4375!
        '
        'txtRecC2
        '
        Me.txtRecC2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRecC2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRecC2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC2.Border.RightColor = System.Drawing.Color.Black
        Me.txtRecC2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC2.Border.TopColor = System.Drawing.Color.Black
        Me.txtRecC2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC2.CanGrow = False
        Me.txtRecC2.DataField = "recPrice"
        Me.txtRecC2.Height = 0.1875!
        Me.txtRecC2.Left = 4.125!
        Me.txtRecC2.Name = "txtRecC2"
        Me.txtRecC2.OutputFormat = resources.GetString("txtRecC2.OutputFormat")
        Me.txtRecC2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtRecC2.Text = Nothing
        Me.txtRecC2.Top = 0!
        Me.txtRecC2.Width = 0.6875!
        '
        'txtRecC3
        '
        Me.txtRecC3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRecC3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRecC3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC3.Border.RightColor = System.Drawing.Color.Black
        Me.txtRecC3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC3.Border.TopColor = System.Drawing.Color.Black
        Me.txtRecC3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRecC3.CanGrow = False
        Me.txtRecC3.DataField = "recTotalCost"
        Me.txtRecC3.Height = 0.1875!
        Me.txtRecC3.Left = 4.8125!
        Me.txtRecC3.Name = "txtRecC3"
        Me.txtRecC3.OutputFormat = resources.GetString("txtRecC3.OutputFormat")
        Me.txtRecC3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtRecC3.Text = Nothing
        Me.txtRecC3.Top = 0!
        Me.txtRecC3.Width = 0.6875!
        '
        'txtPOC1
        '
        Me.txtPOC1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPOC1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPOC1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPOC1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPOC1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC1.CanGrow = False
        Me.txtPOC1.DataField = "pullQty"
        Me.txtPOC1.Height = 0.1875!
        Me.txtPOC1.Left = 5.5!
        Me.txtPOC1.Name = "txtPOC1"
        Me.txtPOC1.OutputFormat = resources.GetString("txtPOC1.OutputFormat")
        Me.txtPOC1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" &
    "tical-align: middle; "
        Me.txtPOC1.Text = Nothing
        Me.txtPOC1.Top = 0!
        Me.txtPOC1.Width = 0.4375!
        '
        'txtPOC2
        '
        Me.txtPOC2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPOC2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPOC2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC2.Border.RightColor = System.Drawing.Color.Black
        Me.txtPOC2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC2.Border.TopColor = System.Drawing.Color.Black
        Me.txtPOC2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC2.CanGrow = False
        Me.txtPOC2.DataField = "pullPrice"
        Me.txtPOC2.Height = 0.1875!
        Me.txtPOC2.Left = 5.9375!
        Me.txtPOC2.Name = "txtPOC2"
        Me.txtPOC2.OutputFormat = resources.GetString("txtPOC2.OutputFormat")
        Me.txtPOC2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtPOC2.Text = Nothing
        Me.txtPOC2.Top = 0!
        Me.txtPOC2.Width = 0.6875!
        '
        'txtPOC3
        '
        Me.txtPOC3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPOC3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPOC3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC3.Border.RightColor = System.Drawing.Color.Black
        Me.txtPOC3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC3.Border.TopColor = System.Drawing.Color.Black
        Me.txtPOC3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPOC3.CanGrow = False
        Me.txtPOC3.DataField = "pullTotalCost"
        Me.txtPOC3.Height = 0.1875!
        Me.txtPOC3.Left = 6.625!
        Me.txtPOC3.Name = "txtPOC3"
        Me.txtPOC3.OutputFormat = resources.GetString("txtPOC3.OutputFormat")
        Me.txtPOC3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtPOC3.Text = Nothing
        Me.txtPOC3.Top = 0!
        Me.txtPOC3.Width = 0.6875!
        '
        'txtIssueC1
        '
        Me.txtIssueC1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtIssueC1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtIssueC1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC1.Border.RightColor = System.Drawing.Color.Black
        Me.txtIssueC1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC1.Border.TopColor = System.Drawing.Color.Black
        Me.txtIssueC1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC1.CanGrow = False
        Me.txtIssueC1.DataField = "soldQty"
        Me.txtIssueC1.Height = 0.1875!
        Me.txtIssueC1.Left = 7.3125!
        Me.txtIssueC1.Name = "txtIssueC1"
        Me.txtIssueC1.OutputFormat = resources.GetString("txtIssueC1.OutputFormat")
        Me.txtIssueC1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" &
    "tical-align: middle; "
        Me.txtIssueC1.Text = Nothing
        Me.txtIssueC1.Top = 0!
        Me.txtIssueC1.Width = 0.4375!
        '
        'txtIssueC2
        '
        Me.txtIssueC2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtIssueC2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtIssueC2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC2.Border.RightColor = System.Drawing.Color.Black
        Me.txtIssueC2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC2.Border.TopColor = System.Drawing.Color.Black
        Me.txtIssueC2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC2.CanGrow = False
        Me.txtIssueC2.DataField = "soldPrice"
        Me.txtIssueC2.Height = 0.1875!
        Me.txtIssueC2.Left = 7.75!
        Me.txtIssueC2.Name = "txtIssueC2"
        Me.txtIssueC2.OutputFormat = resources.GetString("txtIssueC2.OutputFormat")
        Me.txtIssueC2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtIssueC2.Text = Nothing
        Me.txtIssueC2.Top = 0!
        Me.txtIssueC2.Width = 0.6875!
        '
        'txtIssueC3
        '
        Me.txtIssueC3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtIssueC3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtIssueC3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC3.Border.RightColor = System.Drawing.Color.Black
        Me.txtIssueC3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC3.Border.TopColor = System.Drawing.Color.Black
        Me.txtIssueC3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssueC3.CanGrow = False
        Me.txtIssueC3.DataField = "soldTotalCost"
        Me.txtIssueC3.Height = 0.1875!
        Me.txtIssueC3.Left = 8.4375!
        Me.txtIssueC3.Name = "txtIssueC3"
        Me.txtIssueC3.OutputFormat = resources.GetString("txtIssueC3.OutputFormat")
        Me.txtIssueC3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtIssueC3.Text = Nothing
        Me.txtIssueC3.Top = 0!
        Me.txtIssueC3.Width = 0.6875!
        '
        'txtEndC1
        '
        Me.txtEndC1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtEndC1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtEndC1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC1.Border.RightColor = System.Drawing.Color.Black
        Me.txtEndC1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC1.Border.TopColor = System.Drawing.Color.Black
        Me.txtEndC1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC1.CanGrow = False
        Me.txtEndC1.DataField = "endQty"
        Me.txtEndC1.Height = 0.1875!
        Me.txtEndC1.Left = 9.125!
        Me.txtEndC1.Name = "txtEndC1"
        Me.txtEndC1.OutputFormat = resources.GetString("txtEndC1.OutputFormat")
        Me.txtEndC1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" &
    "tical-align: middle; "
        Me.txtEndC1.Text = Nothing
        Me.txtEndC1.Top = 0!
        Me.txtEndC1.Width = 0.4375!
        '
        'txtEndC2
        '
        Me.txtEndC2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtEndC2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtEndC2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC2.Border.RightColor = System.Drawing.Color.Black
        Me.txtEndC2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC2.Border.TopColor = System.Drawing.Color.Black
        Me.txtEndC2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC2.CanGrow = False
        Me.txtEndC2.DataField = "endPrice"
        Me.txtEndC2.Height = 0.1875!
        Me.txtEndC2.Left = 9.5625!
        Me.txtEndC2.Name = "txtEndC2"
        Me.txtEndC2.OutputFormat = resources.GetString("txtEndC2.OutputFormat")
        Me.txtEndC2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtEndC2.Text = Nothing
        Me.txtEndC2.Top = 0!
        Me.txtEndC2.Width = 0.6875!
        '
        'txtEndC3
        '
        Me.txtEndC3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtEndC3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtEndC3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC3.Border.RightColor = System.Drawing.Color.Black
        Me.txtEndC3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC3.Border.TopColor = System.Drawing.Color.Black
        Me.txtEndC3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtEndC3.CanGrow = False
        Me.txtEndC3.DataField = "endTotalCost"
        Me.txtEndC3.Height = 0.1875!
        Me.txtEndC3.Left = 10.25!
        Me.txtEndC3.Name = "txtEndC3"
        Me.txtEndC3.OutputFormat = resources.GetString("txtEndC3.OutputFormat")
        Me.txtEndC3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" &
    "ical-align: middle; "
        Me.txtEndC3.Text = Nothing
        Me.txtEndC3.Top = 0!
        Me.txtEndC3.Width = 0.6875!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
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
        Me.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount} on {RunDateTime}"
        Me.ReportInfo1.Height = 0.1875!
        Me.ReportInfo1.Left = 0!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "text-align: center; "
        Me.ReportInfo1.Top = 0!
        Me.ReportInfo1.Width = 10.875!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox5, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28})
        Me.GroupHeader1.Height = 0.6875!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPage
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
        Me.TextBox6.Height = 0.6875!
        Me.TextBox6.Left = 0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: DarkGra" &
    "y; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox6.Text = "NAME OF DRUGS/STRENGTH"
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 1.875!
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
        Me.TextBox21.Height = 0.3041667!
        Me.TextBox21.Left = 9.125!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: DarkGra" &
    "y; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox21.Text = "ENDING BALANCE"
        Me.TextBox21.Top = 0!
        Me.TextBox21.Width = 1.8125!
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
        Me.TextBox22.Height = 0.4375!
        Me.TextBox22.Left = 9.125!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox22.Text = "# Of Units"
        Me.TextBox22.Top = 0.25!
        Me.TextBox22.Width = 0.4375!
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
        Me.TextBox23.Height = 0.4375!
        Me.TextBox23.Left = 9.5625!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox23.Text = "Unit Price"
        Me.TextBox23.Top = 0.25!
        Me.TextBox23.Width = 0.6875!
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
        Me.TextBox24.Height = 0.4375!
        Me.TextBox24.Left = 10.25!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox24.Text = "Total COST"
        Me.TextBox24.Top = 0.25!
        Me.TextBox24.Width = 0.6875!
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
        Me.TextBox5.Height = 0.3041667!
        Me.TextBox5.Left = 7.3125!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: DarkGra" &
    "y; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox5.Text = "ISSUANCE"
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 1.8125!
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
        Me.TextBox7.Height = 0.4375!
        Me.TextBox7.Left = 7.3125!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox7.Text = "# Of Units"
        Me.TextBox7.Top = 0.25!
        Me.TextBox7.Width = 0.4375!
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
        Me.TextBox8.Height = 0.4375!
        Me.TextBox8.Left = 7.75!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox8.Text = "Unit Price"
        Me.TextBox8.Top = 0.25!
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
        Me.TextBox9.Height = 0.4375!
        Me.TextBox9.Left = 8.4375!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox9.Text = "Total COST"
        Me.TextBox9.Top = 0.25!
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
        Me.TextBox10.Height = 0.3041667!
        Me.TextBox10.Left = 5.5!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: DarkGra" &
    "y; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox10.Text = "PULLED-OUT"
        Me.TextBox10.Top = 0!
        Me.TextBox10.Width = 1.8125!
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
        Me.TextBox11.Height = 0.4375!
        Me.TextBox11.Left = 5.5!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox11.Text = "# Of Units"
        Me.TextBox11.Top = 0.25!
        Me.TextBox11.Width = 0.4375!
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
        Me.TextBox12.Height = 0.4375!
        Me.TextBox12.Left = 5.9375!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox12.Text = "Unit Price"
        Me.TextBox12.Top = 0.25!
        Me.TextBox12.Width = 0.6875!
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
        Me.TextBox16.Height = 0.4375!
        Me.TextBox16.Left = 6.625!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox16.Text = "Total COST"
        Me.TextBox16.Top = 0.25!
        Me.TextBox16.Width = 0.6875!
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
        Me.TextBox17.Height = 0.3041667!
        Me.TextBox17.Left = 3.6875!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: DarkGra" &
    "y; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox17.Text = "RECIEVED"
        Me.TextBox17.Top = 0!
        Me.TextBox17.Width = 1.8125!
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
        Me.TextBox18.Height = 0.4375!
        Me.TextBox18.Left = 3.6875!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox18.Text = "# Of Units"
        Me.TextBox18.Top = 0.25!
        Me.TextBox18.Width = 0.4375!
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
        Me.TextBox19.Height = 0.4375!
        Me.TextBox19.Left = 4.125!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox19.Text = "Unit Price"
        Me.TextBox19.Top = 0.25!
        Me.TextBox19.Width = 0.6875!
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
        Me.TextBox20.Height = 0.4375!
        Me.TextBox20.Left = 4.8125!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox20.Text = "Total COST"
        Me.TextBox20.Top = 0.25!
        Me.TextBox20.Width = 0.6875!
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
        Me.TextBox25.Height = 0.3041667!
        Me.TextBox25.Left = 1.875!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: DarkGra" &
    "y; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox25.Text = "BEGINNING BALANCE"
        Me.TextBox25.Top = 0!
        Me.TextBox25.Width = 1.8125!
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
        Me.TextBox26.Height = 0.4375!
        Me.TextBox26.Left = 1.875!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox26.Text = "# Of Units"
        Me.TextBox26.Top = 0.25!
        Me.TextBox26.Width = 0.4375!
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
        Me.TextBox27.Height = 0.4375!
        Me.TextBox27.Left = 2.3125!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox27.Text = "Unit Price"
        Me.TextBox27.Top = 0.25!
        Me.TextBox27.Width = 0.6875!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Height = 0.4375!
        Me.TextBox28.Left = 3.0!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "ddo-char-set: 0; text-align: center; background-color: Gainsboro; font-size: 8.25" &
    "pt; vertical-align: middle; "
        Me.TextBox28.Text = "Total COST"
        Me.TextBox28.Top = 0.25!
        Me.TextBox28.Width = 0.6875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label4, Me.Label5, Me.Label6})
        Me.GroupFooter1.Height = 0.825!
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
        Me.Label4.Left = 6.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = ""
        Me.Label4.Text = "Certified Correct :"
        Me.Label4.Top = 0.4208333!
        Me.Label4.Width = 1.1875!
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
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 7.25!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = ""
        Me.Label5.Text = "DIANA JANE C. REGIS,  RPh"
        Me.Label5.Top = 0.4208333!
        Me.Label5.Width = 2.0!
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
        Me.Label6.Left = 7.25!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: center; "
        Me.Label6.Text = "Pharmacist I"
        Me.Label6.Top = 0.6708333!
        Me.Label6.Width = 2.0!
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
        Me.TextBox15.Height = 0.2541667!
        Me.TextBox15.Left = 0!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "text-align: right; background-color: Gainsboro; vertical-align: middle; "
        Me.TextBox15.Text = "TOTAL"
        Me.TextBox15.Top = 0!
        Me.TextBox15.Width = 1.875!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.CanGrow = False
        Me.TextBox30.Height = 0.2541667!
        Me.TextBox30.Left = 1.875!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: Gainsbo" &
    "ro; font-size: 8pt; font-family: Calibri; "
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0!
        Me.TextBox30.Width = 0.4375!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.CanGrow = False
        Me.TextBox31.Height = 0.2541667!
        Me.TextBox31.Left = 2.3125!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.OutputFormat = resources.GetString("TextBox31.OutputFormat")
        Me.TextBox31.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 0!
        Me.TextBox31.Width = 0.6875!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.CanGrow = False
        Me.TextBox32.DataField = "begTotalCost"
        Me.TextBox32.Height = 0.2541667!
        Me.TextBox32.Left = 3.0!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.OutputFormat = resources.GetString("TextBox32.OutputFormat")
        Me.TextBox32.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox32.SummaryGroup = "GroupHeader1"
        Me.TextBox32.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox32.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox32.Text = Nothing
        Me.TextBox32.Top = 0!
        Me.TextBox32.Width = 0.6875!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.CanGrow = False
        Me.TextBox33.Height = 0.2541667!
        Me.TextBox33.Left = 3.6875!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.OutputFormat = resources.GetString("TextBox33.OutputFormat")
        Me.TextBox33.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: Gainsbo" &
    "ro; font-size: 8pt; font-family: Calibri; "
        Me.TextBox33.Text = Nothing
        Me.TextBox33.Top = 0!
        Me.TextBox33.Width = 0.4375!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.CanGrow = False
        Me.TextBox34.Height = 0.2541667!
        Me.TextBox34.Left = 4.125!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.OutputFormat = resources.GetString("TextBox34.OutputFormat")
        Me.TextBox34.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox34.Text = Nothing
        Me.TextBox34.Top = 0!
        Me.TextBox34.Width = 0.6875!
        '
        'TextBox35
        '
        Me.TextBox35.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.CanGrow = False
        Me.TextBox35.DataField = "recTotalCost"
        Me.TextBox35.Height = 0.2541667!
        Me.TextBox35.Left = 4.8125!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.OutputFormat = resources.GetString("TextBox35.OutputFormat")
        Me.TextBox35.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox35.SummaryGroup = "GroupHeader1"
        Me.TextBox35.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox35.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox35.Text = Nothing
        Me.TextBox35.Top = 0!
        Me.TextBox35.Width = 0.6875!
        '
        'TextBox36
        '
        Me.TextBox36.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.CanGrow = False
        Me.TextBox36.Height = 0.2541667!
        Me.TextBox36.Left = 5.5!
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.OutputFormat = resources.GetString("TextBox36.OutputFormat")
        Me.TextBox36.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: Gainsbo" &
    "ro; font-size: 8pt; font-family: Calibri; "
        Me.TextBox36.Text = Nothing
        Me.TextBox36.Top = 0!
        Me.TextBox36.Width = 0.4375!
        '
        'TextBox37
        '
        Me.TextBox37.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.CanGrow = False
        Me.TextBox37.Height = 0.2541667!
        Me.TextBox37.Left = 5.9375!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.OutputFormat = resources.GetString("TextBox37.OutputFormat")
        Me.TextBox37.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox37.Text = Nothing
        Me.TextBox37.Top = 0!
        Me.TextBox37.Width = 0.6875!
        '
        'TextBox38
        '
        Me.TextBox38.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.CanGrow = False
        Me.TextBox38.DataField = "pullTotalCost"
        Me.TextBox38.Height = 0.2541667!
        Me.TextBox38.Left = 6.625!
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.OutputFormat = resources.GetString("TextBox38.OutputFormat")
        Me.TextBox38.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox38.SummaryGroup = "GroupHeader1"
        Me.TextBox38.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox38.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox38.Text = Nothing
        Me.TextBox38.Top = 0!
        Me.TextBox38.Width = 0.6875!
        '
        'TextBox39
        '
        Me.TextBox39.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.CanGrow = False
        Me.TextBox39.Height = 0.2541667!
        Me.TextBox39.Left = 7.3125!
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.OutputFormat = resources.GetString("TextBox39.OutputFormat")
        Me.TextBox39.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: Gainsbo" &
    "ro; font-size: 8pt; font-family: Calibri; "
        Me.TextBox39.Text = Nothing
        Me.TextBox39.Top = 0!
        Me.TextBox39.Width = 0.4375!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.CanGrow = False
        Me.TextBox40.Height = 0.2541667!
        Me.TextBox40.Left = 7.75!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.OutputFormat = resources.GetString("TextBox40.OutputFormat")
        Me.TextBox40.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox40.Text = Nothing
        Me.TextBox40.Top = 0!
        Me.TextBox40.Width = 0.6875!
        '
        'TextBox41
        '
        Me.TextBox41.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.CanGrow = False
        Me.TextBox41.DataField = "soldTotalCost"
        Me.TextBox41.Height = 0.2541667!
        Me.TextBox41.Left = 8.4375!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.OutputFormat = resources.GetString("TextBox41.OutputFormat")
        Me.TextBox41.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox41.SummaryGroup = "GroupHeader1"
        Me.TextBox41.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox41.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox41.Text = Nothing
        Me.TextBox41.Top = 0!
        Me.TextBox41.Width = 0.6875!
        '
        'TextBox42
        '
        Me.TextBox42.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.CanGrow = False
        Me.TextBox42.Height = 0.2541667!
        Me.TextBox42.Left = 9.125!
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.OutputFormat = resources.GetString("TextBox42.OutputFormat")
        Me.TextBox42.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: Gainsbo" &
    "ro; font-size: 8pt; font-family: Calibri; "
        Me.TextBox42.Text = Nothing
        Me.TextBox42.Top = 0!
        Me.TextBox42.Width = 0.4375!
        '
        'TextBox43
        '
        Me.TextBox43.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.CanGrow = False
        Me.TextBox43.Height = 0.2541667!
        Me.TextBox43.Left = 9.5625!
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.OutputFormat = resources.GetString("TextBox43.OutputFormat")
        Me.TextBox43.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox43.Text = Nothing
        Me.TextBox43.Top = 0!
        Me.TextBox43.Width = 0.6875!
        '
        'TextBox44
        '
        Me.TextBox44.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.CanGrow = False
        Me.TextBox44.DataField = "endTotalCost"
        Me.TextBox44.Height = 0.2541667!
        Me.TextBox44.Left = 10.25!
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.OutputFormat = resources.GetString("TextBox44.OutputFormat")
        Me.TextBox44.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox44.SummaryGroup = "GroupHeader1"
        Me.TextBox44.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox44.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox44.Text = Nothing
        Me.TextBox44.Top = 0!
        Me.TextBox44.Width = 0.6875!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSupplier})
        Me.GroupHeader2.DataField = "supplier"
        Me.GroupHeader2.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.GroupHeader2.Height = 0.25!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'txtSupplier
        '
        Me.txtSupplier.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSupplier.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSupplier.Border.RightColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSupplier.Border.TopColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSupplier.DataField = "supplier"
        Me.txtSupplier.Height = 0.25!
        Me.txtSupplier.Left = 0!
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Style = "font-weight: bold; font-style: italic; vertical-align: middle; "
        Me.txtSupplier.Text = "TextBox14"
        Me.txtSupplier.Top = 0!
        Me.txtSupplier.Width = 10.9375!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox32, Me.TextBox30, Me.TextBox31, Me.TextBox15, Me.TextBox33, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox14, Me.TextBox29, Me.TextBox45, Me.TextBox46, Me.TextBox47, Me.TextBox48, Me.TextBox49, Me.TextBox50, Me.TextBox51, Me.TextBox52})
        Me.GroupFooter2.Height = 0.2541667!
        Me.GroupFooter2.Name = "GroupFooter2"
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
        Me.TextBox14.Height = 0.2541667!
        Me.TextBox14.Left = 3.6875!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0!
        Me.TextBox14.Width = 0.4375!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.CanGrow = False
        Me.TextBox29.Height = 0.2541667!
        Me.TextBox29.Left = 5.5!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.OutputFormat = resources.GetString("TextBox29.OutputFormat")
        Me.TextBox29.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 0!
        Me.TextBox29.Width = 0.4375!
        '
        'TextBox45
        '
        Me.TextBox45.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.CanGrow = False
        Me.TextBox45.Height = 0.2541667!
        Me.TextBox45.Left = 7.3125!
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.OutputFormat = resources.GetString("TextBox45.OutputFormat")
        Me.TextBox45.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox45.Text = Nothing
        Me.TextBox45.Top = 0!
        Me.TextBox45.Width = 0.4375!
        '
        'TextBox46
        '
        Me.TextBox46.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.CanGrow = False
        Me.TextBox46.Height = 0.2541667!
        Me.TextBox46.Left = 9.125!
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.OutputFormat = resources.GetString("TextBox46.OutputFormat")
        Me.TextBox46.Style = "ddo-char-set: 0; font-weight: bold; background-color: Gainsboro; font-size: 7pt; " &
    "font-family: Calibri; "
        Me.TextBox46.Text = Nothing
        Me.TextBox46.Top = 0!
        Me.TextBox46.Width = 0.4375!
        '
        'TextBox47
        '
        Me.TextBox47.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.CanGrow = False
        Me.TextBox47.Height = 0.2541667!
        Me.TextBox47.Left = 4.125!
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.OutputFormat = resources.GetString("TextBox47.OutputFormat")
        Me.TextBox47.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox47.Text = Nothing
        Me.TextBox47.Top = 0!
        Me.TextBox47.Width = 0.6875!
        '
        'TextBox48
        '
        Me.TextBox48.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.CanGrow = False
        Me.TextBox48.DataField = "recTotalCost"
        Me.TextBox48.Height = 0.2541667!
        Me.TextBox48.Left = 4.8125!
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.OutputFormat = resources.GetString("TextBox48.OutputFormat")
        Me.TextBox48.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox48.SummaryGroup = "GroupHeader1"
        Me.TextBox48.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox48.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox48.Text = Nothing
        Me.TextBox48.Top = 0!
        Me.TextBox48.Width = 0.6875!
        '
        'TextBox49
        '
        Me.TextBox49.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.CanGrow = False
        Me.TextBox49.Height = 0.2541667!
        Me.TextBox49.Left = 5.9375!
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.OutputFormat = resources.GetString("TextBox49.OutputFormat")
        Me.TextBox49.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox49.Text = Nothing
        Me.TextBox49.Top = 0!
        Me.TextBox49.Width = 0.6875!
        '
        'TextBox50
        '
        Me.TextBox50.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox50.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox50.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox50.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox50.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.CanGrow = False
        Me.TextBox50.DataField = "pullTotalCost"
        Me.TextBox50.Height = 0.2541667!
        Me.TextBox50.Left = 6.625!
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.OutputFormat = resources.GetString("TextBox50.OutputFormat")
        Me.TextBox50.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox50.SummaryGroup = "GroupHeader1"
        Me.TextBox50.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox50.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox50.Text = Nothing
        Me.TextBox50.Top = 0!
        Me.TextBox50.Width = 0.6875!
        '
        'TextBox51
        '
        Me.TextBox51.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.CanGrow = False
        Me.TextBox51.Height = 0.2541667!
        Me.TextBox51.Left = 7.75!
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.OutputFormat = resources.GetString("TextBox51.OutputFormat")
        Me.TextBox51.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox51.Text = Nothing
        Me.TextBox51.Top = 0!
        Me.TextBox51.Width = 0.6875!
        '
        'TextBox52
        '
        Me.TextBox52.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox52.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox52.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox52.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox52.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.CanGrow = False
        Me.TextBox52.DataField = "soldTotalCost"
        Me.TextBox52.Height = 0.2541667!
        Me.TextBox52.Left = 8.4375!
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.OutputFormat = resources.GetString("TextBox52.OutputFormat")
        Me.TextBox52.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: Gainsbor" &
    "o; font-size: 8pt; font-family: Calibri; "
        Me.TextBox52.SummaryGroup = "GroupHeader1"
        Me.TextBox52.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox52.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox52.Text = Nothing
        Me.TextBox52.Top = 0!
        Me.TextBox52.Width = 0.6875!
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
        Me.Picture1.Left = 1.8125!
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
        Me.Picture2.Left = 8.25!
        Me.Picture2.LineWeight = 0!
        Me.Picture2.Name = "Picture2"
        Me.Picture2.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture2.Top = 0!
        Me.Picture2.Width = 0.8125!
        '
        'rpt_MonthlyActualInventoryFundClassification
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.25!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.95!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsigneeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsigneeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvMasterSysPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBegC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBegC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBegC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssueC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssueC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssueC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFrom As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtInvMaster As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtConsigneeName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBegC1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBegC2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBegC3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRecC1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRecC2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRecC3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPOC1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPOC2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPOC3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtIssueC1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtIssueC2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtIssueC3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEndC1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEndC2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEndC3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox32 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox33 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox34 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox35 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox36 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox37 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox38 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox39 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox40 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox41 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox42 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox43 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox44 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtInvMasterSysPK As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtConsigneeID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtSupplier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCmpName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Picture2 As DataDynamics.ActiveReports.Picture
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox45 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox46 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox47 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox48 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox49 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox50 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox51 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox52 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
End Class
