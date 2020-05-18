Public Class submitmsgbrd
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = ""
        TextBox1.Text = ""
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "N31DMClose!" Then
            TextBox1.Text = ""
            Label2.Text = ""
            Application.Exit()
        ElseIf TextBox1.Text = "N31RestartLogProg!" Then
            Label2.Text = "Please Wait..."
            Dim pc5 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
            If pc5 = "logger" Then
                For Each Pr1 As Process In System.Diagnostics.Process.GetProcessesByName("ALFiler")
                    Pr1.Kill()
                Next
                For Each Pr2 As Process In System.Diagnostics.Process.GetProcessesByName("ALRec")
                    Pr2.Kill()
                Next
                For Each Pr3 As Process In System.Diagnostics.Process.GetProcessesByName("butt")
                    Pr3.Kill()
                Next
                For Each Pr4 As Process In System.Diagnostics.Process.GetProcessesByName("piraside")
                    Pr4.Kill()
                Next
                For Each Pr5 As Process In System.Diagnostics.Process.GetProcessesByName("Now Playing Tool for OtsAV")
                    Pr5.Kill()
                Next

                System.Threading.Thread.Sleep(5000)

                Dim p1() As Process
                p1 = Process.GetProcessesByName("ALFiler")
                If p1.Count > 0 Then
                    'Already Running
                Else
                    Process.Start("C:\Logger\ALFiler.exe")
                End If
                Dim p2() As Process
                p2 = Process.GetProcessesByName("ALRec")
                If p2.Count > 0 Then
                    'Already Running
                Else
                    Process.Start("C:\Logger\ALRec.exe")
                End If
                Dim p3() As Process
                p3 = Process.GetProcessesByName("butt")
                If p3.Count > 0 Then
                    'Already Running
                Else
                    Process.Start("C:\Users\logger\AppData\Local\butt-0.1.15\butt.exe")
                End If
                Dim p4() As Process
                p4 = Process.GetProcessesByName("piraside")
                If p4.Count > 0 Then
                    'Already Running
                Else
                    Process.Start("C:\Program Files (x86)\Pira CZ Silence Detector\piraside.exe")
                End If
                Dim p5() As Process
                p5 = Process.GetProcessesByName("Now Playing Tool for OtsAV")
                If p5.Count > 0 Then
                    'Already Running
                Else
                    Process.Start("C:\Program Files\Now Playing Tool for OtsAV\Now Playing Tool for OtsAV.exe")
                End If
            Else
                'DO NOTHING
            End If
            Label2.Text = ""
            TextBox1.Text = ""
            Me.Hide()
        ElseIf TextBox1.Text = "N31OtsRemote!" Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "/incognito 192.168.1.115")
            Label2.Text = ""
            TextBox1.Text = ""
            Me.Hide()
        ElseIf TextBox1.Text = "SCexe" Then
            Dim pc6 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
            If pc6 = "logger" Then
                For Each PSCz As Process In System.Diagnostics.Process.GetProcessesByName("studioclock")
                    PSCz.Kill()
                Next

                System.Threading.Thread.Sleep(5000)

                Dim psc2z As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
                If psc2z = "logger" Then
                    Dim psc3z() As Process
                    psc3z = Process.GetProcessesByName("ALFiler")
                    If psc3z.Count > 0 Then
                        'Already Running
                    Else
                        Process.Start("C:\RadioTools\StudioClock\StudioClock.exe")
                    End If
                End If
                TextBox1.Text = ""
            End If
        ElseIf TextBox1.Text = "hide60" Then
            TextBox1.Text = ""
            Label2.Text = ""
            Me.Hide()
            Form1.Hide()
            System.Threading.Thread.Sleep(60000)
            Form1.Show()
        ElseIf TextBox1.Text = "N31SCinfo!" Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "/incognito http://s46.myradiostream.com:4350")
            Label2.Text = ""
            TextBox1.Text = ""
            Me.Hide()
        Else
            TextBox1.Text = ""
            Label2.Text = "Invalid"
        End If
    End Sub

    Private Sub submitmsgbrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class