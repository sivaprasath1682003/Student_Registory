Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class studentattentance

    Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("INSERT into stu_att(Rollno,Date,Morningprayer,MReason,Afternoonprayer,AReason,Eveningprayer,EReason,Rollcall,RReason,Status)VALUES(@rollno,@date,@morningprayer,@mreason,@afternoonprayer,@areason,@eveningprayer,@ereason,@rollcall,@rreason,@status)", connection)

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
        command.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox6.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("student attendance inserted")
        Else
            MessageBox.Show("student attendance Not inserted")
        End If
        connection.Close()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        studentattendance_search.Show()

    End Sub

    Private Sub studentattentance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim searchQuery As String = "select * from stu_att"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("delete from stu_att where Rollno=@rollno", connection)
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
        command.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox6.Text
       
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("student attendance deleted")
        Else
            MessageBox.Show("student attendance not deleted")
        End If
        connection.Close()
    End Sub
End Class