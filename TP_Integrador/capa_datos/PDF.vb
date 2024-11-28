Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports TP_Integrador.Equipos
Imports System.IO
Imports PdfSharp.Drawing.Layout

Public Class PDF

    Public Shared Sub GenerarPDFIngresoEquipo(equipo As Equipos.Equipo)

        Dim equipos As Equipos = New Equipos()

        ' Crear el documento PDF
        Dim documento As New PdfDocument()
        documento.Info.Title = "Constancia de Ingreso de Equipo"

        ' Crear una página
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)

        ' Definir fuentes
        Dim fuenteTitulo As New XFont("Arial", 18, XFontStyle.Bold)
        Dim fuenteSubtitulo As New XFont("Arial", 14, XFontStyle.Bold)
        Dim fuenteTexto As New XFont("Arial", 12, XFontStyle.Regular)

        ' Cargar la imagen (reemplaza la ruta con la de tu imagen)
        Dim rutaImagen As String = "..\..\..\imagenes\gst_logo.png" ' Asegúrate de usar la ruta correcta de tu imagen
        Dim imagen As XImage = XImage.FromFile(rutaImagen)
        gfx.DrawImage(imagen, 20, 20, 100, 100) ' Ajusta la posición y el tamaño según prefieras

        ' Ajustar la posición inicial en Y para el contenido (un poco más abajo que la imagen)
        Dim yPosition As Double = 120 ' Ajusta según el alto de tu imagen y un margen adicional

        ' Título del documento
        gfx.DrawString("Constancia de Ingreso de Equipo", fuenteTitulo, XBrushes.Black, New XRect(0, yPosition, pagina.Width, pagina.Height), XStringFormats.TopCenter)
        yPosition += 50 ' Espacio adicional debajo del título

        ' Obtener la fecha de ingreso
        Dim fechaIngreso As DateTime = Equipos.obtenerEquipo(equipo.IDEquipo).fechaIngreso
        gfx.DrawString("Fecha y Hora de Ingreso: " & fechaIngreso, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 40 ' Espacio adicional después de la fecha

        ' Datos del Cliente
        gfx.DrawString("Datos del Cliente", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20

        Dim nombreCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Nombre & " " & equipos.obtenerCliente(equipo.IDEquipo).Apellido
        Dim DNICliente As String = equipos.obtenerCliente(equipo.IDEquipo).Dni
        Dim telefonoCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Telefono
        Dim correoCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Correo

        gfx.DrawString("Nombre: " & nombreCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("DNI: " & DNICliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Teléfono: " & telefonoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Correo: " & correoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 40 ' Espacio adicional después de los datos del cliente

        ' Detalles del Equipo
        gfx.DrawString("Detalles del Equipo", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20

        Dim tipoEquipo As String = Equipos.obtenerEquipo(equipo.IDEquipo).TipoEquipo.Nombre
        Dim marcaEquipo As String = Equipos.obtenerEquipo(equipo.IDEquipo).Marca.nombre
        Dim modeloEquipo As String = Equipos.obtenerEquipo(equipo.IDEquipo).Modelo.nombre
        Dim numeroSerie As String = Equipos.obtenerEquipo(equipo.IDEquipo).NumeroSerie

        gfx.DrawString("Tipo de Equipo: " & tipoEquipo, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Marca: " & marcaEquipo, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Modelo: " & modeloEquipo, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Número de Serie: " & numeroSerie, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 40 ' Espacio adicional después de los detalles del equipo

        Dim pageWidth As Double = 500 ' Ajusta el ancho disponible en tu página
        Dim textWrapLimit As Integer = 60 ' Ajusta este valor según el ancho disponible para el texto


        ' Razón de Ingreso
        gfx.DrawString("Razón de Ingreso", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim razonIngreso As String = Equipos.obtenerEquipo(equipo.IDEquipo).RazonIngreso.Replace("–", "-").Replace("—", "-")
        Dim wrappedRazonIngreso As List(Of String) = WrapTextWithLineBreaks(razonIngreso, textWrapLimit)

        For Each line As String In wrappedRazonIngreso
            gfx.DrawString(line, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
            yPosition += 20 ' Avanza la posición para cada línea
        Next
        yPosition += 20 ' Espacio adicional después de la razón de ingreso

        ' Observaciones Iniciales
        gfx.DrawString("Observaciones Iniciales", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim observaciones As String = Equipos.obtenerEquipo(equipo.IDEquipo).Observaciones.Replace("–", "-").Replace("—", "-")
        Dim wrappedObservaciones As List(Of String) = WrapTextWithLineBreaks(observaciones, textWrapLimit)

        For Each line As String In wrappedObservaciones
            gfx.DrawString(line, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
            yPosition += 20 ' Avanza la posición para cada línea
        Next
        yPosition += 20 ' Espacio adicional después de las observaciones

        ' Firmas
        gfx.DrawString("Firma del Administrador: ________________________", fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Firma del Cliente: ________________________", fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        ' Guardar el documento

        Try
            Dim saveFileDialog = New SaveFileDialog()

            saveFileDialog.Filter = "PDF Files |*.pdf"
            saveFileDialog.Title = "Guardar constancia"
            saveFileDialog.FileName = "ConstanciaIngresoEquipo-" + equipo.IDEquipo.ToString() + ".pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                documento.Save(saveFileDialog.FileName)

                MessageBox.Show("PDF generado exitosamente en " & saveFileDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar el PDF: " & ex.Message)
        Finally
            documento.Close()
        End Try
    End Sub



    ' Función para dividir texto en líneas
    Private Shared Function WrapText(ByVal text As String, ByVal maxCharsPerLine As Integer) As String()
        Dim words As String() = text.Split(" "c)
        Dim lines As New List(Of String)
        Dim currentLine As String = ""

        For Each word As String In words
            If currentLine.Length + word.Length + 1 <= maxCharsPerLine Then
                currentLine &= If(currentLine = "", "", " ") & word
            Else
                lines.Add(currentLine)
                currentLine = word
            End If
        Next
        If currentLine.Length > 0 Then lines.Add(currentLine)

        Return lines.ToArray()
    End Function

    Private Shared Function WrapTextWithLineBreaks(ByVal text As String, ByVal maxCharsPerLine As Integer) As List(Of String)
        Dim result As New List(Of String)
        ' Divide el texto original en líneas donde encuentre saltos de línea explícitos
        Dim paragraphs As String() = text.Split(New String() {vbLf, vbCrLf}, StringSplitOptions.None)

        For Each paragraph As String In paragraphs
            ' Usa la función WrapText para dividir solo las líneas largas dentro del párrafo
            Dim wrappedLines As String() = WrapText(paragraph, maxCharsPerLine)
            result.AddRange(wrappedLines)
        Next

        Return result
    End Function



















    Public Shared Sub GenerarPDFFacturaEquipo(equipo As Equipos.Equipo)

        Dim equipos As Equipos = New Equipos()

        ' Crear el documento PDF
        Dim documento As New PdfDocument()
        documento.Info.Title = "Factura"

        ' Crear una página
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)
        Dim tf As New XTextFormatter(gfx)

        ' Definir colores y fuentes
        Dim colorAzulFondo As XColor = XColor.FromArgb(25, 50, 200)
        Dim fuenteTitulo As New XFont("Arial", 22, XFontStyle.Bold)
        Dim fuenteTexto As New XFont("Arial", 12, XFontStyle.Regular)
        Dim fuenteSubtitulo As New XFont("Arial", 14, XFontStyle.Bold)
        Dim fuenteTablaHeader As New XFont("Arial", 12, XFontStyle.Bold)


        ' Cargar el logo desde un archivo (asegurate de poner la ruta correcta)
        Dim logo As XImage = XImage.FromFile("..\..\..\imagenes\gst_logo.png")

        gfx.DrawRectangle(New XSolidBrush(colorAzulFondo), New XRect(0, 0, pagina.Width, 100))
        gfx.DrawString("FACTURA", fuenteTitulo, XBrushes.White, New XPoint(40, 40))
        gfx.DrawString("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy"), fuenteTexto, XBrushes.White, New XPoint(40, 70))

        ' Logo en la esquina superior derecha
        gfx.DrawImage(logo, CDbl(pagina.Width) - 120, 10, 100, 80)  ' Ajusta el tamaño y la posición según sea necesario

        ' Información de la Empresa (centrada en el fondo azul)
        Dim empresaX As Double = (CDbl(pagina.Width) - 200) / 2 ' Centrado horizontal
        Dim empresaY As Double = 30 ' Posición vertical, por debajo del título

        ' Información de la empresa centrada
        gfx.DrawString("EMPRESA", fuenteSubtitulo, XBrushes.White, New XPoint(empresaX, empresaY))
        gfx.DrawString("Gestión de Servicios Técnicos", fuenteTexto, XBrushes.White, New XPoint(empresaX, empresaY + 20))
        gfx.DrawString("LaMadrid 123, Corrientes Cap. CP:3400", fuenteTexto, XBrushes.White, New XPoint(empresaX, empresaY + 40))
        gfx.DrawString("911-234-567", fuenteTexto, XBrushes.White, New XPoint(empresaX, empresaY + 60))
        gfx.DrawString("GestionST@gmail.com", fuenteTexto, XBrushes.White, New XPoint(empresaX, empresaY + 80))

        ' Resto de la información de cliente y reparaciones
        Dim yPosition As Double = empresaY + 100 '
        gfx.DrawString("CLIENTE", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20

        Dim nombreCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Nombre & " " & equipos.obtenerCliente(equipo.IDEquipo).Apellido
        Dim DNICliente As String = equipos.obtenerCliente(equipo.IDEquipo).Dni
        Dim telefonoCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Telefono
        Dim correoCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Correo

        gfx.DrawString("Nombre: " & nombreCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        gfx.DrawString("DNI: " & DNICliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition + 20))
        gfx.DrawString("Teléfono: " & telefonoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition + 40))
        gfx.DrawString("Correo: " & correoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition + 60))

        Dim pageWidth As Double = 500 ' Ajusta el ancho disponible en tu página
        Dim textWrapLimit As Integer = 80 ' Ajusta este valor según el ancho disponible para el texto

        ' Línea separadora
        gfx.DrawLine(XPens.Black, 40, yPosition + 80, CDbl(pagina.Width) - 40, yPosition + 80)

        ' Sección de Reparaciones
        gfx.DrawString("REPARACIONES", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition + 100))
        yPosition += 40 ' Incrementar la posición después de la etiqueta

        Dim reparacion As String = Reparaciones.devolverReparacion(equipo.IDEquipo).observaciones.Replace("–", "-").Replace("—", "-")
        Dim wrappedReparacion As List(Of String) = WrapTextWithLineBreaks(reparacion, textWrapLimit)
        tf.Alignment = XParagraphAlignment.Left

        ' Dibujar el texto de las observaciones
        For Each line As String In wrappedReparacion
            gfx.DrawString(line, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition + 80))
            yPosition += 20 ' Avanzar la posición para cada línea
        Next


        ' Sección de Insumos
        yPosition += 100
        gfx.DrawString("INSUMOS", fuenteTablaHeader, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20


        Dim presupuesto_observacion As String = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Detalles.Replace("–", "-").Replace("—", "-")

        Dim wrappedObservacion As List(Of String) = WrapTextWithLineBreaks(presupuesto_observacion, textWrapLimit)

        For Each line As String In wrappedObservacion
            gfx.DrawString(line, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
            yPosition += 20 ' Avanza la posición para cada línea
        Next

        yPosition += 30

        gfx.DrawString("TECNICO", fuenteTablaHeader, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20

        'ACA AGREGA EL TECNICO
        Dim tecnico As Usuarios.Usuario = Reparaciones.devolverReparacion(equipo.IDEquipo).Tecnico

        gfx.DrawString("Nombre: " + tecnico.Nombre + " " + tecnico.Apellido, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Avanza la posición para cada línea

        gfx.DrawString("E-mail: " + tecnico.Correo, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Avanza la posición para cada línea

        gfx.DrawString("Telefono: " + tecnico.Telefono, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Avanza la posición para cada línea


        ' Línea separadora
        gfx.DrawLine(XPens.Black, 40, yPosition, CDbl(pagina.Width) - 40, yPosition)



        Dim IVA As Double = 8000
        Dim presupuesto_monto As Double = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Monto + IVA


        ' Total de la factura
        yPosition += 50
        gfx.DrawString("IVA", fuenteTablaHeader, XBrushes.Black, New XPoint(300, yPosition))
        gfx.DrawString(IVA & " $", fuenteTexto, XBrushes.Black, New XPoint(400, yPosition))
        yPosition += 20
        gfx.DrawString("TOTAL", fuenteTablaHeader, XBrushes.Black, New XPoint(300, yPosition))
        gfx.DrawString(presupuesto_monto & " $", fuenteTexto, XBrushes.Black, New XPoint(400, yPosition))

        ' Guardar el documento
        Try
            Dim saveFileDialog = New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files |*.pdf"
            saveFileDialog.Title = "Guardar factura"
            saveFileDialog.FileName = "Factura-" & equipo.IDEquipo.ToString() & ".pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                documento.Save(saveFileDialog.FileName)
                MessageBox.Show("PDF generado exitosamente en " & saveFileDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar el PDF: " & ex.Message)
        Finally
            documento.Close()
        End Try
    End Sub























    Public Shared Sub generarPDFInformeEquipo(equipo As Equipos.Equipo)

        Dim equipos As Equipos = New Equipos()

        ' Crear el documento PDF
        Dim documento As New PdfDocument()
        documento.Info.Title = "Informe de Equipo"

        ' Crear una página
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)

        ' Definir fuentes
        Dim fuenteTitulo As New XFont("Verdana", 16, XFontStyle.Bold)
        Dim fuenteSubtitulo As New XFont("Verdana", 12, XFontStyle.Bold)
        Dim fuenteTexto As New XFont("Verdana", 10, XFontStyle.Regular)

        Dim yPosition As Double = 10

        ' Título del documento
        gfx.DrawString("Informe de Equipo Reparado", fuenteTitulo, XBrushes.Black, New XRect(0, yPosition, pagina.Width, pagina.Height), XStringFormats.TopCenter)
        yPosition += 40

        ' Fecha y hora de finalización de la reparación
        Dim fechaFinReparacion As DateTime = Reparaciones.devolverReparacion(equipo.IDEquipo).fechaDeFinalizacion
        gfx.DrawString("Fecha de Finalización: " & fechaFinReparacion, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30

        '---------------------------------------------------------------------------------------------------

        ' Datos del Cliente
        gfx.DrawString("Datos del Cliente", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim nombreCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Nombre & " " & equipos.obtenerCliente(equipo.IDEquipo).Apellido
        Dim DNICliente As String = equipos.obtenerCliente(equipo.IDEquipo).Dni
        Dim telefonoCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Telefono
        Dim correoCliente As String = equipos.obtenerCliente(equipo.IDEquipo).Correo

        gfx.DrawString("Nombre: " & nombreCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("DNI: " & DNICliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Teléfono: " & telefonoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Correo: " & correoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30


        '---------------------------------------------------------------------------------------------------

        ' Detalles del Equipo
        gfx.DrawString("Detalles del Equipo", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim tipoEquipo As String = Equipos.obtenerEquipo(equipo.IDEquipo).TipoEquipo.Nombre
        Dim marcaEquipo As String = Equipos.obtenerEquipo(equipo.IDEquipo).Marca.nombre
        Dim modeloEquipo As String = Equipos.obtenerEquipo(equipo.IDEquipo).Modelo.nombre
        Dim numeroSerie As String = Equipos.obtenerEquipo(equipo.IDEquipo).NumeroSerie

        gfx.DrawString("Tipo de Equipo: " & tipoEquipo, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Marca: " & marcaEquipo, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Modelo: " & modeloEquipo, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Número de Serie: " & numeroSerie, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30

        '---------------------------------------------------------------------------------------------------

        Dim pageWidth As Double = 500 ' Ajusta el ancho disponible en tu página
        Dim textWrapLimit As Integer = 80 ' Ajusta este valor según el ancho disponible para el texto

        ' Revisiones
        gfx.DrawString("Revisiones", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim descripcionRevisiones As String = Revisiones.obtenerRevisionStringPorID(equipo.IDEquipo).Replace("–", "-").Replace("—", "-")
        Dim wrappedRevisiones As List(Of String) = WrapTextWithLineBreaks(descripcionRevisiones, textWrapLimit)

        For Each line As String In wrappedRevisiones
            gfx.DrawString(line, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
            yPosition += 20 ' Avanza la posición para cada línea
        Next
        yPosition += 10
        '---------------------------------------------------------------------------------------------------




        ' Presupuesto
        gfx.DrawString("Presupuesto", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim presupuesto_observacion As String = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Detalles.Replace("–", "-").Replace("—", "-")
        Dim wrapped_observacion As List(Of String) = WrapTextWithLineBreaks(presupuesto_observacion, textWrapLimit)
        Dim presupuesto_monto As Double = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Monto
        For Each line As String In wrapped_observacion
            gfx.DrawString(line, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
            yPosition += 20 ' Avanza la posición para cada línea
        Next

        gfx.DrawString("Monto: $" & presupuesto_monto, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30

        '---------------------------------------------------------------------------------------------------

        ' Reparacion

        Dim reparacionfalse As String = Nothing

        gfx.DrawString("Reparacion", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim reparacion As String = Reparaciones.devolverReparacion(equipo.IDEquipo).observaciones.Replace("–", "-").Replace("—", "-")
        Dim wrapped_reparacion As List(Of String) = WrapTextWithLineBreaks(reparacion, textWrapLimit)
        For Each line As String In wrapped_reparacion
            gfx.DrawString(line, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
            yPosition += 20 ' Avanza la posición para cada línea
        Next

        If Reparaciones.devolverReparacion(equipo.IDEquipo).reparado = False Then
            yPosition += 20
            reparacionfalse = "Debido a que el equipo es irreparable, se procederá a devolverse el equipo sin cobrarle"
            gfx.DrawString("ATENCIÓN: " & reparacionfalse, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        End If



        yPosition += 20

        '---------------------------------------------------------------------------------------------------
        ' Firmas
        gfx.DrawString("Firma del Administrador: ________________________", fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Firma del Cliente: ________________________", fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))

        ' Guardar el documento
        Try
            Dim saveFileDialog = New SaveFileDialog()

            saveFileDialog.Filter = "PDF Files |*.pdf"
            saveFileDialog.Title = "Guardar informe"
            saveFileDialog.FileName = "InformeEquipo-" + equipo.IDEquipo.ToString() + ".pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                documento.Save(saveFileDialog.FileName)

                MessageBox.Show("PDF generado exitosamente en " & saveFileDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar el PDF: " & ex.Message)
        Finally
            documento.Close()
        End Try
    End Sub



End Class
