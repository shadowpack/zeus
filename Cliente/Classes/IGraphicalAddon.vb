Public Interface IGraphicalAddon
    ReadOnly Property Name As String
    ReadOnly Property NameText As String
    ReadOnly Property Category As String
    ReadOnly Property idProduct As String
    ReadOnly Property Image As Image
    WriteOnly Property ParentForm As Form
    WriteOnly Property SaycSetting As SAYC_Settings
    WriteOnly Property DataSource As DataSet
    Sub OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
End Interface
