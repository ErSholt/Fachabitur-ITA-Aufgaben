Imports System.Console
Module Module1

    Sub Main()
        Dim betrag, zinsen, zinssatz, n, anfangsbetrag As Single


        WriteLine("Zinssatz > ")
        zinssatz = ReadLine()
        WriteLine("Bisheriger Betrag > ")
        anfangsbetrag = ReadLine()
     

        WriteLine()

        WriteLine("Sie starten mit " & anfangsbetrag & " Euro")

        betrag = anfangsbetrag

        Do While betrag < anfangsbetrag * 2


            zinsen = betrag * zinssatz / 100
            betrag = betrag + zinsen
            n = n + 1




        Loop

        WriteLine("Nach " & n & " jahren wurde ihr Kapital aufs doppelte erhöht")

        ReadLine()





    End Sub

End Module
