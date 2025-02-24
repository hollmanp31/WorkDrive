<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registro))
        Panel1 = New Panel()
        TxtContraseña = New TextBox()
        TxtEmail = New TextBox()
        CmbBTipoUsuario = New ComboBox()
        Label14 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        LinkLabel1 = New LinkLabel()
        Label7 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        Label3 = New Label()
        TxtApellidos = New TextBox()
        TxtNombre = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TxtContraseña)
        Panel1.Controls.Add(TxtEmail)
        Panel1.Controls.Add(CmbBTipoUsuario)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TxtApellidos)
        Panel1.Controls.Add(TxtNombre)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(230, 432)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(875, 742)
        Panel1.TabIndex = 0
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Location = New Point(488, 399)
        TxtContraseña.Multiline = True
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.Size = New Size(270, 61)
        TxtContraseña.TabIndex = 20
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(63, 399)
        TxtEmail.Multiline = True
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(268, 52)
        TxtEmail.TabIndex = 19
        ' 
        ' CmbBTipoUsuario
        ' 
        CmbBTipoUsuario.FormattingEnabled = True
        CmbBTipoUsuario.Location = New Point(63, 558)
        CmbBTipoUsuario.Name = "CmbBTipoUsuario"
        CmbBTipoUsuario.Size = New Size(341, 33)
        CmbBTipoUsuario.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.Gray
        Label14.Location = New Point(488, 175)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(102, 28)
        Label14.TabIndex = 17
        Label14.Text = "Apellidos "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(63, 502)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(341, 28)
        Label10.TabIndex = 12
        Label10.Text = "¿Desea registrarse como trabajador?"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(63, 344)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 28)
        Label9.TabIndex = 11
        Label9.Text = "Email"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        LinkLabel1.Location = New Point(160, 661)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(113, 25)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Iniciar sesion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.CausesValidation = False
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.DarkGray
        Label7.Location = New Point(140, 613)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 28)
        Label7.TabIndex = 6
        Label7.Text = "¿ tienes cuenta?,"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(488, 558)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(270, 58)
        Button1.TabIndex = 5
        Button1.Text = "Registrarse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(488, 344)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 28)
        Label5.TabIndex = 4
        Label5.Text = "Contraseña"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(63, 175)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 28)
        Label3.TabIndex = 3
        Label3.Text = "Nombres "
        ' 
        ' TxtApellidos
        ' 
        TxtApellidos.Location = New Point(488, 225)
        TxtApellidos.Margin = New Padding(4, 5, 4, 5)
        TxtApellidos.MaxLength = 100
        TxtApellidos.Multiline = True
        TxtApellidos.Name = "TxtApellidos"
        TxtApellidos.Size = New Size(268, 51)
        TxtApellidos.TabIndex = 2
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(63, 225)
        TxtNombre.Margin = New Padding(4, 5, 4, 5)
        TxtNombre.MaxLength = 50
        TxtNombre.Multiline = True
        TxtNombre.Name = "TxtNombre"
        TxtNombre.PlaceholderText = " "
        TxtNombre.Size = New Size(268, 51)
        TxtNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label1.Location = New Point(313, 40)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 40)
        Label1.TabIndex = 0
        Label1.Text = "Registrarse"
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
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(1087, 258)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(150, 32)
        Label11.TabIndex = 11
        Label11.Text = "Contactanos"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(840, 258)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(178, 32)
        Label12.TabIndex = 12
        Label12.Text = "Sobre nosotros"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ActiveCaption
        Label13.Location = New Point(80, 258)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(143, 32)
        Label13.TabIndex = 13
        Label13.Text = "Work Drive"
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.FromArgb(CByte(21), CByte(30), CByte(43))
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Panel1)
        Panel2.Location = New Point(-36, -217)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1285, 1315)
        Panel2.TabIndex = 2
        ' 
        ' registro
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(21), CByte(30), CByte(43))
        ClientSize = New Size(1247, 1050)
        Controls.Add(Panel2)
        Margin = New Padding(4, 5, 4, 5)
        Name = "registro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registro"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents CmbBTipoUsuario As ComboBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtEmail As TextBox
End Class
