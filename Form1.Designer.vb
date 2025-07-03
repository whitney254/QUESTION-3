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
        Me.Number1Textbox = New System.Windows.Forms.TextBox()
        Me.Number2TextBox = New System.Windows.Forms.TextBox()
        Me.ResultsTextBox = New System.Windows.Forms.TextBox()
        Me.SubtractButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MultiplyButton = New System.Windows.Forms.Button()
        Me.DivideButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter first number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter second number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Results"
        '
        'Number1Textbox
        '
        Me.Number1Textbox.Location = New System.Drawing.Point(264, 43)
        Me.Number1Textbox.Name = "Number1Textbox"
        Me.Number1Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Number1Textbox.TabIndex = 3
        '
        'Number2TextBox
        '
        Me.Number2TextBox.Location = New System.Drawing.Point(264, 99)
        Me.Number2TextBox.Name = "Number2TextBox"
        Me.Number2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number2TextBox.TabIndex = 4
        '
        'ResultsTextBox
        '
        Me.ResultsTextBox.Location = New System.Drawing.Point(264, 154)
        Me.ResultsTextBox.Name = "ResultsTextBox"
        Me.ResultsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResultsTextBox.TabIndex = 5
        '
        'SubtractButton
        '
        Me.SubtractButton.BackColor = System.Drawing.Color.Aqua
        Me.SubtractButton.Location = New System.Drawing.Point(227, 283)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(75, 23)
        Me.SubtractButton.TabIndex = 6
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Aqua
        Me.ClearButton.Location = New System.Drawing.Point(227, 352)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Aqua
        Me.ExitButton.Location = New System.Drawing.Point(376, 352)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'MultiplyButton
        '
        Me.MultiplyButton.BackColor = System.Drawing.Color.Aqua
        Me.MultiplyButton.Location = New System.Drawing.Point(376, 283)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(72, 23)
        Me.MultiplyButton.TabIndex = 9
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = False
        '
        'DivideButton
        '
        Me.DivideButton.BackColor = System.Drawing.Color.Aqua
        Me.DivideButton.Location = New System.Drawing.Point(55, 352)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(75, 23)
        Me.DivideButton.TabIndex = 10
        Me.DivideButton.Text = "Divide"
        Me.DivideButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Aqua
        Me.AddButton.Location = New System.Drawing.Point(55, 283)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 11
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DivideButton)
        Me.Controls.Add(Me.MultiplyButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubtractButton)
        Me.Controls.Add(Me.ResultsTextBox)
        Me.Controls.Add(Me.Number2TextBox)
        Me.Controls.Add(Me.Number1Textbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Computer Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Number1Textbox As TextBox
    Friend WithEvents Number2TextBox As TextBox
    Friend WithEvents ResultsTextBox As TextBox
    Friend WithEvents SubtractButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MultiplyButton As Button
    Friend WithEvents DivideButton As Button
    Friend WithEvents AddButton As Button
End Class
