﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18033
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18033.
'
Namespace internalFunction
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="internalFunctionBinding", [Namespace]:="urn:internalFunction")>  _
    Partial Public Class internalFunction
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private AliveStatusOperationCompleted As System.Threading.SendOrPostCallback
        
        Private checkAddOnsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getIdUserOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.AdminCuentas.My.MySettings.Default.FormPrueba_localhost_internalFunction
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event AliveStatusCompleted As AliveStatusCompletedEventHandler
        
        '''<remarks/>
        Public Event checkAddOnsCompleted As checkAddOnsCompletedEventHandler
        
        '''<remarks/>
        Public Event getIdUserCompleted As getIdUserCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:internalFunction#AliveStatus", RequestNamespace:="urn:internalFunction", ResponseNamespace:="urn:internalFunction")>  _
        Public Function AliveStatus(ByVal db As String, ByVal user As String, ByVal pass As String, ByVal token As String) As <System.Xml.Serialization.SoapElementAttribute("return")> Boolean
            Dim results() As Object = Me.Invoke("AliveStatus", New Object() {db, user, pass, token})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub AliveStatusAsync(ByVal db As String, ByVal user As String, ByVal pass As String, ByVal token As String)
            Me.AliveStatusAsync(db, user, pass, token, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub AliveStatusAsync(ByVal db As String, ByVal user As String, ByVal pass As String, ByVal token As String, ByVal userState As Object)
            If (Me.AliveStatusOperationCompleted Is Nothing) Then
                Me.AliveStatusOperationCompleted = AddressOf Me.OnAliveStatusOperationCompleted
            End If
            Me.InvokeAsync("AliveStatus", New Object() {db, user, pass, token}, Me.AliveStatusOperationCompleted, userState)
        End Sub
        
        Private Sub OnAliveStatusOperationCompleted(ByVal arg As Object)
            If (Not (Me.AliveStatusCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AliveStatusCompleted(Me, New AliveStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:internalFunction#logUser", RequestNamespace:="urn:internalFunction", ResponseNamespace:="urn:internalFunction")>  _
        Public Function checkAddOns(ByVal id_empresa As String, ByVal id_user As String, ByVal db_target As String, ByVal db_user As String, ByVal db_pass As String) As <System.Xml.Serialization.SoapElementAttribute("return")> String
            Dim results() As Object = Me.Invoke("checkAddOns", New Object() {id_empresa, id_user, db_target, db_user, db_pass})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub checkAddOnsAsync(ByVal id_empresa As String, ByVal id_user As String, ByVal db_target As String, ByVal db_user As String, ByVal db_pass As String)
            Me.checkAddOnsAsync(id_empresa, id_user, db_target, db_user, db_pass, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub checkAddOnsAsync(ByVal id_empresa As String, ByVal id_user As String, ByVal db_target As String, ByVal db_user As String, ByVal db_pass As String, ByVal userState As Object)
            If (Me.checkAddOnsOperationCompleted Is Nothing) Then
                Me.checkAddOnsOperationCompleted = AddressOf Me.OncheckAddOnsOperationCompleted
            End If
            Me.InvokeAsync("checkAddOns", New Object() {id_empresa, id_user, db_target, db_user, db_pass}, Me.checkAddOnsOperationCompleted, userState)
        End Sub
        
        Private Sub OncheckAddOnsOperationCompleted(ByVal arg As Object)
            If (Not (Me.checkAddOnsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent checkAddOnsCompleted(Me, New checkAddOnsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:internalFunction#getIdUser", RequestNamespace:="urn:internalFunction", ResponseNamespace:="urn:internalFunction")>  _
        Public Function getIdUser(ByVal db As String, ByVal user As String, ByVal pass As String, ByVal token As String) As <System.Xml.Serialization.SoapElementAttribute("return")> String
            Dim results() As Object = Me.Invoke("getIdUser", New Object() {db, user, pass, token})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getIdUserAsync(ByVal db As String, ByVal user As String, ByVal pass As String, ByVal token As String)
            Me.getIdUserAsync(db, user, pass, token, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getIdUserAsync(ByVal db As String, ByVal user As String, ByVal pass As String, ByVal token As String, ByVal userState As Object)
            If (Me.getIdUserOperationCompleted Is Nothing) Then
                Me.getIdUserOperationCompleted = AddressOf Me.OngetIdUserOperationCompleted
            End If
            Me.InvokeAsync("getIdUser", New Object() {db, user, pass, token}, Me.getIdUserOperationCompleted, userState)
        End Sub
        
        Private Sub OngetIdUserOperationCompleted(ByVal arg As Object)
            If (Not (Me.getIdUserCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getIdUserCompleted(Me, New getIdUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")>  _
    Public Delegate Sub AliveStatusCompletedEventHandler(ByVal sender As Object, ByVal e As AliveStatusCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class AliveStatusCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")>  _
    Public Delegate Sub checkAddOnsCompletedEventHandler(ByVal sender As Object, ByVal e As checkAddOnsCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class checkAddOnsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")>  _
    Public Delegate Sub getIdUserCompletedEventHandler(ByVal sender As Object, ByVal e As getIdUserCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getIdUserCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
