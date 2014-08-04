Namespace OBJETOS

    Public Class ObjTransaccion


        Property nombre_cliente As String
        Property id_cajero As Integer
        Property tipo_transaccion As String
        Property hora_transaccion As Date




        Sub New()

            nombre_cliente = String.Empty
            id_cajero = Integer.MinValue
            tipo_transaccion = String.Empty
            hora_transaccion = Date.MinValue


        End Sub

    End Class
End Namespace
