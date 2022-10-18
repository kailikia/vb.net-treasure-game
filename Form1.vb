Public Class Form1
    Public player_name As String
    Dim game_level As String
    Dim f2 As Form

    Private Sub ComboBox_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        level_combo.Items.Add("easy")
        level_combo.Items.Add("medium")
        level_combo.Items.Add("hard")

    End Sub


    Private Sub StartButtonClick(sender As Object, e As EventArgs) Handles StartButton.Click

        'Get form inputs
        player_name = txtPlayer.Text
        game_level = level_combo.Text

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
