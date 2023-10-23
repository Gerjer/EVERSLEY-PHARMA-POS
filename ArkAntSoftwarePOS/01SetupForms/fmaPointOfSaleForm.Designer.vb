<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaPointOfSaleForm
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaPointOfSaleForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnAddPatient = New DevComponents.DotNetBar.ButtonX()
        Me.btnAddItem = New DevComponents.DotNetBar.ButtonX()
        Me.btnPay = New DevComponents.DotNetBar.ButtonX()
        Me.btnSetDisc = New DevComponents.DotNetBar.ButtonX()
        Me.btnRemoveItem = New DevComponents.DotNetBar.ButtonX()
        Me.btnSetQty = New DevComponents.DotNetBar.ButtonX()
        Me.btnVoid = New DevComponents.DotNetBar.ButtonX()
        Me.btnNewSale = New DevComponents.DotNetBar.ButtonX()
        Me.btnInq = New DevComponents.DotNetBar.ButtonX()
        Me.btnSetPatient = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel9 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cxbxdirectPrinting = New System.Windows.Forms.CheckBox()
        Me.btnPostPayment = New DevComponents.DotNetBar.ButtonX()
        Me.lblPayableAmount = New DevComponents.DotNetBar.LabelX()
        Me.txtAmtDue = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel8 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cxbxSCDiscount = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.qty_unfilled = New DevComponents.Editors.DoubleInput()
        Me.cxbxUnfilledPrx = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtDiscount = New DevComponents.Editors.DoubleInput()
        Me.cxbxDiscounted = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel10 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblDate = New DevComponents.DotNetBar.LabelX()
        Me.txtVAT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cxboxVAT = New System.Windows.Forms.CheckBox()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblSysMsg = New DevComponents.DotNetBar.LabelX()
        Me.ITEMS = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dtgvOrderList = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consigneeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRIS_Det_No = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDisplayCost = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCharging = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.linkAddPatient = New System.Windows.Forms.LinkLabel()
        Me.txtChargeTo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.txtOSCA = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtRefNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtORNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPatientProfile = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.lblPatientWard = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtPatientTypeID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.rbtnWard = New System.Windows.Forms.RadioButton()
        Me.rbtnPatient = New System.Windows.Forms.RadioButton()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtTransNum = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtItemCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtQty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnSelectItem = New System.Windows.Forms.Button()
        Me.txtPatientCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtChargingID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtTotalAmt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel9.SuspendLayout()
        Me.GroupPanel8.SuspendLayout()
        CType(Me.qty_unfilled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel10.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        Me.ITEMS.SuspendLayout()
        Me.GroupPanel7.SuspendLayout()
        CType(Me.dtgvOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.WinLabel)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1374, 28)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'WinLabel
        '
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(1374, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "MEDICINE ISSUANCE"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Staff"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "User"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "HR Personnel"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Accounting"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnAddPatient)
        Me.GroupPanel1.Controls.Add(Me.btnAddItem)
        Me.GroupPanel1.Controls.Add(Me.btnPay)
        Me.GroupPanel1.Controls.Add(Me.btnSetDisc)
        Me.GroupPanel1.Controls.Add(Me.btnRemoveItem)
        Me.GroupPanel1.Controls.Add(Me.btnSetQty)
        Me.GroupPanel1.Controls.Add(Me.btnVoid)
        Me.GroupPanel1.Controls.Add(Me.btnNewSale)
        Me.GroupPanel1.Controls.Add(Me.btnInq)
        Me.GroupPanel1.Controls.Add(Me.btnSetPatient)
        Me.GroupPanel1.Controls.Add(Me.btnClose)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 740)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1374, 93)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 16
        '
        'btnAddPatient
        '
        Me.btnAddPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddPatient.BackColor = System.Drawing.Color.Transparent
        Me.btnAddPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAddPatient.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddPatient.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatient.ForeColor = System.Drawing.Color.Cyan
        Me.btnAddPatient.Image = CType(resources.GetObject("btnAddPatient.Image"), System.Drawing.Image)
        Me.btnAddPatient.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnAddPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnAddPatient.Location = New System.Drawing.Point(819, 0)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAddPatient.Size = New System.Drawing.Size(91, 87)
        Me.btnAddPatient.TabIndex = 26
        Me.btnAddPatient.Text = "ADD PATIENT"
        '
        'btnAddItem
        '
        Me.btnAddItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddItem.BackColor = System.Drawing.Color.Transparent
        Me.btnAddItem.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAddItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddItem.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.Cyan
        Me.btnAddItem.Image = CType(resources.GetObject("btnAddItem.Image"), System.Drawing.Image)
        Me.btnAddItem.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnAddItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnAddItem.Location = New System.Drawing.Point(728, 0)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9)
        Me.btnAddItem.Size = New System.Drawing.Size(91, 87)
        Me.btnAddItem.TabIndex = 11
        Me.btnAddItem.Text = "ADD ITEM "
        Me.btnAddItem.Tooltip = "Add Item to Order List"
        '
        'btnPay
        '
        Me.btnPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPay.BackColor = System.Drawing.Color.Transparent
        Me.btnPay.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnPay.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPay.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.Cyan
        Me.btnPay.Image = CType(resources.GetObject("btnPay.Image"), System.Drawing.Image)
        Me.btnPay.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnPay.Location = New System.Drawing.Point(637, 0)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8)
        Me.btnPay.Size = New System.Drawing.Size(91, 87)
        Me.btnPay.TabIndex = 10
        Me.btnPay.Text = "PAY "
        Me.btnPay.Tooltip = "Tender Amount"
        Me.btnPay.Visible = False
        '
        'btnSetDisc
        '
        Me.btnSetDisc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetDisc.BackColor = System.Drawing.Color.Transparent
        Me.btnSetDisc.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSetDisc.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSetDisc.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetDisc.ForeColor = System.Drawing.Color.Cyan
        Me.btnSetDisc.Image = CType(resources.GetObject("btnSetDisc.Image"), System.Drawing.Image)
        Me.btnSetDisc.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnSetDisc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnSetDisc.Location = New System.Drawing.Point(546, 0)
        Me.btnSetDisc.Name = "btnSetDisc"
        Me.btnSetDisc.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7)
        Me.btnSetDisc.Size = New System.Drawing.Size(91, 87)
        Me.btnSetDisc.TabIndex = 9
        Me.btnSetDisc.Text = "SET DISC%"
        Me.btnSetDisc.Tooltip = "Set Discounts"
        Me.btnSetDisc.Visible = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveItem.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveItem.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnRemoveItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRemoveItem.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.Cyan
        Me.btnRemoveItem.Image = CType(resources.GetObject("btnRemoveItem.Image"), System.Drawing.Image)
        Me.btnRemoveItem.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnRemoveItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnRemoveItem.Location = New System.Drawing.Point(455, 0)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F6)
        Me.btnRemoveItem.Size = New System.Drawing.Size(91, 87)
        Me.btnRemoveItem.TabIndex = 8
        Me.btnRemoveItem.Text = "REM. ITEM"
        Me.btnRemoveItem.Tooltip = "Remove Item/s"
        '
        'btnSetQty
        '
        Me.btnSetQty.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetQty.BackColor = System.Drawing.Color.Transparent
        Me.btnSetQty.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSetQty.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSetQty.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetQty.ForeColor = System.Drawing.Color.Cyan
        Me.btnSetQty.Image = CType(resources.GetObject("btnSetQty.Image"), System.Drawing.Image)
        Me.btnSetQty.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnSetQty.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnSetQty.Location = New System.Drawing.Point(364, 0)
        Me.btnSetQty.Name = "btnSetQty"
        Me.btnSetQty.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnSetQty.Size = New System.Drawing.Size(91, 87)
        Me.btnSetQty.TabIndex = 7
        Me.btnSetQty.Text = "SET QTY"
        Me.btnSetQty.Tooltip = "Set Quantity of Item"
        '
        'btnVoid
        '
        Me.btnVoid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVoid.BackColor = System.Drawing.Color.Transparent
        Me.btnVoid.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnVoid.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVoid.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.Cyan
        Me.btnVoid.Image = CType(resources.GetObject("btnVoid.Image"), System.Drawing.Image)
        Me.btnVoid.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnVoid.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnVoid.Location = New System.Drawing.Point(273, 0)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4)
        Me.btnVoid.Size = New System.Drawing.Size(91, 87)
        Me.btnVoid.TabIndex = 6
        Me.btnVoid.Text = "VIEW TR"
        Me.btnVoid.Tooltip = "View Saved Transactions"
        '
        'btnNewSale
        '
        Me.btnNewSale.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNewSale.BackColor = System.Drawing.Color.Transparent
        Me.btnNewSale.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnNewSale.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNewSale.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSale.ForeColor = System.Drawing.Color.Cyan
        Me.btnNewSale.Image = CType(resources.GetObject("btnNewSale.Image"), System.Drawing.Image)
        Me.btnNewSale.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnNewSale.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnNewSale.Location = New System.Drawing.Point(182, 0)
        Me.btnNewSale.Name = "btnNewSale"
        Me.btnNewSale.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.btnNewSale.Size = New System.Drawing.Size(91, 87)
        Me.btnNewSale.TabIndex = 5
        Me.btnNewSale.Text = "NEW SALES"
        Me.btnNewSale.Tooltip = "New Sale Entry"
        '
        'btnInq
        '
        Me.btnInq.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInq.BackColor = System.Drawing.Color.Transparent
        Me.btnInq.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnInq.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInq.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInq.ForeColor = System.Drawing.Color.Cyan
        Me.btnInq.Image = CType(resources.GetObject("btnInq.Image"), System.Drawing.Image)
        Me.btnInq.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnInq.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnInq.Location = New System.Drawing.Point(91, 0)
        Me.btnInq.Name = "btnInq"
        Me.btnInq.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.btnInq.Size = New System.Drawing.Size(91, 87)
        Me.btnInq.TabIndex = 3
        Me.btnInq.Text = "INQUIRY"
        Me.btnInq.Tooltip = "Product Inquiry"
        '
        'btnSetPatient
        '
        Me.btnSetPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetPatient.BackColor = System.Drawing.Color.Transparent
        Me.btnSetPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSetPatient.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSetPatient.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPatient.ForeColor = System.Drawing.Color.Cyan
        Me.btnSetPatient.Image = CType(resources.GetObject("btnSetPatient.Image"), System.Drawing.Image)
        Me.btnSetPatient.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnSetPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnSetPatient.Location = New System.Drawing.Point(0, 0)
        Me.btnSetPatient.Name = "btnSetPatient"
        Me.btnSetPatient.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.btnSetPatient.Size = New System.Drawing.Size(91, 87)
        Me.btnSetPatient.TabIndex = 12
        Me.btnSetPatient.Text = "SET PATIENT"
        Me.btnSetPatient.Tooltip = "Select Patient"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Aqua
        Me.btnClose.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.close
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(70, 60)
        Me.btnClose.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.btnClose.Location = New System.Drawing.Point(1280, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7)
        Me.btnClose.Size = New System.Drawing.Size(88, 87)
        Me.btnClose.SplitButton = True
        Me.btnClose.TabIndex = 146
        Me.btnClose.Tag = "7"
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.Tooltip = "Close Form"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel2.Controls.Add(Me.ITEMS)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1374, 712)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 17
        '
        'GroupPanel4
        '
        Me.GroupPanel4.BackColor = System.Drawing.Color.Black
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.GroupPanel9)
        Me.GroupPanel4.Controls.Add(Me.GroupPanel8)
        Me.GroupPanel4.Controls.Add(Me.GroupPanel5)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Location = New System.Drawing.Point(851, 0)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(517, 706)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel4.Style.BackColor2 = System.Drawing.SystemColors.HighlightText
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel4.TabIndex = 1
        Me.GroupPanel4.Text = "TENDER"
        '
        'GroupPanel9
        '
        Me.GroupPanel9.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel9.Controls.Add(Me.cxbxdirectPrinting)
        Me.GroupPanel9.Controls.Add(Me.btnPostPayment)
        Me.GroupPanel9.Controls.Add(Me.lblPayableAmount)
        Me.GroupPanel9.Controls.Add(Me.txtAmtDue)
        Me.GroupPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel9.Location = New System.Drawing.Point(0, 228)
        Me.GroupPanel9.Name = "GroupPanel9"
        Me.GroupPanel9.Size = New System.Drawing.Size(511, 400)
        '
        '
        '
        Me.GroupPanel9.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemDesignTimeBorder
        Me.GroupPanel9.Style.BackColorGradientAngle = 90
        Me.GroupPanel9.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemDesignTimeBorder
        Me.GroupPanel9.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderBottomWidth = 1
        Me.GroupPanel9.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel9.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderLeftWidth = 1
        Me.GroupPanel9.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderRightWidth = 1
        Me.GroupPanel9.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel9.Style.BorderTopWidth = 1
        Me.GroupPanel9.Style.CornerDiameter = 4
        Me.GroupPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel9.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel9.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel9.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel9.TabIndex = 9
        '
        'cxbxdirectPrinting
        '
        Me.cxbxdirectPrinting.AutoSize = True
        Me.cxbxdirectPrinting.BackColor = System.Drawing.Color.Transparent
        Me.cxbxdirectPrinting.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxbxdirectPrinting.ForeColor = System.Drawing.Color.Aqua
        Me.cxbxdirectPrinting.Location = New System.Drawing.Point(17, 301)
        Me.cxbxdirectPrinting.Name = "cxbxdirectPrinting"
        Me.cxbxdirectPrinting.Size = New System.Drawing.Size(119, 22)
        Me.cxbxdirectPrinting.TabIndex = 140
        Me.cxbxdirectPrinting.Text = "Direct Printing"
        Me.cxbxdirectPrinting.UseVisualStyleBackColor = False
        '
        'btnPostPayment
        '
        Me.btnPostPayment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPostPayment.BackColor = System.Drawing.Color.Transparent
        Me.btnPostPayment.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnPostPayment.Enabled = False
        Me.btnPostPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostPayment.ForeColor = System.Drawing.Color.Cyan
        Me.btnPostPayment.Image = CType(resources.GetObject("btnPostPayment.Image"), System.Drawing.Image)
        Me.btnPostPayment.ImageFixedSize = New System.Drawing.Size(80, 60)
        Me.btnPostPayment.Location = New System.Drawing.Point(16, 214)
        Me.btnPostPayment.Name = "btnPostPayment"
        Me.btnPostPayment.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F10)
        Me.btnPostPayment.Size = New System.Drawing.Size(172, 87)
        Me.btnPostPayment.TabIndex = 139
        Me.btnPostPayment.Text = " - POST"
        '
        'lblPayableAmount
        '
        Me.lblPayableAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPayableAmount.AutoSize = True
        Me.lblPayableAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblPayableAmount.Font = New System.Drawing.Font("Book Antiqua", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayableAmount.ForeColor = System.Drawing.Color.Lime
        Me.lblPayableAmount.Location = New System.Drawing.Point(27, 42)
        Me.lblPayableAmount.Name = "lblPayableAmount"
        Me.lblPayableAmount.Size = New System.Drawing.Size(258, 37)
        Me.lblPayableAmount.TabIndex = 134
        Me.lblPayableAmount.Text = "TOTAL AMOUNT"
        '
        'txtAmtDue
        '
        Me.txtAmtDue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmtDue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtAmtDue.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtAmtDue.Border.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarFloatingBorder
        Me.txtAmtDue.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.txtAmtDue.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtAmtDue.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtAmtDue.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtAmtDue.Border.Class = "TextBoxBorder"
        Me.txtAmtDue.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtAmtDue.FocusHighlightEnabled = True
        Me.txtAmtDue.Font = New System.Drawing.Font("Book Antiqua", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtDue.ForeColor = System.Drawing.Color.Green
        Me.txtAmtDue.Location = New System.Drawing.Point(221, 91)
        Me.txtAmtDue.Name = "txtAmtDue"
        Me.txtAmtDue.ReadOnly = True
        Me.txtAmtDue.Size = New System.Drawing.Size(271, 48)
        Me.txtAmtDue.TabIndex = 133
        Me.txtAmtDue.Tag = "budget_lbpform3_1master"
        Me.txtAmtDue.Text = "<>"
        Me.txtAmtDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupPanel8
        '
        Me.GroupPanel8.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel8.Controls.Add(Me.Label6)
        Me.GroupPanel8.Controls.Add(Me.Label5)
        Me.GroupPanel8.Controls.Add(Me.Label4)
        Me.GroupPanel8.Controls.Add(Me.Label3)
        Me.GroupPanel8.Controls.Add(Me.cxbxSCDiscount)
        Me.GroupPanel8.Controls.Add(Me.Label2)
        Me.GroupPanel8.Controls.Add(Me.Label1)
        Me.GroupPanel8.Controls.Add(Me.qty_unfilled)
        Me.GroupPanel8.Controls.Add(Me.cxbxUnfilledPrx)
        Me.GroupPanel8.Controls.Add(Me.txtDiscount)
        Me.GroupPanel8.Controls.Add(Me.cxbxDiscounted)
        Me.GroupPanel8.Controls.Add(Me.GroupPanel10)
        Me.GroupPanel8.Controls.Add(Me.txtVAT)
        Me.GroupPanel8.Controls.Add(Me.cxboxVAT)
        Me.GroupPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel8.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel8.Name = "GroupPanel8"
        Me.GroupPanel8.Size = New System.Drawing.Size(511, 228)
        '
        '
        '
        Me.GroupPanel8.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupPanel8.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupPanel8.Style.BackColorGradientAngle = 90
        Me.GroupPanel8.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderBottomWidth = 1
        Me.GroupPanel8.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel8.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderLeftWidth = 1
        Me.GroupPanel8.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderRightWidth = 1
        Me.GroupPanel8.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel8.Style.BorderTopWidth = 1
        Me.GroupPanel8.Style.CornerDiameter = 4
        Me.GroupPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel8.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel8.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel8.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel8.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(67, 186)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(53, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 20)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "UNFILLED PRESCRIPTION ?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(54, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(350, 20)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "QUANTIFIED FREE SERVICE DISCOUNT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 20)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "SENIOR CITIZEN DISCOUNT"
        '
        'cxbxSCDiscount
        '
        '
        '
        '
        Me.cxbxSCDiscount.BackgroundStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxbxSCDiscount.BackgroundStyle.TextColor = System.Drawing.Color.Blue
        Me.cxbxSCDiscount.BackgroundStyle.WordWrap = True
        Me.cxbxSCDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxbxSCDiscount.Location = New System.Drawing.Point(27, 63)
        Me.cxbxSCDiscount.Name = "cxbxSCDiscount"
        Me.cxbxSCDiscount.Size = New System.Drawing.Size(22, 29)
        Me.cxbxSCDiscount.TabIndex = 26
        Me.cxbxSCDiscount.TextColor = System.Drawing.Color.Aqua
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(266, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Amount"
        '
        'qty_unfilled
        '
        '
        '
        '
        Me.qty_unfilled.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.qty_unfilled.Enabled = False
        Me.qty_unfilled.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_unfilled.Increment = 1.0R
        Me.qty_unfilled.Location = New System.Drawing.Point(136, 186)
        Me.qty_unfilled.MinValue = 0R
        Me.qty_unfilled.Name = "qty_unfilled"
        Me.qty_unfilled.ShowUpDown = True
        Me.qty_unfilled.Size = New System.Drawing.Size(140, 29)
        Me.qty_unfilled.TabIndex = 142
        '
        'cxbxUnfilledPrx
        '
        '
        '
        '
        Me.cxbxUnfilledPrx.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.cxbxUnfilledPrx.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxbxUnfilledPrx.Location = New System.Drawing.Point(26, 157)
        Me.cxbxUnfilledPrx.Name = "cxbxUnfilledPrx"
        Me.cxbxUnfilledPrx.Size = New System.Drawing.Size(22, 22)
        Me.cxbxUnfilledPrx.TabIndex = 141
        Me.cxbxUnfilledPrx.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'txtDiscount
        '
        '
        '
        '
        Me.txtDiscount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Increment = 1.0R
        Me.txtDiscount.Location = New System.Drawing.Point(136, 123)
        Me.txtDiscount.MinValue = 0R
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ShowUpDown = True
        Me.txtDiscount.Size = New System.Drawing.Size(140, 29)
        Me.txtDiscount.TabIndex = 28
        '
        'cxbxDiscounted
        '
        '
        '
        '
        Me.cxbxDiscounted.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.cxbxDiscounted.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxbxDiscounted.Location = New System.Drawing.Point(26, 95)
        Me.cxbxDiscounted.Name = "cxbxDiscounted"
        Me.cxbxDiscounted.Size = New System.Drawing.Size(23, 25)
        Me.cxbxDiscounted.TabIndex = 27
        Me.cxbxDiscounted.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'GroupPanel10
        '
        Me.GroupPanel10.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel10.Controls.Add(Me.lblDate)
        Me.GroupPanel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel10.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel10.Name = "GroupPanel10"
        Me.GroupPanel10.Size = New System.Drawing.Size(505, 51)
        '
        '
        '
        Me.GroupPanel10.Style.BackColor = System.Drawing.Color.Black
        Me.GroupPanel10.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText
        Me.GroupPanel10.Style.BackColorGradientAngle = 90
        Me.GroupPanel10.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderBottomWidth = 1
        Me.GroupPanel10.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel10.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderLeftWidth = 1
        Me.GroupPanel10.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderRightWidth = 1
        Me.GroupPanel10.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel10.Style.BorderTopWidth = 1
        Me.GroupPanel10.Style.CornerDiameter = 4
        Me.GroupPanel10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel10.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel10.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel10.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel10.TabIndex = 13
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(0, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(499, 45)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "SYSTEM MESSAGE"
        Me.lblDate.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtVAT
        '
        '
        '
        '
        Me.txtVAT.Border.Class = "TextBoxBorder"
        Me.txtVAT.Location = New System.Drawing.Point(69, 6)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(36, 20)
        Me.txtVAT.TabIndex = 1
        Me.txtVAT.Text = "12%"
        Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtVAT.Visible = False
        '
        'cxboxVAT
        '
        Me.cxboxVAT.AutoSize = True
        Me.cxboxVAT.BackColor = System.Drawing.Color.Transparent
        Me.cxboxVAT.Location = New System.Drawing.Point(16, 11)
        Me.cxboxVAT.Name = "cxboxVAT"
        Me.cxboxVAT.Size = New System.Drawing.Size(47, 17)
        Me.cxboxVAT.TabIndex = 0
        Me.cxboxVAT.Text = "VAT"
        Me.cxboxVAT.UseVisualStyleBackColor = False
        Me.cxboxVAT.Visible = False
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.lblSysMsg)
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel5.Location = New System.Drawing.Point(0, 628)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(511, 54)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemDesignTimeBorder
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemDesignTimeBorder
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel5.TabIndex = 7
        '
        'lblSysMsg
        '
        Me.lblSysMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblSysMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysMsg.ForeColor = System.Drawing.Color.Red
        Me.lblSysMsg.Location = New System.Drawing.Point(0, 0)
        Me.lblSysMsg.Name = "lblSysMsg"
        Me.lblSysMsg.Size = New System.Drawing.Size(505, 48)
        Me.lblSysMsg.TabIndex = 0
        Me.lblSysMsg.Text = "SYSTEM MESSAGE"
        Me.lblSysMsg.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblSysMsg.Visible = False
        '
        'ITEMS
        '
        Me.ITEMS.BackColor = System.Drawing.Color.Black
        Me.ITEMS.CanvasColor = System.Drawing.SystemColors.Control
        Me.ITEMS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ITEMS.Controls.Add(Me.GroupPanel7)
        Me.ITEMS.Controls.Add(Me.GroupPanel6)
        Me.ITEMS.Controls.Add(Me.GroupPanel3)
        Me.ITEMS.Dock = System.Windows.Forms.DockStyle.Left
        Me.ITEMS.Location = New System.Drawing.Point(0, 0)
        Me.ITEMS.Name = "ITEMS"
        Me.ITEMS.Size = New System.Drawing.Size(851, 706)
        '
        '
        '
        Me.ITEMS.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ITEMS.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ITEMS.Style.BackColorGradientAngle = 90
        Me.ITEMS.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ITEMS.Style.BorderBottomWidth = 1
        Me.ITEMS.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ITEMS.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ITEMS.Style.BorderLeftWidth = 1
        Me.ITEMS.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ITEMS.Style.BorderRightWidth = 1
        Me.ITEMS.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ITEMS.Style.BorderTopWidth = 1
        Me.ITEMS.Style.CornerDiameter = 4
        Me.ITEMS.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ITEMS.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEMS.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ITEMS.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ITEMS.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.ITEMS.TabIndex = 0
        Me.ITEMS.Text = "ITEM MENU"
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.dtgvOrderList)
        Me.GroupPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel7.Location = New System.Drawing.Point(0, 220)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(845, 399)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel7.TabIndex = 32
        '
        'dtgvOrderList
        '
        Me.dtgvOrderList.AllowUserToAddRows = False
        Me.dtgvOrderList.AllowUserToDeleteRows = False
        Me.dtgvOrderList.BackgroundColor = System.Drawing.Color.White
        Me.dtgvOrderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvOrderList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column6, Me.consigneeid, Me.Column7, Me.Column8})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvOrderList.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtgvOrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvOrderList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgvOrderList.GridColor = System.Drawing.Color.Turquoise
        Me.dtgvOrderList.Location = New System.Drawing.Point(0, 0)
        Me.dtgvOrderList.MultiSelect = False
        Me.dtgvOrderList.Name = "dtgvOrderList"
        Me.dtgvOrderList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvOrderList.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgvOrderList.RowHeadersWidth = 10
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.dtgvOrderList.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvOrderList.Size = New System.Drawing.Size(839, 393)
        Me.dtgvOrderList.TabIndex = 30
        '
        'Column5
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = "CODE"
        Me.Column5.Name = "Column5"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "ITEM"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 62
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "QTY"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column2
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column2.HeaderText = "PRICE"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "TOTAL"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "CONSIGNEE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 200
        '
        'consigneeid
        '
        Me.consigneeid.HeaderText = "consigneeid"
        Me.consigneeid.Name = "consigneeid"
        '
        'Column7
        '
        Me.Column7.HeaderText = "invmaster_sys"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "ris_det_no"
        Me.Column8.Name = "Column8"
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.GroupBox1)
        Me.GroupPanel6.Controls.Add(Me.txtPatientTypeID)
        Me.GroupPanel6.Controls.Add(Me.rbtnWard)
        Me.GroupPanel6.Controls.Add(Me.rbtnPatient)
        Me.GroupPanel6.Controls.Add(Me.LabelX6)
        Me.GroupPanel6.Controls.Add(Me.txtTransNum)
        Me.GroupPanel6.Controls.Add(Me.LabelX2)
        Me.GroupPanel6.Controls.Add(Me.txtItemCode)
        Me.GroupPanel6.Controls.Add(Me.txtQty)
        Me.GroupPanel6.Controls.Add(Me.LabelX1)
        Me.GroupPanel6.Controls.Add(Me.btnSelectItem)
        Me.GroupPanel6.Controls.Add(Me.txtPatientCode)
        Me.GroupPanel6.Controls.Add(Me.txtChargingID)
        Me.GroupPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel6.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(845, 220)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor = System.Drawing.Color.Black
        Me.GroupPanel6.Style.BackColor2 = System.Drawing.Color.Black
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel6.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRIS_Det_No)
        Me.GroupBox1.Controls.Add(Me.txtDisplayCost)
        Me.GroupBox1.Controls.Add(Me.txtCharging)
        Me.GroupBox1.Controls.Add(Me.linkAddPatient)
        Me.GroupBox1.Controls.Add(Me.txtChargeTo)
        Me.GroupBox1.Controls.Add(Me.LabelX14)
        Me.GroupBox1.Controls.Add(Me.txtOSCA)
        Me.GroupBox1.Controls.Add(Me.LabelX11)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.txtORNo)
        Me.GroupBox1.Controls.Add(Me.txtPatientProfile)
        Me.GroupBox1.Controls.Add(Me.LabelX13)
        Me.GroupBox1.Controls.Add(Me.LabelX12)
        Me.GroupBox1.Controls.Add(Me.lblPatientWard)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(13, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 120)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'txtRIS_Det_No
        '
        '
        '
        '
        Me.txtRIS_Det_No.Border.Class = "TextBoxBorder"
        Me.txtRIS_Det_No.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRIS_Det_No.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtRIS_Det_No.Location = New System.Drawing.Point(401, 45)
        Me.txtRIS_Det_No.Name = "txtRIS_Det_No"
        Me.txtRIS_Det_No.ReadOnly = True
        Me.txtRIS_Det_No.Size = New System.Drawing.Size(63, 28)
        Me.txtRIS_Det_No.TabIndex = 27
        Me.txtRIS_Det_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRIS_Det_No.Visible = False
        '
        'txtDisplayCost
        '
        '
        '
        '
        Me.txtDisplayCost.Border.Class = "TextBoxBorder"
        Me.txtDisplayCost.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayCost.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDisplayCost.Location = New System.Drawing.Point(401, 77)
        Me.txtDisplayCost.Name = "txtDisplayCost"
        Me.txtDisplayCost.ReadOnly = True
        Me.txtDisplayCost.Size = New System.Drawing.Size(63, 28)
        Me.txtDisplayCost.TabIndex = 26
        Me.txtDisplayCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDisplayCost.Visible = False
        '
        'txtCharging
        '
        Me.txtCharging.AccessibleName = ""
        Me.txtCharging.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCharging.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCharging.DisplayMember = "Text"
        Me.txtCharging.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtCharging.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCharging.FocusHighlightEnabled = True
        Me.txtCharging.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharging.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCharging.FormattingEnabled = True
        Me.txtCharging.ItemHeight = 20
        Me.txtCharging.Location = New System.Drawing.Point(101, 84)
        Me.txtCharging.Name = "txtCharging"
        Me.txtCharging.Size = New System.Drawing.Size(291, 26)
        Me.txtCharging.TabIndex = 23
        '
        'linkAddPatient
        '
        Me.linkAddPatient.AutoSize = True
        Me.linkAddPatient.LinkColor = System.Drawing.Color.LawnGreen
        Me.linkAddPatient.Location = New System.Drawing.Point(400, 20)
        Me.linkAddPatient.Name = "linkAddPatient"
        Me.linkAddPatient.Size = New System.Drawing.Size(121, 13)
        Me.linkAddPatient.TabIndex = 22
        Me.linkAddPatient.TabStop = True
        Me.linkAddPatient.Text = "Add Patient [ CTRL + A]"
        Me.linkAddPatient.Visible = False
        '
        'txtChargeTo
        '
        Me.txtChargeTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        '
        '
        '
        Me.txtChargeTo.Border.Class = "TextBoxBorder"
        Me.txtChargeTo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtChargeTo.Location = New System.Drawing.Point(101, 50)
        Me.txtChargeTo.Name = "txtChargeTo"
        Me.txtChargeTo.ReadOnly = True
        Me.txtChargeTo.Size = New System.Drawing.Size(291, 25)
        Me.txtChargeTo.TabIndex = 20
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.White
        Me.LabelX14.Location = New System.Drawing.Point(6, 55)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(111, 23)
        Me.LabelX14.TabIndex = 19
        Me.LabelX14.Text = "TYPE :"
        '
        'txtOSCA
        '
        Me.txtOSCA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        '
        '
        '
        Me.txtOSCA.Border.Class = "TextBoxBorder"
        Me.txtOSCA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOSCA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOSCA.Location = New System.Drawing.Point(578, 77)
        Me.txtOSCA.Name = "txtOSCA"
        Me.txtOSCA.Size = New System.Drawing.Size(210, 26)
        Me.txtOSCA.TabIndex = 18
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.White
        Me.LabelX11.Location = New System.Drawing.Point(525, 81)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(47, 23)
        Me.LabelX11.TabIndex = 17
        Me.LabelX11.Text = "OSCA # :"
        '
        'txtRefNo
        '
        Me.txtRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        '
        '
        '
        Me.txtRefNo.Border.Class = "TextBoxBorder"
        Me.txtRefNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRefNo.Location = New System.Drawing.Point(578, 47)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(210, 26)
        Me.txtRefNo.TabIndex = 16
        '
        'txtORNo
        '
        Me.txtORNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        '
        '
        '
        Me.txtORNo.Border.Class = "TextBoxBorder"
        Me.txtORNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtORNo.Location = New System.Drawing.Point(578, 17)
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.Size = New System.Drawing.Size(210, 26)
        Me.txtORNo.TabIndex = 15
        '
        'txtPatientProfile
        '
        Me.txtPatientProfile.AccessibleName = ""
        Me.txtPatientProfile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPatientProfile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtPatientProfile.DisplayMember = "Text"
        Me.txtPatientProfile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtPatientProfile.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPatientProfile.FocusHighlightEnabled = True
        Me.txtPatientProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientProfile.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPatientProfile.FormattingEnabled = True
        Me.txtPatientProfile.ItemHeight = 20
        Me.txtPatientProfile.Location = New System.Drawing.Point(101, 19)
        Me.txtPatientProfile.Name = "txtPatientProfile"
        Me.txtPatientProfile.Size = New System.Drawing.Size(291, 26)
        Me.txtPatientProfile.TabIndex = 13
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.White
        Me.LabelX13.Location = New System.Drawing.Point(525, 50)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(47, 23)
        Me.LabelX13.TabIndex = 12
        Me.LabelX13.Text = "REF # :"
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.White
        Me.LabelX12.Location = New System.Drawing.Point(525, 20)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(47, 23)
        Me.LabelX12.TabIndex = 11
        Me.LabelX12.Text = "OR # :"
        '
        'lblPatientWard
        '
        Me.lblPatientWard.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientWard.ForeColor = System.Drawing.Color.White
        Me.lblPatientWard.Location = New System.Drawing.Point(6, 20)
        Me.lblPatientWard.Name = "lblPatientWard"
        Me.lblPatientWard.Size = New System.Drawing.Size(164, 23)
        Me.lblPatientWard.TabIndex = 9
        Me.lblPatientWard.Text = "PATIENT NAME :"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.White
        Me.LabelX3.Location = New System.Drawing.Point(6, 81)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(111, 23)
        Me.LabelX3.TabIndex = 24
        Me.LabelX3.Text = "CHARGING :"
        '
        'txtPatientTypeID
        '
        '
        '
        '
        Me.txtPatientTypeID.Border.Class = "TextBoxBorder"
        Me.txtPatientTypeID.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientTypeID.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPatientTypeID.Location = New System.Drawing.Point(686, 3)
        Me.txtPatientTypeID.Name = "txtPatientTypeID"
        Me.txtPatientTypeID.ReadOnly = True
        Me.txtPatientTypeID.Size = New System.Drawing.Size(74, 28)
        Me.txtPatientTypeID.TabIndex = 21
        Me.txtPatientTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPatientTypeID.Visible = False
        '
        'rbtnWard
        '
        Me.rbtnWard.AutoSize = True
        Me.rbtnWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtnWard.Location = New System.Drawing.Point(397, 10)
        Me.rbtnWard.Name = "rbtnWard"
        Me.rbtnWard.Size = New System.Drawing.Size(77, 24)
        Me.rbtnWard.TabIndex = 8
        Me.rbtnWard.Text = "WARD"
        Me.rbtnWard.UseVisualStyleBackColor = True
        '
        'rbtnPatient
        '
        Me.rbtnPatient.AutoSize = True
        Me.rbtnPatient.Checked = True
        Me.rbtnPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtnPatient.Location = New System.Drawing.Point(234, 10)
        Me.rbtnPatient.Name = "rbtnPatient"
        Me.rbtnPatient.Size = New System.Drawing.Size(93, 24)
        Me.rbtnPatient.TabIndex = 7
        Me.rbtnPatient.TabStop = True
        Me.rbtnPatient.Text = "PATIENT"
        Me.rbtnPatient.UseVisualStyleBackColor = True
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.White
        Me.LabelX6.Location = New System.Drawing.Point(544, 170)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(89, 29)
        Me.LabelX6.TabIndex = 5
        Me.LabelX6.Text = "TRANS #."
        '
        'txtTransNum
        '
        '
        '
        '
        Me.txtTransNum.Border.Class = "TextBoxBorder"
        Me.txtTransNum.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransNum.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTransNum.Location = New System.Drawing.Point(650, 170)
        Me.txtTransNum.Name = "txtTransNum"
        Me.txtTransNum.ReadOnly = True
        Me.txtTransNum.Size = New System.Drawing.Size(173, 30)
        Me.txtTransNum.TabIndex = 4
        Me.txtTransNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(10, 158)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(70, 48)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "CODE"
        '
        'txtItemCode
        '
        '
        '
        '
        Me.txtItemCode.Border.Class = "TextBoxBorder"
        Me.txtItemCode.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.ForeColor = System.Drawing.Color.Tomato
        Me.txtItemCode.Location = New System.Drawing.Point(86, 170)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(319, 30)
        Me.txtItemCode.TabIndex = 0
        Me.txtItemCode.Text = "Enter Item Code ..."
        '
        'txtQty
        '
        '
        '
        '
        Me.txtQty.Border.Class = "TextBoxBorder"
        Me.txtQty.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Tomato
        Me.txtQty.Location = New System.Drawing.Point(462, 171)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(69, 30)
        Me.txtQty.TabIndex = 1
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(410, 170)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(52, 29)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "QTY"
        '
        'btnSelectItem
        '
        Me.btnSelectItem.Location = New System.Drawing.Point(468, 187)
        Me.btnSelectItem.Name = "btnSelectItem"
        Me.btnSelectItem.Size = New System.Drawing.Size(45, 8)
        Me.btnSelectItem.TabIndex = 6
        Me.btnSelectItem.Text = "select"
        Me.btnSelectItem.UseVisualStyleBackColor = True
        '
        'txtPatientCode
        '
        '
        '
        '
        Me.txtPatientCode.Border.Class = "TextBoxBorder"
        Me.txtPatientCode.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientCode.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPatientCode.Location = New System.Drawing.Point(761, 44)
        Me.txtPatientCode.Name = "txtPatientCode"
        Me.txtPatientCode.ReadOnly = True
        Me.txtPatientCode.Size = New System.Drawing.Size(35, 28)
        Me.txtPatientCode.TabIndex = 14
        Me.txtPatientCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPatientCode.Visible = False
        '
        'txtChargingID
        '
        '
        '
        '
        Me.txtChargingID.Border.Class = "TextBoxBorder"
        Me.txtChargingID.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargingID.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtChargingID.Location = New System.Drawing.Point(761, 111)
        Me.txtChargingID.Name = "txtChargingID"
        Me.txtChargingID.ReadOnly = True
        Me.txtChargingID.Size = New System.Drawing.Size(35, 28)
        Me.txtChargingID.TabIndex = 25
        Me.txtChargingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtChargingID.Visible = False
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.LabelX4)
        Me.GroupPanel3.Controls.Add(Me.txtTotalAmt)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 619)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Padding = New System.Windows.Forms.Padding(0, 4, 4, 8)
        Me.GroupPanel3.Size = New System.Drawing.Size(845, 63)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 6
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(485, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(135, 45)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "TOTAL"
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.BackColor = System.Drawing.SystemColors.InfoText
        '
        '
        '
        Me.txtTotalAmt.Border.Class = "TextBoxBorder"
        Me.txtTotalAmt.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmt.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalAmt.Location = New System.Drawing.Point(620, 4)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.Size = New System.Drawing.Size(215, 53)
        Me.txtTotalAmt.TabIndex = 1
        Me.txtTotalAmt.Text = "0.00"
        Me.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'fmaPointOfSaleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1374, 833)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaPointOfSaleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel9.ResumeLayout(False)
        Me.GroupPanel9.PerformLayout()
        Me.GroupPanel8.ResumeLayout(False)
        Me.GroupPanel8.PerformLayout()
        CType(Me.qty_unfilled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel10.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.ITEMS.ResumeLayout(False)
        Me.GroupPanel7.ResumeLayout(False)
        CType(Me.dtgvOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel6.ResumeLayout(False)
        Me.GroupPanel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ITEMS As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtItemCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnVoid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNewSale As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnInq As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSetQty As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtQty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRemoveItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotalAmt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dtgvOrderList As System.Windows.Forms.DataGridView
    Friend WithEvents btnSetDisc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPay As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTransNum As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel8 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtVAT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cxboxVAT As System.Windows.Forms.CheckBox
    Friend WithEvents GroupPanel9 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblSysMsg As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPostPayment As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAddItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel10 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblDate As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents cxbxdirectPrinting As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelectItem As System.Windows.Forms.Button
    Friend WithEvents rbtnWard As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPatient As System.Windows.Forms.RadioButton
    Friend WithEvents lblPayableAmount As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAmtDue As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents linkAddPatient As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPatientTypeID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtChargeTo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOSCA As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRefNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtORNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPatientCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPatientProfile As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPatientWard As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCharging As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtChargingID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSetPatient As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDisplayCost As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAddPatient As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cxbxSCDiscount As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cxbxUnfilledPrx As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cxbxDiscounted As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtDiscount As DevComponents.Editors.DoubleInput
    Friend WithEvents txtRIS_Det_No As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents qty_unfilled As DevComponents.Editors.DoubleInput
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents consigneeid As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
