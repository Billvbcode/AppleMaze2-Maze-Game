<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApple
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblClick = New System.Windows.Forms.Label()
        Me.LblMouseMove = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LblPlay = New System.Windows.Forms.Label()
        Me.PApple = New System.Windows.Forms.PictureBox()
        Me.PMan = New System.Windows.Forms.PictureBox()
        Me.pWall = New System.Windows.Forms.PictureBox()
        Me.Pgrass = New System.Windows.Forms.PictureBox()
        Me.pChest = New System.Windows.Forms.PictureBox()
        Me.pHole = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.PAll = New System.Windows.Forms.PictureBox()
        Me.LblTag = New System.Windows.Forms.Label()
        Me.LblSave = New System.Windows.Forms.Label()
        Me.LblApple = New System.Windows.Forms.Label()
        Me.pDrop = New System.Windows.Forms.PictureBox()
        Me.pFire = New System.Windows.Forms.PictureBox()
        Me.pKnight = New System.Windows.Forms.PictureBox()
        Me.pRock = New System.Windows.Forms.PictureBox()
        Me.pEye = New System.Windows.Forms.PictureBox()
        Me.pShoot = New System.Windows.Forms.PictureBox()
        Me.TimFoe = New System.Windows.Forms.Timer(Me.components)
        Me.TimShoot = New System.Windows.Forms.Timer(Me.components)
        Me.Papple2 = New System.Windows.Forms.PictureBox()
        CType(Me.PApple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pgrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pChest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pHole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pFire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pKnight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pShoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Papple2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblClick
        '
        Me.LblClick.AutoSize = True
        Me.LblClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClick.Location = New System.Drawing.Point(633, 561)
        Me.LblClick.Name = "LblClick"
        Me.LblClick.Size = New System.Drawing.Size(83, 24)
        Me.LblClick.TabIndex = 8
        Me.LblClick.Text = "LblClick"
        '
        'LblMouseMove
        '
        Me.LblMouseMove.AutoSize = True
        Me.LblMouseMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMouseMove.Location = New System.Drawing.Point(633, 592)
        Me.LblMouseMove.Name = "LblMouseMove"
        Me.LblMouseMove.Size = New System.Drawing.Size(152, 24)
        Me.LblMouseMove.TabIndex = 9
        Me.LblMouseMove.Text = "LblMouseMove"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(637, 411)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(114, 69)
        Me.ListBox1.TabIndex = 10
        '
        'LblPlay
        '
        Me.LblPlay.AutoSize = True
        Me.LblPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlay.Location = New System.Drawing.Point(633, 526)
        Me.LblPlay.Name = "LblPlay"
        Me.LblPlay.Size = New System.Drawing.Size(77, 24)
        Me.LblPlay.TabIndex = 11
        Me.LblPlay.Text = "LblPlay"
        '
        'PApple
        '
        Me.PApple.Image = Global.WindowsApplication1.My.Resources.Resources.Food1
        Me.PApple.Location = New System.Drawing.Point(12, 591)
        Me.PApple.Name = "PApple"
        Me.PApple.Size = New System.Drawing.Size(25, 25)
        Me.PApple.TabIndex = 14
        Me.PApple.TabStop = False
        Me.PApple.Tag = "A"
        '
        'PMan
        '
        Me.PMan.Image = Global.WindowsApplication1.My.Resources.Resources.Man
        Me.PMan.Location = New System.Drawing.Point(167, 592)
        Me.PMan.Name = "PMan"
        Me.PMan.Size = New System.Drawing.Size(25, 25)
        Me.PMan.TabIndex = 13
        Me.PMan.TabStop = False
        Me.PMan.Tag = "M"
        '
        'pWall
        '
        Me.pWall.Image = Global.WindowsApplication1.My.Resources.Resources.Wall
        Me.pWall.Location = New System.Drawing.Point(198, 592)
        Me.pWall.Name = "pWall"
        Me.pWall.Size = New System.Drawing.Size(25, 25)
        Me.pWall.TabIndex = 12
        Me.pWall.TabStop = False
        Me.pWall.Tag = "W"
        '
        'Pgrass
        '
        Me.Pgrass.Image = Global.WindowsApplication1.My.Resources.Resources.Ground
        Me.Pgrass.Location = New System.Drawing.Point(105, 592)
        Me.Pgrass.Name = "Pgrass"
        Me.Pgrass.Size = New System.Drawing.Size(25, 25)
        Me.Pgrass.TabIndex = 7
        Me.Pgrass.TabStop = False
        Me.Pgrass.Tag = "G"
        '
        'pChest
        '
        Me.pChest.Image = Global.WindowsApplication1.My.Resources.Resources.chest
        Me.pChest.Location = New System.Drawing.Point(43, 592)
        Me.pChest.Name = "pChest"
        Me.pChest.Size = New System.Drawing.Size(25, 25)
        Me.pChest.TabIndex = 15
        Me.pChest.TabStop = False
        Me.pChest.Tag = "C"
        '
        'pHole
        '
        Me.pHole.Image = Global.WindowsApplication1.My.Resources.Resources.Hole
        Me.pHole.Location = New System.Drawing.Point(136, 592)
        Me.pHole.Name = "pHole"
        Me.pHole.Size = New System.Drawing.Size(25, 25)
        Me.pHole.TabIndex = 16
        Me.pHole.TabStop = False
        Me.pHole.Tag = "H"
        '
        'pExit
        '
        Me.pExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.pExit.Location = New System.Drawing.Point(74, 592)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(25, 25)
        Me.pExit.TabIndex = 17
        Me.pExit.TabStop = False
        Me.pExit.Tag = "E"
        '
        'PAll
        '
        Me.PAll.Image = Global.WindowsApplication1.My.Resources.Resources.Ground
        Me.PAll.Location = New System.Drawing.Point(548, 575)
        Me.PAll.Name = "PAll"
        Me.PAll.Size = New System.Drawing.Size(25, 25)
        Me.PAll.TabIndex = 18
        Me.PAll.TabStop = False
        Me.PAll.Tag = "G"
        '
        'LblTag
        '
        Me.LblTag.AutoSize = True
        Me.LblTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTag.Location = New System.Drawing.Point(544, 603)
        Me.LblTag.Name = "LblTag"
        Me.LblTag.Size = New System.Drawing.Size(74, 24)
        Me.LblTag.TabIndex = 19
        Me.LblTag.Text = "LblTag"
        '
        'LblSave
        '
        Me.LblSave.AutoSize = True
        Me.LblSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSave.Location = New System.Drawing.Point(407, 630)
        Me.LblSave.Name = "LblSave"
        Me.LblSave.Size = New System.Drawing.Size(84, 24)
        Me.LblSave.TabIndex = 20
        Me.LblSave.Text = "LblSave"
        '
        'LblApple
        '
        Me.LblApple.AutoSize = True
        Me.LblApple.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApple.Location = New System.Drawing.Point(633, 493)
        Me.LblApple.Name = "LblApple"
        Me.LblApple.Size = New System.Drawing.Size(93, 24)
        Me.LblApple.TabIndex = 21
        Me.LblApple.Text = "LblApple"
        '
        'pDrop
        '
        Me.pDrop.Image = Global.WindowsApplication1.My.Resources.Resources.Blob
        Me.pDrop.Location = New System.Drawing.Point(272, 592)
        Me.pDrop.Name = "pDrop"
        Me.pDrop.Size = New System.Drawing.Size(25, 25)
        Me.pDrop.TabIndex = 25
        Me.pDrop.TabStop = False
        Me.pDrop.Tag = "D"
        '
        'pFire
        '
        Me.pFire.Image = Global.WindowsApplication1.My.Resources.Resources.Fire
        Me.pFire.Location = New System.Drawing.Point(303, 592)
        Me.pFire.Name = "pFire"
        Me.pFire.Size = New System.Drawing.Size(25, 25)
        Me.pFire.TabIndex = 24
        Me.pFire.TabStop = False
        Me.pFire.Tag = "F"
        '
        'pKnight
        '
        Me.pKnight.Image = Global.WindowsApplication1.My.Resources.Resources.ghost
        Me.pKnight.Location = New System.Drawing.Point(241, 592)
        Me.pKnight.Name = "pKnight"
        Me.pKnight.Size = New System.Drawing.Size(25, 25)
        Me.pKnight.TabIndex = 22
        Me.pKnight.TabStop = False
        Me.pKnight.Tag = "K"
        '
        'pRock
        '
        Me.pRock.Image = Global.WindowsApplication1.My.Resources.Resources.Rock
        Me.pRock.Location = New System.Drawing.Point(334, 591)
        Me.pRock.Name = "pRock"
        Me.pRock.Size = New System.Drawing.Size(25, 25)
        Me.pRock.TabIndex = 27
        Me.pRock.TabStop = False
        Me.pRock.Tag = "R"
        '
        'pEye
        '
        Me.pEye.Image = Global.WindowsApplication1.My.Resources.Resources.eye1
        Me.pEye.Location = New System.Drawing.Point(365, 591)
        Me.pEye.Name = "pEye"
        Me.pEye.Size = New System.Drawing.Size(25, 25)
        Me.pEye.TabIndex = 26
        Me.pEye.TabStop = False
        Me.pEye.Tag = "Y"
        '
        'pShoot
        '
        Me.pShoot.Image = Global.WindowsApplication1.My.Resources.Resources.e2
        Me.pShoot.Location = New System.Drawing.Point(396, 592)
        Me.pShoot.Name = "pShoot"
        Me.pShoot.Size = New System.Drawing.Size(25, 25)
        Me.pShoot.TabIndex = 28
        Me.pShoot.TabStop = False
        Me.pShoot.Tag = "Y"
        '
        'TimFoe
        '
        Me.TimFoe.Interval = 800
        '
        'TimShoot
        '
        '
        'Papple2
        '
        Me.Papple2.Image = Global.WindowsApplication1.My.Resources.Resources.Food1
        Me.Papple2.Location = New System.Drawing.Point(650, 353)
        Me.Papple2.Name = "Papple2"
        Me.Papple2.Size = New System.Drawing.Size(25, 25)
        Me.Papple2.TabIndex = 29
        Me.Papple2.TabStop = False
        Me.Papple2.Tag = "A"
        Me.Papple2.Visible = False
        '
        'FrmApple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 663)
        Me.Controls.Add(Me.Papple2)
        Me.Controls.Add(Me.pShoot)
        Me.Controls.Add(Me.pRock)
        Me.Controls.Add(Me.pEye)
        Me.Controls.Add(Me.pDrop)
        Me.Controls.Add(Me.pFire)
        Me.Controls.Add(Me.pKnight)
        Me.Controls.Add(Me.LblApple)
        Me.Controls.Add(Me.LblSave)
        Me.Controls.Add(Me.LblTag)
        Me.Controls.Add(Me.PAll)
        Me.Controls.Add(Me.pExit)
        Me.Controls.Add(Me.pHole)
        Me.Controls.Add(Me.pChest)
        Me.Controls.Add(Me.PApple)
        Me.Controls.Add(Me.PMan)
        Me.Controls.Add(Me.pWall)
        Me.Controls.Add(Me.LblPlay)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LblMouseMove)
        Me.Controls.Add(Me.LblClick)
        Me.Controls.Add(Me.Pgrass)
        Me.Name = "FrmApple"
        Me.Text = "FrmApple"
        CType(Me.PApple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pgrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pChest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pHole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pFire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pKnight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pShoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Papple2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pgrass As PictureBox
    Friend WithEvents LblClick As Label
    Friend WithEvents LblMouseMove As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LblPlay As Label
    Friend WithEvents pWall As PictureBox
    Friend WithEvents PMan As PictureBox
    Friend WithEvents PApple As PictureBox
    Friend WithEvents pChest As PictureBox
    Friend WithEvents pHole As PictureBox
    Friend WithEvents pExit As PictureBox
    Friend WithEvents PAll As PictureBox
    Friend WithEvents LblTag As Label
    Friend WithEvents LblSave As Label
    Friend WithEvents LblApple As Label
    Friend WithEvents pDrop As PictureBox
    Friend WithEvents pFire As PictureBox
    Friend WithEvents pKnight As PictureBox
    Friend WithEvents pRock As PictureBox
    Friend WithEvents pEye As PictureBox
    Friend WithEvents pShoot As PictureBox
    Friend WithEvents TimFoe As Timer
    Friend WithEvents TimShoot As Timer
    Friend WithEvents Papple2 As PictureBox
End Class
