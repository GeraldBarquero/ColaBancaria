Public Class Frm_Inicio

    Private Sub Bt_Clientes_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Clientes.Click
        Dim ListaClientes As New Frm_ListaClientes
        ListaClientes.ShowDialog()
    End Sub

    Private Sub Bnt_NuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCliente.Click
        Dim NuevoCliente As New Frm_RegistroCliente
        NuevoCliente.ShowDialog()
    End Sub
End Class