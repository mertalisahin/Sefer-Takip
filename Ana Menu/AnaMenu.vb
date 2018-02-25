Public Class AnaMenu

    Private Sub ParçalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokumToolStripMenuItem.Click
        formclose()

        Dim frmC As New Dokum
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.ShowIcon = False
        frmC.Show()
        pic()
    End Sub


    Private Sub ServisGirisiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeferTakipMenuStripItm.Click
        formclose()

        Dim frmC As New SeferTakip
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.ShowIcon = False
        frmC.Show()
        pic()
    End Sub


    Private Sub AraçlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AraçlarToolStripMenuItem.Click
        formclose()

        Dim frmC As New Araclar
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.ShowIcon = False
        frmC.Show()
        pic()
    End Sub

    Private Sub ProgramıKapatToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SeferlerRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeferlerRaporuMenuStripItem.Click
        sefertakipcrystal.ShowDialog()
    End Sub

    Private Sub ServisElemanlarıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoforlerToolStripMenuItem.Click
        formclose()
        Dim frmC As New Soforler
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.ShowIcon = False
        frmC.Show()
        pic()
    End Sub

    Private Sub AnaMenu_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        End

    End Sub

    Private Sub BirimlerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SantiyelerToolStripMenuItem.Click
        formclose()
        Dim frmC As New Santiye
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.ShowIcon = False
        frmC.Show()
        pic()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ÖzetSeferRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖzetSeferRaporuToolStripMenuItem.Click
        ozetseferraporu.ShowDialog()
    End Sub

    Private Sub DökümAdınaGöreÖzetSeferRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DökümAdınaGöreÖzetSeferRaporuToolStripMenuItem.Click
        ozetseferraporudokum.ShowDialog()
    End Sub


    Private Sub ŞantiyeAdınaGöreÖzetSeferRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞantiyeAdınaGöreÖzetSeferRaporuToolStripMenuItem.Click
        ozetseferraporusantiye.ShowDialog()
    End Sub

    Private Sub ŞoförAdınaGöreÖzetSeferRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞoförAdınaGöreÖzetSeferRaporuToolStripMenuItem.Click
        ozetseferraporusofor.ShowDialog()
    End Sub

    Private Sub ŞoförGenelRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞoförGenelRaporuToolStripMenuItem.Click
        ozetseferraporutoplam.ShowDialog()
    End Sub

    Private Sub ŞoförPrimRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞoförPrimRaporuToolStripMenuItem.Click
        ozetseferraporuucretli.ShowDialog()
    End Sub

    Private Sub GenelPrimRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenelPrimRaporuToolStripMenuItem.Click
        genelprimraporu.ShowDialog()

    End Sub
    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        End
    End Sub

    Private Sub MazotTakibiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MazotTakibiToolStripMenuItem.Click
        formclose()

        Dim frmC As New mazottakip
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.ShowIcon = False
        frmC.Show()
        pic()
    End Sub
End Class