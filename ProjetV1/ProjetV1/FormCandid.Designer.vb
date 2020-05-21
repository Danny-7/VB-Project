<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCandid
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
        Me.components = New System.ComponentModel.Container()
        Me.HScrollAge = New System.Windows.Forms.HScrollBar()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.LabelAgeMax = New System.Windows.Forms.Label()
        Me.LabelAgeMin = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAban = New System.Windows.Forms.Button()
        Me.BtnVali = New System.Windows.Forms.Button()
        Me.LabelAgeChoisi = New System.Windows.Forms.Label()
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.TbAdr = New System.Windows.Forms.TextBox()
        Me.TbPrenom = New System.Windows.Forms.TextBox()
        Me.TbCp = New System.Windows.Forms.TextBox()
        Me.TbVille = New System.Windows.Forms.TextBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelAdr = New System.Windows.Forms.Label()
        Me.LabelCp = New System.Windows.Forms.Label()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'HScrollAge
        '
        Me.HScrollAge.LargeChange = 1
        Me.HScrollAge.Location = New System.Drawing.Point(75, 187)
        Me.HScrollAge.Maximum = 55
        Me.HScrollAge.Minimum = 18
        Me.HScrollAge.Name = "HScrollAge"
        Me.HScrollAge.Size = New System.Drawing.Size(377, 21)
        Me.HScrollAge.TabIndex = 5
        Me.HScrollAge.Value = 18
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Location = New System.Drawing.Point(45, 136)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(33, 17)
        Me.LabelAge.TabIndex = 11
        Me.LabelAge.Text = "Âge"
        '
        'LabelAgeMax
        '
        Me.LabelAgeMax.AutoSize = True
        Me.LabelAgeMax.Location = New System.Drawing.Point(468, 187)
        Me.LabelAgeMax.Name = "LabelAgeMax"
        Me.LabelAgeMax.Size = New System.Drawing.Size(24, 17)
        Me.LabelAgeMax.TabIndex = 12
        Me.LabelAgeMax.Text = "55"
        '
        'LabelAgeMin
        '
        Me.LabelAgeMin.AutoSize = True
        Me.LabelAgeMin.Location = New System.Drawing.Point(48, 187)
        Me.LabelAgeMin.Name = "LabelAgeMin"
        Me.LabelAgeMin.Size = New System.Drawing.Size(24, 17)
        Me.LabelAgeMin.TabIndex = 13
        Me.LabelAgeMin.Text = "18"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "* champs obligatoire"
        '
        'BtnAban
        '
        Me.BtnAban.Location = New System.Drawing.Point(229, 263)
        Me.BtnAban.Name = "BtnAban"
        Me.BtnAban.Size = New System.Drawing.Size(123, 43)
        Me.BtnAban.TabIndex = 15
        Me.BtnAban.Text = "Abandonner"
        Me.BtnAban.UseVisualStyleBackColor = True
        '
        'BtnVali
        '
        Me.BtnVali.Location = New System.Drawing.Point(443, 263)
        Me.BtnVali.Name = "BtnVali"
        Me.BtnVali.Size = New System.Drawing.Size(123, 43)
        Me.BtnVali.TabIndex = 16
        Me.BtnVali.Text = "Valider"
        Me.BtnVali.UseVisualStyleBackColor = True
        '
        'LabelAgeChoisi
        '
        Me.LabelAgeChoisi.AutoSize = True
        Me.LabelAgeChoisi.Location = New System.Drawing.Point(153, 136)
        Me.LabelAgeChoisi.Name = "LabelAgeChoisi"
        Me.LabelAgeChoisi.Size = New System.Drawing.Size(24, 17)
        Me.LabelAgeChoisi.TabIndex = 17
        Me.LabelAgeChoisi.Text = "18"
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(134, 25)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(175, 22)
        Me.TbNom.TabIndex = 0
        '
        'TbAdr
        '
        Me.TbAdr.Location = New System.Drawing.Point(482, 22)
        Me.TbAdr.Name = "TbAdr"
        Me.TbAdr.Size = New System.Drawing.Size(319, 22)
        Me.TbAdr.TabIndex = 1
        '
        'TbPrenom
        '
        Me.TbPrenom.Location = New System.Drawing.Point(134, 84)
        Me.TbPrenom.Name = "TbPrenom"
        Me.TbPrenom.Size = New System.Drawing.Size(175, 22)
        Me.TbPrenom.TabIndex = 2
        '
        'TbCp
        '
        Me.TbCp.Location = New System.Drawing.Point(482, 84)
        Me.TbCp.Name = "TbCp"
        Me.TbCp.Size = New System.Drawing.Size(100, 22)
        Me.TbCp.TabIndex = 3
        '
        'TbVille
        '
        Me.TbVille.Location = New System.Drawing.Point(701, 81)
        Me.TbVille.Name = "TbVille"
        Me.TbVille.Size = New System.Drawing.Size(100, 22)
        Me.TbVille.TabIndex = 4
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(45, 25)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(42, 17)
        Me.LabelNom.TabIndex = 6
        Me.LabelNom.Text = "Nom*"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(45, 84)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(62, 17)
        Me.LabelPrenom.TabIndex = 7
        Me.LabelPrenom.Text = "Prénom*"
        '
        'LabelAdr
        '
        Me.LabelAdr.AutoSize = True
        Me.LabelAdr.Location = New System.Drawing.Point(371, 27)
        Me.LabelAdr.Name = "LabelAdr"
        Me.LabelAdr.Size = New System.Drawing.Size(60, 17)
        Me.LabelAdr.TabIndex = 8
        Me.LabelAdr.Text = "Adresse"
        '
        'LabelCp
        '
        Me.LabelCp.AutoSize = True
        Me.LabelCp.Location = New System.Drawing.Point(371, 84)
        Me.LabelCp.Name = "LabelCp"
        Me.LabelCp.Size = New System.Drawing.Size(88, 17)
        Me.LabelCp.TabIndex = 9
        Me.LabelCp.Text = "Code postal*"
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Location = New System.Drawing.Point(648, 84)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(39, 17)
        Me.LabelVille.TabIndex = 10
        Me.LabelVille.Text = "Ville*"
        '
        'Timer1
        '
        '
        'FormCandid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 382)
        Me.Controls.Add(Me.LabelAgeChoisi)
        Me.Controls.Add(Me.BtnVali)
        Me.Controls.Add(Me.BtnAban)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelAgeMin)
        Me.Controls.Add(Me.LabelAgeMax)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.LabelVille)
        Me.Controls.Add(Me.LabelCp)
        Me.Controls.Add(Me.LabelAdr)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.HScrollAge)
        Me.Controls.Add(Me.TbVille)
        Me.Controls.Add(Me.TbCp)
        Me.Controls.Add(Me.TbPrenom)
        Me.Controls.Add(Me.TbAdr)
        Me.Controls.Add(Me.TbNom)
        Me.Name = "FormCandid"
        Me.Text = "Renseignements du candidat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HScrollAge As HScrollBar
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelAgeMax As Label
    Friend WithEvents LabelAgeMin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAban As Button
    Friend WithEvents BtnVali As Button
    Friend WithEvents LabelAgeChoisi As Label
    Friend WithEvents TbNom As TextBox
    Friend WithEvents TbAdr As TextBox
    Friend WithEvents TbPrenom As TextBox
    Friend WithEvents TbCp As TextBox
    Friend WithEvents TbVille As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelAdr As Label
    Friend WithEvents LabelCp As Label
    Friend WithEvents LabelVille As Label
    Friend WithEvents Timer1 As Timer
End Class
