﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamento
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.LblModificar = New System.Windows.Forms.Label()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.PbIcono = New System.Windows.Forms.PictureBox()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CboPais = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigoDepartamento = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CboBusqueda = New System.Windows.Forms.ComboBox()
        Me.PbLapiz = New System.Windows.Forms.PictureBox()
        Me.PbLupa = New System.Windows.Forms.PictureBox()
        Me.DgvDepartamento = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PbSalir = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PbIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PbLapiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLupa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabIndex = 21
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
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.LblCancelar)
        Me.Panel1.Controls.Add(Me.LblModificar)
        Me.Panel1.Controls.Add(Me.LblGuardar)
        Me.Panel1.Controls.Add(Me.LblNuevo)
        Me.Panel1.Controls.Add(Me.BtnModificar)
        Me.Panel1.Controls.Add(Me.PbIcono)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.CboPais)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodigoDepartamento)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-56, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 508)
        Me.Panel1.TabIndex = 17
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.ba52
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(592, 294)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 53)
        Me.BtnCancelar.TabIndex = 104
        Me.BtnCancelar.Text = " "
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.ba11
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(419, 294)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(73, 53)
        Me.BtnGuardar.TabIndex = 103
        Me.BtnGuardar.Text = " "
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.ba21
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(332, 294)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 53)
        Me.BtnNuevo.TabIndex = 102
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(589, 352)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(72, 13)
        Me.LblCancelar.TabIndex = 101
        Me.LblCancelar.Text = "CANCELAR"
        Me.LblCancelar.Visible = False
        '
        'LblModificar
        '
        Me.LblModificar.AutoSize = True
        Me.LblModificar.BackColor = System.Drawing.Color.Transparent
        Me.LblModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModificar.Location = New System.Drawing.Point(501, 352)
        Me.LblModificar.Name = "LblModificar"
        Me.LblModificar.Size = New System.Drawing.Size(75, 13)
        Me.LblModificar.TabIndex = 100
        Me.LblModificar.Text = "MODIFICAR"
        Me.LblModificar.Visible = False
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(420, 352)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(68, 13)
        Me.LblGuardar.TabIndex = 99
        Me.LblGuardar.Text = "GUARDAR"
        Me.LblGuardar.Visible = False
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(343, 352)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(50, 13)
        Me.LblNuevo.TabIndex = 98
        Me.LblNuevo.Text = "NUEVO"
        Me.LblNuevo.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.ba31
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(505, 294)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(73, 53)
        Me.BtnModificar.TabIndex = 97
        Me.BtnModificar.Text = " "
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'PbIcono
        '
        Me.PbIcono.BackColor = System.Drawing.Color.Transparent
        Me.PbIcono.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.departamento
        Me.PbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbIcono.Location = New System.Drawing.Point(91, 82)
        Me.PbIcono.Name = "PbIcono"
        Me.PbIcono.Size = New System.Drawing.Size(184, 193)
        Me.PbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbIcono.TabIndex = 0
        Me.PbIcono.TabStop = False
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDepartamento.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepartamento.Location = New System.Drawing.Point(3, 4)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(268, 18)
        Me.TxtDepartamento.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtDepartamento)
        Me.Panel3.Location = New System.Drawing.Point(423, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 29)
        Me.Panel3.TabIndex = 30
        '
        'CboPais
        '
        Me.CboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPais.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CboPais.FormattingEnabled = True
        Me.CboPais.Location = New System.Drawing.Point(423, 218)
        Me.CboPais.Name = "CboPais"
        Me.CboPais.Size = New System.Drawing.Size(276, 24)
        Me.CboPais.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "País"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Departamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtCodigoDepartamento
        '
        Me.TxtCodigoDepartamento.BackColor = System.Drawing.Color.White
        Me.TxtCodigoDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigoDepartamento.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoDepartamento.Location = New System.Drawing.Point(427, 139)
        Me.TxtCodigoDepartamento.Name = "TxtCodigoDepartamento"
        Me.TxtCodigoDepartamento.ReadOnly = True
        Me.TxtCodigoDepartamento.Size = New System.Drawing.Size(190, 18)
        Me.TxtCodigoDepartamento.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(422, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 29)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Departamento"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtBusqueda)
        Me.TabPage2.Controls.Add(Me.CboBusqueda)
        Me.TabPage2.Controls.Add(Me.PbLapiz)
        Me.TabPage2.Controls.Add(Me.PbLupa)
        Me.TabPage2.Controls.Add(Me.DgvDepartamento)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(701, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ver Datos"
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
        Me.TxtBusqueda.Location = New System.Drawing.Point(348, 76)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(332, 26)
        Me.TxtBusqueda.TabIndex = 80
        '
        'CboBusqueda
        '
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Location = New System.Drawing.Point(44, 76)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(237, 27)
        Me.CboBusqueda.TabIndex = 79
        '
        'PbLapiz
        '
        Me.PbLapiz.BackColor = System.Drawing.Color.Transparent
        Me.PbLapiz.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.lapiz
        Me.PbLapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbLapiz.Location = New System.Drawing.Point(316, 76)
        Me.PbLapiz.Name = "PbLapiz"
        Me.PbLapiz.Size = New System.Drawing.Size(27, 27)
        Me.PbLapiz.TabIndex = 82
        Me.PbLapiz.TabStop = False
        '
        'PbLupa
        '
        Me.PbLupa.BackColor = System.Drawing.Color.Transparent
        Me.PbLupa.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.lupa
        Me.PbLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbLupa.Location = New System.Drawing.Point(16, 76)
        Me.PbLupa.Name = "PbLupa"
        Me.PbLupa.Size = New System.Drawing.Size(22, 27)
        Me.PbLupa.TabIndex = 81
        Me.PbLupa.TabStop = False
        '
        'DgvDepartamento
        '
        Me.DgvDepartamento.AllowUserToDeleteRows = False
        Me.DgvDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDepartamento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamento.Location = New System.Drawing.Point(16, 137)
        Me.DgvDepartamento.Name = "DgvDepartamento"
        Me.DgvDepartamento.Size = New System.Drawing.Size(665, 355)
        Me.DgvDepartamento.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(226, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(295, 43)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "DEPARTAMENTO"
        '
        'PbSalir
        '
        Me.PbSalir.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.close_button_png_26
        Me.PbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbSalir.Location = New System.Drawing.Point(679, 8)
        Me.PbSalir.Name = "PbSalir"
        Me.PbSalir.Size = New System.Drawing.Size(33, 32)
        Me.PbSalir.TabIndex = 24
        Me.PbSalir.TabStop = False
        '
        'frmDepartamento
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
        Me.Name = "frmDepartamento"
        Me.Text = "Gestión de Departamento"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PbLapiz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLupa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PbIcono As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CboPais As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigoDepartamento As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DgvDepartamento As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents PbSalir As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents CboBusqueda As ComboBox
    Friend WithEvents PbLapiz As PictureBox
    Friend WithEvents PbLupa As PictureBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents LblCancelar As Label
    Friend WithEvents LblModificar As Label
    Friend WithEvents LblGuardar As Label
    Friend WithEvents LblNuevo As Label
    Friend WithEvents BtnModificar As Button
End Class
