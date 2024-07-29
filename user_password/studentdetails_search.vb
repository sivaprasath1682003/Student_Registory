Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Imports System.IO
Public Class Studentdetails_search

    Private Sub SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim Command As New SqlCommand("select * from studentdetail where Rollno=@rollno", connection)
        Command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBoxRollno.Text
        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            TextBoxRollno.Text = table.Rows(0)(0).ToString()
            TextBoxname.Text = table.Rows(0)(1).ToString()
            ComboBoxMajor.Text = table.Rows(0)(2).ToString()
            DateTimePicker1.Text = table.Rows(0)(3).ToString()
            ComboBoxbloodgroup.Text = table.Rows(0)(4).ToString()
            TextBoxmothername.Text = table.Rows(0)(5).ToString()
            TextBoxfathername.Text = table.Rows(0)(6).ToString()
            TextBoxmobilenumber.Text = table.Rows(0)(7).ToString()
            ComboBoxcommunity.Text = table.Rows(0)(8).ToString()
            TextBoxaadhar.Text = table.Rows(0)(9).ToString()
            TextBoxaddress.Text = table.Rows(0)(10).ToString()
            TextBoxbankaccount.Text = table.Rows(0)(11).ToString()
            ComboBoxsports.Text = table.Rows(0)(12).ToString()
            ComboBoxevent.Text = table.Rows(0)(13).ToString()
            ComboBoxextra.Text = table.Rows(0)(14).ToString()
            ComboBoxstudentcontact.Text = table.Rows(0)(15).ToString()
        Else
            MessageBox.Show("no data found")
        End If
    End Sub

    Private Sub UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATE.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        If TextBoxRollno.Text = "" Then
            MessageBox.Show("empty rollno")
        Else
            Dim command As New SqlClient.SqlCommand("update studentdetail SET Name=@name,Major=@major,DataOfBirth=@dob,Bloodgroup=@bloodgroup,Mothername=@mothername,Fathername=@fathername,Parentmobilenumber=@mobilenumber,Community=@community,Aadharnumber=@aadhar,Address=@address,Bankaccountnumber=@bankaccount,Sports=@sports,Event=@event,Extracurricularactivity=@extracurricular,studentcontact=@studentcontact WHERE Rollno=@rollno", connection)
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
                MessageBox.Show("student details updated")
            Else
                MessageBox.Show("student details Not update")
            End If
            connection.Close()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class