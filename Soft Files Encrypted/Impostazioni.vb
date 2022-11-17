Imports System.IO
Public Class Impostazioni

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer


    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Informazioni.Show()
    End Sub

    Private Sub Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Pass2.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        'passc2.show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        Conf.Close()
        Form1.Close()
        Me.Close()
        pass.Close()
        Process.Start(Application.StartupPath & "\Soft Files Encrypted.exe")
        Pass2.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        Conf.Close()
        Form1.Close()
        Me.Close()
        pass.Close()
        Process.Start(Application.StartupPath & "\Soft Files Encrypted.exe")
        Pass2.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        Conf.Close()
        Form1.Close()
        Me.Close()
        pass.Close()
        Process.Start(Application.StartupPath & "\Soft Files Encrypted.exe")
        Pass2.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        Conf.Close()
        Form1.Close()
        Me.Close()
        pass.Close()
        Process.Start(Application.StartupPath & "\Soft Files Encrypted.exe")
        Pass2.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Gold")
        Conf.Close()
        Form1.Close()
        Me.Close()
        pass.Close()
        Process.Start(Application.StartupPath & "\Soft Files Encrypted.exe")
        Pass2.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Gold")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Blue")
        Conf.Close()
        Form1.Close()
        Me.Close()
        pass.Close()
        Process.Start(Application.StartupPath & "\Soft Files Encrypted.exe")
        Pass2.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
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

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub
End Class