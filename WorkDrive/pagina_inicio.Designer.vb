<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pagina_inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pagina_inicio))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel6 = New Panel()
        PictureBox13 = New PictureBox()
        PictureBox12 = New PictureBox()
        Label9 = New Label()
        Label10 = New Label()
        PictureBox14 = New PictureBox()
        Panel5 = New Panel()
        PictureBox10 = New PictureBox()
        PictureBox9 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        PictureBox11 = New PictureBox()
        Panel4 = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox8 = New PictureBox()
        Panel2 = New Panel()
        PictureBox5 = New PictureBox()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Panel3 = New Panel()
        ComboBox1 = New ComboBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        BtnSolicitar = New Button()
        txtTarifa = New TextBox()
        TxtDescripcion = New TextBox()
        txtDireccionActual = New TextBox()
        txtDireccion = New TextBox()
        mapa = New Microsoft.Web.WebView2.WinForms.WebView2()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(mapa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 637)
        Panel1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 44)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(PictureBox13)
        Panel6.Controls.Add(PictureBox12)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(PictureBox14)
        Panel6.Location = New Point(6, 385)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(230, 66)
        Panel6.TabIndex = 10
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), Image)
        PictureBox13.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox13.Location = New Point(67, 36)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(26, 23)
        PictureBox13.TabIndex = 7
        PictureBox13.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), Image)
        PictureBox12.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox12.Location = New Point(177, 23)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(27, 28)
        PictureBox12.TabIndex = 4
        PictureBox12.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(93, 42)
        Label9.Name = "Label9"
        Label9.Size = New Size(17, 15)
        Label9.TabIndex = 3
        Label9.Text = "11"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(63, 12)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 21)
        Label10.TabIndex = 1
        Label10.Text = "Cheff"
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackgroundImage = CType(resources.GetObject("PictureBox14.BackgroundImage"), Image)
        PictureBox14.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox14.Location = New Point(3, 3)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(58, 59)
        PictureBox14.TabIndex = 0
        PictureBox14.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(PictureBox10)
        Panel5.Controls.Add(PictureBox9)
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(PictureBox11)
        Panel5.Location = New Point(3, 313)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(230, 66)
        Panel5.TabIndex = 9
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(67, 39)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(26, 23)
        PictureBox10.TabIndex = 6
        PictureBox10.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(177, 23)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(27, 28)
        PictureBox9.TabIndex = 4
        PictureBox9.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Gray
        Label7.Location = New Point(94, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(21, 15)
        Label7.TabIndex = 3
        Label7.Text = "50"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(63, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 21)
        Label8.TabIndex = 1
        Label8.Text = "Electricistas"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackgroundImage = CType(resources.GetObject("PictureBox11.BackgroundImage"), Image)
        PictureBox11.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox11.Location = New Point(3, 12)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(56, 50)
        PictureBox11.TabIndex = 0
        PictureBox11.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(PictureBox7)
        Panel4.Controls.Add(PictureBox6)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(PictureBox8)
        Panel4.Location = New Point(3, 241)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(230, 66)
        Panel4.TabIndex = 8
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(67, 36)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(26, 23)
        PictureBox7.TabIndex = 5
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(177, 23)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(27, 28)
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(93, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(21, 15)
        Label5.TabIndex = 3
        Label5.Text = "32"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(63, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 21)
        Label6.TabIndex = 1
        Label6.Text = "Plomeros"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(3, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(58, 59)
        PictureBox8.TabIndex = 0
        PictureBox8.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(0, 169)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(230, 66)
        Panel2.TabIndex = 7
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(177, 23)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(27, 28)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(99, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(21, 15)
        Label4.TabIndex = 3
        Label4.Text = "48"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(71, 36)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(26, 23)
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(66, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 21)
        Label3.TabIndex = 1
        Label3.Text = "Mecanico"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(6, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(56, 59)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(25, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 21)
        Label1.TabIndex = 6
        Label1.Text = "Profesiones"
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleName = ""
        TextBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.Location = New Point(25, 67)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "buscar"
        TextBox1.Size = New Size(170, 32)
        TextBox1.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(BtnSolicitar)
        Panel3.Controls.Add(txtTarifa)
        Panel3.Controls.Add(TxtDescripcion)
        Panel3.Controls.Add(txtDireccionActual)
        Panel3.Controls.Add(txtDireccion)
        Panel3.ForeColor = SystemColors.Control
        Panel3.Location = New Point(748, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(228, 637)
        Panel3.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Tranferencia", "Efectivo", ""})
        ComboBox1.Location = New Point(82, 506)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(33, 497)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 36)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(22, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 38)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' BtnSolicitar
        ' 
        BtnSolicitar.BackColor = Color.SteelBlue
        BtnSolicitar.FlatStyle = FlatStyle.Flat
        BtnSolicitar.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSolicitar.ForeColor = SystemColors.ButtonHighlight
        BtnSolicitar.Location = New Point(33, 563)
        BtnSolicitar.Name = "BtnSolicitar"
        BtnSolicitar.Size = New Size(170, 45)
        BtnSolicitar.TabIndex = 4
        BtnSolicitar.Text = "Solicitar"
        BtnSolicitar.UseVisualStyleBackColor = False
        ' 
        ' txtTarifa
        ' 
        txtTarifa.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtTarifa.Location = New Point(33, 436)
        txtTarifa.Multiline = True
        txtTarifa.Name = "txtTarifa"
        txtTarifa.PlaceholderText = "Tarifa"
        txtTarifa.Size = New Size(170, 32)
        txtTarifa.TabIndex = 3
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TxtDescripcion.Location = New Point(33, 243)
        TxtDescripcion.Multiline = True
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.PlaceholderText = "Descripcion"
        TxtDescripcion.Size = New Size(170, 144)
        TxtDescripcion.TabIndex = 2
        ' 
        ' txtDireccionActual
        ' 
        txtDireccionActual.AccessibleName = ""
        txtDireccionActual.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDireccionActual.Location = New Point(33, 128)
        txtDireccionActual.Multiline = True
        txtDireccionActual.Name = "txtDireccionActual"
        txtDireccionActual.PlaceholderText = "A"
        txtDireccionActual.Size = New Size(170, 32)
        txtDireccionActual.TabIndex = 1
        ' 
        ' txtDireccion
        ' 
        txtDireccion.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDireccion.Location = New Point(33, 181)
        txtDireccion.Multiline = True
        txtDireccion.Name = "txtDireccion"
        txtDireccion.PlaceholderText = "Direccion"
        txtDireccion.Size = New Size(170, 32)
        txtDireccion.TabIndex = 0
        ' 
        ' mapa
        ' 
        mapa.AllowExternalDrop = True
        mapa.CreationProperties = Nothing
        mapa.DefaultBackgroundColor = Color.White
        mapa.Location = New Point(236, 0)
        mapa.Name = "mapa"
        mapa.Size = New Size(517, 637)
        mapa.TabIndex = 0
        mapa.ZoomFactor = 1R
        ' 
        ' pagina_inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(973, 639)
        Controls.Add(mapa)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "pagina_inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pagina_inicio"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(mapa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents mapa As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTarifa As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents txtDireccionActual As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents BtnSolicitar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Button1 As Button
End Class
