Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmCuenta

    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmCuenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
                       FrmProfesion, FrmTipodeCuenta, FrmTipoPrestamo, FrmCargo, FrmAval,
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
        PlCuenta.Enabled = Panel
    End Sub

    Private Sub MostrarTodoCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoCuentaDgv"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim AdaptadorCargo As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorCargo.Fill(Dt)
                DgvCuenta.DataSource = Dt
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub Limpiar()
        TxtCodigoCuenta.Text = ""
        TxtSaldoActual.Text = ""
        CboSocio.Text = Nothing
        CboTipoCuenta.Text = Nothing

    End Sub

    Public Sub LlenarComboBoxSocio()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarSocioIdentificacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorOficial As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorOficial.Fill(ds, "Socio")
                CboSocio.DataSource = ds.Tables(0)
                CboSocio.DisplayMember = ds.Tables(0).Columns("Nombre Completo").ToString
                CboSocio.ValueMember = ds.Tables(0).Columns("CodigoSocio").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el nombre completo de los socios " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Public Sub LlenarComboBoxTipoCuenta()
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
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorOficial As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorOficial.Fill(ds, "TipoCuenta")
                CboTipoCuenta.DataSource = ds.Tables(0)
                CboTipoCuenta.DisplayMember = ds.Tables(0).Columns("TipoCuenta").ToString
                CboTipoCuenta.ValueMember = ds.Tables(0).Columns("IdTipoCuenta").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos del tipo de cuenta" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub FrmCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodoCuenta()
        Call LlenarComboBoxSocio()
        Call LlenarComboBoxTipoCuenta()
        Call Limpiar()
    End Sub

    Private Function ExisteCuenta() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteCuenta2"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@NumCuenta", SqlDbType.Decimal, 11).Value = CDec(TxtCodigoCuenta.Text)
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

    Private Function ValidarCuenta()
        Dim Estado As Boolean
        If TxtCodigoCuenta.Text = "" Then
            MessageBox.Show("Ingrese el número de cuenta", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCodigoCuenta.Focus()
            Estado = False
        ElseIf CboSocio.Text = "" Then
            MessageBox.Show("Seleccione el nombre del socio", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboSocio.Focus()
            Estado = False
        ElseIf CboTipoCuenta.Text = "" Then
            MessageBox.Show("Seleccione el tipo de cuenta", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboTipoCuenta.Focus()
            Estado = False
        ElseIf TxtSaldoActual.Text = "" Then
            MessageBox.Show("Ingrese el saldo actual", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtSaldoActual.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub GuardarCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@NumCuenta", SqlDbType.Decimal, 11, 0).Value = CDec(TxtCodigoCuenta.Text)
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = (CboSocio.SelectedValue.ToString)
                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CInt(CboTipoCuenta.SelectedValue.ToString)
                    .Parameters.Add("@SaldoActual", SqlDbType.Decimal, 11, 2).Value = CDbl(TxtSaldoActual.Text)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cuenta almacenada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al almacenar la cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarCuenta() = True Then
            If ExisteCuenta() = False Then
                Call GuardarCuenta()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCuenta()
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado este número de cuenta", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtCodigoCuenta.Text = ""
                TxtCodigoCuenta.Focus()
            End If
        End If
    End Sub

    Private Sub EditarCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@NumCuenta", SqlDbType.Decimal, 11, 0).Value = CDec(TxtCodigoCuenta.Text)
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = (CboSocio.SelectedValue.ToString)
                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CInt(CboTipoCuenta.SelectedValue.ToString)
                    .Parameters.Add("@SaldoActual", SqlDbType.Decimal, 11, 2).Value = CDec(TxtSaldoActual.Text)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cuenta modificada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al modificar la cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarCuenta() = True Then

            Call EditarCuenta()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCuenta()
            Call Limpiar()
        End If
    End Sub

    Private Sub EliminarCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@NumCuenta", SqlDbType.Decimal, 11, 0).Value = CDec(DgvCuenta.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Cuenta eliminada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la cuenta " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarCuenta()
            Call MostrarTodoCuenta()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TbcCuenta.SelectedIndex = 0
        TxtCodigoCuenta.Enabled = False
        TxtCodigoCuenta.Text = DgvCuenta.CurrentRow.Cells(0).Value
        CboSocio.Text = DgvCuenta.CurrentRow.Cells(1).Value.ToString
        CboTipoCuenta.Text = DgvCuenta.CurrentRow.Cells(2).Value.ToString
        TxtSaldoActual.Text = DgvCuenta.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call Limpiar()
        Call HabilitarControles(False, True, False, True, True)
        TxtCodigoCuenta.Focus()
        TxtCodigoCuenta.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call Limpiar()
        Call HabilitarControles(True, False, False, False, False)
    End Sub

    Private Sub BusquedaFiltradaCuenta()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@ParametroCuenta", SqlDbType.NVarChar, 50).Value = (TxtBusquedaCuenta.Text)
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvCuenta.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBusquedaCuenta_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaCuenta.TextChanged
        If TxtBusquedaCuenta.Text = Nothing Then
            MostrarTodoCuenta()
        Else
            BusquedaFiltradaCuenta()
        End If
    End Sub


    Private Sub TxtCodigoCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoCuenta.KeyPress
        If Asc(e.KeyChar) = Keys.Back Then

        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TxtSaldoActual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSaldoActual.KeyPress
        If Asc(e.KeyChar) = Keys.Back Then
        ElseIf Asc(e.KeyChar) = 46 Then


        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub
End Class