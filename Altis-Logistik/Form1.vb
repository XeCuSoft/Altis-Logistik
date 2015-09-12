'Imports Microsoft.Win32
Imports System.Net
Imports System.IO
'Imports System.Net.Dns
'Imports System.Threading
'Imports System.Diagnostics.Process
'Imports System.Windows
Imports System.Text.RegularExpressions
Public Class Form1
    Public AktuellesItem As Integer
    Dim temp() As String
    Dim Items As New List(Of Item)
    Private TargetDT As Date

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        settings()
        dateiversion()
        fzgliste()
        rohstoffliste()
        lizenz()

        TabControl1.TabPages.Remove(DebugTab)
    End Sub

    '' Einstellungen
    Private Sub settings()
        If fzglistonline.Checked = True Then
            fzglistonline_download()
        End If

        If My.Settings.autoupdate = True Then
            autoupdate.Checked = True
            updateapp()
        Else
            autoupdate.Checked = False
            updatedownloadbutton.Visible = True
        End If

        If My.Settings.boersetimerauto = True Then
            boersetimerauto.Checked = True
            boersetimer.Text = My.Settings("boersetimer")
            Me.TargetDT = Date.Now.AddMinutes(boersetimer.Text)
            Timer1.Start()
        Else
            boersetimerauto.Checked = False
            timerstatus.Text = "deaktiviert"
        End If

        txtboxfzglist.Text = My.Settings.fzglist
        txtboxlizenzlist.Text = My.Settings.lizenzlist
        txtboxrohstofflist.Text = My.Settings.rohstofflist

        fzglistonline.Checked = My.Settings.fzglistonline
        rohstofflistonline.Checked = My.Settings.rohstofflistonline
        lizenzlistonline.Checked = My.Settings.lizenzlistonline

        If fzglistonline.Checked = True Then
            fzglistonline_download()
        End If

        If rohstofflistonline.Checked = True Then
            rohstofflistonline_download()
        End If

        If lizenzlistonline.Checked = True Then
            lizenzlistonline_download()
        End If

        If Not IO.File.Exists(txtboxfzglist.Text) Then
            fzglistonline_download()
        End If

        If Not IO.File.Exists(txtboxlizenzlist.Text) Then
            lizenzlistonline_download()
        End If

        If Not IO.File.Exists(txtboxrohstofflist.Text) Then
            rohstofflistonline_download()
        End If
    End Sub

    '' Einstellungen Speichern
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If boersetimerauto.Checked = True Then
            My.Settings("boersetimerauto") = True
            My.Settings("boersetimer") = boersetimer.Text
            Me.TargetDT = Date.Now.AddMinutes(boersetimer.Text)
            Me.TargetDT = Date.Now.AddMinutes(boersetimer.Text)
            Timer1.Start()
        Else
            My.Settings("boersetimerauto") = False
            Timer1.Stop()
            timerstatus.Text = "deaktiviert"
        End If

        If autoupdate.Checked = True Then
            My.Settings("autoupdate") = True
            updatedownloadbutton.Visible = False
        Else
            My.Settings("autoupdate") = False
        End If

        My.Settings.fzglistonline = fzglistonline.Checked
        My.Settings.rohstofflistonline = rohstofflistonline.Checked
        My.Settings.lizenzlistonline = lizenzlistonline.Checked
        My.Settings.Save()
    End Sub

    '' Ladet die Fahrzeuge.txt über Github runter
    Private Sub fzglistonline_download()
        If Not IO.Directory.Exists(txtboxfzglist.Text) Then
            Try
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\config")
            Catch ex As Exception
            End Try
        End If

        Try
            File.Delete(txtboxfzglist.Text)
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/XeCuSoft/Altis-Logistik/master/config/fahrzeuge.txt", txtboxfzglist.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Fahrzeugliste - Error")
        End Try
    End Sub

    '' Ladet die Lizenzen.txt über Github runter
    Private Sub lizenzlistonline_download()
        Try
            File.Delete(txtboxlizenzlist.Text)
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/XeCuSoft/Altis-Logistik/master/config/lizenzen.txt", txtboxlizenzlist.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Lizenzliste - Error")
        End Try
    End Sub

    '' Ladet die Rohstoffe.txt über Github runter
    Private Sub rohstofflistonline_download()
        Try
            File.Delete(txtboxrohstofflist.Text)
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/XeCuSoft/Altis-Logistik/master/config/rohstoffe.txt", txtboxrohstofflist.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Rohstoffliste - Error")
        End Try
    End Sub

    '' Setzt denn Timer der die Warenpreise aktuallisiert
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TargetDT < Date.Now Then
            Me.Timer1.Stop()
            boersepreise.Items.Clear()
            boerse()
            Me.TargetDT = Date.Now.AddMinutes(boersetimer.Text)
            Me.Timer1.Start()
        Else
            Dim remainingTime As TimeSpan = Me.TargetDT.Subtract(Date.Now)
            Me.timerstatus.Text = String.Format("{0}:{1:d2}:{2:d2} min.",
                                                remainingTime.Hours,
                                                remainingTime.Minutes,
                                                remainingTime.Seconds)
        End If
    End Sub

    '' Gibt die Anwendungsname und Dateiversion im Titel aus
    Private Sub dateiversion()
        Try
            Me.Text = "Altis-Logistik | Altis Life - Logistik Manager | v" & System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Catch ex As Exception
            Me.Text = "Altis-Logistik | Altis Life - Logistik Manager | v" & Application.ProductVersion.ToString
        End Try
    End Sub

    '' Liest die Warenpreise online aus
    Private Sub boerse()
        Dim httpRequest As HttpWebRequest = HttpWebRequest.Create("http://www.e-monkeys.com/forum/scripts/markt/test.php")
        Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
        Dim reader As StreamReader = New StreamReader(httpResponse.GetResponseStream)
        Dim httpContent As String = reader.ReadToEnd
        txtSourcecode.Text = httpContent

        Dim rx As New Regex("\/(?<String>(.*?))\/(\s)</br>", RegexOptions.Compiled Or RegexOptions.IgnoreCase)
        Dim rxMatches As MatchCollection = rx.Matches(txtSourcecode.Text)

        For Each oMatch As Match In rxMatches
            boersepreise.Items.Add(oMatch.Groups("String").ToString())
            lblboerseInfo.Text = oMatch.ToString
        Next
    End Sub

    '' Erstellt die Fahrzeug Übersicht
    Private Sub fzgliste()
        Dim fzge As String() = System.IO.File.ReadAllLines(txtboxfzglist.Text)

        Dim UsedSpace As Long = 0
        'Spalten
        With Me.fzglist.Columns
            .Add("Fahrzeuge", 200, HorizontalAlignment.Left)
            .Add("Inv. Slots", 80, HorizontalAlignment.Left)
            .Add("Preis", 100, HorizontalAlignment.Left)
        End With
        'Gruppen
        Dim Group1 As ListViewGroup = New ListViewGroup("PKW", HorizontalAlignment.Left)
        Dim Group2 As ListViewGroup = New ListViewGroup("LKW", HorizontalAlignment.Left)
        Dim Group3 As ListViewGroup = New ListViewGroup("Tanker", HorizontalAlignment.Left)
        Dim Group4 As ListViewGroup = New ListViewGroup("Helikopter", HorizontalAlignment.Left)

        For i As Integer = 0 To fzge.Length - 1
            temp = Split(fzge(i), ":")
            Items.Add(New Item(temp(0), temp(1), temp(2), temp(3), temp(4), temp(5)))
            fzgcombobox.Items.Add(temp(2))

            With Me.fzglist.Groups
                .Add(Group1)
                .Add(Group2)
                .Add(Group3)
                .Add(Group4)

                Dim fzge1 As ListViewItem = New ListViewItem(New String() {temp(2), temp(3), temp(4) + " €"})

                Select Case temp(1).ToString
                    Case "pkw"
                        fzge1.Group = Group1
                        fzglist.Items.Add(fzge1)
                    Case "lkw"
                        fzge1.Group = Group2
                        fzglist.Items.Add(fzge1)
                    Case "tanker"
                        fzge1.Group = Group3
                        fzglist.Items.Add(fzge1)
                    Case "heli"
                        fzge1.Group = Group4
                        fzglist.Items.Add(fzge1)
                End Select
            End With
        Next

    End Sub

    '' Erstellt die Rohstoff Übersicht
    Private Sub rohstoffliste()
        Dim rohstofflist As String() = System.IO.File.ReadAllLines(txtboxrohstofflist.Text, System.Text.Encoding.UTF8)
        Dim UsedSpace As Long = 0
        'Spalten
        With Me.rohstoff.Columns
            .Add("Rohstoff", 140, HorizontalAlignment.Left)
            .Add("Verarbeitet", 100, HorizontalAlignment.Left)
            .Add("Roh Gewicht", 100, HorizontalAlignment.Left)
            .Add("Verarbeitet Gewicht", 120, HorizontalAlignment.Left)
        End With
        'Gruppen
        Dim Group1 As ListViewGroup = New ListViewGroup("Legal", HorizontalAlignment.Left)
        Dim Group2 As ListViewGroup = New ListViewGroup("Illegal", HorizontalAlignment.Left)

        For i As Integer = 0 To rohstofflist.Length - 1
            temp = Split(rohstofflist(i), ":")
            itemge.Items.Add(temp(4))

            With Me.rohstoff.Groups
                .Add(Group1)
                .Add(Group2)

                Dim rohstofflist1 As ListViewItem = New ListViewItem(New String() {temp(2), temp(3), temp(4), temp(5)})

                Select Case temp(1).ToString
                    Case "legal"
                        rohstofflist1.Group = Group1
                        rohstoff.Items.Add(rohstofflist1)
                    Case "illegal"
                        rohstofflist1.Group = Group2
                        rohstoff.Items.Add(rohstofflist1)
                End Select
            End With
        Next
    End Sub

    '' Erstellt die Lizenz Übersicht
    Private Sub lizenz()
        Dim lizenzlist As String() = System.IO.File.ReadAllLines(txtboxlizenzlist.Text, System.Text.Encoding.UTF8)
        Dim UsedSpace As Long = 0
        'Spalten
        With Me.lizenzen.Columns
            .Add("Lizenz", 100, HorizontalAlignment.Left)
            .Add("Preis", 100, HorizontalAlignment.Left)
        End With
        'Gruppen
        Dim Group1 As ListViewGroup = New ListViewGroup("Allgemein", HorizontalAlignment.Left)
        Dim Group2 As ListViewGroup = New ListViewGroup("Verarbeitung", HorizontalAlignment.Left)

        For i As Integer = 0 To lizenzlist.Length - 1
            temp = Split(lizenzlist(i), ":")

            With Me.lizenzen.Groups
                .Add(Group1)
                .Add(Group2)

                Dim lizenzlist1 As ListViewItem = New ListViewItem(New String() {temp(2), temp(3) + " €"})

                Select Case temp(1).ToString
                    Case "allgemein"
                        lizenzlist1.Group = Group1
                        lizenzen.Items.Add(lizenzlist1)
                    Case "verarbeitung"
                        lizenzlist1.Group = Group2
                        lizenzen.Items.Add(lizenzlist1)
                End Select
            End With
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fzgcombobox.SelectedIndexChanged
        Aktualisieren()
    End Sub

    Private Sub LadeItems()
        For Each it As Item In Items
            If (it.Name = fzgcombobox.Text) Then
                fzgname.Text = it.Name
                fzgslot.Text = it.Wert1
                AktuellesItem = it.ID
            End If
        Next
    End Sub

    '' Berechnet die Warenpreise
    Private Sub Aktualisieren()
        boersepreise.Items.Clear()
        boerse()

        If boersepreise.Items.Count >= 0 Then
            Label3.Visible = True
            Label3.Text = "Börsepreise werden geladen bitte warten..."

            LadeItems()
            Dim eisen As String = boersepreise.Items.Item(0).ToString()
            Dim silber As String = boersepreise.Items.Item(1).ToString()
            Dim kupfer As String = boersepreise.Items.Item(2).ToString()
            Dim glas As String = boersepreise.Items.Item(3).ToString()
            Dim whiskey As String = boersepreise.Items.Item(4).ToString()
            Dim diamanten As String = boersepreise.Items.Item(5).ToString()
            Dim zement As String = boersepreise.Items.Item(6).ToString()
            Dim oel As String = boersepreise.Items.Item(7).ToString()
            Dim salz As String = boersepreise.Items.Item(8).ToString()
            Dim bier As String = boersepreise.Items.Item(9).ToString()
            Dim kokain As String = boersepreise.Items.Item(10).ToString()
            Dim heroin As String = boersepreise.Items.Item(11).ToString()
            Dim marijuana As String = boersepreise.Items.Item(12).ToString()
            Dim absinth As String = boersepreise.Items.Item(13).ToString()
            Dim edelholz As String = boersepreise.Items.Item(14).ToString()
            Dim bretter As String = boersepreise.Items.Item(15).ToString()
            Dim faser As String = boersepreise.Items.Item(16).ToString()
            Dim stoff As String = boersepreise.Items.Item(17).ToString()
            Dim flush As String = boersepreise.Items.Item(18).ToString()
            Dim aspirin As String = boersepreise.Items.Item(19).ToString()
            Dim viagra As String = boersepreise.Items.Item(20).ToString()

            Dim eisenge As String = itemge.Items.Item(0).ToString()
            Dim silberge As String = itemge.Items.Item(1).ToString()
            Dim kupferge As String = itemge.Items.Item(2).ToString()
            Dim glasge As String = itemge.Items.Item(3).ToString()
            Dim whiskeyge As String = itemge.Items.Item(4).ToString()
            Dim diamantenge As String = itemge.Items.Item(5).ToString()
            Dim zementge As String = itemge.Items.Item(6).ToString()
            Dim oelge As String = itemge.Items.Item(7).ToString()
            Dim salzge As String = itemge.Items.Item(8).ToString()
            Dim bierge As String = itemge.Items.Item(9).ToString()
            Dim kokainge As String = itemge.Items.Item(10).ToString()
            Dim heroinge As String = itemge.Items.Item(11).ToString()
            Dim marijuanage As String = itemge.Items.Item(12).ToString()
            Dim absinthge As String = itemge.Items.Item(13).ToString()
            Dim edelholzge As String = itemge.Items.Item(14).ToString()
            Dim bretterge As String = itemge.Items.Item(15).ToString
            Dim faserge As String = itemge.Items.Item(16).ToString
            Dim stoffge As String = itemge.Items.Item(17).ToString
            Dim flushge As String = itemge.Items.Item(18).ToString
            Dim aspiringe As String = itemge.Items.Item(19).ToString
            Dim viagrage As String = itemge.Items.Item(20).ToString

            erloeslist.Items.Clear()
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(eisenge) * Val(eisen) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(silberge) * Val(silber) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(kupferge) * Val(kupfer) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(glasge) * Val(glas) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(whiskeyge) * Val(whiskey) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(diamantenge) * Val(diamanten) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(zementge) * Val(zement) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(oelge) * Val(oel) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(salzge) * Val(salz) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(bierge) * Val(bier) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(kokainge) * Val(kokain) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(heroinge) * Val(heroin) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(marijuanage) * Val(marijuana) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(absinthge) * Val(absinth) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(edelholzge) * Val(edelholz) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(bretterge) * Val(bretter) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(faserge) * Val(faser) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(stoffge) * Val(stoff) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(flushge) * Val(flush) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(aspiringe) * Val(aspirin) & " €")
            erloeslist.Items.Add(Val(fzgslot.Text + Val(BackPackTextBox.Text)) / Val(viagrage) * Val(viagra) & " €")
            Label3.Visible = False
        Else
            Label3.Visible = True
            Label3.Text = "Börsepreise konnten nicht gefunden werden."
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Process.Start("https://github.com/XeCuSoft/Altis-Logistik")
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Process.Start("https://github.com/XeCuSoft/Altis-Logistik/issues")
    End Sub

    Private Sub BearbeitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BearbeitenToolStripMenuItem.Click
        Editor.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Editor2.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Editor3.Show()
    End Sub

    '' Button zum manuellen laden der Warenpreise
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Visible = True
        boersepreise.Items.Clear()
        boerse()

        If boersepreise.Items.Count = 0 Then
            Label3.Text = "Börsepreise konnten nicht gefunden werden."
        Else
            Label3.Visible = False
        End If
    End Sub

    '' Button zum aktuallisieren der Warenpreisberechnung wenn die Rucksack größe geändert wurde
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles backpackrefresh.Click
        Aktualisieren()
    End Sub

    '' Überprüft ob eine neue Version verfügbar ist und leiter auf Github weiter
    Private Sub updateapp()
        Try
            File.Delete("update.txt")
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/XeCuSoft/Altis-Logistik/master/update.txt", "update.txt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Updater - Fehler")
        End Try

        If File.Exists("update.txt") Then
            Dim sr As StreamReader = New StreamReader("update.txt")

            Select Case sr.ReadLine().ToString()
                Case My.Application.Info.Version.ToString()
                    updatestatus.Visible = True
                    updatestatus.Text = "Ihre Version ist auf denn aktuellen Stand!"
                'MsgBox("Ihre Version ist auf denn aktuellsten Stand!", MsgBoxStyle.Information, "Updater - Version ist aktuell")
                Case Else
                    If MsgBox("Es ist eine neue Version verfügbar!", MsgBoxStyle.Information, "Updater - Neue Version") = MsgBoxResult.Ok Then
                        If MsgBox("Möchten Sie das Update runterladen?" & vbCrLf & "Sie werden auf Github.com weitergeleitet.", MsgBoxStyle.YesNo, "Updater - Github weiterleitung") = MsgBoxResult.Yes Then
                            Process.Start("https://github.com/XeCuSoft/Altis-Logistik/releases")
                        End If
                    End If
            End Select
            sr.Close()
            File.Delete("update.txt")
        Else
            MsgBox("Ressourcen zum überprüfen auf ein Update fehlen!", MsgBoxStyle.Exclamation, "Updater - Fehler")
        End If
    End Sub

    '' Button zum manuellen überprüfen nach Updates
    Private Sub updatedownloadbutton_Click(sender As Object, e As EventArgs) Handles updatedownloadbutton.Click
        updateapp()
    End Sub

    '' Ändert das Verzeichnis der Fahrzeugliste
    Private Sub fzglistbutton_Click(sender As Object, e As EventArgs) Handles fzglistbutton.Click
        Dim DateiBrowser As New OpenFileDialog
        DateiBrowser.Title = "Bitte wähle das Verzeichnis zur Fahrzeugliste"
        If DateiBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtboxfzglist.Text = DateiBrowser.FileName
            My.Settings.fzglist = txtboxfzglist.Text
            My.Settings.Save()
        End If
    End Sub

    '' Ändert das Verzeichnis der Rohstoffliste
    Private Sub rohstoffbutton_Click(sender As Object, e As EventArgs) Handles rohstoffbutton.Click
        Dim DateiBrowser As New OpenFileDialog
        DateiBrowser.Title = "Bitte wähle das Verzeichnis zur Rohstoffliste"
        If DateiBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtboxrohstofflist.Text = DateiBrowser.FileName
            My.Settings.rohstofflist = txtboxrohstofflist.Text
            My.Settings.Save()
        End If
    End Sub

    '' Ändert das Verzeichnis der Lizenzliste
    Private Sub lizenzlistbutton_Click(sender As Object, e As EventArgs) Handles lizenzlistbutton.Click
        Dim DateiBrowser As New OpenFileDialog
        DateiBrowser.Title = "Bitte wähle das Verzeichnis zur Lizenzliste"
        If DateiBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtboxlizenzlist.Text = DateiBrowser.FileName
            My.Settings.lizenzlist = txtboxlizenzlist.Text
            My.Settings.Save()
        End If
    End Sub
End Class

Public Class Item
    Public ID As Integer
    Public Cat As String
    Public Wert1 As String
    Public Wert2 As String
    Public Wert3 As String
    Public Name As String

    Public Sub New(ByVal ID As Integer, ByVal Cat As String, ByVal Name As String, ByVal Wert1 As String, ByVal Wert2 As String, ByVal Wert3 As String)
        Me.ID = ID
        Me.Cat = Cat
        Me.Name = Name
        Me.Wert1 = Wert1
        Me.Wert2 = Wert2
        Me.Wert3 = Wert3
    End Sub
End Class
