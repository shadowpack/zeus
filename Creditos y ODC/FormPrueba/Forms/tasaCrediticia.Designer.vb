<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tasaCrediticia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tasaCrediticia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRestablcer = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxTipoInteres = New System.Windows.Forms.ComboBox()
        Me.txtNameTasa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgridTasas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameTasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tasaNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interesTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgridTasas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnRestablcer)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.txtTasaInteres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboxTipoInteres)
        Me.GroupBox1.Controls.Add(Me.txtNameTasa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Tasa Crediticia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(468, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "%"
        '
        'btnRestablcer
        '
        Me.btnRestablcer.Image = CType(resources.GetObject("btnRestablcer.Image"), System.Drawing.Image)
        Me.btnRestablcer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablcer.Location = New System.Drawing.Point(197, 131)
        Me.btnRestablcer.Name = "btnRestablcer"
        Me.btnRestablcer.Size = New System.Drawing.Size(165, 50)
        Me.btnRestablcer.TabIndex = 7
        Me.btnRestablcer.Text = "Restablecer"
        Me.btnRestablcer.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(26, 131)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(165, 50)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar Datos"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.Location = New System.Drawing.Point(121, 61)
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.Size = New System.Drawing.Size(341, 20)
        Me.txtTasaInteres.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Interes :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tasa de Interes :"
        '
        'cboxTipoInteres
        '
        Me.cboxTipoInteres.FormattingEnabled = True
        Me.cboxTipoInteres.Location = New System.Drawing.Point(121, 87)
        Me.cboxTipoInteres.Name = "cboxTipoInteres"
        Me.cboxTipoInteres.Size = New System.Drawing.Size(341, 21)
        Me.cboxTipoInteres.TabIndex = 2
        '
        'txtNameTasa
        '
        Me.txtNameTasa.Location = New System.Drawing.Point(121, 35)
        Me.txtNameTasa.Name = "txtNameTasa"
        Me.txtNameTasa.Size = New System.Drawing.Size(341, 20)
        Me.txtNameTasa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Tasa :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgridTasas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 229)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tasas Vigentes"
        '
        'dgridTasas
        '
        Me.dgridTasas.AllowUserToAddRows = False
        Me.dgridTasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridTasas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nameTasa, Me.tasaNum, Me.interesTipo, Me.action})
        Me.dgridTasas.Location = New System.Drawing.Point(17, 34)
        Me.dgridTasas.Name = "dgridTasas"
        Me.dgridTasas.RowHeadersVisible = False
        Me.dgridTasas.Size = New System.Drawing.Size(553, 176)
        Me.dgridTasas.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'nameTasa
        '
        Me.nameTasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nameTasa.HeaderText = "Denominacion"
        Me.nameTasa.Name = "nameTasa"
        '
        'tasaNum
        '
        Me.tasaNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tasaNum.HeaderText = "Tasa de Interes"
        Me.tasaNum.Name = "tasaNum"
        '
        'interesTipo
        '
        Me.interesTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.interesTipo.HeaderText = "Tipo de Interes"
        Me.interesTipo.Name = "interesTipo"
        '
        'action
        '
        Me.action.HeaderText = "Accion"
        Me.action.Name = "action"
        Me.action.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.action.Text = "Eliminar"
        Me.action.UseColumnTextForButtonValue = True
        '
        'tasaCrediticia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 459)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "tasaCrediticia"
        Me.Text = "Tasas Crediticias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgridTasas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablcer As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtTasaInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxTipoInteres As System.Windows.Forms.ComboBox
    Friend WithEvents txtNameTasa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgridTasas As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nameTasa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tasaNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents interesTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents action As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
