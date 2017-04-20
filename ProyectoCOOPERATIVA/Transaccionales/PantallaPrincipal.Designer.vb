<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.LblOficialNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblIdOficial = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCooperativa = New System.Windows.Forms.Label()
        Me.PnlCooperativa = New System.Windows.Forms.Panel()
        Me.LblSOCIOS = New System.Windows.Forms.Label()
        Me.LblEmpleado = New System.Windows.Forms.Label()
        Me.PnlSOCIOS = New System.Windows.Forms.Panel()
        Me.LblUbicacion = New System.Windows.Forms.Label()
        Me.PnlEmpleados = New System.Windows.Forms.Panel()
        Me.PnlUbicacion = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnUbicacion2 = New System.Windows.Forms.Panel()
        Me.PnlCiudad = New System.Windows.Forms.Panel()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.Lbldepto = New System.Windows.Forms.Label()
        Me.LblPais = New System.Windows.Forms.Label()
        Me.PnlDepartamento = New System.Windows.Forms.Panel()
        Me.PnlPais = New System.Windows.Forms.Panel()
        Me.PnlNacionalidad = New System.Windows.Forms.Panel()
        Me.LblNacionalidad = New System.Windows.Forms.Label()
        Me.PnEmpleados2 = New System.Windows.Forms.Panel()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblCargo = New System.Windows.Forms.Label()
        Me.PnlUsuario = New System.Windows.Forms.Panel()
        Me.LblProfesion = New System.Windows.Forms.Label()
        Me.Pnlcargo = New System.Windows.Forms.Panel()
        Me.PnlProfesion = New System.Windows.Forms.Panel()
        Me.PnlOficial = New System.Windows.Forms.Panel()
        Me.LblOficial = New System.Windows.Forms.Label()
        Me.PnSocios2 = New System.Windows.Forms.Panel()
        Me.LblCuenta = New System.Windows.Forms.Label()
        Me.PnlCuenta = New System.Windows.Forms.Panel()
        Me.PnlSocio = New System.Windows.Forms.Panel()
        Me.LblSocio = New System.Windows.Forms.Label()
        Me.PnCooperativa2 = New System.Windows.Forms.Panel()
        Me.LblTipoPrestamo = New System.Windows.Forms.Label()
        Me.PnlTipoPrestamo = New System.Windows.Forms.Panel()
        Me.LblTipoCuenta = New System.Windows.Forms.Label()
        Me.LblPrestamo = New System.Windows.Forms.Label()
        Me.PnlTipoCuenta = New System.Windows.Forms.Panel()
        Me.PnlPrestamo = New System.Windows.Forms.Panel()
        Me.PnlAval = New System.Windows.Forms.Panel()
        Me.LblAval = New System.Windows.Forms.Label()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlLogo1 = New System.Windows.Forms.Panel()
        Me.PbSalir = New System.Windows.Forms.PictureBox()
        Me.PbCambioSesion = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblSalir = New System.Windows.Forms.Label()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnUbicacion2.SuspendLayout()
        Me.PnEmpleados2.SuspendLayout()
        Me.PnSocios2.SuspendLayout()
        Me.PnCooperativa2.SuspendLayout()
        Me.PnlLogo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLogo1.SuspendLayout()
        CType(Me.PbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCambioSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1345, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblOficialNombre, Me.LblIdOficial})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 632)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1345, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'LblOficialNombre
        '
        Me.LblOficialNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOficialNombre.Name = "LblOficialNombre"
        Me.LblOficialNombre.Size = New System.Drawing.Size(46, 17)
        Me.LblOficialNombre.Text = "Status"
        '
        'LblIdOficial
        '
        Me.LblIdOficial.Name = "LblIdOficial"
        Me.LblIdOficial.Size = New System.Drawing.Size(120, 17)
        Me.LblIdOficial.Text = "ToolStripStatusLabel1"
        Me.LblIdOficial.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LblCooperativa)
        Me.Panel1.Controls.Add(Me.PnlCooperativa)
        Me.Panel1.Controls.Add(Me.LblSOCIOS)
        Me.Panel1.Controls.Add(Me.LblEmpleado)
        Me.Panel1.Controls.Add(Me.PnlSOCIOS)
        Me.Panel1.Controls.Add(Me.LblUbicacion)
        Me.Panel1.Controls.Add(Me.PnlEmpleados)
        Me.Panel1.Controls.Add(Me.PnlUbicacion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(109, 600)
        Me.Panel1.TabIndex = 9
        '
        'LblCooperativa
        '
        Me.LblCooperativa.AutoSize = True
        Me.LblCooperativa.BackColor = System.Drawing.Color.Transparent
        Me.LblCooperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCooperativa.ForeColor = System.Drawing.Color.Black
        Me.LblCooperativa.Location = New System.Drawing.Point(4, 481)
        Me.LblCooperativa.Name = "LblCooperativa"
        Me.LblCooperativa.Size = New System.Drawing.Size(94, 13)
        Me.LblCooperativa.TabIndex = 8
        Me.LblCooperativa.Text = "COOPERATIVA"
        Me.LblCooperativa.Visible = False
        '
        'PnlCooperativa
        '
        Me.PnlCooperativa.BackColor = System.Drawing.Color.Transparent
        Me.PnlCooperativa.BackgroundImage = CType(resources.GetObject("PnlCooperativa.BackgroundImage"), System.Drawing.Image)
        Me.PnlCooperativa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlCooperativa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlCooperativa.Location = New System.Drawing.Point(12, 403)
        Me.PnlCooperativa.Name = "PnlCooperativa"
        Me.PnlCooperativa.Size = New System.Drawing.Size(75, 75)
        Me.PnlCooperativa.TabIndex = 7
        '
        'LblSOCIOS
        '
        Me.LblSOCIOS.AutoSize = True
        Me.LblSOCIOS.BackColor = System.Drawing.Color.Transparent
        Me.LblSOCIOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSOCIOS.ForeColor = System.Drawing.Color.Black
        Me.LblSOCIOS.Location = New System.Drawing.Point(18, 294)
        Me.LblSOCIOS.Name = "LblSOCIOS"
        Me.LblSOCIOS.Size = New System.Drawing.Size(53, 13)
        Me.LblSOCIOS.TabIndex = 6
        Me.LblSOCIOS.Text = "SOCIOS"
        Me.LblSOCIOS.Visible = False
        '
        'LblEmpleado
        '
        Me.LblEmpleado.AutoSize = True
        Me.LblEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpleado.ForeColor = System.Drawing.Color.Black
        Me.LblEmpleado.Location = New System.Drawing.Point(9, 387)
        Me.LblEmpleado.Name = "LblEmpleado"
        Me.LblEmpleado.Size = New System.Drawing.Size(82, 13)
        Me.LblEmpleado.TabIndex = 4
        Me.LblEmpleado.Text = "EMPLEADOS"
        Me.LblEmpleado.Visible = False
        '
        'PnlSOCIOS
        '
        Me.PnlSOCIOS.BackColor = System.Drawing.Color.Transparent
        Me.PnlSOCIOS.BackgroundImage = CType(resources.GetObject("PnlSOCIOS.BackgroundImage"), System.Drawing.Image)
        Me.PnlSOCIOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlSOCIOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlSOCIOS.Location = New System.Drawing.Point(9, 216)
        Me.PnlSOCIOS.Name = "PnlSOCIOS"
        Me.PnlSOCIOS.Size = New System.Drawing.Size(75, 75)
        Me.PnlSOCIOS.TabIndex = 5
        '
        'LblUbicacion
        '
        Me.LblUbicacion.AutoSize = True
        Me.LblUbicacion.BackColor = System.Drawing.Color.Transparent
        Me.LblUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacion.ForeColor = System.Drawing.Color.Black
        Me.LblUbicacion.Location = New System.Drawing.Point(12, 575)
        Me.LblUbicacion.Name = "LblUbicacion"
        Me.LblUbicacion.Size = New System.Drawing.Size(74, 13)
        Me.LblUbicacion.TabIndex = 2
        Me.LblUbicacion.Text = "UBICACIÓN"
        Me.LblUbicacion.Visible = False
        '
        'PnlEmpleados
        '
        Me.PnlEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.PnlEmpleados.BackgroundImage = CType(resources.GetObject("PnlEmpleados.BackgroundImage"), System.Drawing.Image)
        Me.PnlEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlEmpleados.Location = New System.Drawing.Point(9, 309)
        Me.PnlEmpleados.Name = "PnlEmpleados"
        Me.PnlEmpleados.Size = New System.Drawing.Size(75, 75)
        Me.PnlEmpleados.TabIndex = 3
        '
        'PnlUbicacion
        '
        Me.PnlUbicacion.BackColor = System.Drawing.Color.Transparent
        Me.PnlUbicacion.BackgroundImage = CType(resources.GetObject("PnlUbicacion.BackgroundImage"), System.Drawing.Image)
        Me.PnlUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlUbicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlUbicacion.Location = New System.Drawing.Point(12, 497)
        Me.PnlUbicacion.Name = "PnlUbicacion"
        Me.PnlUbicacion.Size = New System.Drawing.Size(75, 75)
        Me.PnlUbicacion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENÚ"
        '
        'PnUbicacion2
        '
        Me.PnUbicacion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnUbicacion2.BackgroundImage = CType(resources.GetObject("PnUbicacion2.BackgroundImage"), System.Drawing.Image)
        Me.PnUbicacion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnUbicacion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnUbicacion2.Controls.Add(Me.PnlCiudad)
        Me.PnUbicacion2.Controls.Add(Me.LblCiudad)
        Me.PnUbicacion2.Controls.Add(Me.Lbldepto)
        Me.PnUbicacion2.Controls.Add(Me.LblPais)
        Me.PnUbicacion2.Controls.Add(Me.PnlDepartamento)
        Me.PnUbicacion2.Controls.Add(Me.PnlPais)
        Me.PnUbicacion2.Controls.Add(Me.PnlNacionalidad)
        Me.PnUbicacion2.Controls.Add(Me.LblNacionalidad)
        Me.PnUbicacion2.Location = New System.Drawing.Point(108, 578)
        Me.PnUbicacion2.Name = "PnUbicacion2"
        Me.PnUbicacion2.Size = New System.Drawing.Size(396, 85)
        Me.PnUbicacion2.TabIndex = 11
        Me.PnUbicacion2.Visible = False
        '
        'PnlCiudad
        '
        Me.PnlCiudad.BackColor = System.Drawing.Color.Transparent
        Me.PnlCiudad.BackgroundImage = CType(resources.GetObject("PnlCiudad.BackgroundImage"), System.Drawing.Image)
        Me.PnlCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlCiudad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlCiudad.Location = New System.Drawing.Point(307, 15)
        Me.PnlCiudad.Name = "PnlCiudad"
        Me.PnlCiudad.Size = New System.Drawing.Size(65, 65)
        Me.PnlCiudad.TabIndex = 14
        Me.PnlCiudad.Visible = False
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.BackColor = System.Drawing.Color.Transparent
        Me.LblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.Location = New System.Drawing.Point(311, 2)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(54, 13)
        Me.LblCiudad.TabIndex = 16
        Me.LblCiudad.Text = "CIUDAD"
        Me.LblCiudad.Visible = False
        '
        'Lbldepto
        '
        Me.Lbldepto.AutoSize = True
        Me.Lbldepto.BackColor = System.Drawing.Color.Transparent
        Me.Lbldepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldepto.Location = New System.Drawing.Point(191, 2)
        Me.Lbldepto.Name = "Lbldepto"
        Me.Lbldepto.Size = New System.Drawing.Size(109, 13)
        Me.Lbldepto.TabIndex = 15
        Me.Lbldepto.Text = "DEPARTAMENTO"
        Me.Lbldepto.Visible = False
        '
        'LblPais
        '
        Me.LblPais.AutoSize = True
        Me.LblPais.BackColor = System.Drawing.Color.Transparent
        Me.LblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPais.Location = New System.Drawing.Point(128, 2)
        Me.LblPais.Name = "LblPais"
        Me.LblPais.Size = New System.Drawing.Size(35, 13)
        Me.LblPais.TabIndex = 14
        Me.LblPais.Text = "PAÍS"
        Me.LblPais.Visible = False
        '
        'PnlDepartamento
        '
        Me.PnlDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.PnlDepartamento.BackgroundImage = CType(resources.GetObject("PnlDepartamento.BackgroundImage"), System.Drawing.Image)
        Me.PnlDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlDepartamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlDepartamento.Location = New System.Drawing.Point(215, 15)
        Me.PnlDepartamento.Name = "PnlDepartamento"
        Me.PnlDepartamento.Size = New System.Drawing.Size(65, 65)
        Me.PnlDepartamento.TabIndex = 13
        Me.PnlDepartamento.Visible = False
        '
        'PnlPais
        '
        Me.PnlPais.BackColor = System.Drawing.Color.Transparent
        Me.PnlPais.BackgroundImage = CType(resources.GetObject("PnlPais.BackgroundImage"), System.Drawing.Image)
        Me.PnlPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlPais.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlPais.Location = New System.Drawing.Point(97, 15)
        Me.PnlPais.Name = "PnlPais"
        Me.PnlPais.Size = New System.Drawing.Size(95, 65)
        Me.PnlPais.TabIndex = 12
        Me.PnlPais.Visible = False
        '
        'PnlNacionalidad
        '
        Me.PnlNacionalidad.BackColor = System.Drawing.Color.Transparent
        Me.PnlNacionalidad.BackgroundImage = CType(resources.GetObject("PnlNacionalidad.BackgroundImage"), System.Drawing.Image)
        Me.PnlNacionalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlNacionalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlNacionalidad.Location = New System.Drawing.Point(17, 18)
        Me.PnlNacionalidad.Name = "PnlNacionalidad"
        Me.PnlNacionalidad.Size = New System.Drawing.Size(65, 65)
        Me.PnlNacionalidad.TabIndex = 11
        Me.PnlNacionalidad.Visible = False
        '
        'LblNacionalidad
        '
        Me.LblNacionalidad.AutoSize = True
        Me.LblNacionalidad.BackColor = System.Drawing.Color.Transparent
        Me.LblNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNacionalidad.Location = New System.Drawing.Point(0, 4)
        Me.LblNacionalidad.Name = "LblNacionalidad"
        Me.LblNacionalidad.Size = New System.Drawing.Size(99, 13)
        Me.LblNacionalidad.TabIndex = 12
        Me.LblNacionalidad.Text = "NACIONALIDAD"
        Me.LblNacionalidad.Visible = False
        '
        'PnEmpleados2
        '
        Me.PnEmpleados2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnEmpleados2.BackgroundImage = CType(resources.GetObject("PnEmpleados2.BackgroundImage"), System.Drawing.Image)
        Me.PnEmpleados2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnEmpleados2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnEmpleados2.Controls.Add(Me.LblUsuario)
        Me.PnEmpleados2.Controls.Add(Me.LblCargo)
        Me.PnEmpleados2.Controls.Add(Me.PnlUsuario)
        Me.PnEmpleados2.Controls.Add(Me.LblProfesion)
        Me.PnEmpleados2.Controls.Add(Me.Pnlcargo)
        Me.PnEmpleados2.Controls.Add(Me.PnlProfesion)
        Me.PnEmpleados2.Controls.Add(Me.PnlOficial)
        Me.PnEmpleados2.Controls.Add(Me.LblOficial)
        Me.PnEmpleados2.Location = New System.Drawing.Point(108, 390)
        Me.PnEmpleados2.Name = "PnEmpleados2"
        Me.PnEmpleados2.Size = New System.Drawing.Size(352, 85)
        Me.PnEmpleados2.TabIndex = 17
        Me.PnEmpleados2.Visible = False
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(284, 4)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(63, 13)
        Me.LblUsuario.TabIndex = 17
        Me.LblUsuario.Text = "USUARIO"
        Me.LblUsuario.Visible = False
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.BackColor = System.Drawing.Color.Transparent
        Me.LblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargo.Location = New System.Drawing.Point(197, 4)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(50, 13)
        Me.LblCargo.TabIndex = 15
        Me.LblCargo.Text = "CARGO"
        Me.LblCargo.Visible = False
        '
        'PnlUsuario
        '
        Me.PnlUsuario.BackColor = System.Drawing.Color.Transparent
        Me.PnlUsuario.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.usuario
        Me.PnlUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlUsuario.Location = New System.Drawing.Point(273, 15)
        Me.PnlUsuario.Name = "PnlUsuario"
        Me.PnlUsuario.Size = New System.Drawing.Size(65, 65)
        Me.PnlUsuario.TabIndex = 16
        Me.PnlUsuario.Visible = False
        '
        'LblProfesion
        '
        Me.LblProfesion.AutoSize = True
        Me.LblProfesion.BackColor = System.Drawing.Color.Transparent
        Me.LblProfesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfesion.Location = New System.Drawing.Point(97, 4)
        Me.LblProfesion.Name = "LblProfesion"
        Me.LblProfesion.Size = New System.Drawing.Size(78, 13)
        Me.LblProfesion.TabIndex = 14
        Me.LblProfesion.Text = "PROFESIÓN"
        Me.LblProfesion.Visible = False
        '
        'Pnlcargo
        '
        Me.Pnlcargo.BackColor = System.Drawing.Color.Transparent
        Me.Pnlcargo.BackgroundImage = CType(resources.GetObject("Pnlcargo.BackgroundImage"), System.Drawing.Image)
        Me.Pnlcargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnlcargo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pnlcargo.Location = New System.Drawing.Point(186, 15)
        Me.Pnlcargo.Name = "Pnlcargo"
        Me.Pnlcargo.Size = New System.Drawing.Size(65, 65)
        Me.Pnlcargo.TabIndex = 13
        Me.Pnlcargo.Visible = False
        '
        'PnlProfesion
        '
        Me.PnlProfesion.BackColor = System.Drawing.Color.Transparent
        Me.PnlProfesion.BackgroundImage = CType(resources.GetObject("PnlProfesion.BackgroundImage"), System.Drawing.Image)
        Me.PnlProfesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlProfesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlProfesion.Location = New System.Drawing.Point(102, 15)
        Me.PnlProfesion.Name = "PnlProfesion"
        Me.PnlProfesion.Size = New System.Drawing.Size(65, 65)
        Me.PnlProfesion.TabIndex = 12
        Me.PnlProfesion.Visible = False
        '
        'PnlOficial
        '
        Me.PnlOficial.BackColor = System.Drawing.Color.Transparent
        Me.PnlOficial.BackgroundImage = CType(resources.GetObject("PnlOficial.BackgroundImage"), System.Drawing.Image)
        Me.PnlOficial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlOficial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlOficial.Location = New System.Drawing.Point(16, 15)
        Me.PnlOficial.Name = "PnlOficial"
        Me.PnlOficial.Size = New System.Drawing.Size(65, 65)
        Me.PnlOficial.TabIndex = 11
        Me.PnlOficial.Visible = False
        '
        'LblOficial
        '
        Me.LblOficial.AutoSize = True
        Me.LblOficial.BackColor = System.Drawing.Color.Transparent
        Me.LblOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOficial.Location = New System.Drawing.Point(19, 4)
        Me.LblOficial.Name = "LblOficial"
        Me.LblOficial.Size = New System.Drawing.Size(54, 13)
        Me.LblOficial.TabIndex = 12
        Me.LblOficial.Text = "OFICIAL"
        Me.LblOficial.Visible = False
        '
        'PnSocios2
        '
        Me.PnSocios2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnSocios2.BackgroundImage = CType(resources.GetObject("PnSocios2.BackgroundImage"), System.Drawing.Image)
        Me.PnSocios2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnSocios2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnSocios2.Controls.Add(Me.LblCuenta)
        Me.PnSocios2.Controls.Add(Me.PnlCuenta)
        Me.PnSocios2.Controls.Add(Me.PnlSocio)
        Me.PnSocios2.Controls.Add(Me.LblSocio)
        Me.PnSocios2.Location = New System.Drawing.Point(108, 297)
        Me.PnSocios2.Name = "PnSocios2"
        Me.PnSocios2.Size = New System.Drawing.Size(196, 85)
        Me.PnSocios2.TabIndex = 18
        Me.PnSocios2.Visible = False
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuenta.Location = New System.Drawing.Point(107, 4)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(57, 13)
        Me.LblCuenta.TabIndex = 14
        Me.LblCuenta.Text = "CUENTA"
        Me.LblCuenta.Visible = False
        '
        'PnlCuenta
        '
        Me.PnlCuenta.BackColor = System.Drawing.Color.Transparent
        Me.PnlCuenta.BackgroundImage = CType(resources.GetObject("PnlCuenta.BackgroundImage"), System.Drawing.Image)
        Me.PnlCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlCuenta.Location = New System.Drawing.Point(102, 15)
        Me.PnlCuenta.Name = "PnlCuenta"
        Me.PnlCuenta.Size = New System.Drawing.Size(65, 65)
        Me.PnlCuenta.TabIndex = 12
        Me.PnlCuenta.Visible = False
        '
        'PnlSocio
        '
        Me.PnlSocio.BackColor = System.Drawing.Color.Transparent
        Me.PnlSocio.BackgroundImage = CType(resources.GetObject("PnlSocio.BackgroundImage"), System.Drawing.Image)
        Me.PnlSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlSocio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlSocio.Location = New System.Drawing.Point(16, 16)
        Me.PnlSocio.Name = "PnlSocio"
        Me.PnlSocio.Size = New System.Drawing.Size(65, 65)
        Me.PnlSocio.TabIndex = 11
        Me.PnlSocio.Visible = False
        '
        'LblSocio
        '
        Me.LblSocio.AutoSize = True
        Me.LblSocio.BackColor = System.Drawing.Color.Transparent
        Me.LblSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSocio.Location = New System.Drawing.Point(19, 4)
        Me.LblSocio.Name = "LblSocio"
        Me.LblSocio.Size = New System.Drawing.Size(45, 13)
        Me.LblSocio.TabIndex = 12
        Me.LblSocio.Text = "SOCIO"
        Me.LblSocio.Visible = False
        '
        'PnCooperativa2
        '
        Me.PnCooperativa2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnCooperativa2.BackgroundImage = CType(resources.GetObject("PnCooperativa2.BackgroundImage"), System.Drawing.Image)
        Me.PnCooperativa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnCooperativa2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnCooperativa2.Controls.Add(Me.LblTipoPrestamo)
        Me.PnCooperativa2.Controls.Add(Me.PnlTipoPrestamo)
        Me.PnCooperativa2.Controls.Add(Me.LblTipoCuenta)
        Me.PnCooperativa2.Controls.Add(Me.LblPrestamo)
        Me.PnCooperativa2.Controls.Add(Me.PnlTipoCuenta)
        Me.PnCooperativa2.Controls.Add(Me.PnlPrestamo)
        Me.PnCooperativa2.Controls.Add(Me.PnlAval)
        Me.PnCooperativa2.Controls.Add(Me.LblAval)
        Me.PnCooperativa2.Location = New System.Drawing.Point(108, 484)
        Me.PnCooperativa2.Name = "PnCooperativa2"
        Me.PnCooperativa2.Size = New System.Drawing.Size(396, 85)
        Me.PnCooperativa2.TabIndex = 18
        Me.PnCooperativa2.Visible = False
        '
        'LblTipoPrestamo
        '
        Me.LblTipoPrestamo.AutoSize = True
        Me.LblTipoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoPrestamo.Location = New System.Drawing.Point(256, 4)
        Me.LblTipoPrestamo.Name = "LblTipoPrestamo"
        Me.LblTipoPrestamo.Size = New System.Drawing.Size(129, 13)
        Me.LblTipoPrestamo.TabIndex = 17
        Me.LblTipoPrestamo.Text = "TIPO DE PRESTAMO"
        Me.LblTipoPrestamo.Visible = False
        '
        'PnlTipoPrestamo
        '
        Me.PnlTipoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.PnlTipoPrestamo.BackgroundImage = CType(resources.GetObject("PnlTipoPrestamo.BackgroundImage"), System.Drawing.Image)
        Me.PnlTipoPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTipoPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlTipoPrestamo.Location = New System.Drawing.Point(273, 15)
        Me.PnlTipoPrestamo.Name = "PnlTipoPrestamo"
        Me.PnlTipoPrestamo.Size = New System.Drawing.Size(77, 65)
        Me.PnlTipoPrestamo.TabIndex = 16
        Me.PnlTipoPrestamo.Visible = False
        '
        'LblTipoCuenta
        '
        Me.LblTipoCuenta.AutoSize = True
        Me.LblTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoCuenta.Location = New System.Drawing.Point(170, 4)
        Me.LblTipoCuenta.Name = "LblTipoCuenta"
        Me.LblTipoCuenta.Size = New System.Drawing.Size(111, 13)
        Me.LblTipoCuenta.TabIndex = 15
        Me.LblTipoCuenta.Text = "TIPO DE CUENTA"
        Me.LblTipoCuenta.Visible = False
        '
        'LblPrestamo
        '
        Me.LblPrestamo.AutoSize = True
        Me.LblPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.LblPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrestamo.Location = New System.Drawing.Point(97, 4)
        Me.LblPrestamo.Name = "LblPrestamo"
        Me.LblPrestamo.Size = New System.Drawing.Size(75, 13)
        Me.LblPrestamo.TabIndex = 14
        Me.LblPrestamo.Text = "PRÉSTAMO"
        Me.LblPrestamo.Visible = False
        '
        'PnlTipoCuenta
        '
        Me.PnlTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.PnlTipoCuenta.BackgroundImage = CType(resources.GetObject("PnlTipoCuenta.BackgroundImage"), System.Drawing.Image)
        Me.PnlTipoCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTipoCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlTipoCuenta.Location = New System.Drawing.Point(186, 15)
        Me.PnlTipoCuenta.Name = "PnlTipoCuenta"
        Me.PnlTipoCuenta.Size = New System.Drawing.Size(65, 65)
        Me.PnlTipoCuenta.TabIndex = 13
        Me.PnlTipoCuenta.Visible = False
        '
        'PnlPrestamo
        '
        Me.PnlPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.PnlPrestamo.BackgroundImage = CType(resources.GetObject("PnlPrestamo.BackgroundImage"), System.Drawing.Image)
        Me.PnlPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlPrestamo.Location = New System.Drawing.Point(102, 15)
        Me.PnlPrestamo.Name = "PnlPrestamo"
        Me.PnlPrestamo.Size = New System.Drawing.Size(65, 65)
        Me.PnlPrestamo.TabIndex = 12
        Me.PnlPrestamo.Visible = False
        '
        'PnlAval
        '
        Me.PnlAval.BackColor = System.Drawing.Color.Transparent
        Me.PnlAval.BackgroundImage = CType(resources.GetObject("PnlAval.BackgroundImage"), System.Drawing.Image)
        Me.PnlAval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlAval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlAval.Location = New System.Drawing.Point(16, 16)
        Me.PnlAval.Name = "PnlAval"
        Me.PnlAval.Size = New System.Drawing.Size(65, 65)
        Me.PnlAval.TabIndex = 11
        Me.PnlAval.Visible = False
        '
        'LblAval
        '
        Me.LblAval.AutoSize = True
        Me.LblAval.BackColor = System.Drawing.Color.Transparent
        Me.LblAval.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAval.Location = New System.Drawing.Point(29, 4)
        Me.LblAval.Name = "LblAval"
        Me.LblAval.Size = New System.Drawing.Size(38, 13)
        Me.LblAval.TabIndex = 12
        Me.LblAval.Text = "AVAL"
        Me.LblAval.Visible = False
        '
        'PnlLogo
        '
        Me.PnlLogo.BackColor = System.Drawing.Color.White
        Me.PnlLogo.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.CapturaQ3
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlLogo.Controls.Add(Me.PictureBox2)
        Me.PnlLogo.Location = New System.Drawing.Point(424, 240)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(644, 278)
        Me.PnlLogo.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.LOGO11
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(644, 278)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.LOGO11
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(4, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 189)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PnlLogo1
        '
        Me.PnlLogo1.BackColor = System.Drawing.Color.Transparent
        Me.PnlLogo1.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.CapturaQ2
        Me.PnlLogo1.Controls.Add(Me.PictureBox1)
        Me.PnlLogo1.Location = New System.Drawing.Point(111, 90)
        Me.PnlLogo1.Name = "PnlLogo1"
        Me.PnlLogo1.Size = New System.Drawing.Size(393, 201)
        Me.PnlLogo1.TabIndex = 17
        Me.PnlLogo1.Visible = False
        '
        'PbSalir
        '
        Me.PbSalir.BackColor = System.Drawing.Color.LightGray
        Me.PbSalir.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.Logout_37127
        Me.PbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbSalir.Location = New System.Drawing.Point(1222, 26)
        Me.PbSalir.Name = "PbSalir"
        Me.PbSalir.Size = New System.Drawing.Size(37, 34)
        Me.PbSalir.TabIndex = 20
        Me.PbSalir.TabStop = False
        '
        'PbCambioSesion
        '
        Me.PbCambioSesion.BackColor = System.Drawing.Color.LightGray
        Me.PbCambioSesion.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.salir
        Me.PbCambioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbCambioSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbCambioSesion.InitialImage = Nothing
        Me.PbCambioSesion.Location = New System.Drawing.Point(1179, 27)
        Me.PbCambioSesion.Name = "PbCambioSesion"
        Me.PbCambioSesion.Size = New System.Drawing.Size(37, 34)
        Me.PbCambioSesion.TabIndex = 22
        Me.PbCambioSesion.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.barra3
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(0, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1363, 22)
        Me.Panel3.TabIndex = 28
        '
        'LblSalir
        '
        Me.LblSalir.AutoSize = True
        Me.LblSalir.BackColor = System.Drawing.Color.Transparent
        Me.LblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalir.Location = New System.Drawing.Point(1211, 5)
        Me.LblSalir.Name = "LblSalir"
        Me.LblSalir.Size = New System.Drawing.Size(54, 18)
        Me.LblSalir.TabIndex = 30
        Me.LblSalir.Text = "SALIR"
        Me.LblSalir.Visible = False
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.BackColor = System.Drawing.Color.Transparent
        Me.LblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.Location = New System.Drawing.Point(1104, 5)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(167, 18)
        Me.LblCambio.TabIndex = 31
        Me.LblCambio.Text = "CAMBIO DE SESIÓN"
        Me.LblCambio.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Blue
        Me.PictureBox3.Image = Global.ProyectoCOOPERATIVA.My.Resources.Resources.logo_SysCAp3
        Me.PictureBox3.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.ProyectoCOOPERATIVA.My.Resources.Resources.FONDO1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1345, 654)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LblCambio)
        Me.Controls.Add(Me.LblSalir)
        Me.Controls.Add(Me.PbSalir)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PbCambioSesion)
        Me.Controls.Add(Me.PnlLogo1)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.PnCooperativa2)
        Me.Controls.Add(Me.PnSocios2)
        Me.Controls.Add(Me.PnEmpleados2)
        Me.Controls.Add(Me.PnUbicacion2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "PantallaPrincipal"
        Me.Text = "PantallaPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnUbicacion2.ResumeLayout(False)
        Me.PnUbicacion2.PerformLayout()
        Me.PnEmpleados2.ResumeLayout(False)
        Me.PnEmpleados2.PerformLayout()
        Me.PnSocios2.ResumeLayout(False)
        Me.PnSocios2.PerformLayout()
        Me.PnCooperativa2.ResumeLayout(False)
        Me.PnCooperativa2.PerformLayout()
        Me.PnlLogo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLogo1.ResumeLayout(False)
        CType(Me.PbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbCambioSesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents LblOficialNombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlUbicacion As Panel
    Friend WithEvents LblUbicacion As Label
    Friend WithEvents PnUbicacion2 As Panel
    Friend WithEvents PnlNacionalidad As Panel
    Friend WithEvents LblNacionalidad As Label
    Friend WithEvents PnlCiudad As Panel
    Friend WithEvents LblCiudad As Label
    Friend WithEvents Lbldepto As Label
    Friend WithEvents LblPais As Label
    Friend WithEvents PnlDepartamento As Panel
    Friend WithEvents PnlPais As Panel
    Friend WithEvents LblEmpleado As Label
    Friend WithEvents PnlEmpleados As Panel
    Friend WithEvents PnEmpleados2 As Panel
    Friend WithEvents LblCargo As Label
    Friend WithEvents LblProfesion As Label
    Friend WithEvents Pnlcargo As Panel
    Friend WithEvents PnlProfesion As Panel
    Friend WithEvents PnlOficial As Panel
    Friend WithEvents LblOficial As Label
    Friend WithEvents LblCooperativa As Label
    Friend WithEvents PnlCooperativa As Panel
    Friend WithEvents LblSOCIOS As Label
    Friend WithEvents PnlSOCIOS As Panel
    Friend WithEvents PnSocios2 As Panel
    Friend WithEvents LblCuenta As Label
    Friend WithEvents PnlCuenta As Panel
    Friend WithEvents PnlSocio As Panel
    Friend WithEvents LblSocio As Label
    Friend WithEvents PnCooperativa2 As Panel
    Friend WithEvents LblTipoPrestamo As Label
    Friend WithEvents PnlTipoPrestamo As Panel
    Friend WithEvents LblTipoCuenta As Label
    Friend WithEvents LblPrestamo As Label
    Friend WithEvents PnlTipoCuenta As Panel
    Friend WithEvents PnlPrestamo As Panel
    Friend WithEvents PnlAval As Panel
    Friend WithEvents LblAval As Label
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlLogo1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PbSalir As PictureBox
    Friend WithEvents PbCambioSesion As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblSalir As Label
    Friend WithEvents LblCambio As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents PnlUsuario As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblIdOficial As ToolStripStatusLabel
End Class
