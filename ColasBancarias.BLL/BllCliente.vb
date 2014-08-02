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
