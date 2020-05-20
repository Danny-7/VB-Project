Module MainModule

    Private accueil As FormAccueil
    Private candidat As FormCandid
    Private epreuve As FormEpv
    Private recap As FormRecap
    Private modifSuppr As FormModifSuppr
    Private inscrits As List(Of Candidat) = New List(Of Candidat)

    Sub Main()
        accueil = New FormAccueil
        candidat = New FormCandid
        epreuve = New FormEpv
        recap = New FormRecap
        modifSuppr = New FormModifSuppr
        Application.Run(accueil)
    End Sub

    Public Sub ShowCandidat()
        candidat.Visible = True
    End Sub

    Public Sub ShowAccueil()
        accueil.Visible = True
    End Sub

    Public Sub ShowEpreuve()
        epreuve.Visible = True
    End Sub

    Public Sub ShowRecap()
        recap.Visible = True
    End Sub

    Public Sub ShowModifSuppr()
        modifSuppr.Visible = True
    End Sub

    Public Function GetNom() As String
        Return candidat.TbNom.Text
    End Function

    Public Function GetPrenom() As String
        Return candidat.TbPrenom.Text
    End Function

    Public Sub AjouterCandidat(ByRef candidat As Candidat)
        inscrits.Add(candidat)
    End Sub

    Public Function créerCandidat() As Candidat
        Return candidat.créerCandidat()
    End Function

    ' change le candidat à afficher dans le formulaire récap
    Public Sub SetCandidat(ByRef c As Candidat)
        recap.SetCandidat(c)
    End Sub

    Public Function GetNbInscits() As Integer
        Return inscrits.Count
    End Function

    Public Sub AjouterEpreuves(ByRef c As Candidat)
        epreuve.AjouterEpreuves(c)
    End Sub

    Public Function GetListeOfCandidats() As List(Of Candidat)
        Return inscrits
    End Function

    ' retourne un candidat en fonction de son identifiant
    Public Function GetCandidat(ByVal id As Integer) As Candidat
        For Each i In inscrits
            If i.GetCandidat.GetId = id Then
                Return i
            End If
        Next
    End Function

    ' supprime un candidat à partir de son identifiant
    Public Sub DeleteCandidat(ByVal id As Integer)
        Dim c As Candidat = GetCandidat(id)
        If c IsNot Nothing Then
            inscrits.Remove(c)
        End If

    End Sub

    Public Sub ClearForms()
        candidat.ClearForm()
        epreuve.ClearForm()
    End Sub
End Module
