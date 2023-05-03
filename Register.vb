Imports System.Data.OleDb


Public Class Register
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\DHDatabase.accdb")
    Dim cmd As OleDbCommand
    Dim sql As String

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrEmpty(txtPassport.Text) OrElse String.IsNullOrEmpty(txtUsername.Text) Then
            MessageBox.Show("Please Enter Values", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
        Else
            conn.Open()
            sql = "INSERT INTO [USER]([Passport], [Username], [Password], [FullName], [Gender], [Address], [PhoneNumber], [DOB]) VALUES (@Passport, @Username, @Password, @FullName, @Gender, @Address, @PhoneNumber, @DOB)"

            cmd = New OleDbCommand(sql, conn)

            cmd.Parameters.AddWithValue("@Passport", txtPassport.Text)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@FullName", txtFullname.Text)
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhonenum.Text)
            cmd.Parameters.AddWithValue("@DOB", dateDOB.Text)


            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Registration successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login.Show()
                Hide()
            Else
                MessageBox.Show("Registration failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conn.Close()
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Hide()
    End Sub

    Private Sub txtPhonenum_TextChanged(sender As Object, e As EventArgs) Handles txtPhonenum.TextChanged

    End Sub

    Private Sub txtPhonenum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhonenum.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MsgBox("Only Numbers Allowed")
        End If
    End Sub

End Class