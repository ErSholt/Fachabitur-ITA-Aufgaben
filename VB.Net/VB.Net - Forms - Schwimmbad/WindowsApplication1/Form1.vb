Public Class Form1
    Dim betrag, zahlen, einzel, solarium, sauna As Single

    Private Sub Btneinzel_Click(sender As System.Object, e As System.EventArgs) Handles Btneinzel.Click

        betrag = betrag + 3
        einzel = einzel + 1

    End Sub

    Private Sub BtnSolarium_Click(sender As System.Object, e As System.EventArgs) Handles BtnSolarium.Click

        betrag = betrag + 4
        solarium = solarium + 1

    End Sub

    Private Sub Btnsauna_Click(sender As System.Object, e As System.EventArgs) Handles Btnsauna.Click

        betrag = betrag + 5
        sauna = sauna + 1

    End Sub

    Private Sub btnok_Click(sender As System.Object, e As System.EventArgs) Handles btnok.Click

        lblbetrag.Text = " Gesamtbetrag der zu Zahlen ist:   " & betrag & "EUR"

    End Sub


    Private Sub txtzahlen_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtzahlen.TextChanged

        zahlen = Val(txtzahlen.Text)

        If Val(txtzahlen.Text) = betrag Then

            lblauswurf.Text = "Auswurf: " & einzel & "xEinzelkarten; " & solarium & "xSolarium Zeitkarten; " & sauna & "xSauna Zeitkarten"

        ElseIf Val(txtzahlen.Text) > betrag Then

            lblauswurf.Text = "Auswurf: " & einzel & "xEinzelkarten; " & solarium & "xSolarium Zeitkarten; " & sauna & "xSauna Zeitkarten; Wechselgeld: " & zahlen - betrag & "EUR"

        ElseIf Val(txtzahlen.Text) < betrag Then

            lblauswurf.Text = "Auswurf: Zu wenig geld! Bitte " & betrag - zahlen & "EUR mehr einwerfen"

        ElseIf Val(txtzahlen.Text) = 0 Then

            lblauswurf.Text = "Auswurf: "

        End If

    End Sub

    Private Sub Btnende_Click(sender As System.Object, e As System.EventArgs) Handles Btnende.Click

        betrag = 0
        zahlen = 0
        sauna = 0
        solarium = 0
        einzel = 0

        lblbetrag.Text = "Gesamtbetrag der zu Zahlen ist: "
        lblauswurf.Text = "Auswurf: "
        txtzahlen.Text = 0

    End Sub

    
    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click

        betrag = 0
        zahlen = 0
        sauna = 0
        solarium = 0
        einzel = 0

    End Sub
End Class
