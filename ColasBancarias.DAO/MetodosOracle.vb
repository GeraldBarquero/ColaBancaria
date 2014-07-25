Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace MetodosOracle
    Public Class MetodosOracle
        Dim objeto As Integer
        Public Function consultarCliente(objeto) As DataTable
            Dim tablaClientes As New DataTable()
            Try
                Dim conn As New ConeccionOracle.ConeccionOracle()
                If conn.connection.State = ConnectionState.Closed Then
                    conn.connection.Open()
                End If
                conn.cmd = New OracleCommand("DATOS_CLIENTE_ID", conn.connection)
                conn.cmd.CommandType = CommandType.StoredProcedure

                conn.cmd.Parameters.Add("P_ID_CEDULA", OracleDbType.Int32, objeto, ParameterDirection.Input)
                conn.cmd.Parameters.Add("P_DATOS", OracleDbType.RefCursor, ParameterDirection.Output)

                Dim dataReader As OracleDataReader = conn.cmd.ExecuteReader()

                tablaClientes.Load(dataReader)

                conn.connection.Close()
                Return tablaClientes
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Clientes", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return tablaClientes
            End Try
        End Function

        Public Function listaCliente() As DataTable
            Dim tablaListaClientes As New DataTable()
            Try
                Dim conn As New ConeccionOracle.ConeccionOracle()
                If conn.connection.State = ConnectionState.Closed Then
                    conn.connection.Open()
                End If
                conn.cmd = New OracleCommand("LISTA_CLIENTES", conn.connection)
                conn.cmd.CommandType = CommandType.StoredProcedure

                conn.cmd.Parameters.Add("P_LISTA", OracleDbType.RefCursor, ParameterDirection.Output)

                Dim dataReader As OracleDataReader = conn.cmd.ExecuteReader()

                tablaListaClientes.Load(dataReader)

                conn.connection.Close()
                Return tablaListaClientes
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Clientes", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return tablaListaClientes
            End Try
        End Function
    End Class
End Namespace
