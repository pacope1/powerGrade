Public Class PGForm1

    Dim pgForm As New PGForm2
    Private Sub PGForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        playAudio1()
    End Sub

    Private Sub launchButton_Click(sender As Object, e As EventArgs) Handles launchButton.Click
        Me.Hide()
        pgForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class
