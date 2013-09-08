Public Class Accounts
#Region "PROPIEDADES DE CLASE"
    Private settingObj As Object
    Private internalCore As New internalFunction.internalFunction
    Private photo As Boolean = False
    Private rut As New cRUNRUTChileno()
#End Region
#Region "CONSTRUCTOR"
    Sub New(obj As Object)
        Me.settingObj = obj
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
#End Region
#Region "METODOS DE CLASE"
    Private Function validarRut(ByVal rut_Verificar As String) As Boolean
        If txt_rut.Text.Length > 8 Then
            Dim rut As String = txt_rut.Text
            If Me.rut.Valida(rut) Then
                txt_rut.Text = rut
                Return True
            Else
                txt_rut.Text = Nothing
                Return False
            End If
        Else
            Return False
        End If
    End Function
    'FUNCION PARA FORMATEAR EL RUT
    Public Function getRutFormato(ByVal rut As String) As String
        Dim FRut(5) As String
        rut = rut.Replace(".", "")
        rut = rut.Replace("-", "")
        If rut.Length = 9 Then
            FRut(0) = rut.Substring(0, 2)
            FRut(1) = rut.Substring(2, 3)
            FRut(2) = rut.Substring(5, 3)
            FRut(3) = rut.Substring(8, 1)
        End If
        If rut.Length() = 8 Then
            FRut(0) = rut.Substring(0, 1)
            FRut(1) = rut.Substring(1, 3)
            FRut(2) = rut.Substring(4, 3)
            FRut(3) = rut.Substring(7, 1)
        End If
        Return FRut(0) & "." & FRut(1) & "." & FRut(2) & "-" & FRut(3)
    End Function
#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS DE CLASE"
    Private Sub btn_photo_Click(sender As Object, e As EventArgs) Handles btn_photo.Click
        Dim photocam As New CapturaWebcam.Frm_Index
        photocam.setName(Me.txt_id.Text & ".jpg")
        photocam.setPath(Environment.CurrentDirectory & "\TempImages\")
        photocam.ShowDialog()
        If photocam.getPhotoStatus() Then
            Me.pboxPhoto.Image = My.Resources.apply
            Me.photo = True
        Else
            Me.pboxPhoto.Image = My.Resources.agt_action_fail
            Me.photo = False
        End If
    End Sub
    'EVENTOS QUE DEFINEN LA DESACTIVACIOND DE USO DE LAS HERRAMIENTAS DE PHOTO
    Private Sub photoCheck1_CheckedChanged(sender As Object, e As EventArgs)
        pboxPhoto.Enabled = True
        btn_photo.Enabled = True
    End Sub
    Private Sub photoCheck2_CheckedChanged(sender As Object, e As EventArgs) Handles photoCheck2.CheckedChanged
        pboxPhoto.Enabled = False
        btn_photo.Enabled = False
    End Sub
    'EVENTO QUE CREA UN NUEVO USUARIO EN LA SELECCION
    Private Sub userAdd_CheckedChanged(sender As Object, e As EventArgs) Handles userAdd.CheckedChanged
        If userAdd.Checked Then
            Dim setting As List(Of String) = Me.settingObj.getdbvars()
            Me.txt_id.Text = Me.internalCore.getIdUser(setting(0), setting(1), setting(2), setting(3))
        End If
    End Sub
    'EVENTO PARA ACTIVAR BUSQUEDA DE USUARIO
    Private Sub userSearch_CheckedChanged(sender As Object, e As EventArgs) Handles userSearch.CheckedChanged
        If userSearch.Checked Then
            Dim buscar As New searchUser(Me, Me.settingObj)
            buscar.ShowDialog()
        End If
    End Sub
    'EVENTO PARA ACTUALIZAR LOS DATOS DEL USUARIO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Errors As New List(Of String)
        If Me.txt_name.TextLength = 0 Then
            Errors.Add("Debe Indicar un nombre para el Usuario")
        End If
        If Not Me.validarRut(Me.txt_rut.Text) Then
            Errors.Add("El rut indicado no es valido, o su formato es incorrecto")
        End If
        If Me.txt_direccion.TextLength = 0 Then
            Errors.Add("Debe indicar una direccion valida")
        End If
        If Me.txt_telefono.TextLength = 0 Then
            Errors.Add("Debe indicar un Telefono fijo valido, en caso de no posee escriba 'No Registra'")
        End If
        If Me.txt_telefono_movil.TextLength = 0 Then
            Errors.Add("Debe indicar un Telefono movil valido, en caso de no posee escriba 'No Registra'")
        End If
        If Me.txt_id.TextLength = 0 Then
            Errors.Add("Existe un error debido a que el id no se genero adecuadamente")
        End If
        If Not Me.photo Then
            Errors.Add("No se ha indicado una fotografia de forma correcta. En caso de no requerir fotografia indique la opcion 'No tomar fotografia'")
        End If
        If Errors.Count > 0 Then
            Dim ErrorString As String = "Existen Errores en los campos indicados" & Chr(13) & Chr(13)
            Dim key As Integer = 1
            For Each vector As String In Errors
                ErrorString &= key & "- " & vector & Chr(13)
                key += 1
            Next
            MessageBox.Show(ErrorString)
        Else
            If Me.userAdd.Checked Then
                Try
                    Dim photo As String
                    Dim local As String = Environment.CurrentDirectory & "/TempImages/" & Me.txt_id.Text & ".jpg"
                    Dim remoto As String = Me.settingObj.getFtpPath() & "/Repositorio/Imagenes/" & Me.txt_id.Text & ".jpg"
                    If photoCheck1.Checked Then
                        Dim credencial As Net.NetworkCredential = New Net.NetworkCredential
                        credencial.UserName = Me.settingObj.getFtpUser()
                        credencial.Password = Me.settingObj.getFtpPass()
                        Dim icrede As Net.ICredentials = credencial
                        My.Computer.Network.UploadFile(local, New Uri(remoto), icrede, True, 500)
                        System.IO.File.Delete(local)
                        photo = Me.settingObj.getWebPath() & "/Repositorio/Imagenes/" & Me.txt_id.Text & ".jpg"
                    ElseIf photoCheck2.Checked Then
                        photo = "noPhoto"
                    End If
                    Dim resp As String = Me.settingObj.securityVerify(Me.settingObj.internalCore.newUser(Me.settingObj.db_target, Me.settingObj.db_user, Me.settingObj.db_pass, Me.settingObj.token, Me.txt_name.Text, Me.txt_rut.Text, Me.txt_direccion.Text, Me.txt_telefono.Text, Me.txt_telefono_movil.Text, Me.txt_id.Text, photo, Me.settingObj.getIdCompany()))
                    If resp = "true" Then
                        MessageBox.Show("Usuario Creado Con Exito")
                    ElseIf resp = "repeat" Then
                        If photoCheck1.Checked Then
                            Dim FTPRequest As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(remoto), System.Net.FtpWebRequest)
                            Dim crede As New Net.NetworkCredential
                            crede.UserName = Me.settingObj.getFtpUser()
                            crede.Password = Me.settingObj.getFtpPass()
                            FTPRequest.Credentials = crede
                            FTPRequest.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
                            Dim FTPDelResp As Net.FtpWebResponse = FTPRequest.GetResponse
                        End If
                        MessageBox.Show("Ya existe un usuario creado con el rut especificado. Proceda a buscarlo para ingresarlo como usuario de su empresa")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    MessageBox.Show("Existe un error al cargar la fotografia en el servidor")
                End Try
            ElseIf Me.userSearch.Checked Then
                Dim photo As String = Nothing
                If photoCheck1.Checked Then
                    Dim local As String = Environment.CurrentDirectory & "/TempImages/" & Me.txt_id.Text & ".jpg"
                    Dim remoto As String = Me.settingObj.getFtpPath() & "/Repositorio/Imagenes/" & Me.txt_id.Text & ".jpg"
                    Dim credencial As Net.NetworkCredential = New Net.NetworkCredential
                    credencial.UserName = Me.settingObj.getFtpUser()
                    credencial.Password = Me.settingObj.getFtpPass()
                    Dim icrede As Net.ICredentials = credencial
                    My.Computer.Network.UploadFile(local, New Uri(remoto), icrede, True, 500)
                    System.IO.File.Delete(local)
                    photo = Me.settingObj.getWebPath() & "/Repositorio/Imagenes/" & Me.txt_id.Text & ".jpg"
                End If
                Dim resp As String = Me.settingObj.securityVerify(Me.settingObj.internalCore.modUser(Me.settingObj.db_target, Me.settingObj.db_user, Me.settingObj.db_pass, Me.settingObj.token, Me.txt_name.Text, Me.txt_rut.Text, Me.txt_direccion.Text, Me.txt_telefono.Text, Me.txt_telefono_movil.Text, Me.txt_id.Text, photo, Me.settingObj.getIdCompany()))
                If resp = "true" Then
                    MessageBox.Show("Usuario modificado con exito")
                End If
            End If
        End If
    End Sub
    'ESTABLECE METODO PARA FORMATO DE RUT
    Private Sub txt_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_rut.TextChanged
        Dim rut As String = txt_rut.Text
        rut = rut.Replace(".", "")
        rut = rut.Replace("-", "")
        If rut > 8 Then
            txt_rut.Text = Me.getRutFormato(txt_rut.Text)
        End If
    End Sub
#End Region
End Class
