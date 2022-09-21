''Imports euRitmo
Imports System.Reflection




Public Class EdiOrderConverter

    Public Shared Function ReplaceFieldWithValues(tg904 As Tg904, order_edi As ordine_edi, ord_trk As String, order_edi_field As String, tg904_trk As String, tg904_field As String)
        Dim classType1 As Type = Type.GetType(ord_trk)
        Dim classType2 As Type = Type.GetType(tg904_trk)
        Dim objects As New List(Of Object)
        'Istanzio l'oggetto del record order_edi'
        Dim order_ediFieldObj = classType1.GetConstructor(Type.EmptyTypes).Invoke(objects.ToArray())
        Dim fieldName1 = ord_trk.Substring(8).ToLower()

        Dim sourceField1 = order_edi.GetType().GetField(fieldName1, BindingFlags.NonPublic Or BindingFlags.Instance).GetValue(order_edi)
        Dim tg904_fieldObj = classType2.GetConstructor(Type.EmptyTypes).Invoke(objects.ToArray())
        Dim castedObject1 = CTypeDynamic(order_ediFieldObj, classType1)
        CopyFieldsUsingReflection(sourceField1, castedObject1)
        Dim castedObject2 = CTypeDynamic(tg904_fieldObj, classType2)
        Dim fieldName2 = tg904_trk.Substring(8)
        Dim sourceField2 = tg904.GetType().GetField(fieldName2, BindingFlags.NonPublic Or BindingFlags.Instance).GetValue(tg904)
        ''MsgBox("SOURCE" & sourceField2.ToString())
        CopyFieldsUsingReflection(sourceField2, castedObject2)
        ''  MsgBox(sourceField2.GetType().ToString())


        ''Dim castedResult = getCastedObject(ord_trk, newObject)
        '' MsgBox(castedObject1.GetType().ToString())
        ''MsgBox(castedObject2.GetType().ToString())
        Dim field1 = classType1.GetField(order_edi_field, BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim field2 = classType2.GetField(tg904_field, BindingFlags.NonPublic Or BindingFlags.Instance)
        ''MsgBox(field1.Name)
        'Trovo il campo dell'oggetto contenuto nell'ordine_edi'
        Dim fieldValue1 = field1.GetValue(castedObject1)
        '' MsgBox(field2.Name)
        Dim fieldValue2 = field2.GetValue(castedObject2)

        field2.SetValue(castedObject1, fieldValue2)
        order_edi.GetType().GetField(fieldName1, BindingFlags.NonPublic Or BindingFlags.Instance).SetValue(order_edi, castedObject1)


        Return order_edi

    End Function
    'Mi costruisco l'oggetto castato'

    Private Shared Sub CopyFieldsUsingReflection(ByVal source As Object, dest As Object)
        Dim sourceFields = source.GetType().GetFields(BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim destFields = dest.GetType().GetFields(BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim counter As Integer = 0
        For Each field As FieldInfo In sourceFields
            destFields(counter).SetValue(dest, field.GetValue(source))
            Dim fieldValue = field.GetValue(source)



            If Not IsNothing(fieldValue) Then
                ''MsgBox(field.Name & " " & fieldValue.ToString())
            Else
                ''MsgBox(field.Name & " Vuoto ")
            End If
            counter += 1
        Next
    End Sub


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
