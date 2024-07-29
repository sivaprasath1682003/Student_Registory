Public Class forgotpassword


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("select * from LOGIN where USERNAME = @username and YOUR_FAVOURITE_ANIMAL=@favourite_animal or YOUR_FAVOURITE_BIRD=@favourite_bird or YOUR_FAVOURITE_PERSON=@favourite_person", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@favourite_animal", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@favourite_bird", SqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@favourite_person", SqlDbType.VarChar).Value = TextBox4.Text
        Dim adapter As New SqlClient.SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("given details  are invalid")
        Else
            forgotpasswordentry.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class