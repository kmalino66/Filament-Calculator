<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Spool_Dialog
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
        Me.spoolname_textbox = New System.Windows.Forms.TextBox()
        Me.spool_length_textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.spool_cost_textbox = New System.Windows.Forms.TextBox()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What is the spool name:"
        '
        'spoolname_textbox
        '
        Me.spoolname_textbox.Location = New System.Drawing.Point(139, 6)
        Me.spoolname_textbox.Name = "spoolname_textbox"
        Me.spoolname_textbox.Size = New System.Drawing.Size(182, 20)
        Me.spoolname_textbox.TabIndex = 1
        '
        'spool_length_textbox
        '
        Me.spool_length_textbox.Location = New System.Drawing.Point(237, 45)
        Me.spool_length_textbox.Name = "spool_length_textbox"
        Me.spool_length_textbox.Size = New System.Drawing.Size(100, 20)
        Me.spool_length_textbox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How much filament is on the spool in meters?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "How much did the spool cost?"
        '
        'spool_cost_textbox
        '
        Me.spool_cost_textbox.Location = New System.Drawing.Point(168, 80)
        Me.spool_cost_textbox.Name = "spool_cost_textbox"
        Me.spool_cost_textbox.Size = New System.Drawing.Size(100, 20)
        Me.spool_cost_textbox.TabIndex = 5
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(264, 128)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 6
        Me.button_ok.Text = "Ok"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'button_cancel
        '
        Me.button_cancel.Location = New System.Drawing.Point(345, 128)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_cancel.TabIndex = 7
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = True
        '
        'New_Spool_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 163)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(Me.spool_cost_textbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.spool_length_textbox)
        Me.Controls.Add(Me.spoolname_textbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "New_Spool_Dialog"
        Me.Text = "New_Spool_Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents spoolname_textbox As TextBox
    Friend WithEvents spool_length_textbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents spool_cost_textbox As TextBox
    Friend WithEvents button_ok As Button
    Friend WithEvents button_cancel As Button
End Class
