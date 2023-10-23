Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_dailyCashCount

    Private totalCash As Double = 0

    Sub New()
        InitializeComponent()

    End Sub

    Sub New(ByVal dateFrom As String)
        InitializeComponent()

        Me.txtDate.Text = dateFrom

    End Sub

    Private Sub rpt_InventoryReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS
    End Sub




    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim dm1000 As Double = 1000
        Dim dm500 As Double = 500
        Dim dm200 As Double = 200
        Dim dm100 As Double = 100
        Dim dm50 As Double = 50
        Dim dm20 As Double = 20
        Dim dm10 As Double = 10
        Dim dm5 As Double = 5
        Dim dm01 As Double = 1
        Dim dm025 As Double = 0.25
        Dim dm010 As Double = 0.1
        Dim dm005 As Double = 0.05

        If CDbl(den_1000.Text) > 0 Then
            txtamt1000.Text = Format(dm1000 * CDbl(den_1000.Text), "#,##0.00")
            totalCash += dm1000 * CDbl(den_1000.Text)
        Else
            txtamt1000.Text = ""
        End If

        If CDbl(den_500.Text) > 0 Then
            txtamt500.Text = Format(dm500 * CDbl(den_500.Text), "#,##0.00")
            totalCash += dm500 * CDbl(den_500.Text)
        Else
            txtamt500.Text = ""
        End If

        If CDbl(den_200.Text) > 0 Then
            txtamt200.Text = Format(dm200 * CDbl(den_200.Text), "#,##0.00")
            totalCash += dm200 * CDbl(den_200.Text)
        Else
            txtamt200.Text = ""
        End If

        If CDbl(den_100.Text) > 0 Then
            txtamt100.Text = Format(dm100 * CDbl(den_100.Text), "#,##0.00")
            totalCash += dm100 * CDbl(den_100.Text)
        Else
            txtamt100.Text = ""
        End If

        If CDbl(den_50.Text) > 0 Then
            txtamt50.Text = Format(dm50 * CDbl(den_50.Text), "#,##0.00")
            totalCash += dm50 * CDbl(den_50.Text)
        Else
            txtamt50.Text = ""
        End If

        If CDbl(den_20.Text) > 0 Then
            txtamt20.Text = Format(dm20 * CDbl(den_20.Text), "#,##0.00")
            totalCash += dm20 * CDbl(den_20.Text)
        Else
            txtamt20.Text = ""
        End If

        If CDbl(den_10.Text) > 0 Then
            txtamt10.Text = Format(dm10 * CDbl(den_10.Text), "#,##0.00")
            totalCash += dm10 * CDbl(den_10.Text)
        Else
            txtamt10.Text = ""
        End If

        If CDbl(den_05.Text) > 0 Then
            txtamt5.Text = Format(dm5 * CDbl(den_05.Text), "#,##0.00")
            totalCash += dm5 * CDbl(den_05.Text)
        Else
            txtamt5.Text = ""
        End If

        'piso

        If CDbl(den_01.Text) > 0 Then
            txtamt1peso.Text = Format(dm01 * CDbl(den_01.Text), "#,##0.00")
            totalCash += dm01 * CDbl(den_01.Text)
        Else
            txtamt1peso.Text = ""
        End If

        '.25
        If CDbl(den_025.Text) > 0 Then
            txtamt25cent.Text = Format(dm025 * CDbl(den_025.Text), "#,##0.00")
            totalCash += dm025 * CDbl(den_025.Text)
        Else
            txtamt25cent.Text = ""
        End If

        '.10
        If CDbl(den_010.Text) > 0 Then
            txtamt10cent.Text = Format(dm010 * CDbl(den_010.Text), "#,##0.00")
            totalCash += dm010 * CDbl(den_010.Text)
        Else
            txtamt10cent.Text = ""
        End If

        '.05
        If CDbl(den_050.Text) > 0 Then
            txtamt5cent.Text = Format(dm005 * CDbl(den_050.Text), "#,##0.00")
            totalCash += dm005 * CDbl(den_050.Text)
        Else
            txtamt5cent.Text = ""
        End If



        TextBox43.Text = Format(totalCash, "#,##0.00")
    End Sub
End Class
