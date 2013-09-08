Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public Class AccountSelector
#Region "PROPIEDADES"
    'PROPIEDADES CLASE
    Private obj As SAYC_ingreso_class
    Private name As String
#End Region
#Region "CONSTRUCTOR"
    'DECLARAMOS EL CONSTRUCTOR
    Public Sub main(obj As SAYC_ingreso_class)
        Me.obj = obj
        Me.name = name
    End Sub
#End Region
#Region "METODOS DE CLASE"
    'DECLARAMOS LOS METODOS DE CLASE
#End Region
#Region "METODOS PUBLICOS"
    'DECLARAMOS LOS METODOS PUBLICOS
    Public Sub chargeAccount(accounts As JArray)
        For Each vector As JObject In accounts.Values(Of Object)()
            dgridSelector.Rows.Add(vector.SelectToken("id_empresa"), vector.SelectToken("empresaname"), vector.SelectToken("cargo"))
            Me.name = vector.SelectToken("name").ToString
        Next
    End Sub
#End Region
#Region "EVENTOS"
    'DECLARAMOS LOS EVENTOS
    Private Sub dgridSelector_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridSelector.CellContentClick
        If e.ColumnIndex = 3 Then
            Me.obj.setCompany(dgridSelector.Rows(e.RowIndex).Cells(1).Value.ToString, dgridSelector.Rows(e.RowIndex).Cells(0).Value.ToString, Me.name, dgridSelector.Rows(e.RowIndex).Cells(2).Value.ToString)
            Me.Close()
        End If
    End Sub
#End Region
End Class