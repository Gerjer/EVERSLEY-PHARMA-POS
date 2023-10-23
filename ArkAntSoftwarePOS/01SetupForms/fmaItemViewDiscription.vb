'Imports DevExpress.Utils.MVVM.Services.DocumentManagerService
Imports DevExpress.XtraReports.Design.CodeCompletion
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.DocumentFormat

Public Class fmaItemViewDiscription

    Public indication As String = ""
    Public interaction As String = ""
    Public inv_id As String = ""

    Dim document As DevExpress.XtraRichEdit.API.Native.Document
    Dim document1 As DevExpress.XtraRichEdit.API.Native.Document

    Private Sub fmaItemViewDiscription_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Me.Tag = 1 Then
            btnSaveRIS.Text = "APPLY TEXT"
        Else
            btnSaveRIS.Text = "UPDATE TEXT"
        End If

        document = RichEditControl1.Document
        Dim pos As DevExpress.XtraRichEdit.API.Native.DocumentPosition = document.CreatePosition(1)
        document.InsertText(pos, indication)
        document.Unit = DevExpress.Office.DocumentUnit.Inch
        document.Sections(0).Page.Width = 4.0F
        document.Sections(0).Margins.Top = 0.25F
        document.Sections(0).Margins.Left = 0.25F
        document.Sections(0).Margins.Right = 0.25F

        RichEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
        RichEditControl1.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden

        document1 = RichEditControl2.Document
        Dim pos1 As DevExpress.XtraRichEdit.API.Native.DocumentPosition = document1.CreatePosition(1)
        document1.InsertText(pos1, interaction)
        document1.Unit = DevExpress.Office.DocumentUnit.Inch
        document1.Sections(0).Page.Width = 4.0F
        document1.Sections(0).Margins.Top = 0.25F
        document1.Sections(0).Margins.Left = 0.25F
        document1.Sections(0).Margins.Right = 0.25F

        RichEditControl2.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
        RichEditControl2.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden

        'Dim document1 As DevExpress.XtraRichEdit.API.Native.Document = RichEditControl2.Document
        'Dim pos1 As DevExpress.XtraRichEdit.API.Native.DocumentPosition = document1.CreatePosition(1)
        'document1.InsertText(pos1, interaction)
        'document1.Sections(0).Margins.Top = 10.0F
        'document1.Sections(0).Margins.Left = 10.0F
        'document1.Sections(0).Margins.Right = 5.0F

        'RichEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
        'RichEditControl2.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden

        'RichEditControl1.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden
        'RichEditControl2.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden

        'RichEditControl1.Document.Sections(0).Page.PaperKind = System.Drawing.Printing.PaperKind.A2

        'RichEditControl1.Document.Sections(0).Margins.Left = 2.0F
        'RichEditControl1.Document.Sections(0).Margins.Right = 2.0F

    End Sub

    Private Sub btnSaveRIS_Click(sender As Object, e As EventArgs) Handles btnSaveRIS.Click

        apply_indication = document.GetText(document.Range)
        apply_interaction = document1.GetText(document1.Range)

        If Me.Tag = 2 Then
            DataSource(String.Format("UPDATE inventory_master SET indication = '" & apply_indication & "',drug_interaction = '" & apply_interaction & "' WHERE SysPK = '" & inv_id & "'"))
        End If

        Me.Close()

    End Sub
End Class