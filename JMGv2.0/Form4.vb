Public Class Form4
    Dim sidebar As String = "Close"

    Sub clear()
        lblWelcome.Visible = False
        dtpPanelDate.Visible = False
        OrderBtn.Visible = False
        PayBtn.Visible = False
        MainBtn.Visible = False
        AccBtn.Visible = False
        PurBtn.Visible = False
    End Sub

    Sub setname()
        lblWelcome.Visible = True
        dtpPanelDate.Visible = True
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

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTableNo.SelectedIndexChanged

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles lblTableNo.Click

    End Sub

    Private Sub leftSideBar_Paint(sender As Object, e As PaintEventArgs) Handles leftSideBar.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblSearchV.Click

    End Sub
End Class