''' <summary>
''' Formulaire du bilan des inscriptions pour une matière choisie dans le FormBilan
''' </summary>
Public Class FormBilanMatière

    ''' <summary>
    ''' A l'apparition du formulaire,
    ''' On affiche dans une listBox triée par ordre alphabétique tous les candidats inscrits à cette épreuve
    ''' </summary>
    Private Sub FormBilanMatière_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            LbCandidat.Items.Clear()
            Dim liste As List(Of String) = New List(Of String)
            For Each c As Candidat In MainModule.GetListeOfInscrits
                For i As Integer = 0 To c.GetSizeOfEpreuve - 1
                    If c.GetEpreuve(i).GetNom = LabelMatière.Text Then
                        LbCandidat.Items.Add(c.GetRegion & " " & c.GetNom & " " & c.GetPrenom)
                    End If
                Next
            Next
            LbCandidat.Sorted = True
        End If
    End Sub

    ''' <summary>
    ''' Affiche l'accueil et ferme le bilan de la matière
    ''' </summary>
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        MainModule.ShowBilan()
        Me.Visible = False
    End Sub
End Class