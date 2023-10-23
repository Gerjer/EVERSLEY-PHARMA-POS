<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_ReceiptHeader
    Inherits DataDynamics.ActiveReports.ActiveReport3

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rpt_ReceiptHeader))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtCompname = New DataDynamics.ActiveReports.TextBox
        Me.txtAddress = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        CType(Me.txtCompname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Height = 0.0!
        Me.Detail1.Name = "Detail1"
        Me.Detail1.Visible = False
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCompname, Me.txtAddress})
        Me.PageHeader1.Height = 0.34375!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtCompname
        '
        Me.txtCompname.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCompname.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompname.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCompname.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompname.Border.RightColor = System.Drawing.Color.Black
        Me.txtCompname.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompname.Border.TopColor = System.Drawing.Color.Black
        Me.txtCompname.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompname.Height = 0.1875!
        Me.txtCompname.Left = 0.0!
        Me.txtCompname.Name = "txtCompname"
        Me.txtCompname.Style = "ddo-char-set: 0; text-align: center; font-size: 6pt; font-family: Century; "
        Me.txtCompname.Text = "companyName"
        Me.txtCompname.Top = 0.0!
        Me.txtCompname.Width = 1.8125!
        '
        'txtAddress
        '
        Me.txtAddress.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAddress.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAddress.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Border.RightColor = System.Drawing.Color.Black
        Me.txtAddress.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Border.TopColor = System.Drawing.Color.Black
        Me.txtAddress.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAddress.Height = 0.1875!
        Me.txtAddress.Left = 0.0!
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Style = "ddo-char-set: 0; text-align: center; font-size: 6pt; font-family: Century; "
        Me.txtAddress.Text = "address"
        Me.txtAddress.Top = 0.1875!
        Me.txtAddress.Width = 1.8125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        Me.PageFooter1.Visible = False
        '
        'rpt_ReceiptHeader
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.05!
        Me.PageSettings.Margins.Top = 0.05!
        Me.PageSettings.PaperHeight = 4.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 2.28!
        Me.PrintWidth = 2.03125!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtCompname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Friend WithEvents txtCompname As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAddress As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
End Class
