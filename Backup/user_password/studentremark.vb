Public Class studentremark

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("INSERT into Table_2(Rollno,Name,Department,Year,Date,Reason,Fine) VALUES(@rollno,@name,@department,@year,@date,@reason,@fine)", connection)
        command.Parameters.Add("@rollno", SqlDbType.VarChar).Value = TextBoxrollno.Text
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBoxname.Text
        command.Parameters.Add("@department", SqlDbType.VarChar).Value = ComboBoxdepartment.Text
        command.Parameters.Add("@year", SqlDbType.VarChar).Value = ComboBoxyear.Text
        command.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@reason", SqlDbType.VarChar).Value = ComboBoxreason.Text
        command.Parameters.Add("@fine", SqlDbType.VarChar).Value = TextBoxfine.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("new student  remark inserted")
        Else
            MessageBox.Show("new student remarkNot Added")
        End If
        connection.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBoxrollno.Text = ""
        TextBoxname.Text = ""
        ComboBoxdepartment.Text = ""
        ComboBoxyear.Text = ""
        ComboBoxreason.Text = ""
        TextBoxfine.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        studentremark_search.Show()
    End Sub
End Class