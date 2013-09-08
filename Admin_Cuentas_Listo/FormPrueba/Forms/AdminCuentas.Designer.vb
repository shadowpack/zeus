<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCuentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminCuentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRestablecerCrear = New System.Windows.Forms.Button()
        Me.btnActualizarCrear = New System.Windows.Forms.Button()
        Me.cboxPerfilPago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNameCuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxCuenta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxAccion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRestablecerAsignar = New System.Windows.Forms.Button()
        Me.btnActualizarAsignar = New System.Windows.Forms.Button()
        Me.cboxUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboxAccionAsignar = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboxCuentaAsignar = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRestablecerCrear)
        Me.GroupBox1.Controls.Add(Me.btnActualizarCrear)
        Me.GroupBox1.Controls.Add(Me.cboxPerfilPago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNameCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboxCuenta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboxAccion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 302)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear o modificar perfil"
        '
        'btnRestablecerCrear
        '
        Me.btnRestablecerCrear.Image = CType(resources.GetObject("btnRestablecerCrear.Image"), System.Drawing.Image)
        Me.btnRestablecerCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecerCrear.Location = New System.Drawing.Point(171, 240)
        Me.btnRestablecerCrear.Name = "btnRestablecerCrear"
        Me.btnRestablecerCrear.Size = New System.Drawing.Size(145, 43)
        Me.btnRestablecerCrear.TabIndex = 11
        Me.btnRestablecerCrear.Text = "Restablecer"
        Me.btnRestablecerCrear.UseVisualStyleBackColor = True
        '
        'btnActualizarCrear
        '
        Me.btnActualizarCrear.Image = CType(resources.GetObject("btnActualizarCrear.Image"), System.Drawing.Image)
        Me.btnActualizarCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarCrear.Location = New System.Drawing.Point(20, 240)
        Me.btnActualizarCrear.Name = "btnActualizarCrear"
        Me.btnActualizarCrear.Size = New System.Drawing.Size(145, 43)
        Me.btnActualizarCrear.TabIndex = 10
        Me.btnActualizarCrear.Text = "Actualizar Datos"
        Me.btnActualizarCrear.UseVisualStyleBackColor = True
        '
        'cboxPerfilPago
        '
        Me.cboxPerfilPago.FormattingEnabled = True
        Me.cboxPerfilPago.Location = New System.Drawing.Point(103, 188)
        Me.cboxPerfilPago.Name = "cboxPerfilPago"
        Me.cboxPerfilPago.Size = New System.Drawing.Size(284, 21)
        Me.cboxPerfilPago.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Perfil de Pago :"
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(103, 152)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(284, 20)
        Me.txtResponsable.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Responsable :"
        '
        'txtNameCuenta
        '
        Me.txtNameCuenta.Location = New System.Drawing.Point(103, 116)
        Me.txtNameCuenta.Name = "txtNameCuenta"
        Me.txtNameCuenta.Size = New System.Drawing.Size(284, 20)
        Me.txtNameCuenta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre cuenta :"
        '
        'cboxCuenta
        '
        Me.cboxCuenta.Enabled = False
        Me.cboxCuenta.FormattingEnabled = True
        Me.cboxCuenta.Location = New System.Drawing.Point(103, 81)
        Me.cboxCuenta.Name = "cboxCuenta"
        Me.cboxCuenta.Size = New System.Drawing.Size(284, 21)
        Me.cboxCuenta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cuenta :"
        '
        'cboxAccion
        '
        Me.cboxAccion.FormattingEnabled = True
        Me.cboxAccion.Items.AddRange(New Object() {"Crear nueva cuenta", "Modificar cuenta existente", "Caducar cuenta existente", "Reactivar cuenta existente"})
        Me.cboxAccion.Location = New System.Drawing.Point(103, 45)
        Me.cboxAccion.Name = "cboxAccion"
        Me.cboxAccion.Size = New System.Drawing.Size(284, 21)
        Me.cboxAccion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accion :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRestablecerAsignar)
        Me.GroupBox2.Controls.Add(Me.btnActualizarAsignar)
        Me.GroupBox2.Controls.Add(Me.cboxUsuarios)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboxAccionAsignar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboxCuentaAsignar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 203)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asignacion de  Usuarios"
        '
        'btnRestablecerAsignar
        '
        Me.btnRestablecerAsignar.Image = CType(resources.GetObject("btnRestablecerAsignar.Image"), System.Drawing.Image)
        Me.btnRestablecerAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecerAsignar.Location = New System.Drawing.Point(171, 140)
        Me.btnRestablecerAsignar.Name = "btnRestablecerAsignar"
        Me.btnRestablecerAsignar.Size = New System.Drawing.Size(145, 43)
        Me.btnRestablecerAsignar.TabIndex = 13
        Me.btnRestablecerAsignar.Text = "Restablecer"
        Me.btnRestablecerAsignar.UseVisualStyleBackColor = True
        '
        'btnActualizarAsignar
        '
        Me.btnActualizarAsignar.Image = CType(resources.GetObject("btnActualizarAsignar.Image"), System.Drawing.Image)
        Me.btnActualizarAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarAsignar.Location = New System.Drawing.Point(20, 140)
        Me.btnActualizarAsignar.Name = "btnActualizarAsignar"
        Me.btnActualizarAsignar.Size = New System.Drawing.Size(145, 43)
        Me.btnActualizarAsignar.TabIndex = 12
        Me.btnActualizarAsignar.Text = "Actualizar Datos"
        Me.btnActualizarAsignar.UseVisualStyleBackColor = True
        '
        'cboxUsuarios
        '
        Me.cboxUsuarios.Enabled = False
        Me.cboxUsuarios.FormattingEnabled = True
        Me.cboxUsuarios.Location = New System.Drawing.Point(103, 94)
        Me.cboxUsuarios.Name = "cboxUsuarios"
        Me.cboxUsuarios.Size = New System.Drawing.Size(284, 21)
        Me.cboxUsuarios.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Usuario :"
        '
        'cboxAccionAsignar
        '
        Me.cboxAccionAsignar.Enabled = False
        Me.cboxAccionAsignar.FormattingEnabled = True
        Me.cboxAccionAsignar.Items.AddRange(New Object() {"Asignar usuario a cuenta", "Retirar usuario de cuenta"})
        Me.cboxAccionAsignar.Location = New System.Drawing.Point(103, 67)
        Me.cboxAccionAsignar.Name = "cboxAccionAsignar"
        Me.cboxAccionAsignar.Size = New System.Drawing.Size(284, 21)
        Me.cboxAccionAsignar.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Accion :"
        '
        'cboxCuentaAsignar
        '
        Me.cboxCuentaAsignar.FormattingEnabled = True
        Me.cboxCuentaAsignar.Location = New System.Drawing.Point(103, 40)
        Me.cboxCuentaAsignar.Name = "cboxCuentaAsignar"
        Me.cboxCuentaAsignar.Size = New System.Drawing.Size(284, 21)
        Me.cboxCuentaAsignar.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cuenta :"
        '
        'AdminCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 536)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AdminCuentas"
        Me.Text = "Administrar Perfiles de Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablecerCrear As System.Windows.Forms.Button
    Friend WithEvents btnActualizarCrear As System.Windows.Forms.Button
    Friend WithEvents cboxPerfilPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNameCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboxCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxAccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablecerAsignar As System.Windows.Forms.Button
    Friend WithEvents btnActualizarAsignar As System.Windows.Forms.Button
    Friend WithEvents cboxUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboxAccionAsignar As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboxCuentaAsignar As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
