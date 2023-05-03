Imports System.Data.OleDb


Public Class Profile

    Dim searchkey As String
    Dim conn As New OleDbConnection
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim cmd As OleDbCommand

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Home.Show()
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

    Private Sub btnEditprofile_Click(sender As Object, e As EventArgs) Handles btnEditprofile.Click
        EditProfile.Show()
        Hide()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        searchkey = txtPassword.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\DHDatabase.accdb")
        conn.Open()
        sql = "SELECT * FROM [USER] WHERE Password='" & searchkey & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            lblUsername.Text = dr.Item("Username")
            lblPassport.Text = dr.Item("Passport")
            lblFullname.Text = dr.Item("FullName")
            lblGender.Text = dr.Item("Gender")
            lblAddress.Text = dr.Item("Address")
            lblPhonenum.Text = dr.Item("PhoneNumber")
            lblDOB.Text = dr.Item("DOB")
        Else
            MessageBox.Show("No records of this user", "Healthcare+", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr.Close()
        conn.Close()
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Please Enter Your Password First", "Healthcare+", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class