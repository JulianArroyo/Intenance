Public Class SplashWindow
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashProgressBar.Increment(1)
        If SplashProgressBar.Value = 100 Then
            PrincipalWindow.Show()
            Me.Hide()
            SplashTimer.Stop()
        End If
    End Sub
End Class
