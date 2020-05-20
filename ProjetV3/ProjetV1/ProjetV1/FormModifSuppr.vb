Public Class FormModifSuppr
    Private id As Integer
    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click
        If CheckForm() Then

        End If
    End Sub
    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        If CheckForm() Then
            MainModule.SetCandidat(MainModule.GetCandidat(id))
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

    Private Sub CbNomPrenom_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbNomPrenom.SelectedValueChanged
        If CbNomPrenom.Text <> "" Then
            Dim str() As String = Split(CbNomPrenom.Text, ":")
            Me.id = str(0)
            'Dim nom As String = Split(str(1), ",")(0)
            'Dim prenom As String = Split(str(1), ",")(1)
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

End Class