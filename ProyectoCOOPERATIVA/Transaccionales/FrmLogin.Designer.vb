<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnLogin = New System.Windows.Forms.Panel()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.PnLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnLogin
        '
        Me.PnLogin.BackColor = System.Drawing.Color.Transparent
        Me.PnLogin.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.logincooperativacorrecto
        Me.PnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnLogin.Controls.Add(Me.TxtUsuario)
        Me.PnLogin.Controls.Add(Me.Cancel)
        Me.PnLogin.Controls.Add(Me.TxtContrasena)
        Me.PnLogin.Controls.Add(Me.OK)
        Me.PnLogin.Location = New System.Drawing.Point(90, 3)
        Me.PnLogin.Name = "PnLogin"
        Me.PnLogin.Size = New System.Drawing.Size(732, 337)
        Me.PnLogin.TabIndex = 6
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(429, 171)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(166, 17)
        Me.TxtUsuario.TabIndex = 1
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(516, 280)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(429, 224)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(166, 17)
        Me.TxtContrasena.TabIndex = 3
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(416, 280)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Iniciar"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(848, 352)
        Me.Controls.Add(Me.PnLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.PnLogin.ResumeLayout(False)
        Me.PnLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnLogin As Panel
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents OK As Button
End Class
