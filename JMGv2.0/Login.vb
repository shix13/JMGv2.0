Imports IBM.Data.DB2

Public Class Login
    Private Conn As Common.DbConnection

    Private Sub Login_Load(sender As Object, e As EventArgs)
        Try
            Conn = New DB2Connection("server=localhost;database=oneg;" + "uid=db2admin;password=db2admin;")
            Conn.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Login_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class