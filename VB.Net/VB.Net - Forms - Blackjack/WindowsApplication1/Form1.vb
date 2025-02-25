Public Class Form1
    Dim rnd As New System.Random()
    Dim neuwürfeln, würfeln, neuwürfeln2, würfeln2 As Integer

    Dim spieler1 As Boolean = True


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        




    End Sub

    Private Sub btnja_Click(sender As System.Object, e As System.EventArgs) Handles btnja.Click





        If spieler1 = True And würfeln <= 21 Then

            neuwürfeln = rnd.Next(1, 11)

            If neuwürfeln <> 5 And neuwürfeln <> 6 Then


                würfeln = würfeln + neuwürfeln

                If würfeln > 21 Then

                    lblwin.Text = "Gewonnen hat: Spieler2"
                    würfeln = 0

                End If

                lblsp1.Text = "Spieler1 Augen: " & würfeln


            ElseIf neuwürfeln = 5 And neuwürfeln = 6 Then

                würfeln = würfeln + 0

                If würfeln > 21 Then

                    lblwin.Text = "Gewonnen hat: Spieler2"
                    würfeln = 0

                End If

                lblsp1.Text = "Spieler1 Augen: " & würfeln

            End If
        End If






        If spieler1 = False And würfeln <= 21 Then

            neuwürfeln2 = rnd.Next(1, 11)

            If neuwürfeln2 <> 5 And neuwürfeln2 <> 6 Then


                würfeln2 = würfeln2 + neuwürfeln2

                If würfeln2 > 21 Then

                    lblwin.Text = "Gewonnen hat Spieler1"
                    würfeln2 = 0

                End If

                lblsp2.Text = "Spieler2 Augen: " & würfeln2

            ElseIf neuwürfeln2 = 5 And neuwürfeln2 = 6 Then

                würfeln2 = würfeln2 + 0

                If würfeln2 > 21 Then

                    lblwin.Text = "Gewonnen hat Spieler1"
                    würfeln2 = 0

                End If

                lblsp2.Text = "Spieler2 Augen: " & würfeln2

            End If
        End If



    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click

        If spieler1 = True Then

            spieler1 = False
            Lblkarte.Text = "Spieler2 Karte ziehen?"
            btn2.Text = "Gewinner erfahren!"
            
        ElseIf spieler1 = False Then

            If würfeln < würfeln2 Then

                lblwin.Text = "Gewonnen hat: Spieler2"

            ElseIf würfeln > würfeln2 Then

                lblwin.Text = "Gewonnen hat: Spieler1"

            ElseIf würfeln = würfeln2 Then

                lblwin.Text = "Patt"

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        würfeln = 0
        würfeln2 = 0
        neuwürfeln = 0
        neuwürfeln2 = 0
        spieler1 = True
        Lblkarte.Text = "Spieler1 Karte ziehen?"
        lblwin.Text = "Gewonnen hat: "
        lblsp1.Text = "Spieler1 Augen: "
        lblsp2.Text = "Spieler2 Augen: "
        btn2.Text = "Spieler2 ist dran!"










    End Sub
End Class
