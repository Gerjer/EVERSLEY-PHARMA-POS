<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyProfileSetup
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanyProfileSetup))
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.pic_box_save = New System.Windows.Forms.PictureBox
        Me.btnOK = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.txtDisplayName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtPhotoPath_Empl = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtAddress = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pic_box_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(293, 36)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(173, 17)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "COMPANY DISPLAY NAME"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.pic_box_save)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(262, 233)
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
        Me.GroupPanel1.TabIndex = 10
        Me.GroupPanel1.Text = "COMPANY LOGO"
        '
        'pic_box_save
        '
        Me.pic_box_save.BackgroundImage = CType(resources.GetObject("pic_box_save.BackgroundImage"), System.Drawing.Image)
        Me.pic_box_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_box_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_box_save.Location = New System.Drawing.Point(0, 0)
        Me.pic_box_save.Name = "pic_box_save"
        Me.pic_box_save.Size = New System.Drawing.Size(256, 212)
        Me.pic_box_save.TabIndex = 0
        Me.pic_box_save.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(472, 269)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(128, 39)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(606, 269)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 39)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "CANCEL"
        '
        'txtDisplayName
        '
        Me.txtDisplayName.AccessibleName = "users"
        '
        '
        '
        Me.txtDisplayName.Border.Class = "TextBoxBorder"
        Me.txtDisplayName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDisplayName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtDisplayName.FocusHighlightEnabled = True
        Me.txtDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDisplayName.Location = New System.Drawing.Point(472, 30)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(262, 23)
        Me.txtDisplayName.TabIndex = 11
        Me.txtDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhotoPath_Empl
        '
        Me.txtPhotoPath_Empl.AccessibleName = "employees"
        '
        '
        '
        Me.txtPhotoPath_Empl.Border.Class = "TextBoxBorder"
        Me.txtPhotoPath_Empl.ButtonCustom.Text = "Browse"
        Me.txtPhotoPath_Empl.ButtonCustom.Visible = True
        Me.txtPhotoPath_Empl.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPhotoPath_Empl.FocusHighlightEnabled = True
        Me.txtPhotoPath_Empl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPhotoPath_Empl.Location = New System.Drawing.Point(12, 248)
        Me.txtPhotoPath_Empl.Name = "txtPhotoPath_Empl"
        Me.txtPhotoPath_Empl.Size = New System.Drawing.Size(262, 20)
        Me.txtPhotoPath_Empl.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(399, 75)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(67, 17)
        Me.LabelX1.TabIndex = 31
        Me.LabelX1.Text = "ADDRESS"
        '
        'txtAddress
        '
        Me.txtAddress.AccessibleName = "users"
        '
        '
        '
        Me.txtAddress.Border.Class = "TextBoxBorder"
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtAddress.FocusHighlightEnabled = True
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAddress.Location = New System.Drawing.Point(472, 69)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(262, 108)
        Me.txtAddress.TabIndex = 12
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(325, 196)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(141, 17)
        Me.LabelX3.TabIndex = 33
        Me.LabelX3.Text = "CONTACT NUMBER/S"
        '
        'txtContact
        '
        Me.txtContact.AccessibleName = "users"
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContact.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtContact.FocusHighlightEnabled = True
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContact.Location = New System.Drawing.Point(472, 190)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(262, 23)
        Me.txtContact.TabIndex = 13
        '
        'frmCompanyProfileSetup
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(749, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtPhotoPath_Empl)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.LabelX2)
        Me.Name = "frmCompanyProfileSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.pic_box_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pic_box_save As System.Windows.Forms.PictureBox
    Friend WithEvents txtDisplayName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPhotoPath_Empl As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ofdBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
End Class
