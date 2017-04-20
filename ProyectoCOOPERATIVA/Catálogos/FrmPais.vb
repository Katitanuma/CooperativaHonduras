Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmPais
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()

    End Sub
    Private Sub PAIS_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmAval,
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Call HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoPais()

    End Sub


    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)

        BtnCancelar.Enabled = Cancelar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnNuevo.Enabled = Nuevo
        PlPais.Enabled = Panel

    End Sub

    Private Sub InvestigarCorrelativoPais()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_CorrelativoPais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = Cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoPais.Text = 1
                    Else
                        TxtCodigoPais.Text = LectorCorrelativo("Id").ToString
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

        If ValidarPais() = True Then


            If ExistePais() = False Then

                Call HabilitarControles(True, False, False, False, False)
                Call InsertarPais()
                Call MostrarTodoPais()
                Call LimpiarPais()

            Else
                MessageBox.Show("Ya existe ese país", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Call InvestigarCorrelativoPais()
        Call LimpiarPais()
        Call HabilitarControles(True, False, False, False, False)

    End Sub

    Private Function ExistePais() As Boolean

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExistePais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Pais", SqlDbType.NVarChar, 50).Value = TxtPais.Text.Trim
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

    Private Sub InsertarPais()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_InsertarPais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Pais", SqlDbType.NVarChar, 50).Value = TxtPais.Text.Trim
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("País almacenado con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error al almacencar el Pais" + ex.Message)

            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub EliminarPais()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_EliminarPais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdPais", SqlDbType.Int).Value = CInt(DgvPais.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("País eliminado con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el País", ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub


    Private Sub ActualizarPais()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_ActualizarPais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdPais", SqlDbType.Int).Value = TxtCodigoPais.Text.Trim
                    .Parameters.Add("@Pais", SqlDbType.NVarChar, 50).Value = TxtPais.Text.Trim
                    .ExecuteNonQuery()

                End With

                MessageBox.Show("País modificado con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MsgBox("Error al modificar el País" + ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub


    Private Sub MostrarTodoPais()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_MostrarTodoPais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                End With

                Dim AdaptadorPais As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable

                AdaptadorPais.Fill(Dt)
                DgvPais.DataSource = Dt


            Catch ex As Exception

                MessageBox.Show("Error al mostrar los datos de los países " + ex.Message)
            Finally

                Con.Close()

            End Try
        End Using
    End Sub

    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoPais()
        Call LimpiarPais()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarPais() = True Then

            Call ActualizarPais()
            Call MostrarTodoPais()
            Call LimpiarPais()
            Call HabilitarControles(True, False, False, False, False)


        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoPais.Text = DgvPais.CurrentRow.Cells(0).Value
        TxtPais.Text = DgvPais.CurrentRow.Cells(1).Value.ToString
        TabPage1.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "SYS CAP",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call HabilitarControles(True, False, False, False, False)
            Call EliminarPais()
            Call MostrarTodoPais()
        End If
    End Sub

    Private Sub LimpiarPais()

        Call MostrarTodoPais()
        TxtPais.Text = ""
        TxtCodigoPais.Text = ""

    End Sub

    Private Function ValidarPais() As Boolean

        Dim Estado As Boolean

        If TxtPais.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el país", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else
            Estado = True

        End If

        Return Estado

    End Function

    Private Sub BusquedaFiltradasPais()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaPais"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvPais.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodoPais()
        Else
            BusquedaFiltradasPais()
        End If
    End Sub
End Class