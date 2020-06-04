Imports System.IO
Imports System.Text

''' <summary>
''' Module se chargeant des créer et supprimer les fichiers de sauvegarde et les listings
''' </summary>
Module ModuleFichier

    ''' <summary>
    ''' Retourne une liste d'épreuves sans doublons
    ''' </summary>
    ''' <returns>Une liste d'épreuves</returns>
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

        'Trie de la liste qu'on vient de créer
        matières.Sort()
        Return matières
    End Function

    ''' <summary>
    ''' Vérifie que le candidat s'est inscrit pour cette matière dans cette région
    ''' </summary>
    ''' <param name="r">La région</param>
    ''' <param name="m">La matière</param>
    ''' <param name="c">Le candidat</param>
    ''' <returns></returns>
    Private Function IsCandidatOfEpreuveValid(ByVal r As String, ByVal m As String, ByVal c As Candidat) As Epreuve.TypeEpv
        For i As Integer = 0 To c.GetSizeOfEpreuve() - 1
            If c.GetEpreuve(i).GetNom.Equals(m) And c.GetRegion.Equals(r) Then
                Return c.GetEpreuve(i).GetTypeOfEpv()
            End If
        Next
        Return Epreuve.TypeEpv.Vide
    End Function

    ''' <summary>
    ''' Création d'un ensemble de fichiers
    ''' Pour chaque région et chaque épreuve on crée un nouveau fichier avec tous les candidats inscrits(nom, prenom, id) 
    ''' </summary>
    Public Sub CréerListing()
        'Création d'un dossier où l'on va stocker tous les fichiers qui vont être créés
        My.Computer.FileSystem.CreateDirectory("listings")

        For Each r As String In MainModule.Région
            For Each m As String In GetMatièreDistinct()

                'Le titre de chaque fichier est la concaténation de la matière suivie de la région
                Dim titre As String = "listings\" & m & r & ".txt"
                Dim fs As FileStream = File.Create(titre)
                fs.Close()

                'Liste des candidats triée par nom, prenom et identifiant 
                For Each c As Candidat In MainModule.GetListeOfInscrits.OrderBy(Function(o) o.GetNom).ThenBy(Function(o) o.GetPrenom).ThenBy(Function(o) o.GetId)
                    Dim type As Epreuve.TypeEpv = IsCandidatOfEpreuveValid(r, m, c)
                    If type = Epreuve.TypeEpv.Oral Or type = Epreuve.TypeEpv.Facultatif Then

                        'Variable intermédiare permettant de concaténer les informations nécessaires
                        Dim cand As String = c.GetNom & " " & c.GetPrenom & " " & c.GetId & " Oral" & vbCrLf
                        'Ecriture dans le fichier
                        My.Computer.FileSystem.WriteAllText(titre, cand, True)
                    End If
                    If type = Epreuve.TypeEpv.Ecrit Then
                        Dim cand As String = c.GetNom & " " & c.GetPrenom & " " & c.GetId & " Ecrit" & vbCrLf
                        My.Computer.FileSystem.WriteAllText(titre, cand, True)
                    End If
                Next
            Next
        Next
    End Sub

    ''' <summary>
    ''' Suppression des listings vides créés lors de la création
    ''' </summary>
    Public Sub SupprListingVide()
        For Each r As String In MainModule.Région
            For Each m As String In GetMatièreDistinct()
                Dim s As String = "listings\" & m & r & ".txt"
                Dim sr As New StreamReader(s)

                ' Si la première ligne est vide alors le fichier est vide
                If sr.ReadLine() = "" Then
                    sr.Close()
                    My.Computer.FileSystem.DeleteFile(s)
                End If
            Next
        Next
    End Sub

    ''' <summary>
    ''' Sauvegarde des inscriptions en cas de fermeture de l'application sans clôture des inscriptions
    ''' </summary>
    Public Sub SauvegarderInscrits()
        Dim cand As New StringBuilder

        ' Création du fichier de sauvegarde
        Dim s As String = "inscrits.txt"
        Dim fs As FileStream = File.Create(s)
        fs.Close()

        ' Sauvegarde d'un candidat et des ses informations sur une ligne dans le fichier
        For Each c As Candidat In MainModule.GetListeOfInscrits
            cand.Append(c.GetId & "_" & c.GetNom & "_" & c.GetPrenom & "_" & c.GetAdresse & "_" & c.GetCP & "_" & c.GetVille & "_" & c.GetAge & "_" & c.GetRegion)
            For i As Integer = 0 To c.GetSizeOfEpreuve() - 1
                cand.Append("_" & c.GetEpreuve(i).GetNom())
            Next
            cand.Append(vbCrLf)
            My.Computer.FileSystem.WriteAllText(s, cand.ToString, True)
            cand.Clear()
        Next
    End Sub

    ''' <summary>
    ''' S'il n'existe aucun fichier de sauvegarde,
    ''' Chargement des inscrits sauvegardés lors d'une inscriptions précédente non close
    ''' Et supression de la sauvegarde
    ''' </summary>
    Public Sub LoadInscrits()
        If File.Exists("inscrits.txt") Then
            Dim f As New StreamReader("inscrits.txt")
            While f.Peek() >= 0
                Dim cand() As String = Split(f.ReadLine(), "_")
                Dim candidat As Candidat = New Candidat(CInt(cand(0)), cand(1), cand(2), cand(3), cand(4), cand(5), CInt(cand(6)), cand(7))

                ' Ajout des candidats du fichier dans la liste des inscrits du MainModule
                MainModule.AjouterCandidat(candidat)

                ' Ajout des épreuves du candidat
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

            ' Supression de la sauvegarde après chargement
            My.Computer.FileSystem.DeleteFile("inscrits.txt")
        End If
    End Sub
End Module
