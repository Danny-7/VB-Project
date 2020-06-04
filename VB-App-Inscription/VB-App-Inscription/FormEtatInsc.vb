''' <summary>
''' Formulaire permettant de visualiser l'état de l'inscription des candidats
''' </summary>
Public Class FormEtatInsc
    ''' <summary>
    ''' Au chargement du formulaire la liste des épreuves écrites et orales est triée
    ''' </summary>
    Private Sub FormEtatInsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbOral.Sorted = True
        LbEcrit.Sorted = True
        LbCandidat.Sorted = False
    End Sub

    ''' <summary>
    ''' Au changement de visibilité dans le cas où le fomrulaire est visible
    ''' On remplit la liste des candidats par ordre alphabétique en focntion du nom et prénom
    ''' </summary>

    Private Sub FormEtatInsc_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            LbCandidat.Items.Clear()
            ' On trie la liste par nom et prénom
            For Each c In MainModule.GetListeOfInscrits().OrderBy(Function(o) o.GetNom).ThenBy(Function(o) o.GetPrenom)
                Dim s As String = c.GetId & ": " & c.GetNom & " " & c.GetPrenom
                LbCandidat.Items.Add(s)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Au changement de sélection du candidat, 
    ''' Mise à jour des listBox des épreuves pour contenir les épreuves du candidat sélectionné
    ''' </summary>
    Private Sub LbCandidat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbCandidat.SelectedIndexChanged
        LbEcrit.Items.Clear()
        LbOral.Items.Clear()
        LabelFacultatif.Text = "Aucune"

        Dim c As Candidat = MainModule.GetCandidat(CInt(Split(LbCandidat.Text, ":")(0)))

        ' Mise à jour des listBox
        For i As Integer = 0 To c.GetSizeOfEpreuve - 1
            Dim ep As Epreuve = c.GetEpreuve(i)

            ' Si c'est une épreuve écrite
            If ep.GetTypeOfEpv = Epreuve.TypeEpv.Ecrit Then
                LbEcrit.Items.Add(ÉcritDictionnaire.Item(ep.GetNom))

                ' Si c'est une épreuve orale
            ElseIf ep.GetTypeOfEpv = Epreuve.TypeEpv.Oral Then
                LbOral.Items.Add(OralDictionnaire.Item(ep.GetNom))

                ' Si c'est une épreuve facultative
            Else
                LabelFacultatif.Text = If(ÉcritDictionnaire.ContainsKey(ep.GetNom), ÉcritDictionnaire.Item(ep.GetNom), OralDictionnaire.Item(ep.GetNom))
            End If
        Next
    End Sub

    ''' <summary>
    ''' Au clic du bouton retour, affiche l'accueil
    ''' </summary>
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

End Class