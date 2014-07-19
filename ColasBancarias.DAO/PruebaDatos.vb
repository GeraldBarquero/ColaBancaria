Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports Oracle.DataAccess.Client

Namespace PruebaDatos
    Public Class cadClientes
        Public Function consultarCliente() As DataTable
            Dim tablaClientes As New DataTable()
            Try
                Dim conn As New ConeccionOracle.ConeccionOracle()
                If conn.connection.State = ConnectionState.Closed Then
                    conn.connection.Open()
                End If
                conn.cmd = New OracleCommand("sp_tclientes_mostrar", conn.connection)
                conn.cmd.CommandType = CommandType.StoredProcedure

                conn.cmd.Parameters.Add("c_clientes", OracleDbType.RefCursor, ParameterDirection.Output)

                Dim dataReader As OracleDataReader = conn.cmd.ExecuteReader()

                tablaClientes.Load(dataReader)

                conn.connection.Close()
                Return tablaClientes
            Catch ex As Exception
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                msg = "Error al consultar Clientes"   ' Define message.
                style = MsgBoxStyle.DefaultButton2 Or _
                   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                title = "MsgBox Demonstration"   ' Define title.
                ' Display message.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then   ' User chose Yes.
                    ' Perform some action.
                Else
                    ' Perform some other action.
                End If
                Return tablaClientes
            End Try
        End Function

       

        Public Function MsgBox( _
           ByVal Prompt As Object, _
           Optional ByVal Buttons As MsgBoxStyle = MsgBoxStyle.OkOnly, _
           Optional ByVal Title As Object = Nothing _
        ) As MsgBoxResult
        End Function
    End Class
End Namespace