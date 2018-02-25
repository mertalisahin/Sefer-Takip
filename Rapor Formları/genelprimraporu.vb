Public Class genelprimraporu
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.CrystalReportViewer1
            .ReportSource = "C:\Sefer Takip\genelprimraporu.rpt"
            .Refresh()
            .RefreshReport()
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            .BringToFront()
        End With

        If CrystalReportViewer1.ReportSource = "C:\Sefer Takip\genelprimraporu.rpt" Then
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
End Class