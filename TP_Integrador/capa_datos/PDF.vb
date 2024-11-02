Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports TP_Integrador.Equipos
Imports System.IO

Public Class PDF

    Public Shared Sub GenerarPDFIngresoEquipo(equipo As Equipos.Equipo)

        Dim equipos As Equipos = New Equipos()

        Dim rutaCarpeta As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Documentos")
        ' Ruta donde se guardará el PDF
        Dim rutaArchivo As String = Path.Combine(rutaCarpeta, "ConstanciaIngresoEquipo.pdf")

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
            documento.Save(rutaArchivo)
            MessageBox.Show("PDF generado exitosamente en " & rutaArchivo)
        Catch ex As Exception
            MessageBox.Show("Error al guardar el PDF: " & ex.Message)
        Finally
            documento.Close()
        End Try
    End Sub


















    Public Shared Sub GenerarPDFFacturaEquipo(equipo As Equipos.Equipo)

        Dim equipos As Equipos = New Equipos()

        Dim rutaCarpeta As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Documentos")
        ' Ruta donde se guardará el PDF
        Dim rutaArchivo As String = Path.Combine(rutaCarpeta, "FacturaEquipoReparado.pdf")


        ' Crear el documento PDF
        Dim documento As New PdfDocument()
        documento.Info.Title = "Factura"

        ' Crear una página
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)

        ' Definir fuentes
        Dim fuenteTitulo As New XFont("Arial", 18, XFontStyle.Bold)
        Dim fuenteSubtitulo As New XFont("Arial", 14, XFontStyle.Bold)
        Dim fuenteTexto As New XFont("Arial", 12, XFontStyle.Regular)

        ' Ajustar la posición inicial en Y
        Dim yPosition As Double = 20 ' Inicia cerca del margen superior

        ' Título del documento
        gfx.DrawString("Factura", fuenteTitulo, XBrushes.Black, New XRect(0, yPosition, pagina.Width, pagina.Height), XStringFormats.TopCenter)
        yPosition += 50 ' Espacio adicional debajo del título

        ' Fecha y hora de finalización de la reparación
        Dim fechaFinReparacion As DateTime = Entregas.devolverEntrega(equipo.IDEquipo).fecha
        gfx.DrawString("Fecha de emisión: " & fechaFinReparacion, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30 ' Espacio adicional después de la fecha

        ' Datos del Cliente
        gfx.DrawString("Datos del Cliente", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Espacio después del subtítulo

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

        ' Servicio realizado
        gfx.DrawString("Servicio realizado", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Espacio después del subtítulo

        Dim reparacion As String = Reparaciones.devolverReparacion(equipo.IDEquipo).observaciones
        gfx.DrawString(reparacion, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30 ' Espacio adicional después del servicio realizado

        ' Subtotal
        gfx.DrawString("Subtotal", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Espacio después del subtítulo

        Dim presupuesto_observacion As String = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Detalles
        gfx.DrawString(presupuesto_observacion, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Espacio adicional después del subtotal

        ' Total
        gfx.DrawString("Total", fuenteSubtitulo, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 20 ' Espacio después del subtítulo

        Dim presupuesto_monto As Double = Presupuestos.obtenerPresupuestoParaInforme(equipo.IDEquipo).Monto
        gfx.DrawString("Monto: $" & presupuesto_monto, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 30 ' Espacio adicional después del total

        Dim metodoPago = Entregas.devolverEntrega(equipo.IDEquipo).metodoPago.nombre
        gfx.DrawString("Método de pago: " & metodoPago, fuenteTexto, XBrushes.Black, New XPoint(40, yPosition))
        yPosition += 40 ' Espacio adicional antes de guardar el documento

        ' Guardar el documento
        Try
            documento.Save(rutaArchivo)
            MessageBox.Show("PDF generado exitosamente en " & rutaArchivo)
        Catch ex As Exception
            MessageBox.Show("Error al guardar el PDF: " & ex.Message)
        Finally
            documento.Close()
        End Try
    End Sub






















    Public Shared Sub generarPDFInformeEquipo(equipo As Equipos.Equipo)

        Dim equipos As Equipos = New Equipos()

        Dim rutaCarpeta As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Documentos")
        ' Ruta donde se guardará el PDF
        Dim rutaArchivo As String = Path.Combine(rutaCarpeta, "InformeEquipoReparado.pdf")

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
            documento.Save(rutaArchivo)
            MessageBox.Show("PDF generado exitosamente en " & rutaArchivo)
        Catch ex As Exception
            MessageBox.Show("Error al guardar el PDF: " & ex.Message)
        Finally
            documento.Close()
        End Try
    End Sub



End Class
