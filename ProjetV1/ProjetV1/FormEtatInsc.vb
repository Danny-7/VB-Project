Public Class FormEtatInsc
    Private Sub FormEtatInsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbOral.Sorted = True
        LbEcrit.Sorted = True
        LbCandidat.Sorted = False

    End Sub
    Private Sub FormEtatInsc_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            LbCandidat.Items.Clear()
            For Each c In MainModule.GetListeOfCandidats().OrderBy(Function(o) o.GetNom).ThenBy(Function(o) o.GetPrenom)
                Dim s As String = c.GetId & ": " & c.GetNom & " " & c.GetPrenom
                LbCandidat.Items.Add(s)
            Next
        End If
    End Sub

    Private Sub LbCandidat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbCandidat.SelectedIndexChanged
        LbEcrit.Items.Clear()
        LbOral.Items.Clear()
        LabelFacultatif.Text = "Aucune"
        Dim c As Candidat = MainModule.GetCandidat(CInt(Split(LbCandidat.Text, ":")(0)))

        For i As Integer = 0 To c.GetSizeOfEpreuve - 1
            Dim ep As Epreuve = c.GetEpreuve(i)
            If ep.GetTypeOfEpv = Epreuve.TypeEpv.Ecrit Then
                LbEcrit.Items.Add(ÉcritDictionnaire.Item(ep.GetNom))
            ElseIf ep.GetTypeOfEpv = Epreuve.TypeEpv.Oral Then
                LbOral.Items.Add(OralDictionnaire.Item(ep.GetNom))
            Else
                If ÉcritDictionnaire.ContainsKey(ep.GetNom) Then
                    LabelFacultatif.Text = ÉcritDictionnaire.Item(ep.GetNom)
                Else
                    LabelFacultatif.Text = OralDictionnaire.Item(ep.GetNom)
                End If
            End If
        Next
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

End Class