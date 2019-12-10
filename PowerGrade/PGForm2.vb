Public Class PGForm2

    Dim pgForm As New PGForm3
    Private Sub PGForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Integer.TryParse(s:=studentBox.Text, result:=numStudents)
        Integer.TryParse(s:=dataBox.Text, result:=numData)

        If numStudents > 0 And numData > 0 Then
            If numData > 10 Then
                MessageBox.Show("Due to memory limitations, you may only have up to ten data points.")
                Exit Sub
            End If
        playAudio2()
            x = numStudents - 1
            y = numData - 1
            ReDim studentNames(x)
            ReDim studentData(y)
            MessageBox.Show("Great! Your students and number of data points saved correctly.")
            pgForm.ShowDialog()
        Me.Close()
        Else
        playAudio3()
        MessageBox.Show("Please input a valid number into each category.")
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        studentBox.Clear()
        dataBox.Clear()
        playAudio3()
        MessageBox.Show("Data Cleared")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class