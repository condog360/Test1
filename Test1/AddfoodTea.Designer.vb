<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddfoodTea
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_FoodName = New System.Windows.Forms.TextBox()
        Me.txt_Calories = New System.Windows.Forms.TextBox()
        Me.txt_Protein = New System.Windows.Forms.TextBox()
        Me.txt_Carbohydrates = New System.Windows.Forms.TextBox()
        Me.Txt_Sugars = New System.Windows.Forms.TextBox()
        Me.txt_Fat = New System.Windows.Forms.TextBox()
        Me.txt_SatFats = New System.Windows.Forms.TextBox()
        Me.txt_Fibre = New System.Windows.Forms.TextBox()
        Me.txt_Salt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Food Name and Weight (Grams):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Calories:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Protein (Grams):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Carbohydrates (Grams):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sugar (Grams):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fat (Grams):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Saturated Fat (Grams):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fibre (Grams):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Salt (Grams):"
        '
        'txt_FoodName
        '
        Me.txt_FoodName.Location = New System.Drawing.Point(271, 10)
        Me.txt_FoodName.Name = "txt_FoodName"
        Me.txt_FoodName.Size = New System.Drawing.Size(196, 20)
        Me.txt_FoodName.TabIndex = 10
        '
        'txt_Calories
        '
        Me.txt_Calories.Location = New System.Drawing.Point(88, 39)
        Me.txt_Calories.Name = "txt_Calories"
        Me.txt_Calories.Size = New System.Drawing.Size(60, 20)
        Me.txt_Calories.TabIndex = 11
        '
        'txt_Protein
        '
        Me.txt_Protein.Location = New System.Drawing.Point(147, 69)
        Me.txt_Protein.Name = "txt_Protein"
        Me.txt_Protein.Size = New System.Drawing.Size(53, 20)
        Me.txt_Protein.TabIndex = 12
        '
        'txt_Carbohydrates
        '
        Me.txt_Carbohydrates.Location = New System.Drawing.Point(203, 96)
        Me.txt_Carbohydrates.Name = "txt_Carbohydrates"
        Me.txt_Carbohydrates.Size = New System.Drawing.Size(62, 20)
        Me.txt_Carbohydrates.TabIndex = 13
        '
        'Txt_Sugars
        '
        Me.Txt_Sugars.Location = New System.Drawing.Point(137, 124)
        Me.Txt_Sugars.Name = "Txt_Sugars"
        Me.Txt_Sugars.Size = New System.Drawing.Size(61, 20)
        Me.Txt_Sugars.TabIndex = 14
        '
        'txt_Fat
        '
        Me.txt_Fat.Location = New System.Drawing.Point(117, 151)
        Me.txt_Fat.Name = "txt_Fat"
        Me.txt_Fat.Size = New System.Drawing.Size(66, 20)
        Me.txt_Fat.TabIndex = 15
        '
        'txt_SatFats
        '
        Me.txt_SatFats.Location = New System.Drawing.Point(194, 183)
        Me.txt_SatFats.Name = "txt_SatFats"
        Me.txt_SatFats.Size = New System.Drawing.Size(72, 20)
        Me.txt_SatFats.TabIndex = 16
        '
        'txt_Fibre
        '
        Me.txt_Fibre.Location = New System.Drawing.Point(132, 215)
        Me.txt_Fibre.Name = "txt_Fibre"
        Me.txt_Fibre.Size = New System.Drawing.Size(62, 20)
        Me.txt_Fibre.TabIndex = 17
        '
        'txt_Salt
        '
        Me.txt_Salt.Location = New System.Drawing.Point(123, 239)
        Me.txt_Salt.Name = "txt_Salt"
        Me.txt_Salt.Size = New System.Drawing.Size(60, 20)
        Me.txt_Salt.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(311, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 105)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Save and Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddfoodTea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_Salt)
        Me.Controls.Add(Me.txt_Fibre)
        Me.Controls.Add(Me.txt_SatFats)
        Me.Controls.Add(Me.txt_Fat)
        Me.Controls.Add(Me.Txt_Sugars)
        Me.Controls.Add(Me.txt_Carbohydrates)
        Me.Controls.Add(Me.txt_Protein)
        Me.Controls.Add(Me.txt_Calories)
        Me.Controls.Add(Me.txt_FoodName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddfoodTea"
        Me.Text = "AddfoodTea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_FoodName As TextBox
    Friend WithEvents txt_Calories As TextBox
    Friend WithEvents txt_Protein As TextBox
    Friend WithEvents txt_Carbohydrates As TextBox
    Friend WithEvents Txt_Sugars As TextBox
    Friend WithEvents txt_Fat As TextBox
    Friend WithEvents txt_SatFats As TextBox
    Friend WithEvents txt_Fibre As TextBox
    Friend WithEvents txt_Salt As TextBox
    Friend WithEvents Button1 As Button
End Class
