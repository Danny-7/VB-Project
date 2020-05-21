Module MainModule

    Private accueil As FormAccueil
    Private candidat As FormCandid
    Private epreuve As FormEpv
    Private recap As FormRecap
    Private modifSuppr As FormModifSuppr
    Private etatInsc As FormEtatInsc
    Private bilan As FormBilan
    Private inscrits As List(Of Candidat) = New List(Of Candidat)

    Private _région As String() = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie",
    "Paris", "Poitou", "Roussillon"}

    Private _écritDictionnaire As New Dictionary(Of String, String)

    Private _oralDictionnaire As New Dictionary(Of String, String)

    Public Property ÉcritDictionnaire As Dictionary(Of String, String)
        Get
            Return _écritDictionnaire
        End Get
        Set(value As Dictionary(Of String, String))
            _écritDictionnaire = value
        End Set
    End Property

    Public Property OralDictionnaire As Dictionary(Of String, String)
        Get
            Return _oralDictionnaire
        End Get
        Set(value As Dictionary(Of String, String))
            _oralDictionnaire = value
        End Set
    End Property

    Public Property Région As String()
        Get
            Return _région
        End Get
        Set(value As String())
            _région = value
        End Set
    End Property

    Private Sub MakeDictionary()
        ÉcritDictionnaire.Add("Algorithme", "ALG")
        ÉcritDictionnaire.Add("Base de données", "BDD")
        ÉcritDictionnaire.Add("Droit", "DRO")
        ÉcritDictionnaire.Add("Expression", "EXP")
        ÉcritDictionnaire.Add("Gestion", "GES")
        ÉcritDictionnaire.Add("Langage C", "LAC")
        ÉcritDictionnaire.Add("Langage Java", "LAJ")
        ÉcritDictionnaire.Add("Mathématiques", "MAT")
        ÉcritDictionnaire.Add("Programmation web", "PRW")
        ÉcritDictionnaire.Add("Réseau", "RES")
        ÉcritDictionnaire.Add("Système", "SYS")
        ÉcritDictionnaire.Add("Visual Basic .NET", "VBN")

        OralDictionnaire.Add("Droit", "DRO")
        OralDictionnaire.Add("Expression", "EXP")
        OralDictionnaire.Add("Gestion", "GES")
        OralDictionnaire.Add("Mathématiques", "MAT")
        OralDictionnaire.Add("Réseau", "RES")
        OralDictionnaire.Add("Système", "SYS")
        OralDictionnaire.Add("Anglais", "ANG")
        OralDictionnaire.Add("Chinois", "CHI")
        OralDictionnaire.Add("Espagnol", "ESP")
    End Sub

    Sub Main()
        accueil = New FormAccueil
        candidat = New FormCandid
        epreuve = New FormEpv
        recap = New FormRecap
        modifSuppr = New FormModifSuppr
        etatInsc = New FormEtatInsc
        bilan = New FormBilan
        MakeDictionary()
        ModuleFichier.ChargementInscrits()
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

    Public Sub ShowEtatInsc()
        etatInsc.Visible = True
    End Sub

    Public Sub ShowBilan()
        bilan.Visible = True
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

    Public Function CréerCandidat() As Candidat
        Return candidat.CréerCandidat()
    End Function

    Public Function CréerCandidat(ByVal id As Integer) As Candidat
        Return candidat.CréerCandidat(id)
    End Function

    ' change le candidat à afficher dans le formulaire récap
    Public Sub SetCandidat(ByRef c As Candidat)
        recap.SetCandidat(c)
    End Sub

    Public Function GetNbInscits() As Integer
        Return inscrits.Count
    End Function

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
        Return Nothing
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

    Public Sub ModeInscription()
        recap.ModeInscription()
    End Sub

    Public Sub ModeSuppr()
        recap.ModeSuppr()
    End Sub

    Public Sub ModeBilanProvisoire()
        recap.ModeBilan()
        bilan.BtnFermer.Enabled = False
        bilan.BtnRetour.Enabled = True
    End Sub

    Public Sub ModeBilanFinal()
        recap.ModeBilan()
        bilan.BtnFermer.Enabled = True
        bilan.BtnRetour.Enabled = False
    End Sub

    Public Sub LoadCandidat(ByRef c As Candidat)
        candidat.LoadCandidat(c)
    End Sub

    Public Sub LoadEpreuves(ByRef c As Candidat)
        epreuve.LoadEpreuves(c)
    End Sub
End Module
