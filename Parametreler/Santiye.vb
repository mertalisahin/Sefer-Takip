Imports System.Data
Imports System.Data.OleDb
Public Class Santiye
    Dim yol As String = "C:\Sefer Takip\sefertakip.accdb"
    Dim coon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & yol & "'")
    Dim santiyeadi, santiyeyeri, santiyesorumlusu, sql As String

    Dim Kimlik1 As Int32
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & yol & "'"
    Dim con As New OleDbConnection(conString)
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dt As New DataTable()


    Private Sub populate(Kimlik As Integer, SANTIYE_ADI As String, SANTIYE_YERI As String, SANTIYE_SORUMLU As String)
        Dim row As String() = New String() {Kimlik, SANTIYE_ADI, SANTIYE_YERI, SANTIYE_SORUMLU}


        DataGridView1.Rows.Add(row)


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)

    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)

    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)

    End Sub
    

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Kimlik"
        DataGridView1.Columns(1).Name = "Şantiye Adı"
        DataGridView1.Columns(2).Name = "Şantiye Yeri"
        DataGridView1.Columns(3).Name = "Şantiye Sorumlusu"

        DataGridView1.Columns(0).Visible = False






        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Retrieve()

        Call items()

    End Sub
    Private Sub temizle()
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        DataGridView1.Enabled = True

        yeni.Visible = True
        duzenle.Visible = True
        sil.Visible = True
        kaydet1.Visible = False
        kaydet2.Visible = False
        vazgec.Visible = False
        kapat.Visible = True

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
    End Sub

    Private Sub Retrieve()

        DataGridView1.Rows.Clear()

        Dim sql As String = "SELECT * FROM SANTIYELER order by SANTIYE_ADI"
        cmd = New OleDbCommand(sql, con)

        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)

            adapter.Fill(dt)

            For Each row In dt.Rows
                populate(row(0), row(1), row(2), row(3))

            Next
            con.Close()
            dt.Rows.Clear()

        Catch ex As Exception

        End Try

        Call temizle()
    End Sub


    Private Sub items()
        Dim SANTIYE_ADI As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim SANTIYE_YERI As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim SANTIYE_SORUMLU As String = DataGridView1.SelectedRows(0).Cells(3).Value
        TextBox1.Text = SANTIYE_ADI
        TextBox2.Text = SANTIYE_YERI
        TextBox3.Text = SANTIYE_SORUMLU
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Call items()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        sefertakipcrystal.Show()


    End Sub

    Private Sub kaydet1_Click(sender As Object, e As EventArgs) Handles kaydet1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Then
            MsgBox("Boş Alan Bırakmayınız")
            Beep()
            Exit Sub
        End If
        santiyeadi = TRSiz(TextBox1.Text)
        santiyeyeri = TRSiz(TextBox2.Text)
        santiyesorumlusu = TRSiz(TextBox3.Text)
        Dim sql As String = "insert into SANTIYELER (SANTIYE_ADI,SANTIYE_YERI,SANTIYE_SORUMLU) VALUES ('" & santiyeadi & "','" & santiyeyeri & "','" & santiyesorumlusu & "')"
        Dim sql2 As String = "select * from SANTIYELER"
        Dim komut As New OleDbCommand(sql2, coon)

        coon.Open()


        komut.CommandText = sql
        komut.ExecuteNonQuery()
        coon.Close()
        Retrieve()
        items()
        temizle()
        MessageBox.Show("Bilgiler kaydedildi")
        kaydet1.Visible = False
        Call items()
    End Sub


    Private Sub duzenle_Click(sender As Object, e As EventArgs) Handles duzenle.Click
        DataGridView1.Enabled = False
        vazgec.Visible = True
        kapat.Visible = False
        yeni.Visible = False
        duzenle.Visible = False
        sil.Visible = False
        kaydet2.Visible = True
        kaydet1.Visible = False
        TextBox3.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox1.ReadOnly = False


    End Sub




    Private Sub yeni_Click(sender As Object, e As EventArgs) Handles yeni.Click
        kaydet1.Visible = True
        vazgec.Visible = True
        kapat.Visible = False
        yeni.Visible = False
        duzenle.Visible = False
        sil.Visible = False

        TextBox3.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox1.ReadOnly = False
        DataGridView1.Enabled = False
    End Sub

    Private Sub Kaydet2_Click(sender As Object, e As EventArgs) Handles kaydet2.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Then
            MsgBox("Boş Alan Bırakmayınız")
            Beep()
            Exit Sub
        End If
        santiyeadi = TRSiz(TextBox1.Text)
        santiyeyeri = TRSiz(TextBox2.Text)
        santiyesorumlusu = TRSiz(TextBox3.Text)
        Kimlik1 = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)
        sql = "UPDATE SANTIYELER SET SANTIYE_ADI=@santiyeadi, SANTIYE_YERI=@santiyeyeri, SANTIYE_SORUMLU=@santiyesorumlusu WHERE Kimlik=@id"

        Dim komut As New OleDbCommand
        With komut
            .Parameters.AddWithValue("@santiyeadi", santiyeadi)
            .Parameters.AddWithValue("@santiyeyeri", santiyeyeri)
            .Parameters.AddWithValue("@santiyesorumlusu", santiyesorumlusu)
            .Parameters.AddWithValue("@id", Kimlik1)
        End With
        komut.Connection = coon
        komut.CommandText = sql
        coon.Open()

        komut.ExecuteNonQuery()
        MessageBox.Show("Bilgiler başarıyla güncellendi")
        coon.Close()
        Retrieve()
        items()
        kaydet2.Visible = False
        Call temizle()
        Call items()
    End Sub



    Private Sub sil_click(sender As Object, e As EventArgs) Handles sil.Click
        Kimlik1 = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)
        sql = "DELETE FROM SANTIYELER WHERE Kimlik=@id"

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
        kaydet2.Visible = False
        Call items()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class