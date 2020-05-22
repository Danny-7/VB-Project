''' <summary>
''' Formulaire de saisie des informations personnelles du candidat
''' </summary>
Public Class FormCandid

    ''' <summary>
    ''' Au chargement du formulaire la taille maximale des champs est modifiée
    ''' </summary>
    Private Sub FormCandid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbNom.MaxLength = 15
        TbPrenom.MaxLength = 20
        TbAdr.MaxLength = 30
        TbCp.MaxLength = 5
        TbVille.MaxLength = 15
    End Sub

    ''' Le compteur associé au Timer1 pour le décompte
    Private cpt As Integer = 60

    ''' <summary>
    ''' Au changement de visibilité, si le formulaire est visible le Timer1 s'enclenche
    ''' </summary>
    Private Sub FormCandid_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        cpt = 60
        If Me.Visible Then
            Timer1.Interval = 1000
            Timer1.Start()
            Timer1_Tick(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' Au tic, si le décompte de cpt est fini, l'application revient à l'accueil
    ''' Sinon, le décompte de cpt continue
    ''' </summary>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cpt = 0 Then
            Timer1.Stop()
            MsgBox("Temps imparti écoulé")
            BtnAban.PerformClick()
        Else
            cpt -= 1
            Me.Text = "Renseignements du candidat " & TimeString & " Temps restant : 00:" & cpt
        End If
    End Sub

    ''' <summary>
    ''' Vérifie que les données entrées sont bien des caractères alphabétiques
    ''' </summary>
    Private Sub TbAlpha_keypress(sender As Object, e As KeyPressEventArgs) Handles TbNom.KeyPress, TbPrenom.KeyPress, TbVille.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Vérifie que le code postal est bien numérique 
    ''' </summary>
    Private Sub TbCp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCp.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Affiche l'age choisi sur le scroll bar
    ''' </summary>
    Private Sub HScrollAge_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollAge.Scroll
        LabelAgeChoisi.Text = HScrollAge.Value
    End Sub

    ''' <summary>
    ''' Lors de l'appui sur le bouton abandonner, le formulaire nous redirige vers l'accueil 
    ''' </summary>
    Private Sub BtnAban_Click(sender As Object, e As EventArgs) Handles BtnAban.Click
        Timer1.Stop()
        MainModule.ShowAccueil()
        Visible = False
    End Sub

    ''' <summary>
    ''' Lors de l'appui sur le bouton valider le timer s'arrête, le formulaire devient invisible
    ''' Le formulaire pour selectionner les épreuves devient visible 
    ''' Si les informtaions obligatoires ne sont pas entrées un message apparait 
    ''' </summary>
    Private Sub BtnVali_Click(sender As Object, e As EventArgs) Handles BtnVali.Click
        If CheckForm() Then
            Timer1.Stop()
            Visible = False
            MainModule.ShowEpreuve()
        Else
            MsgBox("Les saisies sont invalides.")
        End If
    End Sub

    ''' <summary>
    ''' Réinitialise le formulaire
    ''' </summary>
    Public Sub ClearForm()
        cpt = 60
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
                c.ForeColor = Color.Black
            End If
        Next

        LabelAgeChoisi.Text = LabelAgeMin.Text

        HScrollAge.Value = HScrollAge.Minimum
    End Sub

    ''' <summary>
    ''' Vérifie que le formulaire est rempli correctement
    ''' Indique les champs incorrects en rouge
    ''' </summary>
    ''' <returns>Un boolean qui indique la validité du formulaire</returns>
    Private Function CheckForm() As Boolean
        Dim valid As Boolean = True

        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.ForeColor = Color.Black
            End If
        Next

        If TbNom.TextLength = 0 Then
            LabelNom.ForeColor = Color.Red
            valid = False
        End If

        If TbPrenom.TextLength = 0 Then
            LabelPrenom.ForeColor = Color.Red
            valid = False
        End If

        If TbCp.Text.Length = 5 Then
            If TbCp.Text.Substring(0, 2).Equals("00") Then
                LabelCp.ForeColor = Color.Red
                valid = False
            End If
        Else
            LabelCp.ForeColor = Color.Red
            valid = False
        End If

        If TbVille.TextLength = 0 Then
            LabelVille.ForeColor = Color.Red
            valid = False
        End If

        Return valid
    End Function

    ''' <summary>
    ''' Permet de créer un candidat à partir des informations personnelles saisies
    ''' </summary>
    ''' <returns>Un nouveau candidat</returns>
    Public Function CréerCandidat() As Candidat
        Return New Candidat(Me.TbNom.Text, Me.TbPrenom.Text, Me.TbAdr.Text, Me.TbCp.Text, Me.TbVille.Text, Me.LabelAgeChoisi.Text)
    End Function

    ''' <summary>
    ''' Permet de créer un candidat à partir des informations d'un identifiant et des informations personnelles saisies
    ''' </summary>
    ''' <param name="id">L'identifiant du candidat</param>
    ''' <returns>Un nouveau candidat</returns>
    Public Function CréerCandidat(ByVal id As Integer) As Candidat
        Return New Candidat(id, Me.TbNom.Text, Me.TbPrenom.Text, Me.TbAdr.Text, Me.TbCp.Text, Me.TbVille.Text, Me.LabelAgeChoisi.Text)
    End Function

    ''' <summary>
    ''' Remplit le formulaire avec les informations d'un candidat
    ''' </summary>
    ''' <param name="c">Le candidat avec lequel on remplit le formulaire</param>
    Public Sub LoadCandidat(ByRef c As Candidat)
        If c IsNot Nothing Then
            TbNom.Text = c.GetNom
            TbPrenom.Text = c.GetPrenom
            LabelAgeChoisi.Text = c.GetAge
            HScrollAge.Value = c.GetAge
            TbAdr.Text = c.GetAdresse
            TbCp.Text = c.GetCP
            TbVille.Text = c.GetVille
        End If
    End Sub
End Class
