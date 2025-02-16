<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro_trabajador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registro_trabajador))
        Panel2 = New Panel()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Label15 = New Label()
        cargar_archivo2 = New Button()
        Label14 = New Label()
        cargar_archivo = New Button()
        Label10 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Panel1)
        Panel2.Location = New Point(-13, -104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(900, 790)
        Panel2.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ActiveCaption
        Label13.Location = New Point(56, 132)
        Label13.Name = "Label13"
        Label13.Size = New Size(96, 21)
        Label13.TabIndex = 13
        Label13.Text = "Work Drive"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(588, 132)
        Label12.Name = "Label12"
        Label12.Size = New Size(123, 21)
        Label12.TabIndex = 12
        Label12.Text = "Sobre nosotros"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(761, 132)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 21)
        Label11.TabIndex = 11
        Label11.Text = "Contactanos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaption
        Label6.Location = New Point(30, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 25)
        Label6.TabIndex = 10
        Label6.Text = "Work Drive"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(555, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 21)
        Label2.TabIndex = 9
        Label2.Text = "Sobre nosotros"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(712, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 21)
        Label4.TabIndex = 8
        Label4.Text = "Contactanos"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(cargar_archivo2)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(cargar_archivo)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(151, 224)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(613, 446)
        Panel1.TabIndex = 0
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(94, 326)
        Label15.Name = "Label15"
        Label15.Size = New Size(51, 15)
        Label15.TabIndex = 21
        Label15.Text = "Nombre"
        ' 
        ' cargar_archivo2
        ' 
        cargar_archivo2.BackgroundImage = CType(resources.GetObject("cargar_archivo2.BackgroundImage"), Image)
        cargar_archivo2.BackgroundImageLayout = ImageLayout.Stretch
        cargar_archivo2.Location = New Point(44, 314)
        cargar_archivo2.Name = "cargar_archivo2"
        cargar_archivo2.Size = New Size(44, 39)
        cargar_archivo2.TabIndex = 20
        cargar_archivo2.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(374, 244)
        Label14.Name = "Label14"
        Label14.Size = New Size(51, 15)
        Label14.TabIndex = 19
        Label14.Text = "Nombre"
        ' 
        ' cargar_archivo
        ' 
        cargar_archivo.BackgroundImage = CType(resources.GetObject("cargar_archivo.BackgroundImage"), Image)
        cargar_archivo.BackgroundImageLayout = ImageLayout.Stretch
        cargar_archivo.Location = New Point(324, 227)
        cargar_archivo.Name = "cargar_archivo"
        cargar_archivo.Size = New Size(44, 39)
        cargar_archivo.TabIndex = 18
        cargar_archivo.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(44, 284)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 17)
        Label10.TabIndex = 17
        Label10.Text = "Curriculum"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Albalñil", "plomerista", "electrisista"})
        ComboBox2.Location = New Point(324, 134)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(189, 23)
        ComboBox2.TabIndex = 16
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"C.C", "Tarjeta Identidad", "Cedula extranjera"})
        ComboBox1.Location = New Point(44, 134)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(189, 23)
        ComboBox1.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(324, 197)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 17)
        Label9.TabIndex = 11
        Label9.Text = "Certificacion"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(44, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 17)
        Label8.TabIndex = 10
        Label8.Text = "Tipo de indentificacion"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(324, 314)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 35)
        Button1.TabIndex = 5
        Button1.Text = "Registrarse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(44, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 17)
        Label5.TabIndex = 4
        Label5.Text = "Numero documento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(324, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 17)
        Label3.TabIndex = 3
        Label3.Text = "Labor"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(44, 227)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(189, 32)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label1.Location = New Point(219, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 25)
        Label1.TabIndex = 0
        Label1.Text = "Registrarse"
        ' 
        ' registro_trabajador
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(874, 683)
        Controls.Add(Panel2)
        Name = "registro_trabajador"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registro_trabajador"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cargar_archivo As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cargar_archivo2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
