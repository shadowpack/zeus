Public Class vacaciones
#Region "PROPIEDADES"
    Dim eximiciones As Eximiciones
    Dim Sayc_Setting As Object
    Dim dias As Integer = Nothing
#End Region
#Region "CONSTRUCTOR"
    Sub New(excimicion As Eximiciones, setting As Object)
        Me.eximiciones = excimicion
        Me.Sayc_Setting = setting
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
#End Region
#Region "METODOS DE CLASE"
    'METODO QUE OBTIENE LOS DIAS CONFIGURADOS DESDE LA DB
    Private Sub getDias()
        Dim consulta As Object = Me.Sayc_Setting.db_query("SELECT * FROM configuraciones WHERE configuraciones.name='vacaciones'")
        If consulta.HasRows() Then
            consulta.read()
            Me.dias = consulta(2)
        End If
    End Sub
    'METODO PARA RESTABLECER EL FORM
    Private Sub restablecer()
        Me.txtDiasVacaciones.Text = Me.dias
    End Sub
#End Region
#Region "EVENTOS DE CLASE"
    'EVENTO DEL BOTON RESTABLECER
    Private Sub btnRestablece_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        Me.restablecer()
    End Sub
    'EVENTO DE CARGA DEL FORM
    Private Sub vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.getDias()
    End Sub
    'EVENTO DE BTN ACTUALIZAR
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.Sayc_Setting.adminOnly() Then
            Dim result As String = MsgBox("¿Esta seguro que desea cambiar los dias de vacaciones maximos por año?", MsgBoxStyle.YesNo, "Confirmación")
            If result = MsgBoxResult.Yes Then
                Me.Sayc_Setting.db_opquery("DELETE FROM configuraciones WHERE configuraciones.name='vacaciones'")
                Me.Sayc_Setting.db_opquery("INSERT INTO configuraciones (configuraciones.name,configuraciones.setting) VALUES ('vacaciones', '" & txtDiasVacaciones.Text & "')")
                MessageBox.Show("Configuracion guardada con exito")
            End If
        End If
    End Sub
#End Region
    
    
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class