Imports System.Math

Public Class Form1


    Dim rest, teiler, zahl, anzahl, zahlenfolge, zählen As Single


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtzahl.TextChanged

    End Sub

    Private Sub btnprüfen_Click(sender As System.Object, e As System.EventArgs) Handles btnprüfen.Click

        zahl = txtzahl.Text
        teiler = 2

        Do Until teiler = zahl - 1

            rest = zahl Mod teiler

            If rest = 0 Then

                lblprim.Text = "Ist diese Zahl eine Primzahl?! NEIN!"

                Exit Do

            Else

                teiler = teiler + 1

            End If



        Loop

        If teiler = zahl - 1 Then

            lblprim.Text = "Ist diese Zahl eine Primzahl?! JA!"

        End If


    End Sub

    Private Sub btnzahlenfolge_Click(sender As System.Object, e As System.EventArgs) Handles btnzahlenfolge.Click


        zahl = txtzahlenfolge.Text
        zählen = 4
        teiler = 2

        Do Until zählen = zahl


            Do Until teiler = zählen - 1

                rest = zählen Mod teiler

                If rest = 0 Then

                    anzahl = anzahl + 1
                    zählen = zählen + 1
                    Exit Do


                Else

                    teiler = teiler + 1

                End If

                zählen = zählen + 1

            Loop
        Loop




        If zählen = zahl Then

            lblzahlenfolge.Text = "Es gibt " & anzahl & " Primzahlen"

        End If













    End Sub
End Class
