''' <summary>
''' Formulaire de l'accueil de l'application d'inscription à un concours 
''' </summary>
Public Class FormAccueil
    ''' <summary>
    ''' Ouvrir le formulaire d'inscription 
    ''' </summary>
    Private Sub BtnEnrg_Click(sender As Object, e As EventArgs) Handles BtnEnrg.Click
        MainModule.ClearForms()
        MainModule.ShowFormCandidat()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Ouvrir le formulaire de modification et de suppression d'une inscription
    ''' </summary>
    Private Sub BtnModifSuppr_Click(sender As Object, e As EventArgs) Handles BtnModifSuppr.Click
        MainModule.ShowModifSuppr()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Ouvrir le formulaire Etat inscriptions pour visualiser l'état des inscriptions
    ''' </summary>
    Private Sub BtnEtatInsc_Click(sender As Object, e As EventArgs) Handles BtnEtatInsc.Click
        MainModule.ShowEtatInsc()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Ouvrir le formulaire du bilan provisoire
    ''' </summary>
    Private Sub BtnBilan_Click(sender As Object, e As EventArgs) Handles BtnBilan.Click
        MainModule.ShowBilan()
        MainModule.ModeBilanProvisoire()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Ouvrir le formulaire bilan pour visualiser le bilan des inscriptions
    ''' Clore les inscriptions en créant un listing de tous les candidats inscrits
    ''' </summary>
    Private Sub BtnClore_Click(sender As Object, e As EventArgs) Handles BtnClore.Click
        ModuleFichier.CréerListing()
        ModuleFichier.SupprListingVide()
        MainModule.ShowBilan()
        MainModule.ModeBilanFinal()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Sauvegarder les inscriptions
    ''' Fermer l'application sans clore les inscriptions
    ''' </summary>
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        ModuleFichier.SauvegarderInscrits()
        Me.Close()
    End Sub
End Class