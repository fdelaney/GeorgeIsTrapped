Imports System.IO
Imports System.Text.RegularExpressions

Module fonctionLabelInteraction
    'Constante de grossissement du texte
    Const TEXT_ZOOMING As Integer = 2

    'Constantes de texte pour les messages d'erreur
    Const ERROR_CONTENT_KEY_IS_BOUND As String = "La touche entrée est déjà en cours d'utilisation."
    Const ERROR_TITLE_KEY_IS_BOUND As String = "Attention"
    

    'Variables globales
    Public unchangedKey As String
    ReadOnly codeNames() As String = {"UP", "DOWN", "LEFT", "RIGHT", "SHOOT"}
    ReadOnly dataNames() As String = {"UPLBL", "DOWNLBL", "LEFTLBL", "RIGHTLBL", "SHOOTLBL"}
    ReadOnly maps As String = "MAPS"

    Sub MouseEnterLabel(ByVal MenuLabel As Label, ByVal SelectedLabel As Label)
        'Faire apparaître le label de selection
        SelectedLabel.Visible = True
        'Grossir le label sélectionné.
        Dim currentFontSize As Single
        currentFontSize = MenuLabel.Font.Size
        MenuLabel.Font = New Font("Exo", currentFontSize + TEXT_ZOOMING)
        'Changer la couleur du texte
        MenuLabel.ForeColor = Color.DarkOrange

        'Effet de zoom du texte
        Dim labelLocationXY(1) As Integer

        labelLocationXY(0) = MenuLabel.Location.X
        labelLocationXY(1) = MenuLabel.Location.Y

        MenuLabel.Location = New Point(labelLocationXY(0) - TEXT_ZOOMING, labelLocationXY(1) - TEXT_ZOOMING)
    End Sub

    Sub MouseLeaveLabel(ByVal MenuLabel As Label, ByVal SelectedLabel As Label)
        'Faire apparaître le label de selection
        SelectedLabel.Visible = False
        'Grossir le label sélectionné.
        Dim currentFontSize As Single
        currentFontSize = MenuLabel.Font.Size
        MenuLabel.Font = New Font("Exo", currentFontSize - TEXT_ZOOMING)
        'Remettre à défaut la couleur du texte
        MenuLabel.ForeColor = Color.Black
        'Effet de zoom du texte
        Dim labelLocationXY(1) As Integer

        labelLocationXY(0) = MenuLabel.Location.X
        labelLocationXY(1) = MenuLabel.Location.Y

        MenuLabel.Location = New Point(labelLocationXY(0) + TEXT_ZOOMING, labelLocationXY(1) + TEXT_ZOOMING)
    End Sub

    Sub MouseEnterLabelGame(ByVal MenuLabel As Label, ByVal SelectedLabel As Label)
        'Faire apparaître le label de selection
        SelectedLabel.Visible = True
        'Grossir le label sélectionné.
        Dim currentFontSize As Single
        currentFontSize = MenuLabel.Font.Size
        MenuLabel.Font = New Font("Impact", currentFontSize + TEXT_ZOOMING)
        'Changer la couleur du texte
        MenuLabel.ForeColor = Color.DarkOrange

        'Effet de zoom du texte
        Dim labelLocationXY(1) As Integer

        labelLocationXY(0) = MenuLabel.Location.X
        labelLocationXY(1) = MenuLabel.Location.Y

        MenuLabel.Location = New Point(labelLocationXY(0) - TEXT_ZOOMING, labelLocationXY(1) - TEXT_ZOOMING)
    End Sub

    Sub MouseLeaveLabelGame(ByVal MenuLabel As Label, ByVal SelectedLabel As Label)
        'Faire apparaître le label de selection
        SelectedLabel.Visible = False
        'Grossir le label sélectionné.
        Dim currentFontSize As Single
        currentFontSize = MenuLabel.Font.Size
        MenuLabel.Font = New Font("Impact", currentFontSize - TEXT_ZOOMING)
        'Remettre à défaut la couleur du texte
        MenuLabel.ForeColor = Color.Black
        'Effet de zoom du texte
        Dim labelLocationXY(1) As Integer

        labelLocationXY(0) = MenuLabel.Location.X
        labelLocationXY(1) = MenuLabel.Location.Y

        MenuLabel.Location = New Point(labelLocationXY(0) + TEXT_ZOOMING, labelLocationXY(1) + TEXT_ZOOMING)
    End Sub

    'SECTION POUR L'ASSIGNATION DES CONTRÔLES DANS LE MENU OPTIONS

    'Remettre à défaut les paramètres du label

    Sub MouseLeaveBindKeys(ByVal OptionLabel As Label)
        OptionLabel.ForeColor = Color.Black
        OptionLabel.Text = menuOptions.keyDataArray(menuOptions.bindingPosition)
        menuOptions.isOnLabel = False
    End Sub

    'Demander à l'utilisateur d'entrer une touche

    Sub MouseEnterBindKeys(ByVal OptionLabel As Label)

        unchangedKey = OptionLabel.Text
        OptionLabel.ForeColor = Color.DarkOrange
        OptionLabel.Text = "Press key..."
        OptionLabel.Focus()
        menuOptions.isOnLabel = True
    End Sub

    'Fonction qui vérifie que la touche entrée n'est pas déjà en utilisation
    
    Function ValidateBinding(ByVal enteredKeyCode As Integer) As Boolean
        Dim isValid As Boolean = True
        For Each item As Keys In menuOptions.keyCodeArray
            If item = enteredKeyCode Then
                isValid = False
                MsgBox(ERROR_CONTENT_KEY_IS_BOUND, , ERROR_TITLE_KEY_IS_BOUND)
                Exit For
            End If
        Next

        Return isValid
    End Function

    Function ValidateConfigFileExists(ByVal configFilePath As String) As Boolean
        Dim fileExists As Boolean = True
        If Not File.Exists(configFilePath) Then
            fileExists = False
        End If

        Return fileExists
    End Function

    Sub NewConfigFileWithDefaultValues(ByVal configFilePath As String)
        File.Create(configFilePath).Dispose()
        Dim writeNewFile As StreamWriter = New StreamWriter(configFilePath)
        Dim configFileDefaultContent() As String = {"UP = 87", "DOWN = 83", "LEFT = 65", "RIGHT = 68", "UPLBL = W", "DOWNLBL = S", "LEFTLBL = A", "RIGHTLBL = D", "MAPS = 4"}
        writeNewFile.WriteLine("//Fichier de configuration - NE PAS MODIFIER." & Environment.NewLine)

        For i As Integer = 0 To configFileDefaultContent.Count - 1
            writeNewFile.WriteLine(configFileDefaultContent(i))
        Next

        writeNewFile.Close()
    End Sub

    Sub LoadConfigFile(ByVal configFilePath As String, ByVal dataArray() As String, ByVal codeArray() As Integer, ByVal totalMaps As Integer)
        'Lecture du fichier de configuration
        Dim configContent As String
        Dim loadDictionary As New Dictionary(Of String, String)
        Dim StreamIO As StreamReader = New StreamReader(configFilePath)

        configContent = StreamIO.ReadToEnd
        StreamIO.Close()

        'Fonction Regex
        Dim VarPattern As String = "([A-Z]+) = ([0-9A-Za-z]+)"
        For Each m As Match In Regex.Matches(configContent, VarPattern)
            'Si la requête se déroule bien, les valeurs sont ajoutées au dictionnaire Variable
            If (m.Success) Then
                Dim varKey As String = m.Groups(1).Value
                Dim varValue As String = ((m.Groups(2).Value))
                loadDictionary.Add(varKey, varValue)
            End If
        Next

        'Storer les valeurs du dictionnaire dans les tableaux keyDataArray et keyCodeArray

        For i As Integer = 0 To codeArray.Count - 1
            codeArray(i) = CInt(loadDictionary.Item(codeNames(i)))
            dataArray(i) = loadDictionary.Item(dataNames(i))
        Next

        totalMaps = CInt(loadDictionary.Item(maps))
    End Sub

    Sub SaveConfigFile(ByVal configFilePath As String, ByVal codeArray() As Integer, ByVal dataArray() As String, ByVal totalMaps As Integer)
        'Écriture d'un nouveau fichier de configuration
        Dim saveFile As StreamWriter = New StreamWriter(configFilePath)

        saveFile.WriteLine("//Fichier de configuration - NE PAS MODIFIER." & Environment.NewLine)

        For i = 0 To codeArray.Count - 1
            saveFile.Write(codeNames(i) & " = ")
            saveFile.WriteLine(codeArray(i))
        Next

        For i = 0 To dataArray.Count - 1
            saveFile.Write(dataNames(i) & " = ")
            saveFile.WriteLine(dataArray(i))
        Next
        saveFile.WriteLine("MAPS = " & CStr(totalMaps))
        saveFile.Close()
    End Sub
End Module
