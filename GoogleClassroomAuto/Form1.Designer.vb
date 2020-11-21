<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.statusbox = New System.Windows.Forms.Label()
        Me.urlBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddEmailPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearEmailPasswrodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeBox = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Status :"
        '
        'statusbox
        '
        Me.statusbox.BackColor = System.Drawing.Color.White
        Me.statusbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statusbox.Location = New System.Drawing.Point(37, 181)
        Me.statusbox.Name = "statusbox"
        Me.statusbox.Size = New System.Drawing.Size(301, 100)
        Me.statusbox.TabIndex = 11
        '
        'urlBox
        '
        Me.urlBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.urlBox.DefaultText = ""
        Me.urlBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.urlBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.urlBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.urlBox.DisabledState.Parent = Me.urlBox
        Me.urlBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.urlBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.urlBox.FocusedState.Parent = Me.urlBox
        Me.urlBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.urlBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.urlBox.HoverState.Parent = Me.urlBox
        Me.urlBox.Location = New System.Drawing.Point(37, 93)
        Me.urlBox.Name = "urlBox"
        Me.urlBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.urlBox.PlaceholderText = "URL"
        Me.urlBox.SelectedText = ""
        Me.urlBox.ShadowDecoration.Parent = Me.urlBox
        Me.urlBox.Size = New System.Drawing.Size(648, 36)
        Me.urlBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "GoogleClassroom Auto"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(364, 245)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(321, 36)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "set"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmailPasswordToolStripMenuItem, Me.ClearEmailPasswrodToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(251, 100)
        '
        'AddEmailPasswordToolStripMenuItem
        '
        Me.AddEmailPasswordToolStripMenuItem.Name = "AddEmailPasswordToolStripMenuItem"
        Me.AddEmailPasswordToolStripMenuItem.Size = New System.Drawing.Size(250, 32)
        Me.AddEmailPasswordToolStripMenuItem.Text = "Add Email Password"
        '
        'ClearEmailPasswrodToolStripMenuItem
        '
        Me.ClearEmailPasswrodToolStripMenuItem.Name = "ClearEmailPasswrodToolStripMenuItem"
        Me.ClearEmailPasswrodToolStripMenuItem.Size = New System.Drawing.Size(250, 32)
        Me.ClearEmailPasswrodToolStripMenuItem.Text = "Clear Email Passwrod"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(250, 32)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'Timer1
        '
        '
        'timeBox
        '
        Me.timeBox.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.timeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeBox.Location = New System.Drawing.Point(364, 181)
        Me.timeBox.Name = "timeBox"
        Me.timeBox.Size = New System.Drawing.Size(321, 30)
        Me.timeBox.TabIndex = 13
        Me.timeBox.Value = New Date(2020, 11, 21, 12, 48, 36, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 329)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.timeBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.statusbox)
        Me.Controls.Add(Me.urlBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automation"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents statusbox As Label
    Friend WithEvents urlBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddEmailPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearEmailPasswrodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeBox As DateTimePicker
End Class
