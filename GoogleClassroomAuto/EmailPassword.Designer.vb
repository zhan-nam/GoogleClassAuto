<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailPassword
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
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PasswordBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EmailBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "**the email and password will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   auto store in /bin txt file"
        '
        'SaveBtn
        '
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.SaveBtn.FillColor = System.Drawing.Color.RoyalBlue
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(50, 238)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(329, 45)
        Me.SaveBtn.TabIndex = 6
        Me.SaveBtn.Text = "Save To File"
        '
        'PasswordBox
        '
        Me.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBox.DefaultText = ""
        Me.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.DisabledState.Parent = Me.PasswordBox
        Me.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordBox.FocusedState.Parent = Me.PasswordBox
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordBox.HoverState.Parent = Me.PasswordBox
        Me.PasswordBox.Location = New System.Drawing.Point(50, 168)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordBox.PlaceholderText = "Password"
        Me.PasswordBox.SelectedText = ""
        Me.PasswordBox.ShadowDecoration.Parent = Me.PasswordBox
        Me.PasswordBox.Size = New System.Drawing.Size(329, 36)
        Me.PasswordBox.TabIndex = 5
        '
        'EmailBox
        '
        Me.EmailBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailBox.DefaultText = ""
        Me.EmailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailBox.DisabledState.Parent = Me.EmailBox
        Me.EmailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailBox.FocusedState.Parent = Me.EmailBox
        Me.EmailBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailBox.HoverState.Parent = Me.EmailBox
        Me.EmailBox.Location = New System.Drawing.Point(50, 98)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailBox.PlaceholderText = "Email"
        Me.EmailBox.SelectedText = ""
        Me.EmailBox.ShadowDecoration.Parent = Me.EmailBox
        Me.EmailBox.Size = New System.Drawing.Size(329, 36)
        Me.EmailBox.TabIndex = 4
        '
        'EmailPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(429, 324)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.EmailBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "EmailPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Email & Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PasswordBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailBox As Guna.UI2.WinForms.Guna2TextBox
End Class
