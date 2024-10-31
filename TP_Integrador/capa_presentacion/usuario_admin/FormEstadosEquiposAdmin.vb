Imports System.Runtime.InteropServices 'Permite funcionalidades de API de Windows para poder trabajar con la funcion releaseCapture'
Public Class FormEstadosEquiposAdmin

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






    Private WithEvents TimerEstados As New Timer
    Private EstadoActual As Integer
    Private Equipo As Equipos.Equipo


    Public Sub New(equipo As Equipos.Equipo)

        InitializeComponent()
        Me.EstadoActual = equipo.Estado
        Me.Equipo = equipo
        LEstadosEquipo.Text = Equipos.ObtenerDescripcionEstado(equipo.Estado)


    End Sub

    ' Al cargar el formulario
    Private Sub FormEstadosEquiposAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerEstados.Interval = 100
        MostrarBotonPorEstado(EstadoActual)
        TimerEstados.Start()
    End Sub


    Private Sub BRevisarEquipo_Click(sender As Object, e As EventArgs) Handles BRevisarEquipo.Click

        If Revisiones.RevisarEquipo(Equipo, 2) Then
            EstadoActual = 2
            LEstadosEquipo.Text = Equipos.ObtenerDescripcionEstado(EstadoActual)
            Application.DoEvents()
            MostrarBotonPorEstado(EstadoActual)

            TimerEstados.Start()
        End If



    End Sub


    Private Sub BFinalizarRevision_Click(sender As Object, e As EventArgs) Handles BFinalizarRevision.Click

        Dim form As New FormFinalizarRevision(Equipo)
        AddHandler form.FormClosed, Sub(s, args) FormClosedHandler(3)
        form.Show()

    End Sub

    Private Sub BInfoRevision_Click(sender As Object, e As EventArgs) Handles BInfoRevision.Click

        Dim revision As Revisiones.Revision = Revisiones.obtenerRevisionPorID(Equipo.IDEquipo)

        Dim form As New FormInfoRevision(revision)
        form.Show()

    End Sub

    Private Sub BCargarPresupuesto_Click(sender As Object, e As EventArgs) Handles BCargarPresupuesto.Click

        Dim revision As Revisiones.Revision = Revisiones.obtenerRevisionPorID(Equipo.IDEquipo)

        Dim form As New FormCargarPresupuesto(revision)
        AddHandler form.FormClosed, Sub(s, args) FormClosedHandler(10)
        form.Show()


    End Sub

    Private Sub BInfoPresupuesto_Click(sender As Object, e As EventArgs) Handles BInfoPresupuesto.Click

        Dim presupuesto As Presupuestos.Presupuesto = Presupuestos.obtenerPresupuestoPorID(Equipo.IDEquipo)

        Dim form As New FormInfoPresupuesto(presupuesto)
        form.Show()

    End Sub

    Private Sub BAprobarPresupuesto_Click(sender As Object, e As EventArgs) Handles BAprobarPresupuesto.Click
        Presupuestos.aprobarPresupuesto(Equipo.IDEquipo, 11)

        EstadoActual = 11
        LEstadosEquipo.Text = Equipos.ObtenerDescripcionEstado(EstadoActual)
        Application.DoEvents()
        MostrarBotonPorEstado(EstadoActual)

        TimerEstados.Start()
    End Sub

    Private Sub BDesaprobarPresupuesto_Click(sender As Object, e As EventArgs) Handles BDesaprobarPresupuesto.Click
        Presupuestos.desaprobarPresupuesto(Equipo.IDEquipo, 13)

        EstadoActual = 13
        LEstadosEquipo.Text = Equipos.ObtenerDescripcionEstado(EstadoActual)
        Application.DoEvents()
        MostrarBotonPorEstado(EstadoActual)

        TimerEstados.Start()
    End Sub

    Private Sub BRepararEquipo_Click(sender As Object, e As EventArgs) Handles BRepararEquipo.Click
        Reparaciones.RepararEquipo(Equipo, 12)
        EstadoActual = 12
        LEstadosEquipo.Text = Equipos.ObtenerDescripcionEstado(EstadoActual)
        Application.DoEvents()
        MostrarBotonPorEstado(EstadoActual)

        TimerEstados.Start()
    End Sub

    Private Sub BReparacionExitosa_Click(sender As Object, e As EventArgs) Handles BReparacionExitosa.Click


        Dim presupuesto As Presupuestos.Presupuesto = Presupuestos.obtenerPresupuestoPorID(Equipo.IDEquipo)

        Dim form As New FormReparacionEquipo(presupuesto, 1)
        AddHandler form.FormClosed, Sub(s, args) FormClosedHandler(13)
        form.Show()

    End Sub

    Private Sub BIrreparable_Click(sender As Object, e As EventArgs) Handles BIrreparable.Click
        Dim presupuesto As Presupuestos.Presupuesto = Presupuestos.obtenerPresupuestoPorID(Equipo.IDEquipo)

        Dim form As New FormReparacionEquipo(presupuesto, 0)
        AddHandler form.FormClosed, Sub(s, args) FormClosedHandler(13)
        form.Show()


    End Sub

    Private Sub BInfoReparacion_Click(sender As Object, e As EventArgs) Handles BInfoReparacion.Click
        Dim reparacion As Reparaciones.Reparacion = Reparaciones.obtenerReparacionPorID(Equipo.IDEquipo)

        Dim form As New FormInfoReparacion(reparacion)
        form.Show()
    End Sub

    Private Sub BDevolverEquipo_Click(sender As Object, e As EventArgs) Handles BDevolverEquipo.Click
        Dim reparacion As Reparaciones.Reparacion = Reparaciones.obtenerReparacionPorID(Equipo.IDEquipo)

        Dim entrega As New Entregas.Entrega
        entrega.Reparacion = reparacion

        Entregas.agregarEntrega(entrega, 14)


        EstadoActual = 14
        LEstadosEquipo.Text = Equipos.ObtenerDescripcionEstado(EstadoActual)
        Application.DoEvents()
        MostrarBotonPorEstado(EstadoActual)

        TimerEstados.Start()
    End Sub

    ' Evento que maneja las acciones del temporizador
    Private Sub TimerEstados_Tick(sender As Object, e As EventArgs) Handles TimerEstados.Tick
        Debug.Print("Tick del temporizador. Valor de la ProgressBar: " & ProgressBarEstadosEquipos.Value)
        ProgressBarEstadosEquipos.Increment(1)

        Application.DoEvents()

        Select Case EstadoActual

            Case 1

                ProgressBarEstadosEquipos.Value = 0
                TimerEstados.Stop()

            Case 2

                If ProgressBarEstadosEquipos.Value = 15 Then
                    TimerEstados.Stop()
                End If

            Case 3

                If ProgressBarEstadosEquipos.Value = 30 Then
                    TimerEstados.Stop()
                End If

            Case 10

                If ProgressBarEstadosEquipos.Value = 45 Then
                    TimerEstados.Stop()
                End If

            Case 11
                If ProgressBarEstadosEquipos.Value = 60 Then
                    TimerEstados.Stop()
                End If

            Case 12
                If ProgressBarEstadosEquipos.Value = 75 Then
                    TimerEstados.Stop()
                End If

            Case 13

                If ProgressBarEstadosEquipos.Value = 90 Then
                    TimerEstados.Stop()
                End If

        End Select
    End Sub

    ' Método para mostrar solo el botón correspondiente al estado
    Private Sub MostrarBotonPorEstado(estado As Integer)
        ' Ocultar todos los botones
        BRevisarEquipo.Visible = False
        BFinalizarRevision.Visible = False
        BCargarPresupuesto.Visible = False
        BAprobarPresupuesto.Visible = False
        BDesaprobarPresupuesto.Visible = False
        BRepararEquipo.Visible = False
        BReparacionExitosa.Visible = False
        BIrreparable.Visible = False
        BDevolverEquipo.Visible = False
        BInfoRevision.Visible = False
        BInfoPresupuesto.Visible = False
        BInfoReparacion.Visible = False
        ' Mostrar solo el botón correspondiente al estado actual
        Select Case estado
            Case 1
                BRevisarEquipo.Visible = True
            Case 2
                BFinalizarRevision.Visible = True
            Case 3
                BCargarPresupuesto.Visible = True
                BInfoRevision.Visible = True

            Case 10
                BAprobarPresupuesto.Visible = True
                BDesaprobarPresupuesto.Visible = True
                BInfoRevision.Visible = True
                BInfoPresupuesto.Visible = True

            Case 11
                BRepararEquipo.Visible = True
                BInfoRevision.Visible = True
                BInfoPresupuesto.Visible = True

            Case 12
                BReparacionExitosa.Visible = True
                BIrreparable.Visible = True
                BInfoRevision.Visible = True
                BInfoPresupuesto.Visible = True

            Case 13
                BInfoRevision.Visible = True
                BInfoPresupuesto.Visible = True
                BDevolverEquipo.Visible = True
                If Reparaciones.reparacionAprobada(Equipo.IDEquipo) Then
                    BInfoReparacion.Visible = True
                Else
                    BInfoReparacion.Visible = False
                End If


        End Select
    End Sub

    Private Sub FormClosedHandler(nuevoEstado As Integer)
        EstadoActual = nuevoEstado
        LEstadosEquipo.Text = Equipos.ObtenerDescripcionEstado(EstadoActual)
        Application.DoEvents()
        MostrarBotonPorEstado(EstadoActual)
        TimerEstados.Start()
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub

    Private Sub PBordeSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PBordeSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub
End Class
