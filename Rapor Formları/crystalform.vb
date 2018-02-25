Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Public Class crystalform

    Private Sub crystalform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SefertakipDataSet.SANTIYELER' table. You can move, or remove it, as needed.
        Me.SANTIYELERTableAdapter.Fill(Me.SefertakipDataSet.SANTIYELER)
        'TODO: This line of code loads data into the 'SefertakipDataSet.SOFORLER' table. You can move, or remove it, as needed.
        Me.SOFORLERTableAdapter.Fill(Me.SefertakipDataSet.SOFORLER)
        'TODO: This line of code loads data into the 'SefertakipDataSet.ARACLAR' table. You can move, or remove it, as needed.
        Me.ARACLARTableAdapter.Fill(Me.SefertakipDataSet.ARACLAR)
        SantiyeComboBox.SelectedIndex = -1
        SoforComboBox.SelectedIndex = -1
        PlakaComboBox.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RptDocument As New ReportDocument

        RptDocument.Load("C:\Sefer Takip\sefertakip.rpt")

        RptDocument.SetParameterValue("tarih1", Geliş_TarihiDateTimePicker.Value)
        RptDocument.SetParameterValue("tarih2", Geliş_Tarihi_2DateTimePicker.Value)
        RptDocument.SetParameterValue("Plaka", PlakaComboBox.Text)
        RptDocument.SetParameterValue("Santiye", SantiyeComboBox.Text)


        'Set login info
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim myTable As Table
        For Each myTable In RptDocument.Database.Tables
            myLogin = myTable.LogOnInfo
            myLogin.ConnectionInfo.ServerName = "sefertakip.accdb"
            myLogin.ConnectionInfo.DatabaseName = "sefertakip.accdb"
            myLogin.ConnectionInfo.UserID = "Admin"
            myLogin.ConnectionInfo.Password = ""
            myTable.ApplyLogOnInfo(myLogin)
            myTable.Location = myTable.Location
        Next

        sefertakipcrystal.CrystalReportViewer1.ReportSource = RptDocument
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then

            SantiyeComboBox.Enabled = False
            SantiyeComboBox.DropDownStyle = ComboBoxStyle.DropDown
            SantiyeComboBox.Text = "Hepsi"

        ElseIf CheckBox2.Checked = False Then

            SantiyeComboBox.Enabled = True
            SantiyeComboBox.DropDownStyle = ComboBoxStyle.DropDownList


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            SoforComboBox.Enabled = False
            SoforComboBox.DropDownStyle = ComboBoxStyle.DropDown
            SoforComboBox.Text = "Hepsi"

        ElseIf CheckBox1.Checked = False Then

            SoforComboBox.Enabled = True
            SoforComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            SoforComboBox.SelectedIndex = 0

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then

            PlakaComboBox.Enabled = False
            PlakaComboBox.DropDownStyle = ComboBoxStyle.DropDown
            PlakaComboBox.Text = "Hepsi"

        ElseIf CheckBox3.Checked = False Then

            PlakaComboBox.Enabled = True
            PlakaComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            PlakaComboBox.SelectedIndex = 0

        End If
    End Sub
End Class