Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Perfiles_Pago
#Region "PROPIEDADES DE CLASE"
    'PROPIEDADES DE CLASE
    Private SAYC_settings As Object
    Private distrip1 As String = Nothing
    Private distrip2 As String = Nothing
    Private distrip3 As String = Nothing
    Private distrip4 As String = Nothing
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
    Private Sub checkPerfiles()
        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT id_perfil, name_perfil FROM tipo_perfil WHERE tipo_perfil.status=1")
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

    End Sub
    'METODO PARA LIMPIAR EL FORM COMPLETO
    Private Sub limpiar()
        Me.checkPerfiles()
        cboxAction.SelectedIndex = 0
        cboxPerfiles.SelectedIndex = 0
        txtp1.Text = "0"
        txtp2.Text = "0"
        txtp3.Text = "0"
        txtp4.Text = "0"
        checkp1.Checked = True
        checkp2.Checked = True
        checkp3.Checked = True
        checkp4.Checked = True
        Me.distrip1 = Nothing
        Me.distrip2 = Nothing
        Me.distrip3 = Nothing
        Me.distrip4 = Nothing
    End Sub
    'FUNCION PARA CORRELACIONAR EL VALOR INGRESADO CON EL DISTRIBUIDO
    Private Function checkCash(valor As String, distri As String) As Boolean
        If distri <> Nothing Then
            Dim acumulado As Integer = 0
            Dim matriz As JArray = JsonConvert.DeserializeObject(distri)
            For Each vector As JObject In matriz
                acumulado += vector.SelectToken("valor").ToString()
            Next
            If acumulado = valor Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region
#Region "METODOS PUBLICOS"
    'DEFINIMOS LOS METODOS PARA SETEAR LAS DISTRIBUCIONES
    Public Sub setp1(sett As String)
        Me.distrip1 = sett
    End Sub
    Public Sub setp2(sett As String)
        Me.distrip2 = sett
    End Sub
    Public Sub setp3(sett As String)
        Me.distrip3 = sett
    End Sub
    Public Sub setp4(sett As String)
        Me.distrip4 = sett
    End Sub
    'DEFINIMOS LOS METODOS PARA OBTENER LAS DISTRIBUCIONES
    Public Function getp1() As String
        Return distrip1
    End Function
    Public Function getp2() As String
        Return distrip2
    End Function
    Public Function getp3() As String
        Return distrip3
    End Function
    Public Function getp4() As String
        Return Me.distrip4
    End Function
#End Region
#Region "EVENTOS"
    'MANEJAMOS EL EVENTO LOAD DEL FORMULARIO
    Private Sub MoneyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxAction.SelectedIndex = 0
        Me.checkPerfiles()
    End Sub
    'EVENTO QUE MANEJA EL EVENTO LOAD
    Private Sub ConfigurarNombresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarNombresToolStripMenuItem.Click
        Dim config As New Opciones_Perfiles_Pago(SAYC_settings)
        config.ShowDialog()
    End Sub
    'EVENTO QUE MANEJA EL PRIMER BOTON
    Private Sub btnPrimario_Click(sender As Object, e As EventArgs) Handles btnPrimario.Click
        If IsNumeric(txtp1.Text) Then
            If txtp1.Text > 0 Then
                Dim distri As New distribucion(Me.SAYC_settings, txtp1.Text, "p1", Me)
                distri.ShowDialog()
            Else
                MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
            End If
        Else
            MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
        End If
    End Sub
    'EVENTO QUE MANEJA EL SEGUNDO BOTON
    Private Sub btnSecundario_Click(sender As Object, e As EventArgs) Handles btnSecundario.Click
        If IsNumeric(txtp2.Text) Then
            If txtp2.Text > 0 Then
                Dim distri As New distribucion(Me.SAYC_settings, txtp2.Text, "p2", Me)
                distri.ShowDialog()
            Else
                MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
            End If
        Else
            MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
        End If
    End Sub
    'EVENTO QUE MANEJA EL TERCER BOTON
    Private Sub btnTerciario_Click(sender As Object, e As EventArgs) Handles btnTerciario.Click
        If IsNumeric(txtp3.Text) Then
            If txtp3.Text > 0 Then
                Dim distri As New distribucion(Me.SAYC_settings, txtp3.Text, "p3", Me)
                distri.ShowDialog()
            Else
                MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
            End If
        Else
            MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
        End If
    End Sub
    'EVENTO QUE MANEJA EL CUARTO BOTON
    Private Sub btnCuaternario_Click(sender As Object, e As EventArgs) Handles btnCuaternario.Click
        If IsNumeric(txtp4.Text) Then
            If txtp4.Text > 0 Then
                Dim distri As New distribucion(Me.SAYC_settings, txtp4.Text, "p4", Me)
                distri.ShowDialog()
            Else
                MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
            End If
        Else
            MessageBox.Show("Debe especificar un monto mayor que cero para el pago indicado")
        End If
    End Sub
    'EVENTOS PARA MANEJAR LOS CHECKBOX DE HABILITACION
    'CHECKBOX1 P1
    Private Sub checkp1_CheckedChanged(sender As Object, e As EventArgs) Handles checkp1.CheckedChanged
        If checkp1.Checked Then
            txtp1.Text = 0
            txtp1.Enabled = True
            btnPrimario.Enabled = True
        Else
            txtp1.Text = Nothing
            txtp1.Enabled = False
            Me.distrip1 = Nothing
            btnPrimario.Enabled = False
        End If
    End Sub
    'CHECKBOX2 P2
    Private Sub checkp2_CheckedChanged(sender As Object, e As EventArgs) Handles checkp2.CheckedChanged
        If checkp2.Checked Then
            txtp2.Text = 0
            txtp2.Enabled = True
            btnSecundario.Enabled = True
        Else
            txtp2.Text = Nothing
            txtp2.Enabled = False
            Me.distrip2 = Nothing
            btnSecundario.Enabled = False
        End If
    End Sub
    'CHECKBOX3 P3
    Private Sub checkp3_CheckedChanged(sender As Object, e As EventArgs) Handles checkp3.CheckedChanged
        If checkp3.Checked Then
            txtp3.Text = 0
            txtp3.Enabled = True
            btnTerciario.Enabled = True
        Else
            txtp3.Text = Nothing
            txtp3.Enabled = False
            Me.distrip3 = Nothing
            btnTerciario.Enabled = False
        End If
    End Sub
    'CHECKBOX4 P4
    Private Sub checkp4_CheckedChanged(sender As Object, e As EventArgs) Handles checkp4.CheckedChanged
        If checkp4.Checked Then
            txtp4.Text = 0
            txtp4.Enabled = True
            btnCuaternario.Enabled = True
        Else
            txtp4.Text = Nothing
            txtp4.Enabled = False
            Me.distrip4 = Nothing
            btnCuaternario.Enabled = False
        End If
    End Sub
    'EVENTO PARA CONTROLAR QUE SOLO INGRESEN NUMEROS EN LOS TEXTBOX
    Private Sub txtp1_TextChanged(sender As Object, e As EventArgs) Handles txtp1.TextChanged
        If Not IsNumeric(txtp1.Text) And txtp1.Text <> Nothing Then
            MessageBox.Show("Debe especificar un monto numerico")
            txtp1.Text = 0
        End If
    End Sub

    Private Sub txtp2_TextChanged(sender As Object, e As EventArgs) Handles txtp2.TextChanged
        If Not IsNumeric(txtp2.Text) And txtp2.Text <> Nothing Then
            MessageBox.Show("Debe especificar un monto numerico")
            txtp2.Text = 0
        End If
    End Sub

    Private Sub txtp3_TextChanged(sender As Object, e As EventArgs) Handles txtp3.TextChanged
        If Not IsNumeric(txtp3.Text) And txtp3.Text <> Nothing Then
            MessageBox.Show("Debe especificar un monto numerico")
            txtp3.Text = 0
        End If
    End Sub

    Private Sub txtp4_TextChanged(sender As Object, e As EventArgs) Handles txtp4.TextChanged
        If Not IsNumeric(txtp4.Text) And txtp4.Text <> Nothing Then
            MessageBox.Show("Debe especificar un monto numerico")
            txtp4.Text = 0
        End If
    End Sub
    'MANEJAMOS EL EVENTO CBOX QUE ACTIVA Y DESACTIVA LA POSIBILIDAD DE MODIFICAR UN PERFIL
    Private Sub cboxAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxAction.SelectedIndexChanged
        If cboxAction.SelectedIndex = 0 Then
            cboxPerfiles.Enabled = False
            Me.distrip1 = Nothing
            Me.distrip2 = Nothing
            Me.distrip3 = Nothing
            Me.distrip4 = Nothing
            Me.txtNamePerfil.Enabled = True
        ElseIf cboxAction.SelectedIndex = 1 Then
            cboxPerfiles.Enabled = True
            Me.txtNamePerfil.Enabled = False
        End If
    End Sub
    'MANEJAMOS EL EVENTO PARA SELECCIONAR UNO DE LOS PERFILES A MODIFICAR
    Private Sub cboxPerfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPerfiles.SelectedIndexChanged
        If cboxPerfiles.SelectedIndex <> 0 Then
            Dim consulta As Object = Me.SAYC_settings.db_query("SELECT * FROM tipo_perfil WHERE tipo_perfil.id_perfil='" & cboxPerfiles.SelectedItem(0) & "' AND tipo_perfil.status = 1")
            While consulta.read()
                'ITERAMOS LOS VALORES UNO POR UNO PARA DETERMINAR ESTADO DEL PERFIL
                'ASIGANAMOS EL NOMBRE
                Me.txtNamePerfil.Text = consulta(1)
                'PAGO PRIMARIO
                If consulta(2) = 0 Or consulta(6) = "" Then
                    checkp1.Checked = False
                Else
                    Me.distrip1 = consulta(6)
                    txtp1.Text = consulta(2)
                End If
                'PAGO SECUNDARIO
                If consulta(3) = 0 Or consulta(7) = "" Then
                    checkp2.Checked = False
                Else
                    Me.distrip2 = consulta(7)
                    txtp2.Text = consulta(3)
                End If
                'PAGO TERCIARIO
                If consulta(4) = 0 Or consulta(8) = "" Then
                    checkp3.Checked = False
                Else
                    Me.distrip3 = consulta(8)
                    txtp3.Text = consulta(4)
                End If
                'PAGO CUATERNARIO
                If consulta(5) = 0 Or consulta(9) = "" Then
                    checkp4.Checked = False
                Else
                    Me.distrip4 = consulta(9)
                    txtp4.Text = consulta(5)
                End If
            End While
        End If
    End Sub
    'MANEJAMOS EL EVENTO PARA AGREGAR PERFILES DE PAGO
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.SAYC_settings.adminOnly() Then
            If Me.cboxAction.SelectedIndex = 0 Then
                If Me.txtNamePerfil.Text <> Nothing Then
                    Dim status As Boolean = True
                    If Not ((checkp1.Checked And txtp1.Text <> Nothing And Me.distrip1 <> Nothing And Me.checkCash(Me.txtp1.Text, Me.distrip1)) Or Not checkp1.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago primario")
                        status = False
                    End If
                    If Not ((checkp2.Checked And txtp2.Text <> Nothing And Me.distrip2 <> Nothing And Me.checkCash(Me.txtp2.Text, Me.distrip2)) Or Not checkp2.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago secundario")
                        status = False
                    End If
                    If Not ((checkp3.Checked And txtp3.Text <> Nothing And Me.distrip3 <> Nothing And Me.checkCash(Me.txtp3.Text, Me.distrip3)) Or Not checkp3.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago terciario")
                        status = False
                    End If
                    If Not ((checkp4.Checked And txtp4.Text <> Nothing And Me.distrip4 <> Nothing And Me.checkCash(Me.txtp4.Text, Me.distrip4)) Or Not checkp4.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago cuaternario")
                        status = False
                    End If
                    If status Then
                        Dim consulta As Object = SAYC_settings.db_query("SELECT COUNT(*) FROM tipo_perfil WHERE tipo_perfil.name_perfil='" & Me.txtNamePerfil.Text & "' AND tipo_perfil.status=1")
                        consulta.read()
                        If consulta(0) = 0 Then
                            Me.SAYC_settings.db_opquery("INSERT INTO tipo_perfil (name_perfil,p1,p2,p3,p4,detail_p1,detail_p2,detail_p3,detail_p4,status) VALUES ('" & Me.txtNamePerfil.Text & "', '" & Me.txtp1.Text & "', '" & Me.txtp2.Text & "', '" & Me.txtp3.Text & "', '" & Me.txtp4.Text & "', '" & Me.distrip1 & "', '" & Me.distrip2 & "', '" & Me.distrip3 & "', '" & Me.distrip4 & "', 1)")
                            MessageBox.Show("Perfil de pago agregado con Exito")
                            Me.limpiar()
                        Else
                            MessageBox.Show("Ya existe un perfil activo con el nombre indicado")
                        End If
                    End If
                Else
                    MessageBox.Show("Debe Asignar un nombre al nuevo perfil")
                End If
            ElseIf Me.cboxAction.SelectedIndex = 1 Then
                If Me.txtNamePerfil.Text <> Nothing Then
                    Dim status As Boolean = True
                    If Not ((checkp1.Checked And txtp1.Text <> Nothing And Me.distrip1 <> Nothing And Me.checkCash(Me.txtp1.Text, Me.distrip1)) Or Not checkp1.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago primario")
                        status = False
                    End If
                    If Not ((checkp2.Checked And txtp2.Text <> Nothing And Me.distrip2 <> Nothing And Me.checkCash(Me.txtp2.Text, Me.distrip2)) Or Not checkp2.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago secundario")
                        status = False
                    End If
                    If Not ((checkp3.Checked And txtp3.Text <> Nothing And Me.distrip3 <> Nothing And Me.checkCash(Me.txtp3.Text, Me.distrip3)) Or Not checkp3.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago terciario")
                        status = False
                    End If
                    If Not ((checkp4.Checked And txtp4.Text <> Nothing And Me.distrip4 <> Nothing And Me.checkCash(Me.txtp4.Text, Me.distrip4)) Or Not checkp4.Checked) Then
                        MessageBox.Show("Debe asignar valores y distribuciones correctas para el pago cuaternario")
                        status = False
                    End If
                    If status Then
                        Me.SAYC_settings.db_opquery("UPDATE tipo_perfil SET tipo_perfil.status=0 WHERE tipo_perfil.id_perfil='" & cboxPerfiles.SelectedValue & "' AND tipo_perfil.status=1")
                        Me.SAYC_settings.db_opquery("INSERT INTO tipo_perfil (name_perfil,p1,p2,p3,p4,detail_p1,detail_p2,detail_p3,detail_p4,status) VALUES ('" & Me.txtNamePerfil.Text & "', '" & Me.txtp1.Text & "', '" & Me.txtp2.Text & "', '" & Me.txtp3.Text & "', '" & Me.txtp4.Text & "', '" & Me.distrip1 & "', '" & Me.distrip2 & "', '" & Me.distrip3 & "', '" & Me.distrip4 & "', 1)")
                        Dim consulta As Object = Me.SAYC_settings.db_query("SELECT id_perfil FROM tipo_perfil WHERE tipo_perfil.name_perfil='" & Me.txtNamePerfil.Text & "' AND tipo_perfil.status=1")
                        consulta.read()
                        Me.SAYC_settings.db_opquery("UPDATE cuenta SET cuenta.tipo_perfil='" & consulta(0) & "' WHERE cuenta.tipo_perfil='" & Me.cboxPerfiles.SelectedValue & "'")
                        MessageBox.Show("Perfil de pago modificado con Exito")
                        Me.limpiar()
                    End If
                Else
                    MessageBox.Show("Debe Asignar un nombre al nuevo perfil")
                End If
            End If
        End If
    End Sub
    'MANEJAMOS EL METODO PARA LIMPIAR LOS DATOS
    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        Me.limpiar()
    End Sub
#End Region
End Class