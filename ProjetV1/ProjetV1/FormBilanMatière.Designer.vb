<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBilanMatière
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.LabelMatière = New System.Windows.Forms.Label()
        Me.LbCandidat = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Liste des candidats pour la matière "
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(211, 229)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(92, 46)
        Me.BtnRetour.TabIndex = 2
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'LabelMatière
        '
        Me.LabelMatière.AutoSize = True
        Me.LabelMatière.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMatière.Location = New System.Drawing.Point(355, 34)
        Me.LabelMatière.Name = "LabelMatière"
        Me.LabelMatière.Size = New System.Drawing.Size(57, 18)
        Me.LabelMatière.TabIndex = 4
        Me.LabelMatière.Text = "Label3"
        '
        'LbCandidat
        '
        Me.LbCandidat.FormattingEnabled = True
        Me.LbCandidat.ItemHeight = 16
        Me.LbCandidat.Location = New System.Drawing.Point(135, 78)
        Me.LbCandidat.Name = "LbCandidat"
        Me.LbCandidat.Size = New System.Drawing.Size(252, 116)
        Me.LbCandidat.TabIndex = 5
        '
        'FormBilanMatière
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 310)
        Me.Controls.Add(Me.LbCandidat)
        Me.Controls.Add(Me.LabelMatière)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBilanMatière"
        Me.Text = "Bilan d'une matière"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRetour As Button
    Friend WithEvents LabelMatière As Label
    Friend WithEvents LbCandidat As ListBox
End Class
