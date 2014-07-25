Public Class Frm_Inicio

    Private Sub Bt_Clientes_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Clientes.Click
        Dim ListaClientes As New Frm_ListaClientes
        ListaClientes.ShowDialog()
<<<<<<< HEAD
    End Sub

    Private Sub Bnt_NuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCliente.Click
        Dim NuevoCliente As New Frm_RegistroCliente
=======

    End Sub

    Private Sub Bnt_RegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCliente.Click
        Dim NuevoCliente As New Frm_NuevoCliente
>>>>>>> 6d9d6ee2371317435acdb2fef5e2349ebbb86734
        NuevoCliente.ShowDialog()
    End Sub

    Private Sub Bnt_NuevoCajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCajero.Click
        Dim NuevoCajero As New Frm_RegistroCajero
        NuevoCajero.ShowDialog()
    End Sub
End Class