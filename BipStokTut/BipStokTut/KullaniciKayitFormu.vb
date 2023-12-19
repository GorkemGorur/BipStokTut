Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Public Class KullaniciKayitFormu

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KullaniciEkleBtn.Click
        Dim KAdi As String = AdTBox.Text
        Dim KSifre As String = SifreTBox.Text
        Dim Tekrar As String = TekrarTBox.Text.Trim
        Dim Soru As String = SoruTBox.Text.Trim
        Dim Cevap As String = CevapTBox.Text.Trim
        Dim EPosta As String = EPostaTBox.Text.Trim
        If KAdi.Length = 0 Or KSifre.Length = 0 Then
            MessageBox.Show("Kullanıcı adı veya şifre bilgisi bulunamadı.", "Hata")
            Exit Sub
        End If
        KSifre = KodUret(SHA512.Create, KSifre)
        Tekrar = KodUret(SHA512.Create, Tekrar)
        If KSifre <> Tekrar Then
            MessageBox.Show("Şifre tekrarı hatalı. Lütfen kontrol ediniz.", "Hata")
            Exit Sub
        End If
        If Soru.Length < 2 Or Cevap.Length < 2 Then
            MessageBox.Show("Soru ve Cevap en az iki karakter olmalıdır.", "Hata")
            Exit Sub
        End If
        If Not EPostaKontrol(EPosta) Then
            MessageBox.Show("E-Posta adresiniz hatalı. Lütfen kontrol ediniz.", "Hata")
            Exit Sub
        End If
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "INSERT INTO KullaniciTablosu 
        (KullaniciAdi,Sifre,Soru,Cevap,E_Posta,Fotograf) VALUES 
        (@KullaniciAdi,@Sifre,@Soru,@Cevap,@E_Posta,@Fotograf)"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 25).Value = KAdi
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = KSifre
        SqlKomut.Parameters.Add("@Soru", SqlDbType.NVarChar, 35).Value = Soru
        SqlKomut.Parameters.Add("@Cevap", SqlDbType.NVarChar, 128).Value = Cevap
        SqlKomut.Parameters.Add("@E_Posta", SqlDbType.NVarChar, 40).Value = EPosta
        SqlKomut.Parameters.Add("@Fotograf", SqlDbType.VarBinary)
        Dim ResimMS As New MemoryStream
        If Not IsNothing(ResimPBox.Image) Then
            ResimPBox.Image.Save(ResimMS, Imaging.ImageFormat.Jpeg) 'ResimPBox.Image.RawFormat)
        End If
        SqlKomut.Parameters("@Fotograf").Value = ResimMS.ToArray
        Try
            SqlBaglanti.Open()
            If SqlKomut.ExecuteNonQuery = 1 Then
                MessageBox.Show("Kullanıcı başarı ile eklendi. Bu kullanıcı ile giriş yapılabilir", "Kullanıcı Ekleme")
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AdTBox_Validating(sender As Object, e As CancelEventArgs) Handles AdTBox.Validating
        Dim KAdi As String = AdTBox.Text
        If KAdi.Length < 3 Or KAdi.IndexOf(" ") <> -1 Then
            MessageBox.Show("Kullanıcı adı en az 3 karakter olmalı ve boşluk karakteri içermemelidir.", "Hata")
            AdTBox.Focus()
            Exit Sub
        End If
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT KullaniciAdi FROM KullaniciTablosu WHERE KullaniciAdi=@KullaniciAdi"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 25).Value = KAdi
        Dim KTablo As New DataTable
        Try
            SqlBaglanti.Open()
            KTablo.Load(SqlKomut.ExecuteReader)
            If KTablo.Rows.Count > 0 Then
                MessageBox.Show("Bu kullanıcı adı kayıtlı. Başka bir kullanıcı adı deneyiniz", "Hata")
                AdTBox.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub SifreTBox_Validating(sender As Object, e As CancelEventArgs) Handles SifreTBox.Validating
        Dim KSifre As String = SifreTBox.Text
        If KSifre.Length < 4 Or KSifre.IndexOf(" ") <> -1 Then
            MessageBox.Show("Şifre en az 4 karakter olmalı ve boşluk karakteri içermemelidir.", "Hata")
            SifreTBox.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub KullaniciKayitFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdTBox.Focus()
    End Sub

    Private Sub ResimEkleBtn_Click(sender As Object, e As EventArgs) Handles ResimEkleBtn.Click
        ResimOFD.FileName = Nothing
        ResimOFD.Filter = "JPG Resimler|*.jpg;*.jpeg|PNG Resimler|*.png|BMP Resimler|*.bmp"
        ResimOFD.FilterIndex = 1
        If ResimOFD.ShowDialog = DialogResult.OK Then
            ResimPBox.Image = Image.FromFile(ResimOFD.FileName)
        End If
    End Sub
End Class
