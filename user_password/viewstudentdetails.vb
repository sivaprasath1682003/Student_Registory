Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient
Public Class viewstudentdetails
    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim Command As New SqlCommand("select * from studentdetail where Rollno=@rollno", connection)
        Command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBoxRollno.Text
        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            TextBoxRollno.Text = table.Rows(0)(0).ToString()
            TextBoxname.Text = table.Rows(0)(1).ToString()
            TextBox2.Text = table.Rows(0)(2).ToString()
            TextBox1.Text = table.Rows(0)(3).ToString()
            TextBox4.Text = table.Rows(0)(4).ToString()
            TextBoxmothername.Text = table.Rows(0)(5).ToString()
            TextBoxfathername.Text = table.Rows(0)(6).ToString()
            TextBoxmobilenumber.Text = table.Rows(0)(7).ToString()
            TextBox3.Text = table.Rows(0)(8).ToString()
            TextBoxaadhar.Text = table.Rows(0)(9).ToString()
            TextBoxaddress.Text = table.Rows(0)(10).ToString()
            TextBoxbankaccount.Text = table.Rows(0)(11).ToString()
            TextBox5.Text = table.Rows(0)(12).ToString()
            TextBox6.Text = table.Rows(0)(13).ToString()
            TextBox7.Text = table.Rows(0)(14).ToString()
            TextBox8.Text = table.Rows(0)(15).ToString()

        Else
            MessageBox.Show("no data found")
        End If

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBoxRollno.Text = ""
        TextBoxname.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBoxmothername.Text = ""
        TextBoxfathername.Text = ""
        TextBoxmobilenumber.Text = ""
        TextBox3.Text = ""
        TextBoxaadhar.Text = ""
        TextBoxaddress.Text = ""
        TextBoxbankaccount.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

    End Sub

    Private Sub buttonexit_Click(sender As Object, e As EventArgs) Handles buttonexit.Click
        Me.Close()
    End Sub

    Private Sub TextBoxname_TextChanged(sender As Object, e As EventArgs) Handles TextBoxname.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class