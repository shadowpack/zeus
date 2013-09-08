Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public Class Downloader
    'DECLARAMOS LAS VARIABLES DE CLASE
    Private WithEvents download As FileDownloader
    Private exeFile As Boolean = False
    'DELCARAMOS EVENTOS
    Private Sub Downloader_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.download.SupportsProgress = True
        Me.download.Start()
    End Sub
    'EVENTO QUE DECLARA CAMBIOS DE ESTADO Y PROGRESO EN LA DESCARGA
    Private Sub downloader_ProgressChanged() Handles download.ProgressChanged
        Me.statusBar.Value = CInt(Me.download.TotalPercentage)
        Me.lblSpeed.Text = _
        String.Format("Descargado {0} de {1} ({2}%)", _
        FileDownloader.FormatSizeBinary(Me.download.CurrentFileProgress), _
        FileDownloader.FormatSizeBinary(Me.download.CurrentFileSize), _
        download.CurrentFilePercentage) & String.Format(" - {0}/s", _
        FileDownloader.FormatSizeBinary(Me.download.DownloadSpeed))
        Me.lblStatus.Text = "Descargando Archivo : " & Me.download.CurrentFile.Name
        Me.lblProgreso.Text = String.Format("Progreso Total : {0}%", Me.download.TotalPercentage)
    End Sub
    Private Sub downloader_DownloadFinish() Handles download.Completed
        If Me.exeFile Then
            Process.Start(download.LocalDirectory & "\" & Me.download.CurrentFile.Name)
        End If
        Me.Close()
    End Sub
    'DECLARAMOS LOS METODOS
    Public Sub setDownloader(downloader As FileDownloader)
        Me.download = downloader
    End Sub
    Public Sub setAction(action As String)
        Me.lblAction.Text = "Operación Actual : " & action
        Me.Text = action
    End Sub
    Public Sub execFile(bol As Boolean)
        Me.exeFile = bol
    End Sub
End Class