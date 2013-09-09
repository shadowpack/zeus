Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class addAccount
#Region "PROPIEDADES DE CLASE"
    Private Sayc_Settings As Object
    Private otrosPagos As OtrosPagos
    Private accounts As String
    Private status As Boolean = False
#End Region
#Region "CONSTRUCTOR"
    Sub New(obj As Object, otros As OtrosPagos, accounts As String)
        Me.Sayc_Settings = obj
        Me.otrosPagos = otros
        Me.accounts = accounts
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
#End Region
#Region "METODOS DE CLASE"
    'METODO PARA OBTENER LOS USUARIOS ASOCIADOS A LA EMPRESA
    Private Sub getUsers()
        dgridAddAccount.Rows.Clear()
        Dim consulta As Object = Me.Sayc_Settings.db_query("SELECT id_cuenta, name_cuenta FROM cuenta")
        While consulta.read()
            dgridAddAccount.Rows.Add(consulta(0), consulta(1))
        End While
    End Sub
    'METODO PARA RECUPERAR LOS USUARIOS
    Private Sub recuperar()
        If Me.accounts <> Nothing Then
            Dim account As JArray = JsonConvert.DeserializeObject(Me.accounts)
            For Each vector As JObject In account
                For Each puntero As DataGridViewRow In dgridAddAccount.Rows()
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
        Dim account() As items
        Dim puntero As Integer = 0
        ReDim account(dgridAddAccount.Rows.Count)
        For Each vector As DataGridViewRow In dgridAddAccount.Rows
            If vector.Cells(2).Value = True Then
                account(puntero) = New items(vector.Cells(0).Value, vector.Cells(1).Value)
                puntero += 1
            End If
        Next
        Dim llave As String = JsonConvert.SerializeObject(account)
        Me.otrosPagos.setAccount(llave)
        Me.status = True
        Me.Close()
    End Sub
#End Region
End Class