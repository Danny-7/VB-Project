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

    Public Sub New(id, nom, prenom, adresse, cp, ville, age)
        Me.New(nom, prenom, adresse, cp, ville, age)
        Me.id = id
        cpt -= 1
    End Sub

    Public Sub New(id, nom, prenom, adresse, cp, ville, age, region)
        Me.New(id, nom, prenom, adresse, cp, ville, age)
        Me.region = region
        cpt = Me.id + 1

    End Sub

    Public Function GetId() As Integer
        Return Me.id
    End Function

    Public Function GetNom() As String
        Return Me.nom
    End Function

    Public Function GetPrenom() As String
        Return Me.prenom
    End Function

    Public Function GetAdresse() As String
        Return Me.adresse
    End Function

    Public Function GetCP() As String
        Return Me.codePostal
    End Function

    Public Function GetVille() As String
        Return Me.ville
    End Function

    Public Function GetAge() As String
        Return Me.age
    End Function

    Public Sub SetRegion(region As String)
        Me.region = region
    End Sub

    Public Function GetRegion() As String
        Return Me.region
    End Function

    Public Function GetCandidat() As Candidat
        Return Me
    End Function

    Public Sub AjouterEpreuve(ByVal nom As String, ByRef type As Epreuve.TypeEpv)
        Me.epreuves.Add(New Epreuve(nom, type))
    End Sub

    Public Sub ClearEpreuve()
        Me.epreuves.Clear()
    End Sub

    Public Function GetEpreuve(i As Integer) As Epreuve
        Return Me.epreuves(i)
    End Function

    Public Function GetSizeOfEpreuve() As Integer
        Return Me.epreuves.Count
    End Function
End Class
