Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports Microsoft.Web.WebView2
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Transactions

Public Class registro
    Dim C_validaciones As New Validaciones

    Private read As Object

    Private Consultasql As String
    Private Id_registro As Object
    Private tipoUsuario As Object
    Private usr As Object
    Private cmd As MySqlCommand
    Private contraseñaHasheada As Object
    Private transaccion As MySqlTransaction
    Private ex As Object
    Public Property OpenFileDialog1 As Object
    Public Property BtnCertificado As Object
    Public Property Btncurrilum As Object
    Public Property Id_Empleado As Object



    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(180, 0, 0, 0)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.Transparent
        Button1.Size = New Size(200, 40)

        Button1.Invalidate()

        CmbBTipoUsuario.Items.Clear() ' Limpiar elementos existentes (opcional)
        CmbBTipoUsuario.Items.Add("Seleccionar tipo de registro")
        CmbBTipoUsuario.Items.Add("Empleado")
        CmbBTipoUsuario.Items.Add("Persona Natural")

        CmbBTipoUsuario.SelectedIndex = 0 ' Seleccionar el primer elemento (opcional)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Using brush As New LinearGradientBrush(Button1.ClientRectangle, Color.LightBlue, Color.DarkBlue, 0.0F) ' De izquierda a derecha
            e.Graphics.FillRectangle(brush, Button1.ClientRectangle)
        End Using

        TextRenderer.DrawText(e.Graphics, Button1.Text, Button1.Font, Button1.ClientRectangle, Button1.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Obtener datos y validar campos (igual que antes)
        Dim Id_registro As Integer
        Dim Nombre As String = TxtNombre.Text
        Dim Apellidos As String = TxtApellidos.Text
        Dim Email As String = TxtEmail.Text
        Dim Contraseña As String = TxtContraseña.Text

        Dim Id_Empleado As Integer











        If (TxtNombre.Text = "" Or TxtApellidos.Text = "" Or TxtEmail.Text = "" Or TxtContraseña.Text = "" Or CmbBTipoUsuario.Text = "") Then
            MessageBox.Show("Faltan datos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (ConexionBD()) Then

                Try

                    ' Hashear la contraseña
                    Dim contraseñaHasheada As String = C_validaciones.HashContraseña(TxtContraseña.Text)


                    ' Determinar el valor de Id_tipo_usuario
                    Dim Id_tipo_usuario As Integer = 1 ' Valor predeterminado
                    If CmbBTipoUsuario.SelectedItem IsNot Nothing AndAlso CmbBTipoUsuario.SelectedItem.ToString() = "Persona Natural" Then
                        Id_tipo_usuario = 1 ' Establecer Id_tipo_usuario en 1 para Persona Natural
                    End If

                    ' Si hay conexión a la BD...
                    Consultasql = "INSERT INTO registros (Nombre, Apellidos, Email, Contraseña, Id_tipo_usuario, Id_Empleado) VALUES (@Nombre, @Apellidos, @Email, @Contraseña, @Id_tipo_usuario, @Id_empleado)"
                    If conexion IsNot Nothing Then
                        Dim cmd As New MySqlCommand(Consultasql, conexion)

                        cmd.Parameters.AddWithValue("@Nombre", Nombre)
                        cmd.Parameters.AddWithValue("@Apellidos", Apellidos)
                        cmd.Parameters.AddWithValue("@Email", Email)
                        cmd.Parameters.AddWithValue("@Contraseña", contraseñaHasheada)
                        cmd.Parameters.AddWithValue("@Id_tipo_usuario", Id_tipo_usuario)
                        read = Leer_Registro(Consultasql)
                    End If
                    If read IsNot Nothing Then
                        If read.Read() Then
                            'Id_registro = Convert.ToInt32(cmd.ExecuteScalar())
                            Nombre = read("Email").ToString
                            Apellidos = read("Apellidos").ToString
                            Email = read("Email").ToString
                            Contraseña = read("Contraseña").ToString
                            Id_tipo_usuario = Convert.ToInt32(read("Id_tipo_usuario"))
                            read.Close()
                            MessageBox.Show("Usuario ya registrado " & Id_registro & Id_tipo_usuario, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Cerrar lector de datos
                            'TxtEmail.Focus() 

                            ' Asignar Id_Empleado y Id_tipo_usuario por separado
                            If read("Id_Empleado") IsNot DBNull.Value Then
                                Id_Empleado = Convert.ToInt32(read("Id_Empleado"))
                            Else
                                Id_Empleado = 0 ' O un valor predeterminado adecuado
                            End If


                            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                                ' Iniciar transacción
                                transaccion = conexion.BeginTransaction()
                                cmd.Transaction = transaccion



                                ' Consulta de inserción en la tabla usuarios
                                Consultasql = "INSERT INTO usuarios (usuario, Password) VALUES (@Email, @Contraseña)"
                                cmd = New MySqlCommand(Consultasql, conexion)

                                ' Agregar parámetros para la tabla usuarios
                                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text)
                                cmd.Parameters.AddWithValue("@Contraseña", contraseñaHasheada)

                                'Id_registro = Convert.ToInt32(cmd.ExecuteScalar())
                                cmd.ExecuteNonQuery()

                                ' Confirmar la transacción
                                transaccion.Commit()
                            End If
                            ' Revertir la transacción en caso de error
                            'If transaccion IsNot Nothing Then
                            'transaccion.Rollback()
                            'End If
                            'MessageBox.Show("Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            'If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                            'conexion.Close()
                            'End If
                        End If
                    Else
                        MessageBox.Show("Usuario no registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If


                Catch ex As MySqlException
            If transaccion IsNot Nothing Then transaccion.Rollback()
            MessageBox.Show("Error de base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
            If transaccion IsNot Nothing Then transaccion.Rollback()
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
            If read IsNot Nothing AndAlso Not read.IsClosed Then
                read.Close()
            End If
            End Try
            Else
                MessageBox.Show("No't exists connection with BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If 

            End If


        'Button1.Enabled = False ' Deshabilitar el botón
    End Sub

    ' Revertir la transacción en caso de error
    'If transaccion IsNot Nothing Then
    'transaccion.Rollback()
    'End If
    'MessageBox.Show("Error de base de datos: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)




    'Else'

    'End If





    'If Not ValidarCorreo(Email) Then
    'MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    'Return
    'End If


    'cmd.Parameters.AddWithValue("@Nombre", If(String.IsNullOrEmpty(TxtNombre.Text), DBNull.Value, TxtNombre.Text))




    Function ValidarCorreo(ByVal correo As String) As Boolean
        Dim regex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Return regex.IsMatch(correo)
    End Function

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CmbTipoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBTipoUsuario.SelectedIndexChanged
    End Sub

    Private Sub Button1_Disposed(sender As Object, e As EventArgs) Handles Button1.Disposed

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub TxtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True ' Evita el sonido de "ding"
            TxtNombre.Text = UCase(TxtNombre.Text)
            TxtApellidos.Focus()
        End If
    End Sub

    Private Sub TxtApellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtApellidos.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True ' Evita el sonido de "ding"
            TxtApellidos.Text = UCase(TxtApellidos.Text)
            TxtEmail.Focus()
        End If
    End Sub

    Private Sub TxtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True ' Evita el sonido de "ding"
            TxtEmail.Text = (TxtEmail.Text)
            TxtContraseña.Focus()
        End If
    End Sub

    Private Sub TxtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True ' Evita el sonido de "ding"
            TxtContraseña.Text = (TxtContraseña.Text)
            CmbBTipoUsuario.Focus()
        End If
    End Sub

    Private Sub cmbBTipoUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbBTipoUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True ' Evita el sonido de "ding"
            CmbBTipoUsuario.Text = (CmbBTipoUsuario.Text)
            Button1.Focus()
        End If
    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        If C_validaciones.EsLetra(Asc(e.KeyChar)) Then
            If Asc(e.KeyChar) = 13 Then
                TxtEmail.Text = UCase(TxtEmail.Text)
                TxtContraseña.Focus()
                'c_Varias.Tabula()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellidos.KeyPress
        If C_validaciones.EsLetra(Asc(e.KeyChar)) Then
            If Asc(e.KeyChar) = 13 Then
                TxtApellidos.Text = UCase(TxtApellidos.Text)
                TxtEmail.Focus()
                'c_Varias.Tabula()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtApellidos_TextChanged(sender As Object, e As EventArgs) Handles TxtApellidos.TextChanged

    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged

    End Sub

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub TxtContraseña_KeyPress_1(sender As Object, e As KeyPressEventArgs)

    End Sub
End Class