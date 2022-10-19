<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.closeInstructions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1. Enter your name and select difficulty level."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2. Enter a guess by typing any number between 0 and 79."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3. Each difficulty has a limit to number of guesses."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(307, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "4. Whenyou get the right treasure, the cell turns to green."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "5. Every treasure you miss, the cell turns to red."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(296, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Game Instructions"
        '
        'closeInstructions
        '
        Me.closeInstructions.Location = New System.Drawing.Point(342, 301)
        Me.closeInstructions.Name = "closeInstructions"
        Me.closeInstructions.Size = New System.Drawing.Size(75, 23)
        Me.closeInstructions.TabIndex = 6
        Me.closeInstructions.Text = "Close"
        Me.closeInstructions.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.closeInstructions)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents closeInstructions As Button
End Class
