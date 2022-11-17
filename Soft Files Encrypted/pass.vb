Imports System.IO
Imports System.Net
Public Class pass


    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer


    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Dim pass As String

    Public WithEvents download As New webclient
    Private Sub pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = My.Settings.Password

        If TextBox3.Text = "" Then

            Conf.Show()
            Me.Close()
        Else
            Me.Show()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer2.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer3.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer4.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer5.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer6.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer7.Start()
        End If


        ' If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
        'download.DownloadFileAsync(New Uri("Server Ftp Url"), Application.StartupPath & "\Updater.txt")

        'Timer10.Start()
        'Timer8.Start()
        'Timer9.Start()
        'End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = My.Settings.Password Then
            Form1.Show()
        Else
            MsgBox("Password errata")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        Dim apri As String = My.Computer.FileSystem.ReadAllText("H:\Pass\p1.txt")
        TextBox2.Text = apri


        If TextBox2.Text = My.Settings.Cript Then
            Form1.Show()
        Else
            MsgBox("Chiave non inserita")
        End If




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox2.Text = My.Settings.Password Then
            Form1.Show()
        Else
            MsgBox("Chiave non inserita")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If TextBox1.Text = My.Settings.Password Then
            Form1.Show()

            Me.Hide()
        Else
            MsgBox("Password errata")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Dim apri As String = My.Computer.FileSystem.ReadAllText("H:\Pass\p1.txt")
        TextBox2.Text = apri


        If TextBox2.Text = My.Settings.Cript Then
            Form1.Show()

            Me.Close()
        Else
            MsgBox("Chiave non inserita")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If b.Text < c.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/soft-optimizer-1-01")
        Else


        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Timer8.Stop()
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        c.Text = apri
    End Sub

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub
End Class