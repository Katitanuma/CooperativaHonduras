﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.PnLogin = New System.Windows.Forms.Panel()
        Me.PnLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTextBox.Location = New System.Drawing.Point(452, 172)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(177, 13)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTextBox.Location = New System.Drawing.Point(452, 226)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(177, 13)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(435, 280)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(535, 280)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'PnLogin
        '
        Me.PnLogin.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.LoginCooperativa1
        Me.PnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnLogin.Controls.Add(Me.UsernameTextBox)
        Me.PnLogin.Controls.Add(Me.Cancel)
        Me.PnLogin.Controls.Add(Me.PasswordTextBox)
        Me.PnLogin.Controls.Add(Me.OK)
        Me.PnLogin.Location = New System.Drawing.Point(2, 7)
        Me.PnLogin.Name = "PnLogin"
        Me.PnLogin.Size = New System.Drawing.Size(806, 337)
        Me.PnLogin.TabIndex = 6
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(696, 355)
        Me.Controls.Add(Me.PnLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.PnLogin.ResumeLayout(False)
        Me.PnLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnLogin As Panel
End Class
