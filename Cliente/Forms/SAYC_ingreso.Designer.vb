<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAYC_ingreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SAYC_ingreso))
        Me.pboxactu = New System.Windows.Forms.PictureBox()
        Me.lblEmpre = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblcargo = New System.Windows.Forms.Label()
        Me.lblcar = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pboxactu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pboxactu
        '
        Me.pboxactu.Image = CType(resources.GetObject("pboxactu.Image"), System.Drawing.Image)
        Me.pboxactu.Location = New System.Drawing.Point(3, 399)
        Me.pboxactu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pboxactu.Name = "pboxactu"
        Me.pboxactu.Size = New System.Drawing.Size(29, 31)
        Me.pboxactu.TabIndex = 25
        Me.pboxactu.TabStop = False
        '
        'lblEmpre
        '
        Me.lblEmpre.AutoSize = True
        Me.lblEmpre.Enabled = False
        Me.lblEmpre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpre.Location = New System.Drawing.Point(175, 164)
        Me.lblEmpre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpre.Name = "lblEmpre"
        Me.lblEmpre.Size = New System.Drawing.Size(86, 24)
        Me.lblEmpre.TabIndex = 24
        Me.lblEmpre.Text = "Empresa"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Enabled = False
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(69, 164)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(96, 24)
        Me.lblEmpresa.TabIndex = 23
        Me.lblEmpresa.Text = "Empresa :"
        '
        'btnIngreso
        '
        Me.btnIngreso.Enabled = False
        Me.btnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngreso.Image = CType(resources.GetObject("btnIngreso.Image"), System.Drawing.Image)
        Me.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngreso.Location = New System.Drawing.Point(133, 332)
        Me.btnIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(291, 57)
        Me.btnIngreso.TabIndex = 22
        Me.btnIngreso.Text = "Ingresar"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Enabled = False
        Me.lblcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontraseña.Location = New System.Drawing.Point(47, 267)
        Me.lblcontraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(116, 24)
        Me.lblcontraseña.TabIndex = 21
        Me.lblcontraseña.Text = "Contraseña :"
        '
        'txtpassword
        '
        Me.txtpassword.Enabled = False
        Me.txtpassword.Location = New System.Drawing.Point(179, 268)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(279, 22)
        Me.txtpassword.TabIndex = 20
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'lblcargo
        '
        Me.lblcargo.AutoSize = True
        Me.lblcargo.Enabled = False
        Me.lblcargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcargo.Location = New System.Drawing.Point(175, 231)
        Me.lblcargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcargo.Name = "lblcargo"
        Me.lblcargo.Size = New System.Drawing.Size(61, 24)
        Me.lblcargo.TabIndex = 19
        Me.lblcargo.Text = "Cargo"
        '
        'lblcar
        '
        Me.lblcar.AutoSize = True
        Me.lblcar.Enabled = False
        Me.lblcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcar.Location = New System.Drawing.Point(95, 231)
        Me.lblcar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcar.Name = "lblcar"
        Me.lblcar.Size = New System.Drawing.Size(71, 24)
        Me.lblcar.TabIndex = 18
        Me.lblcar.Text = "Cargo :"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Enabled = False
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(175, 198)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(79, 24)
        Me.lblname.TabIndex = 17
        Me.lblname.Text = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Enabled = False
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(77, 198)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(89, 24)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre :"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(49, 107)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(465, 22)
        Me.txtid.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(516, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Acerque su credencial al lector o digite su id para validar su usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bienvenido al sistema de Administracion CLOUD ZEUS"
        '
        'SAYC_ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 432)
        Me.Controls.Add(Me.pboxactu)
        Me.Controls.Add(Me.lblEmpre)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lblcargo)
        Me.Controls.Add(Me.lblcar)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SAYC_ingreso"
        Me.Text = "Ingreso - CLOUD ZEUS"
        CType(Me.pboxactu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxactu As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpre As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents btnIngreso As System.Windows.Forms.Button
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblcargo As System.Windows.Forms.Label
    Friend WithEvents lblcar As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
