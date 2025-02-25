<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form
    Dim zahl1, zahl2, ergebnis As Single


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
        Me.btnplus = New System.Windows.Forms.Button()
        Me.Btnminus = New System.Windows.Forms.Button()
        Me.btnmal = New System.Windows.Forms.Button()
        Me.Btngeteilt = New System.Windows.Forms.Button()
        Me.Lblergebnis = New System.Windows.Forms.Label()
        Me.Lblzahl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtzahl1 = New System.Windows.Forms.TextBox()
        Me.Txtzahl2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnplus
        '
        Me.btnplus.Location = New System.Drawing.Point(12, 85)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(39, 23)
        Me.btnplus.TabIndex = 0
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'Btnminus
        '
        Me.Btnminus.Location = New System.Drawing.Point(57, 85)
        Me.Btnminus.Name = "Btnminus"
        Me.Btnminus.Size = New System.Drawing.Size(39, 23)
        Me.Btnminus.TabIndex = 2
        Me.Btnminus.Text = "-"
        Me.Btnminus.UseVisualStyleBackColor = True
        '
        'btnmal
        '
        Me.btnmal.Location = New System.Drawing.Point(102, 85)
        Me.btnmal.Name = "btnmal"
        Me.btnmal.Size = New System.Drawing.Size(39, 23)
        Me.btnmal.TabIndex = 3
        Me.btnmal.Text = "*"
        Me.btnmal.UseVisualStyleBackColor = True
        '
        'Btngeteilt
        '
        Me.Btngeteilt.Location = New System.Drawing.Point(147, 85)
        Me.Btngeteilt.Name = "Btngeteilt"
        Me.Btngeteilt.Size = New System.Drawing.Size(39, 23)
        Me.Btngeteilt.TabIndex = 4
        Me.Btngeteilt.Text = "/"
        Me.Btngeteilt.UseVisualStyleBackColor = True
        '
        'Lblergebnis
        '
        Me.Lblergebnis.AutoSize = True
        Me.Lblergebnis.Location = New System.Drawing.Point(12, 123)
        Me.Lblergebnis.Name = "Lblergebnis"
        Me.Lblergebnis.Size = New System.Drawing.Size(51, 13)
        Me.Lblergebnis.TabIndex = 5
        Me.Lblergebnis.Text = "Ergebnis:"
        '
        'Lblzahl1
        '
        Me.Lblzahl1.AutoSize = True
        Me.Lblzahl1.Location = New System.Drawing.Point(12, 22)
        Me.Lblzahl1.Name = "Lblzahl1"
        Me.Lblzahl1.Size = New System.Drawing.Size(43, 13)
        Me.Lblzahl1.TabIndex = 6
        Me.Lblzahl1.Text = "Zahl 1 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Zahl 2 :"
        '
        'txtzahl1
        '
        Me.txtzahl1.Location = New System.Drawing.Point(62, 22)
        Me.txtzahl1.Name = "txtzahl1"
        Me.txtzahl1.Size = New System.Drawing.Size(100, 20)
        Me.txtzahl1.TabIndex = 8
        '
        'Txtzahl2
        '
        Me.Txtzahl2.Location = New System.Drawing.Point(62, 48)
        Me.Txtzahl2.Name = "Txtzahl2"
        Me.Txtzahl2.Size = New System.Drawing.Size(100, 20)
        Me.Txtzahl2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 148)
        Me.Controls.Add(Me.Txtzahl2)
        Me.Controls.Add(Me.txtzahl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lblzahl1)
        Me.Controls.Add(Me.Lblergebnis)
        Me.Controls.Add(Me.Btngeteilt)
        Me.Controls.Add(Me.btnmal)
        Me.Controls.Add(Me.Btnminus)
        Me.Controls.Add(Me.btnplus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnplus As System.Windows.Forms.Button
    Friend WithEvents Btnminus As System.Windows.Forms.Button
    Friend WithEvents btnmal As System.Windows.Forms.Button
    Friend WithEvents Btngeteilt As System.Windows.Forms.Button
    Friend WithEvents Lblergebnis As System.Windows.Forms.Label
    Friend WithEvents Lblzahl1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtzahl1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtzahl2 As System.Windows.Forms.TextBox



    
    Private Sub btnplus_Click(sender As System.Object, e As System.EventArgs) Handles btnplus.Click

        zahl1 = Val(txtzahl1.Text)
        zahl2 = Val(Txtzahl2.Text)
        ergebnis = zahl1 + zahl2
        Lblergebnis.Text = "Ergebnis: " & ergebnis

    End Sub

    Private Sub Btnminus_Click(sender As System.Object, e As System.EventArgs) Handles Btnminus.Click

        zahl1 = Val(txtzahl1.Text)
        zahl2 = Val(Txtzahl2.Text)
        ergebnis = zahl1 - zahl2
        Lblergebnis.Text = "Ergebnis: " & ergebnis

    End Sub

    Private Sub btnmal_Click(sender As System.Object, e As System.EventArgs) Handles btnmal.Click

        zahl1 = Val(txtzahl1.Text)
        zahl2 = Val(Txtzahl2.Text)
        ergebnis = zahl1 * zahl2
        Lblergebnis.Text = "Ergebnis: " & ergebnis

    End Sub

    Private Sub Btngeteilt_Click(sender As System.Object, e As System.EventArgs) Handles Btngeteilt.Click

        zahl1 = Val(txtzahl1.Text)
        zahl2 = Val(Txtzahl2.Text)
        ergebnis = zahl1 / zahl2
        Lblergebnis.Text = "Ergebnis: " & ergebnis

    End Sub
End Class

