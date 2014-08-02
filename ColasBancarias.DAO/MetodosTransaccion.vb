Imports ColasBancarias.Entidades
Imports Oracle.DataAccess.Client

Public Class MetodosTransaccion

    Public Sub insertarTransaccion(ByVal objtransaccion As OBJETOS.ObjTransaccion)
        Try
            Dim conn As New ConeccionOracle.ConeccionOracle()
            If conn.connection.State = ConnectionState.Closed Then
                conn.connection.Open()
            End If
            conn.cmd = New OracleCommand("INSERT_TBTRANSACCION", conn.connection)
            conn.cmd.CommandType = CommandType.StoredProcedure

            conn.cmd.Parameters.Add("PCLIENTE")
            conn.cmd.Parameters.Add("PCAJERO")
            conn.cmd.Parameters.Add("PTIPO_TRANSACCION")

        Catch ex As Exception

        End Try
    End Sub


End Class
