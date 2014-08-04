Imports ColasBancarias.DAO
Imports ColasBancarias.Entidades


Public Class BllTransaccion
    Dim ejecutar As New MetodosTransaccion

    Public Sub insertarTransaccion(ByVal datosTransaccion As OBJETOS.ObjTransaccion)
        ejecutar.insertarTransaccion(datosTransaccion)
    End Sub

End Class
