Imports System.Drawing
Imports System.Windows.Forms
Imports ColasBancarias.BLL
Imports ColasBancarias.Entidades
Imports ColasBancarias.Entidades.OBJETOS

Public Class Frm_FilaClientes
    Dim ejecutar As New BllCajero
    Dim ejecutar2 As New BllCliente

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


    Private Sub Bnt_Siguente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Siguente1.Click, Bnt_Siguente2.Click, Bnt_Siguente3.Click, Bnt_Siguente4.Click
        Dim datosFila As New Collection
        Dim imagen As String
        datosFila = ejecutar2.SiguienteEnFila()
        Lb_Contador.Text = ejecutar2.ClientesEnFila()

        If Lb_Contador.Text <> "0" Then
            imagen = "../../Resources/mujer2.PNG"
            Select Case datosFila.Item("Prioridad")
                Case 1
                    imagen = "../../Resources/ciego.PNG"
                Case 2
                    imagen = "../../Resources/anciano.PNG"
                Case 3
                    imagen = "../../Resources/hombre.PNG"
                Case 4
                    imagen = "../../Resources/hombre2.PNG"
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
            PrimerCliente.Load("../../Resources/sinCliente.png")

            MessageBox.Show("No hay clientes en la fila")
        End If
        

    End Sub

    Private Sub Bnt_PararTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_PararTrabajo1.Click, Bnt_PararTrabajo4.Click, Bnt_PararTrabajo2.Click, Bnt_PararTrabajo3.Click
        Dim datosCajero As New OBJETOS.ObjCajero
        Dim accion As String
        Dim idCajero As Integer
        Try
            accion = "SALIDA"
            Select Case sender.Name()

                Case "Bnt_PararTrabajo1"
                    datosCajero.id_cajero = 41
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

                Case "Bnt_PararTrabajo2"
                    datosCajero.id_cajero = 21
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

                Case "Bnt_PararTrabajo3"
                    datosCajero.id_cajero = 22
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

                Case "Bnt_PararTrabajo4"
                    datosCajero.id_cajero = 23
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

            End Select
            idCajero = datosCajero.id_cajero
            MessageBox.Show("El cajero número : " & idCajero & " salio a almorzar.")


        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al salir el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])

        End Try


    End Sub

    Private Sub Bnt_Trabajar_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Trabajar1.Click, Bnt_Trabajar2.Click, Bnt_Trabajar3.Click, Bnt_Trabajar4.Click
        Dim datosCajero As New OBJETOS.ObjCajero
        Dim accion As String
        Dim idCajero As Integer
        Try
            accion = "ENTRADA"
            Select Case sender.Name()

                Case "Bnt_Trabajar1"
                    datosCajero.id_cajero = 41
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

                Case "Bnt_Trabajar2"
                    datosCajero.id_cajero = 21
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

                Case "Bnt_Trabajar3"
                    datosCajero.id_cajero = 22
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

                Case "Bnt_Trabajar4"
                    datosCajero.id_cajero = 23
                    ejecutar.AlmuerzoCafeOtros(datosCajero, accion)

            End Select
            idCajero = datosCajero.id_cajero
            MessageBox.Show("El cajero número : " & idCajero & " entro a trabajar.")

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al entrar el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])

        End Try
    End Sub

    Private Sub btn_RefrescarFila_Click(sender As System.Object, e As System.EventArgs) Handles btn_RefrescarFila.Click

        Lb_Contador.Text = ejecutar2.ClientesEnFila()
    End Sub

    Private Sub Bnt_Menu_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Menu.Click

        Dim MenuPrincipal As New Frm_Menu
        MenuPrincipal.ShowDialog()

    End Sub

    Private Sub Bnt_IngresarFila_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_IngresarFila.Click
        Dim Resultado As String

        Resultado = ejecutar2.IngresarEnFila("4-321-5687")
        MessageBox.Show(Resultado)
    End Sub
End Class