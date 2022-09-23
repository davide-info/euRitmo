
Imports System.Reflection




Public Class EdiOrderConverter
    Public Shared Function ReplaceFieldWithValues(tg904 As Tg904, order_edi As ordine_edi, order_edi_trk As String, order_edi_field As String, tg904_trk As String, tg904_field As String)
        Dim classType1 As Type = Type.GetType(order_edi_trk)
        Const bf As BindingFlags = BindingFlags.Instance Or BindingFlags.NonPublic
        Dim orderEdiFieldName = order_edi_trk.Substring(8).ToLower()
        Dim tg904FieldName = tg904_trk.Substring(8).ToLower()
        Dim orderEdiFieldInfo = order_edi.GetType().GetField(orderEdiFieldName, bf)
        Dim trkOrderField = orderEdiFieldInfo.GetValue(order_edi)
        Dim fieldTypeTg904 As Type = Type.GetType(tg904_trk)
        Dim tg904Type = tg904.GetType()
        Dim tg904FieldInfo = tg904Type.GetField(tg904FieldName, bf)
        If Not IsNothing(tg904FieldInfo) Then
            Dim trkTg904Field = tg904FieldInfo.GetValue(tg904)
            MsgBox(trkTg904Field.ToString())
        End If
        MsgBox(trkOrderField.ToString())
        Return order_edi

    End Function
End Class
