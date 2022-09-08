﻿Public Class ordine_edi
    Friend ID_EDI_MITT As String
    Friend ID_EDI_MITT1 As String
    Friend ID_EDI_MITT2 As String
    Friend ID_EDI_MITT3 As String
    Friend IED_EDI_DEST As String
    Friend ID_EDI_DEST1 As String
    Friend ID_EDI_DEST2 As String
    Friend ID_EDI_DEST3 As String
    Friend Doc As Doc
    Friend Rff As RFF
    Friend RFC As RFC
    Friend nas As NAS
    Friend cta As Cta
    Friend nab As NAB
    Friend nad As Nad



End Class

Public Enum TipoDoc
    ORDCHG
    ORDERS
    ORDPRP
    ORDSRP
    ORDSLS


End Enum

Public Class Doc
    Friend TIPO_DOC As TipoDoc
    Friend NUMDOC As String
    Friend DATADOC As Integer
    Friend ORADOC As Integer
    Friend CodAzION As Codazion
    Friend flagime As tipoOrd
    Friend NOMEDOC As String


End Class
Public Enum Codazion
    A
    M
    R
End Enum
Public Enum tipoOrd
    BlanketOrder = 221
    DispositivoUrgente = 224
    DispositivoConsegna = 226
    ConfermaOrdine = 231
    YA9

End Enum
Public Class RFF
    Friend TIPOREC As String
    Friend FORDPROM As String
    Friend NUMORDF As String
    Friend DATAORDF As Integer
    Friend ORAORDF As Integer
    '
    Friend NUMORDC As String
    Friend DATAORDC As Integer
    Friend ORAORDC As Integer

    Friend NUMPORDF As String
    Friend NUMPORDC As String
End Class
Public Class RFC
    Friend TIPOREC As String
    Friend NUMCO As String
    Friend DATAINCO As Integer
    Friend DATAFICO As Integer

End Class
Public Class NAS
    Friend TIPOREC As String
    Friend CODFORN As String
    Friend QCODFORN As String
    Friend RAGSOCF As String
    Friend INDIRF As String
    Friend CITTAF As String
    Friend PROVF As String
    Friend CAPF As String
    Friend NZAIOF As String

End Class

Public Class CTA
    Friend TIPOREC As String
    Friend FUNZCONT As String
    Friend TELEFONO As String
    Friend FAX As String
    Friend TELEX As String
    Friend EMAIL As String

End Class
Public Class NAB
    Friend tiporec As String
    Friend QCODBY As String
    Friend RAGCOSB As String
    Friend CITTAB As String
    Friend CAPB As String
    Friend NAZIOB As String
End Class

Public Class Nad
    Friend TIPOREC As String
End Class

















