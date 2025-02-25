Imports System.Console
Module Module1

    Sub Main()
        Dim betrag, zinsen, zinssatz As Single
        Dim laufzeit, i As Integer

        WriteLine("Zinssatz > ")
        zinssatz = ReadLine()
        WriteLine("Bisheriger Betrag > ")
        betrag = ReadLine()
        WriteLine("Laufzeit eingeben > ")
        laufzeit = ReadLine()

        WriteLine()

        WriteLine("Sie starten mit " & betrag & " Euro")


        For i = 1 To laufzeit

            zinsen = betrag * zinssatz / 100
            betrag = betrag + zinsen
            WriteLine("Nach " & i & " jahren hast du " & betrag & " Euro")


        Next i

        ReadLine()




    End Sub

End Module
