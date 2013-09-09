Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class searchUser
#Region "PROPIEDADES"
    Private account As Accounts
    Private SAYC_settings As Object
    Private status As Boolean = False
#End Region
#Region "CONSTRUCTOR"
    Sub New(obj As Accounts, sayc_settings As Object)
        Me.account = obj
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
#End Region
#Region "METODOS DE CLASE"

#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS DE CLASE"
    'MANEJADOR PARA EL EVENTO DE FORMATO DE RUT
    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim rut As String = Me.account.txt_rut.Text
        rut = rut.Replace(".", "")
        rut = rut.Replace("-", "")
        If rut > 8 Then
            txtId.Text = account.getRutFormato(txtId.Text)
        End If
    End Sub
    'MANEJADOR PARA EL EVENTO DEL BOTON BUSCAR
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim resp As String = SAYC_settings.securityVerify(SAYC_settings.internalCore.searchUser(SAYC_settings.db_target, SAYC_settings.db_user, SAYC_settings.db_pass, SAYC_settings.token, Me.txtId.Text))
        If resp <> "nobody" Then
            Dim consulta As JArray = JsonConvert.DeserializeObject(resp)
            For Each vector As JObject In consulta
                account.txt_name.Text = vector.SelectToken("name")
                account.txt_rut.Text = vector.SelectToken("rut")
                account.txt_telefono.Text = vector.SelectToken("fono")
                account.txt_telefono_movil.Text = vector.SelectToken("fono_movil")
                account.txt_id.Text = vector.SelectToken("user_id")
                account.txt_direccion.Text = vector.SelectToken("direccion")
                account.photoCheck1.Checked = True
                Me.status = True
            Next
            Me.Close()
        Else
            MessageBox.Show("El usuario indicado no se encuentra registrado. Por favor proceda a crearlo")
            Me.status = False
        End If

    End Sub
    'EVENTO PARA MANEJAR EL CIERRE DEL FORM
    Private Sub searchUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not Me.status Then
            account.userAdd.Checked = True
        End If
    End Sub
#End Region
End Class