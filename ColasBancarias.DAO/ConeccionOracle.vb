Imports Oracle.DataAccess.Client
Imports System.Data

Namespace ConeccionOracle
    Public Class ConeccionOracle
        Private conectionString_value As [String]
        Private conn_value As OracleConnection
        Private cmd_value As OracleCommand

        Public Property conectionString() As [String]
            Get
                Return conectionString_value
            End Get
            Set(value As [String])
                conectionString_value = value
            End Set
        End Property

        Public Property connection() As OracleConnection
            Get
                Return conn_value
            End Get
            Set(value As OracleConnection)
                conn_value = value
            End Set
        End Property

        Public Property cmd() As OracleCommand
            Get
                Return cmd_value
            End Get
            Set(value As OracleCommand)
                cmd_value = value
            End Set
        End Property

        Public Sub New()
            Me.conectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));User Id=colabancaria;Password=123456;"
            Me.connection = New OracleConnection(Me.conectionString)
        End Sub

    End Class
End Namespace
