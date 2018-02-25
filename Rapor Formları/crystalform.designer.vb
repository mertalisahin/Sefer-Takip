<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crystalform
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
        Dim İlgili_UstaLabel As System.Windows.Forms.Label
        Dim Geliş_Tarihi_2Label As System.Windows.Forms.Label
        Dim Geliş_TarihiLabel As System.Windows.Forms.Label
        Dim SantiyeLabel As System.Windows.Forms.Label
        Dim PlakaLabel As System.Windows.Forms.Label
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SoforComboBox = New System.Windows.Forms.ComboBox()
        Me.SOFORLERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SefertakipDataSet = New Sefer_Takip.sefertakipDataSet()
        Me.Geliş_Tarihi_2DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Geliş_TarihiDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SantiyeComboBox = New System.Windows.Forms.ComboBox()
        Me.SANTIYELERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlakaComboBox = New System.Windows.Forms.ComboBox()
        Me.ARACLARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARACLARTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.ARACLARTableAdapter()
        Me.SOFORLERTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.SOFORLERTableAdapter()
        Me.SANTIYELERTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.SANTIYELERTableAdapter()
        İlgili_UstaLabel = New System.Windows.Forms.Label()
        Geliş_Tarihi_2Label = New System.Windows.Forms.Label()
        Geliş_TarihiLabel = New System.Windows.Forms.Label()
        SantiyeLabel = New System.Windows.Forms.Label()
        PlakaLabel = New System.Windows.Forms.Label()
        CType(Me.SOFORLERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANTIYELERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARACLARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'İlgili_UstaLabel
        '
        İlgili_UstaLabel.AutoSize = True
        İlgili_UstaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        İlgili_UstaLabel.Location = New System.Drawing.Point(57, 46)
        İlgili_UstaLabel.Name = "İlgili_UstaLabel"
        İlgili_UstaLabel.Size = New System.Drawing.Size(45, 15)
        İlgili_UstaLabel.TabIndex = 24
        İlgili_UstaLabel.Text = "Şoför:"
        '
        'Geliş_Tarihi_2Label
        '
        Geliş_Tarihi_2Label.AutoSize = True
        Geliş_Tarihi_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Geliş_Tarihi_2Label.Location = New System.Drawing.Point(11, 140)
        Geliş_Tarihi_2Label.Name = "Geliş_Tarihi_2Label"
        Geliş_Tarihi_2Label.Size = New System.Drawing.Size(97, 15)
        Geliş_Tarihi_2Label.TabIndex = 22
        Geliş_Tarihi_2Label.Text = "Geliş Tarihi 2:"
        '
        'Geliş_TarihiLabel
        '
        Geliş_TarihiLabel.AutoSize = True
        Geliş_TarihiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Geliş_TarihiLabel.Location = New System.Drawing.Point(20, 112)
        Geliş_TarihiLabel.Name = "Geliş_TarihiLabel"
        Geliş_TarihiLabel.Size = New System.Drawing.Size(85, 15)
        Geliş_TarihiLabel.TabIndex = 20
        Geliş_TarihiLabel.Text = "Geliş Tarihi:"
        '
        'SantiyeLabel
        '
        SantiyeLabel.AutoSize = True
        SantiyeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SantiyeLabel.Location = New System.Drawing.Point(47, 75)
        SantiyeLabel.Name = "SantiyeLabel"
        SantiyeLabel.Size = New System.Drawing.Size(58, 15)
        SantiyeLabel.TabIndex = 18
        SantiyeLabel.Text = "Şantiye:"
        '
        'PlakaLabel
        '
        PlakaLabel.AutoSize = True
        PlakaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PlakaLabel.Location = New System.Drawing.Point(309, 46)
        PlakaLabel.Name = "PlakaLabel"
        PlakaLabel.Size = New System.Drawing.Size(47, 15)
        PlakaLabel.TabIndex = 16
        PlakaLabel.Text = "Plaka:"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(362, 69)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(63, 19)
        Me.CheckBox3.TabIndex = 30
        Me.CheckBox3.Text = "Hepsi"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(236, 74)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(63, 19)
        Me.CheckBox2.TabIndex = 29
        Me.CheckBox2.Text = "Hepsi"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(236, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(63, 19)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Hepsi"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(440, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Göster"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Filitre Seçiniz"
        '
        'SoforComboBox
        '
        Me.SoforComboBox.DataSource = Me.SOFORLERBindingSource
        Me.SoforComboBox.DisplayMember = "SOFOR_ADSOYAD"
        Me.SoforComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SoforComboBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SoforComboBox.FormattingEnabled = True
        Me.SoforComboBox.Location = New System.Drawing.Point(108, 45)
        Me.SoforComboBox.Name = "SoforComboBox"
        Me.SoforComboBox.Size = New System.Drawing.Size(121, 22)
        Me.SoforComboBox.TabIndex = 25
        '
        'SOFORLERBindingSource
        '
        Me.SOFORLERBindingSource.DataMember = "SOFORLER"
        Me.SOFORLERBindingSource.DataSource = Me.SefertakipDataSet
        '
        'SefertakipDataSet
        '
        Me.SefertakipDataSet.DataSetName = "sefertakipDataSet"
        Me.SefertakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Geliş_Tarihi_2DateTimePicker
        '
        Me.Geliş_Tarihi_2DateTimePicker.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Geliş_Tarihi_2DateTimePicker.Location = New System.Drawing.Point(108, 140)
        Me.Geliş_Tarihi_2DateTimePicker.Name = "Geliş_Tarihi_2DateTimePicker"
        Me.Geliş_Tarihi_2DateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Geliş_Tarihi_2DateTimePicker.TabIndex = 23
        Me.Geliş_Tarihi_2DateTimePicker.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'Geliş_TarihiDateTimePicker
        '
        Me.Geliş_TarihiDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Geliş_TarihiDateTimePicker.Location = New System.Drawing.Point(108, 110)
        Me.Geliş_TarihiDateTimePicker.Name = "Geliş_TarihiDateTimePicker"
        Me.Geliş_TarihiDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Geliş_TarihiDateTimePicker.TabIndex = 21
        Me.Geliş_TarihiDateTimePicker.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'SantiyeComboBox
        '
        Me.SantiyeComboBox.DataSource = Me.SANTIYELERBindingSource
        Me.SantiyeComboBox.DisplayMember = "SANTIYE_ADI"
        Me.SantiyeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SantiyeComboBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SantiyeComboBox.FormattingEnabled = True
        Me.SantiyeComboBox.Location = New System.Drawing.Point(108, 72)
        Me.SantiyeComboBox.Name = "SantiyeComboBox"
        Me.SantiyeComboBox.Size = New System.Drawing.Size(121, 22)
        Me.SantiyeComboBox.TabIndex = 19
        '
        'SANTIYELERBindingSource
        '
        Me.SANTIYELERBindingSource.DataMember = "SANTIYELER"
        Me.SANTIYELERBindingSource.DataSource = Me.SefertakipDataSet
        '
        'PlakaComboBox
        '
        Me.PlakaComboBox.DataSource = Me.ARACLARBindingSource
        Me.PlakaComboBox.DisplayMember = "ARAC_PLAKA"
        Me.PlakaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlakaComboBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PlakaComboBox.FormattingEnabled = True
        Me.PlakaComboBox.Location = New System.Drawing.Point(362, 43)
        Me.PlakaComboBox.Name = "PlakaComboBox"
        Me.PlakaComboBox.Size = New System.Drawing.Size(169, 22)
        Me.PlakaComboBox.TabIndex = 17
        '
        'ARACLARBindingSource
        '
        Me.ARACLARBindingSource.DataMember = "ARACLAR"
        Me.ARACLARBindingSource.DataSource = Me.SefertakipDataSet
        '
        'ARACLARTableAdapter
        '
        Me.ARACLARTableAdapter.ClearBeforeFill = True
        '
        'SOFORLERTableAdapter
        '
        Me.SOFORLERTableAdapter.ClearBeforeFill = True
        '
        'SANTIYELERTableAdapter
        '
        Me.SANTIYELERTableAdapter.ClearBeforeFill = True
        '
        'crystalform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 177)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(İlgili_UstaLabel)
        Me.Controls.Add(Me.SoforComboBox)
        Me.Controls.Add(Geliş_Tarihi_2Label)
        Me.Controls.Add(Me.Geliş_Tarihi_2DateTimePicker)
        Me.Controls.Add(Geliş_TarihiLabel)
        Me.Controls.Add(Me.Geliş_TarihiDateTimePicker)
        Me.Controls.Add(SantiyeLabel)
        Me.Controls.Add(Me.SantiyeComboBox)
        Me.Controls.Add(PlakaLabel)
        Me.Controls.Add(Me.PlakaComboBox)
        Me.Name = "crystalform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "crystalform"
        CType(Me.SOFORLERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANTIYELERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARACLARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SoforComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Geliş_Tarihi_2DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Geliş_TarihiDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SantiyeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlakaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SefertakipDataSet As Sefer_Takip.sefertakipDataSet
    Friend WithEvents ARACLARBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARACLARTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.ARACLARTableAdapter
    Friend WithEvents SOFORLERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SOFORLERTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.SOFORLERTableAdapter
    Friend WithEvents SANTIYELERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SANTIYELERTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.SANTIYELERTableAdapter
End Class
