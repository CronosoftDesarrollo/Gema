<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibo
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibo))
        Me.txtImportePagado = New System.Windows.Forms.TextBox
        Me.txtMontoTotal = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDominio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.txtFormapago = New System.Windows.Forms.TextBox
        Me.txtImporte2 = New System.Windows.Forms.TextBox
        Me.txtBanco2 = New System.Windows.Forms.TextBox
        Me.txtCh2 = New System.Windows.Forms.TextBox
        Me.txtImporte1 = New System.Windows.Forms.TextBox
        Me.txtBanco1 = New System.Windows.Forms.TextBox
        Me.txtCh1 = New System.Windows.Forms.TextBox
        Me.lblImporte = New System.Windows.Forms.Label
        Me.lblBanco = New System.Windows.Forms.Label
        Me.lblNroCh = New System.Windows.Forms.Label
        Me.txtNro_recibo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtImportePagado
        '
        Me.txtImportePagado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImportePagado.Enabled = False
        Me.txtImportePagado.Location = New System.Drawing.Point(373, 468)
        Me.txtImportePagado.Name = "txtImportePagado"
        Me.txtImportePagado.Size = New System.Drawing.Size(100, 13)
        Me.txtImportePagado.TabIndex = 36
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoTotal.Enabled = False
        Me.txtMontoTotal.Location = New System.Drawing.Point(373, 395)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(100, 13)
        Me.txtMontoTotal.TabIndex = 35
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(504, 94)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 13)
        Me.txtFecha.TabIndex = 32
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(103, 157)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 13)
        Me.txtNombre.TabIndex = 31
        '
        'txtDominio
        '
        Me.txtDominio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDominio.Enabled = False
        Me.txtDominio.Location = New System.Drawing.Point(464, 160)
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.Size = New System.Drawing.Size(100, 13)
        Me.txtDominio.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(288, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Importe a Pagar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(287, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Monto Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Forma de Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Concepto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Dominio"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(44, 514)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 37
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(294, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 33)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(195, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Documento no valido como factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Fecha"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "---------------------------------------------------------------------------------" & _
            "------------------"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(291, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(304, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "---------------------------------------------------------------------------------" & _
            "------------------"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(406, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(304, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "---------------------------------------------------------------------------------" & _
            "------------------"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Logo de la Empresa"
        '
        'txtConcepto
        '
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Location = New System.Drawing.Point(103, 214)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(234, 13)
        Me.txtConcepto.TabIndex = 47
        '
        'txtFormapago
        '
        Me.txtFormapago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFormapago.Enabled = False
        Me.txtFormapago.Location = New System.Drawing.Point(464, 217)
        Me.txtFormapago.Name = "txtFormapago"
        Me.txtFormapago.Size = New System.Drawing.Size(129, 13)
        Me.txtFormapago.TabIndex = 48
        '
        'txtImporte2
        '
        Me.txtImporte2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImporte2.Enabled = False
        Me.txtImporte2.Location = New System.Drawing.Point(373, 310)
        Me.txtImporte2.Name = "txtImporte2"
        Me.txtImporte2.Size = New System.Drawing.Size(100, 13)
        Me.txtImporte2.TabIndex = 57
        '
        'txtBanco2
        '
        Me.txtBanco2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBanco2.Enabled = False
        Me.txtBanco2.Location = New System.Drawing.Point(221, 310)
        Me.txtBanco2.Name = "txtBanco2"
        Me.txtBanco2.Size = New System.Drawing.Size(146, 13)
        Me.txtBanco2.TabIndex = 56
        '
        'txtCh2
        '
        Me.txtCh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCh2.Enabled = False
        Me.txtCh2.Location = New System.Drawing.Point(106, 310)
        Me.txtCh2.Name = "txtCh2"
        Me.txtCh2.Size = New System.Drawing.Size(100, 13)
        Me.txtCh2.TabIndex = 55
        '
        'txtImporte1
        '
        Me.txtImporte1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImporte1.Enabled = False
        Me.txtImporte1.Location = New System.Drawing.Point(373, 287)
        Me.txtImporte1.Name = "txtImporte1"
        Me.txtImporte1.Size = New System.Drawing.Size(100, 13)
        Me.txtImporte1.TabIndex = 54
        '
        'txtBanco1
        '
        Me.txtBanco1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBanco1.Enabled = False
        Me.txtBanco1.Location = New System.Drawing.Point(221, 287)
        Me.txtBanco1.Name = "txtBanco1"
        Me.txtBanco1.Size = New System.Drawing.Size(146, 13)
        Me.txtBanco1.TabIndex = 53
        '
        'txtCh1
        '
        Me.txtCh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCh1.Enabled = False
        Me.txtCh1.Location = New System.Drawing.Point(106, 284)
        Me.txtCh1.Name = "txtCh1"
        Me.txtCh1.Size = New System.Drawing.Size(100, 13)
        Me.txtCh1.TabIndex = 52
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(370, 259)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 51
        Me.lblImporte.Text = "Importe"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(218, 259)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblBanco.TabIndex = 50
        Me.lblBanco.Text = "Banco"
        '
        'lblNroCh
        '
        Me.lblNroCh.AutoSize = True
        Me.lblNroCh.Location = New System.Drawing.Point(103, 259)
        Me.lblNroCh.Name = "lblNroCh"
        Me.lblNroCh.Size = New System.Drawing.Size(64, 13)
        Me.lblNroCh.TabIndex = 49
        Me.lblNroCh.Text = "Nro Cheque"
        '
        'txtNro_recibo
        '
        Me.txtNro_recibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNro_recibo.Enabled = False
        Me.txtNro_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro_recibo.Location = New System.Drawing.Point(464, 59)
        Me.txtNro_recibo.Name = "txtNro_recibo"
        Me.txtNro_recibo.Size = New System.Drawing.Size(166, 17)
        Me.txtNro_recibo.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(460, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 20)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Recibo Nro"
        '
        'frmRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(729, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNro_recibo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtImporte2)
        Me.Controls.Add(Me.txtBanco2)
        Me.Controls.Add(Me.txtCh2)
        Me.Controls.Add(Me.txtImporte1)
        Me.Controls.Add(Me.txtBanco1)
        Me.Controls.Add(Me.txtCh1)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblBanco)
        Me.Controls.Add(Me.lblNroCh)
        Me.Controls.Add(Me.txtFormapago)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtImportePagado)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDominio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRecibo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtImportePagado As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDominio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFormapago As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtImporte2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCh2 As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCh1 As System.Windows.Forms.TextBox
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents lblNroCh As System.Windows.Forms.Label
    Friend WithEvents txtNro_recibo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
