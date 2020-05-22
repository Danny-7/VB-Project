''' <summary>
''' Classe représentant un candidat
''' </summary>
Public Class Candidat

    Private id As Integer
    Private nom As String
    Private prenom As String
    Private adresse As String
    Private codePostal As String
    Private ville As String
    Private age As Integer
    Private region As String
    Private epreuves As List(Of Epreuve)

    Private Shared cpt As Integer = 1

    ''' <summary>
    ''' Constructeur de la classe Candidat
    ''' L'identifiant est créé par un compteur statique
    ''' </summary>
    ''' <param name="nom">Nom du candidat</param>
    ''' <param name="prenom">Prénom du candidat</param>
    ''' <param name="adresse">Adresse du candidat</param>
    ''' <param name="cp">Code postal du candidat</param>
    ''' <param name="ville">Ville du candidat</param>
    ''' <param name="age">Age du candidat</param>
    Public Sub New(nom, prenom, adresse, cp, ville, age)
        id = cpt
        cpt += 1
        Me.nom = nom
        Me.prenom = prenom
        Me.adresse = adresse
        Me.codePostal = cp
        Me.ville = ville
        Me.age = age
        Me.epreuves = New List(Of Epreuve)
    End Sub

    ''' <summary>
    ''' Constructeur de la classe Candidat
    ''' L'identifiant est passé en paramètre
    ''' </summary>
    Public Sub New(id, nom, prenom, adresse, cp, ville, age)
        Me.New(nom, prenom, adresse, cp, ville, age)
        Me.id = id
        cpt -= 1
    End Sub

    ''' <summary>
    ''' Constructeur de la classe Candidat
    ''' L'identifiant et la région sont passés en paramètre
    ''' </summary>
    Public Sub New(id, nom, prenom, adresse, cp, ville, age, region)
        Me.New(id, nom, prenom, adresse, cp, ville, age)
        Me.region = region
        cpt = Me.id + 1
    End Sub

    ''' <summary>
    ''' Retourne l'identifiant du candidat
    ''' </summary>
    ''' <returns>L'identifiant du candidat</returns>
    Public Function GetId() As Integer
        Return Me.id
    End Function

    ''' <summary>
    ''' Retourne le nom du candidat
    ''' </summary>
    ''' <returns>Le nom du candidat</returns>
    Public Function GetNom() As String
        Return Me.nom
    End Function

    ''' <summary>
    ''' Retourne le prénom du candidat
    ''' </summary>
    ''' <returns>Le prénom du candidat</returns>
    Public Function GetPrenom() As String
        Return Me.prenom
    End Function

    ''' <summary>
    ''' Retourne l'adresse du candidat
    ''' </summary>
    ''' <returns>L'adresse du candidat</returns>
    Public Function GetAdresse() As String
        Return Me.adresse
    End Function

    ''' <summary>
    ''' Retourne le code postal du candidat
    ''' </summary>
    ''' <returns>Le code postal du candidat</returns>
    Public Function GetCP() As String
        Return Me.codePostal
    End Function

    ''' <summary>
    ''' Retourne la ville du candidat
    ''' </summary>
    ''' <returns>La ville du candidat</returns>
    Public Function GetVille() As String
        Return Me.ville
    End Function

    ''' <summary>
    ''' Retourne l'age du candidat
    ''' </summary>
    ''' <returns>L'age du candidat</returns>
    Public Function GetAge() As String
        Return Me.age
    End Function

    ''' <summary>
    ''' Retourne la région du candidat
    ''' </summary>
    ''' <returns>La région du candidat</returns>
    Public Function GetRegion() As String
        Return Me.region
    End Function

    ''' <summary>
    ''' Retourne une epreuve présente dans la liste des épreuves
    ''' </summary>
    ''' <param name="i">L'indice au quel l'épreuve se trouve dans la liste</param>
    ''' <returns>L'épreuve à l'indice i</returns>
    Public Function GetEpreuve(i As Integer) As Epreuve
        Return Me.epreuves(i)
    End Function

    ''' <summary>
    ''' Retourne le nombre d'épreuves du candidat
    ''' </summary>
    ''' <returns>Le nombre d'épreuves</returns>
    Public Function GetSizeOfEpreuve() As Integer
        Return Me.epreuves.Count
    End Function

    ''' <summary>
    ''' Permet de modifier la région du candidat
    ''' </summary>
    ''' <param name="region">La région du candidat</param>
    Public Sub SetRegion(region As String)
        Me.region = region
    End Sub

    ''' <summary>
    ''' Ajoute une epreuve choisie par le candidat
    ''' </summary>
    ''' <param name="nom"> Nom de l'épreuve à ajouter</param>
    ''' <param name="type"> Type de l'épreuve à ajouter</param>
    Public Sub AjouterEpreuve(ByVal nom As String, ByRef type As Epreuve.TypeEpv)
        Me.epreuves.Add(New Epreuve(nom, type))
    End Sub

    ''' <summary>
    ''' Supprime toutes les épreuves du candidat
    ''' </summary>
    Public Sub ClearEpreuve()
        Me.epreuves.Clear()
    End Sub
End Class
