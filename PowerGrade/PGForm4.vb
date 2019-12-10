Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class PGForm4
    Private Sub PGForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        Dim average As Double
        Dim dataStorage As String = "dataStorage.xlsx"
        Dim test As Integer = 1
        Dim index As Integer = 0
        Dim total As Integer = 0
        Dim highNum As Integer = studentData(0)
        Dim lowNum As Integer = studentData(0)

        If File.Exists(dataStorage) Then
            File.Delete(dataStorage)
        End If

        Dim eFile As Object
        eFile = CreateObject("Excel.Application")
        Dim eBook As Excel.Workbook
        Dim eSheet As Excel.Worksheet

        eBook = eFile.Workbooks.Add
        eSheet = eFile.Worksheets(1)

        eSheet.Name = "Student Scores"
        eSheet.Range("A2").Value = "Student Scores"
        Do While test <= numData
            eSheet.Range(aRange(index).ToString + "1").Value = "Test " + test.ToString
            eSheet.Range(aRange(index).ToString + "2").Value = studentData(index)
            test += 1
            index += 1
        Loop

        index = 0
        test = 1

        eBook.SaveAs(dataStorage)
        eBook.Close()
        eBook = Nothing
        eFile.Quit()
        eFile = Nothing


        Do While index <= (studentData.Length - 1)
            total += studentData(index)
            index += 1
        Loop

        average = total / numData

        index = 0

        Do While index <= (studentData.Length - 1)
            If studentData(index) > highNum Then
                highNum = studentData(index)
            End If
            index += 1
        Loop

        index = 0

        Do While index <= (studentData.Length - 1)
            If studentData(index) < lowNum Then
                lowNum = studentData(index)
            End If
            index += 1
        Loop

        index = 0

        Me.studentChart.Series.Clear()
        Me.studentChart.Series.Add("Test Performance")
        Me.studentChart.Series.Add("Average Score")
        Me.studentChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
        Me.studentChart.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Me.studentChart.Series(0).BorderWidth = 5
        Me.studentChart.Series(1).BorderWidth = 3
        Me.studentChart.Series(1).BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
        Me.studentChart.ChartAreas("ChartArea1").AxisX.Title = "Student Tests"
        Me.studentChart.ChartAreas("ChartArea1").AxisY.Title = "Student Scores"
        Me.studentChart.ChartAreas("ChartArea1").AxisX.Minimum = 1
        Me.studentChart.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font("Century Gothic", 8)
        Me.studentChart.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font("Century Gothic", 8)
        Do While test <= studentData.Length
            Me.studentChart.Series("Test Performance").Points.AddXY(Val(test), Val(studentData(index)))
            Me.studentChart.Series("Average Score").Points.AddXY(Val(test), Val(average))
            test += 1
            index += 1
        Loop
        Me.studentChart.ChartAreas("ChartArea1").AxisX.Maximum = test - 1

        averageLabel.Text = average
        nameLabel.Text = nameStudent
        highLabel.Text = highNum
        lowLabel.Text = lowNum
    End Sub


    Private Sub trendButton_Click(sender As Object, e As EventArgs) Handles trendButton.Click
        Dim index As Integer = 0
        Dim index1 As Integer = 1
        Dim test As Integer = 1


        Me.studentChart.Series.Add("Trend Line")
        Me.studentChart.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Me.studentChart.Series(2).BorderWidth = 3
        Me.studentChart.Series("Trend Line").Points.AddXY(Val(test), Val(studentData(index1)))
        test += 1
        Do While test <= studentData.Length - 1
            If index < studentData.Length Then
                Me.studentChart.Series("Trend Line").Points.AddXY(Val(test), Val((studentData(index) + (studentData(index1))) / 2))
            End If
            test += 1
            index += 1
            index1 += 1
        Loop
        Me.studentChart.Series("Trend Line").Points.AddXY(Val(test), Val((studentData(index) + (studentData(index1))) / 2))
    End Sub

    Private Sub predButton_Click(sender As Object, e As EventArgs) Handles predButton.Click
        Dim index As Integer = 0
        Dim total As Integer = 0
        Dim test As Integer = 1
        Dim passing As String = InputBox("What is a passing grade?")
        Dim pass As Double
        Dim grade As Integer
        Dim prob As Double
        Double.TryParse(s:=passing, result:=pass)

        If pass > 0 Then
            Do While index <= (studentData.Length - 1)
                grade = studentData(index)
                If grade >= pass Then
                    total += 1
                End If
                index += 1
                test += 1
            Loop
        Else
            MessageBox.Show("Please enter a valid number.")
            Exit Sub
        End If

        prob = (total / studentData.Length)
        passLabel.Text = prob.ToString("p")
    End Sub

    Private Sub returnButton_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        Me.Close()
        PGForm3.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class

