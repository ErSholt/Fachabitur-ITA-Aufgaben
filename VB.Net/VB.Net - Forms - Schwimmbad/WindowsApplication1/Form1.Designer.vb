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
        Me.Btneinzel = New System.Windows.Forms.Button()
        Me.BtnSolarium = New System.Windows.Forms.Button()
        Me.Btnsauna = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.lblbetrag = New System.Windows.Forms.Label()
        Me.txtzahlen = New System.Windows.Forms.TextBox()
        Me.lblgeldeinwurf = New System.Windows.Forms.Label()
        Me.lblauswurf = New System.Windows.Forms.Label()
        Me.Btnende = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btneinzel
        '
        Me.Btneinzel.Location = New System.Drawing.Point(12, 12)
        Me.Btneinzel.Name = "Btneinzel"
        Me.Btneinzel.Size = New System.Drawing.Size(109, 23)
        Me.Btneinzel.TabIndex = 0
        Me.Btneinzel.Text = "Einzelkarte (3EUR)"
        Me.Btneinzel.UseVisualStyleBackColor = True
        '
        'BtnSolarium
        '
        Me.BtnSolarium.Location = New System.Drawing.Point(12, 41)
        Me.BtnSolarium.Name = "BtnSolarium"
        Me.BtnSolarium.Size = New System.Drawing.Size(109, 23)
        Me.BtnSolarium.TabIndex = 1
        Me.BtnSolarium.Text = "Solarium (4EUR)"
        Me.BtnSolarium.UseVisualStyleBackColor = True
        '
        'Btnsauna
        '
        Me.Btnsauna.Location = New System.Drawing.Point(12, 70)
        Me.Btnsauna.Name = "Btnsauna"
        Me.Btnsauna.Size = New System.Drawing.Size(109, 23)
        Me.Btnsauna.TabIndex = 2
        Me.Btnsauna.Text = "Sauna (5EUR)"
        Me.Btnsauna.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(141, 12)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 110)
        Me.btnok.TabIndex = 3
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'lblbetrag
        '
        Me.lblbetrag.AutoSize = True
        Me.lblbetrag.Location = New System.Drawing.Point(300, 12)
        Me.lblbetrag.Name = "lblbetrag"
        Me.lblbetrag.Size = New System.Drawing.Size(169, 13)
        Me.lblbetrag.TabIndex = 4
        Me.lblbetrag.Text = " Gesamtbetrag der zu Zahlen ist:   "
        '
        'txtzahlen
        '
        Me.txtzahlen.Location = New System.Drawing.Point(466, 38)
        Me.txtzahlen.Name = "txtzahlen"
        Me.txtzahlen.Size = New System.Drawing.Size(187, 20)
        Me.txtzahlen.TabIndex = 5
        '
        'lblgeldeinwurf
        '
        Me.lblgeldeinwurf.AutoSize = True
        Me.lblgeldeinwurf.Location = New System.Drawing.Point(268, 41)
        Me.lblgeldeinwurf.Name = "lblgeldeinwurf"
        Me.lblgeldeinwurf.Size = New System.Drawing.Size(192, 13)
        Me.lblgeldeinwurf.TabIndex = 6
        Me.lblgeldeinwurf.Text = "Bitte den geforderten Betrag einwerfen:"
        '
        'lblauswurf
        '
        Me.lblauswurf.AutoSize = True
        Me.lblauswurf.Location = New System.Drawing.Point(412, 70)
        Me.lblauswurf.Name = "lblauswurf"
        Me.lblauswurf.Size = New System.Drawing.Size(48, 13)
        Me.lblauswurf.TabIndex = 7
        Me.lblauswurf.Text = "Auswurf:"
        '
        'Btnende
        '
        Me.Btnende.Location = New System.Drawing.Point(466, 99)
        Me.Btnende.Name = "Btnende"
        Me.Btnende.Size = New System.Drawing.Size(187, 23)
        Me.Btnende.TabIndex = 8
        Me.Btnende.Text = "Tickets und Wechselgeld ok? Ja!"
        Me.Btnende.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(12, 99)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(109, 23)
        Me.btnreset.TabIndex = 9
        Me.btnreset.Text = "Zurücksetzen"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 139)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Btnende)
        Me.Controls.Add(Me.lblauswurf)
        Me.Controls.Add(Me.lblgeldeinwurf)
        Me.Controls.Add(Me.txtzahlen)
        Me.Controls.Add(Me.lblbetrag)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Btnsauna)
        Me.Controls.Add(Me.BtnSolarium)
        Me.Controls.Add(Me.Btneinzel)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Kassenautomat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btneinzel As System.Windows.Forms.Button
    Friend WithEvents BtnSolarium As System.Windows.Forms.Button
    Friend WithEvents Btnsauna As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents lblbetrag As System.Windows.Forms.Label
    Friend WithEvents txtzahlen As System.Windows.Forms.TextBox
    Friend WithEvents lblgeldeinwurf As System.Windows.Forms.Label
    Friend WithEvents lblauswurf As System.Windows.Forms.Label
    Friend WithEvents Btnende As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button

End Class
