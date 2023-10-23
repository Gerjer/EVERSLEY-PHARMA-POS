<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_tr_barcode 
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
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rpt_tr_barcode))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.Barcode1 = New DataDynamics.ActiveReports.Barcode
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Barcode1})
        Me.Detail1.Height = 1.010417!
        Me.Detail1.Name = "Detail1"
        '
        'Barcode1
        '
        Me.Barcode1.Border.BottomColor = System.Drawing.Color.Black
        Me.Barcode1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.LeftColor = System.Drawing.Color.Black
        Me.Barcode1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.RightColor = System.Drawing.Color.Black
        Me.Barcode1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.TopColor = System.Drawing.Color.Black
        Me.Barcode1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.CaptionPosition = DataDynamics.ActiveReports.BarCodeCaptionPosition.Below
        Me.Barcode1.DataField = "transactionno"
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode1.Height = 0.6875!
        Me.Barcode1.Left = 0.25!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_93
        Me.Barcode1.Text = "16011409"
        Me.Barcode1.Top = 0.1875!
        Me.Barcode1.Width = 1.75!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'rpt_tr_barcode
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 2.0!
        Me.PageSettings.Margins.Left = 0.02!
        Me.PageSettings.Margins.Right = 0.02!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.135417!
        Me.ScriptLanguage = "VB.NET"
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Barcode1 As DataDynamics.ActiveReports.Barcode
End Class 
