Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Once button is clicked'
        UserName = txt_Username.Text 'Allocates the user's input into the UserName variable'
        Height = txt_Height.Text 'Allocates the user's input into the Height variable'
        Dim Year As Integer = DateDiff(DateInterval.Year, dtp_1.Value, Now) 'Retrieves Value of Year'
        Dim month As Integer = DateDiff(DateInterval.Month, dtp_1.Value, Now) Mod 12 'Retrieves value of month'
        Dim day As Integer = DateDiff(DateInterval.Day, dtp_1.Value, Now) Mod 30 - 10 'Retrieves value of day'
        age = Year - 1  'Allocates the user's input into the Age variable'
        Gender = cbo_Gender.Text 'Allocates the user's input into the Gender variable'
        CurrentWeight = txt_CurrentWeight.Text 'Allocates the user's input into the CurrentWeight variable'
        GoalWeight = txt_GoalWeight.Text 'Allocates the user's input into the GoalWeight variable'
        ActivityLevel = cbo_ActivityLevel.Text 'Allocates the user's input into the ActivityLevel variable'
        If ActivityLevel = "Sedentary" Then
            ActivityLevel = 1.25 'Multiplier for if the user selects their activity level as 'sedentary''
        ElseIf ActivityLevel = "Lightly Active" Then
            ActivityLevel = 1.375 'Multiplier for if the user selects their activity level as 'Lightly Active''
        ElseIf ActivityLevel = "Moderately Active" Then
            ActivityLevel = 1.55 'Multiplier for if the user selects their activity level as 'Moderately Active ''
        ElseIf ActivityLevel = "Active" Then
            ActivityLevel = 1.725 'Multiplier for if the user selects their activity level as 'Active''
        ElseIf ActivityLevel = "Very Active" Then
            ActivityLevel = 1.9 'Multiplier for if the user selects their activity level as 'Very Active''
        End If 'End the IF statement'
        GoalRate = cbo_GoalRate.Text 'Allocates the user's input into the GoalRate variable'
        If GoalRate = "Lose 2 Pounds Per Week" Then
            GoalRate = -1000 'This number is the calorie deficit required to lose the weight declared above'
        ElseIf GoalRate = "Lose 1 Pound Per Week" Then
            GoalRate = -500 'This number is the calorie deficit required to lose the weight declared above'
        ElseIf GoalRate = "Lose 0.5 Pounds Per Week" Then
            GoalRate = -250 'This number is the calorie deficit required to lose this weight'
        ElseIf GoalRate = "Maintain Weight" Then
            GoalRate = 1 'This number stays as one because the user neither requires a defecit or surplus in calories to achieve their goal'
        ElseIf GoalRate = "Gain 0.5 Pounds Per Week" Then
            GoalRate = +250 'This is the number of extra calories the user must consume to gain the weight declared above'
        ElseIf GoalRate = "Gain  1 Pound Per Week" Then
            GoalRate = +500 'This is the number of extra calories the user must consume to gain the weight declared above'
        End If
        BMR = 88.362 + (13.397 * CurrentWeight) + (4.799 * Height) - (5.667 * age) 'This calculation is the formaula to figure out the persons basic metabolic rate'
        BMRPLUSEXERCISE = (BMR * ActivityLevel) 'This line multiplies the my stakeholder's goal by the activity level which was most applicable to them'
        STAKEHOLDERSAIM = BMRPLUSEXERCISE + GoalRate 'This line takes into consideration the user's goal rate (How quickly they would like to achieve their goal'
        MainMenuScreen.lbl_Goal.Text = STAKEHOLDERSAIM 'Take the above variable and set the label 'lbl_goal' as this number'
        Dim fullline As String = "" 'Set the fullline as a string'
        fullline = (UserName & "," & Height & "," & age & "," & Gender & "," & CurrentWeight & "," & GoalWeight & "," & ActivityLevel & "," & GoalRate & "," & STAKEHOLDERSAIM) 'Store these variables'
        FileOpen(1, "N:\Visual Studio 2017\project\logins.csv", OpenMode.Append) 'Open The file'
        PrintLine(1, fullline) 'Print the contents into the File on a line'
        FileClose(1) 'Close the file'
        MsgBox("Account Added", MsgBoxStyle.OkOnly, "Success") 'let the user know they have had their account added successfully'
        MainMenuScreen.Show() 'Show the main menu'
        Hide() 'Hide this window'
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class