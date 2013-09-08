Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Ahorros
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
    Private Sub getcuentas()
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
        cboxHabiente.ValueMember = "Value"
        cboxHabiente.DisplayMember = "Name"
        cboxHabiente.DataSource = dt
        cboxHabiente.SelectedIndex = 0
    End Sub
    Private Sub getusers()
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
        cboxHabiente.ValueMember = "Value"
        cboxHabiente.DisplayMember = "Name"
        cboxHabiente.DataSource = dt
        cboxHabiente.SelectedIndex = 0
    End Sub
    Private Sub restablecer()
        txtMontoOperacion.Text = Nothing
        cboxHabiente.SelectedIndex = 0
        cboxTipoAhorro.SelectedIndex = 0
        cboxOperacion.SelectedIndex = 0
        lblMontoDisponible.Text = "Monto Disponible"
        dgridAhorros.Rows.Clear()
    End Sub
#End Region
#Region "METODOS PUBLICOS"
#End Region
#Region "EVENTOS DE CLASE"
    Private Sub cboxTipoAhorro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTipoAhorro.SelectedIndexChanged
        If cboxTipoAhorro.SelectedIndex = 0 Then
            Me.getcuentas()
        ElseIf cboxTipoAhorro.SelectedIndex = 1 Then
            Me.getusers()
        End If
    End Sub

    Private Sub cboxHabiente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxHabiente.SelectedIndexChanged
        If cboxHabiente.SelectedIndex <> 0 Then
            Dim consulta As Object
            If cboxTipoAhorro.SelectedIndex = 0 Then
                consulta = Me.SAYC_settings.db_query("SELECT operacion,monto FROM ahorros WHERE ahorros.id_cuenta='" & cboxHabiente.SelectedValue & "'")
            ElseIf cboxTipoAhorro.SelectedIndex = 1 Then
                consulta = Me.SAYC_settings.db_query("SELECT operacion,monto FROM ahorros WHERE ahorros.id_user='" & cboxHabiente.SelectedValue & "'")
            End If
            Dim total As Integer = 0
            While consulta.read()
                If consulta(0) = "abono" Then
                    Me.dgridAhorros.Rows.Add("Abono", "$" & consulta(1), total, "$" & (total + consulta(1)))
                    total += consulta(1)
                ElseIf consulta(0) = "retiro" Then
                    Me.dgridAhorros.Rows.Add("Retiro", "$" & consulta(1), total, "$" & (total - consulta(1)))
                    total -= consulta(1)
                End If
            End While
            Me.lblMontoDisponible.Text = "$ " & total
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If cboxHabiente.SelectedIndex <> 0 And txtMontoOperacion.Text > 0 Then
            'DEFINIMOS SI ES NEGATIVO O POSITIVA LA OPERACION
            Dim monto As Integer
            If cboxOperacion.SelectedIndex = 0 Then
                monto = txtMontoOperacion.Text
            ElseIf cboxOperacion.SelectedIndex = 1 Then
                monto = txtMontoOperacion.Text * -1
            End If
            'DEFINIMOS LA OPERACION
            Dim operacion As String
            If cboxOperacion.SelectedIndex = 0 Then
                operacion = "abono"
            ElseIf cboxOperacion.SelectedIndex = 1 Then
                operacion = "retiro"
            End If
            If (Replace(lblMontoDisponible.Text, "$ ", "") + monto) > 0 Then
                If cboxTipoAhorro.SelectedIndex = 0 Then
                    Me.SAYC_settings.db_opquery("INSERT INTO ahorros (ahorros.id_cuenta,ahorros.fecha,ahorros.operacion,ahorros.monto) VALUES ('" & cboxHabiente.SelectedValue & "', '" & Date.Now.ToString("dd-MM-yyyy") & "','" & operacion & "', '" & monto & "')")
                ElseIf cboxTipoAhorro.SelectedIndex = 1 Then
                    Me.SAYC_settings.db_opquery("INSERT INTO ahorros (ahorros.id_user,ahorros.fecha,ahorros.operacion,ahorros.monto) VALUES ('" & cboxHabiente.SelectedValue & "', '" & Date.Now.ToString("dd-MM-yyyy") & "','" & operacion & "', '" & monto & "')")
                End If
                MessageBox.Show("Operacion Completada con exito")
                Me.restablecer()
            Else
                MessageBox.Show("No hay fondos suficientes para realizar la operacion")
            End If
        Else
            MessageBox.Show("Faltan Datos por completar")
        End If
    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        Me.restablecer()
    End Sub
#End Region
End Class