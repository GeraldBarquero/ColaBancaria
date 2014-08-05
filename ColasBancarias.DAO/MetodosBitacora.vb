Imports Oracle.DataAccess.Client
Imports System.Windows.Forms

Public Class MetodosBitacora

    Public Function listaBitacora() As DataTable
        Dim tablaListaBitacora As New DataTable()
        Try
            Dim conn As New ConeccionOracle.ConeccionOracle()
            If conn.connection.State = ConnectionState.Closed Then
                conn.connection.Open()
            End If
            conn.cmd = New OracleCommand("BITACORA", conn.connection)
            conn.cmd.CommandType = CommandType.StoredProcedure

            conn.cmd.Parameters.Add("P_BITACORA", OracleDbType.RefCursor, ParameterDirection.Output)

            Dim dataReader As OracleDataReader = conn.cmd.ExecuteReader

            tablaListaBitacora.Load(dataReader)
            conn.cmd.Dispose()
            conn.connection.Close()
            Return tablaListaBitacora
        Catch ex As Exception

        End Try
        ''  MessageBox.Show("Error: " + ex.Message, "Error al consultar la fila de clientes", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Return tablaListaBitacora

    End Function

End Class
