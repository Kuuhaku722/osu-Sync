﻿Public Class Window_Welcome

    Private ShutdownAfterClose As Boolean = True

    Private Sub Button_SkipLogin_Click(sender As Object, e As RoutedEventArgs) Handles Button_SkipLogin.Click
        ShutdownAfterClose = False
        DirectCast(Application.Current.MainWindow, MainWindow).Activate()
        Me.Close()
    End Sub

    Private Sub Window_Welcome_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.Closing
        If ShutdownAfterClose Then
            Application.Current.Shutdown()
        End If
    End Sub
End Class
