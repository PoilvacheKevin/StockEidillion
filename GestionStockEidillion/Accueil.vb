Imports MySql.Data.MySqlClient
Public Class Form_Acceuil
    Private Connexion As New MySqlConnection

    Private Sub BT_Valider_Click(sender As Object, e As EventArgs) Handles BT_Valider.Click
        Dim Test As Boolean
        Test = Connect()
        If Test = True Then
            Test = ID_Confirm()
            If Test = True Then
                Form_Stocks.Show()
            End If
        Else
            TB_Password.Text = ""
            TB_User.Text = ""
        End If
    End Sub

    Private Function Connect() As Boolean
        Dim cs As String = "Database = EidillionStocktest;Data Source=127.0.0.1; User Id=root;Password=;"
        Dim Connexion As New MySqlConnection(cs)
        Try
            Connexion.Open()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Connexion.Close()
    End Function

    Private Function ID_Confirm() As Boolean
        Dim cs As String = "Database = EidillionStocktest;Data Source=127.0.0.1; User Id=root;Password=;"
        Dim Connexion As New MySqlConnection(cs)
        Connexion.Open()
        Dim Naming(50) As String
        Dim Password(50) As String
        Dim i As Integer
        Dim Request As String = "SELECT * FROM `t_acces`"
        Dim Command As New MySqlCommand(Request, Connexion)
        Command.ExecuteNonQuery()
        Dim Reader As MySqlDataReader
        Reader = Command.ExecuteReader()

        While Reader.Read()
            Naming(i) = Reader.GetString(1)
            Password(i) = Reader.GetString(2)
            i += 1
        End While

        Reader.Close()
        Connexion.Close()
        Dim Compare As Integer = 1
        Dim x As Integer

        While Compare <> 0 And x <> i
            Compare = String.Compare(Naming(x), TB_User.Text)
            Compare = String.Compare(Password(x), TB_Password.Text)
            x += 1
        End While

        If Compare = 0 Then
            Return True
        Else
            MessageBox.Show("Erreur Mdp ou Pseudonyme !")
            Return False
        End If

    End Function

End Class
