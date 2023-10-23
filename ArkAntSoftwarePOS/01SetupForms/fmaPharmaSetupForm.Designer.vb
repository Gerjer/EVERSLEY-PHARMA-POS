<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaPharmaSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaPharmaSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.WinLabel = New DevComponents.DotNetBar.LabelX
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtpaymentgroup = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtcontactNum = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnModify = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnList = New DevComponents.DotNetBar.ButtonX
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtSysPK = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtaddress = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txta_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txta_code = New DevComponents.DotNetBar.Controls.TextBoxX
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
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(366, 28)
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
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(366, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "Pharma Data Information"
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
        Me.GroupPanel2.Controls.Add(Me.txtpaymentgroup)
        Me.GroupPanel2.Controls.Add(Me.RadioButton2)
        Me.GroupPanel2.Controls.Add(Me.RadioButton1)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.txtcontactNum)
        Me.GroupPanel2.Controls.Add(Me.btnModify)
        Me.GroupPanel2.Controls.Add(Me.btnCancel)
        Me.GroupPanel2.Controls.Add(Me.btnList)
        Me.GroupPanel2.Controls.Add(Me.btnAdd)
        Me.GroupPanel2.Controls.Add(Me.btnSave)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.txtSysPK)
        Me.GroupPanel2.Controls.Add(Me.txtaddress)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.txta_name)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.txta_code)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(366, 359)
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
        'txtpaymentgroup
        '
        Me.txtpaymentgroup.AccessibleName = "pharmaceuticals"
        '
        '
        '
        Me.txtpaymentgroup.Border.Class = "TextBoxBorder"
        Me.txtpaymentgroup.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtpaymentgroup.FocusHighlightEnabled = True
        Me.txtpaymentgroup.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtpaymentgroup.Location = New System.Drawing.Point(25, 136)
        Me.txtpaymentgroup.Name = "txtpaymentgroup"
        Me.txtpaymentgroup.Size = New System.Drawing.Size(32, 20)
        Me.txtpaymentgroup.TabIndex = 154
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton2.Location = New System.Drawing.Point(198, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton2.TabIndex = 153
        Me.RadioButton2.Text = "GOVERNMENT"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton1.Location = New System.Drawing.Point(111, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton1.TabIndex = 152
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PRIVATE"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(25, 27)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(52, 15)
        Me.LabelX5.TabIndex = 151
        Me.LabelX5.Text = "PayGroup"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(25, 198)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(82, 15)
        Me.LabelX4.TabIndex = 150
        Me.LabelX4.Text = "Contact Number"
        '
        'txtcontactNum
        '
        Me.txtcontactNum.AccessibleName = "pharmaceuticals"
        '
        '
        '
        Me.txtcontactNum.Border.Class = "TextBoxBorder"
        Me.txtcontactNum.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtcontactNum.FocusHighlightEnabled = True
        Me.txtcontactNum.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcontactNum.Location = New System.Drawing.Point(111, 193)
        Me.txtcontactNum.Name = "txtcontactNum"
        Me.txtcontactNum.Size = New System.Drawing.Size(189, 20)
        Me.txtcontactNum.TabIndex = 149
        '
        'btnModify
        '
        Me.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.Location = New System.Drawing.Point(310, 87)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnModify.Size = New System.Drawing.Size(49, 31)
        Me.btnModify.TabIndex = 148
        Me.btnModify.Text = "Modify"
        Me.btnModify.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(134, 251)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 31)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        '
        'btnList
        '
        Me.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.Location = New System.Drawing.Point(310, 50)
        Me.btnList.Name = "btnList"
        Me.btnList.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.btnList.Size = New System.Drawing.Size(49, 31)
        Me.btnList.TabIndex = 20
        Me.btnList.Text = "List's"
        Me.btnList.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(242, 251)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(93, 31)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(25, 251)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 31)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(25, 92)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(43, 15)
        Me.LabelX3.TabIndex = 19
        Me.LabelX3.Text = "Address"
        '
        'txtSysPK
        '
        Me.txtSysPK.AccessibleName = ""
        '
        '
        '
        Me.txtSysPK.Border.Class = "TextBoxBorder"
        Me.txtSysPK.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSysPK.FocusHighlightEnabled = True
        Me.txtSysPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysPK.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSysPK.Location = New System.Drawing.Point(310, 2)
        Me.txtSysPK.Name = "txtSysPK"
        Me.txtSysPK.Size = New System.Drawing.Size(49, 20)
        Me.txtSysPK.TabIndex = 19
        Me.txtSysPK.Tag = "pharmaceuticals"
        Me.txtSysPK.Visible = False
        '
        'txtaddress
        '
        Me.txtaddress.AccessibleName = "pharmaceuticals"
        '
        '
        '
        Me.txtaddress.Border.Class = "TextBoxBorder"
        Me.txtaddress.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtaddress.FocusHighlightEnabled = True
        Me.txtaddress.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtaddress.Location = New System.Drawing.Point(111, 87)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(189, 100)
        Me.txtaddress.TabIndex = 18
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(25, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(82, 15)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "Company Name"
        '
        'txta_name
        '
        Me.txta_name.AccessibleName = "pharmaceuticals"
        '
        '
        '
        Me.txta_name.Border.Class = "TextBoxBorder"
        Me.txta_name.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txta_name.FocusHighlightEnabled = True
        Me.txta_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txta_name.Location = New System.Drawing.Point(111, 55)
        Me.txta_name.Name = "txta_name"
        Me.txta_name.Size = New System.Drawing.Size(189, 20)
        Me.txta_name.TabIndex = 16
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(25, 7)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(29, 15)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "Code"
        Me.LabelX1.Visible = False
        '
        'txta_code
        '
        Me.txta_code.AccessibleName = "pharmaceuticals"
        '
        '
        '
        Me.txta_code.Border.Class = "TextBoxBorder"
        Me.txta_code.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txta_code.FocusHighlightEnabled = True
        Me.txta_code.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txta_code.Location = New System.Drawing.Point(111, 2)
        Me.txta_code.Name = "txta_code"
        Me.txta_code.Size = New System.Drawing.Size(189, 20)
        Me.txta_code.TabIndex = 2
        Me.txta_code.Visible = False
        '
        'fmaPharmaSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(366, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaPharmaSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArkAnt: Pharmaceuticals Setup"
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
    Friend WithEvents txtSysPK As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txta_code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtaddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txta_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcontactNum As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtpaymentgroup As DevComponents.DotNetBar.Controls.TextBoxX
End Class
