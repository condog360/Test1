Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserName = txt_Username.Text 'Allocates the user's input into the UserName variable'
        Height = txt_Height.Text 'Allocates the user's input into the Height variable'
        Age = dtp_1.Value 'Allocates the user's input into the Age variable'
        Gender = cbo_Gender.Text 'Allocates the user's input into the Gender variable'
        CurrentWeight = txt_CurrentWeight.Text 'Allocates the user's input into the CurrentWeight variable'
        GoalWeight = txt_GoalWeight.Text 'Allocates the user's input into the GoalWeight variable'
        ActivityLevel = cbo_ActivityLevel.Text 'Allocates the user's input into the ActivityLevel variable'
        GoalRate = cbo_GoalRate.Text 'Allocates the user's input into the GoalRate variable'
        Dim fullline As String = "" 'Set the fullline as a string'
        fullline = (UserName & "," & Height & "," & Age & "," & Gender & "," & CurrentWeight & "," & GoalWeight & "," & ActivityLevel & "," & GoalWeight) 'Store these variables'
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

End Class