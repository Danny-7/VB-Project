''' <summary>
''' Classe représentant une épreuve
''' </summary>
Public Class Epreuve
    Private nom As String
    Private type As TypeEpv

    ''' <summary>
    ''' Enumération du type d'épreuve possible
    ''' </summary>
    Public Enum TypeEpv
        Vide
        Ecrit
        Oral
        Facultatif
    End Enum

    ''' <summary>
    ''' Constructeur pour créer une épreuve
    ''' </summary>
    ''' <param name="nom"> Nom de l'épreuve</param>
    ''' <param name="type"> Type de l'épreuve</param>
    Public Sub New(nom, type)
        Me.nom = nom
        Me.type = type
    End Sub

    ''' <summary>
    ''' Retourne le type de l'épreuve
    ''' </summary>
    ''' <returns>Le type de l'épreuve</returns>
    Public Function GetTypeOfEpv() As TypeEpv
        Return Me.type
    End Function

    ''' <summary>
    ''' Retourne le nom de l'épreuve
    ''' </summary>
    ''' <returns>Le nom</returns>
    Public Function GetNom() As String
        Return Me.nom
    End Function

End Class
