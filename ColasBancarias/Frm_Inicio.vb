Public Class Frm_Inicio

    Private Sub Bt_Clientes_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Clientes.Click
        Dim ListaClientes As New Frm_ListaClientes
        ListaClientes.ShowDialog()

    End Sub

    Private Sub Bnt_RegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCliente.Click
        Dim NuevoCliente As New Frm_NuevoCliente
        NuevoCliente.ShowDialog()
    End Sub

    Private Sub Bnt_NuevoCajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCajero.Click
        Dim NuevoCajero As New Frm_RegistroCajero
        NuevoCajero.ShowDialog()
    End Sub
End Class