Imports System.Data.Common
Imports System.Security.Cryptography
Imports System.Text
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports MySql.Data.MySqlClient

Module conectarBD
    Public conexion As New MySqlConnection("server=localhost;database=project_workdrive;user id=root;")
    Public orden As MySqlCommand
    Private adaptador As MySqlDataAdapter
    Public texto As String = ""




    Public Function ConexionBD() As Boolean
        Try
            conexion.Open()
            Return True
        Catch ex As Exception
            'MessageBox.Show("Error de conexión: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Leer_Registro(ByVal sqll As String) As MySqlDataReader
        Try
            orden = New MySqlCommand(sqll, conexion)
            Return orden.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Error al Leer Registros en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

End Module
