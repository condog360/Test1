<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Goall = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Goal = New System.Windows.Forms.Label()
        Me.lbl_FoodCalories = New System.Windows.Forms.Label()
        Me.lbl_ExerciseCalories = New System.Windows.Forms.Label()
        Me.lbl_CaloriesRemaining = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btn_FinishLogging = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Goall
        '
        Me.lbl_Goall.AutoSize = True
        Me.lbl_Goall.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbl_Goall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Goall.Location = New System.Drawing.Point(12, 11)
        Me.lbl_Goall.Name = "lbl_Goall"
        Me.lbl_Goall.Size = New System.Drawing.Size(53, 24)
        Me.lbl_Goall.TabIndex = 0
        Me.lbl_Goall.Text = "Goal"
        Me.lbl_Goall.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Food calories"
        Me.Label2.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exercise Calories"
        Me.Label3.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Calories Remaining"
        Me.Label4.UseWaitCursor = True
        '
        'lbl_Goal
        '
        Me.lbl_Goal.AutoSize = True
        Me.lbl_Goal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Goal.Location = New System.Drawing.Point(24, 49)
        Me.lbl_Goal.Name = "lbl_Goal"
        Me.lbl_Goal.Size = New System.Drawing.Size(21, 24)
        Me.lbl_Goal.TabIndex = 4
        Me.lbl_Goal.Text = "0"
        Me.lbl_Goal.UseWaitCursor = True
        '
        'lbl_FoodCalories
        '
        Me.lbl_FoodCalories.AutoSize = True
        Me.lbl_FoodCalories.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_FoodCalories.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FoodCalories.Location = New System.Drawing.Point(142, 49)
        Me.lbl_FoodCalories.Name = "lbl_FoodCalories"
        Me.lbl_FoodCalories.Size = New System.Drawing.Size(21, 24)
        Me.lbl_FoodCalories.TabIndex = 5
        Me.lbl_FoodCalories.Text = "0"
        Me.lbl_FoodCalories.UseWaitCursor = True
        '
        'lbl_ExerciseCalories
        '
        Me.lbl_ExerciseCalories.AutoSize = True
        Me.lbl_ExerciseCalories.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_ExerciseCalories.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ExerciseCalories.Location = New System.Drawing.Point(340, 49)
        Me.lbl_ExerciseCalories.Name = "lbl_ExerciseCalories"
        Me.lbl_ExerciseCalories.Size = New System.Drawing.Size(21, 24)
        Me.lbl_ExerciseCalories.TabIndex = 6
        Me.lbl_ExerciseCalories.Text = "0"
        Me.lbl_ExerciseCalories.UseWaitCursor = True
        '
        'lbl_CaloriesRemaining
        '
        Me.lbl_CaloriesRemaining.AutoSize = True
        Me.lbl_CaloriesRemaining.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_CaloriesRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CaloriesRemaining.Location = New System.Drawing.Point(555, 49)
        Me.lbl_CaloriesRemaining.Name = "lbl_CaloriesRemaining"
        Me.lbl_CaloriesRemaining.Size = New System.Drawing.Size(21, 24)
        Me.lbl_CaloriesRemaining.TabIndex = 7
        Me.lbl_CaloriesRemaining.Text = "0"
        Me.lbl_CaloriesRemaining.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Breakfast"
        Me.Label7.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 24)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Lunch"
        Me.Label8.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Dinner"
        Me.Label9.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Snacks"
        Me.Label10.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 571)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Water"
        Me.Label11.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 21)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add food for Breakfast"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(242, 21)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Add food for Lunch"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.UseWaitCursor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(7, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(242, 21)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Add food for Dinner"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.UseWaitCursor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 547)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(242, 21)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Add food for Snacks"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.UseWaitCursor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(7, 638)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(242, 21)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Add Water"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.UseWaitCursor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 113)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(242, 56)
        Me.ListBox1.TabIndex = 18
        Me.ListBox1.UseWaitCursor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(7, 221)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(242, 69)
        Me.ListBox2.TabIndex = 19
        Me.ListBox2.UseWaitCursor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(7, 344)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(242, 69)
        Me.ListBox3.TabIndex = 20
        Me.ListBox3.UseWaitCursor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(7, 472)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(242, 69)
        Me.ListBox4.TabIndex = 21
        Me.ListBox4.UseWaitCursor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(7, 594)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(242, 43)
        Me.ListBox5.TabIndex = 22
        Me.ListBox5.UseWaitCursor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(422, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 24)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Exercise:"
        Me.Label12.UseWaitCursor = True
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(426, 113)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(242, 56)
        Me.ListBox6.TabIndex = 24
        Me.ListBox6.UseWaitCursor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(426, 170)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(242, 21)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Add Exercise"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.UseWaitCursor = True
        '
        'btn_FinishLogging
        '
        Me.btn_FinishLogging.Location = New System.Drawing.Point(383, 606)
        Me.btn_FinishLogging.Name = "btn_FinishLogging"
        Me.btn_FinishLogging.Size = New System.Drawing.Size(288, 52)
        Me.btn_FinishLogging.TabIndex = 26
        Me.btn_FinishLogging.Text = "Finish Logging For The Day"
        Me.btn_FinishLogging.UseVisualStyleBackColor = True
        Me.btn_FinishLogging.UseWaitCursor = True
        '
        'MainMenuScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.Controls.Add(Me.btn_FinishLogging)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_CaloriesRemaining)
        Me.Controls.Add(Me.lbl_ExerciseCalories)
        Me.Controls.Add(Me.lbl_FoodCalories)
        Me.Controls.Add(Me.lbl_Goal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Goall)
        Me.Name = "MainMenuScreen"
        Me.Text = "MainMenu"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Goall As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Goal As Label
    Friend WithEvents lbl_FoodCalories As Label
    Friend WithEvents lbl_ExerciseCalories As Label
    Friend WithEvents lbl_CaloriesRemaining As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents Button6 As Button
    Friend WithEvents btn_FinishLogging As Button
End Class
