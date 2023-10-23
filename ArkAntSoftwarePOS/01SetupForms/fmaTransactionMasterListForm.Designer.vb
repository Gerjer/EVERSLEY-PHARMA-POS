<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaTransactionMasterListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaTransactionMasterListForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TabControl4 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel9 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonX11 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX12 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX13 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX14 = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem13 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel10 = New DevComponents.DotNetBar.TabControlPanel()
        Me.tdbViewer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabItem14 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.rbtnWard = New System.Windows.Forms.RadioButton()
        Me.rbtnPatient = New System.Windows.Forms.RadioButton()
        Me.txtItemCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.dtpTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.WinTitle = New System.Windows.Forms.Label()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabControlPanel9.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMenuStripOperations.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel10.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
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
        Me.GroupPanel2.Size = New System.Drawing.Size(919, 500)
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
        Me.TabControl4.Controls.Add(Me.TabControlPanel10)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(0, 240)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl4.SelectedTabIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(913, 254)
        Me.TabControl4.TabIndex = 53
        Me.TabControl4.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl4.Tabs.Add(Me.TabItem13)
        Me.TabControl4.Tabs.Add(Me.TabItem14)
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
        Me.TabControlPanel9.Size = New System.Drawing.Size(913, 228)
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
        Me.GridControl1.ContextMenuStrip = Me.CMenuStripOperations
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Location = New System.Drawing.Point(1, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(911, 226)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedToolStripMenuItem})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(129, 30)
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSelectedToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSelectedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DeleteSelectedToolStripMenuItem.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.Text_Edit_icon32
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.DeleteSelectedToolStripMenuItem.Text = "Details"
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.DetailHeight = 284
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter
        Me.GridView1.OptionsFind.FindDelay = 300
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
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
        'TabControlPanel10
        '
        Me.TabControlPanel10.Controls.Add(Me.tdbViewer)
        Me.TabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel10.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel10.Name = "TabControlPanel10"
        Me.TabControlPanel10.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel10.Size = New System.Drawing.Size(913, 228)
        Me.TabControlPanel10.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel10.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel10.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel10.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel10.Style.GradientAngle = 90
        Me.TabControlPanel10.TabIndex = 2
        Me.TabControlPanel10.TabItem = Me.TabItem14
        '
        'tdbViewer
        '
        Me.tdbViewer.AllowHorizontalSplit = True
        Me.tdbViewer.AllowUpdate = False
        Me.tdbViewer.AllowVerticalSplit = True
        Me.tdbViewer.AlternatingRows = True
        Me.tdbViewer.BackColor = System.Drawing.Color.LightBlue
        Me.tdbViewer.Caption = "Details"
        Me.tdbViewer.CaptionHeight = 30
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.FilterBar = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(347, 69)
        Me.tdbViewer.MaintainRowCurrency = True
        Me.tdbViewer.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbViewer.Name = "tdbViewer"
        Me.tdbViewer.PictureAddnewRow = CType(resources.GetObject("tdbViewer.PictureAddnewRow"), System.Drawing.Image)
        Me.tdbViewer.PictureCurrentRow = CType(resources.GetObject("tdbViewer.PictureCurrentRow"), System.Drawing.Image)
        Me.tdbViewer.PictureFilterBar = CType(resources.GetObject("tdbViewer.PictureFilterBar"), System.Drawing.Image)
        Me.tdbViewer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbViewer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbViewer.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbViewer.PrintInfo.PageSettings = CType(resources.GetObject("tdbViewer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbViewer.RowDivider.Color = System.Drawing.Color.DarkBlue
        Me.tdbViewer.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.tdbViewer.RowHeight = 20
        Me.tdbViewer.RowSubDividerColor = System.Drawing.Color.Navy
        Me.tdbViewer.Size = New System.Drawing.Size(117, 96)
        Me.tdbViewer.TabAcrossSplits = True
        Me.tdbViewer.TabIndex = 21
        Me.tdbViewer.Text = "C1TrueDBGrid1"
        Me.tdbViewer.Visible = False
        Me.tdbViewer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.tdbViewer.PropBag = resources.GetString("tdbViewer.PropBag")
        '
        'TabItem14
        '
        Me.TabItem14.AttachedControl = Me.TabControlPanel10
        Me.TabItem14.Name = "TabItem14"
        Me.TabItem14.Text = "Permanent"
        Me.TabItem14.Visible = False
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.rbtnWard)
        Me.PanelEx1.Controls.Add(Me.rbtnPatient)
        Me.PanelEx1.Controls.Add(Me.txtItemCode)
        Me.PanelEx1.Controls.Add(Me.btnSearch)
        Me.PanelEx1.Controls.Add(Me.dtpTo)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.dtpFrom)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.WinTitle)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(913, 240)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
        '
        'rbtnWard
        '
        Me.rbtnWard.AutoSize = True
        Me.rbtnWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtnWard.Location = New System.Drawing.Point(245, 40)
        Me.rbtnWard.Name = "rbtnWard"
        Me.rbtnWard.Size = New System.Drawing.Size(77, 24)
        Me.rbtnWard.TabIndex = 111
        Me.rbtnWard.Text = "WARD"
        Me.rbtnWard.UseVisualStyleBackColor = True
        '
        'rbtnPatient
        '
        Me.rbtnPatient.AutoSize = True
        Me.rbtnPatient.Checked = True
        Me.rbtnPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtnPatient.Location = New System.Drawing.Point(82, 40)
        Me.rbtnPatient.Name = "rbtnPatient"
        Me.rbtnPatient.Size = New System.Drawing.Size(93, 24)
        Me.rbtnPatient.TabIndex = 110
        Me.rbtnPatient.TabStop = True
        Me.rbtnPatient.Text = "PATIENT"
        Me.rbtnPatient.UseVisualStyleBackColor = True
        '
        'txtItemCode
        '
        '
        '
        '
        Me.txtItemCode.Border.Class = "TextBoxBorder"
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtItemCode.Location = New System.Drawing.Point(80, 161)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(242, 29)
        Me.txtItemCode.TabIndex = 109
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.zoom
        Me.btnSearch.Location = New System.Drawing.Point(328, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.btnSearch.Size = New System.Drawing.Size(152, 58)
        Me.btnSearch.TabIndex = 108
        Me.btnSearch.Text = "Search [ F3 ]"
        '
        'dtpTo
        '
        Me.dtpTo.AccessibleName = "budget_appropriation_master"
        '
        '
        '
        Me.dtpTo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpTo.ButtonDropDown.Visible = True
        Me.dtpTo.CustomFormat = "MMMM dd, yyyy"
        Me.dtpTo.ForeColor = System.Drawing.Color.Red
        Me.dtpTo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(80, 122)
        '
        '
        '
        Me.dtpTo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpTo.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpTo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpTo.MonthCalendar.DisplayMonth = New Date(2012, 6, 1, 0, 0, 0, 0)
        Me.dtpTo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpTo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTo.MonthCalendar.TodayButtonVisible = True
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(242, 26)
        Me.dtpTo.TabIndex = 107
        Me.dtpTo.Value = New Date(2014, 4, 18, 11, 38, 18, 0)
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(3, 125)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(29, 23)
        Me.LabelX2.TabIndex = 106
        Me.LabelX2.Text = "TO"
        '
        'dtpFrom
        '
        Me.dtpFrom.AccessibleName = "budget_appropriation_master"
        '
        '
        '
        Me.dtpFrom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFrom.ButtonDropDown.Visible = True
        Me.dtpFrom.CustomFormat = "MMMM dd, yyyy"
        Me.dtpFrom.ForeColor = System.Drawing.Color.Red
        Me.dtpFrom.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(80, 90)
        '
        '
        '
        Me.dtpFrom.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpFrom.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpFrom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFrom.MonthCalendar.DisplayMonth = New Date(2012, 6, 1, 0, 0, 0, 0)
        Me.dtpFrom.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFrom.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFrom.MonthCalendar.TodayButtonVisible = True
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(242, 26)
        Me.dtpFrom.TabIndex = 105
        Me.dtpFrom.Value = New Date(2014, 4, 18, 11, 38, 18, 0)
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(4, 93)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(80, 23)
        Me.LabelX1.TabIndex = 28
        Me.LabelX1.Text = "FROM"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnPrint)
        Me.GroupPanel1.Controls.Add(Me.btnClose)
        Me.GroupPanel1.Controls.Add(Me.btnDetails)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 202)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(913, 38)
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
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.Print_24x24
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(86, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(86, 32)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(821, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 32)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        Me.btnDetails.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.Text_Edit_icon32
        Me.btnDetails.Location = New System.Drawing.Point(0, 0)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(86, 32)
        Me.btnDetails.TabIndex = 21
        Me.btnDetails.Text = "Details"
        Me.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetails.UseVisualStyleBackColor = True
        Me.btnDetails.Visible = False
        '
        'WinTitle
        '
        Me.WinTitle.AutoSize = True
        Me.WinTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinTitle.Location = New System.Drawing.Point(0, 0)
        Me.WinTitle.Name = "WinTitle"
        Me.WinTitle.Size = New System.Drawing.Size(207, 20)
        Me.WinTitle.TabIndex = 0
        Me.WinTitle.Text = "TRANSACTION DATA LIST"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(4, 164)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(80, 23)
        Me.LabelX3.TabIndex = 112
        Me.LabelX3.Text = "TRXN NO"
        '
        'fmaTransactionMasterListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(919, 500)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaTransactionMasterListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabControlPanel9.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMenuStripOperations.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel10.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents WinTitle As System.Windows.Forms.Label
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtItemCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents rbtnWard As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPatient As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl4 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel10 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabItem14 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel9 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonX11 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX12 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX13 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX14 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem13 As DevComponents.DotNetBar.TabItem
End Class
