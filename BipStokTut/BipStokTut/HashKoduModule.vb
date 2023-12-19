Imports System.Security.Cryptography
Imports System.Text
Module HashKoduModule
    Public Function KodUret(Algoritma As HashAlgorithm, Metin As String) As String
        Dim Sonuc As String = Nothing
        Dim ByteMetin() As Byte = Encoding.UTF8.GetBytes(Metin)
        Dim ByteSonuc() As Byte = Algoritma.ComputeHash(ByteMetin)
        For Each Eleman As Byte In ByteSonuc
            Sonuc &= Eleman.ToString("x2")
        Next
        Return Sonuc
    End Function

End Module
