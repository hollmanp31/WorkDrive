<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_foto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_foto))
        Panel2 = New Panel()
        Panel1 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(-53, -120)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(900, 790)
        Panel2.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(253, 210)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(425, 433)
        Panel1.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(110, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 35)
        Button1.TabIndex = 6
        Button1.Text = "Continuar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(247, 242)
        Button2.Name = "Button2"
        Button2.Size = New Size(66, 60)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(114, 117)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(185, 185)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label1.Location = New Point(107, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 37)
        Label1.TabIndex = 1
        Label1.Text = "Foto de perfil"
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
        ' form_foto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(841, 578)
        Controls.Add(Panel2)
        Name = "form_foto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form_foto"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
