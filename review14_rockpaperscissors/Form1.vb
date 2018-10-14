Public Class Form1
    Const ROCK As Integer = 1
    Const PAPER As Integer = 2
    Const SCISSORS As Integer = 3
    Dim computerThrow As Integer
    Dim intDraw As Integer
    Dim intWins As Integer
    Dim intWinsme As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Randomize()
        computerThrow = Int(3 * Rnd() + 1)

        If Me.radRock.Checked Then
            Select Case computerThrow
                Case Is = ROCK
                    Me.lblWinner.Text = "Computer throws Rock. It's a Draw!"
                    intDraw = intDraw + 1
                    Me.lblDrawsnum.Text = intDraw
                Case Is = PAPER
                    Me.lblWinner.Text = "Computer throws Paper. Computer Wins!"
                    intWins = intWins + 1
                    Me.lblCompWinsnum.Text = intWins
                Case Is = SCISSORS
                    Me.lblWinner.Text = "Computer throws Scissors. You win!"
                    intWinsme = intWinsme + 1
                    Me.lblPlayerWinsnum.Text = intWinsme
            End Select
        End If

        If Me.radPaper.Checked Then
            Select Case computerThrow
                Case Is = ROCK
                    Me.lblWinner.Text = "Computer throws Rock. You win!"
                    intWinsme = intWinsme + 1
                    Me.lblPlayerWinsnum.Text = intWinsme
                Case Is = PAPER
                    Me.lblWinner.Text = "Computer throws Paper. It's a draw!"
                    intDraw = intDraw + 1
                    Me.lblDrawsnum.Text = intDraw
                Case Is = SCISSORS
                    Me.lblWinner.Text = "Computer throws Scissors. Computer win!"
                    intWins = intWins + 1
                    Me.lblCompWinsnum.Text = intWins
            End Select
        End If

        If Me.radScissors.Checked Then
            Select Case computerThrow
                Case Is = ROCK
                    Me.lblWinner.Text = "Computer throws Rock. Computer win!"
                    intWins = intWins + 1
                    Me.lblCompWinsnum.Text = intWins
                Case Is = PAPER
                    Me.lblWinner.Text = "Computer throws Paper. You win!"
                    intWinsme = intWinsme + 1
                    Me.lblPlayerWinsnum.Text = intWinsme
                Case Is = SCISSORS
                    Me.lblWinner.Text = "Computer throws Scissors. It's a draw!"
                    intDraw = intDraw + 1
                    Me.lblDrawsnum.Text = intDraw
            End Select
        End If
    End Sub
End Class
