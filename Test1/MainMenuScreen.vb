Public Class MainMenuScreen

    Property currentLabelChanger As LabelChanger

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentLabelChanger.CurrentButton = LabelChanger.MealBoxes.breakfast
        AddFood.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentLabelChanger = New LabelChanger(Me)
        currentLabelChanger.CurrentButton = LabelChanger.MealBoxes.lunch
        AddFood.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddFood.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddFood.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddFood.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AddExercise.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentLabelChanger = New LabelChanger(Me)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_FinishLogging.Click
        Dim fullline As String = ""
        fullline = (CurrentCaloriesTotal)
        FileOpen(1, "N:\Visual Studio 2017\project\Calories", OpenMode.Append)
        PrintLine(1, fullline)
        FileClose(1)
        MsgBox("Your total amount of calories for today is: " & CurrentCaloriesTotal)
    End Sub
End Class

