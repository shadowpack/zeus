<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addUsers))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgridAddUser = New System.Windows.Forms.DataGridView()
        Me.idAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddAcount = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgridAddUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRestablecer)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.dgridAddUser)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 340)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Usuarios"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Image = CType(resources.GetObject("btnRestablecer.Image"), System.Drawing.Image)
        Me.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecer.Location = New System.Drawing.Point(191, 285)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(153, 39)
        Me.btnRestablecer.TabIndex = 2
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(22, 285)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(153, 39)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgridAddUser
        '
        Me.dgridAddUser.AllowUserToAddRows = False
        Me.dgridAddUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridAddUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idAccount, Me.colAccount, Me.colAddAcount})
        Me.dgridAddUser.Location = New System.Drawing.Point(22, 39)
        Me.dgridAddUser.Name = "dgridAddUser"
        Me.dgridAddUser.RowHeadersVisible = False
        Me.dgridAddUser.Size = New System.Drawing.Size(401, 222)
        Me.dgridAddUser.TabIndex = 0
        '
        'idAccount
        '
        Me.idAccount.HeaderText = "Id Cuenta"
        Me.idAccount.Name = "idAccount"
        Me.idAccount.Visible = False
        '
        'colAccount
        '
        Me.colAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAccount.HeaderText = "Nombre Cuenta"
        Me.colAccount.Name = "colAccount"
        Me.colAccount.ReadOnly = True
        '
        'colAddAcount
        '
        Me.colAddAcount.HeaderText = "Agregar Cuenta"
        Me.colAddAcount.Name = "colAddAcount"
        Me.colAddAcount.Width = 120
        '
        'addUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 369)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "addUsers"
        Me.Text = "Agregar Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgridAddUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgridAddUser As System.Windows.Forms.DataGridView
    Friend WithEvents idAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddAcount As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
