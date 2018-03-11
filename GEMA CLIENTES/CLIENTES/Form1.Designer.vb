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
        Me.btnConfAgreg = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.BtnCanc = New System.Windows.Forms.Button
        Me.btnUlt = New System.Windows.Forms.Button
        Me.btnSig = New System.Windows.Forms.Button
        Me.btnAnt = New System.Windows.Forms.Button
        Me.btnPrim = New System.Windows.Forms.Button
        Me.txtPrecUniprod = New System.Windows.Forms.TextBox
        Me.txtCantidadprod = New System.Windows.Forms.TextBox
        Me.txtDetalleprod = New System.Windows.Forms.TextBox
        Me.txtCodigoprod = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.codigo_producto = New System.Windows.Forms.Label
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(252, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 31)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "CLIENTES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 40)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Ingresar producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 40)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Modificar producto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(407, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 40)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Eliminar Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnConfAgreg
        '
        Me.btnConfAgreg.Location = New System.Drawing.Point(340, 400)
        Me.btnConfAgreg.Name = "btnConfAgreg"
        Me.btnConfAgreg.Size = New System.Drawing.Size(75, 23)
        Me.btnConfAgreg.TabIndex = 52
        Me.btnConfAgreg.Text = "Confirmar"
        Me.btnConfAgreg.UseVisualStyleBackColor = True
        Me.btnConfAgreg.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(453, 177)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 40)
        Me.btnBuscar.TabIndex = 51
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCanc
        '
        Me.BtnCanc.Location = New System.Drawing.Point(209, 400)
        Me.BtnCanc.Name = "BtnCanc"
        Me.BtnCanc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCanc.TabIndex = 50
        Me.BtnCanc.Text = "Cancelar"
        Me.BtnCanc.UseVisualStyleBackColor = True
        Me.BtnCanc.Visible = False
        '
        'btnUlt
        '
        Me.btnUlt.Location = New System.Drawing.Point(443, 318)
        Me.btnUlt.Name = "btnUlt"
        Me.btnUlt.Size = New System.Drawing.Size(85, 47)
        Me.btnUlt.TabIndex = 49
        Me.btnUlt.Text = ">> Ultimo >>"
        Me.btnUlt.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(340, 318)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(85, 47)
        Me.btnSig.TabIndex = 48
        Me.btnSig.Text = "> Siguiente >"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(193, 318)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(85, 47)
        Me.btnAnt.TabIndex = 47
        Me.btnAnt.Text = "< Anterior <"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnPrim
        '
        Me.btnPrim.Location = New System.Drawing.Point(93, 318)
        Me.btnPrim.Name = "btnPrim"
        Me.btnPrim.Size = New System.Drawing.Size(85, 47)
        Me.btnPrim.TabIndex = 46
        Me.btnPrim.Text = "<< Primero <<"
        Me.btnPrim.UseVisualStyleBackColor = True
        '
        'txtPrecUniprod
        '
        Me.txtPrecUniprod.Location = New System.Drawing.Point(209, 264)
        Me.txtPrecUniprod.Name = "txtPrecUniprod"
        Me.txtPrecUniprod.ReadOnly = True
        Me.txtPrecUniprod.Size = New System.Drawing.Size(216, 20)
        Me.txtPrecUniprod.TabIndex = 45
        '
        'txtCantidadprod
        '
        Me.txtCantidadprod.Location = New System.Drawing.Point(209, 224)
        Me.txtCantidadprod.Name = "txtCantidadprod"
        Me.txtCantidadprod.ReadOnly = True
        Me.txtCantidadprod.Size = New System.Drawing.Size(216, 20)
        Me.txtCantidadprod.TabIndex = 44
        '
        'txtDetalleprod
        '
        Me.txtDetalleprod.Location = New System.Drawing.Point(209, 177)
        Me.txtDetalleprod.Name = "txtDetalleprod"
        Me.txtDetalleprod.ReadOnly = True
        Me.txtDetalleprod.Size = New System.Drawing.Size(216, 20)
        Me.txtDetalleprod.TabIndex = 43
        '
        'txtCodigoprod
        '
        Me.txtCodigoprod.Location = New System.Drawing.Point(209, 137)
        Me.txtCodigoprod.Name = "txtCodigoprod"
        Me.txtCodigoprod.ReadOnly = True
        Me.txtCodigoprod.Size = New System.Drawing.Size(216, 20)
        Me.txtCodigoprod.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Precio Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Detalle"
        '
        'codigo_producto
        '
        Me.codigo_producto.AutoSize = True
        Me.codigo_producto.Location = New System.Drawing.Point(90, 144)
        Me.codigo_producto.Name = "codigo_producto"
        Me.codigo_producto.Size = New System.Drawing.Size(101, 13)
        Me.codigo_producto.TabIndex = 38
        Me.codigo_producto.Text = "Código de Producto"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(362, 400)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 53
        Me.btnConfirm.Text = "Confirmar"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 443)
        Me.Controls.Add(Me.btnConfAgreg)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.BtnCanc)
        Me.Controls.Add(Me.btnUlt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnPrim)
        Me.Controls.Add(Me.txtPrecUniprod)
        Me.Controls.Add(Me.txtCantidadprod)
        Me.Controls.Add(Me.txtDetalleprod)
        Me.Controls.Add(Me.txtCodigoprod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codigo_producto)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnConfirm)
        Me.Name = "Form1"
        Me.Text = "CLIENTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnConfAgreg As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnCanc As System.Windows.Forms.Button
    Friend WithEvents btnUlt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnPrim As System.Windows.Forms.Button
    Friend WithEvents txtPrecUniprod As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadprod As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleprod As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoprod As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codigo_producto As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button

End Class
