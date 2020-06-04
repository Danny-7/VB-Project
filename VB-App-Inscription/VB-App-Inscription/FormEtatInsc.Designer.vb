<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEtatInsc
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
        Me.LbCandidat = New System.Windows.Forms.ListBox()
        Me.LbEcrit = New System.Windows.Forms.ListBox()
        Me.LbOral = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelFacultatif = New System.Windows.Forms.Label()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbCandidat
        '
        Me.LbCandidat.FormattingEnabled = True
        Me.LbCandidat.ItemHeight = 16
        Me.LbCandidat.Location = New System.Drawing.Point(48, 117)
        Me.LbCandidat.Name = "LbCandidat"
        Me.LbCandidat.Size = New System.Drawing.Size(176, 116)
        Me.LbCandidat.TabIndex = 0
        '
        'LbEcrit
        '
        Me.LbEcrit.FormattingEnabled = True
        Me.LbEcrit.ItemHeight = 16
        Me.LbEcrit.Location = New System.Drawing.Point(248, 117)
        Me.LbEcrit.Name = "LbEcrit"
        Me.LbEcrit.Size = New System.Drawing.Size(176, 116)
        Me.LbEcrit.TabIndex = 1
        '
        'LbOral
        '
        Me.LbOral.FormattingEnabled = True
        Me.LbOral.ItemHeight = 16
        Me.LbOral.Location = New System.Drawing.Point(449, 117)
        Me.LbOral.Name = "LbOral"
        Me.LbOral.Size = New System.Drawing.Size(176, 116)
        Me.LbOral.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Candidats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Epreuves écrites"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Epreuves orales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(637, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Epreuve facultative"
        '
        'LabelFacultatif
        '
        Me.LabelFacultatif.AutoSize = True
        Me.LabelFacultatif.Location = New System.Drawing.Point(649, 117)
        Me.LabelFacultatif.Name = "LabelFacultatif"
        Me.LabelFacultatif.Size = New System.Drawing.Size(51, 17)
        Me.LabelFacultatif.TabIndex = 8
        Me.LabelFacultatif.Text = "Label5"
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(346, 290)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(88, 40)
        Me.BtnRetour.TabIndex = 21
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'FormEtatInsc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 358)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.LabelFacultatif)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbOral)
        Me.Controls.Add(Me.LbEcrit)
        Me.Controls.Add(Me.LbCandidat)
        Me.Name = "FormEtatInsc"
        Me.Text = "Etats des incriptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbCandidat As ListBox
    Friend WithEvents LbEcrit As ListBox
    Friend WithEvents LbOral As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelFacultatif As Label
    Friend WithEvents BtnRetour As Button
End Class
