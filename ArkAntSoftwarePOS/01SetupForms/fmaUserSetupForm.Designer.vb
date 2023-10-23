<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaUserSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaUserSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtUserFull_name = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtType_User = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.txtSysPK_User = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword_User = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUserName_User = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.txtList = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(424, 28)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "User Setup"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.txtUserFull_name)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.txtType_User)
        Me.GroupPanel1.Controls.Add(Me.txtSysPK_User)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.txtPassword_User)
        Me.GroupPanel1.Controls.Add(Me.txtUserName_User)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(424, 239)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
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
        Me.GroupPanel1.TabIndex = 1
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(37, 49)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(60, 18)
        Me.LabelX4.TabIndex = 11
        Me.LabelX4.Text = "FullName"
        '
        'txtUserFull_name
        '
        Me.txtUserFull_name.AccessibleName = "users"
        '
        '
        '
        Me.txtUserFull_name.Border.Class = "TextBoxBorder"
        Me.txtUserFull_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserFull_name.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtUserFull_name.FocusHighlightEnabled = True
        Me.txtUserFull_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserFull_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUserFull_name.Location = New System.Drawing.Point(105, 47)
        Me.txtUserFull_name.Name = "txtUserFull_name"
        Me.txtUserFull_name.Size = New System.Drawing.Size(273, 23)
        Me.txtUserFull_name.TabIndex = 2
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(37, 112)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(32, 18)
        Me.LabelX3.TabIndex = 9
        Me.LabelX3.Text = "Type"
        '
        'txtType_User
        '
        Me.txtType_User.AccessibleName = "users"
        Me.txtType_User.DisplayMember = "Text"
        Me.txtType_User.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtType_User.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtType_User.FocusHighlightEnabled = True
        Me.txtType_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType_User.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtType_User.FormattingEnabled = True
        Me.txtType_User.ItemHeight = 17
        Me.txtType_User.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem4})
        Me.txtType_User.Location = New System.Drawing.Point(105, 110)
        Me.txtType_User.Name = "txtType_User"
        Me.txtType_User.Size = New System.Drawing.Size(273, 23)
        Me.txtType_User.TabIndex = 4
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Supervisor"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Cashier"
        '
        'txtSysPK_User
        '
        '
        '
        '
        Me.txtSysPK_User.Border.Class = "TextBoxBorder"
        Me.txtSysPK_User.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSysPK_User.FocusHighlightEnabled = True
        Me.txtSysPK_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysPK_User.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSysPK_User.Location = New System.Drawing.Point(105, 139)
        Me.txtSysPK_User.Name = "txtSysPK_User"
        Me.txtSysPK_User.Size = New System.Drawing.Size(128, 23)
        Me.txtSysPK_User.TabIndex = 5
        Me.txtSysPK_User.TabStop = False
        Me.txtSysPK_User.Tag = "users"
        Me.txtSysPK_User.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(37, 81)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(61, 18)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Password"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(37, 18)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(66, 18)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "UserName"
        '
        'txtPassword_User
        '
        Me.txtPassword_User.AccessibleName = "users"
        '
        '
        '
        Me.txtPassword_User.Border.Class = "TextBoxBorder"
        Me.txtPassword_User.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPassword_User.FocusHighlightEnabled = True
        Me.txtPassword_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword_User.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPassword_User.Location = New System.Drawing.Point(105, 78)
        Me.txtPassword_User.Name = "txtPassword_User"
        Me.txtPassword_User.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword_User.Size = New System.Drawing.Size(273, 23)
        Me.txtPassword_User.TabIndex = 3
        '
        'txtUserName_User
        '
        Me.txtUserName_User.AccessibleName = "users"
        '
        '
        '
        Me.txtUserName_User.Border.Class = "TextBoxBorder"
        Me.txtUserName_User.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtUserName_User.FocusHighlightEnabled = True
        Me.txtUserName_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName_User.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUserName_User.Location = New System.Drawing.Point(105, 17)
        Me.txtUserName_User.Name = "txtUserName_User"
        Me.txtUserName_User.Size = New System.Drawing.Size(273, 23)
        Me.txtUserName_User.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(323, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 37)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(100, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnDelete.Size = New System.Drawing.Size(93, 37)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(224, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(93, 37)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        '
        'txtList
        '
        Me.txtList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.txtList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.txtList.Image = CType(resources.GetObject("txtList.Image"), System.Drawing.Image)
        Me.txtList.Location = New System.Drawing.Point(1, 5)
        Me.txtList.Name = "txtList"
        Me.txtList.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.txtList.Size = New System.Drawing.Size(93, 37)
        Me.txtList.TabIndex = 7
        Me.txtList.Text = "List's"
        Me.txtList.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtList)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 46)
        Me.Panel1.TabIndex = 9
        '
        'fmaUserSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(424, 267)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 400)
        Me.MinimumSize = New System.Drawing.Size(424, 306)
        Me.Name = "fmaUserSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Setup Form"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtUserName_User As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword_User As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSysPK_User As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtType_User As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUserFull_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As Panel
End Class
