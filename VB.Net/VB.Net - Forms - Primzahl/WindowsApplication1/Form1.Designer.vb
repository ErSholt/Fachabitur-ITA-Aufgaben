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
        Me.txtzahl = New System.Windows.Forms.TextBox()
        Me.lblprim = New System.Windows.Forms.Label()
        Me.lbprüfen = New System.Windows.Forms.Label()
        Me.btnprüfen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtzahlenfolge = New System.Windows.Forms.TextBox()
        Me.btnzahlenfolge = New System.Windows.Forms.Button()
        Me.lblzahlenfolge = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtzahl
        '
        Me.txtzahl.Location = New System.Drawing.Point(15, 29)
        Me.txtzahl.Name = "txtzahl"
        Me.txtzahl.Size = New System.Drawing.Size(166, 20)
        Me.txtzahl.TabIndex = 0
        '
        'lblprim
        '
        Me.lblprim.AutoSize = True
        Me.lblprim.Location = New System.Drawing.Point(12, 95)
        Me.lblprim.Name = "lblprim"
        Me.lblprim.Size = New System.Drawing.Size(147, 13)
        Me.lblprim.TabIndex = 1
        Me.lblprim.Text = "Ist diese Zahl eine Primzahl?: "
        '
        'lbprüfen
        '
        Me.lbprüfen.AutoSize = True
        Me.lbprüfen.Location = New System.Drawing.Point(12, 13)
        Me.lbprüfen.Name = "lbprüfen"
        Me.lbprüfen.Size = New System.Drawing.Size(169, 13)
        Me.lbprüfen.TabIndex = 2
        Me.lbprüfen.Text = "Welche Zahl soll geprüft werden?!"
        '
        'btnprüfen
        '
        Me.btnprüfen.Location = New System.Drawing.Point(15, 56)
        Me.btnprüfen.Name = "btnprüfen"
        Me.btnprüfen.Size = New System.Drawing.Size(166, 23)
        Me.btnprüfen.TabIndex = 3
        Me.btnprüfen.Text = "Prüfen"
        Me.btnprüfen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Zahlen bis... Prüfen:"
        '
        'txtzahlenfolge
        '
        Me.txtzahlenfolge.Location = New System.Drawing.Point(204, 29)
        Me.txtzahlenfolge.Name = "txtzahlenfolge"
        Me.txtzahlenfolge.Size = New System.Drawing.Size(147, 20)
        Me.txtzahlenfolge.TabIndex = 5
        '
        'btnzahlenfolge
        '
        Me.btnzahlenfolge.Location = New System.Drawing.Point(204, 56)
        Me.btnzahlenfolge.Name = "btnzahlenfolge"
        Me.btnzahlenfolge.Size = New System.Drawing.Size(147, 23)
        Me.btnzahlenfolge.TabIndex = 6
        Me.btnzahlenfolge.Text = "Prüfen"
        Me.btnzahlenfolge.UseVisualStyleBackColor = True
        '
        'lblzahlenfolge
        '
        Me.lblzahlenfolge.AutoSize = True
        Me.lblzahlenfolge.Location = New System.Drawing.Point(204, 94)
        Me.lblzahlenfolge.Name = "lblzahlenfolge"
        Me.lblzahlenfolge.Size = New System.Drawing.Size(102, 13)
        Me.lblzahlenfolge.TabIndex = 7
        Me.lblzahlenfolge.Text = "Es gibt...Primzahlen!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 111)
        Me.Controls.Add(Me.lblzahlenfolge)
        Me.Controls.Add(Me.btnzahlenfolge)
        Me.Controls.Add(Me.txtzahlenfolge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprüfen)
        Me.Controls.Add(Me.lbprüfen)
        Me.Controls.Add(Me.lblprim)
        Me.Controls.Add(Me.txtzahl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Primzahl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtzahl As System.Windows.Forms.TextBox
    Friend WithEvents lblprim As System.Windows.Forms.Label
    Friend WithEvents lbprüfen As System.Windows.Forms.Label
    Friend WithEvents btnprüfen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtzahlenfolge As System.Windows.Forms.TextBox
    Friend WithEvents btnzahlenfolge As System.Windows.Forms.Button
    Friend WithEvents lblzahlenfolge As System.Windows.Forms.Label

End Class
