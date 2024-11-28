Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FormEditarEquipo



    '-------------------------------------------------------------------------------------------------------------------------'
    'Declaraciones para poder utilizar la funcion releaseCapture, que permite mover el formulario desde el panel superior'
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Sub SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2
    '-------------------------------------------------------------------------------------------------------------------------'





    Private _equipoActual As Equipos.Equipo
    Private _alFinalizar As Action

    Private _controladorClientes As ControladorClientes = New ControladorClientes()
    Private _controladorTiposDeEquipo As ControladorTiposDeEquipo = New ControladorTiposDeEquipo()
    Private _controladorMarcas As ControladorMarcas = New ControladorMarcas()
    Private _controladorModelos As ControladorModelos = New ControladorModelos()
    Private _controladorEquipos As ControladorEquipos = New ControladorEquipos()

    Public Sub New(equipoActual As Equipos.Equipo, alFinalizar As Action)
        InitializeComponent()

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.MinimumSize = New Size(900, 700)


        Me._equipoActual = equipoActual
        Me._alFinalizar = alFinalizar


    End Sub

    Private Sub FormEditarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarTiposDeEquipos()
        ListarMarcas()
        ListarModelos()
        InicializarCampos()
    End Sub

    Private Sub ListarClientes()
        Dim clientes = _controladorClientes.ObtenerTodos()

        ComboBAsociarCliente.DataSource = clientes
        ComboBAsociarCliente.DisplayMember = "DNI_Nombre"
        ComboBAsociarCliente.ValueMember = "ID"
        ComboBAsociarCliente.Refresh()
    End Sub

    Private Sub ListarTiposDeEquipos()
        Dim tiposDeEquipo = _controladorTiposDeEquipo.ObtenerTodos()

        ComboBTipoEquipo.DataSource = tiposDeEquipo
        ComboBTipoEquipo.DisplayMember = "Nombre"
        ComboBTipoEquipo.ValueMember = "IdTipoEquipo"
        ComboBTipoEquipo.Refresh()
    End Sub

    Private Sub ListarMarcas()
        Dim marcas = _controladorMarcas.ObtenerTodas()

        ComboBMarca.DataSource = marcas
        ComboBMarca.DisplayMember = "nombre"
        ComboBMarca.ValueMember = "idMarca"
        ComboBMarca.Refresh()
    End Sub

    Private Sub ListarModelos()
        Dim modelos = _controladorModelos.ObtenerTodos()

        ComboBModelo.DataSource = modelos
        ComboBModelo.DisplayMember = "nombre"
        ComboBModelo.ValueMember = "idModelo"
        ComboBModelo.Refresh()
    End Sub

    Private Sub InicializarCampos()
        ComboBTipoEquipo.SelectedValue = _equipoActual.TipoEquipo.IdTipoEquipo
        TBNroSerie.Text = _equipoActual.NumeroSerie
        ComboBMarca.SelectedValue = _equipoActual.Marca.idMarca
        ComboBModelo.SelectedValue = _equipoActual.Modelo.idModelo
        TBRazonIngreso.Text = _equipoActual.RazonIngreso
        TBObservaciones.Text = _equipoActual.Observaciones
        CBEquipoEnciende.Checked = (_equipoActual.Enciende = "Si")
        ComboBAsociarCliente.SelectedValue = _equipoActual.Cliente.ID
    End Sub

    Private Sub BEditarEquipo_Click(sender As Object, e As EventArgs) Handles BEditarEquipo.Click
        If Not ValidarCampos() Then
            MessageBox.Show("Por favor complete todos los campos obligatorios", "Editar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        Dim equipoActualizado As New Equipos.Equipo() With {
            .NumeroSerie = TBNroSerie.Text,
            .RazonIngreso = TBRazonIngreso.Text,
            .Observaciones = TBObservaciones.Text,
            .Enciende = If(CBEquipoEnciende.Checked, "Si", "No"),
            .TipoEquipo = New TiposDeEquipo.TipoDeEquipo() With {.IdTipoEquipo = ComboBTipoEquipo.SelectedValue},
            .Marca = New Marcas.Marca() With {.idMarca = ComboBMarca.SelectedValue},
            .Modelo = New Modelos.Modelo() With {.idModelo = ComboBModelo.SelectedValue},
            .Cliente = New Cliente() With {.ID = ComboBAsociarCliente.SelectedValue}
        }

        Try
            _controladorEquipos.ActualizarUnoPorId(_equipoActual.IDEquipo, equipoActualizado)

            _alFinalizar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        Return Not String.IsNullOrEmpty(TBNroSerie.Text) AndAlso
           Not String.IsNullOrEmpty(TBRazonIngreso.Text) AndAlso
           Not String.IsNullOrEmpty(TBObservaciones.Text) AndAlso
           ComboBTipoEquipo.SelectedValue IsNot Nothing AndAlso
           ComboBMarca.SelectedValue IsNot Nothing AndAlso
           ComboBModelo.SelectedValue IsNot Nothing AndAlso
           ComboBAsociarCliente.SelectedValue IsNot Nothing
    End Function

    Private Sub IBCerrar_EC_Click(sender As Object, e As EventArgs) Handles IBCerrar_EC.Click
        Me.Close()
    End Sub

    Private Sub IBMinimizar_EC_Click(sender As Object, e As EventArgs) Handles IBMinimizar_EC.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BEstadoEquipo_Click(sender As Object, e As EventArgs) Handles BEstadoEquipo.Click


        Dim form As New FormEstadosEquipos(_equipoActual)


        form.Show()
    End Sub


    Private Sub PMenuSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PMenuSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

End Class
