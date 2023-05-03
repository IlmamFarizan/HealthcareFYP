Imports System.Data.OleDb


Public Class SearchDoctor

    Dim searchkey As String
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\DHDatabase.accdb")
        conn.Open()
        sql = "SELECT * FROM [DOCTOR] WHERE Name='" & searchkey & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            txtName.Text = dr.Item("Name")
            txtHospital.Text = dr.Item("Hospital")
            txtQualification.Text = dr.Item("Qualification")
            txtGender.Text = dr.Item("Gender")
            txtExpertise.Text = dr.Item("Expertise")
        Else
            MessageBox.Show("No records of the Doctor found in the database", "Healthcare+", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSearchbox.Clear()
            txtSearchbox.Focus()
            txtName.Clear()
            txtHospital.Clear()
            txtQualification.Clear()
            txtGender.Clear()
            txtExpertise.Clear()
        End If
        txtSearchbox.Focus()
        dr.Close()
        conn.Close()


    End Sub

    Private Sub txtSearchbox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchbox.TextChanged
        searchkey = txtSearchbox.Text
    End Sub
End Class