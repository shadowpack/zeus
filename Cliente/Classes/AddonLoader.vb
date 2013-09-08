Imports System.Reflection
Imports System.IO
Public Class AddonLoader
    Public Enum AddonType
        IGraphicalAddon = 10
        ISomeOtherAddonType2 = 20
        ISomeOtherAddonType3 = 30
    End Enum
    Public Function GetAddonsByType(ByVal addonType As AddonType) As List(Of System.Type)
        Dim currentApplicationDirectory As String = My.Application.Info.DirectoryPath
        Dim addonsRootDirectory As String = currentApplicationDirectory & "\Addons\"
        Dim loadedAssembly As Assembly
        Dim listOfModules As New List(Of System.Type)
        If My.Computer.FileSystem.DirectoryExists(addonsRootDirectory) Then
            Dim dllFilesFound = My.Computer.FileSystem.GetFiles(addonsRootDirectory, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.dll")
            For Each dllFile In dllFilesFound
                Try
                    loadedAssembly = Assembly.LoadFile(dllFile)
                Catch ex As Exception
                End Try
                If loadedAssembly IsNot Nothing Then
                    For Each assemblyModule In loadedAssembly.GetModules
                        For Each moduleType In assemblyModule.GetTypes()
                            For Each interfaceImplemented In moduleType.GetInterfaces()
                                If interfaceImplemented.Name = addonType.ToString Then
                                    listOfModules.Add(moduleType)
                                End If
                            Next
                        Next
                    Next
                End If
            Next
        End If
        Return listOfModules
    End Function
    Public Function GetAddonsInfo() As List(Of Array)
        Dim currentApplicationDirectory As String = My.Application.Info.DirectoryPath
        Dim addonsRootDirectory As String = currentApplicationDirectory & "\Addons\"
        Dim arrayFileInfo As New List(Of Array)
        If My.Computer.FileSystem.DirectoryExists(addonsRootDirectory) Then
            Dim dllFilesFound = My.Computer.FileSystem.GetFiles(addonsRootDirectory, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.dll")
            For Each dllFile In dllFilesFound
                Try
                    arrayFileInfo.Add({System.Diagnostics.FileVersionInfo.GetVersionInfo(dllFile).ProductName, Diagnostics.FileVersionInfo.GetVersionInfo(dllFile).Comments, System.Diagnostics.FileVersionInfo.GetVersionInfo(dllFile).ProductMajorPart, System.Diagnostics.FileVersionInfo.GetVersionInfo(dllFile).ProductMinorPart, System.Diagnostics.FileVersionInfo.GetVersionInfo(dllFile).ProductBuildPart, System.Diagnostics.FileVersionInfo.GetVersionInfo(dllFile).ProductPrivatePart})
                Catch ex As Exception
                End Try
            Next
        End If
        Return arrayFileInfo
    End Function
End Class
