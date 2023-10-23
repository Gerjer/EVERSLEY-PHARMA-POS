<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaDateRange_DailyViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaDateRange_DailyViewer))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnThread = New DevComponents.DotNetBar.ButtonX
        Me.lblStatus = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cxbxDailyTransaction = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cxbxDailySales = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.dtpTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.cxbxDirectPrinting = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.dtpFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.cxbxDailySalesItem = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.GroupPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelEx1.Size = New System.Drawing.Size(398, 28)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "Daily Report Form"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cxbxDailySalesItem)
        Me.GroupPanel2.Controls.Add(Me.btnThread)
        Me.GroupPanel2.Controls.Add(Me.lblStatus)
        Me.GroupPanel2.Controls.Add(Me.PictureBox1)
        Me.GroupPanel2.Controls.Add(Me.CheckBoxX1)
        Me.GroupPanel2.Controls.Add(Me.cxbxDailyTransaction)
        Me.GroupPanel2.Controls.Add(Me.cxbxDailySales)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(398, 209)
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
        Me.GroupPanel2.TabIndex = 15
        '
        'btnThread
        '
        Me.btnThread.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThread.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThread.Location = New System.Drawing.Point(177, 171)
        Me.btnThread.Name = "btnThread"
        Me.btnThread.Size = New System.Drawing.Size(75, 23)
        Me.btnThread.TabIndex = 6
        Me.btnThread.Text = "Start"
        Me.btnThread.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(258, 187)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(35, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "status"
        Me.lblStatus.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ArkAntSoftwarePOS.My.Resources.Resources.I4LdK
        Me.PictureBox1.Location = New System.Drawing.Point(263, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 89)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxX1.Location = New System.Drawing.Point(9, 175)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(200, 23)
        Me.CheckBoxX1.TabIndex = 5
        Me.CheckBoxX1.Text = "ALL"
        Me.CheckBoxX1.Visible = False
        '
        'cxbxDailyTransaction
        '
        Me.cxbxDailyTransaction.BackColor = System.Drawing.Color.Transparent
        Me.cxbxDailyTransaction.Location = New System.Drawing.Point(9, 143)
        Me.cxbxDailyTransaction.Name = "cxbxDailyTransaction"
        Me.cxbxDailyTransaction.Size = New System.Drawing.Size(200, 23)
        Me.cxbxDailyTransaction.TabIndex = 4
        Me.cxbxDailyTransaction.Text = "TRANSACTION REPORT"
        '
        'cxbxDailySales
        '
        Me.cxbxDailySales.BackColor = System.Drawing.Color.Transparent
        Me.cxbxDailySales.Checked = True
        Me.cxbxDailySales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cxbxDailySales.CheckValue = "Y"
        Me.cxbxDailySales.Location = New System.Drawing.Point(9, 88)
        Me.cxbxDailySales.Name = "cxbxDailySales"
        Me.cxbxDailySales.Size = New System.Drawing.Size(200, 23)
        Me.cxbxDailySales.TabIndex = 2
        Me.cxbxDailySales.Text = "SALES REPORT PER CASHIER"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.dtpTo)
        Me.GroupPanel1.Controls.Add(Me.cxbxDirectPrinting)
        Me.GroupPanel1.Controls.Add(Me.btnPrint)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.dtpFrom)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(392, 87)
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
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(6, 39)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(18, 15)
        Me.LabelX1.TabIndex = 124
        Me.LabelX1.Text = "TO"
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
        Me.dtpTo.Location = New System.Drawing.Point(52, 34)
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
        Me.dtpTo.Size = New System.Drawing.Size(143, 20)
        Me.dtpTo.TabIndex = 123
        Me.dtpTo.Value = New Date(2014, 4, 18, 11, 38, 18, 0)
        '
        'cxbxDirectPrinting
        '
        Me.cxbxDirectPrinting.BackColor = System.Drawing.Color.Transparent
        Me.cxbxDirectPrinting.Location = New System.Drawing.Point(231, 58)
        Me.cxbxDirectPrinting.Name = "cxbxDirectPrinting"
        Me.cxbxDirectPrinting.Size = New System.Drawing.Size(139, 23)
        Me.cxbxDirectPrinting.TabIndex = 122
        Me.cxbxDirectPrinting.Text = "Print to POS Printer"
        Me.cxbxDirectPrinting.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnPrint.Location = New System.Drawing.Point(231, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnPrint.Size = New System.Drawing.Size(139, 47)
        Me.btnPrint.TabIndex = 121
        Me.btnPrint.Text = "Print"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(6, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(35, 15)
        Me.LabelX3.TabIndex = 105
        Me.LabelX3.Text = "FROM"
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
        Me.dtpFrom.Location = New System.Drawing.Point(52, 7)
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
        Me.dtpFrom.Size = New System.Drawing.Size(143, 20)
        Me.dtpFrom.TabIndex = 104
        Me.dtpFrom.Value = New Date(2014, 4, 18, 11, 38, 18, 0)
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
        'cxbxDailySalesItem
        '
        Me.cxbxDailySalesItem.BackColor = System.Drawing.Color.Transparent
        Me.cxbxDailySalesItem.Location = New System.Drawing.Point(9, 108)
        Me.cxbxDailySalesItem.Name = "cxbxDailySalesItem"
        Me.cxbxDailySalesItem.Size = New System.Drawing.Size(200, 23)
        Me.cxbxDailySalesItem.TabIndex = 8
        Me.cxbxDailySalesItem.Text = "SALES REPORT PER ITEM"
        '
        'fmaDateRange_DailyViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(398, 237)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(414, 275)
        Me.MinimumSize = New System.Drawing.Size(414, 275)
        Me.Name = "fmaDateRange_DailyViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArkAntSoft : Daily Report Viewer"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cxbxDailySales As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cxbxDailyTransaction As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cxbxDirectPrinting As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnThread As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cxbxDailySalesItem As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
