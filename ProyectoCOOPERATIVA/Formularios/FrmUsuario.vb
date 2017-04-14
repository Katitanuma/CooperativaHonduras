Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmUsuario
    Private Sub PbSalir_Click(sender As Object, e As EventArgs) Handles PbSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmOficial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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

    Private Function ValidarUsuario() As Boolean
        Dim Estado As Boolean
        If TxtUsuario.Text = Nothing Then
            MsgBox("Ingrese el nombre de usuario", MsgBoxStyle.Critical, "Control Keeper")
            TxtUsuario.Focus()
            Estado = False
        ElseIf TxtContrasena.Text = Nothing Then
            MsgBox("ingrese la contraseña", MsgBoxStyle.Critical, "Control Keeper")
            txtContrasena.Focus()
            Estado = False
        ElseIf CboTipoAcceso.Text = Nothing Then
            MsgBox("Seleccione el tipo de acceso", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboOficial.Text = Nothing Then
            MsgBox("Seleccione el oficial", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodosUsuarios()
        Call LlenarComboBoxTipoAcceso()
        Call LlenarComboBoxOficial()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlUsuario.Enabled = Panel
    End Sub
    Private Sub MostrarTodosUsuarios()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorUsuario.Fill(dt)
                DgvUsuario.DataSource = dt
                DgvUsuario.Columns(2).Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los usuarios " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoUsuario()
    End Sub
    Private Sub LlenarComboBoxTipoAcceso()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoTipoAcceso"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorTipoAcceso As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorTipoAcceso.Fill(ds, "TipoAcceso")
                CboTipoAcceso.DataSource = ds.Tables(0)
                CboTipoAcceso.DisplayMember = ds.Tables(0).Columns("TipoAcceso").ToString
                CboTipoAcceso.ValueMember = ds.Tables(0).Columns("IdTipoAcceso").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar tipo acceso " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Public Sub LlenarComboBoxOficial()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarOficialIdentificacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorOficial As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorOficial.Fill(ds, "Oficial")
                CboOficial.DataSource = ds.Tables(0)
                CboOficial.DisplayMember = ds.Tables(0).Columns("NombreCompletoOficial").ToString
                CboOficial.ValueMember = ds.Tables(0).Columns("IdOficial").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el nombre completo de los oficiales " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub GuardarUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text.Trim
                    .Parameters.Add("@Constrasena", SqlDbType.NVarChar, 100).Value = TxtContrasena.Text.Trim
                    .Parameters.Add("@IdTipoAcceso", SqlDbType.Int).Value = CInt(CboTipoAcceso.SelectedValue)
                    .Parameters.Add("@IdOficial", SqlDbType.VarChar, 15).Value = CboOficial.SelectedValue.ToString
                    .Parameters.Add("@Estado", SqlDbType.Bit).Value = IdentificarEstado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Usuario Registrado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el usuario " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarUsuario() = True Then
            If ExisteNombreUsuario() = False Then
                Call GuardarUsuario()
                Call MostrarTodosUsuarios()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado ese usuario", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If


    End Sub
    Private Sub Limpiar()
        TxtIdUsuario.Clear()
        TxtUsuario.Clear()
        TxtContrasena.Clear()
        CboOficial.Text = Nothing
        CboTipoAcceso.Text = Nothing
        ChkEstado.Checked = False
    End Sub
    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstado.CheckedChanged
        If ChkEstado.CheckState = CheckState.Checked Then
            ChkEstado.Text = "Activo"
        Else
            ChkEstado.Text = "Inactivo"
        End If
    End Sub
    Private Function IdentificarEstado() As Integer
        Dim var As Integer
        If ChkEstado.CheckState = CheckState.Checked Then
            var = 1
        Else
            var = 0
        End If
        Return var
    End Function
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TbcUsuario.SelectedIndex = 0
        TxtIdUsuario.Text = DgvUsuario.CurrentRow.Cells(0).Value
        TxtUsuario.Text = DgvUsuario.CurrentRow.Cells(1).Value.ToString
        txtContrasena.Text = DgvUsuario.CurrentRow.Cells(2).Value.ToString
        CboTipoAcceso.Text = DgvUsuario.CurrentRow.Cells(3).Value.ToString
        CboOficial.Text = DgvUsuario.CurrentRow.Cells(4).Value.ToString

        If DgvUsuario.CurrentRow.Cells(5).Value.ToString = "True" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If
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
                    .CommandText = "Sp_ActualizarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(TxtIdUsuario.Text)
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text.Trim
                    .Parameters.Add("@Constrasena", SqlDbType.NVarChar, 100).Value = txtContrasena.Text.Trim
                    .Parameters.Add("@IdTipoAcceso", SqlDbType.Int).Value = CInt(CboTipoAcceso.SelectedValue)
                    .Parameters.Add("@IdOficial", SqlDbType.VarChar, 15).Value = CboOficial.SelectedValue.ToString
                    .Parameters.Add("@Estado", SqlDbType.Bit).Value = IdentificarEstado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Usuario editado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar el usuario " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(DgvUsuario.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Usuario eliminado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el usuario " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarUsuario() = True Then
            Call EditarUsuario()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodosUsuarios()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarUsuario()
            Call MostrarTodosUsuarios()
        End If
    End Sub

    Private Sub InvestigarCorrelativoUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdUsuario.Text = 1
                    Else
                        TxtIdUsuario.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteNombreUsuario() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text.Trim
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

    Private Sub BusquedaFiltradasUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvUsuario.DataSource = dt
                DgvUsuario.Columns(2).Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosUsuarios()
        Else
            BusquedaFiltradasUsuario()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PbLupa_Click(sender As Object, e As EventArgs) Handles PbLupa.Click

    End Sub
End Class