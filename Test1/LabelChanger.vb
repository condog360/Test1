Public Class LabelChanger

    Enum MealBoxes
        breakfast
        lunch
        dinner
        snacks
    End Enum

    Property CurrentButton As New MealBoxes
    Private TextMap As Dictionary(Of MealBoxes, ListBox)

    Sub New(ByRef currentForm As MainMenuScreen)
        TextMap.Add(MealBoxes.breakfast, currentForm.ListBox1)
        TextMap.Add(MealBoxes.lunch, currentForm.ListBox2)
        TextMap.Add(MealBoxes.dinner, currentForm.ListBox3)
        TextMap.Add(MealBoxes.snacks, currentForm.ListBox4)


        'TextMap.Add(MealBoxes.breakfast, GetObject(, "MainMenuScreen.ListBox1"))
        'TextMap.Add(MealBoxes.lunch, GetObject(, "MainMenuScreen.ListBox2"))
        'TextMap.Add(MealBoxes.dinner, GetObject(, "MainMenuScreen.ListBox3"))
        'TextMap.Add(MealBoxes.snacks, GetObject(, "MainMenuScreen.ListBox4"))

    End Sub

    Sub AddToBox(ByRef stringToAdd As String)
        TextMap.Item(CurrentButton).Items.Add(stringToAdd)
    End Sub




End Class
