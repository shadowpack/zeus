<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class distribucion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(distribucion))
        Me.dgridDistri = New System.Windows.Forms.DataGridView()
        Me.cc_cbox = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.montocc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbldinero = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgridDistri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgridDistri
        '
        Me.dgridDistri.AllowUserToAddRows = False
        Me.dgridDistri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridDistri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cc_cbox, Me.montocc})
        Me.dgridDistri.Location = New System.Drawing.Point(12, 74)
        Me.dgridDistri.Name = "dgridDistri"
        Me.dgridDistri.RowHeadersVisible = False
        Me.dgridDistri.Size = New System.Drawing.Size(364, 259)
        Me.dgridDistri.TabIndex = 0
        '
        'cc_cbox
        '
        Me.cc_cbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cc_cbox.HeaderText = "Cuenta Monetaria"
        Me.cc_cbox.Name = "cc_cbox"
        '
        'montocc
        '
        Me.montocc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.montocc.HeaderText = "Monto"
        Me.montocc.Name = "montocc"
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(12, 354)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(162, 48)
        Me.btnAsignar.TabIndex = 1
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Image = CType(resources.GetObject("btnRestablecer.Image"), System.Drawing.Image)
        Me.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecer.Location = New System.Drawing.Point(193, 354)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(167, 48)
        Me.btnRestablecer.TabIndex = 2
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dinero por Distribuir :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "$"
        '
        'lbldinero
        '
        Me.lbldinero.AutoSize = True
        Me.lbldinero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldinero.Location = New System.Drawing.Point(189, 23)
        Me.lbldinero.Name = "lbldinero"
        Me.lbldinero.Size = New System.Drawing.Size(18, 20)
        Me.lbldinero.TabIndex = 5
        Me.lbldinero.Text = "0"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(242, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 34)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Agregar Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'distribucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 414)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbldinero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRestablecer)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.dgridDistri)
        Me.Name = "distribucion"
        Me.Text = "Distribuciones"
        CType(Me.dgridDistri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgridDistri As System.Windows.Forms.DataGridView
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldinero As System.Windows.Forms.Label
    Friend WithEvents cc_cbox As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents montocc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
