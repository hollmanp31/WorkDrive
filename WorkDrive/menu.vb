Imports System.Drawing.Drawing2D

Public Class menu
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModoTrabajador.FlatStyle = FlatStyle.Flat
        ModoTrabajador.BackColor = Color.Transparent
        ModoTrabajador.Size = New Size(240, 45)

        ModoTrabajador.Invalidate()
    End Sub
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles ModoTrabajador.Paint
        Using brush As New LinearGradientBrush(ModoTrabajador.ClientRectangle, Color.DarkBlue, Color.DarkRed, 0.0F) ' De izquierda a derecha
            e.Graphics.FillRectangle(brush, ModoTrabajador.ClientRectangle)
        End Using

        TextRenderer.DrawText(e.Graphics, ModoTrabajador.Text, ModoTrabajador.Font, ModoTrabajador.ClientRectangle, ModoTrabajador.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ModoTrabajador.Click
        Pantalla_Trabajador.Show()
        Me.Hide()
        pagina_inicio.Hide()

    End Sub
End Class