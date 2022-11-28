Public Class Home
    Dim sidebar As String = "Close"

    Sub clear()
        lblPanelWelcome.Visible = False
        OrderBtn.Visible = False
        PayBtn.Visible = False
        MainBtn.Visible = False
        AccBtn.Visible = False
        PurBtn.Visible = False
    End Sub

    Sub setname()
        lblPanelWelcome.Visible = True
        OrderBtn.Visible = True
        PayBtn.Visible = True
        MainBtn.Visible = True
        AccBtn.Visible = True
        PurBtn.Visible = True
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles MenuBarBtn.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "Open" Then
            leftSideBar.Width -= 60
            If leftSideBar.Width <= 60 Then
                clear()
                sidebar = "Close"
                Timer1.Stop()
            End If
        Else
            leftSideBar.Width += 60
            If leftSideBar.Width >= 200 Then
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles OrderIconBtn.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub leftSideBar_Paint(sender As Object, e As PaintEventArgs) Handles leftSideBar.Paint

    End Sub

    Private Sub MainBtn_Click(sender As Object, e As EventArgs) Handles MainBtn.Click

    End Sub

    Private Sub PayBtn_Click(sender As Object, e As EventArgs) Handles PayBtn.Click

    End Sub

    Private Sub WelcomePanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblPanelWelcome.Click

    End Sub

End Class