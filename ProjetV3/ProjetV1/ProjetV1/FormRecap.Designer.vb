<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecap
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.LabelAdr = New System.Windows.Forms.Label()
        Me.LabelCp = New System.Windows.Forms.Label()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.LabelEcrit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelOral = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelFacultatif = New System.Windows.Forms.Label()
        Me.LabelEpvFacul = New System.Windows.Forms.Label()
        Me.PanelEcrit = New System.Windows.Forms.Panel()
        Me.PanelOral = New System.Windows.Forms.Panel()
        Me.BtnAbandon = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.BtnEnrg = New System.Windows.Forms.Button()
        Me.PanelCandidat = New System.Windows.Forms.Panel()
        Me.PanelEcrit.SuspendLayout()
        Me.PanelOral.SuspendLayout()
        Me.PanelCandidat.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(20, 11)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(35, 17)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(122, 11)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(56, 17)
        Me.LabelPrenom.TabIndex = 1
        Me.LabelPrenom.Text = "prenom"
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Location = New System.Drawing.Point(243, 11)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(32, 17)
        Me.LabelAge.TabIndex = 2
        Me.LabelAge.Text = "age"
        '
        'LabelAdr
        '
        Me.LabelAdr.AutoSize = True
        Me.LabelAdr.Location = New System.Drawing.Point(20, 70)
        Me.LabelAdr.Name = "LabelAdr"
        Me.LabelAdr.Size = New System.Drawing.Size(59, 17)
        Me.LabelAdr.TabIndex = 3
        Me.LabelAdr.Text = "adresse"
        '
        'LabelCp
        '
        Me.LabelCp.AutoSize = True
        Me.LabelCp.Location = New System.Drawing.Point(20, 122)
        Me.LabelCp.Name = "LabelCp"
        Me.LabelCp.Size = New System.Drawing.Size(81, 17)
        Me.LabelCp.TabIndex = 4
        Me.LabelCp.Text = "code postal"
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Location = New System.Drawing.Point(153, 122)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(32, 17)
        Me.LabelVille.TabIndex = 5
        Me.LabelVille.Text = "ville"
        '
        'LabelEcrit
        '
        Me.LabelEcrit.AutoSize = True
        Me.LabelEcrit.Location = New System.Drawing.Point(48, 234)
        Me.LabelEcrit.Name = "LabelEcrit"
        Me.LabelEcrit.Size = New System.Drawing.Size(122, 17)
        Me.LabelEcrit.TabIndex = 6
        Me.LabelEcrit.Text = "Epreuves écrites :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Label5"
        '
        'LabelOral
        '
        Me.LabelOral.AutoSize = True
        Me.LabelOral.Location = New System.Drawing.Point(276, 234)
        Me.LabelOral.Name = "LabelOral"
        Me.LabelOral.Size = New System.Drawing.Size(119, 17)
        Me.LabelOral.TabIndex = 11
        Me.LabelOral.Text = "Epreuves orales :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label9"
        '
        'LabelFacultatif
        '
        Me.LabelFacultatif.AutoSize = True
        Me.LabelFacultatif.Location = New System.Drawing.Point(494, 234)
        Me.LabelFacultatif.Name = "LabelFacultatif"
        Me.LabelFacultatif.Size = New System.Drawing.Size(137, 17)
        Me.LabelFacultatif.TabIndex = 15
        Me.LabelFacultatif.Text = "Epreuve facultative :"
        '
        'LabelEpvFacul
        '
        Me.LabelEpvFacul.AutoSize = True
        Me.LabelEpvFacul.Location = New System.Drawing.Point(499, 279)
        Me.LabelEpvFacul.Name = "LabelEpvFacul"
        Me.LabelEpvFacul.Size = New System.Drawing.Size(56, 17)
        Me.LabelEpvFacul.TabIndex = 16
        Me.LabelEpvFacul.Text = "Aucune"
        '
        'PanelEcrit
        '
        Me.PanelEcrit.Controls.Add(Me.Label5)
        Me.PanelEcrit.Controls.Add(Me.Label4)
        Me.PanelEcrit.Controls.Add(Me.Label3)
        Me.PanelEcrit.Controls.Add(Me.Label2)
        Me.PanelEcrit.Location = New System.Drawing.Point(41, 266)
        Me.PanelEcrit.Name = "PanelEcrit"
        Me.PanelEcrit.Size = New System.Drawing.Size(170, 174)
        Me.PanelEcrit.TabIndex = 17
        '
        'PanelOral
        '
        Me.PanelOral.Controls.Add(Me.Label9)
        Me.PanelOral.Controls.Add(Me.Label8)
        Me.PanelOral.Controls.Add(Me.Label7)
        Me.PanelOral.Location = New System.Drawing.Point(266, 269)
        Me.PanelOral.Name = "PanelOral"
        Me.PanelOral.Size = New System.Drawing.Size(161, 121)
        Me.PanelOral.TabIndex = 18
        '
        'BtnAbandon
        '
        Me.BtnAbandon.Location = New System.Drawing.Point(80, 474)
        Me.BtnAbandon.Name = "BtnAbandon"
        Me.BtnAbandon.Size = New System.Drawing.Size(100, 40)
        Me.BtnAbandon.TabIndex = 19
        Me.BtnAbandon.Text = "Abandonner"
        Me.BtnAbandon.UseVisualStyleBackColor = True
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(266, 474)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(88, 40)
        Me.BtnRetour.TabIndex = 20
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'BtnEnrg
        '
        Me.BtnEnrg.Location = New System.Drawing.Point(446, 474)
        Me.BtnEnrg.Name = "BtnEnrg"
        Me.BtnEnrg.Size = New System.Drawing.Size(94, 40)
        Me.BtnEnrg.TabIndex = 21
        Me.BtnEnrg.Text = "Enregistrer"
        Me.BtnEnrg.UseVisualStyleBackColor = True
        '
        'PanelCandidat
        '
        Me.PanelCandidat.Controls.Add(Me.LabelVille)
        Me.PanelCandidat.Controls.Add(Me.LabelCp)
        Me.PanelCandidat.Controls.Add(Me.LabelAdr)
        Me.PanelCandidat.Controls.Add(Me.LabelAge)
        Me.PanelCandidat.Controls.Add(Me.LabelPrenom)
        Me.PanelCandidat.Controls.Add(Me.LabelNom)
        Me.PanelCandidat.Location = New System.Drawing.Point(33, 31)
        Me.PanelCandidat.Name = "PanelCandidat"
        Me.PanelCandidat.Size = New System.Drawing.Size(294, 161)
        Me.PanelCandidat.TabIndex = 22
        '
        'FormRecap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 548)
        Me.Controls.Add(Me.PanelCandidat)
        Me.Controls.Add(Me.BtnEnrg)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnAbandon)
        Me.Controls.Add(Me.PanelOral)
        Me.Controls.Add(Me.PanelEcrit)
        Me.Controls.Add(Me.LabelEpvFacul)
        Me.Controls.Add(Me.LabelFacultatif)
        Me.Controls.Add(Me.LabelOral)
        Me.Controls.Add(Me.LabelEcrit)
        Me.Name = "FormRecap"
        Me.Text = "Récapitulatif de l'inscription"
        Me.PanelEcrit.ResumeLayout(False)
        Me.PanelEcrit.PerformLayout()
        Me.PanelOral.ResumeLayout(False)
        Me.PanelOral.PerformLayout()
        Me.PanelCandidat.ResumeLayout(False)
        Me.PanelCandidat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelAdr As Label
    Friend WithEvents LabelCp As Label
    Friend WithEvents LabelVille As Label
    Friend WithEvents LabelEcrit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelOral As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelFacultatif As Label
    Friend WithEvents LabelEpvFacul As Label
    Friend WithEvents PanelEcrit As Panel
    Friend WithEvents PanelOral As Panel
    Friend WithEvents BtnAbandon As Button
    Friend WithEvents BtnRetour As Button
    Friend WithEvents BtnEnrg As Button
    Friend WithEvents PanelCandidat As Panel
End Class
