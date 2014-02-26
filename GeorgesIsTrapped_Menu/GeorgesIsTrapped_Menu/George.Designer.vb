<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class George
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(George))
        Me.BoardContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblremainingTime = New System.Windows.Forms.Label()
        Me.PcbGeorgesLeft = New System.Windows.Forms.PictureBox()
        Me.PcbGeorgesRight = New System.Windows.Forms.PictureBox()
        Me.PcbGeorgesUp = New System.Windows.Forms.PictureBox()
        Me.PcbGeorgesDown = New System.Windows.Forms.PictureBox()
        Me.PcbÉchelle = New System.Windows.Forms.PictureBox()
        Me.PcbRoche = New System.Windows.Forms.PictureBox()
        Me.PcbBrique = New System.Windows.Forms.PictureBox()
        Me.PcbGazon = New System.Windows.Forms.PictureBox()
        Me.TmrTempsLimite = New System.Windows.Forms.Timer(Me.components)
        Me.lblVictoire = New System.Windows.Forms.Label()
        Me.lblVictoireMessage = New System.Windows.Forms.Label()
        Me.lblNiveau = New System.Windows.Forms.Label()
        Me.lblNombreNiveau = New System.Windows.Forms.Label()
        Me.lblÉchelle = New System.Windows.Forms.Label()
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.lblGoToMenu = New System.Windows.Forms.Label()
        Me.lblMenuSelected = New System.Windows.Forms.Label()
        Me.lblNextLevel = New System.Windows.Forms.Label()
        Me.lblNextLevelSelected = New System.Windows.Forms.Label()
        CType(Me.PcbGeorgesLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbGeorgesRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbGeorgesUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbGeorgesDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbÉchelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbRoche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbBrique, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbGazon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BoardContainer
        '
        Me.BoardContainer.Location = New System.Drawing.Point(12, 11)
        Me.BoardContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.BoardContainer.Name = "BoardContainer"
        Me.BoardContainer.Size = New System.Drawing.Size(750, 750)
        Me.BoardContainer.TabIndex = 5
        '
        'lblremainingTime
        '
        Me.lblremainingTime.AutoSize = True
        Me.lblremainingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremainingTime.Location = New System.Drawing.Point(905, 184)
        Me.lblremainingTime.Name = "lblremainingTime"
        Me.lblremainingTime.Size = New System.Drawing.Size(89, 29)
        Me.lblremainingTime.TabIndex = 10
        Me.lblremainingTime.Text = "Temps"
        '
        'PcbGeorgesLeft
        '
        Me.PcbGeorgesLeft.Image = Global.GeorgesIsTrapped_Menu.My.Resources.Resources.GeorgesGauche
        Me.PcbGeorgesLeft.Location = New System.Drawing.Point(408, 768)
        Me.PcbGeorgesLeft.Name = "PcbGeorgesLeft"
        Me.PcbGeorgesLeft.Size = New System.Drawing.Size(50, 50)
        Me.PcbGeorgesLeft.TabIndex = 9
        Me.PcbGeorgesLeft.TabStop = False
        Me.PcbGeorgesLeft.Visible = False
        '
        'PcbGeorgesRight
        '
        Me.PcbGeorgesRight.Image = Global.GeorgesIsTrapped_Menu.My.Resources.Resources.GeorgesDroite
        Me.PcbGeorgesRight.Location = New System.Drawing.Point(352, 768)
        Me.PcbGeorgesRight.Name = "PcbGeorgesRight"
        Me.PcbGeorgesRight.Size = New System.Drawing.Size(50, 50)
        Me.PcbGeorgesRight.TabIndex = 8
        Me.PcbGeorgesRight.TabStop = False
        Me.PcbGeorgesRight.Visible = False
        '
        'PcbGeorgesUp
        '
        Me.PcbGeorgesUp.Image = Global.GeorgesIsTrapped_Menu.My.Resources.Resources.GeorgesDos
        Me.PcbGeorgesUp.Location = New System.Drawing.Point(296, 767)
        Me.PcbGeorgesUp.Name = "PcbGeorgesUp"
        Me.PcbGeorgesUp.Size = New System.Drawing.Size(50, 50)
        Me.PcbGeorgesUp.TabIndex = 7
        Me.PcbGeorgesUp.TabStop = False
        Me.PcbGeorgesUp.Visible = False
        '
        'PcbGeorgesDown
        '
        Me.PcbGeorgesDown.Image = Global.GeorgesIsTrapped_Menu.My.Resources.Resources.GeorgesFace
        Me.PcbGeorgesDown.Location = New System.Drawing.Point(240, 768)
        Me.PcbGeorgesDown.Name = "PcbGeorgesDown"
        Me.PcbGeorgesDown.Size = New System.Drawing.Size(50, 50)
        Me.PcbGeorgesDown.TabIndex = 6
        Me.PcbGeorgesDown.TabStop = False
        Me.PcbGeorgesDown.Visible = False
        '
        'PcbÉchelle
        '
        Me.PcbÉchelle.ErrorImage = Nothing
        Me.PcbÉchelle.Image = CType(resources.GetObject("PcbÉchelle.Image"), System.Drawing.Image)
        Me.PcbÉchelle.Location = New System.Drawing.Point(12, 768)
        Me.PcbÉchelle.Name = "PcbÉchelle"
        Me.PcbÉchelle.Size = New System.Drawing.Size(50, 50)
        Me.PcbÉchelle.TabIndex = 4
        Me.PcbÉchelle.TabStop = False
        Me.PcbÉchelle.Visible = False
        '
        'PcbRoche
        '
        Me.PcbRoche.Image = Global.GeorgesIsTrapped_Menu.My.Resources.Resources.Roche
        Me.PcbRoche.Location = New System.Drawing.Point(72, 768)
        Me.PcbRoche.Name = "PcbRoche"
        Me.PcbRoche.Size = New System.Drawing.Size(50, 50)
        Me.PcbRoche.TabIndex = 3
        Me.PcbRoche.TabStop = False
        Me.PcbRoche.Visible = False
        '
        'PcbBrique
        '
        Me.PcbBrique.Image = Global.GeorgesIsTrapped_Menu.My.Resources.Resources.Brique
        Me.PcbBrique.Location = New System.Drawing.Point(128, 767)
        Me.PcbBrique.Name = "PcbBrique"
        Me.PcbBrique.Size = New System.Drawing.Size(50, 51)
        Me.PcbBrique.TabIndex = 2
        Me.PcbBrique.TabStop = False
        Me.PcbBrique.Visible = False
        '
        'PcbGazon
        '
        Me.PcbGazon.Image = Global.GeorgesIsTrapped_Menu.My.Resources.Resources.Gazon
        Me.PcbGazon.Location = New System.Drawing.Point(184, 768)
        Me.PcbGazon.Name = "PcbGazon"
        Me.PcbGazon.Size = New System.Drawing.Size(50, 50)
        Me.PcbGazon.TabIndex = 1
        Me.PcbGazon.TabStop = False
        Me.PcbGazon.Visible = False
        '
        'TmrTempsLimite
        '
        Me.TmrTempsLimite.Interval = 1000
        '
        'lblVictoire
        '
        Me.lblVictoire.AutoSize = True
        Me.lblVictoire.Font = New System.Drawing.Font("Impact", 65.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVictoire.ForeColor = System.Drawing.Color.Red
        Me.lblVictoire.Location = New System.Drawing.Point(757, 367)
        Me.lblVictoire.Name = "lblVictoire"
        Me.lblVictoire.Size = New System.Drawing.Size(390, 106)
        Me.lblVictoire.TabIndex = 17
        Me.lblVictoire.Text = "VICTOIRE!"
        Me.lblVictoire.Visible = False
        '
        'lblVictoireMessage
        '
        Me.lblVictoireMessage.AutoSize = True
        Me.lblVictoireMessage.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVictoireMessage.Location = New System.Drawing.Point(819, 487)
        Me.lblVictoireMessage.Name = "lblVictoireMessage"
        Me.lblVictoireMessage.Size = New System.Drawing.Size(267, 52)
        Me.lblVictoireMessage.TabIndex = 18
        Me.lblVictoireMessage.Text = "George à réussi à s'échapper" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "du labyrinthe!"
        Me.lblVictoireMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVictoireMessage.Visible = False
        '
        'lblNiveau
        '
        Me.lblNiveau.AutoSize = True
        Me.lblNiveau.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiveau.Location = New System.Drawing.Point(893, 125)
        Me.lblNiveau.Name = "lblNiveau"
        Me.lblNiveau.Size = New System.Drawing.Size(88, 39)
        Me.lblNiveau.TabIndex = 21
        Me.lblNiveau.Text = "Carte"
        Me.lblNiveau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombreNiveau
        '
        Me.lblNombreNiveau.AutoSize = True
        Me.lblNombreNiveau.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreNiveau.Location = New System.Drawing.Point(976, 125)
        Me.lblNombreNiveau.Name = "lblNombreNiveau"
        Me.lblNombreNiveau.Size = New System.Drawing.Size(29, 39)
        Me.lblNombreNiveau.TabIndex = 22
        Me.lblNombreNiveau.Text = "1"
        Me.lblNombreNiveau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblÉchelle
        '
        Me.lblÉchelle.AutoSize = True
        Me.lblÉchelle.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblÉchelle.Location = New System.Drawing.Point(770, 45)
        Me.lblÉchelle.Name = "lblÉchelle"
        Me.lblÉchelle.Size = New System.Drawing.Size(359, 52)
        Me.lblÉchelle.TabIndex = 23
        Me.lblÉchelle.Text = "Aidez George à s'échapper du labyrinthe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en atteignant l'échelle."
        Me.lblÉchelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChrono
        '
        Me.lblChrono.AutoSize = True
        Me.lblChrono.BackColor = System.Drawing.Color.Transparent
        Me.lblChrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrono.Location = New System.Drawing.Point(893, 213)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(112, 42)
        Me.lblChrono.TabIndex = 24
        Me.lblChrono.Text = "00:00"
        '
        'lblGoToMenu
        '
        Me.lblGoToMenu.AutoSize = True
        Me.lblGoToMenu.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoToMenu.Location = New System.Drawing.Point(817, 268)
        Me.lblGoToMenu.Name = "lblGoToMenu"
        Me.lblGoToMenu.Size = New System.Drawing.Size(81, 36)
        Me.lblGoToMenu.TabIndex = 25
        Me.lblGoToMenu.Text = "Menu"
        Me.lblGoToMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMenuSelected
        '
        Me.lblMenuSelected.AutoSize = True
        Me.lblMenuSelected.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMenuSelected.Location = New System.Drawing.Point(777, 268)
        Me.lblMenuSelected.Name = "lblMenuSelected"
        Me.lblMenuSelected.Size = New System.Drawing.Size(34, 36)
        Me.lblMenuSelected.TabIndex = 26
        Me.lblMenuSelected.Text = "♦"
        Me.lblMenuSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMenuSelected.Visible = False
        '
        'lblNextLevel
        '
        Me.lblNextLevel.AutoSize = True
        Me.lblNextLevel.Enabled = False
        Me.lblNextLevel.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextLevel.Location = New System.Drawing.Point(817, 307)
        Me.lblNextLevel.Name = "lblNextLevel"
        Me.lblNextLevel.Size = New System.Drawing.Size(207, 36)
        Me.lblNextLevel.TabIndex = 27
        Me.lblNextLevel.Text = "Prochain niveau"
        Me.lblNextLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNextLevel.Visible = False
        '
        'lblNextLevelSelected
        '
        Me.lblNextLevelSelected.AutoSize = True
        Me.lblNextLevelSelected.Enabled = False
        Me.lblNextLevelSelected.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextLevelSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNextLevelSelected.Location = New System.Drawing.Point(777, 307)
        Me.lblNextLevelSelected.Name = "lblNextLevelSelected"
        Me.lblNextLevelSelected.Size = New System.Drawing.Size(34, 36)
        Me.lblNextLevelSelected.TabIndex = 28
        Me.lblNextLevelSelected.Text = "♦"
        Me.lblNextLevelSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNextLevelSelected.Visible = False
        '
        'George
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 825)
        Me.Controls.Add(Me.lblNextLevel)
        Me.Controls.Add(Me.lblNextLevelSelected)
        Me.Controls.Add(Me.lblGoToMenu)
        Me.Controls.Add(Me.lblMenuSelected)
        Me.Controls.Add(Me.lblChrono)
        Me.Controls.Add(Me.PcbGeorgesLeft)
        Me.Controls.Add(Me.PcbGeorgesRight)
        Me.Controls.Add(Me.PcbGeorgesUp)
        Me.Controls.Add(Me.PcbGeorgesDown)
        Me.Controls.Add(Me.BoardContainer)
        Me.Controls.Add(Me.PcbÉchelle)
        Me.Controls.Add(Me.PcbRoche)
        Me.Controls.Add(Me.PcbBrique)
        Me.Controls.Add(Me.PcbGazon)
        Me.Controls.Add(Me.lblÉchelle)
        Me.Controls.Add(Me.lblNombreNiveau)
        Me.Controls.Add(Me.lblNiveau)
        Me.Controls.Add(Me.lblVictoireMessage)
        Me.Controls.Add(Me.lblVictoire)
        Me.Controls.Add(Me.lblremainingTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "George"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "George is Trapped!"
        CType(Me.PcbGeorgesLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbGeorgesRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbGeorgesUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbGeorgesDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbÉchelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbRoche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbBrique, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbGazon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PcbGazon As System.Windows.Forms.PictureBox
    Friend WithEvents PcbBrique As System.Windows.Forms.PictureBox
    Friend WithEvents PcbRoche As System.Windows.Forms.PictureBox
    Friend WithEvents PcbÉchelle As System.Windows.Forms.PictureBox
    Friend WithEvents BoardContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PcbGeorgesDown As System.Windows.Forms.PictureBox
    Friend WithEvents PcbGeorgesUp As System.Windows.Forms.PictureBox
    Friend WithEvents PcbGeorgesRight As System.Windows.Forms.PictureBox
    Friend WithEvents PcbGeorgesLeft As System.Windows.Forms.PictureBox
    Friend WithEvents lblremainingTime As System.Windows.Forms.Label
    Friend WithEvents TmrTempsLimite As System.Windows.Forms.Timer
    Private WithEvents lblVictoire As System.Windows.Forms.Label
    Friend WithEvents lblVictoireMessage As System.Windows.Forms.Label
    Friend WithEvents lblNiveau As System.Windows.Forms.Label
    Friend WithEvents lblNombreNiveau As System.Windows.Forms.Label
    Friend WithEvents lblÉchelle As System.Windows.Forms.Label
    Friend WithEvents lblChrono As System.Windows.Forms.Label
    Friend WithEvents lblGoToMenu As System.Windows.Forms.Label
    Friend WithEvents lblMenuSelected As System.Windows.Forms.Label
    Friend WithEvents lblNextLevel As System.Windows.Forms.Label
    Friend WithEvents lblNextLevelSelected As System.Windows.Forms.Label

End Class
