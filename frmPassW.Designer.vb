<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassW
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtMdp = New System.Windows.Forms.TextBox
        Me.gbxBtn = New System.Windows.Forms.GroupBox
        Me.btnValid = New System.Windows.Forms.Button
        Me.gbxTxt = New System.Windows.Forms.GroupBox
        Me.lblMdp = New System.Windows.Forms.Label
        Me.gbxBtn.SuspendLayout()
        Me.gbxTxt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(6, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(63, 27)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Cancel"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtMdp
        '
        Me.txtMdp.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdp.ForeColor = System.Drawing.Color.Black
        Me.txtMdp.Location = New System.Drawing.Point(75, 26)
        Me.txtMdp.MaxLength = 20
        Me.txtMdp.Name = "txtMdp"
        Me.txtMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMdp.Size = New System.Drawing.Size(164, 18)
        Me.txtMdp.TabIndex = 1
        Me.txtMdp.UseSystemPasswordChar = True
        '
        'gbxBtn
        '
        Me.gbxBtn.BackColor = System.Drawing.Color.Transparent
        Me.gbxBtn.Controls.Add(Me.btnExit)
        Me.gbxBtn.Controls.Add(Me.btnValid)
        Me.gbxBtn.ForeColor = System.Drawing.Color.Red
        Me.gbxBtn.Location = New System.Drawing.Point(11, 72)
        Me.gbxBtn.Name = "gbxBtn"
        Me.gbxBtn.Size = New System.Drawing.Size(250, 52)
        Me.gbxBtn.TabIndex = 6
        Me.gbxBtn.TabStop = False
        '
        'btnValid
        '
        Me.btnValid.BackColor = System.Drawing.Color.Black
        Me.btnValid.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnValid.FlatAppearance.BorderSize = 0
        Me.btnValid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnValid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnValid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValid.ForeColor = System.Drawing.Color.Red
        Me.btnValid.Location = New System.Drawing.Point(181, 19)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(63, 27)
        Me.btnValid.TabIndex = 3
        Me.btnValid.Text = "Go !"
        Me.btnValid.UseVisualStyleBackColor = False
        '
        'gbxTxt
        '
        Me.gbxTxt.Controls.Add(Me.txtMdp)
        Me.gbxTxt.Controls.Add(Me.lblMdp)
        Me.gbxTxt.Location = New System.Drawing.Point(11, 9)
        Me.gbxTxt.Name = "gbxTxt"
        Me.gbxTxt.Size = New System.Drawing.Size(250, 57)
        Me.gbxTxt.TabIndex = 7
        Me.gbxTxt.TabStop = False
        '
        'lblMdp
        '
        Me.lblMdp.AutoSize = True
        Me.lblMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdp.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMdp.Location = New System.Drawing.Point(6, 25)
        Me.lblMdp.Name = "lblMdp"
        Me.lblMdp.Size = New System.Drawing.Size(63, 15)
        Me.lblMdp.TabIndex = 2
        Me.lblMdp.Text = "PassWord"
        '
        'frmPassW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(273, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxBtn)
        Me.Controls.Add(Me.gbxTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPassW"
        Me.ShowInTaskbar = False
        Me.Text = "CryptX :  ENTER CURRENT PASSWORD"
        Me.gbxBtn.ResumeLayout(False)
        Me.gbxTxt.ResumeLayout(False)
        Me.gbxTxt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtMdp As System.Windows.Forms.TextBox
    Friend WithEvents gbxBtn As System.Windows.Forms.GroupBox
    Friend WithEvents btnValid As System.Windows.Forms.Button
    Friend WithEvents gbxTxt As System.Windows.Forms.GroupBox
    Friend WithEvents lblMdp As System.Windows.Forms.Label
End Class
