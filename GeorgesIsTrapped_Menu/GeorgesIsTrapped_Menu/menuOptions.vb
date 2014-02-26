Imports System.IO
Imports System.Text.RegularExpressions

Public Class menuOptions
    'Variables pour la lecture et la sauvegarde des paramètres
    Const FILE_PATH As String = "config.cfg"
    Const ERROR_TEXTBOX_IS_EMPTY As String = "Veuillez entrer un nombre de carte avant de savegarder les paramètres et retourner au menu."
    Const ERROR_NMB_MAPS_INFERIOR_EQUAL_TO_0 As String = "Il doit y avoir au moins une carte afin que le jeu s'exécute."
    Const ERROR_TITLE_MAPS As String = "Attention"

    'Variables pour l'assignation de touches
    Public keyDataCache As Keys
    Public keyCodeCache As Integer
    Public keyDataArray(3) As String
    Public keyCodeArray(3) As Integer
    Public bindingPosition As Integer
    Public numberTotalMaps As Integer = George.nombreMap
    Public isOnLabel As Boolean
    Public keyIsValid As Boolean

    Private Sub lblMainMenu_Click(sender As Object, e As EventArgs) Handles lblMainMenu.Click

        If IsNumeric(txtNumberMaps.Text) AndAlso Not (txtNumberMaps.Text = "") Then
            If CInt(txtNumberMaps.Text) > 0 Then
                SaveConfigFile(FILE_PATH, keyCodeArray, keyDataArray, numberTotalMaps)
                George.nombreMap = CInt(txtNumberMaps.Text)
                Close()
            Else
                MessageBox.Show(ERROR_NMB_MAPS_INFERIOR_EQUAL_TO_0, ERROR_TITLE_MAPS)
            End If
        Else
            MessageBox.Show(ERROR_TEXTBOX_IS_EMPTY, ERROR_TITLE_MAPS)
        End If
    End Sub

    Private Sub lblMainMenu_MouseEnter(sender As Object, e As EventArgs) Handles lblMainMenu.MouseEnter
        MouseEnterLabel(lblMainMenu, lblMainMenuSelected)
    End Sub

    Private Sub lblMainMenu_MouseLeave(sender As Object, e As EventArgs) Handles lblMainMenu.MouseLeave
        MouseLeaveLabel(lblMainMenu, lblMainMenuSelected)
    End Sub

    Private Sub menuOptions_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadConfigFile(FILE_PATH, keyDataArray, keyCodeArray, numberTotalMaps)
        lblAssignUp.Text = keyDataArray(0)
        lblAssignDown.Text = keyDataArray(1)
        lblAssignLeft.Text = keyDataArray(2)
        lblAssignRight.Text = keyDataArray(3)
        txtNumberMaps.Text = CStr(numberTotalMaps)
    End Sub

    Private Sub lblAssignUp_MouseEnter(sender As Object, e As EventArgs) Handles lblAssignUp.MouseEnter
        MouseEnterBindKeys(lblAssignUp)
        bindingPosition = 0
    End Sub

    Private Sub lblAssignUp_MouseLeave(sender As Object, e As EventArgs) Handles lblAssignUp.MouseLeave
        MouseLeaveBindKeys(lblAssignUp)
    End Sub

    Private Sub lblAssignDown_MouseEnter(sender As Object, e As EventArgs) Handles lblAssignDown.MouseEnter
        MouseEnterBindKeys(lblAssignDown)
        bindingPosition = 1
    End Sub

    Private Sub lblAssignDown_MouseLeave(sender As Object, e As EventArgs) Handles lblAssignDown.MouseLeave
        MouseLeaveBindKeys(lblAssignDown)
    End Sub

    Private Sub lblAssignLeft_MouseEnter(sender As Object, e As EventArgs) Handles lblAssignLeft.MouseEnter
        MouseEnterBindKeys(lblAssignLeft)
        bindingPosition = 2
    End Sub

    Private Sub lblAssignLeft_MouseLeave(sender As Object, e As EventArgs) Handles lblAssignLeft.MouseLeave
        MouseLeaveBindKeys(lblAssignLeft)
    End Sub

    Private Sub lblAssignRight_MouseEnter(sender As Object, e As EventArgs) Handles lblAssignRight.MouseEnter
        MouseEnterBindKeys(lblAssignRight)
        bindingPosition = 3
    End Sub

    Private Sub lblAssignRight_MouseLeave(sender As Object, e As EventArgs) Handles lblAssignRight.MouseLeave
        MouseLeaveBindKeys(lblAssignRight)
    End Sub

    Private Sub menuOptions_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Capture des touches au clavier

        keyDataCache = e.KeyData
        keyCodeCache = e.KeyValue



        If bindingPosition = 0 AndAlso isOnLabel AndAlso ValidateBinding(keyCodeCache) Then
            keyDataArray(bindingPosition) = keyDataCache.ToString
            keyCodeArray(bindingPosition) = keyCodeCache
            lblAssignUp.Text = keyDataArray(bindingPosition).ToString
        ElseIf bindingPosition = 1 AndAlso isOnLabel AndAlso ValidateBinding(keyCodeCache) Then
            keyDataArray(bindingPosition) = keyDataCache.ToString
            keyCodeArray(bindingPosition) = keyCodeCache
            lblAssignDown.Text = keyDataArray(bindingPosition).ToString
        ElseIf bindingPosition = 2 AndAlso isOnLabel AndAlso ValidateBinding(keyCodeCache) Then
            keyDataArray(bindingPosition) = keyDataCache.ToString
            keyCodeArray(bindingPosition) = keyCodeCache
            lblAssignLeft.Text = keyDataArray(bindingPosition).ToString
        ElseIf bindingPosition = 3 AndAlso isOnLabel AndAlso ValidateBinding(keyCodeCache) Then
            keyDataArray(bindingPosition) = keyDataCache.ToString
            keyCodeArray(bindingPosition) = keyCodeCache
            lblAssignRight.Text = keyDataArray(bindingPosition).ToString
        End If


    End Sub

End Class