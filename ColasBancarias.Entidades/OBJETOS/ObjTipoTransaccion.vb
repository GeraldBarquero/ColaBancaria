Namespace OBJETOS

    Public Class ObjTipoTransaccion

        Property id_transaccion As Integer
        Property id_cliente As Integer
        Property id_cajero As Integer
        Property id_tipo_transaccion As Integer
        Property hora_transaccion As String


        Sub New()

            id_transaccion = Integer.MinValue
            id_cliente = Integer.MinValue
            id_cajero = Integer.MinValue
            id_tipo_transaccion = Integer.MinValue
            hora_transaccion = String.Empty

        End Sub

    End Class
End Namespace
