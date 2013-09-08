<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountSelector))
        Me.dgridSelector = New System.Windows.Forms.DataGridView()
        Me.lblSelector = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgridSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgridSelector
        '
        Me.dgridSelector.AllowUserToAddRows = False
        Me.dgridSelector.AllowUserToDeleteRows = False
        Me.dgridSelector.AllowUserToResizeColumns = False
        Me.dgridSelector.AllowUserToResizeRows = False
        Me.dgridSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridSelector.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Empresa, Me.Cargo, Me.Accion})
        Me.dgridSelector.Location = New System.Drawing.Point(12, 63)
        Me.dgridSelector.Name = "dgridSelector"
        Me.dgridSelector.RowHeadersVisible = False
        Me.dgridSelector.Size = New System.Drawing.Size(422, 188)
        Me.dgridSelector.TabIndex = 0
        '
        'lblSelector
        '
        Me.lblSelector.AutoSize = True
        Me.lblSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelector.Location = New System.Drawing.Point(12, 22)
        Me.lblSelector.Name = "lblSelector"
        Me.lblSelector.Size = New System.Drawing.Size(355, 16)
        Me.lblSelector.TabIndex = 1
        Me.lblSelector.Text = "El usuario indicado posee cuenta en mas de una empresa"
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Empresa
        '
        Me.Empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        '
        'Cargo
        '
        Me.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'Accion
        '
        Me.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Accion.HeaderText = "Accion"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        Me.Accion.Text = "Elegir"
        Me.Accion.UseColumnTextForButtonValue = True
        '
        'AccountSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 274)
        Me.Controls.Add(Me.lblSelector)
        Me.Controls.Add(Me.dgridSelector)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.name = "AccountSelector"
        Me.Text = "Seleccion de Cuentas"
        CType(Me.dgridSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgridSelector As System.Windows.Forms.DataGridView
    Friend WithEvents lblSelector As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewButtonColumn
End Class
