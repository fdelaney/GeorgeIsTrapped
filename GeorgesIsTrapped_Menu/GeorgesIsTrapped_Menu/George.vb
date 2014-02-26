Imports System.Drawing
Imports System.IO

Public Class George
    'Variable Carte
    Dim Carte As New Board(15, 15) 'Carte pour graphique
    Public CarteLogique(15, 15) As Tuiles 'Carte logique

    Dim UpControl As Keys = Keys.Up
    Dim DownControl As Keys = Keys.Down
    Dim LeftControl As Keys = Keys.Left
    Dim RightControl As Keys = Keys.Right

    Public moved As Boolean
    Public characterLock As Boolean = False
    Public tuile As Tuiles
    Public cases As PictureBox

    Dim FinX As Integer
    Dim finY As Integer
    Dim MapNumber As Integer
    Public nombreMap As Integer = 5
    Dim nomFichier As String
    Dim MapDejaJoues(nombreMap - 1) As Boolean
    Dim AuMoinsUnNiveauComplete As Boolean

    'Variable timer
    Dim tempsMinutes As Integer
    Dim tempsSecondes As Integer
    Dim meilleurTempsSecondes As Integer = 59
    Dim meilleurTempsMinutes As Integer = 0
    Dim cartePlusRapide As Integer

    'Variables Personnages
    Dim direction As Short
    Dim PersoX As Integer
    Dim PersoY As Integer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        moved = False
        If characterLock = False Then
            Select Case e.KeyCode
                Case UpControl
                    direction = 0
                    PersoY = Carte.moveCharacterUp(PersoX, PersoY)
                Case DownControl
                    direction = 1
                    PersoY = Carte.moveCharacterDown(PersoX, PersoY)
                Case LeftControl
                    direction = 2
                    PersoX = Carte.moveCharacterLeft(PersoX, PersoY)
                Case RightControl
                    direction = 3
                    PersoX = Carte.moveCharacterRight(PersoX, PersoY)
            End Select
            updateGraphics(PersoX, PersoY, direction)
        End If
        'Conditions de Victoire
        If (PersoX = FinX) AndAlso (PersoY = finY) Then
            characterLock = True
            AuMoinsUnNiveauComplete = True
            TmrTempsLimite.Stop()
            If tempsMinutes <= meilleurTempsMinutes AndAlso tempsSecondes < meilleurTempsSecondes AndAlso tempsSecondes <> 0 Then
                meilleurTempsMinutes = tempsMinutes
                meilleurTempsSecondes = tempsSecondes
                cartePlusRapide = MapNumber
            End If

            lblVictoire.Visible = True
            lblVictoireMessage.Visible = True
            lblNextLevel.Visible = True
            lblNextLevel.Enabled = True
            lblNextLevelSelected.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrTempsLimite.Start()
        Dim Map As FlowLayoutPanel = DirectCast(Me.Controls.Item("BoardContainer"), FlowLayoutPanel)
        Dim tuile As Tuiles
        Dim cases As PictureBox

        For y As Integer = 0 To 14
            For x As Integer = 0 To 14
                cases = New PictureBox
                tuile = New Tuiles
                cases.Name = "PB" + CStr(x) + "," + CStr(y)
                cases.Size = New Size(50, 50)
                cases.Margin = New Padding(0)
                cases.Padding = New Padding(0)
                Map.Controls.Add(cases)
                CarteLogique(x, y) = (tuile)
            Next
        Next

        NewMap(MapNumber)

        My.Computer.Audio.Play(My.Resources._8_Bit_Weapon___Chip_On_Your_Shoulder, AudioPlayMode.BackgroundLoop)
    End Sub
    Sub RandomizeMapNumber()
        Dim totalDePartiesJoues As Integer
        Randomize()
        Do
            MapNumber = CInt(Int(nombreMap * Rnd()))
        Loop While (MapDejaJoues(MapNumber))
        MapDejaJoues(MapNumber) = True

        For i = 0 To (MapDejaJoues.Count - 1)
            If MapDejaJoues(i) = True Then
                totalDePartiesJoues += 1
            End If
        Next
        If totalDePartiesJoues = nombreMap Then
            For i = 0 To (MapDejaJoues.Count - 1)
                MapDejaJoues(i) = False
            Next
        End If
        lblNombreNiveau.Text = CStr(MapNumber + 1)
    End Sub

    Function GenererNomMap(numeroMap As Integer) As String
        nomFichier = "Map" + CStr(numeroMap) + ".txt"
        Return nomFichier
    End Function

    Sub mapFilesAreValid()
        Dim newFileToLoad As String = GenererNomMap(MapNumber)
        Dim lectureFichier As StreamReader = New StreamReader(newFileToLoad)
        Dim fileIsValid As Boolean = True
        If Not File.Exists(GenererNomMap(MapNumber)) Then
            fileIsValid = False
            MsgBox("Aucun fichier de carte n'a été trouvé. L'application va terminer.")
            Application.Exit()
        End If
        lectureFichier.Close()

    End Sub

    Private Sub NewMap(ByVal mapNumber As Integer)
        Dim Map As FlowLayoutPanel = DirectCast(Me.Controls.Item("BoardContainer"), FlowLayoutPanel)
        Dim caseTemp As String
        Dim CaseActuelle As PictureBox
        Dim newFileToLoad As String = GenererNomMap(mapNumber)
        Dim lectureFichier As StreamReader = New StreamReader(newFileToLoad)


        RandomizeMapNumber()
        mapFilesAreValid()

            For y As Integer = 0 To 14
                For x As Integer = 0 To 14
                    CaseActuelle = DirectCast(Map.Controls.Item("PB" + CStr(x) + "," + CStr(y)), PictureBox)
                    If x = 14 Then
                        caseTemp = lectureFichier.ReadLine()
                    Else
                        caseTemp = ChrW(lectureFichier.Read)
                    End If

                    Select Case caseTemp
                        Case "b"
                            CaseActuelle.Image = PcbBrique.Image
                            CarteLogique(x, y).collision = True
                        Case "g"
                            CaseActuelle.Image = PcbGazon.Image
                            CarteLogique(x, y).collision = False
                        Case "r"
                            CaseActuelle.Image = PcbRoche.Image
                        Case "s"
                            CaseActuelle.Image = PcbGeorgesDown.Image
                            CarteLogique(x, y).collision = False
                            PersoX = x
                            PersoY = y
                        Case "f"
                            CaseActuelle.Image = PcbÉchelle.Image
                            CarteLogique(x, y).collision = False
                            FinX = x
                            finY = y
                    End Select
                Next
            Next
            lectureFichier.Close()


    End Sub

    Private Sub updateGraphics(PosX As Integer, PosY As Integer, direction As Short)
        'BOUGER LE SPRITE DU PERSONNAGE
        Dim Map As FlowLayoutPanel = DirectCast(Me.Controls.Item("BoardContainer"), FlowLayoutPanel)
        Dim CasePerso As PictureBox = DirectCast(Map.Controls.Item("PB" + CStr(PosX) + "," + CStr(PosY)), PictureBox)
        Dim CasePrécédente As PictureBox
            Select Case direction
            Case 0
                CasePerso.Image = PcbGeorgesUp.Image
                If moved = True Then
                    CasePrécédente = DirectCast(Map.Controls.Item("PB" + CStr(PosX) + "," + CStr(PosY + 1)), PictureBox)
                    CasePrécédente.Image = PcbGazon.Image
                End If
            Case 1
                CasePerso.Image = PcbGeorgesDown.Image
                If moved = True Then
                    CasePrécédente = DirectCast(Map.Controls.Item("PB" + CStr(PosX) + "," + CStr(PosY - 1)), PictureBox)
                    CasePrécédente.Image = PcbGazon.Image
                End If
            Case 2
                CasePerso.Image = PcbGeorgesLeft.Image
                If moved = True Then
                    CasePrécédente = DirectCast(Map.Controls.Item("PB" + CStr(PosX + 1) + "," + CStr(PosY)), PictureBox)
                    CasePrécédente.Image = PcbGazon.Image
                End If
            Case 3
                CasePerso.Image = PcbGeorgesRight.Image
                If moved = True Then
                    CasePrécédente = DirectCast(Map.Controls.Item("PB" + CStr(PosX - 1) + "," + CStr(PosY)), PictureBox)
                    CasePrécédente.Image = PcbGazon.Image
                End If
        End Select
    End Sub

    Private Sub TmrTempsLimite_Tick(sender As Object, e As EventArgs) Handles TmrTempsLimite.Tick
        If tempsSecondes > 58 Then
            tempsMinutes += 1
            tempsSecondes = 0
        Else
            tempsSecondes += 1
        End If

        lblChrono.Text = (CStr(Format(tempsMinutes, "00"))) + ":" + (CStr(Format(tempsSecondes, "00")))
    End Sub

    Private Sub lblGoToMenu_Click(sender As Object, e As EventArgs) Handles lblGoToMenu.Click
        TmrTempsLimite.Stop()
        characterLock = False
        My.Computer.Audio.Play(My.Resources.Kola_Kid___castle, AudioPlayMode.BackgroundLoop)
        If AuMoinsUnNiveauComplete Then
            MessageBox.Show("Votre temps le plus rapide a été de " + CStr(meilleurTempsMinutes) + " minutes et " + CStr(meilleurTempsSecondes) + " secondes dans la carte " + CStr(cartePlusRapide + 1) + "!", "Votre meilleur temps!", MessageBoxButtons.OK)
        End If
        frmMenuPrincipal.Enabled = True
        frmMenuPrincipal.Visible = True
        Me.Close()
    End Sub

    Private Sub lblGoToMenu_MouseEnter(sender As Object, e As EventArgs) Handles lblGoToMenu.MouseEnter
        MouseEnterLabelGame(lblGoToMenu, lblMenuSelected)
    End Sub

    Private Sub lblGoToMenu_MouseLeave(sender As Object, e As EventArgs) Handles lblGoToMenu.MouseLeave
        MouseLeaveLabelGame(lblGoToMenu, lblMenuSelected)
    End Sub

    Private Sub lblNextLevel_Click(sender As Object, e As EventArgs) Handles lblNextLevel.Click
        tempsMinutes = 0
        tempsSecondes = 0
        lblChrono.Text = "00:00"
        TmrTempsLimite.Start()
        characterLock = False
        lblVictoire.Visible = False
        lblVictoireMessage.Visible = False
        lblNextLevel.Visible = False
        lblNextLevelSelected.Visible = False
        lblNextLevel.Enabled = False
        lblNextLevelSelected.Enabled = False
        NewMap(MapNumber)
    End Sub

    Private Sub lblNextLevel_MouseEnter(sender As Object, e As EventArgs) Handles lblNextLevel.MouseEnter
        MouseEnterLabelGame(lblNextLevel, lblNextLevelSelected)
    End Sub

    Private Sub lblNextLevel_MouseLeave(sender As Object, e As EventArgs) Handles lblNextLevel.MouseLeave
        MouseLeaveLabelGame(lblNextLevel, lblNextLevelSelected)
    End Sub
End Class