<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.level_combo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Difficulty"
        '
        'txtPlayer
        '
        Me.txtPlayer.Location = New System.Drawing.Point(378, 125)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(100, 23)
        Me.txtPlayer.TabIndex = 2
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(349, 212)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(103, 26)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "Start Playing"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'level_combo
        '
        Me.level_combo.FormattingEnabled = True
        Me.level_combo.Location = New System.Drawing.Point(378, 170)
        Me.level_combo.Name = "level_combo"
        Me.level_combo.Size = New System.Drawing.Size(121, 23)
        Me.level_combo.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "View Game Instructions"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Treasure Hunt Game"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.level_combo)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPlayer As TextBox
    Friend WithEvents txtDifficulty As TextBox
    Friend WithEvents StartButton As Button
    Friend WithEvents level_combo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
