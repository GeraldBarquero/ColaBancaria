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
        Me.Lb_ListaCajeros = New System.Windows.Forms.Label()
        Me.Lb_RegistroCajero = New System.Windows.Forms.Label()
        Me.Lb_ListaClientes = New System.Windows.Forms.Label()
        Me.Lb_RegistroCliente = New System.Windows.Forms.Label()
        Me.Lb_FilaClientes = New System.Windows.Forms.Label()
        Me.Bnt_FilaCliente = New System.Windows.Forms.Button()
        Me.Bnt_NuevoCajero = New System.Windows.Forms.Button()
        Me.Bnt_NuevoCliente = New System.Windows.Forms.Button()
        Me.Bt_Cajero = New System.Windows.Forms.Button()
        Me.Bt_Clientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_ListaCajeros
        '
        Me.Lb_ListaCajeros.AutoSize = True
        Me.Lb_ListaCajeros.BackColor = System.Drawing.Color.White
        Me.Lb_ListaCajeros.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_ListaCajeros.Location = New System.Drawing.Point(42, 41)
        Me.Lb_ListaCajeros.Name = "Lb_ListaCajeros"
        Me.Lb_ListaCajeros.Size = New System.Drawing.Size(96, 15)
        Me.Lb_ListaCajeros.TabIndex = 4
        Me.Lb_ListaCajeros.Text = "Lista de Cajeros"
        '
        'Lb_RegistroCajero
        '
        Me.Lb_RegistroCajero.AutoSize = True
        Me.Lb_RegistroCajero.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_RegistroCajero.Location = New System.Drawing.Point(191, 41)
        Me.Lb_RegistroCajero.Name = "Lb_RegistroCajero"
        Me.Lb_RegistroCajero.Size = New System.Drawing.Size(116, 15)
        Me.Lb_RegistroCajero.TabIndex = 5
        Me.Lb_RegistroCajero.Text = "Registro de Cajeros"
        '
        'Lb_ListaClientes
        '
        Me.Lb_ListaClientes.AutoSize = True
        Me.Lb_ListaClientes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_ListaClientes.Location = New System.Drawing.Point(39, 220)
        Me.Lb_ListaClientes.Name = "Lb_ListaClientes"
        Me.Lb_ListaClientes.Size = New System.Drawing.Size(99, 15)
        Me.Lb_ListaClientes.TabIndex = 6
        Me.Lb_ListaClientes.Text = "Lista de Clientes"
        '
        'Lb_RegistroCliente
        '
        Me.Lb_RegistroCliente.AutoSize = True
        Me.Lb_RegistroCliente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_RegistroCliente.Location = New System.Drawing.Point(188, 220)
        Me.Lb_RegistroCliente.Name = "Lb_RegistroCliente"
        Me.Lb_RegistroCliente.Size = New System.Drawing.Size(119, 15)
        Me.Lb_RegistroCliente.TabIndex = 7
        Me.Lb_RegistroCliente.Text = "Registro de Clientes"
        '
        'Lb_FilaClientes
        '
        Me.Lb_FilaClientes.AutoSize = True
        Me.Lb_FilaClientes.BackColor = System.Drawing.Color.White
        Me.Lb_FilaClientes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_FilaClientes.Location = New System.Drawing.Point(344, 149)
        Me.Lb_FilaClientes.Name = "Lb_FilaClientes"
        Me.Lb_FilaClientes.Size = New System.Drawing.Size(151, 15)
        Me.Lb_FilaClientes.TabIndex = 8
        Me.Lb_FilaClientes.Text = "Lista de la Fila de Clientes"
        '
        'Bnt_FilaCliente
        '
        Me.Bnt_FilaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bnt_FilaCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bnt_FilaCliente.FlatAppearance.BorderSize = 0
        Me.Bnt_FilaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bnt_FilaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bnt_FilaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bnt_FilaCliente.Image = Global.ColasBancarias.UI.My.Resources.Resources.filaClientes
        Me.Bnt_FilaCliente.Location = New System.Drawing.Point(360, 173)
        Me.Bnt_FilaCliente.Name = "Bnt_FilaCliente"
        Me.Bnt_FilaCliente.Size = New System.Drawing.Size(118, 108)
        Me.Bnt_FilaCliente.TabIndex = 9
        Me.Bnt_FilaCliente.UseVisualStyleBackColor = False
        '
        'Bnt_NuevoCajero
        '
        Me.Bnt_NuevoCajero.BackColor = System.Drawing.Color.White
        Me.Bnt_NuevoCajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Bnt_NuevoCajero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bnt_NuevoCajero.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bnt_NuevoCajero.FlatAppearance.BorderSize = 0
        Me.Bnt_NuevoCajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bnt_NuevoCajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bnt_NuevoCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bnt_NuevoCajero.ForeColor = System.Drawing.Color.White
        Me.Bnt_NuevoCajero.Image = Global.ColasBancarias.UI.My.Resources.Resources.AddEmpleados
        Me.Bnt_NuevoCajero.Location = New System.Drawing.Point(194, 60)
        Me.Bnt_NuevoCajero.Name = "Bnt_NuevoCajero"
        Me.Bnt_NuevoCajero.Size = New System.Drawing.Size(134, 104)
        Me.Bnt_NuevoCajero.TabIndex = 3
        Me.Bnt_NuevoCajero.UseVisualStyleBackColor = False
        '
        'Bnt_NuevoCliente
        '
        Me.Bnt_NuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bnt_NuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bnt_NuevoCliente.FlatAppearance.BorderSize = 0
        Me.Bnt_NuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bnt_NuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bnt_NuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bnt_NuevoCliente.Image = Global.ColasBancarias.UI.My.Resources.Resources.AddCliente
        Me.Bnt_NuevoCliente.Location = New System.Drawing.Point(191, 238)
        Me.Bnt_NuevoCliente.Name = "Bnt_NuevoCliente"
        Me.Bnt_NuevoCliente.Size = New System.Drawing.Size(120, 104)
        Me.Bnt_NuevoCliente.TabIndex = 2
        Me.Bnt_NuevoCliente.UseVisualStyleBackColor = False
        '
        'Bt_Cajero
        '
        Me.Bt_Cajero.BackColor = System.Drawing.Color.White
        Me.Bt_Cajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Bt_Cajero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Cajero.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bt_Cajero.FlatAppearance.BorderSize = 0
        Me.Bt_Cajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bt_Cajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_Cajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Cajero.ForeColor = System.Drawing.Color.White
        Me.Bt_Cajero.Image = Global.ColasBancarias.UI.My.Resources.Resources.empleados
        Me.Bt_Cajero.Location = New System.Drawing.Point(37, 60)
        Me.Bt_Cajero.Name = "Bt_Cajero"
        Me.Bt_Cajero.Size = New System.Drawing.Size(134, 104)
        Me.Bt_Cajero.TabIndex = 1
        Me.Bt_Cajero.UseVisualStyleBackColor = False
        '
        'Bt_Clientes
        '
        Me.Bt_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Clientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bt_Clientes.FlatAppearance.BorderSize = 0
        Me.Bt_Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bt_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Clientes.Image = Global.ColasBancarias.UI.My.Resources.Resources.clientes
        Me.Bt_Clientes.Location = New System.Drawing.Point(29, 238)
        Me.Bt_Clientes.Name = "Bt_Clientes"
        Me.Bt_Clientes.Size = New System.Drawing.Size(118, 104)
        Me.Bt_Clientes.TabIndex = 0
        Me.Bt_Clientes.UseVisualStyleBackColor = True
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(519, 383)
        Me.Controls.Add(Me.Bnt_FilaCliente)
        Me.Controls.Add(Me.Lb_FilaClientes)
        Me.Controls.Add(Me.Lb_RegistroCliente)
        Me.Controls.Add(Me.Lb_ListaClientes)
        Me.Controls.Add(Me.Lb_RegistroCajero)
        Me.Controls.Add(Me.Lb_ListaCajeros)
        Me.Controls.Add(Me.Bnt_NuevoCajero)
        Me.Controls.Add(Me.Bnt_NuevoCliente)
        Me.Controls.Add(Me.Bt_Cajero)
        Me.Controls.Add(Me.Bt_Clientes)
        Me.Name = "Frm_Menu"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bt_Clientes As System.Windows.Forms.Button
    Friend WithEvents Bt_Cajero As System.Windows.Forms.Button
    Friend WithEvents Bnt_NuevoCliente As System.Windows.Forms.Button
    Friend WithEvents Bnt_NuevoCajero As System.Windows.Forms.Button
    Friend WithEvents Lb_ListaCajeros As System.Windows.Forms.Label
    Friend WithEvents Lb_RegistroCajero As System.Windows.Forms.Label
    Friend WithEvents Lb_ListaClientes As System.Windows.Forms.Label
    Friend WithEvents Lb_RegistroCliente As System.Windows.Forms.Label
    Friend WithEvents Lb_FilaClientes As System.Windows.Forms.Label
    Friend WithEvents Bnt_FilaCliente As System.Windows.Forms.Button
End Class
