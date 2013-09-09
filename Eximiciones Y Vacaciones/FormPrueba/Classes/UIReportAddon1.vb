Public Class UIReportAddon1
    Implements IGraphicalAddon
    Private _dataSource As DataSet
    Private _parentForm As Form
    Private _saycSetting
    Public WriteOnly Property DataSource As System.Data.DataSet Implements IGraphicalAddon.DataSource
        Set(ByVal value As System.Data.DataSet)
            _dataSource = value
        End Set
    End Property
    Public ReadOnly Property Name As String Implements IGraphicalAddon.Name
        Get
            Return "EximicionesYVacaciones"
        End Get
    End Property
    Public ReadOnly Property NameText As String Implements IGraphicalAddon.NameText
        Get
            Return "Eximiciones y Vacaciones"
        End Get
    End Property
    Public ReadOnly Property idProduct As String Implements IGraphicalAddon.idProduct
        Get
            Return "A109"
        End Get
    End Property
    Public ReadOnly Property Category As String Implements IGraphicalAddon.Category
        Get
            Return "Operaciones"
        End Get
    End Property
    Public ReadOnly Property mdiStatus As Boolean Implements IGraphicalAddon.mdiStatus
        Get
            Return False
        End Get
    End Property
    Public ReadOnly Property Image As Image Implements IGraphicalAddon.Image
        Get
            Return My.Resources._7days
        End Get
    End Property
   
    Public WriteOnly Property ParentForm As Form Implements IGraphicalAddon.ParentForm
        Set(ByVal ParentForm As Form)
            Me._parentForm = ParentForm
        End Set
    End Property
    Public WriteOnly Property SaycSetting As Object Implements IGraphicalAddon.SaycSetting
        Set(ByVal setting As Object)
            Me._saycSetting = setting
        End Set
    End Property
    Public Sub OnClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IGraphicalAddon.OnClick
        Dim newUiReportingAddonForm As New Eximiciones(_saycSetting)
        If mdiStatus Then
            newUiReportingAddonForm.MdiParent = Me._parentForm
            newUiReportingAddonForm.MaximizeBox = True
        End If
        newUiReportingAddonForm.ShowDialog()
    End Sub
End Class
