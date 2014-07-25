Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports ColasBancarias.Entidades


Namespace MetodosCliente
    Public Class MetodosCliente
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

        Public Sub insertarCliente(ByVal ObjCliente As OBJETOS.ObjCliente)
            Try
                Dim conn As New ConeccionOracle.ConeccionOracle()
                If conn.connection.State = ConnectionState.Closed Then
                    conn.connection.Open()
                End If
                conn.cmd = New OracleCommand("INSERT_TBCLIENTE", conn.connection)
                conn.cmd.CommandType = CommandType.StoredProcedure

                conn.cmd.Parameters.Add("PTIPO_CLIENTE", OracleDbType.Int32, ObjCliente.id_tipo_cliente, ParameterDirection.Input)
                conn.cmd.Parameters.Add("PCEDULA", OracleDbType.Varchar2, ObjCliente.cedula_cliente, ParameterDirection.Input)
                conn.cmd.Parameters.Add("PNOMBRE", OracleDbType.Varchar2, ObjCliente.nombre_cliente, ParameterDirection.Input)
                conn.cmd.Parameters.Add("PEDAD_CLIENTE", OracleDbType.Int32, ObjCliente.edad_cliente, ParameterDirection.Input)
                conn.cmd.ExecuteReader()

                conn.cmd.Dispose()
                conn.connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Cliente", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End Sub
    End Class
End Namespace
