Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class studentremark_search
    Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
    Private Sub studentremark_search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SivaDataSet12.stu_remarks' table. You can move, or remove it, as needed.
        Me.Stu_remarksTableAdapter.Fill(Me.SivaDataSet12.stu_remarks)
        Dim searchQuery As String = "select * from stu_remarks"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH.Click
        Dim searchQuery As String = "select Rollno,Name,Major,year,Date,reason,fine from stu_remarks where Rollno=@rollno"
        Dim command As New SqlCommand(searchQuery, connection)
        command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBoxrollno.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class