Module Module1
    Public Sub pic()
        If AnaMenu.PictureBox1.Visible = True Then
            AnaMenu.PictureBox1.Visible = False
        ElseIf AnaMenu.PictureBox1.Visible = False Then
            AnaMenu.PictureBox1.Visible = True
        End If
    End Sub
    Public Sub formclose()
        If AnaMenu.FormToolStripMenuItem.Enabled = True Then
            AnaMenu.FormToolStripMenuItem.Enabled = False
        ElseIf AnaMenu.FormToolStripMenuItem.Enabled = False Then
            AnaMenu.FormToolStripMenuItem.Enabled = True
        End If
        If AnaMenu.ParametrelerToolStripMenuItem.Enabled = True Then
            AnaMenu.ParametrelerToolStripMenuItem.Enabled = False
        ElseIf AnaMenu.ParametrelerToolStripMenuItem.Enabled = False Then
            AnaMenu.ParametrelerToolStripMenuItem.Enabled = True
        End If
    End Sub
    Public Function TRSiz(ByVal vdata As String) As String
        Dim tmp As String
        tmp = Replace(vdata, "İ", "I")
        tmp = Replace(tmp, "İ", "I")
        tmp = Replace(tmp, "ı", "i")
        tmp = Replace(tmp, "Ğ", "G")
        tmp = Replace(tmp, "ğ", "g")
        tmp = Replace(tmp, "Ş", "S")
        tmp = Replace(tmp, "ş", "s")
        tmp = Replace(tmp, "Ç", "C")
        tmp = Replace(tmp, "ç", "c")
        tmp = Replace(tmp, "Ü", "U")
        tmp = Replace(tmp, "ü", "u")
        tmp = Replace(tmp, "Ö", "O")
        tmp = Replace(tmp, "ö", "o")
        TRSiz = tmp
    End Function

End Module
