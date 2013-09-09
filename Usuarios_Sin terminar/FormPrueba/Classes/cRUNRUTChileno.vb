Public Class cRUNRUTChileno

    ''' <summary>
    ''' Valida Rol Único Nacional (RUN) y Rol Único Tributario (RUT) chilenos.
    ''' </summary>
    ''' <param name="sRUNRUT">Rol Único Nacional (RUN) o Rol Único Tributario (RUT) en 
    ''' formato "00000000-0" o "00.000.000-0"</param>
    ''' <returns>True: correcto, False: incorrecto</returns>
    ''' <remarks></remarks>
    Public Function Valida(ByVal sRUNRUT As String) As Boolean
        Try
            Dim aRUNRUT() As String
            Dim sDigitoVerificadorRUNRUT, sDigitoVerificador As String

            'Obtiene parte del número y dígito verificador
            aRUNRUT = Split(sRUNRUT, "-")
            'Verificación de existencia de parte del número y dígito verificador
            If aRUNRUT.Count <> 2 Then
                Return False
            End If
            'Asignación de dígito verificador
            sDigitoVerificadorRUNRUT = aRUNRUT(1).ToUpper
            'Obtención de dígito verificador según parte del número del RUN o RUT
            sDigitoVerificador = DigitoVerificador(aRUNRUT(0).ToString)

            'Verificación si RUN o RUT es correcto según comparación de dígito verificador
            If sDigitoVerificadorRUNRUT = sDigitoVerificador Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Entrega dígito verificador de Rol Único Nacional (RUN) y Rol Único Tributario (RUT) chilenos.
    ''' </summary>
    ''' <param name="sNumeroRUNRUT">Rol Único Nacional (RUN) o Rol Único Tributario (RUT) en 
    ''' formato "00000000" o "00.000.000"</param>
    ''' <returns>Dígito verificador "0,1,2,3,4,5,6,7,8,9,K"</returns>
    ''' <remarks></remarks>
    Public Function DigitoVerificador(ByVal sNumeroRUNRUT As String) As String
        Try
            Dim iNumero, iNumeroRUNRUT, iSumaNumero, iMultiplicadorNumero, iRestoModulo11 As Integer
            Dim sDigitoVerificador As String

            'Inicio de variable de multiplicador de secuencia 2,3,4,5,6,7
            iMultiplicadorNumero = 2

            'Quita puntos, guiones bajos, espacios y transforma a mayúsculas
            sNumeroRUNRUT = LimpiaFormato(sNumeroRUNRUT)
            'Verificación que formato de RUN o RUT sea la parte del número
            If IsNumeric(sNumeroRUNRUT) Then
                iNumeroRUNRUT = CInt(sNumeroRUNRUT)
            Else
                Return ""
            End If

            'Se procede a tomar la parte del número de derecha a izquierda, multiplicando cada dígito 
            'por los números que componen la serie numérica 2,3,4,5,6,7 y sumando el resultado de estos productos.
            'Si se ha aplicado la serie hasta el 7 y quedan dígitos por multiplicar, se comienza la serie nuevamente.
            For i As Integer = Len(iNumeroRUNRUT.ToString) To 1 Step -1
                iNumero = iNumeroRUNRUT.ToString.Substring(i - 1, 1)
                iSumaNumero += iNumero * iMultiplicadorNumero
                iMultiplicadorNumero += 1
                If iMultiplicadorNumero = 8 Then iMultiplicadorNumero = 2
            Next

            'Al número obtenido por la suma del producto de cada dígito por la serie, 
            'se le aplica módulo 11, o sea, se divide por 11 y se determina el resto de la división.
            iRestoModulo11 = iSumaNumero Mod 11
            'Ahora a 11 se le resta el resto
            sDigitoVerificador = CStr(11 - iRestoModulo11)

            'Si el resultado es 11, el dígito verificador será 0.
            'Si el resultado es 10, el dígito verificador será K.
            'En otro caso el resultado será el dígito verificador.
            Select Case sDigitoVerificador
                Case "10"
                    sDigitoVerificador = "K"
                Case "11"
                    sDigitoVerificador = "0"
            End Select

            'Retorno de dígito verificador
            Return sDigitoVerificador
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Quita puntos, guiones bajos, espacios y transforma a mayúsculas RUN y RUT.
    ''' </summary>
    ''' <param name="sRUNRUT">Rol Único Nacional (RUN) o Rol Único Tributario (RUT)</param>
    ''' <returns>RUN o RUT sin puntos, guiones bajo y espacios</returns>
    ''' <remarks></remarks>
    Private Function LimpiaFormato(ByVal sRUNRUT As String) As String
        'Limpia puntos
        sRUNRUT = Replace(sRUNRUT, ".", "")
        'Limpia guiones bajos
        sRUNRUT = Replace(sRUNRUT, "_", "")
        'Transforma a mayúsculas
        sRUNRUT = sRUNRUT.ToUpper
        'Limpia espacios en extremos
        Return Trim(sRUNRUT)
    End Function

End Class
