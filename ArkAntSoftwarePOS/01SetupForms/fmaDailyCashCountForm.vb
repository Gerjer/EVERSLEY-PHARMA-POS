Imports MySql.Data.MySqlClient

Public Class fmaDailyCashCountForm

    Private TOTAL_DENOMINATION As Double = 0


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub fmaDailyCashCountForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim SQLEX As String = "SELECT DCC_date from daily_cash_count where DCC_date='" & Format(Date.Now, "yyyy-MM-dd") & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count = 0 Then
            Dim SQLIN As String = "INSERT INTO daily_cash_count(DCC_date) VALUES('" & Format(Date.Now, "yyyy-MM-dd") & "')"
            clsDBConn.ExecuteSilence(SQLIN)
        End If


        Me.WinLabel.Text = "Cash Count For : " & Format(Date.Now, " MMMM dd, yyyy")
        displayCashCount()


        getTotalSales()
        getTotalAmount()
    End Sub

    Private Sub den_1000_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_1000.Click
        den_1000.SelectAll()
    End Sub

    Private Sub den_1000_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_1000.GotFocus
        den_1000.SelectAll()
    End Sub


    Private Sub den_1000_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_1000.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False

            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_500_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_500.Click
        den_500.SelectAll()
    End Sub

    Private Sub den_500_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_500.GotFocus
        den_500.SelectAll()
    End Sub

    Private Sub den_500_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_500.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_200_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_200.Click
        den_200.SelectAll()
    End Sub

    Private Sub den_200_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_200.GotFocus
        den_200.SelectAll()
    End Sub

    Private Sub den_200_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_200.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_100_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_100.Click
        den_100.SelectAll()
    End Sub

    Private Sub den_100_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_100.GotFocus
        den_100.SelectAll()
    End Sub

    Private Sub den_100_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_100.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_50_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_50.Click
        den_50.SelectAll()
    End Sub

    Private Sub den_50_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_50.GotFocus
        den_50.SelectAll()
    End Sub

    Private Sub den_50_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_50.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_20.Click
        den_20.SelectAll()
    End Sub

    Private Sub den_20_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_20.GotFocus
        den_20.SelectAll()
    End Sub

    Private Sub den_20_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_20.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_10.Click
        den_10.SelectAll()
    End Sub

    Private Sub den_10_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_10.GotFocus
        den_10.SelectAll()
    End Sub

    Private Sub den_10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_10.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_05.Click
        den_05.SelectAll()
    End Sub

    Private Sub den_05_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_05.GotFocus
        den_05.SelectAll()
    End Sub

    Private Sub den_05_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_05.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_01.Click
        den_01.SelectAll()
    End Sub

    Private Sub den_01_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_01.GotFocus
        den_01.SelectAll()
    End Sub

    Private Sub den_01_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_01.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_025_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_025.Click
        den_025.SelectAll()
    End Sub

    Private Sub den_025_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_025.GotFocus
        den_025.SelectAll()
    End Sub


    Private Sub den_025_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_025.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_010_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_010.Click
        den_010.SelectAll()
    End Sub

    Private Sub den_010_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_010.GotFocus
        den_010.SelectAll()
    End Sub

    Private Sub den_010_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_010.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_050_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_050.Click
        den_050.SelectAll()
    End Sub

    Private Sub den_050_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_050.GotFocus
        den_050.SelectAll()
    End Sub

    Private Sub den_050_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_050.KeyPress
        Select Case e.KeyChar
            Case "0" To "9", Chr(Keys.Back)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub den_1000_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_1000.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_500.Focus()
        End If
    End Sub


    Private Sub den_1000_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_1000.TextChanged

        If den_1000.Text.Length = 0 Then
            den_1000.Text = "0"
        End If

        Try
            Dim total As Double = 1000 * CInt(den_1000.Text)
            total_den_1000.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_1000.Text = "0.00"
        End Try

        GetTotalDenomination()
    End Sub

    Private Sub den_500_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_500.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_200.Focus()
        End If
    End Sub

    Private Sub den_500_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_500.TextChanged
        If den_500.Text.Length = 0 Then
            den_500.Text = "0"
        End If

        Try
            Dim total As Double = 500 * CInt(den_500.Text)
            total_den_500.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_500.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_100_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_100.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_50.Focus()
        End If
    End Sub

    Private Sub den_100_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_100.TextChanged
        If den_100.Text.Length = 0 Then
            den_100.Text = "0"
        End If

        Try
            Dim total As Double = 100 * CInt(den_100.Text)
            total_den_100.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_100.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_200_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_200.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_100.Focus()
        End If
    End Sub

    Private Sub den_200_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_200.TextChanged
        If den_200.Text.Length = 0 Then
            den_200.Text = "0"
        End If
        Try
            Dim total As Double = 200 * CInt(den_200.Text)
            total_den_200.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_200.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_50_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_50.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_20.Focus()
        End If
    End Sub

    Private Sub den_50_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_50.TextChanged

        If den_50.Text.Length = 0 Then
            den_50.Text = "0"
        End If

        Try
            Dim total As Double = 50 * CInt(den_50.Text)
            total_den_50.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_50.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_20_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_20.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_10.Focus()
        End If
    End Sub

    Private Sub den_20_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_20.TextChanged
        If den_20.Text.Length = 0 Then
            den_20.Text = "0"
        End If

        Try
            Dim total As Double = 20 * CInt(den_20.Text)
            total_den_20.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_20.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_10.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_05.Focus()
        End If
    End Sub

    Private Sub den_10_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_10.TextChanged
        If den_10.Text.Length = 0 Then
            den_10.Text = "0"
        End If

        Try
            Dim total As Double = 10 * CInt(den_10.Text)
            total_den_10.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_10.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_05_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_05.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_01.Focus()
        End If
    End Sub

    Private Sub den_05_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_05.TextChanged
        If den_05.Text.Length = 0 Then
            den_05.Text = "0"
        End If

        Try
            Dim total As Double = 5 * CInt(den_05.Text)
            total_den_05.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_05.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_01_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_01.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_025.Focus()
        End If
    End Sub

    Private Sub den_01_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_01.TextChanged

        If den_01.Text.Length = 0 Then
            den_01.Text = "0"
        End If

        Try
            Dim total As Double = 1 * CInt(den_01.Text)
            total_den_01.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_01.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_025_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_025.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_010.Focus()
        End If
    End Sub

    Private Sub den_025_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_025.TextChanged

        If den_025.Text.Length = 0 Then
            den_025.Text = "0"
        End If

        Try
            Dim total As Double = 0.25 * CInt(den_025.Text)
            total_den_025.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_025.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_010_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_010.KeyUp
        If e.KeyCode = Keys.Enter Then
            den_050.Focus()
        End If
    End Sub

    Private Sub den_010_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_010.TextChanged

        If den_010.Text.Length = 0 Then
            den_010.Text = "0"
        End If

        Try
            Dim total As Double = 0.1 * CInt(den_010.Text)
            total_den_010.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_010.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub

    Private Sub den_050_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles den_050.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub den_050_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_050.TextChanged
        If den_050.Text.Length = 0 Then
            den_050.Text = "0"
        End If


        Try
            Dim total As Double = 0.05 * CInt(den_050.Text)
            total_den_050.Text = Format(total, "#,##0.00")
        Catch ex As Exception
            total_den_050.Text = "0.00"
        End Try
        GetTotalDenomination()
    End Sub



    Private Sub GetTotalDenomination()
        TOTAL_DENOMINATION = 0

        Try
            TOTAL_DENOMINATION += IIf(total_den_1000.Text = "", 0, CDbl(total_den_1000.Text))
            TOTAL_DENOMINATION += IIf(total_den_500.Text = "", 0, CDbl(total_den_500.Text))
            TOTAL_DENOMINATION += IIf(total_den_200.Text = "", 0, CDbl(total_den_200.Text))
            TOTAL_DENOMINATION += IIf(total_den_100.Text = "", 0, CDbl(total_den_100.Text))
            TOTAL_DENOMINATION += IIf(total_den_50.Text = "", 0, CDbl(total_den_50.Text))
            TOTAL_DENOMINATION += IIf(total_den_20.Text = "", 0, CDbl(total_den_20.Text))
            TOTAL_DENOMINATION += IIf(total_den_10.Text = "", 0, CDbl(total_den_10.Text))
            TOTAL_DENOMINATION += IIf(total_den_05.Text = "", 0, CDbl(total_den_05.Text))
            TOTAL_DENOMINATION += IIf(total_den_01.Text = "", 0, CDbl(total_den_01.Text))
            TOTAL_DENOMINATION += IIf(total_den_025.Text = "", 0, CDbl(total_den_025.Text))
            TOTAL_DENOMINATION += IIf(total_den_010.Text = "", 0, CDbl(total_den_010.Text))
            TOTAL_DENOMINATION += IIf(total_den_050.Text = "", 0, CDbl(total_den_050.Text))
            TOTAL_DENOMINATION += IIf(txtden1cent.Text = "", 0, CDbl(txtden1cent.Text))

        Catch ex As Exception

        End Try

       
        txtTotalAmount.Text = Format(TOTAL_DENOMINATION, "#,##0.00")
    End Sub


    Private Sub getTotalSales()
        'GET ALL PAID TOTAL OF BILL OF LADING ON THE SAME DATE

        txtDailySales.Text = "0.00"

    End Sub

    Private Sub txtTotalAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalAmount.TextChanged
        getTotalAmount()
    End Sub

    Private Sub getTotalAmount()
        Dim totalAmount As Double = 0
        Dim totalSales As Double = 0


        Try
            totalAmount = CDbl(txtTotalAmount.Text)
        Catch ex As Exception

        End Try

        Try
            totalSales = CDbl(txtDailySales.Text)
        Catch ex As Exception

        End Try

        Dim diff As Double = totalAmount - totalSales


        If diff < 0 Then
            txtOverShort.Text = "<" & Format(diff, "#,##0.00") & ">"
            txtOverShort.ForeColor = Color.Red
            'btnSave.Enabled = False
        ElseIf diff > 0 Then
            txtOverShort.Text = "<" & Format(diff, "#,##0.00") & ">"
            txtOverShort.ForeColor = Color.SeaGreen
            'btnSave.Enabled = False
        Else
            txtOverShort.Text = Format(diff, "#,##0.00")
            txtOverShort.ForeColor = Color.MidnightBlue
            'btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Are you sure you want to SAVE AMOUNT?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim SQLUP As String = "UPDATE daily_cash_count"
            SQLUP += String.Format(" SET den_1000 = '{0}',", den_1000.Text.Replace(",", ""))
            SQLUP += String.Format(" den_500 = '{0}',", den_500.Text.Replace(",", ""))
            SQLUP += String.Format(" den_200 = '{0}',", den_200.Text.Replace(",", ""))
            SQLUP += String.Format(" den_100 = '{0}',", den_100.Text.Replace(",", ""))
            SQLUP += String.Format(" den_50 = '{0}',", den_50.Text.Replace(",", ""))
            SQLUP += String.Format(" den_20 = '{0}',", den_20.Text.Replace(",", ""))
            SQLUP += String.Format(" den_10 = '{0}',", den_10.Text.Replace(",", ""))
            SQLUP += String.Format(" den_05 = '{0}',", den_05.Text.Replace(",", ""))
            SQLUP += String.Format(" den_01 = '{0}',", den_01.Text.Replace(",", ""))
            SQLUP += String.Format(" den_025 = '{0}',", den_025.Text.Replace(",", ""))
            SQLUP += String.Format(" den_010 = '{0}',", den_010.Text.Replace(",", ""))
            SQLUP += String.Format(" den_050 = '{0}',", den_050.Text.Replace(",", ""))
            'SQLUP += String.Format(" den_001 = '{0}',", den_001.Text)
            SQLUP += String.Format(" daily_total = '{0}'", txtTotalAmount.Text.Replace(",", ""))
            SQLUP += String.Format(" WHERE DCC_date = '{0}'", Format(Date.Now, "yyyy-MM-dd"))



            If clsDBConn.Execute(SQLUP) Then
                MsgBox("CASH COUNT HAS BEEN SAVED.", MsgBoxStyle.Information)
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub displayCashCount()
        Dim SQLEX As String = "SELECT den_1000,den_500"
        SQLEX += " ,den_200,den_100,den_50"
        SQLEX += " ,den_20,den_10,den_05"
        SQLEX += " ,den_01,den_025,den_010"
        'SQLEX += " ,den_050,den_001, daily_total FROM daily_cash_count"
        SQLEX += " ,den_050,daily_total FROM daily_cash_count"
        SQLEX += String.Format(" WHERE DCC_date = '{0}'", Format(Date.Now, "yyyy-MM-dd"))

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)


        If MeData.Rows.Count > 0 Then
            Try
                
                den_1000.Text = CInt(MeData.Rows(0).Item("den_1000").ToString)
                den_500.Text = CInt(MeData.Rows(0).Item("den_500").ToString)
                den_200.Text = CInt(MeData.Rows(0).Item("den_200").ToString)
                den_100.Text = CInt(MeData.Rows(0).Item("den_100").ToString)
                den_50.Text = CInt(MeData.Rows(0).Item("den_50").ToString)
                den_20.Text = CInt(MeData.Rows(0).Item("den_20").ToString)
                den_10.Text = CInt(MeData.Rows(0).Item("den_10").ToString)
                den_05.Text = CInt(MeData.Rows(0).Item("den_05").ToString)
                den_01.Text = CInt(MeData.Rows(0).Item("den_01").ToString)
                den_025.Text = CInt(MeData.Rows(0).Item("den_025").ToString)
                den_010.Text = CInt(MeData.Rows(0).Item("den_010").ToString)
                den_050.Text = CInt(MeData.Rows(0).Item("den_050").ToString)
                'den_001.Text = CInt(MeData.Rows(0).Item("den_001").ToString)




            Catch ex As Exception

            End Try
        End If


    End Sub

    'Private Sub den_001_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_001.Click
    '    den_001.SelectAll()
    'End Sub

    'Private Sub den_001_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_001.GotFocus
    '    den_001.SelectAll()
    'End Sub

    'Private Sub den_001_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles den_001.KeyPress
    '    Select Case e.KeyChar
    '        Case "0" To "9", Chr(Keys.Back)
    '            e.Handled = False
    '        Case Else
    '            e.Handled = True
    '    End Select
    'End Sub


    'Private Sub den_001_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles den_001.TextChanged

    '    If den_001.Text.Length = 0 Then
    '        den_001.Text = "0"
    '    End If

    '    Try
    '        Dim total As Double = 0.01 * CInt(den_001.Text)
    '        txtden1cent.Text = Format(total, "#,##0.00")
    '    Catch ex As Exception
    '        txtden1cent.Text = "0.00"
    '    End Try
    '    GetTotalDenomination()
    'End Sub

    Private Sub txtDailySales_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDailySales.MouseHover
        BalloonTip1.SetBalloonText(Me.txtDailySales, "GET ALL THE CASH PAID TRANSACTION FOR THIS DATE")
        BalloonTip1.ShowBalloon(Me.txtDailySales)
    End Sub
End Class