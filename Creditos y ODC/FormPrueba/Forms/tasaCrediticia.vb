Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class tasaCrediticia
#Region "PROPIEDADES"
    Private credito As CreditoyODC
    Private Sayc_setting As Object
#End Region
#Region "CONSTRUCTOR"
    Sub New(formi As CreditoyODC, setting As Object)
        Me.credito = formi
        Me.Sayc_setting = setting
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
#Region "METODOS DE CLASE"
    'METODO PARA EXTRAER LAS TASAS MONETARIAS
    Private Sub gettasas()
        Me.dgridTasas.Rows.Clear()
        Dim consulta As Object = Me.Sayc_setting.db_query("SELECT * FROM configuraciones WHERE configuraciones.name='tasacredi'")
        While consulta.read()
            Dim result As JObject = JsonConvert.DeserializeObject(consulta(2))
            dgridTasas.Rows.Add(consulta(0), result.SelectToken("name").ToString, result.SelectToken("tasa").ToString * 100 & "%", "Interes " & result.SelectToken("tipo").ToString)
        End While
    End Sub
    'METODO PARA RESTBLCER
    Private Sub restablecer()
        txtNameTasa.Text = Nothing
        txtTasaInteres.Text = Nothing
        cboxTipoInteres.SelectedIndex = 0
    End Sub
    'METODO PARA COLOCAR LOS TIPOS DE TASA
    Private Sub setTipoTasas()
        Dim dt = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr(1) = "simple"
        dr(0) = "Interes Simple"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr(1) = "compuesto"
        dr(0) = "Interes Compuesto"
        dt.Rows.Add(dr)
        cboxTipoInteres.DataSource = dt
        cboxTipoInteres.DisplayMember = "Name"
        cboxTipoInteres.ValueMember = "Value"
        cboxTipoInteres.SelectedIndex = 0
    End Sub

#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS DE CLASE"
    'MANEJADOR DEL BOTON RESTABLECER
    Private Sub btnRestablcer_Click(sender As Object, e As EventArgs) Handles btnRestablcer.Click
        Me.restablecer()
    End Sub
    'MANEJADOR DEL EVENTO PARA AGREGAR TASAS
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtNameTasa.Text.Length > 0 And IsNumeric(txtTasaInteres.Text) And txtTasaInteres.Text > 0 And Me.Sayc_setting.adminOnly() Then
            Dim tasa As tasa = New tasa(cboxTipoInteres.SelectedValue, txtNameTasa.Text, (txtTasaInteres.Text / 100))
            Me.Sayc_setting.db_opquery("INSERT INTO configuraciones (configuraciones.name, configuraciones.setting) VALUES ('tasacredi', '" & JsonConvert.SerializeObject(tasa) & "')")
            MessageBox.Show("Tasa crediticia ingresada con exito")
            Me.gettasas()
            Me.credito.getTasa()
        End If
    End Sub
    'MANEJADOR DEL EVENTO PARA ELIMINAR TASAS
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridTasas.CellContentClick
        If e.RowIndex = 4 And Me.Sayc_setting.adminOnly() Then
            Dim result As String = MsgBox("¿Esta seguro que desea borrar la tasa crediticia indicada?", MsgBoxStyle.YesNo, "Confirmacion")
            If result = MsgBoxResult.Yes Then
                Me.Sayc_setting.db_query("DELETE FROM configuraciones WHERE configuraciones.id_config='" & dgridTasas.Rows(e.RowIndex).Cells(0).Value & "'")
                MessageBox.Show("Tasa Crediticia eliminada con exito")
                Me.gettasas()
                Me.credito.getTasa()
            End If
        End If
    End Sub
    'MANEJADOR DE LA CARGA DEL FORM
    Private Sub tasaCrediticia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.gettasas()
        Me.setTipoTasas()
        Me.restablecer()
    End Sub
#End Region
End Class