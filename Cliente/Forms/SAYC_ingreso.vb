Public Class SAYC_ingreso
    'DEFINIMOS LAS PROPIEDADES DE CLASE
    Private ingreso_class As SAYC_ingreso_class
    'DEFINIMOS EL CONSTRUCTOR
    Public Sub New()
        'LLAMAMOS A LA VENTANA DE SPLASH
        Splash.ShowDialog()
        'LLAMAMOS AL CONSTRUCTOR DEL FORM
        InitializeComponent()
        'INICIALIZAMOS LA CLASE ASOCIADA AL FORM
        ingreso_class = New SAYC_ingreso_class(Me, Me.pboxactu)
    End Sub
    'DEFINIMOS LOS EVENTOS
    Private Sub txtid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingreso_class.get_user(Me)
        End If
    End Sub
    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        If Me.txtid.Text <> Nothing And Me.txtpassword.Text <> Nothing Then
            ingreso_class.loginUser(Me)
        End If
    End Sub
    'DEFINIMOS LOS METODOS DE CLASE
    'DEFINIMOS LOS METODO PUBLICOS
    Public Sub clearForm()
        Me.txtid.Text = Nothing
        Me.txtpassword.Text = Nothing
        Me.lblEmpre.Text = "Empresa"
        Me.lblname.Text = "Nombre"
        Me.lblcargo.Text = "Cargo"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class