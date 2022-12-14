Imports System.IO

Public Module Initialize

    Public Sub InitProcess()
        InitFolders()
        InitHide()
        InitSettings()
        InitPanels()
        Avatars.TitleScreen()

    End Sub

    Private Sub InitFolders()
        FilesFolders.CreateDirectory(MemoryBank.AvatarsDir)
        FilesFolders.CreateDirectory(MemoryBank.DataDir)
        FilesFolders.CreateDirectory(MemoryBank.SavesDir)
    End Sub

    Private Sub InitHide()
        FilesFolders.HideFolder(MemoryBank.LibDir)
        FilesFolders.HideFile(LCase(Application.ProductName) & ".exe.config")
    End Sub

    Private Sub InitSettings()
        If Not File.Exists(MemoryBank.SettingsFile & "." &
                           MemoryBank.SettingsExt) Then
            Settings.CreateSettings()
            Settings.BuildDefault()
        End If
    End Sub

    Private Sub InitPanels()
        MainWindow.WelcomePanel.Visible = True
        MainWindow.AboutPanel.Visible = False
        MainWindow.DonatePanel.Visible = False
        MainWindow.OptionsPanel.Visible = False
    End Sub

End Module
