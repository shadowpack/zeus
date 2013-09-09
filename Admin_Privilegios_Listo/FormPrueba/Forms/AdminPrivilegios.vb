Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class AdminPrivilegios
#Region "PROPIEDADES DE CLASE"
    'PROPIEDADES DE CLASE
    Dim SAYC_settings As Object
#End Region
#Region "CONSTRUCTOR"
    'DEFINIMOS EL CONSTRUCTOR DE LA CLASE
    Sub New(setting As Object)
        Me.SAYC_settings = setting
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
#Region "METODOS DE CLASE"
    'METODO PAR OBETNER LOS MODULOS ASIGNADOS A LA EMPRESA
    Private Sub getModules()
        dgridPrivilegios.Rows.Clear()
        Dim consulta As Object = JsonConvert.DeserializeObject(SAYC_settings.securityVerify(Me.SAYC_settings.internalCore.getModules(Me.SAYC_settings.db_target, Me.SAYC_settings.db_user, Me.SAYC_settings.db_pass, Me.SAYC_settings.token, Me.SAYC_settings.getIdCompany())))
        For Each vector As JObject In consulta
            dgridPrivilegios.Rows.Add(vector.SelectToken("name"), vector.SelectToken("idProduct"), False, vector.SelectToken("id_module"))
        Next
    End Sub
    'METODO PARA OBTENER LOS PERFILES DE PRIVILEGIOS 
    Private Sub getPerfiles()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT perfiles_privilegio.id_perfil_privilegio, perfiles_privilegio.name FROM perfiles_privilegio")
        Dim dt = New DataTable("Tabla")
        dt.Columns.Add("Value")
        dt.Columns.Add("Name")
        Dim dl As DataRow
        dl = dt.NewRow()
        dl(0) = 0
        dl(1) = "Seleccione"
        dt.Rows.Add(dl)
        While consulta.read()
            Dim dr As DataRow
            dr = dt.NewRow()
            dr(0) = consulta(0)
            dr(1) = consulta(1)
            dt.Rows.Add(dr)
        End While
        Me.cboxPerfiles.DataSource = dt
        Me.cboxPerfiles.ValueMember = "Value"
        Me.cboxPerfiles.DisplayMember = "Name"
        Me.cboxPerfiles.SelectedIndex = 0
    End Sub
    'METODO QUE DETERMINA SI EL NOMBRE ES REPETIDO
    Private Function checkRepeat(name As String) As Boolean
        Dim status As Boolean = True
        For Each vector As Object In cboxPerfiles.Items
            If LCase(vector(1)) = LCase(name) Then
                status = False
            End If
        Next
        Return status
    End Function
#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS"
    'MANEJAMOS EL EVENTO DE CARGA DEL FORMULARIO
    Private Sub MoneyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.getModules()
        Me.getPerfiles()
        cboxAction.SelectedIndex = 0
    End Sub
    'MANEJAMOS EL EVENTO DE CAMBIO DEL COMBOBOX
    Private Sub cboxAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxAction.SelectedIndexChanged
        If cboxAction.SelectedIndex = 0 Then
            cboxPerfiles.Enabled = False
            txtNamePerfil.Enabled = True
        ElseIf cboxAction.SelectedIndex = 1 Then
            cboxPerfiles.Enabled = True
            txtNamePerfil.Enabled = False
        ElseIf cboxAction.SelectedIndex = 2 Then
            txtNamePerfil.Enabled = False
            cboxPerfiles.Enabled = True
        End If
    End Sub
    'MANEJAMOS EL EVENTO DE CAMBIO DEL COMBOBOX PERFILES
    Private Sub cboxPerfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPerfiles.SelectedIndexChanged
        If cboxPerfiles.SelectedIndex <> 0 Then
            Dim consulta As Object = Me.SAYC_settings.db_query("SELECT * FROM perfiles_privilegio WHERE perfiles_privilegio.id_perfil_privilegio='" & cboxPerfiles.selectedValue & "'")
            consulta.read()
            txtNamePerfil.Text = consulta(1)
            If consulta(3) = 1 Then
                checkAdmin.Checked = True
            End If
            Dim result As Object = Me.SAYC_settings.db_query("SELECT * FROM assign_modules WHERE assign_modules.id_perfil_privilegio='" & cboxPerfiles.selectedValue & "'")
            While result.read()
                For Each vector As DataGridViewRow In dgridPrivilegios.Rows
                    If vector.Cells(1).Value = result(2) Then
                        vector.Cells(2).Value = True
                        Exit For
                    End If
                Next
            End While
        End If
    End Sub
    'MANEJAMOS EL EVENTO DEL BTN ACTUALIZAR DATOS
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.SAYC_settings.adminOnly() Then
            If cboxAction.SelectedIndex = 0 Then
                If checkRepeat(txtNamePerfil.Text) Then
                    Dim admin As String = ""
                    If checkAdmin.Checked Then
                        admin = "1"
                    Else
                        admin = "0"
                    End If
                    Me.SAYC_settings.db_opquery("INSERT INTO perfiles_privilegio (perfiles_privilegio.name, perfiles_privilegio.admin) VALUES ('" & txtNamePerfil.Text & "', '" & admin & "')")
                    Dim consulta As Object = Me.SAYC_settings.db_query("SELECT id_perfil_privilegio FROM perfiles_privilegio WHERE perfiles_privilegio.name='" & txtNamePerfil.Text & "' ORDER BY DESC")
                    consulta.read()
                    For Each vector As DataGridViewRow In dgridPrivilegios.Rows
                        If vector.Cells(2).Value = True Then
                            Me.SAYC_settings.db_opquery("INSERT INTO assign_modules (assign_modules.id_module,assign_modules.id_perfil_privilegio,assign_modules.idProduct) VALUES ('" & vector.Cells(3).Value & "',  '" & consulta(0) & "', '" & vector.Cells(1).Value & "')")
                        End If
                    Next
                    MessageBox.Show("Perfil agregado con exito")
                Else
                    MessageBox.Show("El Perfil indicado se encuentra repetido. Por favor especifique otro")
                End If
            ElseIf cboxAction.SelectedIndex = 1 Then
                Dim admin As String = ""
                If checkAdmin.Checked Then
                    admin = "1"
                Else
                    admin = "0"
                End If
                Me.SAYC_settings.db_opquery("UPDATE perfiles_privilegio SET perfiles_privilegio.name='" & txtNamePerfil.Text & "', perfiles_privilegio.admin='" & admin & "' WHERE perfiles_privilegio.id_perfil_privilegio='" & cboxPerfiles.selectedValue & "'")
                Me.SAYC_settings.db_opquery("DELETE FROM assign_modules WHERE assign_modules.id_perfil_privilegio='" & cboxPerfiles.selectedValue & "'")
                For Each vector As DataGridViewRow In dgridPrivilegios.Rows
                    If vector.Cells(2).Value = True Then
                        Me.SAYC_settings.db_opquery("INSERT INTO assign_modules (assign_modules.id_module,assign_modules.id_perfil_privilegio,assign_modules.idProduct) VALUES ('" & vector.Cells(3).Value & "',  '" & cboxPerfiles.selectedValue & "', '" & vector.Cells(1).Value & "')")
                    End If
                Next
                MessageBox.Show("Perfil modificado con exito")
            ElseIf cboxAction.SelectedIndex = 2 Then
                If Me.SAYC_settings.securityVerify(Me.SAYC_settings.internalCore.deletePrivilege(Me.SAYC_settings.db_target, Me.SAYC_settings.db_user, Me.SAYC_settings.db_pass, Me.SAYC_settings.token, Me.SAYC_settings.privilege, Me.SAYC_settings.id_company)) = "true" Then
                    MessageBox.Show("Perfil eliminado con exito")
                End If
            End If
        End If
    End Sub
    'MANEJAMOS EL EVENTO DEL BTN RESTABLECER
    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        txtNamePerfil.Text = Nothing
        cboxAction.SelectedIndex = 0
        getModules()
        getPerfiles()
    End Sub
#End Region
End Class