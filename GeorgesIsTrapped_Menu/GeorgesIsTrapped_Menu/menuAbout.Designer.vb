<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAbout
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
        Me.lblAboutGame = New System.Windows.Forms.Label()
        Me.lblDeveloppeurs = New System.Windows.Forms.Label()
        Me.lblFrancis = New System.Windows.Forms.Label()
        Me.lblAnthony = New System.Windows.Forms.Label()
        Me.lblEric = New System.Windows.Forms.Label()
        Me.lblCadreProjet = New System.Windows.Forms.Label()
        Me.lblEmailFrancis = New System.Windows.Forms.Label()
        Me.lblEmailAnthony = New System.Windows.Forms.Label()
        Me.lblEmailEric = New System.Windows.Forms.Label()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.lblMainMenuSelected = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAboutGame
        '
        Me.lblAboutGame.AutoSize = True
        Me.lblAboutGame.Font = New System.Drawing.Font("Exo", 60.0!, System.Drawing.FontStyle.Bold)
        Me.lblAboutGame.Location = New System.Drawing.Point(42, 9)
        Me.lblAboutGame.Name = "lblAboutGame"
        Me.lblAboutGame.Size = New System.Drawing.Size(701, 106)
        Me.lblAboutGame.TabIndex = 0
        Me.lblAboutGame.Text = "À propos de ce jeu"
        '
        'lblDeveloppeurs
        '
        Me.lblDeveloppeurs.AutoSize = True
        Me.lblDeveloppeurs.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblDeveloppeurs.Location = New System.Drawing.Point(57, 160)
        Me.lblDeveloppeurs.Name = "lblDeveloppeurs"
        Me.lblDeveloppeurs.Size = New System.Drawing.Size(180, 36)
        Me.lblDeveloppeurs.TabIndex = 1
        Me.lblDeveloppeurs.Text = "Développeurs"
        '
        'lblFrancis
        '
        Me.lblFrancis.AutoSize = True
        Me.lblFrancis.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblFrancis.Location = New System.Drawing.Point(57, 222)
        Me.lblFrancis.Name = "lblFrancis"
        Me.lblFrancis.Size = New System.Drawing.Size(207, 36)
        Me.lblFrancis.TabIndex = 2
        Me.lblFrancis.Text = "Francis Delaney"
        '
        'lblAnthony
        '
        Me.lblAnthony.AutoSize = True
        Me.lblAnthony.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblAnthony.Location = New System.Drawing.Point(57, 258)
        Me.lblAnthony.Name = "lblAnthony"
        Me.lblAnthony.Size = New System.Drawing.Size(198, 36)
        Me.lblAnthony.TabIndex = 3
        Me.lblAnthony.Text = "Anthony Vallee"
        '
        'lblEric
        '
        Me.lblEric.AutoSize = True
        Me.lblEric.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblEric.Location = New System.Drawing.Point(57, 294)
        Me.lblEric.Name = "lblEric"
        Me.lblEric.Size = New System.Drawing.Size(183, 36)
        Me.lblEric.TabIndex = 4
        Me.lblEric.Text = "Éric Boudreau"
        '
        'lblCadreProjet
        '
        Me.lblCadreProjet.AutoSize = True
        Me.lblCadreProjet.Font = New System.Drawing.Font("Exo", 16.0!)
        Me.lblCadreProjet.Location = New System.Drawing.Point(57, 384)
        Me.lblCadreProjet.Name = "lblCadreProjet"
        Me.lblCadreProjet.Size = New System.Drawing.Size(651, 58)
        Me.lblCadreProjet.TabIndex = 6
        Me.lblCadreProjet.Text = "Ce jeu a été développé dans le cadre du cours de programmation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "420-120-SF, au Ce" & _
    "gep Sainte-Foy (Automne 2013)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblEmailFrancis
        '
        Me.lblEmailFrancis.AutoSize = True
        Me.lblEmailFrancis.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblEmailFrancis.Location = New System.Drawing.Point(328, 222)
        Me.lblEmailFrancis.Name = "lblEmailFrancis"
        Me.lblEmailFrancis.Size = New System.Drawing.Size(366, 36)
        Me.lblEmailFrancis.TabIndex = 7
        Me.lblEmailFrancis.Text = "delaneyfrancis@hotmail.com"
        '
        'lblEmailAnthony
        '
        Me.lblEmailAnthony.AutoSize = True
        Me.lblEmailAnthony.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblEmailAnthony.Location = New System.Drawing.Point(328, 258)
        Me.lblEmailAnthony.Name = "lblEmailAnthony"
        Me.lblEmailAnthony.Size = New System.Drawing.Size(317, 36)
        Me.lblEmailAnthony.TabIndex = 8
        Me.lblEmailAnthony.Text = "tony.vallee@hotmail.com"
        '
        'lblEmailEric
        '
        Me.lblEmailEric.AutoSize = True
        Me.lblEmailEric.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblEmailEric.Location = New System.Drawing.Point(328, 294)
        Me.lblEmailEric.Name = "lblEmailEric"
        Me.lblEmailEric.Size = New System.Drawing.Size(214, 36)
        Me.lblEmailEric.TabIndex = 9
        Me.lblEmailEric.Text = "aquacity@live.ca"
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Exo", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(284, 472)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(216, 80)
        Me.lblMainMenu.TabIndex = 15
        Me.lblMainMenu.Text = "Retour"
        Me.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainMenuSelected
        '
        Me.lblMainMenuSelected.AutoSize = True
        Me.lblMainMenuSelected.Font = New System.Drawing.Font("Exo", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenuSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMainMenuSelected.Location = New System.Drawing.Point(206, 472)
        Me.lblMainMenuSelected.Name = "lblMainMenuSelected"
        Me.lblMainMenuSelected.Size = New System.Drawing.Size(72, 80)
        Me.lblMainMenuSelected.TabIndex = 16
        Me.lblMainMenuSelected.Text = "♦"
        Me.lblMainMenuSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMainMenuSelected.Visible = False
        '
        'menuAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.lblMainMenuSelected)
        Me.Controls.Add(Me.lblEmailEric)
        Me.Controls.Add(Me.lblEmailAnthony)
        Me.Controls.Add(Me.lblEmailFrancis)
        Me.Controls.Add(Me.lblCadreProjet)
        Me.Controls.Add(Me.lblEric)
        Me.Controls.Add(Me.lblAnthony)
        Me.Controls.Add(Me.lblFrancis)
        Me.Controls.Add(Me.lblDeveloppeurs)
        Me.Controls.Add(Me.lblAboutGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutGame As System.Windows.Forms.Label
    Friend WithEvents lblDeveloppeurs As System.Windows.Forms.Label
    Friend WithEvents lblFrancis As System.Windows.Forms.Label
    Friend WithEvents lblAnthony As System.Windows.Forms.Label
    Friend WithEvents lblEric As System.Windows.Forms.Label
    Friend WithEvents lblCadreProjet As System.Windows.Forms.Label
    Friend WithEvents lblEmailFrancis As System.Windows.Forms.Label
    Friend WithEvents lblEmailAnthony As System.Windows.Forms.Label
    Friend WithEvents lblEmailEric As System.Windows.Forms.Label
    Friend WithEvents lblMainMenu As System.Windows.Forms.Label
    Friend WithEvents lblMainMenuSelected As System.Windows.Forms.Label
End Class
