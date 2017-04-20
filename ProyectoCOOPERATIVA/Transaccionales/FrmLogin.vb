Imports System.Data.SqlClient
Public Class FrmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtUsuario.Text = Nothing And TxtContrasena.Text = Nothing Then
            MessageBox.Show("Ingrese el nombre de usuario y contraseña", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            TxtUsuario.Focus()
        ElseIf TxtUsuario.Text = Nothing Then
            MessageBox.Show("Ingrese el nombre de usuario", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            TxtUsuario.Focus()
        ElseIf TxtContrasena.Text = Nothing Then
            MessageBox.Show("Ingrese la contraseña del usuario", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
            TxtContrasena.Focus()
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_Login"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text.Trim
                    .Parameters.Add("@Contrasena", SqlDbType.NVarChar, 100).Value = TxtContrasena.Text.Trim
                End With
                Dim LectorUsuario As SqlDataReader = cmd.ExecuteReader
                If LectorUsuario.Read Then

                    If LectorUsuario("Estado").ToString = "True" Then
                        Me.Hide()
                        PantallaPrincipal.LblOficialNombre.Text = "Oficial: " + LectorUsuario("Oficial").ToString
                        PantallaPrincipal.LblIdOficial.Text = LectorUsuario("IdOficial").ToString
                        TxtContrasena.Clear()
                        TxtUsuario.Clear()
                        PantallaPrincipal.Show()
                    Else
                        MessageBox.Show("Usuario Inactivo", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    MessageBox.Show("Nombre de usuario o contraseña incorrecta", "SYS CAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub


    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK.PerformClick()
        End If
    End Sub
End Class
