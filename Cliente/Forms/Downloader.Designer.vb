<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downloader))
        Me.statusBar = New System.Windows.Forms.ProgressBar()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'statusBar
        '
        Me.statusBar.Location = New System.Drawing.Point(12, 100)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(504, 31)
        Me.statusBar.TabIndex = 0
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Location = New System.Drawing.Point(9, 71)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(76, 13)
        Me.lblProgreso.TabIndex = 1
        Me.lblProgreso.Text = "Progreso Total"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(11, 146)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(170, 13)
        Me.lblSpeed.TabIndex = 2
        Me.lblSpeed.Text = "Velocidad de Descargar :  --- Kb/S"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 46)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(143, 13)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Descargando Archivo :  - - - -"
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(9, 21)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(128, 13)
        Me.lblAction.TabIndex = 4
        Me.lblAction.Text = "Operacion Actual :  - - - - -"
        '
        'Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 179)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblProgreso)
        Me.Controls.Add(Me.statusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Downloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProgreso As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAction As System.Windows.Forms.Label
End Class
