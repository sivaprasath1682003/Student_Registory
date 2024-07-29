Imports System.Data.SqlClient
Public Class userlogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection("Data Source=LAPTOP-T1M8R05D;Initial Catalog=siva;Integrated Security=True")
        Dim command As New SqlClient.SqlCommand("select * from LOGIN where Username = @username and Password = @password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxPassword.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxUsername.Text
        Dim adapter As New SqlClient.SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("username or password are invalid")
        Else
            FORM2ui.Show()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        forgotpassword.Show()
    End Sub
End Class