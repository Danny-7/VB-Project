Public Class FormModifSuppr
    Private id As Integer

    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click
        If CheckForm() Then
            Dim c As Candidat = MainModule.GetCandidat(id)
            MainModule.LoadCandidat(c)
            MainModule.LoadEpreuves(c)
            MainModule.ShowCandidat()
            Me.Visible = False
        End If
    End Sub
    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        If CheckForm() Then
            MainModule.SetCandidat(MainModule.GetCandidat(id))
            MainModule.ModeSuppr()
            MainModule.ShowRecap()
            Me.Visible = False
        End If
    End Sub

    Private Sub TbId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbId.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If TbId.Text = "" Then
            CbNomPrenom.Enabled = True
        Else
            CbNomPrenom.Enabled = False
        End If
    End Sub

    Private Sub TbId_LostFocus(sender As Object, e As EventArgs) Handles TbId.LostFocus
        If TbId.Text <> "" Then
            Me.id = CInt(TbId.Text)
        End If
    End Sub

    Private Sub CbNomPrenom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbNomPrenom.SelectedValueChanged
        If CbNomPrenom.Text <> "" Then
            Dim str() As String = Split(CbNomPrenom.Text, ":")
            Me.id = CInt(str(0))
        End If
    End Sub

    Private Sub FormModifSuppr_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ClearForm()

        For Each c As Candidat In GetListeOfCandidats()
            CbNomPrenom.Items.Add(c.GetId & ": " & c.GetNom & " " & c.GetPrenom)
        Next
    End Sub

    Private Function CheckForm() As Boolean
        If TbId.Text <> "" Then
            For Each c As Candidat In GetListeOfCandidats()
                If c.GetId = TbId.Text Then
                    Return True
                End If
            Next
        End If

        Return CbNomPrenom.Text <> ""
    End Function

    Private Sub ClearForm()
        CbNomPrenom.Items.Clear()
        TbId.Text = ""
        CbNomPrenom.Text = ""
    End Sub

    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAbandon.Click
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

    Private Sub FormModifSuppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class