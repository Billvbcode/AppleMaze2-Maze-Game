Public Class ClsFoe
    Public strFoeTag As String                'Tag
    Public iFoeLoc As Integer                 'Location
    Public iFoeStart As Integer               'Start
    Public strFoeName As String               'Name
    Public strFoePic As System.Drawing.Image  'Image
    Public strFoeDir As String                'Diirection
    Public bFoeAlive As Boolean               'True = Alive
    Public bCanMove As Boolean                'True = Can Move
    Public bCanShoot As Boolean               'True = Can Shoot
    Public iFoeCnt As Integer                 'Timer Count   
    '
    ' Set default values
    Public Sub New()
        bCanMove = True    'True = Can Move
        bFoeAlive = True   'True = Alive
        bCanShoot = False  'False = Can Not Shoot
        iFoeStart = -1     '-1 = No starting Spot
        strFoeDir = "R"    'R=Move Right
    End Sub
End Class
