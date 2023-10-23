<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_DailyRpt_MedicineIssuance_ChargingSummary 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_DailyRpt_MedicineIssuance_ChargingSummary))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox()
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.txtFrom = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txtgrpCharging = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.txtgrpInhouse = New DataDynamics.ActiveReports.TextBox()
        Me.txtgrpconsign = New DataDynamics.ActiveReports.TextBox()
        Me.txtgrpTotal = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.txtChargingID = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubInhouse = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubConsig = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubTotalAmt = New DataDynamics.ActiveReports.TextBox()
        Me.PageBreak1 = New DataDynamics.ActiveReports.PageBreak()
        Me.GroupHeader3 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.txtInhouseAmt = New DataDynamics.ActiveReports.TextBox()
        Me.txtConsignAmt = New DataDynamics.ActiveReports.TextBox()
        Me.txtTotalAmt = New DataDynamics.ActiveReports.TextBox()
        Me.txtPatient_id = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter3 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.Picture2 = New DataDynamics.ActiveReports.Picture()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrpCharging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrpInhouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrpconsign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrpTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChargingID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubInhouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubConsig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInhouseAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsignAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatient_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.txtAddress, Me.txtCmpName, Me.TextBox1, Me.TextBox4, Me.txtFrom, Me.Label1, Me.Label2, Me.Picture1, Me.Picture2})
        Me.PageHeader1.Height = 1.275!
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
        Me.TextBox2.Text = "SUMMARY OF DRUGS AND MEDICINE ISSUED( Per Patient)"
        Me.TextBox2.Top = 0.6875!
        Me.TextBox2.Width = 7.25!
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
        Me.txtAddress.Width = 7.1875!
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
        Me.txtCmpName.Width = 7.25!
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
        Me.TextBox1.Top = 1.0!
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
        Me.TextBox4.Top = 1.0!
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
        Me.txtFrom.Top = 1.0!
        Me.txtFrom.Width = 2.5!
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
        Me.Label1.Left = 0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; vertical" &
    "-align: middle; "
        Me.Label1.Text = "EVERSLEY CHILDS SANITARIUM AND GENERAL HOSPITAL"
        Me.Label1.Top = 0.1875!
        Me.Label1.Width = 7.1875!
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
        Me.Label2.Left = 0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 9.75pt; "
        Me.Label2.Text = "North Road, Jagobiao, Mandaue City, Cebu 6014"
        Me.Label2.Top = 0.4375!
        Me.Label2.Width = 7.25!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Height = 0!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtgrpCharging, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox13, Me.TextBox15, Me.txtgrpInhouse, Me.txtgrpconsign, Me.txtgrpTotal})
        Me.GroupFooter1.Height = 1.84375!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtgrpCharging
        '
        Me.txtgrpCharging.Border.BottomColor = System.Drawing.Color.Black
        Me.txtgrpCharging.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpCharging.Border.LeftColor = System.Drawing.Color.Black
        Me.txtgrpCharging.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpCharging.Border.RightColor = System.Drawing.Color.Black
        Me.txtgrpCharging.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpCharging.Border.TopColor = System.Drawing.Color.Black
        Me.txtgrpCharging.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpCharging.Height = 0.1875!
        Me.txtgrpCharging.Left = 0!
        Me.txtgrpCharging.Name = "txtgrpCharging"
        Me.txtgrpCharging.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.txtgrpCharging.Text = "CHARGING"
        Me.txtgrpCharging.Top = 0.375!
        Me.txtgrpCharging.Visible = False
        Me.txtgrpCharging.Width = 2.75!
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
        Me.TextBox9.Left = 0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox9.Text = "SUMMARY OF DRUGS AND MEDICINE ISSUED"
        Me.TextBox9.Top = 0!
        Me.TextBox9.Visible = False
        Me.TextBox9.Width = 7.25!
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
        Me.TextBox10.Left = 0!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox10.Text = "CHARGING"
        Me.TextBox10.Top = 0.1875!
        Me.TextBox10.Visible = False
        Me.TextBox10.Width = 2.75!
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
        Me.TextBox11.Left = 2.75!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox11.Text = "IN-HOUSE"
        Me.TextBox11.Top = 0.1875!
        Me.TextBox11.Visible = False
        Me.TextBox11.Width = 1.5!
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
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 4.25!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox13.Text = "CONSIGNMENT"
        Me.TextBox13.Top = 0.1875!
        Me.TextBox13.Visible = False
        Me.TextBox13.Width = 1.5!
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
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 5.75!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox15.Text = "TOTAL"
        Me.TextBox15.Top = 0.1875!
        Me.TextBox15.Visible = False
        Me.TextBox15.Width = 1.5!
        '
        'txtgrpInhouse
        '
        Me.txtgrpInhouse.Border.BottomColor = System.Drawing.Color.Black
        Me.txtgrpInhouse.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpInhouse.Border.LeftColor = System.Drawing.Color.Black
        Me.txtgrpInhouse.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpInhouse.Border.RightColor = System.Drawing.Color.Black
        Me.txtgrpInhouse.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpInhouse.Border.TopColor = System.Drawing.Color.Black
        Me.txtgrpInhouse.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpInhouse.Height = 0.1875!
        Me.txtgrpInhouse.Left = 2.75!
        Me.txtgrpInhouse.Name = "txtgrpInhouse"
        Me.txtgrpInhouse.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.txtgrpInhouse.Text = "IN-HOUSE"
        Me.txtgrpInhouse.Top = 0.375!
        Me.txtgrpInhouse.Visible = False
        Me.txtgrpInhouse.Width = 1.5!
        '
        'txtgrpconsign
        '
        Me.txtgrpconsign.Border.BottomColor = System.Drawing.Color.Black
        Me.txtgrpconsign.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpconsign.Border.LeftColor = System.Drawing.Color.Black
        Me.txtgrpconsign.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpconsign.Border.RightColor = System.Drawing.Color.Black
        Me.txtgrpconsign.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpconsign.Border.TopColor = System.Drawing.Color.Black
        Me.txtgrpconsign.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpconsign.Height = 0.1875!
        Me.txtgrpconsign.Left = 4.25!
        Me.txtgrpconsign.Name = "txtgrpconsign"
        Me.txtgrpconsign.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.txtgrpconsign.Text = "CONSIGNMENT"
        Me.txtgrpconsign.Top = 0.375!
        Me.txtgrpconsign.Visible = False
        Me.txtgrpconsign.Width = 1.5!
        '
        'txtgrpTotal
        '
        Me.txtgrpTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtgrpTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtgrpTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtgrpTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtgrpTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtgrpTotal.Height = 0.1875!
        Me.txtgrpTotal.Left = 5.75!
        Me.txtgrpTotal.Name = "txtgrpTotal"
        Me.txtgrpTotal.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.txtgrpTotal.Text = "TOTAL"
        Me.txtgrpTotal.Top = 0.375!
        Me.txtgrpTotal.Visible = False
        Me.txtgrpTotal.Width = 1.5!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox12, Me.txtChargingID, Me.TextBox6, Me.TextBox5, Me.TextBox8, Me.TextBox3})
        Me.GroupHeader2.DataField = "chargingid"
        Me.GroupHeader2.Height = 0.375!
        Me.GroupHeader2.Name = "GroupHeader2"
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
        Me.TextBox12.DataField = "charging"
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 0!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox12.Text = "charging"
        Me.TextBox12.Top = 0!
        Me.TextBox12.Width = 7.25!
        '
        'txtChargingID
        '
        Me.txtChargingID.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChargingID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtChargingID.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChargingID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtChargingID.Border.RightColor = System.Drawing.Color.Black
        Me.txtChargingID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtChargingID.Border.TopColor = System.Drawing.Color.Black
        Me.txtChargingID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtChargingID.CanGrow = False
        Me.txtChargingID.DataField = "chargingid"
        Me.txtChargingID.Height = 0.1875!
        Me.txtChargingID.Left = 5.75!
        Me.txtChargingID.Name = "txtChargingID"
        Me.txtChargingID.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; vertical-align: middle; "
        Me.txtChargingID.Text = Nothing
        Me.txtChargingID.Top = 0!
        Me.txtChargingID.Visible = False
        Me.txtChargingID.Width = 1.5!
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
        Me.TextBox6.Left = 0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox6.Text = "PATIENT"
        Me.TextBox6.Top = 0.1875!
        Me.TextBox6.Width = 2.75!
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
        Me.TextBox5.Left = 2.75!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox5.Text = "IN-HOUSE"
        Me.TextBox5.Top = 0.1875!
        Me.TextBox5.Width = 1.5!
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
        Me.TextBox8.Left = 4.25!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox8.Text = "CONSIGNMENT"
        Me.TextBox8.Top = 0.1875!
        Me.TextBox8.Width = 1.5!
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
        Me.TextBox3.Left = 5.75!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox3.Text = "TOTAL"
        Me.TextBox3.Top = 0.1875!
        Me.TextBox3.Width = 1.5!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox14, Me.txtSubInhouse, Me.txtSubConsig, Me.txtSubTotalAmt, Me.PageBreak1})
        Me.GroupFooter2.Height = 0.3333333!
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
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox14.Text = "Sub Total"
        Me.TextBox14.Top = 0!
        Me.TextBox14.Width = 2.75!
        '
        'txtSubInhouse
        '
        Me.txtSubInhouse.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubInhouse.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubInhouse.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubInhouse.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubInhouse.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubInhouse.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubInhouse.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubInhouse.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubInhouse.Height = 0.1875!
        Me.txtSubInhouse.Left = 2.75!
        Me.txtSubInhouse.Name = "txtSubInhouse"
        Me.txtSubInhouse.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.txtSubInhouse.Text = Nothing
        Me.txtSubInhouse.Top = 0!
        Me.txtSubInhouse.Width = 1.5!
        '
        'txtSubConsig
        '
        Me.txtSubConsig.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubConsig.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubConsig.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubConsig.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubConsig.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubConsig.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubConsig.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubConsig.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubConsig.Height = 0.1875!
        Me.txtSubConsig.Left = 4.25!
        Me.txtSubConsig.Name = "txtSubConsig"
        Me.txtSubConsig.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.txtSubConsig.Text = Nothing
        Me.txtSubConsig.Top = 0!
        Me.txtSubConsig.Width = 1.5!
        '
        'txtSubTotalAmt
        '
        Me.txtSubTotalAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubTotalAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubTotalAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubTotalAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubTotalAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalAmt.Height = 0.1875!
        Me.txtSubTotalAmt.Left = 5.75!
        Me.txtSubTotalAmt.Name = "txtSubTotalAmt"
        Me.txtSubTotalAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.txtSubTotalAmt.Text = Nothing
        Me.txtSubTotalAmt.Top = 0!
        Me.txtSubTotalAmt.Width = 1.5!
        '
        'PageBreak1
        '
        Me.PageBreak1.Border.BottomColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Border.LeftColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Border.RightColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Border.TopColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Height = 0.0625!
        Me.PageBreak1.Left = 0!
        Me.PageBreak1.Name = "PageBreak1"
        Me.PageBreak1.Size = New System.Drawing.SizeF(7.258332!, 0.0625!)
        Me.PageBreak1.Top = 0.3125!
        Me.PageBreak1.Width = 7.258332!
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox7, Me.txtInhouseAmt, Me.txtConsignAmt, Me.txtTotalAmt, Me.txtPatient_id})
        Me.GroupHeader3.DataField = "patient_id"
        Me.GroupHeader3.Height = 0.1770833!
        Me.GroupHeader3.Name = "GroupHeader3"
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
        Me.TextBox7.DataField = "patient_name"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox7.Text = "PATIENT"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 2.75!
        '
        'txtInhouseAmt
        '
        Me.txtInhouseAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtInhouseAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInhouseAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtInhouseAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInhouseAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtInhouseAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInhouseAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtInhouseAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtInhouseAmt.CanGrow = False
        Me.txtInhouseAmt.DataField = "fund_class"
        Me.txtInhouseAmt.Height = 0.1875!
        Me.txtInhouseAmt.Left = 2.75!
        Me.txtInhouseAmt.Name = "txtInhouseAmt"
        Me.txtInhouseAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.txtInhouseAmt.Text = Nothing
        Me.txtInhouseAmt.Top = 0!
        Me.txtInhouseAmt.Width = 1.5!
        '
        'txtConsignAmt
        '
        Me.txtConsignAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtConsignAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtConsignAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtConsignAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtConsignAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtConsignAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtConsignAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtConsignAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtConsignAmt.CanGrow = False
        Me.txtConsignAmt.DataField = "tr_amount"
        Me.txtConsignAmt.Height = 0.1875!
        Me.txtConsignAmt.Left = 4.25!
        Me.txtConsignAmt.Name = "txtConsignAmt"
        Me.txtConsignAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.txtConsignAmt.Text = Nothing
        Me.txtConsignAmt.Top = 0!
        Me.txtConsignAmt.Width = 1.5!
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalAmt.CanGrow = False
        Me.txtTotalAmt.Height = 0.1875!
        Me.txtTotalAmt.Left = 5.75!
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.txtTotalAmt.Text = Nothing
        Me.txtTotalAmt.Top = 0!
        Me.txtTotalAmt.Width = 1.5!
        '
        'txtPatient_id
        '
        Me.txtPatient_id.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPatient_id.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPatient_id.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPatient_id.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPatient_id.Border.RightColor = System.Drawing.Color.Black
        Me.txtPatient_id.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPatient_id.Border.TopColor = System.Drawing.Color.Black
        Me.txtPatient_id.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPatient_id.CanGrow = False
        Me.txtPatient_id.DataField = "patient_id"
        Me.txtPatient_id.Height = 0.1875!
        Me.txtPatient_id.Left = 7.25!
        Me.txtPatient_id.Name = "txtPatient_id"
        Me.txtPatient_id.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; vertical-align: middle; "
        Me.txtPatient_id.Text = Nothing
        Me.txtPatient_id.Top = 0!
        Me.txtPatient_id.Visible = False
        Me.txtPatient_id.Width = 1.1875!
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Height = 0!
        Me.GroupFooter3.Name = "GroupFooter3"
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
        Me.Picture1.Left = 0.0625!
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
        Me.Picture2.Left = 6.25!
        Me.Picture2.LineWeight = 0!
        Me.Picture2.Name = "Picture2"
        Me.Picture2.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture2.Top = 0!
        Me.Picture2.Width = 0.8125!
        '
        'rpt_DailyRpt_MedicineIssuance_ChargingSummary
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.258332!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.GroupHeader3)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter3)
        Me.Sections.Add(Me.GroupFooter2)
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
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrpCharging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrpInhouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrpconsign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrpTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChargingID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubInhouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubConsig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInhouseAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsignAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatient_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCmpName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFrom As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtChargingID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSubInhouse As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSubConsig As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSubTotalAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader3 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtInhouseAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtConsignAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPatient_id As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupFooter3 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents PageBreak1 As DataDynamics.ActiveReports.PageBreak
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtgrpCharging As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtgrpInhouse As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtgrpconsign As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtgrpTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Picture2 As DataDynamics.ActiveReports.Picture
End Class
