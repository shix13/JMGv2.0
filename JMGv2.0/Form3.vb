Public Class Form3
    Dim sidebar As String = "Close"

    Sub clear()
        HomeBtn.Text = ""
        OrderBtn.Text = ""
        PayBtn.Text = ""
        MainBtn.Text = ""
        AccBtn.Text = ""
        PurBtn.Text = ""
    End Sub

    Sub setname()
        HomeBtn.Text = "HOME"
        OrderBtn.Text = "ORDER"
        PayBtn.Text = "PAYMENT"
        MainBtn.Text = "MAINTENANCE"
        AccBtn.Text = "ACCOUNT"
        PurBtn.Text = "PURCHASE ORDER"
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles MenuBar.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "Open" Then
            leftSideBar.Width -= 41
            If leftSideBar.Width <= 50 Then
                clear()
                sidebar = "Close"
                Timer1.Stop()
            End If
        Else
            leftSideBar.Width += 41
            If leftSideBar.Width >= 214 Then
                setname()
                sidebar = "Open"
                Timer1.Stop()
            End If


        End If
    End Sub
    Private Sub Form3_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class