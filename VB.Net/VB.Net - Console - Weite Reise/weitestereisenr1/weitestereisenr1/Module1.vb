Imports System.Console

Module Module1

    Sub Main()

        Dim rnd As New System.Random
        Dim a, summe, summe2, augenzahl, i As Integer


        Write("Die weiteste Reise")
        WriteLine()
        WriteLine()
        WriteLine()


        '#########################################################################################
        '##############################Spieler1###################################################
        '#########################################################################################


        summe = 0

        For i = 1 To 3

            a = rnd.Next(1, 7)

            WriteLine("Augenzahl: " & a)
            WriteLine("Augenzahl als Hunderter(100), Zehner(10) oder Einer(1) : ")
            augenzahl = ReadLine()

            If augenzahl = 100 Then

                summe = summe + a * 100

            ElseIf augenzahl = 10 Then

                summe = summe + a * 10

            ElseIf augenzahl = 1 Then

                summe = summe + a * 1

            End If

        Next i

      

        WriteLine("KM Spieler 1: " & summe)
        WriteLine()
        WriteLine()
        WriteLine()


        '#########################################################################################
        '##############################Spieler2###################################################
        '#########################################################################################


        summe2 = 0

        For i = 1 To 3

            a = rnd.Next(1, 7)

            WriteLine("Augenzahl: " & a)
            WriteLine("Augenzahl als Hunderter(100), Zehner(10) oder Einer(1) : ")
            augenzahl = ReadLine()

            If augenzahl = 100 Then

                summe2 = summe2 + a * 100

            ElseIf augenzahl = 10 Then

                summe2 = summe2 + a * 10

            ElseIf augenzahl = 1 Then

                summe2 = summe2 + a * 1

            End If

        Next i

        WriteLine("KM Spieler 2: " & summe2)
        WriteLine()
        WriteLine()
        WriteLine()

        '#########################################################################################
        '##############################Auswertung#################################################
        '#########################################################################################


        If summe > summe2 Then
            WriteLine("Der gewinner ist Spieler 1 mit : " & summe - summe2 & "Km mehr")

        ElseIf summe < summe2 Then

            WriteLine("Der gewinner ist Spieler 2 mit : " & summe2 - summe & "Km mehr")

        ElseIf summe = summe2 Then

            WriteLine("Es steht unentschieden")
        End If





        ReadLine()

    End Sub

End Module
