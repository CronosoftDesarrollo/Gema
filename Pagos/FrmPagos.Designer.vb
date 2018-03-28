<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagos))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblNroCh = New System.Windows.Forms.Label
        Me.lblBanco = New System.Windows.Forms.Label
        Me.lblImporte = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDominio = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.cmbConcepto = New System.Windows.Forms.ComboBox
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox
        Me.txtCh1 = New System.Windows.Forms.TextBox
        Me.txtBanco1 = New System.Windows.Forms.TextBox
        Me.txtImporte1 = New System.Windows.Forms.TextBox
        Me.txtCh2 = New System.Windows.Forms.TextBox
        Me.txtBanco2 = New System.Windows.Forms.TextBox
        Me.txtImporte2 = New System.Windows.Forms.TextBox
        Me.txtMontoTotal = New System.Windows.Forms.TextBox
        Me.txtImportePagado = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNro_recibo = New System.Windows.Forms.TextBox
        Me.btnBuscarRec = New System.Windows.Forms.Button
        Me.txtPara = New System.Windows.Forms.TextBox
        Me.txtAsunto = New System.Windows.Forms.TextBox
        Me.txtMensaje = New System.Windows.Forms.TextBox
        Me.lblPara = New System.Windows.Forms.Label
        Me.lblAsunto = New System.Windows.Forms.Label
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.btnEnviarMail = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtletras = New System.Windows.Forms.TextBox
        Me.btnMenos = New System.Windows.Forms.Button
        Me.btnMas = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dominio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Concepto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Forma de Pago"
        '
        'lblNroCh
        '
        Me.lblNroCh.AutoSize = True
        Me.lblNroCh.Location = New System.Drawing.Point(345, 195)
        Me.lblNroCh.Name = "lblNroCh"
        Me.lblNroCh.Size = New System.Drawing.Size(64, 13)
        Me.lblNroCh.TabIndex = 5
        Me.lblNroCh.Text = "Nro Cheque"
        Me.lblNroCh.Visible = False
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(460, 195)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblBanco.TabIndex = 6
        Me.lblBanco.Text = "Banco"
        Me.lblBanco.Visible = False
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(612, 195)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 7
        Me.lblImporte.Text = "Importe"
        Me.lblImporte.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Monto Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Importe a Pagar"
        '
        'txtDominio
        '
        Me.txtDominio.Location = New System.Drawing.Point(132, 56)
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.Size = New System.Drawing.Size(100, 20)
        Me.txtDominio.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(132, 99)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(132, 139)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 12
        '
        'cmbConcepto
        '
        Me.cmbConcepto.FormattingEnabled = True
        Me.cmbConcepto.Items.AddRange(New Object() {"Honorarios", "Tramites", "Honorarios + Tramites"})
        Me.cmbConcepto.Location = New System.Drawing.Point(132, 178)
        Me.cmbConcepto.Name = "cmbConcepto"
        Me.cmbConcepto.Size = New System.Drawing.Size(175, 21)
        Me.cmbConcepto.TabIndex = 13
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Cheque", "Efectivo", "Transferencia"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(132, 221)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormaPago.TabIndex = 14
        '
        'txtCh1
        '
        Me.txtCh1.Location = New System.Drawing.Point(348, 220)
        Me.txtCh1.Name = "txtCh1"
        Me.txtCh1.Size = New System.Drawing.Size(100, 20)
        Me.txtCh1.TabIndex = 15
        Me.txtCh1.Visible = False
        '
        'txtBanco1
        '
        Me.txtBanco1.Location = New System.Drawing.Point(463, 223)
        Me.txtBanco1.Name = "txtBanco1"
        Me.txtBanco1.Size = New System.Drawing.Size(146, 20)
        Me.txtBanco1.TabIndex = 16
        Me.txtBanco1.Visible = False
        '
        'txtImporte1
        '
        Me.txtImporte1.Location = New System.Drawing.Point(615, 223)
        Me.txtImporte1.Name = "txtImporte1"
        Me.txtImporte1.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte1.TabIndex = 17
        Me.txtImporte1.Visible = False
        '
        'txtCh2
        '
        Me.txtCh2.Location = New System.Drawing.Point(348, 246)
        Me.txtCh2.Name = "txtCh2"
        Me.txtCh2.Size = New System.Drawing.Size(100, 20)
        Me.txtCh2.TabIndex = 18
        Me.txtCh2.Visible = False
        '
        'txtBanco2
        '
        Me.txtBanco2.Location = New System.Drawing.Point(463, 246)
        Me.txtBanco2.Name = "txtBanco2"
        Me.txtBanco2.Size = New System.Drawing.Size(146, 20)
        Me.txtBanco2.TabIndex = 19
        Me.txtBanco2.Visible = False
        '
        'txtImporte2
        '
        Me.txtImporte2.Location = New System.Drawing.Point(615, 246)
        Me.txtImporte2.Name = "txtImporte2"
        Me.txtImporte2.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte2.TabIndex = 20
        Me.txtImporte2.Visible = False
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(132, 264)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoTotal.TabIndex = 21
        '
        'txtImportePagado
        '
        Me.txtImportePagado.Location = New System.Drawing.Point(132, 309)
        Me.txtImportePagado.Name = "txtImportePagado"
        Me.txtImportePagado.Size = New System.Drawing.Size(100, 20)
        Me.txtImportePagado.TabIndex = 22
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(238, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(29, 23)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(379, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Recibo Nro"
        '
        'txtNro_recibo
        '
        Me.txtNro_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro_recibo.Location = New System.Drawing.Point(501, 47)
        Me.txtNro_recibo.Name = "txtNro_recibo"
        Me.txtNro_recibo.Size = New System.Drawing.Size(166, 31)
        Me.txtNro_recibo.TabIndex = 26
        '
        'btnBuscarRec
        '
        Me.btnBuscarRec.Location = New System.Drawing.Point(673, 55)
        Me.btnBuscarRec.Name = "btnBuscarRec"
        Me.btnBuscarRec.Size = New System.Drawing.Size(29, 23)
        Me.btnBuscarRec.TabIndex = 27
        Me.btnBuscarRec.Text = "..."
        Me.btnBuscarRec.UseVisualStyleBackColor = True
        '
        'txtPara
        '
        Me.txtPara.Location = New System.Drawing.Point(474, 300)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(241, 20)
        Me.txtPara.TabIndex = 30
        Me.txtPara.Visible = False
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(474, 326)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(241, 20)
        Me.txtAsunto.TabIndex = 31
        Me.txtAsunto.Visible = False
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(474, 352)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(241, 67)
        Me.txtMensaje.TabIndex = 32
        Me.txtMensaje.Visible = False
        '
        'lblPara
        '
        Me.lblPara.AutoSize = True
        Me.lblPara.Location = New System.Drawing.Point(435, 303)
        Me.lblPara.Name = "lblPara"
        Me.lblPara.Size = New System.Drawing.Size(32, 13)
        Me.lblPara.TabIndex = 33
        Me.lblPara.Text = "Para:"
        Me.lblPara.Visible = False
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Location = New System.Drawing.Point(423, 333)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(43, 13)
        Me.lblAsunto.TabIndex = 34
        Me.lblAsunto.Text = "Asunto:"
        Me.lblAsunto.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(423, 352)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(50, 13)
        Me.lblMensaje.TabIndex = 35
        Me.lblMensaje.Text = "Mensaje:"
        Me.lblMensaje.Visible = False
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(579, 438)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(109, 92)
        Me.btnEnviar.TabIndex = 36
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnviar.UseVisualStyleBackColor = True
        Me.btnEnviar.Visible = False
        '
        'btnEnviarMail
        '
        Me.btnEnviarMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarMail.Location = New System.Drawing.Point(247, 438)
        Me.btnEnviarMail.Name = "btnEnviarMail"
        Me.btnEnviarMail.Size = New System.Drawing.Size(109, 92)
        Me.btnEnviarMail.TabIndex = 29
        Me.btnEnviarMail.Text = "Correo "
        Me.btnEnviarMail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnviarMail.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(132, 438)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(109, 92)
        Me.btnImprimir.TabIndex = 28
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(16, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 93)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Acreditar Pago"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 24)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Acreditacion de Pagos"
        '
        'txtletras
        '
        Me.txtletras.Location = New System.Drawing.Point(50, 359)
        Me.txtletras.Name = "txtletras"
        Me.txtletras.Size = New System.Drawing.Size(322, 20)
        Me.txtletras.TabIndex = 39
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(714, 223)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(21, 23)
        Me.btnMenos.TabIndex = 41
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        Me.btnMenos.Visible = False
        '
        'btnMas
        '
        Me.btnMas.Location = New System.Drawing.Point(714, 222)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(21, 23)
        Me.btnMas.TabIndex = 42
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        Me.btnMas.Visible = False
        '
        'FrmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 554)
        Me.Controls.Add(Me.btnMas)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.txtletras)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblAsunto)
        Me.Controls.Add(Me.lblPara)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.btnEnviarMail)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnBuscarRec)
        Me.Controls.Add(Me.txtNro_recibo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtImportePagado)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.txtImporte2)
        Me.Controls.Add(Me.txtBanco2)
        Me.Controls.Add(Me.txtCh2)
        Me.Controls.Add(Me.txtImporte1)
        Me.Controls.Add(Me.txtBanco1)
        Me.Controls.Add(Me.txtCh1)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.cmbConcepto)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDominio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblBanco)
        Me.Controls.Add(Me.lblNroCh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPagos"
        Me.Text = "GeMa - Acreditacion de Pagos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNroCh As System.Windows.Forms.Label
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDominio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents txtCh1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco1 As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCh2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco2 As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtImportePagado As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNro_recibo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarRec As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnEnviarMail As System.Windows.Forms.Button
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents lblPara As System.Windows.Forms.Label
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtletras As System.Windows.Forms.TextBox
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents btnMas As System.Windows.Forms.Button

End Class
