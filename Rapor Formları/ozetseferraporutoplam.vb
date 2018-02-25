Public Class ozetseferraporutoplam
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.CrystalReportViewer1
            .ReportSource = "C:\Sefer Takip\sofortoplam.rpt"
            .Refresh()
            .RefreshReport()
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            .BringToFront()
        End With
        If CrystalReportViewer1.ReportSource = "C:\Sefer Takip\sofortoplam.rpt" Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class