Option Strict Off
Imports System.Windows.Forms
Imports System.Net
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Net.Mail
Imports System.Diagnostics

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.ForeColor = Color.Black
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        Try
            Dim pc As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
            If pc = "emails" Then
                Dim npo As String = My.Computer.FileSystem.ReadAllText("\\NE1-LOGGER\Logger\LoggerNowPlaying\nowplaying.txt")
                If Len(npo) > 25 Then
                    Label2.Text = npo + "  :::  "
                Else
                    Label2.Text = npo
                End If
            Else
                Dim npo As String = My.Computer.FileSystem.ReadAllText("C:\Logger\LoggerNowPlaying\nowplaying.txt")
                If Len(npo) > 25 Then
                    Label2.Text = npo + "  :::  "
                Else
                    Label2.Text = npo
                End If
            End If
        Catch ex As Exception
        End Try
        Timer8.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Format(Now, "HH")
        Label10.Text = Format(Now, "ddd")
        Label11.Text = Format(Now, "ss")
        Label12.Text = Format(Now, "mm")
        Label20.Text = Format(Now, "yyyy")
        Label23.Text = Format(Now, "dd")
        Label24.Text = Format(Now, "MM")
        If Label12.Text = "00" Then
            If Label11.Text = "00" Then
                RadioButton3.Checked = True
            End If
        End If
        If Label11.Text = "00" Then
            If Label12.Text = "25" Then
                If Label8.Text = "02" Then
                    Application.Restart()
                End If
            End If
        End If
        If Label11.Text = "00" Then
            If Label8.Text = "03" Or Label8.Text = "06" Or Label8.Text = "22" Or Label8.Text = "23" Then
                Dim x2 As Integer
                Dim y2 As Integer
                x2 = Screen.PrimaryScreen.WorkingArea.Width
                y2 = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

                Do Until x2 = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
                    x2 = x2 - 1
                    Me.Location = New Point(x2, y2)
                Loop
            End If
        End If
        If Label11.Text = "00" Then
            If Label12.Text = "01" Or Label12.Text = "10" Or Label12.Text = "20" Or Label12.Text = "30" Or Label12.Text = "40" Or Label12.Text = "50" Then
                RadioButton4.Checked = True
            End If
        End If
        If Label12.Text = "05" Or Label12.Text = "15" Or Label12.Text = "25" Or Label12.Text = "35" Or Label12.Text = "45" Or Label12.Text = "55" Then
            If Label11.Text = "00" Then
                RadioButton1.Checked = True
            End If
        End If

        If Label11.Text = "00" Then
            If Label12.Text = "00" Then
                If Label8.Text = "03" Or Label8.Text = "09" Or Label8.Text = "22" Or Label8.Text = "00" Then

                    Dim pc7 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
                    If pc7 = "logger" Then

                        For Each PSC As Process In System.Diagnostics.Process.GetProcessesByName("studioclock")
                            PSC.Kill()
                        Next

                        System.Threading.Thread.Sleep(5000)

                        Dim psc2 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
                        If psc2 = "logger" Then
                            Dim psc3() As Process
                            psc3 = Process.GetProcessesByName("ALFiler")
                            If psc3.Count > 0 Then
                                'Already Running
                            Else
                                Process.Start("C:\RadioTools\StudioClock\StudioClock.exe")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Try
                Dim web As New WebClient()
                If Label8.Text = "00" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/agp5u2m76odstui/mon00.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/fmor3orfm9dkhjv/tue00.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/1jlnuh6kvo2bkym/wed00.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/lvq7lnw6yebxv1v/thu00.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/anjiv7zkrv5un8y/fri00.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/1k4sz7zlxa9j7kt/sat00.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/grorgwwucxm6c9y/sun00.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "01" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/hw0pfl2q4mw5mzx/mon01.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/cysokxrz9vuscm6/tue01.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/57khiomiuzbl56u/wed01.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/qm34fyc995sfd77/thu01.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/4ebwcdg8vmnpevj/fri01.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/jkuqo9qbnt240y0/sat01.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/a0ukpz983427fo2/sun01.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "02" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/mw1441q0vtxjsuz/mon02.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/fiby2vj48ngite8/tue02.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/fvm0cpc4i38z1xz/wed02.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/aodq3at3kpp480z/thu02.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/q9lbildy87s9ysl/fri02.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/bbct36tth37cz9b/sat02.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/tfnlxxj4c7mwpbh/sun02.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "03" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/nomrsw3m3v7qwqv/mon03.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/7dv6xtj38y80mfy/tue03.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/cc3rz8jbs7o2l1p/wed03.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/pqvip33yiud76r4/thu03.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ur5gltn6yvl63pw/fri03.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/6uei2lxr1vyv12g/sat03.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/h8lhjmb8w5nntj8/sun03.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "04" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/hrzgv7bq138zrzk/mon04.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/gybw3uiksj9aijp/tue04.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/xgw99il5eotrkga/wed04.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/panqf46lht5uymq/thu04.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/16lsrku3toib0yp/fri04.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/18o1um51juc10ik/sat04.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/diygn1yr4w70t4n/sun04.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "05" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ypx7uegsw4nra88/mon05.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/x3xb65341mmin1j/tue05.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/nqn2ox1us1whyoq/wed05.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/lpmmwhmbcdrgnjt/thu05.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/yj2cv9idqti9iyo/fri05.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/u6v2e4j9opy1vj4/sat05.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/u5xdbljdq1g88qu/sun05.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "06" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ob9008w5q8uua9o/mon06.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/d4thjjjq0a1fw4e/tue06.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/eyd1c0kukw4vniw/wed06.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/lo1zzydvoo10nyp/thu06.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/29k434nhvhhaeyn/fri06.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/9iz9mpmeau5zuap/sat06.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/o3hs39mhldwfskr/sun06.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "07" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/bbik3j913tij6tc/mon07.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/pmon9tnakmqy5oh/tue07.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/5k23yojgo5qtw40/wed07.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/444v4hy1w1mje56/thu07.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/xi0xf3psodxo6hn/fri07.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/fio1imoez7dkvup/sat07.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/1xdu2j72qy3cabg/sun07.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "08" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/161wu479wi3ntts/mon08.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/k26obtrq7sgl2sn/tue08.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/9r3u3cxlmnnhw8t/wed08.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/2edxbc85k53bc7d/thu08.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ykvpctc759d3a4c/fri08.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/2csnn91xd5r3jtk/sat08.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/1coaxdueajv63si/sun08.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If

                If Label8.Text = "09" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/hliql2jck6lhm8z/mon09.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/uw9d1o9glccwxm1/tue09.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/hx9sd4kxw5xnwk5/wed09.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/b117xiufxucmws0/thu09.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ld546gd0ek10e1x/fri09.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/g43gavknvpd1lbd/sat09.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ipw4umief490wa2/sun09.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "10" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ie2oao4ute98ybu/mon10.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/k3uendlfd0krvxr/tue10.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/0wwz5dpgvxhbd18/wed10.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/48ogibu9clzy57c/thu10.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/yqu8108h47qbdy2/fri10.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/9bha3xqkrdoecvl/sat10.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/qugvvtnrimx7wvm/sun10.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If

                If Label8.Text = "11" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/cvv1848m75loe8k/mon11.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/b9hu09au4jxtj2t/tue11.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/mcbdyklq18i51ohc/wed11.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/p4gtyn1k7maph8s/thu11.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/635djnh3ss2jcvn/fri11.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/734wmkrwsv34b13/sat11.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/syy1fswvipcx2rt/sun11.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "12" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/imnz3uxbvbj9opi/mon12.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ll2zcr4xvosbxla/tue12.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/q6qhjj97fl69u7g/wed12.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/rr56qg2xtptily7/thu12.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/mi4g14b7igf9l9e/fri12.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/rd7ot8amu59xy9n/sat12.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/yi4994l609db4h7/sun12.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "13" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/bmilm4efia29vzm/mon13.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/rjbrmytpoikgjdy/tue13.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/dxex814yib9hah1/wed13.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/nsxba0jeyahoii2/thu13.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ujffs0so2rc4njw/fri13.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/npvq3denc8i2egx/sat13.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/qopswgfxaq979g4/sun13.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "14" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/0dfcamj5q2v94kb/mon14.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/1cxrorzw0q3m7td/tue14.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/uf4evf2h3tjeem6/wed14.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/yps65nz5qyi0lk1/thu14.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/wlnb9h5f12m88l2/fri14.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/dwuk13c33r4exyt/sat14.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/3hjni90mhg4mpqd/sun14.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "15" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/69emeo6npuvcuw4/mon15.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/5sjycp4dtybz3s4/tue15.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/rv7egmrpmo4xjkk/wed15.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/oogslyazi5351rz/thu15.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/hd567tpgk6o8gja/fri15.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/zojwdfko2byulgx/sat15.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/t0soykt9iztetb9/sun15.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "16" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/bym6vye79ynkemk/mon16.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/q5euvx5klhhr7n6/tue16.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/1c9tk1aeoahy092/wed16.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/nk497wz3ygp8zna/thu16.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/cakba4cbp0tzekj/fri16.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/0ivu8t89xf4no8j/sat16.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/3vpl0gxi6z92620/sun16.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "17" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/0a7eihacxmn77h1/mon17.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/pixqzu1kev7357h/tue17.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/5e5cnbp6yvzcjv3/wed17.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/rv3pnjj2v9tweu6/thu17.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/g0934lba58kto6e/fri17.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/fqvkxtpsvn8zr35/sat17.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/l79oa04so8v2wl9/sun17.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "18" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/5peke0vfcd6xttu/mon18.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/vb3ap91bq6l29uz/tue18.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/qax6ft5d0lp2p6o/wed18.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/nzyorwfgtrn1jnq/thu18.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/3rzy8b66zdi6exk/fri18.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/lhcsbkid2oywqiu/sat18.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/2mhgq2719g9tcko/sun18.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "19" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/t062j6ntnn42wvq/mon19.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/wy3f753zqfnq007/tue19.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/bvn88xutulvph4t/wed19.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/btulmbseio9kq7k/thu19.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/m30xjgqs86j8p28/fri19.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/r8xiidnoj412xk5/sat19.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ekt6y01mf7n1e5i/sun19.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "20" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/buf6nluwmzq0wfr/mon20.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/371ia907zyc4xi6/tue20.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/vm4tc6rnqcx5s1j/wed20.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/k3gu4trdhatu45c/thu20.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ln8h3xrwrbgsnc4/fri20.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/rz7v5oi6703n0rn/sat20.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/6w6xum4etwgflam/sun20.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "21" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ylsxfvq68kebza6/mon21.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/iun4k1pwkxvai8n/tue21.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/mz846d23llmp2zf/wed21.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/it3xgmntwoq53ab/thu21.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/xsbql7z6wofn31x/fri21.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ja3zl7wp5myy1ps/sat21.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/okcr2mo1vrnhl2b/sun21.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "22" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/afzxw9hd29ra8va/mon22.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/m0mx9nzlx6wf0sp/tue22.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/vseow4gl7yxe08z/wed22.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/yq0wu26hal2517n/thu22.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/mh21czvl1ujs7au/fri22.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/se0bsz9posszg8e/sat22.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/irp9ig8oil9f9qt/sun22.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "23" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/bq7ql3c23bf7tlw/mon23.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/zwcg1ilmknbluo3/tue23.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/vmqhb3ykqz3i63a/wed23.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/lbqi6obfzckvgjo/thu23.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ahjx1ey2w8lu40n/fri23.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/0bww1kp7313ln6g/sat23.txt")
                        Label7.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web.DownloadString("https://dl.dropboxusercontent.com/s/ag8wzw6y5f9utpi/sun23.txt")
                        Label7.Text = response
                    Else
                        Label7.Text = "Something has gone wrong!"
                    End If
                End If
            Catch ex As Exception
                RadioButton3.Checked = True
            End Try

            Try
                Dim web3 As New WebClient()
                If Label8.Text = "01" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/agp5u2m76odstui/mon00.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/fmor3orfm9dkhjv/tue00.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/1jlnuh6kvo2bkym/wed00.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/lvq7lnw6yebxv1v/thu00.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/anjiv7zkrv5un8y/fri00.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/1k4sz7zlxa9j7kt/sat00.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/grorgwwucxm6c9y/sun00.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "02" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/hw0pfl2q4mw5mzx/mon01.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/cysokxrz9vuscm6/tue01.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/57khiomiuzbl56u/wed01.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/qm34fyc995sfd77/thu01.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/4ebwcdg8vmnpevj/fri01.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/jkuqo9qbnt240y0/sat01.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/a0ukpz983427fo2/sun01.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "03" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/mw1441q0vtxjsuz/mon02.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/fiby2vj48ngite8/tue02.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/fvm0cpc4i38z1xz/wed02.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/aodq3at3kpp480z/thu02.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/q9lbildy87s9ysl/fri02.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/bbct36tth37cz9b/sat02.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/tfnlxxj4c7mwpbh/sun02.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "04" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/nomrsw3m3v7qwqv/mon03.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/7dv6xtj38y80mfy/tue03.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/cc3rz8jbs7o2l1p/wed03.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/pqvip33yiud76r4/thu03.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ur5gltn6yvl63pw/fri03.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/6uei2lxr1vyv12g/sat03.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/h8lhjmb8w5nntj8/sun03.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "05" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/hrzgv7bq138zrzk/mon04.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/gybw3uiksj9aijp/tue04.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/xgw99il5eotrkga/wed04.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/panqf46lht5uymq/thu04.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/16lsrku3toib0yp/fri04.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/18o1um51juc10ik/sat04.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/diygn1yr4w70t4n/sun04.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "06" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ypx7uegsw4nra88/mon05.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/x3xb65341mmin1j/tue05.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/nqn2ox1us1whyoq/wed05.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/lpmmwhmbcdrgnjt/thu05.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/yj2cv9idqti9iyo/fri05.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/u6v2e4j9opy1vj4/sat05.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/u5xdbljdq1g88qu/sun05.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "07" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ob9008w5q8uua9o/mon06.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/d4thjjjq0a1fw4e/tue06.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/eyd1c0kukw4vniw/wed06.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/lo1zzydvoo10nyp/thu06.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/29k434nhvhhaeyn/fri06.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/9iz9mpmeau5zuap/sat06.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/o3hs39mhldwfskr/sun06.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "08" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/bbik3j913tij6tc/mon07.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/pmon9tnakmqy5oh/tue07.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/5k23yojgo5qtw40/wed07.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/444v4hy1w1mje56/thu07.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/xi0xf3psodxo6hn/fri07.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/fio1imoez7dkvup/sat07.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/1xdu2j72qy3cabg/sun07.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "09" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/161wu479wi3ntts/mon08.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/k26obtrq7sgl2sn/tue08.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/9r3u3cxlmnnhw8t/wed08.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/2edxbc85k53bc7d/thu08.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ykvpctc759d3a4c/fri08.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/2csnn91xd5r3jtk/sat08.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/1coaxdueajv63si/sun08.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If

                If Label8.Text = "10" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/hliql2jck6lhm8z/mon09.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/uw9d1o9glccwxm1/tue09.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/hx9sd4kxw5xnwk5/wed09.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/b117xiufxucmws0/thu09.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ld546gd0ek10e1x/fri09.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/g43gavknvpd1lbd/sat09.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ipw4umief490wa2/sun09.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "11" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ie2oao4ute98ybu/mon10.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/k3uendlfd0krvxr/tue10.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/0wwz5dpgvxhbd18/wed10.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/48ogibu9clzy57c/thu10.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/yqu8108h47qbdy2/fri10.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/9bha3xqkrdoecvl/sat10.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/qugvvtnrimx7wvm/sun10.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If

                If Label8.Text = "12" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/cvv1848m75loe8k/mon11.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/b9hu09au4jxtj2t/tue11.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/mcbdyklq18i51ohc/wed11.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/p4gtyn1k7maph8s/thu11.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/635djnh3ss2jcvn/fri11.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/734wmkrwsv34b13/sat11.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/syy1fswvipcx2rt/sun11.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "13" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/imnz3uxbvbj9opi/mon12.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ll2zcr4xvosbxla/tue12.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/q6qhjj97fl69u7g/wed12.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/rr56qg2xtptily7/thu12.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/mi4g14b7igf9l9e/fri12.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/rd7ot8amu59xy9n/sat12.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/yi4994l609db4h7/sun12.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "14" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/bmilm4efia29vzm/mon13.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/rjbrmytpoikgjdy/tue13.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/dxex814yib9hah1/wed13.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/nsxba0jeyahoii2/thu13.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ujffs0so2rc4njw/fri13.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/npvq3denc8i2egx/sat13.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/qopswgfxaq979g4/sun13.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "15" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/0dfcamj5q2v94kb/mon14.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/1cxrorzw0q3m7td/tue14.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/uf4evf2h3tjeem6/wed14.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/yps65nz5qyi0lk1/thu14.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/wlnb9h5f12m88l2/fri14.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/dwuk13c33r4exyt/sat14.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/3hjni90mhg4mpqd/sun14.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "16" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/69emeo6npuvcuw4/mon15.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/5sjycp4dtybz3s4/tue15.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/rv7egmrpmo4xjkk/wed15.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/oogslyazi5351rz/thu15.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/hd567tpgk6o8gja/fri15.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/zojwdfko2byulgx/sat15.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/t0soykt9iztetb9/sun15.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "17" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/bym6vye79ynkemk/mon16.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/q5euvx5klhhr7n6/tue16.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/1c9tk1aeoahy092/wed16.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/nk497wz3ygp8zna/thu16.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/cakba4cbp0tzekj/fri16.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/0ivu8t89xf4no8j/sat16.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/3vpl0gxi6z92620/sun16.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "18" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/0a7eihacxmn77h1/mon17.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/pixqzu1kev7357h/tue17.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/5e5cnbp6yvzcjv3/wed17.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/rv3pnjj2v9tweu6/thu17.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/g0934lba58kto6e/fri17.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/fqvkxtpsvn8zr35/sat17.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/l79oa04so8v2wl9/sun17.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "19" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/5peke0vfcd6xttu/mon18.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/vb3ap91bq6l29uz/tue18.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/qax6ft5d0lp2p6o/wed18.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/nzyorwfgtrn1jnq/thu18.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/3rzy8b66zdi6exk/fri18.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/lhcsbkid2oywqiu/sat18.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/2mhgq2719g9tcko/sun18.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "20" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/t062j6ntnn42wvq/mon19.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/wy3f753zqfnq007/tue19.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/bvn88xutulvph4t/wed19.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/btulmbseio9kq7k/thu19.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/m30xjgqs86j8p28/fri19.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/r8xiidnoj412xk5/sat19.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ekt6y01mf7n1e5i/sun19.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "21" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/buf6nluwmzq0wfr/mon20.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/371ia907zyc4xi6/tue20.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/vm4tc6rnqcx5s1j/wed20.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/k3gu4trdhatu45c/thu20.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ln8h3xrwrbgsnc4/fri20.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/rz7v5oi6703n0rn/sat20.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/6w6xum4etwgflam/sun20.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "22" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ylsxfvq68kebza6/mon21.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/iun4k1pwkxvai8n/tue21.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/mz846d23llmp2zf/wed21.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/it3xgmntwoq53ab/thu21.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/xsbql7z6wofn31x/fri21.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ja3zl7wp5myy1ps/sat21.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/okcr2mo1vrnhl2b/sun21.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "23" Then
                    If Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/afzxw9hd29ra8va/mon22.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/m0mx9nzlx6wf0sp/tue22.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/vseow4gl7yxe08z/wed22.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/yq0wu26hal2517n/thu22.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/mh21czvl1ujs7au/fri22.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/se0bsz9posszg8e/sat22.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/irp9ig8oil9f9qt/sun22.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
                If Label8.Text = "00" Then
                    If Label10.Text = "Tue" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/bq7ql3c23bf7tlw/mon23.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Wed" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/zwcg1ilmknbluo3/tue23.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Thu" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/vmqhb3ykqz3i63a/wed23.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Fri" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/lbqi6obfzckvgjo/thu23.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sat" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ahjx1ey2w8lu40n/fri23.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Sun" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/0bww1kp7313ln6g/sat23.txt")
                        Label13.Text = response
                    ElseIf Label10.Text = "Mon" Then
                        Dim response As String = web3.DownloadString("https://dl.dropboxusercontent.com/s/ag8wzw6y5f9utpi/sun23.txt")
                        Label13.Text = response
                    Else
                        Label13.Text = "Something has gone wrong!"
                    End If
                End If
            Catch ex As Exception
                RadioButton3.Checked = True
            End Try
            RadioButton3.Checked = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RadioButton3.Checked = True
        RadioButton4.Checked = True
        Dim minutenow As String
        minutenow = Format(Now, "mm")
        If minutenow = "00" Or minutenow = "01" Or minutenow = "02" Or minutenow = "03" Or minutenow = "04" Or minutenow = "59" Then
            Label27.Text = "[Updating Soon]"
        Else
            RadioButton1.Checked = True
        End If
        Timer2.Enabled = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Try
                Dim webstatus As New WebClient()
                Dim statusresponse As String = webstatus.DownloadString("http://scripts.myradiostream.com/s46/4350/status.js")
                Dim status_start As String
                Dim status_end As String
                status_start = Replace(statusresponse, "document.write('", "")
                status_end = Replace(status_start, "');", "")
                If status_end = "Online" Then
                    Dim weblisten As New WebClient()
                    Dim listenresponse As String = weblisten.DownloadString("http://scripts.myradiostream.com/s46/4350/listeners.js")
                    Dim list_start As String
                    Dim list_end As String
                    Dim list_rem As String
                    list_start = Replace(listenresponse, "document.write('", "")
                    list_end = Replace(list_start, "');", "")
                    list_rem = Replace(list_end, "<html><body>", "")
                    Label22.Text = "Online" & " " & "(" & list_rem & ")"
                    Label22.ForeColor = Color.Green()
                    Label22.Font = New Font(Label22.Font.FontFamily, 12, FontStyle.Italic)
                End If
                If status_end = "Offline (No Server Connection)" Then
                    Label22.Text = "Offline"
                    Label22.ForeColor = Color.Red()
                    Label22.Font = New Font(Label22.Font.FontFamily, 12, FontStyle.Italic)
                End If
                If status_end = "Offline (No Source)" Then
                    Label22.Text = "Offline"
                    Label22.ForeColor = Color.DarkOrange()
                    Label22.Font = New Font(Label22.Font.FontFamily, 12, FontStyle.Italic)
                End If
            Catch ex As Exception
                RadioButton4.Checked = False
                RadioButton4.Checked = True
            End Try
        End If
        RadioButton4.Checked = False

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Dim lognumber As String
            Dim cachelognumber As String
            Dim logname As String
            Dim cachelogname As String
            Dim cachelognameogg As String
            Dim cachelognametmp As String
            Dim logpath As String
            Dim cachelogpath As String
            Dim cachelogpatha As String
            Dim cachelogpathb As String
            Dim hournow As Integer
            hournow = Format(Now, "HH")
            Dim minutenow As String
            minutenow = Format(Now, "mm")
            Dim twohourago As Integer
            twohourago = hournow - 2
            Dim twohoursago As String
            twohoursago = twohourago
            lognumber = Format(Now, "yyyyMMddHH")
            cachelognumber = Format(Now, "yyyyMMddHHmm")
            logname = lognumber + "0000.ogg"
            cachelognametmp = cachelognumber + "00.tmp"
            cachelognameogg = cachelognumber + "00.ogg"

            Dim pc5 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
            If pc5 = "emails" Then
                logpath = "\\NE1-LOGGER\Logger\Store\" + logname
                cachelogpatha = "NE1-LOGGER\Logger\Cache\" + cachelognametmp
                cachelogpathb = "NE1-LOGGER\Logger\Cache\" + cachelognameogg
                If My.Computer.FileSystem.FileExists(logpath) Then
                    Label27.Text = "Recording"
                    Label27.ForeColor = Color.Green()
                    Label27.Font = New Font(Label27.Font.FontFamily, 12, FontStyle.Italic)
                ElseIf My.Computer.FileSystem.FileExists(cachelogpatha) Or My.Computer.FileSystem.FileExists(cachelogpathb) Then
                    Label27.Text = "Recording In Minutes"
                    Label27.ForeColor = Color.DarkOrange()
                    Label27.Font = New Font(Label27.Font.FontFamily, 12, FontStyle.Italic)
                Else
                    Label27.Text = "Not Recording"
                    Label27.ForeColor = Color.Red()
                    Label27.Font = New Font(Label27.Font.FontFamily, 12, FontStyle.Italic)
                End If
                If Label27.Text = "Not Recording" Or Label27.Text = "Recording In Minutes" Then
                    Label1.Visible = True
                Else
                    Label1.Visible = False
                End If
                RadioButton1.Checked = False
            Else
                logpath = "C:\Logger\Store\" + logname
                cachelogpatha = "C:\Logger\Cache\" + cachelognametmp
                cachelogpathb = "C:\Logger\Cache\" + cachelognameogg
                If My.Computer.FileSystem.FileExists(logpath) Then
                    Label27.Text = "Recording"
                    Label27.ForeColor = Color.Green()
                    Label27.Font = New Font(Label27.Font.FontFamily, 12, FontStyle.Italic)
                ElseIf My.Computer.FileSystem.FileExists(cachelogpatha) Or My.Computer.FileSystem.FileExists(cachelogpathb) Then
                    Label27.Text = "Recording In Minutes"
                    Label27.ForeColor = Color.DarkOrange()
                    Label27.Font = New Font(Label27.Font.FontFamily, 12, FontStyle.Italic)
                Else
                    Label27.Text = "Not Recording"
                    Label27.ForeColor = Color.Red()
                    Label27.Font = New Font(Label27.Font.FontFamily, 12, FontStyle.Italic)
                End If
                If Label27.Text = "Not Recording" Or Label27.Text = "Recording In Minutes" Then
                    Label1.Visible = True
                Else
                    Label1.Visible = False
                End If
                RadioButton1.Checked = False
            End If



        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Try

            Dim pc3 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
            If pc3 = "emails" Then
                Dim npmod As DateTime
                npmod = File.GetLastWriteTime("\\NE1-LOGGER\Logger\LoggerNowPlaying\nowplaying.txt")
                Dim timenow As DateTime
                timenow = Date.Now
                Label4.Text = DateDiff(DateInterval.Minute, timenow, npmod)

                If Label4.Text < -5 Then
                    Label2.Text = "UNKNOWN"
                ElseIf Len(Label2.Text) > 25 Then
                    Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, Len(Label2.Text) - 1) + Microsoft.VisualBasic.Left(Label2.Text, 1)
                Else
                    'Label2.Text = My.Computer.FileSystem.ReadAllText("C:\LoggerNowPlaying\nowplaying.txt")
                End If
            Else
                Dim npmod As DateTime
                npmod = File.GetLastWriteTime("C:\Logger\LoggerNowPlaying\nowplaying.txt")
                Dim timenow As DateTime
                timenow = Date.Now
                Label4.Text = DateDiff(DateInterval.Minute, timenow, npmod)

                If Label4.Text < -5 Then
                    Label2.Text = "UNKNOWN"
                ElseIf Len(Label2.Text) > 25 Then
                    Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, Len(Label2.Text) - 1) + Microsoft.VisualBasic.Left(Label2.Text, 1)
                Else
                    'Label2.Text = My.Computer.FileSystem.ReadAllText("C:\LoggerNowPlaying\nowplaying.txt")
                End If
            End If

        Catch ex As Exception
        End Try


    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim pc4 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
        If pc4 = "logger" Then
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

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            Dim pc2 As String = My.Computer.FileSystem.ReadAllText("C:\DesktopManager\programdata.txt")
            If pc2 = "emails" Then
                Dim np As String = My.Computer.FileSystem.ReadAllText("\\NE1-LOGGER\Logger\LoggerNowPlaying\nowplaying.txt")
                If Len(np) > 25 Then
                    Label2.Text = np + "  :::  "
                Else
                    Label2.Text = np
                End If
            Else
                Dim np As String = My.Computer.FileSystem.ReadAllText("C:\Logger\LoggerNowPlaying\nowplaying.txt")
                If Len(np) > 25 Then
                    Label2.Text = np + "  :::  "
                Else
                    Label2.Text = np
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x3 As Integer
        Dim y3 As Integer
        x3 = Screen.PrimaryScreen.WorkingArea.Width
        y3 = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x3 = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x3 = x3 - 1
            Me.Location = New Point(x3, y3)
        Loop
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        submitmsgbrd.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
    End Sub
End Class