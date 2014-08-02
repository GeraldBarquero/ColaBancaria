Imports ColasBancarias.DAO
Imports ColasBancarias.Entidades
Public Class BllFilaCliente
    Dim ejecutar As New MetodosFilaCliente

    Public Function ListaFilacliente()
        Dim tablaListaFilaCliente As New DataTable()

        tablaListaFilaCliente = ejecutar.listaFilaCliente()

        Return tablaListaFilaCliente
    End Function

    Public Function SiguienteEnFila()
        Dim valores As New Collection
        valores = ejecutar.SiguienteEnFila()

        Return valores
    End Function

    Public Function ClientesEnFila()
        Dim vCantidad As String
        vCantidad = ejecutar.ClientesEnFila()

        Return vCantidad
    End Function

    Public Function Validarcliente(ByVal cedula) As String
        Dim vResultado As String
        vResultado = ejecutar.ValidarCliente(cedula)

        Return vResultado
    End Function

    Public Sub IngresarEnFila(ByVal cedula)
        ejecutar.IngresarEnFila(cedula)
    End Sub
End Class
