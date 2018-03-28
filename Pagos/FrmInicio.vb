Public Class FrmInicio

    Private Sub btnPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagos.Click
        FrmPagos.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class