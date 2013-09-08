<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eximiciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eximiciones))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinirVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.cboxTipoOperacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJustificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpickertermino = New System.Windows.Forms.DateTimePicker()
        Me.dpickerinicio = New System.Windows.Forms.DateTimePicker()
        Me.cboxBeneficiario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxhabiente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpcionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiasDeVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Image = CType(resources.GetObject("OpcionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'DefinirVacacionesToolStripMenuItem
        '
        Me.DefinirVacacionesToolStripMenuItem.Image = CType(resources.GetObject("DefinirVacacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DefinirVacacionesToolStripMenuItem.Name = "DefinirVacacionesToolStripMenuItem"
        Me.DefinirVacacionesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DefinirVacacionesToolStripMenuItem.Text = "Definir Vacaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRestablecer)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.cboxTipoOperacion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtJustificacion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dpickertermino)
        Me.GroupBox1.Controls.Add(Me.dpickerinicio)
        Me.GroupBox1.Controls.Add(Me.cboxBeneficiario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboxhabiente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 290)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Eximición o Vacacion"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Image = CType(resources.GetObject("btnRestablecer.Image"), System.Drawing.Image)
        Me.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecer.Location = New System.Drawing.Point(216, 228)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(185, 44)
        Me.btnRestablecer.TabIndex = 14
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(25, 228)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(185, 44)
        Me.btnActualizar.TabIndex = 13
        Me.btnActualizar.Text = "Actualizar Datos"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'cboxTipoOperacion
        '
        Me.cboxTipoOperacion.FormattingEnabled = True
        Me.cboxTipoOperacion.Items.AddRange(New Object() {"Ingresar Eximición", "Asignar Vacaciones"})
        Me.cboxTipoOperacion.Location = New System.Drawing.Point(146, 41)
        Me.cboxTipoOperacion.Name = "cboxTipoOperacion"
        Me.cboxTipoOperacion.Size = New System.Drawing.Size(320, 21)
        Me.cboxTipoOperacion.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de Operacion :"
        '
        'txtJustificacion
        '
        Me.txtJustificacion.Location = New System.Drawing.Point(146, 178)
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.Size = New System.Drawing.Size(320, 20)
        Me.txtJustificacion.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Motivo de Justificación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha de Termino :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha de Inicio :"
        '
        'dpickertermino
        '
        Me.dpickertermino.Location = New System.Drawing.Point(146, 149)
        Me.dpickertermino.Name = "dpickertermino"
        Me.dpickertermino.Size = New System.Drawing.Size(320, 20)
        Me.dpickertermino.TabIndex = 6
        '
        'dpickerinicio
        '
        Me.dpickerinicio.Location = New System.Drawing.Point(146, 123)
        Me.dpickerinicio.Name = "dpickerinicio"
        Me.dpickerinicio.Size = New System.Drawing.Size(320, 20)
        Me.dpickerinicio.TabIndex = 5
        '
        'cboxBeneficiario
        '
        Me.cboxBeneficiario.FormattingEnabled = True
        Me.cboxBeneficiario.Location = New System.Drawing.Point(146, 96)
        Me.cboxBeneficiario.Name = "cboxBeneficiario"
        Me.cboxBeneficiario.Size = New System.Drawing.Size(320, 21)
        Me.cboxBeneficiario.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Beneficiario Objetivo :"
        '
        'cboxhabiente
        '
        Me.cboxhabiente.FormattingEnabled = True
        Me.cboxhabiente.Items.AddRange(New Object() {"Seleccione", "Los cuentas que elija", "Todas las cuentas"})
        Me.cboxhabiente.Location = New System.Drawing.Point(146, 69)
        Me.cboxhabiente.Name = "cboxhabiente"
        Me.cboxhabiente.Size = New System.Drawing.Size(320, 21)
        Me.cboxhabiente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Beneficiario Destino :"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Ingresar Eximición", "Asignar Vacaciones"})
        Me.ComboBox3.Location = New System.Drawing.Point(146, 41)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(320, 21)
        Me.ComboBox3.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(146, 123)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(320, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 178)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 10
        '
        'OpcionesToolStripMenuItem1
        '
        Me.OpcionesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiasDeVacacionesToolStripMenuItem})
        Me.OpcionesToolStripMenuItem1.Image = CType(resources.GetObject("OpcionesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OpcionesToolStripMenuItem1.Name = "OpcionesToolStripMenuItem1"
        Me.OpcionesToolStripMenuItem1.Size = New System.Drawing.Size(85, 20)
        Me.OpcionesToolStripMenuItem1.Text = "Opciones"
        '
        'DiasDeVacacionesToolStripMenuItem
        '
        Me.DiasDeVacacionesToolStripMenuItem.Image = CType(resources.GetObject("DiasDeVacacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DiasDeVacacionesToolStripMenuItem.Name = "DiasDeVacacionesToolStripMenuItem"
        Me.DiasDeVacacionesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DiasDeVacacionesToolStripMenuItem.Text = "Dias de Vacaciones"
        '
        'Eximiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 344)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Eximiciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eximiciones y Vacaciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefinirVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents cboxTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJustificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpickertermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpickerinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboxBeneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxhabiente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpcionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiasDeVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
