Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class CreditoyODC
#Region "PROPIEDADES DE CLASE"
    'PROPIEDADES DE CLASE
    Dim SAYC_settings As Object
#End Region
#Region "CONSTRUCTOR"
    'DEFINIMOS EL CONSTRUCTOR DE LA CLASE
    Sub New(setting As Object)
        Me.SAYC_settings = setting
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
#Region "METODOS DE CLASE"
    'METODO PARA UBICAR LAS CUENTAS HABIENTES
    Private Sub getAccount()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT id_cuenta,name_cuenta FROM cuenta")
        Dim dt = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr(1) = ""
        dr(0) = "Seleccione"
        dt.Rows.Add(dr)
        While consulta.read()
            dr = dt.NewRow()
            dr(1) = consulta(0)
            dr(0) = consulta(1)
            dt.Rows.Add(dr)
        End While
        'En Credito
        Me.cboxCuentaCredito.DataSource = dt
        Me.cboxCuentaCredito.ValueMember = "Value"
        Me.cboxCuentaCredito.DisplayMember = "Name"
        Me.cboxCuentaCredito.SelectedIndex = 0
        'En Orden de Compra
        Me.cboxCuentaODC.DataSource = dt
        Me.cboxCuentaODC.ValueMember = "Value"
        Me.cboxCuentaODC.DisplayMember = "Name"
        Me.cboxCuentaODC.SelectedIndex = 0
    End Sub
    'METODO PARA OBTENER LAS CUENTAS MONEY
    Private Sub getCC()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT id_cc,name_cc FROM perfiles_cc WHERE perfiles_cc.active = 1")
        Dim dt = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")
        While consulta.read()
            Dim dr As DataRow
            dr = dt.NewRow()
            dr(1) = consulta(0)
            dr(0) = consulta(1)
            dt.Rows.Add(dr)
        End While
        'EN CREDITO
        cboxCuentaMoneyCredito.DataSource = dt
        cboxCuentaMoneyCredito.DisplayMember = "Name"
        cboxCuentaMoneyCredito.ValueMember = "Value"
        cboxCuentaMoneyCredito.SelectedIndex = 0
        ' EN ODC
        cboxCuentaMoneyODC.DataSource = dt
        cboxCuentaMoneyODC.DisplayMember = "Name"
        cboxCuentaMoneyODC.ValueMember = "Value"
        cboxCuentaMoneyODC.SelectedIndex = 0
    End Sub
    'METODO PARA RESTABLECER LA PESTAÑA DE CREDITO
    Private Sub restaCredito()
        txtCuotaCredito.Text = Nothing
        txtMontoCredito.Text = Nothing
        txtMotivoCredito.Text = Nothing
        txtNameCredito.Text = Nothing
        txtTitularCredito.Text = Nothing
        cboxCuentaCredito.SelectedIndex = 0
    End Sub
    'METODO PARA OBTENER LOS PROVEEDORES DE ODC
    Private Sub getProveedorOdc()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT setting FROM configuraciones WHERE configuraciones.name='proveedorODC'")
        Dim dt = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr(1) = ""
        dr(0) = "Seleccione"
        dt.Rows.Add(dr)
        While consulta.read()
            Dim proveedor As JObject = JsonConvert.DeserializeObject(consulta(0))
            dr = dt.NewRow()
            dr(1) = proveedor.SelectToken("name")
            dr(0) = proveedor.SelectToken("name")
            dt.Rows.Add(dr)
        End While
        cboxProveedorOdc.DataSource = dt
        cboxProveedorOdc.DisplayMember = "Name"
        cboxProveedorOdc.ValueMember = "Value"
        cboxProveedorOdc.SelectedIndex = 0
    End Sub
    'METODO PARA RESTABLCECER ORDENES DE COMPRA
    Private Sub restaODC()
        txtDiasCobroODC.Text = Nothing
        txtNombreOdc.Text = Nothing
        txtTitularOdc.Text = Nothing
        txtValorOdc.Text = Nothing
        cboxCajaODC.SelectedIndex = 0
        cboxCuentaMoneyODC.SelectedIndex = 0
        cboxCuentaODC.SelectedIndex = 0
        cboxProveedorOdc.SelectedIndex = 0
        cboxTasaODC.SelectedIndex = 0
    End Sub
#End Region
#Region "METODOS PUBLICOS"
    'METODO PARA OBTENER LAS CUENTAS CREDITICIAS
    Public Sub getTasa()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT setting FROM configuraciones WHERE configuraciones.name='tasacredi'")
        Dim dt = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")
        While consulta.read()
            Dim tasa As JObject = JsonConvert.DeserializeObject(consulta(0))
            Dim dr As DataRow
            dr = dt.NewRow()
            dr(1) = consulta(0)
            dr(0) = tasa.SelectToken("name")
            dt.Rows.Add(dr)
        End While
        'EN CREDITO
        cboxTasaCrediticia.DataSource = dt
        cboxTasaCrediticia.DisplayMember = "Name"
        cboxTasaCrediticia.ValueMember = "Value"
        cboxTasaCrediticia.SelectedIndex = 0
        'EN ORDEN DE COMPRA
        cboxTasaODC.DataSource = dt
        cboxTasaODC.DisplayMember = "Name"
        cboxTasaODC.ValueMember = "Value"
        cboxTasaODC.SelectedIndex = 0
    End Sub
#End Region
#Region "EVENTOS DE CLASE"
    'EVENTO QUE MANEJA CARGA DEL FORMULARIO
    Private Sub CreditoyODC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.getAccount()
        Me.getCC()
        Me.getTasa()
        Me.getProveedorOdc()
    End Sub
    'EVENTO PARA MANJEAR EL BOTON DE SIMULAR
    Private Sub btnSimularCredito_Click(sender As Object, e As EventArgs) Handles btnSimularCredito.Click
        If IsNumeric(txtCuotaCredito.Text.Length) And IsNumeric(txtMontoCredito.Text) Then
            Dim interes As JObject = JsonConvert.DeserializeObject(cboxTasaCrediticia.SelectedValue)
            If interes.SelectToken("tipo").ToString = "simple" Then
                Dim numeroCuota As Integer = txtMontoCredito.Text / txtCuotaCredito.Text
                Dim creditoTotal As Integer = txtMontoCredito.Text * (CDbl(1) + CDbl(interes.SelectToken("tasa").ToString))
                Dim cuotasdiferencia As Integer = (creditoTotal - txtMontoCredito.Text) / txtCuotaCredito.Text
                lblMontoEsctimadoCredito.Text = creditoTotal
                lblCuotaEstimadaCredito.Text = (numeroCuota + cuotasdiferencia) & "Cuotas de " & txtCuotaCredito.Text
                lblCaeCredito.Text = ((creditoTotal / txtMontoCredito.Text) - 1) * 100 & "%"
            ElseIf interes.SelectToken("tipo") = "compuesto" Then
                Dim numeroCuota As Integer = txtMontoCredito.Text / txtCuotaCredito.Text
                Dim creditoTotal As Double = (txtMontoCredito.Text * (CDbl(1) + CDbl(interes.SelectToken("tasa").ToString))) * ((CDbl(1) + CDbl(interes.SelectToken("tasa").ToString)) ^ (numeroCuota / 20))
                Dim cuotasdiferencia As Integer = (creditoTotal - txtMontoCredito.Text) / txtCuotaCredito.Text
                lblMontoEsctimadoCredito.Text = creditoTotal
                lblCuotaEstimadaCredito.Text = (numeroCuota + cuotasdiferencia) & " Cuotas de $ " & txtCuotaCredito.Text
                lblCaeCredito.Text = ((creditoTotal / txtMontoCredito.Text) - 1) * 100 & "%"
            End If
        End If
    End Sub
    'BTN PARA MANEJAR ACTUALIZAR DATOS
    Private Sub btnActualizarCredito_Click(sender As Object, e As EventArgs) Handles btnActualizarCredito.Click
        If cboxCuentaCredito.SelectedIndex <> 0 And txtNameCredito.Text.Length > 0 And IsNumeric(txtMontoCredito.Text) And IsNumeric(txtCuotaCredito.Text) And txtMotivoCredito.Text.Length > 0 Then
            Dim interes As JObject = JsonConvert.DeserializeObject(cboxTasaCrediticia.SelectedValue)
            Dim valorInicial As Integer = (txtMontoCredito.Text * (CDbl(1) + CDbl(interes.SelectToken("tasa").ToString)))
            Dim interesAcumulado As Integer = valorInicial - txtMontoCredito.Text
            Me.SAYC_settings.db_opquery("INSERT INTO creditos (creditos.tipo,creditos.nombreReceptor,creditos.id_cuenta,creditos.id_cc,creditos.fecha_emision,creditos.fechainteres,creditos.valor_cuota,creditos.interes,creditos.valor_acumulado,creditos.monto_inicial,creditos.interes_acumulado,creditos.detalle,creditos.estado) VALUES ('credito','" & txtNameCredito.Text & "','" & cboxCuentaCredito.SelectedValue & "','" & cboxCuentaMoneyCredito.SelectedValue & "', '" & dpickerFechaCredito.Value.ToString("dd-MM-yyyy") & "','" & dpickerFechaCredito.Value.ToString("dd-MM-yyyy") & "','" & txtCuotaCredito.Text & "', '" & cboxTasaCrediticia.SelectedValue & "','" & valorInicial & "', '" & txtMontoCredito.Text & "', '" & interesAcumulado & "', '" & txtMotivoCredito.Text & "', '0')")
            MessageBox.Show("Solicitud de credito emitida con exito")
            Me.restaCredito()
        End If
    End Sub
    'EVENTO PARA MANEJAR EL BOTON RESTABLECER CREDITO
    Private Sub btnRestablecerCredito_Click(sender As Object, e As EventArgs) Handles btnRestablecerCredito.Click
        Me.restaCredito()
    End Sub
    'MANEJADORES DE LOS EVENTOS DE CAMBIO DE CUENTA CREDITO
    Private Sub cboxCuentaCredito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCuentaCredito.SelectedIndexChanged
        If cboxCuentaCredito.SelectedIndex <> 0 Then
            Dim consulta As Object = Me.SAYC_settings.db_query("SELECT responsable FROM cuenta WHERE cuenta.id_cuenta='" & cboxCuentaCredito.SelectedValue & "'")
            consulta.read()
            txtTitularCredito.Text = consulta(0)
        End If
    End Sub
    'MANEJADORES DE LOS EVENTOS DE CAMBIO DE CUENTA ODC
    Private Sub cboxCuentaODC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCuentaODC.SelectedIndexChanged
        If cboxCuentaODC.SelectedIndex <> 0 Then
            Dim consulta As Object = Me.SAYC_settings.db_query("SELECT responsable FROM cuenta WHERE cuenta.id_cuenta='" & cboxCuentaCredito.SelectedValue & "'")
            consulta.read()
            txtTitularOdc.Text = consulta(0)
        End If
    End Sub
    'MANEJADOR DEL GRID EDIT EN ODC
    Private Sub dgridDetalleOdc_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgridDetalleOdc.CellEndEdit
        If IsNumeric(dgridDetalleOdc.Rows(e.RowIndex).Cells(1).Value) And dgridDetalleOdc.Rows(e.RowIndex).Cells(1).Value > 0 And dgridDetalleOdc.Rows(e.RowIndex).Cells(0).Value <> "" Then
            Dim total As Integer = 0
            For Each vector As DataGridViewRow In dgridDetalleOdc.Rows
                total += vector.Cells(1).Value
            Next
            txtValorOdc.Text = total
        Else
            MessageBox.Show("Debe completar ambos datos de forma correcta. 1ero el detalle y luego el valor")
        End If
    End Sub
    'MANEJADOR DEL BOTON ACTUALIZAR EN ODC
    Private Sub btnActualizarOdc_Click(sender As Object, e As EventArgs) Handles btnActualizarOdc.Click
        If Me.SAYC_settings.adminOnly() And IsNumeric(txtDiasCobroODC.Text) And txtDiasCobroODC.Text > 0 And txtNombreOdc.Text.Length > 0 And txtTitularOdc.Text.Length > 0 And IsNumeric(txtValorOdc.Text) And txtValorOdc.Text > 0 Then
            Dim items(dgridDetalleOdc.Rows.Count - 1) As item
            Dim puntero As Integer = 0
            For Each vector As DataGridViewRow In dgridDetalleOdc.Rows
                items(puntero) = New item(vector.Cells(0).Value, vector.Cells(1).Value)
            Next
            Dim egreso(0) As item
            egreso(0) = New item("Orden de compra cancelada. Movil: " & cboxCuentaODC.SelectedValue, txtValorOdc.Text)
            Me.SAYC_settings.db_opquery("INSERT INTO creditos (creditos.tipo,creditos.nombreReceptor,creditos.id_cuenta,creditos.id_cc,creditos.fecha_emision,creditos.fechainteres,creditos.valor_cuota,creditos.interes,creditos.valor_acumulado,creditos.monto_inicial,creditos.interes_acumulado,creditos.detalle,creditos.estado) VALUES ('ODC','" & txtNombreOdc.Text & "','" & cboxCuentaODC.SelectedValue & "','" & cboxCuentaMoneyODC.SelectedValue & "', '" & dpickerFechaOdc.Value.ToString("dd-MM-yyyy") & "','" & dpickerFechaOdc.Value.ToString("dd-MM-yyyy") & "','0', '" & cboxTasaODC.SelectedValue & "','" & txtValorOdc.Text & "', '" & txtValorOdc.Text & "', '0', '" & JsonConvert.SerializeObject(items) & "', '1')")
            Me.SAYC_settings.db_opquery("INSERT INTO ie_reg (ie_reg.tipo,ie_reg.caja,ie_reg.id_cc,ie_reg.fecha,ie_reg.item,ie_reg.monto) VALUES ('Egreso','" & cboxCajaODC.SelectedItem & "', '" & cboxCuentaMoneyODC.SelectedValue & "', '" & dpickerFechaOdc.Value.ToString("dd-MM-yyyy") & "', '" & JsonConvert.SerializeObject(egreso) & "', '" & txtValorOdc.Text & "')")
            MessageBox.Show("Orden de compra emitida con exito")
            Me.restaODC()
        End If
    End Sub
    'MANEJADOR DEL BOTON RESTABLECER EN ODC
    Private Sub btnRestablecerOdc_Click(sender As Object, e As EventArgs) Handles btnRestablecerOdc.Click
        Me.restaODC()
    End Sub
    'MANEJADOR DEL CLICK EN CONFIG TASAS
    Private Sub TazasCrediticiasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TazasCrediticiasToolStripMenuItem.Click
        Dim tasa As New tasaCrediticia(Me, Me.SAYC_settings)
        tasa.ShowDialog()
    End Sub
    'MANEJADOR DEL CLICK EN ADMIN PROVEEDOR
    Private Sub AdministrarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarProveedoresToolStripMenuItem.Click
        Dim proveedor As New adminProveedores(Me, Me.SAYC_settings)
        proveedor.ShowDialog()
    End Sub
#End Region
End Class