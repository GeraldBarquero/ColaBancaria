Namespace OBJETOS
    Public Class ObjBitacora

        Property id_bitacora_transaccion As Integer
        Property id_transaccion As Integer
        Property id_cliente As Integer
        Property id_cajero As Integer
        Property id_tipo_transaccion As Integer
        Property hora_Transaccion As String
        Property estado As String

        Sub New()

            id_bitacora_transaccion = Integer.MaxValue
            id_transaccion = Integer.MaxValue
            id_cliente = Integer.MaxValue
            id_cajero = Integer.MaxValue
            id_tipo_transaccion = Integer.MaxValue
            hora_Transaccion = String.Empty
            estado = String.Empty
        End Sub
    End Class
End Namespace



