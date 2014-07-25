<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RegistroCajero
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
        Me.Lb_CedulaCajero = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_CedulaCajero = New System.Windows.Forms.TextBox()
        Me.Txt_NombreCajero = New System.Windows.Forms.TextBox()
        Me.Btn_CancelarRegistroCajero = New System.Windows.Forms.Button()
        Me.Btn_CrearCajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_CedulaCajero
        '
        Me.Lb_CedulaCajero.AutoSize = True
        Me.Lb_CedulaCajero.Location = New System.Drawing.Point(28, 35)
        Me.Lb_CedulaCajero.Name = "Lb_CedulaCajero"
        Me.Lb_CedulaCajero.Size = New System.Drawing.Size(40, 13)
        Me.Lb_CedulaCajero.TabIndex = 0
        Me.Lb_CedulaCajero.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Txt_CedulaCajero
        '
        Me.Txt_CedulaCajero.Location = New System.Drawing.Point(101, 35)
        Me.Txt_CedulaCajero.Name = "Txt_CedulaCajero"
        Me.Txt_CedulaCajero.Size = New System.Drawing.Size(100, 20)
        Me.Txt_CedulaCajero.TabIndex = 2
        '
        'Txt_NombreCajero
        '
        Me.Txt_NombreCajero.Location = New System.Drawing.Point(101, 72)
        Me.Txt_NombreCajero.Name = "Txt_NombreCajero"
        Me.Txt_NombreCajero.Size = New System.Drawing.Size(100, 20)
        Me.Txt_NombreCajero.TabIndex = 3
        '
        'Btn_CancelarRegistroCajero
        '
        Me.Btn_CancelarRegistroCajero.Image = Global.ColasBancarias.UI.My.Resources.Resources.Cancel
        Me.Btn_CancelarRegistroCajero.Location = New System.Drawing.Point(162, 150)
        Me.Btn_CancelarRegistroCajero.Name = "Btn_CancelarRegistroCajero"
        Me.Btn_CancelarRegistroCajero.Size = New System.Drawing.Size(86, 53)
        Me.Btn_CancelarRegistroCajero.TabIndex = 5
        Me.Btn_CancelarRegistroCajero.UseVisualStyleBackColor = True
        '
        'Btn_CrearCajero
        '
        Me.Btn_CrearCajero.Image = Global.ColasBancarias.UI.My.Resources.Resources.Add
        Me.Btn_CrearCajero.Location = New System.Drawing.Point(31, 150)
        Me.Btn_CrearCajero.Name = "Btn_CrearCajero"
        Me.Btn_CrearCajero.Size = New System.Drawing.Size(86, 53)
        Me.Btn_CrearCajero.TabIndex = 4
        Me.Btn_CrearCajero.UseVisualStyleBackColor = True
        '
        'Frm_RegistroCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Btn_CancelarRegistroCajero)
        Me.Controls.Add(Me.Btn_CrearCajero)
        Me.Controls.Add(Me.Txt_NombreCajero)
        Me.Controls.Add(Me.Txt_CedulaCajero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lb_CedulaCajero)
        Me.Name = "Frm_RegistroCajero"
        Me.Text = "Frm_RegistroCajero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_CedulaCajero As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_CedulaCajero As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NombreCajero As System.Windows.Forms.TextBox
    Friend WithEvents Btn_CrearCajero As System.Windows.Forms.Button
    Friend WithEvents Btn_CancelarRegistroCajero As System.Windows.Forms.Button
End Class
