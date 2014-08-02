<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaFilaCliente
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
        Me.Dgv_FilaCliente = New System.Windows.Forms.DataGridView()
        CType(Me.Dgv_FilaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_FilaCliente
        '
        Me.Dgv_FilaCliente.AllowUserToAddRows = False
        Me.Dgv_FilaCliente.AllowUserToDeleteRows = False
        Me.Dgv_FilaCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_FilaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_FilaCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.Dgv_FilaCliente.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_FilaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgv_FilaCliente.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_FilaCliente.Name = "Dgv_FilaCliente"
        Me.Dgv_FilaCliente.Size = New System.Drawing.Size(834, 212)
        Me.Dgv_FilaCliente.TabIndex = 1
        '
        'Frm_ListaFilaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(834, 251)
        Me.Controls.Add(Me.Dgv_FilaCliente)
        Me.Name = "Frm_ListaFilaCliente"
        Me.Text = "Frm_ListaFilaCliente"
        CType(Me.Dgv_FilaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_FilaCliente As System.Windows.Forms.DataGridView
End Class
