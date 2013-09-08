Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Threading
Public Class SAYC_ingreso_class
#Region "PROPIEDADES DE CLASE"
    'DEFINIMOS LAS VARIABLES DE CLASE
    Private webservice As New initFunction.initFunction
    Private obj As SAYC_ingreso
    Private pboxactu As New PictureBox
    Private Account As New AccountSelector
    Private user As New users
    'DELCARACION DEL TIMER
    Private timer As New System.Timers.Timer
#End Region
#Region "CONSTRUCTOR"
    'DEFINIMOS EL CONSTRUCTOR
    Public Sub New(obj As SAYC_ingreso, img As PictureBox)
        'DEFINIMOS METODO DE CONSTRCUTOR
        webservice.isAlive()
        'ASIGANMOS LOS ELEMENTOS DEL FORM A LAS PROPIEDADES DE CLASE
        Me.obj = obj
        Me.pboxactu = img
        'CARGAMOS EL TIMER
        Me.chargeTimer()
    End Sub
#End Region
#Region "METODOS DE CLASE"
    'ESTE METODO INTERCAMBIA DATOS CON EL SERVER PARA COMPROBAR ACTIVIDAD CON EL SERVER
    Private Sub Alive()
        Me.openActivity()
        Dim intenConect As Integer = 0
        Do
            Try
                If webservice.isAlive() = True Then
                    Exit Do
                Else
                    If intenConect > 5 Then
                        MessageBox.Show("Se ha perdido la conexion con el servidor. Se procedera a cerrar el software")
                        End
                    End If
                    intenConect += 1
                End If
            Catch ex As Exception
                If intenConect > 5 Then
                    MessageBox.Show("Se ha perdido la conexion con el servidor. Se procedera a cerrar el software")
                    End
                End If
                intenConect += 1
            End Try
        Loop
        Me.closeActivity()
    End Sub
    'ESTE METODO CAMBIA EL LA IMAGEN STATUS PARA MOSTRAR ACTIVIDAD
    Private Sub openActivity()
        Me.pboxactu.Image = Image.FromFile(Environment.CurrentDirectory & "\Imagenes\refresh.png")
    End Sub
    'ESTE METODO CAMBIA EL LA IMAGEN STATUS PARA MOSTRAR ACTIVIDAD
    Private Sub closeActivity()
        Me.pboxactu.Image = Image.FromFile(Environment.CurrentDirectory & "\Imagenes\refreshout.png")
    End Sub
    Private Sub chargeTimer()
        Me.timer.Interval = 2000
        Me.timer.AutoReset = True
        Me.timer.Enabled = True
        AddHandler Me.timer.Elapsed, AddressOf Me.patrol
        Me.timer.Start()
    End Sub
    'DEFINO AL METODO QUE LLAMA A ALIVE EN OTRO THREAD
    Private Sub patrol()
        Dim vigilante As New Thread(AddressOf Me.Alive)
        vigilante.Start()
    End Sub
    'DEFINIMOS METODO QUE CAMBIA LOS PARAMETROS EN EL FORM
    Private Sub updateUser(obj As SAYC_ingreso)
        obj.lblEmpresa.Enabled = True
        obj.lblNombre.Enabled = True
        obj.lblcar.Enabled = True
        obj.lblcontraseña.Enabled = True
        obj.lblname.Text = Me.user.name
        obj.lblname.Enabled = True
        obj.lblEmpre.Text = Me.user.companyName
        obj.lblEmpre.Enabled = True
        obj.lblcargo.Text = Me.user.appoint
        obj.lblcargo.Enabled = True
        obj.txtpassword.Enabled = True
        obj.txtpassword.Select()
        obj.btnIngreso.Enabled = True
    End Sub
#End Region
#Region "METODOS PUBLICOS"
    'DEFINIMOS METODOS PUBLICOS
    Public Sub get_user(obj As SAYC_ingreso)
        Me.openActivity()
        Dim users As JArray = JsonConvert.DeserializeObject(webservice.requestUser(obj.txtid.Text))
        Me.closeActivity()
        If users.Count = 1 Then
            Dim obje As JObject = users.Value(Of Object)(0)
            Me.setCompany(obje.SelectToken("empresaname"), obje.SelectToken("id_empresa"), obje.SelectToken("user"), obje.SelectToken("cargo"))
            updateUser(obj)
        ElseIf users.Count > 1 Then
            Account.main(Me)
            Account.chargeAccount(users)
            Account.ShowDialog()
            updateUser(obj)
        Else
            'INDICAMOS QUE EL USUARIO NO TIENE PERMISOS PARA INGRESAR
            MessageBox.Show("El usuario indicado no posee permisos para ingresar al software.")
            'RESTABLECEMOS EL FORMULARIO
            obj.txtid.Text = Nothing
            obj.txtid.Select()
        End If
    End Sub
    Public Sub setCompany(companyName As String, id As String, name As String, appoint As String)
        Me.user.companyName = companyName
        Me.user.id = id
        Me.user.name = name
        Me.user.appoint = appoint
    End Sub
    Public Sub loginUser(obj As SAYC_ingreso)
        Me.openActivity()
        Dim result As JObject = JsonConvert.DeserializeObject(webservice.logUser(obj.txtid.Text, obj.txtpassword.Text))
        Me.closeActivity()
        Dim sayc_setting As New SAYC_Settings(PrincipalScreen)
        sayc_setting.Extend(result)
        PrincipalScreen.loadForm(sayc_setting)
        obj.Hide()
    End Sub
#End Region
End Class
#Region "CLASES ADICIONALES"
Friend Class users
    Public companyName As String
    Public id As String
    Public name As String
    Public appoint As String
End Class
#End Region
