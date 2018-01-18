Public Class AddFoodBreakfast
    Private Sub AddFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FoodName = txt_FoodName.Text
        MainMenuScreen.ListBox1.Items.Add(txt_FoodName.Text)

        Calories = txt_Calories.Text
        CurrentCaloriesTotal = CurrentCaloriesTotal + Calories
        MainMenuScreen.lbl_FoodCalories.Text = CurrentCaloriesTotal
        MainMenuScreen.lbl_CaloriesSoFar.Text = CurrentCaloriesTotal

        Protein = txt_Protein.Text
        CurrentProteinTotal = CurrentProteinTotal + Protein
        MainMenuScreen.lbl_ProteinSoFar.Text = CurrentProteinTotal

        Carbohydrates = txt_Carbohydrates.Text
        CurrentCarbohydratesTotal = CurrentCarbohydratesTotal + Carbohydrates
        MainMenuScreen.lbl_CarbohydratesSoFar.Text = CurrentCarbohydratesTotal

        Sugars = Txt_Sugars.Text
        CurrentSugarTotal = CurrentSugarTotal + Sugars
        MainMenuScreen.lbl_SugarSoFar.Text = CurrentSugarTotal

        Fats = txt_Fat.Text
        CurrentFatTotal = CurrentFatTotal + Fats
        MainMenuScreen.lbl_FatSoFar.Text = CurrentFatTotal

        SatFats = txt_SatFats.Text
        CurrentSaturatedFatTotal = CurrentSaturatedFatTotal + SatFats
        MainMenuScreen.lbl_SaturatedFatSoFar.Text = CurrentSaturatedFatTotal

        Fibre = txt_Fibre.Text
        CurrentFibreTotal = CurrentFibreTotal + Fibre
        MainMenuScreen.lbl_FibreSoFar.Text = CurrentFibreTotal

        Salt = txt_Salt.Text
        CurrentSaltTotal = CurrentSaltTotal + Salt
        MainMenuScreen.lbl_SaltSoFar.Text = CurrentSaltTotal


        Dim fullline As String = ""
        fullline = (FoodName & "," & Calories & "," & Protein & "," & Carbohydrates & "," & Sugars & "," & Fats & "," & SatFats & "," & Fibre & "," & Salt)
        FileOpen(1, "N:\Visual Studio 2017\project\FoodTable.CSV", OpenMode.Append)
        PrintLine(1, fullline)
        FileClose(1)
        MsgBox("Food Added", MsgBoxStyle.OkOnly, "Success")
        MainMenuScreen.lbl_CaloriesRemaining.Text = MainMenuScreen.lbl_Goal.Text - (MainMenuScreen.lbl_FoodCalories.Text - MainMenuScreen.lbl_ExerciseCalories.Text)
        Close()
        MainMenuScreen.Refresh()
    End Sub

    Private Sub txt_FoodName_TextChanged(sender As Object, e As EventArgs) Handles txt_FoodName.TextChanged

    End Sub
End Class