Imports System.Drawing
Imports System.Windows.Forms
Imports ColasBancarias.BLL
Imports ColasBancarias.Entidades

Public Class Frm_FilaClientes
    Dim ejecutar As New BllCajero

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


    Private Sub Bnt_Siguente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Siguente1.Click, Bnt_Siguente2.Click, Bnt_Siguente3.Click, Bnt_Siguente4.Click


        Select Case sender.Name()

            Case "Bnt_Siguente1"

                Ciego.Location = New Point(87, 164)

            Case "Bnt_Siguente2"

                Ciego.Location = New Point(288, 164)

            Case "Bnt_Siguente3"

                Ciego.Location = New Point(480, 164)

            Case "Bnt_Siguente4"
                Ciego.Location = New Point(682, 164)
        End Select

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
            MessageBox.Show("El cajero número : " & idCajero & +" salio a almorzar.")

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
            MessageBox.Show("El cajero número : " & idCajero & +" entro a trabajar.")

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al entrar el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])

        End Try
    End Sub
End Class