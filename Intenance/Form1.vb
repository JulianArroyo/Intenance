Public Class SplashWindow

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashProgressBar.Increment(1)
        If SplashProgressBar.Value = 100 Then
            PrincipalWindow.Show()
            Me.Hide()
            SplashTimer.Stop()
        End If
    End Sub

    Private Sub SplashWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(SplashProgressBar.Handle, 1040, 3, 0)
        SplashTimer.Start()
    End Sub
End Class