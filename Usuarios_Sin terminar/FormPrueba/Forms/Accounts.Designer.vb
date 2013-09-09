<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.photoCheck2 = New System.Windows.Forms.RadioButton()
        Me.photoCheck1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.userSearch = New System.Windows.Forms.RadioButton()
        Me.userAdd = New System.Windows.Forms.RadioButton()
        Me.pboxPhoto = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_photo = New System.Windows.Forms.Button()
        Me.txt_telefono_movil = New System.Windows.Forms.TextBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Ayuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.pboxPhoto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.Panel2)
        Me.GroupBox.Controls.Add(Me.Panel1)
        Me.GroupBox.Controls.Add(Me.pboxPhoto)
        Me.GroupBox.Controls.Add(Me.Button2)
        Me.GroupBox.Controls.Add(Me.Button1)
        Me.GroupBox.Controls.Add(Me.txt_id)
        Me.GroupBox.Controls.Add(Me.txt_name)
        Me.GroupBox.Controls.Add(Me.txt_direccion)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.btn_photo)
        Me.GroupBox.Controls.Add(Me.txt_telefono_movil)
        Me.GroupBox.Controls.Add(Me.txt_rut)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.txt_telefono)
        Me.GroupBox.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(454, 510)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = false
        Me.GroupBox.Text = "Agregar Nuevo Usuario"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.photoCheck2)
        Me.Panel2.Controls.Add(Me.photoCheck1)
        Me.Panel2.Location = New System.Drawing.Point(24, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 53)
        Me.Panel2.TabIndex = 23
        Me.Ayuda.SetToolTip(Me.Panel2, "Elija entre tomar y no tomar una foto al usuario")
        '
        'photoCheck2
        '
        Me.photoCheck2.AutoSize = true
        Me.photoCheck2.Location = New System.Drawing.Point(236, 19)
        Me.photoCheck2.Name = "photoCheck2"
        Me.photoCheck2.Size = New System.Drawing.Size(154, 17)
        Me.photoCheck2.TabIndex = 24
        Me.photoCheck2.Text = "NO TOMAR FOTOGRAFIA"
        Me.photoCheck2.UseVisualStyleBackColor = true
        '
        'photoCheck1
        '
        Me.photoCheck1.AutoSize = true
        Me.photoCheck1.Checked = true
        Me.photoCheck1.Location = New System.Drawing.Point(29, 19)
        Me.photoCheck1.Name = "photoCheck1"
        Me.photoCheck1.Size = New System.Drawing.Size(161, 17)
        Me.photoCheck1.TabIndex = 23
        Me.photoCheck1.TabStop = true
        Me.photoCheck1.Text = "TOMAR UNA FOTOGRAFIA"
        Me.photoCheck1.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.userSearch)
        Me.Panel1.Controls.Add(Me.userAdd)
        Me.Panel1.Location = New System.Drawing.Point(6, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 74)
        Me.Panel1.TabIndex = 0
        Me.Ayuda.SetToolTip(Me.Panel1, "Elija entre Crear un Usuario o Modificarlo")
        '
        'userSearch
        '
        Me.userSearch.AutoSize = true
        Me.userSearch.Location = New System.Drawing.Point(163, 29)
        Me.userSearch.Name = "userSearch"
        Me.userSearch.Size = New System.Drawing.Size(276, 17)
        Me.userSearch.TabIndex = 3
        Me.userSearch.Text = "BUSCAR O MODIFICAR UN USUARIO EXISTENTE"
        Me.Ayuda.SetToolTip(Me.userSearch, "Busque o un Usuario en la red por sus datos.")
        Me.userSearch.UseVisualStyleBackColor = true
        '
        'userAdd
        '
        Me.userAdd.AutoSize = true
        Me.userAdd.Checked = true
        Me.userAdd.Location = New System.Drawing.Point(7, 29)
        Me.userAdd.Name = "userAdd"
        Me.userAdd.Size = New System.Drawing.Size(155, 17)
        Me.userAdd.TabIndex = 2
        Me.userAdd.TabStop = true
        Me.userAdd.Text = "CREAR NUEVO USUARIO"
        Me.Ayuda.SetToolTip(Me.userAdd, "Cree un Nuevo Usuario en caso de no existir")
        Me.userAdd.UseVisualStyleBackColor = true
        '
        'pboxPhoto
        '
        Me.pboxPhoto.Image = Global.Accounts.My.Resources.Resources.agt_action_fail
        Me.pboxPhoto.Location = New System.Drawing.Point(379, 376)
        Me.pboxPhoto.Name = "pboxPhoto"
        Me.pboxPhoto.Size = New System.Drawing.Size(34, 32)
        Me.pboxPhoto.TabIndex = 18
        Me.pboxPhoto.TabStop = false
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"),System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(241, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 48)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Restablecer"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"),System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(34, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Actualizar Datos"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'txt_id
        '
        Me.txt_id.AllowDrop = true
        Me.txt_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_id.Location = New System.Drawing.Point(165, 283)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = true
        Me.txt_id.Size = New System.Drawing.Size(271, 20)
        Me.txt_id.TabIndex = 14
        Me.Ayuda.SetToolTip(Me.txt_id, "Este es el Codigo ID unico del Usuario.")
        '
        'txt_name
        '
        Me.txt_name.AllowDrop = true
        Me.txt_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_name.Location = New System.Drawing.Point(165, 103)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(271, 20)
        Me.txt_name.TabIndex = 2
        Me.Ayuda.SetToolTip(Me.txt_name, "Escriba el Nombre del Usuario")
        '
        'txt_direccion
        '
        Me.txt_direccion.AllowDrop = true
        Me.txt_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_direccion.Location = New System.Drawing.Point(165, 175)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(271, 20)
        Me.txt_direccion.TabIndex = 4
        Me.Ayuda.SetToolTip(Me.txt_direccion, "Indique la Direccion Particular del Usuario")
        '
        'Label2
        '
        Me.Label2.AllowDrop = true
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(117, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "RUT :"
        '
        'Label6
        '
        Me.Label6.AllowDrop = true
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(84, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CODIGO ID :"
        '
        'Label1
        '
        Me.Label1.AllowDrop = true
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(31, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NOMBRE COMPLETO :"
        '
        'Label3
        '
        Me.Label3.AllowDrop = true
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(47, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "TELEFONO MOVIL :"
        '
        'btn_photo
        '
        Me.btn_photo.AllowDrop = true
        Me.btn_photo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_photo.Image = CType(resources.GetObject("btn_photo.Image"),System.Drawing.Image)
        Me.btn_photo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_photo.Location = New System.Drawing.Point(99, 366)
        Me.btn_photo.Name = "btn_photo"
        Me.btn_photo.Size = New System.Drawing.Size(265, 52)
        Me.btn_photo.TabIndex = 12
        Me.btn_photo.Text = "TOMAR FOTOGRAFIA"
        Me.Ayuda.SetToolTip(Me.btn_photo, "Presione para tomar fotografia al Usuario")
        Me.btn_photo.UseVisualStyleBackColor = true
        '
        'txt_telefono_movil
        '
        Me.txt_telefono_movil.AllowDrop = true
        Me.txt_telefono_movil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_telefono_movil.Location = New System.Drawing.Point(165, 247)
        Me.txt_telefono_movil.Name = "txt_telefono_movil"
        Me.txt_telefono_movil.Size = New System.Drawing.Size(271, 20)
        Me.txt_telefono_movil.TabIndex = 6
        Me.Ayuda.SetToolTip(Me.txt_telefono_movil, "Indique el Telefono Movil, en caso de no poseer indique : No Registra")
        '
        'txt_rut
        '
        Me.txt_rut.AllowDrop = true
        Me.txt_rut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_rut.Location = New System.Drawing.Point(165, 139)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(271, 20)
        Me.txt_rut.TabIndex = 3
        Me.Ayuda.SetToolTip(Me.txt_rut, "Indique el RUT del nuevo Usuario. Formato XX.XXX.XXX-X")
        '
        'Label4
        '
        Me.Label4.AllowDrop = true
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(10, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DIRECCIÓN PARTICULAR :"
        '
        'Label5
        '
        Me.Label5.AllowDrop = true
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(58, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TELEFONO FIJO :"
        '
        'txt_telefono
        '
        Me.txt_telefono.AllowDrop = true
        Me.txt_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_telefono.Location = New System.Drawing.Point(165, 211)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(271, 20)
        Me.txt_telefono.TabIndex = 5
        Me.Ayuda.SetToolTip(Me.txt_telefono, "Indique el Telefono Fijo, en caso de no poseer indique : No Registra")
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = true
        Me.RadioButton2.Location = New System.Drawing.Point(176, 45)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(276, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = true
        Me.RadioButton2.Text = "BUSCAR O MODIFICAR UN USUARIO EXISTENTE"
        Me.Ayuda.SetToolTip(Me.RadioButton2, "Busque o un Usuario en la red por sus datos.")
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(490, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 510)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Emision de Credenciales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(379, 376)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = false
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "Accounts"
        Me.Text = "Administracion de Usuarios"
        Me.GroupBox.ResumeLayout(false)
        Me.GroupBox.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.pboxPhoto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_movil As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Ayuda As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_photo As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pboxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents photoCheck2 As System.Windows.Forms.RadioButton
    Friend WithEvents photoCheck1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents userSearch As System.Windows.Forms.RadioButton
    Friend WithEvents userAdd As System.Windows.Forms.RadioButton

End Class
