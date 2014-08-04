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

            conn.cmd.Parameters.Add("PNOMBRE_CLIENTE", OracleDbType.Varchar2, objtransaccion.nombre_cliente, ParameterDirection.Input)
            conn.cmd.Parameters.Add("PID_CAJERO", OracleDbType.Int32, objtransaccion.id_cajero, ParameterDirection.Input)
            conn.cmd.Parameters.Add("PTIPO_TRANSACCION", OracleDbType.Varchar2, objtransaccion.tipo_transaccion, ParameterDirection.Input)
            conn.cmd.ExecuteReader()

            conn.cmd.Dispose()
            conn.connection.Close()

        Catch ex As Exception

        End Try
    End Sub


End Class
