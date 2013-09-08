Public Class MoneyAccount
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
    Private Sub MoneyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_cat()
    End Sub
    'METODO PARA REFRESCAR LAS CATEGORIAS DE CUENTAS
    Private Sub refresh_cat()
        cboxDestino.Items.Clear()
        cboxObjetivo.Items.Clear()
        cboxDestino.Items.Add("Seleccione")
        cboxObjetivo.Items.Add("Seleccione")
        Dim consultas As Object = SAYC_settings.db_query("SELECT * FROM perfiles_cc WHERE perfiles_cc.active=1")
        While consultas.read()
            cboxDestino.Items.Add(consultas(1))
            cboxObjetivo.Items.Add(consultas(1))
        End While
    End Sub
#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS"
    'EVENTO PARA AGREGAR UNA CUENTA MONETARIA
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.SAYC_settings.adminOnly() Then
            Dim creacion As String = SAYC_settings.securityVerify(SAYC_settings.internalCore.newMoneyAcount(SAYC_settings.db_target, SAYC_settings.db_user, SAYC_settings.db_pass, SAYC_settings.token, Me.txtNuevaCuenta.Text))
            If creacion = "true" Then
                MessageBox.Show("Cuenta Monetaria Creada con Exito")
                Me.refresh_cat()
            Else
                MessageBox.Show("Ya Existe una Cuenta Monetaria Activa con este nombre, Porfavor indique otro nombre")
            End If
        End If
    End Sub
    'EVENTO PARA ELIMINAR UNA CUENTA MONETARIA
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub
#End Region
End Class