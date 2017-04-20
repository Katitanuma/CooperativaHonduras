Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmCargo
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub CARGO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
                         FrmProfesion, FrmTipodeCuenta, FrmTipoPrestamo, FrmAval, FrmCuenta,
                         FrmOficial, FrmPrestamo, FrmSocio, FrmUsuario)
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

    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlCargo.Enabled = Panel
    End Sub

    Private Sub MostrarTodoCargo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim AdaptadorCargo As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorCargo.Fill(Dt)
                DgvCargo.DataSource = Dt
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de cargo " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub Limpiar()
        TxtCodigoCargo.Text = ""
        TxtCargo.Text = ""
    End Sub

    Private Sub FrmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Limpiar()
        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoCargo()
    End Sub

    Private Sub InvestigarCorrelativoCargo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoCargo.Text = 1
                    Else
                        TxtCodigoCargo.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteNombreCargo() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Cargo", SqlDbType.NVarChar, 50).Value = TxtCargo.Text.Trim
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

    Private Function ValidarCargo()
        Dim Estado As Boolean
        If TxtCodigoCargo.Text = "" Then
            MessageBox.Show("Ingrese el nombre del cargo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCodigoCargo.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub GuardarCargo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Cargo", SqlDbType.NVarChar, 50).Value = TxtCargo.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cargo almacenado con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al almacenar el cargo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarCargo() = True Then
            If ExisteNombreCargo() = False Then
                Call GuardarCargo()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCargo()
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado ese cargo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtCargo.Text = ""
                TxtCargo.Focus()
            End If
        End If
    End Sub

    Private Sub EditarCargo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdCargo", SqlDbType.Int).Value = CInt(TxtCodigoCargo.Text)
                    .Parameters.Add("@Cargo", SqlDbType.NVarChar, 50).Value = TxtCargo.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cargo modificado con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al modificar el cargo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarCargo() = True Then
            If ExisteNombreCargo() = False Then
                Call EditarCargo()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCargo()
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado ese cargo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtCargo.Text = ""
                TxtCargo.Focus()
            End If
        End If
    End Sub

    Private Sub EliminarCargo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdCargo", SqlDbType.Int).Value = CInt(DgvCargo.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cargo eliminado con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el cargo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "SYS CAP",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarCargo()
            Call MostrarTodoCargo()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TbcCargo.SelectedIndex = 0
        TxtCodigoCargo.Text = DgvCargo.CurrentRow.Cells(0).Value
        TxtCargo.Text = DgvCargo.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call Limpiar()
        Call InvestigarCorrelativoCargo()
        Call HabilitarControles(False, True, False, True, True)
        TxtCargo.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call Limpiar()
        Call HabilitarControles(True, False, False, False, False)
    End Sub

    Private Sub BusquedaFiltradaCargo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@ParametroCargo", SqlDbType.NVarChar, 50).Value = TxtBusquedaCargo.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvCargo.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBusquedaCargo_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaCargo.TextChanged
        If TxtBusquedaCargo.Text = Nothing Then
            MostrarTodoCargo()
        Else
            BusquedaFiltradaCargo()
        End If
    End Sub
End Class