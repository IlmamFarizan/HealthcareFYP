Public Class GleneaglesHospital
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
End Class