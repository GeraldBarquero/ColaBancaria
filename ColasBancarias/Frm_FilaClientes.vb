Imports System.Drawing
Imports System.Windows.Forms
Imports ColasBancarias.BLL
Imports ColasBancarias.Entidades.OBJETOS

Public Class Frm_FilaClientes
    Dim ejecutarCajero As New BllCajero
    Dim ejecutarFilaCliente As New BllFilaCliente

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Bnt_Trabajar1.Enabled = False
        Bnt_Trabajar2.Enabled = False
        Bnt_Trabajar3.Enabled = False
        Bnt_Trabajar4.Enabled = False
        Lb_Contador.Text = ejecutarFilaCliente.ClientesEnFila()
        If Lb_Contador.Text = 0 Then
            PrimerCliente.Load("../../Resources/sinCliente.png")
        End If

    End Sub


    Private Sub Bnt_Siguente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Siguente1.Click, Bnt_Siguente2.Click, Bnt_Siguente3.Click, Bnt_Siguente4.Click
        Dim datosFila As New Collection
        Dim imagen As String
        Dim sexoCliente As String
        datosFila = ejecutarFilaCliente.SiguienteEnFila()
        imagen = "../../Resources/sinCliente.png"


        If Lb_Contador.Text <> "0" Then
            Lb_Contador.Text = ejecutarFilaCliente.ClientesEnFila()
            sexoCliente = datosFila.Item("Sexo_Cliente")
            Select Case datosFila.Item("Prioridad")
                Case 1
                    If sexoCliente = "Hombre" Then
                        imagen = "../../Resources/ciego.PNG"
                    ElseIf sexoCliente = "Mujer" Then
                        imagen = "../../Resources/ciega.PNG"
                    End If
                Case 2
                    If sexoCliente = "Hombre" Then
                        imagen = "../../Resources/anciano.PNG"
                    ElseIf sexoCliente = "Mujer" Then
                        imagen = "../../Resources/anciana.png"
                    End If
                Case 3
                    If sexoCliente = "Hombre" Then
                        imagen = "../../Resources/hombre.PNG"
                    ElseIf sexoCliente = "Mujer" Then
                        imagen = "../../Resources/mujer.PNG"
                    End If
                Case 4
                    If sexoCliente = "Hombre" Then
                        imagen = "../../Resources/hombre2.PNG"
                    ElseIf sexoCliente = "Mujer" Then
                        imagen = "../../Resources/mujer2.PNG"
                    End If
            End Select
            Select Case sender.Name()

                Case "Bnt_Siguente1"
                    Cliente1.Location = New Point(87, 164)
                    Cliente1.Load(imagen)
                    Cliente1.Visible = True
                    Cliente1.Show()
                    Txt_NombreCliente1.Text = datosFila.Item("Nombre_Cliente")
                Case "Bnt_Siguente2"
                    Cliente2.Location = New Point(288, 164)
                    Cliente2.Load(imagen)
                    Cliente2.Visible = True
                    Cliente2.Show()
                    Txt_NombreCliente2.Text = datosFila.Item("Nombre_Cliente")
                Case "Bnt_Siguente3"
                    Cliente3.Location = New Point(480, 164)
                    Cliente3.Load(imagen)
                    Cliente3.Visible = True
                    Cliente3.Show()
                    Txt_NombreCliente3.Text = datosFila.Item("Nombre_Cliente")
                Case "Bnt_Siguente4"
                    Cliente4.Location = New Point(682, 164)
                    Cliente4.Load(imagen)
                    Cliente4.Visible = True
                    Cliente4.Show()
                    Txt_NombreCliente4.Text = datosFila.Item("Nombre_Cliente")
            End Select
        Else
            PrimerCliente.Load(imagen)

            MessageBox.Show("No hay clientes en la fila")
        End If
        

    End Sub

    Private Sub Bnt_PararTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_PararTrabajo1.Click, Bnt_PararTrabajo4.Click, Bnt_PararTrabajo2.Click, Bnt_PararTrabajo3.Click
        Dim datosCajero As New ObjCajero
        Dim accion As String
        Dim idCajero As Integer
        Try
            accion = "SALIDA"

            Select Case sender.Name()

                Case "Bnt_PararTrabajo1"
                    datosCajero.id_cajero = 41
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente1.Enabled = False
                    Bnt_PararTrabajo1.Enabled = False
                    Bnt_Trabajar1.Enabled = True
                Case "Bnt_PararTrabajo2"
                    datosCajero.id_cajero = 21
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente2.Enabled = False
                    Bnt_PararTrabajo2.Enabled = False
                    Bnt_Trabajar2.Enabled = True
                Case "Bnt_PararTrabajo3"
                    datosCajero.id_cajero = 22
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente3.Enabled = False
                    Bnt_PararTrabajo3.Enabled = False
                    Bnt_Trabajar3.Enabled = True
                Case "Bnt_PararTrabajo4"
                    datosCajero.id_cajero = 23
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente4.Enabled = False
                    Bnt_PararTrabajo4.Enabled = False
                    Bnt_Trabajar4.Enabled = True
            End Select

            idCajero = datosCajero.id_cajero
            MessageBox.Show("El cajero número : " & idCajero & " salio a almorzar.")
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al salir el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try


    End Sub

    Private Sub Bnt_Trabajar_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Trabajar1.Click, Bnt_Trabajar2.Click, Bnt_Trabajar3.Click, Bnt_Trabajar4.Click
        Dim datosCajero As New ObjCajero
        Dim accion As String
        Dim idCajero As Integer
        Try
            accion = "ENTRADA"
            Select Case sender.Name()
                Case "Bnt_Trabajar1"
                    datosCajero.id_cajero = 41
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente1.Enabled = True
                    Bnt_PararTrabajo1.Enabled = True
                    Bnt_Trabajar1.Enabled = False
                Case "Bnt_Trabajar2"
                    datosCajero.id_cajero = 21
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente2.Enabled = True
                    Bnt_PararTrabajo2.Enabled = True
                    Bnt_Trabajar2.Enabled = False
                Case "Bnt_Trabajar3"
                    datosCajero.id_cajero = 22
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente3.Enabled = True
                    Bnt_PararTrabajo3.Enabled = True
                    Bnt_Trabajar3.Enabled = False
                Case "Bnt_Trabajar4"
                    datosCajero.id_cajero = 23
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente4.Enabled = True
                    Bnt_PararTrabajo4.Enabled = True
                    Bnt_Trabajar4.Enabled = False
            End Select
            idCajero = datosCajero.id_cajero
            MessageBox.Show("El cajero número : " & idCajero & " entro a trabajar.")
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al entrar el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btn_RefrescarFila_Click(sender As System.Object, e As System.EventArgs) Handles btn_RefrescarFila.Click
        Lb_Contador.Text = ejecutarFilaCliente.ClientesEnFila()
    End Sub

    Private Sub Bnt_Menu_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Menu.Click
        Dim MenuPrincipal As New Frm_Menu
        MenuPrincipal.ShowDialog()
    End Sub

    Private Sub Bnt_IngresarFila_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_IngresarFila.Click
        Dim ValidarCliente As New Frm_ValidarCliente
        ValidarCliente.ShowDialog()
    End Sub

    Private Sub Bnt_Transaccion1_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Transaccion1.Click

    End Sub
End Class