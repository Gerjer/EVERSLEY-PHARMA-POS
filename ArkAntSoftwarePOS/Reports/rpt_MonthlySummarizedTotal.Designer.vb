<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_MonthlySummarizedTotal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_MonthlySummarizedTotal))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox()
        Me.txtCmpName = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.txtMonthOf = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.txtChargingID = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubTotalInhouse = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubTotalConsign = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubTotalTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.Picture2 = New DataDynamics.ActiveReports.Picture()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonthOf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChargingID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalInhouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalConsign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.txtAddress, Me.txtCmpName, Me.TextBox1, Me.TextBox4, Me.txtMonthOf, Me.TextBox7, Me.TextBox3, Me.TextBox5, Me.TextBox6, Me.Label7, Me.Label8, Me.Picture1, Me.Picture2})
        Me.PageHeader1.Height = 2.1875!
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
        Me.TextBox2.Style = "ddo-char-set: 0; text-decoration: underline; text-align: center; font-size: 9.75p" &
    "t; "
        Me.TextBox2.Text = "SUMMARY OF DRUGS AND MEDICINES"
        Me.TextBox2.Top = 0.875!
        Me.TextBox2.Width = 7.9375!
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
        Me.txtAddress.Width = 7.9375!
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
        Me.txtCmpName.Width = 7.9375!
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
        Me.TextBox1.Top = 1.375!
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
        Me.TextBox4.Left = 0.875!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = ""
        Me.TextBox4.Text = ":"
        Me.TextBox4.Top = 1.375!
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
        Me.txtMonthOf.Left = 1.0!
        Me.txtMonthOf.Name = "txtMonthOf"
        Me.txtMonthOf.Style = ""
        Me.txtMonthOf.Text = Nothing
        Me.txtMonthOf.Top = 1.375!
        Me.txtMonthOf.Width = 2.5!
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
        Me.TextBox7.Left = 0.1875!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox7.Text = "CHARGING"
        Me.TextBox7.Top = 2.0!
        Me.TextBox7.Width = 2.6875!
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
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 2.875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox3.Text = "IN-HOUSE"
        Me.TextBox3.Top = 2.0!
        Me.TextBox3.Width = 1.625!
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
        Me.TextBox5.CanGrow = False
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 4.5!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox5.Text = "CONSIGNMENT"
        Me.TextBox5.Top = 2.0!
        Me.TextBox5.Width = 1.625!
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
        Me.TextBox6.Left = 6.125!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox6.Text = "TOTAL"
        Me.TextBox6.Top = 2.0!
        Me.TextBox6.Width = 1.625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.txtChargingID})
        Me.Detail1.Height = 0.1666667!
        Me.Detail1.Name = "Detail1"
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
        Me.TextBox8.DataField = "payment_type"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 0.1875!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 2.6875!
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
        Me.TextBox9.Left = 2.875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0!
        Me.TextBox9.Width = 1.625!
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
        Me.TextBox10.Left = 4.5!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0!
        Me.TextBox10.Width = 1.625!
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
        Me.TextBox11.Left = 6.125!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; "
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0!
        Me.TextBox11.Width = 1.625!
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
        Me.txtChargingID.Left = 2.4375!
        Me.txtChargingID.Name = "txtChargingID"
        Me.txtChargingID.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.txtChargingID.Text = Nothing
        Me.txtChargingID.Top = 0!
        Me.txtChargingID.Visible = False
        Me.txtChargingID.Width = 0.4375!
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
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox12, Me.txtSubTotalInhouse, Me.txtSubTotalConsign, Me.txtSubTotalTotal, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6})
        Me.GroupFooter1.Height = 1.989583!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.TextBox12.Left = 0.1875!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.TextBox12.Text = "TOTAL"
        Me.TextBox12.Top = 0!
        Me.TextBox12.Width = 2.6875!
        '
        'txtSubTotalInhouse
        '
        Me.txtSubTotalInhouse.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubTotalInhouse.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalInhouse.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubTotalInhouse.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalInhouse.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubTotalInhouse.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalInhouse.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubTotalInhouse.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalInhouse.CanGrow = False
        Me.txtSubTotalInhouse.Height = 0.1875!
        Me.txtSubTotalInhouse.Left = 2.875!
        Me.txtSubTotalInhouse.Name = "txtSubTotalInhouse"
        Me.txtSubTotalInhouse.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" &
    "l-align: middle; "
        Me.txtSubTotalInhouse.Text = Nothing
        Me.txtSubTotalInhouse.Top = 0!
        Me.txtSubTotalInhouse.Width = 1.625!
        '
        'txtSubTotalConsign
        '
        Me.txtSubTotalConsign.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubTotalConsign.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalConsign.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubTotalConsign.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalConsign.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubTotalConsign.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalConsign.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubTotalConsign.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalConsign.CanGrow = False
        Me.txtSubTotalConsign.Height = 0.1875!
        Me.txtSubTotalConsign.Left = 4.5!
        Me.txtSubTotalConsign.Name = "txtSubTotalConsign"
        Me.txtSubTotalConsign.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" &
    "l-align: middle; "
        Me.txtSubTotalConsign.Text = Nothing
        Me.txtSubTotalConsign.Top = 0!
        Me.txtSubTotalConsign.Width = 1.625!
        '
        'txtSubTotalTotal
        '
        Me.txtSubTotalTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubTotalTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubTotalTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubTotalTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubTotalTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtSubTotalTotal.CanGrow = False
        Me.txtSubTotalTotal.Height = 0.1875!
        Me.txtSubTotalTotal.Left = 6.125!
        Me.txtSubTotalTotal.Name = "txtSubTotalTotal"
        Me.txtSubTotalTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" &
    "l-align: middle; "
        Me.txtSubTotalTotal.Text = Nothing
        Me.txtSubTotalTotal.Top = 0!
        Me.txtSubTotalTotal.Width = 1.625!
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
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.3125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = ""
        Me.Label1.Text = "Prepared By:"
        Me.Label1.Top = 1.4375!
        Me.Label1.Visible = False
        Me.Label1.Width = 1.0!
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
        Me.Label2.Left = 1.375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
        Me.Label2.Text = "HENDRICH HAZEL J. TIBON"
        Me.Label2.Top = 1.4375!
        Me.Label2.Visible = False
        Me.Label2.Width = 2.0!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "text-align: center; "
        Me.Label3.Text = "Pharmacy Aide"
        Me.Label3.Top = 1.6875!
        Me.Label3.Visible = False
        Me.Label3.Width = 2.0!
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
        Me.Label4.Left = 4.5!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = ""
        Me.Label4.Text = "Certified Correct :"
        Me.Label4.Top = 1.4375!
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
        Me.Label5.Left = 5.75!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = ""
        Me.Label5.Text = "DIANA JANE C. REGIS,  RPh"
        Me.Label5.Top = 1.4375!
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
        Me.Label6.Left = 5.75!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: center; "
        Me.Label6.Text = "Pharmacy Head"
        Me.Label6.Top = 1.6875!
        Me.Label6.Width = 2.0!
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
        Me.Label7.Left = 0!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; vertical" &
    "-align: middle; "
        Me.Label7.Text = "EVERSLEY CHILDS SANITARIUM AND GENERAL HOSPITAL"
        Me.Label7.Top = 0.1083333!
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
        Me.Label8.Left = 0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 9.75pt; "
        Me.Label8.Text = "North Road, Jagobiao, Mandaue City, Cebu 6014"
        Me.Label8.Top = 0.4208333!
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
        Me.Picture1.Left = 0.25!
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
        Me.Picture2.Left = 6.6875!
        Me.Picture2.LineWeight = 0!
        Me.Picture2.Name = "Picture2"
        Me.Picture2.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture2.Top = 0!
        Me.Picture2.Width = 0.8125!
        '
        'rpt_MonthlySummarizedTotal
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.25!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.989583!
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
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChargingID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalInhouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalConsign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtChargingID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSubTotalInhouse As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSubTotalConsign As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSubTotalTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Picture2 As DataDynamics.ActiveReports.Picture
End Class
