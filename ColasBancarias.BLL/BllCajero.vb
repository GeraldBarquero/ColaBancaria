Imports ColasBancarias.DAO
Imports ColasBancarias.Entidades

Public Class BllCajero
    Dim ejecutar As New MetodosCajero

    Public Function listaCajero()
        Dim tablaListaCajero As New DataTable()

        tablaListaCajero = ejecutar.listaCajero()

        Return tablaListaCajero
    End Function

    Public Sub insertarCajero(ByVal datosCajero As OBJETOS.ObjCajero)
        ejecutar.insertarCajero(datosCajero)
    End Sub

    Public Sub AlmuerzoCafeOtros(ByVal datosCajero As OBJETOS.ObjCajero, ByVal accion As String)
        ejecutar.AlmuerzoCafeOtros(datosCajero, accion)
    End Sub
End Class
