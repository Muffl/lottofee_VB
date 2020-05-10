<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEnde = New System.Windows.Forms.Button()
        Me.cmdSpielen = New System.Windows.Forms.Button()
        Me.cmdRichtigeZahl = New System.Windows.Forms.Button()
        Me.lblKleineZahl = New System.Windows.Forms.Label()
        Me.lblRichtigeZahl = New System.Windows.Forms.Label()
        Me.lblGrosseZahl = New System.Windows.Forms.Label()
        Me.lblAnzahlVersuche = New System.Windows.Forms.Label()
        Me.txtEingabe = New System.Windows.Forms.TextBox()
        Me.lblZahlEingeben = New System.Windows.Forms.Label()
        Me.lblVersucheText = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdEnde
        '
        Me.cmdEnde.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnde.ForeColor = System.Drawing.Color.OrangeRed
        Me.cmdEnde.Location = New System.Drawing.Point(709, 406)
        Me.cmdEnde.Name = "cmdEnde"
        Me.cmdEnde.Size = New System.Drawing.Size(75, 32)
        Me.cmdEnde.TabIndex = 3
        Me.cmdEnde.Text = "&Ende"
        Me.cmdEnde.UseVisualStyleBackColor = True
        '
        'cmdSpielen
        '
        Me.cmdSpielen.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSpielen.ForeColor = System.Drawing.Color.Black
        Me.cmdSpielen.Location = New System.Drawing.Point(313, 319)
        Me.cmdSpielen.Name = "cmdSpielen"
        Me.cmdSpielen.Size = New System.Drawing.Size(173, 58)
        Me.cmdSpielen.TabIndex = 0
        Me.cmdSpielen.Text = "&Spielen"
        Me.cmdSpielen.UseVisualStyleBackColor = True
        '
        'cmdRichtigeZahl
        '
        Me.cmdRichtigeZahl.Enabled = False
        Me.cmdRichtigeZahl.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRichtigeZahl.ForeColor = System.Drawing.Color.LimeGreen
        Me.cmdRichtigeZahl.Location = New System.Drawing.Point(324, 165)
        Me.cmdRichtigeZahl.Name = "cmdRichtigeZahl"
        Me.cmdRichtigeZahl.Size = New System.Drawing.Size(152, 32)
        Me.cmdRichtigeZahl.TabIndex = 2
        Me.cmdRichtigeZahl.Text = "Richtige Zahl?"
        Me.cmdRichtigeZahl.UseVisualStyleBackColor = True
        '
        'lblKleineZahl
        '
        Me.lblKleineZahl.AutoSize = True
        Me.lblKleineZahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKleineZahl.ForeColor = System.Drawing.Color.Red
        Me.lblKleineZahl.Location = New System.Drawing.Point(111, 90)
        Me.lblKleineZahl.Name = "lblKleineZahl"
        Me.lblKleineZahl.Size = New System.Drawing.Size(32, 33)
        Me.lblKleineZahl.TabIndex = 3
        Me.lblKleineZahl.Text = "0"
        '
        'lblRichtigeZahl
        '
        Me.lblRichtigeZahl.AutoSize = True
        Me.lblRichtigeZahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRichtigeZahl.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblRichtigeZahl.Location = New System.Drawing.Point(111, 138)
        Me.lblRichtigeZahl.Name = "lblRichtigeZahl"
        Me.lblRichtigeZahl.Size = New System.Drawing.Size(32, 33)
        Me.lblRichtigeZahl.TabIndex = 4
        Me.lblRichtigeZahl.Text = "?"
        '
        'lblGrosseZahl
        '
        Me.lblGrosseZahl.AutoSize = True
        Me.lblGrosseZahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrosseZahl.ForeColor = System.Drawing.Color.Red
        Me.lblGrosseZahl.Location = New System.Drawing.Point(111, 183)
        Me.lblGrosseZahl.Name = "lblGrosseZahl"
        Me.lblGrosseZahl.Size = New System.Drawing.Size(83, 33)
        Me.lblGrosseZahl.TabIndex = 5
        Me.lblGrosseZahl.Text = "1001"
        '
        'lblAnzahlVersuche
        '
        Me.lblAnzahlVersuche.AutoSize = True
        Me.lblAnzahlVersuche.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnzahlVersuche.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblAnzahlVersuche.Location = New System.Drawing.Point(640, 97)
        Me.lblAnzahlVersuche.Name = "lblAnzahlVersuche"
        Me.lblAnzahlVersuche.Size = New System.Drawing.Size(32, 33)
        Me.lblAnzahlVersuche.TabIndex = 6
        Me.lblAnzahlVersuche.Text = "0"
        '
        'txtEingabe
        '
        Me.txtEingabe.Enabled = False
        Me.txtEingabe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEingabe.Location = New System.Drawing.Point(326, 97)
        Me.txtEingabe.Name = "txtEingabe"
        Me.txtEingabe.Size = New System.Drawing.Size(150, 26)
        Me.txtEingabe.TabIndex = 1
        '
        'lblZahlEingeben
        '
        Me.lblZahlEingeben.AutoSize = True
        Me.lblZahlEingeben.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZahlEingeben.Location = New System.Drawing.Point(206, 100)
        Me.lblZahlEingeben.Name = "lblZahlEingeben"
        Me.lblZahlEingeben.Size = New System.Drawing.Size(114, 20)
        Me.lblZahlEingeben.TabIndex = 8
        Me.lblZahlEingeben.Text = "Zahl eingeben:"
        '
        'lblVersucheText
        '
        Me.lblVersucheText.AutoSize = True
        Me.lblVersucheText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersucheText.Location = New System.Drawing.Point(553, 103)
        Me.lblVersucheText.Name = "lblVersucheText"
        Me.lblVersucheText.Size = New System.Drawing.Size(81, 20)
        Me.lblVersucheText.TabIndex = 9
        Me.lblVersucheText.Text = "Versuche:"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(267, 223)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(273, 20)
        Me.lblInfo.TabIndex = 10
        Me.lblInfo.Text = "Klicke auf <Spielen> um zu beginnen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblVersucheText)
        Me.Controls.Add(Me.lblZahlEingeben)
        Me.Controls.Add(Me.txtEingabe)
        Me.Controls.Add(Me.lblAnzahlVersuche)
        Me.Controls.Add(Me.lblGrosseZahl)
        Me.Controls.Add(Me.lblRichtigeZahl)
        Me.Controls.Add(Me.lblKleineZahl)
        Me.Controls.Add(Me.cmdRichtigeZahl)
        Me.Controls.Add(Me.cmdSpielen)
        Me.Controls.Add(Me.cmdEnde)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zahlen Raten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdEnde As Button
    Friend WithEvents cmdSpielen As Button
    Friend WithEvents cmdRichtigeZahl As Button
    Friend WithEvents lblKleineZahl As Label
    Friend WithEvents lblRichtigeZahl As Label
    Friend WithEvents lblGrosseZahl As Label
    Friend WithEvents lblAnzahlVersuche As Label
    Friend WithEvents txtEingabe As TextBox
    Friend WithEvents lblZahlEingeben As Label
    Friend WithEvents lblVersucheText As Label
    Friend WithEvents lblInfo As Label
End Class
