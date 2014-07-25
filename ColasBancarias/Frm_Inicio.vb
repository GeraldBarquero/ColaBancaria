Public Class Frm_Inicio

    Private Sub Bt_Clientes_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Clientes.Click
        Dim ListaClientes As New Frm_ListaClientes
        ListaClientes.ShowDialog()
    End Sub
End Class