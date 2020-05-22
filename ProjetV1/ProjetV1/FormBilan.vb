''' <summary>
''' Formulaire du bilan (provisoire ou final) des inscriptions
''' </summary>
Public Class FormBilan
    Private bilanMatière As New FormBilanMatière

    ''' <summary>
    ''' Au chargement du formulaire on ajoute à la comboBox des candidats tous les candidats enregistrés
    ''' De même pour la comboBox des matières à partir des deux dictionnaires permettant d'avoir les initials de chaque matière
    ''' 
    ''' </summary>
    Private Sub FormBilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each pair As KeyValuePair(Of String, String) In ÉcritDictionnaire
            If Not CbMatière.Items.Contains(pair.Key) Then
                'Ajout de la matière à aprtir de la valeur de la pair du dictionnaire
                CbMatière.Items.Add(pair.Key)
            End If
        Next
        For Each pair As KeyValuePair(Of String, String) In OralDictionnaire
            If Not CbMatière.Items.Contains(pair.Key) Then
                CbMatière.Items.Add(pair.Key)
            End If
        Next
        CbMatière.Sorted = True
    End Sub

    ''' <summary>
    ''' Si le bilan est visible, mise à jour du nombre d'inscrit dans un label du formulaire,
    ''' Mise à jour des candidats inscrits
    ''' </summary>
    Private Sub FormBilan_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            LabelNbCandi.Text = MainModule.GetNbInscrits
            CbCandidat.Items.Clear()
            CbCandidat.Text = ""
            CbMatière.Text = ""
            For Each c As Candidat In MainModule.GetListeOfInscrits
                CbCandidat.Items.Add(c.GetNom & " " & c.GetPrenom)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Au clic du bouton "Afficher le bilan de la candidature",
    ''' On récupère le candidat sélectionné
    ''' On affiche la formulaire récapitulatif en mode provisoire ou final selon si le bouton retour est actif ou non
    ''' </summary>
    Private Sub BtnCandidat_Click(sender As Object, e As EventArgs) Handles BtnCandidat.Click
        If CbCandidat.Text <> "" And CbCandidat.Items.Contains(CbCandidat.Text) Then
            Dim candidat() As String = Split(CbCandidat.Text, " ")
            For Each c As Candidat In MainModule.GetListeOfInscrits
                If c.GetNom.Equals(candidat(0)) And c.GetPrenom.Equals(candidat(1)) Then
                    MainModule.SetCandidatFormRecap(MainModule.GetCandidat(c.GetId))
                End If
            Next

            If BtnRetour.Enabled = True Then
                MainModule.ModeBilanProvisoire()
            Else
                MainModule.ModeBilanFinal()
            End If
            MainModule.ShowRecap()
            Me.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Lors de l'appui sur le bouton "Afficher bilan matière"
    ''' Vérification qu'une matière a été séléctionnée
    ''' On modifie le label de la matière du formulaire "bilan matière"
    ''' Puis on affiche le formulaire "bilan matière"
    ''' </summary>
    Private Sub BtnMatiere_Click(sender As Object, e As EventArgs) Handles BtnMatiere.Click
        If CbMatière.Text <> "" And CbMatière.Items.Contains(CbMatière.Text) Then
            bilanMatière.LabelMatière.Text = CbMatière.Text
            bilanMatière.Visible = True
            Me.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Au clic du bouton retour, affichage de l'accueil
    ''' Ce bouton est activé si le bilan est provisoire et désactivé si le bilan est final
    ''' </summary>
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Ce bouton est activé si nous avons choisi de clore les inscriptions depuis l'accueil
    ''' A la clôture des inscriptions on quitte l'application
    ''' </summary>
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Application.Exit()
    End Sub
End Class