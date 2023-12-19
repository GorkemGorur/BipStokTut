Imports System.Data.SqlClient
Public Class YeniSirketKayitFormu
    Private SirketTablosuSqlDA As SqlDataAdapter
    Private Sub YeniSirketKayitFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SirketBilgileriniGetir()
        NesneleriBagla()
    End Sub
    Private Sub SirketBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM SirketTablosu ORDER BY SirketAdi"
        SirketTablosuSqlDA = New SqlDataAdapter(Sorgu, SqlBaglanti)
        Dim KomutOlusturucu As New SqlCommandBuilder(SirketTablosuSqlDA)
        Try
            SqlBaglanti.Open()
            SirketTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            SirketTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            SirketTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand
            SirketTablosuSqlDA.Fill(BipStokVTDS, "SirketTablosu")
            SirketTablosuBS.DataSource = BipStokVTDS.Tables("SirketTablosu")
        Catch ex As Exception
            MessageBox.Show("Bağlantı hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        SirketAdiTBox.DataBindings.Add("Text", SirketTablosuBS, "SirketAdi")
        TelefonuTBox.DataBindings.Add("Text", SirketTablosuBS, "Telefonu")
        FaksTBox.DataBindings.Add("Text", SirketTablosuBS, "Faks")
        E_PostaTBox.DataBindings.Add("Text", SirketTablosuBS, "E_Posta")
        VergiTCKimlikNoTBox.DataBindings.Add("Text", SirketTablosuBS, "VergiTCKimlikNo")
        VergiDairesiTBox.DataBindings.Add("Text", SirketTablosuBS, "VergiDairesi")
        AdresiTBox.DataBindings.Add("Text", SirketTablosuBS, "Adresi")

        SirketlerDGV.AutoGenerateColumns = False
        SirketlerDGV.DataSource = SirketTablosuBS
    End Sub
    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        SirketTablosuBS.AddNew()
    End Sub
    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        If SirketTablosuBS.Count > 0 Then
            Dim Satir As DataRowView = SirketTablosuBS.Current
            Dim SirketAdi As String = Nothing
            If Not IsDBNull(Satir("SirketAdi")) Then
                SirketAdi = Satir("SirketAdi")
            End If
            Dim Mesaj As String = String.Format("{0} şirketini silmek istediğinize emin misiniz?", SirketAdi)
            Dim Sonuc As DialogResult = MessageBox.Show(Mesaj, "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Sonuc = DialogResult.Yes Then
                SirketTablosuBS.RemoveCurrent()
            End If
        End If
    End Sub
    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Me.Validate()
        SirketTablosuBS.EndEdit()
        Dim ZorunluAlanlar() As String = {"SirketAdi"}
        Try
            If ZorunluAlanlarDolumu(BipStokVTDS.Tables("SirketTablosu"), ZorunluAlanlar) Then
                If SirketTablosuSqlDA.Update(BipStokVTDS, "SirketTablosu") > 0 Then
                    Dim Pozisyon As Integer = SirketTablosuBS.Position
                    BipStokVTDS.Tables("SirketTablosu").Clear()
                    SirketTablosuSqlDA.Fill(BipStokVTDS, "SirketTablosu")
                    SirketTablosuBS.Position = Pozisyon
                    MessageBox.Show("Yapılan tüm değişiklikler başarı ile KAYDEDİLDİ.", "Kayıt İşlemi")
                End If
            Else
                MessageBox.Show("Veri girilmesi zorunlu olan bazı alanlar boş geçilmiş. Lütfen bu alanları doldurunuz.", "Kayıt İşlemi")
            End If
        Catch ex As Exception
            MessageBox.Show("Kayıt hatası. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
End Class