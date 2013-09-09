Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class AdminCuentas
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
    'METODO PARA OBTENER LAS CUENTAS
    Private Sub refreshAccount()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT id_cuenta, name_cuenta FROM cuenta ORDER BY name_cuenta")
        Dim dt = New DataTable("Tabla")
        dt.Columns.Add("Value")
        dt.Columns.Add("Name")
        Dim dl As DataRow
        dl = dt.NewRow()
        dl(0) = 0
        dl(1) = "Seleccione"
        dt.Rows.Add(dl)
        While consulta.read()
            dl = dt.NewRow()
            dl(0) = consulta(0)
            dl(1) = consulta(1)
            dt.Rows.Add(dl)
        End While
        cboxCuenta.ValueMember = "Value"
        cboxCuenta.DisplayMember = "Name"
        cboxCuenta.ValueMember = "Value"
        cboxCuentaAsignar.DisplayMember = "Name"
        cboxCuentaAsignar.ValueMember = "Value"
        cboxCuentaAsignar.DataSource = dt
        cboxCuenta.DataSource = dt
        cboxCuenta.SelectedIndex = 0
        cboxCuentaAsignar.SelectedIndex = 0
    End Sub
    'METODO PARA OBTENER LOS USUARIOS ASOCIADOS A LA EMPRESA
    Private Sub getUsers()
        Dim consulta As JArray = JsonConvert.DeserializeObject(Me.SAYC_settings.securityVerify(Me.SAYC_settings.internalCore.getUser(Me.SAYC_settings.db_target, Me.SAYC_settings.db_user, Me.SAYC_settings.db_pass, Me.SAYC_settings.token, Me.SAYC_settings.getIdCompany())))
        Dim dt = New DataTable("Tabla")
        dt.Columns.Add("Value")
        dt.Columns.Add("Name")
        Dim dl As DataRow
        dl = dt.NewRow()
        dl(0) = 0
        dl(1) = "Seleccione"
        dt.Rows.Add(dl)
        For Each vector As JObject In consulta
            dl = dt.NewRow()
            dl(0) = vector.SelectToken("user_id")
            dl(1) = vector.SelectToken("name")
            dt.Rows.Add(dl)
        Next
        Me.cboxUsuarios.ValueMember = "Value"
        Me.cboxUsuarios.DisplayMember = "Name"
        Me.cboxUsuarios.DataSource = dt
        Me.cboxUsuarios.SelectedIndex = 0
    End Sub
    'METODO PARA OBTENER LOS PRIVILEGIOS EXISTENTES
    Private Sub getPerfiles()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT id_perfil, name_perfil FROM tipo_perfil WHERE tipo_perfil.status='1'")
        Dim dt = New DataTable("Tabla")
        dt.Columns.Add("Value")
        dt.Columns.Add("Name")
        Dim dl As DataRow
        dl = dt.NewRow()
        dl(0) = 0
        dl(1) = "Seleccione"
        dt.Rows.Add(dl)
        While consulta.read()
            dl = dt.NewRow()
            dl(0) = consulta(0)
            dl(1) = consulta(1)
            dt.Rows.Add(dl)
        End While
        Me.cboxPerfilPago.DataSource = dt
        Me.cboxPerfilPago.ValueMember = "Value"
        Me.cboxPerfilPago.DisplayMember = "Name"
        Me.cboxPerfilPago.SelectedIndex = 0
    End Sub
    'METODO PARA DETECTAR SI UNA CUENTA ESTA REPETIDA
    Private Function checkRepeat(txtNameCuenta As String) As Boolean
        If cboxCuenta.Items.Count > 1 Then
            For Each vector As DataRowView In cboxCuenta.Items
                If vector.Item(1) = Me.txtNameCuenta.Text Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    'METODO PARA RESTBLACER LA CREACION DE CUENTAS
    Private Sub restablacerCreacion()
        Me.refreshAccount()
        Me.cboxAccion.SelectedIndex = 0
        Me.cboxCuenta.SelectedIndex = 0
        Me.txtNameCuenta.Text = Nothing
        Me.txtResponsable.Text = Nothing
        Me.cboxPerfilPago.SelectedIndex = 0
        Me.cboxAccion.SelectedIndex = 0
    End Sub
    'METODO PARA RESTABLECER LA ASIGNACION
    Private Sub restablecerAsignacion()
        Me.refreshAccount()
        Me.cboxCuentaAsignar.SelectedIndex = 0
        Me.cboxCuentaAsignar.SelectedIndex = 0
        Me.cboxUsuarios.SelectedIndex = 0
    End Sub
#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS DE CLASE"
    'EVENTO QUE MANEJA EL LOAD DEL FORMULARIO
    Private Sub MoneyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.refreshAccount()
        Me.getUsers()
        Me.getPerfiles()
        Me.restablacerCreacion()
        Me.restablecerAsignacion()
    End Sub
    'METODO QUE MANEJA EL CAMBIO DEL COMBOBOX ACCION
    Private Sub cboxAccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxAccion.SelectedIndexChanged
        If Me.cboxAccion.SelectedIndex = 0 Then
            Me.cboxCuenta.Enabled = False
            Me.txtNameCuenta.Enabled = True
            Me.txtResponsable.Enabled = True
            Me.cboxPerfilPago.Enabled = True
        ElseIf Me.cboxAccion.SelectedIndex = 1 Then
            Me.cboxCuenta.Enabled = True
            Me.txtNameCuenta.Enabled = False
            Me.txtResponsable.Enabled = True
            Me.cboxPerfilPago.Enabled = True
        ElseIf Me.cboxAccion.SelectedIndex = 2 Then
            Me.cboxCuenta.Enabled = False
            Me.txtNameCuenta.Enabled = False
            Me.txtResponsable.Enabled = False
            Me.cboxPerfilPago.Enabled = False
        ElseIf Me.cboxAccion.SelectedIndex = 3 Then
            Me.cboxCuenta.Enabled = False
            Me.txtNameCuenta.Enabled = False
            Me.txtResponsable.Enabled = False
            Me.cboxPerfilPago.Enabled = False
        End If
    End Sub
    'METODO QUE MANEJA LA ACTUALIZACION DE DATOS ARRIBA
    Private Sub btnActualizarCrear_Click(sender As Object, e As EventArgs) Handles btnActualizarCrear.Click
        If cboxAccion.SelectedIndex = 0 Then
            If Me.SAYC_settings.adminOnly() And Me.checkRepeat(txtNameCuenta.Text) And txtNameCuenta.Text.Length > 0 And txtResponsable.Text.Length > 0 And cboxPerfilPago.SelectedIndex <> 0 Then
                Dim respuesta As Integer = MsgBox("¿Esta seguro que desea crear la cuenta indicada?", MsgBoxStyle.YesNo, "Creacion de cuenta")
                If respuesta = MsgBoxResult.Yes Then
                    Me.SAYC_settings.db_opquery("INSERT INTO cuenta (cuenta.name_cuenta,cuenta.tipo_perfil,cuenta.responsable,cuenta.estado) VALUES ('" & txtNameCuenta.Text & "', '" & cboxPerfilPago.SelectedValue & "','" & txtResponsable.Text & "', '1')")
                    MessageBox.Show("Datos actualizados con exito")
                    Me.restablacerCreacion()
                End If
            End If
        ElseIf cboxAccion.SelectedIndex = 1 Then
            If Me.SAYC_settings.adminOnly() And cboxCuenta.SelectedIndex <> 0 And txtNameCuenta.Text.Length > 0 And txtResponsable.Text.Length > 0 And cboxPerfilPago.SelectedIndex <> 0 Then
                Dim respuesta As Integer = MsgBox("¿Esta seguro que desea modificar la cuenta indicada?", MsgBoxStyle.YesNo, "Modificacion de cuenta")
                If respuesta = MsgBoxResult.Yes Then
                    Me.SAYC_settings.db_opquery("UPDATE cuenta SET cuenta.name_cuenta='" & txtNameCuenta.Text & "',cuenta.tipo_perfil='" & cboxPerfilPago.SelectedValue & "',cuenta.responsable='" & txtResponsable.Text & "' WHERE cuenta.id_cuenta='" & cboxCuenta.SelectedValue & "'")
                    MessageBox.Show("Datos actualizados con exito")
                    Me.restablacerCreacion()
                End If
            End If
        ElseIf cboxAccion.SelectedIndex = 2 Then
            If Me.SAYC_settings.adminOnly() And cboxCuenta.SelectedIndex <> 0 Then
                Dim respuesta As Integer = MsgBox("¿Esta seguro que desea caducar la cuenta indicada?", MsgBoxStyle.YesNo, "Caducidad de cuenta")
                If respuesta = MsgBoxResult.Yes Then
                    Me.SAYC_settings.db_opquery("UPDATE cuenta SET cuenta.estado'0' WHERE cuenta.id_cuenta='" & cboxCuenta.SelectedValue & "'")
                    MessageBox.Show("Datos actualizados con exito")
                    Me.restablacerCreacion()
                End If
            End If
        ElseIf cboxAccion.SelectedIndex = 3 Then
            If Me.SAYC_settings.adminOnly() And cboxCuenta.SelectedIndex <> 0 Then
                Dim respuesta As Integer = MsgBox("¿Esta seguro que desea reactivar la cuenta indicada?", MsgBoxStyle.YesNo, "Reactivar de cuenta")
                If respuesta = MsgBoxResult.Yes Then
                    Me.SAYC_settings.db_opquery("UPDATE cuenta SET cuenta.estado'1' WHERE cuenta.id_cuenta='" & cboxCuenta.SelectedValue & "'")
                    MessageBox.Show("Datos actualizados con exito")
                    Me.restablacerCreacion()
                End If
            End If
        End If
    End Sub
    'METODO QUE MANEJA EL EVENTO DE ACTIVACION DE LA ACCION DE LA ASIGNACION
    Private Sub cboxCuentaAsignar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCuentaAsignar.SelectedIndexChanged
        If cboxAccionAsignar.SelectedIndex <> 0 Then
            cboxAccionAsignar.Enabled = True
            cboxCuentaAsignar.Enabled = True
        ElseIf cboxAccionAsignar.SelectedIndex = 0 Then
            cboxAccionAsignar.Enabled = False
            cboxCuentaAsignar.Enabled = False
        End If
    End Sub
    'METODO PARA MANEJAR EL EVENTO DEL BOTON ACTUALIZAR DATOS ASIGNAR
    Private Sub btnActualizarAsignar_Click(sender As Object, e As EventArgs) Handles btnActualizarAsignar.Click
        If cboxAccionAsignar.SelectedIndex = 0 Then
            If Me.SAYC_settings.adminOnly() And cboxCuentaAsignar.SelectedIndex <> 0 And cboxCuenta.SelectedIndex <> 0 Then
                Dim respuesta As Integer = MsgBox("¿Esta seguro que desea asignar al usuario indicado la cuenta especificada?", MsgBoxStyle.YesNo, "Asignacion de cuentas")
                If respuesta = MsgBoxResult.Yes Then
                    Me.SAYC_settings.db_opquery("DELETE FROM assign_cuenta WHERE assign_cuenta.id_user='" & cboxUsuarios.SelectedValue & "' AND assign_cuenta.id_cuenta='" & cboxCuentaAsignar.selectedValue & "'")
                    Me.SAYC_settings.db_opquery("INSERT INTO assign_cuenta (assign_cuenta.id_user, assign_cuenta.id_cuenta) VALUES ('" & cboxUsuarios.selectedValue & "', '" & cboxCuentaAsignar.selectedValue & "')")
                End If
            End If
        ElseIf cboxAccionAsignar.SelectedIndex = 1 Then
            If Me.SAYC_settings.adminOnly() And cboxCuentaAsignar.SelectedIndex <> 0 And cboxCuenta.SelectedIndex <> 0 Then
                Dim respuesta As Integer = MsgBox("¿Esta seguro que desea retirar al usuario indicado la cuenta especificada?", MsgBoxStyle.YesNo, "Asignacion de cuentas")
                If respuesta = MsgBoxResult.Yes Then

                End If
            End If
        End If
    End Sub
    'METODO PARA MANEJAR EL EVENTO DEL BOTNO RESTBALCER DE LA SECCION ASIGNAR
    Private Sub btnRestablecerAsignar_Click(sender As Object, e As EventArgs) Handles btnRestablecerAsignar.Click
        Me.restablecerAsignacion()
    End Sub
    'METODO PARA MANEJAR EL EVENTO DEL BOTNO RESTBALCER DE LA SECCION CREACION
    Private Sub btnRestablecerCrear_Click(sender As Object, e As EventArgs) Handles btnRestablecerCrear.Click

    End Sub
#End Region
End Class