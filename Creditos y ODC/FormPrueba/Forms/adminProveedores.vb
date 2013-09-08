Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class adminProveedores
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
    Private Sub getProveedor()
        Me.dgridProveedores.Rows.Clear()
        Dim consulta As Object = Me.Sayc_setting.db_query("SELECT * FROM configuraciones WHERE configuraciones.name='proveedorODC'")
        While consulta.read()
            Dim result As JObject = JsonConvert.DeserializeObject(consulta(2))
            Me.dgridProveedores.Rows.Add(consulta(0), result.SelectToken("name").ToString, result.SelectToken("direccion").ToString, result.SelectToken("telefono").ToString)
        End While
    End Sub
    'METODO PARA RESTBLCER
    Private Sub restablecer()
        txtName.Text = Nothing
        txtDireccion.Text = Nothing
        txtTelefono.Text = Nothing
    End Sub
#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS DE CLASE"
    'MANEJADOR DEL BOTON RESTABLECER
    Private Sub btnRestablcer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        Me.restablecer()
    End Sub
    'MANEJADOR DEL EVENTO PARA AGREGAR TASAS
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtName.Text.Length > 0 And txtDireccion.Text.Length > 0 And txtTelefono.Text.Length > 0 And Me.Sayc_setting.adminOnly() Then
            Dim tasa As proveedor = New proveedor(txtName.Text, txtDireccion.Text, txtTelefono.Text)
            Me.Sayc_setting.db_opquery("INSERT INTO configuraciones (configuraciones.name, configuraciones.setting) VALUES ('proveedorODC', '" & JsonConvert.SerializeObject(tasa) & "')")
            MessageBox.Show("Proveedor ingresado con exito")
            Me.getProveedor()
        End If
    End Sub
    'MANEJADOR DEL EVENTO PARA ELIMINAR TASAS
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridProveedores.CellContentClick
        If e.RowIndex = 4 And Me.Sayc_setting.adminOnly() Then
            Dim result As String = MsgBox("¿Esta seguro que desea borrar el proveedor indicado?", MsgBoxStyle.YesNo, "Confirmacion")
            If result = MsgBoxResult.Yes Then
                Me.Sayc_setting.db_opquery("DELETE FROM configuraciones WHERE configuraciones.id_config='" & dgridProveedores.Rows(e.RowIndex).Cells(0).Value & "'")
                MessageBox.Show("Proveedor eliminado con exito")
                Me.getProveedor()
                Me.credito.getTasa()
            End If
        End If
    End Sub
    'MANEJADOR DE LA CARGA DEL FORM
    Private Sub tasaCrediticia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.restablecer()
        Me.getProveedor()
    End Sub
#End Region
End Class