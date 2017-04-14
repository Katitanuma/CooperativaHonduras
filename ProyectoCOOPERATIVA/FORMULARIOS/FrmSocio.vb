Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmSocio
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
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
    Private Sub FrmSocio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PantallaPrincipal.PnlLogo.BringToFront()
        PantallaPrincipal.PnlLogo1.Visible = False
    End Sub


    Private Sub FrmSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarComboBoxEstadoCivil()
        Call LlenarComboBoxNacionalidad()
        Call LlenarComboBoxSexo()
        Call MostrarTodosSocio()
        Call HabilitarControles(True, False, False, False, False)
    End Sub

    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlSocio.Enabled = Panel

    End Sub


    Private Sub LlenarComboBoxNacionalidad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorNacionalidad As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorNacionalidad.Fill(ds, "Nacionalidad")
                CboNacionalidad.DataSource = ds.Tables(0)
                CboNacionalidad.DisplayMember = ds.Tables(0).Columns("Nacionalidad").ToString
                CboNacionalidad.ValueMember = ds.Tables(0).Columns("IdNacionalidad").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar las nacionalidades " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Public Sub LlenarComboBoxEstadoCivil()
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
                MessageBox.Show("Error al mostrar los estados civiles " + ex.Message)
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
                MessageBox.Show("Error al mostrar tipo acceso " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub


    Private Sub MostrarTodosSocio()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorSocio As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorSocio.Fill(dt)
                DgvSocio.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los socios" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub


    Private Sub GuardarSocio()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = TxtCodigoSocio.Text.Trim
                    .Parameters.Add("@NombreSocio", SqlDbType.NVarChar, 50).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@ApellidoSocio", SqlDbType.NVarChar, 50).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@RTN", SqlDbType.NVarChar, 15).Value = TxtRTN.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = TxtDIreccion.Text.Trim
                    .Parameters.Add("@LugarTrabajo", SqlDbType.NVarChar, 200).Value = TxtLugardeTrabajo.Text.Trim
                    .Parameters.Add("@TelCasa", SqlDbType.VarChar, 9).Value = TxtTelefonoCasa.Text.Trim
                    .Parameters.Add("@TelTrabajo", SqlDbType.VarChar, 9).Value = TxtTelefonoTrabajo.Text.Trim
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CboNacionalidad.SelectedValue.ToString
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CInt(CboEstadoCivil.SelectedValue)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue.ToString
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Socio registrado con éxito", "SYS CAP")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el socio " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub


    Private Sub ModificarSocio()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = TxtCodigoSocio.Text.Trim
                    .Parameters.Add("@NombreSocio", SqlDbType.NVarChar, 50).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@ApellidoSocio", SqlDbType.NVarChar, 50).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@RTN", SqlDbType.NVarChar, 15).Value = TxtRTN.Text.Trim

                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = TxtDIreccion.Text.Trim
                    .Parameters.Add("@LugarTrabajo", SqlDbType.NVarChar, 200).Value = TxtLugardeTrabajo.Text.Trim
                    .Parameters.Add("@TelCasa", SqlDbType.VarChar, 9).Value = TxtTelefonoCasa.Text.Trim
                    .Parameters.Add("@TelTrabajo", SqlDbType.VarChar, 9).Value = TxtTelefonoTrabajo.Text.Trim
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CboNacionalidad.SelectedValue.ToString
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CboEstadoCivil.SelectedValue.ToString
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue.ToString
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Socio modificado con éxito", "SYS CAP")
            Catch ex As Exception
                MessageBox.Show("Error al modificar el socio " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub EliminarSocio()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = CInt(DgvSocio.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Socio eliminado con éxito", "SYS CAP")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el socio " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Function ExisteRTNSocio() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@RTN", SqlDbType.NVarChar, 50).Value = TxtRTN.Text.Trim
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


    Private Sub BusquedaFiltradaSocio()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvSocio.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosSocio()
        Else
            BusquedaFiltradaSocio()
        End If
    End Sub

    Private Function ValidarSocio() As Boolean

        Dim Estado As Boolean

        If TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            '2
        ElseIf TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            '3
        ElseIf TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

            '4
        ElseIf TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtLugardeTrabajo.Text = Nothing AndAlso TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing And TxtLugardeTrabajo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            '6
        ElseIf TxtTelefonoTrabajo.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing And TxtDIreccion.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            '7
        ElseIf TxtTelefonoCasa.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtRTN.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            '8
        ElseIf CboNacionalidad.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboEstadoCivil.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que seleccionar el estado civil y el sexo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el códgio del socio y seleccionar el sexo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing And TxtNombre.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el código del socio y el nombre", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el código del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtNombre.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el nombre del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtApellido.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el apellido del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtRTN.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el RTN del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDIreccion.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar la dirección del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtLugardeTrabajo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el lugar de trabajo del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtTelefonoTrabajo.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el teléfono de trabajo del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtTelefonoCasa.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el teléfono de casa del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboNacionalidad.Text = Nothing Then

            MessageBox.Show("Tiene que seleccionar la nacionalidad del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboEstadoCivil.Text = Nothing Then

            MessageBox.Show("Tiene que seleccionar el estado civil del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboSexo.Text = Nothing Then

            MessageBox.Show("Tiene que seleccionar el sexo del socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else

            Estado = True

        End If


        Return Estado

    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarSocio() = True Then

            If ExisteRTNSocio() = False Then
                Call GuardarSocio()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodosSocio()
                Call LimpiarSocio()

            Else
                MessageBox.Show("Ya existe ese socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarSocio() = True Then

            If ExisteRTNSocio() = False Then
                Call ModificarSocio()
                Call MostrarTodosSocio()
                Call LimpiarSocio()
                Call HabilitarControles(True, False, False, False, False)
            Else
                MessageBox.Show("Ya existe ese socio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoSocio.Text = DgvSocio.CurrentRow.Cells(0).Value.ToString
        TxtNombre.Text = DgvSocio.CurrentRow.Cells(1).Value.ToString
        TxtApellido.Text = DgvSocio.CurrentRow.Cells(2).Value.ToString
        TxtRTN.Text = DgvSocio.CurrentRow.Cells(3).Value.ToString
        TxtDIreccion.Text = DgvSocio.CurrentRow.Cells(4).Value.ToString
        TxtLugardeTrabajo.Text = DgvSocio.CurrentRow.Cells(5).Value.ToString
        TxtTelefonoCasa.Text = DgvSocio.CurrentRow.Cells(6).Value.ToString
        TxtTelefonoTrabajo.Text = DgvSocio.CurrentRow.Cells(7).Value.ToString
        CboNacionalidad.Text = DgvSocio.CurrentRow.Cells(8).Value.ToString
        CboEstadoCivil.Text = DgvSocio.CurrentRow.Cells(9).Value.ToString
        CboSexo.Text = DgvSocio.CurrentRow.Cells(10).Value.ToString
        TxtCodigoSocio.ReadOnly = True

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "SYS CAP",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarSocio()
            Call MostrarTodosSocio()
            Call HabilitarControles(True, False, False, False, False)
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        TxtCodigoSocio.ReadOnly = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call LimpiarSocio()
    End Sub

    Private Sub LimpiarSocio()
        TxtCodigoSocio.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtRTN.Text = ""
        TxtDIreccion.Text = ""
        TxtLugardeTrabajo.Text = ""
        TxtTelefonoTrabajo.Text = ""
        TxtTelefonoCasa.Text = ""
        CboNacionalidad.Text = ""
        CboEstadoCivil.Text = ""
        CboSexo.Text = ""

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class