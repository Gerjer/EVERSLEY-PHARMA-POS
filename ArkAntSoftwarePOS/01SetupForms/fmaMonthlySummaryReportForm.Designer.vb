<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaMonthlySummaryReportForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaMonthlySummaryReportForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.cmbClassification = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtYear = New DevComponents.Editors.IntegerInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.dtpDateMonthof = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblMonthof = New DevComponents.DotNetBar.LabelX()
        Me.dateFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dateTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgvBeginning = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcludeInPayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRPTCADCForMACHINERYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRPTCADCForLANDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgvBeginning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMenuStripOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1129, 34)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "MONTHLY SUMMARY REPORT FORM"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.cmbClassification)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.dtpDateMonthof)
        Me.GroupBox1.Controls.Add(Me.lblMonthof)
        Me.GroupBox1.Controls.Add(Me.dateFrom)
        Me.GroupBox1.Controls.Add(Me.dateTo)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1129, 256)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(11, 196)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(243, 34)
        Me.btnPrint.TabIndex = 103
        Me.btnPrint.Text = "&PRINT"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(276, 196)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(243, 34)
        Me.btnClose.TabIndex = 102
        Me.btnClose.Text = "&CLOSE"
        '
        'cmbClassification
        '
        Me.cmbClassification.DisplayMember = "Text"
        Me.cmbClassification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.ItemHeight = 14
        Me.cmbClassification.Items.AddRange(New Object() {Me.ComboItem7, Me.ComboItem5, Me.ComboItem6, Me.ComboItem8, Me.ComboItem10, Me.ComboItem9})
        Me.cmbClassification.Location = New System.Drawing.Point(100, 92)
        Me.cmbClassification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New System.Drawing.Size(557, 20)
        Me.cmbClassification.TabIndex = 100
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "SUMMARIZED TOTAL OF ISSUED MEDICINES"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "ISSUED DRUGS AND MEDICINE"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "MEDICAL ASSISTANCE PROGRAM(MAP/CMAP/LMAF)"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "PATIENT COUNT PER CHARGING"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "ISSUANCE COUNT PER CHARGING"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "PULL-OUT AND DELIVERY REPORT"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.Location = New System.Drawing.Point(11, 98)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(57, 17)
        Me.LabelX4.TabIndex = 99
        Me.LabelX4.Text = "REPORT"
        '
        'txtYear
        '
        '
        '
        '
        Me.txtYear.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtYear.Location = New System.Drawing.Point(100, 49)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYear.MaxValue = 2030
        Me.txtYear.MinValue = 2020
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ShowUpDown = True
        Me.txtYear.Size = New System.Drawing.Size(177, 22)
        Me.txtYear.TabIndex = 95
        Me.txtYear.Value = 2020
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Location = New System.Drawing.Point(11, 55)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(38, 17)
        Me.LabelX3.TabIndex = 94
        Me.LabelX3.Text = "YEAR"
        '
        'dtpDateMonthof
        '
        Me.dtpDateMonthof.DisplayMember = "Text"
        Me.dtpDateMonthof.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.dtpDateMonthof.FormattingEnabled = True
        Me.dtpDateMonthof.ItemHeight = 14
        Me.dtpDateMonthof.Location = New System.Drawing.Point(100, 23)
        Me.dtpDateMonthof.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDateMonthof.Name = "dtpDateMonthof"
        Me.dtpDateMonthof.Size = New System.Drawing.Size(176, 20)
        Me.dtpDateMonthof.TabIndex = 93
        '
        'lblMonthof
        '
        Me.lblMonthof.AutoSize = True
        Me.lblMonthof.Location = New System.Drawing.Point(11, 30)
        Me.lblMonthof.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMonthof.Name = "lblMonthof"
        Me.lblMonthof.Size = New System.Drawing.Size(72, 17)
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
        Me.dateFrom.Location = New System.Drawing.Point(340, 20)
        Me.dateFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.dateFrom.Size = New System.Drawing.Size(319, 26)
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
        Me.dateTo.Location = New System.Drawing.Point(340, 50)
        Me.dateTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.dateTo.Size = New System.Drawing.Size(319, 26)
        Me.dateTo.TabIndex = 91
        Me.dateTo.Tag = ""
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(285, 50)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 28)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "TO"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(285, 20)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 28)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "FROM"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dgvBeginning)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 290)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1129, 357)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Check Charging Type you want to include."
        '
        'dgvBeginning
        '
        Me.dgvBeginning.AllowUserToAddRows = False
        Me.dgvBeginning.AllowUserToDeleteRows = False
        Me.dgvBeginning.AllowUserToResizeColumns = False
        Me.dgvBeginning.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBeginning.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBeginning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeginning.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBeginning.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBeginning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBeginning.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvBeginning.Location = New System.Drawing.Point(0, 0)
        Me.dgvBeginning.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvBeginning.Name = "dgvBeginning"
        Me.dgvBeginning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvBeginning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBeginning.Size = New System.Drawing.Size(1123, 334)
        Me.dgvBeginning.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "INCLUDE"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "TYPE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "CHARGING TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 400
        '
        'Column4
        '
        Me.Column4.HeaderText = "CODE"
        Me.Column4.Name = "Column4"
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcludeInPayrollToolStripMenuItem, Me.ViewRPTCADCForMACHINERYToolStripMenuItem, Me.ViewRPTCADCForLANDToolStripMenuItem})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(299, 76)
        '
        'ExcludeInPayrollToolStripMenuItem
        '
        Me.ExcludeInPayrollToolStripMenuItem.Name = "ExcludeInPayrollToolStripMenuItem"
        Me.ExcludeInPayrollToolStripMenuItem.Size = New System.Drawing.Size(298, 24)
        Me.ExcludeInPayrollToolStripMenuItem.Text = "View RPT CA/DC for BUILDING"
        '
        'ViewRPTCADCForMACHINERYToolStripMenuItem
        '
        Me.ViewRPTCADCForMACHINERYToolStripMenuItem.Name = "ViewRPTCADCForMACHINERYToolStripMenuItem"
        Me.ViewRPTCADCForMACHINERYToolStripMenuItem.Size = New System.Drawing.Size(298, 24)
        Me.ViewRPTCADCForMACHINERYToolStripMenuItem.Text = "View RPT CA/DC for MACHINERY"
        '
        'ViewRPTCADCForLANDToolStripMenuItem
        '
        Me.ViewRPTCADCForLANDToolStripMenuItem.Name = "ViewRPTCADCForLANDToolStripMenuItem"
        Me.ViewRPTCADCForLANDToolStripMenuItem.Size = New System.Drawing.Size(298, 24)
        Me.ViewRPTCADCForLANDToolStripMenuItem.Text = "View RPT CA/DC for LAND"
        '
        'fmaMonthlySummaryReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1129, 647)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fmaMonthlySummaryReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONTHLY SUMMARY REPORT FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dgvBeginning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMenuStripOperations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYear As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDateMonthof As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblMonthof As DevComponents.DotNetBar.LabelX
    Friend WithEvents dateFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dateTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbClassification As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcludeInPayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRPTCADCForMACHINERYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ViewRPTCADCForLANDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvBeginning As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
End Class
