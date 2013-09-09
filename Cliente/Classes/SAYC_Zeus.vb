Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public Class SAYC_ZEUS
#Region "PROPIEDADES DE CLASE"
    'DECLARACION DE VARIABLES DE CLASE
    'DECLARACION DEL WEBSERVICE
    Private obj As Splash
    Private initFunctions As New initFunction.initFunction
    'DECLARACION DE OBJETOS NECESARIOS
    Private WithEvents downloader As New FileDownloader
    'DECLARACION DE LOS STATUS
    Private lblStatus As Label
    Private barStatus As ProgressBar
    Private versionName As Label
    'DELCARACION DEL TIMER
    Private timer As New System.Timers.Timer
#End Region
#Region "CONSTRUCTOR"
    'DEFINIMOS EL CONSTRUCTOR DE CLASE
    Public Sub New(Slbl As Label, Sbar As ProgressBar, Vname As Label, obj As Splash)
        'CARGAMOS LAS VARIABLES
        Me.initFunctions.Url = "http://localhost/Apolo%20Server/initFunction.php?wsdl"
        Me.lblStatus = Slbl
        Me.barStatus = Sbar
        Me.versionName = Vname
        'LLAMAMOS WEBSERVICES NECESARIOS
        Me.versionName.Text = Me.initFunctions.versionName(My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & My.Application.Info.Version.Build)
        Me.obj = obj
        Me.obj.Show()
        Me.main()
    End Sub
#End Region
#Region "METODOS DE CLASE"
    'DEFINIMOS LOS METODOS DE CLASE
    'ESTE METODO MAIN ES EL ENCARGADO DE ESTABLECER LOS SUCESOS
    Public Sub main()
        Me.lblStatus.Text = "Inicializando Funciones"
        Me.barStatus.Value = 20
        Me.lblStatus.Text = "Intentando conectar con el servidor"
        Me.conectionStatus()
        Me.lblStatus.Text = "Comprobando Nuevas Versiones"
        Me.barStatus.Value = 50
        Me.newVersions()
        Me.lblStatus.Text = "Iniciando Cloud SAYC"
        Me.barStatus.Value = 100
        Me.chargeTimer()
    End Sub
    'DEFINIMOS METODO DE COMPROBACION DE CONECCION AL SERVIDOR
    Private Function conectionStatus()
        Dim conectTry As Integer = 0
        Do
            Try
                If Me.initFunctions.isAlive() Then
                    Return True
                End If
            Catch ex As Exception
                'Esperamos 5 intentos de coneccion al servidor con 1000 msec de delay
                If conectTry > 5 Then
                    MessageBox.Show("No se puede efectuar la coneccion con el servidor. Asegurese de estar conectado a internet")
                    End
                End If
                conectTry += 1
                Me.sleep(1000)
            End Try
        Loop
    End Function
    'METODO QUE BUSCA ACTUALIZACIONES AUTOMATICAS
    Private Sub newVersions()
        Dim arraylist As JArray = Newtonsoft.Json.JsonConvert.DeserializeObject(Me.initFunctions.newVersionCheck())
        Dim versionServ As Integer = arraylist.Value(Of Double)(2) * 1000 + arraylist.Value(Of Double)(3) * 100 + arraylist.Value(Of Double)(4) * 10
        Dim version As Integer = My.Application.Info.Version.Major * 1000 + My.Application.Info.Version.Minor * 100 + My.Application.Info.Version.Build * 10
        If (version < versionServ) Or (version = versionServ And My.Application.Info.Version.Revision < arraylist.Value(Of Double)(5)) Then
            Dim box As MsgBoxResult = MsgBox("Actualmente existe una version actualizada del software, ¿Desea actualizar su software a la version mas reciente?", MsgBoxStyle.YesNo, "Actualización del software")
            If box = MsgBoxResult.Yes Then
                lblStatus.Text = "Descargando Actualizaciones"
                Me.barStatus.Value = 60
                With Me.downloader
                    .Files.Clear()
                    .LocalDirectory = Environment.CurrentDirectory & "\Updates"
                    .Files.Add(New FileDownloader.FileInfo(arraylist.Value(Of String)(6)))
                End With
                My.Forms.Downloader.execFile(True)
                My.Forms.Downloader.setDownloader(Me.downloader)
                My.Forms.Downloader.setAction("Descargando Actualizaciones")
                My.Forms.Downloader.ShowDialog()
                End
            End If
        End If
    End Sub
    Private Sub chargeTimer()
        Me.timer.Interval = 2000
        Me.timer.AutoReset = False
        Me.timer.Enabled = True
        AddHandler Me.timer.Elapsed, AddressOf Me.TimerTick
        Me.timer.Start()
    End Sub
    Private Sub TimerTick()
        Me.obj.Close()
    End Sub
    'DEFINIMOS FUNCION AUXILIAR SLEEP
    Public Sub sleep(mSec As Integer)
        System.Threading.Thread.Sleep(mSec)
    End Sub
#End Region
End Class
