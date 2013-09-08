<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditoyODC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreditoyODC))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarSolicitudesPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarOrdenesDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TazasCrediticiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Credito = New System.Windows.Forms.TabPage()
        Me.btnRestablecerCredito = New System.Windows.Forms.Button()
        Me.btnActualizarCredito = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSimularCredito = New System.Windows.Forms.Button()
        Me.lblCaeCredito = New System.Windows.Forms.Label()
        Me.lblCuotaEstimadaCredito = New System.Windows.Forms.Label()
        Me.lblMontoEsctimadoCredito = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboxCuentaMoneyCredito = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCuotaCredito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboxTasaCrediticia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMontoCredito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMotivoCredito = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNameCredito = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpickerFechaCredito = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxCuentaCredito = New System.Windows.Forms.ComboBox()
        Me.txtTitularCredito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ocompra = New System.Windows.Forms.TabPage()
        Me.btnRestablecerOdc = New System.Windows.Forms.Button()
        Me.btnActualizarOdc = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboxCajaODC = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboxCuentaMoneyODC = New System.Windows.Forms.ComboBox()
        Me.cboxTasaODC = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDiasCobroODC = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtValorOdc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboxProveedorOdc = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombreOdc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dpickerFechaOdc = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboxCuentaODC = New System.Windows.Forms.ComboBox()
        Me.txtTitularOdc = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgridDetalleOdc = New System.Windows.Forms.DataGridView()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorOdc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Credito.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ocompra.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgridDetalleOdc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarSolicitudesPendientesToolStripMenuItem, Me.AdministrarOrdenesDeCompraToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Image = CType(resources.GetObject("OperacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'VisualizarSolicitudesPendientesToolStripMenuItem
        '
        Me.VisualizarSolicitudesPendientesToolStripMenuItem.Image = CType(resources.GetObject("VisualizarSolicitudesPendientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VisualizarSolicitudesPendientesToolStripMenuItem.Name = "VisualizarSolicitudesPendientesToolStripMenuItem"
        Me.VisualizarSolicitudesPendientesToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.VisualizarSolicitudesPendientesToolStripMenuItem.Text = "Visualizar Solicitudes y Creditos"
        '
        'AdministrarOrdenesDeCompraToolStripMenuItem
        '
        Me.AdministrarOrdenesDeCompraToolStripMenuItem.Image = CType(resources.GetObject("AdministrarOrdenesDeCompraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdministrarOrdenesDeCompraToolStripMenuItem.Name = "AdministrarOrdenesDeCompraToolStripMenuItem"
        Me.AdministrarOrdenesDeCompraToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.AdministrarOrdenesDeCompraToolStripMenuItem.Text = "Administrar Ordenes de Compra"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TazasCrediticiasToolStripMenuItem, Me.AdministrarProveedoresToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Image = CType(resources.GetObject("OpcionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'TazasCrediticiasToolStripMenuItem
        '
        Me.TazasCrediticiasToolStripMenuItem.Image = CType(resources.GetObject("TazasCrediticiasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TazasCrediticiasToolStripMenuItem.Name = "TazasCrediticiasToolStripMenuItem"
        Me.TazasCrediticiasToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.TazasCrediticiasToolStripMenuItem.Text = "Tazas Crediticias"
        '
        'AdministrarProveedoresToolStripMenuItem
        '
        Me.AdministrarProveedoresToolStripMenuItem.Image = CType(resources.GetObject("AdministrarProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdministrarProveedoresToolStripMenuItem.Name = "AdministrarProveedoresToolStripMenuItem"
        Me.AdministrarProveedoresToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AdministrarProveedoresToolStripMenuItem.Text = "Administrar proveedores"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Credito)
        Me.TabControl1.Controls.Add(Me.ocompra)
        Me.TabControl1.Location = New System.Drawing.Point(13, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(687, 628)
        Me.TabControl1.TabIndex = 1
        '
        'Credito
        '
        Me.Credito.Controls.Add(Me.btnRestablecerCredito)
        Me.Credito.Controls.Add(Me.btnActualizarCredito)
        Me.Credito.Controls.Add(Me.GroupBox2)
        Me.Credito.Controls.Add(Me.GroupBox1)
        Me.Credito.Location = New System.Drawing.Point(4, 22)
        Me.Credito.Name = "Credito"
        Me.Credito.Padding = New System.Windows.Forms.Padding(3)
        Me.Credito.Size = New System.Drawing.Size(679, 602)
        Me.Credito.TabIndex = 0
        Me.Credito.Text = "Emisor de Creditos"
        Me.Credito.UseVisualStyleBackColor = True
        '
        'btnRestablecerCredito
        '
        Me.btnRestablecerCredito.Image = CType(resources.GetObject("btnRestablecerCredito.Image"), System.Drawing.Image)
        Me.btnRestablecerCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecerCredito.Location = New System.Drawing.Point(244, 536)
        Me.btnRestablecerCredito.Name = "btnRestablecerCredito"
        Me.btnRestablecerCredito.Size = New System.Drawing.Size(219, 49)
        Me.btnRestablecerCredito.TabIndex = 5
        Me.btnRestablecerCredito.Text = "Restablecer"
        Me.btnRestablecerCredito.UseVisualStyleBackColor = True
        '
        'btnActualizarCredito
        '
        Me.btnActualizarCredito.Image = CType(resources.GetObject("btnActualizarCredito.Image"), System.Drawing.Image)
        Me.btnActualizarCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarCredito.Location = New System.Drawing.Point(6, 536)
        Me.btnActualizarCredito.Name = "btnActualizarCredito"
        Me.btnActualizarCredito.Size = New System.Drawing.Size(219, 49)
        Me.btnActualizarCredito.TabIndex = 4
        Me.btnActualizarCredito.Text = "Actualizar Datos"
        Me.btnActualizarCredito.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSimularCredito)
        Me.GroupBox2.Controls.Add(Me.lblCaeCredito)
        Me.GroupBox2.Controls.Add(Me.lblCuotaEstimadaCredito)
        Me.GroupBox2.Controls.Add(Me.lblMontoEsctimadoCredito)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cboxCuentaMoneyCredito)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCuotaCredito)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboxTasaCrediticia)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtMontoCredito)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(666, 299)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Variables de Credito"
        '
        'btnSimularCredito
        '
        Me.btnSimularCredito.Image = CType(resources.GetObject("btnSimularCredito.Image"), System.Drawing.Image)
        Me.btnSimularCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimularCredito.Location = New System.Drawing.Point(481, 139)
        Me.btnSimularCredito.Name = "btnSimularCredito"
        Me.btnSimularCredito.Size = New System.Drawing.Size(93, 23)
        Me.btnSimularCredito.TabIndex = 25
        Me.btnSimularCredito.Text = "Simular"
        Me.btnSimularCredito.UseVisualStyleBackColor = True
        '
        'lblCaeCredito
        '
        Me.lblCaeCredito.AutoSize = True
        Me.lblCaeCredito.Location = New System.Drawing.Point(153, 244)
        Me.lblCaeCredito.Name = "lblCaeCredito"
        Me.lblCaeCredito.Size = New System.Drawing.Size(128, 13)
        Me.lblCaeCredito.TabIndex = 24
        Me.lblCaeCredito.Text = "Porcentaje real de credito"
        '
        'lblCuotaEstimadaCredito
        '
        Me.lblCuotaEstimadaCredito.AutoSize = True
        Me.lblCuotaEstimadaCredito.Location = New System.Drawing.Point(153, 210)
        Me.lblCuotaEstimadaCredito.Name = "lblCuotaEstimadaCredito"
        Me.lblCuotaEstimadaCredito.Size = New System.Drawing.Size(108, 13)
        Me.lblCuotaEstimadaCredito.TabIndex = 23
        Me.lblCuotaEstimadaCredito.Text = "Estimacion de cuotas"
        '
        'lblMontoEsctimadoCredito
        '
        Me.lblMontoEsctimadoCredito.AutoSize = True
        Me.lblMontoEsctimadoCredito.Location = New System.Drawing.Point(153, 176)
        Me.lblMontoEsctimadoCredito.Name = "lblMontoEsctimadoCredito"
        Me.lblMontoEsctimadoCredito.Size = New System.Drawing.Size(83, 13)
        Me.lblMontoEsctimadoCredito.TabIndex = 22
        Me.lblMontoEsctimadoCredito.Text = "Monto Simulado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(107, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "CAE :"
        '
        'cboxCuentaMoneyCredito
        '
        Me.cboxCuentaMoneyCredito.FormattingEnabled = True
        Me.cboxCuentaMoneyCredito.Location = New System.Drawing.Point(156, 37)
        Me.cboxCuentaMoneyCredito.Name = "cboxCuentaMoneyCredito"
        Me.cboxCuentaMoneyCredito.Size = New System.Drawing.Size(318, 21)
        Me.cboxCuentaMoneyCredito.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Cuenta Monetaria :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(266, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Cuotas Estimadas :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(153, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Monto Simulado Estimado :"
        '
        'txtCuotaCredito
        '
        Me.txtCuotaCredito.Location = New System.Drawing.Point(156, 139)
        Me.txtCuotaCredito.Name = "txtCuotaCredito"
        Me.txtCuotaCredito.Size = New System.Drawing.Size(318, 20)
        Me.txtCuotaCredito.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cuota Estimada :"
        '
        'cboxTasaCrediticia
        '
        Me.cboxTasaCrediticia.FormattingEnabled = True
        Me.cboxTasaCrediticia.Location = New System.Drawing.Point(156, 105)
        Me.cboxTasaCrediticia.Name = "cboxTasaCrediticia"
        Me.cboxTasaCrediticia.Size = New System.Drawing.Size(318, 21)
        Me.cboxTasaCrediticia.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tasa Crediticia :"
        '
        'txtMontoCredito
        '
        Me.txtMontoCredito.Location = New System.Drawing.Point(156, 71)
        Me.txtMontoCredito.Name = "txtMontoCredito"
        Me.txtMontoCredito.Size = New System.Drawing.Size(318, 20)
        Me.txtMontoCredito.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Monto a Solicitar :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtMotivoCredito)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNameCredito)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dpickerFechaCredito)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboxCuentaCredito)
        Me.GroupBox1.Controls.Add(Me.txtTitularCredito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Emision de solcitud de credito"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(96, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Motivo :"
        '
        'txtMotivoCredito
        '
        Me.txtMotivoCredito.Location = New System.Drawing.Point(156, 151)
        Me.txtMotivoCredito.Name = "txtMotivoCredito"
        Me.txtMotivoCredito.Size = New System.Drawing.Size(318, 20)
        Me.txtMotivoCredito.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre del Solicitante :"
        '
        'txtNameCredito
        '
        Me.txtNameCredito.Location = New System.Drawing.Point(156, 121)
        Me.txtNameCredito.Name = "txtNameCredito"
        Me.txtNameCredito.Size = New System.Drawing.Size(318, 20)
        Me.txtNameCredito.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre del Titular :"
        '
        'dpickerFechaCredito
        '
        Me.dpickerFechaCredito.Location = New System.Drawing.Point(156, 62)
        Me.dpickerFechaCredito.Name = "dpickerFechaCredito"
        Me.dpickerFechaCredito.Size = New System.Drawing.Size(318, 20)
        Me.dpickerFechaCredito.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha de Solicitud :"
        '
        'cboxCuentaCredito
        '
        Me.cboxCuentaCredito.FormattingEnabled = True
        Me.cboxCuentaCredito.Location = New System.Drawing.Point(156, 31)
        Me.cboxCuentaCredito.Name = "cboxCuentaCredito"
        Me.cboxCuentaCredito.Size = New System.Drawing.Size(318, 21)
        Me.cboxCuentaCredito.TabIndex = 2
        '
        'txtTitularCredito
        '
        Me.txtTitularCredito.Enabled = False
        Me.txtTitularCredito.Location = New System.Drawing.Point(156, 92)
        Me.txtTitularCredito.Name = "txtTitularCredito"
        Me.txtTitularCredito.Size = New System.Drawing.Size(318, 20)
        Me.txtTitularCredito.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta Habiente :"
        '
        'ocompra
        '
        Me.ocompra.Controls.Add(Me.btnRestablecerOdc)
        Me.ocompra.Controls.Add(Me.btnActualizarOdc)
        Me.ocompra.Controls.Add(Me.GroupBox3)
        Me.ocompra.Controls.Add(Me.GroupBox4)
        Me.ocompra.Location = New System.Drawing.Point(4, 22)
        Me.ocompra.Name = "ocompra"
        Me.ocompra.Padding = New System.Windows.Forms.Padding(3)
        Me.ocompra.Size = New System.Drawing.Size(679, 602)
        Me.ocompra.TabIndex = 1
        Me.ocompra.Text = "Ordenes de Compra"
        Me.ocompra.UseVisualStyleBackColor = True
        '
        'btnRestablecerOdc
        '
        Me.btnRestablecerOdc.Image = CType(resources.GetObject("btnRestablecerOdc.Image"), System.Drawing.Image)
        Me.btnRestablecerOdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestablecerOdc.Location = New System.Drawing.Point(231, 539)
        Me.btnRestablecerOdc.Name = "btnRestablecerOdc"
        Me.btnRestablecerOdc.Size = New System.Drawing.Size(219, 49)
        Me.btnRestablecerOdc.TabIndex = 7
        Me.btnRestablecerOdc.Text = "Restablecer"
        Me.btnRestablecerOdc.UseVisualStyleBackColor = True
        '
        'btnActualizarOdc
        '
        Me.btnActualizarOdc.Image = CType(resources.GetObject("btnActualizarOdc.Image"), System.Drawing.Image)
        Me.btnActualizarOdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarOdc.Location = New System.Drawing.Point(6, 539)
        Me.btnActualizarOdc.Name = "btnActualizarOdc"
        Me.btnActualizarOdc.Size = New System.Drawing.Size(219, 49)
        Me.btnActualizarOdc.TabIndex = 6
        Me.btnActualizarOdc.Text = "Actualizar Datos"
        Me.btnActualizarOdc.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.cboxCajaODC)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.cboxCuentaMoneyODC)
        Me.GroupBox3.Controls.Add(Me.cboxTasaODC)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtDiasCobroODC)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtValorOdc)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.cboxProveedorOdc)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtNombreOdc)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dpickerFechaOdc)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.cboxCuentaODC)
        Me.GroupBox3.Controls.Add(Me.txtTitularOdc)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(666, 330)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Emision de Orden de Compra"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(57, 202)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 13)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Caja de Salida :"
        '
        'cboxCajaODC
        '
        Me.cboxCajaODC.FormattingEnabled = True
        Me.cboxCajaODC.Items.AddRange(New Object() {"Caja Interna", "Caja Recaudacion"})
        Me.cboxCajaODC.Location = New System.Drawing.Point(156, 200)
        Me.cboxCajaODC.Name = "cboxCajaODC"
        Me.cboxCajaODC.Size = New System.Drawing.Size(318, 21)
        Me.cboxCajaODC.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(44, 175)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(97, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Cuenta Monetaria :"
        '
        'cboxCuentaMoneyODC
        '
        Me.cboxCuentaMoneyODC.FormattingEnabled = True
        Me.cboxCuentaMoneyODC.Location = New System.Drawing.Point(156, 172)
        Me.cboxCuentaMoneyODC.Name = "cboxCuentaMoneyODC"
        Me.cboxCuentaMoneyODC.Size = New System.Drawing.Size(318, 21)
        Me.cboxCuentaMoneyODC.TabIndex = 17
        '
        'cboxTasaODC
        '
        Me.cboxTasaODC.FormattingEnabled = True
        Me.cboxTasaODC.Location = New System.Drawing.Point(156, 281)
        Me.cboxTasaODC.Name = "cboxTasaODC"
        Me.cboxTasaODC.Size = New System.Drawing.Size(318, 21)
        Me.cboxTasaODC.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(57, 285)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Tasa Crediticia :"
        '
        'txtDiasCobroODC
        '
        Me.txtDiasCobroODC.Enabled = False
        Me.txtDiasCobroODC.Location = New System.Drawing.Point(156, 255)
        Me.txtDiasCobroODC.Name = "txtDiasCobroODC"
        Me.txtDiasCobroODC.Size = New System.Drawing.Size(318, 20)
        Me.txtDiasCobroODC.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 257)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Dias Antes de 1er cobro :"
        '
        'txtValorOdc
        '
        Me.txtValorOdc.Enabled = False
        Me.txtValorOdc.Location = New System.Drawing.Point(156, 227)
        Me.txtValorOdc.Name = "txtValorOdc"
        Me.txtValorOdc.Size = New System.Drawing.Size(318, 20)
        Me.txtValorOdc.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(45, 229)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Valor del Servicio :"
        '
        'cboxProveedorOdc
        '
        Me.cboxProveedorOdc.FormattingEnabled = True
        Me.cboxProveedorOdc.Location = New System.Drawing.Point(156, 145)
        Me.cboxProveedorOdc.Name = "cboxProveedorOdc"
        Me.cboxProveedorOdc.Size = New System.Drawing.Size(318, 21)
        Me.cboxProveedorOdc.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Proveedor de Servicio :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Nombre del Solicitante :"
        '
        'txtNombreOdc
        '
        Me.txtNombreOdc.Location = New System.Drawing.Point(156, 117)
        Me.txtNombreOdc.Name = "txtNombreOdc"
        Me.txtNombreOdc.Size = New System.Drawing.Size(318, 20)
        Me.txtNombreOdc.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(41, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Nombre del Titular :"
        '
        'dpickerFechaOdc
        '
        Me.dpickerFechaOdc.Location = New System.Drawing.Point(156, 62)
        Me.dpickerFechaOdc.Name = "dpickerFechaOdc"
        Me.dpickerFechaOdc.Size = New System.Drawing.Size(318, 20)
        Me.dpickerFechaOdc.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Fecha de Solicitud :"
        '
        'cboxCuentaODC
        '
        Me.cboxCuentaODC.FormattingEnabled = True
        Me.cboxCuentaODC.Location = New System.Drawing.Point(156, 31)
        Me.cboxCuentaODC.Name = "cboxCuentaODC"
        Me.cboxCuentaODC.Size = New System.Drawing.Size(318, 21)
        Me.cboxCuentaODC.TabIndex = 2
        '
        'txtTitularOdc
        '
        Me.txtTitularOdc.Enabled = False
        Me.txtTitularOdc.Location = New System.Drawing.Point(156, 88)
        Me.txtTitularOdc.Name = "txtTitularOdc"
        Me.txtTitularOdc.Size = New System.Drawing.Size(318, 20)
        Me.txtTitularOdc.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(48, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Cuenta Habiente :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgridDetalleOdc)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 342)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(666, 183)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de la orden de Compra"
        '
        'dgridDetalleOdc
        '
        Me.dgridDetalleOdc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridDetalleOdc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.detalle, Me.valorOdc})
        Me.dgridDetalleOdc.Location = New System.Drawing.Point(25, 29)
        Me.dgridDetalleOdc.Name = "dgridDetalleOdc"
        Me.dgridDetalleOdc.Size = New System.Drawing.Size(616, 134)
        Me.dgridDetalleOdc.TabIndex = 5
        '
        'detalle
        '
        Me.detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.detalle.FillWeight = 200.0!
        Me.detalle.HeaderText = "Detalle del Item"
        Me.detalle.Name = "detalle"
        '
        'valorOdc
        '
        Me.valorOdc.HeaderText = "Valor de Item"
        Me.valorOdc.Name = "valorOdc"
        Me.valorOdc.Width = 170
        '
        'CreditoyODC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 677)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CreditoyODC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credito y Ordenes de Compra"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Credito.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ocompra.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgridDetalleOdc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizarSolicitudesPendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarOrdenesDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Credito As System.Windows.Forms.TabPage
    Friend WithEvents ocompra As System.Windows.Forms.TabPage
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TazasCrediticiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRestablecerCredito As System.Windows.Forms.Button
    Friend WithEvents btnActualizarCredito As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboxCuentaMoneyCredito As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCuotaCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboxTasaCrediticia As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNameCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpickerFechaCredito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxCuentaCredito As System.Windows.Forms.ComboBox
    Friend WithEvents txtTitularCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNombreOdc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dpickerFechaOdc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboxCuentaODC As System.Windows.Forms.ComboBox
    Friend WithEvents txtTitularOdc As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboxProveedorOdc As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtValorOdc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgridDetalleOdc As System.Windows.Forms.DataGridView
    Friend WithEvents btnRestablecerOdc As System.Windows.Forms.Button
    Friend WithEvents btnActualizarOdc As System.Windows.Forms.Button
    Friend WithEvents detalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valorOdc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCaeCredito As System.Windows.Forms.Label
    Friend WithEvents lblCuotaEstimadaCredito As System.Windows.Forms.Label
    Friend WithEvents lblMontoEsctimadoCredito As System.Windows.Forms.Label
    Friend WithEvents btnSimularCredito As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMotivoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasCobroODC As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboxTasaODC As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboxCuentaMoneyODC As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboxCajaODC As System.Windows.Forms.ComboBox
End Class
