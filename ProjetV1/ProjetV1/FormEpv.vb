''' <summary>
''' Formulaire de choix des épreuves d'un candidat
''' </summary>
Public Class FormEpv

    ''' <summary>
    ''' Au chargement du formulaire des épreuves 
    ''' A partir de deux dictionnaires, l'un pour les épreuves orales et l'autre pour les épreuves écrites,
    ''' Chaque checkbox contenu dans un panel distinct en fonction du type d'épreuve, va être assignée avec le nom d'une épreuve
    ''' Une comboBox contenant toutes les régions possibles va être remplie
    ''' </summary>
    Private Sub FormEpv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On rempli la comboBox des régions à partir d'un tableau présent dans le mainModule
        CbRegion.DataSource = MainModule.Région
        Dim i As Integer = ÉcritDictionnaire.Count - 1
        For Each pair As KeyValuePair(Of String, String) In ÉcritDictionnaire
            'On assigne le texte de la checkbox contenu dans le panel écrit à la clé courante du dictionnaire
            PanelEcrit.Controls(i).Text = pair.Key
            i -= 1
        Next
        i = OralDictionnaire.Count - 1
        For Each pair As KeyValuePair(Of String, String) In OralDictionnaire
            'On assigne le texte de la checkbox contenu dans le panel oral à la clé courante du dictionnaire
            PanelOral.Controls(i).Text = pair.Key
            i -= 1
        Next
    End Sub

    ''' <summary>
    ''' Au changement de visibilité, si le candidat s'inscrit pour la première fois
    ''' la première région est sélectionnée dans la comboBox
    ''' Si le formulaire est visible, il est chargé avec le nom et le prénom du candidat et le Timer2 est lancé
    ''' </summary>
    Private Sub FormEpv_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ' Vérifie si le candidat s'inscrit pour la première fois
        If LabelID.Text = "0" And TbCptEcrit.Text <> "0" Then
            CbRegion.SelectedIndex = 0
        End If
        If Me.Visible Then
            LabelNom.Text = MainModule.GetTbNomFormCandidat
            LabelPrenom.Text = MainModule.GetTbPrenomFormCandidat
            cpt = 90
            Timer2.Interval = 1000
            Timer2.Start()
            Timer2_Tick(sender, e)
        End If
    End Sub

    ' Le compteur associé au Timer2 pour le décompte
    Private cpt As Integer = 90

    ''' <summary>
    ''' Au tic, si le décompte de cpt est fini, l'application revient à l'accueil
    ''' Sinon, le décompte de cpt continue
    ''' </summary>
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If cpt = 0 Then
            Timer2.Stop()
            MsgBox("Temps imparti écoulé")
            BtnAban.PerformClick()
        Else
            cpt -= 1
            Dim minute As Integer = cpt \ 60
            Dim seconde As Integer = cpt Mod 60
            Me.Text = "Choix des épreuves " & TimeString & " Temps restant : " & minute & ":" & seconde
        End If
    End Sub

    ''' <summary>
    ''' Si checkbox est sélectionnée on vérifie que le compteur ne soit pas égal 0 car dans ce cas on ne peut plus ajouter une épreuve
    ''' Lors de la selection si la première condition est valide 
    ''' Alors on désactive la checkBox contenant le même nom de l'épreuve séléctionnée dans le panel des épreuves orales
    ''' Si une checkBox est désélectionnée, on réactive la checkBox dans le panel oral
    ''' </summary>
    Private Sub CbEcrit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged,
        CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged,
        CheckBox6.CheckedChanged, CheckBox7.CheckedChanged, CheckBox8.CheckedChanged, CheckBox9.CheckedChanged,
        CheckBox10.CheckedChanged, CheckBox11.CheckedChanged, CheckBox12.CheckedChanged

        Dim cpt As Integer = CInt(TbCptEcrit.Text)
        If sender.Checked Then
            If cpt = 0 Then
                TbCptEcrit.Text = cpt - 1
                MsgBox("Impossible de selectionner plus d'options")
                sender.Checked = False
            Else
                For Each c As CheckBox In PanelOral.Controls
                    If c.Text = sender.Text Then
                        c.Enabled = False
                    End If
                Next
                TbCptEcrit.Text = cpt - 1
            End If
        Else
            For Each c As CheckBox In PanelOral.Controls
                If c.Text = sender.text Then
                    c.Enabled = True
                End If
            Next
            TbCptEcrit.Text = cpt + 1
        End If
    End Sub

    ''' <summary>
    ''' Si checkbox est sélectionnée on vérifie que le compteur ne soit pas égal 0 car dans ce cas on ne peut plus ajouter une épreuve
    ''' Lors de la selection si la première condition est valide 
    ''' Alors on désactive la checkBox contenant le même nom de l'épreuve séléctionnée dans le panel des épreuves écrites
    ''' Si une checkBox est désélectionnée, on réactive la checkBox dans le panel écrit
    ''' </summary>
    Private Sub CbOral_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged,
        CheckBox14.CheckedChanged, CheckBox15.CheckedChanged, CheckBox16.CheckedChanged, CheckBox17.CheckedChanged,
        CheckBox18.CheckedChanged, CheckBox19.CheckedChanged, CheckBox20.CheckedChanged, CheckBox21.CheckedChanged

        Dim cpt As Integer = CInt(TbCptOral.Text)
        If sender.Checked Then
            If cpt = 0 Then
                TbCptOral.Text = cpt - 1
                MsgBox("Impossible de selectionner plus d'options")
                sender.Checked = False
            Else
                For Each c As CheckBox In PanelEcrit.Controls
                    If c.Text = sender.Text Then
                        c.Enabled = False
                    End If
                Next
                TbCptOral.Text = cpt - 1
            End If
        Else
            For Each c As CheckBox In PanelEcrit.Controls
                If c.Text = sender.text Then
                    c.Enabled = True
                End If
            Next
            TbCptOral.Text = cpt + 1
        End If
    End Sub

    ''' <summary>
    ''' Si les compteurs d'épreuves restantes sont nulles
    ''' Le panel du choix de l'épreuve facultative devient actif
    ''' </summary>
    Private Sub TbCpt_TextChanged(sender As Object, e As EventArgs) Handles TbCptEcrit.TextChanged, TbCptOral.TextChanged
        If IsNumeric(TbCptEcrit.Text) And IsNumeric(TbCptOral.Text) Then
            PanelFacultatif.Enabled = CInt(TbCptEcrit.Text) = 0 And CInt(TbCptOral.Text) = 0
        End If
    End Sub

    ''' <summary>
    ''' Si RbOui est sélectionné, les panels des épreuves sont désactivées
    ''' Une comboBox avec les épreuves restantes est chargée et devient visible
    ''' </summary>
    Private Sub RbOui_CheckedChanged(sender As Object, e As EventArgs) Handles RbOui.CheckedChanged
        If sender.checked Then
            CbFacultatif.Items.Clear()

            PanelEcrit.Enabled = False
            PanelOral.Enabled = False
            LabelMatRest.Visible = True
            CbFacultatif.Visible = True

            For Each c As CheckBox In PanelEcrit.Controls
                If Not CbFacultatif.Items.Contains(c.Text) And Not c.Checked Then
                    CbFacultatif.Items.Add(c.Text)
                End If
            Next
            For Each c As CheckBox In PanelOral.Controls
                If Not CbFacultatif.Items.Contains(c.Text) And Not c.Checked Then
                    CbFacultatif.Items.Add(c.Text)
                End If
            Next

            For Each c As CheckBox In PanelEcrit.Controls
                If c.Checked Then
                    CbFacultatif.Items.Remove(c.Text)
                End If
            Next
            For Each c As CheckBox In PanelOral.Controls
                If c.Checked Then
                    CbFacultatif.Items.Remove(c.Text)
                End If
            Next
            CbFacultatif.Sorted = True
        End If
    End Sub

    ''' <summary>
    ''' Si RbNon est sélectionné, les panels des épreuves sont activés
    ''' La comboBox avec les épreuves restantes devient invisible
    ''' </summary>
    Private Sub RbNon_CheckedChanged(sender As Object, e As EventArgs) Handles RbNon.CheckedChanged
        If sender.checked Then
            PanelEcrit.Enabled = True
            PanelOral.Enabled = True
            LabelMatRest.Visible = False
            CbFacultatif.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Dans le cas où le candidat décide d'abandonner son inscription (choix des épreuves)
    ''' On le redirige vers l'accueil
    ''' le formulaire courant devient invisible
    ''' </summary>
    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAban.Click
        Timer2.Stop()
        MainModule.ShowAccueil()
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Si le formulaire est valide alors le Timer2 s'arrête
    ''' Puis un Candidat est créé et le formulaire récapitulatif devient visible en mode inscription
    ''' Sinon une msgBox indique que le formulaire est non valide
    ''' </summary>
    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        If CheckForm() Then
            Timer2.Stop()
            Dim c As Candidat
            If LabelID.Text = "0" Then
                c = MainModule.CréerCandidat()
                LabelID.Text = c.GetId
            Else
                c = MainModule.CréerCandidat(CInt(LabelID.Text))
            End If

            ' on assigne le candidat qu'on vient de créer au formulaire récapitulatif
            AjouterEpreuves(c)
            MainModule.SetCandidatFormRecap(c)
            MainModule.ModeInscription()
            MainModule.ShowRecap()
            Me.Visible = False
        Else
            MsgBox("Les saisies ne sont pas valides.")
        End If
    End Sub

    ''' <summary>
    ''' Réinitialise le formulaire lors d'une nouvelle inscription 
    ''' </summary>
    Public Sub ClearForm()
        cpt = 90
        PanelEcrit.Enabled = True
        PanelOral.Enabled = True

        'Réinitialisation des deux panels du formulaire
        For Each p As Control In Me.Controls
            If TypeOf p Is Panel Then
                Dim panel As Panel = CType(p, Panel)
                For Each cb As Control In panel.Controls
                    'Si le controle courant est une checkBox 
                    If TypeOf cb Is CheckBox Then
                        CType(cb, CheckBox).Checked = False
                        CType(cb, CheckBox).Enabled = True
                    End If
                Next
            End If
            p.ForeColor = Color.Black
        Next

        LabelID.Text = "0"
        PanelFacultatif.Enabled = False
        RbOui.Checked = False
        RbNon.Checked = False
        LabelMatRest.Visible = False
        CbFacultatif.Visible = False
        CbFacultatif.Text = ""
        TbCptEcrit.Text = 4
        TbCptOral.Text = 3
    End Sub

    ''' <summary>
    ''' Vérifie que le formulaire est rempli correctement
    ''' Indique les champs incorrects en rouge
    ''' </summary>
    ''' <returns>Un boolean qui indique la validité du formulaire</returns>
    Private Function CheckForm() As Boolean
        Dim valid As Boolean = True

        LabelCptEcrit.ForeColor = Color.Black
        LabelCptOral.ForeColor = Color.Black
        LabelMatRest.ForeColor = Color.Black
        LabelFacultatif.ForeColor = Color.Black

        If TbCptEcrit.Text <> "0" Then
            valid = False
            LabelCptEcrit.ForeColor = Color.Red
        End If

        If TbCptOral.Text <> "0" Then
            valid = False
            LabelCptOral.ForeColor = Color.Red
        End If

        If RbOui.Checked Then
            If Not CbFacultatif.SelectedIndex >= 0 Then
                valid = False
                LabelMatRest.ForeColor = Color.Red
            End If
        Else
            If Not RbNon.Checked Then
                LabelFacultatif.ForeColor = Color.Red
                valid = False
            End If
        End If

        Return valid
    End Function

    ''' <summary>
    ''' Ajoute les épreuves séléctionnées à la liste des épreuves du candidat
    ''' </summary>
    ''' <param name="cand">L'objet candidat</param>
    Public Sub AjouterEpreuves(ByRef cand As Candidat)
        cand.SetRegion(CbRegion.Text)

        cand.ClearEpreuve()

        For Each c As CheckBox In PanelEcrit.Controls
            If c.Checked Then
                cand.AjouterEpreuve(c.Text, Epreuve.TypeEpv.Ecrit)
            End If
        Next

        For Each c As CheckBox In PanelOral.Controls
            If c.Checked Then
                cand.AjouterEpreuve(c.Text, Epreuve.TypeEpv.Oral)
            End If
        Next

        If CbFacultatif.Visible Then
            cand.AjouterEpreuve(CbFacultatif.SelectedItem.ToString, Epreuve.TypeEpv.Facultatif)
        End If
    End Sub

    ''' <summary>
    ''' Remplit le formulaire avec les informations sur les épreuves d'un candidat
    ''' </summary>
    ''' <param name="c">Le candidat avec lequel on remplit le formulaire</param>
    Public Sub LoadEpreuves(c As Candidat)
        CbRegion.SelectedItem() = c.GetRegion
        LabelID.Text = c.GetId

        For i As Integer = 0 To c.GetSizeOfEpreuve - 1
            Dim e = c.GetEpreuve(i)
            If e.GetTypeOfEpv = Epreuve.TypeEpv.Ecrit Then
                For Each cb As CheckBox In PanelEcrit.Controls
                    If cb.Text = e.GetNom Then
                        cb.Checked = True
                    End If
                Next
            ElseIf e.GetTypeOfEpv = Epreuve.TypeEpv.Oral Then
                For Each cb As CheckBox In PanelOral.Controls
                    If cb.Text = e.GetNom Then
                        cb.Checked = True
                    End If
                Next
            Else
                RbOui.Checked = True
                CbFacultatif.SelectedItem = e.GetNom
            End If
        Next
    End Sub
End Class