Imports ColasBancarias.DAO
Imports ColasBancarias.Entidades

Public Class BllCajero
    Dim objeto As Integer
    Dim ejecutar As New MetodosCajero

    Public Function listaCajero()
        Dim tablaListaCajero As New DataTable()

        tablaListaCajero = ejecutar.listaCajero()

        Return tablaListaCajero
    End Function

    Public Sub insertarCajero(ByVal datosCajero As OBJETOS.ObjCajero)
        ejecutar.insertarCajero(datosCajero)
    End Sub
End Class
