<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Me.BtnEnrg = New System.Windows.Forms.Button()
        Me.BtnModifSuppr = New System.Windows.Forms.Button()
        Me.BtnEtatInsc = New System.Windows.Forms.Button()
        Me.BtnBilan = New System.Windows.Forms.Button()
        Me.BtnClore = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnEnrg
        '
        Me.BtnEnrg.Location = New System.Drawing.Point(72, 29)
        Me.BtnEnrg.Name = "BtnEnrg"
        Me.BtnEnrg.Size = New System.Drawing.Size(145, 65)
        Me.BtnEnrg.TabIndex = 0
        Me.BtnEnrg.Text = "Enregistrer une inscription"
        Me.BtnEnrg.UseVisualStyleBackColor = True
        '
        'BtnModifSuppr
        '
        Me.BtnModifSuppr.Location = New System.Drawing.Point(72, 124)
        Me.BtnModifSuppr.Name = "BtnModifSuppr"
        Me.BtnModifSuppr.Size = New System.Drawing.Size(145, 65)
        Me.BtnModifSuppr.TabIndex = 2
        Me.BtnModifSuppr.Text = "Modifier ou supprimer une inscription"
        Me.BtnModifSuppr.UseVisualStyleBackColor = True
        '
        'BtnEtatInsc
        '
        Me.BtnEtatInsc.Location = New System.Drawing.Point(286, 29)
        Me.BtnEtatInsc.Name = "BtnEtatInsc"
        Me.BtnEtatInsc.Size = New System.Drawing.Size(145, 65)
        Me.BtnEtatInsc.TabIndex = 3
        Me.BtnEtatInsc.Text = "Etat actuel des inscriptions"
        Me.BtnEtatInsc.UseVisualStyleBackColor = True
        '
        'BtnBilan
        '
        Me.BtnBilan.Location = New System.Drawing.Point(286, 121)
        Me.BtnBilan.Name = "BtnBilan"
        Me.BtnBilan.Size = New System.Drawing.Size(145, 65)
        Me.BtnBilan.TabIndex = 4
        Me.BtnBilan.Text = "Bilan des inscriptions"
        Me.BtnBilan.UseVisualStyleBackColor = True
        '
        'BtnClore
        '
        Me.BtnClore.Location = New System.Drawing.Point(72, 264)
        Me.BtnClore.Name = "BtnClore"
        Me.BtnClore.Size = New System.Drawing.Size(145, 70)
        Me.BtnClore.TabIndex = 10
        Me.BtnClore.Text = "Clore les inscriptions"
        Me.BtnClore.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(286, 264)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(145, 68)
        Me.BtnFermer.TabIndex = 11
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 376)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnClore)
        Me.Controls.Add(Me.BtnBilan)
        Me.Controls.Add(Me.BtnEtatInsc)
        Me.Controls.Add(Me.BtnModifSuppr)
        Me.Controls.Add(Me.BtnEnrg)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEnrg As Button
    Friend WithEvents BtnModifSuppr As Button
    Friend WithEvents BtnEtatInsc As Button
    Friend WithEvents BtnBilan As Button
    Friend WithEvents BtnClore As Button
    Friend WithEvents BtnFermer As Button
End Class
