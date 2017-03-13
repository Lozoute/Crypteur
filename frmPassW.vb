Public Class frmPassW
    Dim curPass As Boolean = True

    Private Sub btnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValid.Click
        If curPass Then
            If mdpOk(txtMdp.Text) Then
                curPass = False
                Call frmPassW_Load(sender, e)
                Exit Sub
            End If
            Call btnExit_Click(sender, e)
            Exit Sub
        End If

        If Trim(txtMdp.Text) = "" Then
            frmPassW_Load(sender, e)
            Exit Sub
        End If

        Info.passW = txtMdp.Text
        Call Save_Data()
        Call btnExit_Click(sender, e)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmPassW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not curPass Then
            Me.Text = "CryptX : ENTER NEW PASSWORD"
            btnExit.Enabled = False
        Else
            Me.Text = "CryptX : ENTER CURRENT PASSWORD"
            btnExit.Enabled = True
        End If
        txtMdp.Text = ""
        txtMdp.Focus()
    End Sub


    Private Sub frmPassW_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtMdp.Focus()
    End Sub

    Private Sub txtMdp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMdp.KeyPress
        If Asc(e.KeyChar) = 10 Or Asc(e.KeyChar) = 13 Then
            Call btnValid_Click(sender, e)
        ElseIf Asc(e.KeyChar) = 27 And curPass Then
            Call btnExit_Click(sender, e)
        End If
    End Sub
End Class