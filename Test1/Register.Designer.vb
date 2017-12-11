<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CurrentWeight = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Height = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_GoalWeight = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_Gender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_ActivityLevel = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_GoalRate = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(1, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(57, 34)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(214, 20)
        Me.txt_Username.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Current Weight (KG):"
        '
        'txt_CurrentWeight
        '
        Me.txt_CurrentWeight.Location = New System.Drawing.Point(128, 119)
        Me.txt_CurrentWeight.Name = "txt_CurrentWeight"
        Me.txt_CurrentWeight.Size = New System.Drawing.Size(38, 20)
        Me.txt_CurrentWeight.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Height (CM):"
        '
        'txt_Height
        '
        Me.txt_Height.Location = New System.Drawing.Point(90, 56)
        Me.txt_Height.Name = "txt_Height"
        Me.txt_Height.Size = New System.Drawing.Size(58, 20)
        Me.txt_Height.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Goal Weight (KG):"
        '
        'txt_GoalWeight
        '
        Me.txt_GoalWeight.Location = New System.Drawing.Point(117, 142)
        Me.txt_GoalWeight.Name = "txt_GoalWeight"
        Me.txt_GoalWeight.Size = New System.Drawing.Size(43, 20)
        Me.txt_GoalWeight.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Gender:"
        '
        'cbo_Gender
        '
        Me.cbo_Gender.FormattingEnabled = True
        Me.cbo_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbo_Gender.Location = New System.Drawing.Point(57, 97)
        Me.cbo_Gender.Name = "cbo_Gender"
        Me.cbo_Gender.Size = New System.Drawing.Size(109, 21)
        Me.cbo_Gender.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Activity Level:"
        '
        'cbo_ActivityLevel
        '
        Me.cbo_ActivityLevel.FormattingEnabled = True
        Me.cbo_ActivityLevel.Items.AddRange(New Object() {"Sedentary", "Lightly Active", "Moderately Active", "Active", "Very Active"})
        Me.cbo_ActivityLevel.Location = New System.Drawing.Point(98, 165)
        Me.cbo_ActivityLevel.Name = "cbo_ActivityLevel"
        Me.cbo_ActivityLevel.Size = New System.Drawing.Size(510, 21)
        Me.cbo_ActivityLevel.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "What is your goal?:"
        '
        'cbo_GoalRate
        '
        Me.cbo_GoalRate.FormattingEnabled = True
        Me.cbo_GoalRate.Items.AddRange(New Object() {"Lose 2 Pounds Per Week", "Lose 1 Pound Per Week", "Lose 0.5 Pounds Per Week", "Maintain Weight", "Gain 0.5 Pounds Per Week", "Gain 1 Pound Per Week"})
        Me.cbo_GoalRate.Location = New System.Drawing.Point(128, 189)
        Me.cbo_GoalRate.Name = "cbo_GoalRate"
        Me.cbo_GoalRate.Size = New System.Drawing.Size(472, 21)
        Me.cbo_GoalRate.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(178, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(257, 63)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Save and Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Age:"
        '
        'dtp_1
        '
        Me.dtp_1.Location = New System.Drawing.Point(37, 78)
        Me.dtp_1.Name = "dtp_1"
        Me.dtp_1.Size = New System.Drawing.Size(128, 20)
        Me.dtp_1.TabIndex = 17
        Me.dtp_1.Value = New Date(2017, 12, 4, 0, 0, 0, 0)
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 291)
        Me.Controls.Add(Me.dtp_1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbo_GoalRate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbo_ActivityLevel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbo_Gender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_GoalWeight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Height)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_CurrentWeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_CurrentWeight As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Height As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_GoalWeight As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_Gender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbo_ActivityLevel As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbo_GoalRate As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp_1 As DateTimePicker
End Class
