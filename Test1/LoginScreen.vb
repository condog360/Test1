﻿Public Class frm_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(1, "N:\Visual Studio 2017\project\logins.csv", OpenMode.Input)
        loginnameattempt = txt_LoginAttempt.Text
        logindobattempt = age
        logindatafile = ""
        accountfound = False
        Do Until EOF(1) Or accountfound = True
            Dim fullline As String = LineInput(1)
            Dim Item() As String = Split(fullline, ",")
            correctloginname = Item(0)
            correctlogindob = Item(2)
            If loginnameattempt = correctloginname And logindobattempt = correctlogindob Then
                MainMenuScreen.Show()
                Hide()
            ElseIf accountfound = False Then
                MsgBox("Sorry, usercode not found", MsgBoxStyle.OkOnly, "Invalid Store Login")
                txt_LoginAttempt.Clear()
                FileClose(1)
            End If
        Loop
        FileClose(1)
End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class







