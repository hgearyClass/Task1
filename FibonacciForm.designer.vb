<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FibonacciForm
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
        Me.TxtPosition = New System.Windows.Forms.TextBox()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtPosition
        '
        Me.TxtPosition.Location = New System.Drawing.Point(49, 41)
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.Size = New System.Drawing.Size(100, 20)
        Me.TxtPosition.TabIndex = 0
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(155, 39)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGo.TabIndex = 1
        Me.BtnGo.Text = "GO"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutput.Location = New System.Drawing.Point(49, 68)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(45, 13)
        Me.LblOutput.TabIndex = 2
        Me.LblOutput.Text = "Output"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter a position and click the GO button."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Output"
        '
        'FibonacciForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 102)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.TxtPosition)
        Me.Name = "FibonacciForm"
        Me.Text = "Fibonacci Series"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPosition As System.Windows.Forms.TextBox
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents LblOutput As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
