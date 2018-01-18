Public Class AddExercise
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NameOfExercise = lst_NameOfExercise.Text
        DurationOfExercise = txt_DurationOfExercise.Text
        IntensityOfExercise = cbo_IntensityOfExercise.Text
        Dim fullline As String = ""
        fullline = (NameOfExercise & "," & DurationOfExercise & "," & IntensityOfExercise)
        FileOpen(1, "N:\Visual Studio 2017\project\ExerciseTable.CSV", OpenMode.Append)
        PrintLine(1, fullline)
        FileClose(1)
        MsgBox("Exercise Added", MsgBoxStyle.OkOnly, "Success")
    End Sub

    Private Sub lst_NameOfExercise_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_NameOfExercise.SelectedIndexChanged

    End Sub

    Private Sub AddExercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class