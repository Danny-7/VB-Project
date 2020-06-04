''' <summary>
''' Formulaire de modification et de suppression d'un candidat
''' </summary>
Public Class FormModifSuppr
    Private id As Integer

    ''' <summary>
    ''' On met à jour le formulaire en le vidant de toute donnée
    ''' Au chargement du formulaire on ajoute tous les candidats enregistrés à la comboBox
    ''' </summary>
    Private Sub FormModifSuppr_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ClearForm()

        For Each c As Candidat In GetListeOfInscrits()
            CbNomPrenom.Items.Add(c.GetId & ": " & c.GetNom & " " & c.GetPrenom)
        Next
    End Sub

    ''' <summary>
    ''' Vérifie que l'identifiant entré est bien numérique 
    ''' </summary>
    Private Sub TbId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbId.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    ''' <summary>
    ''' A l'arrêt de la saisie, on récupère l'identifiant entré si le champ n'est pas vide
    ''' </summary>
    Private Sub TbId_LostFocus(sender As Object, e As EventArgs) Handles TbId.LostFocus
        If TbId.Text <> "" Then
            Me.id = TbId.Text
            For Each cb As String In CbNomPrenom.Items
                Dim str() As String = Split(cb, ":")
                If Me.id = CInt(str(0)) Then
                    CbNomPrenom.SelectedItem = cb
                    Exit Sub
                End If
            Next
            CbNomPrenom.SelectedItem = Nothing
        End If
    End Sub

    ''' <summary>
    ''' A la sélection d'un candidat, on récupère l'identifiant correspondant
    ''' </summary>
    Private Sub CbNomPrenom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbNomPrenom.SelectedValueChanged
        If CbNomPrenom.Text <> "" Then
            Dim str() As String = Split(CbNomPrenom.Text, ":")
            Me.id = CInt(str(0))
            TbId.Text = Me.id
        End If
    End Sub

    ''' <summary>
    ''' Au clic du bouton modifier, on affiche le formulaire de la saisie des informations personnelles du candidat
    ''' Et les formulaires d'inscription sont remplis avec les informations du candidat si le formulaire est valide
    ''' Sinon les labels deviennent rouge
    ''' </summary>
    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click
        LabelId.ForeColor = Color.Black
        LabelNp.ForeColor = Color.Black
        If CheckForm() Then
            Dim c As Candidat = MainModule.GetCandidat(id)
            MainModule.LoadCandidat(c)
            MainModule.LoadEpreuves(c)
            MainModule.ShowFormCandidat()
            Me.Visible = False
        Else
            LabelId.ForeColor = Color.Red
            LabelNp.ForeColor = Color.Red
        End If

    End Sub

    ''' <summary>
    ''' Au clic du bouton supprimer, on affiche le formulaire récapitulatif en mode suppression
    ''' Et il est rempli avec les informations du candidat si le formulaire est valide
    ''' Sinon les labels deviennent rouge
    ''' </summary>
    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        LabelId.ForeColor = Color.Black
        LabelNp.ForeColor = Color.Black
        If CheckForm() Then
            MainModule.SetCandidatFormRecap(MainModule.GetCandidat(id))
            MainModule.ModeSuppr()
            MainModule.ShowRecap()
            Me.Visible = False
        Else
            LabelId.ForeColor = Color.Red
            LabelNp.ForeColor = Color.Red
        End If
    End Sub

    ''' <summary>
    ''' Au clic du bouton abandonner, on affiche l'accueil
    ''' </summary>
    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAbandon.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Réinitialise le formulaire
    ''' </summary>
    Private Sub ClearForm()
        CbNomPrenom.Items.Clear()
        TbId.Text = ""
        CbNomPrenom.Text = ""
        LabelId.ForeColor = Color.Black
        LabelNp.ForeColor = Color.Black
    End Sub

    ''' <summary>
    ''' Vérifie que le formulaire est rempli correctement
    ''' Indique les champs incorrects en rouge
    ''' </summary>
    ''' <returns>Un boolean qui indique la validité du formulaire</returns>
    Private Function CheckForm() As Boolean
        Return If(TbId.Text <> "", MainModule.GetCandidat(Me.id) IsNot Nothing, CbNomPrenom.Text <> "")
    End Function
End Class