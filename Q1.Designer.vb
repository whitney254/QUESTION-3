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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Number1TextBox = New System.Windows.Forms.TextBox()
        Me.Number2TextBox = New System.Windows.Forms.TextBox()
        Me.ResultsTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DivideButton = New System.Windows.Forms.Button()
        Me.SubtractButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.MultiplyButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Results"
        '
        'Number1TextBox
        '
        Me.Number1TextBox.Location = New System.Drawing.Point(196, 12)
        Me.Number1TextBox.Name = "Number1TextBox"
        Me.Number1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number1TextBox.TabIndex = 3
        '
        'Number2TextBox
        '
        Me.Number2TextBox.Location = New System.Drawing.Point(196, 85)
        Me.Number2TextBox.Name = "Number2TextBox"
        Me.Number2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number2TextBox.TabIndex = 4
        '
        'ResultsTextBox
        '
        Me.ResultsTextBox.Location = New System.Drawing.Point(196, 170)
        Me.ResultsTextBox.Name = "ResultsTextBox"
        Me.ResultsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResultsTextBox.TabIndex = 5
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Aqua
        Me.AddButton.Location = New System.Drawing.Point(49, 267)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'DivideButton
        '
        Me.DivideButton.BackColor = System.Drawing.Color.Aqua
        Me.DivideButton.Location = New System.Drawing.Point(49, 319)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(84, 23)
        Me.DivideButton.TabIndex = 7
        Me.DivideButton.Text = "Divide"
        Me.DivideButton.UseVisualStyleBackColor = False
        '
        'SubtractButton
        '
        Me.SubtractButton.BackColor = System.Drawing.Color.Aqua
        Me.SubtractButton.Location = New System.Drawing.Point(211, 267)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(98, 23)
        Me.SubtractButton.TabIndex = 8
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Aqua
        Me.ClearButton.Location = New System.Drawing.Point(221, 319)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'MultiplyButton
        '
        Me.MultiplyButton.BackColor = System.Drawing.Color.Aqua
        Me.MultiplyButton.Location = New System.Drawing.Point(366, 267)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(97, 23)
        Me.MultiplyButton.TabIndex = 10
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Aqua
        Me.ExitButton.Location = New System.Drawing.Point(366, 319)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MultiplyButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubtractButton)
        Me.Controls.Add(Me.DivideButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ResultsTextBox)
        Me.Controls.Add(Me.Number2TextBox)
        Me.Controls.Add(Me.Number1TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "COMPUTER APPLICATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Number1TextBox As TextBox
    Friend WithEvents Number2TextBox As TextBox
    Friend WithEvents ResultsTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents DivideButton As Button
    Friend WithEvents SubtractButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents MultiplyButton As Button
    Friend WithEvents ExitButton As Button
End Class
