Public Class verificarAutorizacion
#Region "PROPIEDADES"
    Private obj As SAYC_Settings
#End Region
#Region "METODOS DE CLASE"

#End Region
#Region "METODOS PUBLICOS"
    Public Sub Construct(obj As SAYC_Settings)
        Me.obj = obj
        Me.obj.setTxt_Verificador("")
        Me.obj.setBool_Verificador(False)
    End Sub
#End Region
#Region "EVENTOS"
    'METODO PARA MAENJAR BOTON CANCELADO
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.obj.setBool_Verificador(False)
        Me.Close()
    End Sub
    'METODO PARA MANEJAR BOTON ACEPTAR
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtId.Text.Length > 0 Then
            Me.obj.setBool_Verificador(True)
            Me.obj.setTxt_Verificador(txtId.Text)
            Me.Close()
        Else
            MessageBox.Show("Debe indicar un ID valido. Para esto acerque la credencial al lector")
        End If
    End Sub
#End Region
End Class