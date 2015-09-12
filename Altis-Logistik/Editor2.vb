Imports System.IO
Public Class Editor2
    Public AktuellesItem As Integer
    Dim temp() As String
    Dim Items As New List(Of Item)
    Dim rohstoffliste As String() = System.IO.File.ReadAllLines("config/rohstoffe.txt", System.Text.Encoding.UTF8)
    Public itempath As String = "config/rohstoffe.txt"

    Private Sub Editor2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LadeItems()
        For i As Integer = 0 To rohstoffliste.Length - 1
            temp = Split(rohstoffliste(i), ":")
            Items.Add(New Item(temp(0), temp(1), temp(2), temp(3), temp(4), temp(5)))
            rohstoffitemcombobox.Items.Add(temp(3))
        Next
        rohstoffitemcombobox.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rohstoffitemcombobox.SelectedIndexChanged
        LadeItems()
    End Sub

    Public Sub SaveItems(ByVal Items As List(Of Item))
        Dim Writer As New StreamWriter(itempath)
        For Each It As Item In Items
            Writer.WriteLine(It.ID & ":" & It.Cat & ":" & It.Name & ":" & It.Wert1 & ":" & It.Wert2 & ":" & It.Wert3)
        Next
        Writer.Close()
    End Sub

    Sub Aktualisieren()
        rohstoffitemcombobox.Items.Clear()
        Items.Clear()
        Dim Daten As String() = System.IO.File.ReadAllLines(itempath)
        For i As Integer = 0 To Daten.Length - 1
            temp = Split(Daten(i), ":")
            Items.Add(New Item(temp(0), temp(1), temp(2), temp(3), temp(4), temp(5)))
            rohstoffitemcombobox.Items.Add(temp(3))
        Next

    End Sub

    Private Sub LadeItems()
        For Each it As Item In Items
            If (it.Wert1 = rohstoffitemcombobox.Text) Then
                rohstoffname.Text = it.Name
                rohstoffname2.Text = rohstoffitemcombobox.Text
                rohgewicht.Text = it.Wert2
                vergewicht.Text = it.Wert3
                kategoriecombobox.Text = it.Cat
                AktuellesItem = it.ID
            End If
        Next

    End Sub

    Sub hinzufügen()
        Items.Add(New Item(Items.Count + 1, kategoriecombobox.Text, rohstoffname.Text, rohstoffname2.Text, rohgewicht.Text, vergewicht.Text))
        SaveItems(Items)
        LadeItems()
        Aktualisieren()
        rohstoffitemcombobox.SelectedIndex = rohstoffitemcombobox.Items.Count - 1
    End Sub

    Sub bearbeiten()
        For Each i As Item In Items
            If (i.ID = AktuellesItem) Then
                i.Name = rohstoffname.Text
                i.Cat = kategoriecombobox.Text
                i.Wert1 = rohstoffname2.Text
                i.Wert2 = rohgewicht.Text
                i.Wert3 = vergewicht.Text
            End If
        Next
        SaveItems(Items)
        LadeItems()
        Aktualisieren()
    End Sub

    Sub löschen()
        Dim lines As System.Collections.Generic.List(Of String) = System.Text.RegularExpressions.Regex.Split(My.Computer.FileSystem.ReadAllText(itempath), vbCrLf).ToList
        lines.RemoveAt(rohstoffitemcombobox.SelectedIndex)
        My.Computer.FileSystem.WriteAllText(itempath, String.Join(vbCrLf, lines.ToArray), False)

        LadeItems()
        Aktualisieren()
        rohstoffitemcombobox.SelectedIndex = rohstoffitemcombobox.Items.Count - 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hinzufügen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bearbeiten()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        löschen()
    End Sub
End Class