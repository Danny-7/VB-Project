<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBilan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNbCandi = New System.Windows.Forms.Label()
        Me.BtnCandidat = New System.Windows.Forms.Button()
        Me.BtnMatiere = New System.Windows.Forms.Button()
        Me.CbCandidat = New System.Windows.Forms.ComboBox()
        Me.CbMatière = New System.Windows.Forms.ComboBox()
        Me.LabelCandidat = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de candidatures :"
        '
        'LabelNbCandi
        '
        Me.LabelNbCandi.AutoSize = True
        Me.LabelNbCandi.Location = New System.Drawing.Point(330, 20)
        Me.LabelNbCandi.Name = "LabelNbCandi"
        Me.LabelNbCandi.Size = New System.Drawing.Size(51, 17)
        Me.LabelNbCandi.TabIndex = 1
        Me.LabelNbCandi.Text = "Label2"
        '
        'BtnCandidat
        '
        Me.BtnCandidat.Location = New System.Drawing.Point(63, 169)
        Me.BtnCandidat.Name = "BtnCandidat"
        Me.BtnCandidat.Size = New System.Drawing.Size(163, 74)
        Me.BtnCandidat.TabIndex = 2
        Me.BtnCandidat.Text = "Afficher le bilan de candidature"
        Me.BtnCandidat.UseVisualStyleBackColor = True
        '
        'BtnMatiere
        '
        Me.BtnMatiere.Location = New System.Drawing.Point(312, 169)
        Me.BtnMatiere.Name = "BtnMatiere"
        Me.BtnMatiere.Size = New System.Drawing.Size(163, 74)
        Me.BtnMatiere.TabIndex = 3
        Me.BtnMatiere.Text = "Afficher le bilan de la matière"
        Me.BtnMatiere.UseVisualStyleBackColor = True
        '
        'CbCandidat
        '
        Me.CbCandidat.FormattingEnabled = True
        Me.CbCandidat.Location = New System.Drawing.Point(63, 107)
        Me.CbCandidat.Name = "CbCandidat"
        Me.CbCandidat.Size = New System.Drawing.Size(163, 24)
        Me.CbCandidat.TabIndex = 4
        '
        'CbMatière
        '
        Me.CbMatière.FormattingEnabled = True
        Me.CbMatière.Location = New System.Drawing.Point(312, 107)
        Me.CbMatière.Name = "CbMatière"
        Me.CbMatière.Size = New System.Drawing.Size(162, 24)
        Me.CbMatière.TabIndex = 5
        '
        'LabelCandidat
        '
        Me.LabelCandidat.AutoSize = True
        Me.LabelCandidat.Location = New System.Drawing.Point(60, 77)
        Me.LabelCandidat.Name = "LabelCandidat"
        Me.LabelCandidat.Size = New System.Drawing.Size(71, 17)
        Me.LabelCandidat.TabIndex = 6
        Me.LabelCandidat.Text = "Candidats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Matières"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "OU"
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(312, 273)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(114, 44)
        Me.BtnFermer.TabIndex = 9
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(115, 275)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(111, 40)
        Me.BtnRetour.TabIndex = 10
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'FormBilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 360)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelCandidat)
        Me.Controls.Add(Me.CbMatière)
        Me.Controls.Add(Me.CbCandidat)
        Me.Controls.Add(Me.BtnMatiere)
        Me.Controls.Add(Me.BtnCandidat)
        Me.Controls.Add(Me.LabelNbCandi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBilan"
        Me.Text = "Bilan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNbCandi As Label
    Friend WithEvents BtnCandidat As Button
    Friend WithEvents BtnMatiere As Button
    Friend WithEvents CbCandidat As ComboBox
    Friend WithEvents CbMatière As ComboBox
    Friend WithEvents LabelCandidat As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnRetour As Button
End Class
