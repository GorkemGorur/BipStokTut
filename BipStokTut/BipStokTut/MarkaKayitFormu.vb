Imports System.Data.SqlClient

Public Class MarkaKayitFormu
    Private MarkaTablosuSqlDA As SqlDataAdapter
    Private Sub MarkaKayitFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi) 'SQLBaglantiCumlesi Ayarlar Module' deki Fonksiyon Adı
        Try
            SQLBaglanti.Open() 'Bağlantıyı Aç
            'MarkaTablosundaki kayıtları okuma
            Dim Sorgu As String = "Select * From MarkaTablosu"
            MarkaTablosuSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)
            MarkaTablosuSqlDA.Fill(BipStokVTDS, "MarkaTablosu") 'MarkaTablosundaki kayıtlar dataSet üzerine gene MarkaTablosu ismi ile aktarıldı
            MarkaTablosuBS.DataSource = BipStokVTDS.Tables("MarkaTablosu")
            'Eğer Form üzerinde kayıt ekleme,düzenleme veya silme işlemleri yapılacaksa
            'Buradaki kodları yazmalıyız. Bu işlemler yapılmayacaksa bu kodları yazmaya gerek yoktur
            Dim KomutOlusturucu As New SqlCommandBuilder(MarkaTablosuSqlDA)
            MarkaTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            MarkaTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            MarkaTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand
            '*************************************************************
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Bağlantı hatası. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close() 'Bağlantıyı Kapat
        End Try
    End Sub
    Private Sub NesneleriBagla()
        'MarkaAdiTBox.DataBindings.Clear()
        MarkaAdiTBox.DataBindings.Add("Text", MarkaTablosuBS, "MarkaAdi")
        'DataGridView nesnesini tablo ile bağlama
        MarkaNoC.DataPropertyName = "MarkaNo" 'Kolonu Tablodaki Alan ile eşleştir
        MarkaAdiC.DataPropertyName = "MarkaAdi"
        MarkaTablosuDGV.DataSource = MarkaTablosuBS 'DataGridView ile Marka Tablosu bağlanır
    End Sub

    Private Sub MarkaKayitFormu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        MarkaTablosuBS.AddNew()
        MarkaAdiTBox.ReadOnly = False
    End Sub

    Private Sub DuzenleBtn_Click(sender As Object, e As EventArgs) Handles DuzenleBtn.Click
        MarkaAdiTBox.ReadOnly = False
    End Sub

    Private Sub MarkaTablosuBS_PositionChanged(sender As Object, e As EventArgs) Handles MarkaTablosuBS.PositionChanged
        MarkaAdiTBox.ReadOnly = True
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        If MarkaTablosuDGV.SelectedRows.Count = 1 Then
            Dim SatirDGV As DataGridViewRow = MarkaTablosuDGV.SelectedRows(0)
            Dim Adi As String = Nothing
            If Not IsDBNull(SatirDGV.Cells("MarkaAdiC").Value) Then
                Adi = SatirDGV.Cells("MarkaAdiC").Value
            End If
            Dim Mesaj As String = String.Format("{0} markasını silmek istediğinize emin misiniz?", Adi)
                If MessageBox.Show(Mesaj, "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    MarkaTablosuBS.RemoveCurrent()
                End If
            End If
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Me.Validate()
        MarkaTablosuBS.EndEdit()
        Try
            If MarkaTablosuSqlDA.Update(BipStokVTDS, "MarkaTablosu") > 0 Then
                MessageBox.Show("Yapılan tüm değişiklikler başarı ile KAYDEDİLDİ.", "Kayıt İşlemi")
                MarkaAdiTBox.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("Kayıt hatası. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
End Class
