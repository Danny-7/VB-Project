Public Class FormAccueil
    Private Sub BtnEnrg_Click(sender As Object, e As EventArgs) Handles BtnEnrg.Click
        MainModule.ClearForms()
        MainModule.ShowCandidat()
        Me.Visible = False
    End Sub

    Private Sub BtnModifSuppr_Click(sender As Object, e As EventArgs) Handles BtnModifSuppr.Click
        MainModule.ShowModifSuppr()
        Me.Visible = False
    End Sub

    Private Sub BtnEtatInsc_Click(sender As Object, e As EventArgs) Handles BtnEtatInsc.Click
        MainModule.ShowEtatInsc()
        Me.Visible = False
    End Sub

    Private Sub BtnBilan_Click(sender As Object, e As EventArgs) Handles BtnBilan.Click
        MainModule.ShowBilan()
        MainModule.ModeBilanProvisoire()
        Me.Visible = False
    End Sub

    Private Sub BtnClore_Click(sender As Object, e As EventArgs) Handles BtnClore.Click
        ModuleFichier.CréerListing()
        ModuleFichier.SupprListingVide()
        MainModule.ShowBilan()
        MainModule.ModeBilanFinal()
        Me.Visible = False
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        ModuleFichier.Sauvegarder()
        Me.Close()
    End Sub
End Class