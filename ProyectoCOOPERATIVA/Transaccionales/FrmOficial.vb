Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmOficial
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmOficial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
                       FrmProfesion, FrmTipodeCuenta, FrmTipoPrestamo, FrmCargo, FrmCuenta,
                       FrmAval, FrmPrestamo, FrmSocio, FrmUsuario)
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

    Private Function ValidarOficial() As Boolean
        Dim Estado As Boolean
        If Replace(MtbCodigoOficial.Text, "-", "") = Nothing Then
            MsgBox("Ingrese el código del oficial", MsgBoxStyle.Critical, "Control Keeper")
            MtbCodigoOficial.Focus()
            Estado = False
        ElseIf TxtNombre.Text = Nothing Then
            MsgBox("Ingrese el nombre del oficial", MsgBoxStyle.Critical, "Control Keeper")
            TxtNombre.Focus()
            Estado = False
        ElseIf TxtApellido.Text = Nothing Then
            MsgBox("Ingrese el apellido del oficial", MsgBoxStyle.Critical, "Control Keeper")
            TxtApellido.Focus()
            Estado = False
        ElseIf CboCargo.Text = Nothing Then
            MsgBox("Seleccione el cargo del oficial", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboProfesion.Text = Nothing Then
            MsgBox("Seleccione la profesión del oficial", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboCiudad.Text = Nothing Then
            MsgBox("Seleccione la ciudad del oficial", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboSexo.Text = Nothing Then
            MsgBox("Seleccione el sexo del oficial", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboEstadoCivil.Text = Nothing Then
            MsgBox("Seleccione el estado civil del oficial", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmOficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call LlenarComboBoxCargo()
        Call LlenarComboBoxProfesion()
        Call LlenarComboBoxCiudad()
        Call LlenarComboBoxEstadoCivil()
        Call LlenarComboBoxSexo()
        Call MostrarTodosOficial()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlOficial.Enabled = Panel
    End Sub
    Private Sub MostrarTodosOficial()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorOficial As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorOficial.Fill(dt)
                DgvOficial.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los oficiales " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()

    End Sub
    Private Sub LlenarComboBoxCargo()
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
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorCargo As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorCargo.Fill(ds, "Cargo")
                CboCargo.DataSource = ds.Tables(0)
                CboCargo.DisplayMember = ds.Tables(0).Columns("Cargo").ToString
                CboCargo.ValueMember = ds.Tables(0).Columns("IdCargo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar cargo " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxProfesion()
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
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorProfesion As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorProfesion.Fill(ds, "Profesion")
                CboProfesion.DataSource = ds.Tables(0)
                CboProfesion.DisplayMember = ds.Tables(0).Columns("Profesion").ToString
                CboProfesion.ValueMember = ds.Tables(0).Columns("IdProfesion").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar profesion " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorCiudad As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorCiudad.Fill(ds, "Ciudad")
                CboCiudad.DataSource = ds.Tables(0)
                CboCiudad.DisplayMember = ds.Tables(0).Columns("Ciudad").ToString
                CboCiudad.ValueMember = ds.Tables(0).Columns("IdCiudad").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar ciudad " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxSexo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorSexo As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorSexo.Fill(ds, "Sexo")
                CboSexo.DataSource = ds.Tables(0)
                CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar sexo " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxEstadoCivil()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoEstadoCivil"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorEstadoCivil As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorEstadoCivil.Fill(ds, "EstadoCivil")
                CboEstadoCivil.DataSource = ds.Tables(0)
                CboEstadoCivil.DisplayMember = ds.Tables(0).Columns("EstadoCivil").ToString
                CboEstadoCivil.ValueMember = ds.Tables(0).Columns("IdEstadoCivil").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar estado civil " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub GuardarOficial()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdOficial", SqlDbType.VarChar, 15).Value = MtbCodigoOficial.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@IdCargo", SqlDbType.Int).Value = CInt(CboCargo.SelectedValue)
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CInt(CboProfesion.SelectedValue)
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(CboCiudad.SelectedValue)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CInt(CboEstadoCivil.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Oficial Registrado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el oficial " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarOficial() = True Then
            Call GuardarOficial()
            Call MostrarTodosOficial()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
        End If
    End Sub
    Private Sub Limpiar()
        MtbCodigoOficial.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        CboCargo.Text = Nothing
        CboProfesion.Text = Nothing
        CboCiudad.Text = Nothing
        CboSexo.Text = Nothing
        CboEstadoCivil.Text = Nothing
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TbcOficial.SelectedIndex = 0
        Call HabilitarControles(False, False, True, True, True)
        MtbCodigoOficial.Text = DgvOficial.CurrentRow.Cells(0).Value.ToString
        TxtNombre.Text = DgvOficial.CurrentRow.Cells(1).Value.ToString
        TxtApellido.Text = DgvOficial.CurrentRow.Cells(2).Value.ToString
        CboCargo.Text = DgvOficial.CurrentRow.Cells(3).Value.ToString
        CboProfesion.Text = DgvOficial.CurrentRow.Cells(4).Value.ToString
        CboCiudad.Text = DgvOficial.CurrentRow.Cells(5).Value.ToString
        CboSexo.Text = DgvOficial.CurrentRow.Cells(6).Value.ToString
        CboEstadoCivil.Text = DgvOficial.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
    Private Sub EditarUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdOficial", SqlDbType.VarChar, 15).Value = MtbCodigoOficial.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@IdCargo", SqlDbType.Int).Value = CInt(CboCargo.SelectedValue)
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CInt(CboProfesion.SelectedValue)
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(CboCiudad.SelectedValue)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CInt(CboEstadoCivil.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Oficial editado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar el oficial " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarOficial()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdOficial", SqlDbType.VarChar, 15).Value = DgvOficial.CurrentRow.Cells(0).Value.ToString
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Oficial eliminado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el Oficial " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarOficial() = True Then
            Call EditarUsuario()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodosOficial()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarOficial()
            Call MostrarTodosOficial()
        End If
    End Sub

    Private Sub BusquedaFiltradaOficial()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvOficial.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosOficial()
        Else
            BusquedaFiltradaOficial()
        End If
    End Sub

End Class