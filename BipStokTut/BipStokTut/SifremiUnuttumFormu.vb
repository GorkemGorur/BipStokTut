Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class SifremiUnuttumFormu
    Public KKayitNo As Guid
    Public KAdi, KSoru, KCevap As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If KCevap <> KodUret(SHA512.Create, CevapTBox.Text) Then
            MessageBox.Show("Vermiş olduğunuz cevap hatalı.", "Hata")
            Exit Sub
        End If
        If YeniSifreTBox.TextLength < 4 Then
            MessageBox.Show("Şifreniz en az 4 karakter olmalı.", "Hata")
            Exit Sub
        End If
        Dim YSifre As String = KodUret(SHA512.Create, YeniSifreTBox.Text)
        Dim TSifre As String = KodUret(SHA512.Create, SifreTekrarTBox.Text)
        If YSifre <> TSifre Then
            MessageBox.Show("Şifre tekrarı hatalı.", "Hata")
            Exit Sub
        End If
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "UPDATE KullaniciTablosu SET Sifre=@Sifre WHERE KullaniciKayitNo=@KKNo"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KKNo", SqlDbType.UniqueIdentifier).Value = KKayitNo
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = YSifre
        Try
            SqlBaglanti.Open()
            If SqlKomut.ExecuteNonQuery = 1 Then
                MessageBox.Show("Şifreniz başarı ile değiştirildi. Yeni şifreniz ile giriş yapabilirsiniz.", "Şifre Değişimi")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Güncelleme hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SifremiUnuttumFormu_Load(sender As Object, e As EventArgs) Handles Me.Load
        SoruTBox.Text = KSoru
    End Sub
End Class
