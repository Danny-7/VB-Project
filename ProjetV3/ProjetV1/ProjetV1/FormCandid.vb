﻿Imports System.Reflection

Public Class FormCandid

    Private Sub FormCandid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbNom.MaxLength = 15
        TbPrenom.MaxLength = 20
        TbAdr.MaxLength = 30
        TbCp.MaxLength = 5
        TbVille.MaxLength = 15
    End Sub

    Private Sub TbAlpha_keypress(sender As Object, e As KeyPressEventArgs) Handles TbNom.KeyPress, TbPrenom.KeyPress, TbVille.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbCp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCp.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HScrollAge_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollAge.Scroll
        LabelAgeChoisi.Text = HScrollAge.Value
    End Sub

    Private Sub BtnAban_Click(sender As Object, e As EventArgs) Handles BtnAban.Click
        MainModule.ShowAccueil()
        Visible = False
    End Sub
    Private Sub BtnVali_Click(sender As Object, e As EventArgs) Handles BtnVali.Click
        If CheckForm() Then
            Visible = False
            MainModule.ShowEpreuve()
        Else
            MsgBox("Les saisies sont invalides.")
        End If
    End Sub

    Public Sub ClearForm()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
                c.ForeColor = Color.Black
            End If
        Next

        LabelAgeChoisi.Text = LabelAgeMin.Text

        HScrollAge.Value = HScrollAge.Minimum
    End Sub

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

    Public Function créerCandidat() As Candidat
        Return New Candidat(Me.TbNom.Text, Me.TbPrenom.Text, Me.TbAdr.Text, Me.TbCp.Text, Me.TbVille.Text, Me.LabelAgeChoisi.Text)
    End Function


End Class