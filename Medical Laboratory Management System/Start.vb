Public Class Start
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RectangleShape1.Width += 2
            If RectangleShape1.Width >= 298 Then
                Timer1.Stop()
                Login.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class
