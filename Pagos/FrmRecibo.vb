Public Class frmRecibo

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnImprimir.Focus()
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        'Me.Focus()
        PrintForm1.Print()

    End Sub
End Class