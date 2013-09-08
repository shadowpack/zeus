<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ahorros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ahorros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMontoDisponible = New System.Windows.Forms.Label()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMontoOperacion = New System.Windows.Forms.TextBox()
        Me.cboxOperacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxHabiente = New System.Windows.Forms.ComboBox()
        Me.cboxTipoAhorro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgridAhorros = New System.Windows.Forms.DataGridView()
        Me.tipomov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgridAhorros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMontoDisponible)
        Me.GroupBox1.Controls.Add(Me.btnRestablecer)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMontoOperacion)
        Me.GroupBox1.Controls.Add(Me.cboxOperacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboxHabiente)
        Me.GroupBox1.Controls.Add(Me.cboxTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Habiente"
        '
        'lblMontoDisponible
        '
        Me.lblMontoDisponible.AutoSize = True
        Me.lblMontoDisponible.Location = New System.Drawing.Point(122, 92)
        Me.lblMontoDisponible.Name = "lblMontoDisponible"
        Me.lblMontoDisponible.Size = New System.Drawing.Size(89, 13)
        Me.lblMontoDisponible.TabIndex = 13
        Me.lblMontoDisponible.Text = "Monto Disponible"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Image = CType(resources.GetObject("btnRestablecer.Image"), System.Drawing.Image)
        Me.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecer.Location = New System.Drawing.Point(234, 184)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(204, 45)
        Me.btnRestablecer.TabIndex = 12
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(24, 184)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(204, 45)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar Datos"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Monto operacion :"
        '
        'txtMontoOperacion
        '
        Me.txtMontoOperacion.Location = New System.Drawing.Point(122, 142)
        Me.txtMontoOperacion.Name = "txtMontoOperacion"
        Me.txtMontoOperacion.Size = New System.Drawing.Size(431, 20)
        Me.txtMontoOperacion.TabIndex = 9
        '
        'cboxOperacion
        '
        Me.cboxOperacion.FormattingEnabled = True
        Me.cboxOperacion.Items.AddRange(New Object() {"Abonar Dinero", "Retirar Ahorros"})
        Me.cboxOperacion.Location = New System.Drawing.Point(123, 115)
        Me.cboxOperacion.Name = "cboxOperacion"
        Me.cboxOperacion.Size = New System.Drawing.Size(431, 21)
        Me.cboxOperacion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Operacion :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Monto Disponible :"
        '
        'cboxHabiente
        '
        Me.cboxHabiente.FormattingEnabled = True
        Me.cboxHabiente.Location = New System.Drawing.Point(123, 62)
        Me.cboxHabiente.Name = "cboxHabiente"
        Me.cboxHabiente.Size = New System.Drawing.Size(431, 21)
        Me.cboxHabiente.TabIndex = 3
        '
        'cboxTipoAhorro
        '
        Me.cboxTipoAhorro.FormattingEnabled = True
        Me.cboxTipoAhorro.Items.AddRange(New Object() {"Ahorros de Cuenta", "Ahorros de Usuario"})
        Me.cboxTipoAhorro.Location = New System.Drawing.Point(123, 35)
        Me.cboxTipoAhorro.Name = "cboxTipoAhorro"
        Me.cboxTipoAhorro.Size = New System.Drawing.Size(431, 21)
        Me.cboxTipoAhorro.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Habiente :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipos de Ahorros :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgridAhorros)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(687, 323)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movimientos del habiente"
        '
        'dgridAhorros
        '
        Me.dgridAhorros.AllowUserToAddRows = False
        Me.dgridAhorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridAhorros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipomov, Me.cantidad, Me.Column2, Me.Column1})
        Me.dgridAhorros.Location = New System.Drawing.Point(25, 35)
        Me.dgridAhorros.Name = "dgridAhorros"
        Me.dgridAhorros.RowHeadersVisible = False
        Me.dgridAhorros.Size = New System.Drawing.Size(638, 261)
        Me.dgridAhorros.TabIndex = 0
        '
        'tipomov
        '
        Me.tipomov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipomov.HeaderText = "Tipo de Operacion"
        Me.tipomov.Name = "tipomov"
        '
        'cantidad
        '
        Me.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Monto Previo"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Saldo Post-Operacion"
        Me.Column1.Name = "Column1"
        '
        'Ahorros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 613)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ahorros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de Ahorros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgridAhorros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMontoOperacion As System.Windows.Forms.TextBox
    Friend WithEvents cboxOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboxHabiente As System.Windows.Forms.ComboBox
    Friend WithEvents cboxTipoAhorro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgridAhorros As System.Windows.Forms.DataGridView
    Friend WithEvents tipomov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMontoDisponible As System.Windows.Forms.Label
End Class
