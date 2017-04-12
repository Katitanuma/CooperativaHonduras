Imports System.Windows.Forms

Public Class PantallaPrincipal
    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlLogo.BringToFront()
    End Sub

    Private Sub PnUbicacion_MouseHover(sender As Object, e As EventArgs) Handles PnlUbicacion.MouseHover
        PnlUbicacion.Size = New Size(80, 80)
        LblUbicacion.Visible = True
    End Sub

    Private Sub PnUbicacion_MouseLeave(sender As Object, e As EventArgs) Handles PnlUbicacion.MouseLeave
        PnlUbicacion.Size = New Size(75, 75)
        LblUbicacion.Visible = False
    End Sub

    Private Sub PnUbicacion_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlUbicacion.MouseClick
        If PnUbicacion2.Visible = True Then
            PnUbicacion2.Visible = False
            PnlNacionalidad.Visible = False
            PnlPais.Visible = False
            PnlDepartamento.Visible = False
            PnlCiudad.Visible = False
        Else
            PnUbicacion2.Visible = True
            PnlNacionalidad.Visible = True
            LblNacionalidad.Visible = False
            PnlPais.Visible = True
            PnlDepartamento.Visible = True
            PnlCiudad.Visible = True
        End If
    End Sub

    Private Sub PnNacionalidad_MouseHover(sender As Object, e As EventArgs) Handles PnlNacionalidad.MouseHover
        LblNacionalidad.Visible = True
    End Sub

    Private Sub PnNacionalidad_MouseLeave(sender As Object, e As EventArgs) Handles PnlNacionalidad.MouseLeave
        LblNacionalidad.Visible = False
    End Sub

    Private Sub PnPais_MouseHover(sender As Object, e As EventArgs) Handles PnlPais.MouseHover
        LblPais.Visible = True
    End Sub

    Private Sub PnPais_MouseLeave(sender As Object, e As EventArgs) Handles PnlPais.MouseLeave
        LblPais.Visible = False
    End Sub

    Private Sub PnDepartamento_MouseHover(sender As Object, e As EventArgs) Handles PnlDepartamento.MouseHover
        Lbldepto.Visible = True
    End Sub

    Private Sub PnDepartamento_MouseLeave(sender As Object, e As EventArgs) Handles PnlDepartamento.MouseLeave
        Lbldepto.Visible = False
    End Sub

    Private Sub PnCiudad_MouseHover(sender As Object, e As EventArgs) Handles PnlCiudad.MouseHover
        LblCiudad.Visible = True
    End Sub

    Private Sub PnCiudad_MouseLeave(sender As Object, e As EventArgs) Handles PnlCiudad.MouseLeave
        LblCiudad.Visible = False
    End Sub

    Private Sub PnEmpleados_MouseHover(sender As Object, e As EventArgs) Handles PnlEmpleados.MouseHover
        PnlEmpleados.Size = New Size(80, 80)
        LblEmpleado.Visible = True
    End Sub

    Private Sub PnEmpleados_MouseLeave(sender As Object, e As EventArgs) Handles PnlEmpleados.MouseLeave
        PnlEmpleados.Size = New Size(75, 75)
        LblEmpleado.Visible = False
    End Sub

    Private Sub PnOficial_MouseHover(sender As Object, e As EventArgs) Handles PnlOficial.MouseHover
        LblOficial.Visible = True
    End Sub

    Private Sub PnOficial_MouseLeave(sender As Object, e As EventArgs) Handles PnlOficial.MouseLeave
        LblOficial.Visible = False
    End Sub

    Private Sub PnProfesion_MouseHover(sender As Object, e As EventArgs) Handles PnlProfesion.MouseHover
        LblProfesion.Visible = True
    End Sub

    Private Sub PnProfesion_MouseLeave(sender As Object, e As EventArgs) Handles PnlProfesion.MouseLeave
        LblProfesion.Visible = False
    End Sub

    Private Sub Pncargo_MouseHover(sender As Object, e As EventArgs) Handles Pnlcargo.MouseHover
        LblCargo.Visible = True
    End Sub

    Private Sub Pncargo_MouseLeave(sender As Object, e As EventArgs) Handles Pnlcargo.MouseLeave
        LblCargo.Visible = False
    End Sub

    Private Sub PnEmpleados_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlEmpleados.MouseClick
        If PnEmpleados2.Visible = True Then
            PnEmpleados2.Visible = False
            PnlProfesion.Visible = False
            Pnlcargo.Visible = False
            PnlOficial.Visible = False
        Else
            LblEmpleado.Visible = True
            PnEmpleados2.Visible = True
            PnlProfesion.Visible = True
            Pnlcargo.Visible = True
            PnlOficial.Visible = True
        End If
    End Sub

    Private Sub PnSOCIOS_MouseHover(sender As Object, e As EventArgs) Handles PnlSOCIOS.MouseHover
        PnlSOCIOS.Size = New Size(80, 80)
        LblSOCIOS.Visible = True
    End Sub

    Private Sub PnSOCIOS_MouseLeave(sender As Object, e As EventArgs) Handles PnlSOCIOS.MouseLeave
        PnlSOCIOS.Size = New Size(75, 75)
        LblSOCIOS.Visible = False
    End Sub

    Private Sub PnSocio_MouseHover(sender As Object, e As EventArgs) Handles PnlSocio.MouseHover
        LblSocio.Visible = True
    End Sub

    Private Sub PnSocio_MouseLeave(sender As Object, e As EventArgs) Handles PnlSocio.MouseLeave
        LblSocio.Visible = False
    End Sub

    Private Sub PnCuenta_MouseHover(sender As Object, e As EventArgs) Handles PnlCuenta.MouseHover
        LblCuenta.Visible = True
    End Sub

    Private Sub PnCuenta_MouseLeave(sender As Object, e As EventArgs) Handles PnlCuenta.MouseLeave
        LblCuenta.Visible = False
    End Sub

    Private Sub PnSOCIOS_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlSOCIOS.MouseClick
        If PnSocios2.Visible = True Then
            PnSocios2.Visible = False
            PnlSocio.Visible = False
            PnlCuenta.Visible = False

        Else
            PnSocios2.Visible = True
            PnlSocio.Visible = True
            PnlCuenta.Visible = True
        End If
    End Sub

    Private Sub PnCooperativa_MouseHover(sender As Object, e As EventArgs) Handles PnlCooperativa.MouseHover
        PnlCooperativa.Size = New Size(80, 80)
        LblCooperativa.Visible = True
    End Sub

    Private Sub PnCooperativa_MouseLeave(sender As Object, e As EventArgs) Handles PnlCooperativa.MouseLeave
        PnlCooperativa.Size = New Size(75, 75)
        LblCooperativa.Visible = False
    End Sub

    Private Sub PnAval_MouseHover(sender As Object, e As EventArgs) Handles PnlAval.MouseHover
        LblAval.Visible = True
    End Sub

    Private Sub PnAval_MouseLeave(sender As Object, e As EventArgs) Handles PnlAval.MouseLeave
        LblAval.Visible = False
    End Sub

    Private Sub PnPrestamo_MouseHover(sender As Object, e As EventArgs) Handles PnlPrestamo.MouseHover
        LblPrestamo.Visible = True
    End Sub

    Private Sub PnPrestamo_MouseLeave(sender As Object, e As EventArgs) Handles PnlPrestamo.MouseLeave
        LblPrestamo.Visible = False
    End Sub

    Private Sub PnTipoCuenta_MouseHover(sender As Object, e As EventArgs) Handles PnlTipoCuenta.MouseHover
        LblTipoCuenta.Visible = True
    End Sub

    Private Sub PnTipoCuenta_MouseLeave(sender As Object, e As EventArgs) Handles PnlTipoCuenta.MouseLeave
        LblTipoCuenta.Visible = False
    End Sub

    Private Sub PnTipoPrestamo_MouseHover(sender As Object, e As EventArgs) Handles PnlTipoPrestamo.MouseHover
        LblTipoPrestamo.Visible = True
    End Sub

    Private Sub PnTipoPrestamo_MouseLeave(sender As Object, e As EventArgs) Handles PnlTipoPrestamo.MouseLeave
        LblTipoPrestamo.Visible = False
    End Sub

    Private Sub PnCooperativa_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlCooperativa.MouseClick
        If PnCooperativa2.Visible = True Then
            PnCooperativa2.Visible = False
            PnlAval.Visible = False
            PnlPrestamo.Visible = False
            PnlTipoCuenta.Visible = False
            PnlTipoPrestamo.Visible = False
        Else
            PnCooperativa2.Visible = True
            PnCooperativa2.BringToFront()
            PnlAval.Visible = True
            PnlPrestamo.Visible = True
            PnlTipoCuenta.Visible = True
            PnlTipoPrestamo.Visible = True

        End If
    End Sub

    Private Sub PnSocio_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlSocio.MouseClick

        Dim MiSocio As New FrmSocio
        MiSocio.MdiParent = Me
        MiSocio.Show()
        MiSocio.Location = New Point(550, 60)
        MiSocio.BringToFront()
        PnlLogo.SendToBack()
        PnlLogo1.Visible = True
        PnSocios2.Visible = False
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnUbicacion2.Visible = False


    End Sub

    Private Sub PnCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlCuenta.MouseClick
        Dim MiCuenta As New FrmCuenta
        MiCuenta.MdiParent = Me
        MiCuenta.Show()
        MiCuenta.Location = New Point(550, 60)
        MiCuenta.BringToFront()
        PnlLogo.SendToBack()
        PnSocios2.Visible = False
        PnlLogo1.Visible = True
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnUbicacion2.Visible = False


    End Sub

    Private Sub PnOficial_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlOficial.MouseClick
        Dim MiOficial As New FrmOficial
        MiOficial.MdiParent = Me
        MiOficial.Show()
        MiOficial.Location = New Point(550, 60)
        MiOficial.BringToFront()
        PnlLogo.SendToBack()
        PnlLogo1.Visible = True
        PnSocios2.Visible = False
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnUbicacion2.Visible = False
    End Sub

    Private Sub PnProfesion_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlProfesion.MouseClick
        Dim MiProfesion As New FrmProfesion
        MiProfesion.MdiParent = Me
        MiProfesion.Show()
        MiProfesion.Location = New Point(550, 60)
        MiProfesion.BringToFront()
        PnlLogo.SendToBack()
        PnEmpleados2.Visible = False
        PnSocios2.Visible = False
        PnCooperativa2.Visible = False
        PnUbicacion2.Visible = False
    End Sub

    Private Sub Pncargo_MouseClick(sender As Object, e As MouseEventArgs) Handles Pnlcargo.MouseClick
        Dim MiCargo As New CARGO
        MiCargo.MdiParent = Me
        MiCargo.Show()
        MiCargo.Location = New Point(550, 60)
        MiCargo.BringToFront()
        PnlLogo.SendToBack()
        PnEmpleados2.Visible = False
        PnSocios2.Visible = False
        PnCooperativa2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PnAval_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlAval.MouseClick
        Dim MiAval As New AVAL
        MiAval.MdiParent = Me
        MiAval.Show()
        MiAval.Location = New Point(550, 60)
        MiAval.BringToFront()
        PnlLogo.SendToBack()
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnSocios2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PnPrestamo_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlPrestamo.MouseClick
        Dim MiPrestamo As New PRESTAMO
        MiPrestamo.MdiParent = Me
        MiPrestamo.Show()
        MiPrestamo.Location = New Point(550, 60)
        MiPrestamo.BringToFront()
        PnlLogo.SendToBack()
        PnCooperativa2.Visible = False
        PnEmpleados2.Visible = False
        PnSocios2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PnTipoCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlTipoCuenta.MouseClick
        Dim MiTipoCuenta As New TipodeCuenta
        MiTipoCuenta.MdiParent = Me
        MiTipoCuenta.Show()
        MiTipoCuenta.Location = New Point(550, 60)
        MiTipoCuenta.BringToFront()
        PnlLogo.SendToBack()
        PnCooperativa2.Visible = False
        PnEmpleados2.Visible = False
        PnSocios2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PnTipoPrestamo_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlTipoPrestamo.MouseClick
        Dim MiTipoPrestamo As New TipoPrestamo
        MiTipoPrestamo.MdiParent = Me
        MiTipoPrestamo.Show()
        MiTipoPrestamo.Location = New Point(550, 60)
        MiTipoPrestamo.BringToFront()
        PnlLogo.SendToBack()
        PnCooperativa2.Visible = False
        PnEmpleados2.Visible = False
        PnSocios2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PnNacionalidad_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlNacionalidad.MouseClick
        Dim MiNacionalidad As New NACIONALIDAD
        MiNacionalidad.MdiParent = Me
        MiNacionalidad.Show()
        MiNacionalidad.Location = New Point(550, 60)
        MiNacionalidad.BringToFront()
        PnlLogo.SendToBack()
        PnUbicacion2.Visible = False
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnSocios2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PnPais_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlPais.MouseClick
        Dim MiPais As New PAIS
        MiPais.MdiParent = Me
        MiPais.Show()
        MiPais.Location = New Point(550, 60)
        MiPais.BringToFront()
        PnlLogo.SendToBack()
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnSocios2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PnDepartamento_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlDepartamento.MouseClick
        Dim MiDepto As New DEPARTAMENTO
        MiDepto.MdiParent = Me
        MiDepto.Show()
        MiDepto.Location = New Point(550, 60)
        MiDepto.BringToFront()
        PnlLogo.SendToBack()
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnSocios2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub

    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub PbSalir_MouseHover(sender As Object, e As EventArgs) Handles PbSalir.MouseHover
        LblSalir.Visible = True
    End Sub

    Private Sub PbCambioSesion_MouseHover(sender As Object, e As EventArgs) Handles PbCambioSesion.MouseHover
        LblCambio.Visible = True
    End Sub

    Private Sub PbSalir_MouseLeave(sender As Object, e As EventArgs) Handles PbSalir.MouseLeave
        LblSalir.Visible = False
    End Sub

    Private Sub PbCambioSesion_MouseLeave(sender As Object, e As EventArgs) Handles PbCambioSesion.MouseLeave
        LblCambio.Visible = False
    End Sub

    Private Sub PnlCiudad_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlCiudad.MouseClick
        Dim MiCiudad As New CIUDAD
        MiCiudad.MdiParent = Me
        MiCiudad.Show()
        MiCiudad.Location = New Point(550, 60)
        MiCiudad.BringToFront()
        PnlLogo.SendToBack()
        PnEmpleados2.Visible = False
        PnCooperativa2.Visible = False
        PnSocios2.Visible = False
        PnUbicacion2.Visible = False
        PnlLogo1.Visible = True
    End Sub
End Class
