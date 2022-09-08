Public Class ordine_edi
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
    Friend nai As Nai
    Friend nac As Nac
    Friend nam As Nam
    Friend dtm As Dtm
    Friend ftx As Ftx
    Friend pat As Pat
    Friend tod As Tod
    Friend lin As lin
    Friend mea As MEA
    Friend pac As Pac
    Friend mei As Mei
    Friend dtr As Dtr
    Friend ald As Ald
    Friend ftl As Ftl
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
    Friend CODCONS As String
    Friend QCODCONS As String
    Friend RAGSOCD As String
    Friend INDIRD As String
    Friend CITTAD As String
    Friend PROVD As String
    Friend CAPD As String
    Friend NAZIOD As String
End Class

Public Class Nai
    Friend TIPOREC As String
    Friend CODFATT As String
    Friend QCODFATT As TipoFattura
    Friend RAGSOCI As String
    Friend INDIRi As String
    Friend CITTAI As String
    Friend PROVI As String
    Friend CAPI As String
    Friend NAZOI As String

End Class






Public Enum TipoFattura
    Cod = 14
    VA
    CodVenditore = 91
    CodCompratore = 92
    ZZ
End Enum

Public Class Nac
    Friend TIPOREC As String
    Friend CODMAGI As String
    Friend QCODMAGI As TipoCodiceMerce
    Friend RAGSOCC As String
    Friend INDIRC As String
    Friend CITTAC As String
    Friend PROVC As String
    Friend CAPC As String
    Friend NAZIOC As String
End Class

Public Enum TipoCodiceMerce
    Ean = 14

End Enum

Public Class Nam
    Friend TIPOREC As String
    Friend CODMAGP As String
    Friend QCODMAGP As TipoCodiceMagazzino
    Friend CITTAM As String
    Friend PROVM As String
    Friend CAPM As String
    Friend NAZIOM As String
    Public Sub New()


    End Sub



End Class

Public Enum TipoCodiceMagazzino
    Ean = 14
    VA
    CodiceVenditore = 91
    CodiceCompratore = 92
    ZZ

End Enum

Public Class Dtm
    Friend TIPOREC As String
    Friend DATACONS As Integer
    Friend ORACONS As Integer
    Friend TIPODATAc As tipoDataConsegna
    Friend DATACON2 As Integer
    Friend ORACON2 As Integer
    Friend TIPODATA2 As String

End Class

Public Enum tipoDataConsegna
    DataRichiesta = 2
    NonConsegnarePrima = 3
    DataTassativa = 69
    DataPrevista = 76

End Enum

Public Class Ftx
    Friend TIPOREC As String
    Friend DIVISA As String
    Friend NOTE As String
End Class
Public Class Pat
    Friend TIPOREC As String
    Friend TIPOCOND As String
    Friend RIFERMP As String
    Friend RELTERMP As String
    Friend UNTEMP As String
    Friend NUMTEMP As Integer
    Friend IMPORTO As String
    Friend DIVISA As String
    Friend PERC As String
    Friend DESCRIZ As String
    Friend BANCACOD As String
    Friend BANCADESC As String
    Friend FACTOR As String
    Friend COPAG As String
    Friend MEZZOPAG As String
End Class



Public Enum TipoCondizionePagamento
    TerminiPenalita = 20
    PagamentoARate = 21
    Sconti = 22
    PagamentoCompleto = 10



End Enum

Public Class Tod
    Friend TIPOREC As String
    Friend CODCONS As String
    Friend CODCONST As String
    Friend CODCOND As String
    Friend DESCOND1 As String
    Friend DESCOND2 As String

End Class
Public Class lin
    Friend TIPOREC As String
    Friend NUMRIGA As Integer
    Friend CODICEANCU As String
    Friend TIPOCODCU As String
    Friend CODEANTU As String
    Friend CODFORTU As String
    Friend CODDISTU As String
    Friend DESART As String
    Friend FLINPROM As String
    Friend QTAORD As String
    Friend UDMQTAORD As String
    Friend PRZUNI As String
    Friend TIPOPRZ As String
    Friend UDMPRZUN As String
    Friend NRCUINTU As String
    Friend CODAZIOL As String
    Friend QTACONF As String
    Friend UDMQCONF As String
    Friend PRZUN2 As String
    Friend TIPOPRZ2 As String
    Friend UDMPRUNZ2 As String
    Friend PRZBASE As String

End Class
Public Class MEA
    Friend TIPOREC As String
    Friend QUALMISURA As String
    Friend IDDICOMMNCOD As String
    Friend SIGNIMISCOD As String
    Friend QUALUNIMIS As String
    Friend VALOMISURA As String
    Friend RANGEMIN As String
    Friend RANGEMAS As String

End Class
Public Class Pac
    Friend TIPOREC As String
    Friend NUMRIGA As Integer
    Friend CODART As String
    Friend TIPCODART As String
    Friend UDMQUIMB As String
    Friend INFIBACOD As String
    Friend CONIMBCOD As String
    Friend IDETIPIMB As String
    Friend RESPAGIMBREST As String
End Class
Public Class Mei
    Friend TIPOREC As String
    Friend QUALMISURA As String
    Friend IDDEMENCOD As String
    Friend SIGNIMISCOD As String
    Friend QUALUNIMIS As String
    Friend VALOMIMISURA As String
    Friend RANGEMIN As String
    Friend RANGEMAS As String
End Class
Public Class Dtr
    Friend TIPOREC As String
    Friend DATRCONS As Integer
    Friend ORARCONS As Integer
    Friend TIPODATRC As String
    Friend DATRCON2 As Integer
    Friend ORARCON2 As Integer
    Friend TIPODATTR2 As String
    Friend QTACONS As String

End Class
Public Class Ald
    Friend TIPOREC As String
    Friend INSCADD As String
    Friend DESCR As String
    Friend INDSEQ As Integer
    Friend TIPOSCADD As String
    Friend IMPORTO As String
    Friend PERC As String
    Friend FLGPRZUN As String
End Class
Public Class Ftl

    Friend TIPOREC As String
    Friend NOTE As String
End Class