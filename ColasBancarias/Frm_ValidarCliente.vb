Imports System.Windows.Forms
Imports ColasBancarias.BLL
Public Class Frm_ValidarCliente
    Dim ejecutar2 As New BllCliente

    Private Sub Bnt_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Aceptar.Click
        Dim Resultado As String
        Dim NumCedula As String
        Dim RegistroCliente As New Frm_RegistroCliente
        NumCedula = Txt_NumeroCedula.Text
        Resultado = ejecutar2.Validarcliente(NumCedula)

        If Resultado = "1" Then
            MessageBox.Show("El usuario se encuentra registrado en el sistema, se procede a colocarlo en la fila.")
            ejecutar2.IngresarEnFila(NumCedula)
        Else
            MessageBox.Show("El usuario no se encuentra registrado en el sistema, se procede a registrarlo.")
            RegistroCliente.ShowDialog()
            'ejecutar2.IngresarEnFila(NumCedula)
        End If
    End Sub

    Private Sub Bnt_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Cancelar.Click
        Me.Close()
    End Sub
End Class