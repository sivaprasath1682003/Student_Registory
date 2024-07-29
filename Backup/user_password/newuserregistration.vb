Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class newuserregistration

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("INSERT into LOGIN(USERNAME,PASSWORD,YOUR_FAVOURITE_ANIMAL,YOUR_FAVOURITE_BIRD,YOUR_FAVOURITE_PERSON)values(@username,@password,@favourite_animal,@favourite_bird,@favourite_person)", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text
        command.Parameters.Add("@favourite_animal", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@favourite_bird", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@favourite_person", SqlDbType.VarChar).Value = TextBox3.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("new user registered")
        Else
            MessageBox.Show("no one user added")
        End If
        connection.Close()
    End Sub

    Private Sub Button3clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3clear.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""

    End Sub

    Private Sub Button2exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2exit.Click
        Me.Close()
    End Sub
End Class