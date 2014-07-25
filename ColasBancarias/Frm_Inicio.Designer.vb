<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inicio
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
        Me.Bt_Clientes = New System.Windows.Forms.Button()
        Me.Bt_Cajero = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Bt_FilaCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bt_Clientes
        '
        Me.Bt_Clientes.Location = New System.Drawing.Point(52, 36)
        Me.Bt_Clientes.Name = "Bt_Clientes"
        Me.Bt_Clientes.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Clientes.TabIndex = 0
        Me.Bt_Clientes.Text = "Clientes"
        Me.Bt_Clientes.UseVisualStyleBackColor = True
        '
        'Bt_Cajero
        '
        Me.Bt_Cajero.Location = New System.Drawing.Point(326, 36)
        Me.Bt_Cajero.Name = "Bt_Cajero"
        Me.Bt_Cajero.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Cajero.TabIndex = 1
        Me.Bt_Cajero.Text = "Cajero"
        Me.Bt_Cajero.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(52, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(326, 142)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Bt_FilaCliente
        '
        Me.Bt_FilaCliente.Location = New System.Drawing.Point(172, 83)
        Me.Bt_FilaCliente.Name = "Bt_FilaCliente"
        Me.Bt_FilaCliente.Size = New System.Drawing.Size(91, 23)
        Me.Bt_FilaCliente.TabIndex = 4
        Me.Bt_FilaCliente.Text = "Fila de clientes"
        Me.Bt_FilaCliente.UseVisualStyleBackColor = True
        '
        'Frm_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 191)
        Me.Controls.Add(Me.Bt_FilaCliente)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Bt_Cajero)
        Me.Controls.Add(Me.Bt_Clientes)
        Me.Name = "Frm_Inicio"
        Me.Text = "Frm_Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bt_Clientes As System.Windows.Forms.Button
    Friend WithEvents Bt_Cajero As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Bt_FilaCliente As System.Windows.Forms.Button
End Class
