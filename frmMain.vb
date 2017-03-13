Imports System.IO
Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Call Fin()
    End Sub

    Private Sub btnChMdp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChMdp.Click
        Me.Hide()
        frmPassW.Show()

    End Sub

    Private Sub btnCrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrypt.Click

    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click

    End Sub

    Private Sub btnFilmList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstFilm.Items.Clear()
        For i As Integer = 0 To UBound(Films)
            If Films(i).estCrypte Then
                lstFilm.Items.Add("[Cx] " & Films(i).nomFilm)
            Else
                lstFilm.Items.Add("[--] " & Films(i).nomFilm)
            End If

        Next i
    End Sub

    Private Sub btnAj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAj.Click
        opFile.ShowDialog()
        ReDim Preserve Films(UBound(Films) + 1)

        Films(UBound(Films)).estCrypte = False
        Films(UBound(Films)).nomFilm = Path.GetFileName(opFile.FileName)
        Films(UBound(Films)).path = Path.GetDirectoryName(opFile.FileName)
        Info.nbFilm += 1
        Info.indDernier += 1
        Call frmMain_Load(sender, e)
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If lstFilm.SelectedIndex < 0 Then Exit Sub
        Dim nomFilm As String = Mid(lstFilm.Items.Item(lstFilm.SelectedIndex), 6)
        Dim i As Integer = Find_Film(nomFilm)

        If Films(i).estCrypte Then
            Call DeCrypt(Films(i))
            Call Organize_Films(i)
        Else
            Call Organize_Films(i)
        End If

        Info.nbFilm -= 1
        Info.indDernier -= 1

        Call frmMain_Load(sender, e)
    End Sub
End Class