Imports ColasBancarias.DAO
Imports ColasBancarias.Entidades

Public Class BllBitacora
    Dim ejecucion As New MetodosBitacora

    Public Function llenarBitacora()

        Dim tablaListaBitacora = ejecucion.listaBitacora()

        Return tablaListaBitacora
    End Function
End Class
