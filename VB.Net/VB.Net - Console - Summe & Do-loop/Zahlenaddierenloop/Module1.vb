Imports System.Console
Module Module1

    Sub Main()
        Dim max, n, summe As Single


        WriteLine("Zählen bis > ")
        max = ReadLine()


        WriteLine()

        Do
            n = n + 1

            summe = summe + n

        Loop Until summe >= max

        WriteLine("Summe: " & summe & " Es musste: " & n & " mal gezählt werden")

        ReadLine()





    End Sub

End Module
