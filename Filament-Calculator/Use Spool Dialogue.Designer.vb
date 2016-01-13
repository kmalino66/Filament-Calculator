<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Use_Spool_Dialogue
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
        Dim filament_used_textbox As System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.money_charged_textbox = New System.Windows.Forms.TextBox()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.button_cancel = New System.Windows.Forms.Button()
        filament_used_textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which spool would you like to use?"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(192, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please Confirm that the below information is correct:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Money Charged:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Filament Used:"
        '
        'money_charged_textbox
        '
        Me.money_charged_textbox.Location = New System.Drawing.Point(172, 91)
        Me.money_charged_textbox.Name = "money_charged_textbox"
        Me.money_charged_textbox.Size = New System.Drawing.Size(100, 20)
        Me.money_charged_textbox.TabIndex = 5
        '
        'filament_used_textbox
        '
        filament_used_textbox.Location = New System.Drawing.Point(172, 120)
        filament_used_textbox.Name = "filament_used_textbox"
        filament_used_textbox.Size = New System.Drawing.Size(100, 20)
        filament_used_textbox.TabIndex = 6
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(305, 175)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 7
        Me.button_ok.Text = "Ok"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'button_cancel
        '
        Me.button_cancel.Location = New System.Drawing.Point(387, 175)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_cancel.TabIndex = 8
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = True
        '
        'Use_Spool_Dialogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 219)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(filament_used_textbox)
        Me.Controls.Add(Me.money_charged_textbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Use_Spool_Dialogue"
        Me.Text = "Use_Spool_Dialogue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents money_charged_textbox As TextBox
    Friend WithEvents button_ok As Button
    Friend WithEvents button_cancel As Button
End Class
