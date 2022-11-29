﻿Public Class AccountUser
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

    Private Sub AccountUser_Load(sender As Object, e As EventArgs)
        txtbPassword.PasswordChar = "*"
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
    Private Sub AccountUser_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles OrderIconBtn.Click
        Order.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Order.Show()
        Me.Hide()
    End Sub

    Private Sub PayIconBtn_Click(sender As Object, e As EventArgs) Handles PayIconBtn.Click
        Pay.Show()
        Me.Hide()
    End Sub

    Private Sub PayBtn_Click(sender As Object, e As EventArgs) Handles PayBtn.Click
        Pay.Show()
        Me.Hide()
    End Sub

    Private Sub MainIconBtn_Click(sender As Object, e As EventArgs) Handles MainIconBtn.Click
        mainTable.Show()
        Me.Hide()
    End Sub

    Private Sub MainBtn_Click(sender As Object, e As EventArgs) Handles MainBtn.Click
        mainTable.Show()
        Me.Hide()
    End Sub

    Private Sub PurIconBtn_Click(sender As Object, e As EventArgs) Handles PurIconBtn.Click
        PurchaseOrderCreate.Show()
        Me.Hide()
    End Sub

    Private Sub PurBtn_Click(sender As Object, e As EventArgs) Handles PurBtn.Click
        PurchaseOrderCreate.Show()
        Me.Hide()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class