Public Class frmAverageUnitsShippped

    Const minimumValue As Integer = 0 'Variable declarations
    Const maximumValue As Integer = 1000
    Const daysInAWeek As Integer = 7
    Private unitsEachDay(6) As Integer
    Dim counter As Integer = 1



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        tbUserInput.Text = ""   'When The reset button is clicked, all text and calculations are cleared
        tbEntryDisplay.Text = ""
        lbAverageOutput.Text = ""
        tbUserInput.ReadOnly = False
        btnEnter.Enabled = True
        counter = 1


    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If (Integer.TryParse(tbUserInput.Text, unitsEachDay(counter - 1)) = False) Then 'makes sure that text that is entered is not a string

            MessageBox.Show("This value must be a whole number.") 'Shows and error message, Clears the textbox and focusus it
            tbUserInput.Text = ""
            tbUserInput.Focus()

        ElseIf (minimumValue > unitsEachDay(counter - 1) Or maximumValue < unitsEachDay(counter - 1)) Then 'makes sure that the input is within the specified range

            MessageBox.Show("This value must be between 0 and 1000.") 'Shows an error message, clears the textbox and focuses it
            tbUserInput.Text = ""
            tbUserInput.Focus()

        Else

            tbDayNumber.Text = counter.ToString()

            counter += 1

            tbEntryDisplay.Text += unitsEachDay(counter - 1).ToString() & vbCrLf

            tbUserInput.Text = ""


            If (counter = 7) Then

                tbUserInput.ReadOnly = True
                btnEnter.Enabled = False


                For Count As Integer = 1 To daysInAWeek

                    lbAverageOutput.Text = unitsEachDay.Average

                Next

            End If

        End If



    End Sub

End Class
