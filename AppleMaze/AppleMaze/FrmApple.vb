Public Class FrmApple
    Dim cPic(800) As PictureBox ' Array of Picture Boxes
    Dim iLevel As Integer 'Level
    Dim iMan As Integer   ' Player Location
    Dim sFolder As String  ' Location of map files
    Dim bPlay As Boolean  ' Switch between Play and Edit
    Dim bLoss As Boolean  ' True when you loose
    Dim bWIn As Boolean    'True if you win
    Dim bAuto As Boolean   'True is Auto Draw On
    Dim iApple As Integer  'Number of apples
    Dim ColFoe As Collection 'ColFoe = Collection (all the foes)
    Dim cFoe As ClsFoe       'cFoe = ClsFoe
    Dim iRock As Integer     ' Rock Location
    Dim sRockDir As String   ' Rock Direction
    Dim iShoot As Integer     'iShoot Location
    Dim sShootDir As String   'sShoot Direction
    Dim MyRnd As New Random   'Random Number Generator
    Dim Num As Integer        'Store Random Number
    Private Sub FrmApple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim j As Integer
        Dim iCnt As Integer
        Randomize() 'Random # seed
        iLevel = 1 'Level number
        iMan = 1    ' Player Location
        sFolder = "Map"  ' Location of map files
        bPlay = True   'True  to play
        bLoss = False ' True when you loose
        bWIn = False 'True if you win
        bAuto = False 'False is Auto Draw Off
        iApple = 0      ' Number of Apples
        iCnt = 1
        For j = 1 To 20    ' Vertical
            For i = 1 To 20 ' Horizontal
                'Create Picture Boxes
                cPic(iCnt) = New System.Windows.Forms.PictureBox()
                With cPic(iCnt)
                    .Name = iCnt
                    .Location = New System.Drawing.Point(4 + (i - 1) * 28,
                                                         6 + (j - 1) * 28)
                    .Size = New Size(28, 28)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Image = Pgrass.Image
                    .Tag = "G"
                End With
                Me.Controls.Add(cPic(iCnt))  ' Add Picturebox to form
                AddHandler cPic(iCnt).Click, AddressOf cPic_Click 'Click Event
                AddHandler cPic(iCnt).MouseMove, AddressOf cPic_MouseMove 'Mouse Event
                iCnt += 1
            Next
        Next
        GetFiles() 'Get Files with .txt extension 
        ListBox1.Enabled = False ' Diable Listbox1
        LblPlay.Text = "Play"  ' Display Play 
        LblPlay.BackColor = Color.LightGreen
        LblApple.Text = "Apples= " & iApple ' Write Apples Left
        Me.Text = "Level= " & iLevel  ' Write Level On Top of the Form
        DrawMap()  'Draw the map
    End Sub
    '
    'Get Files with .txt extension 
    Private Sub GetFiles()
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & “\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        '
        ' Check to see if the Directory Exist
        Try
            If di.Exists = False Then
                di.Create() ' Create the Directory if it Dosen't Exist
            End If
        Catch ex As Exception
            MsgBox("Failed", MsgBoxStyle.OkOnly, "Failed")
        End Try
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.txt")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra.Name)
        Next
    End Sub

    'Click Event
    Private Sub cPic_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        i = Val(sender.name) ' Extract Picture Number
        LblClick.Text = "Click  Name=" & sender.name & "   Tag=" & sender.tag & "   #=" & i
        If bPlay Then Exit Sub ' Exit if playing game
        sender.image = PAll.Image ' Copy Image to Tile
        sender.tag = PAll.Tag    ' Copy Tag to Tile
    End Sub

    'MouseMove Event 
    Private Sub cPic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Dim i As Integer
        i = Val(sender.name)  ' Extract Picture Number
        LblMouseMove.Text = "Mouse  Name=" & sender.name & "   Tag=" & sender.tag & "   #=" & i
        If bPlay Then Exit Sub ' Exit if playing game
        If bAuto = False Then Exit Sub ' Exit if auto draw is off
        sender.image = PAll.Image ' Copy Image to Tile
        sender.tag = PAll.Tag    ' Copy Tag to Tile
    End Sub

    Private Sub FrmApple_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & “\"
        Dim sMap As String
        Dim sFileName As String
        Papple2.Visible = False      ' Hide 2nd Apple
        If TimShoot.Enabled Then Exit Sub  'No Movement if Shooting Bullet

        If e.KeyValue = Keys.L Then ' L = Last Level
            If iLevel > 1 Then iLevel -= 1
            DrawMap()  'Draw the map
            Exit Sub
        End If
        If e.KeyValue = Keys.R Or bLoss Then ' R = Restart or If You Lose
            DrawMap()  'Draw the map
            Exit Sub
        End If
        If e.KeyValue = Keys.N Or bWIn Then ' N = Next Level or If You Win
            If iLevel < ListBox1.Items.Count Then
                iLevel += 1 ' For Play or Edit Go to Next Level if it exist
            ElseIf bPlay = False Then
                iLevel += 1   ' in Edit Mode - Create a New Level 
                sFileName = value & iLevel & ".Txt"
                Dim srFileWrite As New System.IO.StreamWriter(sFileName)
                sMap = ""          ' Blank Map
                For i = 1 To 400   ' For all 400 PictureBoxes
                    sMap = sMap & cPic(i).Tag ' Create Map String
                Next
                srFileWrite.WriteLine(sMap) 'Write Map String as a File
                srFileWrite.Close()         'Close File
                LblSave.Text = sFileName
                GetFiles()
            End If
            Me.Text = "Level= " & iLevel  ' Write Level On Top of the Form
            DrawMap()  'Draw the map
            Exit Sub
        End If
        If e.KeyValue = Keys.S And bPlay = False Then   ' S = In Edit Mode Save Map File
            sFileName = value & iLevel & ".txt"
            Dim srFileWrite As New System.IO.StreamWriter(sFileName)
            sMap = ""          ' Blank Map
            For i = 1 To 400   ' For all 400 PictureBoxes
                sMap = sMap & cPic(i).Tag ' Create Map String
            Next
            srFileWrite.WriteLine(sMap) 'Write Map String as a File
            srFileWrite.Close()         'Close File
            LblSave.Text = sFileName
            LblSave.Visible = True
            GetFiles()
            Exit Sub
        End If
        If e.KeyCode = Keys.X And bPlay = False Then ' X = Auto Draw On/Off
            If bAuto Then ' Switch Between Auto Draw On/Off
                bAuto = False
                LblPlay.Text = "Edit (Auto Off)"
                LblPlay.BackColor = Color.Tomato
            Else
                bAuto = True
                LblPlay.Text = "Edit (Auto On)"
                LblPlay.BackColor = Color.Yellow
            End If
        End If
        If e.KeyCode = Keys.P Then
            If bPlay Then ' P = Switch Between Play and Edit
                bPlay = False
                LblPlay.Text = "Edit (Auto Off)"
                LblPlay.BackColor = Color.Tomato
                bAuto = False
                TimFoe.Stop() ' Stop Timer
                DrawMap()
            Else
                bPlay = True
                LblPlay.Text = "Play"
                LblPlay.BackColor = Color.LightGreen
                bAuto = False
                DrawMap()
            End If
        End If
        '
        ' Logic to Move Man
        Dim iNew As Integer
        If bPlay Then ' If Playing Game
            If TimFoe.Enabled = False Then TimFoe.Start() ' Start Timer When Game Starts
            LblSave.Visible = False ' Hide Lblsave
            iNew = iMan
            Select Case e.KeyValue
                Case Keys.Up    ' Up Arrow - Move UP 
                    iNew -= 20
                    sRockDir = "U"  'Save Rock Direction
                Case Keys.Down   ' Down Arrow - Move Down
                    iNew += 20
                    sRockDir = "D"  'Save Rock Direction
                Case Keys.Right  ' Right Arrow - Move Right 
                    iNew += 1
                    sRockDir = "R"  'Save Rock Direction
                Case Keys.Left ' Left Arrow - Move Left
                    iNew -= 1
                    sRockDir = "L"  'Save Rock Direction
            End Select
            If iNew = iMan Then Exit Sub ' Exit if did not move man
            iRock = iNew  'Save Rock Location 
            If cPic(iNew).Tag = "R" Then PushRock 'Push The Rock
            If cPic(iNew).Tag = "W" Then Exit Sub ' Exit if new tile is a wall
            If cPic(iNew).Tag = "D" Or cPic(iNew).Tag = "K" Or cPic(iNew).Tag = "F" _
                Or cPic(iNew).Tag = "Y" Then 'Lose if you hit a Foe
                bLoss = True
                LblSave.Visible = True   'Show Lblsave
                LblSave.Text = "Hit A Foe so You Lost - Push Any Key To Go To Restart"
                cPic(iMan).Image = Pgrass.Image ' Change Old Location to Grass Image
                Exit Sub
            End If
            If cPic(iNew).Tag = "E" Then ' Win only if all apples are gone
                If iApple > 0 Then Exit Sub
                bWIn = True
                LblSave.Visible = True   'Show Lblsave
                LblSave.Text = "You Won - Push Any Key To Go To Next Level"
            End If
            If cPic(iNew).Tag = "H" Then 'Lose if you hit a hole
                bLoss = True
                LblSave.Visible = True   'Show Lblsave
                LblSave.Text = "You Lost - Push Any Key To Go To Restart"
                cPic(iMan).Image = Pgrass.Image ' Change Old Location to Grass Image
                Exit Sub
            End If
            If cPic(iNew).Tag = "A" Then
                iApple -= 1 ' Decrease Apple Count
                Papple2.Visible = True      ' Show 2nd Apple
            End If
            LblApple.Text = "Apples= " & iApple ' Write Apples Left
            cPic(iMan).Image = Pgrass.Image ' Change Old Location to Grass Image
            cPic(iMan).Tag = Pgrass.Tag     ' Change Old Tag to Grass Tag
            iMan = iNew                     ' Change Man Location
            cPic(iMan).Image = PMan.Image   ' Change New Location to Man Image
            cPic(iMan).Tag = PMan.Tag       ' Change New Tag to Man Tag
            If iApple > 0 Then Exit Sub       'Exit if there as more apples
        End If
    End Sub

    Private Sub PApple_Click(sender As Object, e As EventArgs) Handles PApple.Click
        PAll.Image = PApple.Image 'Copy Apple Image To Pall
        PAll.Tag = PApple.Tag
        LblTag.Text = PApple.Tag
    End Sub

    Private Sub pChest_Click(sender As Object, e As EventArgs) Handles pChest.Click
        PAll.Image = pChest.Image 'Copy Chest Image To Pall
        PAll.Tag = pChest.Tag
        LblTag.Text = pChest.Tag
    End Sub

    Private Sub pExit_Click(sender As Object, e As EventArgs) Handles pExit.Click
        PAll.Image = pExit.Image 'Copy Exit Image To Pall
        PAll.Tag = pExit.Tag
        LblTag.Text = pExit.Tag
    End Sub

    Private Sub Pgrass_Click(sender As Object, e As EventArgs) Handles Pgrass.Click
        PAll.Image = Pgrass.Image 'Copy Grass Image To Pall
        PAll.Tag = Pgrass.Tag
        LblTag.Text = Pgrass.Tag
    End Sub

    Private Sub pHole_Click(sender As Object, e As EventArgs) Handles pHole.Click
        PAll.Image = pHole.Image 'Copy Hole Image To Pall
        PAll.Tag = pHole.Tag
        LblTag.Text = pHole.Tag
    End Sub

    Private Sub PMan_Click(sender As Object, e As EventArgs) Handles PMan.Click
        PAll.Image = PMan.Image 'Copy Man Image To Pall
        PAll.Tag = PMan.Tag
        LblTag.Text = PMan.Tag
    End Sub

    Private Sub pWall_Click(sender As Object, e As EventArgs) Handles pWall.Click
        PAll.Image = pWall.Image 'Copy Wall Image To Pall
        PAll.Tag = pWall.Tag
        LblTag.Text = pWall.Tag
    End Sub
    Private Sub DrawMap()
        Dim sFileName As String
        Dim value As String = My.Application.Info.DirectoryPath & "\" & sFolder & "\"
        Dim sMap As String ' Save Map Information
        Dim sTag As String
        Dim i As Integer
        TimFoe.Stop()             'Stop Timer
        bLoss = False ' Set Loss To False (Did not lose)
        bWIn = False  ' Set Win To False (Did not Win)
        iApple = 0    ' Set Apples to 0
        Me.Text = "Level= " & iLevel  ' Write Level On Top of the Form
        '
        ' Read Map File File This Level
        Dim srFileReader As System.IO.StreamReader            '
        ' Value is the current file directory        '
        sFileName = value & iLevel & ".Txt"   ' File Name ' File Name
        srFileReader = System.IO.File.OpenText(sFileName) 'Open File
        sMap = srFileReader.ReadLine()    'Read File
        srFileReader.Close()

        ColFoe = New Collection ' Reset the collectioo
        cFoe = New ClsFoe       'New Class  Foe
        cFoe.bFoeAlive = False     'False = Not Alive
        ColFoe.Add(cFoe)         'Add Dummy Foe to collextion  
        iMan = 1
        For i = 1 To 400
            sTag = Mid(sMap, i, 1) ' Extract Map Tag
            cPic(i).Tag = sTag ' Set Picture Tag To Correct Tag
            Select Case sTag
                Case "D"    ' D=Drop
                    cPic(i).Image = pDrop.Image
                    cFoe = New ClsFoe       'New Class  Foe
                    cFoe.iFoeLoc = i         'Drop Location
                    cFoe.strFoeName = "Drop"  'Drop Name
                    cFoe.strFoeTag = pDrop.Tag 'Drop Tag
                    cFoe.strFoePic = pDrop.Image 'Drop Image
                    ColFoe.Add(cFoe)         'Add Drop to collextion  
                Case "F"    ' F=Fire
                    cPic(i).Image = pFire.Image
                    cFoe = New ClsFoe       'New Class  Foe
                    cFoe.iFoeLoc = i         'Fire Location
                    cFoe.iFoeStart = i        'Fire Starting Location
                    cFoe.strFoeName = "Fire"  'Fire Name
                    cFoe.strFoeTag = pFire.Tag 'Fire Tag
                    cFoe.strFoePic = pFire.Image 'Fire Image
                    ColFoe.Add(cFoe)         'Add Fire to collextion 
                Case "K"    ' K=Knight
                    cPic(i).Image = pKnight.Image
                    cFoe = New ClsFoe       'New Class  Foe
                    cFoe.iFoeLoc = i         'Knight Location
                    cFoe.strFoeName = "Knight"  'Knight Name
                    cFoe.strFoeTag = pKnight.Tag 'Knight Tag
                    cFoe.strFoePic = pKnight.Image 'Knight Image
                    cFoe.strFoeDir = "D"           'Knight will move down
                    ColFoe.Add(cFoe)         'Add Knight to collextion  
                Case "R"    ' R=Rock
                    cPic(i).Image = pRock.Image
                Case "Y"    ' Y=Eye
                    cPic(i).Image = pEye.Image
                    cFoe = New ClsFoe       'New Class  Foe
                    cFoe.iFoeLoc = i         'Eye Location
                    cFoe.strFoeName = "Eye"  'Eye Name
                    cFoe.strFoeTag = pEye.Tag 'Eye Tag
                    cFoe.strFoePic = pEye.Image 'Eye Image
                    cFoe.bCanMove = False        'False = Eye can not move
                    cFoe.bCanShoot = True        'True = Eye Can Shoot
                    ColFoe.Add(cFoe)         'Add Eye to collextion  
                Case "A"    ' A=Apple
                    cPic(i).Image = PApple.Image
                    iApple += 1 ' Increase Apple Count
                Case "C"  'C=Chest
                    cPic(i).Image = pChest.Image
                    Num = MyRnd.Next(1, 4)
                    If Num > 2 Then   ' Hide Apple in some chest
                        cPic(i).Tag = "A"
                        iApple += 1 ' Increase Apple Count
                    End If
                Case "E"  ' E=Exit
                    cPic(i).Image = pExit.Image
                Case "G"  'G=Grass
                    cPic(i).Image = Pgrass.Image
                Case "H"  ' H=Hole
                    cPic(i).Image = pHole.Image
                Case "M"
                    cPic(i).Image = PMan.Image
                    iMan = i
                Case "W"
                    cPic(i).Image = pWall.Image
            End Select
        Next
        LblApple.Text = "Apples= " & iApple ' Write Apples Left
    End Sub

    Private Sub pKinght_Click(sender As Object, e As EventArgs) Handles pKnight.Click
        PAll.Image = pKnight.Image 'Copy Knight Image To Pall
        PAll.Tag = pKnight.Tag
        LblTag.Text = pKnight.Tag
    End Sub

    Private Sub pDrop_Click(sender As Object, e As EventArgs) Handles pDrop.Click
        PAll.Image = pDrop.Image 'Copy Drop Image To Pall
        PAll.Tag = pDrop.Tag
        LblTag.Text = pDrop.Tag
    End Sub

    Private Sub pFire_Click(sender As Object, e As EventArgs) Handles pFire.Click
        PAll.Image = pFire.Image 'Copy Fire Image To Pall
        PAll.Tag = pFire.Tag
        LblTag.Text = pFire.Tag
    End Sub

    Private Sub pRock_Click(sender As Object, e As EventArgs) Handles pRock.Click
        PAll.Image = pRock.Image 'Copy Fire Image To Pall
        PAll.Tag = pRock.Tag
        LblTag.Text = pRock.Tag
    End Sub

    Private Sub pEye_Click(sender As Object, e As EventArgs) Handles pEye.Click
        PAll.Image = pEye.Image 'Copy Fire Image To Pall
        PAll.Tag = pEye.Tag
        LblTag.Text = pEye.Tag
    End Sub

    Private Sub TimFoe_Tick(sender As Object, e As EventArgs) Handles TimFoe.Tick
        Dim i As Integer
        Dim iNew As Integer
        Dim sRev As String
        For Each cFoe In ColFoe
            If cFoe.bFoeAlive Then     ' Only if Foe Alive
                If cFoe.bCanMove Then  ' Only if Foe Can Move
                    iNew = cFoe.iFoeLoc
                    cPic(cFoe.iFoeLoc).Image = Pgrass.Image ' Erase Current image
                    cPic(cFoe.iFoeLoc).Tag = Pgrass.Tag     ' Erase Current tag
                    Select Case cFoe.strFoeDir      ' iNew = Where to move
                        Case "U"
                            iNew -= 20
                            sRev = "D"   ' Reverse Direction
                        Case "D"
                            iNew += 20
                            sRev = "U"    ' Reverse Direction
                        Case "R"
                            iNew += 1
                            sRev = "L"   ' Reverse Direction
                        Case "L"
                            iNew -= 1
                            sRev = "R"   ' Reverse Direction
                    End Select
                    If cPic(iNew).Tag = "G" Or cPic(iNew).Tag = "M" Then ' Only if Grass or Man
                        cFoe.iFoeLoc = iNew                ' Move Foe to new location
                    Else
                        If cFoe.iFoeStart > 0 Then
                            cFoe.iFoeLoc = cFoe.iFoeStart  'Restart Foe at Starting Spot
                        Else
                            cFoe.strFoeDir = sRev           'Reverse Foe Direction
                        End If
                    End If
                    cPic(cFoe.iFoeLoc).Image = cFoe.strFoePic ' Place Foe image
                    cPic(cFoe.iFoeLoc).Tag = cFoe.strFoeTag   ' Place Foe tag
                    If cFoe.iFoeLoc = iMan Then 'Loss if Foe Hits Man
                        bLoss = True
                        LblSave.Visible = True   'Show Lblsave
                        LblSave.Text = cFoe.strFoeName & " Hit You so You Lost - Push Any Key To Go To Restart"
                        TimFoe.Stop()  ' Stop Timer
                        Exit Sub
                    End If
                End If
                '
                ' Shooting Logic
                Dim sFDir() As String = {"R", "L", "D", "U"}
                Dim iAdd() As Integer = {1, -1, 20, -20}
                Dim j As Integer
                If cFoe.bCanShoot Then  ' Only if Foe Can Move
                    For j = 0 To 3                        ' For Each Direction
                        iShoot = cFoe.iFoeLoc + iAdd(j)   'Add Offset
                        For i = 1 To 20
                            If cPic(iShoot).Tag = "M" Then      'Shoot If Hit Man
                                iShoot = cFoe.iFoeLoc + iAdd(j) 'Shoot Location
                                sShootDir = sFDir(j)            'Shoot Direction
                                TimFoe.Stop()                   'Stop Timfoe
                                cPic(iShoot).Image = pShoot.Image ' PShoot Image
                                TimShoot.Start()                  'Start Shoot Timer
                                Exit Sub
                            ElseIf cPic(iShoot).Tag <> "G" Then
                                Exit For                   'Exit For if Not Grass
                            End If
                            iShoot += iAdd(j)
                        Next
                    Next
                End If
            End If
        Next
    End Sub

    Private Sub TimShoot_Tick(sender As Object, e As EventArgs) Handles TimShoot.Tick
        Dim iNew As Integer
        iNew = iShoot                     ' Shoot Location
        cPic(iShoot).Image = Pgrass.Image ' Erase Old image
        cPic(iShoot).Tag = Pgrass.Tag     ' Erase Old  tag
        Select Case sShootDir   ' iNew = Where to move
            Case "U"
                iNew -= 20
            Case "D"
                iNew += 20
            Case "R"
                iNew += 1
            Case "L"
                iNew -= 1
        End Select
        iShoot = iNew   ' Move Bullet
        cPic(iShoot).Image = pShoot.Image ' PShoot Image
        If cPic(iNew).Tag <> "M" Then Exit Sub 'Exit If Not Man 
        cPic(iShoot).Image = Pgrass.Image ' Erase Current image
        cPic(iShoot).Tag = Pgrass.Tag     ' Erase Current tag
        bLoss = True                      ' Lose if hit by bullet
        LblSave.Visible = True   'Show Lblsave
        LblSave.Text = " You Lost - Push Any Key To Go To Restart"
        TimShoot.Stop()  ' Stop Shoot Timer
        TimFoe.Stop()  ' Stop Timer
    End Sub
    Private Sub PushRock()
        Dim iNew As Integer
        iNew = iRock           ' Rock Location
        Select Case sRockDir   ' iNew = Where to move
            Case "U"
                iNew -= 20
            Case "D"
                iNew += 20
            Case "R"
                iNew += 1
            Case "L"
                iNew -= 1
        End Select
        If cPic(iNew).Tag = "G" Or cPic(iNew).Tag = "H" Then
            cPic(iRock).Image = Pgrass.Image ' Erase Old image
            cPic(iRock).Tag = Pgrass.Tag     ' Erase Old  tag
            iRock = iNew   ' Move Rock
            If cPic(iNew).Tag = "G" Then
                cPic(iRock).Image = pRock.Image ' Rock Image
                cPic(iRock).Tag = pRock.Tag ' Rock Image
            Else
                cPic(iRock).Image = Pgrass.Image ' Erase Hole
                cPic(iRock).Tag = Pgrass.Tag     ' Erase Hole
            End If
        End If

    End Sub
End Class