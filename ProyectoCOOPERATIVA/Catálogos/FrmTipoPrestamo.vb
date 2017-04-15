Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmTipoPrestamo
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub TipoPrestamo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
                       FrmProfesion, FrmTipodeCuenta, FrmAval, FrmCargo, FrmCuenta,
                       FrmOficial, FrmPrestamo, FrmSocio, FrmUsuario)
    End Sub
    Private Sub FrmTipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodoTipoPrestamo()
        Call Limpiar()
    End Sub
    Private Sub BtnNuevo_MouseHover_1(sender As Object, e As EventArgs) Handles BtnNuevo.MouseHover
        LblNuevo.Visible = True
    End Sub

    Private Sub BtnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles BtnNuevo.MouseLeave
        LblNuevo.Visible = False
    End Sub

    Private Sub BtnGuardar_MouseHover(sender As Object, e As EventArgs) Handles BtnGuardar.MouseHover
        LblGuardar.Visible = True
    End Sub

    Private Sub BtnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles BtnGuardar.MouseLeave
        LblGuardar.Visible = False
    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover
        LblModificar.Visible = True
    End Sub

    Private Sub BtnModificar_MouseLeave(sender As Object, e As EventArgs) Handles BtnModificar.MouseLeave
        LblModificar.Visible = False
    End Sub

    Private Sub BtnCancelar_MouseHover(sender As Object, e As EventArgs) Handles BtnCancelar.MouseHover
        LblCancelar.Visible = True
    End Sub

    Private Sub BtnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancelar.MouseLeave
        LblCancelar.Visible = False
    End Sub
    Private Function ValidarTipoPrestamo() As Boolean
        Dim Estado As Boolean
        If TxtTipoPrestamo.Text = Nothing Then
            MsgBox("Ingrese el Tipo de prestamo", MsgBoxStyle.Critical, "Control Keeper")
            TxtTipoPrestamo.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub GuardarTipoPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 50).Value = TxtTipoPrestamo.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Prestamo Registrado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el prestamo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EditarTipoPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(TxtCodigoTipoPrestamo.Text)
                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 50).Value = TxtTipoPrestamo.Text.Trim

                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Prestamo editado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar el prestamo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarTipoPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(DgvTipoPrestamo.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Prestao eliminado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el prestamo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub MostrarTodoTipoPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorUsuario.Fill(dt)
                DgvTipoPrestamo.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos del prestamo " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub InvestigarCorrelativoTipoPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoTipoPrestamo.Text = 1
                    Else
                        TxtCodigoTipoPrestamo.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteTipoPrestamo() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 50).Value = TxtTipoPrestamo.Text.Trim
                End With
                Dim Existe As Integer = cmd.ExecuteScalar
                If Existe = 0 Then
                    Valor = False
                Else
                    Valor = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
        Return Valor
    End Function

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodigoTipoPrestamo.Text = DgvTipoPrestamo.CurrentRow.Cells(0).Value
        TxtTipoPrestamo.Text = DgvTipoPrestamo.CurrentRow.Cells(1).Value.ToString
        Call HabilitarControles(False, False, True, True, True)
        TabPage1.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarTipoPrestamo()
            Call MostrarTodoTipoPrestamo()
        End If
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlTipoPrestamo.Enabled = Panel
    End Sub
    Private Sub Limpiar()
        TxtCodigoTipoPrestamo.Clear()
        TxtTipoPrestamo.Clear()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoTipoPrestamo()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTipoPrestamo() = True Then
            If ExisteTipoPrestamo() = False Then
                Call GuardarTipoPrestamo()
                Call MostrarTodoTipoPrestamo()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado este prestamo", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTipoPrestamo() = True Then
            Call EditarTipoPrestamo()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodoTipoPrestamo()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
End Class