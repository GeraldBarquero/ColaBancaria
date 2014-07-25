Imports ColasBancarias.DAO

Public Class BllCliente
    Dim objeto As Integer
    Dim ejecutar As New MetodosOracle.MetodosOracle

    Public Function consultar(objeto)
        Dim tablaCliente As New DataTable()

        tablaCliente = ejecutar.consultarCliente(objeto)

        Return tablaCliente
    End Function


End Class
