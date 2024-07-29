Imports System.Drawing.Printing
Public Class leaveform
    Dim HH As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        HH = 50
        e.Graphics.DrawString(Label1.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 300, HH)
        HH += 48
        e.Graphics.DrawString(Label2.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 46
        e.Graphics.DrawString(Label3.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 44
        e.Graphics.DrawString(Label4.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 42
        e.Graphics.DrawString(Label5.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 40
        e.Graphics.DrawString(Label6.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 38
        e.Graphics.DrawString(Label7.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 36
        e.Graphics.DrawString(Label8.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 34
        e.Graphics.DrawString(Label9.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 32
        e.Graphics.DrawString(Label10.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 30
        e.Graphics.DrawString(Label12.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 28
        e.Graphics.DrawString(Label13.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH += 26
        e.Graphics.DrawString(Label14.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 10, HH)
        HH = 26
        e.Graphics.DrawString(Label15.Text, New Drawing.Font("Times New Roman", 16), Brushes.Black, 50, HH)
    End Sub
End Class