Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Eximiciones
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
        cboxBeneficiario.ValueMember = "Value"
        cboxBeneficiario.DisplayMember = "Name"
        cboxBeneficiario.DataSource = dt
        cboxBeneficiario.SelectedIndex = 0
    End Sub
    Private Sub restablecer()
        txtJustificacion.Text = Nothing
        cboxTipoOperacion.SelectedIndex = 0
        cboxhabiente.SelectedIndex = 0
        cboxBeneficiario.SelectedIndex = 0
        cboxBeneficiario.Enabled = False
        txtJustificacion.Enabled = True
        dpickerinicio.Value = Date.Now
        dpickertermino.Value = Date.Now
    End Sub
#End Region
#Region "METODOS PUBLICOS"
#End Region
#Region "EVENTOS DE CLASE"
    'MANEJADOR DEL BOTONO ACTUALIZAR
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If cboxTipoOperacion.SelectedIndex = 0 Then
            If dpickertermino.Value >= dpickerinicio.Value Then
                If cboxhabiente.SelectedIndex = 1 Then
                    Me.SAYC_settings.db_opquery("INSERT INTO eximiciones (eximiciones.id_cuenta,eximiciones.tipo,eximiciones.detalle,eximiciones.fechaInit,eximiciones.fechaFinish) VALUES ('" & cboxBeneficiario.SelectedValue & "', 'eximicion','" & txtJustificacion.Text & "', '" & dpickerinicio.Value.ToString("dd-MM-yyyy") & "', '" & dpickertermino.Value.ToString("dd-MM-yyyy") & "')")
                ElseIf cboxhabiente.SelectedIndex = 2 Then
                    Dim consulta As Object = Me.SAYC_settings.db_query("SELECT * FROM cuenta")
                    While consulta.read()
                        Me.SAYC_settings.db_opquery("INSERT INTO eximiciones (eximiciones.id_cuenta,eximiciones.tipo,eximiciones.detalle,eximiciones.fechaInit,eximiciones.fechaFinish) VALUES ('" & consulta(0) & "', 'eximicion','" & txtJustificacion.Text & "', '" & dpickerinicio.Value.ToString("dd-MM-yyyy") & "', '" & dpickertermino.Value.ToString("dd-MM-yyyy") & "')")
                    End While
                End If
                MessageBox.Show("Eximicion emitida con exito")
            Else
                MessageBox.Show("La fecha de termino debe ser mayor a la de inicio")
            End If
        ElseIf cboxTipoOperacion.SelectedIndex = 1 Then
            If dpickertermino.Value >= dpickerinicio.Value Then
                If cboxhabiente.SelectedIndex = 1 Then
                    Me.SAYC_settings.db_opquery("INSERT INTO eximiciones (eximiciones.id_cuenta,eximiciones.tipo,eximiciones.detalle,eximiciones.fechaInit,eximiciones.fechaFinish) VALUES ('" & cboxBeneficiario.SelectedValue & "', 'vacacion','Vacaciones', '" & dpickerinicio.Value.ToString("dd-MM-yyyy") & "', '" & dpickertermino.Value.ToString("dd-MM-yyyy") & "')")
                ElseIf cboxhabiente.SelectedIndex = 2 Then
                    Dim consulta As Object = Me.SAYC_settings.db_query("SELECT * FROM cuenta")
                    While consulta.read()
                        Me.SAYC_settings.db_opquery("INSERT INTO eximiciones (eximiciones.id_cuenta,eximiciones.tipo,eximiciones.detalle,eximiciones.fechaInit,eximiciones.fechaFinish) VALUES ('" & consulta(0) & "', 'vacacion','Vacaciones', '" & dpickerinicio.Value.ToString("dd-MM-yyyy") & "', '" & dpickertermino.Value.ToString("dd-MM-yyyy") & "')")
                    End While
                End If
                MessageBox.Show("Vacaciones asignadas con exito")
            Else
                MessageBox.Show("La fecha de termino debe ser mayor a la de inicio")
            End If
        End If
    End Sub
    'EVENTO PARA CONTROLAR LOS GRUPOS DE USUARIOS EN EXIMICION
    Private Sub cboxhabiente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxhabiente.SelectedIndexChanged
        If cboxhabiente.SelectedIndex = 1 Then
            Me.getcuentas()
            Me.cboxBeneficiario.Enabled = True
        ElseIf cboxhabiente.SelectedIndex = 2 Then
            Me.cboxBeneficiario.Enabled = False
        End If
    End Sub
    'MANEJADOR DEL LOAD DEL FORM
    Private Sub Eximiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.getcuentas()
        Me.restablecer()
    End Sub
    'MANEJADOR DE TIPO DE OPERACION
    Private Sub cboxTipoOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTipoOperacion.SelectedIndexChanged
        If cboxTipoOperacion.SelectedIndex = 0 Then
            txtJustificacion.Enabled = True
        Else
            txtJustificacion.Enabled = False
        End If
    End Sub
    Private Sub btnRestablecer_Click_1(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        Me.restablecer()
    End Sub
#End Region

    Private Sub DiasDeVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiasDeVacacionesToolStripMenuItem.Click
        Dim vacaciones As New vacaciones(Me, Me.SAYC_settings)
        vacaciones.ShowDialog()
    End Sub
End Class