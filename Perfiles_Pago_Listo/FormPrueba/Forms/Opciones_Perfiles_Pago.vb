Public Class Opciones_Perfiles_Pago
#Region "PROPIEDADES"
    'PROPIEDADES DE CLASE
    Private SAYC_settings As Object
#End Region
#Region "METODOS DE CLASE"
    
#End Region
#Region "METODOS PUBLICOS"
    
#End Region
#Region "CONSTRUCTOR"
    Sub New(obj As Object)
        'TRANSPASAMOS EL OBJETO DE CONFIGURACION AL FORM
        Me.SAYC_settings = obj
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
#End Region
#Region "EVENTOS"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'ESTA OPERACION BORRA LOS ANTIGUOS NOMBRES Y INGRESA NOMBRES NUEVOS. NO AFECTA A NIVEL CONTABLE
        'SOLO ES UNA OPERACION ESTETICA
        SAYC_settings.dbObj.opquery("DELETE FROM configuraciones WHERE configuraciones.name='namep2';" & _
        "DELETE FROM configuraciones WHERE configuraciones.name='namep2';" & _
        "DELETE FROM configuraciones WHERE configuraciones.name='namep3';" & _
        "DELETE FROM configuraciones WHERE configuraciones.name='namep4';" & _
        "INSERT INTO configuraciones (configuraciones.name, configuraciones.setting) VALUES ('namep1', '" & Me.txtp1.Text & "');" & _
        "INSERT INTO configuraciones (configuraciones.name, configuraciones.setting) VALUES ('namep2', '" & Me.txtp2.Text & "');" & _
        "INSERT INTO configuraciones (configuraciones.name, configuraciones.setting) VALUES ('namep3', '" & Me.txtp3.Text & "');" & _
        "INSERT INTO configuraciones (configuraciones.name, configuraciones.setting) VALUES ('namep4', '" & Me.txtp4.Text & "');")
    End Sub
#End Region
End Class