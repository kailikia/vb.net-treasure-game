Public Class Form2

    Dim g_limit As Integer
    Dim submitted_guess As String

    Public Sub New(ByVal player_name As String, ByVal game_level As String)

        ' This call is required by the designer.

        InitializeComponent()

        ' Add the player name plus difficulty to the labels

        playername.Text = player_name
        gamelevel.Text = game_level

        If gamelevel.Text = "easy" Then
            g_limit = 40
        ElseIf gamelevel.Text = "medium" Then
            g_limit = 35
        Else
            g_limit = 30
        End If

        guesses.Text = g_limit

    End Sub

    Private Sub Submit_Guess_Click(sender As Object, e As EventArgs) Handles Submit_Guess.Click
        submitted_guess = user_guess.Text

        If submitted_guess = "" Then
            MessageBox.Show("Enter a value")
        Else
            Dim result As String
            result = submitted_guess.Substring(0, 1) + submitted_guess.Substring(1, 2)
            If result.Length() <= 99 Then
                MessageBox.Show("Row is: " + submitted_guess.Substring(0, 1) + " and Column is: " + submitted_guess.Substring(1, 2))
            End If
        End If

    End Sub

End Class