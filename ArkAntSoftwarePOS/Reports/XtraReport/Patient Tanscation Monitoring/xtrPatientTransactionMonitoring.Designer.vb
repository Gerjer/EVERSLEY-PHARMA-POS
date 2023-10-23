<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xtrPatientTransactionMonitoring
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.txtDiscounted = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtUnfilled = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCharging = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtContatNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtGender = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDOB = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAge = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTranDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTransNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTimeOut = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTimeIN = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPatient = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.txtServedby = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtReceivedby = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1})
        Me.Detail.HeightF = 24.66663!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.PageHeader.HeightF = 51.66667!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(750.0!, 49.66667!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "PATIENT DAILY TRANSACTION "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.XrLine2, Me.XrLine1, Me.XrPanel1, Me.XrLabel2, Me.XrLabel3, Me.txtTranDate, Me.txtTransNo, Me.txtTimeOut, Me.txtTimeIN, Me.XrLabel7, Me.XrLabel6, Me.txtPatient})
        Me.GroupHeader1.HeightF = 289.6944!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 77.78569!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(34.16666!, 23.00001!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(560.4525!, 68.78569!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(189.5475!, 23.00001!)
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtAddress, Me.XrLabel10, Me.txtDiscounted, Me.txtUnfilled, Me.txtCharging, Me.XrLabel15, Me.XrLabel16, Me.XrLabel17, Me.txtContatNo, Me.txtGender, Me.txtDOB, Me.txtAge, Me.XrLabel9, Me.XrLabel8, Me.XrLabel5, Me.XrLabel4})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 89.66666!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(750.0!, 165.0!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'txtDiscounted
        '
        Me.txtDiscounted.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtDiscounted.LocationFloat = New DevExpress.Utils.PointFloat(452.6667!, 88.50005!)
        Me.txtDiscounted.Multiline = True
        Me.txtDiscounted.Name = "txtDiscounted"
        Me.txtDiscounted.NullValueText = """"""
        Me.txtDiscounted.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtDiscounted.SizeF = New System.Drawing.SizeF(273.0238!, 23.0!)
        Me.txtDiscounted.StylePriority.UseBorders = False
        Me.txtDiscounted.StylePriority.UsePadding = False
        Me.txtDiscounted.StylePriority.UseTextAlignment = False
        Me.txtDiscounted.Text = "AGE :"
        Me.txtDiscounted.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtUnfilled
        '
        Me.txtUnfilled.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtUnfilled.LocationFloat = New DevExpress.Utils.PointFloat(452.6667!, 65.83333!)
        Me.txtUnfilled.Multiline = True
        Me.txtUnfilled.Name = "txtUnfilled"
        Me.txtUnfilled.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtUnfilled.SizeF = New System.Drawing.SizeF(273.0238!, 22.99997!)
        Me.txtUnfilled.StylePriority.UseBorders = False
        Me.txtUnfilled.StylePriority.UsePadding = False
        Me.txtUnfilled.StylePriority.UseTextAlignment = False
        Me.txtUnfilled.Text = "AGE :"
        Me.txtUnfilled.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtCharging
        '
        Me.txtCharging.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtCharging.LocationFloat = New DevExpress.Utils.PointFloat(452.6667!, 43.50005!)
        Me.txtCharging.Multiline = True
        Me.txtCharging.Name = "txtCharging"
        Me.txtCharging.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtCharging.SizeF = New System.Drawing.SizeF(273.0238!, 23.00002!)
        Me.txtCharging.StylePriority.UseBorders = False
        Me.txtCharging.StylePriority.UsePadding = False
        Me.txtCharging.StylePriority.UseTextAlignment = False
        Me.txtCharging.Text = "AGE :"
        Me.txtCharging.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(321.1667!, 88.49998!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(131.5!, 23.00002!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "DISCOUNTED AMT. :"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(321.1667!, 65.83329!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(131.5!, 23.00002!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "UNSERVED MED. :"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(321.1667!, 43.50008!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(131.5!, 23.0!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "CHARGING :"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtContatNo
        '
        Me.txtContatNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtContatNo.LocationFloat = New DevExpress.Utils.PointFloat(132.6667!, 88.49997!)
        Me.txtContatNo.Multiline = True
        Me.txtContatNo.Name = "txtContatNo"
        Me.txtContatNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtContatNo.SizeF = New System.Drawing.SizeF(165.0!, 23.99998!)
        Me.txtContatNo.StylePriority.UseBorders = False
        Me.txtContatNo.StylePriority.UsePadding = False
        Me.txtContatNo.StylePriority.UseTextAlignment = False
        Me.txtContatNo.Text = "0925-586-7989"
        Me.txtContatNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtGender
        '
        Me.txtGender.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtGender.LocationFloat = New DevExpress.Utils.PointFloat(132.6667!, 66.50009!)
        Me.txtGender.Multiline = True
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtGender.SizeF = New System.Drawing.SizeF(165.0!, 23.0!)
        Me.txtGender.StylePriority.UseBorders = False
        Me.txtGender.StylePriority.UsePadding = False
        Me.txtGender.StylePriority.UseTextAlignment = False
        Me.txtGender.Text = "AGE :"
        Me.txtGender.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtDOB
        '
        Me.txtDOB.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtDOB.LocationFloat = New DevExpress.Utils.PointFloat(132.6667!, 43.83337!)
        Me.txtDOB.Multiline = True
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtDOB.SizeF = New System.Drawing.SizeF(85.83331!, 22.99999!)
        Me.txtDOB.StylePriority.UseBorders = False
        Me.txtDOB.StylePriority.UsePadding = False
        Me.txtDOB.StylePriority.UseTextAlignment = False
        Me.txtDOB.Text = "12-31-2022"
        Me.txtDOB.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtAge
        '
        Me.txtAge.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtAge.LocationFloat = New DevExpress.Utils.PointFloat(262.0!, 43.50011!)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtAge.SizeF = New System.Drawing.SizeF(35.66669!, 22.99999!)
        Me.txtAge.StylePriority.UseBorders = False
        Me.txtAge.StylePriority.UsePadding = False
        Me.txtAge.StylePriority.UseTextAlignment = False
        Me.txtAge.Text = "99"
        Me.txtAge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(15.16666!, 88.83337!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(117.5!, 23.00002!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "CONTACT NO.# :"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(15.16666!, 66.50005!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(117.5!, 23.00002!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "GENDER :"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(15.16666!, 43.83336!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(117.5!, 23.00002!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "DATE OF BIRTH :"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(221.5!, 43.50011!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(40.5!, 22.99997!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "AGE :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(165.0!, 23.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "TRANSACTION DATE :"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 30.0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(165.0!, 23.0!)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "TRANSACTION NO.# :"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTranDate
        '
        Me.txtTranDate.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtTranDate.LocationFloat = New DevExpress.Utils.PointFloat(165.0!, 0!)
        Me.txtTranDate.Multiline = True
        Me.txtTranDate.Name = "txtTranDate"
        Me.txtTranDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100.0!)
        Me.txtTranDate.SizeF = New System.Drawing.SizeF(196.6667!, 23.0!)
        Me.txtTranDate.StylePriority.UseBorders = False
        Me.txtTranDate.StylePriority.UsePadding = False
        Me.txtTranDate.StylePriority.UseTextAlignment = False
        Me.txtTranDate.Text = "TRANSACTION DATE :"
        Me.txtTranDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTransNo
        '
        Me.txtTransNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtTransNo.LocationFloat = New DevExpress.Utils.PointFloat(165.0!, 29.99999!)
        Me.txtTransNo.Multiline = True
        Me.txtTransNo.Name = "txtTransNo"
        Me.txtTransNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100.0!)
        Me.txtTransNo.SizeF = New System.Drawing.SizeF(196.6667!, 23.0!)
        Me.txtTransNo.StylePriority.UseBorders = False
        Me.txtTransNo.StylePriority.UsePadding = False
        Me.txtTransNo.StylePriority.UseTextAlignment = False
        Me.txtTransNo.Text = "TRANSACTION DATE :"
        Me.txtTransNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtTimeOut.LocationFloat = New DevExpress.Utils.PointFloat(475.0001!, 29.99999!)
        Me.txtTimeOut.Multiline = True
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100.0!)
        Me.txtTimeOut.SizeF = New System.Drawing.SizeF(196.6667!, 23.0!)
        Me.txtTimeOut.StylePriority.UseBorders = False
        Me.txtTimeOut.StylePriority.UsePadding = False
        Me.txtTimeOut.StylePriority.UseTextAlignment = False
        Me.txtTimeOut.Text = "TRANSACTION DATE :"
        Me.txtTimeOut.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTimeIN
        '
        Me.txtTimeIN.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtTimeIN.LocationFloat = New DevExpress.Utils.PointFloat(475.0001!, 0!)
        Me.txtTimeIN.Multiline = True
        Me.txtTimeIN.Name = "txtTimeIN"
        Me.txtTimeIN.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100.0!)
        Me.txtTimeIN.SizeF = New System.Drawing.SizeF(196.6667!, 23.0!)
        Me.txtTimeIN.StylePriority.UseBorders = False
        Me.txtTimeIN.StylePriority.UsePadding = False
        Me.txtTimeIN.StylePriority.UseTextAlignment = False
        Me.txtTimeIN.Text = "TRANSACTION DATE :"
        Me.txtTimeIN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(388.3333!, 29.99999!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(86.66672!, 23.0!)
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "TIME-OUT :"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(388.3333!, 0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(86.66672!, 23.0!)
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "TIME-IN :"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtPatient
        '
        Me.txtPatient.BackColor = System.Drawing.Color.DarkGray
        Me.txtPatient.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtPatient.BorderWidth = 2.0!
        Me.txtPatient.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtPatient.LocationFloat = New DevExpress.Utils.PointFloat(34.16669!, 67.78571!)
        Me.txtPatient.Multiline = True
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100.0!)
        Me.txtPatient.SizeF = New System.Drawing.SizeF(526.2858!, 36.33335!)
        Me.txtPatient.StylePriority.UseBackColor = False
        Me.txtPatient.StylePriority.UseBorders = False
        Me.txtPatient.StylePriority.UseBorderWidth = False
        Me.txtPatient.StylePriority.UseFont = False
        Me.txtPatient.StylePriority.UsePadding = False
        Me.txtPatient.StylePriority.UseTextAlignment = False
        Me.txtPatient.Text = "NAME"
        Me.txtPatient.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtServedby, Me.XrLabel18, Me.XrLabel21, Me.txtReceivedby})
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtServedby
        '
        Me.txtServedby.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServedby.LocationFloat = New DevExpress.Utils.PointFloat(102.6388!, 5.0!)
        Me.txtServedby.Multiline = True
        Me.txtServedby.Name = "txtServedby"
        Me.txtServedby.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtServedby.SizeF = New System.Drawing.SizeF(245.8333!, 23.0!)
        Me.txtServedby.StylePriority.UseFont = False
        Me.txtServedby.StylePriority.UseTextAlignment = False
        Me.txtServedby.Text = "TRANSACTION DATE :"
        Me.txtServedby.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.000009!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(102.6388!, 23.0!)
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "SERVED BY :"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 33.99997!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(102.6388!, 23.00001!)
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "RECEIVED BY :"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtReceivedby
        '
        Me.txtReceivedby.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceivedby.LocationFloat = New DevExpress.Utils.PointFloat(102.6388!, 33.99999!)
        Me.txtReceivedby.Multiline = True
        Me.txtReceivedby.Name = "txtReceivedby"
        Me.txtReceivedby.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReceivedby.SizeF = New System.Drawing.SizeF(245.8333!, 23.00001!)
        Me.txtReceivedby.StylePriority.UseFont = False
        Me.txtReceivedby.StylePriority.UseTextAlignment = False
        Me.txtReceivedby.Text = "TRANSACTION DATE :"
        Me.txtReceivedby.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(15.16666!, 111.5!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(117.5!, 23.00002!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "ADDRESS :"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtAddress
        '
        Me.txtAddress.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.txtAddress.LocationFloat = New DevExpress.Utils.PointFloat(132.6667!, 112.5!)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.txtAddress.SizeF = New System.Drawing.SizeF(501.4035!, 21.99998!)
        Me.txtAddress.StylePriority.UseBorders = False
        Me.txtAddress.StylePriority.UsePadding = False
        Me.txtAddress.StylePriority.UseTextAlignment = False
        Me.txtAddress.Text = "0925-586-7989"
        Me.txtAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New ArkAntSoftwarePOS.xtrSubReport_PatientDetails()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(750.0!, 23.0!)
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial Narrow", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 266.6944!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(165.0!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Transaction Details :"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xtrPatientTransactionMonitoring
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents txtDiscounted As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtUnfilled As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCharging As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtContatNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtGender As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDOB As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtAge As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTranDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTransNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTimeOut As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTimeIN As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPatient As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtServedby As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtReceivedby As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents txtAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
End Class
