Imports System.Text

Public Class ordine_edi
    Friend bgm As Bgm
    Friend Rff As RFF
    Friend RFC As RFC
    Friend nas As NAS
    Friend cta As CTA
    Friend nab As NAB
    Friend nad As Nad
    Friend nai As Nai
    Friend nac As Nac
    Friend nam As Nam
    Friend dtm As Dtm
    Friend ftx As Ftx
    Friend pat As Pat
    Friend tod As Tod
    Friend lin As New List(Of lin)
    Friend mea As MEA
    Friend pac As Pac
    Friend mei As Mei
    Friend dtr As Dtr
    Friend ald As Ald
    Friend ftl As Ftl
    Friend loc As Loc
    Friend dtl As Dtl
    Friend cnt As Cnt
    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        If (Not IsNothing(bgm)) Then
            builder.Append(bgm.ToString() & " ")
        End If


        If Not IsNothing(Rff) Then
            builder.Append(Rff.ToString() & " ")
        End If
        If Not IsNothing(RFC) Then
            builder.Append(RFC.ToString() & " ")
        End If

        If (Not IsNothing(nas)) Then
            builder.Append(nas.ToString() & " ")
        End If
        If Not IsNothing(Me.cta) Then
            builder.Append(cta.ToString() & " ")

        End If
        If Not IsNothing(nab) Then
            builder.Append(nab.ToString() & " ")

        End If
        If Not IsNothing(nad) Then
            builder.Append(nad.ToString() & " ")
        End If


        If Not IsNothing(nai) Then
            builder.Append(nai.ToString() & " ")
        End If
        If Not IsNothing(nac) Then
            builder.Append(nac.ToString() & " ")
        End If
        If Not IsNothing(nam) Then
            builder.Append(nam.ToString() & " ")
        End If
        If Not IsNothing(dtm) Then
            builder.Append(dtm.ToString() & " ")
        End If
        If Not IsNothing(ftx) Then
            builder.Append(ftx.ToString() & " ")
        End If
        If Not IsNothing(pat) Then
            builder.Append(pat.ToString() & " ")
        End If
        If Not IsNothing(tod) Then
            builder.Append(tod.ToString() & " ")
        End If

        For Each l As lin In lin
            If (Not IsNothing(l)) Then
                builder.Append(l.ToString())
            End If
        Next
        builder.Append(" ")
        If Not IsNothing(pac) Then
            builder.Append(pac.ToString() & " ")
        End If

        Return builder.ToString()
    End Function

End Class

Public Class Bgm

    Friend TIPOREC As String = "BGM"
    Friend ID_EDI_MITT1 As String = "".PadLeft(35)
    Friend ID_EDI_MITT2 As String = "".PadLeft(4)
    Friend ID_EDI_MITT3 As String = "".PadLeft(14)
    Friend ID_EDI_DEST1 As String = "".PadLeft(35)
    Friend ID_EDI_DEST2 As String = "".PadLeft(4)
    Friend ID_EDI_DEST3 As String = "".PadLeft(14)
    Friend TIPODOC As String = "".PadLeft(6)
    Friend NUMDOC As String = "".PadLeft(35)
    Friend DATADOC As String = "".PadLeft(8)
    Friend FORDPROM As String = "".PadLeft(4)
    Friend NUMORDF As String = "".PadLeft(14)
    Friend DATAORDF As String
    Friend ORAORDF As String ''"".PadLeft(4)
    Friend NUMORDC As String = "".PadLeft(14)
    Friend DATAORDC As String
    Friend ORAORDC As String
    Friend NUMPROFDF As String
    Friend numpordc As String
    Friend Codazion As String = "".PadLeft(3)
    Friend FLAGIMPE As String = "".PadLeft(3)
    Friend TIPOORD As String = "".PadLeft(3)
    Public Sub New()

    End Sub
    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        builder.Append(Me.TIPOREC)
        builder.Append(Me.ID_EDI_MITT1)
        builder.Append(Me.ID_EDI_MITT2)



        Return builder.ToString()
    End Function
End Class

'Public Enum TipoDoc
'    ORDCHG
'    ORDERS
'    ORDPRP
'    ORDSRP
'    ORDSLS


'End Enum
'Public Enum Codazion
'    A
'    M
'    R
'End Enum

Public Class RFF
    Friend TIPOREC As String = "RFF"
    Friend FORDPROM As String = "".PadLeft(3)
    Friend NUMORDF As String = "".PadLeft(35)
    Friend DATAORDF As String
    Friend ORAORDF As String
    Friend NUMORDC As String = "".PadLeft(35)
    Friend DATAORDC As String
    Friend ORAORDC As String

    Friend NUMPORDF As String = "".PadLeft(35)
    Friend NUMPORDC As String = "".PadLeft(35)

    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)

        Return builder.ToString()
    End Function


End Class
Public Class RFC
    Friend TIPOREC As String = "RFC"
    Friend NUMCO As String = "".PadLeft(35)
    Friend DATAINCO As String
    Friend DATAFICO As String
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function


End Class
Public Class NAS
    Friend TIPOREC As String = "NAS"
    Friend CODFORN As String = "".PadLeft(17)
    Friend QCODFORN As String = "".PadLeft(3)
    Friend RAGSOCF As String = "".PadLeft(70)
    Friend INDIRF As String = "".PadLeft(70)
    Friend CITTAF As String = "".PadLeft(35)
    Friend PROVF As String = "".PadLeft(9)
    Friend CAPF As String = "".PadLeft(9)
    Friend NAZIOF As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)

        Return builder.ToString()
    End Function


End Class

Public Class CTA
    Friend TIPOREC As String = "CTA"
    Friend FUNZCONT As String = "".PadLeft(3)
    Friend TELEFONO As String = "".PadLeft(25)
    Friend FAX As String = "".PadLeft(25)
    Friend TELEX As String = "".PadLeft(25)
    Friend EMAIL As String = "".PadLeft(70)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)

        Return builder.ToString()

    End Function

End Class
Public Class NAB
    Friend TIPOREC As String = "NAB"

    Friend CODBUYER As String = "".PadLeft(17)
    Friend QCODBUY As String = "".PadLeft(3)
    Friend REGSOC As String = "".PadLeft(70)
    Friend INDRB As String = "".PadLeft(70)
    Friend CITTAB As String = "".PadLeft(35)
    Friend CAPB As String = "".PadLeft(9)
    Friend PROvB As String = "".PadLeft(9)
    Friend NAZIOB As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function
End Class

Public Class Nad
    Friend TIPOREC As String = "NAD"
    Friend CODCONS As String = "".PadLeft(17)
    Friend QCODCONS As String = "".PadLeft(3)
    Friend RAGSOCD As String = "".PadLeft(70)
    Friend INDIRD As String = "".PadLeft(70)
    Friend CITTAD As String = "".PadLeft(35)
    Friend PROVD As String = "".PadLeft(9)
    Friend CAPD As String = "".PadLeft(9)
    Friend NAZIOD As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class

Public Class Nai
    Friend TIPOREC As String = "NAI"
    Friend CODFATT As String = "".PadLeft(17)
    Friend QCODFATT As String = "".PadLeft(3)
    Friend RAGSOCI As String = "".PadLeft(70)
    Friend INDIRi As String = "".PadLeft(70)
    Friend CITTAI As String = "".PadLeft(35)
    Friend PROVI As String = "".PadLeft(9)
    Friend CAPI As String = "".PadLeft(9)
    Friend NAZOI As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class






'Public Enum TipoFattura
'    Cod = 14
'    VA
'    CodVenditore = 91
'    CodCompratore = 92
'    ZZ
'End Enum

Public Class Nac
    Friend TIPOREC As String = "NAC"
    Friend CODMAGI As String = "".PadLeft(17)
    Friend QCODMAGI As String = "".PadLeft(3)
    Friend RAGSOCC As String = "".PadLeft(70)
    Friend INDIRC As String = "".PadLeft(70)
    Friend CITTAC As String = "".PadLeft(35)
    Friend PROVC As String = "".PadLeft(9)
    Friend CAPC As String = "".PadLeft(9)
    Friend NAZIOC As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class

'Public Enum TipoCodiceMerce
'    Ean = 14

'End Enum

Public Class Nam
    Friend TIPOREC As String = "NAM"
    Friend CODMAGP As String = "".PadLeft(17)
    Friend QCODMAGP As String = "".PadLeft(3)
    Friend RAGOSCM As String = "".PadLeft(70)
    Friend INDRIM As String = "".PadLeft(70)
    Friend CITTAM As String = "".PadLeft(35)
    Friend PROVM As String = "".PadLeft(9)
    Friend CAPM As String = "".PadLeft(9)
    Friend NAZIOM As String = "".PadLeft(3)
    Public Sub New()


    End Sub

    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        builder.Append(Me.TIPOREC).Append(Me.RAGOSCM)



        Return builder.ToString()

    End Function



End Class

'Public Enum TipoCodiceMagazzino
'    Ean = 14
'    VA
'    CodiceVenditore = 91
'    CodiceCompratore = 92
'    ZZ

'End Enum

Public Class Dtm
    Friend TIPOREC As String = "DTM"

    Friend DATACONS As String
    Friend ORACONS As String
    Friend TIPODATAc As String = "".PadLeft(3)
    Friend DATACON2 As String
    Friend ORACON2 As String
    Friend TIPODATA2 As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function


End Class

'Public Enum tipoDataConsegna
'    DataRichiesta = 2
'    NonConsegnarePrima = 3
'    DataTassativa = 69
'    DataPrevista = 76

'End Enum

Public Class Ftx
    Friend TIPOREC As String = "FTX"
    Friend DIVISA As String = "".PadLeft(3)
    Friend NOTE As String = "".PadLeft(210)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function
End Class
Public Class Pat
    Friend TIPOREC As String = "PAT"
    Friend TIPOCOND As String = "".PadLeft(3)
    Friend DATASCAD As String
    Friend RIFERMP As String = "".PadLeft(3)
    Friend RELTERMP As String = "".PadLeft(3)
    Friend UNTEMP As String = "".PadLeft(3)
    Friend NUMTEMP As String
    Friend IMPORTO As String = "".PadLeft(32)
    Friend DIVISA As String = "".PadLeft(3)
    Friend PERC As String = "".PadLeft(14)
    Friend DESCRIZ As String = "".PadLeft(35)
    Friend BANCACOD As String = "".PadLeft(35)
    Friend BANCADESC As String = "".PadLeft(35)
    Friend FACTOR As String = "".PadLeft(35)
    Friend COPAG As String = "".PadLeft(3)
    Friend MEZZOPAG As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class



'Public Enum TipoCondizionePagamento
'    TerminiPenalita = 20
'    PagamentoARate = 21
'    Sconti = 22
'    PagamentoCompleto = 10



'End Enum

Public Class Tod
    Friend TIPOREC As String = "TOD"
    Friend CODCONS As String = "".PadLeft(3)
    Friend CODCOST As String = "".PadLeft(3)
    Friend CODCOND As String = "".PadLeft(3)
    Friend DESCOND1 As String = "".PadLeft(70)
    Friend DESCOND2 As String = "".PadLeft(70)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function


End Class
Public Class lin
    Friend TIPOREC As String = "LIN"
    Friend NUMRIGA As String
    Friend CODICEANCU As String = "".PadLeft(35)
    Friend TIPOCODCU As String = "".PadLeft(3)
    Friend CODEANTU As String = "".PadLeft(35)
    Friend CODFORTU As String = "".PadLeft(35)
    Friend CODDISTU As String = "".PadLeft(35)
    Friend DESART As String = "".PadLeft(35)
    Friend FLINPROM As String = "".PadLeft(3)
    Friend QTAORD As String = ""
    Friend UDMQTAORD As String = "".PadLeft(3)
    Friend PRZUNI As String = ""
    Friend TIPOPRZ As String = "".PadLeft(3)
    Friend UDMPRZUN As String = "".PadLeft(3)
    Friend NRCUINTU As String = ""
    Friend QTACONF As String = ""
    Friend UDMQCONF As String = "".PadLeft(3)
    Friend PRZUN2 As String = ""
    Friend TIPOPRZ2 As String = "".PadLeft(3)
    Friend UDMPRUNZ2 As String = "".PadLeft(3)
    Friend PRZBASE As String = ""
    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        builder.Append(Me.TIPOREC)
        builder.Append(Me.NUMRIGA)
        builder.Append(Me.CODEANTU)

        Return builder.ToString()

    End Function

End Class
Public Class MEA
    Friend TIPOREC As String = "MEA"
    Friend QUALMISURA As String = "".PadLeft(3)
    Friend IDDICOMMNCOD As String = "".PadLeft(3)
    Friend SIGNIMISCOD As String = "".PadLeft(3)
    Friend QUALUNIMIS As String = "".PadLeft(3)
    Friend VALOMISURA As String = ""
    Friend RANGEMIN As String = ""
    Friend RANGEMAS As String = ""

    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function


End Class
Public Class Pac
    Friend TIPOREC As String = "PAC"
    Friend NUMRIGA As String
    Friend CODART As String = "".PadLeft(35)
    Friend TIPCODART As String = "".PadLeft(3)
    Friend UDMQUIMB As String = "".PadLeft(3)
    Friend INFIBACOD As String = "".PadLeft(3)
    Friend CONIMBCOD As String = "".PadLeft(3)
    Friend IDETIPIMB As String = "".PadLeft(3)
    Friend RESPAGIMBREST As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class
Public Class Mei
    Friend TIPOREC As String = "MEI"
    Friend QUALMISURA As String = "".PadLeft(3)
    Friend IDDIEMENCOD As String = "".PadLeft(3)
    Friend SIGNIMISCOD As String = "".PadLeft(3)
    Friend QUALUNIMIS As String = "".PadLeft(3)
    Friend VALOMIMISURA As String = ""
    Friend RANGEMIN As String = ""
    Friend RANGEMAS As String = ""
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function
End Class
Public Class Dtr
    Friend TIPOREC As String = "DTR"
    Friend DATRCONS As String
    Friend ORARCONS As String
    Friend TIPODATRC As String = "".PadLeft(3)
    Friend DATRCON2 As String
    Friend ORARCON2 As String
    Friend TIPODATTR2 As String = "".PadLeft(3)
    Friend QTACONS As String = ""
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function


End Class
Public Class Ald
    Friend TIPOREC As String = "ALD"
    Friend INSCADD As String = "".PadLeft(3)
    Friend DESCR As String = "".PadLeft(35)
    Friend INDSEQ As String
    Friend TIPOSCADD As String = "".PadLeft(6)
    Friend IMPORTO As String = ""
    Friend PERC As String = ""
    Friend FLGPRZUN As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class
Public Class Ftl
    Friend TIPOREC As String = "FTL"
    Friend NOTE As String = "".PadLeft(140)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class

Public Class Loc
    Friend TIPOREC As String = "LOC"
    Friend CODCONS As String = "".PadLeft(17)
    Friend QCODCONS As String = "".PadLeft(3)
    Friend RAGSOCD As String = "".PadLeft(70)
    Friend INDIRD As String = "".PadLeft(70)
    Friend CITTAD As String = "".PadLeft(35)
    Friend PROVD As String = "".PadLeft(9)
    Friend CAPD As String = "".PadLeft(9)
    Friend NAZIOD As String = ""
    Friend QTASPLIt As String = ""
    Friend UDMQORD As String = ""
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class
Public Class Dtl
    Friend TIPOREC As String = "DTL"
    Friend DATRCONS As String
    Friend ORARCONS As String


    Friend TIPODATARC As String
    Friend DATRCON2 As String
    Friend ORARCON2 As String
    Friend TIPODATATR2 As String
    Friend QTACONS As String
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function

End Class
Public Class Cnt
    Friend TIPOREC As String = "CNT"
    Friend QTAORDT As String
    Friend UDMQORDT As String
    Friend NUMLIT As String
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC)
        Return builder.ToString()
    End Function
End Class