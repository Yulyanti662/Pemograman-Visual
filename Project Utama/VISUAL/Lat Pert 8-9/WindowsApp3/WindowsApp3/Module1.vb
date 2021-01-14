Module Module1
    Public X As Integer
    Public S As String = ""
    Public T As String = ""
    Public OLECMD As OleDb.OleDbCommand
    Public OLERDR As OleDb.OleDbDataReader
    Public CNN As OleDb.OleDbConnection
    Public KONEKSI As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" &
    Application.StartupPath & "\ADOGaji.accdb;"
End Module
