Public Class Form2

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Application.Exit()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Clipboard.Clear()
        Clipboard.SetText(MetroTextBox1.Text)
        Dim hh As String = Clipboard.GetText()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Clipboard.Clear()
        Clipboard.SetText(MetroTextBox3.Text)
        Dim hh As String = Clipboard.GetText()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Clipboard.Clear()
        Clipboard.SetText(MetroTextBox4.Text)
        Dim hh As String = Clipboard.GetText()
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Clipboard.Clear()
        Clipboard.SetText(MetroTextBox5.Text)
        Dim hh As String = Clipboard.GetText()
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Clipboard.Clear()
        Clipboard.SetText(MetroTextBox6.Text)
        Dim hh As String = Clipboard.GetText()
    End Sub
End Class