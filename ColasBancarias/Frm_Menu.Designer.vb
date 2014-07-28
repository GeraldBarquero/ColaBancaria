<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Bnt_NuevoCajero = New System.Windows.Forms.Button()
        Me.Bnt_NuevoCliente = New System.Windows.Forms.Button()
        Me.Bt_Cajero = New System.Windows.Forms.Button()
        Me.Bt_Clientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bnt_NuevoCajero
        '
        Me.Bnt_NuevoCajero.Image = Global.ColasBancarias.UI.My.Resources.Resources.AddEmpleados
        Me.Bnt_NuevoCajero.Location = New System.Drawing.Point(205, 20)
        Me.Bnt_NuevoCajero.Name = "Bnt_NuevoCajero"
        Me.Bnt_NuevoCajero.Size = New System.Drawing.Size(97, 129)
        Me.Bnt_NuevoCajero.TabIndex = 3
        Me.Bnt_NuevoCajero.UseVisualStyleBackColor = True
        '
        'Bnt_NuevoCliente
        '
        Me.Bnt_NuevoCliente.Image = Global.ColasBancarias.UI.My.Resources.Resources.AddCliente
        Me.Bnt_NuevoCliente.Location = New System.Drawing.Point(192, 204)
        Me.Bnt_NuevoCliente.Name = "Bnt_NuevoCliente"
        Me.Bnt_NuevoCliente.Size = New System.Drawing.Size(120, 126)
        Me.Bnt_NuevoCliente.TabIndex = 2
        Me.Bnt_NuevoCliente.UseVisualStyleBackColor = True
        '
        'Bt_Cajero
        '
        Me.Bt_Cajero.Image = Global.ColasBancarias.UI.My.Resources.Resources.empleados
        Me.Bt_Cajero.Location = New System.Drawing.Point(42, 45)
        Me.Bt_Cajero.Name = "Bt_Cajero"
        Me.Bt_Cajero.Size = New System.Drawing.Size(91, 104)
        Me.Bt_Cajero.TabIndex = 1
        Me.Bt_Cajero.UseVisualStyleBackColor = True
        '
        'Bt_Clientes
        '
        Me.Bt_Clientes.Image = Global.ColasBancarias.UI.My.Resources.Resources.clientes
        Me.Bt_Clientes.Location = New System.Drawing.Point(20, 221)
        Me.Bt_Clientes.Name = "Bt_Clientes"
        Me.Bt_Clientes.Size = New System.Drawing.Size(123, 109)
        Me.Bt_Clientes.TabIndex = 0
        Me.Bt_Clientes.UseVisualStyleBackColor = True
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(324, 383)
        Me.Controls.Add(Me.Bnt_NuevoCajero)
        Me.Controls.Add(Me.Bnt_NuevoCliente)
        Me.Controls.Add(Me.Bt_Cajero)
        Me.Controls.Add(Me.Bt_Clientes)
        Me.Name = "Frm_Menu"
        Me.Text = "Frm_Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bt_Clientes As System.Windows.Forms.Button
    Friend WithEvents Bt_Cajero As System.Windows.Forms.Button
    Friend WithEvents Bnt_NuevoCliente As System.Windows.Forms.Button
    Friend WithEvents Bnt_NuevoCajero As System.Windows.Forms.Button
End Class
