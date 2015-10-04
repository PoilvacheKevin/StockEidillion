Imports MySql.Data.MySqlClient
Public Class SQLCom
    Private cs As String = "Database = EidillionStocktest;Data Source=127.0.0.1; User Id=root;Password=;"
    Private Connexion As New MySqlConnection(cs)

    'Méthode pour ajouter un Client à la Database
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

    'Méthode pour ajouter un produit à la Database
    Public Function AddProduct(ByVal ProductName As String, ByVal ProductRef As Integer, ByVal ProductProvider As Integer) As Boolean
        Dim Request As String
        Try
            Connexion.Open()
            Request = "INSERT INTO `t_produits`(`Nom`, `Reference`, `XID_Fournisseur`) VALUES( """ & ProductName & """," & ProductRef & "," & ProductProvider & ");"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Connexion.Close()
    End Function

    Public Function GiveNamesOfProviders() As String()
        Dim Number As Integer
        Dim Request As String
        Dim Value() As String
        Try
            Connexion.Open()
            Request = "SELECT * FROM `t_fournisseurs`"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader()
            While Reader.Read()
                ReDim Preserve Value(Number)
                Value(Number) = Reader.GetString(1)
                Number += 1
            End While
            Connexion.Close()
            Return Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Value
        End Try
        Connexion.Close()
    End Function

    Public Function GiveIDProviders(ByVal ProviderName As String) As Integer
        Dim Request As String
        Dim Capture As String
        Dim Value As Integer
        Try
            Connexion.Open()
            Request = "SELECT * FROM `t_fournisseurs` WHERE `Nom`=""" & ProviderName & """"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader

            While Reader.Read
                Capture = Reader.GetString(0)
            End While
            Value = CType(Capture, Integer)
            Connexion.Close()

            Return Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
        Connexion.Close()
    End Function
End Class
