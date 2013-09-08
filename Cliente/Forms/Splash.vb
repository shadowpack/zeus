Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public NotInheritable Class Splash
    'PROPIEDADES DE CLASE
    Private initFunction As SAYC_ZEUS
    'DEFINIMOS EL CONSTRUCTOR DE LA CLASE
    Public Sub New()
        'DEFINIMOS CONFIGS
        CheckForIllegalCrossThreadCalls = False
        System.Windows.Forms.Application.DoEvents()
        'LLAMAMOS AL CONSTRUCTOR DEL FORM
        InitializeComponent()
    End Sub
    Public Sub inicio()
        Me.initFunction = New SAYC_ZEUS(lblstatus, pbar, lblVersion, Me)
    End Sub
    'EVENTOS DE SPLASH
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.inicio()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
