Public Class GradeSwitch

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim grade As Integer = Convert.ToInt32(TextBoxScore.Text)
        Select Case grade
            Case 70 To 100
                TextBoxGrade.Text = "A"
            Case 60 To 69
                TextBoxGrade.Text = "B"
            Case 50 To 59
                TextBoxGrade.Text = "C"
            Case 45 To 49
                TextBoxGrade.Text = "D"
            Case 40 To 44
                TextBoxGrade.Text = "E"
            Case 0 To 39
                TextBoxGrade.Text = "F"
            Case Else
                TextBoxGrade.Text = "Unknown Grade"
        End Select
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub
End Class
