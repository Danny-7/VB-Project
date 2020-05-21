Imports System.Security.Cryptography.X509Certificates

Public Class Epreuve
    Private nom As String
    Private type As TypeEpv

    Public Enum TypeEpv
        Ecrit
        Oral
        Facultatif
    End Enum

    Public Sub New(nom, type)
        Me.nom = nom
        Me.type = type
    End Sub

    Public Function GetTypeOfEpv() As TypeEpv
        Return Me.type
    End Function


    Public Function GetNom() As String
        Return Me.nom
    End Function
End Class
