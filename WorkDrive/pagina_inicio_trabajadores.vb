Imports Microsoft.Web.WebView2.WinForms

Public Class pagina_inicio_trabajadores
    Private WithEvents webView As New WebView2()
    Private Sub pagina_inicio_trabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar WebView2
        webView.Dock = DockStyle.Fill
        mapa.Controls.Add(webView)

        ' Cargar Google Maps
        Dim url As String = $"https://www.google.com/maps/@10.8595,-74.7737"
        webView.Source = New Uri(url)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        menu.Show()
    End Sub
End Class