Namespace OBJETOS
    Public Class ObjFilaCliente

        Property id_fila_cliente As Integer
        Property id_cliente As Integer
        Property tipo_cliente As Char
        Property prioridad As String
        Property numero_ficha As Integer
        Property hora_llegada As String
        Property estado As String


        Sub New()

            id_fila_cliente = Integer.MinValue
            id_cliente = Integer.MinValue
            tipo_cliente = Char.MinValue
            prioridad = String.Empty
            numero_ficha = Integer.MinValue
            hora_llegada = String.Empty
            estado = String.Empty
        End Sub
    End Class
End Namespace
