<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtrosPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OtrosPagos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCuotaRecurrente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnCuentas = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDaysCredito = New System.Windows.Forms.TextBox()
        Me.checkCredito = New System.Windows.Forms.CheckBox()
        Me.cboxHabienteDestino = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxRecurrenciaPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamePago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarPagosExistentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerDetalleDePagoEspecificoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboxCuentaMonetaria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.checkLicencia = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.checkLicencia)
        Me.GroupBox1.Controls.Add(Me.cboxCuentaMonetaria)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCuotaRecurrente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnRestablecer)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnUsers)
        Me.GroupBox1.Controls.Add(Me.btnCuentas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDaysCredito)
        Me.GroupBox1.Controls.Add(Me.checkCredito)
        Me.GroupBox1.Controls.Add(Me.cboxHabienteDestino)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboxRecurrenciaPago)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtValorPago)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNamePago)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 445)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Nuevo Pago "
        '
        'txtCuotaRecurrente
        '
        Me.txtCuotaRecurrente.Enabled = False
        Me.txtCuotaRecurrente.Location = New System.Drawing.Point(118, 232)
        Me.txtCuotaRecurrente.Name = "txtCuotaRecurrente"
        Me.txtCuotaRecurrente.Size = New System.Drawing.Size(415, 20)
        Me.txtCuotaRecurrente.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cuota recurrente :"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Image = CType(resources.GetObject("btnRestablecer.Image"), System.Drawing.Image)
        Me.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecer.Location = New System.Drawing.Point(254, 374)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(225, 48)
        Me.btnRestablecer.TabIndex = 14
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(23, 374)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(225, 48)
        Me.btnActualizar.TabIndex = 13
        Me.btnActualizar.Text = "Actualizar Datos"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Enabled = False
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(113, 301)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(174, 43)
        Me.btnUsers.TabIndex = 10
        Me.btnUsers.Tag = ""
        Me.btnUsers.Text = "Usuarios"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnCuentas
        '
        Me.btnCuentas.Enabled = False
        Me.btnCuentas.Image = CType(resources.GetObject("btnCuentas.Image"), System.Drawing.Image)
        Me.btnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentas.Location = New System.Drawing.Point(293, 301)
        Me.btnCuentas.Name = "btnCuentas"
        Me.btnCuentas.Size = New System.Drawing.Size(174, 43)
        Me.btnCuentas.TabIndex = 11
        Me.btnCuentas.Text = "Cuentas"
        Me.btnCuentas.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Habientes :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Credito :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(505, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dias"
        '
        'txtDaysCredito
        '
        Me.txtDaysCredito.Enabled = False
        Me.txtDaysCredito.Location = New System.Drawing.Point(279, 166)
        Me.txtDaysCredito.Name = "txtDaysCredito"
        Me.txtDaysCredito.Size = New System.Drawing.Size(220, 20)
        Me.txtDaysCredito.TabIndex = 6
        '
        'checkCredito
        '
        Me.checkCredito.AutoSize = True
        Me.checkCredito.Location = New System.Drawing.Point(118, 168)
        Me.checkCredito.Name = "checkCredito"
        Me.checkCredito.Size = New System.Drawing.Size(155, 17)
        Me.checkCredito.TabIndex = 5
        Me.checkCredito.Text = "Pasar a credito despues de"
        Me.checkCredito.UseVisualStyleBackColor = True
        '
        'cboxHabienteDestino
        '
        Me.cboxHabienteDestino.FormattingEnabled = True
        Me.cboxHabienteDestino.ItemHeight = 13
        Me.cboxHabienteDestino.Items.AddRange(New Object() {"Las Cuentas y Usuarios que especifique", "Todos los Usuarios", "Todas las Cuentas", "Todos los Usuarios y Cuentas "})
        Me.cboxHabienteDestino.Location = New System.Drawing.Point(118, 264)
        Me.cboxHabienteDestino.Name = "cboxHabienteDestino"
        Me.cboxHabienteDestino.Size = New System.Drawing.Size(415, 21)
        Me.cboxHabienteDestino.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Habiente Destino :"
        '
        'cboxRecurrenciaPago
        '
        Me.cboxRecurrenciaPago.FormattingEnabled = True
        Me.cboxRecurrenciaPago.Items.AddRange(New Object() {"Solo una vez", "Todos los dias", "Todas las semanas", "Todos los meses", "Al comienzo de cada año"})
        Me.cboxRecurrenciaPago.Location = New System.Drawing.Point(118, 134)
        Me.cboxRecurrenciaPago.Name = "cboxRecurrenciaPago"
        Me.cboxRecurrenciaPago.Size = New System.Drawing.Size(415, 21)
        Me.cboxRecurrenciaPago.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Recurrencia :"
        '
        'txtValorPago
        '
        Me.txtValorPago.Location = New System.Drawing.Point(118, 71)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(415, 20)
        Me.txtValorPago.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valor Pago :"
        '
        'txtNamePago
        '
        Me.txtNamePago.Location = New System.Drawing.Point(118, 39)
        Me.txtNamePago.Name = "txtNamePago"
        Me.txtNamePago.Size = New System.Drawing.Size(415, 20)
        Me.txtNamePago.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del pago :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarPagosExistentesToolStripMenuItem, Me.ObtenerDetalleDePagoEspecificoToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Image = CType(resources.GetObject("OperacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'VisualizarPagosExistentesToolStripMenuItem
        '
        Me.VisualizarPagosExistentesToolStripMenuItem.Name = "VisualizarPagosExistentesToolStripMenuItem"
        Me.VisualizarPagosExistentesToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.VisualizarPagosExistentesToolStripMenuItem.Text = "Adminstrar Pagos Existentes"
        '
        'ObtenerDetalleDePagoEspecificoToolStripMenuItem
        '
        Me.ObtenerDetalleDePagoEspecificoToolStripMenuItem.Name = "ObtenerDetalleDePagoEspecificoToolStripMenuItem"
        Me.ObtenerDetalleDePagoEspecificoToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ObtenerDetalleDePagoEspecificoToolStripMenuItem.Text = "Obtener Detalle de Pago Especifico"
        '
        'cboxCuentaMonetaria
        '
        Me.cboxCuentaMonetaria.FormattingEnabled = True
        Me.cboxCuentaMonetaria.Location = New System.Drawing.Point(118, 102)
        Me.cboxCuentaMonetaria.Name = "cboxCuentaMonetaria"
        Me.cboxCuentaMonetaria.Size = New System.Drawing.Size(415, 21)
        Me.cboxCuentaMonetaria.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Cuenta Monetaria :"
        '
        'checkLicencia
        '
        Me.checkLicencia.AutoSize = True
        Me.checkLicencia.Location = New System.Drawing.Point(118, 200)
        Me.checkLicencia.Name = "checkLicencia"
        Me.checkLicencia.Size = New System.Drawing.Size(188, 17)
        Me.checkLicencia.TabIndex = 7
        Me.checkLicencia.Text = "Cobrar pago en estado de licencia"
        Me.checkLicencia.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Opciones :"
        '
        'OtrosPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "OtrosPagos"
        Me.Text = "Administrar Otros Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkCredito As System.Windows.Forms.CheckBox
    Friend WithEvents cboxHabienteDestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboxRecurrenciaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValorPago As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamePago As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDaysCredito As System.Windows.Forms.TextBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnCuentas As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizarPagosExistentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObtenerDetalleDePagoEspecificoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCuotaRecurrente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboxCuentaMonetaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents checkLicencia As System.Windows.Forms.CheckBox
End Class
