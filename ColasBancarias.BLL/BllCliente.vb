Imports ColasBancarias.DAO

Public Class BllCliente
    Dim objeto As Integer
    Dim ejecutar As New MetodosOracle.MetodosOracle

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
End Class
