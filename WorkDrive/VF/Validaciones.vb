Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Validaciones
    Public Function HashContraseña(ByVal contraseña As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytesContraseña As Byte() = Encoding.UTF8.GetBytes(contraseña)
            Return BitConverter.ToString(sha256.ComputeHash(bytesContraseña)).Replace("-", "").ToLower()
        End Using
    End Function

    Public Function EsLetra(ByVal car As Integer) As Boolean
        Try
            If Not (car >= 65 And car <= 90) And Not (car >= 97 And car <= 122) _
                And Not (car = 13) And Not (car = 8) And Not (car = 32) _
                And Not (car = 209) And Not (car = 241) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function EsNumero(ByVal car As Integer) As Boolean
        Try
            If Not (car >= 45 And car <= 57) And Not (car = 13) _
                And Not (car = 8) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
