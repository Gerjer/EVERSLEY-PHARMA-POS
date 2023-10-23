<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaInventoryReplenishmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaInventoryReplenishmentForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtRIS_no = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtitemremarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtconsignee = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtinv_qty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRemStocks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txta_name = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txta_code = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSysPK = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtconsignee_id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtInvSys = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFundClass_id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(529, 34)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'WinLabel
        '
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(529, 28)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "Inventory Replenishment Information"
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
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtFundClass_id)
        Me.GroupPanel2.Controls.Add(Me.txtRIS_no)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.txtitemremarks)
        Me.GroupPanel2.Controls.Add(Me.RadioButton2)
        Me.GroupPanel2.Controls.Add(Me.RadioButton1)
        Me.GroupPanel2.Controls.Add(Me.txtconsignee)
        Me.GroupPanel2.Controls.Add(Me.LabelX12)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.txtinv_qty)
        Me.GroupPanel2.Controls.Add(Me.txtRemStocks)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.txta_name)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.txta_code)
        Me.GroupPanel2.Controls.Add(Me.txtSysPK)
        Me.GroupPanel2.Controls.Add(Me.txtconsignee_id)
        Me.GroupPanel2.Controls.Add(Me.txtInvSys)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 34)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(529, 419)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
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
        Me.GroupPanel2.TabIndex = 15
        '
        'txtRIS_no
        '
        Me.txtRIS_no.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtRIS_no.Border.Class = "TextBoxBorder"
        Me.txtRIS_no.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtRIS_no.FocusHighlightEnabled = True
        Me.txtRIS_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRIS_no.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRIS_no.Location = New System.Drawing.Point(488, 162)
        Me.txtRIS_no.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRIS_no.Name = "txtRIS_no"
        Me.txtRIS_no.Size = New System.Drawing.Size(31, 23)
        Me.txtRIS_no.TabIndex = 188
        Me.txtRIS_no.Tag = ""
        Me.txtRIS_no.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 343)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 70)
        Me.Panel1.TabIndex = 187
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(370, 16)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(124, 38)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(28, 25)
        Me.btnSave.Location = New System.Drawing.Point(238, 16)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(124, 38)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(15, 231)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(144, 19)
        Me.LabelX5.TabIndex = 182
        Me.LabelX5.Text = "Reference / Remarks"
        '
        'txtitemremarks
        '
        Me.txtitemremarks.AccessibleName = "pharmaceuticals"
        '
        '
        '
        Me.txtitemremarks.Border.Class = "TextBoxBorder"
        Me.txtitemremarks.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtitemremarks.FocusHighlightEnabled = True
        Me.txtitemremarks.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtitemremarks.Location = New System.Drawing.Point(168, 226)
        Me.txtitemremarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtitemremarks.Multiline = True
        Me.txtitemremarks.Name = "txtitemremarks"
        Me.txtitemremarks.Size = New System.Drawing.Size(318, 96)
        Me.txtitemremarks.TabIndex = 181
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(174, 189)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 22)
        Me.RadioButton2.TabIndex = 180
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pull-out"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(344, 190)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(81, 22)
        Me.RadioButton1.TabIndex = 179
        Me.RadioButton1.Text = "Delivery"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'txtconsignee
        '
        Me.txtconsignee.AccessibleName = "inventory_master"
        Me.txtconsignee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtconsignee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtconsignee.DisplayMember = "Text"
        Me.txtconsignee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtconsignee.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtconsignee.FocusHighlightEnabled = True
        Me.txtconsignee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconsignee.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtconsignee.FormattingEnabled = True
        Me.txtconsignee.ItemHeight = 18
        Me.txtconsignee.Location = New System.Drawing.Point(163, 54)
        Me.txtconsignee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtconsignee.Name = "txtconsignee"
        Me.txtconsignee.Size = New System.Drawing.Size(318, 24)
        Me.txtconsignee.TabIndex = 176
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(15, 57)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(74, 19)
        Me.LabelX12.TabIndex = 177
        Me.LabelX12.Text = "Consignee"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(15, 120)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(123, 19)
        Me.LabelX2.TabIndex = 158
        Me.LabelX2.Text = "Remaining Stocks"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(15, 152)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(133, 19)
        Me.LabelX4.TabIndex = 157
        Me.LabelX4.Text = "Quantity Pulled-Out"
        '
        'txtinv_qty
        '
        Me.txtinv_qty.AccessibleName = "inventory_master"
        '
        '
        '
        Me.txtinv_qty.Border.Class = "TextBoxBorder"
        Me.txtinv_qty.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtinv_qty.FocusHighlightEnabled = True
        Me.txtinv_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinv_qty.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtinv_qty.Location = New System.Drawing.Point(163, 150)
        Me.txtinv_qty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinv_qty.Name = "txtinv_qty"
        Me.txtinv_qty.Size = New System.Drawing.Size(318, 24)
        Me.txtinv_qty.TabIndex = 156
        Me.txtinv_qty.Text = "0.00"
        Me.txtinv_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemStocks
        '
        Me.txtRemStocks.AccessibleName = "inventory_master"
        '
        '
        '
        Me.txtRemStocks.Border.Class = "TextBoxBorder"
        Me.txtRemStocks.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtRemStocks.FocusHighlightEnabled = True
        Me.txtRemStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemStocks.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRemStocks.Location = New System.Drawing.Point(163, 118)
        Me.txtRemStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemStocks.Name = "txtRemStocks"
        Me.txtRemStocks.ReadOnly = True
        Me.txtRemStocks.Size = New System.Drawing.Size(318, 24)
        Me.txtRemStocks.TabIndex = 155
        Me.txtRemStocks.Tag = ""
        Me.txtRemStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(15, 87)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(76, 19)
        Me.LabelX3.TabIndex = 152
        Me.LabelX3.Text = "Item Name"
        '
        'txta_name
        '
        Me.txta_name.AccessibleName = "inventory_master"
        Me.txta_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txta_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txta_name.DisplayMember = "Text"
        Me.txta_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txta_name.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txta_name.FocusHighlightEnabled = True
        Me.txta_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txta_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txta_name.FormattingEnabled = True
        Me.txta_name.ItemHeight = 18
        Me.txta_name.Location = New System.Drawing.Point(163, 86)
        Me.txta_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txta_name.Name = "txta_name"
        Me.txta_name.Size = New System.Drawing.Size(318, 24)
        Me.txta_name.TabIndex = 151
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(15, 27)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(38, 19)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "Code"
        '
        'txta_code
        '
        Me.txta_code.AccessibleName = "inventory_master"
        '
        '
        '
        Me.txta_code.Border.Class = "TextBoxBorder"
        Me.txta_code.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txta_code.FocusHighlightEnabled = True
        Me.txta_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txta_code.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txta_code.Location = New System.Drawing.Point(163, 22)
        Me.txta_code.Margin = New System.Windows.Forms.Padding(4)
        Me.txta_code.Name = "txta_code"
        Me.txta_code.Size = New System.Drawing.Size(318, 24)
        Me.txta_code.TabIndex = 2
        '
        'txtSysPK
        '
        Me.txtSysPK.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtSysPK.Border.Class = "TextBoxBorder"
        Me.txtSysPK.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSysPK.FocusHighlightEnabled = True
        Me.txtSysPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysPK.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSysPK.Location = New System.Drawing.Point(489, 131)
        Me.txtSysPK.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSysPK.Name = "txtSysPK"
        Me.txtSysPK.Size = New System.Drawing.Size(31, 23)
        Me.txtSysPK.TabIndex = 186
        Me.txtSysPK.Tag = ""
        Me.txtSysPK.Visible = False
        '
        'txtconsignee_id
        '
        Me.txtconsignee_id.AccessibleName = ""
        '
        '
        '
        Me.txtconsignee_id.Border.Class = "TextBoxBorder"
        Me.txtconsignee_id.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtconsignee_id.FocusHighlightEnabled = True
        Me.txtconsignee_id.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtconsignee_id.Location = New System.Drawing.Point(489, 99)
        Me.txtconsignee_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txtconsignee_id.Name = "txtconsignee_id"
        Me.txtconsignee_id.Size = New System.Drawing.Size(31, 22)
        Me.txtconsignee_id.TabIndex = 178
        Me.txtconsignee_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtconsignee_id.Visible = False
        '
        'txtInvSys
        '
        Me.txtInvSys.AccessibleName = "inventory_master"
        '
        '
        '
        Me.txtInvSys.Border.Class = "TextBoxBorder"
        Me.txtInvSys.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtInvSys.FocusHighlightEnabled = True
        Me.txtInvSys.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtInvSys.Location = New System.Drawing.Point(489, 69)
        Me.txtInvSys.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvSys.Name = "txtInvSys"
        Me.txtInvSys.Size = New System.Drawing.Size(31, 22)
        Me.txtInvSys.TabIndex = 159
        Me.txtInvSys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInvSys.Visible = False
        '
        'txtFundClass_id
        '
        Me.txtFundClass_id.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtFundClass_id.Border.Class = "TextBoxBorder"
        Me.txtFundClass_id.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtFundClass_id.FocusHighlightEnabled = True
        Me.txtFundClass_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFundClass_id.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtFundClass_id.Location = New System.Drawing.Point(488, 195)
        Me.txtFundClass_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFundClass_id.Name = "txtFundClass_id"
        Me.txtFundClass_id.Size = New System.Drawing.Size(31, 23)
        Me.txtFundClass_id.TabIndex = 189
        Me.txtFundClass_id.Tag = ""
        Me.txtFundClass_id.Visible = False
        '
        'fmaInventoryReplenishmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(529, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fmaInventoryReplenishmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArkAnt: Inventory Replenishment Setup"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txta_code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txta_name As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtRemStocks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtinv_qty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtInvSys As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtconsignee As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtconsignee_id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtitemremarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSysPK As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRIS_no As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFundClass_id As DevComponents.DotNetBar.Controls.TextBoxX
End Class
