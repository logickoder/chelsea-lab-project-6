Public Class QuadraticEquationSwitch

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim a As Double = CheckValidData(LabelA.Text, TextBoxA.Text)
        Dim b As Double = CheckValidData(LabelB.Text, TextBoxB.Text)
        Dim c As Double = CheckValidData(LabelC.Text, TextBoxC.Text)

        Dim d As Double = Math.Pow(b, 2) - (4 * a * c)
        Select Case d
            Case 0
                Dim x As Double = -b / (2 * a)
                MessageBox.Show("The value of x is " + x.ToString())
            Case Is > 0
                Dim x1 As Double = (-b + Math.Sqrt(d)) / (2 * a)
                Dim x2 As Double = (-b - Math.Sqrt(d)) / (2 * a)
                MessageBox.Show("X1: " + x1.ToString() + Environment.NewLine + "X2: " + x2.ToString())
            Case Else
                Dim real As Double = -b / (2 * a)
                Dim imaginary As Double = Math.Sqrt(-d) / (2 * a)
                MessageBox.Show("The value of x is " + real.ToString() + " + " + imaginary.ToString() + "i")
        End Select
    End Sub



    Private Function CheckValidData(title As String, value As String) As Double
        Try
            Return Convert.ToDouble(value)
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number for " + title, "Invalid entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub
End Class
