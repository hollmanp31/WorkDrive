Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports mysql.Data
Imports MySql.Data.MySqlClient
Public Class login
    Private reg As Object

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(180, 0, 0, 0)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.Transparent
        Button1.Size = New Size(200, 40)

        Button1.Invalidate()
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Using brush As New LinearGradientBrush(Button1.ClientRectangle, Color.DarkBlue, Color.DarkRed, 0.0F) ' De izquierda a derecha
            e.Graphics.FillRectangle(brush, Button1.ClientRectangle)
        End Using

        TextRenderer.DrawText(e.Graphics, Button1.Text, Button1.Font, Button1.ClientRectangle, Button1.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        registro.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Obtener correo y contraseña de los TextBox
        Dim correo As String = TxtEmail.Text
        Dim contraseña As String = TxtPassword.Text

        ' 2. Validar que no estén vacíos y que el correo tenga un formato válido
        If String.IsNullOrEmpty(correo) OrElse String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Ingrese correo y contraseña.", "Error")
            Return ' Salir del evento si hay campos vacíos
        End If

        If Not ValidarCorreo(correo) Then
            MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error")
            Return ' Salir del evento si el formato del correo es inválido
        End If

        Using conexion As New MySqlConnection("server=localhost;database=workdrive;user id=root;")

            Try
                ' 3. Abrir conexión a la base de datos
                conexion.Open()

                ' 4. Crear comando SQL parametrizado (PREVIENE INYECCIÓN DE SQL)
                Dim stm As String = "SELECT * FROM usuarios WHERE Email = @correo AND contraseña = @contraseña"
                Dim cmd As New MySqlCommand(stm, conexion)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.Parameters.AddWithValue("@contraseña", contraseña)

                ' 5. Ejecutar consulta y leer resultados
                Dim reg As MySqlDataReader = cmd.ExecuteReader()

                If reg.Read() Then ' Si se encontraron resultados...
                    Dim Nombre As String = reg.GetString("Usuario")

                    ' 6. Mostrar mensaje de éxito
                    MessageBox.Show("¡Bienvenido, " & Nombre & "!", "Éxito")

                    ' 7. (Opcional) Abrir otro formulario, etc. 
                    Me.Hide()
                    Dim nuevoFormulario As New pagina_inicio()
                    nuevoFormulario.Show()
                Else ' Si no se encontraron resultados...
                    ' 8. Mostrar mensaje de error
                    MessageBox.Show("Correo o contraseña incorrectos.", "Error")
                End If

                ' 9. Cerrar conexión y lector
                reg.Close()
                conexion.Close()

            Catch ex As MySqlException  ' Captura excepciones de MySQL
                MessageBox.Show("Error de base de datos: " & ex.Message, "Error")
                ' Aquí podrías registrar el error en un archivo o base de datos para depuración

            Catch ex As InvalidCastException ' Captura error si los tipos de datos no coinciden
                MessageBox.Show("Error en los datos recuperados: " & ex.Message, "Error")

            Catch ex As Exception ' Captura cualquier otra excepción (debe ir al final)
                MessageBox.Show("Error inesperado: " & ex.Message, "Error")
                ' También podrías registrar este error genérico

            Finally
                ' 9. Cerrar conexión y lector (siempre se ejecutan)
                If reg IsNot Nothing Then reg.Close() ' Verifica que reg no sea Nothing
                If conexion.State = ConnectionState.Open Then conexion.Close() ' Verifica el estado antes de cerrar
            End Try
        End Using
    End Sub

    Function ValidarCorreo(ByVal correo As String) As Boolean
        Dim regex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Return regex.IsMatch(correo)
    End Function


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub
End Class