
Imports System.Console



Module Module1
    Dim z4, z3, z2, z1, z0 As Single

    Sub Main()
        Dim x, xb, xb2 As Single

        WriteLine()
        WriteLine("Beispielprogramm für die Ausgabe von x-Werten und f(x)-Werten")
        WriteLine("Der Funktion : f(x)= Z4 * x^4 + z3 * x^3 + z2 * x^2 + z1 * x + z")
        WriteLine()
        WriteLine("Ersten Wertebereich eingeben xb:")
        xb = ReadLine()
        WriteLine("Zweiten Wertebereich eingeben xb:")
        xb2 = ReadLine()
        WriteLine("Z0 eingeben:")
        z0 = ReadLine()
        WriteLine("Z1 eingeben:")
        z1 = ReadLine()
        WriteLine("Z2 eingeben:")
        z2 = ReadLine()
        WriteLine("Z3 eingeben:")
        z3 = ReadLine()
        WriteLine("Z4 eingeben:")
        z4 = ReadLine()


        WriteLine()
        WriteLine("X-Wert   Y-Wert ")
        WriteLine("________________")
        For x = xb To xb2 Step 1

            If x > 0 Then

                WriteLine("+" & x.ToString("0.00") & "   |   " & f(x).ToString("0.000"))

            ElseIf x = 0 Then

                WriteLine(x.ToString("0.000") & "   |   " & f(x).ToString("0.000"))
            Else

                WriteLine(x.ToString("0.00") & "   |   " & f(x).ToString("0.000"))


            End If

        Next x
      





        ReadLine()
    End Sub
    Function f(ByVal x As Single) As Single

        Return z4 * x ^ 4 + z3 * x ^ 3 + z2 * x ^ 2 + z1 ^ x + z0

    End Function
End Module
