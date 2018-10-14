<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpThrows = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblCompWins = New System.Windows.Forms.Label()
        Me.lblPlayerWins = New System.Windows.Forms.Label()
        Me.lblDraws = New System.Windows.Forms.Label()
        Me.lblCompWinsnum = New System.Windows.Forms.Label()
        Me.lblPlayerWinsnum = New System.Windows.Forms.Label()
        Me.lblDrawsnum = New System.Windows.Forms.Label()
        Me.grpThrows.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpThrows
        '
        Me.grpThrows.Controls.Add(Me.radScissors)
        Me.grpThrows.Controls.Add(Me.radPaper)
        Me.grpThrows.Controls.Add(Me.radRock)
        Me.grpThrows.Location = New System.Drawing.Point(125, 85)
        Me.grpThrows.Name = "grpThrows"
        Me.grpThrows.Size = New System.Drawing.Size(447, 163)
        Me.grpThrows.TabIndex = 0
        Me.grpThrows.TabStop = False
        Me.grpThrows.Text = "Choose Your Throw"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(298, 74)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(125, 29)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(156, 74)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(100, 29)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(22, 74)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(92, 29)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Location = New System.Drawing.Point(204, 275)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(0, 25)
        Me.lblWinner.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(209, 351)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(244, 49)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblCompWins
        '
        Me.lblCompWins.AutoSize = True
        Me.lblCompWins.Location = New System.Drawing.Point(174, 486)
        Me.lblCompWins.Name = "lblCompWins"
        Me.lblCompWins.Size = New System.Drawing.Size(165, 25)
        Me.lblCompWins.TabIndex = 3
        Me.lblCompWins.Text = "Computer Wins:"
        '
        'lblPlayerWins
        '
        Me.lblPlayerWins.AutoSize = True
        Me.lblPlayerWins.Location = New System.Drawing.Point(174, 556)
        Me.lblPlayerWins.Name = "lblPlayerWins"
        Me.lblPlayerWins.Size = New System.Drawing.Size(133, 25)
        Me.lblPlayerWins.TabIndex = 4
        Me.lblPlayerWins.Text = "Player Wins:"
        '
        'lblDraws
        '
        Me.lblDraws.AutoSize = True
        Me.lblDraws.Location = New System.Drawing.Point(174, 629)
        Me.lblDraws.Name = "lblDraws"
        Me.lblDraws.Size = New System.Drawing.Size(78, 25)
        Me.lblDraws.TabIndex = 5
        Me.lblDraws.Text = "Draws:"
        '
        'lblCompWinsnum
        '
        Me.lblCompWinsnum.AutoSize = True
        Me.lblCompWinsnum.Location = New System.Drawing.Point(376, 486)
        Me.lblCompWinsnum.Name = "lblCompWinsnum"
        Me.lblCompWinsnum.Size = New System.Drawing.Size(0, 25)
        Me.lblCompWinsnum.TabIndex = 6
        '
        'lblPlayerWinsnum
        '
        Me.lblPlayerWinsnum.AutoSize = True
        Me.lblPlayerWinsnum.Location = New System.Drawing.Point(376, 556)
        Me.lblPlayerWinsnum.Name = "lblPlayerWinsnum"
        Me.lblPlayerWinsnum.Size = New System.Drawing.Size(0, 25)
        Me.lblPlayerWinsnum.TabIndex = 7
        '
        'lblDrawsnum
        '
        Me.lblDrawsnum.AutoSize = True
        Me.lblDrawsnum.Location = New System.Drawing.Point(376, 629)
        Me.lblDrawsnum.Name = "lblDrawsnum"
        Me.lblDrawsnum.Size = New System.Drawing.Size(0, 25)
        Me.lblDrawsnum.TabIndex = 8
        Me.lblDrawsnum.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 729)
        Me.Controls.Add(Me.lblDrawsnum)
        Me.Controls.Add(Me.lblPlayerWinsnum)
        Me.Controls.Add(Me.lblCompWinsnum)
        Me.Controls.Add(Me.lblDraws)
        Me.Controls.Add(Me.lblPlayerWins)
        Me.Controls.Add(Me.lblCompWins)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.grpThrows)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.grpThrows.ResumeLayout(False)
        Me.grpThrows.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpThrows As GroupBox
    Friend WithEvents radScissors As RadioButton
    Friend WithEvents radPaper As RadioButton
    Friend WithEvents radRock As RadioButton
    Friend WithEvents lblWinner As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents lblCompWins As Label
    Friend WithEvents lblPlayerWins As Label
    Friend WithEvents lblDraws As Label
    Friend WithEvents lblCompWinsnum As Label
    Friend WithEvents lblPlayerWinsnum As Label
    Friend WithEvents lblDrawsnum As Label
End Class
