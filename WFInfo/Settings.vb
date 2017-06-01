﻿Imports System.IO
Public Class Settings
    Dim chTemp As String
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Sub btnHkey1_Click(sender As Object, e As EventArgs) Handles btnHkey1.Click
        If Not key1Tog Then
            btnHkey1.Text = "..."
            key1Tog = True
        Else
            btnHkey1.Text = My.Settings.HKey1Text
        End If
    End Sub

    Private Sub btnHkey1_KeyUp(sender As Object, e As KeyEventArgs) Handles btnHkey1.KeyUp
        If key1Tog Then
            key1Tog = False
            HKey1 = e.KeyCode
            e.SuppressKeyPress = True
            If e.KeyCode = Keys.PrintScreen Then
                btnHkey1.Text = "Print Screen"
            Else
                Select Case e.KeyCode

                    Case 112 To 123
                        btnHkey1.Text = "F" & e.KeyCode - 111
                    Case 32
                        btnHkey1.Text = "SPACE"
                    Case 8
                        btnHkey1.Text = "BACKSPACE"
                    Case 16
                        btnHkey1.Text = "SHIFT"
                    Case 17
                        btnHkey1.Text = "CTRL"
                    Case 18
                        btnHkey1.Text = "ALT"
                    Case 9
                        btnHkey1.Text = "TAB"
                    Case 20
                        btnHkey1.Text = "CAPSLOCK"
                    Case 45
                        btnHkey1.Text = "INS"
                    Case 46
                        btnHkey1.Text = "DELETE"
                    Case 36
                        btnHkey1.Text = "HOME"
                    Case 35
                        btnHkey1.Text = "END"
                    Case 33
                        btnHkey1.Text = "PG UP"
                    Case 34
                        btnHkey1.Text = "PG DOWN"
                    Case Else
                        btnHkey1.Text = chTemp
                End Select
            End If
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Location.X + Main.Width + 25, Main.Location.Y)
        btnHkey1.Text = My.Settings.HKey1Text
        btnHkey2.Text = My.Settings.HKey2Text
        cbCommands.Checked = Commands
        cbAnimations.Checked = Animate
        cbFullscreen.Checked = Fullscreen
        cbDebug.Checked = Debug
    End Sub

    Private Sub Settings_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If key1Tog Or key2Tog Then
            chTemp = Chr(AscW(e.KeyChar)).ToString.ToUpper()
        End If
    End Sub

    Private Sub btnHkey2_KeyUp(sender As Object, e As KeyEventArgs) Handles btnHkey2.KeyUp
        If key2Tog Then
            key2Tog = False
            HKey2 = e.KeyCode
            e.SuppressKeyPress = True
            If e.KeyCode = Keys.PrintScreen Then
                btnHkey2.Text = "Print Screen"
            Else
                Select Case e.KeyCode

                    Case 112 To 123
                        btnHkey2.Text = "F" & e.KeyCode - 111
                    Case 32
                        btnHkey2.Text = "SPACE"
                    Case 8
                        btnHkey2.Text = "BACKSPACE"
                    Case 16
                        btnHkey2.Text = "SHIFT"
                    Case 17
                        btnHkey2.Text = "CTRL"
                    Case 18
                        btnHkey2.Text = "ALT"
                    Case 9
                        btnHkey2.Text = "TAB"
                    Case 20
                        btnHkey2.Text = "CAPSLOCK"
                    Case 45
                        btnHkey2.Text = "INS"
                    Case 46
                        btnHkey2.Text = "DELETE"
                    Case 36
                        btnHkey2.Text = "HOME"
                    Case 35
                        btnHkey2.Text = "END"
                    Case 33
                        btnHkey2.Text = "PG UP"
                    Case 34
                        btnHkey2.Text = "PG DOWN"
                    Case Else
                        btnHkey2.Text = chTemp
                End Select
            End If
        End If
    End Sub

    Private Sub Settings_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If key1Tog Then
            key1Tog = False
            HKey1 = e.KeyCode
            e.SuppressKeyPress = True
            If e.KeyCode = Keys.PrintScreen Then
                btnHkey1.Text = "Print Screen"
            Else
                Select Case e.KeyCode

                    Case 112 To 123
                        btnHkey1.Text = "F" & e.KeyCode - 111
                    Case 32
                        btnHkey1.Text = "SPACE"
                    Case 8
                        btnHkey1.Text = "BACKSPACE"
                    Case 16
                        btnHkey1.Text = "SHIFT"
                    Case 17
                        btnHkey1.Text = "CTRL"
                    Case 18
                        btnHkey1.Text = "ALT"
                    Case 9
                        btnHkey1.Text = "TAB"
                    Case 20
                        btnHkey1.Text = "CAPSLOCK"
                    Case 45
                        btnHkey1.Text = "INS"
                    Case 46
                        btnHkey1.Text = "DELETE"
                    Case 36
                        btnHkey1.Text = "HOME"
                    Case 35
                        btnHkey1.Text = "END"
                    Case 33
                        btnHkey1.Text = "PG UP"
                    Case 34
                        btnHkey1.Text = "PG DOWN"
                    Case Else
                        btnHkey1.Text = chTemp
                End Select
            End If
        ElseIf key2Tog Then
            key2Tog = False
            HKey2 = e.KeyCode
            e.SuppressKeyPress = True
            If e.KeyCode = Keys.PrintScreen Then
                btnHkey2.Text = "Print Screen"
            Else
                Select Case e.KeyCode

                    Case 112 To 123
                        btnHkey2.Text = "F" & e.KeyCode - 111
                    Case 32
                        btnHkey2.Text = "SPACE"
                    Case 8
                        btnHkey2.Text = "BACKSPACE"
                    Case 16
                        btnHkey2.Text = "SHIFT"
                    Case 17
                        btnHkey2.Text = "CTRL"
                    Case 18
                        btnHkey2.Text = "ALT"
                    Case 9
                        btnHkey2.Text = "TAB"
                    Case 20
                        btnHkey2.Text = "CAPSLOCK"
                    Case 45
                        btnHkey2.Text = "INS"
                    Case 46
                        btnHkey2.Text = "DELETE"
                    Case 36
                        btnHkey2.Text = "HOME"
                    Case 35
                        btnHkey2.Text = "END"
                    Case 33
                        btnHkey2.Text = "PG UP"
                    Case 34
                        btnHkey2.Text = "PG DOWN"
                    Case Else
                        btnHkey2.Text = chTemp
                End Select
            End If
        End If
    End Sub

    Private Sub btnHkey2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnHkey2.KeyPress
        If key1Tog Or key2Tog Then
            chTemp = Chr(AscW(e.KeyChar)).ToString.ToUpper()
        End If
    End Sub

    Private Sub btnHkey1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnHkey1.KeyPress
        If key1Tog Or key2Tog Then
            chTemp = Chr(AscW(e.KeyChar)).ToString.ToUpper()
        End If
    End Sub

    Private Sub btnHkey2_Click(sender As Object, e As EventArgs) Handles btnHkey2.Click
        If Not key2Tog Then
            btnHkey2.Text = "..."
            key2Tog = True
        Else
            btnHkey2.Text = My.Settings.HKey2Text
        End If
    End Sub

    Private Sub Settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Settings.Animate = cbAnimations.Checked
        My.Settings.Commands = cbCommands.Checked
        My.Settings.HKey1 = HKey1
        My.Settings.HKey2 = HKey2
        My.Settings.HKey1Text = btnHkey1.Text
        My.Settings.HKey2Text = btnHkey2.Text
        My.Settings.Debug = cbDebug.Checked
        My.Settings.Save()
    End Sub

    Private Sub cbFullscreen_Click(sender As Object, e As EventArgs) Handles cbFullscreen.Click
        Dim msgChoice
        If Not Fullscreen Then
            Fullscreen = True
            HideShots = False
            msgChoice = MsgBox("Would you like to disable Steam Screenshot Notifications?", MsgBoxStyle.YesNo, "Fullscreen Mode")
            If msgChoice = MsgBoxResult.Yes Then
                HideShots = True
            End If
            If Not System.IO.Directory.GetDirectories("C:\Program Files (x86)\Steam\userdata").Count = 1 Then
                For Each userDir As String In System.IO.Directory.GetDirectories("C:\Program Files (x86)\Steam\userdata")
                    Dim settingsFile As String = My.Computer.FileSystem.ReadAllText(userDir & "\config\localconfig.vdf")
                    Dim lines = settingsFile.Split({vbCrLf, vbCr, vbLf}, StringSplitOptions.None)
                    Dim match = lines.FirstOrDefault(Function(x) x.Contains("PersonaName"))
                    msgChoice = MsgBox(match.Split("""")(3) & vbNewLine & vbNewLine & "Is this you?", vbYesNo, "Fullscreen Mode")
                    If msgChoice = MsgBoxResult.Yes Then
                        LocStorage = userDir
                        SettingsStorage = settingsFile
                        If HideShots Then
                            settingsFile = settingsFile.Replace("""InGameOverlayScreenshotNotification""		""1""", """InGameOverlayScreenshotNotification""		""0""")
                            settingsFile = settingsFile.Replace("""InGameOverlayScreenshotPlaySound""		""1""", """InGameOverlayScreenshotPlaySound""		""0""")
                            My.Computer.FileSystem.WriteAllText(userDir & "\config\localconfig.vdf", settingsFile, False)
                            MsgBox("Restart Steam to hide screenshot notification.")
                        End If
                        If Directory.GetFiles(LocStorage & "\760\remote\230410\screenshots").Count = 0 Then
                            LastFile = ""
                        Else
                            LastFile = Directory.GetFiles(LocStorage & "\760\remote\230410\screenshots").OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First()
                        End If
                        Exit For
                    End If
                Next
                cbFullscreen.Checked = False
                MsgBox("Unable to find user!")
            Else
                Dim userDir As String = System.IO.Directory.GetDirectories("C:\Program Files (x86)\Steam\userdata")(0)
                Dim settingsFile As String = My.Computer.FileSystem.ReadAllText(userDir & "\config\localconfig.vdf")
                Dim lines = settingsFile.Split({vbCrLf, vbCr, vbLf}, StringSplitOptions.None)
                Dim match = lines.FirstOrDefault(Function(x) x.Contains("PersonaName"))
                msgChoice = MsgBox(match.Split("""")(3) & vbNewLine & vbNewLine & "Is this you?", vbYesNo, "Fullscreen Mode")
                If msgChoice = MsgBoxResult.No Then
                    cbFullscreen.Checked = False
                    MsgBox("Unable to find user!")
                Else
                    LocStorage = userDir
                    SettingsStorage = settingsFile
                    If HideShots Then
                        settingsFile = settingsFile.Replace("""InGameOverlayScreenshotNotification""		""1""", """InGameOverlayScreenshotNotification""		""0""")
                        settingsFile = settingsFile.Replace("""InGameOverlayScreenshotPlaySound""		""1""", """InGameOverlayScreenshotPlaySound""		""0""")
                        My.Computer.FileSystem.WriteAllText(userDir & "\config\localconfig.vdf", settingsFile, False)
                        MsgBox("Restart Steam to hide screenshot notification.")
                    End If
                    If Directory.GetFiles(LocStorage & "\760\remote\230410\screenshots").Count = 0 Then
                        LastFile = ""
                    Else
                        LastFile = Directory.GetFiles(LocStorage & "\760\remote\230410\screenshots").OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First()
                    End If
                End If
            End If
        Else
            Fullscreen = False
            If HideShots Then
                My.Computer.FileSystem.WriteAllText(LocStorage & "\config\localconfig.vdf", SettingsStorage, False)
            End If

        End If
    End Sub

    Private Sub cbAnimations_Click(sender As Object, e As EventArgs) Handles cbAnimations.Click
        My.Settings.Animate = cbAnimations.Checked
        Animate = cbAnimations.Checked
    End Sub

    Private Sub cbCommands_Click(sender As Object, e As EventArgs) Handles cbCommands.Click
        My.Settings.Commands = cbCommands.Checked
        Commands = cbCommands.Checked
    End Sub

    Private Sub cbDebug_Click(sender As Object, e As EventArgs) Handles cbDebug.Click
        My.Settings.Debug = cbDebug.Checked
        Debug = cbDebug.Checked
    End Sub

    Private Sub pTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles pTitle.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub pTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles pTitle.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub pTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles pTitle.MouseUp
        drag = False
    End Sub

    Private Sub lbTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lbTitle.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub lbTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lbTitle.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub lbTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lbTitle.MouseUp
        drag = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class