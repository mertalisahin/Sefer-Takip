Imports System.Data
Imports System.Data.OleDb

Public Class SeferTakip
    Dim yol As String = "C:\Sefer Takip\sefertakip.accdb"
    Dim coon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & yol & "'")
    Dim tarih1, sofor1, plaka1, santiye1, dokum1, sql, sqlquery As String
    Dim sefersayi1 As Integer
    Dim Kimlik1 As Int32
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & yol & "'"
    Dim con As New OleDbConnection(conString)
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dt As New DataTable()


    Private Sub populate(Kimlik As Integer, TARIH As String, SOFOR As String, PLAKA As String, SANTIYE As String, DOKUM_SAHASI As String, SEFER_SAYISI As String)
        Dim row As String() = New String() {Kimlik, TARIH, SOFOR, PLAKA, SANTIYE, DOKUM_SAHASI, SEFER_SAYISI}


        DataGridView1.Rows.Add(row)


    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SOFOR_ADSOYADComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SefertakipDataSet.DOKUM' table. You can move, or remove it, as needed.
        Me.DOKUMTableAdapter.Fill(Me.SefertakipDataSet.DOKUM)
        'TODO: This line of code loads data into the 'SefertakipDataSet.SANTIYELER' table. You can move, or remove it, as needed.
        Me.SANTIYELERTableAdapter.Fill(Me.SefertakipDataSet.SANTIYELER)
        'TODO: This line of code loads data into the 'SefertakipDataSet.ARACLAR' table. You can move, or remove it, as needed.
        Me.ARACLARTableAdapter.Fill(Me.SefertakipDataSet.ARACLAR)
        'TODO: This line of code loads data into the 'SefertakipDataSet.SOFORLER' table. You can move, or remove it, as needed.
        Me.SOFORLERTableAdapter.Fill(Me.SefertakipDataSet.SOFORLER)
        'TODO: This line of code loads data into the 'SefertakipDataSet.SEFERLER' table. You can move, or remove it, as needed.
        Me.SEFERLERTableAdapter.Fill(Me.SefertakipDataSet.SEFERLER)

        DataGridView1.ColumnCount = 7
        DataGridView1.Columns(0).Name = "Kimlik"
        DataGridView1.Columns(1).Name = "Tarih"
        DataGridView1.Columns(2).Name = "Şoför"
        DataGridView1.Columns(3).Name = "Plaka No"
        DataGridView1.Columns(4).Name = "Şantiye Adı"
        DataGridView1.Columns(5).Name = "Döküm Adı"
        DataGridView1.Columns(6).Name = "Sefer Sayısı"
        'DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        SOFORLERBindingSource.Sort = "SOFOR_ADSOYAD ASC"
        ARACLARBindingSource.Sort = "ARAC_PLAKA ASC"
        DOKUMBindingSource.Sort = "DOKUM_ADI ASC"
        SANTIYELERBindingSource.Sort = "SANTIYE_ADI ASC"
        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter





        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        Retrieve2()

        Call items()


    End Sub
    Private Sub temizle()
        santiyecombobox()

        On Error Resume Next
        DateTimePicker1.Value = Date.Today
        ARAC_PLAKAComboBox.SelectedIndex = -1
        SOFOR_ADSOYADComboBox.SelectedIndex = -1
        SANTIYE_ADIComboBox.SelectedIndex = -1
        DOKUM_ADIComboBox.SelectedIndex = -1
        NumericUpDown1.Value = 0
        DataGridView1.Enabled = True




        yeni.Visible = True
        duzenle.Visible = True
        sil.Visible = True
        Kaydet1.Visible = False
        Kaydet2.Visible = False
        vazgec.Visible = False
        kapat.Visible = True
        Bul.Visible = True
        bultextbox.Visible = True
        ilk.Visible = True
        son.Visible = True
        bugun.Visible = True

        DateTimePicker1.Enabled = False
        ARAC_PLAKAComboBox.Enabled = False
        SOFOR_ADSOYADComboBox.Enabled = False
        SANTIYE_ADIComboBox.Enabled = False
        DOKUM_ADIComboBox.Enabled = False
        NumericUpDown1.Enabled = False
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
        Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Selected = True
    End Sub


    Private Sub temizle1()
        On Error Resume Next
        'DateTimePicker1.Value = Date.Today
        'ARAC_PLAKAComboBox.SelectedIndex = -1
        'SOFOR_ADSOYADComboBox.SelectedIndex = -1
        'SANTIYE_ADIComboBox.SelectedIndex = -1
        DOKUM_ADIComboBox.SelectedIndex = -1
        NumericUpDown1.Value = 0
        DataGridView1.Enabled = True

        yeni.Visible = True
        duzenle.Visible = True
        sil.Visible = True
        Kaydet1.Visible = False
        Kaydet2.Visible = False
        vazgec.Visible = False
        kapat.Visible = True
        Bul.Visible = True
        bultextbox.Visible = True
        ilk.Visible = True
        son.Visible = True
        bugun.Visible = True

        DateTimePicker1.Enabled = False
        ARAC_PLAKAComboBox.Enabled = False
        SOFOR_ADSOYADComboBox.Enabled = False
        SANTIYE_ADIComboBox.Enabled = False
        DOKUM_ADIComboBox.Enabled = False
        NumericUpDown1.Enabled = False

        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
        Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Selected = True
    End Sub
    Private Sub Retrieve()
        Dim bultarih As String = bultextbox.Text
        DataGridView1.Rows.Clear()

        Dim sql As String = "SELECT * FROM SEFERLER WHERE SEFER_TARIH =@sefertarih order by Kimlik "

        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@sefertarih", bultarih)
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)

            adapter.Fill(dt)

            For Each row In dt.Rows
                populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6))

            Next
            con.Close()
            dt.Rows.Clear()

        Catch ex As Exception

        End Try

        Call temizle()
    End Sub

    Private Sub Retrieve2()
        Dim bultarih As String = bultextbox.Text
        DataGridView1.Rows.Clear()

        Dim sql As String = "SELECT * FROM SEFERLER WHERE SEFER_TARIH =@sefertarih order by Kimlik "

        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@sefertarih", Date.Today.ToShortDateString)
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)

            adapter.Fill(dt)

            For Each row In dt.Rows
                populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6))

            Next
            con.Close()
            dt.Rows.Clear()

        Catch ex As Exception

        End Try

        Call temizle()
    End Sub


    Private Sub items()
        On Error Resume Next
        Dim Kimlik = DataGridView1.SelectedRows(0).Cells(0).Value
        Dim TARIH As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim SOFOR As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim PLAKA As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim SANTIYE As String = DataGridView1.SelectedRows(0).Cells(4).Value
        Dim DOKUMSAHASI As String = DataGridView1.SelectedRows(0).Cells(5).Value
        Dim SEFERSAYISI As String = DataGridView1.SelectedRows(0).Cells(6).Value



        DateTimePicker1.Text = TARIH
        SOFOR_ADSOYADComboBox.Text = SOFOR
        ARAC_PLAKAComboBox.Text = PLAKA
        SANTIYE_ADIComboBox.Text = SANTIYE
        DOKUM_ADIComboBox.Text = DOKUMSAHASI
        NumericUpDown1.Value = SEFERSAYISI
        TextBox1.Text = Kimlik
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Call items()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        sefertakipcrystal.Show()


    End Sub

    Private Sub kaydet1_Click(sender As Object, e As EventArgs) Handles Kaydet1.Click
        If NumericUpDown1.Value = 0 Or SOFOR_ADSOYADComboBox.Text = Nothing Or ARAC_PLAKAComboBox.Text = Nothing Or SANTIYE_ADIComboBox.Text = Nothing Or DOKUM_ADIComboBox.Text = Nothing Then
            MsgBox("Boş Alan Bırakmayınız")
            Beep()
            Exit Sub
        End If
        tarih1 = DateTimePicker1.Text
        sofor1 = SOFOR_ADSOYADComboBox.Text
        plaka1 = ARAC_PLAKAComboBox.Text
        santiye1 = SANTIYE_ADIComboBox.Text
        dokum1 = DOKUM_ADIComboBox.Text
        sefersayi1 = NumericUpDown1.Value
        Dim sql As String = "insert into SEFERLER (SEFER_TARIH,SEFER_SOFOR,SEFER_PLAKA,SEFER_SANTIYE,SEFER_DOKUM,SEFER_SAYI) VALUES ('" & tarih1 & "','" & sofor1 & "','" & plaka1 & "','" & santiye1 & "','" & dokum1 & "','" & sefersayi1 & "')"
        Dim sql2 As String = "select * from SEFERLER"
        Dim komut As New OleDbCommand(sql2, coon)

        coon.Open()


        komut.CommandText = sql
        komut.ExecuteNonQuery()
        coon.Close()
        Retrieve()
        temizle()
        items()
        MessageBox.Show("Bilgiler kaydedildi")
        Kaydet1.Visible = False
    End Sub


    Private Sub duzenle_Click(sender As Object, e As EventArgs) Handles duzenle.Click
        If IsNothing(Me.DataGridView1.CurrentRow) Then
            MsgBox("Bir Kayıt Seçiniz", MsgBoxStyle.Critical, "Uyarı")
            Beep()
            Exit Sub
        Else
            GoTo 2
        End If
2:      DataGridView1.Enabled = False
        vazgec.Visible = True
        kapat.Visible = False
        yeni.Visible = False
        duzenle.Visible = False
        sil.Visible = False
        Kaydet2.Visible = True
        Kaydet1.Visible = False
        Bul.Visible = False
        bultextbox.Visible = False
        ilk.Visible = False
        son.Visible = False
        bugun.Visible = False

        DateTimePicker1.Enabled = True
        ARAC_PLAKAComboBox.Enabled = True
        SOFOR_ADSOYADComboBox.Enabled = True
        SANTIYE_ADIComboBox.Enabled = True
        DOKUM_ADIComboBox.Enabled = True
        NumericUpDown1.Enabled = True


    End Sub




    Private Sub yeni_Click(sender As Object, e As EventArgs) Handles yeni.Click
        bugun.PerformClick()
        Call temizle1()
        Kaydet1.Visible = True
        vazgec.Visible = True
        kapat.Visible = False
        yeni.Visible = False
        duzenle.Visible = False
        sil.Visible = False
        Bul.Visible = False
        ilk.Visible = False
        son.Visible = False
        bugun.Visible = False

        bultextbox.Visible = False
        DateTimePicker1.Enabled = True
        ARAC_PLAKAComboBox.Enabled = True
        SOFOR_ADSOYADComboBox.Enabled = True
        SANTIYE_ADIComboBox.Enabled = True
        DOKUM_ADIComboBox.Enabled = True
        NumericUpDown1.Enabled = True
        DataGridView1.Enabled = False

        DataGridView1.Enabled = False


    End Sub

    Private Sub Kaydet2_Click(sender As Object, e As EventArgs) Handles Kaydet2.Click
        If NumericUpDown1.Value = 0 Or SOFOR_ADSOYADComboBox.Text = Nothing Or ARAC_PLAKAComboBox.Text = Nothing Or SANTIYE_ADIComboBox.Text = Nothing Or DOKUM_ADIComboBox.Text = Nothing Then
            MsgBox("Boş Alan Bırakmayınız")
            Beep()
            Exit Sub
        End If
        tarih1 = DateTimePicker1.Value
        sofor1 = SOFOR_ADSOYADComboBox.Text
        plaka1 = ARAC_PLAKAComboBox.Text
        santiye1 = SANTIYE_ADIComboBox.Text
        dokum1 = DOKUM_ADIComboBox.Text
        sefersayi1 = NumericUpDown1.Value
        Kimlik1 = Convert.ToInt32(TextBox1.Text)
        sql = "UPDATE SEFERLER SET SEFER_TARIH=@sefertarih, SEFER_SOFOR=@sofor, SEFER_PLAKA=@plaka, SEFER_SANTIYE=@santiye, SEFER_DOKUM=@dokum, SEFER_SAYI=@sefersayi WHERE Kimlik=@id"

        Dim komut As New OleDbCommand
        With komut
            .Parameters.AddWithValue("@sefertarih", tarih1)
            .Parameters.AddWithValue("@sofor", sofor1)
            .Parameters.AddWithValue("@plaka", plaka1)
            .Parameters.AddWithValue("@santiye", santiye1)
            .Parameters.AddWithValue("@dokum", dokum1)
            .Parameters.AddWithValue("@sefersayi", sefersayi1)
            .Parameters.AddWithValue("@id", Kimlik1)
        End With
        komut.Connection = coon
        komut.CommandText = sql
        coon.Open()

        komut.ExecuteNonQuery()
        MessageBox.Show("Bilgiler başarıyla güncellendi")
        coon.Close()
        Retrieve()

        Kaydet2.Visible = False
        Call temizle()
        items()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        tarih1 = DateTimePicker1.Text
        sofor1 = SOFOR_ADSOYADComboBox.Text
        plaka1 = ARAC_PLAKAComboBox.Text
        santiye1 = SANTIYE_ADIComboBox.Text
        dokum1 = DOKUM_ADIComboBox.Text
        sefersayi1 = NumericUpDown1.Value
        Kimlik1 = TextBox1.Text

        MsgBox(Convert.ToInt32(TextBox1.Text))

    End Sub

    Private Sub sil_click(sender As Object, e As EventArgs) Handles sil.Click
        If IsNothing(Me.DataGridView1.CurrentRow) Then
            MsgBox("Bir Kayıt Seçiniz", MsgBoxStyle.Critical, "Uyarı")
            Beep()
            Exit Sub
        Else
            GoTo 2
        End If
2:      If MsgBox("Kayıt Silinecek. Emin Misiniz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.Yes Then
            GoTo 1
        Else
            Exit Sub
        End If
1:      Kimlik1 = Convert.ToInt32(TextBox1.Text)
        sql = "DELETE FROM SEFERLER WHERE Kimlik=@id"

        Dim komut As New OleDbCommand
        With komut
            .Parameters.AddWithValue("@id", Kimlik1)
        End With
        komut.Connection = coon
        komut.CommandText = sql
        coon.Open()
        komut.ExecuteNonQuery()
        coon.Close()
        MessageBox.Show("Veri başarıyla silindi.")
        Retrieve()
        items()
        Kaydet2.Visible = False

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles kapat.Click
        Me.Close()
        formclose()
        pic()
    End Sub

    Private Sub vazgec_Click(sender As Object, e As EventArgs) Handles vazgec.Click
        Call temizle()
        Call items()
    End Sub


    Private Sub tarih(bultarih As String)
        bultarih = bultextbox.Text
    End Sub


    Private Sub Bul_Click(sender As Object, e As EventArgs) Handles Bul.Click
        On Error Resume Next
        Retrieve()
        items()
    End Sub

    Private Sub ilk_Click(sender As Object, e As EventArgs) Handles ilk.Click
        On Error Resume Next
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = 0
        Me.DataGridView1.Rows(0).Selected = True
        items()
    End Sub

    Private Sub son_Click(sender As Object, e As EventArgs) Handles son.Click
        On Error Resume Next
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
        Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Selected = True
        items()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bugun.Click
        bultextbox.Value = Date.Today
        Retrieve()
        items()
    End Sub

    Private Sub santiyecombobox()

        If DataGridView1.RowCount = 0 Then
            SANTIYE_ADIComboBox.DataSource = SANTIYELERBindingSource
            SANTIYE_ADIComboBox.DisplayMember = "SANTIYE_ADI"
        Else
            SANTIYE_ADIComboBox.DataSource = Nothing
        End If
        Dim bultarih As String = bultextbox.Value.Month.ToString + "/" + bultextbox.Value.AddDays(-1).Day.ToString + "/" + bultextbox.Value.Year.ToString
        Dim tarih2 As String = bultextbox.Value.Month.ToString + "/" + "01" + "/" + bultextbox.Value.Year.ToString
        MsgBox(bultarih + "  " + tarih2)
        Dim Con = New OleDbConnection(conString)
        Dim cmd As New OleDbCommand
        Dim adr As OleDbDataReader

        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()

                cmd.Connection = Con
                cmd.CommandText = "SELECT SEFER_SANTIYE, COUNT(*) AS Adet FROM SEFERLER WHERE SEFER_TARIH BETWEEN @tarih1 and @tarih2 GROUP BY SEFER_SANTIYE ORDER BY COUNT(*) desc"
                cmd.Parameters.AddWithValue("@tarih2", bultarih)
                cmd.Parameters.AddWithValue("@tarih1", tarih2)
                adr = cmd.ExecuteReader()

                ' Fill a combo box with the datareader
                Do While adr.Read = True
                    SANTIYE_ADIComboBox.Items.Add(adr.GetString(0))
                    SANTIYE_ADIComboBox.Items.Add(adr.GetString(1))
                Loop

                Con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class