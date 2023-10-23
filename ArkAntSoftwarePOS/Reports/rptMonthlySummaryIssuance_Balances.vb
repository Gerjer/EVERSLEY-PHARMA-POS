Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptMonthlySummaryIssuance_Balances


    Private lbl2 As DataDynamics.ActiveReports.Label
    Private lbl3 As DataDynamics.ActiveReports.Label

    Private TotalFooter As DataDynamics.ActiveReports.TextBox
    Private TotalIssuanceFooter As DataDynamics.ActiveReports.TextBox


    Private MeFormControls As Hashtable

    Private DATEFROM As String
    Private DATETO As String
    Private MONTHOF As String
    Private PAYMENTGROUP As Integer

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal pdateFrom As String, ByVal pdateTo As String, ByVal month As String, ByVal paygrp As Integer)
        InitializeComponent()
        Me.PAYMENTGROUP = paygrp
        Me.DATEFROM = pdateFrom
        Me.DATETO = pdateTo
        Me.MONTHOF = month

        Me.txtReportTitle.Text = txtReportTitle.Text & " " & month
        txtHeaderBegBal.Text = txtHeaderBegBal.Text & " " & month
        MeFormControls = New Hashtable

    End Sub

    Private Sub rptMonthlySummaryIssuance_Balances_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS

        displayHeader()
    End Sub

    Private Sub displayHeader()
        Dim inPatientWidth As Double = 0
        Dim outPatientWidth As Double = 0


        Dim SQLEX As String = "SELECT a_code, a_name, payment_type,patient_type FROM patient_type"
        SQLEX += " ORDER BY patient_type, a_code"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim xLoc1 As Single = txtSIHeader.Bounds.Right
        Dim xLocDetail As Single = TextBox14.Bounds.Right

        If MeData.Rows.Count > 0 Then

            For nCtr As Short = 0 To MeData.Rows.Count - 1
                Dim grouping As Integer = CInt(MeData.Rows(nCtr).Item("patient_type").ToString)

                Dim type As String = MeData.Rows(nCtr).Item("a_code").ToString
                Dim ColName As String = MeData.Rows(nCtr).Item("payment_type").ToString

                Dim lbl1 As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = ColName, .Style = FontStyle.Regular, .Font = txtSIHeader.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, txtSIHeader.Location.Y)}
                'Dim label3size As Single = txtSIHeader.Width
                txtSIHeader.Border.CopyTo(lbl1.Border)
                'xLoc1 = xLoc1 + Label3.Width
                GroupHeader1.Controls.Add(lbl1)

                ' detail amount
                lbl2 = New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y)}
                lbl2.Tag = type
                Label1.Border.CopyTo(lbl2.Border)
                '                    xLocDetail = xLocDetail + Label7.Width
                Detail1.Controls.Add(lbl2)

                ' footer amount
                lbl3 = New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label2.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox18.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label2.Location.Y)}
                lbl3.Tag = "total_" & type
                Label2.Border.CopyTo(lbl3.Border)
                'xLocDetail = xLocDetail + Label2.Width
                GroupFooter1.Controls.Add(lbl3)



                xLoc1 = xLoc1 + txtSIHeader.Width

                If grouping = 0 Then
                    xLocDetail = xLocDetail + txtSIHeader.Width
                    inPatientWidth += txtSIHeader.Width
                Else
                    'xLocDetail = xLocDetail + txtSIHeader.Width
                    outPatientWidth += txtSIHeader.Width
                End If

            Next

            ' separator for inpatient and outpatient
            txtTypeInPatient.Width = inPatientWidth

            Dim lbloutpatient As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtTypeInPatient.Size, .Text = "OUT-PATIENT", .Style = FontStyle.Bold, .Font = Label3.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, txtTypeInPatient.Location.Y)}
            txtTypeInPatient.Border.CopyTo(lbloutpatient.Border)
            lbloutpatient.Width = outPatientWidth
            GroupHeader1.Controls.Add(lbloutpatient)

            xLocDetail += lbloutpatient.Width

            Dim lblTotalIssuance As New DataDynamics.ActiveReports.Label() _
                    With {.Size = TextBox7.Size, .Text = "TOTAL ISSUANCES", .Style = FontStyle.Bold, .Font = Label3.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, txtTypeInPatient.Location.Y)}
            txtTypeInPatient.Border.CopyTo(lblTotalIssuance.Border)
            GroupHeader1.Controls.Add(lblTotalIssuance)

            Dim totalIssuanceDetail As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox8.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox8.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, TextBox8.Location.Y)}
            totalIssuanceDetail.DataField = "totalIssuance"
            totalIssuanceDetail.OutputFormat = "###,###.00"
            TextBox7.Border.CopyTo(totalIssuanceDetail.Border)
            Detail1.Controls.Add(totalIssuanceDetail)

            TotalIssuanceFooter = New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox18.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox18.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, TextBox19.Location.Y)}
            TotalIssuanceFooter.DataField = "det_total"
            TotalIssuanceFooter.OutputFormat = "###,###.00"
            TextBox19.Border.CopyTo(TotalIssuanceFooter.Border)
            GroupFooter1.Controls.Add(TotalIssuanceFooter)


            xLocDetail += TextBox7.Width
            Dim endDisplay As String = "INVENTORY as of " & Me.MONTHOF

            Dim lblTotal As New DataDynamics.ActiveReports.Label() _
                    With {.Size = TextBox7.Size, .Text = endDisplay, .Style = FontStyle.Regular, .Font = Label3.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, txtTypeInPatient.Location.Y)}
            txtTypeInPatient.Border.CopyTo(lblTotal.Border)
            GroupHeader1.Controls.Add(lblTotal)

            'xLocDetail += TextBox7.Width

            Dim totalDetail As New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox8.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox8.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, TextBox8.Location.Y)}
            totalDetail.DataField = "ending_value"
            totalDetail.OutputFormat = "###,###.00"
            TextBox7.Border.CopyTo(totalDetail.Border)
            Detail1.Controls.Add(totalDetail)


            TotalFooter = New DataDynamics.ActiveReports.TextBox() _
                    With {.Size = TextBox18.Size, .Text = "", .Style = FontStyle.Regular, .Font = TextBox18.Font, .Alignment = TextAlignment.Right, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, TextBox19.Location.Y)}
            TotalFooter.DataField = "det_total"
            TotalFooter.OutputFormat = "###,###.00"
            TotalFooter.CanGrow = False
            TextBox19.Border.CopyTo(TotalFooter.Border)
            GroupFooter1.Controls.Add(TotalFooter)


        End If
    End Sub

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim sysPK As String = txtSysPK.Text

        For Each iControl As DataDynamics.ActiveReports.ARControl In Detail1.Controls

            If TypeOf iControl Is DataDynamics.ActiveReports.Label Then

                Dim tag As String = ""
                tag = iControl.Tag

                If Not tag Is Nothing Then
                    Dim SQLDetail As String = "SELECT  `issuance_summary_detail`.`amount`"
                    SQLDetail += " , `patient_type`.`payment_type`"
                    SQLDetail += " , `patient_type`.`a_code`"
                    SQLDetail += " FROM issuance_summary_detail"
                    SQLDetail += " INNER JOIN patient_type"
                    SQLDetail += " ON (`issuance_summary_detail`.`paymentType` = `patient_type`.`a_code`)"
                    SQLDetail += " WHERE paymentType='" & tag & "'"
                    SQLDetail += " AND masterSysPK='" & sysPK & "'"

                    Dim MeData As DataTable
                    MeData = clsDBConn.ExecQuery(SQLDetail)


                    If MeData.Rows.Count > 0 Then
                        Try
                            Dim amount As String = Format(MeData.Rows(0).Item("amount"), "###,###.00")
                            CType(iControl, DataDynamics.ActiveReports.Label).Text = amount
                            tag = MeFormControls.Count + 1 & "_" & tag
                            MeFormControls.Add(tag, amount)
                        Catch ex As Exception

                        End Try
                    End If

                End If
            End If

        Next
    End Sub


    Private Sub getAllTotal()

        For Each iControl As DataDynamics.ActiveReports.ARControl In GroupFooter1.Controls
            If TypeOf iControl Is DataDynamics.ActiveReports.Label Then
                Dim tag As String = ""
                tag = iControl.Tag
                If Not tag Is Nothing Then
                    Try
                        CType(iControl, DataDynamics.ActiveReports.Label).Text = 0.0

                        Dim words As String() = tag.Split(New Char() {"_"c})
                        Dim LoanNameTotal As String = words(1)

                        Dim runningTotal As Double = 0

                        For Each element As DictionaryEntry In MeFormControls
                            Dim elementKey As String = element.Key
                            Dim elementvalue As String = element.Value
                            Dim total As String() = elementKey.Split(New Char() {"_"c})
                            Dim loanDetails As String = total(1)

                            If LoanNameTotal = loanDetails Then
                                Dim value As Double = CDbl(elementvalue)
                                runningTotal = runningTotal + value
                            End If

                        Next
                        CType(iControl, DataDynamics.ActiveReports.Label).Text = Format(runningTotal, "###,###.00")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If

            End If
        Next


        ' total_net pay

        'Me.PAYMENTGROUP = paygrp
        'Me.DATEFROM = pdateFrom
        'Me.DATETO = pdateTo

        Dim SQLEX As String = "SELECT SUM(ending_value) 'TotalAmt', SUM(totalIssuance) 'TOTALISSUANCE'"
        SQLEX += " FROM issuance_summary_master"
        SQLEX += " WHERE dateFrom='" & DATEFROM & "'"
        SQLEX += " AND dateTo='" & DATETO & "'"
        SQLEX += " AND type='" & CInt(PAYMENTGROUP) & "'"
        SQLEX += " ORDER BY supplier"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                Dim TotalInv As Double = MeData.Rows(0).Item("TotalAmt")
                Dim TotalIssue As Double = MeData.Rows(0).Item("TOTALISSUANCE")

                Me.TotalFooter.Text = Format(TotalInv, "#,###,###.00")
                Me.TotalIssuanceFooter.Text = Format(TotalIssue, "#,###,###.00")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        getAllTotal()
    End Sub
End Class
