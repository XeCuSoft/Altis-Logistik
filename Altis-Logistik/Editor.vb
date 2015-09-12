Imports System.IO
Public Class Editor
    Inherits System.Windows.Forms.Form
    Public AktuellesItem As Integer
    Dim temp() As String
    Dim Items As New List(Of Item)
    Dim Daten As String() = System.IO.File.ReadAllLines("config/fahrzeuge.txt")
    Public itempath As String = "config/fahrzeuge.txt"

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LadeItems()
        For i As Integer = 0 To Daten.Length - 1
            temp = Split(Daten(i), ":")
            Items.Add(New Item(temp(0), temp(1), temp(2), temp(3), temp(4), temp(5)))
            ComboBox2.Items.Add(temp(2))
        Next
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        LadeItems()
    End Sub

    Private Sub LadeFzglist()
        For i As Integer = 0 To Daten.Length - 1
            temp = Split(Daten(i), ":")
            Items.Add(New Item(temp(0), temp(1), temp(2), temp(3), temp(4), temp(5)))
            ComboBox2.Items.Add(temp(2))
        Next
        ComboBox2.SelectedIndex = 0

        For Each it As Item In Items
            If (it.Name = ComboBox2.Text) Then
                TextBox1.Text = ComboBox2.Text
                TextBox2.Text = it.Wert1
                TextBox3.Text = it.Wert2
                ComboBox1.Text = it.Cat
                AktuellesItem = it.ID
            End If
        Next

    End Sub

    Public Sub SaveItems(ByVal Items As List(Of Item))
        Dim Writer As New StreamWriter(itempath)
        For Each It As Item In Items
            Writer.WriteLine(It.ID & ":" & It.Cat & ":" & It.Name & ":" & It.Wert1 & ":" & It.Wert2 & ":" & "0")
        Next
        Writer.Close()
    End Sub

    Sub Aktualisieren()
        ComboBox2.Items.Clear()
        Items.Clear()
        Dim Daten As String() = System.IO.File.ReadAllLines(itempath)
        For i As Integer = 0 To Daten.Length - 1
            temp = Split(Daten(i), ":")
            Items.Add(New Item(temp(0), temp(1), temp(2), temp(3), temp(4), temp(5)))
            ComboBox2.Items.Add(temp(2))
        Next

    End Sub

    Private Sub LadeItems()
        For Each it As Item In Items
            If (it.Name = ComboBox2.Text) Then
                TextBox1.Text = ComboBox2.Text
                TextBox2.Text = it.Wert1
                TextBox3.Text = it.Wert2
                ComboBox1.Text = it.Cat
                AktuellesItem = it.ID
            End If
        Next

    End Sub

    Sub hinzufügen()
        Items.Add(New Item(Items.Count + 1, ComboBox1.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, "0"))
        SaveItems(Items)
        LadeItems()
        Aktualisieren()
        ComboBox2.SelectedIndex = ComboBox2.Items.Count - 1
    End Sub

    Sub bearbeiten()
        For Each i As Item In Items
            If (i.ID = AktuellesItem) Then
                i.Name = TextBox1.Text
                i.Cat = ComboBox1.Text
                i.Wert1 = TextBox2.Text
                i.Wert2 = TextBox3.Text
                i.Wert3 = "0"
            End If
        Next
        SaveItems(Items)
        LadeItems()
        Aktualisieren()
    End Sub

    Sub löschen()
        Dim lines As System.Collections.Generic.List(Of String) = System.Text.RegularExpressions.Regex.Split(My.Computer.FileSystem.ReadAllText(itempath), vbCrLf).ToList
        lines.RemoveAt(ComboBox2.SelectedIndex)
        My.Computer.FileSystem.WriteAllText(itempath, String.Join(vbCrLf, lines.ToArray), False)

        LadeItems()
        Aktualisieren()
        ComboBox2.SelectedIndex = ComboBox2.Items.Count - 1
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