Imports Microsoft.Web.WebView2.WinForms
Imports System
Imports System.Drawing.Drawing2D
Imports System.Net
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms

Public Class pagina_inicio
    Private WithEvents WebView As New WebView2()
    Private webBrowser1 As Object
    Public Property GMapControl1 As Object

    Private Sub pagina_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gmap.Source = New Uri("\Projects_JavaScript_HP\index.html")

        'Try
        'webBrowser1.Navigate(Application.StartupPath & "\Projects_JavaScript_HP\index.html")
        'Catch ex As NullReferenceException
        ' Manejar la excepción
        'MessageBox.Show("Error: " & ex.Message)
        'End Try


        ' Configuración del control GMap
        'GMapControl1.DragButton = MouseButtons.Left
        'GMapControl1.CanDragMap = True
        'GMapControl1.MapProvider = GMapProviders.OpenStreetMap
        'GMapControl1.Position = New PointLatLng(4.6097, -74.0817) ' Bogotá
        'GMapControl1.MinZoom = 2
        'GMapControl1.MaxZoom = 18
        'GMapControl1.Zoom = 12
        'GMapControl1.AutoScroll = True

        'Inicializar WebView2
        WebView.Dock = DockStyle.Fill
        mapa.Controls.Add(webView)

        'Cargar Google Maps
        Dim url As String = $"https://www.google.com/maps/@10.8595,-74.7737"
        WebView.Source = New Uri(url)


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

    Private Sub WebView21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles map.Paint

    End Sub
End Class

