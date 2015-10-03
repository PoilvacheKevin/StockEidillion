Imports MySql.Data.MySqlClient
Public Class SQLCom
    Private cs As String = "Database = EidillionStocktest;Data Source=127.0.0.1; User Id=root;Password=;"
    Private Connexion As New MySqlConnection(cs)

    Public Function AddClient(ByVal ClientName As String, ByVal ClientAdresse As String, ByVal ClientTelephone As String, ByVal ClientN_TVA As String, ByVal ClientMail As String) As Boolean
        Dim Request As String
        Try
            Connexion.Open()
            Request = "INSERT INTO `t_clients`(`Adresse`, `Nom`, `N_TVA`, `Telephone`, `Mail`) VALUES (""" & ClientAdresse & """,""" & ClientName & """,""" & ClientN_TVA & """,""" & ClientTelephone & """,""" & ClientMail & """)"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Connexion.Close()
    End Function


End Class
