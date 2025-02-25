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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnja = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lblsp1 = New System.Windows.Forms.Label()
        Me.lblsp2 = New System.Windows.Forms.Label()
        Me.Lblkarte = New System.Windows.Forms.Label()
        Me.lblwin = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnja
        '
        Me.btnja.Location = New System.Drawing.Point(157, 71)
        Me.btnja.Name = "btnja"
        Me.btnja.Size = New System.Drawing.Size(127, 23)
        Me.btnja.TabIndex = 0
        Me.btnja.Text = "Ja"
        Me.btnja.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(157, 100)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(127, 23)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Spieler2 ist dran!"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'lblsp1
        '
        Me.lblsp1.AutoSize = True
        Me.lblsp1.BackColor = System.Drawing.Color.Transparent
        Me.lblsp1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblsp1.Location = New System.Drawing.Point(13, 24)
        Me.lblsp1.Name = "lblsp1"
        Me.lblsp1.Size = New System.Drawing.Size(82, 13)
        Me.lblsp1.TabIndex = 2
        Me.lblsp1.Text = "Spieler1 Augen:"
        '
        'lblsp2
        '
        Me.lblsp2.AutoSize = True
        Me.lblsp2.BackColor = System.Drawing.Color.Transparent
        Me.lblsp2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblsp2.Location = New System.Drawing.Point(13, 46)
        Me.lblsp2.Name = "lblsp2"
        Me.lblsp2.Size = New System.Drawing.Size(82, 13)
        Me.lblsp2.TabIndex = 3
        Me.lblsp2.Text = "Spieler2 Augen:"
        '
        'Lblkarte
        '
        Me.Lblkarte.AutoSize = True
        Me.Lblkarte.BackColor = System.Drawing.Color.Transparent
        Me.Lblkarte.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Lblkarte.Location = New System.Drawing.Point(12, 90)
        Me.Lblkarte.Name = "Lblkarte"
        Me.Lblkarte.Size = New System.Drawing.Size(113, 13)
        Me.Lblkarte.TabIndex = 4
        Me.Lblkarte.Text = "Spieler1 Karte ziehen?"
        '
        'lblwin
        '
        Me.lblwin.AutoSize = True
        Me.lblwin.BackColor = System.Drawing.Color.Transparent
        Me.lblwin.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblwin.Location = New System.Drawing.Point(12, 140)
        Me.lblwin.Name = "lblwin"
        Me.lblwin.Size = New System.Drawing.Size(83, 13)
        Me.lblwin.TabIndex = 5
        Me.lblwin.Text = "Gewonnen hat: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Beenden"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(288, 196)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblwin)
        Me.Controls.Add(Me.Lblkarte)
        Me.Controls.Add(Me.lblsp2)
        Me.Controls.Add(Me.lblsp1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(300, 230)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 230)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Blackjack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnja As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents lblsp1 As System.Windows.Forms.Label
    Friend WithEvents lblsp2 As System.Windows.Forms.Label
    Friend WithEvents Lblkarte As System.Windows.Forms.Label
    Friend WithEvents lblwin As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
