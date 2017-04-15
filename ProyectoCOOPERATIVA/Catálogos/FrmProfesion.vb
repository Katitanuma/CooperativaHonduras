Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmProfesion
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub
    Private Sub FrmProfesion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
                       FrmAval, FrmTipodeCuenta, FrmTipoPrestamo, FrmCargo, FrmCuenta,
                       FrmOficial, FrmPrestamo, FrmSocio, FrmUsuario)
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

    Private Sub FrmProfesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodoProfesion()
        Call Limpiar()
    End Sub
    Private Function ValidarProfesion() As Boolean
        Dim Estado As Boolean
        If TxtProfesion.Text = Nothing Then
            MsgBox("Ingrese el Tipo de prestamo", MsgBoxStyle.Critical, "Control Keeper")
            TxtProfesion.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub GuardarProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 50).Value = TxtProfesion.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Profesion Registrada con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar la profesion " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EditarProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CInt(TxtCodigoProfesion.Text)
                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 50).Value = TxtProfesion.Text.Trim

                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Profesion editada con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar la profesion " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CInt(DgvProfesion.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Profesion eliminada con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la profesion " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub MostrarTodoProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorUsuario.Fill(dt)
                DgvProfesion.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de la profesion " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub InvestigarCorrelativoProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoProfesion.Text = 1
                    Else
                        TxtCodigoProfesion.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteProfesion() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 50).Value = TxtProfesion.Text.Trim
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
        TxtCodigoProfesion.Text = DgvProfesion.CurrentRow.Cells(0).Value
        TxtProfesion.Text = DgvProfesion.CurrentRow.Cells(1).Value.ToString
        Call HabilitarControles(False, False, True, True, True)
        TabPage1.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarProfesion()
            Call MostrarTodoProfesion()
        End If
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlProfesion.Enabled = Panel
    End Sub
    Private Sub Limpiar()
        TxtCodigoProfesion.Clear()
        TxtProfesion.Clear()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoProfesion()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarProfesion() = True Then
            If ExisteProfesion() = False Then
                Call GuardarProfesion()
                Call MostrarTodoProfesion()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado esta profesion", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarProfesion() = True Then
            Call EditarProfesion()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodoProfesion()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
End Class