Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit

Public Class registro_trabajador

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Código para manejar el cambio en ComboBox1
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Código para manejar el cambio en ComboBox2
    End Sub

    Private Sub cargar_archivo_Click(sender As Object, e As EventArgs) Handles cargar_archivo.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Title = "Seleccionar un archivo"
        openFileDialog.Filter = "Todos los archivos (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFileName(openFileDialog.FileName)
            Label14.Text = fileName
        End If

    End Sub

    Private Sub cargar_archivo2_Click(sender As Object, e As EventArgs) Handles cargar_archivo2.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Title = "Seleccionar un archivo"
        openFileDialog.Filter = "Todos los archivos (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFileName(openFileDialog.FileName)
            Label15.Text = fileName
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Using brush As New LinearGradientBrush(Button1.ClientRectangle, Color.LightBlue, Color.DarkBlue, 0.0F) ' De izquierda a derecha
            e.Graphics.FillRectangle(brush, Button1.ClientRectangle)
        End Using

        TextRenderer.DrawText(e.Graphics, Button1.Text, Button1.Font, Button1.ClientRectangle, Button1.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub registro_trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(180, 0, 0, 0)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.Transparent
        Button1.Size = New Size(200, 40)

        Button1.Invalidate()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form_foto.Show()
    End Sub

End Class

