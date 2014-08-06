Imports ColasBancarias.BLL
Public Class Frm_ListaCajeros
    Dim ejecutar As New BllCajero

    Private Sub Frm_ListaCajeros_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDataGridView()
    End Sub

    Private Sub CargarDataGridView()
        Dgv_Cajeros.DataSource = ejecutar.listaCajero()
    End Sub

    Private Sub Frm_ListaCajeros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDataGridView()
    End Sub

    Private Sub Btn_RegistrarCajero_Click(sender As System.Object, e As System.EventArgs) Handles Btn_RegistrarCajero.Click
        Dim registroCajero As New Frm_RegistroCajero
        registroCajero.ShowDialog()
    End Sub

End Class