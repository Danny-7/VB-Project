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

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub
End Class