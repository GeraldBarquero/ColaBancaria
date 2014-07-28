Imports ColasBancarias.BLL
Imports ColasBancarias.Entidades
Imports System.Windows.Forms

Public Class Frm_RegistroCliente
    Dim ejecutar As New BllCliente
    Private Sub Btn_CrearCliente_Click(sender As System.Object, e As System.EventArgs) Handles Btn_CrearCliente.Click
        Dim datosCliente As New OBJETOS.ObjCliente
        Try
            datosCliente.cedula_cliente = Txt_CedulaCliente.Text
            datosCliente.edad_cliente = Txt_EdadCliente.Text
            datosCliente.nombre_cliente = Txt_NombreCliente.Text
            datosCliente.sexo_cliente = Cmb_SexoCliente.Text
            Select Case Cmb_TipoCliente.Text
                Case "Discapacitado"
                    datosCliente.id_tipo_cliente = 1
                Case "Adulto Mayor"
                    datosCliente.id_tipo_cliente = 2
                Case "Cliente Interno"
                    datosCliente.id_tipo_cliente = 3
                Case "Cliente Externo"
                    datosCliente.id_tipo_cliente = 4
            End Select
            ejecutar.insertarCliente(datosCliente)

            MessageBox.Show("Se registro correctamente el cliente")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al insertar Cliente", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub Btn_CancelarRegistroCliente_Click(sender As System.Object, e As System.EventArgs) Handles Btn_CancelarRegistroCliente.Click
        Me.Close()

    End Sub
End Class