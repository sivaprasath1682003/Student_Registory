Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Imports System.IO


Public Class Studentdetails
    Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
    Private Sub INSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSERT.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("INSERT into studentdetail(Rollno,Name,Major,DataOfBirth,Bloodgroup,Mothername,Fathername,Parentmobilenumber,Community,Aadharnumber,address,Bankaccountnumber,Sports,Event,Extracurricularactivity,studentcontact) VALUES(@rollno,@name,@major,@dob,@bloodgroup,@mothername,@fathername,@mobilenumber,@community,@aadhar,@address,@bankaccount,@sports,@event,@extracurricular,@studentcontact)", connection)

        command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBoxRollno.Text
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBoxname.Text
        command.Parameters.Add("@major", SqlDbType.VarChar).Value = ComboBoxMajor.Text
        command.Parameters.Add("@dob", SqlDbType.VarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@bloodgroup", SqlDbType.VarChar).Value = ComboBoxbloodgroup.Text
        command.Parameters.Add("@mothername", SqlDbType.VarChar).Value = TextBoxmothername.Text
        command.Parameters.Add("@fathername", SqlDbType.VarChar).Value = TextBoxfathername.Text
        command.Parameters.Add("@mobilenumber", SqlDbType.VarChar).Value = TextBoxmobilenumber.Text
        command.Parameters.Add("@community", SqlDbType.VarChar).Value = ComboBoxcommunity.Text
        command.Parameters.Add("@aadhar", SqlDbType.VarChar).Value = TextBoxaadhar.Text
        command.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBoxaddress.Text
        command.Parameters.Add("@bankaccount", SqlDbType.VarChar).Value = TextBoxbankaccount.Text
        command.Parameters.Add("@sports", SqlDbType.VarChar).Value = ComboBoxsports.Text
        command.Parameters.Add("@event", SqlDbType.VarChar).Value = ComboBoxevent.Text
        command.Parameters.Add("@extracurricular", SqlDbType.VarChar).Value = ComboBoxextra.Text
        command.Parameters.Add("@studentcontact", SqlDbType.VarChar).Value = ComboBoxstudentcontact.Text


        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("new student inserted")
        Else
            MessageBox.Show("new student Not Added")
        End If
        connection.Close()
    End Sub

    Private Sub UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATE.Click
        Studentdetails_search.Show()
    End Sub

    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("delete from studentdetail where Rollno=@rollno", connection)
        command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBoxRollno.Text
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBoxname.Text
        command.Parameters.Add("@major", SqlDbType.VarChar).Value = ComboBoxMajor.Text
        command.Parameters.Add("@dob", SqlDbType.VarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@bloodgroup", SqlDbType.VarChar).Value = ComboBoxbloodgroup.Text
        command.Parameters.Add("@mothername", SqlDbType.VarChar).Value = TextBoxmothername.Text
        command.Parameters.Add("@fathername", SqlDbType.VarChar).Value = TextBoxfathername.Text
        command.Parameters.Add("@mobilenumber", SqlDbType.VarChar).Value = TextBoxmobilenumber.Text
        command.Parameters.Add("@community", SqlDbType.VarChar).Value = ComboBoxcommunity.Text
        command.Parameters.Add("@aadhar", SqlDbType.VarChar).Value = TextBoxaadhar.Text
        command.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBoxaddress.Text
        command.Parameters.Add("@bankaccount", SqlDbType.VarChar).Value = TextBoxbankaccount.Text
        command.Parameters.Add("@sports", SqlDbType.VarChar).Value = ComboBoxsports.Text
        command.Parameters.Add("@event", SqlDbType.VarChar).Value = ComboBoxevent.Text
        command.Parameters.Add("@extracurricular", SqlDbType.VarChar).Value = ComboBoxextra.Text
        command.Parameters.Add("@studentcontact", SqlDbType.VarChar).Value = ComboBoxstudentcontact.Text

        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("student details deleted")
        Else
            MessageBox.Show("student details not deleted")
        End If
        connection.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonexit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        TextBoxRollno.Text = ""
        TextBoxname.Text = ""
        TextBoxmothername.Text = ""
        TextBoxfathername.Text = ""
        TextBoxmobilenumber.Text = ""
        TextBoxaadhar.Text = ""
        TextBoxaddress.Text = ""
        TextBoxbankaccount.Text = ""




    End Sub

    Private Sub Studentdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SivaDataSet10.studentdetail' table. You can move, or remove it, as needed.
        Me.StudentdetailTableAdapter.Fill(Me.SivaDataSet10.studentdetail)

        Dim searchQuery As String = "select * from studentdetail"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub ViewStudentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentDetailsToolStripMenuItem.Click
        viewstudentdetails.Show()

    End Sub

    Private Sub ViewAllStudentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllStudentDetailsToolStripMenuItem.Click
        viewallstudentdetails.Show()
    End Sub
End Class