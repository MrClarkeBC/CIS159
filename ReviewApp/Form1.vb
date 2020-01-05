Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Integer.TryParse(TextBox1.Text, n)
        Label1.Text = n
    End Sub
End Class
