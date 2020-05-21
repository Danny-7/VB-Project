
Imports System.IO
Imports System.Text
Module ModuleFichier
    Private Function GetMatièreDistinct() As List(Of String)
        Dim matières As List(Of String) = New List(Of String)

        For Each pair As KeyValuePair(Of String, String) In ÉcritDictionnaire
            matières.Add(pair.Key)
        Next
        For Each pair As KeyValuePair(Of String, String) In OralDictionnaire
            If Not matières.Contains(pair.Key) Then
                matières.Add(pair.Key)
            End If
        Next
        matières.Sort()
        Return matières
    End Function

    Private Function IsValid(ByVal r As String, ByVal m As String, ByVal c As Candidat) As Epreuve.TypeEpv
        For i As Integer = 0 To c.GetSizeOfEpreuve() - 1
            If c.GetEpreuve(i).GetNom.Equals(m) And c.GetRegion.Equals(r) Then
                Return c.GetEpreuve(i).GetTypeOfEpv()
            End If
        Next
        Return Epreuve.TypeEpv.Vide
    End Function

    Public Sub CréerListing()
        My.Computer.FileSystem.CreateDirectory("listings")

        For Each r As String In MainModule.Région
            For Each m As String In GetMatièreDistinct()
                Dim s As String = "listings\" & m & r & ".txt"
                Dim fs As FileStream = File.Create(s)
                fs.Close()
                For Each c As Candidat In MainModule.GetListeOfCandidats.OrderBy(Function(o) o.GetNom).ThenBy(Function(o) o.GetPrenom).ThenBy(Function(o) o.GetId)
                    Dim type As Epreuve.TypeEpv = IsValid(r, m, c)
                    If type = Epreuve.TypeEpv.Oral Or type = Epreuve.TypeEpv.Facultatif Then
                        Dim cand As String = c.GetNom & " " & c.GetPrenom & " " & c.GetId & " Oral" & vbCrLf
                        My.Computer.FileSystem.WriteAllText(s, cand, True)
                    End If
                    If type = Epreuve.TypeEpv.Ecrit Then
                        Dim cand As String = c.GetNom & " " & c.GetPrenom & " " & c.GetId & " Ecrit" & vbCrLf
                        My.Computer.FileSystem.WriteAllText(s, cand, True)
                    End If
                Next
            Next
        Next
    End Sub

    Public Sub SupprListingVide()
        For Each r As String In MainModule.Région
            For Each m As String In GetMatièreDistinct()
                Dim s As String = "listings\" & m & r & ".txt"
                Dim sr As New StreamReader(s)

                If sr.ReadLine() = "" Then
                    sr.Close()
                    My.Computer.FileSystem.DeleteFile(s)
                End If
            Next
        Next
    End Sub

    Public Sub Sauvegarder()
        Dim cand As New StringBuilder
        Dim s As String = "inscrits.txt"
        Dim fs As FileStream = File.Create(s)
        fs.Close()
        For Each c As Candidat In MainModule.GetListeOfCandidats
            cand.Append(c.GetId & "_" & c.GetNom & "_" & c.GetPrenom & "_" & c.GetAdresse & "_" & c.GetCP & "_" & c.GetVille & "_" & c.GetAge & "_" & c.GetRegion)
            For i As Integer = 0 To c.GetSizeOfEpreuve() - 1
                cand.Append("_" & c.GetEpreuve(i).GetNom())
            Next
            cand.Append(vbCrLf)
            My.Computer.FileSystem.WriteAllText(s, cand.ToString, True)
            cand.Clear()
        Next
    End Sub

    Public Sub ChargementInscrits()
        If File.Exists("inscrits.txt") Then
            Dim f As New StreamReader("inscrits.txt")
            While f.Peek() >= 0
                Dim cand() As String = Split(f.ReadLine(), "_")
                Dim candidat As Candidat = New Candidat(CInt(cand(0)), cand(1), cand(2), cand(3), cand(4), cand(5), CInt(cand(6)), cand(7))

                MainModule.AjouterCandidat(candidat)
                For i As Integer = 8 To cand.Length - 1
                    If i < 12 Then
                        candidat.AjouterEpreuve(cand(i), Epreuve.TypeEpv.Ecrit)
                    ElseIf i < 15 Then
                        candidat.AjouterEpreuve(cand(i), Epreuve.TypeEpv.Oral)
                    ElseIf i = 15 Then
                        candidat.AjouterEpreuve(cand(i), Epreuve.TypeEpv.Facultatif)
                    End If
                Next
            End While
            f.Close()
        End If
    End Sub
End Module
