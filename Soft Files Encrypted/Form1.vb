Imports System.IO
Imports System.Net

Public Class Form1


    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer


    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Dim Dcfile As String, Desafe As String
    Public WithEvents download As New WebClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load






        BackgroundWorker1.CancelAsync()
        BackgroundWorker1.Dispose()

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

        Timer8.Start()



    End Sub

    Dim a As New OpenFileDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        a.Title = "Scegli file"

        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Dim bb As String, cc As String

    Dim files As String


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Control.CheckForIllegalCrossThreadCalls = False




        Dim b As String = Convert.ToBase64String(File.ReadAllBytes(a.FileName))
        ProgressBar1.Maximum = Convert.ToInt32(b.Length)
        Dim c As String = String.Empty
        For d As Integer = 1 To b.Length
            c &= ChrW(AscW(GetChar(b, d))) & "Soft Corporation"
            Try
                ProgressBar1.Value = Convert.ToInt32(d)
            Catch

            End Try
        Next
        File.WriteAllText(a.FileName, c)

        MsgBox("Operazione completata")
        ProgressBar1.Hide()
        Label6.Hide()
        Panel6.Show()
        Panel2.Show()
        Panel3.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ProgressBar1.Show()
        Label6.Show()
        Panel6.Hide()
        Panel2.Hide()
        Panel3.Hide()

        a.Title = "Scegli file"

        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync()
        Else
            Label6.Hide()
            Panel6.Show()
            Panel2.Show()
            Panel3.Show()
            ProgressBar1.Hide()
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim a As New OpenFileDialog
        With a


            If a.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dcfile = a.FileName
                Desafe = a.SafeFileName
                If Not BackgroundWorker2.IsBusy Then BackgroundWorker2.RunWorkerAsync()
            End If
        End With
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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        Dim msg = "Questa opzione cancellerà dal PC la configurazione di accesso della tua Pendrive 'ATTUARE LA PROCEDURA SOLO SE LA PENDRIVE E'. STATA RUBATA' Vuoi cancellare la configurazione di accesso della tua Pendrive?"
        Dim CD = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2

        Dim response = MsgBox(msg, CD)

        If response = MsgBoxResult.Yes Then
            My.Settings.Cript = ""
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("Configurazione di accesso pendrive eliminata!")
        Else

        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Impostazioni.Show()
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

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

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        pass.Close()
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Timer8.Stop()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        Control.CheckForIllegalCrossThreadCalls = False


        Dim b As String = File.ReadAllText(Dcfile)

        File.WriteAllBytes(Dcfile, Convert.FromBase64String(b.Replace("Soft Corporation", String.Empty)))

        MsgBox("Operazione completata")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim a As New OpenFileDialog
        With a


            If a.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dcfile = a.FileName
                Desafe = a.SafeFileName
                If Not BackgroundWorker2.IsBusy Then BackgroundWorker2.RunWorkerAsync()
            End If


        End With
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
