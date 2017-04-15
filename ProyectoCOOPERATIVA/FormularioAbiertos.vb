Module FormularioAbiertos
    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function

    Public Sub CierreFormulario(ByVal frm1 As Form, ByVal frm2 As Form, ByVal frm3 As Form, ByVal frm4 As Form,
                                ByVal frm5 As Form, ByVal frm6 As Form, ByVal frm7 As Form, ByVal frm8 As Form,
                                ByVal frm9 As Form, ByVal frm10 As Form, ByVal frm11 As Form, ByVal frm12 As Form,
                                ByVal frm13 As Form)
        If Not EstaAbierto(frm1) And Not EstaAbierto(frm2) And Not EstaAbierto(frm3) And Not EstaAbierto(frm4) And Not EstaAbierto(frm5) And Not EstaAbierto(frm6) And Not EstaAbierto(frm7) And Not EstaAbierto(frm8) And Not EstaAbierto(frm9) And Not EstaAbierto(frm10) And Not EstaAbierto(frm11) And Not EstaAbierto(frm12) And Not EstaAbierto(frm13) Then
            PantallaPrincipal.PnlLogo.BringToFront()
            PantallaPrincipal.PnlLogo1.Visible = False
        End If
    End Sub

End Module
