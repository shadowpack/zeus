Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class addUsers
#Region "PROPIEDADES DE CLASE"
    Private Sayc_Settings As Object
    Private otrosPagos As OtrosPagos
    Private users As String = Nothing
    Private status As Boolean = False
#End Region
#Region "CONSTRUCTOR"
    Sub New(obj As Object, otros As OtrosPagos, users As String)
        Me.Sayc_Settings = obj
        Me.otrosPagos = otros
        Me.users = users
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
#End Region
#Region "METODOS DE CLASE"
    'METODO PARA OBTENER LOS USUARIOS ASOCIADOS A LA EMPRESA
    Private Sub getUsers()
        dgridAddUser.Rows.Clear()
        Dim consulta As JArray = JsonConvert.DeserializeObject(Me.Sayc_Settings.securityVerify(Me.Sayc_Settings.internalCore.getUser(Me.Sayc_Settings.db_target, Me.Sayc_Settings.db_user, Me.Sayc_Settings.db_pass, Me.Sayc_Settings.token, Me.Sayc_Settings.getIdCompany())))
        For Each vector As JObject In consulta
            dgridAddUser.Rows.Add(vector.SelectToken("user_id").ToString, vector.SelectToken("name").ToString)
        Next
    End Sub
    'METODO PARA RECUPERAR LOS USUARIOS
    Private Sub recuperar()
        If Me.users <> Nothing Then
            Dim users As JArray = JsonConvert.DeserializeObject(Me.users)
            For Each vector As JObject In users
                For Each puntero As DataGridViewRow In dgridAddUser.Rows
                    If vector.SelectToken("id") = puntero.Cells(0).Value Then
                        puntero.Cells(2).Value = True
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub
#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS DE CLASE"
    'MANEJADOR DE LA CARGA DEL FORMULARIO
    Private Sub addUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.getUsers()
        Me.recuperar()
    End Sub
    'MANEJADOR DEL EVENTO RESTABLECER
    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        Me.getUsers()
        Me.recuperar()
    End Sub
    'MANEJADOR DEL BOTON AGREGAR
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim users() As items
        Dim puntero As Integer = 0
        ReDim users(dgridAddUser.Rows.Count - 1)
        For Each vector As DataGridViewRow In dgridAddUser.Rows
            If vector.Cells(2).Value = True Then
                users(puntero) = New items(vector.Cells(0).Value, vector.Cells(1).Value)
                puntero += 1
            End If
        Next
        Dim llave As String = JsonConvert.SerializeObject(users)
        Me.otrosPagos.setUsers(llave)
        Me.status = True
        Me.Close()
    End Sub
    
#End Region
End Class