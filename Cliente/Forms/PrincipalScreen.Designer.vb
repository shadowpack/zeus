<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalScreen))
        Me.pboxactu = New System.Windows.Forms.PictureBox()
        Me.menuForm = New System.Windows.Forms.MenuStrip()
        Me.ProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pboxactu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'pboxactu
        '
        Me.pboxactu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pboxactu.Image = CType(resources.GetObject("pboxactu.Image"), System.Drawing.Image)
        Me.pboxactu.Location = New System.Drawing.Point(981, 623)
        Me.pboxactu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pboxactu.Name = "pboxactu"
        Me.pboxactu.Size = New System.Drawing.Size(29, 31)
        Me.pboxactu.TabIndex = 26
        Me.pboxactu.TabStop = False
        '
        'menuForm
        '
        Me.menuForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramaToolStripMenuItem})
        Me.menuForm.Location = New System.Drawing.Point(0, 0)
        Me.menuForm.Name = "menuForm"
        Me.menuForm.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menuForm.Size = New System.Drawing.Size(1012, 28)
        Me.menuForm.TabIndex = 27
        Me.menuForm.Text = "MenuStrip1"
        '
        'ProgramaToolStripMenuItem
        '
        Me.ProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem})
        Me.ProgramaToolStripMenuItem.Name = "ProgramaToolStripMenuItem"
        Me.ProgramaToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.ProgramaToolStripMenuItem.Text = "Programa"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Image = CType(resources.GetObject("CerrarSesionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'PrincipalScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 654)
        Me.Controls.Add(Me.pboxactu)
        Me.Controls.Add(Me.menuForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuForm
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PrincipalScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pboxactu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuForm.ResumeLayout(False)
        Me.menuForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxactu As System.Windows.Forms.PictureBox
    Friend WithEvents menuForm As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
