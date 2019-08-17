Public Class WeatherForm
    Private Sub WeatherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        weatherBrowser.ScriptErrorsSuppressed = True
        weatherBrowser.Navigate("https://weather.com/weather/tenday/l/422:11:AU")
    End Sub

    Private Sub TSBtnwebGo_Click(sender As Object, e As EventArgs) Handles TSBtnwebGo.Click
        weatherBrowser.Navigate(txtBrowserAddress.Text)
    End Sub

    Private Sub TSBtnGoBack_Click(sender As Object, e As EventArgs) Handles TSBtnGoBack.Click
        weatherBrowser.GoBack()
    End Sub

    Private Sub TSBtnClose_Click(sender As Object, e As EventArgs) Handles TSBtnClose.Click
        Me.Close()
    End Sub
End Class