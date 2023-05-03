<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(108, 240)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(627, 97)
        Me.lblDesc.TabIndex = 20
        Me.lblDesc.Text = "Chat doctors, visit hospitals, buy healthcare products, check BMI and update info" &
    "rmation about healthcare, all can be done here!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 34)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Complete Health Solution"
        '
        'lblAboutus
        '
        Me.lblAboutus.AutoSize = True
        Me.lblAboutus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAboutus.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutus.Location = New System.Drawing.Point(1002, 34)
        Me.lblAboutus.Name = "lblAboutus"
        Me.lblAboutus.Size = New System.Drawing.Size(159, 34)
        Me.lblAboutus.TabIndex = 18
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
        Me.lblLogout.TabIndex = 17
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
        Me.btnLogout.TabIndex = 16
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
        Me.PictureBox1.TabIndex = 15
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
        Me.lblPharmacy.TabIndex = 14
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
        Me.lblHealthsupport.TabIndex = 13
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
        Me.lblArticles.TabIndex = 12
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
        Me.lblProfile.TabIndex = 11
        Me.lblProfile.Text = "Profile"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1186, 541)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAboutus)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPharmacy)
        Me.Controls.Add(Me.lblHealthsupport)
        Me.Controls.Add(Me.lblArticles)
        Me.Controls.Add(Me.lblProfile)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDesc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAboutus As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPharmacy As Label
    Friend WithEvents lblHealthsupport As Label
    Friend WithEvents lblArticles As Label
    Friend WithEvents lblProfile As Label
End Class
