Public Class Frm_Inicio

    Private Sub Bt_Clientes_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Clientes.Click
        Dim ListaClientes As New Frm_ListaClientes
        ListaClientes.ShowDialog()
    End Sub

    Private Sub Bnt_NuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCliente.Click
        Dim NuevoCliente As New Frm_RegistroCliente
        NuevoCliente.ShowDialog()
    End Sub

    Private Sub Bnt_NuevoCajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCajero.Click
        Dim NuevoCajero As New Frm_RegistroCajero
        NuevoCajero.ShowDialog()
    End Sub

    Private Sub Bt_Cajero_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Cajero.Click
        Dim ListaCajeros As New Frm_ListaCajeros
        ListaCajeros.ShowDialog()
    End Sub

    Private Sub Bt_FilaCliente_Click(sender As System.Object, e As System.EventArgs) Handles Bt_FilaCliente.Click
        Dim FilaClientes As New Frm_FilaClientes
        FilaClientes.ShowDialog()

    End Sub
End Class