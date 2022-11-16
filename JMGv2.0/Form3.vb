Public Class Form3
    Dim sidebar As String = "Close"

    Private Sub Form3_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles MenuBar.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "Open" Then
            leftSideBar.Width = 25
            If leftSideBar >= 250 Then
                sidebar = "Close"
                Timer1.Stop()

            End If
        Else
            leftSideBar -= 25
            If leftSideBar.Width <= 50 Then
                sidebar = "Open"
                Timer1.Stop()
            End If

        End If
    End Sub
End Class