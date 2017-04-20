Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmAval
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub AVAL_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
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

    Private Function ValidarPrestamo() As Boolean
        Dim Estado As Boolean

        If CboCodigoPrestamo.Text = Nothing Then
            MessageBox.Show("Seleccione el código del préstamo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
        ElseIf CboAval.Text = Nothing Then
            MessageBox.Show("Seleccione el aval para el préstamo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmAval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call LlenarComboBoxCodigoPrestamo()
        Call LlenarComboBoxAval()
        Call MostrarTodosPrestamosAval()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlAval.Enabled = Panel
    End Sub
    Private Sub MostrarTodosPrestamosAval()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoPrestamoAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorPrestamoAval As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorPrestamoAval.Fill(dt)
                DgvAval.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de préstamo aval " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        TxtCodigoPrestamoAval.Text = CorrelativoPrestamoAval()
    End Sub
    Private Sub LlenarComboBoxCodigoPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorPrestamo As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorPrestamo.Fill(ds, "Prestamo")
                CboCodigoPrestamo.DataSource = ds.Tables(0)
                CboCodigoPrestamo.DisplayMember = ds.Tables(0).Columns("NumPrestamo").ToString
                CboCodigoPrestamo.ValueMember = ds.Tables(0).Columns("NumPrestamo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar préstamo " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxAval()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarIdentificacionSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorSocio As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorSocio.Fill(ds, "Socio")
                CboAval.DataSource = ds.Tables(0)
                CboAval.DisplayMember = ds.Tables(0).Columns("NombreCompleto").ToString
                CboAval.ValueMember = ds.Tables(0).Columns("CodigoSocio").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los socios  " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Function CorrelativoPrestamoAval() As Integer

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Integer
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoPrestamoAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Valor = cmd.ExecuteScalar

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

        Return Valor


    End Function
    Private Sub GuardarPrestamoAval()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarPrestamoAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@NumPrestamo", SqlDbType.Int).Value = CInt(CboCodigoPrestamo.SelectedValue)
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = CboAval.SelectedValue.ToString
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Aval almacenado con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al almacenar el aval" + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarPrestamo() = True Then
            Call GuardarPrestamoAval()
            Call MostrarTodosPrestamosAval()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
        End If
    End Sub

    Private Sub Limpiar()
        TxtCodigoPrestamoAval.Clear()
        CboAval.Text = Nothing
        CboCodigoPrestamo.Text = Nothing

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TbcAval.SelectedIndex = 0
        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoPrestamoAval.Text = DgvAval.CurrentRow.Cells(0).Value.ToString
        CboCodigoPrestamo.Text = DgvAval.CurrentRow.Cells(1).Value.ToString
        CboAval.Text = DgvAval.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
    Private Sub EditarPrestamoAval()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarPrestamoAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdPrestamoAval", SqlDbType.Int).Value = CInt(TxtCodigoPrestamoAval.Text)
                    .Parameters.Add("@NumPrestamo", SqlDbType.Int).Value = CInt(CboCodigoPrestamo.SelectedValue)
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = CboAval.SelectedValue.ToString
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Aval modificado con éxito", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al modificar el aval " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarPrestamo() = True Then
            Call EditarPrestamoAval()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodosPrestamosAval()
        End If
    End Sub

    Private Sub BusquedaFiltradaPrestamoAval()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaPrestamoAval"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvAval.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosPrestamosAval()
        Else
            BusquedaFiltradaPrestamoAval()
        End If
    End Sub


End Class