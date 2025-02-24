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
        cmbBSalario = New ComboBox()
        cmbBsexo = New ComboBox()
        cmbBlabor = New ComboBox()
        Button2 = New Button()
        Label15 = New Label()
        BtnCertificado = New Button()
        Label14 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Button1 = New Button()
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
        Panel2.Location = New Point(-19, -173)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1285, 1315)
        Panel2.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ActiveCaption
        Label13.Location = New Point(80, 220)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(143, 32)
        Label13.TabIndex = 13
        Label13.Text = "Work Drive"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(840, 220)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(178, 32)
        Label12.TabIndex = 12
        Label12.Text = "Sobre nosotros"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(1087, 220)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(150, 32)
        Label11.TabIndex = 11
        Label11.Text = "Contactanos"
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
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(1017, 42)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 32)
        Label4.TabIndex = 8
        Label4.Text = "Contactanos"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(cmbBSalario)
        Panel1.Controls.Add(cmbBsexo)
        Panel1.Controls.Add(cmbBlabor)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(BtnCertificado)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(216, 373)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(875, 742)
        Panel1.TabIndex = 0
        ' 
        ' cmbBSalario
        ' 
        cmbBSalario.FormattingEnabled = True
        cmbBSalario.Location = New Point(102, 326)
        cmbBSalario.Name = "cmbBSalario"
        cmbBSalario.Size = New Size(251, 33)
        cmbBSalario.TabIndex = 25
        ' 
        ' cmbBsexo
        ' 
        cmbBsexo.FormattingEnabled = True
        cmbBsexo.Location = New Point(503, 203)
        cmbBsexo.Name = "cmbBsexo"
        cmbBsexo.Size = New Size(251, 33)
        cmbBsexo.TabIndex = 24
        ' 
        ' cmbBlabor
        ' 
        cmbBlabor.FormattingEnabled = True
        cmbBlabor.Location = New Point(102, 203)
        cmbBlabor.Name = "cmbBlabor"
        cmbBlabor.Size = New Size(251, 33)
        cmbBlabor.TabIndex = 23
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(503, 383)
        Button2.Name = "Button2"
        Button2.Size = New Size(74, 73)
        Button2.TabIndex = 22
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(202, 487)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(78, 25)
        Label15.TabIndex = 21
        Label15.Text = "Nombre"
        ' 
        ' BtnCertificado
        ' 
        BtnCertificado.BackgroundImage = CType(resources.GetObject("BtnCertificado.BackgroundImage"), Image)
        BtnCertificado.BackgroundImageLayout = ImageLayout.Stretch
        BtnCertificado.Location = New Point(102, 466)
        BtnCertificado.Margin = New Padding(4, 5, 4, 5)
        BtnCertificado.Name = "BtnCertificado"
        BtnCertificado.Size = New Size(72, 67)
        BtnCertificado.TabIndex = 20
        BtnCertificado.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(623, 407)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(78, 25)
        Label14.TabIndex = 19
        Label14.Text = "Nombre"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(102, 404)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 28)
        Label10.TabIndex = 17
        Label10.Text = "Curriculum"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(503, 326)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 28)
        Label9.TabIndex = 11
        Label9.Text = "Certificacion"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(313, 619)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(270, 58)
        Button1.TabIndex = 5
        Button1.Text = "Registrarse"
        Button1.UseVisualStyleBackColor = True
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
        ' registro_trabajador
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1249, 1050)
        Controls.Add(Panel2)
        Margin = New Padding(4, 5, 4, 5)
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
    Friend WithEvents cmbBSalario As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cargar_archivo As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnCertificado As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbBsexo As ComboBox
    Friend WithEvents cmbBlabor As ComboBox
    Public Property BtnCurriculum As Button
End Class
