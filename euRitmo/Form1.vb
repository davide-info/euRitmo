Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Private Function testParseFile(fileName As String)
        Dim result As New StringBuilder()
        Dim lines = File.ReadAllLines(fileName)
        Dim tg904 As Tg904 = Nothing




        For Each line As String In lines
            tg904 = parseLine2(line)

        Next
        MessageBox.Show("RISULTATO " & result.ToString())

        Return tg904


    End Function


    Private Function parseLine2(line As String) As Tg904
        Dim tg904 As New Tg904()

        If (line.startsWith("TES")) Then

            Dim tes As New Tes(line.substring(0, 3))
            tg904.setTes(tes)
        End If
        If (line.startsWith("FOR")) Then
            Dim forn As New Forn(line.substring(0, 3))

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
            Dim str = testParseFile(OpenFileDialog1.FileName)
            ''TextBox1.AppendText(str)
            MessageBox.Show(str)


        End If

    End Sub
End Class
