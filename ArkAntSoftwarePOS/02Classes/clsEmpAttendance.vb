Imports MySql.Data.MySqlClient

Public Class clsEmpAttendance

    Private mAttendanceID As Integer
    Private mEmpNum As Integer
    Private mDTRDate As Date
    Private mAM_IN As DateTime
    Private mAM_OUT As DateTime
    Private mAM_Note As String

    Private mPM_IN As DateTime
    Private mPM_OUT As DateTime
    Private mPM_Note As String

    Private mLate As Double
    Private mUndertime As Double

    Private mFullName As String

#Region "Properties"
    Public WriteOnly Property AttendanceID() As Integer
        Set(ByVal value As Integer)
            mAttendanceID = value
        End Set
    End Property

    Public WriteOnly Property EmployeeNumber() As Integer
        Set(ByVal value As Integer)
            mEmpNum = value
        End Set
    End Property

    Public WriteOnly Property DTRDate() As Date
        Set(ByVal value As Date)
            mDTRDate = value
        End Set
    End Property

    Public WriteOnly Property AM_IN() As DateTime
        Set(ByVal value As DateTime)
            mAM_IN = value
        End Set
    End Property

    Public WriteOnly Property AM_OUT() As DateTime
        Set(ByVal value As DateTime)
            mAM_OUT = value
        End Set
    End Property

    Public WriteOnly Property AM_NOTE() As String
        Set(ByVal value As String)
            mAM_Note = value
        End Set
    End Property

    Public WriteOnly Property PM_IN() As DateTime
        Set(ByVal value As DateTime)
            mPM_IN = value
        End Set
    End Property

    Public WriteOnly Property PM_OUT() As DateTime
        Set(ByVal value As DateTime)
            mPM_OUT = value
        End Set
    End Property

    Public WriteOnly Property PM_NOTE() As String
        Set(ByVal value As String)
            mPM_Note = value
        End Set
    End Property

    Public WriteOnly Property Late() As Double
        Set(ByVal value As Double)
            mLate = value
        End Set
    End Property

    Public WriteOnly Property Undertime() As Double
        Set(ByVal value As Double)
            mUndertime = value
        End Set
    End Property

    Public WriteOnly Property EmpFullName() As String
        Set(ByVal value As String)
            mFullName = value
        End Set
    End Property

#End Region

    Public Function insertNewAttendance_AM() As Boolean


        Dim sysPK As String = System.Guid.NewGuid.GetHashCode
        'Dim attendanceID As String = AutoNumber()



        Dim retval As Boolean = False
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        Dim exec As String = String.Format("call insert_emp_attendance('{0}','{1}','{2}','{3}','{4}')", sysPK, mEmpNum, mFullName, Format(mDTRDate, "yyyy-MM-dd"), Format(mDTRDate, "yyyy-MM-dd") & Format(mAM_IN, " HH:mm:ss"))
        Dim cmd As New MySqlCommand(exec, cn)
        Try
            cmd.ExecuteNonQuery()
            'MsgBox("Data has been saved!")
            retval = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return retval

    End Function

    Public Function insertNewAttendance_PM() As Boolean

        Dim sysPK As String = System.Guid.NewGuid.GetHashCode
        'Dim attendanceID As String = AutoNumber()

        Dim retval As Boolean = False
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String = String.Format("call insert_emp_attendance_pm('{0}','{1}','{2}','{3}','{4}')", sysPK, mEmpNum, mFullName, Format(mDTRDate, "yyyy-MM-dd"), Format(mDTRDate, "yyyy-MM-dd") & Format(mPM_IN, " HH:mm:ss"))

        
        Dim cmd As New MySqlCommand(exec, cn)
        Try
            cmd.ExecuteNonQuery()
            'MsgBox("Data has been saved!")
            retval = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return retval

    End Function

    'Public Function updateEmpAttendance(ByVal vDTR_id As Integer) As Boolean
    '    Dim retval As Boolean = False
    '    If cn.State = ConnectionState.Open Then cn.Close()
    '    cn.Open()

    '    Dim exec As String = "call update_emp_attendance('" & vDTR_id & "','" & _
    '                         Format(mAM_IN, "yyyy-MM-dd HH:mm:ss") & "','" & _
    '                         Format(mAM_OUT, "yyyy-MM-dd HH:mm:ss") & "','" & _
    '                         mAM_Note & "','" & _
    '                         Format(mPM_IN, "yyyy-MM-dd HH:mm:ss") & "','" & _
    '                         Format(mPM_OUT, "yyyy-MM-dd HH:mm:ss") & "','" & _
    '                         mPM_Note & "','" & mLate & "','" & _
    '                         mUndertime & "')"






    '    Dim cmd As New MySqlCommand(exec, cn)
    '    Try
    '        cmd.ExecuteNonQuery()
    '        retval = True
    '    Catch ex As Exception

    '        MsgBox(ex.Message)

    '    End Try

    '    Return retval

    'End Function


    'Public Function AutoNumber() As String
    '    Dim FieldName As String = "attendance_id"
    '    Dim SQL As String = String.Format(" SELECT max({0}) as UserPK FROM {1}", FieldName, "hr_emp_attendance")
    '    Dim MeData As New DataTable
    '    Dim UserPK As String = ""
    '    Try
    '        MeData = clsDBConn.ExecQuery(SQL)
    '        UserPK = MeData.Rows(0).Item("UserPK").ToString

    '        If Val(UserPK) > 0 Then
    '            UserPK = Val(UserPK) + 1
    '            UserPK = Format(Val(UserPK), "000000")
    '        Else
    '            UserPK = "000001"
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    '    Return UserPK
    '    MeData = Nothing
    'End Function

End Class
