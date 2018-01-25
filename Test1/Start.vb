Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Once button is pressed'
        Register.Show() 'Display to the user the egister screen so that they can create an account'
        Me.Visible = False 'Make the screen not visible to my stakeholder'
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Once button is pressed'
        frm_login.Show() 'Display to the user the login screen (This presumes they already have an account'
        Me.Visible = False 'Make the screen not visible to my stakeholder'
    End Sub
End Class