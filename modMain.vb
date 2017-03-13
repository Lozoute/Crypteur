Imports System.IO
Module modMain

    Structure InfoCryptX
        Dim passW As String
        Dim nbFilm As Integer
        Dim indDernier As Integer
    End Structure

    Structure ListFilm
        Dim estCrypte As Boolean
        Dim nomFilm As String
        Dim nomCrypte As String
        Dim path As String
    End Structure

    Public Films() As ListFilm
    Public Info As InfoCryptX
    Public Const ficConfig As String = "c5x.cf"
    Public Const curPath As String = "CryptX_Films\"


    Function mdpOk(ByVal sender As String) As Boolean

        If Not (sender = Info.passW) Then
            MsgBox("Error PassWord")
            Exit Function
        End If

        Return True

    End Function

    Function Find_Film(ByVal nomFilm As String) As Integer
        For i As Integer = 0 To UBound(Films)
            If Films(i).estCrypte And Films(i).nomCrypte = nomFilm Then Return i
            If Not Films(i).estCrypte And Films(i).nomFilm = nomFilm Then Return i
        Next i
    End Function

    Public Sub Organize_Films(ByVal i As Integer)
        Dim tFilms(UBound(Films) - 1) As ListFilm

        For j As Integer = 0 To i - 1
            tFilms(j) = Films(j)
        Next j
        For j As Integer = i + 1 To UBound(Films)
            tFilms(j - 1) = Films(j)
        Next j

        ReDim Films(UBound(tFilms))
        Films = tFilms

    End Sub

    Public Sub Fin()
        Call Save_Data()
        End
    End Sub

    Public Sub EnCrypt(ByVal lstFilm As ListFilm)

    End Sub

    Public Sub DeCrypt(ByVal lstFilm As ListFilm)

    End Sub

    Public Sub Save_Data()

        If My.Computer.FileSystem.FileExists(ficConfig) Then
            My.Computer.FileSystem.DeleteFile(ficConfig)
        End If

        Dim nf As Integer
        nf = FreeFile()
        FileOpen(nf, ficConfig, OpenMode.Random, OpenAccess.Write)

        FilePut(nf, Info, 1)

        For i As Integer = 0 To UBound(Films)
            FilePut(nf, Films(i), i + 2)
        Next i

        FileClose(nf)

    End Sub

    Public Sub Load_Data()
        Dim nf As Integer
        nf = FreeFile()
        FileOpen(nf, ficConfig, OpenMode.Random, OpenAccess.Read)
        FileGet(nf, Info, 1)

        ReDim Preserve Films(Info.nbFilm - 1)

        For i As Integer = 2 To Info.indDernier
            FileGet(nf, Films(i - 2), i)
        Next i

        FileClose(nf)

    End Sub

    Sub main()
        Call Load_Data()
        Application.Run(frmBoot)
    End Sub
End Module
