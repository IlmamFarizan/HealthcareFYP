Public Class FindHospital
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

    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        KLGeneralHospital.Show()
        Hide()
    End Sub

    Private Sub btnGleneagles_Click(sender As Object, e As EventArgs) Handles btnGleneagles.Click
        GleneaglesHospital.Show()
        Hide()
    End Sub

    Private Sub btnPrincecourt_Click(sender As Object, e As EventArgs) Handles btnPrincecourt.Click
        PrinceCourtHospital.Show()
        Hide()
    End Sub

    Private Sub btnMSU_Click(sender As Object, e As EventArgs) Handles btnMSU.Click
        MSUHospital.Show()
        Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Hide()
    End Sub
End Class