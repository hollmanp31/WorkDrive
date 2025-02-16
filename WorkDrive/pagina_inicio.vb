Imports Microsoft.Web.WebView2.WinForms
Imports System
Imports System.Drawing.Drawing2D

Public Class pagina_inicio
    Private WithEvents webView As New WebView2()

    Private Sub pagina_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar WebView2
        webView.Dock = DockStyle.Fill
        mapa.Controls.Add(webView)

        ' Cargar Google Maps
        Dim url As String = $"https://www.google.com/maps/@10.8595,-74.7737"
        webView.Source = New Uri(url)


        BtnSolicitar.FlatStyle = FlatStyle.Flat
        BtnSolicitar.BackColor = Color.Transparent
        BtnSolicitar.Size = New Size(180, 45)

        BtnSolicitar.Invalidate()
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged

    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles BtnSolicitar.Paint
        Using brush As New LinearGradientBrush(BtnSolicitar.ClientRectangle, Color.LightBlue, Color.DarkBlue, 0.0F) ' De izquierda a derecha
            e.Graphics.FillRectangle(brush, BtnSolicitar.ClientRectangle)
        End Using

        TextRenderer.DrawText(e.Graphics, BtnSolicitar.Text, BtnSolicitar.Font, BtnSolicitar.ClientRectangle, BtnSolicitar.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        pagina_inicio_trabajadores.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menu.Show()
    End Sub
End Class

