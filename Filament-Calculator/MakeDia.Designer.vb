<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeDia
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which spool would you like to use?"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(259, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'button_cancel
        '
        Me.button_cancel.Location = New System.Drawing.Point(216, 66)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_cancel.TabIndex = 2
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = True
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(135, 66)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 3
        Me.button_ok.Text = "Ok"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'MakeDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 101)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(315, 140)
        Me.MinimumSize = New System.Drawing.Size(315, 140)
        Me.Name = "MakeDia"
        Me.Text = "MakeDia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents button_cancel As Button
    Friend WithEvents button_ok As Button
End Class
