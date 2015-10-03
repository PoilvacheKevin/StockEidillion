Imports MySql.Data.MySqlClient
Public Class Form_Acceuil

    Private Connexion As New MySqlConnection
    Private Sub BT_Valider_Click(sender As Object, e As EventArgs) Handles BT_Valider.Click
        Dim Test As Boolean
        Test = Connect()
        If Test = True Then
            Form_Stocks.Show()
        Else
            TB_Password.Text = ""
            TB_User.Text = ""
        End If
    End Sub

    Private Function Connect() As Boolean
        Dim cs As String = "Database = EidillionStock;Data Source=127.0.0.1;" & "User Id=" & TB_User.Text & ";Password=" & TB_Password.Text & ";"
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

End Class
