Public Class OtrosPagos
#Region "PROPIEDADES DE CLASE"
    Private Sayc_Settings As Object
    Private users As String = Nothing
    Private account As String = Nothing
#End Region
#Region "CONSTRUCTOR"
    Sub New(obj As Object)
        Me.Sayc_Settings = obj
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
#End Region
#Region "METODOS DE CLASE"
    'METODO PARA OBTENER LAS CUENTAS MONETARIAS
    Private Sub getCuentasCC()
        Dim consulta As Object = Me.Sayc_Settings.db_query("SELECT id_cc,name_cc FROM perfiles_cc WHERE perfiles_cc.active = 1")
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
        Me.cboxCuentaMonetaria.DataSource = dt
        Me.cboxCuentaMonetaria.ValueMember = "Value"
        Me.cboxCuentaMonetaria.DisplayMember = "Name"
        Me.cboxCuentaMonetaria.SelectedIndex = 0
    End Sub
    Private Sub setRecurrencia()
        Dim dt = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")
        Dim dr As DataRow
        Dim dl As DataRow
        Dim dg As DataRow
        Dim dh As DataRow
        Dim dj As DataRow
        dr = dt.NewRow()
        dr(1) = "once"
        dr(0) = "Solo una vez"
        dt.Rows.Add(dr)
        dl = dt.NewRow()
        dl(1) = "day"
        dl(0) = "Todos los dias"
        dt.Rows.Add(dl)
        dg = dt.NewRow()
        dg(1) = "week"
        dg(0) = "Todas las semanas"
        dt.Rows.Add(dg)
        dh = dt.NewRow()
        dh(1) = "month"
        dh(0) = "Todos los meses"
        dt.Rows.Add(dh)
        dj = dt.NewRow()
        dj(1) = "year"
        dj(0) = "Al comienzo de cada año"
        dt.Rows.Add(dj)
        Me.cboxRecurrenciaPago.DataSource = dt
        Me.cboxRecurrenciaPago.ValueMember = "Value"
        Me.cboxRecurrenciaPago.DisplayMember = "Name"
        cboxRecurrenciaPago.SelectedIndex = 0
    End Sub
#End Region
#Region "METODOS PUBLICOS"
    'METODO PARA SETEAR LOS USERS DESDE LOS OTROS FORMS
    Public Sub setUsers(users As String)
        Me.users = users
    End Sub
    'METODO PARA SETEAR LOS ACCOUNTS DESDE LOS OTROS FORMS
    Public Sub setAccount(account As String)
        Me.account = account
    End Sub
#End Region
#Region "EVENTOS DE CLASE"
    'EVENTO QUE MANEJA LA ACTIVACION DE LOS DIAS
    Private Sub checkCredito_CheckedChanged(sender As Object, e As EventArgs) Handles checkCredito.CheckedChanged
        If checkCredito.Checked Then
            Me.txtDaysCredito.Enabled = True
        Else
            Me.txtDaysCredito.Enabled = False
        End If
    End Sub
    'EVENTO QUE MANEJA LA ACTIVACION DE BOTONES SEGUN SELECCION DEL CBOX
    Private Sub cboxHabienteDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxHabienteDestino.SelectedIndexChanged
        If cboxHabienteDestino.SelectedIndex = 0 Then
            Me.btnCuentas.Enabled = True
            Me.btnUsers.Enabled = True
        Else
            Me.btnCuentas.Enabled = False
            Me.btnUsers.Enabled = False
        End If
    End Sub
    'EVENTO QUE MANEJA LA APERTURA DE LOS BOTONES DE CUENTAS Y USUARIOS
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim users As New addUsers(Me.Sayc_Settings, Me, Me.users)
        users.ShowDialog()
    End Sub
    'EVENTO PARA ,ANEJAR EL AGREGADO DE CUENTAS
    Private Sub btnCuentas_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        Dim account As New addAccount(Me.Sayc_Settings, Me, Me.account)
        account.ShowDialog()
    End Sub
    'EVENTO PARA MANEJAR EL BOTON ACTUALIZAR DATOS
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.Sayc_Settings.openActivity()
        Dim licencia As String
        Dim cuentas As String = ""
        Dim usuario As String = ""
        If checkLicencia.Checked Then
            licencia = "1"
        Else
            licencia = "0"
        End If
        If Me.account <> Nothing Then
            cuentas = Me.account
        End If
        If Me.users <> Nothing Then
            usuario = Me.users
        End If
        If Me.checkCredito.Checked Then
            If Me.Sayc_Settings.securityVerify(Me.Sayc_Settings.internalCore.newPago(Me.Sayc_Settings.db_target, Me.Sayc_Settings.db_user, Me.Sayc_Settings.db_pass, Me.Sayc_Settings.token, Me.txtNamePago.Text, Me.txtValorPago.Text, Me.cboxCuentaMonetaria.SelectedValue, Me.cboxRecurrenciaPago.SelectedValue, "true", Me.txtDaysCredito.Text, Me.txtCuotaRecurrente.Text, usuario, cuentas, licencia)) = "true" Then
                MessageBox.Show("Pago agregado con exito")
            End If
        Else
            If Me.Sayc_Settings.securityVerify(Me.Sayc_Settings.internalCore.newPago(Me.Sayc_Settings.db_target, Me.Sayc_Settings.db_user, Me.Sayc_Settings.db_pass, Me.Sayc_Settings.token, Me.txtNamePago.Text, Me.txtValorPago.Text, Me.cboxCuentaMonetaria.SelectedValue, Me.cboxRecurrenciaPago.SelectedValue, "false", Me.txtDaysCredito.Text, Me.txtCuotaRecurrente.Text, usuario, cuentas, licencia)) = "true" Then
                MessageBox.Show("Pago agregado con exito")
            End If
        End If
        Me.Sayc_Settings.closeActivity()
    End Sub
    'EVENTO DE CARGA DEL FORMULARIO
    Private Sub OtrosPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.getCuentasCC()
        Me.setRecurrencia()
        Me.cboxHabienteDestino.SelectedIndex = 0
    End Sub
    'MANEJAMOS EL EVENTO DE RECURRENCIA
    Private Sub cboxRecurrenciaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxRecurrenciaPago.SelectedIndexChanged
        If Me.cboxRecurrenciaPago.SelectedIndex <> 0 Then
            Me.txtCuotaRecurrente.Enabled = True
        Else
            Me.txtCuotaRecurrente.Enabled = False
        End If
    End Sub
#End Region
End Class