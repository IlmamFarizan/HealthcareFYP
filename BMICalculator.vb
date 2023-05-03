Public Class BMICalculator

    Dim h As Double
    Dim w As Double
    Dim t As Double


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

    Private Sub btnCheckBMI_Click(sender As Object, e As EventArgs) Handles btnCheckBMI.Click

        If String.IsNullOrEmpty(txtWeight.Text) OrElse String.IsNullOrEmpty(txtHeight.Text) Then
            MessageBox.Show("Please Enter Values", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtWeight.Focus()
        Else
            w = txtWeight.Text
            h = txtHeight.Text
            t = w / (h * h)

            txtResult.Text = String.Format("{0:f}", t)
        End If


    End Sub

    Private Sub btnResetBMI_Click(sender As Object, e As EventArgs) Handles btnResetBMI.Click

        txtHeight.Text = ""
        txtWeight.Text = ""
        txtResult.Text = ""

    End Sub


    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
            MessageBox.Show("Only Numbers Or Decimal Symbol Are Allowed!")
        End If
    End Sub


    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
            MessageBox.Show("Only Numbers Or Decimal Symbol Are Allowed!")
        End If
    End Sub

    Private Sub BMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DHDatabaseDataSet.BMI_Age' table. You can move, or remove it, as needed.
        Me.BMI_AgeTableAdapter.Fill(Me.DHDatabaseDataSet.BMI_Age)
        'TODO: This line of code loads data into the 'DHDatabaseDataSet.BMI_Status' table. You can move, or remove it, as needed.
        Me.BMI_StatusTableAdapter.Fill(Me.DHDatabaseDataSet.BMI_Status)

    End Sub
End Class