Public Class PGForm3
    Dim pgForm As New PGForm4
    Dim numText As Integer = 1
    Dim data As Integer
    Private Sub PGForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub NamesButton_Click(sender As Object, e As EventArgs) Handles namesButton.Click
        For counter = 0 To studentNames.Length - 1
            studentNames(counter) = InputBox("Input the name of Student #" + (numText.ToString + "."))

            If studentNames(counter).ToString.Trim = Nothing Then
                MessageBox.Show("Please enter a name or numerical representation for each of your students.")
                numText = 1
                Exit Sub
            Else
                selectStudent1.Items.Add(studentNames(counter).ToUpper())
                numText += 1
            End If
        Next
        numText = 1
    End Sub

    Private Sub DataButton_Click(sender As Object, e As EventArgs) Handles dataButton.Click
        Dim scoreInput As String
        Dim index As Integer = 0

        If selectStudent1.SelectedItem = Nothing Then
            MessageBox.Show("Please make a student selection to enter data.")
            numText = 1
            counter = 0
            Exit Sub
        Else
            nameStudent = selectStudent1.SelectedItem.ToString.Trim
        End If

        For counter = 0 To studentData.Length - 1
            scoreInput = (InputBox("Input Data Point #" + (numText.ToString) + " for " + (nameStudent) + "."))
            If Not Integer.TryParse(scoreInput, data) Then
                playAudio3()
                MessageBox.Show("Please input a valid number for each data point.")
                numText = 1
                counter = 0
                Exit Sub
            ElseIf Integer.TryParse(scoreInput, data) > 0 Then
                playAudio3()
                MessageBox.Show("Please input a valid number for each data point.")
                numText = 1
                counter = 0
                Exit Sub
            Else
                studentData(index) = data
                index += 1
            End If
            numText += 1
        Next
        playAudio2()
        counter = 0
        MessageBox.Show("Great! Data has saved correctly.")
    End Sub

    Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
        pgForm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Application.Exit()
    End Sub
End Class