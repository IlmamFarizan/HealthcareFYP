<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HealthSupport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HealthSupport))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnBMIcalc = New System.Windows.Forms.Button()
        Me.btnFindHospital = New System.Windows.Forms.Button()
        Me.btnFinddoc = New System.Windows.Forms.Button()
        Me.btnChatdoc = New System.Windows.Forms.Button()
        Me.lblAboutus = New System.Windows.Forms.Label()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPharmacy = New System.Windows.Forms.Label()
        Me.lblHealthsupport = New System.Windows.Forms.Label()
        Me.lblArticles = New System.Windows.Forms.Label()
        Me.lblProfile = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(963, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "BMI Calculator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(661, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Find a Hospital"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Search a Doctor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Chat with a Doctor"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHeader.Font = New System.Drawing.Font("Lucida Bright", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(443, 101)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(362, 31)
        Me.lblHeader.TabIndex = 43
        Me.lblHeader.Text = "Select Healthcare Service"
        '
        'btnBMIcalc
        '
        Me.btnBMIcalc.BackgroundImage = CType(resources.GetObject("btnBMIcalc.BackgroundImage"), System.Drawing.Image)
        Me.btnBMIcalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBMIcalc.Location = New System.Drawing.Point(924, 170)
        Me.btnBMIcalc.Name = "btnBMIcalc"
        Me.btnBMIcalc.Size = New System.Drawing.Size(210, 190)
        Me.btnBMIcalc.TabIndex = 42
        Me.btnBMIcalc.UseVisualStyleBackColor = True
        '
        'btnFindHospital
        '
        Me.btnFindHospital.BackgroundImage = CType(resources.GetObject("btnFindHospital.BackgroundImage"), System.Drawing.Image)
        Me.btnFindHospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindHospital.Location = New System.Drawing.Point(622, 170)
        Me.btnFindHospital.Name = "btnFindHospital"
        Me.btnFindHospital.Size = New System.Drawing.Size(210, 190)
        Me.btnFindHospital.TabIndex = 41
        Me.btnFindHospital.UseVisualStyleBackColor = True
        '
        'btnFinddoc
        '
        Me.btnFinddoc.BackColor = System.Drawing.SystemColors.Control
        Me.btnFinddoc.BackgroundImage = CType(resources.GetObject("btnFinddoc.BackgroundImage"), System.Drawing.Image)
        Me.btnFinddoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFinddoc.Location = New System.Drawing.Point(327, 170)
        Me.btnFinddoc.Name = "btnFinddoc"
        Me.btnFinddoc.Size = New System.Drawing.Size(210, 190)
        Me.btnFinddoc.TabIndex = 40
        Me.btnFinddoc.UseVisualStyleBackColor = False
        '
        'btnChatdoc
        '
        Me.btnChatdoc.BackColor = System.Drawing.SystemColors.Control
        Me.btnChatdoc.BackgroundImage = CType(resources.GetObject("btnChatdoc.BackgroundImage"), System.Drawing.Image)
        Me.btnChatdoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChatdoc.Location = New System.Drawing.Point(48, 170)
        Me.btnChatdoc.Name = "btnChatdoc"
        Me.btnChatdoc.Size = New System.Drawing.Size(210, 190)
        Me.btnChatdoc.TabIndex = 39
        Me.btnChatdoc.UseVisualStyleBackColor = False
        '
        'lblAboutus
        '
        Me.lblAboutus.AutoSize = True
        Me.lblAboutus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAboutus.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutus.Location = New System.Drawing.Point(1002, 34)
        Me.lblAboutus.Name = "lblAboutus"
        Me.lblAboutus.Size = New System.Drawing.Size(159, 34)
        Me.lblAboutus.TabIndex = 38
        Me.lblAboutus.Text = "About Us"
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.BackColor = System.Drawing.Color.Transparent
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Location = New System.Drawing.Point(1074, 507)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(78, 25)
        Me.lblLogout.TabIndex = 37
        Me.lblLogout.Text = "Logout"
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1056, 413)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 91)
        Me.btnLogout.TabIndex = 36
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'lblPharmacy
        '
        Me.lblPharmacy.AutoSize = True
        Me.lblPharmacy.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPharmacy.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPharmacy.Location = New System.Drawing.Point(786, 34)
        Me.lblPharmacy.Name = "lblPharmacy"
        Me.lblPharmacy.Size = New System.Drawing.Size(172, 34)
        Me.lblPharmacy.TabIndex = 34
        Me.lblPharmacy.Text = "Pharmacy"
        '
        'lblHealthsupport
        '
        Me.lblHealthsupport.AutoSize = True
        Me.lblHealthsupport.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHealthsupport.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthsupport.Location = New System.Drawing.Point(502, 34)
        Me.lblHealthsupport.Name = "lblHealthsupport"
        Me.lblHealthsupport.Size = New System.Drawing.Size(255, 34)
        Me.lblHealthsupport.TabIndex = 33
        Me.lblHealthsupport.Text = "Health Support"
        '
        'lblArticles
        '
        Me.lblArticles.AutoSize = True
        Me.lblArticles.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblArticles.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticles.Location = New System.Drawing.Point(331, 34)
        Me.lblArticles.Name = "lblArticles"
        Me.lblArticles.Size = New System.Drawing.Size(136, 34)
        Me.lblArticles.TabIndex = 32
        Me.lblArticles.Text = "Articles"
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProfile.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.Location = New System.Drawing.Point(178, 34)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(120, 34)
        Me.lblProfile.TabIndex = 31
        Me.lblProfile.Text = "Profile"
        '
        'HealthSupport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1186, 541)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnBMIcalc)
        Me.Controls.Add(Me.btnFindHospital)
        Me.Controls.Add(Me.btnFinddoc)
        Me.Controls.Add(Me.btnChatdoc)
        Me.Controls.Add(Me.lblAboutus)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPharmacy)
        Me.Controls.Add(Me.lblHealthsupport)
        Me.Controls.Add(Me.lblArticles)
        Me.Controls.Add(Me.lblProfile)
        Me.Name = "HealthSupport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HealthSupport"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnBMIcalc As Button
    Friend WithEvents btnFindHospital As Button
    Friend WithEvents btnFinddoc As Button
    Friend WithEvents btnChatdoc As Button
    Friend WithEvents lblAboutus As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPharmacy As Label
    Friend WithEvents lblHealthsupport As Label
    Friend WithEvents lblArticles As Label
    Friend WithEvents lblProfile As Label
End Class
