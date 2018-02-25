Imports System.Data
Imports System.Data.OleDb
Public Class usercontrol
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Sefer Takip\sefertakip.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM USERS WHERE USER_NAME =@username AND USER_PASS =@pass", myConnection)
        cmd.Parameters.AddWithValue("@username", TextBox1.Text)
        cmd.Parameters.AddWithValue("@pass", TextBox2.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        While dr.Read
            userFound = True
        End While
        If userFound = True Then
            AnaMenu.Show()
            Me.Hide()
        Else
            MsgBox("Kullanıcı Adı veya Şifresi Yanlış", MsgBoxStyle.OkOnly, "Giriş Hatalı")
        End If
        myConnection.Close()

    End Sub

    Private Sub usercontrol_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Select()
    End Sub
End Class