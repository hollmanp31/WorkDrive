Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class login
    Dim C_validaciones As New Validaciones
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress, TxtNombre.KeyPress, TxtContraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SelectNextControl(ActiveControl, True, True, True, True)

            'Si el control actual es el último campo, simula el clic en el botón
            If ActiveControl Is TxtNombre.Text Then ' Reemplaza TxtUltimoCampo con el nombre real del último campo
                Button1.PerformClick()
            End If
        End If
    End Sub
    Private reg As Object
    Private reader As Object
    Private toolTipInfo As Object
    Private consultasql As String


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(180, 0, 0, 0)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.Transparent
        Button1.Size = New Size(200, 40)

        Button1.Invalidate()
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Using brush As New LinearGradientBrush(Button1.ClientRectangle, Color.DarkBlue, Color.MediumPurple, 0.0F) ' De izquierda a derecha
            e.Graphics.FillRectangle(brush, Button1.ClientRectangle)
        End Using

        TextRenderer.DrawText(e.Graphics, Button1.Text, Button1.Font, Button1.ClientRectangle, Button1.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        registro.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Obtener correo y contraseña de los TextBox
        Dim Nombre = TxtNombre.Text
        Dim Contraseña = TxtContraseña.Text

        ' Hashear la contraseña
        Dim contraseñaHasheada As String = C_validaciones.HashContraseña(TxtContraseña.Text)

        ' 2. Validar que no estén vacíos y que el correo tenga un formato válido
        If (TxtNombre.Text = "" Or TxtContraseña.Text = "") Then
            MessageBox.Show("Faltan datos por ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (ConexionBD()) Then ' Si hay conexión a la BD...
                consultasql = "SELECT U.usuario, U.Password FROM usuarios U WHERE 1"
                Dim cmd As New MySqlCommand(consultasql, conexion)
                cmd.Parameters.AddWithValue("@Nombre", Nombre)
                cmd.Parameters.AddWithValue("@Password", contraseñaHasheada)
                reader = Leer_Registro(consultasql)
                If reader.Read Then ' Si se encontraron resultados... 
                    'If (ValidarInicioSesion()) Then
                    '(TxtEmail.Text) And (TxtContraseña.Text) 
                    'End If
                    TxtNombre.Text = reader("Nombre").ToString

                    TxtContraseña.Text = reader("Contraseña").ToString
                    MsgBox("Bienvenido: " & TxtNombre.Text)  ' Mostrar mensaje de bienvenida 
                    reader.Close() ' Cerrar lector de datos 

                    pagina_inicio.Show() ' Mostrar formulario de inicio
                    Hide() ' Ocultar formulario actual
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Si no se encontraron resultados...
                End If
            Else
                ' Si no se encontraron resultados...

                MessageBox.Show("No't exists connection with BD, Inform to Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        'If Not ValidarCorreo(Email) Then
        'MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error")
        'Return ' Salir del evento si el formato del correo es inválido
        'End If








    End Sub

    Function ValidarCorreo(ByVal Email As String) As Boolean
        Dim regex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Return regex.IsMatch(Email)
    End Function


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim rutaImagen = "C:\Users\Palma\Desktop\Fondo.jpg"
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TxtEmail_Enter(sender As Object, e As EventArgs) Handles TxtNombre.Enter, TxtContraseña.Enter

    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub TxtEmail_TabIndexChanged(sender As Object, e As EventArgs) Handles TxtNombre.TabIndexChanged

    End Sub

    Private Sub TxtEmail_MouseEnter(sender As Object, e As EventArgs) Handles TxtNombre.MouseEnter

    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged

    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress




    End Sub

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContraseña.KeyPress
        If C_validaciones.EsNumero(Asc(e.KeyChar)) Then
            If Asc(e.KeyChar) = 13 Then
                TxtContraseña.Text = UCase(TxtContraseña.Text)
                Button1.Focus()
                'c_Varias.Tabula()
            End If
        Else
            e.Handled = True
        End If
    End Sub


End Class