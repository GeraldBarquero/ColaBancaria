Imports ColasBancarias.BLL

Public Class Frm_ListaBitacora
    Dim ejecucion As New BllBitacora

    Private Sub Frm_Bitacora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dgv_Bitacora.DataSource = ejecucion.llenarBitacora()
    End Sub
End Class