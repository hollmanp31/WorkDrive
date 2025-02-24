<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        Label7 = New Label()
        Button1 = New Button()
        TxtContraseña = New TextBox()
        TxtNombre = New TextBox()
        Label1 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(-13, -4)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1214, 1188)
        Panel2.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TxtContraseña)
        Panel1.Controls.Add(TxtNombre)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(404, 304)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(392, 700)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Image = CType(resources.GetObject("Label3.Image"), Image)
        Label3.Location = New Point(6, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 80)
        Label3.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Image = CType(resources.GetObject("Label5.Image"), Image)
        Label5.Location = New Point(27, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 54)
        Label5.TabIndex = 11
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        LinkLabel1.Location = New Point(155, 645)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(90, 25)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Registrate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.CausesValidation = False
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.DarkGray
        Label7.Location = New Point(93, 601)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(216, 28)
        Label7.TabIndex = 6
        Label7.Text = "¿Aun no tienes cuenta?,"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(66, 524)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(270, 58)
        Button1.TabIndex = 5
        Button1.Text = "Iniciar sesion"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Location = New Point(93, 368)
        TxtContraseña.Margin = New Padding(4, 5, 4, 5)
        TxtContraseña.MaxLength = 50
        TxtContraseña.Multiline = True
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.PlaceholderText = "Ingrese su Contraseña "
        TxtContraseña.Size = New Size(268, 57)
        TxtContraseña.TabIndex = 2
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(93, 262)
        TxtNombre.Margin = New Padding(4, 5, 4, 5)
        TxtNombre.MaxLength = 50
        TxtNombre.Multiline = True
        TxtNombre.Name = "TxtNombre"
        TxtNombre.PlaceholderText = "Ingrese Su Usuario"
        TxtNombre.Size = New Size(268, 57)
        TxtNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.MediumPurple
        Label1.Location = New Point(93, 113)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 45)
        Label1.TabIndex = 0
        Label1.Text = "Iniciar sesion"
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Gainsboro
        Label9.Location = New Point(210, 237)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(783, 80)
        Label9.TabIndex = 12
        Label9.Text = "Work Drive conecta usuarios con proveedores locales, brindando reseñas y comunicación directa en una interfaz simple."
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(336, 102)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(593, 135)
        Label8.TabIndex = 11
        Label8.Text = "Work Drive"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaption
        Label6.Location = New Point(43, 35)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(172, 40)
        Label6.TabIndex = 10
        Label6.Text = "Work Drive"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(793, 42)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 32)
        Label2.TabIndex = 9
        Label2.Text = "Sobre nosotros"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(1017, 42)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 32)
        Label4.TabIndex = 8
        Label4.Text = "Contactanos"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1200, 1048)
        Controls.Add(Panel2)
        Margin = New Padding(4, 5, 4, 5)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
