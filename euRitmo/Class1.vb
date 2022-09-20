''Imports euRitmo
Imports System.Reflection
Imports ordine_edi



Public Class EdiOrderConverter

    Public Shared Function ReplaceFieldWithValues(tg904 As Tg904, order_edi As ordine_edi, ord_trk As String, order_edi_field As String, tg904_trk As String, tg904_field As String)
        Dim classType1 As Type = Type.GetType(ord_trk)
        Dim objects As New List(Of Object)

        Dim newObject = classType1.GetConstructor(Type.EmptyTypes).Invoke(objects.ToArray())
        Dim castedResult = getCastedObject(ord_trk, newObject)
        If Not IsNothing(castedResult) Then
            MessageBox.Show(castedResult.ToString())

        Else
            MsgBox("Nothing")
        End If
        'Dim tryCastObj = TryCast(newObject, classType1)


        For Each field As FieldInfo In classType1.GetFields()
            If field.Name = order_edi_field Then


            End If

        Next
        'Dim subPro = Sub(fi As FieldInfo)
        '                 If fi.Name = order_edi_field Then
        '                     fi.SetValue(order_edi, value)
        '                 End If
        '             End Sub

        '' Dim fields = Type.GetType(trk_order).GetFields().ToList()
        ''fields.ForEach(subPro)

        Return order_edi

    End Function
    'Mi costruisco l'oggetto castato'

    Private Shared Function getCastedObject(type As String, myObject As Object)
        Dim newType = type.Substring(8) 'Tolgo euritmo.'
        MsgBox(newType)
        If (newType.Equals("bgm", StringComparison.InvariantCultureIgnoreCase)) Then
            Return TryCast(myObject, Bgm)
        End If
        If (newType.Equals("rff", StringComparison.InvariantCultureIgnoreCase)) Then
            Return TryCast(myObject, RFF)
        End If
        If (newType.Equals("rfc", StringComparison.InvariantCultureIgnoreCase)) Then
            Return TryCast(myObject, RFC)
        End If
        If (newType.Equals("NAS", StringComparison.InvariantCultureIgnoreCase)) Then
            Return TryCast(myObject, NAS)

        End If
        If newType.Equals("CTA", StringComparison.InvariantCultureIgnoreCase) Then
            Return TryCast(myObject, CTA)

        End If
        If newType.Equals("NAB", StringComparison.InvariantCultureIgnoreCase) Then
            Return TryCast(myObject, NAB)

        End If
        If newType.Equals("NAD", StringComparison.InvariantCultureIgnoreCase) Then
            Return TryCast(myObject, NAB)

        End If
        If newType.Equals("NAI", StringComparison.InvariantCultureIgnoreCase) Then
            Return TryCast(myObject, Nai)

        End If
        If newType.Equals("NAB", StringComparison.InvariantCultureIgnoreCase) Then
            Return TryCast(myObject, NAB)
        End If


        Return Nothing
    End Function


End Class
