Imports MySql.Data.MySqlClient

Module SW_Mod
    Public clsDBConn As clsDBConnection

    Public Const CONNECTION_REGISTRY_NAME As String = "ANT_ARKSOFT_EVERSLEY_V2"

    Dim _ServerName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName")
    Dim _DatabaseName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName")
    Dim _UserID As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName")
    Dim _Password As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password")
    Public cn As New MySqlConnection(String.Format("Data Source={0};Database={1};Uid={2};Pwd={3}", _ServerName, _DatabaseName, _UserID, _Password))



End Module
