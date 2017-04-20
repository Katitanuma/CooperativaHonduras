Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmCiudad
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()

    End Sub

    Private Sub CIUDAD_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmAval, frmDepartamento, FrmNacionalidad, FrmPais,
                       FrmProfesion, FrmTipodeCuenta, FrmTipoPrestamo, FrmCargo, FrmCuenta,
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

    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlCiudad.Enabled = Panel
    End Sub

    Private Sub MostrarTodoCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoCiudadDgv"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim AdaptadorCargo As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorCargo.Fill(Dt)
                DgvCiudad.DataSource = Dt
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de ciudad " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub Limpiar()
        TxtCodigoCiudad.Text = ""
        TxtCiudad.Text = ""
        CboDepartamento.Text = Nothing
    End Sub

    Public Sub LlenarComboBoxDepartamento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorOficial As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorOficial.Fill(ds, "Departamento")
                CboDepartamento.DataSource = ds.Tables(0)
                CboDepartamento.DisplayMember = ds.Tables(0).Columns("Departamento").ToString
                CboDepartamento.ValueMember = ds.Tables(0).Columns("IdDepartamento").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los departamentos" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoCiudad()
        Call LlenarComboBoxDepartamento()
        Call Limpiar()
    End Sub

    Private Sub InvestigarCorrelativoCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoCiudad.Text = 1
                    Else
                        TxtCodigoCiudad.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteNombreCiudad() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Ciudad", SqlDbType.NVarChar, 50).Value = TxtCiudad.Text.Trim
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

    Private Function ValidarCiudad()
        Dim Estado As Boolean
        If TxtCodigoCiudad.Text = "" Then
            MessageBox.Show("Ingrese el nombre de la ciudad", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCodigoCiudad.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub GuardarCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Ciudad", SqlDbType.NVarChar, 50).Value = TxtCiudad.Text.Trim
                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = CInt(CboDepartamento.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Ciudad almacenada con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al almacenar la ciudad " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarCiudad() = True Then
            If ExisteNombreCiudad() = False Then
                Call GuardarCiudad()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCiudad()
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esa ciudad", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtCiudad.Text = ""
                TxtCiudad.Focus()
            End If
        End If
    End Sub

    Private Sub EditarCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(TxtCodigoCiudad.Text)
                    .Parameters.Add("@Ciudad", SqlDbType.NVarChar, 50).Value = TxtCiudad.Text.Trim
                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = CInt(CboDepartamento.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Ciudad modificada con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al modificar la ciudad " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarCiudad() = True Then
            If ExisteNombreCiudad() = False Then
                Call EditarCiudad()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCiudad()
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esa ciudad", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtCiudad.Text = ""
                TxtCiudad.Focus()
            End If
        End If
    End Sub

    Private Sub EliminarCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(DgvCiudad.CurrentRow.Cells(0).Value.ToString)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Ciudad eliminada con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la ciudad " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "SYS CAP",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarCiudad()
            Call MostrarTodoCiudad()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TbcCiudad.SelectedIndex = 0
        TxtCodigoCiudad.Text = DgvCiudad.CurrentRow.Cells(0).Value
        TxtCiudad.Text = DgvCiudad.CurrentRow.Cells(1).Value.ToString
        CboDepartamento.Text = DgvCiudad.CurrentRow.Cells(2).Value.ToString

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call Limpiar()
        Call InvestigarCorrelativoCiudad()
        Call HabilitarControles(False, True, False, True, True)
        TxtCiudad.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call Limpiar()
        Call HabilitarControles(True, False, False, False, False)
    End Sub

    Private Sub BusquedaFiltradaCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@ParametroCiudad", SqlDbType.NVarChar, 50).Value = TxtBusquedaCiudad.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvCiudad.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBusquedaCiudad_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaCiudad.TextChanged
        If TxtBusquedaCiudad.Text = Nothing Then
            MostrarTodoCiudad()
        Else
            BusquedaFiltradaCiudad()
        End If
    End Sub


End Class