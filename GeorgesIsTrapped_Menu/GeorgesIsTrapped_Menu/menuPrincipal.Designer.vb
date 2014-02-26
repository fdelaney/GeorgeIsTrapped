<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.lblPlayGame = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblStartSelected = New System.Windows.Forms.Label()
        Me.lblOptionsSelected = New System.Windows.Forms.Label()
        Me.lblAboutSelected = New System.Windows.Forms.Label()
        Me.lblExitSelected = New System.Windows.Forms.Label()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPlayGame
        '
        Me.lblPlayGame.AutoSize = True
        Me.lblPlayGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayGame.Location = New System.Drawing.Point(276, 228)
        Me.lblPlayGame.Name = "lblPlayGame"
        Me.lblPlayGame.Size = New System.Drawing.Size(179, 69)
        Me.lblPlayGame.TabIndex = 0
        Me.lblPlayGame.Text = "Jouer"
        Me.lblPlayGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(276, 308)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(237, 69)
        Me.lblOptions.TabIndex = 1
        Me.lblOptions.Text = "Options"
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(276, 388)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(268, 69)
        Me.lblAbout.TabIndex = 2
        Me.lblAbout.Text = "À propos"
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(276, 468)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(211, 69)
        Me.lblExit.TabIndex = 3
        Me.lblExit.Text = "Quitter"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartSelected
        '
        Me.lblStartSelected.AutoSize = True
        Me.lblStartSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStartSelected.Location = New System.Drawing.Point(203, 228)
        Me.lblStartSelected.Name = "lblStartSelected"
        Me.lblStartSelected.Size = New System.Drawing.Size(70, 69)
        Me.lblStartSelected.TabIndex = 4
        Me.lblStartSelected.Text = "♦"
        Me.lblStartSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStartSelected.Visible = False
        '
        'lblOptionsSelected
        '
        Me.lblOptionsSelected.AutoSize = True
        Me.lblOptionsSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionsSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOptionsSelected.Location = New System.Drawing.Point(203, 308)
        Me.lblOptionsSelected.Name = "lblOptionsSelected"
        Me.lblOptionsSelected.Size = New System.Drawing.Size(70, 69)
        Me.lblOptionsSelected.TabIndex = 5
        Me.lblOptionsSelected.Text = "♦"
        Me.lblOptionsSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOptionsSelected.Visible = False
        '
        'lblAboutSelected
        '
        Me.lblAboutSelected.AutoSize = True
        Me.lblAboutSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAboutSelected.Location = New System.Drawing.Point(203, 388)
        Me.lblAboutSelected.Name = "lblAboutSelected"
        Me.lblAboutSelected.Size = New System.Drawing.Size(70, 69)
        Me.lblAboutSelected.TabIndex = 6
        Me.lblAboutSelected.Text = "♦"
        Me.lblAboutSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAboutSelected.Visible = False
        '
        'lblExitSelected
        '
        Me.lblExitSelected.AutoSize = True
        Me.lblExitSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExitSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblExitSelected.Location = New System.Drawing.Point(203, 468)
        Me.lblExitSelected.Name = "lblExitSelected"
        Me.lblExitSelected.Size = New System.Drawing.Size(70, 69)
        Me.lblExitSelected.TabIndex = 7
        Me.lblExitSelected.Text = "♦"
        Me.lblExitSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblExitSelected.Visible = False
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.Location = New System.Drawing.Point(124, 79)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(507, 69)
        Me.lblGameTitle.TabIndex = 8
        Me.lblGameTitle.Text = "George is trapped"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Controls.Add(Me.lblExitSelected)
        Me.Controls.Add(Me.lblAboutSelected)
        Me.Controls.Add(Me.lblOptionsSelected)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblPlayGame)
        Me.Controls.Add(Me.lblStartSelected)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlayGame As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblStartSelected As System.Windows.Forms.Label
    Friend WithEvents lblOptionsSelected As System.Windows.Forms.Label
    Friend WithEvents lblAboutSelected As System.Windows.Forms.Label
    Friend WithEvents lblExitSelected As System.Windows.Forms.Label
    Friend WithEvents lblGameTitle As System.Windows.Forms.Label

End Class
