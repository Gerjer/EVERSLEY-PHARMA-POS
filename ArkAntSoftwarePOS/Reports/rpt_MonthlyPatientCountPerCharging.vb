Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_MonthlyPatientCountPerCharging
    Private reportDateFrom As String = "'"
    Private reportDateTo As String = "'"

    Private lbl2 As DataDynamics.ActiveReports.Label
    Private lbSubTotal As DataDynamics.ActiveReports.Label

    Private TOTAL_REG As Integer = 0
    Private TOTAL_JO As Integer = 0
    Private TOTAL_TOTAL As Integer = 0
    Private TOTAL_UNFILLED As Integer = 0


    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal dateFrom As String, ByVal dateTo As String, ByVal monthOf As String)
        InitializeComponent()
        Me.txtMonthOf.Text = monthOf
        reportDateFrom = dateFrom
        reportDateTo = dateTo
    End Sub


    Private Sub rpt_MonthlyPatientCountPerCharging_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.txtCmpName.Text = COMPANY_NAME
        Me.txtAddress.Text = COMPANY_ADDRESS

        displayHeader()
    End Sub

    Private Sub displayHeader()
        Dim SQLEX As String = "SELECT a_code, IF(patient_type=0, CONCAT('IP-',payment_type), CONCAT('OP-', payment_type)) 'pType'"
        SQLEX += " FROM patient_type"
        SQLEX += " WHERE a_code <>'6'  AND status <> 0"
        SQLEX += " ORDER BY pType,payment_type"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim xLoc1 As Single = txtSIHeader.Bounds.Right
        'Dim xLocDetail As Single = TextBox14.Bounds.Right
        Dim TOTALLBL As New DataDynamics.ActiveReports.Label() _
                    With {.Size = TextBox14.Size, .Text = "TOTAL", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0, TextBox14.Location.Y), .BackColor = Color.Gainsboro}
        Label1.Border.CopyTo(TOTALLBL.Border)
        GroupFooter1.Controls.Add(TOTALLBL)


        If MeData.Rows.Count > 0 Then
            For nCtr As Short = 0 To MeData.Rows.Count - 1

                Dim ColName As String = MeData.Rows(nCtr).Item("pType").ToString
                Dim type As String = MeData.Rows(nCtr).Item("a_code").ToString

                Dim lbl1 As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = ColName, .Style = FontStyle.Regular, .Font = txtSIHeader.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, txtSIHeader.Location.Y), .BackColor = Color.DarkGray}
                'Dim label3size As Single = txtSIHeader.Width
                txtSIHeader.Border.CopyTo(lbl1.Border)
                'xLoc1 = xLoc1 + Label3.Width
                GroupHeader1.Controls.Add(lbl1)

                ' detail amount
                lbl2 = New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y)}
                lbl2.Tag = type
                Label1.Border.CopyTo(lbl2.Border)
                '                    xLocDetail = xLocDetail + Label7.Width
                Detail1.Controls.Add(lbl2)

                lbSubTotal = New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.Gainsboro}
                lbSubTotal.Tag = type & "_SubTotalDetail"
                Label1.Border.CopyTo(lbSubTotal.Border)
                '                    xLocDetail = xLocDetail + Label7.Width
                GroupFooter1.Controls.Add(lbSubTotal)


                xLoc1 = xLoc1 + txtSIHeader.Width
            Next



            'regular emp column
            Dim EMPreg As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = "EMP-REG", .Style = FontStyle.Bold, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.DarkGray}
            txtSIHeader.Border.CopyTo(EMPreg.Border)
            GroupHeader1.Controls.Add(EMPreg)

            Dim regDetail As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y)}
            regDetail.Tag = "detail_reg"
            Label1.Border.CopyTo(regDetail.Border)
            Detail1.Controls.Add(regDetail)

            Dim regSubTotal As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.Gainsboro}
            regSubTotal.Tag = "subtotal_reg"
            Label1.Border.CopyTo(regSubTotal.Border)
            GroupFooter1.Controls.Add(regSubTotal)


            xLoc1 = xLoc1 + txtSIHeader.Width

            'jo emp column
            Dim EMPjo As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = "EMP-JO", .Style = FontStyle.Bold, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.DarkGray}
            txtSIHeader.Border.CopyTo(EMPjo.Border)
            GroupHeader1.Controls.Add(EMPjo)

            Dim joDetail As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y)}
            joDetail.Tag = "detail_jo"

            Label1.Border.CopyTo(joDetail.Border)
            Detail1.Controls.Add(joDetail)

            Dim joSubTotal As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.Gainsboro}
            joSubTotal.Tag = "subtotal_jo"
            Label1.Border.CopyTo(joSubTotal.Border)
            GroupFooter1.Controls.Add(joSubTotal)
            


            ' total header and detail
            xLoc1 = xLoc1 + txtSIHeader.Width

            Dim TOTALHeader As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = "TOTAL", .Style = FontStyle.Bold, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.DarkGray}
            txtSIHeader.Border.CopyTo(TOTALHeader.Border)
            GroupHeader1.Controls.Add(TOTALHeader)

            Dim TOTALDetail As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y)}
            TOTALDetail.Tag = "detail_total"

            Label1.Border.CopyTo(TOTALDetail.Border)
            Detail1.Controls.Add(TOTALDetail)

            Dim TotalSubTotal As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.Gainsboro}
            TotalSubTotal.Tag = "subtotal_total"
            Label1.Border.CopyTo(TotalSubTotal.Border)
            GroupFooter1.Controls.Add(TotalSubTotal)

            'unfilled
            xLoc1 = xLoc1 + txtSIHeader.Width

            Dim HeadUnfilled As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = "UNFILLED", .Style = FontStyle.Bold, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.DarkGray}
            txtSIHeader.Border.CopyTo(HeadUnfilled.Border)
            GroupHeader1.Controls.Add(HeadUnfilled)

            Dim unfilledDetail As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y)}
            unfilledDetail.Tag = "detail_unfilled"

            Label1.Border.CopyTo(unfilledDetail.Border)
            Detail1.Controls.Add(unfilledDetail)

            Dim ufillSubTotal As New DataDynamics.ActiveReports.Label() _
                    With {.Size = Label1.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label1.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, Label1.Location.Y), .BackColor = Color.Gainsboro}
            ufillSubTotal.Tag = "subtotal_unfilled"
            Label1.Border.CopyTo(ufillSubTotal.Border)
            GroupFooter1.Controls.Add(ufillSubTotal)



        End If

    End Sub

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim dateStr As String = txtTrDay.Text
        Dim TOTAL As Integer = 0

        For Each iControl As DataDynamics.ActiveReports.ARControl In Detail1.Controls

            If TypeOf iControl Is DataDynamics.ActiveReports.Label Then
                Dim tag As String = ""
                tag = iControl.Tag


                If Not tag Is Nothing Then

                    If Not tag.Contains("detail_") Then

                        Dim SQLEX As String = "SELECT COUNT(chargingid) 'count', charging, STATUS FROM daily_sales_master"
                        SQLEX += " WHERE DATE(tr_date)='" & dateStr & "'"
                        SQLEX += " AND chargingid='" & tag & "'"
                        SQLEX += " AND status <> 'VOID'"
                        SQLEX += " GROUP BY chargingid"

                        Dim MeData As DataTable
                        MeData = clsDBConn.ExecQuery(SQLEX)

                        If MeData.Rows.Count > 0 Then
                            Try
                                Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)
                                CType(iControl, DataDynamics.ActiveReports.Label).Text = count
                                TOTAL += count
                            Catch ex As Exception

                            End Try
                        Else
                            CType(iControl, DataDynamics.ActiveReports.Label).Text = "-"
                        End If
                    ElseIf tag.Contains("detail_") Then
                        If tag = "detail_reg" Then
                            Dim SQLREG As String = "SELECT COUNT(patient_name) 'count'"
                            SQLREG += " FROM daily_sales_master"
                            SQLREG += " INNER JOIN person_profile"
                            SQLREG += " ON (`daily_sales_master`.`patient_id` = `person_profile`.`a_code`)"
                            SQLREG += " WHERE DATE(tr_date)='" & dateStr & "'"
                            SQLREG += " AND chargingid='6' "
                            SQLREG += " AND isEmp='1'"
                            SQLREG += " AND empType = '0' "
                            SQLREG += " AND status <> 'VOID'"

                            Dim MeData As DataTable
                            MeData = clsDBConn.ExecQuery(SQLREG)

                            If MeData.Rows.Count > 0 Then
                                Try
                                    Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)
                                    CType(iControl, DataDynamics.ActiveReports.Label).Text = count
                                    TOTAL += count
                                    TOTAL_REG += count
                                Catch ex As Exception

                                End Try
                            Else
                                CType(iControl, DataDynamics.ActiveReports.Label).Text = "-"
                            End If

                        ElseIf tag = "detail_jo" Then
                            Dim SQLJO As String = "SELECT COUNT(patient_name) 'count'"
                            SQLJO += " FROM daily_sales_master"
                            SQLJO += " INNER JOIN person_profile"
                            SQLJO += " ON (`daily_sales_master`.`patient_id` = `person_profile`.`a_code`)"
                            SQLJO += " WHERE DATE(tr_date)='" & dateStr & "'"
                            SQLJO += " AND chargingid='6' "
                            SQLJO += " AND isEmp='1'"
                            SQLJO += " AND empType = '1' "
                            SQLJO += " AND status <> 'VOID'"

                            Dim MeData As DataTable
                            MeData = clsDBConn.ExecQuery(SQLJO)

                            If MeData.Rows.Count > 0 Then
                                Try
                                    Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)
                                    CType(iControl, DataDynamics.ActiveReports.Label).Text = count
                                    TOTAL += count
                                    TOTAL_JO += count
                                Catch ex As Exception

                                End Try
                            Else
                                CType(iControl, DataDynamics.ActiveReports.Label).Text = "-"
                            End If
                        ElseIf tag = "detail_unfilled" Then
                            Dim SQLJO As String = "SELECT SUM(unfilled) 'count'"
                            SQLJO += " FROM daily_sales_master"
                            SQLJO += " WHERE DATE(tr_date)='" & dateStr & "'"
                            'SQLJO += " AND unfilled='1' "
                            SQLJO += " AND status <> 'VOID'"

                            Dim MeData As DataTable
                            MeData = clsDBConn.ExecQuery(SQLJO)

                            If MeData.Rows.Count > 0 Then
                                Try
                                    Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)
                                    CType(iControl, DataDynamics.ActiveReports.Label).Text = count
                                    TOTAL += count
                                    TOTAL_UNFILLED += count
                                Catch ex As Exception

                                End Try
                            Else
                                CType(iControl, DataDynamics.ActiveReports.Label).Text = "-"
                            End If

                        ElseIf tag = "detail_total" Then
                            CType(iControl, DataDynamics.ActiveReports.Label).Text = TOTAL
                            TOTAL_TOTAL += TOTAL
                        End If
                    End If
                End If



            End If

        Next
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        Dim TOTAL As Integer = 0

        For Each iControl As DataDynamics.ActiveReports.ARControl In GroupFooter1.Controls

            If TypeOf iControl Is DataDynamics.ActiveReports.Label Then
                Dim tag As String = ""
                tag = iControl.Tag


                If Not tag Is Nothing Then



                    If tag.Contains("_SubTotalDetail") Then
                        Dim SQLEX As String = "SELECT COUNT(chargingid) 'count', charging, STATUS FROM daily_sales_master"
                        SQLEX += " WHERE DATE(tr_date) BETWEEN '" & reportDateFrom & "'"
                        SQLEX += " AND '" & reportDateTo & "'"
                        SQLEX += " AND chargingid='" & tag.Replace("_SubTotalDetail", "") & "'"
                        SQLEX += " AND status <> 'VOID'"
                        SQLEX += " GROUP BY chargingid"

                        Dim MeData As DataTable
                        MeData = clsDBConn.ExecQuery(SQLEX)

                        If MeData.Rows.Count > 0 Then
                            Try
                                Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)
                                CType(iControl, DataDynamics.ActiveReports.Label).Text = count
                                TOTAL += count
                            Catch ex As Exception

                            End Try
                        Else
                            CType(iControl, DataDynamics.ActiveReports.Label).Text = "-"
                        End If
                    ElseIf tag.Contains("subtotal_reg") Then
                        CType(iControl, DataDynamics.ActiveReports.Label).Text = TOTAL_REG
                    ElseIf tag.Contains("subtotal_jo") Then
                        CType(iControl, DataDynamics.ActiveReports.Label).Text = TOTAL_JO
                    ElseIf tag.Contains("subtotal_total") Then
                        CType(iControl, DataDynamics.ActiveReports.Label).Text = Format(TOTAL_TOTAL, "#,##0")
                    ElseIf tag.Contains("subtotal_unfilled") Then
                        CType(iControl, DataDynamics.ActiveReports.Label).Text = TOTAL_UNFILLED

                    End If
                

                End If



            End If

        Next
    End Sub
End Class
