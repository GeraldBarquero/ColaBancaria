﻿Imports System.Drawing
Imports System.Windows.Forms
Imports ColasBancarias.BLL
Imports ColasBancarias.Entidades.OBJETOS

Public Class Frm_FilaClientes
    Dim ejecutarCajero As New BllCajero
    Dim ejecutarFilaCliente As New BllFilaCliente
    Dim ejecutar As New BllCajero
    Dim ejecutar2 As New BllCliente
    Dim idCajero As Integer
    Dim imagen As String = "../../Resources/ciego.png"

    Private Sub RefrescarCampos()
        If Txt_NombreCliente1.Text = "" Then
            Bnt_Transaccion1.Enabled = False
        Else
            Bnt_Transaccion1.Enabled = True
        End If
        If Txt_NombreCliente2.Text = "" Then
            Bnt_Transaccion2.Enabled = False
        Else
            Bnt_Transaccion2.Enabled = True
        End If
        If Txt_NombreCliente3.Text = "" Then
            Bnt_Transaccion3.Enabled = False
        Else
            Bnt_Transaccion3.Enabled = True
        End If
        If Txt_NombreCliente4.Text = "" Then
            Bnt_Transaccion4.Enabled = False
        Else
            Bnt_Transaccion4.Enabled = True
        End If
        Lb_Contador.Text = ejecutarFilaCliente.ClientesEnFila()
        PrimerCliente.Load(imagen)
        If Lb_Contador.Text = 0 Then
            PrimerCliente.Load("../../Resources/sinCliente.png")
            Bnt_Transaccion1.Enabled = False
            Bnt_Transaccion2.Enabled = False
            Bnt_Transaccion3.Enabled = False
            Bnt_Transaccion4.Enabled = False
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        RefrescarCampos()
        Bnt_Trabajar1.Enabled = False
        Bnt_Trabajar2.Enabled = False
        Bnt_Trabajar3.Enabled = False
        Bnt_Trabajar4.Enabled = False

    End Sub


    Private Sub Bnt_Siguente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Siguente1.Click, Bnt_Siguente2.Click, Bnt_Siguente3.Click, Bnt_Siguente4.Click
        Dim datosFila As New Collection
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
        RefrescarCampos()
    End Sub

    Private Sub Bnt_PararTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_PararTrabajo1.Click, Bnt_PararTrabajo4.Click, Bnt_PararTrabajo2.Click, Bnt_PararTrabajo3.Click
        Dim datosCajero As New ObjCajero
        Dim accion As String
        Try
            accion = "SALIDA"

            Select Case sender.Name()

                Case "Bnt_PararTrabajo1"
                    datosCajero.id_cajero = 41
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente1.Enabled = False
                    Bnt_PararTrabajo1.Enabled = False
                    Bnt_Trabajar1.Enabled = True
                    Bnt_Transaccion1.Enabled = False
                Case "Bnt_PararTrabajo2"
                    datosCajero.id_cajero = 21
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente2.Enabled = False
                    Bnt_PararTrabajo2.Enabled = False
                    Bnt_Trabajar2.Enabled = True
                    Bnt_Transaccion2.Enabled = False
                Case "Bnt_PararTrabajo3"
                    datosCajero.id_cajero = 22
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente3.Enabled = False
                    Bnt_PararTrabajo3.Enabled = False
                    Bnt_Trabajar3.Enabled = True
                    Bnt_Transaccion3.Enabled = False
                Case "Bnt_PararTrabajo4"
                    datosCajero.id_cajero = 23
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente4.Enabled = False
                    Bnt_PararTrabajo4.Enabled = False
                    Bnt_Trabajar4.Enabled = True
                    Bnt_Transaccion4.Enabled = False
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)
            End Select

            idCajero = datosCajero.id_cajero
            MessageBox.Show("El cajero número : " & idCajero & " salio a almorzar.")
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al salir el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        RefrescarCampos()

    End Sub

    Private Sub Bnt_Trabajar_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Trabajar1.Click, Bnt_Trabajar2.Click, Bnt_Trabajar3.Click, Bnt_Trabajar4.Click
        Dim datosCajero As New ObjCajero
        Dim accion As String
        Try
            accion = "ENTRADA"
            Select Case sender.Name()
                Case "Bnt_Trabajar1"
                    datosCajero.id_cajero = 41
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente1.Enabled = True
                    Bnt_PararTrabajo1.Enabled = True
                    Bnt_Trabajar1.Enabled = False
                    Bnt_Transaccion1.Enabled = True
                Case "Bnt_Trabajar2"
                    datosCajero.id_cajero = 21
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente2.Enabled = True
                    Bnt_PararTrabajo2.Enabled = True
                    Bnt_Trabajar2.Enabled = False
                    Bnt_Transaccion2.Enabled = True
                Case "Bnt_Trabajar3"
                    datosCajero.id_cajero = 22
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente3.Enabled = True
                    Bnt_PararTrabajo3.Enabled = True
                    Bnt_Trabajar3.Enabled = False
                    Bnt_Transaccion3.Enabled = True
                Case "Bnt_Trabajar4"
                    datosCajero.id_cajero = 23
                    ejecutarCajero.AlmuerzoCafeOtros(datosCajero, accion)
                    Bnt_Siguente4.Enabled = True
                    Bnt_PararTrabajo4.Enabled = True
                    Bnt_Trabajar4.Enabled = False
                    Bnt_Transaccion4.Enabled = True
            End Select
            idCajero = datosCajero.id_cajero
            MessageBox.Show("El cajero número : " & idCajero & " entro a trabajar.")
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al entrar el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        RefrescarCampos()
    End Sub

    Private Sub btn_RefrescarFila_Click(sender As System.Object, e As System.EventArgs) Handles btn_RefrescarFila.Click
        Lb_Contador.Text = ejecutarFilaCliente.ClientesEnFila()
        RefrescarCampos()
    End Sub

    Private Sub Bnt_Menu_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Menu.Click
        Dim MenuPrincipal As New Frm_Menu
        MenuPrincipal.ShowDialog()
        RefrescarCampos()
    End Sub

    Private Sub Bnt_IngresarFila_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_IngresarFila.Click
        Dim ValidarCliente As New Frm_ValidarCliente
        ValidarCliente.ShowDialog()
        RefrescarCampos()
    End Sub

    Private Sub Bnt_Transaccion_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Transaccion1.Click, Bnt_Transaccion2.Click, Bnt_Transaccion3.Click, Bnt_Transaccion4.Click
        Dim TransaccionCliente As New Frm_RegistroTransaccion


        Select Case sender.Name()

            Case "Bnt_Transaccion1"
                TransaccionCliente.idCajero = 41
                TransaccionCliente.nombreCliente = Txt_NombreCliente1.Text
                TransaccionCliente.ShowDialog()
                Cliente1.Visible = False
                Txt_NombreCliente1.Text = ""
            Case "Bnt_Transaccion2"
                TransaccionCliente.idCajero = 21
                TransaccionCliente.nombreCliente = Txt_NombreCliente2.Text
                TransaccionCliente.ShowDialog()
                Cliente2.Visible = False
                Txt_NombreCliente2.Text = ""
            Case "Bnt_Transaccion3"
                TransaccionCliente.idCajero = 22
                TransaccionCliente.nombreCliente = Txt_NombreCliente3.Text
                TransaccionCliente.ShowDialog()
                Cliente3.Visible = False
                Txt_NombreCliente3.Text = ""
            Case "Bnt_Transaccion4"
                TransaccionCliente.idCajero = 23
                TransaccionCliente.nombreCliente = Txt_NombreCliente4.Text
                TransaccionCliente.ShowDialog()
                Cliente4.Visible = False
                Txt_NombreCliente4.Text = ""

        End Select
        RefrescarCampos()

    End Sub
End Class