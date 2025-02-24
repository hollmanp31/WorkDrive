Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit

Public Class registro_trabajador
    Private placeholder As Object
    Public Property Nombre As String
    Public Property Apellidos As String
    Public Property Email As String
    Public Property Password As String
    Public Property Tipo_usuario As Integer
    Public Property Id_Empleado As Integer

    Private Sub cmbBSalario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBlabor.SelectedIndexChanged
        placeholder = "Seleccione su Salario Promedio"
    End Sub

    Private Sub cmbBSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBsexo.SelectedIndexChanged
        placeholder = "Seleccione su Sexo"
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

    Private Sub cargar_archivo2_Click(sender As Object, e As EventArgs) Handles BtnCertificado.Click

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

        cmbBlabor.Items.Clear() ' Limpiar elementos existentes (opcional) 

        cmbBsexo.Items.Clear() ' Limpiar elementos existentes (opcional)
        'cmbBsexo.Items.Add("Seleccione su tipode sexo")
        cmbBsexo.Items.Add("Masculino")
        cmbBsexo.Items.Add("femenino")
        cmbBsexo.Items.Add("Prefiero no decirlo")
        cmbBsexo.Items.Add("otro")

        cmbBlabor.Items.Clear() ' Limpiar elementos existentes (opcional) 
        'cmbBSalario.Items.Add("Seleccione su salario")
        cmbBSalario.Items.Add("Menos de 1 SMMLV")
        cmbBSalario.Items.Add("1 SMMLV")
        cmbBSalario.Items.Add("2 SMMLV")
        cmbBSalario.Items.Add("3 SMMLV")
        cmbBSalario.Items.Add("4 SMMLV")
        cmbBSalario.Items.Add("5 SMMLV o mas")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class

