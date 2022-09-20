Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Private Function testParseFile(fileName As String) As Tg904
        Dim result As New StringBuilder()
        Dim lines = File.ReadAllLines(fileName)
        Dim tg904 As Tg904 = Nothing
        tg904 = parseLine2(lines)
        Return tg904
    End Function

    Private Shared Function MapToOrdineEdi(tg904 As Tg904) As ordine_edi
        Dim strB = New StringBuilder()
        Dim bgm As New Bgm()
        Dim nai As New Nai()
        Dim nas As New NAS()
        Dim nab As New NAB()
        Dim nad As New Nad()
        Dim dtm As New Dtm()
        Dim lin As New lin()
        Dim result As New ordine_edi()
        Dim ftl As New Ftl()
        Dim cnt As New Cnt()
        Dim ftx As New Ftx()
        'Oggetto Nab manca il campo RAGSOCB'
        'Oggetto Lin Manca il campo CODEANCU , COFORTU, DESART, QTAORD, PRZUNI, TIPOPRZ, '
        bgm.DATADOC = tg904.Tes.DTORD
        bgm.TIPODOC = "ORDERS"
        ''bgm.
        bgm.NUMDOC1 = tg904.Tes.ORD.PadRight(35)
        bgm.numdoc2 = tg904.Tes.ORD.PadRight(35)
        bgm.ID_EDI_MITT1 = tg904.Tes.EDI_MITT1.PadRight(35)
        bgm.ID_EDI_MITT2 = tg904.Tes.EDI_MITT2.PadRight(4)
        bgm.ID_EDI_DEST1 = tg904.Tes.EDI_DEST1.PadRight(35)
        bgm.ID_EDI_DEST2 = tg904.Tes.EDI_DEST2.Substring(0, 2).PadRight(4)
        nas.RAGSOCF = tg904.forn.RAGSOC_For.PadRight(70)
        nas.INDIRF = tg904.forn.IND_FOR.PadRight(70)
        nas.CITTAF = tg904.forn.LOC_FOR.PadRight(35)
        nas.PROVF = tg904.forn.PROV_FOR.PadRight(9)
        nas.CAPF = tg904.forn.CAP_FOR.PadRight(9)
        nas.CODFORN = tg904.forn.PARTIVA_FOR.PadRight(17)
        nas.QCODFORN = "VA".PadRight(3)
        nab.CODBUYER = tg904.mit.PARTIVA_CLI.PadRight(17)
        nab.QCODBUY = "VA".PadRight(3)
        nab.REGSOC = tg904.mit.RAGSOC_CLI.PadRight(70)
        nab.INDRB = tg904.mit.IND_CLI.PadRight(70)
        nab.CITTAB = tg904.mit.LOC_CLI.PadRight(35)
        nab.PROvB = tg904.mit.PROV_CLI.PadRight(9)
        nab.CAPB = tg904.mit.CAP_CLI.PadRight(9)
        nad.RAGSOCD = tg904.mit.RAGSOC_CLI.PadRight(70)
        nai.CODFATT = tg904.mit.PARTIVA_CLI.PadRight(17)
        nai.CITTAI = tg904.mit.LOC_CLI.PadRight(35)
        nai.PROVI = tg904.mit.PROV_CLI.PadRight(9)
        nai.CAPI = tg904.mit.CAP_CLI.PadRight(9)
        dtm.DATACONS = tg904.Tes.DTPC.PadRight(8)
        dtm.TIPODATAc = "002"
        nai.QCODFATT = "VA".PadRight(3)
        nai.INDIRi = tg904.mit.IND_CLI.PadRight(70)
        nai.CITTAI = tg904.mit.LOC_MAG.PadRight(35)
        nai.RAGSOCI = tg904.mit.RAGSOC_CLI.PadRight(70)
        nad.CODCONS = tg904.mit.PARTIVA_CLI.PadRight(17)
        nad.QCODCONS = "VA".PadRight(3)
        nad.INDIRD = tg904.mit.IND_MAG.PadRight(70)
        nad.CITTAD = tg904.mit.LOC_MAG.PadRight(35)
        Dim counter = 0

        For i As Integer = 0 To tg904.DetList.Count - 1
            Dim curPro = tg904.DetList(i).pro
            lin = New lin()
            lin.UDMQORD = "TU".PadRight(3)
            lin.NUMRIGA = Convert.ToString(counter + 1).PadLeft(6, "0")
            lin.DESART = curPro.DES_PRO.PadRight(35)
            lin.CODEANCU = curPro.BCODE.PadRight(35)
            If (curPro.BCODE <> "") Then
                lin.TIPCODCU = "EN".PadRight(3)
            End If

            Dim curDet = tg904.DetList(i).det
            lin.QTAORD = (curDet.CART_ORD_D.Replace("+", "").Replace("-", "") & "0").PadLeft(15, "0")
            Dim coList = tg904.DetList(i).coList
            For j As Integer = 0 To tg904.DetList(i).coList.Count - 1
                Dim curCos = coList(j)
                If (curCos.TRK = "CO1") Then
                    lin.PRZUNI = (curCos.COS.Replace("+", "").Replace("-", "").Substring(0, 9)).PadLeft(15, "0")
                End If
            Next

            lin.TIPOPRZ = "AAA"
            If curPro.UM = "KG" Then
                lin.UDMPRZUN = "KGM"
            End If

            If curPro.UM = "LT" Then
                lin.UDMPRZUN = "LTR"
            End If

            If curPro.UM = "PZ" Then
                lin.UDMPRZUN = "PCE"
            End If

            lin.NRCUINTU = (curPro.QTA_FORN.Replace("+", "").Replace("-", "") & "0").PadLeft(15, "0")
            For j As Integer = 1 To lin.NUMRIGA
            Next
            ftx.NOTE = tg904.Tes.NOTE_ORD_T.PadRight(210)
            lin.CODDISTU = curPro.CODPRO.TrimStart("0").PadRight(35)
            lin.CODFORTU = curPro.CODF.PadRight(35)
            result.lin.Add(lin)
            counter += 1
        Next
        cnt.NUMLIT = (Convert.ToString(counter) & "000").PadLeft(15, "0")
        result.cnt = cnt
        result.bgm = bgm
        result.nab = nab
        result.nad = nad
        result.nai = nai
        result.nas = nas
        result.dtm = dtm
        result.ftx = ftx
        result.ftl = ftl
        Return result
    End Function
    Private Sub writeToFile(ordine_edi As ordine_edi)
        Const dirName = "C:\test"
        If Not Directory.Exists(dirName) Then
            Directory.CreateDirectory(dirName)
        End If


        Dim values() As String = {ordine_edi.bgm.TIPOREC & ordine_edi.bgm.NUMDOC}


        Dim fileName = "test.txt"
        Dim fullPathName = dirName & "\" & fileName
        File.WriteAllText(fullPathName, ordine_edi.ToString())
    End Sub
    Private Function parseLine2(lines As String()) As Tg904
        Dim Tg904 As New Tg904()
        For i As Integer = 0 To lines.Count - 1
            If (lines(i).StartsWith("TES")) Then
                Dim tes As New Tes(lines(i))
                Tg904.Tes = tes
            End If
            If (lines(i).StartsWith("TES")) Then
                Dim tes As New Tes(lines(i))
                Tg904.Tes = tes
            End If
            If (lines(i).StartsWith("FOR")) Then
                Dim forn As New Forn(lines(i))
                Tg904.forn = forn
            End If
            If (lines(i).StartsWith("RUB")) Then
                Dim rub As New Rub(lines(i))
                Tg904.rub = rub
            End If
            If (lines(i).StartsWith("PRO")) Then
                Dim bloccoDet As New BloccoDet()
                Dim pro As New Pro(lines(i))
                bloccoDet.pro = pro
                Dim det As New Dett(lines(i + 1))
                bloccoDet.det = det
                For j As Integer = 1 To 6
                    Dim co As New CO(lines(i + 1 + j), j)
                    bloccoDet.coList.Add(co)
                Next
                Tg904.DetList.Add(bloccoDet)
            End If
            If (lines(i).StartsWith("PPI")) Then

                Dim ppi_ppt As New PPI_PPT(lines(i))
                Tg904.ppi = ppi_ppt
            End If
            If (lines(i).StartsWith("PPT")) Then
                Dim ppi_ppt As New PPI_PPT(lines(i))
                Tg904.ppt = ppi_ppt
            End If
            If (lines(i).StartsWith("XNA")) Then
                Tg904.xna = New Xna_Xft(lines(i))
            End If
            If (lines(i).StartsWith("XFT")) Then
                Tg904.xft = New Xna_Xft(lines(i))
            End If
            If (lines(i).StartsWith("MIT")) Then
                Dim mit As New Mit(lines(i))
                Tg904.mit = mit
            End If
            If (lines(i).StartsWith("END")) Then
            End If
        Next
        Return Tg904
    End Function
    Private Function parseLine(line As String) As String
        Dim result As New StringBuilder()
        Dim regexStr = "(?<tes>TES)(?<val1>[a-z-A-Z-0-9]{2,40})"
        Dim regex As New Regex(regexStr)
        Dim names As String() = regex.GetGroupNames()
        Dim match As Match = regex.Match(line)
        Dim str As String
        For Each name As String In names
            If match.Success Then
                str = "GRUPPO CATTURATO " & name & " " & match.Groups(name).Value & Environment.NewLine
                result.Append(str)
            End If
        Next
        Return result.ToString()
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim tg904 = testParseFile(OpenFileDialog1.FileName)
            ''TextBox1.AppendText(str)

            Dim str = tg904.Tostring()
            Dim converter = MapToOrdineEdi(tg904)
            writeToFile(converter)
        End If
    End Sub
End Class
