<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_StockCardHeaderPrint 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rpt_StockCardHeaderPrint))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtSupplier = New DataDynamics.ActiveReports.Label
        Me.txtItemName = New DataDynamics.ActiveReports.Label
        Me.txtStockNo = New DataDynamics.ActiveReports.Label
        Me.txtUnitMeasure = New DataDynamics.ActiveReports.Label
        Me.txtReorderPoint = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.txtItemBuyPrice = New DataDynamics.ActiveReports.TextBox
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.txtReference = New DataDynamics.ActiveReports.TextBox
        Me.txtRcvdQty = New DataDynamics.ActiveReports.TextBox
        Me.txtRcvdAmount = New DataDynamics.ActiveReports.TextBox
        Me.txtIssPullQTY = New DataDynamics.ActiveReports.TextBox
        Me.txtIssPullAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtBalQTY = New DataDynamics.ActiveReports.TextBox
        Me.txtBalanceAmt = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitMeasure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReorderPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemBuyPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRcvdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRcvdAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssPullQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssPullAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalanceAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSupplier, Me.txtItemName, Me.txtStockNo, Me.txtUnitMeasure, Me.txtReorderPoint, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Line1, Me.Label7, Me.Line2, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label13, Me.Label12, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label24, Me.txtItemBuyPrice, Me.Label25, Me.Label26, Me.Label27, Me.Label28})
        Me.PageHeader1.Height = 2.6875!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtSupplier
        '
        Me.txtSupplier.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSupplier.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSupplier.Border.RightColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSupplier.Border.TopColor = System.Drawing.Color.Black
        Me.txtSupplier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSupplier.DataField = "consignee"
        Me.txtSupplier.Height = 0.1875!
        Me.txtSupplier.HyperLink = Nothing
        Me.txtSupplier.Left = 0.0!
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Style = ""
        Me.txtSupplier.Text = ""
        Me.txtSupplier.Top = 1.125!
        Me.txtSupplier.Width = 2.6875!
        '
        'txtItemName
        '
        Me.txtItemName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtItemName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtItemName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtItemName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtItemName.Border.RightColor = System.Drawing.Color.Black
        Me.txtItemName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtItemName.Border.TopColor = System.Drawing.Color.Black
        Me.txtItemName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtItemName.DataField = "a_name"
        Me.txtItemName.Height = 0.1875!
        Me.txtItemName.HyperLink = Nothing
        Me.txtItemName.Left = 0.3125!
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Style = "text-align: center; "
        Me.txtItemName.Text = ""
        Me.txtItemName.Top = 1.5!
        Me.txtItemName.Width = 2.3125!
        '
        'txtStockNo
        '
        Me.txtStockNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtStockNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtStockNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtStockNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtStockNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtStockNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtStockNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtStockNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtStockNo.DataField = "a_code"
        Me.txtStockNo.Height = 0.1875!
        Me.txtStockNo.HyperLink = Nothing
        Me.txtStockNo.Left = 6.4375!
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Style = "text-align: center; "
        Me.txtStockNo.Text = ""
        Me.txtStockNo.Top = 1.5!
        Me.txtStockNo.Width = 1.5!
        '
        'txtUnitMeasure
        '
        Me.txtUnitMeasure.Border.BottomColor = System.Drawing.Color.Black
        Me.txtUnitMeasure.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtUnitMeasure.Border.LeftColor = System.Drawing.Color.Black
        Me.txtUnitMeasure.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUnitMeasure.Border.RightColor = System.Drawing.Color.Black
        Me.txtUnitMeasure.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUnitMeasure.Border.TopColor = System.Drawing.Color.Black
        Me.txtUnitMeasure.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUnitMeasure.DataField = "item_unit"
        Me.txtUnitMeasure.Height = 0.1875!
        Me.txtUnitMeasure.HyperLink = Nothing
        Me.txtUnitMeasure.Left = 6.4375!
        Me.txtUnitMeasure.Name = "txtUnitMeasure"
        Me.txtUnitMeasure.Style = "text-align: center; "
        Me.txtUnitMeasure.Text = ""
        Me.txtUnitMeasure.Top = 1.75!
        Me.txtUnitMeasure.Width = 1.5!
        '
        'txtReorderPoint
        '
        Me.txtReorderPoint.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReorderPoint.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtReorderPoint.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReorderPoint.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReorderPoint.Border.RightColor = System.Drawing.Color.Black
        Me.txtReorderPoint.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReorderPoint.Border.TopColor = System.Drawing.Color.Black
        Me.txtReorderPoint.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReorderPoint.DataField = "item_reordercount"
        Me.txtReorderPoint.Height = 0.1875!
        Me.txtReorderPoint.HyperLink = Nothing
        Me.txtReorderPoint.Left = 6.4375!
        Me.txtReorderPoint.Name = "txtReorderPoint"
        Me.txtReorderPoint.Style = "text-align: center; "
        Me.txtReorderPoint.Text = ""
        Me.txtReorderPoint.Top = 2.0!
        Me.txtReorderPoint.Width = 1.5!
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
        Me.Label1.Height = 0.25!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 15.75pt; "
        Me.Label1.Text = "Eversley Childs Sanitarium"
        Me.Label1.Top = 0.0625!
        Me.Label1.Width = 7.9375!
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
        Me.Label2.Height = 0.3125!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 20.25pt; "
        Me.Label2.Text = "STOCK CARD"
        Me.Label2.Top = 0.5625!
        Me.Label2.Width = 7.9375!
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
        Me.Label3.Height = 0.25!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 14.25pt; "
        Me.Label3.Text = "Agency"
        Me.Label3.Top = 0.3125!
        Me.Label3.Width = 7.9375!
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
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.DataField = "consignee"
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "text-align: center; "
        Me.Label4.Text = ""
        Me.Label4.Top = 1.3125!
        Me.Label4.Width = 7.9375!
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
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = ""
        Me.Label5.Text = "Item :"
        Me.Label5.Top = 1.5!
        Me.Label5.Width = 0.3125!
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
        Me.Label6.Left = 2.75!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = ""
        Me.Label6.Text = "Description:"
        Me.Label6.Top = 1.5!
        Me.Label6.Width = 0.875!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 1.0!
        Me.Line1.Left = 2.6875!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.3125!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 2.6875!
        Me.Line1.X2 = 2.6875!
        Me.Line1.Y1 = 2.3125!
        Me.Line1.Y2 = 1.3125!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.625!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: center; "
        Me.Label7.Text = ""
        Me.Label7.Top = 1.5!
        Me.Label7.Width = 1.625!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 1.0!
        Me.Line2.Left = 5.3125!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.3125!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 5.3125!
        Me.Line2.X2 = 5.3125!
        Me.Line2.Y1 = 2.3125!
        Me.Line2.Y2 = 1.3125!
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
        Me.Label8.Left = 5.375!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = ""
        Me.Label8.Text = "Stock No."
        Me.Label8.Top = 1.5!
        Me.Label8.Width = 1.0625!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 5.375!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = ""
        Me.Label9.Text = "Unit of Measure"
        Me.Label9.Top = 1.75!
        Me.Label9.Width = 1.0625!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 5.375!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = ""
        Me.Label10.Text = "Re-order Point :"
        Me.Label10.Top = 2.0!
        Me.Label10.Width = 1.0625!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.75!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "text-align: center; "
        Me.Label11.Text = ""
        Me.Label11.Top = 1.75!
        Me.Label11.Width = 2.5!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.375!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "text-align: center; vertical-align: middle; "
        Me.Label13.Text = "Date"
        Me.Label13.Top = 2.3125!
        Me.Label13.Width = 0.75!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.75!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "text-align: center; "
        Me.Label12.Text = "References"
        Me.Label12.Top = 2.3125!
        Me.Label12.Width = 1.3125!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 2.0625!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label14.Text = "Receipt"
        Me.Label14.Top = 2.3125!
        Me.Label14.Width = 0.625!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.75!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label15.Text = "Recd/Issues"
        Me.Label15.Top = 2.5!
        Me.Label15.Width = 0.6875!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 1.4375!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label16.Text = "PO/RIS"
        Me.Label16.Top = 2.5!
        Me.Label16.Width = 0.625!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Height = 0.1875!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.0625!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label17.Text = "QTY"
        Me.Label17.Top = 2.5!
        Me.Label17.Width = 0.625!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Height = 0.1875!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.6875!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "text-align: center; "
        Me.Label18.Text = "Amount"
        Me.Label18.Top = 2.3125!
        Me.Label18.Width = 0.9375!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Height = 0.1875!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 3.625!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label19.Text = "Issuance/Pull-Out"
        Me.Label19.Top = 2.3125!
        Me.Label19.Width = 1.6875!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Height = 0.1875!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 2.6875!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label20.Text = "Recd."
        Me.Label20.Top = 2.5!
        Me.Label20.Width = 0.9375!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.Black
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.LeftColor = System.Drawing.Color.Black
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.RightColor = System.Drawing.Color.Black
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.TopColor = System.Drawing.Color.Black
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Height = 0.1875!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 3.625!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label21.Text = "QTY"
        Me.Label21.Top = 2.5!
        Me.Label21.Width = 0.625!
        '
        'Label22
        '
        Me.Label22.Border.BottomColor = System.Drawing.Color.Black
        Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.LeftColor = System.Drawing.Color.Black
        Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.RightColor = System.Drawing.Color.Black
        Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.TopColor = System.Drawing.Color.Black
        Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Height = 0.1875!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 4.25!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label22.Text = "AMOUNT"
        Me.Label22.Top = 2.5!
        Me.Label22.Width = 1.0625!
        '
        'Label24
        '
        Me.Label24.Border.BottomColor = System.Drawing.Color.Black
        Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.LeftColor = System.Drawing.Color.Black
        Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.RightColor = System.Drawing.Color.Black
        Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.TopColor = System.Drawing.Color.Black
        Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Height = 0.1875!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = ""
        Me.Label24.Text = "PRICE :"
        Me.Label24.Top = 2.0!
        Me.Label24.Width = 0.5625!
        '
        'txtItemBuyPrice
        '
        Me.txtItemBuyPrice.Border.BottomColor = System.Drawing.Color.Black
        Me.txtItemBuyPrice.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtItemBuyPrice.Border.LeftColor = System.Drawing.Color.Black
        Me.txtItemBuyPrice.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtItemBuyPrice.Border.RightColor = System.Drawing.Color.Black
        Me.txtItemBuyPrice.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtItemBuyPrice.Border.TopColor = System.Drawing.Color.Black
        Me.txtItemBuyPrice.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtItemBuyPrice.DataField = "item_buyprice"
        Me.txtItemBuyPrice.Height = 0.1875!
        Me.txtItemBuyPrice.Left = 0.6875!
        Me.txtItemBuyPrice.Name = "txtItemBuyPrice"
        Me.txtItemBuyPrice.OutputFormat = resources.GetString("txtItemBuyPrice.OutputFormat")
        Me.txtItemBuyPrice.Style = "text-align: right; "
        Me.txtItemBuyPrice.Text = "0.00"
        Me.txtItemBuyPrice.Top = 2.0!
        Me.txtItemBuyPrice.Width = 1.3125!
        '
        'Label25
        '
        Me.Label25.Border.BottomColor = System.Drawing.Color.Black
        Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.LeftColor = System.Drawing.Color.Black
        Me.Label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.RightColor = System.Drawing.Color.Black
        Me.Label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.TopColor = System.Drawing.Color.Black
        Me.Label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Height = 0.1875!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 5.3125!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "text-align: center; "
        Me.Label25.Text = "BALANCE"
        Me.Label25.Top = 2.3125!
        Me.Label25.Width = 2.625!
        '
        'Label26
        '
        Me.Label26.Border.BottomColor = System.Drawing.Color.Black
        Me.Label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.LeftColor = System.Drawing.Color.Black
        Me.Label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.RightColor = System.Drawing.Color.Black
        Me.Label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.TopColor = System.Drawing.Color.Black
        Me.Label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Height = 0.1875!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 5.3125!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label26.Text = "QTY"
        Me.Label26.Top = 2.5!
        Me.Label26.Width = 0.75!
        '
        'Label27
        '
        Me.Label27.Border.BottomColor = System.Drawing.Color.Black
        Me.Label27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label27.Border.LeftColor = System.Drawing.Color.Black
        Me.Label27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label27.Border.RightColor = System.Drawing.Color.Black
        Me.Label27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label27.Border.TopColor = System.Drawing.Color.Black
        Me.Label27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label27.Height = 0.1875!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 6.0625!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label27.Text = "UNIT COST"
        Me.Label27.Top = 2.5!
        Me.Label27.Width = 0.8125!
        '
        'Label28
        '
        Me.Label28.Border.BottomColor = System.Drawing.Color.Black
        Me.Label28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Border.LeftColor = System.Drawing.Color.Black
        Me.Label28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Border.RightColor = System.Drawing.Color.Black
        Me.Label28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Border.TopColor = System.Drawing.Color.Black
        Me.Label28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Height = 0.1875!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 6.875!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.Label28.Text = "AMOUNT"
        Me.Label28.Top = 2.5!
        Me.Label28.Width = 1.0625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDate, Me.TextBox3, Me.txtReference, Me.txtRcvdQty, Me.txtRcvdAmount, Me.txtIssPullQTY, Me.txtIssPullAmt, Me.txtBalQTY, Me.txtBalanceAmt, Me.TextBox9})
        Me.Detail1.Height = 0.1666667!
        Me.Detail1.Name = "Detail1"
        '
        'txtDate
        '
        Me.txtDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDate.DataField = "TRD_Date"
        Me.txtDate.Height = 0.1875!
        Me.txtDate.Left = 0.0!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.OutputFormat = resources.GetString("txtDate.OutputFormat")
        Me.txtDate.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtDate.Text = Nothing
        Me.txtDate.Top = 0.0!
        Me.txtDate.Width = 0.75!
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
        Me.TextBox3.Left = 0.75!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.6875!
        '
        'txtReference
        '
        Me.txtReference.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReference.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtReference.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReference.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtReference.Border.RightColor = System.Drawing.Color.Black
        Me.txtReference.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtReference.Border.TopColor = System.Drawing.Color.Black
        Me.txtReference.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtReference.Height = 0.1875!
        Me.txtReference.Left = 1.4375!
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtReference.Text = Nothing
        Me.txtReference.Top = 0.0!
        Me.txtReference.Width = 0.625!
        '
        'txtRcvdQty
        '
        Me.txtRcvdQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRcvdQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRcvdQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtRcvdQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtRcvdQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdQty.DataField = "added"
        Me.txtRcvdQty.Height = 0.1875!
        Me.txtRcvdQty.Left = 2.0625!
        Me.txtRcvdQty.Name = "txtRcvdQty"
        Me.txtRcvdQty.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtRcvdQty.Text = Nothing
        Me.txtRcvdQty.Top = 0.0!
        Me.txtRcvdQty.Width = 0.625!
        '
        'txtRcvdAmount
        '
        Me.txtRcvdAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRcvdAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRcvdAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdAmount.Border.RightColor = System.Drawing.Color.Black
        Me.txtRcvdAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdAmount.Border.TopColor = System.Drawing.Color.Black
        Me.txtRcvdAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRcvdAmount.Height = 0.1875!
        Me.txtRcvdAmount.Left = 2.6875!
        Me.txtRcvdAmount.Name = "txtRcvdAmount"
        Me.txtRcvdAmount.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtRcvdAmount.Text = Nothing
        Me.txtRcvdAmount.Top = 0.0!
        Me.txtRcvdAmount.Width = 0.9375!
        '
        'txtIssPullQTY
        '
        Me.txtIssPullQTY.Border.BottomColor = System.Drawing.Color.Black
        Me.txtIssPullQTY.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullQTY.Border.LeftColor = System.Drawing.Color.Black
        Me.txtIssPullQTY.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullQTY.Border.RightColor = System.Drawing.Color.Black
        Me.txtIssPullQTY.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullQTY.Border.TopColor = System.Drawing.Color.Black
        Me.txtIssPullQTY.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullQTY.DataField = "isspull"
        Me.txtIssPullQTY.Height = 0.1875!
        Me.txtIssPullQTY.Left = 3.625!
        Me.txtIssPullQTY.Name = "txtIssPullQTY"
        Me.txtIssPullQTY.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtIssPullQTY.Text = Nothing
        Me.txtIssPullQTY.Top = 0.0!
        Me.txtIssPullQTY.Width = 0.625!
        '
        'txtIssPullAmt
        '
        Me.txtIssPullAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtIssPullAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtIssPullAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtIssPullAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtIssPullAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtIssPullAmt.Height = 0.1875!
        Me.txtIssPullAmt.Left = 4.25!
        Me.txtIssPullAmt.Name = "txtIssPullAmt"
        Me.txtIssPullAmt.OutputFormat = resources.GetString("txtIssPullAmt.OutputFormat")
        Me.txtIssPullAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtIssPullAmt.Text = Nothing
        Me.txtIssPullAmt.Top = 0.0!
        Me.txtIssPullAmt.Width = 1.0625!
        '
        'txtBalQTY
        '
        Me.txtBalQTY.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBalQTY.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalQTY.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBalQTY.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalQTY.Border.RightColor = System.Drawing.Color.Black
        Me.txtBalQTY.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalQTY.Border.TopColor = System.Drawing.Color.Black
        Me.txtBalQTY.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalQTY.DataField = "remaining_qty"
        Me.txtBalQTY.Height = 0.1875!
        Me.txtBalQTY.Left = 5.3125!
        Me.txtBalQTY.Name = "txtBalQTY"
        Me.txtBalQTY.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtBalQTY.Text = Nothing
        Me.txtBalQTY.Top = 0.0!
        Me.txtBalQTY.Width = 0.75!
        '
        'txtBalanceAmt
        '
        Me.txtBalanceAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBalanceAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalanceAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBalanceAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalanceAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtBalanceAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalanceAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtBalanceAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtBalanceAmt.Height = 0.1875!
        Me.txtBalanceAmt.Left = 6.875!
        Me.txtBalanceAmt.Name = "txtBalanceAmt"
        Me.txtBalanceAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtBalanceAmt.Text = Nothing
        Me.txtBalanceAmt.Top = 0.0!
        Me.txtBalanceAmt.Width = 1.0625!
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
        Me.TextBox9.DataField = "item_buyprice"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 6.0625!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.8125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'rpt_StockCardHeaderPrint
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.25!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.958333!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitMeasure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReorderPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemBuyPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRcvdQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRcvdAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssPullQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssPullAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalanceAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtSupplier As DataDynamics.ActiveReports.Label
    Friend WithEvents txtItemName As DataDynamics.ActiveReports.Label
    Friend WithEvents txtStockNo As DataDynamics.ActiveReports.Label
    Friend WithEvents txtUnitMeasure As DataDynamics.ActiveReports.Label
    Friend WithEvents txtReorderPoint As DataDynamics.ActiveReports.Label
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label17 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label18 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label20 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label21 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label24 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtItemBuyPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReference As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRcvdQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRcvdAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtIssPullQTY As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtIssPullAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label25 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label26 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label27 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label28 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtBalQTY As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBalanceAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
End Class
