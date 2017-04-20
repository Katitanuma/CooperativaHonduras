<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNacionalidad
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.PlNacionalidad = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtNacionalidad = New System.Windows.Forms.TextBox()
        Me.CboPais = New System.Windows.Forms.ComboBox()
        Me.TxtCodigoNacionalidad = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PbIcono = New System.Windows.Forms.PictureBox()
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblModificar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PbLupa = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvNacionalidad = New System.Windows.Forms.DataGridView()
        Me.CMSNacionalidad = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PbSalir = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PlNacionalidad.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PbIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PbLupa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvNacionalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSNacionalidad.SuspendLayout()
        CType(Me.PbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 542)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(701, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ingresar Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.PlNacionalidad)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.PbIcono)
        Me.Panel1.Controls.Add(Me.LblCancelar)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LblModificar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblGuardar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblNuevo)
        Me.Panel1.Controls.Add(Me.BtnModificar)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-111, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 509)
        Me.Panel1.TabIndex = 14
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Image = Global.ProyectoCOOPERATIVA.My.Resources.Resources.boton_cancear_listo
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(711, 305)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 58)
        Me.BtnCancelar.TabIndex = 112
        Me.BtnCancelar.Text = " "
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'PlNacionalidad
        '
        Me.PlNacionalidad.Controls.Add(Me.Panel3)
        Me.PlNacionalidad.Controls.Add(Me.CboPais)
        Me.PlNacionalidad.Controls.Add(Me.TxtCodigoNacionalidad)
        Me.PlNacionalidad.Controls.Add(Me.Panel2)
        Me.PlNacionalidad.Location = New System.Drawing.Point(489, 129)
        Me.PlNacionalidad.Name = "PlNacionalidad"
        Me.PlNacionalidad.Size = New System.Drawing.Size(300, 148)
        Me.PlNacionalidad.TabIndex = 105
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtNacionalidad)
        Me.Panel3.Location = New System.Drawing.Point(2, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(274, 29)
        Me.Panel3.TabIndex = 30
        '
        'TxtNacionalidad
        '
        Me.TxtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNacionalidad.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNacionalidad.Location = New System.Drawing.Point(3, 5)
        Me.TxtNacionalidad.Name = "TxtNacionalidad"
        Me.TxtNacionalidad.Size = New System.Drawing.Size(266, 18)
        Me.TxtNacionalidad.TabIndex = 48
        '
        'CboPais
        '
        Me.CboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPais.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CboPais.FormattingEnabled = True
        Me.CboPais.Location = New System.Drawing.Point(2, 100)
        Me.CboPais.Name = "CboPais"
        Me.CboPais.Size = New System.Drawing.Size(274, 24)
        Me.CboPais.TabIndex = 10
        '
        'TxtCodigoNacionalidad
        '
        Me.TxtCodigoNacionalidad.BackColor = System.Drawing.Color.White
        Me.TxtCodigoNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigoNacionalidad.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoNacionalidad.Location = New System.Drawing.Point(6, 31)
        Me.TxtCodigoNacionalidad.Name = "TxtCodigoNacionalidad"
        Me.TxtCodigoNacionalidad.ReadOnly = True
        Me.TxtCodigoNacionalidad.Size = New System.Drawing.Size(164, 18)
        Me.TxtCodigoNacionalidad.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(2, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(172, 29)
        Me.Panel2.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGuardar.Image = Global.ProyectoCOOPERATIVA.My.Resources.Resources.Boton_Guardar_listo
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(541, 303)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(73, 63)
        Me.BtnGuardar.TabIndex = 111
        Me.BtnGuardar.Text = " "
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNuevo.Image = Global.ProyectoCOOPERATIVA.My.Resources.Resources.Boton_Agregar_listo
        Me.BtnNuevo.Location = New System.Drawing.Point(454, 308)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 53)
        Me.BtnNuevo.TabIndex = 110
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'PbIcono
        '
        Me.PbIcono.BackColor = System.Drawing.Color.Transparent
        Me.PbIcono.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.Nacionalidad
        Me.PbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbIcono.Location = New System.Drawing.Point(153, 102)
        Me.PbIcono.Name = "PbIcono"
        Me.PbIcono.Size = New System.Drawing.Size(184, 193)
        Me.PbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbIcono.TabIndex = 0
        Me.PbIcono.TabStop = False
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(711, 366)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(72, 13)
        Me.LblCancelar.TabIndex = 109
        Me.LblCancelar.Text = "CANCELAR"
        Me.LblCancelar.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "País"
        '
        'LblModificar
        '
        Me.LblModificar.AutoSize = True
        Me.LblModificar.BackColor = System.Drawing.Color.Transparent
        Me.LblModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModificar.Location = New System.Drawing.Point(623, 366)
        Me.LblModificar.Name = "LblModificar"
        Me.LblModificar.Size = New System.Drawing.Size(75, 13)
        Me.LblModificar.TabIndex = 108
        Me.LblModificar.Text = "MODIFICAR"
        Me.LblModificar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(393, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nacionalidad"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(542, 366)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(68, 13)
        Me.LblGuardar.TabIndex = 107
        Me.LblGuardar.Text = "GUARDAR"
        Me.LblGuardar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Nacionalidad"
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(465, 366)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(50, 13)
        Me.LblNuevo.TabIndex = 106
        Me.LblNuevo.Text = "NUEVO"
        Me.LblNuevo.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnModificar.Image = Global.ProyectoCOOPERATIVA.My.Resources.Resources.Boton_Editar_listo
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(627, 303)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(73, 58)
        Me.BtnModificar.TabIndex = 105
        Me.BtnModificar.Text = " "
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage2.Controls.Add(Me.PbLupa)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtBusqueda)
        Me.TabPage2.Controls.Add(Me.DgvNacionalidad)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(701, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ver Datos"
        '
        'PbLupa
        '
        Me.PbLupa.BackColor = System.Drawing.Color.Transparent
        Me.PbLupa.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.lupa
        Me.PbLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbLupa.Location = New System.Drawing.Point(16, 92)
        Me.PbLupa.Name = "PbLupa"
        Me.PbLupa.Size = New System.Drawing.Size(22, 27)
        Me.PbLupa.TabIndex = 87
        Me.PbLupa.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 45)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Datos"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(44, 93)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(637, 26)
        Me.TxtBusqueda.TabIndex = 80
        '
        'DgvNacionalidad
        '
        Me.DgvNacionalidad.AllowUserToAddRows = False
        Me.DgvNacionalidad.AllowUserToDeleteRows = False
        Me.DgvNacionalidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNacionalidad.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvNacionalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNacionalidad.ContextMenuStrip = Me.CMSNacionalidad
        Me.DgvNacionalidad.Location = New System.Drawing.Point(16, 137)
        Me.DgvNacionalidad.Name = "DgvNacionalidad"
        Me.DgvNacionalidad.ReadOnly = True
        Me.DgvNacionalidad.RowHeadersVisible = False
        Me.DgvNacionalidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNacionalidad.Size = New System.Drawing.Size(665, 355)
        Me.DgvNacionalidad.TabIndex = 15
        '
        'CMSNacionalidad
        '
        Me.CMSNacionalidad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSNacionalidad.Name = "CMSNacionalidad"
        Me.CMSNacionalidad.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(233, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(282, 43)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "NACIONALIDAD"
        '
        'PbSalir
        '
        Me.PbSalir.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.close_button_png_26
        Me.PbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbSalir.Location = New System.Drawing.Point(679, 12)
        Me.PbSalir.Name = "PbSalir"
        Me.PbSalir.Size = New System.Drawing.Size(33, 32)
        Me.PbSalir.TabIndex = 20
        Me.PbSalir.TabStop = False
        '
        'FrmNacionalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 598)
        Me.Controls.Add(Me.PbSalir)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNacionalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Nacionalidad"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PlNacionalidad.ResumeLayout(False)
        Me.PlNacionalidad.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PbIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PbLupa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvNacionalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSNacionalidad.ResumeLayout(False)
        CType(Me.PbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PbIcono As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtNacionalidad As TextBox
    Friend WithEvents CboPais As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigoNacionalidad As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DgvNacionalidad As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents PbSalir As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PbLupa As PictureBox
    Friend WithEvents PlNacionalidad As Panel
    Friend WithEvents CMSNacionalidad As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents LblCancelar As Label
    Friend WithEvents LblModificar As Label
    Friend WithEvents LblGuardar As Label
    Friend WithEvents LblNuevo As Label
    Friend WithEvents BtnModificar As Button
End Class
