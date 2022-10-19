Imports System.IO
Imports System.Windows.Forms.LinkLabel

Public Class Form2

    Dim g_limit As Integer
    Dim submitted_guess As String
    Dim treasures As String
    Dim lines


    Public Sub New(ByVal player_name As String, ByVal game_level As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add the player name plus difficulty to the labels

        playername.Text = player_name
        gamelevel.Text = game_level

        ' Set level limit

        If gamelevel.Text = "easy" Then
            g_limit = 40
        ElseIf gamelevel.Text = "medium" Then
            g_limit = 35
        Else
            g_limit = 30
        End If

        guesses.Text = g_limit

        ' Read the files treasure.txt is in bin/debug/net.6.0

        lines = File.ReadAllLines("treasure.txt")

        Using reader As StreamReader = New StreamReader("treasure.txt", True)

        End Using

        ' Create a 3D array

    End Sub

    Private Sub Submit_Guess_Click(sender As Object, e As EventArgs) Handles Submit_Guess.Click
        submitted_guess = user_guess.Text

        Dim tfound = 0

        If submitted_guess = "" Then
            MessageBox.Show("Enter a value")
        Else
            If submitted_guess.Length() <= 2 And submitted_guess.Substring(0, 1) < 8 Then

                Dim char1 = submitted_guess.Substring(0, 1)
                Dim char2 = submitted_guess.Substring(1, 1)

                'Reduce guess limit
                g_limit = g_limit - 1

                'check if value is in treasures.txt
                For Each line In lines
                    If submitted_guess = line Then
                        tfound += 1
                    End If
                Next

                If tfound > 0 Then
                    'change the color in array to green
                    MessageBox.Show("Found change to green")

                Else
                    'change the color in array to red
                    MessageBox.Show("Not Found change to green")

                End If

            Else
                MessageBox.Show("Invalid Value")
            End If

        End If

    End Sub

End Class