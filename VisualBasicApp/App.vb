Public Class App
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Hello There!")
    End Sub

    Private Sub PB_Click(sender As Object, e As EventArgs) Handles PB.Click
        'Dim url As String = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
        'If PB.Value = 99 Then Process.Start("explorer", url)
        If PB.Value < 100 Then PB.Value = PB.Value + 1
        If PB.Value = 100 Then
            Console.Beep()
            MessageBox.Show("The Progressbar is full")
        End If
    End Sub
End Class
