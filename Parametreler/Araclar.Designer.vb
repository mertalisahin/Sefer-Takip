<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Araclar
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
        Dim SOFOR_ADSOYADLabel As System.Windows.Forms.Label
        Dim ARAC_PLAKALabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Araclar))
        Me.sil = New System.Windows.Forms.Button()
        Me.kaydet1 = New System.Windows.Forms.Button()
        Me.duzenle = New System.Windows.Forms.Button()
        Me.yeni = New System.Windows.Forms.Button()
        Me.kapat = New System.Windows.Forms.Button()
        Me.vazgec = New System.Windows.Forms.Button()
        Me.SefertakipDataSet1 = New Sefer_Takip.sefertakipDataSet1()
        Me.ARACLARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARACLARTableAdapter = New Sefer_Takip.sefertakipDataSet1TableAdapters.ARACLARTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ARACLARBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SefertakipDataSet = New Sefer_Takip.sefertakipDataSet()
        Me.ARACLARTableAdapter1 = New Sefer_Takip.sefertakipDataSetTableAdapters.ARACLARTableAdapter()
        Me.TableAdapterManager = New Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.kaydet2 = New System.Windows.Forms.Button()
        SOFOR_ADSOYADLabel = New System.Windows.Forms.Label()
        ARAC_PLAKALabel = New System.Windows.Forms.Label()
        CType(Me.SefertakipDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARACLARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARACLARBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SOFOR_ADSOYADLabel
        '
        SOFOR_ADSOYADLabel.AutoSize = True
        SOFOR_ADSOYADLabel.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SOFOR_ADSOYADLabel.Location = New System.Drawing.Point(20, 46)
        SOFOR_ADSOYADLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SOFOR_ADSOYADLabel.Name = "SOFOR_ADSOYADLabel"
        SOFOR_ADSOYADLabel.Size = New System.Drawing.Size(88, 23)
        SOFOR_ADSOYADLabel.TabIndex = 72
        SOFOR_ADSOYADLabel.Text = "Araç Cinsi"
        '
        'ARAC_PLAKALabel
        '
        ARAC_PLAKALabel.AutoSize = True
        ARAC_PLAKALabel.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ARAC_PLAKALabel.Location = New System.Drawing.Point(20, 110)
        ARAC_PLAKALabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ARAC_PLAKALabel.Name = "ARAC_PLAKALabel"
        ARAC_PLAKALabel.Size = New System.Drawing.Size(80, 23)
        ARAC_PLAKALabel.TabIndex = 73
        ARAC_PLAKALabel.Text = "Plaka No"
        '
        'sil
        '
        Me.sil.BackColor = System.Drawing.SystemColors.Control
        Me.sil.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sil.Location = New System.Drawing.Point(220, 387)
        Me.sil.Margin = New System.Windows.Forms.Padding(5)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(97, 49)
        Me.sil.TabIndex = 87
        Me.sil.Text = "Sil"
        Me.sil.UseVisualStyleBackColor = False
        '
        'kaydet1
        '
        Me.kaydet1.BackColor = System.Drawing.SystemColors.Control
        Me.kaydet1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kaydet1.Location = New System.Drawing.Point(220, 456)
        Me.kaydet1.Margin = New System.Windows.Forms.Padding(5)
        Me.kaydet1.Name = "kaydet1"
        Me.kaydet1.Size = New System.Drawing.Size(97, 52)
        Me.kaydet1.TabIndex = 86
        Me.kaydet1.Text = "Kaydet"
        Me.kaydet1.UseVisualStyleBackColor = False
        Me.kaydet1.Visible = False
        '
        'duzenle
        '
        Me.duzenle.BackColor = System.Drawing.SystemColors.Control
        Me.duzenle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.duzenle.Location = New System.Drawing.Point(113, 387)
        Me.duzenle.Margin = New System.Windows.Forms.Padding(5)
        Me.duzenle.Name = "duzenle"
        Me.duzenle.Size = New System.Drawing.Size(97, 49)
        Me.duzenle.TabIndex = 85
        Me.duzenle.Text = "Düzenle"
        Me.duzenle.UseVisualStyleBackColor = False
        '
        'yeni
        '
        Me.yeni.BackColor = System.Drawing.SystemColors.Control
        Me.yeni.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.yeni.Location = New System.Drawing.Point(11, 387)
        Me.yeni.Margin = New System.Windows.Forms.Padding(5)
        Me.yeni.Name = "yeni"
        Me.yeni.Size = New System.Drawing.Size(92, 49)
        Me.yeni.TabIndex = 84
        Me.yeni.Text = "Yeni"
        Me.yeni.UseVisualStyleBackColor = False
        '
        'kapat
        '
        Me.kapat.BackColor = System.Drawing.SystemColors.Control
        Me.kapat.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kapat.Location = New System.Drawing.Point(11, 456)
        Me.kapat.Margin = New System.Windows.Forms.Padding(5)
        Me.kapat.Name = "kapat"
        Me.kapat.Size = New System.Drawing.Size(95, 52)
        Me.kapat.TabIndex = 83
        Me.kapat.Text = "Kapat"
        Me.kapat.UseVisualStyleBackColor = False
        '
        'vazgec
        '
        Me.vazgec.BackColor = System.Drawing.SystemColors.Control
        Me.vazgec.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vazgec.Location = New System.Drawing.Point(113, 456)
        Me.vazgec.Margin = New System.Windows.Forms.Padding(5)
        Me.vazgec.Name = "vazgec"
        Me.vazgec.Size = New System.Drawing.Size(97, 52)
        Me.vazgec.TabIndex = 82
        Me.vazgec.Text = "Vazgeç"
        Me.vazgec.UseVisualStyleBackColor = False
        Me.vazgec.Visible = False
        '
        'SefertakipDataSet1
        '
        Me.SefertakipDataSet1.DataSetName = "sefertakipDataSet1"
        Me.SefertakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARACLARBindingSource
        '
        Me.ARACLARBindingSource.DataMember = "ARACLAR"
        Me.ARACLARBindingSource.DataSource = Me.SefertakipDataSet1
        '
        'ARACLARTableAdapter
        '
        Me.ARACLARTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(327, 46)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(874, 617)
        Me.DataGridView1.TabIndex = 69
        '
        'ARACLARBindingSource1
        '
        Me.ARACLARBindingSource1.DataMember = "ARACLAR"
        Me.ARACLARBindingSource1.DataSource = Me.SefertakipDataSet
        '
        'SefertakipDataSet
        '
        Me.SefertakipDataSet.DataSetName = "sefertakipDataSet"
        Me.SefertakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARACLARTableAdapter1
        '
        Me.ARACLARTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARACLARTableAdapter = Me.ARACLARTableAdapter1
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DOKUMTableAdapter = Nothing
        Me.TableAdapterManager.SANTIYELERTableAdapter = Nothing
        Me.TableAdapterManager.SEFERLERTableAdapter = Nothing
        Me.TableAdapterManager.SOFORLERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextBox1.Location = New System.Drawing.Point(140, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(177, 27)
        Me.TextBox1.TabIndex = 89
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextBox2.Location = New System.Drawing.Point(140, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(177, 27)
        Me.TextBox2.TabIndex = 90
        '
        'kaydet2
        '
        Me.kaydet2.BackColor = System.Drawing.SystemColors.Control
        Me.kaydet2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kaydet2.Location = New System.Drawing.Point(220, 456)
        Me.kaydet2.Margin = New System.Windows.Forms.Padding(5)
        Me.kaydet2.Name = "kaydet2"
        Me.kaydet2.Size = New System.Drawing.Size(97, 52)
        Me.kaydet2.TabIndex = 91
        Me.kaydet2.Text = "Kaydet"
        Me.kaydet2.UseVisualStyleBackColor = False
        Me.kaydet2.Visible = False
        '
        'Araclar
        '
        Me.AcceptButton = Me.kaydet1
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1209, 695)
        Me.ControlBox = False
        Me.Controls.Add(Me.kaydet2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.sil)
        Me.Controls.Add(Me.kaydet1)
        Me.Controls.Add(Me.duzenle)
        Me.Controls.Add(Me.yeni)
        Me.Controls.Add(Me.kapat)
        Me.Controls.Add(Me.vazgec)
        Me.Controls.Add(ARAC_PLAKALabel)
        Me.Controls.Add(SOFOR_ADSOYADLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Araclar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Araçlar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SefertakipDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARACLARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARACLARBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sil As System.Windows.Forms.Button
    Friend WithEvents kaydet1 As System.Windows.Forms.Button
    Friend WithEvents duzenle As System.Windows.Forms.Button
    Friend WithEvents yeni As System.Windows.Forms.Button
    Friend WithEvents kapat As System.Windows.Forms.Button
    Friend WithEvents vazgec As System.Windows.Forms.Button
    Friend WithEvents SefertakipDataSet1 As Sefer_Takip.sefertakipDataSet1
    Friend WithEvents ARACLARBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARACLARTableAdapter As Sefer_Takip.sefertakipDataSet1TableAdapters.ARACLARTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SefertakipDataSet As Sefer_Takip.sefertakipDataSet
    Friend WithEvents ARACLARBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ARACLARTableAdapter1 As Sefer_Takip.sefertakipDataSetTableAdapters.ARACLARTableAdapter
    Friend WithEvents TableAdapterManager As Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents kaydet2 As System.Windows.Forms.Button
End Class
