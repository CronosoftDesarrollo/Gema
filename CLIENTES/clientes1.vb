Imports System.Data.OleDb

Public Class clientes1

    Dim Cn As New OleDb.OleDbConnection
    Public Dt As New DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    Dim versión, Modelo_Año, Fecha_de_Nacimiento, Telefono, Número_de_documento As Integer
    Dim Stringsql As String
    Dim DsGEMA_CLIENTES As New DataSet
    Dim dominio, motor_marca, motor_chasis, marca, nombre_apellido, email As String
    Dim NroReg As Integer

    Private Sub DeshabilitarBotonesTODOS()
        btnIngcliente.Visible = False
        btnModcliente.Visible = False
        btnElimcliente.Visible = False
        btnSig.Visible = False
        btnAnt.Visible = False
        btnBuscar.Visible = False

    End Sub
    Private Sub DeshabilitarBotonesConfirmar()
        btnConfAgreg.Visible = False
        btnConfAgreg.Visible = False
        btnElimcliente.Visible = False
        btnModcliente.Visible = False
    End Sub
    Private Sub HabilitarBotones()

        btnSig.Visible = True
        btnAnt.Visible = True
        btnIngcliente.Visible = True
        btnModcliente.Visible = True
        btnElimcliente.Visible = True

    End Sub
    Private Sub HabilitarCajastexto()
        txtDominio.ReadOnly = False
        txtmotormarca.ReadOnly = False
        txtMarca.ReadOnly = False
        txtmotorchasis.ReadOnly = False
        txtVersion.ReadOnly = False
        txtNombre.ReadOnly = False
        txtModelo.ReadOnly = False
        txtDni.ReadOnly = False
        txtFechan.ReadOnly = False
        txtTelefono.ReadOnly = False
        txtEmail.ReadOnly = False


    End Sub
    Private Sub Vaciarcajas()
        txtDominio.Text = ""
        txtmotormarca.Text = ""
        txtMarca.Text = ""
        txtmotorchasis.Text = ""
        txtVersion.Text = ""
        txtNombre.Text = ""
        txtModelo.Text = ""
        txtDni.Text = ""
        txtFechan.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""

    End Sub

    Private Sub clientes1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=")
        Cn.Open()
        Da = New OleDb.OleDbDataAdapter("SELECT * from GEMA_CLIENTES.MDB", Cn.ConnectionString)
        Dt.Clear()
        Da.Fill(Dt)
        Cn.Close()
        NroReg = 0

    End Sub

    Private Sub LlenarTxt()
        txtDominio.Text = Strings.LTrim(Dt.Rows(NroReg)("DOMINIO"))
        txtDni.Text = (Dt.Rows(NroReg)("DNI"))
        txtEmail.Text = (Dt.Rows(NroReg)("EMAIL"))
        txtFechan.Text = (Dt.Rows(NroReg)("FECHA_DE_NACIMIENTO"))

    End Sub
    Private Sub btnIngcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngcliente.Click
        Vaciarcajas()
        HabilitarCajastexto()
        DeshabilitarBotonesTODOS()
        btnConfAgreg.Visible = True
        BtnCanc.Visible = True
        'LogoBuscar.Visible = False
        'logoEliminar.Visible = False
        'Logomodificar.Visible = False
    End Sub

    Private Sub btnModcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModcliente.Click
        DeshabilitarBotonesTODOS()
        HabilitarCajastexto()
        btnConfAgreg.Visible = True
        BtnCanc.Visible = True
        txtDominio.ReadOnly = True
        btnVolverAlMenu.Visible = False
        'logoagregar.Visible = False
        'logoEliminar.Visible = False
    End Sub

    Private Sub btnElimcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimcliente.Click

    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        If NroReg <> 0 Then
            NroReg = NroReg - 1
            LlenarTxt()
        Else
        End If
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        If NroReg <> Dt.Rows.Count - 1 Then
            NroReg = NroReg + 1
            LlenarTxt()
        Else
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub
    Private Sub BtnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCanc.Click
        DeshabilitarBotonesConfirmar()
        HabilitarBotones()
        DeshabilitarCajasTexto()
        btnVolverAlMenu.Visible = True
    End Sub

    
End Class
