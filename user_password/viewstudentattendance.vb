Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class viewstudentattendance
    Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
    Private Sub viewstudentattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim searchQuery As String = "select * from stu_att where  Rollno=@rollno and Date between @Date1 and @Date2"
        Dim command As New SqlCommand(searchQuery, connection)
        command.Parameters.Add("rollno", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("Date1", SqlDbType.VarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("Date2", SqlDbType.VarChar).Value = DateTimePicker2.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class