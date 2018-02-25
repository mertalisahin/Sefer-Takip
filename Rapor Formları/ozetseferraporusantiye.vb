Public Class ozetseferraporusantiye

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.CrystalReportViewer1
            .ReportSource = "C:\Sefer Takip\ozetseferraporusantiye.rpt"
            .Refresh()
            .RefreshReport()
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            .BringToFront()
        End With
        If CrystalReportViewer1.ReportSource = "C:\Sefer Takip\ozetseferraporusantiye.rpt" Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class