Imports db_core_web_services
Public Class PrincipalScreen
    'DEFINIMOS LAS VARIABLES DE CLASE
    Private SAYC As SAYC_Settings
    'DEFINIMOS EL CONSTRUCTOR DE LA CLASE
    Sub New()
        'INICIALIZAMOS EL FORM
        InitializeComponent()
    End Sub
    'DEFINIMOS LOS EVENTOS DELFORM
    Public Sub loadForm(obj As SAYC_Settings)
        Me.SAYC = obj
        Me.Text = "CLOUD ZEUS - TAXIS COLECTIVOS : " & obj.getCompanyName
        Me.Show()
    End Sub
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Close()
        My.Forms.SAYC_ingreso.clearForm()
        My.Forms.SAYC_ingreso.Show()
    End Sub
    'EVENTO PARA MANEJAR Y ELIMINAR EL OBJETO DE CONFIGURACION
    Private Sub PrincipalScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.SAYC = Nothing
        My.Forms.SAYC_ingreso.clearForm()
        My.Forms.SAYC_ingreso.Show()
    End Sub
End Class
