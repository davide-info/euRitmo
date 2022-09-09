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


        bgm.DATADOC = tg904.Tes.DTORD
        bgm.TIPODOC = "ORDERS"
        bgm.NUMDOC = tg904.Tes.ORD.PadRight(35)
        tg904.Tes.ORD = bgm.NUMDOC
        bgm.ID_EDI_MITT1 = tg904.Tes.EDI_MITT1.PadRight(35)

        bgm.ID_EDI_MITT2 = tg904.Tes.EDI_MITT1.PadRight(4)
        bgm.ID_EDI_DEST2 = tg904.Tes.EDI_MITT2.PadRight(4)
        bgm.ID_EDI_DEST1 = tg904.Tes.EDI_DEST1.PadLeft(35)


        nas.RAGSOCF = tg904.forn.RAGSOC_For.PadRight(70)
        nas.INDIRF = tg904.forn.IND_FOR.PadRight(70)
        nas.CITTAF = tg904.forn.LOC_FOR.PadRight(35)
        nas.PROVF = tg904.forn.PROV_FOR.PadRight(9)
        nas.CAPF = tg904.forn.CAP_FOR.PadRight(9)
        nab.CODBUYER = tg904.mit.PARTIVA_CLI.PadRight(17)
        nab.QCODBUY = "VA".PadRight(3)
        nab.INDRB = tg904.mit.IND_CLI.PadRight(70)
        nab.CITTAB = tg904.mit.LOC_CLI.PadRight(35)
        nab.PROvB = tg904.mit.PROV_CLI.PadRight(9)
        nab.CAPB = tg904.mit.CAP_CLI.PadRight(9)
        nad.RAGSOCD = tg904.mit.RAGSOC_CLI.PadRight(70)
        nad.INDIRD = tg904.mit.IND_MAG.PadRight(70)
        nad.CITTAD = tg904.mit.LOC_MAG.PadRight(35)


        nai.CODFATT = tg904.mit.PARTIVA_CLI.PadRight(17)
        nai.CITTAI = tg904.mit.LOC_CLI.PadRight(35)
        nai.PROVI = tg904.mit.PROV_CLI.PadRight(9)
        nai.CAPI = tg904.mit.CAP_CLI.PadRight(9)
        dtm.DATACONS = tg904.Tes.DTPC.PadRight(8)
        dtm.TIPODATAc = "002"






        For i As Integer = 0 To tg904.DetList.Count - 1
            Dim curPro = tg904.DetList(i).pro
            lin.DESART = curPro.DES_PRO.PadRight(35)
            lin.UDMQTAORD = curPro.UM.PadRight(3)
            lin.CODEANTU = curPro.BCODE.PadRight(35)

            If (curPro.BCODE <> "") Then
                lin.TIPOCODCU = "EN".PadRight(3)

            End If

            Dim curDet = tg904.DetList(i).det
            lin.QTAORD = curDet.CART_ORD_D.Replace("+", "").Replace("-", "") & "0".PadLeft(15, "0")
            lin.UDMQTAORD = "TU".PadRight(3)



            Dim coList = tg904.DetList(i).coList
            For j As Integer = 0 To tg904.DetList(i).coList.Count - 1
                Dim curCos = coList(j)
                If (curCos.TRK = "CO1") Then
                    lin.UDMQTAORD = curCos.COS.Replace("+", "").Replace("-", "").Substring(0, 9).PadLeft(15, "0")

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
            lin.NRCUINTU = curPro.QTA_FORN.Replace("+", "").Replace("-", "") & "0".PadLeft(15, "0")



            For j As Integer = 1 To lin.NUMRIGA

            Next
            ftx.NOTE = tg904.Tes.NOTE_ORD_T.PadRight(210)
            lin.CODDISTU = curPro.CODPRO.PadRight(35)
            lin.CODFORTU = curPro.CODF.PadRight(35)





            result.lin.Add(lin)




            Next
        cnt.UDMQORDT = "CT".PadRight(3)

        If Not IsNothing(tg904.pdv) Then



        End If


        result.cnt = cnt

        result.bgm = bgm
        result.nab = nab
        result.nad = nad
        result.nai = nai
        result.dtm = dtm
        result.ftx = ftx






        Return result
    End Function
    Private Sub writeToFile(ordine_edi As ordine_edi)
        MessageBox.Show(Environment.CurrentDirectory)


        Dim values() As String = {ordine_edi.bgm.TIPOREC & ordine_edi.bgm.NUMDOC}




        File.WriteAllText("C:\test\test.txt", values(0))







    End Sub
    Private Function parseLine2(lines As String()) As Tg904
        Dim tg904 As New Tg904()

        For i As Integer = 0 To lines.Count - 1
            If (lines(i).StartsWith("TES")) Then
                Dim tes As New Tes(lines(i))
                tg904.Tes = tes
            End If
            If (lines(i).StartsWith("TES")) Then
                Dim tes As New Tes(lines(i))
                tg904.Tes = tes
            End If
            If (lines(i).StartsWith("FOR")) Then
                Dim forn As New Forn(lines(i))
                tg904.forn = forn
            End If
            If (lines(i).StartsWith("RUB")) Then
                Dim rub As New Rub(lines(i))

                tg904.rub = rub
            End If
            If (lines(i).StartsWith("DET")) Then
                Dim bloccoDet As New BloccoDet()
                Dim det As New Dett(lines(i))
                bloccoDet.det = det

                Dim pro As New Pro(lines(i + 1))
                bloccoDet.pro = pro

                For j As Integer = 1 To 6
                    Dim co As New CO(lines(i + 1 + j), j)
                    bloccoDet.coList.Add(co)
                Next
                tg904.DetList.Add(bloccoDet)
            End If
            If (lines(i).StartsWith("PPI")) Then

                Dim ppi_ppt As New PPI_PPT(lines(i))
                tg904.ppi = ppi_ppt
            End If

            If (lines(i).StartsWith("PPT")) Then

                Dim ppi_ppt As New PPI_PPT(lines(i))
                tg904.ppt = ppi_ppt
            End If
            If (lines(i).StartsWith("XNA")) Then
                tg904.xna = New Xna_Xft(lines(i))
            End If
            If (lines(i).StartsWith("XFT")) Then
                tg904.xft = New Xna_Xft(lines(i))
            End If
            If (lines(i).StartsWith("MIT")) Then
                Dim mit As New Mit(lines(i))
                tg904.mit = mit
            End If
            If (lines(i).StartsWith("END")) Then
            End If
        Next
        Return tg904


    End Function


    Private Function parseLine(line As String) As String
        Dim result As New StringBuilder()
        Dim regexStr = "(?<tes>TES)(?<val1>[a-z-A-Z-0-9]{2,40})"
        Dim regex As New Regex(regexStr)
        ''Console.WriteLine(regex)
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
