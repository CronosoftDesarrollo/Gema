<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes1
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
        Me.btnConfAgreg = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnSig = New System.Windows.Forms.Button
        Me.btnAnt = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.BtnCanc = New System.Windows.Forms.Button
        Me.txtModelo = New System.Windows.Forms.TextBox
        Me.txtVersion = New System.Windows.Forms.TextBox
        Me.txtMarca = New System.Windows.Forms.TextBox
        Me.txtDominio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.codigo_producto = New System.Windows.Forms.Label
        Me.btnElimcliente = New System.Windows.Forms.Button
        Me.btnModcliente = New System.Windows.Forms.Button
        Me.btnIngcliente = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtmotorchasis = New System.Windows.Forms.TextBox
        Me.txtmotormarca = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtFechan = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnConfAgreg
        '
        Me.btnConfAgreg.Location = New System.Drawing.Point(382, 455)
        Me.btnConfAgreg.Name = "btnConfAgreg"
        Me.btnConfAgreg.Size = New System.Drawing.Size(75, 23)
        Me.btnConfAgreg.TabIndex = 75
        Me.btnConfAgreg.Text = "Confirmar"
        Me.btnConfAgreg.UseVisualStyleBackColor = True
        Me.btnConfAgreg.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(283, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 31)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "CLIENTES"
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(382, 390)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(85, 47)
        Me.btnSig.TabIndex = 70
        Me.btnSig.Text = "> Siguiente >"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(220, 390)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(85, 47)
        Me.btnAnt.TabIndex = 69
        Me.btnAnt.Text = "< Anterior <"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(580, 156)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 40)
        Me.btnBuscar.TabIndex = 74
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCanc
        '
        Me.BtnCanc.Location = New System.Drawing.Point(220, 455)
        Me.BtnCanc.Name = "BtnCanc"
        Me.BtnCanc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCanc.TabIndex = 73
        Me.BtnCanc.Text = "Cancelar"
        Me.BtnCanc.UseVisualStyleBackColor = True
        Me.BtnCanc.Visible = False
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(102, 259)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(216, 20)
        Me.txtModelo.TabIndex = 68
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(102, 222)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(216, 20)
        Me.txtVersion.TabIndex = 67
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(102, 180)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(216, 20)
        Me.txtMarca.TabIndex = 66
        '
        'txtDominio
        '
        Me.txtDominio.Location = New System.Drawing.Point(102, 131)
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.ReadOnly = True
        Me.txtDominio.Size = New System.Drawing.Size(216, 20)
        Me.txtDominio.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "MODELO / AÑO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "VERSION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "MARCA"
        '
        'codigo_producto
        '
        Me.codigo_producto.AutoSize = True
        Me.codigo_producto.Location = New System.Drawing.Point(99, 106)
        Me.codigo_producto.Name = "codigo_producto"
        Me.codigo_producto.Size = New System.Drawing.Size(0, 13)
        Me.codigo_producto.TabIndex = 61
        '
        'btnElimcliente
        '
        Me.btnElimcliente.Location = New System.Drawing.Point(466, 59)
        Me.btnElimcliente.Name = "btnElimcliente"
        Me.btnElimcliente.Size = New System.Drawing.Size(97, 40)
        Me.btnElimcliente.TabIndex = 60
        Me.btnElimcliente.Text = "Eliminar cliente"
        Me.btnElimcliente.UseVisualStyleBackColor = True
        '
        'btnModcliente
        '
        Me.btnModcliente.Location = New System.Drawing.Point(305, 59)
        Me.btnModcliente.Name = "btnModcliente"
        Me.btnModcliente.Size = New System.Drawing.Size(103, 40)
        Me.btnModcliente.TabIndex = 59
        Me.btnModcliente.Text = "Modificar cliente"
        Me.btnModcliente.UseVisualStyleBackColor = True
        '
        'btnIngcliente
        '
        Me.btnIngcliente.Location = New System.Drawing.Point(146, 59)
        Me.btnIngcliente.Name = "btnIngcliente"
        Me.btnIngcliente.Size = New System.Drawing.Size(98, 40)
        Me.btnIngcliente.TabIndex = 58
        Me.btnIngcliente.Text = "Ingresar cliente"
        Me.btnIngcliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "DOMINIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "MOTOR MARCA"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(347, 259)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.ReadOnly = True
        Me.txtDni.Size = New System.Drawing.Size(216, 20)
        Me.txtDni.TabIndex = 84
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(347, 222)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(216, 20)
        Me.txtNombre.TabIndex = 83
        '
        'txtmotorchasis
        '
        Me.txtmotorchasis.Location = New System.Drawing.Point(347, 180)
        Me.txtmotorchasis.Name = "txtmotorchasis"
        Me.txtmotorchasis.ReadOnly = True
        Me.txtmotorchasis.Size = New System.Drawing.Size(216, 20)
        Me.txtmotorchasis.TabIndex = 82
        '
        'txtmotormarca
        '
        Me.txtmotormarca.Location = New System.Drawing.Point(347, 131)
        Me.txtmotormarca.Name = "txtmotormarca"
        Me.txtmotormarca.ReadOnly = True
        Me.txtmotormarca.Size = New System.Drawing.Size(216, 20)
        Me.txtmotormarca.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "NÚMERO DE DOCUMENRO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "NOMBRE Y APELLIDO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "MOTOR CHASIS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(344, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 77
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(347, 303)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(216, 20)
        Me.txtTelefono.TabIndex = 92
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(344, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "TELEFONO"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(269, 340)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(216, 20)
        Me.txtEmail.TabIndex = 89
        '
        'txtFechan
        '
        Me.txtFechan.Location = New System.Drawing.Point(102, 303)
        Me.txtFechan.Name = "txtFechan"
        Me.txtFechan.ReadOnly = True
        Me.txtFechan.Size = New System.Drawing.Size(216, 20)
        Me.txtFechan.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(266, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "E-MAIL"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(99, 287)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "FECHA DE NACIMIENTO"
        '
        'clientes1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 490)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFechan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtmotorchasis)
        Me.Controls.Add(Me.txtmotormarca)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfAgreg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.BtnCanc)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtDominio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codigo_producto)
        Me.Controls.Add(Me.btnElimcliente)
        Me.Controls.Add(Me.btnModcliente)
        Me.Controls.Add(Me.btnIngcliente)
        Me.Name = "clientes1"
        Me.Text = "clientes1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConfAgreg As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnCanc As System.Windows.Forms.Button
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtDominio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codigo_producto As System.Windows.Forms.Label
    Friend WithEvents btnElimcliente As System.Windows.Forms.Button
    Friend WithEvents btnModcliente As System.Windows.Forms.Button
    Friend WithEvents btnIngcliente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtmotorchasis As System.Windows.Forms.TextBox
    Friend WithEvents txtmotormarca As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFechan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
