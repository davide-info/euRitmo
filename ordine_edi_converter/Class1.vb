''Imports euRitmo
Imports model


Public Class EdiOrderConverter
    ''Friend l As List(Of Tg904)
    Private _l As List(Of model.ordine_edi)

    Friend Property L As List(Of ordine_edi)
        Get
            Return _l
        End Get
        Set(value As List(Of ordine_edi))
            _l = value
        End Set
    End Property

    Public Shared Sub FillField(trk As String, ByRef names() As String, values As String())
        If trk = "BGM" Then

        End If


    End Sub

End Class
