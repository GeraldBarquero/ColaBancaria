Imports ColasBancarias.DAO
Imports ColasBancarias.Entidades

Public Class BllCliente
    Dim objeto As Integer
    Dim ejecutar As New MetodosCliente.MetodosCliente

    Public Function consultarCliente(objeto)
        Dim tablaCliente As New DataTable()

        tablaCliente = ejecutar.consultarCliente(objeto)

        Return tablaCliente
    End Function

    Public Function listaCliente()
        Dim tablaListaCliente As New DataTable()

        tablaListaCliente = ejecutar.listaCliente()

        Return tablaListaCliente
    End Function

    Public Sub insertarCliente(ByVal datosCliente As OBJETOS.ObjCliente)
        ejecutar.insertarCliente(datosCliente)
    End Sub
End Class
