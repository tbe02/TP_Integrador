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

        ' Razón de Ingreso
        gfx.DrawString("Razón de Ingreso", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim razonIngreso As String = Equipos.obtenerEquipo(equipo.IDEquipo).RazonIngreso
        gfx.DrawString(razonIngreso, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 40 ' Espacio adicional después de la razón de ingreso

        ' Observaciones Iniciales
        gfx.DrawString("Observaciones Iniciales", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim observaciones As String = Equipos.obtenerEquipo(equipo.IDEquipo).Observaciones
        gfx.DrawString(observaciones, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 40 ' Espacio adicional después de las observaciones

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

        ' Encabezado de la factura con fondo azul
        gfx.DrawRectangle(New XSolidBrush(colorAzulFondo), New XRect(0, 0, pagina.Width, 100))
        gfx.DrawString("FACTURA", fuenteTitulo, XBrushes.White, New XPoint(40, 40))
        gfx.DrawString("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy"), fuenteTexto, XBrushes.White, New XPoint(40, 70))

        ' Cargar el logo desde un archivo (asegurate de poner la ruta correcta)
        Dim logo As XImage = XImage.FromFile("C:\Users\theoe\source\repos\TP_Integrador2\TP_Integrador\imagenes\gst_logo.png")

        ' Dibujar el logo en la esquina superior derecha, al lado del título
        gfx.DrawImage(logo, CDbl(pagina.Width) - 120, 10, 100, 80)  ' Ajusta el tamaño y la posición según sea necesario

        ' Información del Cliente y Empresa
        Dim yPosition As Double = 120
        gfx.DrawString("CLIENTE:", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20

        Dim nombreCliente As String = Equipos.obtenerCliente(equipo.IDEquipo).Nombre & " " & Equipos.obtenerCliente(equipo.IDEquipo).Apellido
        Dim DNICliente As String = Equipos.obtenerCliente(equipo.IDEquipo).Dni
        Dim telefonoCliente As String = Equipos.obtenerCliente(equipo.IDEquipo).Telefono
        Dim correoCliente As String = Equipos.obtenerCliente(equipo.IDEquipo).Correo

        gfx.DrawString(nombreCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        gfx.DrawString(DNICliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition + 20))
        gfx.DrawString(telefonoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition + 40))
        gfx.DrawString(correoCliente, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition + 60))

        gfx.DrawString("EMPRESA:", fuenteSubtitulo, XBrushes.Black, New XPoint(300, 120))
        gfx.DrawString("Gestión de Servicios Técnicos", fuenteTexto, XBrushes.Black, New XPoint(300, yPosition))
        gfx.DrawString("LaMadrid 123, Corrientes Cap., CP:3400", fuenteTexto, XBrushes.Black, New XPoint(300, yPosition + 20))
        gfx.DrawString("911-234-567", fuenteTexto, XBrushes.Black, New XPoint(300, yPosition + 40))
        gfx.DrawString("hola@unsitio.com", fuenteTexto, XBrushes.Black, New XPoint(300, yPosition + 60))

        ' Línea separadora
        gfx.DrawLine(XPens.Black, 40, yPosition + 80, CDbl(pagina.Width) - 40, yPosition + 80)

        ' Sección de descripción de los productos
        yPosition += 100
        gfx.DrawString("DESCRIPCIÓN", fuenteTablaHeader, XBrushes.Black, New XPoint(40, yPosition))
        gfx.DrawString("IMPORTE", fuenteTablaHeader, XBrushes.Black, New XPoint(200, yPosition))
        yPosition += 20


        Dim presupuesto_observacion As String = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Detalles

        ' Ejemplo de producto
        gfx.DrawString(presupuesto_observacion, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30


        ' Línea separadora
        gfx.DrawLine(XPens.Black, 40, yPosition + 80, CDbl(pagina.Width) - 40, yPosition + 80)

        ' Sección de Observaciones
        gfx.DrawString("OBSERVACIONES:", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition + 30))
        Dim reparacion As String = Reparaciones.devolverReparacion(equipo.IDEquipo).observaciones
        tf.Alignment = XParagraphAlignment.Left
        tf.DrawString(reparacion, fuenteTexto, XBrushes.Black, New XRect(40, yPosition + 50, CDbl(pagina.Width) - 80, 100), XStringFormats.TopLeft)



        Dim presupuesto_monto As Double = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Monto

        ' Total de la factura
        yPosition += 150
        gfx.DrawString("IVA", fuenteTablaHeader, XBrushes.Black, New XPoint(300, yPosition))
        gfx.DrawString("0 $", fuenteTexto, XBrushes.Black, New XPoint(400, yPosition))
        yPosition += 20
        gfx.DrawString("IRPF", fuenteTablaHeader, XBrushes.Black, New XPoint(300, yPosition))
        gfx.DrawString("0 $", fuenteTexto, XBrushes.Black, New XPoint(400, yPosition))
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
        documento.Info.Title = "Informe de Equipo Reparado"

        ' Crear una página
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)

        ' Definir fuentes
        Dim fuenteTitulo As New XFont("Verdana", 16, XFontStyle.Bold)
        Dim fuenteSubtitulo As New XFont("Verdana", 12, XFontStyle.Bold)
        Dim fuenteTexto As New XFont("Verdana", 10, XFontStyle.Regular)


        Dim rutaImagen As String = "..\..\..\imagenes\gst_logo.png"
        Dim imagen As XImage = XImage.FromFile(rutaImagen)
        gfx.DrawImage(imagen, 20, 20, 100, 100)


        Dim yPosition As Double = 140

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

        ' Revisiones
        gfx.DrawString("Revisiones", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim descripcionReparaciones As String = Revisiones.obtenerRevisionStringPorID(equipo.IDEquipo)
        gfx.DrawString(descripcionReparaciones, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30
        '---------------------------------------------------------------------------------------------------




        ' Presupuesto
        gfx.DrawString("Presupuesto", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim presupuesto_observacion As String = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Detalles
        Dim presupuesto_monto As Double = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Monto
        gfx.DrawString("Observaciones: " & presupuesto_observacion, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        gfx.DrawString("Monto: $" & presupuesto_monto, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30

        '---------------------------------------------------------------------------------------------------

        ' Reparacion

        Dim reparacionfalse As String = Nothing

        gfx.DrawString("Reparacion", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20
        Dim reparacion As String = Reparaciones.devolverReparacion(equipo.IDEquipo).observaciones
        gfx.DrawString(reparacion, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))

        If Reparaciones.devolverReparacion(equipo.IDEquipo).reparado = False Then
            yPosition += 20
            reparacionfalse = "Debido a que el equipo es irreparable, se procederá a devolverse el equipo sin cobrarle"
            gfx.DrawString("ATENCIÓN: " & reparacionfalse, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        End If



        yPosition += 30

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
            saveFileDialog.FileName = "InformeEquipoReparado-" + equipo.IDEquipo.ToString() + ".pdf"

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
