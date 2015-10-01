Imports MySql.Data.MySqlClient
Public Class Form_Acceuil

    Private Connexion As New MySqlConnection
    Private Sub BT_Valider_Click(sender As Object, e As EventArgs) Handles BT_Valider.Click
        Dim Test As Boolean
        Test = Connect()
        If Test = True Then
            Form_Stocks.Show()
        Else
            MessageBox.Show("Mot de Passe ou Pseudonyme incorrect !")
        End If
    End Sub

    Private Function Connect() As Boolean
        Dim DatabaseName As String = "EidillionStock"
        Dim Server As String = "127.0.0.1"
        Dim UserName As String = TB_User.Text
        Dim Password As String = TB_Password.Text
        If Not Connexion Is Nothing Then Connexion.Close()
        Connexion.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", Server, UserName, Password, DatabaseName)
        Try
            Connexion.Open()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Connexion.Close()
    End Function
End Class
