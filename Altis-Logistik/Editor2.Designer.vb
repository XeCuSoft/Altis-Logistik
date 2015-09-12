<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor2))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.vergewicht = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rohstoffitemcombobox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rohstoffname = New System.Windows.Forms.TextBox()
        Me.rohgewicht = New System.Windows.Forms.TextBox()
        Me.kategoriecombobox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rohstoffname2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(178, 194)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Löschen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Bearbeiten"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Hinzufügen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.vergewicht)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.rohstoffitemcombobox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.rohstoffname)
        Me.GroupBox2.Controls.Add(Me.rohgewicht)
        Me.GroupBox2.Controls.Add(Me.kategoriecombobox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.rohstoffname2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 176)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rohstoffe"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Ver. Gewicht"
        '
        'vergewicht
        '
        Me.vergewicht.Location = New System.Drawing.Point(102, 145)
        Me.vergewicht.Name = "vergewicht"
        Me.vergewicht.Size = New System.Drawing.Size(132, 20)
        Me.vergewicht.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Rohstoff"
        '
        'rohstoffitemcombobox
        '
        Me.rohstoffitemcombobox.FormattingEnabled = True
        Me.rohstoffitemcombobox.Location = New System.Drawing.Point(63, 13)
        Me.rohstoffitemcombobox.Name = "rohstoffitemcombobox"
        Me.rohstoffitemcombobox.Size = New System.Drawing.Size(171, 21)
        Me.rohstoffitemcombobox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kategorie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Roh. Gewicht"
        '
        'rohstoffname
        '
        Me.rohstoffname.Location = New System.Drawing.Point(63, 67)
        Me.rohstoffname.Name = "rohstoffname"
        Me.rohstoffname.Size = New System.Drawing.Size(171, 20)
        Me.rohstoffname.TabIndex = 0
        '
        'rohgewicht
        '
        Me.rohgewicht.Location = New System.Drawing.Point(102, 119)
        Me.rohgewicht.Name = "rohgewicht"
        Me.rohgewicht.Size = New System.Drawing.Size(132, 20)
        Me.rohgewicht.TabIndex = 6
        '
        'kategoriecombobox
        '
        Me.kategoriecombobox.FormattingEnabled = True
        Me.kategoriecombobox.Items.AddRange(New Object() {"legal", "illegal"})
        Me.kategoriecombobox.Location = New System.Drawing.Point(63, 40)
        Me.kategoriecombobox.Name = "kategoriecombobox"
        Me.kategoriecombobox.Size = New System.Drawing.Size(171, 21)
        Me.kategoriecombobox.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Ver. Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-1, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Roh.Name"
        '
        'rohstoffname2
        '
        Me.rohstoffname2.Location = New System.Drawing.Point(63, 93)
        Me.rohstoffname2.Name = "rohstoffname2"
        Me.rohstoffname2.Size = New System.Drawing.Size(171, 20)
        Me.rohstoffname2.TabIndex = 4
        '
        'Editor2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 227)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Editor2"
        Me.Text = "Rohstoff Editor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents vergewicht As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rohstoffitemcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rohstoffname As System.Windows.Forms.TextBox
    Friend WithEvents rohgewicht As System.Windows.Forms.TextBox
    Friend WithEvents kategoriecombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rohstoffname2 As System.Windows.Forms.TextBox
End Class
