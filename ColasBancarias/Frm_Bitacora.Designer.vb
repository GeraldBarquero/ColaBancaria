<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Bitacora
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
        Me.Dgv_Bitacora = New System.Windows.Forms.DataGridView()
        CType(Me.Dgv_Bitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Bitacora
        '
        Me.Dgv_Bitacora.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dgv_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Bitacora.Location = New System.Drawing.Point(12, 12)
        Me.Dgv_Bitacora.Name = "Dgv_Bitacora"
        Me.Dgv_Bitacora.Size = New System.Drawing.Size(983, 200)
        Me.Dgv_Bitacora.TabIndex = 0
        '
        'Frm_Bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 262)
        Me.Controls.Add(Me.Dgv_Bitacora)
        Me.Name = "Frm_Bitacora"
        Me.Text = "Frm_Bitacora"
        CType(Me.Dgv_Bitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_Bitacora As System.Windows.Forms.DataGridView
End Class
