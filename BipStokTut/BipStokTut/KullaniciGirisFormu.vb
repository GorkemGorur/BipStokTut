Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Public Class KullaniciGirisFormu
    Private GirisHak As Integer = 3
    Public Adi, Sifre As String
    Public Resim As Image
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        GirisHak -= 1
        Dim KAdi As String = UsernameTextBox.Text
        Dim KSifre As String = KodUret(SHA512.Create, PasswordTextBox.Text)
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM KullaniciTablosu WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 25).Value = KAdi
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = KSifre
        Dim KTablo As New DataTable
        Try
            SqlBaglanti.Open()
            KTablo.Load(SqlKomut.ExecuteReader)
            If GirisHak >= 0 AndAlso KTablo.Rows.Count = 1 AndAlso KTablo.Rows(0)("KullaniciAdi") = KAdi Then
                Adi = KTablo.Rows(0)("KullaniciAdi")
                Sifre = KTablo.Rows(0)("Sifre")
                Try
                    Dim ResimMS As New MemoryStream
                    If ResimMS.CanWrite Then
                        Dim ByteResim() As Byte = KTablo.Rows(0)("Fotograf")
                        ResimMS.Write(ByteResim, 0, ByteResim.Count)
                    End If
                    Resim = Image.FromStream(ResimMS)
                Catch ex As Exception

                End Try
                Me.DialogResult = DialogResult.OK
                Me.Close()
            ElseIf GirisHak > 0 Then
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý.", "Hata")
            Else
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý. Program Kapatýlacak", "Hata")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Giriþ hatasý. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UnuttumLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UnuttumLinkLbl.LinkClicked
        Dim KAdi As String = UsernameTextBox.Text

        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM KullaniciTablosu WHERE KullaniciAdi=@KullaniciAdi"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 25).Value = KAdi

        Dim KTablo As New DataTable
        Try
            SqlBaglanti.Open()
            KTablo.Load(SqlKomut.ExecuteReader)
            If KTablo.Rows.Count = 1 AndAlso KTablo.Rows(0)("KullaniciAdi") = KAdi Then
                SifremiUnuttumFormu.KAdi = KTablo.Rows(0)("KullaniciAdi")
                SifremiUnuttumFormu.KSoru = KTablo.Rows(0)("Soru")
                SifremiUnuttumFormu.KCevap = KTablo.Rows(0)("Cevap")
                SifremiUnuttumFormu.KKayitNo = KTablo.Rows(0)("KullaniciKayitNo")
                SifremiUnuttumFormu.ShowDialog(Me)
            Else
                MessageBox.Show("Kullanýcý Adý Hatalý.", "Hata")
            End If
        Catch ex As Exception
            MessageBox.Show("Giriþ hatasý. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
End Class
