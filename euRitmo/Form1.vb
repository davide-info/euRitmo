Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Private Function testParseFile(fileName As String) As Tg904

        Dim result As New StringBuilder()
        Dim lines = File.ReadAllLines(fileName)
        Dim tg904 As Tg904 = Nothing




        For Each line As String In lines
            tg904 = parseLine2(line)

        Next

        Return tg904


    End Function


    Private Function parseLine2(line As String) As Tg904
        Dim tg904 As New Tg904()


        If (line.StartsWith("TES")) Then
            ''MessageBox.Show("QUI " & line.Substring(0, 3))

            Dim tes As New Tes(line)
            tg904.Tes = tes
        End If
        If (line.StartsWith("FOR")) Then
            Dim forn As New Forn(line)
            tg904.forn = forn



        End If
        If (line.StartsWith("RUB")) Then
            Dim rub As New Rub(line)

            tg904.rub = rub




        End If
        If (line.StartsWith("MIT")) Then
            Dim mit As New Mit(line)
            tg904.mit = mit

        End If
        If (line.StartsWith("PRO")) Then
            Dim pro As New Pro(line)
            tg904.Pro = pro
        End If
        Dim cols As New List(Of Col)


        If (line.StartsWith("CO1")) Then

            cols.Add(New Col(line))



        End If
        If (line.StartsWith("CO2")) Then
            cols.Add(New Col(line))
        End If
        If (line.StartsWith("CO3")) Then
            cols.Add(New Col(line))

        End If
        If (line.StartsWith("CO4")) Then
            cols.Add(New Col(line))
        End If
        If (line.StartsWith("CO5")) Then
            cols.Add(New Col(line))
        End If
        If (line.StartsWith("CO6")) Then
            cols.Add(New Col(line))
        End If
        tg904.cols = cols

        If (line.StartsWith("DET")) Then
            tg904.Dtope = New Dtope(line)





        End If
        If (line.StartsWith("END")) Then
            tg904.endtr = New EndTr(line)

        End If

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

            MessageBox.Show(str)


        End If

    End Sub
End Class
