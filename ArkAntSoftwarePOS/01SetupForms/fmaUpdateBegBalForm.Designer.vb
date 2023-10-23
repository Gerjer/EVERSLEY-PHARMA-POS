<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaUpdateBegBalForm
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaUpdateBegBalForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgvBeginning = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btnxUpdate = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.txtSupplierCode = New System.Windows.Forms.TextBox()
        Me.txtSupplierList = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtYear = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtClassificationCode = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.cmbClassification = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.dtpDateMonthof = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblMonthof = New DevComponents.DotNetBar.LabelX()
        Me.dateFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dateTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dgvBeginning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateTo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupPanel2.Controls.Add(Me.dgvBeginning)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1256, 446)
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
        'dgvBeginning
        '
        Me.dgvBeginning.AllowUserToAddRows = False
        Me.dgvBeginning.AllowUserToDeleteRows = False
        Me.dgvBeginning.AllowUserToResizeColumns = False
        Me.dgvBeginning.AllowUserToResizeRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBeginning.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvBeginning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeginning.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBeginning.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvBeginning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBeginning.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvBeginning.Location = New System.Drawing.Point(0, 197)
        Me.dgvBeginning.Name = "dgvBeginning"
        Me.dgvBeginning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBeginning.Size = New System.Drawing.Size(1250, 243)
        Me.dgvBeginning.TabIndex = 23
        '
        'Column7
        '
        Me.Column7.HeaderText = "DATE ADDED"
        Me.Column7.Name = "Column7"
        '
        'Column1
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column1.HeaderText = "SysPK_TRD"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column2.HeaderText = "SysPK_InvMaster"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        Me.Column2.Width = 150
        '
        'Column3
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column3.HeaderText = "ITEM CODE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column4.HeaderText = "DESCRIPTION"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column5.HeaderText = "UNIT"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'Column6
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column6.HeaderText = "BEG. BALANCE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 200
        '
        'Column8
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.NullValue = "0.00"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column8.HeaderText = "BUY PRICE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PanelEx2)
        Me.GroupBox1.Controls.Add(Me.btnxUpdate)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtSupplierCode)
        Me.GroupBox1.Controls.Add(Me.txtSupplierList)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.txtClassificationCode)
        Me.GroupBox1.Controls.Add(Me.btnDisplay)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.cmbClassification)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.dtpDateMonthof)
        Me.GroupBox1.Controls.Add(Me.lblMonthof)
        Me.GroupBox1.Controls.Add(Me.dateFrom)
        Me.GroupBox1.Controls.Add(Me.dateTo)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1250, 197)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'PanelEx2
        '
        Me.PanelEx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx2.Location = New System.Drawing.Point(3, 16)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1244, 41)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.Color = System.Drawing.SystemColors.MenuText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 111
        Me.PanelEx2.Text = "UPDATE BEGINNING BALANCE"
        '
        'btnxUpdate
        '
        Me.btnxUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxUpdate.Enabled = False
        Me.btnxUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxUpdate.Image = CType(resources.GetObject("btnxUpdate.Image"), System.Drawing.Image)
        Me.btnxUpdate.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnxUpdate.Location = New System.Drawing.Point(376, 137)
        Me.btnxUpdate.Name = "btnxUpdate"
        Me.btnxUpdate.Size = New System.Drawing.Size(148, 40)
        Me.btnxUpdate.TabIndex = 110
        Me.btnxUpdate.Text = "&AUTO UPDATE"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnSave.Location = New System.Drawing.Point(218, 137)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(148, 40)
        Me.btnSave.TabIndex = 109
        Me.btnSave.Text = "&SAVE"
        '
        'txtSupplierCode
        '
        Me.txtSupplierCode.Location = New System.Drawing.Point(1109, 95)
        Me.txtSupplierCode.Name = "txtSupplierCode"
        Me.txtSupplierCode.Size = New System.Drawing.Size(43, 20)
        Me.txtSupplierCode.TabIndex = 108
        Me.txtSupplierCode.Visible = False
        '
        'txtSupplierList
        '
        Me.txtSupplierList.DisplayMember = "Text"
        Me.txtSupplierList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtSupplierList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierList.FormattingEnabled = True
        Me.txtSupplierList.ItemHeight = 17
        Me.txtSupplierList.Location = New System.Drawing.Point(847, 95)
        Me.txtSupplierList.Name = "txtSupplierList"
        Me.txtSupplierList.Size = New System.Drawing.Size(248, 23)
        Me.txtSupplierList.TabIndex = 107
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.Location = New System.Drawing.Point(746, 102)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(93, 15)
        Me.LabelX5.TabIndex = 106
        Me.LabelX5.Text = "CLASSIFICATION"
        '
        'txtYear
        '
        Me.txtYear.AccessibleName = ""
        '
        '
        '
        Me.txtYear.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtYear.ButtonDropDown.Visible = True
        Me.txtYear.CustomFormat = "yyyy"
        Me.txtYear.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtYear.FocusHighlightEnabled = True
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtYear.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtYear.Location = New System.Drawing.Point(131, 95)
        '
        '
        '
        Me.txtYear.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.txtYear.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txtYear.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtYear.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtYear.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtYear.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtYear.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtYear.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtYear.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtYear.MonthCalendar.DisplayMonth = New Date(2011, 5, 1, 0, 0, 0, 0)
        Me.txtYear.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtYear.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtYear.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtYear.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtYear.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtYear.MonthCalendar.TodayButtonVisible = True
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(246, 23)
        Me.txtYear.TabIndex = 105
        Me.txtYear.Tag = ""
        '
        'txtClassificationCode
        '
        Me.txtClassificationCode.Location = New System.Drawing.Point(1108, 72)
        Me.txtClassificationCode.Name = "txtClassificationCode"
        Me.txtClassificationCode.Size = New System.Drawing.Size(44, 20)
        Me.txtClassificationCode.TabIndex = 104
        Me.txtClassificationCode.Visible = False
        '
        'btnDisplay
        '
        Me.btnDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDisplay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Image = CType(resources.GetObject("btnDisplay.Image"), System.Drawing.Image)
        Me.btnDisplay.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnDisplay.Location = New System.Drawing.Point(58, 137)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(150, 40)
        Me.btnDisplay.TabIndex = 103
        Me.btnDisplay.Text = "&DISPLAY BEGINNING"
        Me.btnDisplay.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnClose.Location = New System.Drawing.Point(533, 137)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(148, 40)
        Me.btnClose.TabIndex = 102
        Me.btnClose.Text = "&CLOSE"
        '
        'cmbClassification
        '
        Me.cmbClassification.DisplayMember = "Text"
        Me.cmbClassification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbClassification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.ItemHeight = 17
        Me.cmbClassification.Location = New System.Drawing.Point(848, 71)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New System.Drawing.Size(248, 23)
        Me.cmbClassification.TabIndex = 100
        Me.cmbClassification.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.Location = New System.Drawing.Point(746, 76)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(31, 15)
        Me.LabelX4.TabIndex = 99
        Me.LabelX4.Text = "TYPE"
        Me.LabelX4.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Location = New System.Drawing.Point(29, 103)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(32, 15)
        Me.LabelX3.TabIndex = 94
        Me.LabelX3.Text = "YEAR"
        '
        'dtpDateMonthof
        '
        Me.dtpDateMonthof.DisplayMember = "Text"
        Me.dtpDateMonthof.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.dtpDateMonthof.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateMonthof.FormattingEnabled = True
        Me.dtpDateMonthof.ItemHeight = 17
        Me.dtpDateMonthof.Location = New System.Drawing.Point(131, 72)
        Me.dtpDateMonthof.Name = "dtpDateMonthof"
        Me.dtpDateMonthof.Size = New System.Drawing.Size(247, 23)
        Me.dtpDateMonthof.TabIndex = 93
        '
        'lblMonthof
        '
        Me.lblMonthof.AutoSize = True
        Me.lblMonthof.Location = New System.Drawing.Point(29, 77)
        Me.lblMonthof.Name = "lblMonthof"
        Me.lblMonthof.Size = New System.Drawing.Size(61, 15)
        Me.lblMonthof.TabIndex = 92
        Me.lblMonthof.Text = "MONTH OF"
        '
        'dateFrom
        '
        Me.dateFrom.AccessibleName = "hr_emp_attendance"
        '
        '
        '
        Me.dateFrom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateFrom.ButtonDropDown.Visible = True
        Me.dateFrom.CustomFormat = "MMMM, dd yyyy"
        Me.dateFrom.Enabled = False
        Me.dateFrom.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.dateFrom.FocusHighlightEnabled = True
        Me.dateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dateFrom.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dateFrom.Location = New System.Drawing.Point(464, 73)
        '
        '
        '
        Me.dateFrom.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dateFrom.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateFrom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateFrom.MonthCalendar.DisplayMonth = New Date(2011, 5, 1, 0, 0, 0, 0)
        Me.dateFrom.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateFrom.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateFrom.MonthCalendar.TodayButtonVisible = True
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(239, 23)
        Me.dateFrom.TabIndex = 90
        Me.dateFrom.Tag = ""
        '
        'dateTo
        '
        Me.dateTo.AccessibleName = ""
        '
        '
        '
        Me.dateTo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateTo.ButtonDropDown.Visible = True
        Me.dateTo.CustomFormat = "MMMM, dd yyyy"
        Me.dateTo.Enabled = False
        Me.dateTo.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.dateTo.FocusHighlightEnabled = True
        Me.dateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dateTo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dateTo.Location = New System.Drawing.Point(464, 98)
        '
        '
        '
        Me.dateTo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dateTo.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateTo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateTo.MonthCalendar.DisplayMonth = New Date(2011, 5, 1, 0, 0, 0, 0)
        Me.dateTo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateTo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateTo.MonthCalendar.TodayButtonVisible = True
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(239, 23)
        Me.dateTo.TabIndex = 91
        Me.dateTo.Tag = ""
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(423, 98)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "TO"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(423, 73)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "FROM"
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem1})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(184, 56)
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSelectedToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSelectedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'DeleteSelectedToolStripMenuItem1
        '
        Me.DeleteSelectedToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSelectedToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSelectedToolStripMenuItem1.Name = "DeleteSelectedToolStripMenuItem1"
        Me.DeleteSelectedToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DeleteSelectedToolStripMenuItem1.Text = "Edit Selected"
        '
        'fmaUpdateBegBalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1256, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaUpdateBegBalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Detailed Inventory Per Supplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dgvBeginning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMenuStripOperations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYear As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtClassificationCode As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbClassification As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDateMonthof As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblMonthof As DevComponents.DotNetBar.LabelX
    Friend WithEvents dateFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dateTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSupplierList As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSupplierCode As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvBeginning As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnxUpdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
End Class
