Module Globals
    Public x As Integer
    Public y As Integer
    Public numStudents As Integer
    Public numData As Integer
    Public counter As Integer
    Public studentNames(x) As String
    Public studentData(y) As Integer
    Public nameStudent As String
    Public aRange() As String = {"B", "C", "D", "E", "F", "G", "H", "I", "J", "K"}
    Function playAudio1()
        My.Computer.Audio.Play(My.Resources.LaunchSound, AudioPlayMode.Background)
        Return Nothing
    End Function

    Function playAudio2()
        My.Computer.Audio.Play(My.Resources.CorrectSound, AudioPlayMode.Background)
        Return Nothing
    End Function

    Function playAudio3()
        My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.Background)
        Return Nothing
    End Function
End Module
