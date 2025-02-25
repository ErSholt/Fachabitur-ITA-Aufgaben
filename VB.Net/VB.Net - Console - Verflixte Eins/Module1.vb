
Imports System.Console

Module Module1

    Sub Main()
        Dim rnd As New System.Random
        Dim x, N, i, summe As Integer

        Write("Anzahl Würfel N ? ")
        N = ReadLine()

        For i = 1 To N

            x = rnd.Next(1, 7)
            summe = summe + x

            If x = 1 Then

                summe = 0

                Exit For
            End If
        Next


        writeline("Summe = " & Summe)






        ReadLine()
    End Sub

End Module
