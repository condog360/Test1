<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExercise
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
        Me.lst_NameOfExercise = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_DurationOfExercise = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_IntensityOfExercise = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type of Exercise"
        '
        'lst_NameOfExercise
        '
        Me.lst_NameOfExercise.BackColor = System.Drawing.SystemColors.Window
        Me.lst_NameOfExercise.Location = New System.Drawing.Point(3, 20)
        Me.lst_NameOfExercise.Name = "lst_NameOfExercise"
        Me.lst_NameOfExercise.Size = New System.Drawing.Size(279, 134)
        Me.lst_NameOfExercise.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Duration (Minutes):"
        '
        'txt_DurationOfExercise
        '
        Me.txt_DurationOfExercise.Location = New System.Drawing.Point(150, 157)
        Me.txt_DurationOfExercise.Name = "txt_DurationOfExercise"
        Me.txt_DurationOfExercise.Size = New System.Drawing.Size(132, 20)
        Me.txt_DurationOfExercise.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Intensity:"
        '
        'cbo_IntensityOfExercise
        '
        Me.cbo_IntensityOfExercise.FormattingEnabled = True
        Me.cbo_IntensityOfExercise.Items.AddRange(New Object() {"Low", "Medium (A slight shortness of breath)", "High (Out of breath)", "Extreme (Completely fatigued, muscle ache, completely out of breath)"})
        Me.cbo_IntensityOfExercise.Location = New System.Drawing.Point(81, 177)
        Me.cbo_IntensityOfExercise.Name = "cbo_IntensityOfExercise"
        Me.cbo_IntensityOfExercise.Size = New System.Drawing.Size(200, 21)
        Me.cbo_IntensityOfExercise.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save and Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbo_IntensityOfExercise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_DurationOfExercise)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lst_NameOfExercise)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddExercise"
        Me.Text = "AddExercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lst_NameOfExercise As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_DurationOfExercise As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_IntensityOfExercise As ComboBox
    Friend WithEvents Button1 As Button
End Class
