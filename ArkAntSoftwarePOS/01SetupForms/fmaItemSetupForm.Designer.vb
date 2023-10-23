<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaItemSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaItemSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtmedtype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtbrand_name = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnModify = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnList = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtSysPK_Item = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtItem_Description = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtItem_Display = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtItem_Code = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
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
        Me.PanelEx1.Size = New System.Drawing.Size(1009, 34)
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
        Me.WinLabel.Size = New System.Drawing.Size(1009, 34)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "Item Data Information"
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
        Me.GroupPanel2.Controls.Add(Me.txtmedtype)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.txtbrand_name)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.btnModify)
        Me.GroupPanel2.Controls.Add(Me.btnCancel)
        Me.GroupPanel2.Controls.Add(Me.btnList)
        Me.GroupPanel2.Controls.Add(Me.btnAdd)
        Me.GroupPanel2.Controls.Add(Me.btnSave)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.txtSysPK_Item)
        Me.GroupPanel2.Controls.Add(Me.txtItem_Description)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.txtItem_Display)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.txtItem_Code)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 34)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1009, 661)
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
        'txtmedtype
        '
        Me.txtmedtype.AccessibleName = "product_item"
        Me.txtmedtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtmedtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtmedtype.DisplayMember = "Text"
        Me.txtmedtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtmedtype.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtmedtype.FocusHighlightEnabled = True
        Me.txtmedtype.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtmedtype.FormattingEnabled = True
        Me.txtmedtype.ItemHeight = 14
        Me.txtmedtype.Location = New System.Drawing.Point(136, 225)
        Me.txtmedtype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmedtype.Name = "txtmedtype"
        Me.txtmedtype.Size = New System.Drawing.Size(251, 20)
        Me.txtmedtype.TabIndex = 5
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(33, 231)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(87, 17)
        Me.LabelX5.TabIndex = 152
        Me.LabelX5.Text = "Medicine Type"
        '
        'txtbrand_name
        '
        Me.txtbrand_name.AccessibleName = "product_item"
        Me.txtbrand_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtbrand_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtbrand_name.DisplayMember = "Text"
        Me.txtbrand_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtbrand_name.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtbrand_name.FocusHighlightEnabled = True
        Me.txtbrand_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtbrand_name.FormattingEnabled = True
        Me.txtbrand_name.ItemHeight = 14
        Me.txtbrand_name.Location = New System.Drawing.Point(136, 180)
        Me.txtbrand_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbrand_name.Name = "txtbrand_name"
        Me.txtbrand_name.Size = New System.Drawing.Size(251, 20)
        Me.txtbrand_name.TabIndex = 4
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(33, 187)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(65, 17)
        Me.LabelX4.TabIndex = 150
        Me.LabelX4.Text = "Consignee"
        '
        'btnModify
        '
        Me.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.Location = New System.Drawing.Point(396, 107)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnModify.Size = New System.Drawing.Size(65, 38)
        Me.btnModify.TabIndex = 148
        Me.btnModify.Text = "Modify"
        Me.btnModify.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(179, 292)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(124, 38)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnList
        '
        Me.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.Location = New System.Drawing.Point(396, 62)
        Me.btnList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnList.Name = "btnList"
        Me.btnList.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.btnList.Size = New System.Drawing.Size(65, 38)
        Me.btnList.TabIndex = 20
        Me.btnList.Text = "List's"
        Me.btnList.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(323, 292)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(124, 38)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(33, 292)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(124, 38)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(33, 107)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(68, 17)
        Me.LabelX3.TabIndex = 19
        Me.LabelX3.Text = "Description"
        '
        'txtSysPK_Item
        '
        Me.txtSysPK_Item.AccessibleName = ""
        '
        '
        '
        Me.txtSysPK_Item.Border.Class = "TextBoxBorder"
        Me.txtSysPK_Item.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSysPK_Item.FocusHighlightEnabled = True
        Me.txtSysPK_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysPK_Item.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSysPK_Item.Location = New System.Drawing.Point(396, 22)
        Me.txtSysPK_Item.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSysPK_Item.Name = "txtSysPK_Item"
        Me.txtSysPK_Item.Size = New System.Drawing.Size(65, 23)
        Me.txtSysPK_Item.TabIndex = 19
        Me.txtSysPK_Item.Tag = "product_item"
        Me.txtSysPK_Item.Visible = False
        '
        'txtItem_Description
        '
        Me.txtItem_Description.AccessibleName = "product_item"
        '
        '
        '
        Me.txtItem_Description.Border.Class = "TextBoxBorder"
        Me.txtItem_Description.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtItem_Description.FocusHighlightEnabled = True
        Me.txtItem_Description.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtItem_Description.Location = New System.Drawing.Point(136, 101)
        Me.txtItem_Description.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItem_Description.Multiline = True
        Me.txtItem_Description.Name = "txtItem_Description"
        Me.txtItem_Description.ReadOnly = True
        Me.txtItem_Description.Size = New System.Drawing.Size(252, 73)
        Me.txtItem_Description.TabIndex = 18
        Me.txtItem_Description.TabStop = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(33, 68)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 17)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "Display Name"
        '
        'txtItem_Display
        '
        Me.txtItem_Display.AccessibleName = "product_item"
        '
        '
        '
        Me.txtItem_Display.Border.Class = "TextBoxBorder"
        Me.txtItem_Display.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItem_Display.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtItem_Display.FocusHighlightEnabled = True
        Me.txtItem_Display.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtItem_Display.Location = New System.Drawing.Point(136, 62)
        Me.txtItem_Display.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItem_Display.MaxLength = 30
        Me.txtItem_Display.Name = "txtItem_Display"
        Me.txtItem_Display.Size = New System.Drawing.Size(252, 22)
        Me.txtItem_Display.TabIndex = 3
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(33, 28)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(34, 17)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "Code"
        '
        'txtItem_Code
        '
        Me.txtItem_Code.AccessibleName = "product_item"
        '
        '
        '
        Me.txtItem_Code.Border.Class = "TextBoxBorder"
        Me.txtItem_Code.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtItem_Code.FocusHighlightEnabled = True
        Me.txtItem_Code.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtItem_Code.Location = New System.Drawing.Point(136, 22)
        Me.txtItem_Code.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItem_Code.Name = "txtItem_Code"
        Me.txtItem_Code.Size = New System.Drawing.Size(252, 22)
        Me.txtItem_Code.TabIndex = 2
        '
        'fmaItemSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1009, 695)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fmaItemSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArkAnt: Item Setup Form"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSysPK_Item As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtItem_Code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtItem_Description As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtItem_Display As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtbrand_name As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtmedtype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
End Class
