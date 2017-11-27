Public Class AddFood
    Private Sub AddFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FoodName = txt_FoodName.Text
        BackMain.ListBox1.Items.Add(txt_FoodName.Text)
        Calories = txt_Calories.Text
        CurrentCaloriesTotal = CurrentCaloriesTotal + Calories
        BackMain.lbl_FoodCalories.Text = CurrentCaloriesTotal
        Protein = txt_Protein.Text
        Carbohydrates = txt_Carbohydrates.Text
        Sugars = Txt_Sugars.Text
        Fats = txt_Fat.Text
        SatFats = txt_SatFats.Text
        Fibre = txt_Fibre.Text
        Salt = txt_Salt.Text
        Dim fullline As String = ""
        fullline = (FoodName & "," & Calories & "," & Protein & "," & Carbohydrates & "," & Sugars & "," & Fats & "," & SatFats & "," & Fibre & "," & Salt)
        FileOpen(1, "N:\Visual Studio 2017\project\FoodTable.CSV", OpenMode.Append)
        PrintLine(1, fullline)
        FileClose(1)
        MsgBox("Food Added", MsgBoxStyle.OkOnly, "Success")
        Hide()
        BackMain.Refresh()
    End Sub



End Class