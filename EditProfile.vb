Imports System.Data.OleDb

Public Class EditProfile

    Dim conn As New OleDbConnection
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim cmd As OleDbCommand

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Home.Show()
        Hide()
    End Sub

    Private Sub lblProfile_Click(sender As Object, e As EventArgs) Handles lblProfile.Click
        Profile.Show()
        Hide()

    End Sub

    Private Sub lblArticles_Click(sender As Object, e As EventArgs) Handles lblArticles.Click
        Articles.Show()
        Hide()
    End Sub

    Private Sub lblHealthsupport_Click(sender As Object, e As EventArgs) Handles lblHealthsupport.Click
        HealthSupport.Show()
        Hide()
    End Sub

    Private Sub lblPharmacy_Click(sender As Object, e As EventArgs) Handles lblPharmacy.Click
        Pharmacy.Show()
        Hide()
    End Sub

    Private Sub lblAboutus_Click(sender As Object, e As EventArgs) Handles lblAboutus.Click
        AboutUs.Show()
        Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Hide()
    End Sub

    Private Sub btnEditprofile_Click(sender As Object, e As EventArgs) Handles btnEditprofile.Click

        If String.IsNullOrEmpty(txtPassport.Text) OrElse String.IsNullOrEmpty(txtFullname.Text) OrElse String.IsNullOrEmpty(txtGender.Text) OrElse String.IsNullOrEmpty(txtAddress.Text) OrElse String.IsNullOrEmpty(txtPhonenum.Text) OrElse String.IsNullOrEmpty(txtDOB.Text) OrElse String.IsNullOrEmpty(txtUsername.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please Enter All Credentials", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
        Else

            Dim sqlUpdate As String

            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\DHDatabase.accdb")
            conn.Open()
            sqlUpdate = "UPDATE [User] SET [Passport]='" & txtPassport.Text & "', [FullName]='" & txtFullname.Text & "', [Gender]='" & txtGender.Text & "', [Address]='" & txtAddress.Text & "', [PhoneNumber]='" & txtPhonenum.Text & "', [DOB]='" & txtDOB.Text & "', [Password]='" & txtPassword.Text & "' WHERE [Username]='" & txtUsername.Text & "'"
            cmd = New OleDbCommand(sqlUpdate, conn)
            cmd.CommandType = CommandType.Text
            Dim iCount As Integer = cmd.ExecuteNonQuery()
            If iCount = 0 Then
                MessageBox.Show("Unable to update record")
            Else
                MessageBox.Show("Record has been updated")
                Home.Show()
                Hide()
            End If
            conn.Close()
        End If


    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassport.Text = Profile.lblPassport.Text
        txtFullname.Text = Profile.lblFullname.Text
        txtGender.Text = Profile.lblGender.Text
        txtAddress.Text = Profile.lblAddress.Text
        txtPhonenum.Text = Profile.lblPhonenum.Text
        txtDOB.Text = Profile.lblDOB.Text
        txtUsername.Text = Profile.lblUsername.Text
        txtPassword.Text = Profile.txtPassword.Text


    End Sub
End Class