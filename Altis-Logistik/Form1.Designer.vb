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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.newstab = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.boersetab = New System.Windows.Forms.TabPage()
        Me.backpackrefresh = New System.Windows.Forms.Button()
        Me.BackPackTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fzgname = New System.Windows.Forms.Label()
        Me.fzgslot = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fzgcombobox = New System.Windows.Forms.ComboBox()
        Me.erloeslist = New System.Windows.Forms.ListBox()
        Me.boersepreise = New System.Windows.Forms.ListBox()
        Me.rohstoffelist = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fzglisttab = New System.Windows.Forms.TabPage()
        Me.fzglist = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rohstoffinfotab = New System.Windows.Forms.TabPage()
        Me.rohstoff = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lizenztab = New System.Windows.Forms.TabPage()
        Me.lizenzen = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.settingstab = New System.Windows.Forms.TabPage()
        Me.lizenzlistonline = New System.Windows.Forms.CheckBox()
        Me.rohstofflistonline = New System.Windows.Forms.CheckBox()
        Me.fzglistonline = New System.Windows.Forms.CheckBox()
        Me.lizenzlistbutton = New System.Windows.Forms.Button()
        Me.rohstoffbutton = New System.Windows.Forms.Button()
        Me.fzglistbutton = New System.Windows.Forms.Button()
        Me.txtboxlizenzlist = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtboxrohstofflist = New System.Windows.Forms.TextBox()
        Me.txtboxfzglist = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.updatestatus = New System.Windows.Forms.Label()
        Me.updatedownloadbutton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.autoupdate = New System.Windows.Forms.CheckBox()
        Me.boersetimerauto = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.boersetimer = New System.Windows.Forms.TextBox()
        Me.DebugTab = New System.Windows.Forms.TabPage()
        Me.itemge = New System.Windows.Forms.ListBox()
        Me.lblboerseInfo = New System.Windows.Forms.RichTextBox()
        Me.lstPeoples = New System.Windows.Forms.ListBox()
        Me.txtSourcecode = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.newstab.SuspendLayout()
        Me.boersetab.SuspendLayout()
        Me.fzglisttab.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.rohstoffinfotab.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.lizenztab.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.settingstab.SuspendLayout()
        Me.DebugTab.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.newstab)
        Me.TabControl1.Controls.Add(Me.boersetab)
        Me.TabControl1.Controls.Add(Me.fzglisttab)
        Me.TabControl1.Controls.Add(Me.rohstoffinfotab)
        Me.TabControl1.Controls.Add(Me.lizenztab)
        Me.TabControl1.Controls.Add(Me.settingstab)
        Me.TabControl1.Controls.Add(Me.DebugTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(522, 350)
        Me.TabControl1.TabIndex = 0
        '
        'newstab
        '
        Me.newstab.Controls.Add(Me.WebBrowser1)
        Me.newstab.Location = New System.Drawing.Point(4, 22)
        Me.newstab.Name = "newstab"
        Me.newstab.Size = New System.Drawing.Size(514, 324)
        Me.newstab.TabIndex = 2
        Me.newstab.Text = "News"
        Me.newstab.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(508, 300)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("https://raw.githubusercontent.com/XeCuSoft/Altis-Logistik/master/changelog.txt", System.UriKind.Absolute)
        '
        'boersetab
        '
        Me.boersetab.Controls.Add(Me.backpackrefresh)
        Me.boersetab.Controls.Add(Me.BackPackTextBox)
        Me.boersetab.Controls.Add(Me.Label3)
        Me.boersetab.Controls.Add(Me.Button1)
        Me.boersetab.Controls.Add(Me.fzgname)
        Me.boersetab.Controls.Add(Me.fzgslot)
        Me.boersetab.Controls.Add(Me.Label8)
        Me.boersetab.Controls.Add(Me.Label7)
        Me.boersetab.Controls.Add(Me.fzgcombobox)
        Me.boersetab.Controls.Add(Me.erloeslist)
        Me.boersetab.Controls.Add(Me.boersepreise)
        Me.boersetab.Controls.Add(Me.rohstoffelist)
        Me.boersetab.Controls.Add(Me.Label6)
        Me.boersetab.Controls.Add(Me.Label5)
        Me.boersetab.Controls.Add(Me.Label4)
        Me.boersetab.Controls.Add(Me.Label2)
        Me.boersetab.Controls.Add(Me.Label1)
        Me.boersetab.Location = New System.Drawing.Point(4, 22)
        Me.boersetab.Name = "boersetab"
        Me.boersetab.Padding = New System.Windows.Forms.Padding(3)
        Me.boersetab.Size = New System.Drawing.Size(514, 324)
        Me.boersetab.TabIndex = 0
        Me.boersetab.Text = "Warenpreise"
        Me.boersetab.UseVisualStyleBackColor = True
        '
        'backpackrefresh
        '
        Me.backpackrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backpackrefresh.Location = New System.Drawing.Point(322, 83)
        Me.backpackrefresh.Name = "backpackrefresh"
        Me.backpackrefresh.Size = New System.Drawing.Size(78, 23)
        Me.backpackrefresh.TabIndex = 20
        Me.backpackrefresh.Text = "aktuallisieren"
        Me.backpackrefresh.UseVisualStyleBackColor = True
        '
        'BackPackTextBox
        '
        Me.BackPackTextBox.Location = New System.Drawing.Point(262, 85)
        Me.BackPackTextBox.Name = "BackPackTextBox"
        Me.BackPackTextBox.Size = New System.Drawing.Size(54, 20)
        Me.BackPackTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Börsepreise werden geladen bitte warten..."
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(386, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Börsepreise laden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fzgname
        '
        Me.fzgname.AutoSize = True
        Me.fzgname.Location = New System.Drawing.Point(296, 43)
        Me.fzgname.Name = "fzgname"
        Me.fzgname.Size = New System.Drawing.Size(60, 13)
        Me.fzgname.TabIndex = 16
        Me.fzgname.Text = "Unbekannt"
        '
        'fzgslot
        '
        Me.fzgslot.AutoSize = True
        Me.fzgslot.Location = New System.Drawing.Point(296, 56)
        Me.fzgslot.Name = "fzgslot"
        Me.fzgslot.Size = New System.Drawing.Size(13, 13)
        Me.fzgslot.TabIndex = 15
        Me.fzgslot.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Slots :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(266, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fzg :"
        '
        'fzgcombobox
        '
        Me.fzgcombobox.FormattingEnabled = True
        Me.fzgcombobox.Location = New System.Drawing.Point(260, 19)
        Me.fzgcombobox.Name = "fzgcombobox"
        Me.fzgcombobox.Size = New System.Drawing.Size(224, 21)
        Me.fzgcombobox.TabIndex = 11
        '
        'erloeslist
        '
        Me.erloeslist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.erloeslist.FormattingEnabled = True
        Me.erloeslist.Location = New System.Drawing.Point(170, 17)
        Me.erloeslist.Name = "erloeslist"
        Me.erloeslist.Size = New System.Drawing.Size(84, 277)
        Me.erloeslist.TabIndex = 10
        '
        'boersepreise
        '
        Me.boersepreise.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.boersepreise.FormattingEnabled = True
        Me.boersepreise.Location = New System.Drawing.Point(90, 17)
        Me.boersepreise.Name = "boersepreise"
        Me.boersepreise.Size = New System.Drawing.Size(74, 277)
        Me.boersepreise.TabIndex = 8
        '
        'rohstoffelist
        '
        Me.rohstoffelist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rohstoffelist.FormattingEnabled = True
        Me.rohstoffelist.Items.AddRange(New Object() {"Eisen", "Silber", "Kupfer", "Glas", "Whiskey", "Diamanten", "Zement", "Öl", "Salz", "Bier", "Kokain", "Heroin", "Marijuana", "Absinth", "Edelholz", "Holzbretter", "Wollfaser", "Stoff", "Altis Flush", "Aspirin", "Viagra"})
        Me.rohstoffelist.Location = New System.Drawing.Point(6, 17)
        Me.rohstoffelist.Name = "rohstoffelist"
        Me.rohstoffelist.Size = New System.Drawing.Size(78, 277)
        Me.rohstoffelist.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Rucksack"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fahrzeuge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Erlös"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Preise"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rohstoffe"
        '
        'fzglisttab
        '
        Me.fzglisttab.Controls.Add(Me.fzglist)
        Me.fzglisttab.Location = New System.Drawing.Point(4, 22)
        Me.fzglisttab.Name = "fzglisttab"
        Me.fzglisttab.Size = New System.Drawing.Size(514, 324)
        Me.fzglisttab.TabIndex = 3
        Me.fzglisttab.Text = "Fahrzeugliste"
        Me.fzglisttab.UseVisualStyleBackColor = True
        '
        'fzglist
        '
        Me.fzglist.ContextMenuStrip = Me.ContextMenuStrip1
        Me.fzglist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fzglist.Location = New System.Drawing.Point(0, 0)
        Me.fzglist.Name = "fzglist"
        Me.fzglist.Size = New System.Drawing.Size(514, 324)
        Me.fzglist.TabIndex = 2
        Me.fzglist.UseCompatibleStateImageBehavior = False
        Me.fzglist.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BearbeitenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 26)
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'rohstoffinfotab
        '
        Me.rohstoffinfotab.Controls.Add(Me.rohstoff)
        Me.rohstoffinfotab.Location = New System.Drawing.Point(4, 22)
        Me.rohstoffinfotab.Name = "rohstoffinfotab"
        Me.rohstoffinfotab.Size = New System.Drawing.Size(514, 324)
        Me.rohstoffinfotab.TabIndex = 4
        Me.rohstoffinfotab.Text = "Rohstoff-Infos"
        Me.rohstoffinfotab.UseVisualStyleBackColor = True
        '
        'rohstoff
        '
        Me.rohstoff.ContextMenuStrip = Me.ContextMenuStrip2
        Me.rohstoff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rohstoff.Location = New System.Drawing.Point(0, 0)
        Me.rohstoff.Name = "rohstoff"
        Me.rohstoff.Size = New System.Drawing.Size(514, 324)
        Me.rohstoff.TabIndex = 3
        Me.rohstoff.UseCompatibleStateImageBehavior = False
        Me.rohstoff.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(131, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem1.Text = "Bearbeiten"
        '
        'lizenztab
        '
        Me.lizenztab.Controls.Add(Me.lizenzen)
        Me.lizenztab.Location = New System.Drawing.Point(4, 22)
        Me.lizenztab.Name = "lizenztab"
        Me.lizenztab.Size = New System.Drawing.Size(514, 324)
        Me.lizenztab.TabIndex = 6
        Me.lizenztab.Text = "Lizenzen"
        Me.lizenztab.UseVisualStyleBackColor = True
        '
        'lizenzen
        '
        Me.lizenzen.ContextMenuStrip = Me.ContextMenuStrip3
        Me.lizenzen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lizenzen.Location = New System.Drawing.Point(0, 0)
        Me.lizenzen.Name = "lizenzen"
        Me.lizenzen.Size = New System.Drawing.Size(514, 324)
        Me.lizenzen.TabIndex = 4
        Me.lizenzen.UseCompatibleStateImageBehavior = False
        Me.lizenzen.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(131, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem2.Text = "Bearbeiten"
        '
        'settingstab
        '
        Me.settingstab.Controls.Add(Me.lizenzlistonline)
        Me.settingstab.Controls.Add(Me.rohstofflistonline)
        Me.settingstab.Controls.Add(Me.fzglistonline)
        Me.settingstab.Controls.Add(Me.lizenzlistbutton)
        Me.settingstab.Controls.Add(Me.rohstoffbutton)
        Me.settingstab.Controls.Add(Me.fzglistbutton)
        Me.settingstab.Controls.Add(Me.txtboxlizenzlist)
        Me.settingstab.Controls.Add(Me.Label12)
        Me.settingstab.Controls.Add(Me.txtboxrohstofflist)
        Me.settingstab.Controls.Add(Me.txtboxfzglist)
        Me.settingstab.Controls.Add(Me.Label11)
        Me.settingstab.Controls.Add(Me.Label9)
        Me.settingstab.Controls.Add(Me.updatestatus)
        Me.settingstab.Controls.Add(Me.updatedownloadbutton)
        Me.settingstab.Controls.Add(Me.Button2)
        Me.settingstab.Controls.Add(Me.autoupdate)
        Me.settingstab.Controls.Add(Me.boersetimerauto)
        Me.settingstab.Controls.Add(Me.Label10)
        Me.settingstab.Controls.Add(Me.boersetimer)
        Me.settingstab.Location = New System.Drawing.Point(4, 22)
        Me.settingstab.Name = "settingstab"
        Me.settingstab.Size = New System.Drawing.Size(514, 324)
        Me.settingstab.TabIndex = 7
        Me.settingstab.Text = "Einstellungen"
        Me.settingstab.UseVisualStyleBackColor = True
        '
        'lizenzlistonline
        '
        Me.lizenzlistonline.AutoSize = True
        Me.lizenzlistonline.Location = New System.Drawing.Point(442, 174)
        Me.lizenzlistonline.Name = "lizenzlistonline"
        Me.lizenzlistonline.Size = New System.Drawing.Size(74, 17)
        Me.lizenzlistonline.TabIndex = 20
        Me.lizenzlistonline.Text = "Onlineliste"
        Me.lizenzlistonline.UseVisualStyleBackColor = True
        '
        'rohstofflistonline
        '
        Me.rohstofflistonline.AutoSize = True
        Me.rohstofflistonline.Location = New System.Drawing.Point(442, 135)
        Me.rohstofflistonline.Name = "rohstofflistonline"
        Me.rohstofflistonline.Size = New System.Drawing.Size(74, 17)
        Me.rohstofflistonline.TabIndex = 19
        Me.rohstofflistonline.Text = "Onlineliste"
        Me.rohstofflistonline.UseVisualStyleBackColor = True
        '
        'fzglistonline
        '
        Me.fzglistonline.AutoSize = True
        Me.fzglistonline.Location = New System.Drawing.Point(442, 96)
        Me.fzglistonline.Name = "fzglistonline"
        Me.fzglistonline.Size = New System.Drawing.Size(74, 17)
        Me.fzglistonline.TabIndex = 18
        Me.fzglistonline.Text = "Onlineliste"
        Me.fzglistonline.UseVisualStyleBackColor = True
        '
        'lizenzlistbutton
        '
        Me.lizenzlistbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lizenzlistbutton.Location = New System.Drawing.Point(377, 170)
        Me.lizenzlistbutton.Name = "lizenzlistbutton"
        Me.lizenzlistbutton.Size = New System.Drawing.Size(59, 23)
        Me.lizenzlistbutton.TabIndex = 17
        Me.lizenzlistbutton.Text = "ändern"
        Me.lizenzlistbutton.UseVisualStyleBackColor = True
        '
        'rohstoffbutton
        '
        Me.rohstoffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rohstoffbutton.Location = New System.Drawing.Point(377, 131)
        Me.rohstoffbutton.Name = "rohstoffbutton"
        Me.rohstoffbutton.Size = New System.Drawing.Size(59, 23)
        Me.rohstoffbutton.TabIndex = 16
        Me.rohstoffbutton.Text = "ändern"
        Me.rohstoffbutton.UseVisualStyleBackColor = True
        '
        'fzglistbutton
        '
        Me.fzglistbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fzglistbutton.Location = New System.Drawing.Point(377, 92)
        Me.fzglistbutton.Name = "fzglistbutton"
        Me.fzglistbutton.Size = New System.Drawing.Size(59, 23)
        Me.fzglistbutton.TabIndex = 3
        Me.fzglistbutton.Text = "ändern"
        Me.fzglistbutton.UseVisualStyleBackColor = True
        '
        'txtboxlizenzlist
        '
        Me.txtboxlizenzlist.Location = New System.Drawing.Point(8, 172)
        Me.txtboxlizenzlist.Name = "txtboxlizenzlist"
        Me.txtboxlizenzlist.Size = New System.Drawing.Size(363, 20)
        Me.txtboxlizenzlist.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Lizenzliste"
        '
        'txtboxrohstofflist
        '
        Me.txtboxrohstofflist.Location = New System.Drawing.Point(8, 133)
        Me.txtboxrohstofflist.Name = "txtboxrohstofflist"
        Me.txtboxrohstofflist.Size = New System.Drawing.Size(363, 20)
        Me.txtboxrohstofflist.TabIndex = 13
        '
        'txtboxfzglist
        '
        Me.txtboxfzglist.Location = New System.Drawing.Point(8, 94)
        Me.txtboxfzglist.Name = "txtboxfzglist"
        Me.txtboxfzglist.Size = New System.Drawing.Size(363, 20)
        Me.txtboxfzglist.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Rohstoffliste"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Fahrzeugliste"
        '
        'updatestatus
        '
        Me.updatestatus.AutoSize = True
        Me.updatestatus.Location = New System.Drawing.Point(13, 55)
        Me.updatestatus.Name = "updatestatus"
        Me.updatestatus.Size = New System.Drawing.Size(70, 13)
        Me.updatestatus.TabIndex = 9
        Me.updatestatus.Text = "Updatestatus"
        Me.updatestatus.Visible = False
        '
        'updatedownloadbutton
        '
        Me.updatedownloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatedownloadbutton.Location = New System.Drawing.Point(254, 31)
        Me.updatedownloadbutton.Name = "updatedownloadbutton"
        Me.updatedownloadbutton.Size = New System.Drawing.Size(117, 23)
        Me.updatedownloadbutton.TabIndex = 8
        Me.updatedownloadbutton.Text = "nach Update suchen"
        Me.updatedownloadbutton.UseVisualStyleBackColor = True
        Me.updatedownloadbutton.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(431, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Speichern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'autoupdate
        '
        Me.autoupdate.AutoSize = True
        Me.autoupdate.Location = New System.Drawing.Point(8, 35)
        Me.autoupdate.Name = "autoupdate"
        Me.autoupdate.Size = New System.Drawing.Size(240, 17)
        Me.autoupdate.TabIndex = 6
        Me.autoupdate.Text = "Automatisch nach Programmupdates suchen."
        Me.autoupdate.UseVisualStyleBackColor = True
        '
        'boersetimerauto
        '
        Me.boersetimerauto.AutoSize = True
        Me.boersetimerauto.Location = New System.Drawing.Point(8, 12)
        Me.boersetimerauto.Name = "boersetimerauto"
        Me.boersetimerauto.Size = New System.Drawing.Size(164, 17)
        Me.boersetimerauto.TabIndex = 5
        Me.boersetimerauto.Text = "Börsepreise aktuallisieren alle"
        Me.boersetimerauto.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(230, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Minuten"
        '
        'boersetimer
        '
        Me.boersetimer.Location = New System.Drawing.Point(178, 10)
        Me.boersetimer.Name = "boersetimer"
        Me.boersetimer.Size = New System.Drawing.Size(46, 20)
        Me.boersetimer.TabIndex = 1
        Me.boersetimer.Text = "1"
        '
        'DebugTab
        '
        Me.DebugTab.Controls.Add(Me.itemge)
        Me.DebugTab.Controls.Add(Me.lblboerseInfo)
        Me.DebugTab.Controls.Add(Me.lstPeoples)
        Me.DebugTab.Controls.Add(Me.txtSourcecode)
        Me.DebugTab.Location = New System.Drawing.Point(4, 22)
        Me.DebugTab.Name = "DebugTab"
        Me.DebugTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugTab.Size = New System.Drawing.Size(514, 324)
        Me.DebugTab.TabIndex = 1
        Me.DebugTab.Text = "Debug"
        Me.DebugTab.UseVisualStyleBackColor = True
        '
        'itemge
        '
        Me.itemge.FormattingEnabled = True
        Me.itemge.Location = New System.Drawing.Point(6, 162)
        Me.itemge.Name = "itemge"
        Me.itemge.Size = New System.Drawing.Size(250, 121)
        Me.itemge.TabIndex = 9
        '
        'lblboerseInfo
        '
        Me.lblboerseInfo.Location = New System.Drawing.Point(262, 107)
        Me.lblboerseInfo.Name = "lblboerseInfo"
        Me.lblboerseInfo.Size = New System.Drawing.Size(218, 174)
        Me.lblboerseInfo.TabIndex = 8
        Me.lblboerseInfo.Text = ""
        '
        'lstPeoples
        '
        Me.lstPeoples.FormattingEnabled = True
        Me.lstPeoples.Location = New System.Drawing.Point(262, 6)
        Me.lstPeoples.Name = "lstPeoples"
        Me.lstPeoples.Size = New System.Drawing.Size(218, 95)
        Me.lstPeoples.TabIndex = 7
        '
        'txtSourcecode
        '
        Me.txtSourcecode.Location = New System.Drawing.Point(6, 6)
        Me.txtSourcecode.Name = "txtSourcecode"
        Me.txtSourcecode.Size = New System.Drawing.Size(250, 150)
        Me.txtSourcecode.TabIndex = 6
        Me.txtSourcecode.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.timerstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 328)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(522, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabel1.Text = "Github.com"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(113, 17)
        Me.ToolStripStatusLabel3.Text = "Support / Bugreport"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(188, 17)
        Me.ToolStripStatusLabel5.Text = "Börsepreise werden aktuallisiert in "
        '
        'timerstatus
        '
        Me.timerstatus.Name = "timerstatus"
        Me.timerstatus.Size = New System.Drawing.Size(46, 17)
        Me.timerstatus.Text = "15 min."
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(522, 350)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Altis-Logistik | Altis Life - Logistik Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.newstab.ResumeLayout(False)
        Me.boersetab.ResumeLayout(False)
        Me.boersetab.PerformLayout()
        Me.fzglisttab.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.rohstoffinfotab.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.lizenztab.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.settingstab.ResumeLayout(False)
        Me.settingstab.PerformLayout()
        Me.DebugTab.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents boersetab As System.Windows.Forms.TabPage
    Friend WithEvents erloeslist As System.Windows.Forms.ListBox
    Friend WithEvents boersepreise As System.Windows.Forms.ListBox
    Friend WithEvents rohstoffelist As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DebugTab As System.Windows.Forms.TabPage
    Friend WithEvents itemge As System.Windows.Forms.ListBox
    Friend WithEvents lblboerseInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents lstPeoples As System.Windows.Forms.ListBox
    Friend WithEvents txtSourcecode As System.Windows.Forms.RichTextBox
    Friend WithEvents newstab As System.Windows.Forms.TabPage
    Friend WithEvents fzglisttab As System.Windows.Forms.TabPage
    Friend WithEvents fzglist As System.Windows.Forms.ListView
    Friend WithEvents rohstoffinfotab As System.Windows.Forms.TabPage
    Friend WithEvents rohstoff As System.Windows.Forms.ListView
    Friend WithEvents fzgcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fzgname As System.Windows.Forms.Label
    Friend WithEvents fzgslot As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lizenztab As System.Windows.Forms.TabPage
    Friend WithEvents lizenzen As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents settingstab As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents boersetimer As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timerstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents boersetimerauto As System.Windows.Forms.CheckBox
    Friend WithEvents autoupdate As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents BackPackTextBox As TextBox
    Friend WithEvents backpackrefresh As Button
    Friend WithEvents updatedownloadbutton As Button
    Friend WithEvents updatestatus As Label
    Friend WithEvents txtboxlizenzlist As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtboxrohstofflist As TextBox
    Friend WithEvents txtboxfzglist As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fzglistbutton As Button
    Friend WithEvents lizenzlistbutton As Button
    Friend WithEvents rohstoffbutton As Button
    Friend WithEvents lizenzlistonline As CheckBox
    Friend WithEvents rohstofflistonline As CheckBox
    Friend WithEvents fzglistonline As CheckBox
End Class
