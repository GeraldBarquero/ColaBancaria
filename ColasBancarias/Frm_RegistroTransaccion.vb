Imports ColasBancarias.Entidades.OBJETOS
Imports System.Windows.Forms
Imports ColasBancarias.BLL

Public Class Frm_RegistroTransaccion

    Dim ejecutar As New BllTransaccion
    Public nombreCliente As String
    Public idCajero As Integer

    Private Sub Bnt_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Bnt_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Aceptar.Click
        Dim TransaccionCliente As New ObjTransaccion
        Try
            TransaccionCliente.nombre_cliente = Txt_NombreClienteTransaccion.Text
            TransaccionCliente.id_cajero = Txt_IDCajeroTransaccion.Text
            TransaccionCliente.tipo_transaccion = Cbx_TipoTransaccion.Text
            ejecutar.insertarTransaccion(TransaccionCliente)
            MessageBox.Show("Transaccion Realizada Correctamente")
            ''TransaccionCliente.nombre_cliente = ""
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al realizar la transacion", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub Frm_RegistroTransaccion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim FrmFilaClientes As New Frm_FilaClientes

        Txt_NombreClienteTransaccion.Text = nombreCliente
        Txt_IDCajeroTransaccion.Text = idCajero



    End Sub
End Class