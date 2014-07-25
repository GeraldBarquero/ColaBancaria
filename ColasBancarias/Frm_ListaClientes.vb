Imports ColasBancarias.BLL

Public Class Frm_ListaClientes
    Dim ejecutar As New BllCliente

    Private Sub Frm_ListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dgv_ListaClientes.DataSource = ejecutar.listaCliente()

    End Sub
End Class