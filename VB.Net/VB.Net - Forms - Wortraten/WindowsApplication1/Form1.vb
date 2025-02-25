Public Class Form1
    Dim rätselwort, neuwort, strich, buchstabe As String
    Dim länge, k As Single


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub btnstart_Click(sender As System.Object, e As System.EventArgs) Handles btnstart.Click


        rätselwort = txträtsel.Text
        länge = rätselwort.length
        neuwort = ""
        btnstart.Text = "Neues Spiel"

        For k = 0 To länge - 1
            buchstabe = rätselwort.Substring(k, 1)

            If buchstabe = "a" Or buchstabe = "u" Or buchstabe = "o" Or buchstabe = "e" Then
                strich = "_"
                neuwort = neuwort + strich
            Else
                neuwort = neuwort + buchstabe

            End If
        Next

        lblrätsel.Text = "Rätselwort: " & neuwort
        txträtsel.Text = ""



    End Sub

   
    Private Sub txtlösung_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlösung.TextChanged


        If txtlösung.Text = rätselwort Then
            lbllösung.Text = "Richtig"
            lbllösung.ForeColor = Color.Green

        End If



    End Sub
End Class
