<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMICalculator
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMICalculator))
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btnResetBMI = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnCheckBMI = New System.Windows.Forms.Button()
        Me.lblAboutus = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPharmacy = New System.Windows.Forms.Label()
        Me.lblHealthsupport = New System.Windows.Forms.Label()
        Me.lblArticles = New System.Windows.Forms.Label()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DHDatabaseDataSet = New Healthcare_.DHDatabaseDataSet()
        Me.BMIStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BMI_StatusTableAdapter = New Healthcare_.DHDatabaseDataSetTableAdapters.BMI_StatusTableAdapter()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BMIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BMIAgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BMI_AgeTableAdapter = New Healthcare_.DHDatabaseDataSetTableAdapters.BMI_AgeTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DHDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BMIStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BMIAgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(333, 307)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(125, 27)
        Me.txtResult.TabIndex = 87
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(333, 229)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(125, 27)
        Me.txtHeight.TabIndex = 86
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(333, 169)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(125, 27)
        Me.txtWeight.TabIndex = 85
        '
        'btnResetBMI
        '
        Me.btnResetBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetBMI.Location = New System.Drawing.Point(330, 390)
        Me.btnResetBMI.Name = "btnResetBMI"
        Me.btnResetBMI.Size = New System.Drawing.Size(128, 46)
        Me.btnResetBMI.TabIndex = 84
        Me.btnResetBMI.Text = "Reset BMI"
        Me.btnResetBMI.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 27)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "BMI Result:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 27)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Enter Your Height (M):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 27)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Enter Your Weight (KG):"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHeader.Font = New System.Drawing.Font("Lucida Bright", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(485, 95)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(284, 31)
        Me.lblHeader.TabIndex = 80
        Me.lblHeader.Text = "Calculate Your BMI"
        '
        'btnCheckBMI
        '
        Me.btnCheckBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckBMI.Location = New System.Drawing.Point(67, 390)
        Me.btnCheckBMI.Name = "btnCheckBMI"
        Me.btnCheckBMI.Size = New System.Drawing.Size(128, 46)
        Me.btnCheckBMI.TabIndex = 79
        Me.btnCheckBMI.Text = "Check BMI"
        Me.btnCheckBMI.UseVisualStyleBackColor = True
        '
        'lblAboutus
        '
        Me.lblAboutus.AutoSize = True
        Me.lblAboutus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAboutus.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutus.Location = New System.Drawing.Point(1002, 34)
        Me.lblAboutus.Name = "lblAboutus"
        Me.lblAboutus.Size = New System.Drawing.Size(159, 34)
        Me.lblAboutus.TabIndex = 78
        Me.lblAboutus.Text = "About Us"
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1056, 413)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 91)
        Me.btnLogout.TabIndex = 77
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
        Me.PictureBox1.TabIndex = 76
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
        Me.lblPharmacy.TabIndex = 75
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
        Me.lblHealthsupport.TabIndex = 74
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
        Me.lblArticles.TabIndex = 73
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
        Me.lblProfile.TabIndex = 72
        Me.lblProfile.Text = "Profile"
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.BackColor = System.Drawing.Color.Transparent
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Location = New System.Drawing.Point(1073, 507)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(78, 25)
        Me.lblLogout.TabIndex = 88
        Me.lblLogout.Text = "Logout"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatusDataGridViewTextBoxColumn, Me.BMIDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BMIStatusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(613, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(304, 212)
        Me.DataGridView1.TabIndex = 89
        '
        'DHDatabaseDataSet
        '
        Me.DHDatabaseDataSet.DataSetName = "DHDatabaseDataSet"
        Me.DHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BMIStatusBindingSource
        '
        Me.BMIStatusBindingSource.DataMember = "BMI_Status"
        Me.BMIStatusBindingSource.DataSource = Me.DHDatabaseDataSet
        '
        'BMI_StatusTableAdapter
        '
        Me.BMI_StatusTableAdapter.ClearBeforeFill = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 125
        '
        'BMIDataGridViewTextBoxColumn
        '
        Me.BMIDataGridViewTextBoxColumn.DataPropertyName = "BMI"
        Me.BMIDataGridViewTextBoxColumn.HeaderText = "BMI"
        Me.BMIDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BMIDataGridViewTextBoxColumn.Name = "BMIDataGridViewTextBoxColumn"
        Me.BMIDataGridViewTextBoxColumn.ReadOnly = True
        Me.BMIDataGridViewTextBoxColumn.Width = 125
        '
        'BMIAgeBindingSource
        '
        Me.BMIAgeBindingSource.DataMember = "BMI_Age"
        Me.BMIAgeBindingSource.DataSource = Me.DHDatabaseDataSet
        '
        'BMI_AgeTableAdapter
        '
        Me.BMI_AgeTableAdapter.ClearBeforeFill = True
        '
        'BMICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1186, 541)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.btnResetBMI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnCheckBMI)
        Me.Controls.Add(Me.lblAboutus)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPharmacy)
        Me.Controls.Add(Me.lblHealthsupport)
        Me.Controls.Add(Me.lblArticles)
        Me.Controls.Add(Me.lblProfile)
        Me.Name = "BMICalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMICalculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DHDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BMIStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BMIAgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btnResetBMI As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnCheckBMI As Button
    Friend WithEvents lblAboutus As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPharmacy As Label
    Friend WithEvents lblHealthsupport As Label
    Friend WithEvents lblArticles As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DHDatabaseDataSet As DHDatabaseDataSet
    Friend WithEvents BMIStatusBindingSource As BindingSource
    Friend WithEvents BMI_StatusTableAdapter As DHDatabaseDataSetTableAdapters.BMI_StatusTableAdapter
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BMIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BMIAgeBindingSource As BindingSource
    Friend WithEvents BMI_AgeTableAdapter As DHDatabaseDataSetTableAdapters.BMI_AgeTableAdapter
End Class
