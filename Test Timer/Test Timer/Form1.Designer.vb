﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TIM_TIM = New System.Windows.Forms.Timer(Me.components)
        Me.BT_DEMAR = New System.Windows.Forms.Button()
        Me.BT_RAZ = New System.Windows.Forms.Button()
        Me.PGB_TIM = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'TIM_TIM
        '
        Me.TIM_TIM.Interval = 20
        '
        'BT_DEMAR
        '
        Me.BT_DEMAR.Location = New System.Drawing.Point(50, 25)
        Me.BT_DEMAR.Name = "BT_DEMAR"
        Me.BT_DEMAR.Size = New System.Drawing.Size(80, 25)
        Me.BT_DEMAR.TabIndex = 0
        Me.BT_DEMAR.Text = "Démarrer"
        Me.BT_DEMAR.UseVisualStyleBackColor = True
        '
        'BT_RAZ
        '
        Me.BT_RAZ.Location = New System.Drawing.Point(155, 25)
        Me.BT_RAZ.Name = "BT_RAZ"
        Me.BT_RAZ.Size = New System.Drawing.Size(80, 25)
        Me.BT_RAZ.TabIndex = 1
        Me.BT_RAZ.Text = "Retour à 0"
        Me.BT_RAZ.UseVisualStyleBackColor = True
        '
        'PGB_TIM
        '
        Me.PGB_TIM.Location = New System.Drawing.Point(15, 65)
        Me.PGB_TIM.Name = "PGB_TIM"
        Me.PGB_TIM.Size = New System.Drawing.Size(250, 23)
        Me.PGB_TIM.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 112)
        Me.Controls.Add(Me.PGB_TIM)
        Me.Controls.Add(Me.BT_RAZ)
        Me.Controls.Add(Me.BT_DEMAR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TIM_TIM As System.Windows.Forms.Timer
    Friend WithEvents BT_DEMAR As System.Windows.Forms.Button
    Friend WithEvents BT_RAZ As System.Windows.Forms.Button
    Friend WithEvents PGB_TIM As System.Windows.Forms.ProgressBar

End Class