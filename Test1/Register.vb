Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserName = txt_Username.Text
        Height = txt_Height.Text
        Age = txt_Age.text
        Gender = cbo_Gender.Text
        CurrentWeight = txt_CurrentWeight.Text
        GoalWeight = txt_GoalWeight.Text
        ActivityLevel = cbo_ActivityLevel.Text
        GoalRate = cbo_GoalRate.Text
        Dim fullline As String = ""
        fullline = (UserName & "," & Height & "," & Age & "," & Gender & "," & CurrentWeight & "," & GoalWeight & "," & ActivityLevel & "," & GoalWeight)
        FileOpen(1, "N:\Visual Studio 2017\project\logins.csv", OpenMode.Append)
        PrintLine(1, fullline)
        FileClose(1)
        MsgBox("Account Added", MsgBoxStyle.OkOnly, "Success")
        BackMain.Show()
        Hide()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is a comment
    End Sub

End Class