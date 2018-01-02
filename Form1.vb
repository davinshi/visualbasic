Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Visible = False
        MsgBox("       Thanks For Using Software Enjoy ^__^")
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim data As String = "u=" & MetroTextBox1.Text & "&p=" & MetroTextBox2.Text
        Dim bytes As Byte() = New UTF8Encoding().GetBytes(data)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://like-liker.com/ambil_token.php"), HttpWebRequest)
        request.Method = "POST"
        request.Accept = "*/*"
        request.ContentType = "application/x-www-form-urlencoded"
        request.Proxy = Nothing
        request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36"
        request.AllowAutoRedirect = False
        request.KeepAlive = True
        request.Referer = "http://like-liker.com/ambil_token.php/"
        request.ContentLength = bytes.Length
        Dim requestStream As Stream = request.GetRequestStream
        requestStream.Write(bytes, 0, bytes.Length)
        requestStream.Close()
        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        Dim page As String = New StreamReader(response.GetResponseStream).ReadToEnd
        sigg = Regex.Match(page, "sig=(.*)""><\/if").Groups(1).ToString
        WebBrowser1.DocumentText = page
    End Sub
    Dim sigg As String
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click

        Try
            Dim d As New OpenFileDialog
            d.Filter = "text | *.txt"
            d.ShowDialog()
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(d.FileName)
            Dim token As String = Regex.Match(fileReader, "access_token"":""(.*)"",""m").Groups(1).ToString
            Dim sig As String = sigg
            Dim session_key As String = Regex.Match(fileReader, "session_key"":""(.*)"",""u").Groups(1).ToString
            Dim secret As String = Regex.Match(fileReader, "secret"":""(.*)"",""a").Groups(1).ToString
            Dim machine_id As String = Regex.Match(fileReader, "machine_id"":""(.*)"",""c").Groups(1).ToString
            Dim r As New Form2
            Me.Hide()
            r.Show()
            r.MetroTextBox1.Text = session_key
            r.MetroTextBox3.Text = secret
            r.MetroTextBox4.Text = token
            r.MetroTextBox5.Text = machine_id
            r.MetroTextBox6.Text = sig
        Catch ex As Exception
            CheckForIllegalCrossThreadCalls = False
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Application.Exit()
    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click
        MetroTextBox1.Clear()
    End Sub

    Private Sub MetroTextBox2_Click(sender As Object, e As EventArgs) Handles MetroTextBox2.Click
        MetroTextBox2.Clear()
    End Sub
End Class
