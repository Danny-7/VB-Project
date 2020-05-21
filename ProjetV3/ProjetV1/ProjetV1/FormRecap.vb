Public Class FormRecap
    Private candidat As Candidat

    'modifie le candidat du formulaire
    Public Sub SetCandidat(ByRef c As Candidat)
        Me.candidat = c
    End Sub

    Private Sub RemplirPanelCandidat(ByRef c As Candidat)
        LabelNom.Text = c.GetNom()
        LabelPrenom.Text = c.GetPrenom()
        LabelAdr.Text = c.GetAdresse()
        LabelCp.Text = c.GetCP()
        LabelVille.Text = c.GetVille()
        LabelAge.Text = c.GetAge()
    End Sub

    Private Sub RemplirPanelEpreuves(ByRef c As Candidat)
        Dim cptEcrit = 0
        Dim cptOral = 0
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

    Private Sub FormRecap_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            'candidat = MainModule.créerCandidat()
            MainModule.AjouterEpreuves(candidat)
            RemplirPanelCandidat(candidat)
            RemplirPanelEpreuves(candidat)
        End If
    End Sub

    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAbandon.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        MainModule.ShowCandidat()
        Me.Visible = False
    End Sub

    Private Sub BtnEnrg_Click(sender As Object, e As EventArgs) Handles BtnEnrg.Click
        MainModule.AjouterCandidat(candidat)
        MsgBox("Votre inscription a été effectuée avec succès. Votre identifiant est " & candidat.GetId)
        MainModule.ShowAccueil()
        Me.Visible = False

    End Sub
End Class