Imports System.Drawing.Drawing2D

Public Class Pantalla_Trabajador
    Private Sub Pantalla_Trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoUsuario.FlatStyle = FlatStyle.Flat
        ModoUsuario.BackColor = Color.Transparent
        ModoUsuario.Size = New Size(240, 45)

        ModoUsuario.Invalidate()
    End Sub
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles ModoUsuario.Paint
        Using brush As New LinearGradientBrush(ModoUsuario.ClientRectangle, Color.DarkBlue, Color.DarkRed, 0.0F) ' De izquierda a derecha
            e.Graphics.FillRectangle(brush, ModoUsuario.ClientRectangle)
        End Using

        TextRenderer.DrawText(e.Graphics, ModoUsuario.Text, ModoUsuario.Font, ModoUsuario.ClientRectangle, ModoUsuario.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ModoUsuario.Click
        pagina_inicio.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class