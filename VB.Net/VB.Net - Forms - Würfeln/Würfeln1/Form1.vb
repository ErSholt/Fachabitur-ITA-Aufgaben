Public Class Form1

    Dim zahl, runde, zahlneu, zahlneu2, maxrunde As Integer


    Dim spieler1 As Boolean = True

    Dim rnd As New System.Random()



    Private Sub btnwürfeln_Click(sender As System.Object, e As System.EventArgs) Handles btnwürfeln.Click

        maxrunde = Val(txtrunden.Text)

        runde = runde + 1
        lblrunde.Text = "Runde: " & runde

        If runde < maxrunde Then
            If spieler1 = True Then

                zahl = rnd.Next(1, 7)
                Lblzahl.Text = "Zahl: " & zahl
                zahlneu = zahlneu + zahl
                lblsp1.Text = "Spieler1: " & zahlneu
                spieler1 = False

            Else

                zahl = rnd.Next(1, 7)
                Lblzahl.Text = "Zahl: " & zahl
                zahlneu2 = zahlneu2 + zahl
                lblsp2.Text = "Spieler2: " & zahlneu2
                spieler1 = True

            End If

        ElseIf runde = maxrunde And zahlneu > zahlneu2 Then

            lblwin.Text = "Gewonnen hat: Spieler1 mit " & zahlneu & "Punkten"

        ElseIf runde = maxrunde And zahlneu < zahlneu2 Then

            lblwin.Text = "Gewonnen hat: Spieler2 mit " & zahlneu2 & "Punkten"

        ElseIf runde = maxrunde And zahlneu = zahlneu2 Then

            lblwin.Text = "Es steht unentschieden!"

        End If

       


    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click

        End

    End Sub

    Private Sub lblzahl_Click(sender As System.Object, e As System.EventArgs) Handles lblsp1.Click

    End Sub

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click

        zahlneu = 0
        zahlneu2 = 0
        runde = 0
        lblwin.Text = "Gewonnen hat:"
        lblrunde.Text = "Runde: "
        Lblzahl.Text = "Zahl: "
        lblsp1.Text = "Spieler1: "
        lblsp2.Text = "Spieler2: "

    End Sub
End Class
