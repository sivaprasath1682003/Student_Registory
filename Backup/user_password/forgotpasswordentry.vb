Public Class forgotpasswordentry

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        If TextBox1.Text = "" Then
            MessageBox.Show("empty username")
        Else
            Dim command As New SqlClient.SqlCommand("update LOGIN SET PASSWORD=@password where USERNAME=@username", connection)
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text
            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show(" user password not updated")
            Else
                MessageBox.Show("user password update")
            End If
            connection.Close()
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class