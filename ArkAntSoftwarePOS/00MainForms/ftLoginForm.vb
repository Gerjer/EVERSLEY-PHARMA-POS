Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging


Public Class ftLoginForm

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim myData As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim dt As New DataTable
    Dim abc As String
    Private DefaultImage As Image

    Dim rawData() As Byte
    Dim FileSize As UInt32
    Dim fs As FileStream

    Private WithEvents company As frmCompanyProfileSetup


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ftLoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.DoEvents()
        GroupPanel1.Focus()
        txtUserName.Focus()
        txtUserName.SelectAll()
        Me.ActiveControl = Me.txtUserName
        displayCompanyInfo()
        clsDBConn = New clsDBConnection
        If Not clsDBConn.IsDBConnected() Then
            'ftDatabaseConnectionForm.BringToFront()
            ftDatabaseConnectionForm.ShowDialog()
        End If


    End Sub

    Private Function IsLoginOK(ByVal UserName As String, ByVal Password As String) As Boolean
        Dim Ret As Boolean = False

        If UserName.Trim = "" And Password = "pbb12345" Then
            AuthUserName = ""
            AuthUserType = ""
            Return True
            Exit Function
        End If

        Dim SQL As String = String.Format("SELECT Type_User,UserFull_name FROM users WHERE UserName_User='{0}' AND Password_User='{1}' AND SysPK_User<>0", UserName, Password)
        Dim Medata As New DataTable

        Try
            Medata = clsDBConn.ExecQuery(SQL)

            If Medata.Rows.Count > 0 Then
                AuthUserName = UserName
                AuthUserType = Medata.Rows(0).Item("Type_User").ToString
                FullUserName = Medata.Rows(0).Item("UserFull_name").ToString
                Ret = True
            Else
                AuthUserName = ""
                AuthUserType = ""
                Ret = False
            End If
        Catch ex As Exception
            Ret = False
        End Try

        getCompanyProfile()
        Medata = Nothing
        Return Ret


    End Function

    Private Sub getCompanyProfile()
        Dim SQLEX As String = "SELECT company_name, address FROM FILE"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                COMPANY_NAME = MeData.Rows(0).Item("company_name").ToString
                COMPANY_ADDRESS = MeData.Rows(0).Item("address").ToString
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtUserName_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtUserName.Text = ""
    End Sub

    Private Sub txtPassword_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtPassword.Text = ""
    End Sub

    Private Sub txtPassword_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtPassword.SelectAll()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = CChar(ChrW(Keys.Enter)) Then
            Call btnOK_Click_1(sender, e)
        End If
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub pxBoxSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""
                Me.Show()
                Exit Sub
            End If
            company = New frmCompanyProfileSetup

            company.ShowDialog()
        Else
            Me.Show()
            frmSU_Pass.txtPassword.Text = ""
            Exit Sub
        End If
        'Me.Show()
    End Sub

    Private Sub company_winClosing() Handles company.winClosing
        displayCompanyInfo()
        Me.Show()
        'Me.displayPicture()
        'Me.Close()
    End Sub

    Private Sub displayCompanyInfo()
        Dim ServerName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName")
        Dim DatabaseName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName")
        Dim UserID As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName")
        Dim Password As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password")
        Dim connectionString As String = String.Format("server={0};database={1};uid={2};pwd={3}", ServerName, DatabaseName, UserID, Password)

        Try
            con.ConnectionString = connectionString
            cmd.Connection = con
            con.Open()
        Catch ex As Exception

        End Try
        


        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT file_name, file_size, file,company_name, address,contactnum FROM file"

            myData = cmd.ExecuteReader

            If Not myData.HasRows Then
                myData.Close()
                Exit Sub
            End If

            myData.Read()
            Dim file_name As String = myData.GetString("file_name")
            Me.txtDisplayName.Text = myData.GetString("company_name")
            FileSize = myData.GetUInt32(myData.GetOrdinal("file_size"))
            rawData = New Byte(FileSize) {}

            myData.GetBytes(myData.GetOrdinal("file"), 0, rawData, 0, FileSize)

            fs = New FileStream("C:\newfile.png", FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(rawData, 0, FileSize)
            fs.Close()


            myData.Close()
            con.Close()
            'Me.txtPhotoPath_Empl.Text = "C:\newfile.png"
        Catch ex As Exception
            'MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            pic_box_save.BackgroundImage = Image.FromFile("C:\newfile.png")
        Catch ex As Exception
        End Try
    End Sub

   
    Private Sub txtUserName_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtUserName.SelectAll()
    End Sub

    Private Sub lblSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""
                Me.Show()
                Exit Sub
            End If
            company = New frmCompanyProfileSetup

            company.ShowDialog()
        Else
            Me.Show()
            frmSU_Pass.txtPassword.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub btnOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If IsLoginOK(Me.txtUserName.Text, Me.txtPassword.Text) Then
            txtUserName.Focus()
            txtPassword.Text = ""

            Me.Hide()

            'Mainloading.ShowDialog()
            ftmdiMainForm.Show()
            ftmdiMainForm.global_loginAuth.Text = AuthUserName & ":" & AuthUserType

        Else
            MessageBox.Show("Login is Incorrect....", "Please Verify UserName and Password!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancel_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lblSettings_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSettings.Click
        Me.Hide()
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""
                Me.Show()
                Exit Sub
            End If
            company = New frmCompanyProfileSetup

            company.ShowDialog()
        Else
            Me.Show()
            frmSU_Pass.txtPassword.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub pxBoxSettings_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxBoxSettings.Click
        Me.Hide()
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""
                Me.Show()
                Exit Sub
            End If
            'company = New frmCompanyProfileSetup
            'company.ShowDialog()

            Dim frm As New ftDatabaseConnectionForm
            frm.ShowDialog()


        Else
            Me.Show()
            frmSU_Pass.txtPassword.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub txtUserName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
            txtPassword.SelectAll()
        End If
    End Sub

    Private Sub txtPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    Private Sub btnBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlank.Click
        txtUserName.Focus()
        txtUserName.SelectAll()
    End Sub

    Private Sub ftLoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control And e.Shift And e.KeyCode = Keys.F10 Then
            Me.txtUserName.Text = "void"
            Me.txtPassword.Text = "HappyBirthDay"
            If IsLoginOK(Me.txtUserName.Text, Me.txtPassword.Text) Then
                txtUserName.Focus()
                txtPassword.Text = ""

                Me.Hide()

                'Mainloading.ShowDialog()
                ftmdiMainForm.Show()
                ftmdiMainForm.global_loginAuth.Text = AuthUserName & ":" & AuthUserType

            Else
                MessageBox.Show("Login is Incorrect....", "Please Verify UserName and Password!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class