Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmTipodeCuenta
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()

    End Sub

    Private Sub TipodeCuenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
                       FrmProfesion, FrmAval, FrmTipoPrestamo, FrmCargo, FrmCuenta,
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

    Private Function ValidarTipoCuenta() As Boolean
        Dim Estado As Boolean
        If TxtTipoCuenta.Text = Nothing Then
            MsgBox("Ingrese el Tipo de Cuenta", MsgBoxStyle.Critical, "Control Keeper")
            TxtTipoCuenta.Focus()
            Estado = False
        ElseIf TxtDescripcion.Text = Nothing Then
            MsgBox("Ingrese la descripcion de Cuenta", MsgBoxStyle.Critical, "Control Keeper")
            TxtDescripcion.Focus()
            Estado = False

        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub GuardarTipoCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@TipoCuenta", SqlDbType.NVarChar, 50).Value = TxtTipoCuenta.Text.Trim
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 150).Value = TxtDescripcion.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cuenta Registrada con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar la cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EditarTipoCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CInt(TxtCodigoTipoCuenta.Text)
                    .Parameters.Add("@TipoCuenta", SqlDbType.NVarChar, 50).Value = TxtTipoCuenta.Text.Trim
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50).Value = TxtDescripcion.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cuenta editada con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar la cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarTipoCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CInt(DgvTipoCuenta.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cuenta eliminada con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub MostrarTodoTipoCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorUsuario.Fill(dt)
                DgvTipoCuenta.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de la cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarTipoCuenta()
            Call MostrarTodoTipoCuenta()
        End If
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlTipoCuenta.Enabled = panel
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TabPage1.Show()
        TxtCodigoTipoCuenta.Text = DgvTipoCuenta.CurrentRow.Cells(0).Value
        TxtTipoCuenta.Text = DgvTipoCuenta.CurrentRow.Cells(1).Value.ToString
        TxtDescripcion.Text = DgvTipoCuenta.CurrentRow.Cells(2).Value.ToString
        Call HabilitarControles(False, False, True, True, True)
    End Sub
    Private Sub InvestigarCorrelativoTipoCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoTipoCuenta.Text = 1
                    Else
                        TxtCodigoTipoCuenta.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteTipoCuenta() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@TipoCuenta", SqlDbType.NVarChar, 50).Value = TxtTipoCuenta.Text.Trim
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
    Private Sub Limpiar()
        TxtCodigoTipoCuenta.Clear()
        TxtTipoCuenta.Clear()
        TxtDescripcion.Clear()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoTipoCuenta()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTipoCuenta() = True Then
            If ExisteTipoCuenta() = False Then
                Call GuardarTipoCuenta()
                Call MostrarTodoTipoCuenta()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado esta cuenta", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTipoCuenta() = True Then
            Call EditarTipoCuenta()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodoTipoCuenta()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub FrmTipoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodoTipoCuenta()
        Call Limpiar()
    End Sub


End Class