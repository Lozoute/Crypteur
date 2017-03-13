<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnChMdp = New System.Windows.Forms.Button
        Me.btnCrypt = New System.Windows.Forms.Button
        Me.btnDecrypt = New System.Windows.Forms.Button
        Me.lstFilm = New System.Windows.Forms.CheckedListBox
        Me.gbxLst = New System.Windows.Forms.GroupBox
        Me.btnView = New System.Windows.Forms.Button
        Me.btnGat = New System.Windows.Forms.Button
        Me.btnSupF = New System.Windows.Forms.Button
        Me.btnAj = New System.Windows.Forms.Button
        Me.btnSup = New System.Windows.Forms.Button
        Me.gbxCrypt = New System.Windows.Forms.GroupBox
        Me.opFile = New System.Windows.Forms.OpenFileDialog
        Me.gbxLst.SuspendLayout()
        Me.gbxCrypt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Location = New System.Drawing.Point(320, 513)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "ExiT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnChMdp
        '
        Me.btnChMdp.BackColor = System.Drawing.Color.Transparent
        Me.btnChMdp.FlatAppearance.BorderSize = 0
        Me.btnChMdp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChMdp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnChMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChMdp.Location = New System.Drawing.Point(259, 34)
        Me.btnChMdp.Name = "btnChMdp"
        Me.btnChMdp.Size = New System.Drawing.Size(141, 23)
        Me.btnChMdp.TabIndex = 2
        Me.btnChMdp.Text = "Change PassWord"
        Me.btnChMdp.UseVisualStyleBackColor = False
        '
        'btnCrypt
        '
        Me.btnCrypt.BackColor = System.Drawing.Color.Transparent
        Me.btnCrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrypt.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrypt.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnCrypt.Location = New System.Drawing.Point(6, 35)
        Me.btnCrypt.Name = "btnCrypt"
        Me.btnCrypt.Size = New System.Drawing.Size(72, 27)
        Me.btnCrypt.TabIndex = 4
        Me.btnCrypt.Text = "EnCrypt"
        Me.btnCrypt.UseVisualStyleBackColor = False
        '
        'btnDecrypt
        '
        Me.btnDecrypt.BackColor = System.Drawing.Color.Transparent
        Me.btnDecrypt.FlatAppearance.BorderSize = 0
        Me.btnDecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrypt.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(581, 35)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(72, 27)
        Me.btnDecrypt.TabIndex = 5
        Me.btnDecrypt.Text = "DeCrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = False
        '
        'lstFilm
        '
        Me.lstFilm.FormattingEnabled = True
        Me.lstFilm.Location = New System.Drawing.Point(18, 19)
        Me.lstFilm.Name = "lstFilm"
        Me.lstFilm.Size = New System.Drawing.Size(227, 304)
        Me.lstFilm.TabIndex = 6
        '
        'gbxLst
        '
        Me.gbxLst.Controls.Add(Me.btnView)
        Me.gbxLst.Controls.Add(Me.btnGat)
        Me.gbxLst.Controls.Add(Me.btnSupF)
        Me.gbxLst.Controls.Add(Me.btnAj)
        Me.gbxLst.Controls.Add(Me.btnSup)
        Me.gbxLst.Controls.Add(Me.lstFilm)
        Me.gbxLst.Location = New System.Drawing.Point(12, 12)
        Me.gbxLst.Name = "gbxLst"
        Me.gbxLst.Size = New System.Drawing.Size(659, 338)
        Me.gbxLst.TabIndex = 7
        Me.gbxLst.TabStop = False
        Me.gbxLst.Text = "Films"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnView.Location = New System.Drawing.Point(567, 265)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(85, 27)
        Me.btnView.TabIndex = 11
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnGat
        '
        Me.btnGat.BackColor = System.Drawing.Color.Transparent
        Me.btnGat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGat.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnGat.Location = New System.Drawing.Point(259, 257)
        Me.btnGat.Name = "btnGat"
        Me.btnGat.Size = New System.Drawing.Size(135, 42)
        Me.btnGat.TabIndex = 10
        Me.btnGat.Text = "Gather Cur Dir"
        Me.btnGat.UseVisualStyleBackColor = False
        '
        'btnSupF
        '
        Me.btnSupF.BackColor = System.Drawing.Color.Transparent
        Me.btnSupF.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSupF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSupF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSupF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupF.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSupF.Location = New System.Drawing.Point(536, 42)
        Me.btnSupF.Name = "btnSupF"
        Me.btnSupF.Size = New System.Drawing.Size(116, 27)
        Me.btnSupF.TabIndex = 9
        Me.btnSupF.Text = "Delete NTFS"
        Me.btnSupF.UseVisualStyleBackColor = False
        '
        'btnAj
        '
        Me.btnAj.BackColor = System.Drawing.Color.Transparent
        Me.btnAj.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAj.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAj.Location = New System.Drawing.Point(259, 42)
        Me.btnAj.Name = "btnAj"
        Me.btnAj.Size = New System.Drawing.Size(85, 27)
        Me.btnAj.TabIndex = 8
        Me.btnAj.Text = "Add Film"
        Me.btnAj.UseVisualStyleBackColor = False
        '
        'btnSup
        '
        Me.btnSup.BackColor = System.Drawing.Color.Transparent
        Me.btnSup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSup.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSup.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSup.Location = New System.Drawing.Point(382, 42)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(116, 27)
        Me.btnSup.TabIndex = 7
        Me.btnSup.Text = "Delete List"
        Me.btnSup.UseVisualStyleBackColor = False
        '
        'gbxCrypt
        '
        Me.gbxCrypt.Controls.Add(Me.btnDecrypt)
        Me.gbxCrypt.Controls.Add(Me.btnCrypt)
        Me.gbxCrypt.Controls.Add(Me.btnChMdp)
        Me.gbxCrypt.Location = New System.Drawing.Point(12, 356)
        Me.gbxCrypt.Name = "gbxCrypt"
        Me.gbxCrypt.Size = New System.Drawing.Size(659, 90)
        Me.gbxCrypt.TabIndex = 9
        Me.gbxCrypt.TabStop = False
        Me.gbxCrypt.Text = "Action"
        '
        'opFile
        '
        Me.opFile.Filter = "Video File | *.avi; *.mkv; *.wmv; *.mov; *.rv; *.rm; *.qt; *.ogm; *.m4a; *.m3u; *" & _
            ".mp4; *.mpe; *.mpg; *.mpeg; *.divx"
        Me.opFile.RestoreDirectory = True
        Me.opFile.Title = "Add Film To List"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(686, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxCrypt)
        Me.Controls.Add(Me.gbxLst)
        Me.Controls.Add(Me.btnExit)
        Me.ForeColor = System.Drawing.Color.RoyalBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "CrypTx"
        Me.gbxLst.ResumeLayout(False)
        Me.gbxCrypt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnChMdp As System.Windows.Forms.Button
    Friend WithEvents btnCrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents lstFilm As System.Windows.Forms.CheckedListBox
    Friend WithEvents gbxLst As System.Windows.Forms.GroupBox
    Friend WithEvents btnAj As System.Windows.Forms.Button
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents btnSupF As System.Windows.Forms.Button
    Friend WithEvents btnGat As System.Windows.Forms.Button
    Friend WithEvents gbxCrypt As System.Windows.Forms.GroupBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents opFile As System.Windows.Forms.OpenFileDialog
End Class
