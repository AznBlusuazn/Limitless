<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.TitleBarIcon = New System.Windows.Forms.Panel()
        Me.MinimizeButton = New System.Windows.Forms.Panel()
        Me.MinimizeText = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.FooterPanel = New System.Windows.Forms.Panel()
        Me.MainMenuPanel = New System.Windows.Forms.Panel()
        Me.OptionsPanel = New System.Windows.Forms.Panel()
        Me.OptionsColorGroup = New System.Windows.Forms.GroupBox()
        Me.OptionsColorCustom = New System.Windows.Forms.CheckBox()
        Me.OptionsColorLite = New System.Windows.Forms.CheckBox()
        Me.OptionsColorDark = New System.Windows.Forms.CheckBox()
        Me.OptionsHost = New System.Windows.Forms.Label()
        Me.OptionsTitle = New System.Windows.Forms.Label()
        Me.AboutPanel = New System.Windows.Forms.Panel()
        Me.AboutBSButton = New System.Windows.Forms.Button()
        Me.AboutYTButton = New System.Windows.Forms.Button()
        Me.AboutDCButton = New System.Windows.Forms.Button()
        Me.AboutFBButton = New System.Windows.Forms.Button()
        Me.AboutText = New System.Windows.Forms.TextBox()
        Me.AboutTitle = New System.Windows.Forms.Label()
        Me.WelcomePanel = New System.Windows.Forms.Panel()
        Me.WelcomeImage0 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage1 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage2 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage4 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage3 = New System.Windows.Forms.PictureBox()
        Me.MainMenuBar = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DonateButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.OptionsButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.TitleLogo = New System.Windows.Forms.PictureBox()
        Me.DonatePanel = New System.Windows.Forms.Panel()
        Me.DonatePPButton = New System.Windows.Forms.Button()
        Me.DonatePTButton = New System.Windows.Forms.Button()
        Me.DonateText = New System.Windows.Forms.TextBox()
        Me.DonateTitle = New System.Windows.Forms.Label()
        Me.OptionsMusicGroup = New System.Windows.Forms.GroupBox()
        Me.OptionsAudioCheckIntro = New System.Windows.Forms.CheckBox()
        Me.OptionsAudioCheckCustom = New System.Windows.Forms.CheckBox()
        Me.OptionsAudioCheckMusic = New System.Windows.Forms.CheckBox()
        Me.OptionsAudioCheckBattle = New System.Windows.Forms.CheckBox()
        Me.OptionsAudioCheckVictory = New System.Windows.Forms.CheckBox()
        Me.OptionsAudioCheckDefeat = New System.Windows.Forms.CheckBox()
        Me.OptionsAudioCheckSound = New System.Windows.Forms.CheckBox()
        Me.OptionsAudioSelectIntro = New System.Windows.Forms.Button()
        Me.OptionsAudioSelectBattle = New System.Windows.Forms.Button()
        Me.OptionsAudioSelectVictory = New System.Windows.Forms.Button()
        Me.OptionsAudioSelectDefeat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TitleBarPanel.SuspendLayout()
        Me.MinimizeButton.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.MainMenuPanel.SuspendLayout()
        Me.OptionsPanel.SuspendLayout()
        Me.OptionsColorGroup.SuspendLayout()
        Me.AboutPanel.SuspendLayout()
        Me.WelcomePanel.SuspendLayout()
        CType(Me.WelcomeImage0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenuBar.SuspendLayout()
        CType(Me.TitleLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DonatePanel.SuspendLayout()
        Me.OptionsMusicGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        resources.ApplyResources(Me.TitleLabel, "TitleLabel")
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TitleLabel.Name = "TitleLabel"
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TitleBarPanel.Controls.Add(Me.TitleBarIcon)
        Me.TitleBarPanel.Controls.Add(Me.MinimizeButton)
        Me.TitleBarPanel.Controls.Add(Me.CloseButton)
        Me.TitleBarPanel.Controls.Add(Me.TitleLabel)
        resources.ApplyResources(Me.TitleBarPanel, "TitleBarPanel")
        Me.TitleBarPanel.Name = "TitleBarPanel"
        '
        'TitleBarIcon
        '
        Me.TitleBarIcon.BackgroundImage = Global.Limitless.My.Resources.Resources.logo
        resources.ApplyResources(Me.TitleBarIcon, "TitleBarIcon")
        Me.TitleBarIcon.Name = "TitleBarIcon"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.MinimizeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MinimizeButton.Controls.Add(Me.MinimizeText)
        Me.MinimizeButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        resources.ApplyResources(Me.MinimizeButton, "MinimizeButton")
        Me.MinimizeButton.Name = "MinimizeButton"
        '
        'MinimizeText
        '
        resources.ApplyResources(Me.MinimizeText, "MinimizeText")
        Me.MinimizeText.BackColor = System.Drawing.SystemColors.WindowText
        Me.MinimizeText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.MinimizeText.Name = "MinimizeText"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        resources.ApplyResources(Me.CloseButton, "CloseButton")
        Me.CloseButton.Name = "CloseButton"
        '
        'CloseText
        '
        resources.ApplyResources(Me.CloseText, "CloseText")
        Me.CloseText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseText.Name = "CloseText"
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.FooterPanel)
        Me.BackgroundPanel.Controls.Add(Me.MainMenuPanel)
        resources.ApplyResources(Me.BackgroundPanel, "BackgroundPanel")
        Me.BackgroundPanel.Name = "BackgroundPanel"
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.FooterPanel, "FooterPanel")
        Me.FooterPanel.Name = "FooterPanel"
        '
        'MainMenuPanel
        '
        Me.MainMenuPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuPanel.Controls.Add(Me.OptionsPanel)
        Me.MainMenuPanel.Controls.Add(Me.AboutPanel)
        Me.MainMenuPanel.Controls.Add(Me.WelcomePanel)
        Me.MainMenuPanel.Controls.Add(Me.MainMenuBar)
        Me.MainMenuPanel.Controls.Add(Me.TitleLogo)
        Me.MainMenuPanel.Controls.Add(Me.DonatePanel)
        resources.ApplyResources(Me.MainMenuPanel, "MainMenuPanel")
        Me.MainMenuPanel.Name = "MainMenuPanel"
        '
        'OptionsPanel
        '
        Me.OptionsPanel.Controls.Add(Me.GroupBox1)
        Me.OptionsPanel.Controls.Add(Me.OptionsMusicGroup)
        Me.OptionsPanel.Controls.Add(Me.OptionsColorGroup)
        Me.OptionsPanel.Controls.Add(Me.OptionsHost)
        Me.OptionsPanel.Controls.Add(Me.OptionsTitle)
        resources.ApplyResources(Me.OptionsPanel, "OptionsPanel")
        Me.OptionsPanel.Name = "OptionsPanel"
        '
        'OptionsColorGroup
        '
        Me.OptionsColorGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.OptionsColorGroup.Controls.Add(Me.OptionsColorCustom)
        Me.OptionsColorGroup.Controls.Add(Me.OptionsColorLite)
        Me.OptionsColorGroup.Controls.Add(Me.OptionsColorDark)
        Me.OptionsColorGroup.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.OptionsColorGroup, "OptionsColorGroup")
        Me.OptionsColorGroup.Name = "OptionsColorGroup"
        Me.OptionsColorGroup.TabStop = False
        '
        'OptionsColorCustom
        '
        resources.ApplyResources(Me.OptionsColorCustom, "OptionsColorCustom")
        Me.OptionsColorCustom.Name = "OptionsColorCustom"
        Me.OptionsColorCustom.UseVisualStyleBackColor = False
        '
        'OptionsColorLite
        '
        resources.ApplyResources(Me.OptionsColorLite, "OptionsColorLite")
        Me.OptionsColorLite.Name = "OptionsColorLite"
        Me.OptionsColorLite.UseVisualStyleBackColor = True
        '
        'OptionsColorDark
        '
        resources.ApplyResources(Me.OptionsColorDark, "OptionsColorDark")
        Me.OptionsColorDark.Name = "OptionsColorDark"
        Me.OptionsColorDark.UseVisualStyleBackColor = True
        '
        'OptionsHost
        '
        resources.ApplyResources(Me.OptionsHost, "OptionsHost")
        Me.OptionsHost.Name = "OptionsHost"
        '
        'OptionsTitle
        '
        resources.ApplyResources(Me.OptionsTitle, "OptionsTitle")
        Me.OptionsTitle.Name = "OptionsTitle"
        '
        'AboutPanel
        '
        Me.AboutPanel.Controls.Add(Me.AboutBSButton)
        Me.AboutPanel.Controls.Add(Me.AboutYTButton)
        Me.AboutPanel.Controls.Add(Me.AboutDCButton)
        Me.AboutPanel.Controls.Add(Me.AboutFBButton)
        Me.AboutPanel.Controls.Add(Me.AboutText)
        Me.AboutPanel.Controls.Add(Me.AboutTitle)
        resources.ApplyResources(Me.AboutPanel, "AboutPanel")
        Me.AboutPanel.Name = "AboutPanel"
        '
        'AboutBSButton
        '
        Me.AboutBSButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutBSButton.BackgroundImage = Global.Limitless.My.Resources.Resources.bs
        resources.ApplyResources(Me.AboutBSButton, "AboutBSButton")
        Me.AboutBSButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutBSButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutBSButton.Name = "AboutBSButton"
        Me.AboutBSButton.UseVisualStyleBackColor = False
        '
        'AboutYTButton
        '
        Me.AboutYTButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutYTButton.BackgroundImage = Global.Limitless.My.Resources.Resources.yt
        resources.ApplyResources(Me.AboutYTButton, "AboutYTButton")
        Me.AboutYTButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutYTButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutYTButton.Name = "AboutYTButton"
        Me.AboutYTButton.UseVisualStyleBackColor = False
        '
        'AboutDCButton
        '
        Me.AboutDCButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutDCButton.BackgroundImage = Global.Limitless.My.Resources.Resources.dc
        resources.ApplyResources(Me.AboutDCButton, "AboutDCButton")
        Me.AboutDCButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutDCButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutDCButton.Name = "AboutDCButton"
        Me.AboutDCButton.UseVisualStyleBackColor = False
        '
        'AboutFBButton
        '
        Me.AboutFBButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutFBButton.BackgroundImage = Global.Limitless.My.Resources.Resources.fb
        resources.ApplyResources(Me.AboutFBButton, "AboutFBButton")
        Me.AboutFBButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutFBButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutFBButton.Name = "AboutFBButton"
        Me.AboutFBButton.UseVisualStyleBackColor = False
        '
        'AboutText
        '
        Me.AboutText.BackColor = System.Drawing.SystemColors.ControlText
        Me.AboutText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AboutText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AboutText.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.AboutText, "AboutText")
        Me.AboutText.Name = "AboutText"
        Me.AboutText.ReadOnly = True
        Me.AboutText.TabStop = False
        '
        'AboutTitle
        '
        resources.ApplyResources(Me.AboutTitle, "AboutTitle")
        Me.AboutTitle.Name = "AboutTitle"
        '
        'WelcomePanel
        '
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage0)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage1)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage2)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage4)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage3)
        resources.ApplyResources(Me.WelcomePanel, "WelcomePanel")
        Me.WelcomePanel.Name = "WelcomePanel"
        '
        'WelcomeImage0
        '
        resources.ApplyResources(Me.WelcomeImage0, "WelcomeImage0")
        Me.WelcomeImage0.Name = "WelcomeImage0"
        Me.WelcomeImage0.TabStop = False
        '
        'WelcomeImage1
        '
        resources.ApplyResources(Me.WelcomeImage1, "WelcomeImage1")
        Me.WelcomeImage1.Name = "WelcomeImage1"
        Me.WelcomeImage1.TabStop = False
        '
        'WelcomeImage2
        '
        resources.ApplyResources(Me.WelcomeImage2, "WelcomeImage2")
        Me.WelcomeImage2.Name = "WelcomeImage2"
        Me.WelcomeImage2.TabStop = False
        '
        'WelcomeImage4
        '
        resources.ApplyResources(Me.WelcomeImage4, "WelcomeImage4")
        Me.WelcomeImage4.Name = "WelcomeImage4"
        Me.WelcomeImage4.TabStop = False
        '
        'WelcomeImage3
        '
        resources.ApplyResources(Me.WelcomeImage3, "WelcomeImage3")
        Me.WelcomeImage3.Name = "WelcomeImage3"
        Me.WelcomeImage3.TabStop = False
        '
        'MainMenuBar
        '
        Me.MainMenuBar.Controls.Add(Me.ExitButton)
        Me.MainMenuBar.Controls.Add(Me.UpdateButton)
        Me.MainMenuBar.Controls.Add(Me.DonateButton)
        Me.MainMenuBar.Controls.Add(Me.AboutButton)
        Me.MainMenuBar.Controls.Add(Me.OptionsButton)
        Me.MainMenuBar.Controls.Add(Me.EditButton)
        Me.MainMenuBar.Controls.Add(Me.LoadButton)
        Me.MainMenuBar.Controls.Add(Me.StartButton)
        resources.ApplyResources(Me.MainMenuBar, "MainMenuBar")
        Me.MainMenuBar.Name = "MainMenuBar"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ExitButton, "ExitButton")
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.UpdateButton, "UpdateButton")
        Me.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.Control
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DonateButton
        '
        Me.DonateButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.DonateButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DonateButton, "DonateButton")
        Me.DonateButton.ForeColor = System.Drawing.SystemColors.Control
        Me.DonateButton.Name = "DonateButton"
        Me.DonateButton.UseVisualStyleBackColor = False
        '
        'AboutButton
        '
        Me.AboutButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AboutButton, "AboutButton")
        Me.AboutButton.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'OptionsButton
        '
        Me.OptionsButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.OptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OptionsButton, "OptionsButton")
        Me.OptionsButton.ForeColor = System.Drawing.SystemColors.Control
        Me.OptionsButton.Name = "OptionsButton"
        Me.OptionsButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.EditButton, "EditButton")
        Me.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.EditButton.ForeColor = System.Drawing.SystemColors.Control
        Me.EditButton.Name = "EditButton"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.LoadButton, "LoadButton")
        Me.LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.LoadButton.ForeColor = System.Drawing.SystemColors.Control
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.StartButton, "StartButton")
        Me.StartButton.ForeColor = System.Drawing.SystemColors.Control
        Me.StartButton.Name = "StartButton"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'TitleLogo
        '
        Me.TitleLogo.BackgroundImage = Global.Limitless.My.Resources.Resources.logo
        resources.ApplyResources(Me.TitleLogo, "TitleLogo")
        Me.TitleLogo.Name = "TitleLogo"
        Me.TitleLogo.TabStop = False
        '
        'DonatePanel
        '
        Me.DonatePanel.Controls.Add(Me.DonatePPButton)
        Me.DonatePanel.Controls.Add(Me.DonatePTButton)
        Me.DonatePanel.Controls.Add(Me.DonateText)
        Me.DonatePanel.Controls.Add(Me.DonateTitle)
        resources.ApplyResources(Me.DonatePanel, "DonatePanel")
        Me.DonatePanel.Name = "DonatePanel"
        '
        'DonatePPButton
        '
        Me.DonatePPButton.BackColor = System.Drawing.SystemColors.Control
        Me.DonatePPButton.BackgroundImage = Global.Limitless.My.Resources.Resources.pp
        resources.ApplyResources(Me.DonatePPButton, "DonatePPButton")
        Me.DonatePPButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DonatePPButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DonatePPButton.Name = "DonatePPButton"
        Me.DonatePPButton.UseVisualStyleBackColor = False
        '
        'DonatePTButton
        '
        Me.DonatePTButton.BackColor = System.Drawing.SystemColors.Control
        Me.DonatePTButton.BackgroundImage = Global.Limitless.My.Resources.Resources.pt
        resources.ApplyResources(Me.DonatePTButton, "DonatePTButton")
        Me.DonatePTButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DonatePTButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DonatePTButton.Name = "DonatePTButton"
        Me.DonatePTButton.UseVisualStyleBackColor = False
        '
        'DonateText
        '
        Me.DonateText.BackColor = System.Drawing.SystemColors.ControlText
        Me.DonateText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DonateText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DonateText.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.DonateText, "DonateText")
        Me.DonateText.Name = "DonateText"
        Me.DonateText.ReadOnly = True
        Me.DonateText.TabStop = False
        '
        'DonateTitle
        '
        resources.ApplyResources(Me.DonateTitle, "DonateTitle")
        Me.DonateTitle.Name = "DonateTitle"
        '
        'OptionsMusicGroup
        '
        Me.OptionsMusicGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioSelectDefeat)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioSelectVictory)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioSelectBattle)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioSelectIntro)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioCheckSound)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioCheckDefeat)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioCheckVictory)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioCheckBattle)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioCheckIntro)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioCheckCustom)
        Me.OptionsMusicGroup.Controls.Add(Me.OptionsAudioCheckMusic)
        Me.OptionsMusicGroup.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.OptionsMusicGroup, "OptionsMusicGroup")
        Me.OptionsMusicGroup.Name = "OptionsMusicGroup"
        Me.OptionsMusicGroup.TabStop = False
        '
        'OptionsAudioCheckIntro
        '
        resources.ApplyResources(Me.OptionsAudioCheckIntro, "OptionsAudioCheckIntro")
        Me.OptionsAudioCheckIntro.Name = "OptionsAudioCheckIntro"
        Me.OptionsAudioCheckIntro.UseVisualStyleBackColor = False
        '
        'OptionsAudioCheckCustom
        '
        resources.ApplyResources(Me.OptionsAudioCheckCustom, "OptionsAudioCheckCustom")
        Me.OptionsAudioCheckCustom.Name = "OptionsAudioCheckCustom"
        Me.OptionsAudioCheckCustom.UseVisualStyleBackColor = True
        '
        'OptionsAudioCheckMusic
        '
        resources.ApplyResources(Me.OptionsAudioCheckMusic, "OptionsAudioCheckMusic")
        Me.OptionsAudioCheckMusic.Name = "OptionsAudioCheckMusic"
        Me.OptionsAudioCheckMusic.UseVisualStyleBackColor = True
        '
        'OptionsAudioCheckBattle
        '
        resources.ApplyResources(Me.OptionsAudioCheckBattle, "OptionsAudioCheckBattle")
        Me.OptionsAudioCheckBattle.Name = "OptionsAudioCheckBattle"
        Me.OptionsAudioCheckBattle.UseVisualStyleBackColor = False
        '
        'OptionsAudioCheckVictory
        '
        resources.ApplyResources(Me.OptionsAudioCheckVictory, "OptionsAudioCheckVictory")
        Me.OptionsAudioCheckVictory.Name = "OptionsAudioCheckVictory"
        Me.OptionsAudioCheckVictory.UseVisualStyleBackColor = False
        '
        'OptionsAudioCheckDefeat
        '
        resources.ApplyResources(Me.OptionsAudioCheckDefeat, "OptionsAudioCheckDefeat")
        Me.OptionsAudioCheckDefeat.Name = "OptionsAudioCheckDefeat"
        Me.OptionsAudioCheckDefeat.UseVisualStyleBackColor = False
        '
        'OptionsAudioCheckSound
        '
        resources.ApplyResources(Me.OptionsAudioCheckSound, "OptionsAudioCheckSound")
        Me.OptionsAudioCheckSound.Checked = True
        Me.OptionsAudioCheckSound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OptionsAudioCheckSound.Name = "OptionsAudioCheckSound"
        Me.OptionsAudioCheckSound.UseVisualStyleBackColor = True
        '
        'OptionsAudioSelectIntro
        '
        Me.OptionsAudioSelectIntro.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OptionsAudioSelectIntro, "OptionsAudioSelectIntro")
        Me.OptionsAudioSelectIntro.Name = "OptionsAudioSelectIntro"
        Me.OptionsAudioSelectIntro.UseVisualStyleBackColor = False
        '
        'OptionsAudioSelectBattle
        '
        Me.OptionsAudioSelectBattle.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OptionsAudioSelectBattle, "OptionsAudioSelectBattle")
        Me.OptionsAudioSelectBattle.Name = "OptionsAudioSelectBattle"
        Me.OptionsAudioSelectBattle.UseVisualStyleBackColor = False
        '
        'OptionsAudioSelectVictory
        '
        Me.OptionsAudioSelectVictory.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OptionsAudioSelectVictory, "OptionsAudioSelectVictory")
        Me.OptionsAudioSelectVictory.Name = "OptionsAudioSelectVictory"
        Me.OptionsAudioSelectVictory.UseVisualStyleBackColor = False
        '
        'OptionsAudioSelectDefeat
        '
        Me.OptionsAudioSelectDefeat.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OptionsAudioSelectDefeat, "OptionsAudioSelectDefeat")
        Me.OptionsAudioSelectDefeat.Name = "OptionsAudioSelectDefeat"
        Me.OptionsAudioSelectDefeat.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MainWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.TitleBarPanel.ResumeLayout(False)
        Me.TitleBarPanel.PerformLayout()
        Me.MinimizeButton.ResumeLayout(False)
        Me.MinimizeButton.PerformLayout()
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.MainMenuPanel.ResumeLayout(False)
        Me.OptionsPanel.ResumeLayout(False)
        Me.OptionsColorGroup.ResumeLayout(False)
        Me.OptionsColorGroup.PerformLayout()
        Me.AboutPanel.ResumeLayout(False)
        Me.AboutPanel.PerformLayout()
        Me.WelcomePanel.ResumeLayout(False)
        CType(Me.WelcomeImage0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenuBar.ResumeLayout(False)
        CType(Me.TitleLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DonatePanel.ResumeLayout(False)
        Me.DonatePanel.PerformLayout()
        Me.OptionsMusicGroup.ResumeLayout(False)
        Me.OptionsMusicGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84



    Friend WithEvents TitleLabel As Label
    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents MinimizeButton As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents MinimizeText As Label
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleBarIcon As Panel
    Friend WithEvents MainMenuPanel As Panel
    Friend WithEvents TitleLogo As PictureBox
    Friend WithEvents FooterPanel As Panel
    Friend WithEvents MainMenuBar As Panel
    Friend WithEvents WelcomePanel As Panel
    Friend WithEvents WelcomeImage0 As PictureBox
    Friend WithEvents WelcomeImage1 As PictureBox
    Friend WithEvents WelcomeImage2 As PictureBox
    Friend WithEvents WelcomeImage4 As PictureBox
    Friend WithEvents WelcomeImage3 As PictureBox
    Friend WithEvents StartButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents LoadButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DonateButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents OptionsButton As Button
    Friend WithEvents AboutPanel As Panel
    Friend WithEvents AboutTitle As Label
    Friend WithEvents AboutText As TextBox
    Friend WithEvents AboutFBButton As Button
    Friend WithEvents AboutBSButton As Button
    Friend WithEvents AboutYTButton As Button
    Friend WithEvents AboutDCButton As Button
    Friend WithEvents DonatePanel As Panel
    Friend WithEvents DonatePPButton As Button
    Friend WithEvents DonatePTButton As Button
    Friend WithEvents DonateText As TextBox
    Friend WithEvents DonateTitle As Label
    Friend WithEvents OptionsPanel As Panel
    Friend WithEvents OptionsTitle As Label
    Friend WithEvents OptionsHost As Label
    Friend WithEvents OptionsColorGroup As GroupBox
    Friend WithEvents OptionsColorDark As CheckBox
    Friend WithEvents OptionsColorCustom As CheckBox
    Friend WithEvents OptionsColorLite As CheckBox
    Friend WithEvents OptionsMusicGroup As GroupBox
    Friend WithEvents OptionsAudioSelectDefeat As Button
    Friend WithEvents OptionsAudioSelectVictory As Button
    Friend WithEvents OptionsAudioSelectBattle As Button
    Friend WithEvents OptionsAudioSelectIntro As Button
    Friend WithEvents OptionsAudioCheckSound As CheckBox
    Friend WithEvents OptionsAudioCheckDefeat As CheckBox
    Friend WithEvents OptionsAudioCheckVictory As CheckBox
    Friend WithEvents OptionsAudioCheckBattle As CheckBox
    Friend WithEvents OptionsAudioCheckIntro As CheckBox
    Friend WithEvents OptionsAudioCheckCustom As CheckBox
    Friend WithEvents OptionsAudioCheckMusic As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
