<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtModeloaño = New System.Windows.Forms.TextBox
        Me.txtVersión = New System.Windows.Forms.TextBox
        Me.txtMarca = New System.Windows.Forms.TextBox
        Me.txtDominio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.c = New System.Windows.Forms.Label
        Me.dominio = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(254, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 31)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "CLIENTES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 40)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Ingresar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 40)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Modificar Cliente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(395, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 40)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Eliminar Cliente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(260, 332)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 37)
        Me.btnBuscar.TabIndex = 51
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtModeloaño
        '
        Me.txtModeloaño.Location = New System.Drawing.Point(93, 301)
        Me.txtModeloaño.Name = "txtModeloaño"
        Me.txtModeloaño.ReadOnly = True
        Me.txtModeloaño.Size = New System.Drawing.Size(146, 20)
        Me.txtModeloaño.TabIndex = 45
        '
        'txtVersión
        '
        Me.txtVersión.Location = New System.Drawing.Point(93, 248)
        Me.txtVersión.Name = "txtVersión"
        Me.txtVersión.ReadOnly = True
        Me.txtVersión.Size = New System.Drawing.Size(146, 20)
        Me.txtVersión.TabIndex = 44
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(93, 193)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(146, 20)
        Me.txtMarca.TabIndex = 43
        '
        'txtDominio
        '
        Me.txtDominio.Location = New System.Drawing.Point(93, 128)
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.ReadOnly = True
        Me.txtDominio.Size = New System.Drawing.Size(146, 20)
        Me.txtDominio.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Modelo / Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Versión"
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Location = New System.Drawing.Point(90, 160)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(37, 13)
        Me.c.TabIndex = 39
        Me.c.Text = "Marca"
        '
        'dominio
        '
        Me.dominio.AutoSize = True
        Me.dominio.Location = New System.Drawing.Point(90, 102)
        Me.dominio.Name = "dominio"
        Me.dominio.Size = New System.Drawing.Size(45, 13)
        Me.dominio.TabIndex = 38
        Me.dominio.Text = "Dominio"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(446, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 54
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(446, 177)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(146, 20)
        Me.TextBox2.TabIndex = 55
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(446, 216)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(146, 20)
        Me.TextBox3.TabIndex = 56
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(446, 248)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(146, 20)
        Me.TextBox4.TabIndex = 57
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(446, 301)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(146, 20)
        Me.TextBox5.TabIndex = 58
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(258, 177)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(146, 20)
        Me.TextBox6.TabIndex = 59
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(258, 248)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(146, 20)
        Me.TextBox7.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Motor Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Motor Chasis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Nombre y Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Tipo y Número de Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(443, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Fecha de Nacimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(443, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Teléfono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "E-mail"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 400)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtModeloaño)
        Me.Controls.Add(Me.txtVersión)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtDominio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.dominio)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Form1"
        Me.Text = "CLIENTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtModeloaño As System.Windows.Forms.TextBox
    Friend WithEvents txtVersión As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtDominio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.Label
    Friend WithEvents dominio As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
