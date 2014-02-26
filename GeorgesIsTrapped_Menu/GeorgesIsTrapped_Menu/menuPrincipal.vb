Imports GeorgesIsTrapped_Menu.fonctionLabelInteraction
Imports System.IO

Public Class frmMenuPrincipal

    Const FILE_PATH As String = "config.cfg"

    Private Sub lblPlayGame_MouseEnter(sender As Object, e As EventArgs) Handles lblPlayGame.MouseEnter
        MouseEnterLabel(lblPlayGame, lblStartSelected)
    End Sub
    Private Sub lblPlayGame_MouseLeave(sender As Object, e As EventArgs) Handles lblPlayGame.MouseLeave
        MouseLeaveLabel(lblPlayGame, lblStartSelected)
    End Sub

    Private Sub lblOptions_MouseEnter(sender As Object, e As EventArgs) Handles lblOptions.MouseEnter
        MouseEnterLabel(lblOptions, lblOptionsSelected)
    End Sub

    Private Sub lblOptions_MouseLeave(sender As Object, e As EventArgs) Handles lblOptions.MouseLeave
        MouseLeaveLabel(lblOptions, lblOptionsSelected)
    End Sub

    Private Sub lblAbout_MouseEnter(sender As Object, e As EventArgs) Handles lblAbout.MouseEnter
        MouseEnterLabel(lblAbout, lblAboutSelected)
    End Sub

    Private Sub lblAbout_MouseLeave(sender As Object, e As EventArgs) Handles lblAbout.MouseLeave
        MouseLeaveLabel(lblAbout, lblAboutSelected)
    End Sub

    Private Sub lblExit_MouseEnter(sender As Object, e As EventArgs) Handles lblExit.MouseEnter
        MouseEnterLabel(lblExit, lblExitSelected)
    End Sub

    Private Sub lblExit_MouseLeave(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        MouseLeaveLabel(lblExit, lblExitSelected)
    End Sub

    'Les événements .Click commencent ici
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub lblOptions_Click(sender As Object, e As EventArgs) Handles lblOptions.Click
        menuOptions.ShowDialog()
    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        menuAbout.ShowDialog()
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ValidateConfigFileExists(FILE_PATH) Then
            NewConfigFileWithDefaultValues(FILE_PATH)
        End If
        My.Computer.Audio.Play(My.Resources.Kola_Kid___castle, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub lblPlayGame_Click(sender As Object, e As EventArgs) Handles lblPlayGame.Click
        Me.Visible = False
        Me.Enabled = False
        George.Show()
    End Sub

    Private Sub lblStartSelected_Click(sender As Object, e As EventArgs) Handles lblStartSelected.Click

    End Sub
End Class
