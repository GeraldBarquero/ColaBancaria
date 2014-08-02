Imports ColasBancarias.BLL

Public Class Frm_ListaFilaCliente
    Dim ejecutar As New BllFilaCliente
    Public imagen As String

    Private Sub Frm_ListaFilaCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dgv_FilaCliente.DataSource = ejecutar.ListaFilacliente()

    End Sub
End Class