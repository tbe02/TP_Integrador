Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices 'Permite funcionalidades de API de Windows para poder trabajar con la funcion releaseCapture'

Public Class modelo_menu_principal

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

    Private bordeIzquierdo As Panel
    Private botonActual As IconButton

    Dim sesion As Sesion = Sesion.ObtenerInstancia()

    Private Sub modelo_menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'creamos un panel izquierdo al iniciar el form que vamos a usar en nuestros botones'
        bordeIzquierdo = New Panel()
        bordeIzquierdo.Size = New Size(7, 60)
        PMenuIzquierdo.Controls.Add(bordeIzquierdo)



        ' Llama al método IBMenuPrincipal_Click desde el evento Load del formulario
        EjecutarIBMenuPrincipal()

        IBSesion.Text = sesion.ObtenerUsuario().Nombre
    End Sub

    'funcion para activar boton seleccionado'
    Private Function activarBoton(boton As Object, color As Color)

        If (boton IsNot Nothing) Then

            'si hay un boton seleccionado se desactiva'
            desactivarBoton()

            'se trabaja sobre el boton seleccionado'
            botonActual = DirectCast(boton, IconButton) 'boton sea del tipo iconbutton'
            botonActual.BackColor = Color.FromArgb(37, 36, 81)
            botonActual.ForeColor = color
            botonActual.TextAlign = ContentAlignment.MiddleCenter
            botonActual.IconColor = color
            botonActual.TextImageRelation = TextImageRelation.TextBeforeImage
            botonActual.ImageAlign = ContentAlignment.MiddleRight

            'se trabaja sobre el panel que queremos colocar en el borde izquierdo'
            bordeIzquierdo.BackColor = color
            bordeIzquierdo.Location = New Point(0, botonActual.Location.Y)
            bordeIzquierdo.Visible = True
            bordeIzquierdo.BringToFront()

        End If

    End Function

    'funcion para desactivar boton no seleccionado'
    Private Function desactivarBoton()

        If (botonActual IsNot Nothing) Then
            botonActual.BackColor = Color.Transparent
            botonActual.ForeColor = Color.White
            botonActual.TextAlign = ContentAlignment.MiddleCenter
            botonActual.IconColor = Color.White
            botonActual.TextImageRelation = TextImageRelation.Overlay
            botonActual.ImageAlign = ContentAlignment.MiddleLeft
        End If

    End Function



    Private Sub IBMenuPrincipal_Click(sender As Object, e As EventArgs) Handles IBMenuPrincipal.Click
        Dim color As Color

        color = Color.FromArgb(173, 126, 241)
        activarBoton(sender, color)

        Me.PFondoPrincipal.Controls.Clear()

        Dim form As New FormEstadisticas()

        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None



        Me.PFondoPrincipal.Controls.Add(form)
        form.Show()


    End Sub

    Private Sub IBAgregarCliente_Click(sender As Object, e As EventArgs) Handles IBAgregarCliente.Click
        Dim color As Color

        color = Color.FromArgb(249, 118, 176)
        activarBoton(sender, color)

        ' Limpiar cualquier control que ya esté en el Panel
        Me.PFondoPrincipal.Controls.Clear()

        ' Crear una nueva instancia del formulario
        Dim form As New FormAgregarCliente()

        ' Configurar el formulario para que no sea de nivel superior y sin bordes
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None

        ' Ajustar el formulario al tamaño del Panel
        Dim x As Integer = form.Location.X
        Dim y As Integer = form.Location.Y
        form.Location = New Point(x + 250, y + 40)


        ' Añadir el formulario al Panel y mostrarlo
        Me.PFondoPrincipal.Controls.Add(form)
        form.Show()




    End Sub

    Private Sub IBListaClientes_Click(sender As Object, e As EventArgs) Handles IBListaClientes.Click
        Dim color As Color

        color = Color.FromArgb(253, 138, 114)
        activarBoton(sender, color)

        Me.PFondoPrincipal.Controls.Clear()

        Dim form As New FormListaClientesAdmin()


        form.FormBorderStyle = FormBorderStyle.None
        form.TopLevel = False
        form.Dock = DockStyle.Fill

        Me.PFondoPrincipal.Controls.Add(form)
        form.Show()

    End Sub

    Private Sub IBAgregarEquipo_Click(sender As Object, e As EventArgs) Handles IBAgregarEquipo.Click
        Dim color As Color

        color = Color.FromArgb(95, 77, 221)
        activarBoton(sender, color)

        Me.PFondoPrincipal.Controls.Clear()

        Dim form As New FormAgregarEquipo()

        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill



        Me.PFondoPrincipal.Controls.Add(form)
        form.Show()


    End Sub

    Private Sub IBListaEquipos_Click(sender As Object, e As EventArgs) Handles IBListaEquipos.Click
        Dim color As Color

        color = Color.FromArgb(249, 88, 155)
        activarBoton(sender, color)

        Me.PFondoPrincipal.Controls.Clear()

        Dim form As New FormListaEquiposAdmin()

        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill



        Me.PFondoPrincipal.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub EjecutarIBMenuPrincipal()
        ' Llama al método IBMenuPrincipal_Click, pasando un valor predeterminado para sender y e
        IBMenuPrincipal_Click(IBMenuPrincipal, EventArgs.Empty)

    End Sub

    Private Sub PMenuSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PMenuSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar.Click
        End
    End Sub

    Private Sub IBMinimizar_Click(sender As Object, e As EventArgs) Handles IBMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IBMaximizar_Click(sender As Object, e As EventArgs) Handles IBMaximizar.Click

        If (Me.WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal

        End If

    End Sub



    Private Sub IBSesion_Click(sender As Object, e As EventArgs) Handles IBSesion.Click
        MenuPerfil.Show(IBSesion, New Point(0, IBSesion.Height))
    End Sub

    Private Sub CerrarSesion(sender As Object, e As EventArgs) Handles TSMCerrarSesion.Click
        sesion.EliminarSesion()

        Me.Close()

        Dim formLogin = New FormLogin()

        formLogin.Show()
    End Sub

End Class