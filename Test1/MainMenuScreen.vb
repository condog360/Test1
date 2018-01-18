Public Class MainMenuScreen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddFoodBreakfast.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddFoodDinner.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddfoodTea.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddFoodSnacks.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddFoodBreakfast.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AddExercise.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_FinishLogging.Click
        Dim fullline As String = ""
        fullline = (CurrentCaloriesTotal)
        FileOpen(1, "N:\Visual Studio 2017\project\Calories", OpenMode.Append)
        PrintLine(1, fullline)
        FileClose(1)
        MsgBox("Your total amount of calories for today is: " & CurrentCaloriesTotal)
        Close()
    End Sub
End Class

