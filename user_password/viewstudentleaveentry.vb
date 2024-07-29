Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class viewstudentleaveentry
    Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchQuery As String = "select * from studentleaveentry where Rollno=@rollno"
        Dim command As New SqlCommand(searchQuery, connection)
        command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBox1.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub viewstudentleaveentry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SivaDataSet15.studentleaveentry' table. You can move, or remove it, as needed.
        Me.StudentleaveentryTableAdapter.Fill(Me.SivaDataSet15.studentleaveentry)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class