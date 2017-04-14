Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmNacionalidad
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()

    End Sub

    Private Sub NACIONALIDAD_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PantallaPrincipal.PnlLogo.BringToFront()
        PantallaPrincipal.PnlLogo1.Visible = False
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Call HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoNacionalidad()

    End Sub


    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)

        BtnCancelar.Enabled = Cancelar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnNuevo.Enabled = Nuevo
        PlNacionalidad.Enabled = Panel

    End Sub

    Private Sub InvestigarCorrelativoNacionalidad()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_CorrelativoNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = Cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoNacionalidad.Text = 1
                    Else
                        TxtCodigoNacionalidad.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception

                MsgBox(ex.Message)

            Finally
                Con.Close()

            End Try

        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarNacionalidad() = True Then


            If ExisteNacionalidad() = False Then

                Call HabilitarControles(True, False, False, False, False)
                Call InsertarNacionalidad()
                Call MostrarTodoNacionalidad()
                Call LimpiarDepartamento()

            Else
                MessageBox.Show("Ya existe esa nacionalidad", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Call InvestigarCorrelativoNacionalidad()
        Call LimpiarDepartamento()
        Call HabilitarControles(True, False, False, False, False)

    End Sub

    Private Function ExisteNacionalidad() As Boolean

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtNacionalidad.Text.Trim
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

    Private Sub InsertarNacionalidad()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_InsertarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtNacionalidad.Text.Trim
                    .Parameters.Add("@IdPais", SqlDbType.Int).Value = CInt(CboPais.SelectedValue)
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("Nacionalidad almacenada con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error al almacencar la nacionalidad" + ex.Message)

            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub EliminarNacionalidad()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_EliminarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(DgvNacionalidad.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("Nacionalidad eliminada con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error al eliminar la nacionalidad", ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub


    Private Sub ActualizarNacionalidad()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_ActualizarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(DgvNacionalidad.CurrentRow.Cells(0).Value)
                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtNacionalidad.Text.Trim
                    .Parameters.Add("@IdPais", SqlDbType.Int).Value = CInt(CboPais.SelectedValue)
                    .ExecuteNonQuery()

                End With

                MessageBox.Show("Nacionalidad actualizada con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MsgBox("Error al actualizar la nacionalidad" + ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub

    Private Sub MostrarTodoNacionalidad()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_MostrarTodoNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                End With

                Dim AdaptadorNacionalidad As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable

                AdaptadorNacionalidad.Fill(Dt)
                DgvNacionalidad.DataSource = Dt


            Catch ex As Exception

                MessageBox.Show("Error al mostrar los datos de las nacionalidades " + ex.Message)
            Finally

                Con.Close()

            End Try
        End Using
    End Sub
    Public Sub LlenarComboBoxPais()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoPais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorOficial As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorOficial.Fill(ds, "Pais")
                CboPais.DataSource = ds.Tables(0)
                CboPais.DisplayMember = ds.Tables(0).Columns("Pais").ToString
                CboPais.ValueMember = ds.Tables(0).Columns("IdPais").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los países " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub FrmNacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoNacionalidad()
        Call LlenarComboBoxPais()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarNacionalidad() = True Then

            If ExisteNacionalidad() = False Then


                Call ActualizarNacionalidad()
                Call MostrarTodoNacionalidad()
                Call LimpiarDepartamento()
                Call HabilitarControles(True, False, False, False, False)

            Else

                MessageBox.Show("Ya existe esa nacionalidad", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoNacionalidad.Text = DgvNacionalidad.CurrentRow.Cells(0).Value
        TxtNacionalidad.Text = DgvNacionalidad.CurrentRow.Cells(1).Value.ToString
        CboPais.Text = DgvNacionalidad.CurrentRow.Cells(2).ToString
        TabPage1.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "SYS CAP",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call HabilitarControles(True, False, False, False, False)
            Call EliminarNacionalidad()
            Call MostrarTodoNacionalidad()
        End If
    End Sub

    Private Sub LimpiarDepartamento()

        Call MostrarTodoNacionalidad()
        TxtNacionalidad.Text = ""
        TxtCodigoNacionalidad.Text = ""

    End Sub

    Private Function ValidarNacionalidad() As Boolean

        Dim Estado As Boolean

        If TxtNacionalidad.Text = Nothing And CboPais.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar un nacionalidad y seleccionar un País", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtNacionalidad.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar una nacionalidad ", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboPais.Text = Nothing Then

            MessageBox.Show("Tiene que seleccionar un País", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else
            Estado = True

        End If

        Return Estado

    End Function

    Private Sub BusquedaFiltradasNacionalidad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvNacionalidad.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodoNacionalidad()
        Else
            BusquedaFiltradasNacionalidad()
        End If
    End Sub

End Class