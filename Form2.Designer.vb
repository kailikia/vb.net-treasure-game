<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.playername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gamelevel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.guesses = New System.Windows.Forms.Label()
        Me.user_guess = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Submit_Guess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'playername
        '
        Me.playername.AutoSize = True
        Me.playername.Location = New System.Drawing.Point(288, 31)
        Me.playername.Name = "playername"
        Me.playername.Size = New System.Drawing.Size(39, 15)
        Me.playername.TabIndex = 0
        Me.playername.Text = "Player"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(400, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Level:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player:"
        '
        'gamelevel
        '
        Me.gamelevel.AutoSize = True
        Me.gamelevel.Location = New System.Drawing.Point(454, 31)
        Me.gamelevel.Name = "gamelevel"
        Me.gamelevel.Size = New System.Drawing.Size(41, 15)
        Me.gamelevel.TabIndex = 3
        Me.gamelevel.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of Guesses:"
        '
        'guesses
        '
        Me.guesses.AutoSize = True
        Me.guesses.Location = New System.Drawing.Point(411, 69)
        Me.guesses.Name = "guesses"
        Me.guesses.Size = New System.Drawing.Size(41, 15)
        Me.guesses.TabIndex = 5
        Me.guesses.Text = "Label4"
        '
        'user_guess
        '
        Me.user_guess.Location = New System.Drawing.Point(352, 145)
        Me.user_guess.Name = "user_guess"
        Me.user_guess.Size = New System.Drawing.Size(100, 23)
        Me.user_guess.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter Guess "
        '
        'Submit_Guess
        '
        Me.Submit_Guess.Location = New System.Drawing.Point(325, 202)
        Me.Submit_Guess.Name = "Submit_Guess"
        Me.Submit_Guess.Size = New System.Drawing.Size(112, 21)
        Me.Submit_Guess.TabIndex = 8
        Me.Submit_Guess.Text = "Submit Guess"
        Me.Submit_Guess.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Submit_Guess)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.user_guess)
        Me.Controls.Add(Me.guesses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gamelevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playername)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents playername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gamelevel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents guesses As Label
    Friend WithEvents user_guess As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Submit_Guess As Button
End Class
