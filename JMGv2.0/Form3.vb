Public Class Form3
    Dim sidebar As String = "Close"

    Private Sub Form3_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles MenuBar.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "Open" Then
            leftSideBar.Width = 40
            If leftSideBar.Width >= 214 Then
                sidebar = "Close"
                Timer1.Stop()
            End If
        Else
            leftSideBar.Width = 40
            If leftSideBar.Width = 50 Then
                sidebar = "Open"
                Timer1.Stop()
            End If

        End If
    End Sub
End Class