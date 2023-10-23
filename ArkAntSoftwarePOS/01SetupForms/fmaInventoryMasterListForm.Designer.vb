<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmaInventoryMasterListForm
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaInventoryMasterListForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TabControl4 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel9 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonX11 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX12 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX13 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX14 = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem13 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.chkAllItem = New System.Windows.Forms.CheckBox()
        Me.chkExpiryDate = New System.Windows.Forms.CheckBox()
        Me.chkRISItem = New System.Windows.Forms.CheckBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.CheckBoxShowALl = New System.Windows.Forms.CheckBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.recordCount = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PgCount = New DevComponents.Editors.IntegerInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplinishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.GroupPanel2.SuspendLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabControlPanel9.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PgCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMenuStripOperations.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupPanel2.Controls.Add(Me.TabControl4)
        Me.GroupPanel2.Controls.Add(Me.PanelEx1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1073, 462)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
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
        'TabControl4
        '
        Me.TabControl4.BackColor = System.Drawing.Color.SkyBlue
        Me.TabControl4.CanReorderTabs = False
        Me.TabControl4.Controls.Add(Me.TabControlPanel9)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(0, 145)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl4.SelectedTabIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(1067, 311)
        Me.TabControl4.TabIndex = 53
        Me.TabControl4.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl4.Tabs.Add(Me.TabItem13)
        Me.TabControl4.Text = "TabControl4"
        '
        'TabControlPanel9
        '
        Me.TabControlPanel9.Controls.Add(Me.GridControl1)
        Me.TabControlPanel9.Controls.Add(Me.Button3)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX11)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX12)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX13)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX14)
        Me.TabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel9.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel9.Name = "TabControlPanel9"
        Me.TabControlPanel9.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel9.Size = New System.Drawing.Size(1067, 285)
        Me.TabControlPanel9.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel9.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel9.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel9.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel9.Style.GradientAngle = 90
        Me.TabControlPanel9.TabIndex = 1
        Me.TabControlPanel9.TabItem = Me.TabItem13
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(1, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1065, 283)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter
        Me.GridView1.OptionsFind.FindDelay = 300
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(780, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'ButtonX11
        '
        Me.ButtonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX11.Image = CType(resources.GetObject("ButtonX11.Image"), System.Drawing.Image)
        Me.ButtonX11.Location = New System.Drawing.Point(886, 441)
        Me.ButtonX11.Name = "ButtonX11"
        Me.ButtonX11.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.ButtonX11.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX11.TabIndex = 29
        Me.ButtonX11.Text = "List's"
        '
        'ButtonX12
        '
        Me.ButtonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX12.Image = CType(resources.GetObject("ButtonX12.Image"), System.Drawing.Image)
        Me.ButtonX12.Location = New System.Drawing.Point(137, 441)
        Me.ButtonX12.Name = "ButtonX12"
        Me.ButtonX12.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.ButtonX12.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX12.TabIndex = 27
        Me.ButtonX12.Text = "Save"
        '
        'ButtonX13
        '
        Me.ButtonX13.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ButtonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX13.Image = CType(resources.GetObject("ButtonX13.Image"), System.Drawing.Image)
        Me.ButtonX13.Location = New System.Drawing.Point(14, 441)
        Me.ButtonX13.Name = "ButtonX13"
        Me.ButtonX13.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.ButtonX13.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX13.TabIndex = 0
        Me.ButtonX13.Text = "Add"
        '
        'ButtonX14
        '
        Me.ButtonX14.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX14.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX14.Image = CType(resources.GetObject("ButtonX14.Image"), System.Drawing.Image)
        Me.ButtonX14.Location = New System.Drawing.Point(260, 441)
        Me.ButtonX14.Name = "ButtonX14"
        Me.ButtonX14.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.ButtonX14.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX14.TabIndex = 28
        Me.ButtonX14.Text = "Delete"
        '
        'TabItem13
        '
        Me.TabItem13.AttachedControl = Me.TabControlPanel9
        Me.TabItem13.Name = "TabItem13"
        Me.TabItem13.Text = "Present"
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.chkAllItem)
        Me.PanelEx1.Controls.Add(Me.chkExpiryDate)
        Me.PanelEx1.Controls.Add(Me.chkRISItem)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.CheckBoxShowALl)
        Me.PanelEx1.Controls.Add(Me.txtTo)
        Me.PanelEx1.Controls.Add(Me.txtFrom)
        Me.PanelEx1.Controls.Add(Me.btnRight)
        Me.PanelEx1.Controls.Add(Me.btnLeft)
        Me.PanelEx1.Controls.Add(Me.recordCount)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.PgCount)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1067, 145)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
        '
        'chkAllItem
        '
        Me.chkAllItem.AutoSize = True
        Me.chkAllItem.ForeColor = System.Drawing.Color.Navy
        Me.chkAllItem.Location = New System.Drawing.Point(3, 80)
        Me.chkAllItem.Name = "chkAllItem"
        Me.chkAllItem.Size = New System.Drawing.Size(99, 24)
        Me.chkAllItem.TabIndex = 252
        Me.chkAllItem.Text = "ALL ITEM"
        Me.chkAllItem.UseVisualStyleBackColor = True
        '
        'chkExpiryDate
        '
        Me.chkExpiryDate.AutoSize = True
        Me.chkExpiryDate.ForeColor = System.Drawing.Color.Navy
        Me.chkExpiryDate.Location = New System.Drawing.Point(4, 54)
        Me.chkExpiryDate.Name = "chkExpiryDate"
        Me.chkExpiryDate.Size = New System.Drawing.Size(210, 24)
        Me.chkExpiryDate.TabIndex = 251
        Me.chkExpiryDate.Text = "INCLUDE EXPIRY DATE"
        Me.chkExpiryDate.UseVisualStyleBackColor = True
        '
        'chkRISItem
        '
        Me.chkRISItem.AutoSize = True
        Me.chkRISItem.ForeColor = System.Drawing.Color.Navy
        Me.chkRISItem.Location = New System.Drawing.Point(5, 28)
        Me.chkRISItem.Name = "chkRISItem"
        Me.chkRISItem.Size = New System.Drawing.Size(98, 24)
        Me.chkRISItem.TabIndex = 28
        Me.chkRISItem.Text = "RIS ITEM"
        Me.chkRISItem.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(-3, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.PaddingTop = 20
        Me.LabelX2.Size = New System.Drawing.Size(420, 59)
        Me.LabelX2.TabIndex = 250
        Me.LabelX2.Text = "<b><h1>INVENTORY MASTER LIST</h1></b>"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'CheckBoxShowALl
        '
        Me.CheckBoxShowALl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxShowALl.AutoSize = True
        Me.CheckBoxShowALl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxShowALl.Location = New System.Drawing.Point(971, 78)
        Me.CheckBoxShowALl.Name = "CheckBoxShowALl"
        Me.CheckBoxShowALl.Size = New System.Drawing.Size(89, 24)
        Me.CheckBoxShowALl.TabIndex = 98
        Me.CheckBoxShowALl.Text = "Show All"
        Me.CheckBoxShowALl.UseVisualStyleBackColor = True
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(722, 3)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(31, 20)
        Me.txtTo.TabIndex = 27
        Me.txtTo.Text = "10"
        Me.txtTo.Visible = False
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(685, 3)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(31, 20)
        Me.txtFrom.TabIndex = 26
        Me.txtFrom.Text = "1"
        Me.txtFrom.Visible = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRight.Location = New System.Drawing.Point(722, 50)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(32, 22)
        Me.btnRight.TabIndex = 25
        Me.btnRight.Text = ">>"
        Me.btnRight.UseVisualStyleBackColor = False
        Me.btnRight.Visible = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLeft.Location = New System.Drawing.Point(684, 50)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(32, 22)
        Me.btnLeft.TabIndex = 24
        Me.btnLeft.Text = "<<"
        Me.btnLeft.UseVisualStyleBackColor = False
        Me.btnLeft.Visible = False
        '
        'recordCount
        '
        Me.recordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recordCount.AutoSize = True
        Me.recordCount.BackColor = System.Drawing.Color.Transparent
        Me.recordCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordCount.Location = New System.Drawing.Point(826, 54)
        Me.recordCount.Name = "recordCount"
        Me.recordCount.Size = New System.Drawing.Size(133, 21)
        Me.recordCount.TabIndex = 22
        Me.recordCount.Text = "Records Per Page"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnPrint)
        Me.GroupPanel1.Controls.Add(Me.btnEdit)
        Me.GroupPanel1.Controls.Add(Me.btnClose)
        Me.GroupPanel1.Controls.Add(Me.btnDelete)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.btnAdd)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 107)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1067, 38)
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
        Me.GroupPanel1.TabIndex = 21
        '
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.Print_24x24
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(258, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(86, 32)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(172, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 32)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(975, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 32)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.cancel
        Me.btnDelete.Location = New System.Drawing.Point(86, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 32)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX4.Location = New System.Drawing.Point(361, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX4.Size = New System.Drawing.Size(425, 23)
        Me.LabelX4.TabIndex = 97
        Me.LabelX4.Text = "Note : If you want to Add Delivery / Pull-Out Stocks, Right Click on the Selected" &
    " Item."
        Me.LabelX4.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 32)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PgCount
        '
        Me.PgCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.PgCount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.PgCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgCount.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PgCount.Increment = 100
        Me.PgCount.Location = New System.Drawing.Point(971, 39)
        Me.PgCount.MaxValue = 99999
        Me.PgCount.MinValue = 10
        Me.PgCount.Name = "PgCount"
        Me.PgCount.ShowUpDown = True
        Me.PgCount.Size = New System.Drawing.Size(91, 26)
        Me.PgCount.TabIndex = 17
        Me.PgCount.Value = 1000
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(826, 31)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(133, 21)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "Records Per Page"
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedToolStripMenuItem, Me.EditSelectedToolStripMenuItem, Me.ReplinishToolStripMenuItem})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(234, 82)
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSelectedToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSelectedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'EditSelectedToolStripMenuItem
        '
        Me.EditSelectedToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EditSelectedToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSelectedToolStripMenuItem.Name = "EditSelectedToolStripMenuItem"
        Me.EditSelectedToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.EditSelectedToolStripMenuItem.Text = "Edit Selected"
        '
        'ReplinishToolStripMenuItem
        '
        Me.ReplinishToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplinishToolStripMenuItem.Name = "ReplinishToolStripMenuItem"
        Me.ReplinishToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ReplinishToolStripMenuItem.Text = "Delivery/Pull-Out Item"
        Me.ReplinishToolStripMenuItem.Visible = False
        '
        'ToolTipController1
        '
        Me.ToolTipController1.Appearance.Options.UseTextOptions = True
        Me.ToolTipController1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ToolTipController1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ToolTipController1.AppearanceTitle.Options.UseBackColor = True
        Me.ToolTipController1.AppearanceTitle.Options.UseBorderColor = True
        Me.ToolTipController1.AppearanceTitle.Options.UseFont = True
        Me.ToolTipController1.AppearanceTitle.Options.UseTextOptions = True
        Me.ToolTipController1.AppearanceTitle.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.ToolTipController1.Rounded = True
        Me.ToolTipController1.RoundRadius = 15
        '
        'fmaInventoryMasterListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1073, 462)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaInventoryMasterListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabControlPanel9.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.PgCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMenuStripOperations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PgCount As DevComponents.Editors.IntegerInput
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents recordCount As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplinishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CheckBoxShowALl As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents TabControl4 As DevComponents.DotNetBar.TabControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabControlPanel9 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonX11 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX12 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX13 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX14 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem13 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkRISItem As CheckBox
    Friend WithEvents chkAllItem As CheckBox
    Friend WithEvents chkExpiryDate As CheckBox
End Class
