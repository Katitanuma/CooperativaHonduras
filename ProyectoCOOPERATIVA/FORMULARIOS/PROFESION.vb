Imports System.ComponentModel

Public Class FrmProfesion
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub
    Private Sub FrmProfesion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PantallaPrincipal.PnlLogo.BringToFront()
        PantallaPrincipal.PnlLogo1.Visible = False
    End Sub

    Private Sub BtnNuevo_MouseHover_1(sender As Object, e As EventArgs)
        LblNuevo.Visible = True
    End Sub

    Private Sub BtnNuevo_MouseLeave(sender As Object, e As EventArgs)
        LblNuevo.Visible = False
    End Sub

    Private Sub BtnGuardar_MouseHover(sender As Object, e As EventArgs)
        LblGuardar.Visible = True
    End Sub

    Private Sub BtnGuardar_MouseLeave(sender As Object, e As EventArgs)
        LblGuardar.Visible = False
    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs)
        LblModificar.Visible = True
    End Sub

    Private Sub BtnModificar_MouseLeave(sender As Object, e As EventArgs)
        LblModificar.Visible = False
    End Sub

    Private Sub BtnCancelar_MouseHover(sender As Object, e As EventArgs)
        LblCancelar.Visible = True
    End Sub

    Private Sub BtnCancelar_MouseLeave(sender As Object, e As EventArgs)
        LblCancelar.Visible = False
    End Sub
End Class