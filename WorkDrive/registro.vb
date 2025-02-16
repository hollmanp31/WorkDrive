Imports System.Drawing.Drawing2D

Public Class registro
    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(180, 0, 0, 0)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.Transparent
        Button1.Size = New Size(200, 40)

        Button1.Invalidate()
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
        If RadioButton1.Checked = True Then
            registro_trabajador.Show()
            Me.Hide()
        Else
            If RadioButton2.Checked = True Then
                Pagina_inicio.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class