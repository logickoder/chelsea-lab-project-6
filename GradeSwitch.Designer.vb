<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeSwitch
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
        Me.TextBoxScore = New System.Windows.Forms.TextBox()
        Me.TextBoxGrade = New System.Windows.Forms.TextBox()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelGrade = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxScore
        '
        Me.TextBoxScore.Location = New System.Drawing.Point(12, 47)
        Me.TextBoxScore.Name = "TextBoxScore"
        Me.TextBoxScore.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxScore.TabIndex = 0
        '
        'TextBoxGrade
        '
        Me.TextBoxGrade.Location = New System.Drawing.Point(663, 47)
        Me.TextBoxGrade.Name = "TextBoxGrade"
        Me.TextBoxGrade.ReadOnly = True
        Me.TextBoxGrade.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxGrade.TabIndex = 2
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Location = New System.Drawing.Point(12, 19)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(54, 20)
        Me.LabelScore.TabIndex = 3
        Me.LabelScore.Text = "SCORE"
        '
        'LabelGrade
        '
        Me.LabelGrade.AutoSize = True
        Me.LabelGrade.Location = New System.Drawing.Point(663, 19)
        Me.LabelGrade.Name = "LabelGrade"
        Me.LabelGrade.Size = New System.Drawing.Size(57, 20)
        Me.LabelGrade.TabIndex = 5
        Me.LabelGrade.Text = "GRADE"
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(12, 346)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(94, 29)
        Me.ButtonCalculate.TabIndex = 8
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(694, 346)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(94, 29)
        Me.ButtonExit.TabIndex = 9
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'GradeSwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 393)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.LabelGrade)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.TextBoxGrade)
        Me.Controls.Add(Me.TextBoxScore)
        Me.Name = "GradeSwitch"
        Me.Text = "ORAZULIKE 211101081"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxScore As TextBox
    Friend WithEvents TextBoxGrade As TextBox
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelGrade As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonExit As Button
End Class
