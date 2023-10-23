Public Class clsRPTValue

    Private CUTOFFDATE As String = ""

    Sub New()
    End Sub

    Sub New(ByVal cutDate As String)
        CUTOFFDATE = cutDate
    End Sub


    Public Sub setCutOffDate(ByVal cutDate As String)
        CUTOFFDATE = cutDate
    End Sub

    Public Function Monthly_GetBuildingOverMarketValue(Optional ByVal classi As String = "") As Double
        Dim tp_mvca As Double = 0
        Dim tp_mvdc As Double = 0
        Dim retValue As Double = 0

        tp_mvca = getMV_Value(classi, CUTOFFDATE, "CA", "+", "Building")

        tp_mvdc = getMV_Value(classi, CUTOFFDATE, "DC", "+", "Building")

        retValue = tp_mvdc - tp_mvca


        Return retValue
    End Function

    Public Function Monthly_GetBuildingLessMarketValue(Optional ByVal classi As String = "") As Double
        Dim tp_mvca As Double = 0
        Dim tp_mvdc As Double = 0
        Dim retValue As Double = 0

        tp_mvca = getMV_Value(classi, CUTOFFDATE, "CA", "-", "Building")

        tp_mvdc = getMV_Value(classi, CUTOFFDATE, "DC", "-", "Building")

        retValue = tp_mvdc - tp_mvca


        Return retValue
    End Function

    Public Function Monthly_GetBuildingLessAssessedValue(Optional ByVal classi As String = "") As Double
        Dim tp_mvca As Double = 0
        Dim tp_mvdc As Double = 0
        Dim retValue As Double = 0

        tp_mvca = getAV_Value(classi, CUTOFFDATE, "CA", "-", "Building")

        tp_mvdc = getAV_Value(classi, CUTOFFDATE, "DC", "-", "Building")

        retValue = tp_mvdc - tp_mvca


        Return retValue
    End Function

    Public Function Monthly_GetBuildingOverAssessedValue(Optional ByVal classi As String = "") As Double
        Dim tp_mvca As Double = 0
        Dim tp_mvdc As Double = 0
        Dim retValue As Double = 0

        tp_mvca = getAV_Value(classi, CUTOFFDATE, "CA", "+", "Building")

        tp_mvdc = getAV_Value(classi, CUTOFFDATE, "DC", "+", "Building")

        retValue = tp_mvdc - tp_mvca


        Return retValue
    End Function


    Private Function getMV_Value(ByVal classi As String, ByVal date_param As String, _
                                 ByVal transtype As String, ByVal aboveOrLess As String, _
                                 ByVal KIND As String) As Double
        Dim MeData As DataTable
        Dim retDouble As Double = 0

        Dim SQLEX As String = "SELECT IFNULL(SUM(mv_value), 0) AS mv FROM assessor_arpa_worksheet"
        'SQLEX += " WHERE BRGY_CODE='" & brgyCode & "'"
        SQLEX += " WHERE date_param='" & date_param & "'"
        SQLEX += " AND trans_type='" & transtype & "'"
        SQLEX += " AND classification='" & classi & "'"
        SQLEX += " AND above_or_less='" & aboveOrLess & "'"
        SQLEX += " AND KIND = '" & KIND & "'"

        MeData = clsDBConn.ExecQuery(SQLEX)

        If Not MeData Is Nothing Then
            If MeData.Rows.Count > 0 Then
                Try

                    retDouble = CDbl(MeData.Rows(0).Item("mv").ToString)
                Catch ex As Exception
                    retDouble = 0
                End Try
            End If
        End If


        Return retDouble

    End Function

    Private Function getAV_Value(ByVal classi As String, ByVal date_param As String, _
                                 ByVal transtype As String, ByVal aboveOrLess As String, _
                                 ByVal KIND As String) As Double
        Dim MeData As DataTable
        Dim retDouble As Double = 0

        Dim SQLEX As String = "SELECT IFNULL(SUM(av_value), 0) AS av FROM assessor_arpa_worksheet"
        'SQLEX += " WHERE BRGY_CODE='" & brgyCode & "'"
        SQLEX += " WHERE date_param='" & date_param & "'"
        SQLEX += " AND trans_type='" & transtype & "'"
        SQLEX += " AND classification='" & classi & "'"
        SQLEX += " AND above_or_less='" & aboveOrLess & "'"
        SQLEX += " AND KIND = '" & KIND & "'"

        MeData = clsDBConn.ExecQuery(SQLEX)

        If Not MeData Is Nothing Then
            If MeData.Rows.Count > 0 Then
                Try

                    retDouble = CDbl(MeData.Rows(0).Item("av").ToString)
                Catch ex As Exception
                    retDouble = 0
                End Try
            End If
        End If


        Return retDouble

    End Function


End Class
