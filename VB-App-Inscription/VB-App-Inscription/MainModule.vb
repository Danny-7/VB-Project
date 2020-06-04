''' <summary>
''' Module principal et point d'entrée de l'application d'inscription
''' Il contient tous les formulaires assurant le fonctionnement de l'application
''' </summary>
Module MainModule

    Private formAccueil As FormAccueil
    Private formCandidat As FormCandid
    Private formEpreuve As FormEpv
    Private formRecap As FormRecap
    Private formModifSuppr As FormModifSuppr
    Private formEtatInsc As FormEtatInsc
    Private formBilan As FormBilan
    Private inscrits As List(Of Candidat) = New List(Of Candidat)

    Private _région As String() = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie",
    "Paris", "Poitou", "Roussillon"}

    Private _oralDictionnaire As New Dictionary(Of String, String)

    Private _écritDictionnaire As New Dictionary(Of String, String)

    ''' <summary>
    ''' Propriété du tableau région
    ''' </summary>
    ''' <returns>Le tableau région</returns>
    Public Property Région As String()
        Get
            Return _région
        End Get
        Set(value As String())
            _région = value
        End Set
    End Property

    ''' <summary>
    ''' Propriété du dictionnaire des épreuves orales
    ''' </summary>
    ''' <returns>Le dictionnaire des épreuves orales</returns>
    Public Property OralDictionnaire As Dictionary(Of String, String)
        Get
            Return _oralDictionnaire
        End Get
        Set(value As Dictionary(Of String, String))
            _oralDictionnaire = value
        End Set
    End Property

    ''' <summary>
    ''' Propriété du dictionnaire des épreuves écrites
    ''' </summary>
    ''' <returns>Le dictionnaire des épreuves écrites</returns>
    Public Property ÉcritDictionnaire As Dictionary(Of String, String)
        Get
            Return _écritDictionnaire
        End Get
        Set(value As Dictionary(Of String, String))
            _écritDictionnaire = value
        End Set
    End Property

    ''' <summary>
    ''' Crée les dictionnaires des épreuves écrites et orales
    ''' </summary>
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

    ''' <summary>
    ''' Affiche le formulaire de l'accueil
    ''' </summary>
    Public Sub ShowAccueil()
        formAccueil.Visible = True
    End Sub

    ''' <summary>
    ''' Affiche le formulaire pour saisir les informations personnelles d'un candidat
    ''' </summary>
    Public Sub ShowFormCandidat()
        formCandidat.Visible = True
    End Sub

    ''' <summary>
    ''' Affiche le formulaire pour choisir les épreuves d'un candidat
    ''' </summary>
    Public Sub ShowEpreuve()
        formEpreuve.Visible = True
    End Sub

    ''' <summary>
    ''' Affiche le formulaire récapitulatif d'une inscription
    ''' </summary>
    Public Sub ShowRecap()
        formRecap.Visible = True
    End Sub

    ''' <summary>
    ''' Affiche le formulaire de modification et de suppression d'un candidat
    ''' </summary>
    Public Sub ShowModifSuppr()
        formModifSuppr.Visible = True
    End Sub

    ''' <summary>
    ''' Affiche le formulaire de montrant l'état des insccriptions
    ''' </summary>
    Public Sub ShowEtatInsc()
        formEtatInsc.Visible = True
    End Sub

    ''' <summary>
    ''' Affiche le formulaire de bilan (provisoire ou final)
    ''' </summary>
    Public Sub ShowBilan()
        formBilan.Visible = True
    End Sub

    ''' <summary>
    ''' Réinitialise les formulaires 
    ''' </summary>
    Public Sub ClearForms()
        formCandidat.ClearForm()
        formEpreuve.ClearForm()
    End Sub

    ''' <summary>
    ''' Met le formulaire récapitulatif en mode inscription
    ''' </summary>
    Public Sub ModeInscription()
        formRecap.ModeInscription()
    End Sub

    ''' <summary>
    ''' Met le formulaire récapitulatif en mode suppression
    ''' </summary>
    Public Sub ModeSuppr()
        formRecap.ModeSuppr()
    End Sub

    ''' <summary>
    ''' Met le formulaire bilan et récapitulatif en mode bilan provisoire
    ''' </summary>
    Public Sub ModeBilanProvisoire()
        formRecap.ModeBilan()
        formBilan.BtnFermer.Enabled = False
        formBilan.BtnRetour.Enabled = True
    End Sub

    ''' <summary>
    ''' Met le formulaire bilan et récapitulatif en mode bilan final
    ''' </summary>
    Public Sub ModeBilanFinal()
        formRecap.ModeBilan()
        formBilan.BtnFermer.Enabled = True
        formBilan.BtnRetour.Enabled = False
    End Sub

    ''' <summary>
    ''' Remplit le formCandidat avec les informations personnelles d'un candidat
    ''' <param name="c">Le candidat en question</param>
    ''' </summary>
    Public Sub LoadCandidat(ByRef c As Candidat)
        formCandidat.LoadCandidat(c)
    End Sub

    ''' <summary>
    ''' Remplit le formEpreuve avec les épreuves d'un candidat
    ''' <param name="c">Le candidat en question</param>
    ''' </summary>
    Public Sub LoadEpreuves(ByRef c As Candidat)
        formEpreuve.LoadEpreuves(c)
    End Sub

    ''' <summary>
    ''' Retourne le nom du candidat saisi dans le formCandidat
    ''' </summary>
    ''' <returns>Le nom du candidat</returns>
    Public Function GetTbNomFormCandidat() As String
        Return formCandidat.TbNom.Text
    End Function

    ''' <summary>
    ''' Retourne le prénom du candidat saisi dans le formCandidat
    ''' </summary>
    ''' <returns>Le prénom du candidat</returns>
    Public Function GetTbPrenomFormCandidat() As String
        Return formCandidat.TbPrenom.Text
    End Function

    ''' <summary>
    ''' Modifie le candidat à afficher dans le formulaire de récapitulatif
    ''' </summary>
    ''' <param name="c">Le candidat en question</param>
    Public Sub SetCandidatFormRecap(ByRef c As Candidat)
        formRecap.SetCandidat(c)
    End Sub

    ''' <summary>
    ''' Permet de créer un candidat à partir des informations de formCandidat
    ''' </summary>
    ''' <returns></returns>
    Public Function CréerCandidat() As Candidat
        Return formCandidat.CréerCandidat()
    End Function

    ''' <summary>
    ''' Permet de créer un candidat à partir d'un identifiant et des informations de formCandidat
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function CréerCandidat(ByVal id As Integer) As Candidat
        Return formCandidat.CréerCandidat(id)
    End Function

    ''' <summary>
    ''' Retourne un candidat en fonction de son identifiant
    ''' </summary>
    ''' <param name="id">Identifiant du candidat</param>
    ''' <returns></returns>
    Public Function GetCandidat(ByVal id As Integer) As Candidat
        For Each i In inscrits
            If i.GetId = id Then
                Return i
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Ajoute un candidat à la liste des inscrits
    ''' </summary>
    ''' <param name="candidat">Le candidat en question</param>
    Public Sub AjouterCandidat(ByRef candidat As Candidat)
        inscrits.Add(candidat)
    End Sub

    ''' <summary>
    ''' Supprime un candidat à partir de son identifiant
    ''' </summary>
    ''' <param name="id"> L'identifiant du candidat</param>
    Public Sub DeleteCandidat(ByVal id As Integer)
        Dim c As Candidat = GetCandidat(id)
        If c IsNot Nothing Then
            inscrits.Remove(c)
        End If
    End Sub

    ''' <summary>
    ''' Retourne le nombre d'inscrits
    ''' </summary>
    ''' <returns>Le nombre d'inscrits</returns>
    Public Function GetNbInscrits() As Integer
        Return inscrits.Count
    End Function

    ''' <summary>
    ''' Retourne la liste des inscrits
    ''' </summary>
    ''' <returns>Retourne une liste de candidat</returns>
    Public Function GetListeOfInscrits() As List(Of Candidat)
        Return inscrits
    End Function

    ''' <summary>
    ''' Point de départ de l'application
    ''' </summary>
    Sub Main()
        formAccueil = New FormAccueil
        formCandidat = New FormCandid
        formEpreuve = New FormEpv
        formRecap = New FormRecap
        formModifSuppr = New FormModifSuppr
        formEtatInsc = New FormEtatInsc
        formBilan = New FormBilan
        MakeDictionary()
        ModuleFichier.LoadInscrits()
        Application.Run(formAccueil)
    End Sub
End Module