Imports ColasBancarias.BLL
Imports ColasBancarias.Entidades
Imports System.Windows.Forms

Public Class Frm_RegistroCajero
    Dim ejecutar As New BllCajero

    Private Sub Btn_CancelarRegistroCajero_Click(sender As System.Object, e As System.EventArgs) Handles Btn_CancelarRegistroCajero.Click
        Me.Close()

    End Sub

    Private Sub Btn_CrearCajero_Click(sender As System.Object, e As System.EventArgs) Handles Btn_CrearCajero.Click
        Dim datosCajero As New OBJETOS.ObjCajero
        Try
            datosCajero.cedula_cajero = Txt_CedulaCajero.Text
            datosCajero.nombre_cajero = Txt_NombreCajero.Text
            ejecutar.insertarCajero(datosCajero)

            MessageBox.Show("Se registro correctamente el cajero")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al insertar Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class