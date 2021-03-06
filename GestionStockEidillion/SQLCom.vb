﻿Imports MySql.Data.MySqlClient
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

    'Donne l'ensemble des noms des producteurs
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


    'Donne l'ID du producteur susnommé
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

    'Donne l'ensemble des noms des produits
    Public Function GiveNamesOfProducts() As String()
        Dim Request As String
        Dim Capture() As String
        Dim i As Integer
        Try
            Connexion.Open()
            Request = "SELECT * FROM `t_produits`"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader

            While Reader.Read
                ReDim Preserve Capture(i)
                Capture(i) = Reader.GetString(1)
                i += 1
            End While

            Connexion.Close()

            Return Capture
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Capture
        End Try
    End Function

    'Donne l'ensemble des noms des clients
    Public Function GiveNamesOfClients() As String()
        Dim Request As String
        Dim Capture() As String
        Dim i As Integer
        Try
            Connexion.Open()
            Request = "SELECT * FROM `t_clients`"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader

            While Reader.Read
                ReDim Preserve Capture(i)
                Capture(i) = Reader.GetString(1)
                i += 1
            End While

            Connexion.Close()

            Return Capture
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Capture
        End Try
    End Function

    'On récupère l'ID du client demandé
    Public Function GiveIDofClients(ByVal NameClient As String) As Integer
        Dim IDClient As Integer
        Dim Request As String
        Dim Capture As String
        Try
            Connexion.Open()
            Request = "SELECT * FROM t_clients WHERE `Nom` = """ & NameClient & """;"

            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()

            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader

            While Reader.Read
                Capture = Reader.GetString(0)
            End While

            IDClient = CType(Capture, Integer)
            Connexion.Close()
            Return IDClient

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function

    Public Function GiveIDofProduct(ByVal NameProduct As String) As Integer
        Dim IDProduct As Integer
        Dim Request As String
        Dim Capture As String
        Try
            Connexion.Open()
            Request = "SELECT * FROM t_produits WHERE `Nom` = """ & NameProduct & """;"

            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()

            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader

            While Reader.Read
                Capture = Reader.GetString(0)
            End While

            IDProduct = CType(Capture, Integer)
            Connexion.Close()
            Return IDProduct

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function

    'On envoie Le produit et sa commande
    Public Function CurrentDeliversiesClientsAdd(ByVal IDProduct As Integer, ByVal IDNameClient As Integer, ByVal DeliveryTime As String, ByVal Reference As Integer, ByVal DeliveryPrice As Double, ByVal DeliveryQuantity As Integer) As Boolean
        Dim Request As String
        Try
            Connexion.Open()
            Request = "INSERT INTO `t_comcli`(`Reference`, `Prix`, `Quantite`, `Date_Depart`, `XID_Client`, `XID_Produit`) VALUES(" & Reference & "," & DeliveryPrice & "," & DeliveryQuantity & ",""" & DeliveryTime & """," & IDNameClient & "," & IDProduct & ");"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Connexion.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Connexion.Close()
    End Function

    Public Function CurrentDeliversiesProviderAdd(ByVal IDProduct As Integer, ByVal IDNameProvider As Integer, ByVal DeliveryTime As String, ByVal Reference As Integer, ByVal DeliveryPrice As Double, ByVal DeliveryQuantity As Integer) As Boolean
        Dim Request As String
        Try
            Connexion.Open()
            Request = "INSERT INTO `t_comfour`(`Reference`, `Prix`, `Quantite`, `Date_Depart`, `XID_Produit`) VALUES(" & Reference & "," & DeliveryPrice & "," & DeliveryQuantity & ",""" & DeliveryTime & """," & IDProduct & ");"
            Dim Command As New MySqlCommand(Request, Connexion)
            Command.ExecuteNonQuery()
            Connexion.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Connexion.Close()
    End Function

End Class
