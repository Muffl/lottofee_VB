Public Class Form1
    Dim intZufallsZahl As Integer = 500
    Dim intVersuche As Integer = 0
    Dim intRandom As New Random



    Private Sub cmdEnde_Click(sender As Object, e As EventArgs) Handles cmdEnde.Click
        Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSpielen_Click(sender As Object, e As EventArgs) Handles cmdSpielen.Click
        intZufallsZahl = intRandom.Next(1, 1001)


        lblInfo.Text = "Gib eine Zahl zwischen 1 und 1000 ein," & Chr(13) & Chr(10) + "klicke danach auf <Richtige Zahl?>."
        cmdRichtigeZahl.Enabled = True
        cmdSpielen.Enabled = False
        txtEingabe.Enabled = True
        txtEingabe.Focus()


    End Sub

    Private Sub cmdRichtigeZahl_Click(sender As Object, e As EventArgs) Handles cmdRichtigeZahl.Click
        ProbeEingabe()

    End Sub


    Private Sub ProbeEingabe()
        Dim intNutzerZahl As Integer
        Dim strNeueEingabe = "Versuche es noch einmal"
        Try

            intNutzerZahl = Convert.ToInt32(txtEingabe.Text)
        Catch ex As Exception
            lblInfo.Text = "Fehler: Du musst eine Zahl eingeben"
            AktiviereTextfeld()

            Exit Sub
        End Try
        intVersuche += 1
        lblAnzahlVersuche.Text = intVersuche.ToString
        '-----------
        If intNutzerZahl = intZufallsZahl Then
            lblInfo.Text = txtEingabe.Text & " ist die gesuchte Zahl." & vbCrLf &
                "Du hast " & intVersuche.ToString & " Versuche benötigt."
            lblRichtigeZahl.Text = txtEingabe.Text

            EventuellNeuesSpiel()
        ElseIf intNutzerZahl < intZufallsZahl Then
            lblKleineZahl.Text = txtEingabe.Text
            lblInfo.Text = "Die Zahl " & txtEingabe.Text & " ist zu klein" & vbCrLf & strNeueEingabe
            aktiviereTextfeld()
        Else
            lblGrosseZahl.Text = txtEingabe.Text
            lblInfo.Text = "Die Zahl " & txtEingabe.Text & " ist zu groß" & vbCrLf & strNeueEingabe
            AktiviereTextfeld()
        End If


    End Sub

    Sub AktiviereTextfeld()
        txtEingabe.Enabled = True : txtEingabe.Clear() : txtEingabe.Focus()

    End Sub

    Sub EventuellNeuesSpiel()
        cmdSpielen.Text = "&Neues Spiel?" : cmdSpielen.Enabled = True : cmdSpielen.Focus()
        txtEingabe.Clear() : txtEingabe.Enabled = False
        cmdRichtigeZahl.Enabled = False
        intVersuche = 0
        AnzeigeZuruecksetzen()


    End Sub

    Sub AnzeigeZuruecksetzen()
        lblRichtigeZahl.Text = "?"
        lblKleineZahl.Text = "1"
        lblGrosseZahl.Text = "1001"
    End Sub
End Class
