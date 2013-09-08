<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPrivilegios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPrivilegios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgridPrivilegios = New System.Windows.Forms.DataGridView()
        Me.checkAdmin = New System.Windows.Forms.CheckBox()
        Me.txtNamePerfil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxPerfiles = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxAction = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModuleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoModule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activeModule = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idModule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgridPrivilegios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRestablecer)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgridPrivilegios)
        Me.GroupBox1.Controls.Add(Me.checkAdmin)
        Me.GroupBox1.Controls.Add(Me.txtNamePerfil)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboxPerfiles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboxAction)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 485)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administrar Privlegios"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Image = CType(resources.GetObject("btnRestablecer.Image"), System.Drawing.Image)
        Me.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecer.Location = New System.Drawing.Point(215, 416)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(178, 51)
        Me.btnRestablecer.TabIndex = 10
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(16, 416)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(178, 51)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "Actualizar Datos"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Privilegios :"
        '
        'dgridPrivilegios
        '
        Me.dgridPrivilegios.AllowUserToAddRows = False
        Me.dgridPrivilegios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridPrivilegios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModuleName, Me.codigoModule, Me.activeModule, Me.idModule})
        Me.dgridPrivilegios.Location = New System.Drawing.Point(18, 187)
        Me.dgridPrivilegios.Name = "dgridPrivilegios"
        Me.dgridPrivilegios.RowHeadersVisible = False
        Me.dgridPrivilegios.Size = New System.Drawing.Size(528, 213)
        Me.dgridPrivilegios.TabIndex = 7
        '
        'checkAdmin
        '
        Me.checkAdmin.AutoSize = True
        Me.checkAdmin.Location = New System.Drawing.Point(127, 143)
        Me.checkAdmin.Name = "checkAdmin"
        Me.checkAdmin.Size = New System.Drawing.Size(190, 17)
        Me.checkAdmin.TabIndex = 6
        Me.checkAdmin.Text = "Otorgar privilegios de administrador"
        Me.checkAdmin.UseVisualStyleBackColor = True
        '
        'txtNamePerfil
        '
        Me.txtNamePerfil.Location = New System.Drawing.Point(127, 105)
        Me.txtNamePerfil.Name = "txtNamePerfil"
        Me.txtNamePerfil.Size = New System.Drawing.Size(419, 20)
        Me.txtNamePerfil.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre del Perfil :"
        '
        'cboxPerfiles
        '
        Me.cboxPerfiles.Enabled = False
        Me.cboxPerfiles.FormattingEnabled = True
        Me.cboxPerfiles.Location = New System.Drawing.Point(127, 71)
        Me.cboxPerfiles.Name = "cboxPerfiles"
        Me.cboxPerfiles.Size = New System.Drawing.Size(419, 21)
        Me.cboxPerfiles.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Perfil de Privilegios :"
        '
        'cboxAction
        '
        Me.cboxAction.FormattingEnabled = True
        Me.cboxAction.Items.AddRange(New Object() {"Crear nuevo perfil de privilegios", "Modificar perfil de privilegios existente", "Eliminar perfil existente "})
        Me.cboxAction.Location = New System.Drawing.Point(127, 40)
        Me.cboxAction.Name = "cboxAction"
        Me.cboxAction.Size = New System.Drawing.Size(419, 21)
        Me.cboxAction.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accion :"
        '
        'ModuleName
        '
        Me.ModuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ModuleName.HeaderText = "Nombre del Modulo"
        Me.ModuleName.Name = "ModuleName"
        Me.ModuleName.ReadOnly = True
        '
        'codigoModule
        '
        Me.codigoModule.HeaderText = "Codigo Modulo"
        Me.codigoModule.Name = "codigoModule"
        Me.codigoModule.ReadOnly = True
        '
        'activeModule
        '
        Me.activeModule.HeaderText = "Asignar Permisos"
        Me.activeModule.Name = "activeModule"
        '
        'idModule
        '
        Me.idModule.HeaderText = "IdModule"
        Me.idModule.Name = "idModule"
        Me.idModule.Visible = False
        '
        'AdminPrivilegios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 510)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AdminPrivilegios"
        Me.Text = "Administrar Perfiles de Privilegios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgridPrivilegios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgridPrivilegios As System.Windows.Forms.DataGridView
    Friend WithEvents checkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents txtNamePerfil As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboxPerfiles As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxAction As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ModuleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoModule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents activeModule As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idModule As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
