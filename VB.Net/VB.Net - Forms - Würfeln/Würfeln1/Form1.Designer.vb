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
        Me.lblsp1 = New System.Windows.Forms.Label()
        Me.btnwürfeln = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblsp2 = New System.Windows.Forms.Label()
        Me.lblrunde = New System.Windows.Forms.Label()
        Me.Lblzahl = New System.Windows.Forms.Label()
        Me.txtrunden = New System.Windows.Forms.TextBox()
        Me.lblmaxrunden = New System.Windows.Forms.Label()
        Me.lblwin = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblsp1
        '
        Me.lblsp1.AutoSize = True
        Me.lblsp1.Location = New System.Drawing.Point(110, 53)
        Me.lblsp1.Name = "lblsp1"
        Me.lblsp1.Size = New System.Drawing.Size(48, 13)
        Me.lblsp1.TabIndex = 0
        Me.lblsp1.Text = "Spieler1:"
        '
        'btnwürfeln
        '
        Me.btnwürfeln.Location = New System.Drawing.Point(106, 143)
        Me.btnwürfeln.Name = "btnwürfeln"
        Me.btnwürfeln.Size = New System.Drawing.Size(75, 52)
        Me.btnwürfeln.TabIndex = 1
        Me.btnwürfeln.Text = "Würfeln"
        Me.btnwürfeln.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(12, 172)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblsp2
        '
        Me.lblsp2.AutoSize = True
        Me.lblsp2.Location = New System.Drawing.Point(110, 79)
        Me.lblsp2.Name = "lblsp2"
        Me.lblsp2.Size = New System.Drawing.Size(48, 13)
        Me.lblsp2.TabIndex = 3
        Me.lblsp2.Text = "Spieler2:"
        '
        'lblrunde
        '
        Me.lblrunde.AutoSize = True
        Me.lblrunde.Location = New System.Drawing.Point(12, 79)
        Me.lblrunde.Name = "lblrunde"
        Me.lblrunde.Size = New System.Drawing.Size(42, 13)
        Me.lblrunde.TabIndex = 4
        Me.lblrunde.Text = "Runde:"
        '
        'Lblzahl
        '
        Me.Lblzahl.AutoSize = True
        Me.Lblzahl.Location = New System.Drawing.Point(12, 53)
        Me.Lblzahl.Name = "Lblzahl"
        Me.Lblzahl.Size = New System.Drawing.Size(31, 13)
        Me.Lblzahl.TabIndex = 5
        Me.Lblzahl.Text = "Zahl:"
        '
        'txtrunden
        '
        Me.txtrunden.Location = New System.Drawing.Point(127, 16)
        Me.txtrunden.Name = "txtrunden"
        Me.txtrunden.Size = New System.Drawing.Size(27, 20)
        Me.txtrunden.TabIndex = 6
        '
        'lblmaxrunden
        '
        Me.lblmaxrunden.AutoSize = True
        Me.lblmaxrunden.Location = New System.Drawing.Point(13, 19)
        Me.lblmaxrunden.Name = "lblmaxrunden"
        Me.lblmaxrunden.Size = New System.Drawing.Size(111, 13)
        Me.lblmaxrunden.TabIndex = 7
        Me.lblmaxrunden.Text = "Gewünschte Runden:"
        '
        'lblwin
        '
        Me.lblwin.AutoSize = True
        Me.lblwin.Location = New System.Drawing.Point(13, 112)
        Me.lblwin.Name = "lblwin"
        Me.lblwin.Size = New System.Drawing.Size(80, 13)
        Me.lblwin.TabIndex = 8
        Me.lblwin.Text = "Gewonnen hat:"
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(13, 143)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 9
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 207)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.lblwin)
        Me.Controls.Add(Me.lblmaxrunden)
        Me.Controls.Add(Me.txtrunden)
        Me.Controls.Add(Me.Lblzahl)
        Me.Controls.Add(Me.lblrunde)
        Me.Controls.Add(Me.lblsp2)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnwürfeln)
        Me.Controls.Add(Me.lblsp1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Würfelspiel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsp1 As System.Windows.Forms.Label
    Friend WithEvents btnwürfeln As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblsp2 As System.Windows.Forms.Label
    Friend WithEvents lblrunde As System.Windows.Forms.Label
    Friend WithEvents Lblzahl As System.Windows.Forms.Label
    Friend WithEvents txtrunden As System.Windows.Forms.TextBox
    Friend WithEvents lblmaxrunden As System.Windows.Forms.Label
    Friend WithEvents lblwin As System.Windows.Forms.Label
    Friend WithEvents btnreset As System.Windows.Forms.Button

End Class
