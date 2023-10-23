<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaReplinishmentSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaReplinishmentSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.WinLabel = New DevComponents.DotNetBar.LabelX
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtSysPK = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.txtitemremarks = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtdate_added = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.cpyPulloutQty = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cpyDelQty = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.txtpullout_qty = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtadded_qty = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.txtdate_modified = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.txtmodify_user = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.btnModify = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnList = New DevComponents.DotNetBar.ButtonX
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.txtSysPK_INVMaster = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtitem_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtitem_code = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.txtdate_added, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdate_modified, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelEx1.Size = New System.Drawing.Size(510, 28)
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
        Me.WinLabel.Size = New System.Drawing.Size(510, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "Delivery / Pull-out"
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
        Me.GroupPanel2.Controls.Add(Me.txtSysPK)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.txtitemremarks)
        Me.GroupPanel2.Controls.Add(Me.txtdate_added)
        Me.GroupPanel2.Controls.Add(Me.cpyPulloutQty)
        Me.GroupPanel2.Controls.Add(Me.cpyDelQty)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.txtpullout_qty)
        Me.GroupPanel2.Controls.Add(Me.txtadded_qty)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.txtdate_modified)
        Me.GroupPanel2.Controls.Add(Me.txtmodify_user)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.btnModify)
        Me.GroupPanel2.Controls.Add(Me.btnCancel)
        Me.GroupPanel2.Controls.Add(Me.btnList)
        Me.GroupPanel2.Controls.Add(Me.btnAdd)
        Me.GroupPanel2.Controls.Add(Me.btnSave)
        Me.GroupPanel2.Controls.Add(Me.txtSysPK_INVMaster)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.txtitem_name)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.txtitem_code)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(510, 334)
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
        Me.txtSysPK.Location = New System.Drawing.Point(352, 50)
        Me.txtSysPK.Name = "txtSysPK"
        Me.txtSysPK.Size = New System.Drawing.Size(147, 20)
        Me.txtSysPK.TabIndex = 185
        Me.txtSysPK.Tag = "inventory_replenishment"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(25, 149)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(106, 15)
        Me.LabelX7.TabIndex = 184
        Me.LabelX7.Text = "Reference / Remarks"
        '
        'txtitemremarks
        '
        Me.txtitemremarks.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtitemremarks.Border.Class = "TextBoxBorder"
        Me.txtitemremarks.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtitemremarks.FocusHighlightEnabled = True
        Me.txtitemremarks.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtitemremarks.Location = New System.Drawing.Point(102, 170)
        Me.txtitemremarks.Multiline = True
        Me.txtitemremarks.Name = "txtitemremarks"
        Me.txtitemremarks.Size = New System.Drawing.Size(189, 37)
        Me.txtitemremarks.TabIndex = 183
        '
        'txtdate_added
        '
        Me.txtdate_added.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtdate_added.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtdate_added.ButtonDropDown.Visible = True
        Me.txtdate_added.CustomFormat = "MMMM dd, yyyy"
        Me.txtdate_added.ForeColor = System.Drawing.Color.Red
        Me.txtdate_added.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtdate_added.Location = New System.Drawing.Point(218, 118)
        '
        '
        '
        Me.txtdate_added.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.txtdate_added.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txtdate_added.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtdate_added.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtdate_added.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtdate_added.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtdate_added.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtdate_added.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtdate_added.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtdate_added.MonthCalendar.DisplayMonth = New Date(2012, 6, 1, 0, 0, 0, 0)
        Me.txtdate_added.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtdate_added.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtdate_added.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtdate_added.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtdate_added.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtdate_added.MonthCalendar.TodayButtonVisible = True
        Me.txtdate_added.Name = "txtdate_added"
        Me.txtdate_added.Size = New System.Drawing.Size(143, 20)
        Me.txtdate_added.TabIndex = 163
        Me.txtdate_added.Value = New Date(2016, 1, 12, 0, 0, 0, 0)
        Me.txtdate_added.Visible = False
        '
        'cpyPulloutQty
        '
        Me.cpyPulloutQty.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.cpyPulloutQty.Border.Class = "TextBoxBorder"
        Me.cpyPulloutQty.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.cpyPulloutQty.FocusHighlightEnabled = True
        Me.cpyPulloutQty.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cpyPulloutQty.Location = New System.Drawing.Point(352, 118)
        Me.cpyPulloutQty.Name = "cpyPulloutQty"
        Me.cpyPulloutQty.Size = New System.Drawing.Size(92, 20)
        Me.cpyPulloutQty.TabIndex = 162
        Me.cpyPulloutQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cpyDelQty
        '
        Me.cpyDelQty.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.cpyDelQty.Border.Class = "TextBoxBorder"
        Me.cpyDelQty.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.cpyDelQty.FocusHighlightEnabled = True
        Me.cpyDelQty.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cpyDelQty.Location = New System.Drawing.Point(352, 91)
        Me.cpyDelQty.Name = "cpyDelQty"
        Me.cpyDelQty.Size = New System.Drawing.Size(92, 20)
        Me.cpyDelQty.TabIndex = 161
        Me.cpyDelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(25, 227)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(63, 15)
        Me.LabelX6.TabIndex = 160
        Me.LabelX6.Text = "Modified By:"
        Me.LabelX6.Visible = False
        '
        'txtpullout_qty
        '
        Me.txtpullout_qty.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtpullout_qty.Border.Class = "TextBoxBorder"
        Me.txtpullout_qty.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtpullout_qty.FocusHighlightEnabled = True
        Me.txtpullout_qty.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtpullout_qty.Location = New System.Drawing.Point(102, 118)
        Me.txtpullout_qty.Name = "txtpullout_qty"
        Me.txtpullout_qty.Size = New System.Drawing.Size(92, 20)
        Me.txtpullout_qty.TabIndex = 159
        Me.txtpullout_qty.Text = "0"
        Me.txtpullout_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtadded_qty
        '
        Me.txtadded_qty.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtadded_qty.Border.Class = "TextBoxBorder"
        Me.txtadded_qty.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtadded_qty.FocusHighlightEnabled = True
        Me.txtadded_qty.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtadded_qty.Location = New System.Drawing.Point(102, 91)
        Me.txtadded_qty.Name = "txtadded_qty"
        Me.txtadded_qty.Size = New System.Drawing.Size(92, 20)
        Me.txtadded_qty.TabIndex = 158
        Me.txtadded_qty.Text = "0"
        Me.txtadded_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(25, 70)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(26, 15)
        Me.LabelX5.TabIndex = 157
        Me.LabelX5.Text = "Date"
        '
        'txtdate_modified
        '
        Me.txtdate_modified.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtdate_modified.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtdate_modified.ButtonDropDown.Visible = True
        Me.txtdate_modified.CustomFormat = "MMMM dd, yyyy"
        Me.txtdate_modified.ForeColor = System.Drawing.Color.Red
        Me.txtdate_modified.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtdate_modified.Location = New System.Drawing.Point(102, 65)
        '
        '
        '
        Me.txtdate_modified.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.txtdate_modified.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txtdate_modified.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtdate_modified.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtdate_modified.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtdate_modified.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtdate_modified.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtdate_modified.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtdate_modified.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtdate_modified.MonthCalendar.DisplayMonth = New Date(2012, 6, 1, 0, 0, 0, 0)
        Me.txtdate_modified.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtdate_modified.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtdate_modified.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtdate_modified.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtdate_modified.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtdate_modified.MonthCalendar.TodayButtonVisible = True
        Me.txtdate_modified.Name = "txtdate_modified"
        Me.txtdate_modified.Size = New System.Drawing.Size(143, 20)
        Me.txtdate_modified.TabIndex = 156
        Me.txtdate_modified.Value = New Date(2016, 1, 12, 0, 0, 0, 0)
        '
        'txtmodify_user
        '
        Me.txtmodify_user.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtmodify_user.Border.Class = "TextBoxBorder"
        Me.txtmodify_user.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtmodify_user.FocusHighlightEnabled = True
        Me.txtmodify_user.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtmodify_user.Location = New System.Drawing.Point(102, 222)
        Me.txtmodify_user.Name = "txtmodify_user"
        Me.txtmodify_user.Size = New System.Drawing.Size(233, 20)
        Me.txtmodify_user.TabIndex = 155
        Me.txtmodify_user.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(25, 123)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(62, 15)
        Me.LabelX4.TabIndex = 152
        Me.LabelX4.Text = "Pull-Out Qty"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(25, 97)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(62, 15)
        Me.LabelX3.TabIndex = 149
        Me.LabelX3.Text = "Delivery Qty"
        '
        'btnModify
        '
        Me.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.Location = New System.Drawing.Point(297, 87)
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
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(134, 255)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 31)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnList
        '
        Me.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.Location = New System.Drawing.Point(297, 50)
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
        Me.btnAdd.Location = New System.Drawing.Point(242, 255)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(93, 31)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(25, 255)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 31)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'txtSysPK_INVMaster
        '
        Me.txtSysPK_INVMaster.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtSysPK_INVMaster.Border.Class = "TextBoxBorder"
        Me.txtSysPK_INVMaster.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSysPK_INVMaster.FocusHighlightEnabled = True
        Me.txtSysPK_INVMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysPK_INVMaster.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSysPK_INVMaster.Location = New System.Drawing.Point(297, 18)
        Me.txtSysPK_INVMaster.Name = "txtSysPK_INVMaster"
        Me.txtSysPK_INVMaster.Size = New System.Drawing.Size(147, 20)
        Me.txtSysPK_INVMaster.TabIndex = 19
        Me.txtSysPK_INVMaster.Tag = ""
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(25, 35)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(71, 15)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "Display Name"
        '
        'txtitem_name
        '
        Me.txtitem_name.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtitem_name.Border.Class = "TextBoxBorder"
        Me.txtitem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitem_name.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtitem_name.FocusHighlightEnabled = True
        Me.txtitem_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtitem_name.Location = New System.Drawing.Point(102, 30)
        Me.txtitem_name.MaxLength = 30
        Me.txtitem_name.Name = "txtitem_name"
        Me.txtitem_name.Size = New System.Drawing.Size(189, 20)
        Me.txtitem_name.TabIndex = 3
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(25, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(29, 15)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "Code"
        '
        'txtitem_code
        '
        Me.txtitem_code.AccessibleName = "inventory_replenishment"
        '
        '
        '
        Me.txtitem_code.Border.Class = "TextBoxBorder"
        Me.txtitem_code.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtitem_code.FocusHighlightEnabled = True
        Me.txtitem_code.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtitem_code.Location = New System.Drawing.Point(102, 1)
        Me.txtitem_code.Name = "txtitem_code"
        Me.txtitem_code.Size = New System.Drawing.Size(189, 20)
        Me.txtitem_code.TabIndex = 2
        '
        'fmaReplinishmentSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(510, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaReplinishmentSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArkAnt: Item Setup Form"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.txtdate_added, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdate_modified, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSysPK_INVMaster As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtitem_code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtitem_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtmodify_user As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdate_modified As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtadded_qty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtpullout_qty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cpyPulloutQty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cpyDelQty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdate_added As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtitemremarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSysPK As DevComponents.DotNetBar.Controls.TextBoxX
End Class
