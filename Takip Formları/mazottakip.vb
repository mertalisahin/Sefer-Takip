Imports System.Data
Imports System.Data.OleDb
Imports System.Object
Imports System.Text.RegularExpressions
Public Class mazottakip

    Dim yol As String = "C:\Sefer Takip\sefertakip.accdb"
    Dim coon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & yol & "'")
    Dim tarih1, sofor1, plaka1, sql As String
    Dim mazottutari1 As Integer
    Dim Kimlik1 As Int32
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & yol & "'"
    Dim con As New OleDbConnection(conString)
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dt As New DataTable()


    Private Sub populate(Kimlik As Integer, TARIH As String, PLAKA As String, SOFOR As String, TUTAR As String)
        Dim row As String() = New String() {Kimlik, TARIH, PLAKA, SOFOR, TUTAR}


        DataGridView1.Rows.Add(row)


    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mazottutaritextbox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mazottutaritextbox.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        mazottutaritextbox.Text = digitsOnly.Replace(mazottutaritextbox.Text, "")
    End Sub



    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SOFOR_ADSOYADComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SefertakipDataSet.ARACLAR' table. You can move, or remove it, as needed.
        Me.ARACLARTableAdapter.Fill(Me.SefertakipDataSet.ARACLAR)
        'TODO: This line of code loads data into the 'SefertakipDataSet.SOFORLER' table. You can move, or remove it, as needed.
        Me.SOFORLERTableAdapter.Fill(Me.SefertakipDataSet.SOFORLER)



        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "Kimlik"
        DataGridView1.Columns(1).Name = "Tarih"
        DataGridView1.Columns(2).Name = "Plaka No"
        DataGridView1.Columns(3).Name = "Şoför Adı"
        DataGridView1.Columns(4).Name = "Mazot Tutarı"
        'DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        SOFORLERBindingSource.Sort = "SOFOR_ADSOYAD ASC"
        ARACLARBindingSource.Sort = "ARAC_PLAKA ASC"


        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter



        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        Retrieve2()

        Call items()


    End Sub
    Private Sub temizle()
        On Error Resume Next
        DateTimePicker1.Value = Date.Today
        ARAC_PLAKAComboBox.SelectedIndex = -1
        SOFOR_ADSOYADComboBox.SelectedIndex = -1
        mazottutaritextbox.ResetText()
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
        mazottutaritextbox.Enabled = False

        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
        Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Selected = True
    End Sub


    Private Sub temizle1()
        On Error Resume Next
        DateTimePicker1.Value = Date.Today
        ARAC_PLAKAComboBox.SelectedIndex = -1
        SOFOR_ADSOYADComboBox.SelectedIndex = -1
        mazottutaritextbox.ResetText()

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

        mazottutaritextbox.Enabled = False

        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
        Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Selected = True
    End Sub
    Private Sub Retrieve()
        Dim bultarih As String = bultextbox.Text
        DataGridView1.Rows.Clear()

        Dim sql As String = "SELECT * FROM MAZOT WHERE MAZOT_TARIH =@mazottarih order by Kimlik "

        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@mazottarih", bultarih)
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)

            adapter.Fill(dt)

            For Each row In dt.Rows
                populate(row(0), row(1), row(2), row(3), row(4))

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

        Dim sql As String = "SELECT * FROM MAZOT WHERE MAZOT_TARIH=@mazottarih order by Kimlik "

        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@mazottarih", Date.Today.ToShortDateString)
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)

            adapter.Fill(dt)

            For Each row In dt.Rows
                populate(row(0), row(1), row(2), row(3), row(4))

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
        Dim PLAKA As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim SOFOR As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim TUTAR As String = DataGridView1.SelectedRows(0).Cells(4).Value




        DateTimePicker1.Text = TARIH
        SOFOR_ADSOYADComboBox.Text = SOFOR
        ARAC_PLAKAComboBox.Text = PLAKA
        mazottutaritextbox.Text = TUTAR
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
        If mazottutaritextbox.Text = Nothing Or SOFOR_ADSOYADComboBox.Text = Nothing Or ARAC_PLAKAComboBox.Text = Nothing Then
            MsgBox("Boş Alan Bırakmayınız")
            Beep()
            Exit Sub
        End If
        tarih1 = DateTimePicker1.Text
        sofor1 = SOFOR_ADSOYADComboBox.Text
        plaka1 = ARAC_PLAKAComboBox.Text
        mazottutari1 = Convert.ToInt32(mazottutaritextbox.Text)

        Dim sql As String = "insert into MAZOT (MAZOT_TARIH,MAZOT_PLAKA,MAZOT_SOFOR,MAZOT_TUTAR) VALUES ('" & tarih1 & "','" & plaka1 & "','" & sofor1 & "','" & mazottutari1 & "')"
        Dim sql2 As String = "select * from MAZOT"
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
        mazottutaritextbox.Enabled = True


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
        mazottutaritextbox.Enabled = True
        DataGridView1.Enabled = False

        DataGridView1.Enabled = False


    End Sub

    Private Sub Kaydet2_Click(sender As Object, e As EventArgs) Handles Kaydet2.Click
        If SOFOR_ADSOYADComboBox.Text = Nothing Or ARAC_PLAKAComboBox.Text = Nothing Or mazottutaritextbox.Text = Nothing Then
            MsgBox("Boş Alan Bırakmayınız")
            Beep()
            Exit Sub
        End If
        tarih1 = DateTimePicker1.Value
        plaka1 = ARAC_PLAKAComboBox.Text
        sofor1 = SOFOR_ADSOYADComboBox.Text
        mazottutari1 = Convert.ToDouble(mazottutaritextbox.Text)
        Kimlik1 = Convert.ToInt32(TextBox1.Text)
        sql = "UPDATE MAZOT SET MAZOT_TARIH=@tarih, MAZOT_PLAKA=@plaka, MAZOT_SOFOR=@sofor, MAZOT_TUTAR=@tutar WHERE Kimlik=@id"

        Dim komut As New OleDbCommand
        With komut
            .Parameters.AddWithValue("@tarih", tarih1)
            .Parameters.AddWithValue("@plaka", plaka1)
            .Parameters.AddWithValue("@sofor", sofor1)
            .Parameters.AddWithValue("@tutar", mazottutari1)
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
        mazottutari1 = Convert.ToInt32(mazottutaritextbox.Text)
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
        sql = "DELETE FROM MAZOT WHERE Kimlik=@id"

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
End Class