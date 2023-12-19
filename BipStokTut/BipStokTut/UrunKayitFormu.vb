Imports System.Data.SqlClient

Public Class UrunKayitFormu
    Private UrunTablosuSqlDA As SqlDataAdapter
    Private FotoPBox As New BindingPictureBox
    Private Sub UrunKayitFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FotoPBox.Location = New Point(100, 100)
        FotoPBox.Size = New Size(50, 50)
        FotoPBox.SizeMode = PictureBoxSizeMode.Zoom
        FotoPanel.Controls.Add(FotoPBox)
        FotoPBox.Dock = DockStyle.Fill
        Dim SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Try
            SQLBaglanti.Open()
            Dim Sorgu As String = "Select * From UrunTablosu"
            UrunTablosuSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)
            UrunTablosuSqlDA.Fill(BipStokVTDS, "UrunTablosu")
            UrunTablosuBS.DataSource = BipStokVTDS.Tables("UrunTablosu")

            Dim KomutOlusturucu As New SqlCommandBuilder(UrunTablosuSqlDA)
            UrunTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            UrunTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            UrunTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand

            'ListBox ve ComboBox Nesnelerinde diğer Tablolardaki verileri görüntülemek için kayıtları DataSet nesnesine yükleme
            Sorgu = "Select * From MarkaTablosu"
            Dim SqlKomutMarka As New SqlCommand(Sorgu, SQLBaglanti)
            BipStokVTDS.Tables.Add("MarkaTablosu").Load(SqlKomutMarka.ExecuteReader)
            MarkaTablosuBS.DataSource = BipStokVTDS.Tables("MarkaTablosu")

            Sorgu = "Select * From UrunGrupTablosu"
            Dim SqlKomutUrunGrup As New SqlCommand(Sorgu, SQLBaglanti)
            BipStokVTDS.Tables.Add("UrunGrupTablosu").Load(SqlKomutUrunGrup.ExecuteReader)
            UrunGrupTablosuBS.DataSource = BipStokVTDS.Tables("UrunGrupTablosu")

            Sorgu = "Select * From BirimCinsiTablosu"
            Dim SqlKomutBirimCinsi As New SqlCommand(Sorgu, SQLBaglanti)
            BipStokVTDS.Tables.Add("BirimCinsiTablosu").Load(SqlKomutBirimCinsi.ExecuteReader)
            BirimCinsiTablosuBS.DataSource = BipStokVTDS.Tables("BirimCinsiTablosu")

            'Fotograf Tablosundaki verileri görüntülemek ve UrunTablosu ile ilişki Kurmak
            Sorgu = "Select * From FotografTablosu"
            Dim SqlKomutFotograf As New SqlCommand(Sorgu, SQLBaglanti)
            BipStokVTDS.Tables.Add("FotografTablosu").Load(SqlKomutFotograf.ExecuteReader)

            'İlişki Kurma
            Dim UrunFotografiliskisi As New DataRelation("UrunFotograf",
                    BipStokVTDS.Tables("UrunTablosu").Columns("UrunNo"),
                    BipStokVTDS.Tables("FotografTablosu").Columns("UrunNo"), False)
            UrunFotografiliskisi.Nested = False
            BipStokVTDS.Relations.Add(UrunFotografiliskisi)

            FotografTablosuBS.DataSource = UrunTablosuBS 'İlişkisi olan BindingSource
            FotografTablosuBS.DataMember = "UrunFotograf" 'İlişkinin adı

            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Bağlantı hatası. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        UrunAdiTbox.DataBindings.Add("Text", UrunTablosuBS, "UrunAdi")
        BarkodNoTBox.DataBindings.Add("Text", UrunTablosuBS, "BarkodNo")
        UretimYeriTBox.DataBindings.Add("Text", UrunTablosuBS, "UretimYeri")
        AciklamaTBox.DataBindings.Add("Text", UrunTablosuBS, "Aciklama")
        'ListBox ve ComboBox nesnelerini başka tablolar ile bağlama
        MarkaNoCBox.DataSource = MarkaTablosuBS
        MarkaNoCBox.DisplayMember = "MarkaAdi" 'Kullanıcının listede görmesini istediğimiz alan
        MarkaNoCBox.ValueMember = "MarkaNo" 'UrunTablosu ile ilişkili olan alan
        MarkaNoCBox.DataBindings.Add("SelectedValue", UrunTablosuBS, "MarkaNo") 'urun tablosundaki alan ile bağlıyoruz

        UrunGrupNoLBox.DataSource = UrunGrupTablosuBS
        UrunGrupNoLBox.DisplayMember = "UrunGrupAdi"
        UrunGrupNoLBox.ValueMember = "UrunGrupNo"
        UrunGrupNoLBox.DataBindings.Add("SelectedValue", UrunTablosuBS, "UrunGrupNo")

        BirimCinsiNoCBox.DataSource = BirimCinsiTablosuBS
        BirimCinsiNoCBox.DisplayMember = "BirimCinsi"
        BirimCinsiNoCBox.ValueMember = "BirimCinsiNo"
        BirimCinsiNoCBox.DataBindings.Add("SelectedValue", UrunTablosuBS, "BirimCinsiNo")

        'DataGridView de ComboBox kolonlarını başka tablolar ile bağlama
        MarkaNoC.DataSource = MarkaTablosuBS
        MarkaNoC.DisplayMember = "MarkaAdi" 'Kullanıcının listede görmesini istediğimiz alan
        MarkaNoC.ValueMember = "MarkaNo" 'UrunTablosu ile ilişkili olan alan
        MarkaNoC.DataPropertyName = "MarkaNo" 'urun tablosundaki alan ile bağlıyoruz

        UrunGrupNoC.DataSource = UrunGrupTablosuBS
        UrunGrupNoC.DisplayMember = "UrunGrupAdi"
        UrunGrupNoC.ValueMember = "UrunGrupNo"
        UrunGrupNoC.DataPropertyName = "UrunGrupNo"

        BirimCinsiNoC.DataSource = BirimCinsiTablosuBS
        BirimCinsiNoC.DisplayMember = "BirimCinsi"
        BirimCinsiNoC.ValueMember = "BirimCinsiNo"
        BirimCinsiNoC.DataPropertyName = "BirimCinsiNo"

        UrunNoC.DataPropertyName = "UrunNo"
        UrunAdiC.DataPropertyName = "UrunAdi"
        BarkodNoC.DataPropertyName = "BarkodNo"
        UretimYeriC.DataPropertyName = "UretimYeri"
        AciklamaC.DataPropertyName = "Aciklama"

        UrunlerDGV.DataSource = UrunTablosuBS
        'İlişkili tabloda fotograf alanını bağlama
        'FotografPBox.DataBindings.Add("Image", FotografTablosuBS, "Fotograf", True)
        FotoPBox.DataBindings.Add("ImagePath", FotografTablosuBS, "Fotograf")

    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        UrunTablosuBS.AddNew()
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        If UrunTablosuBS.Count > 0 Then
            Dim Satir As DataRowView = UrunTablosuBS.Current
            Dim UrunAdi As String = Nothing
            If Not IsDBNull(Satir("UrunAdi")) Then
                UrunAdi = Satir("UrunAdi")
            End If
            Dim Mesaj As String = String.Format("{0} ürününü silmek istediğinize emin misiniz?", UrunAdi)
            Dim Sonuc As DialogResult = MessageBox.Show(Mesaj, "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Sonuc = DialogResult.Yes Then
                UrunTablosuBS.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Me.Validate()
        UrunTablosuBS.EndEdit()
        Dim ZorunluAlanlar() As String = {"UrunAdi", "MarkaNo", "UrunGrupNo", "BirimCinsiNo"}
        Try
            If ZorunluAlanlarDolumu(BipStokVTDS.Tables("UrunTablosu"), ZorunluAlanlar) Then
                If UrunTablosuSqlDA.Update(BipStokVTDS, "UrunTablosu") > 0 Then
                    Dim Pozisyon As Integer = UrunTablosuBS.Position
                    BipStokVTDS.Tables("UrunTablosu").Clear()
                    UrunTablosuSqlDA.Fill(BipStokVTDS, "UrunTablosu")
                    UrunTablosuBS.Position = Pozisyon
                    MessageBox.Show("Yapılan tüm değişiklikler başarı ile KAYDEDİLDİ.", "Kayıt İşlemi")
                End If
            Else
                MessageBox.Show("Veri girilmesi zorunlu olan bazı alanlar boş geçilmiş. Lütfen bu alanları doldurunuz.", "Kayıt İşlemi")
            End If
        Catch ex As Exception
            MessageBox.Show("Kayıt hatası. Hata: " & ex.Message, "Hata")
        End Try
    End Sub

    Private Sub ilkKayitBtn_Click(sender As Object, e As EventArgs) Handles ilkKayitBtn.Click
        UrunTablosuBS.MoveFirst()
    End Sub

    Private Sub OncekiKayitBtn_Click(sender As Object, e As EventArgs) Handles OncekiKayitBtn.Click
        UrunTablosuBS.MovePrevious()
    End Sub

    Private Sub SonrakiKayitBtn_Click(sender As Object, e As EventArgs) Handles SonrakiKayitBtn.Click
        UrunTablosuBS.MoveNext()
    End Sub

    Private Sub SonKayitBtn_Click(sender As Object, e As EventArgs) Handles SonKayitBtn.Click
        UrunTablosuBS.MoveLast()
    End Sub

    Private Sub UrunTablosuBS_PositionChanged(sender As Object, e As EventArgs) Handles UrunTablosuBS.PositionChanged
        ilkKayitBtn.Enabled = True
        OncekiKayitBtn.Enabled = True
        SonrakiKayitBtn.Enabled = True
        SonKayitBtn.Enabled = True
        If UrunTablosuBS.Position = 0 Then
            ilkKayitBtn.Enabled = False
            OncekiKayitBtn.Enabled = False
        End If
        If UrunTablosuBS.Position = UrunTablosuBS.Count - 1 Then
            SonKayitBtn.Enabled = False
            SonrakiKayitBtn.Enabled = False
        End If

    End Sub

    Private Sub OncekiResimBtn_Click(sender As Object, e As EventArgs) Handles OncekiResimBtn.Click
        FotografTablosuBS.MovePrevious()
    End Sub

    Private Sub SonrakiResimBtn_Click(sender As Object, e As EventArgs) Handles SonrakiResimBtn.Click
        FotografTablosuBS.MoveNext()
    End Sub

    Private Sub FotografEkleBtn_Click(sender As Object, e As EventArgs) Handles FotografEkleBtn.Click
        Dim Satir As DataRowView = UrunTablosuBS.Current
        If IsNumeric(Satir("UrunNo")) Then
            Dim UrunNo As Integer = Satir("UrunNo")
            Dim FotografSec As New OpenFileDialog
            FotografSec.Multiselect = True
            FotografSec.CheckFileExists = True
            FotografSec.Filter = "JPEG Dosyalar|*.jpg;*.jpeg|PNG Dosyaları|*.png"
            If FotografSec.ShowDialog = DialogResult.OK Then
                Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
                Dim Sorgu As String = "Insert Into FotografTablosu (Fotograf,UrunNo) Values (@Fotograf,@UrunNo)"
                Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
                SqlKomut.Parameters.Add("@Fotograf", SqlDbType.NVarChar, 75)
                SqlKomut.Parameters.Add("@UrunNo", SqlDbType.Int)
                For Each Dosya As String In FotografSec.FileNames
                    Dim DosyaAdi As String = DosyaKopyala(Dosya)
                    MsgBox(DosyaAdi)
                Next
            End If
        Else
            MessageBox.Show("Ürün henüz kaydedilmemiş, öncelikle KAYDET'e basarak ürünü kaydediniz", "Hata")
        End If
    End Sub
    Private Function DosyaKopyala(Kaynak As String) As String
        Dim DosyaAdi As String = Nothing
        Dim KaynakDosya As New IO.FileInfo(Kaynak)
        If KaynakDosya.Exists Then
            Dim Ad As String = IO.Path.GetFileNameWithoutExtension(KaynakDosya.Name)
            Dim Uzanti As String = KaynakDosya.Extension
            Dim Hedef As String = "UrunFoto\" & Ad & Uzanti
            Dim HedefDosya As New IO.FileInfo(Hedef)
            Dim Sayac As Integer = 1
            Do While HedefDosya.Exists
                Hedef = "UrunFoto\" & Ad & "(" & Sayac & ")" & Uzanti
                HedefDosya = New IO.FileInfo(Hedef)
            Loop
            KaynakDosya.CopyTo(HedefDosya.FullName)
            DosyaAdi = "UrunFoto\" & HedefDosya.Name
        End If
        Return DosyaAdi
    End Function
End Class