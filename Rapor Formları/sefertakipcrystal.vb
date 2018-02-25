Public Class sefertakipcrystal

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.CrystalReportViewer1
            .ReportSource = "C:\Sefer Takip\sefertakip.rpt"
            .Refresh()
            .RefreshReport()
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            .BringToFront()
        End With
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class