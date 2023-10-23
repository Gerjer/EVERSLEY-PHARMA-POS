Module modCommon



    Public WorkGroup As String = ""
    Public DepartmentName As String = ""
    Public DepartmentTo As String = ""
    Public Criteria As String = ""
    Public AuthUserName As String = ""
    Public AuthUserType As String = ""
    Public FullUserName As String = ""

    Public COMPANY_NAME As String = ""
    Public COMPANY_ADDRESS As String = ""

    Public DAILY_TRANSACTION_SYSPK As String = ""

    Public report_summarized_balance As DataTable

    Public SuperPassWord As String = ""

    Public apply_indication As String = ""
    Public apply_interaction As String = ""

    Public NEW_TRANS As Boolean
    Public ITEM_LIST As DataTable

    Public Function GetCurrentAge(value As Date) As String
        Dim age As Integer
        age = Today.Year - value.Year
        If (value > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Public Function mysqlDateTime(ByVal DateTime As Date) As String
        Dim mysqlDate As String = ""
        If InStr(DateTime, "PM") <> 0 Then
            mysqlDate = String.Format("{0} {1}:{2}:{3}", Format(Now.Date, "yyyy-MM-dd"), Hour(Now), Minute(Now), Second(Now))
        Else
            mysqlDate = Format(Now, "yyyy-MM-dd hh:mm:ss")
        End If
        Return mysqlDate
    End Function

    Public Sub ProcessFilterText(ByRef MeData As DataTable, ByRef TDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim StrBuilder As New System.Text.StringBuilder()
        Dim ColData As C1.Win.C1TrueDBGrid.C1DataColumn

        For Each ColData In TDBGrid.Columns
            Application.DoEvents()
            If ColData.FilterText.Length > 0 Then
                If StrBuilder.Length > 0 Then
                    StrBuilder.Append(" AND ")
                End If

                Select Case True
                    Case InStr(ColData.FilterText.ToUpper, "UNTIL") <> 0
                        Dim getFilter() As String = Split(UCase(ColData.FilterText), "UNTIL")
                        If UBound(getFilter) > 0 Then
                            StrBuilder.Append((ColData.DataField & " >= '" & getFilter(0) & "' AND " & ColData.DataField & " <= '" & getFilter(1) & "'"))
                        End If
                    Case InStr(ColData.FilterText.ToUpper, "<") <> 0
                        StrBuilder.Append((ColData.DataField & " < " & ColData.FilterText.Replace("<", "")))
                    Case InStr(ColData.FilterText.ToUpper, "<=") <> 0
                        StrBuilder.Append((ColData.DataField & " <= " & ColData.FilterText.Replace("<=", "")))
                    Case InStr(ColData.FilterText.ToUpper, ">") <> 0
                        StrBuilder.Append((ColData.DataField & " > " & ColData.FilterText.Replace(">", "")))
                    Case InStr(ColData.FilterText.ToUpper, ">=") <> 0
                        StrBuilder.Append((ColData.DataField & " >= " & ColData.FilterText.Replace(">=", "")))
                    Case InStr(ColData.FilterText.ToUpper, "=") <> 0
                        StrBuilder.Append((ColData.DataField & " = " & ColData.FilterText.Replace("=", "")))
                    Case Else
                        StrBuilder.Append((ColData.DataField & " like " & "'*" & ColData.FilterText & "*'"))
                End Select

            End If
        Next

        Try
            MeData.DefaultView.RowFilter = StrBuilder.ToString()
        Catch ex As Exception

        End Try

    End Sub



    Public Function GET_CASH_COUNT_AMOUNT() As Double
        Dim totalsales As Double = 0
        Dim SQLEX As String = "SELECT daily_total AS 'totalsales' FROM daily_cash_count"
        SQLEX += " WHERE TRD_SYSPK='" & modCommon.DAILY_TRANSACTION_SYSPK & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then

            Try
                totalsales = CDbl(MeData.Rows(0).Item("totalsales").ToString)

            Catch ex As Exception

            End Try

        End If

        Return totalsales

    End Function

    Public Function GET_DAILY_SALES() As Double
        Dim totalsales As Double = 0
        Dim SQLEX As String = "SELECT SUM(dailysales_net) 'totalsales' FROM daily_sales_master"
        SQLEX += " WHERE TRD_SYSPK='" & modCommon.DAILY_TRANSACTION_SYSPK & "'"
        SQLEX += " AND Transaction_Type <> 'VOID'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then

            Try
                totalsales = CDbl(MeData.Rows(0).Item("totalsales").ToString)

            Catch ex As Exception

            End Try

        End If
        Return totalsales

    End Function


    

End Module
