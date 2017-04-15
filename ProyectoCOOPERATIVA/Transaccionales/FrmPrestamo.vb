Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmPrestamo
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub PRESTAMO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, frmDepartamento, FrmNacionalidad, FrmPais,
                       FrmProfesion, FrmTipodeCuenta, FrmTipoPrestamo, FrmCargo, FrmCuenta,
                       FrmOficial, FrmAval, FrmSocio, FrmUsuario)
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

    Private Function ValidarPrestamo() As Boolean
        Dim Estado As Boolean
        If TxtCodigoPrestamo.Text = Nothing Then
            MsgBox("Ingrese el código del prestamo", MsgBoxStyle.Critical, "Control Keeper")
            TxtCodigoPrestamo.Focus()
            Estado = False
        ElseIf CboTipoPrestamo.Text = Nothing Then
            MsgBox("Seleccione el tipo de prestamo", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboSocio.Text = Nothing Then
            MsgBox("Seleccione el socio del prestamo", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf TxtCapital.Text = Nothing Then
            MsgBox("Ingrese el capital del socio", MsgBoxStyle.Critical, "Control Keeper")
            TxtCapital.Focus()
            Estado = False
        ElseIf TxtPlazo.Text = Nothing Then
            MsgBox("Ingrese el plazo del prestamo", MsgBoxStyle.Critical, "Control Keeper")
            TxtPlazo.Focus()
            Estado = False
        ElseIf TxtTasa.Text = Nothing Then
            MsgBox("Ingrese la tasa de interes del prestamo", MsgBoxStyle.Critical, "Control Keeper")
            TxtTasa.Focus()
            Estado = False
        ElseIf TxtFinalidad.Text = Nothing Then
            MsgBox("Ingrese la finalidad del prestamo", MsgBoxStyle.Critical, "Control Keeper")
            TxtFinalidad.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call LlenarComboBoxTipoPrestamo()
        Call LlenarComboBoxSocio()
        Call MostrarTodosPrestamos()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlPrestamo.Enabled = Panel
    End Sub
    Private Sub MostrarTodosPrestamos()
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
                End With

                Dim AdaptadorPrestamo As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorPrestamo.Fill(dt)
                DgvPrestamo.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los prestamos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        TxtCodigoPrestamo.Text = CodigoPrestamo()
        ChkEstado.Enabled = False
        ChkEstado.Checked = False

    End Sub
    Private Sub LlenarComboBoxTipoPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorPrestamo As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorPrestamo.Fill(ds, "TipoPrestamo")
                CboTipoPrestamo.DataSource = ds.Tables(0)
                CboTipoPrestamo.DisplayMember = ds.Tables(0).Columns("TipoPrestamo").ToString
                CboTipoPrestamo.ValueMember = ds.Tables(0).Columns("IdTipoPrestamo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar tipo prestamo " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxSocio()
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
                CboSocio.DataSource = ds.Tables(0)
                CboSocio.DisplayMember = ds.Tables(0).Columns("NombreCompleto").ToString
                CboSocio.ValueMember = ds.Tables(0).Columns("CodigoSocio").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar socio " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Function CodigoPrestamo() As Integer

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Integer
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CodigoPrestamo"
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
    Private Sub GuardarPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con


                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(CboTipoPrestamo.SelectedValue)
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = DtpFecha.Text
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue.ToString
                    .Parameters.Add("@Capital", SqlDbType.Decimal, 10, 2).Value = CDbl(TxtCapital.Text)
                    .Parameters.Add("@Plazo", SqlDbType.Int).Value = CInt(TxtPlazo.Text)
                    .Parameters.Add("@TasaInteres", SqlDbType.Int).Value = CInt(TxtTasa.Text)
                    .Parameters.Add("@FinalidadPrestamo", SqlDbType.NVarChar, 200).Value = TxtFinalidad.Text.Trim
                    .Parameters.Add("@IdOficial", SqlDbType.NVarChar, 15).Value = PantallaPrincipal.LblIdOficial.Text.Trim
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Prestamo registrado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el prestamo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarPrestamo() = True Then

            If ExisteCuenta() = True Then
                If CDbl(TxtCapital.Text) <= (SaldoTotalCuenta() * 2) Then
                    Call GuardarPrestamo()
                    MessageBox.Show("Para aprobar el prestamo debe tener más de un aval", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call MostrarTodosPrestamos()
                    Call HabilitarControles(True, False, False, False, False)
                    Call Limpiar()
                    Me.Close()
                    Dim MiAval As New FrmAval
                    MiAval.MdiParent = PantallaPrincipal
                    MiAval.Show()
                    MiAval.Location = New Point(550, 60)
                    MiAval.BringToFront()
                    PantallaPrincipal.PnlLogo.SendToBack()
                Else
                    MessageBox.Show("El capital sobrepasa del limite establecido", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                    MessageBox.Show("El socio no tiene cuentas registradas", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


            End If
    End Sub
    Private Function ExisteCuenta() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Dim estado As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue.ToString

                End With
                Dim Existe As Integer = cmd.ExecuteScalar
                If Existe <> 0 Then
                    estado = True
                Else
                    estado = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar cuenta de socio " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
        Return estado
    End Function
    Private Function ExisteAvales() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Dim estado As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteAvales"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@NumPrestamo", SqlDbType.Int).Value = CInt(TxtCodigoPrestamo.Text.Trim)

                End With
                Dim existe As Integer = cmd.ExecuteScalar
                If existe >= 2 Then
                    estado = True
                Else
                    estado = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar cuenta de socio " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
        Return estado
    End Function
    Private Function SaldoTotalCuenta() As Double
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Dim Total As Double
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_TotalSaldoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue.ToString

                End With
                Dim LectorSaldo As SqlDataReader = cmd.ExecuteReader
                If LectorSaldo.Read() Then
                    Total = CDbl(LectorSaldo("SaldoTotal").ToString)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar cuenta de socio " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
        Return Total
    End Function
    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstado.CheckedChanged
        If ChkEstado.CheckState = CheckState.Checked Then

            ChkEstado.Text = "Aprobado"

        Else
            ChkEstado.Text = "No aprobado"
        End If
    End Sub
    Private Function IdentificarEstado() As String
        Dim var As String
        If ChkEstado.CheckState = CheckState.Checked Then
            var = "Aprobado"
        Else
            var = "No aprobado"
        End If
        Return var
    End Function
    Private Sub Limpiar()
        TxtCodigoPrestamo.Clear()
        CboTipoPrestamo.Text = Nothing
        DtpFecha.ResetText()
        CboSocio.Text = Nothing
        TxtCapital.Text = Nothing
        TxtPlazo.Text = Nothing
        TxtTasa.Clear()
        TxtFinalidad.Clear()
        ChkEstado.Checked = False
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TbcPrestamo.SelectedIndex = 0
        Call HabilitarControles(False, False, True, True, True)
        ChkEstado.Checked = False
        ChkEstado.Enabled = True
        TxtCodigoPrestamo.Enabled = False
        TxtCodigoPrestamo.Text = DgvPrestamo.CurrentRow.Cells(0).Value.ToString
        CboTipoPrestamo.Text = DgvPrestamo.CurrentRow.Cells(1).Value.ToString
        DtpFecha.Text = DgvPrestamo.CurrentRow.Cells(2).Value.ToString
        CboSocio.Text = DgvPrestamo.CurrentRow.Cells(3).Value.ToString
        TxtCapital.Text = DgvPrestamo.CurrentRow.Cells(4).Value.ToString
        TxtPlazo.Text = DgvPrestamo.CurrentRow.Cells(5).Value.ToString
        TxtTasa.Text = DgvPrestamo.CurrentRow.Cells(6).Value.ToString
        TxtFinalidad.Text = DgvPrestamo.CurrentRow.Cells(7).Value.ToString

        If DgvPrestamo.CurrentRow.Cells(9).Value.ToString = "Aprobado" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
    Private Sub EditarPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con


                    .Parameters.Add("@NumPrestamo", SqlDbType.Int).Value = CInt(TxtCodigoPrestamo.Text.Trim)
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(CboTipoPrestamo.SelectedValue)
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = DtpFecha.Text
                    .Parameters.Add("@CodigoSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue.ToString
                    .Parameters.Add("@Capital", SqlDbType.Decimal, 10, 2).Value = CDbl(TxtCapital.Text)
                    .Parameters.Add("@Plazo", SqlDbType.Int).Value = CInt(TxtPlazo.Text)
                    .Parameters.Add("@TasaInteres", SqlDbType.Int).Value = CInt(TxtTasa.Text)
                    .Parameters.Add("@FinalidadPrestamo", SqlDbType.NVarChar, 200).Value = TxtFinalidad.Text.Trim
                    .Parameters.Add("@IdOficial", SqlDbType.NVarChar, 15).Value = PantallaPrincipal.LblIdOficial.Text.Trim
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Prestamo editado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar el prestamo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarPrestamo() = True Then
            If ExisteCuenta() = True Then
                If CDbl(TxtCapital.Text) <= (SaldoTotalCuenta() * 2) Then
                    If ChkEstado.Checked = True Then
                        If ExisteAvales() = True Then
                            ChkEstado.Checked = True
                            Call EditarPrestamo()
                            Call HabilitarControles(True, False, False, False, False)
                            Call Limpiar()
                            Call MostrarTodosPrestamos()
                        Else

                            MessageBox.Show("El prestamo no tiene el número de avales requeridos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        ChkEstado.Checked = False
                        Call EditarPrestamo()
                        Call HabilitarControles(True, False, False, False, False)
                        Call Limpiar()
                        Call MostrarTodosPrestamos()
                    End If

                Else
                    MessageBox.Show("El capital sobrepasa del limite establecido", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("El socio no tiene cuentas registradas", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BusquedaFiltradaPrestamo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvPrestamo.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosPrestamos()
        Else
            BusquedaFiltradaPrestamo()
        End If
    End Sub

    Private Sub TxtCapital_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCapital.KeyPress
        If Asc(e.KeyChar) = Keys.Back Then
        ElseIf Asc(e.KeyChar) = 46 Then


        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TxtPlazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPlazo.KeyPress
        If Asc(e.KeyChar) = Keys.Back Then

        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TxtTasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTasa.KeyPress
        If Asc(e.KeyChar) = Keys.Back Then

        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub
End Class