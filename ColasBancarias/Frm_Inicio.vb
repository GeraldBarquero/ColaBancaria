Public Class Frm_Inicio

    Private Sub Bnt_NuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCliente.Click
        Dim NuevoCliente As New Frm_NuevoCliente
        NuevoCliente.ShowDialog()
    End Sub
End Class