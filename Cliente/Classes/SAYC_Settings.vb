Imports System.Threading
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public Class SAYC_Settings
#Region "PROPIEDADES"
    'Definimos las variables necesarias para el funcionamiento del software
    'VARIABLES DE DATOS PERSONALES DEL OPERADOR
    Private name As String
    Private privilege As Integer
    Private companyName As String
    Private id_user As String
    Private id_company As Integer
    'VARIABLES DE PATH WEBSERVICES
    Private web_service_db_core As String
    Private web_service_internal_core As String
    'VARIABLES DE USER DB Y TOKEN DE ACCESO
    Public db_user As String
    Public db_pass As String
    Public db_target As String
    Public token As String
    'CONFIGURACIONES DE SOFTWARE
    Private inithour As String
    Private finishhour As String
    'IMAGENES DE BUSY STATE
    Private busyObj As PictureBox
    'OBJETOS FUNCIONALES
    Private timer As New System.Timers.Timer
    Private intervalTimer As Integer
    'DEFINIMOS OBJETOS PUBLICOS PARA LLAMADAS A WEBSERVICES - SE UTILIZAN A LO LARGO DEL SOFTWARE
    'Y SON INICIALIZADOS DESDE EL CONSTRUCTOR FICTICIO.
    Public internalCore As internalFunction.internalFunction
    Private dbObj As db_core_web_services.db_core
    'PROPIEDADES NECESARIAS PARA LA CARGA DE ADDONS
    Private m_testDataSource As DataSet
    Private m_graphicalAddons As List(Of System.Type)
    Private listModules As List(Of Array)
    Private listMenus As List(Of ToolStripMenuItem)
    Private menu As MenuStrip
    'DECLARACION DE OBJETOS NECESARIOS
    Private WithEvents downloader As New FileDownloader
    'DECLARACION DE FORMS ESCENCIALES
    Private download_Form As New Downloader
    Private principal_Form As PrincipalScreen
    'DECLARACION DE VARIABLES NECESARIAS PARA VERIFICADOR
    Private respbool_Verificador As Boolean
    Private resptxt_Verificador As String
    'DECLARACION DE CONFIGURACIONES DEL SERVER
    Private ftpPath As String
    Private ftpUser As String
    Private ftpPass As String
    Private webPath As String
    '------------------------------------------------------------
#End Region
#Region "CONSTRUCTOR"
    'DEFINIMOS EL CONSTRUCTOR DE LA CLASE
    Public Sub New(obj As PrincipalScreen)
        Me.busyObj = obj.pboxactu
        Me.menu = obj.menuForm
        Me.principal_Form = obj
    End Sub
    '--------------------------------------------------------------
#End Region
#Region "METODOS DE CLASE"
    '--------------------------------------------------------------
    'DEFINIMOS EL AUXILIAR TIMER Y SU CORRESPONDIETE TICK
    Private Sub chargeTimer()
        Me.timer.Interval = Me.intervalTimer
        Me.timer.AutoReset = True
        AddHandler Me.timer.Elapsed, AddressOf Me.TimerTick
        Me.timer.Start()
    End Sub
    Private Sub TimerTick(sender As Object, e As System.Timers.ElapsedEventArgs)
        Dim vigilante As New Thread(AddressOf Me.iAlive)
        vigilante.Start()
    End Sub
    'METODO PARA DEFINIR LAS CONFIGURACIONES DEL PROGRAMA
    Private Sub set_settings(obj As JArray)
        For Each vector As JObject In obj
            If vector.SelectToken("name") = "interval" Then
                Me.intervalTimer = vector.SelectToken("setting")
            ElseIf vector.SelectToken("name") = "inittime" Then
                Me.inithour = vector.SelectToken("setting")
            ElseIf vector.SelectToken("name") = "finishtime" Then
                Me.finishhour = vector.SelectToken("setting")
            End If
        Next
    End Sub
    'METODO NECESARIO PARA LA CARGA DE ADDONS
    Private Sub LoadAddons()
        Dim loader As New AddonLoader
        Me.listModules = Me.checkAddOns()
        Dim addonsLoaded = loader.GetAddonsByType(AddonLoader.AddonType.IGraphicalAddon)
        'VERIFICAMOS LAS VERSIONES DE LOS MODULOS
        For Each graphicalAddon In addonsLoaded
            Dim typedAddon = Activator.CreateInstance(graphicalAddon)
            typedAddon.DataSource = m_testDataSource
            If Me.GetModule(Me.listModules, typedAddon.idProduct) Then
                Dim AddOnsToolStripMenuItem As ToolStripMenuItem = Me.getItemMenu(typedAddon.Category)
                Dim newlyAddedToolstripItem As ToolStripItem = AddOnsToolStripMenuItem.DropDownItems.Add(typedAddon.NameText)
                typedAddon.ParentForm = Me.principal_Form
                typedAddon.SaycSetting = Me
                newlyAddedToolstripItem.Image = typedAddon.Image
                newlyAddedToolstripItem.Name = typedAddon.Name
                AddHandler newlyAddedToolstripItem.Click, AddressOf typedAddon.OnClick
            End If
        Next
    End Sub
    'FUNCION PARA BUSCAR NAME DENTRO DEL MENU
    Private Function getItemMenu(name As String) As ToolStripMenuItem
        For Each vector As ToolStripMenuItem In Me.menu.Items
            If vector.Name = name Then
                Return vector
            End If
        Next
        'EN CASO DE NO ENCONTRAR EL MENUNAME PROCEDERA A CREARLO
        Dim item As ToolStripMenuItem = PrincipalScreen.menuForm.Items.Add(name)
        item.Name = name
        Return item
    End Function
    'FUNCION PARA DETERMINAR SI DEBE CARGAR O NO EL MODULO
    Private Function GetModule(listModule As List(Of Array), IdProduct As String) As Boolean
        For Each vector As Object In listModule
            If vector(2) = IdProduct Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function checkAddOns() As List(Of Array)
        Dim downloadStatus As Boolean = False
        Dim sincroModule As New List(Of String)
        Dim listResult As New List(Of Array)
        Dim modulos As JArray = JsonConvert.DeserializeObject(internalCore.checkAddOns(Me.id_company, Me.id_user, Me.db_target, Me.db_user, Me.db_pass))
        Dim loader As New AddonLoader
        Dim addonsLoaded = loader.GetAddonsInfo()
        For Each modulo In modulos.Values(Of JObject)()
            listResult.Add({modulo.SelectToken("id_module"), modulo.SelectToken("name"), modulo.SelectToken("idProduct")})
            Dim status As Boolean = True
            For Each localmodules In addonsLoaded
                If modulo.SelectToken("idProduct") = localmodules(1) Then
                    Dim serverVersion As Integer = Integer.Parse(modulo.SelectToken("mayor")) * 1000 + Integer.Parse(modulo.SelectToken("minor")) * 100 + Integer.Parse(modulo.SelectToken("build")) * 10
                    Dim localVersion As Integer = localmodules(2) * 1000 + localmodules(3) * 100 + localmodules(4) * 10
                    If (serverVersion > localVersion) Or (serverVersion = localVersion And Integer.Parse(modulo.SelectToken("revision")) > localmodules(5)) Then
                        status = True
                    Else
                        status = False
                    End If
                End If
            Next
            If status Then
                sincroModule.Add(modulo.SelectToken("path"))
                downloadStatus = True
            End If
        Next
        If downloadStatus Then
            With Me.downloader
                .Files.Clear()
                .LocalDirectory = Environment.CurrentDirectory & "\Addons"
            End With
            For Each vector As String In sincroModule
                Me.downloader.Files.Add(New FileDownloader.FileInfo(vector))
            Next
            Me.download_form.execFile(False)
            Me.download_form.setDownloader(Me.downloader)
            Me.download_form.setAction("Descargando Modulos")
            Me.download_form.ShowDialog()
        End If
        Return listResult
    End Function
#End Region
#Region "METODOS PUBLICOS"
    '--------------------------------------------------------------
    'DEFINIMOS UN CONSTRUCTOR FICTICIO QUE LLAMAMOS UNA VEZ EXTENDIDO EL OBJETO
    Public Sub Construct()
        'INICIALIZAMOS LOS WEBSERVICES NECESARIOS
        Me.internalCore = New internalFunction.internalFunction
        Me.internalCore.Url = Me.web_service_internal_core
        Me.dbObj = New db_core_web_services.db_core(Me.db_target, Me.db_user, Me.db_pass, Me.web_service_db_core, Me.token, Me)
        Me.chargeTimer()
        Me.LoadAddons()
    End Sub
    'DEFINIMOS RUTINA DE EXTENSION - NECESARIA PARA IMPORTAR PROPIEDADES WEBSERVICES DE FORMA AUTORMATICA
    Public Sub Extend(obj As JObject)
        'PARA EL METODO DE EXTENSION ES NECESARIO QUE EN EL OBJETO WEBSERVICES LAS PROPIEDADES SEAN PUBLICAS
        Me.name = obj.SelectToken("name")
        Me.privilege = obj.SelectToken("privilege")
        Me.companyName = obj.SelectToken("companyName")
        Me.id_company = obj.SelectToken("id_company")
        Me.id_user = obj.SelectToken("id_user")
        Me.web_service_db_core = obj.SelectToken("web_service_db_core")
        Me.web_service_internal_core = obj.SelectToken("web_service_internal_core")
        Me.db_user = obj.SelectToken("db_user")
        Me.db_pass = obj.SelectToken("db_pass")
        Me.db_target = obj.SelectToken("db_target")
        Me.token = obj.SelectToken("token")
        Me.set_settings(obj.SelectToken("config"))
        Me.ftpPath = obj.SelectToken("ftpPath")
        Me.ftpUser = obj.SelectToken("ftpUser")
        Me.ftpPass = obj.SelectToken("ftpPass")
        Me.webPath = obj.SelectToken("webPath")
        'LLAMAMOS AL CONSTRUCTOR FICTICIO
        Me.Construct()
    End Sub
    '--------------------------------------------------------------
    'DEFINIMOS LOS METODOS UTILIZADOS PARA UTILIZAR LAS PROPIEDADES
    Public Function getName()
        Return Me.name
    End Function
    Public Function getCompanyName()
        Return Me.companyName
    End Function
    '--------------------------------------------------------------
    'ESTE METODO MANTIENE EL ALIVE STATUS EN EL SERVER
    Public Sub iAlive()
        Me.openActivity()
        Me.internalCore.AliveStatus(Me.db_target, Me.db_user, Me.db_pass, Me.token)
        Me.closeActivity()
    End Sub
    'ESTE METODO CAMBIA EL LA IMAGEN STATUS PARA MOSTRAR ACTIVIDAD
    Public Sub openActivity()
        Me.busyObj.Image = My.Resources.refresh
    End Sub
    'ESTE METODO CAMBIA EL LA IMAGEN STATUS PARA MOSTRAR ACTIVIDAD
    Public Sub closeActivity()
        Me.busyObj.Image = My.Resources.refreshout
    End Sub
    'ESTE METODO OBTIENES LAS VARIABLES DE DB PARA  UTILIZAR LOS METODOS WEBSERVICES
    Public Function getdbvars() As List(Of String)
        Dim dbvars As New List(Of String)
        dbvars.Add(Me.db_target)
        dbvars.Add(Me.db_user)
        dbvars.Add(Me.db_pass)
        dbvars.Add(Me.token)
        Return dbvars
    End Function
    'METODO PARA EFECTUAR UNA CONSULTA SELECT A LA DB CON RETORNO
    Public Function db_query(Consulta) As Object
        Dim db_select = Me.dbObj.query(Consulta)
        Return db_select
    End Function
    'METODO PARA EFECTUAR UNA CONSULTA OPERACIONES A LA DB
    Public Sub db_opquery(Consulta)
        Me.dbObj.opquery(Consulta)
    End Sub
    'FUNCION PARA COMPROBAR PRIVILEGIOS ADMINISTRADOR EN CASO DE REQUERIRLOS
    Public Function adminOnly() As Boolean
        Dim status As Boolean = False
        'COMPROBAMOS QUE LOS PERMISOS DEL USUARIO SEAN DE ADMINISTRADOR
        Dim consulta As String = Me.internalCore.checkPrivilege(Me.db_target, Me.db_user, Me.db_pass, Me.token, Me.privilege)
        If consulta = "true" Then
            status = True
        Else
            My.Forms.verificarAutorizacion.Construct(Me)
            My.Forms.verificarAutorizacion.ShowDialog()
            If Me.respbool_Verificador = True Then
                Dim autorizacion As String = Me.internalCore.checkPrivilege(Me.db_target, Me.db_user, Me.db_pass, Me.token, Me.resptxt_Verificador)
                If autorizacion = "true" Then
                    status = True
                Else
                    status = False
                    MessageBox.Show("El usuario indicado no tiene permisos para realizar funciones de Administrador o no existe")
                End If
            Else
                status = False
                MessageBox.Show("El usuario indicado no tiene permisos para realizar funciones de Administrador o no existe")
            End If
        End If
        Return status
    End Function
    'METODOS PARA SETEAR LAS VARIABLES DEL VERIFICADOR
    Public Sub setBool_Verificador(bool As Boolean)
        Me.respbool_Verificador = bool
    End Sub
    Public Sub setTxt_Verificador(txt As String)
        Me.resptxt_Verificador = txt
    End Sub
    'METODO PARA VERIFICAR SEGURIDAD Y CADUCIDAD DEL TOKEN
    Public Function securityVerify(resp As String) As String
        If resp = "Security-Failed" Then
            MessageBox.Show("Existe un Error de Seguridad del Software, referente a una sesion caduca o no valida. Por seguridad se procedera a cerrar el software")
            My.Forms.PrincipalScreen.Close()
        End If
        Return resp
    End Function
    'METODO PARA OBTENER EL ID DE LA EMPRESA
    Public Function getIdCompany() As Integer
        Return Me.id_company
    End Function
    'JUEGO DE METODOS PARA OBTENER LAS VARIABLES FTP
    Public Function getFtpPath()
        Return Me.ftpPath
    End Function
    Public Function getFtpUser()
        Return Me.ftpUser
    End Function
    Public Function getFtpPass()
        Return Me.ftpPass
    End Function
    Public Function getWebPath()
        Return Me.webPath
    End Function
    'FIN DE FUNCIONES VARIABLES FTPS

#End Region
End Class
