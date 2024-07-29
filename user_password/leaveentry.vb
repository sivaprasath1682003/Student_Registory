Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Imports System.IO
Public Class leaveentry
    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("INSERT into studentleaveentry(Rollno,Name,Major,Reason,Leavingdate,Returningdate,numberofdays,Newreturningdate,Leaveissuesby) VALUES(@rollno,@name,@major,@reason,@leavingdate,@returning,@noofdays,@newreturndate,@leaveissue)", connection)

        command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@major", SqlDbType.VarChar).Value = ComboBox1.Text
        command.Parameters.Add("@reason", SqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@leavingdate", SqlDbType.VarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@returning", SqlDbType.VarChar).Value = DateTimePicker2.Text
        command.Parameters.Add("@noofdays", SqlDbType.VarChar).Value = TextBox5.Text
        command.Parameters.Add("@newreturndate", SqlDbType.VarChar).Value = DateTimePicker3.Text
        command.Parameters.Add("@leaveissue", SqlDbType.VarChar).Value = TextBox6.Text


        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("student leave details saved")
        Else
            MessageBox.Show("student leave details not saved")
        End If
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        If TextBox2.Text = "" Then
            MessageBox.Show("empty rollno")
        Else
            Dim command As New SqlClient.SqlCommand("update studentleaveentry SET Name=@name,Major=@major,Reason=@reason,Leavingdate=@leavingdate,Returningdate=@returning,numberofdays=@noofdays,Newreturningdate=@newreturndate,Leaveissuesby=@leaveissue WHERE Rollno=@rollno", connection)

            command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@major", SqlDbType.VarChar).Value = ComboBox1.Text
            command.Parameters.Add("@reason", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@leavingdate", SqlDbType.VarChar).Value = DateTimePicker1.Text
            command.Parameters.Add("@returning", SqlDbType.VarChar).Value = DateTimePicker2.Text
            command.Parameters.Add("@noofdays", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@newreturndate", SqlDbType.VarChar).Value = DateTimePicker3.Text
            command.Parameters.Add("@leaveissue", SqlDbType.VarChar).Value = TextBox6.Text

            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("student leave details  updated")
            Else
                MessageBox.Show("student leave details Not update")
            End If
            connection.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim Command As New SqlCommand("select * from studentleaveentry where Rollno=@rollno", connection)
        Command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBox2.Text
        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            TextBox2.Text = table.Rows(0)(0).ToString()
            TextBox3.Text = table.Rows(0)(1).ToString()
            ComboBox1.Text = table.Rows(0)(2).ToString()
            TextBox4.Text = table.Rows(0)(3).ToString()
            DateTimePicker1.Text = table.Rows(0)(4).ToString()
            DateTimePicker2.Text = table.Rows(0)(5).ToString()
            TextBox5.Text = table.Rows(0)(6).ToString()
            DateTimePicker3.Text = table.Rows(0)(7).ToString()
            TextBox6.Text = table.Rows(0)(8).ToString()

        Else
            MessageBox.Show("no data found")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("delete from studentleaveentry where Rollno=@rollno", connection)
        command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@major", SqlDbType.VarChar).Value = ComboBox1.Text
        command.Parameters.Add("@reason", SqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@leavingdate", SqlDbType.VarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@returning", SqlDbType.VarChar).Value = DateTimePicker2.Text
        command.Parameters.Add("@noofdays", SqlDbType.VarChar).Value = TextBox5.Text
        command.Parameters.Add("@newreturndate", SqlDbType.VarChar).Value = DateTimePicker3.Text
        command.Parameters.Add("@leaveissue", SqlDbType.VarChar).Value = TextBox6.Text

        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("student leave  details deleted")
        Else
            MessageBox.Show("student leave  details not deleted")
        End If
        connection.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub VIEWSTUDENTLEAVEENTRYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWSTUDENTLEAVEENTRYToolStripMenuItem.Click
        viewstudentleaveentry.Show()
    End Sub
End Class