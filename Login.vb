Imports System.Data.OleDb

Public Class Login
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\DHDatabase.accdb")

        sql = "SELECT * FROM [USER] WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPassword.Text & "'"

        cmd = New OleDbCommand(sql, conn)
        conn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Home.Show()
            Hide()
        Else
            MessageBox.Show("Incorrect Username and Password. Please retry", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        conn.Close()

    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class
