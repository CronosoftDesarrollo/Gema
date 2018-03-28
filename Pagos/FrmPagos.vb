Imports System.Net.Mail
Public Class FrmPagos
    Public Sub EnvioMail()

        Dim correo As New MailMessage
        Dim smtp As New SmtpClient()
        Dim archivo As New System.Net.Mail.Attachment("c:\cgm\archivo.txt")
        correo.From = New MailAddress("claudiomoyano@estudiotartaro.com.ar", "claudio", System.Text.Encoding.UTF8)
        correo.To.Add(txtPara.Text)
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = txtAsunto.Text
        correo.Body = txtmensaje.Text
        correo.Attachments.Add(archivo)
        correo.BodyEncoding = System.Text.Encoding.UTF8
        'correo.IsBodyHtml = False (formato tipo web o normal: true = web)
        'correo.Priority = MailPriority.High >> prioridad

        smtp.Credentials = New System.Net.NetworkCredential("claudiomoyano@estudiotartaro.com.ar", "claudio001_a9")
        smtp.Port = 25
        smtp.Host = "mail2.alpha2000.com.ar"
        smtp.EnableSsl = False

        smtp.Send(correo)
        MsgBox("Mensaje enviado con exito", vbInformation)
        txtPara.Clear()
        txtAsunto.Clear()
        txtmensaje.Clear()
    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFormaPago.SelectedIndexChanged
        If cmbFormaPago.Text = "Cheque" Then
            lblNroCh.Visible = True
            lblBanco.Visible = True
            lblImporte.Visible = True
            txtCh1.Visible = True
            txtBanco1.Visible = True
            txtImporte1.Visible = True
            btnMas.Visible = True
           
        End If
    End Sub

    Private Sub FrmPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        EnvioMail()

    End Sub

    Private Sub btnEnviarMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarMail.Click
        lblPara.Visible = True
        lblAsunto.Visible = True
        lblMensaje.Visible = True
        txtPara.Visible = True
        txtAsunto.Visible = True
        txtMensaje.Visible = True
        btnEnviar.Visible = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        frmRecibo.txtNro_recibo.Text = Me.txtNro_recibo.Text
        frmRecibo.txtDominio.Text = Me.txtDominio.Text
        frmRecibo.txtFecha.Text = Me.txtFecha.Text
        frmRecibo.txtNombre.Text = Me.txtNombre.Text
        frmRecibo.txtConcepto.Text = Me.cmbConcepto.Text
        frmRecibo.txtFormapago.Text = Me.cmbFormaPago.Text
        frmRecibo.txtCh1.Text = Me.txtCh1.Text
        frmRecibo.txtCh2.Text = Me.txtCh2.Text
        frmRecibo.txtBanco1.Text = Me.txtBanco1.Text
        frmRecibo.txtBanco2.Text = Me.txtBanco2.Text
        frmRecibo.txtImporte1.Text = Me.txtImporte1.Text
        frmRecibo.txtImporte2.Text = Me.txtImporte2.Text
        frmRecibo.txtImportePagado.Text = Me.txtImportePagado.Text
        frmRecibo.txtMontoTotal.Text = Me.txtMontoTotal.Text

        frmRecibo.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        




    End Sub

    Private Sub btnMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtCh2.Visible = True
        txtImporte2.Visible = True
        txtBanco2.Visible = True
        btnMenos.Visible = True
    End Sub

    Private Sub btnMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenos.Click
        txtCh2.Visible = False
        txtImporte2.Visible = False
        txtBanco2.Visible = False
        btnMenos.Visible = False
        btnMas.Visible = True
    End Sub

    Private Sub btnMas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMas.Click
        txtCh2.Visible = True
        txtImporte2.Visible = True
        txtBanco2.Visible = True
        btnMas.Visible = False
        btnMenos.Visible = True

    End Sub
End Class
