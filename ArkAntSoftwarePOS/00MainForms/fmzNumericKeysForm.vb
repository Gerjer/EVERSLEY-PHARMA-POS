Public Class fmzNumericKeysForm

    Public Event acceptClick()
    Private Const WHOLENUMBERFORMAT As String = "#,###,###,###,###,###"


    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btnDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub btnDouble0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDouble0.Click
        buttonNumericClick(sender.text)
    End Sub

    Private Sub buttonNumericClick(ByVal btnValue As String)
        Dim Value As Double


        Value = CDbl(Me.txtNumDisplay.Text)
        Try
            If Value = 0 Then
                Me.txtNumDisplay.Text = btnValue
            Else
                If Me.txtNumDisplay.Text.Contains(".") Then
                    Me.txtNumDisplay.Text = Me.txtNumDisplay.Text & btnValue

                    Dim period As Integer = Me.txtNumDisplay.Text.IndexOf(".")
                    Dim last As Integer = Me.txtNumDisplay.Text.Length()



                    Dim wholeNumber As Integer = Me.txtNumDisplay.Text.Substring(0, period)

                    Dim point As String = Me.txtNumDisplay.Text.Substring(period, last - period)

                    Me.txtNumDisplay.Text = Format(wholeNumber, WHOLENUMBERFORMAT) & point

                    'Me.txtNumDisplay.Text = Format(CDbl(Me.txtNumDisplay.Text), "#,###,###,###.00")
                ElseIf btnValue = "." Then
                    Me.txtNumDisplay.Text = Me.txtNumDisplay.Text & btnValue

                Else

                    Me.txtNumDisplay.Text = Me.txtNumDisplay.Text & btnValue
                    Dim wholeNumber As Integer = CInt(Me.txtNumDisplay.Text)
                    Me.txtNumDisplay.Text = Format(wholeNumber, WHOLENUMBERFORMAT)

                End If

            End If
        Catch ex As Exception
            MsgBox("ERROR : " & ex.Message)
        End Try
        


        'Me.txtNumDisplay.Text = Format(Value, "#,###,###,###.00")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        RaiseEvent acceptClick()
        btnCancel.PerformClick()

        Me.Close()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        Me.txtNumDisplay.Text = "0.00"
        Me.txtNumDisplay.Focus()
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackSpace.Click
        If Me.txtNumDisplay.Text.Length > 0 Then
            Me.txtNumDisplay.Text = Me.txtNumDisplay.Text.Substring(0, Me.txtNumDisplay.Text.Length - 1)
        End If
        Me.txtNumDisplay.Focus()
    End Sub

    Private Sub txtNumDisplay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDisplay.KeyPress

        Dim keychar As Char = e.KeyChar


        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.D0)
                btn0.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D1)
                btn1.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D2)
                btn2.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D3)
                btn3.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D4)
                btn4.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D5)
                btn5.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D6)
                btn6.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D7)
                btn7.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D8)
                btn8.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D9)
                btn9.PerformClick()
            Case "."
                btnDot.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Back)
                btnBackSpace.PerformClick()

        End Select
    End Sub
    Private Sub txtNumDisplay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumDisplay.TextChanged
        If txtNumDisplay.Text.Length = 0 Then
            txtNumDisplay.Text = "0.00"
        End If
    End Sub

    Private Sub btn1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1000.Click, btn500.Click, btn200.Click, btn100.Click, btn50.Click, btn20.Click
        txtNumDisplay.Text = Format(CDbl(If(IsNumeric(CType(sender, DevComponents.DotNetBar.ButtonX).Text), CType(sender, DevComponents.DotNetBar.ButtonX).Text, "0.00")), "#,###,##0.00")
        txtNumDisplay.Focus()
    End Sub

    Private Sub fmzNumericKeysForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim keychar As Char = e.KeyChar


        Select e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.D0)
                btn0.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D1)
                btn1.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D2)
                btn2.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D3)
                btn3.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D4)
                btn4.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D5)
                btn5.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D6)
                btn6.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D7)
                btn7.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D8)
                btn8.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.D9)
                btn9.PerformClick()
            Case "."
                btnDot.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Back)
                btnBackSpace.PerformClick()
        End Select
    End Sub

    

    Private Sub fmzNumericKeysForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNumDisplay.Focus()
    End Sub
End Class