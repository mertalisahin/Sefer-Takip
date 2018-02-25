<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Santiye
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
        Dim SANTIYE_YERILabel As System.Windows.Forms.Label
        Dim SANTIYE_ADILabel As System.Windows.Forms.Label
        Dim SANTIYE_SORUMLULabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Santiye))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SANTIYELERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SefertakipDataSet = New Sefer_Takip.sefertakipDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.sil = New System.Windows.Forms.Button()
        Me.kaydet1 = New System.Windows.Forms.Button()
        Me.duzenle = New System.Windows.Forms.Button()
        Me.yeni = New System.Windows.Forms.Button()
        Me.kapat = New System.Windows.Forms.Button()
        Me.vazgec = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SANTIYELERTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.SANTIYELERTableAdapter()
        Me.TableAdapterManager = New Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager()
        Me.kaydet2 = New System.Windows.Forms.Button()
        SANTIYE_YERILabel = New System.Windows.Forms.Label()
        SANTIYE_ADILabel = New System.Windows.Forms.Label()
        SANTIYE_SORUMLULabel = New System.Windows.Forms.Label()
        CType(Me.SANTIYELERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SANTIYE_YERILabel
        '
        SANTIYE_YERILabel.AutoSize = True
        SANTIYE_YERILabel.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SANTIYE_YERILabel.Location = New System.Drawing.Point(14, 110)
        SANTIYE_YERILabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SANTIYE_YERILabel.Name = "SANTIYE_YERILabel"
        SANTIYE_YERILabel.Size = New System.Drawing.Size(102, 23)
        SANTIYE_YERILabel.TabIndex = 93
        SANTIYE_YERILabel.Text = "Şantiye Yeri"
        '
        'SANTIYE_ADILabel
        '
        SANTIYE_ADILabel.AutoSize = True
        SANTIYE_ADILabel.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SANTIYE_ADILabel.Location = New System.Drawing.Point(14, 46)
        SANTIYE_ADILabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SANTIYE_ADILabel.Name = "SANTIYE_ADILabel"
        SANTIYE_ADILabel.Size = New System.Drawing.Size(99, 23)
        SANTIYE_ADILabel.TabIndex = 92
        SANTIYE_ADILabel.Text = "Şantiye Adı"
        '
        'SANTIYE_SORUMLULabel
        '
        SANTIYE_SORUMLULabel.AutoSize = True
        SANTIYE_SORUMLULabel.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SANTIYE_SORUMLULabel.Location = New System.Drawing.Point(12, 170)
        SANTIYE_SORUMLULabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SANTIYE_SORUMLULabel.Name = "SANTIYE_SORUMLULabel"
        SANTIYE_SORUMLULabel.Size = New System.Drawing.Size(155, 23)
        SANTIYE_SORUMLULabel.TabIndex = 102
        SANTIYE_SORUMLULabel.Text = "Şantiye Sorumlusu"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SANTIYELERBindingSource, "SANTIYE_YERI", True))
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextBox2.Location = New System.Drawing.Point(191, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(177, 27)
        Me.TextBox2.TabIndex = 101
        '
        'SANTIYELERBindingSource
        '
        Me.SANTIYELERBindingSource.DataMember = "SANTIYELER"
        Me.SANTIYELERBindingSource.DataSource = Me.SefertakipDataSet
        '
        'SefertakipDataSet
        '
        Me.SefertakipDataSet.DataSetName = "sefertakipDataSet"
        Me.SefertakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SANTIYELERBindingSource, "SANTIYE_ADI", True))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextBox1.Location = New System.Drawing.Point(191, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(177, 27)
        Me.TextBox1.TabIndex = 100
        '
        'sil
        '
        Me.sil.BackColor = System.Drawing.SystemColors.Control
        Me.sil.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sil.Location = New System.Drawing.Point(245, 309)
        Me.sil.Margin = New System.Windows.Forms.Padding(5)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(97, 49)
        Me.sil.TabIndex = 99
        Me.sil.Text = "Sil"
        Me.sil.UseVisualStyleBackColor = False
        '
        'kaydet1
        '
        Me.kaydet1.BackColor = System.Drawing.SystemColors.Control
        Me.kaydet1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kaydet1.Location = New System.Drawing.Point(245, 378)
        Me.kaydet1.Margin = New System.Windows.Forms.Padding(5)
        Me.kaydet1.Name = "kaydet1"
        Me.kaydet1.Size = New System.Drawing.Size(97, 52)
        Me.kaydet1.TabIndex = 98
        Me.kaydet1.Text = "Kaydet"
        Me.kaydet1.UseVisualStyleBackColor = False
        Me.kaydet1.Visible = False
        '
        'duzenle
        '
        Me.duzenle.BackColor = System.Drawing.SystemColors.Control
        Me.duzenle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.duzenle.Location = New System.Drawing.Point(138, 309)
        Me.duzenle.Margin = New System.Windows.Forms.Padding(5)
        Me.duzenle.Name = "duzenle"
        Me.duzenle.Size = New System.Drawing.Size(97, 49)
        Me.duzenle.TabIndex = 97
        Me.duzenle.Text = "Düzenle"
        Me.duzenle.UseVisualStyleBackColor = False
        '
        'yeni
        '
        Me.yeni.BackColor = System.Drawing.SystemColors.Control
        Me.yeni.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.yeni.Location = New System.Drawing.Point(36, 309)
        Me.yeni.Margin = New System.Windows.Forms.Padding(5)
        Me.yeni.Name = "yeni"
        Me.yeni.Size = New System.Drawing.Size(92, 49)
        Me.yeni.TabIndex = 96
        Me.yeni.Text = "Yeni"
        Me.yeni.UseVisualStyleBackColor = False
        '
        'kapat
        '
        Me.kapat.BackColor = System.Drawing.SystemColors.Control
        Me.kapat.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kapat.Location = New System.Drawing.Point(36, 378)
        Me.kapat.Margin = New System.Windows.Forms.Padding(5)
        Me.kapat.Name = "kapat"
        Me.kapat.Size = New System.Drawing.Size(95, 52)
        Me.kapat.TabIndex = 95
        Me.kapat.Text = "Kapat"
        Me.kapat.UseVisualStyleBackColor = False
        '
        'vazgec
        '
        Me.vazgec.BackColor = System.Drawing.SystemColors.Control
        Me.vazgec.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vazgec.Location = New System.Drawing.Point(138, 378)
        Me.vazgec.Margin = New System.Windows.Forms.Padding(5)
        Me.vazgec.Name = "vazgec"
        Me.vazgec.Size = New System.Drawing.Size(97, 52)
        Me.vazgec.TabIndex = 94
        Me.vazgec.Text = "Vazgeç"
        Me.vazgec.UseVisualStyleBackColor = False
        Me.vazgec.Visible = False
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
        Me.DataGridView1.Location = New System.Drawing.Point(376, 46)
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
        Me.DataGridView1.Size = New System.Drawing.Size(833, 604)
        Me.DataGridView1.TabIndex = 91
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SANTIYELERBindingSource, "SANTIYE_SORUMLU", True))
        Me.TextBox3.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextBox3.Location = New System.Drawing.Point(191, 170)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(177, 27)
        Me.TextBox3.TabIndex = 103
        '
        'SANTIYELERTableAdapter
        '
        Me.SANTIYELERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARACLARTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DOKUMTableAdapter = Nothing
        Me.TableAdapterManager.SANTIYELERTableAdapter = Me.SANTIYELERTableAdapter
        Me.TableAdapterManager.SEFERLERTableAdapter = Nothing
        Me.TableAdapterManager.SOFORLERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'kaydet2
        '
        Me.kaydet2.BackColor = System.Drawing.SystemColors.Control
        Me.kaydet2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kaydet2.Location = New System.Drawing.Point(245, 378)
        Me.kaydet2.Margin = New System.Windows.Forms.Padding(5)
        Me.kaydet2.Name = "kaydet2"
        Me.kaydet2.Size = New System.Drawing.Size(97, 52)
        Me.kaydet2.TabIndex = 104
        Me.kaydet2.Text = "Kaydet"
        Me.kaydet2.UseVisualStyleBackColor = False
        Me.kaydet2.Visible = False
        '
        'Santiye
        '
        Me.AcceptButton = Me.kaydet1
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.kaydet2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(SANTIYE_SORUMLULabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.sil)
        Me.Controls.Add(Me.kaydet1)
        Me.Controls.Add(Me.duzenle)
        Me.Controls.Add(Me.yeni)
        Me.Controls.Add(Me.kapat)
        Me.Controls.Add(Me.vazgec)
        Me.Controls.Add(SANTIYE_YERILabel)
        Me.Controls.Add(SANTIYE_ADILabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Santiye"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Şantiyeler"
        CType(Me.SANTIYELERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents sil As System.Windows.Forms.Button
    Friend WithEvents kaydet1 As System.Windows.Forms.Button
    Friend WithEvents duzenle As System.Windows.Forms.Button
    Friend WithEvents yeni As System.Windows.Forms.Button
    Friend WithEvents kapat As System.Windows.Forms.Button
    Friend WithEvents vazgec As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents SefertakipDataSet As Sefer_Takip.sefertakipDataSet
    Friend WithEvents SANTIYELERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SANTIYELERTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.SANTIYELERTableAdapter
    Friend WithEvents TableAdapterManager As Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents kaydet2 As System.Windows.Forms.Button
End Class
