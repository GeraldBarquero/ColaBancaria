Namespace OBJETOS
    Public Class ObjTipoCliente

        Property id_tipo_cliente As Integer
        Property tipo_cliente As Char
        Property prioridad As Integer

        Sub New()
            id_tipo_cliente = Integer.MinValue
            tipo_cliente = Char.MinValue
            prioridad = Integer.MinValue
        End Sub
    End Class
End Namespace
