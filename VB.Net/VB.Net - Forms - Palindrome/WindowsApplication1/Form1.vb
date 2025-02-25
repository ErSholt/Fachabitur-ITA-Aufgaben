Public Class Form1
    Dim wort, neuwort, zeichen As String
    Dim länge As Single

    Private Sub btnstart_Click(sender As System.Object, e As System.EventArgs) Handles btnstart.Click
        neuwort = ""
        wort = txträtsel.Text
        länge = wort.Length
        wort = wort.ToLower
        For i = 0 To länge - 1
            zeichen = wort.Substring(länge - i - 1, 1)
            neuwort = neuwort + zeichen

        Next i

        If neuwort = wort Then
            Label2.Text = "Es ist ein Palindrom"
        Else
            Label2.Text = "Es ist kein Palindrom"
        End If




    End Sub

End Class
