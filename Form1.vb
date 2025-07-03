'Project: ComputeApplication
' Author: Your Name
' Date: Today's Date

Option Explicit On
Option Strict On

Public Class Form1

    ' Declare variables
    Private NumberOneInteger As Integer
    Private NumberTwoInteger As Integer

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim SumInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text, System.Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text, System.Globalization.NumberStyles.Number)
        SumInteger = NumberOneInteger + NumberTwoInteger
        ResultsTextBox.Text = SumInteger.ToString("N0")
    End Sub

    Private Sub SubtractButton_Click(sender As Object, e As EventArgs) Handles SubtractButton.Click
        Dim SubtractInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text, System.Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text, System.Globalization.NumberStyles.Number)
        SubtractInteger = NumberOneInteger - NumberTwoInteger
        ResultsTextBox.Text = SubtractInteger.ToString("N0")
    End Sub

    Private Sub MultiplyButton_Click(sender As Object, e As EventArgs) Handles MultiplyButton.Click
        Dim MultiplyInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text, System.Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text, System.Globalization.NumberStyles.Number)
        MultiplyInteger = NumberOneInteger * NumberTwoInteger
        ResultsTextBox.Text = MultiplyInteger.ToString("N0")
    End Sub

    Private Sub DivisionButton_Click(sender As Object, e As EventArgs) Handles DivideButton.Click
        Dim DivisionResult As Double

        NumberOneInteger = Integer.Parse(Number1TextBox.Text, System.Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text, System.Globalization.NumberStyles.Number)

        If NumberTwoInteger = 0 Then
            MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResultsTextBox.Clear()
        Else
            DivisionResult = NumberOneInteger / NumberTwoInteger
            ResultsTextBox.Text = DivisionResult.ToString("N2")
        End If
    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Number1TextBox.Clear()
        Number2TextBox.Clear()
        ResultsTextBox.Clear()
        Number1TextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


