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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Quitter = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonBrowseRecalboxFolder = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.TxtRecalfolderPath = New System.Windows.Forms.TextBox()
        Me.MenuBoutons = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.ButtonOverlay = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Disclaimer = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.groupBox2.SuspendLayout()
        Me.MenuBoutons.SuspendLayout()
        Me.Disclaimer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Quitter
        '
        Me.Quitter.Font = New System.Drawing.Font("VAGRounded BT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitter.Location = New System.Drawing.Point(576, 598)
        Me.Quitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(159, 53)
        Me.Quitter.TabIndex = 13
        Me.Quitter.Text = "QUITTER"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.DimGray
        Me.groupBox2.Controls.Add(Me.ButtonBrowseRecalboxFolder)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.TxtRecalfolderPath)
        Me.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.groupBox2.Location = New System.Drawing.Point(909, 480)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox2.Size = New System.Drawing.Size(344, 112)
        Me.groupBox2.TabIndex = 12
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Configuration Initiale"
        '
        'ButtonBrowseRecalboxFolder
        '
        Me.ButtonBrowseRecalboxFolder.Font = New System.Drawing.Font("VAG Rounded", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrowseRecalboxFolder.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ButtonBrowseRecalboxFolder.Location = New System.Drawing.Point(243, 68)
        Me.ButtonBrowseRecalboxFolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonBrowseRecalboxFolder.Name = "ButtonBrowseRecalboxFolder"
        Me.ButtonBrowseRecalboxFolder.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseRecalboxFolder.TabIndex = 2
        Me.ButtonBrowseRecalboxFolder.Text = "Parcourir"
        Me.ButtonBrowseRecalboxFolder.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(25, 32)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(195, 17)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Saisir votre Dossier Recalbox"
        '
        'TxtRecalfolderPath
        '
        Me.TxtRecalfolderPath.Location = New System.Drawing.Point(28, 68)
        Me.TxtRecalfolderPath.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtRecalfolderPath.Name = "TxtRecalfolderPath"
        Me.TxtRecalfolderPath.Size = New System.Drawing.Size(191, 22)
        Me.TxtRecalfolderPath.TabIndex = 0
        '
        'MenuBoutons
        '
        Me.MenuBoutons.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.MenuBoutons.Controls.Add(Me.ButtonSave)
        Me.MenuBoutons.Controls.Add(Me.ButtonCopy)
        Me.MenuBoutons.Controls.Add(Me.ButtonOverlay)
        Me.MenuBoutons.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.MenuBoutons.Location = New System.Drawing.Point(15, 82)
        Me.MenuBoutons.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuBoutons.Name = "MenuBoutons"
        Me.MenuBoutons.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuBoutons.Size = New System.Drawing.Size(349, 570)
        Me.MenuBoutons.TabIndex = 11
        Me.MenuBoutons.TabStop = False
        Me.MenuBoutons.Text = "Faites votre Selection :"
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(11, 389)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(325, 175)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "GERER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vos Saves"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCopy.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.Location = New System.Drawing.Point(11, 22)
        Me.ButtonCopy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(325, 178)
        Me.ButtonCopy.TabIndex = 3
        Me.ButtonCopy.Text = "PREPARER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une Copie pour un Ami"
        Me.ButtonCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'ButtonOverlay
        '
        Me.ButtonOverlay.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOverlay.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonOverlay.Image = CType(resources.GetObject("ButtonOverlay.Image"), System.Drawing.Image)
        Me.ButtonOverlay.Location = New System.Drawing.Point(11, 206)
        Me.ButtonOverlay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonOverlay.Name = "ButtonOverlay"
        Me.ButtonOverlay.Size = New System.Drawing.Size(325, 178)
        Me.ButtonOverlay.TabIndex = 1
        Me.ButtonOverlay.Text = "GERER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vos Overlays Consoles et Jeux"
        Me.ButtonOverlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonOverlay.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("VAGRounded BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.Info
        Me.label2.Location = New System.Drawing.Point(21, 59)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(598, 21)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Votre gestionnaire de Roms/Overlays/Saves/Bios pour partager à vos amis"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("VAGRounded BT", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.label1.Location = New System.Drawing.Point(15, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(623, 53)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Bienvenue dans RecopierBox"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Aqua
        Me.label3.Location = New System.Drawing.Point(1142, 629)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(111, 17)
        Me.label3.TabIndex = 14
        Me.label3.Text = "v1 by Soaresden"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 25)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1223, 366)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Disclaimer
        '
        Me.Disclaimer.Controls.Add(Me.Button1)
        Me.Disclaimer.Controls.Add(Me.TextBox1)
        Me.Disclaimer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Disclaimer.Location = New System.Drawing.Point(15, 82)
        Me.Disclaimer.Margin = New System.Windows.Forms.Padding(4)
        Me.Disclaimer.Name = "Disclaimer"
        Me.Disclaimer.Padding = New System.Windows.Forms.Padding(4)
        Me.Disclaimer.Size = New System.Drawing.Size(974, 510)
        Me.Disclaimer.TabIndex = 16
        Me.Disclaimer.TabStop = False
        Me.Disclaimer.Text = "Pourquoi cet Outil ?"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(100, 420)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1095, 49)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "J'accepte que l'Outil n'effectue que des opérations sur des fichiers que je possè" &
    "de déja"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.RichTextBox1.Location = New System.Drawing.Point(965, 599)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(288, 33)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = "https://github.com/soaresden/RecopierBox"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1265, 655)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Disclaimer)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.MenuBoutons)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1283, 702)
        Me.MinimumSize = New System.Drawing.Size(1283, 702)
        Me.Name = "Form1"
        Me.Text = "Menu RecopierBox"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.MenuBoutons.ResumeLayout(False)
        Me.Disclaimer.ResumeLayout(False)
        Me.Disclaimer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Quitter As Button
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents ButtonBrowseRecalboxFolder As Button
    Private WithEvents label4 As Label
    Private WithEvents TxtRecalfolderPath As TextBox
    Private WithEvents MenuBoutons As GroupBox
    Private WithEvents ButtonSave As Button
    Private WithEvents ButtonCopy As Button
    Private WithEvents ButtonOverlay As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Disclaimer As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
