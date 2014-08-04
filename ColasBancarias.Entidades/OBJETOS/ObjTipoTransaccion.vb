Namespace OBJETOS

    Public Class ObjTransaccion


        Property id_cliente As Integer
        Property id_cajero As Integer
        Property tipo_transaccion As String
        Property hora_transaccion As Date
        Property nombre_cliente As String
        Property nombre_cajero As String


        Sub New()

            id_cliente = Integer.MinValue
            id_cajero = Integer.MinValue
            tipo_transaccion = String.Empty
            hora_transaccion = Date.MinValue
            nombre_cajero = String.Empty
            nombre_cliente = String.Empty

        End Sub

    End Class
End Namespace
