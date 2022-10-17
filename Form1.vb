Public Class Form1
    Public player_name As String
    Dim game_level As String
    Dim f2 As Form

    Private Sub StartButtonClick(sender As Object, e As EventArgs) Handles StartButton.Click

        'Get form inputs
        player_name = txtPlayer.Text
        game_level = txtDifficulty.Text

        'Ensure inputs are not null
        If player_name = "" Or game_level = "" Then
            MessageBox.Show("Enter both name and choose level")

        Else
            'Load the form to choose treasure 
            f2 = New Form2(player_name, game_level)
            f2.Show()
            Me.Hide()

        End If

    End Sub
End Class
