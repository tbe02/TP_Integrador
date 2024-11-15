Public Class FormBackup
    Private _controladorRestauracionYRespaldo As ControladorRestauracionYRespaldo = New ControladorRestauracionYRespaldo()

    Private Sub EmpezarBackup(sender As Object, e As EventArgs) Handles BBackup.Click
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Backup Files (*.bak)|*.bak"
            saveFileDialog.Title = "Seleccione la ubicación para guardar el backup"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim backupPath As String = saveFileDialog.FileName

                _controladorRestauracionYRespaldo.Respaldar(backupPath)
            End If
        End Using
    End Sub

    Private Sub EmpezarRestore(sender As Object, e As EventArgs) Handles BRestore.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Backup Files (*.bak)|*.bak"
            openFileDialog.Title = "Seleccione el archivo de backup para restaurar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim backupFilePath As String = openFileDialog.FileName

                _controladorRestauracionYRespaldo.Restaurar(backupFilePath)
            End If
        End Using
    End Sub
End Class
