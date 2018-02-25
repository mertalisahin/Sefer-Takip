<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mazottakip
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
        Dim SEFERSAYISI_Label As System.Windows.Forms.Label
        Dim ARAC_PLAKALabel As System.Windows.Forms.Label
        Dim SOFOR_ADSOYADLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SefertakipDataSet = New Sefer_Takip.sefertakipDataSet()
        Me.SEFERLERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEFERLERTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.SEFERLERTableAdapter()
        Me.TableAdapterManager = New Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kaydet1 = New System.Windows.Forms.Button()
        Me.DOKUMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SANTIYELERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARAC_PLAKAComboBox = New System.Windows.Forms.ComboBox()
        Me.ARACLARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOFOR_ADSOYADComboBox = New System.Windows.Forms.ComboBox()
        Me.SOFORLERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TARIH_Label = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SOFORLERTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.SOFORLERTableAdapter()
        Me.ARACLARTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.ARACLARTableAdapter()
        Me.SANTIYELERTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.SANTIYELERTableAdapter()
        Me.DOKUMTableAdapter = New Sefer_Takip.sefertakipDataSetTableAdapters.DOKUMTableAdapter()
        Me.duzenle = New System.Windows.Forms.Button()
        Me.yeni = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Kaydet2 = New System.Windows.Forms.Button()
        Me.vazgec = New System.Windows.Forms.Button()
        Me.kapat = New System.Windows.Forms.Button()
        Me.sil = New System.Windows.Forms.Button()
        Me.Bul = New System.Windows.Forms.Button()
        Me.ilk = New System.Windows.Forms.Button()
        Me.son = New System.Windows.Forms.Button()
        Me.bultextbox = New System.Windows.Forms.DateTimePicker()
        Me.bugun = New System.Windows.Forms.Button()
        Me.mazottutaritextbox = New System.Windows.Forms.TextBox()
        SEFERSAYISI_Label = New System.Windows.Forms.Label()
        ARAC_PLAKALabel = New System.Windows.Forms.Label()
        SOFOR_ADSOYADLabel = New System.Windows.Forms.Label()
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEFERLERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOKUMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANTIYELERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARACLARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOFORLERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEFERSAYISI_Label
        '
        SEFERSAYISI_Label.AutoSize = True
        SEFERSAYISI_Label.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SEFERSAYISI_Label.Location = New System.Drawing.Point(30, 218)
        SEFERSAYISI_Label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SEFERSAYISI_Label.Name = "SEFERSAYISI_Label"
        SEFERSAYISI_Label.Size = New System.Drawing.Size(113, 23)
        SEFERSAYISI_Label.TabIndex = 41
        SEFERSAYISI_Label.Text = "Mazot Tutarı"
        '
        'ARAC_PLAKALabel
        '
        ARAC_PLAKALabel.AutoSize = True
        ARAC_PLAKALabel.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ARAC_PLAKALabel.Location = New System.Drawing.Point(34, 166)
        ARAC_PLAKALabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        ARAC_PLAKALabel.Name = "ARAC_PLAKALabel"
        ARAC_PLAKALabel.Size = New System.Drawing.Size(80, 23)
        ARAC_PLAKALabel.TabIndex = 33
        ARAC_PLAKALabel.Text = "Plaka No"
        '
        'SOFOR_ADSOYADLabel
        '
        SOFOR_ADSOYADLabel.AutoSize = True
        SOFOR_ADSOYADLabel.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SOFOR_ADSOYADLabel.Location = New System.Drawing.Point(34, 102)
        SOFOR_ADSOYADLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SOFOR_ADSOYADLabel.Name = "SOFOR_ADSOYADLabel"
        SOFOR_ADSOYADLabel.Size = New System.Drawing.Size(83, 23)
        SOFOR_ADSOYADLabel.TabIndex = 32
        SOFOR_ADSOYADLabel.Text = "Şoför Adı"
        '
        'SefertakipDataSet
        '
        Me.SefertakipDataSet.DataSetName = "sefertakipDataSet"
        Me.SefertakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SEFERLERBindingSource
        '
        Me.SEFERLERBindingSource.DataMember = "SEFERLER"
        Me.SEFERLERBindingSource.DataSource = Me.SefertakipDataSet
        '
        'SEFERLERTableAdapter
        '
        Me.SEFERLERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARACLARTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DOKUMTableAdapter = Nothing
        Me.TableAdapterManager.SANTIYELERTableAdapter = Nothing
        Me.TableAdapterManager.SEFERLERTableAdapter = Me.SEFERLERTableAdapter
        Me.TableAdapterManager.SOFORLERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(368, 29)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(823, 704)
        Me.DataGridView1.TabIndex = 0
        '
        'Kaydet1
        '
        Me.Kaydet1.BackColor = System.Drawing.SystemColors.Control
        Me.Kaydet1.Location = New System.Drawing.Point(246, 493)
        Me.Kaydet1.Margin = New System.Windows.Forms.Padding(5)
        Me.Kaydet1.Name = "Kaydet1"
        Me.Kaydet1.Size = New System.Drawing.Size(103, 60)
        Me.Kaydet1.TabIndex = 42
        Me.Kaydet1.Text = "Kaydet"
        Me.Kaydet1.UseVisualStyleBackColor = False
        Me.Kaydet1.Visible = False
        '
        'DOKUMBindingSource
        '
        Me.DOKUMBindingSource.DataMember = "DOKUM"
        Me.DOKUMBindingSource.DataSource = Me.SefertakipDataSet
        '
        'SANTIYELERBindingSource
        '
        Me.SANTIYELERBindingSource.DataMember = "SANTIYELER"
        Me.SANTIYELERBindingSource.DataSource = Me.SefertakipDataSet
        '
        'ARAC_PLAKAComboBox
        '
        Me.ARAC_PLAKAComboBox.DataSource = Me.ARACLARBindingSource
        Me.ARAC_PLAKAComboBox.DisplayMember = "ARAC_PLAKA"
        Me.ARAC_PLAKAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ARAC_PLAKAComboBox.Enabled = False
        Me.ARAC_PLAKAComboBox.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ARAC_PLAKAComboBox.FormattingEnabled = True
        Me.ARAC_PLAKAComboBox.Location = New System.Drawing.Point(154, 166)
        Me.ARAC_PLAKAComboBox.Margin = New System.Windows.Forms.Padding(5)
        Me.ARAC_PLAKAComboBox.Name = "ARAC_PLAKAComboBox"
        Me.ARAC_PLAKAComboBox.Size = New System.Drawing.Size(177, 27)
        Me.ARAC_PLAKAComboBox.TabIndex = 35
        '
        'ARACLARBindingSource
        '
        Me.ARACLARBindingSource.DataMember = "ARACLAR"
        Me.ARACLARBindingSource.DataSource = Me.SefertakipDataSet
        '
        'SOFOR_ADSOYADComboBox
        '
        Me.SOFOR_ADSOYADComboBox.DataSource = Me.SOFORLERBindingSource
        Me.SOFOR_ADSOYADComboBox.DisplayMember = "SOFOR_ADSOYAD"
        Me.SOFOR_ADSOYADComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SOFOR_ADSOYADComboBox.Enabled = False
        Me.SOFOR_ADSOYADComboBox.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SOFOR_ADSOYADComboBox.FormattingEnabled = True
        Me.SOFOR_ADSOYADComboBox.Location = New System.Drawing.Point(154, 102)
        Me.SOFOR_ADSOYADComboBox.Margin = New System.Windows.Forms.Padding(5)
        Me.SOFOR_ADSOYADComboBox.Name = "SOFOR_ADSOYADComboBox"
        Me.SOFOR_ADSOYADComboBox.Size = New System.Drawing.Size(177, 27)
        Me.SOFOR_ADSOYADComboBox.TabIndex = 34
        '
        'SOFORLERBindingSource
        '
        Me.SOFORLERBindingSource.DataMember = "SOFORLER"
        Me.SOFORLERBindingSource.DataSource = Me.SefertakipDataSet
        '
        'TARIH_Label
        '
        Me.TARIH_Label.AutoSize = True
        Me.TARIH_Label.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TARIH_Label.Location = New System.Drawing.Point(34, 46)
        Me.TARIH_Label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TARIH_Label.Name = "TARIH_Label"
        Me.TARIH_Label.Size = New System.Drawing.Size(50, 23)
        Me.TARIH_Label.TabIndex = 31
        Me.TARIH_Label.Text = "Tarih"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(154, 44)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(177, 27)
        Me.DateTimePicker1.TabIndex = 30
        '
        'SOFORLERTableAdapter
        '
        Me.SOFORLERTableAdapter.ClearBeforeFill = True
        '
        'ARACLARTableAdapter
        '
        Me.ARACLARTableAdapter.ClearBeforeFill = True
        '
        'SANTIYELERTableAdapter
        '
        Me.SANTIYELERTableAdapter.ClearBeforeFill = True
        '
        'DOKUMTableAdapter
        '
        Me.DOKUMTableAdapter.ClearBeforeFill = True
        '
        'duzenle
        '
        Me.duzenle.BackColor = System.Drawing.SystemColors.Control
        Me.duzenle.Location = New System.Drawing.Point(130, 409)
        Me.duzenle.Margin = New System.Windows.Forms.Padding(5)
        Me.duzenle.Name = "duzenle"
        Me.duzenle.Size = New System.Drawing.Size(106, 60)
        Me.duzenle.TabIndex = 44
        Me.duzenle.Text = "Düzenle"
        Me.duzenle.UseVisualStyleBackColor = False
        '
        'yeni
        '
        Me.yeni.BackColor = System.Drawing.SystemColors.Control
        Me.yeni.Location = New System.Drawing.Point(14, 409)
        Me.yeni.Margin = New System.Windows.Forms.Padding(5)
        Me.yeni.Name = "yeni"
        Me.yeni.Size = New System.Drawing.Size(106, 60)
        Me.yeni.TabIndex = 45
        Me.yeni.Text = "Yeni"
        Me.yeni.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(31, 562)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(83, 26)
        Me.TextBox1.TabIndex = 46
        Me.TextBox1.Visible = False
        '
        'Kaydet2
        '
        Me.Kaydet2.BackColor = System.Drawing.SystemColors.Control
        Me.Kaydet2.Location = New System.Drawing.Point(246, 493)
        Me.Kaydet2.Margin = New System.Windows.Forms.Padding(5)
        Me.Kaydet2.Name = "Kaydet2"
        Me.Kaydet2.Size = New System.Drawing.Size(103, 60)
        Me.Kaydet2.TabIndex = 47
        Me.Kaydet2.Text = "Kaydet"
        Me.Kaydet2.UseVisualStyleBackColor = False
        Me.Kaydet2.Visible = False
        '
        'vazgec
        '
        Me.vazgec.BackColor = System.Drawing.SystemColors.Control
        Me.vazgec.Location = New System.Drawing.Point(133, 494)
        Me.vazgec.Margin = New System.Windows.Forms.Padding(5)
        Me.vazgec.Name = "vazgec"
        Me.vazgec.Size = New System.Drawing.Size(103, 60)
        Me.vazgec.TabIndex = 48
        Me.vazgec.Text = "Vazgeç"
        Me.vazgec.UseVisualStyleBackColor = False
        '
        'kapat
        '
        Me.kapat.BackColor = System.Drawing.SystemColors.Control
        Me.kapat.Location = New System.Drawing.Point(17, 494)
        Me.kapat.Margin = New System.Windows.Forms.Padding(5)
        Me.kapat.Name = "kapat"
        Me.kapat.Size = New System.Drawing.Size(103, 60)
        Me.kapat.TabIndex = 49
        Me.kapat.Text = "Kapat"
        Me.kapat.UseVisualStyleBackColor = False
        '
        'sil
        '
        Me.sil.BackColor = System.Drawing.SystemColors.Control
        Me.sil.Location = New System.Drawing.Point(246, 409)
        Me.sil.Margin = New System.Windows.Forms.Padding(5)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(103, 60)
        Me.sil.TabIndex = 50
        Me.sil.Text = "Sil"
        Me.sil.UseVisualStyleBackColor = False
        '
        'Bul
        '
        Me.Bul.BackColor = System.Drawing.SystemColors.Control
        Me.Bul.Location = New System.Drawing.Point(130, 701)
        Me.Bul.Margin = New System.Windows.Forms.Padding(5)
        Me.Bul.Name = "Bul"
        Me.Bul.Size = New System.Drawing.Size(103, 60)
        Me.Bul.TabIndex = 51
        Me.Bul.Text = "Tarihi Getir"
        Me.Bul.UseVisualStyleBackColor = False
        '
        'ilk
        '
        Me.ilk.BackColor = System.Drawing.SystemColors.Control
        Me.ilk.Location = New System.Drawing.Point(14, 594)
        Me.ilk.Margin = New System.Windows.Forms.Padding(5)
        Me.ilk.Name = "ilk"
        Me.ilk.Size = New System.Drawing.Size(106, 60)
        Me.ilk.TabIndex = 53
        Me.ilk.Text = "İlk Kayıt"
        Me.ilk.UseVisualStyleBackColor = False
        '
        'son
        '
        Me.son.BackColor = System.Drawing.SystemColors.Control
        Me.son.Location = New System.Drawing.Point(243, 594)
        Me.son.Margin = New System.Windows.Forms.Padding(5)
        Me.son.Name = "son"
        Me.son.Size = New System.Drawing.Size(106, 60)
        Me.son.TabIndex = 54
        Me.son.Text = "Son Kayıt"
        Me.son.UseVisualStyleBackColor = False
        '
        'bultextbox
        '
        Me.bultextbox.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.bultextbox.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.bultextbox.Location = New System.Drawing.Point(93, 664)
        Me.bultextbox.Margin = New System.Windows.Forms.Padding(5)
        Me.bultextbox.Name = "bultextbox"
        Me.bultextbox.Size = New System.Drawing.Size(177, 27)
        Me.bultextbox.TabIndex = 55
        '
        'bugun
        '
        Me.bugun.BackColor = System.Drawing.SystemColors.Control
        Me.bugun.Location = New System.Drawing.Point(130, 594)
        Me.bugun.Margin = New System.Windows.Forms.Padding(5)
        Me.bugun.Name = "bugun"
        Me.bugun.Size = New System.Drawing.Size(103, 60)
        Me.bugun.TabIndex = 56
        Me.bugun.Text = "Bugün"
        Me.bugun.UseVisualStyleBackColor = False
        '
        'mazottutaritextbox
        '
        Me.mazottutaritextbox.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.mazottutaritextbox.Location = New System.Drawing.Point(154, 218)
        Me.mazottutaritextbox.Name = "mazottutaritextbox"
        Me.mazottutaritextbox.Size = New System.Drawing.Size(177, 27)
        Me.mazottutaritextbox.TabIndex = 57
        '
        'mazottakip
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1205, 770)
        Me.ControlBox = False
        Me.Controls.Add(Me.mazottutaritextbox)
        Me.Controls.Add(Me.bugun)
        Me.Controls.Add(Me.bultextbox)
        Me.Controls.Add(Me.son)
        Me.Controls.Add(Me.ilk)
        Me.Controls.Add(Me.Bul)
        Me.Controls.Add(Me.sil)
        Me.Controls.Add(Me.kapat)
        Me.Controls.Add(Me.vazgec)
        Me.Controls.Add(Me.Kaydet2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.yeni)
        Me.Controls.Add(Me.duzenle)
        Me.Controls.Add(Me.Kaydet1)
        Me.Controls.Add(SEFERSAYISI_Label)
        Me.Controls.Add(ARAC_PLAKALabel)
        Me.Controls.Add(Me.ARAC_PLAKAComboBox)
        Me.Controls.Add(SOFOR_ADSOYADLabel)
        Me.Controls.Add(Me.SOFOR_ADSOYADComboBox)
        Me.Controls.Add(Me.TARIH_Label)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mazottakip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sefer Takibi"
        CType(Me.SefertakipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEFERLERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOKUMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANTIYELERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARACLARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOFORLERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SefertakipDataSet As Sefer_Takip.sefertakipDataSet
    Friend WithEvents SEFERLERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEFERLERTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.SEFERLERTableAdapter
    Friend WithEvents TableAdapterManager As Sefer_Takip.sefertakipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Kaydet1 As System.Windows.Forms.Button
    Friend WithEvents ARAC_PLAKAComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SOFOR_ADSOYADComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TARIH_Label As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SOFORLERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SOFORLERTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.SOFORLERTableAdapter
    Friend WithEvents ARACLARBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARACLARTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.ARACLARTableAdapter
    Friend WithEvents SANTIYELERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SANTIYELERTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.SANTIYELERTableAdapter
    Friend WithEvents DOKUMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DOKUMTableAdapter As Sefer_Takip.sefertakipDataSetTableAdapters.DOKUMTableAdapter
    Friend WithEvents duzenle As System.Windows.Forms.Button
    Friend WithEvents yeni As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Kaydet2 As System.Windows.Forms.Button
    Friend WithEvents vazgec As System.Windows.Forms.Button
    Friend WithEvents kapat As System.Windows.Forms.Button
    Friend WithEvents sil As System.Windows.Forms.Button
    Friend WithEvents Bul As System.Windows.Forms.Button
    Friend WithEvents ilk As System.Windows.Forms.Button
    Friend WithEvents son As System.Windows.Forms.Button
    Friend WithEvents bultextbox As System.Windows.Forms.DateTimePicker
    Friend WithEvents bugun As System.Windows.Forms.Button
    Friend WithEvents mazottutaritextbox As System.Windows.Forms.TextBox
End Class
