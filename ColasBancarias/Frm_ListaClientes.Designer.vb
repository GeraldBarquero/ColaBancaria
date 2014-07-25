<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaClientes
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
        Me.Dgv_ListaClientes = New System.Windows.Forms.DataGridView()
        Me.Bt_RegistrarCliente = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_ListaClientes
        '
        Me.Dgv_ListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_ListaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaClientes.Location = New System.Drawing.Point(12, 22)
        Me.Dgv_ListaClientes.Name = "Dgv_ListaClientes"
        Me.Dgv_ListaClientes.Size = New System.Drawing.Size(622, 212)
        Me.Dgv_ListaClientes.TabIndex = 0
        '
        'Bt_RegistrarCliente
        '
        Me.Bt_RegistrarCliente.Location = New System.Drawing.Point(531, 251)
        Me.Bt_RegistrarCliente.Name = "Bt_RegistrarCliente"
        Me.Bt_RegistrarCliente.Size = New System.Drawing.Size(103, 23)
        Me.Bt_RegistrarCliente.TabIndex = 1
        Me.Bt_RegistrarCliente.Text = "Registrar Cliente"
        Me.Bt_RegistrarCliente.UseVisualStyleBackColor = True
        '
        'Frm_ListaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 286)
        Me.Controls.Add(Me.Bt_RegistrarCliente)
        Me.Controls.Add(Me.Dgv_ListaClientes)
        Me.Name = "Frm_ListaClientes"
        Me.Text = "Frm_ListaClientes"
        CType(Me.Dgv_ListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_ListaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Bt_RegistrarCliente As System.Windows.Forms.Button
End Class
