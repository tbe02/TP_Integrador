Imports TP_Integrador.Usuarios

Public Class FormListaUsuarios
    Private usuarios As Usuarios = Usuarios.ObtenerInstancia()
    Public Sub New()
        InitializeComponent()

        CargarUsuarios()
        ListarFiltros()
    End Sub
    Private Sub ListarFiltros()
        CBFiltro.Items.Add("Todos")
        CBFiltro.Items.Add("Apellido")
        CBFiltro.Items.Add("Nombre")
        CBFiltro.Items.Add("DNI")
        CBFiltro.Items.Add("Correo")
        CBFiltro.Items.Add("Telefono")
        CBFiltro.Items.Add("Usuario")
        CBFiltro.Items.Add("Administrador")
        CBFiltro.Items.Add("Tecnico")
        CBFiltro.Items.Add("Maestro")
    End Sub

    Private Sub refrescarLista()
        Dim listaUsuarios As List(Of Usuario) = usuarios.obtenerTodos() ' Reemplaza con tu método para obtener los usuarios

        ' Limpia las filas actuales del DataGridView
        DGVListaUsuarios.Rows.Clear()

        ' Agrega los usuarios actualizados al DataGridView
        For Each usuario In listaUsuarios
            DGVListaUsuarios.Rows.Add(usuario.Apellido, usuario.Nombre, usuario.DNI, usuario.Telefono, usuario.Correo, usuario.NombreUsuario, usuario.Tipo)
        Next
    End Sub

    Private Sub CargarUsuarios()
        DGVListaUsuarios.AllowUserToAddRows = False

        Dim listaUsuarios = usuarios.obtenerTodos()
        For Each usuario As Usuario In listaUsuarios
            DGVListaUsuarios.Rows.Add(usuario.Apellido, usuario.Nombre, usuario.DNI, usuario.Telefono, usuario.Correo, usuario.NombreUsuario, usuario.Tipo)
        Next
    End Sub


    Private Sub DGVEliminarUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaUsuarios.CellClick
        ' Verificar si se hizo clic en la columna "C_Eliminar" y que la fila sea válida
        If e.ColumnIndex = DGVListaUsuarios.Columns("C_Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener el DNI del usuario seleccionado
            Dim dni As String = DGVListaUsuarios.Rows(e.RowIndex).Cells("C_DNI").Value.ToString()

            ' Confirmar la eliminación
            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario confirma la eliminación
            If resultado = DialogResult.Yes Then
                ' Llamar al método para eliminar el cliente usando su DNI
                usuarios.eliminarUsuario(dni)

                ' Refrescar la lista después de eliminar
                refrescarLista()

                ' Mostrar mensaje de éxito
                MessageBox.Show("Cliente eliminado con éxito.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub DGVEditarUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaUsuarios.CellClick
        If e.ColumnIndex = DGVListaUsuarios.Columns("C_Editar").Index AndAlso e.RowIndex >= 0 Then
            Dim nombreUsuario As String = DGVListaUsuarios.Rows(e.RowIndex).Cells("C_Usuario").Value.ToString()

            Dim usuarioActual As Usuarios.Usuario = usuarios.obtenerTodos().Find(Function(u) u.NombreUsuario = nombreUsuario)

            Dim formEditar As New FormEditarUsuario(usuarioActual, usuarios)
            If formEditar.ShowDialog() = DialogResult.OK Then
                ' Obtener los valores editados del formulario
                Dim usuarioEditado As Usuarios.Usuario = formEditar.ObtenerUsuarioEditado()

                ' Actualizar el usuario
                If usuarios.verificaciones(usuarioEditado.Apellido, usuarioEditado.Nombre, usuarioEditado.DNI, usuarioEditado.Correo, usuarioEditado.Telefono) Then
                    usuarios.editarUsuario(usuarioEditado.Apellido, usuarioEditado.Nombre, usuarioEditado.DNI, usuarioEditado.Telefono, usuarioEditado.Correo, usuarioEditado.NombreUsuario, usuarioEditado.Password, usuarioEditado.Tipo)

                    ' Refrescar la lista después de editar
                    refrescarLista()

                    ' Mostrar mensaje de éxito
                    MessageBox.Show("Usuario editado con éxito.", "Edición Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub FiltrarClientes(sender As Object, e As EventArgs) Handles IPBBuscarUsuario.Click
        Dim filtro = CBFiltro.Text
        Dim busqueda = TBBuscarUsuario.Text

        Dim usuariosFiltrados As List(Of Usuario)

        DGVListaUsuarios.Rows.Clear()

        Select Case filtro
            Case "Apellido"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.Apellido.StartsWith(busqueda)).ToList()
            Case "Nombre"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.Nombre.StartsWith(busqueda)).ToList()
            Case "DNI"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.DNI.StartsWith(busqueda)).ToList()
            Case "Correo"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.Correo.StartsWith(busqueda)).ToList()
            Case "Telefono"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.Telefono.StartsWith(busqueda)).ToList()
            Case "Usuario"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.NombreUsuario.StartsWith(busqueda)).ToList()
            Case "Administrador"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.Tipo = "administrador").ToList()
            Case "Tecnico"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.Tipo = "tecnico").ToList()
            Case "Maestro"
                usuariosFiltrados = usuarios.obtenerTodos().Where(Function(usuario) usuario.Tipo = "maestro").ToList()
            Case Else
                usuariosFiltrados = usuarios.obtenerTodos()
        End Select

        For Each usuario In usuariosFiltrados
            DGVListaUsuarios.Rows.Add(usuario.Apellido, usuario.Nombre, usuario.DNI, usuario.Telefono, usuario.Correo, usuario.NombreUsuario, usuario.Tipo)
        Next
    End Sub

    Private Sub ManejarFiltro(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        TBBuscarUsuario.Clear()

        Dim filtro = CBFiltro.Text

        If filtro = "Administrador" Or filtro = "Tecnico" Or filtro = "Maestro" Then
            FiltrarClientes(sender, e)

            Return
        End If

        refrescarLista()
    End Sub
End Class
