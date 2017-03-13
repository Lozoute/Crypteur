Public Class frmBoot

    Private Sub btnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValid.Click
        If (mdpOk(txtMdp.Text)) Then
            Me.Hide()
            frmMain.Show()
            Exit Sub
        End If

        txtMdp.Text = ""
        txtMdp.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Call Fin()
    End Sub

    Private Sub frmPass_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtMdp.Focus()
    End Sub

    Private Sub txtMdp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMdp.KeyPress
        If Asc(e.KeyChar) = 10 Or Asc(e.KeyChar) = 13 Then
            Call btnValid_Click(sender, e)
        ElseIf Asc(e.KeyChar) = 27 Then
            Call btnExit_Click(sender, e)
        End If
    End Sub
End Class