Imports System.IO
Imports System.Runtime.InteropServices
Imports DevExpress.DirectX
Imports Microsoft.Office.Interop

Public Class frmAttacheFile


    Public file_attach As New List(Of attach_file)
    Dim LoadedImage As Boolean
    Public FileName As String = ""
    Public FilePath As String = ""
    Public Images As Image
    Dim File_Dir As String = ""
    Public IfThereIsTransaction As Boolean = False

    Public RISNO As String = ""


    Private Sub frmAttacheFile_Load(sender As Object, e As EventArgs) Handles Me.Load

        PictureBox1.Image = PictureBox1.InitialImage
        GroupControl1.Enabled = False
        loadList()
        loadComboBox()
        creatDirectory()

    End Sub

    Private Sub loadComboBox()
        cmbTypeFile.DataSource = DataSource(String.Format("SELECT
                                          ris_attachment.RIS_Master_No 'id',
	                                        ris_attachment.attach_type 'name'
                                        FROM
	                                        ris_attachment
                                        GROUP BY
	                                        ris_attachment.attach_type"))
        cmbTypeFile.ValueMember = "id"
        cmbTypeFile.DisplayMember = "name"
        cmbTypeFile.SelectedIndex = -1
    End Sub

    Private Sub creatDirectory()

        Try
            Dim dir As String = ""
            dir = Directory.GetCurrentDirectory & "\attach_file\"

            If (Not Directory.Exists(dir)) Then
                File_Dir = dir
                Directory.CreateDirectory(dir)
            Else
                File_Dir = dir
            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub loadList()

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT ris_attachment.RIS_Master_No 'RIS No.',`attach_type` AS 'TYPE',`attach_filename` AS 'FILE NAME',`attach_dir` AS 'DIR' FROM `ris_attachment`"))
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim fileName As String = ""
        Dim file_Format As String = ""

        With OpenFileDialog1
            .Title = "Select a File"  ' Path.GetFileName(.FileName)
            .InitialDirectory = "C:\"
            '       .Filter = " | *.txt |,*.docx,*.pdf,*.rtf,*.xls,*.xlsx,(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG"
            .FilterIndex = 1
        End With
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LoadedImage = True
            With PictureBox1

                file_Format = Path.GetExtension(OpenFileDialog1.FileName)
                Select Case file_Format
                    Case ".tx"
                        fileName = Directory.GetCurrentDirectory & "\icon_logo\notepad1.png"
                    Case ".docx"
                        fileName = Directory.GetCurrentDirectory & "\icon_logo\MicrosoftWord.png"
                    Case ".pdf"
                        fileName = Directory.GetCurrentDirectory & "\icon_logo\pdf.png"
                    Case ".rtf"
                        fileName = Directory.GetCurrentDirectory & "\icon_logo\rtf.png"
                    Case ".xlsx", ".xls,", ".xlsm"
                        fileName = Directory.GetCurrentDirectory & "\icon_logo\MicrosoftExcell.png"
                    Case Else
                        fileName = OpenFileDialog1.FileName
                End Select
                '     .Image = Image.FromFile(OpenFileDialog1.FileName)
                .Image = Image.FromFile(fileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With

            txtFilePath.Text = OpenFileDialog1.FileName
            FilePath = txtFilePath.Text
            FileName = txtFilePath.Text.Trim
            txtFileName.Text = FileName.Substring(FileName.LastIndexOf("\"c) + 1)


            If IfThereIsTransaction = False Then
                file_attach.Clear()
            End If
            GroupControl1.Enabled = True

        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If cmbTypeFile.Text = "" Then
            MsgBox("Required Fields...!!,TYPE OF FILE", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dt As New DataTable
        dt = GridControl1.DataSource
        If GridView1.RowCount > 0 Or GridControl1 IsNot Nothing Then
            dt.Rows.Add(RISNO, cmbTypeFile.Text, txtFileName.Text, txtFilePath.Text)

            Images = PictureBox1.Image

            Dim obj As New attach_file
            With obj
                .attach_type = cmbTypeFile.Text
                .attach_file_name = txtFileName.Text
                .attach_file_path = txtFilePath.Text
                .attach_file_dir = File_Dir
                .attach_image = Images
            End With
            file_attach.Add(obj)

            GridControl1.DataSource = Nothing
            GridView1.Columns.Clear()

            GridControl1.DataSource = dt

            IfThereIsTransaction = True
        End If


    End Sub

    Private Sub txtFilePath_MouseHover(sender As Object, e As EventArgs) Handles txtFilePath.MouseHover
        txtFilePath.ToolTip = txtFilePath.Text
    End Sub


    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim fileName As String = GridView1.GetFocusedRowCellValue("FILE NAME")
        Dim file_Format As String = fileName.Substring(fileName.IndexOf("."c))
        Dim Dir As String = ""

        Select Case file_Format
            Case ".tx"
                Dir = Directory.GetCurrentDirectory & "\icon_logo\notepad1.png"
                getProcessDocument(GridView1.GetFocusedRowCellValue("DIR"))
            Case ".docx"
                Dir = Directory.GetCurrentDirectory & "\icon_logo\MicrosoftWord.png"
                getProcessDocument(GridView1.GetFocusedRowCellValue("DIR"))
            Case ".pdf"
                Dir = Directory.GetCurrentDirectory & "\icon_logo\pdf.png"
                getProcessDocument(GridView1.GetFocusedRowCellValue("DIR"))
            Case ".rtf"
                Dir = Directory.GetCurrentDirectory & "\icon_logo\rtf.png"
                getProcessDocument(GridView1.GetFocusedRowCellValue("DIR"))
            Case ".xlsx", ".xls,", ".xlsm"
                Dir = Directory.GetCurrentDirectory & "\icon_logo\MicrosoftExcell.png"
                getProcessDocument(GridView1.GetFocusedRowCellValue("DIR"))
            Case Else
                Dir = GridView1.GetFocusedRowCellValue("DIR")
        End Select

        Try
            If Not File_Dir.Length = 0 Then
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.BorderStyle = BorderStyle.Fixed3D
                PictureBox1.Load(Dir)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub getProcessDocument(file_path As Object)
        If My.Computer.FileSystem.FileExists(file_path) Then
            Process.Start(file_path)
        Else
            MsgBox("File does not exist", MsgBoxStyle.Critical, "FIL NOT FOUND")
        End If
    End Sub
End Class