<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RegistroTransaccion
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
        Me.Lb_NombreClienteTransaccion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_NombreClienteTransaccion = New System.Windows.Forms.TextBox()
        Me.Txt_IDCajeroTransaccion = New System.Windows.Forms.TextBox()
        Me.Cbx_TipoTransaccion = New System.Windows.Forms.ComboBox()
        Me.Bnt_Cancelar = New System.Windows.Forms.Button()
        Me.Bnt_Aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_NombreClienteTransaccion
        '
        Me.Lb_NombreClienteTransaccion.AutoSize = True
        Me.Lb_NombreClienteTransaccion.Location = New System.Drawing.Point(43, 30)
        Me.Lb_NombreClienteTransaccion.Name = "Lb_NombreClienteTransaccion"
        Me.Lb_NombreClienteTransaccion.Size = New System.Drawing.Size(79, 13)
        Me.Lb_NombreClienteTransaccion.TabIndex = 2
        Me.Lb_NombreClienteTransaccion.Text = "Nombre Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Cajero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Transaccion"
        '
        'Txt_NombreClienteTransaccion
        '
        Me.Txt_NombreClienteTransaccion.Location = New System.Drawing.Point(130, 27)
        Me.Txt_NombreClienteTransaccion.Name = "Txt_NombreClienteTransaccion"
        Me.Txt_NombreClienteTransaccion.Size = New System.Drawing.Size(142, 20)
        Me.Txt_NombreClienteTransaccion.TabIndex = 5
        '
        'Txt_IDCajeroTransaccion
        '
        Me.Txt_IDCajeroTransaccion.Location = New System.Drawing.Point(130, 68)
        Me.Txt_IDCajeroTransaccion.Name = "Txt_IDCajeroTransaccion"
        Me.Txt_IDCajeroTransaccion.Size = New System.Drawing.Size(142, 20)
        Me.Txt_IDCajeroTransaccion.TabIndex = 6
        '
        'Cbx_TipoTransaccion
        '
        Me.Cbx_TipoTransaccion.FormattingEnabled = True
        Me.Cbx_TipoTransaccion.Items.AddRange(New Object() {"", "Deposito ", "Retiro ", "Pago de Servicio"})
        Me.Cbx_TipoTransaccion.Location = New System.Drawing.Point(151, 109)
        Me.Cbx_TipoTransaccion.Name = "Cbx_TipoTransaccion"
        Me.Cbx_TipoTransaccion.Size = New System.Drawing.Size(121, 21)
        Me.Cbx_TipoTransaccion.TabIndex = 7
        '
        'Bnt_Cancelar
        '
        Me.Bnt_Cancelar.Image = Global.ColasBancarias.UI.My.Resources.Resources.Cancel
        Me.Bnt_Cancelar.Location = New System.Drawing.Point(178, 167)
        Me.Bnt_Cancelar.Name = "Bnt_Cancelar"
        Me.Bnt_Cancelar.Size = New System.Drawing.Size(42, 40)
        Me.Bnt_Cancelar.TabIndex = 1
        Me.Bnt_Cancelar.UseVisualStyleBackColor = True
        '
        'Bnt_Aceptar
        '
        Me.Bnt_Aceptar.Image = Global.ColasBancarias.UI.My.Resources.Resources.Add
        Me.Bnt_Aceptar.Location = New System.Drawing.Point(60, 167)
        Me.Bnt_Aceptar.Name = "Bnt_Aceptar"
        Me.Bnt_Aceptar.Size = New System.Drawing.Size(41, 40)
        Me.Bnt_Aceptar.TabIndex = 0
        Me.Bnt_Aceptar.UseVisualStyleBackColor = True
        '
        'Frm_RegistroTransaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 221)
        Me.Controls.Add(Me.Cbx_TipoTransaccion)
        Me.Controls.Add(Me.Txt_IDCajeroTransaccion)
        Me.Controls.Add(Me.Txt_NombreClienteTransaccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lb_NombreClienteTransaccion)
        Me.Controls.Add(Me.Bnt_Cancelar)
        Me.Controls.Add(Me.Bnt_Aceptar)
        Me.Name = "Frm_RegistroTransaccion"
        Me.Text = "Frm_Transaccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bnt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Bnt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Lb_NombreClienteTransaccion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreClienteTransaccion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IDCajeroTransaccion As System.Windows.Forms.TextBox
    Friend WithEvents Cbx_TipoTransaccion As System.Windows.Forms.ComboBox
End Class
