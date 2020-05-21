Public Class FormBilan
    Private bilanMatière As New FormBilanMatière

    Private Sub FormBilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each pair As KeyValuePair(Of String, String) In ÉcritDictionnaire
            If Not CbMatière.Items.Contains(pair.Key) Then
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

    Private Sub BtnCandidat_Click(sender As Object, e As EventArgs) Handles BtnCandidat.Click
        If CbCandidat.Text <> "" And CbCandidat.Items.Contains(CbCandidat.Text) Then
            Dim candidat() As String = Split(CbCandidat.Text, " ")
            For Each c As Candidat In MainModule.GetListeOfCandidats
                If c.GetNom.Equals(candidat(0)) And c.GetPrenom.Equals(candidat(1)) Then
                    MainModule.SetCandidat(MainModule.GetCandidat(c.GetId))
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

    Private Sub BtnMatiere_Click(sender As Object, e As EventArgs) Handles BtnMatiere.Click
        If CbMatière.Text <> "" And CbMatière.Items.Contains(CbMatière.Text) Then
            bilanMatière.LabelMatière.Text = CbMatière.Text
            bilanMatière.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub FormBilan_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            LabelNbCandi.Text = MainModule.GetNbInscits
            CbCandidat.Items.Clear()
            CbCandidat.Text = ""
            CbMatière.Text = ""
            For Each c As Candidat In MainModule.GetListeOfCandidats
                CbCandidat.Items.Add(c.GetNom & " " & c.GetPrenom)
            Next
        End If
    End Sub

    Private Sub BtnClore_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Application.Exit()
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub
End Class