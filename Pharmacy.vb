Public Class Pharmacy
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

    Private Sub lblAboutus_Click(sender As Object, e As EventArgs) Handles lblAboutus.Click
        AboutUs.Show()
        Hide()
    End Sub

    Private Sub btnCough_Click(sender As Object, e As EventArgs) Handles btnCough.Click
        CoughnFlu.Show()
        Hide()
    End Sub

    Private Sub btnFever_Click(sender As Object, e As EventArgs) Handles btnFever.Click
        Fever.Show()
        Hide()
    End Sub

    Private Sub btnBeauty_Click(sender As Object, e As EventArgs) Handles btnBeauty.Click
        BeautyProducts.Show()
        Hide()
    End Sub

    Private Sub btnStomach_Click(sender As Object, e As EventArgs) Handles btnStomach.Click
        Stomach.Show()
        Hide()
    End Sub

    Private Sub btnAntiseptic_Click(sender As Object, e As EventArgs) Handles btnAntiseptic.Click
        Antiseptic.Show()
        Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Hide()
    End Sub
End Class