Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class viewallstudentdetails
    Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
    Private Sub viewallstudentdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searchQuery As String = "select * from studentdetail"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchQuery As String = "select Rollno,Name,Major,DataOfBirth,Bloodgroup,Mothername,Fathername,Parentmobilenumber,Community,Aadharnumber,address,Bankaccountnumber,Sports,Event,Extracurricularactivity,studentcontact from studentdetail where Major=@major"
        Dim command As New SqlCommand(searchQuery, connection)
        command.Parameters.Add("@major", SqlDbType.VarChar).Value = TextBox1.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class