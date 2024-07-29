Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class studentattendance_search
    Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH.Click
        Dim Command As New SqlCommand("select * from stu_att where Rollno=@rollno and Date=@date", connection)
        Command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBox1rollno.Text
        Command.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTimePicker1.Text

        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            TextBox1rollno.Text = table.Rows(0)(0).ToString()
            DateTimePicker1.Text = table.Rows(0)(1).ToString()
            ComboBox1.Text = table.Rows(0)(2).ToString()
            ComboBox5.Text = table.Rows(0)(3).ToString()
            ComboBox2.Text = table.Rows(0)(4).ToString()
            ComboBox7.Text = table.Rows(0)(5).ToString()
            ComboBox3.Text = table.Rows(0)(6).ToString()
            ComboBox8.Text = table.Rows(0)(7).ToString()
            ComboBox4.Text = table.Rows(0)(8).ToString()
            ComboBox9.Text = table.Rows(0)(9).ToString()

        Else
            MessageBox.Show("no data found")



        End If
    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        If TextBox1rollno.Text = "" And DateTimePicker1.Text = "" Then
            MessageBox.Show("empty rollno")
        Else
            Dim command As New SqlClient.SqlCommand("update stu_att SET Morningprayer=@morningprayer,MReason=@mreason,Afternoonprayer=@afternoonprayer,AReason=areason,Eveningprayer=@eveningprayer,EReason=@ereason,Rollcall=@rollcall,RReason=@rreason WHERE Rollno=@rollno and Date=@date", connection)
            command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBox1rollno.Text
            command.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTimePicker1.Text
            command.Parameters.Add("@morningprayer", SqlDbType.VarChar).Value = ComboBox1.Text
            command.Parameters.Add("@mreason", SqlDbType.VarChar).Value = ComboBox5.Text
            command.Parameters.Add("@afternoonprayer", SqlDbType.VarChar).Value = ComboBox2.Text
            command.Parameters.Add("@areason", SqlDbType.VarChar).Value = ComboBox7.Text
            command.Parameters.Add("@eveningprayer", SqlDbType.VarChar).Value = ComboBox3.Text
            command.Parameters.Add("@ereason", SqlDbType.VarChar).Value = ComboBox8.Text
            command.Parameters.Add("@rollcall", SqlDbType.VarChar).Value = ComboBox4.Text
            command.Parameters.Add("@rreason", SqlDbType.VarChar).Value = ComboBox9.Text

            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("student details updated")
            Else
                MessageBox.Show("student details Not update")
            End If
            connection.Close()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class