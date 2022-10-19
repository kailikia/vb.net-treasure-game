Public Class Form3
    Dim f2 As Form


    Private Sub closeInstructions_Click(sender As Object, e As EventArgs) Handles closeInstructions.Click
        f2 = New Form1()
        f2.Show()
        Me.Hide()
    End Sub

End Class