Imports ColasBancarias.BLL

Public Class Frm_ListaClientes
    Dim ejecutar As New BllCliente

    Private Sub Frm_ListaClientes_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.Refresh()
    End Sub

    Private Sub Frm_ListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dgv_ListaClientes.DataSource = ejecutar.listaCliente()
    End Sub

    Private Sub Bt_RegistrarCliente_Click(sender As System.Object, e As System.EventArgs) Handles Bt_RegistrarCliente.Click
        Dim registroCliente As New Frm_RegistroCliente
        registroCliente.ShowDialog()
    End Sub

End Class