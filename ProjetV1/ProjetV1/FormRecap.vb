''' <summary>
''' Formulaire récapitulatif des informations d'un candidat
''' </summary>
Public Class FormRecap
    'Le candidat courant du formulaire
    Private candidat As Candidat

    ''' <summary>
    ''' Au changement de visibilité on remplit le formulaire avec les informations du candidat
    ''' </summary>
    Private Sub FormRecap_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            RemplirPanelCandidat(candidat)
            RemplirPanelEpreuves(candidat)
        End If
    End Sub

    ''' <summary>
    ''' Lors de l'appui sur le bouton abandonner, on abandonne l'enregistrement du candidat et on revient à l'accueil
    ''' Ce bouton est visible en mode inscription
    ''' </summary>
    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAbandon.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Lors de l'appui sur le bouton retour, on revient au formulaire de la saisie des informations personnelles du candidat
    ''' Ce bouton est visible en mode inscription
    ''' </summary>
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        MainModule.ShowFormCandidat()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Dans un premier temps on vérifie qu'on était pas en train de faire une modification de l'inscription du candidat
    ''' Si nous sommes dans ce cas alors on supprime le candidat qu'on avait enregistré
    ''' Puis on ajoute le candidat à la liste des inscrits
    ''' Un message apparait pour lui donner son numéro de candidat 
    ''' Ce bouton est visible en mode inscription
    ''' </summary>
    Private Sub BtnEnrg_Click(sender As Object, e As EventArgs) Handles BtnEnrg.Click
        If MainModule.GetCandidat(candidat.GetId) IsNot Nothing Then
            MainModule.DeleteCandidat(candidat.GetId)
        End If
        MainModule.AjouterCandidat(candidat)
        MsgBox("Votre inscription a été effectuée avec succès. Votre identifiant est " & candidat.GetId)
        BtnAbandon.PerformClick()
    End Sub

    ''' <summary>
    ''' Affiche une msmBox demandant la confirmation de suppression
    ''' Supprime le candidat de la liste des inscrits du MainModule si oui
    ''' Affiche l'accueil et ferme le récapitulatif
    ''' Ce bouton est visible en mode suppression
    ''' </summary>
    Private Sub BtnSuppr_Click(sender As Object, e As EventArgs) Handles BtnSuppr.Click
        Dim result As MsgBoxResult = MsgBox("Voulez-vous supprimer définitivement cette candidature ?", vbYesNo)
        If result = MsgBoxResult.Yes Then
            MainModule.DeleteCandidat(Me.candidat.GetId)
        End If
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Affiche l'accueil et ferme le récapitulatif
    ''' Ce bouton est visible en mode bilan
    ''' </summary>
    Private Sub BtnRetourBilan_Click(sender As Object, e As EventArgs) Handles BtnRetourBilan.Click
        MainModule.ShowBilan()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Fait apparaître les boutons utilisés lors d'un récapitulatif d'inscription
    ''' </summary>
    Public Sub ModeInscription()
        BtnRetourBilan.Visible = False
        BtnSuppr.Visible = False
        BtnAbandon.Visible = True
        BtnEnrg.Visible = True
        BtnRetour.Visible = True
    End Sub

    ''' <summary>
    ''' Fait apparaître les boutons utilisés lors d'un récapitulatif pour une suppression
    ''' </summary>
    Public Sub ModeSuppr()
        BtnRetourBilan.Visible = False
        BtnSuppr.Visible = True
        BtnAbandon.Visible = False
        BtnEnrg.Visible = False
        BtnRetour.Visible = False
    End Sub

    ''' <summary>
    ''' Fait apparaître les boutons utilisés lors d'un récapitulatif bilan
    ''' </summary>
    Public Sub ModeBilan()
        BtnRetourBilan.Visible = True
        BtnSuppr.Visible = False
        BtnAbandon.Visible = False
        BtnEnrg.Visible = False
        BtnRetour.Visible = False
    End Sub

    ''' <summary>
    ''' Modifie le candidat du formulaire
    ''' </summary>
    ''' <param name="c">Le candidat en question</param>
    Public Sub SetCandidat(ByRef c As Candidat)
        Me.candidat = c
    End Sub

    ''' <summary>
    ''' Rempli les champs d'un candidat avec les informations personelles de celui-ci 
    ''' </summary>
    ''' <param name="c">Le candidat en question</param>
    Private Sub RemplirPanelCandidat(ByRef c As Candidat)
        LabelNom.Text = c.GetNom()
        LabelPrenom.Text = c.GetPrenom()
        LabelAdr.Text = c.GetAdresse()
        LabelCp.Text = c.GetCP()
        LabelVille.Text = c.GetVille()
        LabelRegion.Text = c.GetRegion()
        LabelAge.Text = c.GetAge()
    End Sub

    ''' <summary>
    ''' Rempli les champs des épreuves avec les épreuves d'un candidat
    ''' </summary>
    ''' <param name="c">Le candidat en question</param>
    Private Sub RemplirPanelEpreuves(ByRef c As Candidat)
        Dim cptEcrit = 0
        Dim cptOral = 0
        LabelEpvFacul.Text = "Aucune"
        For i As Integer = 0 To c.GetSizeOfEpreuve() - 1
            Dim eprv As Epreuve = c.GetEpreuve(i)

            If eprv.GetTypeOfEpv() = Epreuve.TypeEpv.Ecrit Then
                PanelEcrit.Controls(cptEcrit).Text = eprv.GetNom
                cptEcrit += 1
            ElseIf eprv.GetTypeOfEpv() = Epreuve.TypeEpv.Oral Then
                PanelOral.Controls(cptOral).Text = eprv.GetNom
                cptOral += 1
            Else
                LabelEpvFacul.Text = eprv.GetNom()
            End If
        Next
    End Sub
End Class