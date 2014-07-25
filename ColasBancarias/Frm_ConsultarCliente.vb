Imports ColasBancarias.BLL

Public Class Frm_ConsultarCliente
    Dim objeto As Integer
    Dim ejecutar As New BllCliente

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 0 Then
            objeto = 0
        Else
            objeto = TextBox1.Text
        End If
        DataGridView1.DataSource = ejecutar.consultarCliente(objeto)
    End Sub
End Class