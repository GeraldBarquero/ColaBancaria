<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ValidarCliente
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
        Me.Bnt_Aceptar = New System.Windows.Forms.Button()
        Me.Lb_NumeroCedula = New System.Windows.Forms.Label()
        Me.Txt_NumeroCedula = New System.Windows.Forms.TextBox()
        Me.Bnt_Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bnt_Aceptar
        '
        Me.Bnt_Aceptar.Location = New System.Drawing.Point(53, 49)
        Me.Bnt_Aceptar.Name = "Bnt_Aceptar"
        Me.Bnt_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_Aceptar.TabIndex = 0
        Me.Bnt_Aceptar.Text = "Aceptar"
        Me.Bnt_Aceptar.UseVisualStyleBackColor = True
        '
        'Lb_NumeroCedula
        '
        Me.Lb_NumeroCedula.AutoSize = True
        Me.Lb_NumeroCedula.Location = New System.Drawing.Point(30, 16)
        Me.Lb_NumeroCedula.Name = "Lb_NumeroCedula"
        Me.Lb_NumeroCedula.Size = New System.Drawing.Size(98, 13)
        Me.Lb_NumeroCedula.TabIndex = 1
        Me.Lb_NumeroCedula.Text = "Número de Cédula:"
        '
        'Txt_NumeroCedula
        '
        Me.Txt_NumeroCedula.Location = New System.Drawing.Point(134, 13)
        Me.Txt_NumeroCedula.Name = "Txt_NumeroCedula"
        Me.Txt_NumeroCedula.Size = New System.Drawing.Size(100, 20)
        Me.Txt_NumeroCedula.TabIndex = 2
        '
        'Bnt_Cancelar
        '
        Me.Bnt_Cancelar.Location = New System.Drawing.Point(166, 48)
        Me.Bnt_Cancelar.Name = "Bnt_Cancelar"
        Me.Bnt_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_Cancelar.TabIndex = 3
        Me.Bnt_Cancelar.Text = "Cancelar"
        Me.Bnt_Cancelar.UseVisualStyleBackColor = True
        '
        'Frm_ValidarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 84)
        Me.Controls.Add(Me.Bnt_Cancelar)
        Me.Controls.Add(Me.Txt_NumeroCedula)
        Me.Controls.Add(Me.Lb_NumeroCedula)
        Me.Controls.Add(Me.Bnt_Aceptar)
        Me.Name = "Frm_ValidarCliente"
        Me.Text = "Frm_ValidarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bnt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Lb_NumeroCedula As System.Windows.Forms.Label
    Friend WithEvents Txt_NumeroCedula As System.Windows.Forms.TextBox
    Friend WithEvents Bnt_Cancelar As System.Windows.Forms.Button
End Class
