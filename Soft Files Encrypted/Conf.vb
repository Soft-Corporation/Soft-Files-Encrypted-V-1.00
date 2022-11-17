Imports System.IO
Public Class Conf

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer


    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub



    Public Sub Randowstring(ByVal Lenght As Integer, ByRef obj As Object)
        For x = 1 To 20
            Dim nuberlenght As Integer = Lenght
            Dim ret As String = String.Empty
            Dim ab As New System.Text.StringBuilder
            Dim content As String = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"
            Dim rnd As New Random
            For i As Integer = 0 To nuberlenght
                ab.Append(content(rnd.[Next](content.Length)))
            Next
            obj.text = ab.ToString
        Next x
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Randowstring(15, TextBox2)


        Directory.CreateDirectory(Application.StartupPath & "\Conf")
        My.Settings.Password = TextBox1.Text
        My.Settings.Save()
        My.Settings.Reload()

        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\p1.txt")
            Directory.GetAccessControl("H:\Pass\p1.jpeg")
            salva.Write(TextBox2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\p1.txt")
            sal.Write(TextBox2.Text)
            sal.Close()

            My.Settings.Cript = TextBox2.Text



            Form1.Show()
            Me.Close()

        Else
            MsgBox("Chiave non collegata o non in unita H:\")
        End If
    End Sub

    Private Sub Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("L'unità della chiave deve essere H:\")
        Timer1.Start()
        Form1.Close()


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MsgBox("Questa è la configurazione in cui puoi digitare una passowrd per accedere. Ci sono 2 modi per accedere, Tramite password e tramite una qualsiasi Pendrive. 'ATTENZIONE DURANTE LA CONFIGURAZIONE LA PENDRIVE E' OBBLIGATORIA E DEVE ESSERE CONFIGURATA CON L'UNITA H:\'. Questa finestra configura la password che sceglierai per accedere e la pendrive che ti servira come chiave.")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Randowstring(15, TextBox2)

        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")
        Directory.Delete(Application.StartupPath & "\Gold")
        Directory.CreateDirectory("H:\Pass")
        My.Settings.Password = TextBox1.Text
        My.Settings.Save()
        My.Settings.Reload()

        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\p1.txt")
            Directory.GetAccessControl("H:\Pass\p1.txt")
            salva.Write(TextBox2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\p1.txt")
            sal.Write(TextBox2.Text)
            sal.Close()

            My.Settings.Cript = TextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()


            Form1.Show()
            Me.Close()

        Else
            MsgBox("Chiave non collegata o non in unita H:\")
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

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub
End Class