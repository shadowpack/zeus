Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public Class distribucion
#Region "PROPIEDADES"
    Private Sayc_Settings As Object
    Private valor As Integer
    Private action As String
    Private perfil As Perfiles_Pago
#End Region
#Region "CONSTRUCTOR"
    Sub New(obj As Object, valores As Integer, act As String, objpe As Perfiles_Pago)
        Me.Sayc_Settings = obj
        Me.valor = valores
        Me.action = act
        Me.perfil = objpe
        'INICIALIZAMOS LOS COMPONTENTES GRAFICOS
        InitializeComponent()
    End Sub
#End Region
#Region "METODOS DE CLASE"
    Private Function actuCC() As DataTable
        Dim consulta As Object = Me.Sayc_Settings.db_query("SELECT id_cc,name_cc FROM perfiles_cc WHERE perfiles_cc.active = 1")
        Dim dt = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")
        While consulta.read()
            Dim dr As DataRow
            dr = dt.NewRow()
            dr(1) = consulta(0)
            dr(0) = consulta(1)
            dt.Rows.Add(dr)
        End While
        Return dt
    End Function
    Private Sub actuValor()
        Dim contador = Me.valor
        For Each vector As Object In dgridDistri.Rows
            contador = contador - vector.Cells(1).Value
        Next
        lbldinero.Text = contador
    End Sub
#End Region
#Region "METODOS PUBLICOS"

#End Region
#Region "EVENTOS"
    Private Sub distribucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAMOS LAS CUENTAS CC DISPONIBLES
        Me.actuCC()
        'ACTUALIZAMOS LOS VALORES ASINADOS
        lbldinero.Text = Me.valor
        'DEFINIMOS LOS EVENTOS NECESARIOS PARA CARGAR VARIABLES PREDEFINIDAS EN P1,P2,P3,P4
        If Me.action = "p1" And Me.perfil.getp1() <> Nothing Then
            Dim consulta As JArray = JsonConvert.DeserializeObject(Me.perfil.getp1())
            Dim num As Integer = 0
            For Each vector As JObject In consulta
                Dim dgvCmbCell As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()
                Dim dtval As DataTable = Me.actuCC()
                dgvCmbCell.DataSource = dtval
                dgvCmbCell.DisplayMember = "Name"
                dgvCmbCell.ValueMember = "Value"
                dgvCmbCell.Value = vector.SelectToken("id").ToString
                dgridDistri.Rows.Add(Nothing, vector.SelectToken("valor").ToString)
                dgridDistri.Rows(num).Cells(0) = dgvCmbCell
                num += 1
            Next
            Me.actuValor()
        End If
        If Me.action = "p2" And Me.perfil.getp2() <> Nothing Then
            Dim consulta As Object = JsonConvert.DeserializeObject(Me.perfil.getp2())
            Dim num As Integer = 0
            For Each vector As JObject In consulta
                Dim dgvCmbCell As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()
                Dim dtval As DataTable = Me.actuCC()
                dgvCmbCell.DataSource = dtval
                dgvCmbCell.DisplayMember = "Name"
                dgvCmbCell.ValueMember = "Value"
                dgvCmbCell.Value = vector.SelectToken("id").ToString
                dgridDistri.Rows.Add(Nothing, vector.SelectToken("valor").ToString)
                dgridDistri.Rows(num).Cells(0) = dgvCmbCell
                num += 1
            Next
            Me.actuValor()
        End If
        If Me.action = "p3" And Me.perfil.getp3() <> Nothing Then
            Dim consulta As Object = JsonConvert.DeserializeObject(Me.perfil.getp3())
            Dim num As Integer = 0
            For Each vector As JObject In consulta
                Dim dgvCmbCell As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()
                Dim dtval As DataTable = Me.actuCC()
                dgvCmbCell.DataSource = dtval
                dgvCmbCell.DisplayMember = "Name"
                dgvCmbCell.ValueMember = "Value"
                dgvCmbCell.Value = vector.SelectToken("id").ToString
                dgridDistri.Rows.Add(Nothing, vector.SelectToken("valor").ToString)
                dgridDistri.Rows(num).Cells(0) = dgvCmbCell
                num += 1
            Next
            Me.actuValor()
        End If
        If Me.action = "p4" And Me.perfil.getp4() <> Nothing Then
            Dim consulta As Object = JsonConvert.DeserializeObject(Me.perfil.getp4())
            Dim num As Integer = 0
            For Each vector As JObject In consulta
                Dim dgvCmbCell As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()
                Dim dtval As DataTable = Me.actuCC()
                dgvCmbCell.DataSource = dtval
                dgvCmbCell.DisplayMember = "Name"
                dgvCmbCell.ValueMember = "Value"
                dgvCmbCell.Value = vector.SelectToken("id").ToString
                dgridDistri.Rows.Add(Nothing, vector.SelectToken("valor").ToString)
                dgridDistri.Rows(num).Cells(0) = dgvCmbCell
                num += 1
            Next
            Me.actuValor()
        End If
    End Sub
    'EVENTO QUE MANEJA EL DGRID
    Private Sub dgridDistri_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgridDistri.CellEndEdit
        If e.ColumnIndex = 1 Then
            If dgridDistri.Rows(e.RowIndex).Cells(1).Value > 0 And IsNumeric(dgridDistri.Rows(e.RowIndex).Cells(1).Value) Then
                Me.actuValor()
            Else
                MessageBox.Show("Debe especificar un valor valido para el pago")
            End If
        End If
    End Sub
    'EVENTO PARA MANEJAR EL BOTON
    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        If lbldinero.Text = 0 Then
            Dim matriz() As articulos
            Dim num As Integer = 0
            ReDim matriz(dgridDistri.Rows.Count - 1)
            For Each vector As Object In dgridDistri.Rows
                If (vector.Cells(1).Value <> "" And vector.Cells(1).Value <> "" And vector.Cells(1).Value > 0) Then
                    matriz(num) = New articulos(vector.Cells(0).Value(0), vector.Cells(1).Value)
                    num += 1
                End If
            Next
            If Me.action = "p1" Then
                Me.perfil.setp1(JsonConvert.SerializeObject(matriz))
            ElseIf Me.action = "p2" Then
                Me.perfil.setp2(JsonConvert.SerializeObject(matriz))
            ElseIf Me.action = "p3" Then
                Me.perfil.setp3(JsonConvert.SerializeObject(matriz))
            ElseIf Me.action = "p4" Then
                Me.perfil.setp4(JsonConvert.SerializeObject(matriz))
            End If
            Me.Close()
        Else
            MessageBox.Show("Debe Asignar Todo el Dinero a Cuentas Monetarias Antes de Continuar")
        End If
    End Sub
    'MANEJAMOS EL EVENTO PARA AGREGAR FILAS
    Private Sub dgridDistri_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgridDistri.RowsAdded
        Try
            If dgridDistri.Rows(e.RowIndex).Cells(0).Value = "" Then
                Dim dgvCmbCell As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()
                Dim dtval As DataTable = Me.actuCC()
                dgvCmbCell.DataSource = dtval
                dgvCmbCell.DisplayMember = "Name"
                dgvCmbCell.ValueMember = "Value"
                dgridDistri.Rows(e.RowIndex).Cells(0) = dgvCmbCell
                dgvCmbCell.Value = dtval.Rows(0)("Value")
            End If
        Catch ex As Exception

        End Try
    End Sub
    'MANEJAMOS EL EVENTO PARA AGREGAR COLUMNAS
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dgridDistri.Rows.Add(Nothing, Nothing)
    End Sub
    'EVENTO PARA MANEJAR EL RESTABLECIMIENTO DE LAS VARIABLES
    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        dgridDistri.Rows.Clear()
        Me.lbldinero.Text = Me.valor
    End Sub
#End Region
End Class
#Region "CLASES AUXILIARES"
Class articulos
#Region "PROPIEDADES"
    Public id As String
    Public valor As String
#End Region
#Region "CONSTRUCTOR"
    Public Sub New(id As String, valor As String)
        Me.id = id
        Me.valor = valor
    End Sub
#End Region
End Class
#End Region
