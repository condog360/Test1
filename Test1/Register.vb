Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserName = txt_Username.Text 'Allocates the user's input into the UserName variable'
        Height = txt_Height.Text 'Allocates the user's input into the Height variable'
        Dim Year As Integer = DateDiff(DateInterval.Year, dtp_1.Value, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, dtp_1.Value, Now) Mod 12
        Dim day As Integer = DateDiff(DateInterval.Day, dtp_1.Value, Now) Mod 30 - 10
        age = Year & month  'Allocates the user's input into the Age variable'
        Gender = cbo_Gender.Text 'Allocates the user's input into the Gender variable'
        CurrentWeight = txt_CurrentWeight.Text 'Allocates the user's input into the CurrentWeight variable'
        GoalWeight = txt_GoalWeight.Text 'Allocates the user's input into the GoalWeight variable'
        ActivityLevel = cbo_ActivityLevel.Text 'Allocates the user's input into the ActivityLevel variable'
        If ActivityLevel = "Sedentary" Then
            ActivityLevel = 1
        ElseIf ActivityLevel = "Lightly Active" Then
            ActivityLevel = 2
        ElseIf ActivityLevel = "Moderately Active" Then
            ActivityLevel = 3
        ElseIf ActivityLevel = "Active" Then
            ActivityLevel = 4
        Else Activitylevel = 5
        End If
            GoalRate = cbo_GoalRate.Text 'Allocates the user's input into the GoalRate variable'
        BMR = 88.362 + (13.397 * CurrentWeight) + (4.799 * Height) - (5.667 * Age)
        BMRPLUSEXERCISE = (BMR * ActivityLevel)
        Dim fullline As String = "" 'Set the fullline as a string'
        fullline = (UserName & "," & Height & "," & age & "," & Gender & "," & CurrentWeight & "," & GoalWeight & "," & ActivityLevel & "," & GoalRate) 'Store these variables'
        FileOpen(1, "N:\Visual Studio 2017\project\logins.csv", OpenMode.Append) 'Open The file'
        PrintLine(1, fullline) 'Print the contents into the File on a line'
        FileClose(1) 'Cloe the file'
        MsgBox("Account Added", MsgBoxStyle.OkOnly, "Success") 'let the user know they have had their account added successfully'
        MainMenuScreen.Show() 'Show the main menu'
        Hide() 'Hide this window'
    End Sub


    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is a comment
    End Sub

    Private Sub dtp_1_ValueChanged(sender As Object, e As EventArgs) Handles dtp_1.ValueChanged

    End Sub
End Class