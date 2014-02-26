<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuOptions
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
        Me.lblGameOptions = New System.Windows.Forms.Label()
        Me.lblKeyBindings = New System.Windows.Forms.Label()
        Me.lblControleHaut = New System.Windows.Forms.Label()
        Me.lblControleBas = New System.Windows.Forms.Label()
        Me.lblControleGauche = New System.Windows.Forms.Label()
        Me.lblControleDroit = New System.Windows.Forms.Label()
        Me.lblNumberOfMaps = New System.Windows.Forms.Label()
        Me.lblAssignUp = New System.Windows.Forms.Label()
        Me.lblAssignDown = New System.Windows.Forms.Label()
        Me.lblAssignLeft = New System.Windows.Forms.Label()
        Me.lblAssignRight = New System.Windows.Forms.Label()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.lblMainMenuSelected = New System.Windows.Forms.Label()
        Me.txtNumberMaps = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGameOptions
        '
        Me.lblGameOptions.AutoSize = True
        Me.lblGameOptions.Font = New System.Drawing.Font("Exo", 60.0!, System.Drawing.FontStyle.Bold)
        Me.lblGameOptions.Location = New System.Drawing.Point(232, 9)
        Me.lblGameOptions.Name = "lblGameOptions"
        Me.lblGameOptions.Size = New System.Drawing.Size(321, 106)
        Me.lblGameOptions.TabIndex = 1
        Me.lblGameOptions.Text = "Options"
        '
        'lblKeyBindings
        '
        Me.lblKeyBindings.AutoSize = True
        Me.lblKeyBindings.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblKeyBindings.Location = New System.Drawing.Point(57, 160)
        Me.lblKeyBindings.Name = "lblKeyBindings"
        Me.lblKeyBindings.Size = New System.Drawing.Size(326, 36)
        Me.lblKeyBindings.TabIndex = 2
        Me.lblKeyBindings.Text = "Assignation des contrôles"
        '
        'lblControleHaut
        '
        Me.lblControleHaut.AutoSize = True
        Me.lblControleHaut.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblControleHaut.Location = New System.Drawing.Point(57, 228)
        Me.lblControleHaut.Name = "lblControleHaut"
        Me.lblControleHaut.Size = New System.Drawing.Size(71, 36)
        Me.lblControleHaut.TabIndex = 3
        Me.lblControleHaut.Text = "Haut"
        '
        'lblControleBas
        '
        Me.lblControleBas.AutoSize = True
        Me.lblControleBas.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblControleBas.Location = New System.Drawing.Point(57, 264)
        Me.lblControleBas.Name = "lblControleBas"
        Me.lblControleBas.Size = New System.Drawing.Size(59, 36)
        Me.lblControleBas.TabIndex = 4
        Me.lblControleBas.Text = "Bas"
        '
        'lblControleGauche
        '
        Me.lblControleGauche.AutoSize = True
        Me.lblControleGauche.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblControleGauche.Location = New System.Drawing.Point(57, 300)
        Me.lblControleGauche.Name = "lblControleGauche"
        Me.lblControleGauche.Size = New System.Drawing.Size(104, 36)
        Me.lblControleGauche.TabIndex = 5
        Me.lblControleGauche.Text = "Gauche"
        '
        'lblControleDroit
        '
        Me.lblControleDroit.AutoSize = True
        Me.lblControleDroit.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblControleDroit.Location = New System.Drawing.Point(57, 336)
        Me.lblControleDroit.Name = "lblControleDroit"
        Me.lblControleDroit.Size = New System.Drawing.Size(74, 36)
        Me.lblControleDroit.TabIndex = 6
        Me.lblControleDroit.Text = "Droit"
        '
        'lblNumberOfMaps
        '
        Me.lblNumberOfMaps.AutoSize = True
        Me.lblNumberOfMaps.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblNumberOfMaps.Location = New System.Drawing.Point(57, 387)
        Me.lblNumberOfMaps.Name = "lblNumberOfMaps"
        Me.lblNumberOfMaps.Size = New System.Drawing.Size(233, 36)
        Me.lblNumberOfMaps.TabIndex = 7
        Me.lblNumberOfMaps.Text = "Nombre de cartes"
        '
        'lblAssignUp
        '
        Me.lblAssignUp.AutoSize = True
        Me.lblAssignUp.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblAssignUp.Location = New System.Drawing.Point(482, 228)
        Me.lblAssignUp.Name = "lblAssignUp"
        Me.lblAssignUp.Size = New System.Drawing.Size(169, 36)
        Me.lblAssignUp.TabIndex = 8
        Me.lblAssignUp.Text = "DefaultValue"
        '
        'lblAssignDown
        '
        Me.lblAssignDown.AutoSize = True
        Me.lblAssignDown.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblAssignDown.Location = New System.Drawing.Point(482, 264)
        Me.lblAssignDown.Name = "lblAssignDown"
        Me.lblAssignDown.Size = New System.Drawing.Size(169, 36)
        Me.lblAssignDown.TabIndex = 9
        Me.lblAssignDown.Text = "DefaultValue"
        '
        'lblAssignLeft
        '
        Me.lblAssignLeft.AutoSize = True
        Me.lblAssignLeft.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblAssignLeft.Location = New System.Drawing.Point(482, 300)
        Me.lblAssignLeft.Name = "lblAssignLeft"
        Me.lblAssignLeft.Size = New System.Drawing.Size(169, 36)
        Me.lblAssignLeft.TabIndex = 10
        Me.lblAssignLeft.Text = "DefaultValue"
        '
        'lblAssignRight
        '
        Me.lblAssignRight.AutoSize = True
        Me.lblAssignRight.Font = New System.Drawing.Font("Exo", 20.0!)
        Me.lblAssignRight.Location = New System.Drawing.Point(482, 336)
        Me.lblAssignRight.Name = "lblAssignRight"
        Me.lblAssignRight.Size = New System.Drawing.Size(169, 36)
        Me.lblAssignRight.TabIndex = 11
        Me.lblAssignRight.Text = "DefaultValue"
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Exo", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(284, 472)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(216, 80)
        Me.lblMainMenu.TabIndex = 13
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
        Me.lblMainMenuSelected.TabIndex = 14
        Me.lblMainMenuSelected.Text = "♦"
        Me.lblMainMenuSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMainMenuSelected.Visible = False
        '
        'txtNumberMaps
        '
        Me.txtNumberMaps.Location = New System.Drawing.Point(488, 396)
        Me.txtNumberMaps.Name = "txtNumberMaps"
        Me.txtNumberMaps.Size = New System.Drawing.Size(36, 20)
        Me.txtNumberMaps.TabIndex = 15
        '
        'menuOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.txtNumberMaps)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.lblMainMenuSelected)
        Me.Controls.Add(Me.lblAssignRight)
        Me.Controls.Add(Me.lblAssignLeft)
        Me.Controls.Add(Me.lblAssignDown)
        Me.Controls.Add(Me.lblAssignUp)
        Me.Controls.Add(Me.lblNumberOfMaps)
        Me.Controls.Add(Me.lblControleDroit)
        Me.Controls.Add(Me.lblControleGauche)
        Me.Controls.Add(Me.lblControleBas)
        Me.Controls.Add(Me.lblControleHaut)
        Me.Controls.Add(Me.lblKeyBindings)
        Me.Controls.Add(Me.lblGameOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "menuOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGameOptions As System.Windows.Forms.Label
    Friend WithEvents lblKeyBindings As System.Windows.Forms.Label
    Friend WithEvents lblControleHaut As System.Windows.Forms.Label
    Friend WithEvents lblControleBas As System.Windows.Forms.Label
    Friend WithEvents lblControleGauche As System.Windows.Forms.Label
    Friend WithEvents lblControleDroit As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfMaps As System.Windows.Forms.Label
    Friend WithEvents lblAssignUp As System.Windows.Forms.Label
    Friend WithEvents lblAssignDown As System.Windows.Forms.Label
    Friend WithEvents lblAssignLeft As System.Windows.Forms.Label
    Friend WithEvents lblAssignRight As System.Windows.Forms.Label
    Friend WithEvents lblMainMenu As System.Windows.Forms.Label
    Friend WithEvents lblMainMenuSelected As System.Windows.Forms.Label
    Friend WithEvents txtNumberMaps As System.Windows.Forms.TextBox
End Class
