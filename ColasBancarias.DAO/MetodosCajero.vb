Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports ColasBancarias.Entidades

Public Class MetodosCajero
    Public Function listaCajero() As DataTable
        Dim tablaListaCajeros As New DataTable()
        Try
            Dim conn As New ConeccionOracle.ConeccionOracle()
            If conn.connection.State = ConnectionState.Closed Then
                conn.connection.Open()
            End If
            conn.cmd = New OracleCommand("LISTA_CAJEROS", conn.connection)
            conn.cmd.CommandType = CommandType.StoredProcedure

            conn.cmd.Parameters.Add("P_LISTA", OracleDbType.RefCursor, ParameterDirection.Output)

            Dim dataReader As OracleDataReader = conn.cmd.ExecuteReader()

            tablaListaCajeros.Load(dataReader)

            conn.connection.Close()
            Return tablaListaCajeros
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al consultar Cajeros", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return tablaListaCajeros
        End Try
    End Function

    Public Sub insertarCajero(ByVal ObjCajero As OBJETOS.ObjCajero)
        Try
            Dim conn As New ConeccionOracle.ConeccionOracle()
            If conn.connection.State = ConnectionState.Closed Then
                conn.connection.Open()
            End If
            conn.cmd = New OracleCommand("INSERT_TBCAJERO", conn.connection)
            conn.cmd.CommandType = CommandType.StoredProcedure

            conn.cmd.Parameters.Add("PCEDULA", OracleDbType.Varchar2, ObjCajero.cedula_cajero, ParameterDirection.Input)
            conn.cmd.Parameters.Add("PNOMBRE", OracleDbType.Varchar2, ObjCajero.nombre_cajero, ParameterDirection.Input)
            conn.cmd.ExecuteReader()

            conn.cmd.Dispose()
            conn.connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al insertar Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

    End Sub

    Public Sub AlmuerzoCafeOtros(ByVal objCajero As OBJETOS.ObjCajero, ByVal accion As String)
        Try
            Dim conn As New ConeccionOracle.ConeccionOracle()
            If conn.connection.State = ConnectionState.Closed Then
                conn.connection.Open()
            End If

            conn.cmd = New OracleCommand("ALMUERZO_CAFE_OTROS", conn.connection)
            conn.cmd.CommandType = CommandType.StoredProcedure
            conn.cmd.Parameters.Add("PID_CAJERO", OracleDbType.Int32, objCajero.id_cajero, ParameterDirection.Input)
            conn.cmd.Parameters.Add("PACCION", OracleDbType.Varchar2, accion, ParameterDirection.Input)
            conn.cmd.ExecuteReader()
            conn.cmd.Dispose()
            conn.connection.Close()
        Catch ex As Exception

        End Try

    End Sub





End Class
