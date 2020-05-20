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
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnModifSuppr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnEnrg
        '
        Me.BtnEnrg.Location = New System.Drawing.Point(72, 70)
        Me.BtnEnrg.Name = "BtnEnrg"
        Me.BtnEnrg.Size = New System.Drawing.Size(145, 65)
        Me.BtnEnrg.TabIndex = 0
        Me.BtnEnrg.Text = "Enregistrer une inscription"
        Me.BtnEnrg.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(72, 279)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(145, 57)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnModifSuppr
        '
        Me.BtnModifSuppr.Location = New System.Drawing.Point(72, 165)
        Me.BtnModifSuppr.Name = "BtnModifSuppr"
        Me.BtnModifSuppr.Size = New System.Drawing.Size(145, 65)
        Me.BtnModifSuppr.TabIndex = 2
        Me.BtnModifSuppr.Text = "Modifier ou supprimer une inscription"
        Me.BtnModifSuppr.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 450)
        Me.Controls.Add(Me.BtnModifSuppr)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnEnrg)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEnrg As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnModifSuppr As Button
End Class
