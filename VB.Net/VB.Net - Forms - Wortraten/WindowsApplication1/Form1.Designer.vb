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
        Me.txträtsel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtlösung = New System.Windows.Forms.TextBox()
        Me.lbllösung = New System.Windows.Forms.Label()
        Me.lblrätsel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txträtsel
        '
        Me.txträtsel.Location = New System.Drawing.Point(12, 21)
        Me.txträtsel.Name = "txträtsel"
        Me.txträtsel.Size = New System.Drawing.Size(264, 20)
        Me.txträtsel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hier das zu Lösende Wort eingeben:"
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(12, 48)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(264, 23)
        Me.btnstart.TabIndex = 2
        Me.btnstart.Text = "Spiel Starten"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 139)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(180, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Bitte geben sie das Lösungswort ein:"
        '
        'txtlösung
        '
        Me.txtlösung.Location = New System.Drawing.Point(12, 155)
        Me.txtlösung.Name = "txtlösung"
        Me.txtlösung.Size = New System.Drawing.Size(264, 20)
        Me.txtlösung.TabIndex = 4
        '
        'lbllösung
        '
        Me.lbllösung.AutoSize = True
        Me.lbllösung.ForeColor = System.Drawing.Color.Red
        Me.lbllösung.Location = New System.Drawing.Point(114, 210)
        Me.lbllösung.Name = "lbllösung"
        Me.lbllösung.Size = New System.Drawing.Size(38, 13)
        Me.lbllösung.TabIndex = 5
        Me.lbllösung.Text = "Falsch"
        '
        'lblrätsel
        '
        Me.lblrätsel.AutoSize = True
        Me.lblrätsel.Location = New System.Drawing.Point(13, 115)
        Me.lblrätsel.Name = "lblrätsel"
        Me.lblrätsel.Size = New System.Drawing.Size(57, 13)
        Me.lblrätsel.TabIndex = 6
        Me.lblrätsel.Text = "Rätselwort"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 266)
        Me.Controls.Add(Me.lblrätsel)
        Me.Controls.Add(Me.lbllösung)
        Me.Controls.Add(Me.txtlösung)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txträtsel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Wortspiel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txträtsel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents txtlösung As System.Windows.Forms.TextBox
    Friend WithEvents lbllösung As System.Windows.Forms.Label
    Friend WithEvents lblrätsel As System.Windows.Forms.Label

End Class
