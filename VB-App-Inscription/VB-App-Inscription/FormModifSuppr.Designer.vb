﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifSuppr
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
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.CbNomPrenom = New System.Windows.Forms.ComboBox()
        Me.LabelNp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnAbandon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(82, 54)
        Me.TbId.Margin = New System.Windows.Forms.Padding(2)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(95, 20)
        Me.TbId.TabIndex = 0
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(97, 22)
        Me.LabelId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(53, 13)
        Me.LabelId.TabIndex = 1
        Me.LabelId.Text = "Identifiant"
        '
        'CbNomPrenom
        '
        Me.CbNomPrenom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNomPrenom.FormattingEnabled = True
        Me.CbNomPrenom.Location = New System.Drawing.Point(309, 56)
        Me.CbNomPrenom.Margin = New System.Windows.Forms.Padding(2)
        Me.CbNomPrenom.Name = "CbNomPrenom"
        Me.CbNomPrenom.Size = New System.Drawing.Size(135, 21)
        Me.CbNomPrenom.TabIndex = 2
        '
        'LabelNp
        '
        Me.LabelNp.AutoSize = True
        Me.LabelNp.Location = New System.Drawing.Point(314, 25)
        Me.LabelNp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNp.Name = "LabelNp"
        Me.LabelNp.Size = New System.Drawing.Size(79, 13)
        Me.LabelNp.TabIndex = 3
        Me.LabelNp.Text = "Nom et prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OU"
        '
        'BtnModif
        '
        Me.BtnModif.Location = New System.Drawing.Point(190, 158)
        Me.BtnModif.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Size = New System.Drawing.Size(86, 29)
        Me.BtnModif.TabIndex = 5
        Me.BtnModif.Text = "Modifier"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(307, 158)
        Me.BtnSupprimer.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(86, 29)
        Me.BtnSupprimer.TabIndex = 6
        Me.BtnSupprimer.Text = "Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnAbandon
        '
        Me.BtnAbandon.Location = New System.Drawing.Point(82, 155)
        Me.BtnAbandon.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAbandon.Name = "BtnAbandon"
        Me.BtnAbandon.Size = New System.Drawing.Size(75, 32)
        Me.BtnAbandon.TabIndex = 20
        Me.BtnAbandon.Text = "Abandonner"
        Me.BtnAbandon.UseVisualStyleBackColor = True
        '
        'FormModifSuppr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 254)
        Me.Controls.Add(Me.BtnAbandon)
        Me.Controls.Add(Me.BtnSupprimer)
        Me.Controls.Add(Me.BtnModif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNp)
        Me.Controls.Add(Me.CbNomPrenom)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.TbId)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormModifSuppr"
        Me.Text = "Modification ou suppression"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbId As TextBox
    Friend WithEvents LabelId As Label
    Friend WithEvents CbNomPrenom As ComboBox
    Friend WithEvents LabelNp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnModif As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnAbandon As Button
End Class
