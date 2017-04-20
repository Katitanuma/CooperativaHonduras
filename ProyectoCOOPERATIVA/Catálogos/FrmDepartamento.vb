Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmDepartamento
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub DEPARTAMENTO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CierreFormulario(FrmCiudad, FrmAval, FrmNacionalidad, FrmPais,
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Call HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoDepartamento()
        Call LlenarComboBoxPais()

    End Sub


    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)

        BtnCancelar.Enabled = Cancelar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnNuevo.Enabled = Nuevo
        PlDepartamento.Enabled = Panel

    End Sub

    Private Sub InvestigarCorrelativoDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_CorrelativoDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = Cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoDepartamento.Text = 1
                    Else
                        TxtCodigoDepartamento.Text = LectorCorrelativo("Id").ToString
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

        If ValidarDepartamento() = True Then


            If ExisteDepartamento() = False Then

                Call HabilitarControles(True, False, False, False, False)
                Call InsertarDepartamento()
                Call MostrarTodoDepartamento()
                Call LimpiarDepartamento()

            Else
                MessageBox.Show("Ya existe ese departamento", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Call InvestigarCorrelativoDepartamento()
        Call LimpiarDepartamento()
        Call HabilitarControles(True, False, False, False, False)

    End Sub

    Private Function ExisteDepartamento() As Boolean

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Departamento", SqlDbType.NVarChar, 50).Value = TxtDepartamento.Text.Trim
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

    Private Sub InsertarDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_InsertarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Departamento", SqlDbType.NVarChar, 50).Value = TxtDepartamento.Text.Trim
                    .Parameters.Add("@IdPais", SqlDbType.Int).Value = CInt(CboPais.SelectedValue)
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("Departamento almacenado con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error al almacencar el departamento" + ex.Message)

            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub EliminarDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_EliminarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = CInt(DgvDepartamento.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("Departamento eliminado con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el departamento", ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub


    Private Sub ActualizarDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_ActualizarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = TxtCodigoDepartamento.Text.Trim
                    .Parameters.Add("@Departamento", SqlDbType.NVarChar, 50).Value = TxtDepartamento.Text.Trim
                    .Parameters.Add("@IdPais", SqlDbType.Int).Value = CInt(CboPais.SelectedValue)
                    .ExecuteNonQuery()

                End With

                MessageBox.Show("Departamento modificado con éxtio", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MsgBox("Error al modificar el departamento" + ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub

    Private Sub MostrarTodoDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_MostrarTododepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                End With

                Dim AdaptadorDepartamento As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable

                AdaptadorDepartamento.Fill(Dt)
                DgvDepartamento.DataSource = Dt


            Catch ex As Exception

                MessageBox.Show("Error al mostrar los datos de los departamentos " + ex.Message)
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
    Private Sub FrmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoDepartamento()
        Call LlenarComboBoxPais()
        Call LimpiarDepartamento()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarDepartamento() = True Then



            Call ActualizarDepartamento()
            Call MostrarTodoDepartamento()
            Call LimpiarDepartamento()
            Call HabilitarControles(True, False, False, False, False)

        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoDepartamento.Text = DgvDepartamento.CurrentRow.Cells(0).Value
        TxtDepartamento.Text = DgvDepartamento.CurrentRow.Cells(1).Value.ToString
        CboPais.Text = DgvDepartamento.CurrentRow.Cells(2).Value.ToString
        TabPage1.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "SYS CAP",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call HabilitarControles(True, False, False, False, False)
            Call EliminarDepartamento()
            Call MostrarTodoDepartamento()
        End If
    End Sub

    Private Sub LimpiarDepartamento()

        Call MostrarTodoDepartamento()
        TxtDepartamento.Text = ""
        TxtCodigoDepartamento.Text = Nothing
        CboPais.Text = Nothing

    End Sub

    Private Function ValidarDepartamento() As Boolean

        Dim Estado As Boolean

        If TxtDepartamento.Text = Nothing And CboPais.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el departamento y seleccionar un País", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDepartamento.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el departamento ", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboPais.Text = Nothing Then

            MessageBox.Show("Tiene que seleccionar un País", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else
            Estado = True

        End If

        Return Estado

    End Function

    Private Sub BusquedaFiltradasDepartamento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvDepartamento.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodoDepartamento()
        Else
            BusquedaFiltradasDepartamento()
        End If
    End Sub

End Class