<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSpool
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
        Me.textbox_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textbox_length = New System.Windows.Forms.TextBox()
        Me.textbox_cost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Spool Name:"
        '
        'textbox_name
        '
        Me.textbox_name.Location = New System.Drawing.Point(86, 18)
        Me.textbox_name.Name = "textbox_name"
        Me.textbox_name.Size = New System.Drawing.Size(100, 20)
        Me.textbox_name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Original Filament Length:"
        '
        'textbox_length
        '
        Me.textbox_length.Location = New System.Drawing.Point(140, 44)
        Me.textbox_length.Name = "textbox_length"
        Me.textbox_length.Size = New System.Drawing.Size(100, 20)
        Me.textbox_length.TabIndex = 3
        '
        'textbox_cost
        '
        Me.textbox_cost.Location = New System.Drawing.Point(140, 70)
        Me.textbox_cost.Name = "textbox_cost"
        Me.textbox_cost.Size = New System.Drawing.Size(100, 20)
        Me.textbox_cost.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Spool Cost:"
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(165, 96)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 6
        Me.button_ok.Text = "Ok"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'NewSpool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 143)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(Me.textbox_cost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textbox_length)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textbox_name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewSpool"
        Me.Text = "NewSpool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textbox_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox_length As TextBox
    Friend WithEvents textbox_cost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents button_ok As Button
End Class
