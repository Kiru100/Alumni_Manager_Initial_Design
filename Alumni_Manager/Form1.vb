Public Class splashScreen

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        loadBar.Width += 3
        If (loadBar.Width >= 494) Then
            LoadingTimer.Stop()
            Login.Show()
            Me.Hide()
        End If

    End Sub


End Class
