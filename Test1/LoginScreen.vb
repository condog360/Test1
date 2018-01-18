Public Class frm_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(1, "N:\Visual Studio 2017\project\logins.csv", OpenMode.Input)
        loginnameattempt = txt_LoginAttempt.Text
        loginHeightattempt = txt_HeightAttempt.Text
        logindatafile = ""
        accountfound = False
        Do Until EOF(1) Or accountfound = True
            Dim fullline As String = LineInput(1)
            Dim Item() As String = Split(fullline, ",")
            STAKEHOLDERSAIM = Item(8)
            correctloginname = Item(0)
            correctloginHeight = Item(1)
            If loginnameattempt = correctloginname And loginHeightattempt = correctloginHeight Then
                accountfound = True
                MainMenuScreen.Show()
                MainMenuScreen.lbl_Goal.Text = STAKEHOLDERSAIM
                Hide()
            Else
                MsgBox("Sorry, usercode not found", MsgBoxStyle.OkOnly,)
            End If
        Loop
        FileClose(1)
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class







