<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaCajeros
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
        Me.Dgv_Cajeros = New System.Windows.Forms.DataGridView()
        Me.Btn_RegistrarCajero = New System.Windows.Forms.Button()
        CType(Me.Dgv_Cajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Cajeros
        '
        Me.Dgv_Cajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Cajeros.Location = New System.Drawing.Point(57, 26)
        Me.Dgv_Cajeros.Name = "Dgv_Cajeros"
        Me.Dgv_Cajeros.Size = New System.Drawing.Size(474, 179)
        Me.Dgv_Cajeros.TabIndex = 0
        '
        'Btn_RegistrarCajero
        '
        Me.Btn_RegistrarCajero.Location = New System.Drawing.Point(424, 219)
        Me.Btn_RegistrarCajero.Name = "Btn_RegistrarCajero"
        Me.Btn_RegistrarCajero.Size = New System.Drawing.Size(107, 23)
        Me.Btn_RegistrarCajero.TabIndex = 1
        Me.Btn_RegistrarCajero.Text = "Registrar Cajero"
        Me.Btn_RegistrarCajero.UseVisualStyleBackColor = True
        '
        'Frm_ListaCajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 254)
        Me.Controls.Add(Me.Btn_RegistrarCajero)
        Me.Controls.Add(Me.Dgv_Cajeros)
        Me.Name = "Frm_ListaCajeros"
        Me.Text = "Frm_ListaCajerosvb"
        CType(Me.Dgv_Cajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_Cajeros As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_RegistrarCajero As System.Windows.Forms.Button
End Class
