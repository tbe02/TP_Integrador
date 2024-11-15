Imports TP_Integrador.Usuarios

Public Class FormListaUsuarios

    Private _controladorUsuarios As ControladorUsuarios = New ControladorUsuarios()
    Public Sub New()
        InitializeComponent()

        ListarFiltros()
        CargarUsuarios()
        DGVListaUsuarios.AllowUserToAddRows = False
    End Sub

    Private Sub refrescarLista()
        DGVListaUsuarios.Rows.Clear()
        CargarUsuarios()
    End Sub

    Private Sub ListarFiltros()
        CBFiltro.Items.Add("Maestro")
        CBFiltro.Items.Add("Técnico")
        CBFiltro.Items.Add("Administrador")
        CBFiltro.Items.Add("Todos")
    End Sub

    Private Sub CargarUsuarios()

        DGVListaUsuarios.Rows.Clear() ' Asegúrate de limpiar filas antes de listar

        Dim listaUsuarios = _controladorUsuarios.ObtenerTodos()
        For Each usuario As Usuario In listaUsuarios
            DGVListaUsuarios.Rows.Add(usuario.Apellido, usuario.Nombre, usuario.DNI, usuario.Telefono, usuario.Correo, usuario.NombreUsuario, usuario.Tipo.nombre)
        Next

    End Sub


    Private Sub DGVEliminarUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaUsuarios.CellClick

        If e.ColumnIndex = DGVListaUsuarios.Columns("C_Eliminar").Index AndAlso e.RowIndex >= 0 Then



            Dim usuarioSeleccionado As Usuario = _controladorUsuarios.ObtenerTodos(e.RowIndex)


            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If resultado = DialogResult.Yes Then

                _controladorUsuarios.eliminarUsuario(usuarioSeleccionado.DNI)

                refrescarLista()


                MessageBox.Show("Usuario eliminado con éxito.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub DGVEditarUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaUsuarios.CellClick
        If e.ColumnIndex = DGVListaUsuarios.Columns("C_Editar").Index AndAlso e.RowIndex >= 0 Then

            Dim filaSeleccionada As DataGridViewRow = DGVListaUsuarios.Rows(e.RowIndex)

            Dim usuario As Usuarios.Usuario = _controladorUsuarios.ObtenerTodos(e.RowIndex)


            Dim formEditar As New FormEditarUsuario(usuario, New Action(
                    Sub()
                        refrescarLista()
                    End Sub
                ))

            formEditar.Size = New Size(495, 1001)
            formEditar.Show()

        End If
    End Sub

    Private Sub FiltrarUsuarios()
        Dim filtro As String = TBBuscarUsuario.Text.Trim()
        Dim estadoFiltro As String = If(CBFiltro.SelectedItem IsNot Nothing, CBFiltro.SelectedItem.ToString(), "Todos")


        For Each r As DataGridViewRow In DGVListaUsuarios.Rows
            r.Visible = False
        Next

        For Each r As DataGridViewRow In DGVListaUsuarios.Rows
            Dim estado As String = r.Cells("C_TipoDeUsuario").Value.ToString()
            Dim mostrar As Boolean = False

            ' Filtrar según el ComboBox
            If estadoFiltro = "Maestro" And estado = "maestro" Then
                mostrar = True
            ElseIf estadoFiltro = "Técnico" And estado = "tecnico" Then
                mostrar = True
            ElseIf estadoFiltro = "Administrador" And estado = "administrador" Then
                mostrar = True
            ElseIf estadoFiltro = "Todos" Then
                mostrar = True
            End If

            ' Verificar si coincide con la búsqueda
            If mostrar Then
                If String.IsNullOrEmpty(filtro) OrElse r.Cells.Cast(Of DataGridViewCell)().Any(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString().ToUpper().Contains(filtro.ToUpper())) Then
                    r.Visible = True ' Si cumple con la búsqueda, mostrar la fila
                End If
            End If
        Next
    End Sub


    Private Sub IPBBuscarUsuario_Click(sender As Object, e As EventArgs) Handles IPBBuscarUsuario.Click
        Dim filtro As String = TBBuscarUsuario.Text.Trim()
        Dim estadoFiltro As String = If(CBFiltro.SelectedItem IsNot Nothing, CBFiltro.SelectedItem.ToString(), "Todos")


        For Each r As DataGridViewRow In DGVListaUsuarios.Rows
            r.Visible = False
        Next

        For Each r As DataGridViewRow In DGVListaUsuarios.Rows
            Dim estado As String = r.Cells("C_TipoDeUsuario").Value.ToString()
            Dim mostrar As Boolean = False

            ' Filtrar según el ComboBox
            If estadoFiltro = "Maestro" And estado = "maestro" Then
                mostrar = True
            ElseIf estadoFiltro = "Técnico" And estado = "tecnico" Then
                mostrar = True
            ElseIf estadoFiltro = "Administrador" And estado = "admin" Then
                mostrar = True
            ElseIf estadoFiltro = "Todos" Then
                mostrar = True
            End If

            ' Verificar si coincide con la búsqueda
            If mostrar Then
                If String.IsNullOrEmpty(filtro) OrElse r.Cells.Cast(Of DataGridViewCell)().Any(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString().ToUpper().Contains(filtro.ToUpper())) Then
                    r.Visible = True ' Si cumple con la búsqueda, mostrar la fila
                End If
            End If
        Next
    End Sub

    Private Sub ManejarFiltro(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        FiltrarUsuarios()
    End Sub

    Private Sub TBBuscarUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TBBuscarUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simula un clic en el botón de búsqueda
            IPBBuscarUsuario_Click(sender, e)
            e.SuppressKeyPress = True ' Evita el sonido de "beep" al presionar Enter
        End If
    End Sub
End Class
