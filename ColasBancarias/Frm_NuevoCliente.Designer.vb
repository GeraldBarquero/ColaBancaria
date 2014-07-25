<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NuevoCliente
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
        Me.Lb_CedulaCliente = New System.Windows.Forms.Label()
        Me.Lb_NombreCliente = New System.Windows.Forms.Label()
        Me.Lb_EdadCliente = New System.Windows.Forms.Label()
        Me.Txt_CedulaCliente = New System.Windows.Forms.TextBox()
        Me.Txt_NombreCliente = New System.Windows.Forms.TextBox()
        Me.Txt_EdadCliente = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_CrearCliente = New System.Windows.Forms.Button()
        Me.Lb_TipoCliente = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lb_CedulaCliente
        '
        Me.Lb_CedulaCliente.AutoSize = True
        Me.Lb_CedulaCliente.Location = New System.Drawing.Point(42, 35)
        Me.Lb_CedulaCliente.Name = "Lb_CedulaCliente"
        Me.Lb_CedulaCliente.Size = New System.Drawing.Size(40, 13)
        Me.Lb_CedulaCliente.TabIndex = 0
        Me.Lb_CedulaCliente.Text = "Cedula"
        '
        'Lb_NombreCliente
        '
        Me.Lb_NombreCliente.AutoSize = True
        Me.Lb_NombreCliente.Location = New System.Drawing.Point(42, 72)
        Me.Lb_NombreCliente.Name = "Lb_NombreCliente"
        Me.Lb_NombreCliente.Size = New System.Drawing.Size(44, 13)
        Me.Lb_NombreCliente.TabIndex = 1
        Me.Lb_NombreCliente.Text = "Nombre"
        '
        'Lb_EdadCliente
        '
        Me.Lb_EdadCliente.AutoSize = True
        Me.Lb_EdadCliente.Location = New System.Drawing.Point(42, 110)
        Me.Lb_EdadCliente.Name = "Lb_EdadCliente"
        Me.Lb_EdadCliente.Size = New System.Drawing.Size(32, 13)
        Me.Lb_EdadCliente.TabIndex = 2
        Me.Lb_EdadCliente.Text = "Edad"
        '
        'Txt_CedulaCliente
        '
        Me.Txt_CedulaCliente.Location = New System.Drawing.Point(132, 28)
        Me.Txt_CedulaCliente.Name = "Txt_CedulaCliente"
        Me.Txt_CedulaCliente.Size = New System.Drawing.Size(100, 20)
        Me.Txt_CedulaCliente.TabIndex = 3
        '
        'Txt_NombreCliente
        '
        Me.Txt_NombreCliente.Location = New System.Drawing.Point(132, 72)
        Me.Txt_NombreCliente.Name = "Txt_NombreCliente"
        Me.Txt_NombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.Txt_NombreCliente.TabIndex = 4
        '
        'Txt_EdadCliente
        '
        Me.Txt_EdadCliente.Location = New System.Drawing.Point(132, 107)
        Me.Txt_EdadCliente.Name = "Txt_EdadCliente"
        Me.Txt_EdadCliente.Size = New System.Drawing.Size(100, 20)
        Me.Txt_EdadCliente.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Image = Global.ColasBancarias.UI.My.Resources.Resources.Cancel
        Me.Button2.Location = New System.Drawing.Point(176, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_CrearCliente
        '
        Me.Btn_CrearCliente.Image = Global.ColasBancarias.UI.My.Resources.Resources.Add
        Me.Btn_CrearCliente.Location = New System.Drawing.Point(45, 186)
        Me.Btn_CrearCliente.Name = "Btn_CrearCliente"
        Me.Btn_CrearCliente.Size = New System.Drawing.Size(75, 50)
        Me.Btn_CrearCliente.TabIndex = 6
        Me.Btn_CrearCliente.UseVisualStyleBackColor = True
        '
        'Lb_TipoCliente
        '
        Me.Lb_TipoCliente.AutoSize = True
        Me.Lb_TipoCliente.Location = New System.Drawing.Point(42, 142)
        Me.Lb_TipoCliente.Name = "Lb_TipoCliente"
        Me.Lb_TipoCliente.Size = New System.Drawing.Size(63, 13)
        Me.Lb_TipoCliente.TabIndex = 8
        Me.Lb_TipoCliente.Text = "Tipo Cliente"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(130, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Frm_NuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Lb_TipoCliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_CrearCliente)
        Me.Controls.Add(Me.Txt_EdadCliente)
        Me.Controls.Add(Me.Txt_NombreCliente)
        Me.Controls.Add(Me.Txt_CedulaCliente)
        Me.Controls.Add(Me.Lb_EdadCliente)
        Me.Controls.Add(Me.Lb_NombreCliente)
        Me.Controls.Add(Me.Lb_CedulaCliente)
        Me.Name = "Frm_NuevoCliente"
        Me.Text = "NuevoCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_CedulaCliente As System.Windows.Forms.Label
    Friend WithEvents Lb_NombreCliente As System.Windows.Forms.Label
    Friend WithEvents Lb_EdadCliente As System.Windows.Forms.Label
    Friend WithEvents Txt_CedulaCliente As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Txt_EdadCliente As System.Windows.Forms.TextBox
    Friend WithEvents Btn_CrearCliente As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lb_TipoCliente As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
