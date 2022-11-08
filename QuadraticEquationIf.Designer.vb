<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuadraticEquationIf
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
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.LabelB = New System.Windows.Forms.Label()
        Me.LabelC = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxA
        '
        Me.TextBoxA.Location = New System.Drawing.Point(12, 47)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxA.TabIndex = 0
        '
        'TextBoxB
        '
        Me.TextBoxB.Location = New System.Drawing.Point(342, 47)
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxB.TabIndex = 1
        '
        'TextBoxC
        '
        Me.TextBoxC.Location = New System.Drawing.Point(663, 47)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxC.TabIndex = 2
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Location = New System.Drawing.Point(12, 19)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(64, 20)
        Me.LabelA.TabIndex = 3
        Me.LabelA.Text = "INPUT A"
        '
        'LabelB
        '
        Me.LabelB.AutoSize = True
        Me.LabelB.Location = New System.Drawing.Point(342, 19)
        Me.LabelB.Name = "LabelB"
        Me.LabelB.Size = New System.Drawing.Size(63, 20)
        Me.LabelB.TabIndex = 4
        Me.LabelB.Text = "INPUT B"
        '
        'LabelC
        '
        Me.LabelC.AutoSize = True
        Me.LabelC.Location = New System.Drawing.Point(663, 19)
        Me.LabelC.Name = "LabelC"
        Me.LabelC.Size = New System.Drawing.Size(63, 20)
        Me.LabelC.TabIndex = 5
        Me.LabelC.Text = "INPUT C"
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
        'QuadraticEquationIf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 393)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.LabelC)
        Me.Controls.Add(Me.LabelB)
        Me.Controls.Add(Me.LabelA)
        Me.Controls.Add(Me.TextBoxC)
        Me.Controls.Add(Me.TextBoxB)
        Me.Controls.Add(Me.TextBoxA)
        Me.Name = "QuadraticEquationIf"
        Me.Text = "ORAZULIKE 211101081"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents LabelA As Label
    Friend WithEvents LabelB As Label
    Friend WithEvents LabelC As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonExit As Button
End Class
