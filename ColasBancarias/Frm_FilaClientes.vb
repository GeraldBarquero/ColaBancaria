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
        Dim PID_CAJERO As Int32
        Try

            Select Case sender.Name()

                Case "Bnt_PararTrabajo1"
                    PID_CAJERO = 41
                    ejecutar.SalidaAlmuerzoCafeOtros(datosCajero)

                Case "Bnt_PararTrabajo2"
                    PID_CAJERO = 21
                    ejecutar.SalidaAlmuerzoCafeOtros(datosCajero)


                Case "Bnt_PararTrabajo3"
                    PID_CAJERO = 22
                    ejecutar.SalidaAlmuerzoCafeOtros(datosCajero)


                Case "Bnt_PararTrabajo4"
                    PID_CAJERO = 23
                    ejecutar.SalidaAlmuerzoCafeOtros(datosCajero)

            End Select

            MessageBox.Show("Salida a almorzar, cafe o otros")

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error al salir el Cajero", MessageBoxButtons.OK, MessageBoxIcon.[Error])

        End Try


    End Sub
End Class