Imports System.Data.OracleClient
Imports System.Security.Cryptography

Module Mymod
    Public mycommand As New System.Data.OracleClient.OracleCommand
    Public myadapter As New System.Data.OracleClient.OracleDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.OracleClient.OracleDataReader
    Public SQL As String
    Public conn As New System.Data.OracleClient.OracleConnection
    Public cn As New Connection

    
    'Tabel Fakultas
    '-------------------------------
    Public fakultas_baru As Boolean
    Public ofakultas As New Fakultas
    '--------------------------------

    'Tabel User
    '--------------------------------
    Public user_baru As Boolean
    Public oUser As New User
    '--------------------------------
    Public login_valid As Boolean

    Public Sub DBConnect()
        cn.DataSource = "xe"
        cn.UserID = "freddy"
        cn.Password = "123"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub

    Public Function getMD5Hash(ByVal strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

End Module
