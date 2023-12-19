Imports System.Data.SqlClient
Public Class StokGirisFormu
    Private StokGelenFaturaSqlDA As SqlDataAdapter
    Private Sub StokGirisFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StokGelenFaturaBilgileriniGetir()
        SirketBilgileriniGetir()
        StokGirisDetayBilgileriniGetir()
        NesneleriBagla()
    End Sub
    Private Sub StokGelenFaturaBilgileriniGetir(Optional FaturaNo As Integer = 0)
        Dim FaturaNoDegeri As String = "%%"
        If FaturaNo > 0 Then
            FaturaNoDegeri = FaturaNo
        End If
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM StokGelenFaturaTablosu WHERE FaturaKayitNo Like @FaturaKayitNo"
        StokGelenFaturaSqlDA = New SqlDataAdapter(Sorgu, SqlBaglanti)
        StokGelenFaturaSqlDA.SelectCommand.Parameters.Add("@FaturaKayitNo", SqlDbType.NVarChar).Value = FaturaNoDegeri
        Dim KomutOlusturucu As New SqlCommandBuilder(StokGelenFaturaSqlDA)
        Try
            SqlBaglanti.Open()
            StokGelenFaturaSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            StokGelenFaturaSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            StokGelenFaturaSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand
            StokGelenFaturaSqlDA.Fill(BipStokVTDS, "StokGelenFaturaTablosu")
            StokGelenFaturaTablosuBS.DataSource = BipStokVTDS.Tables("StokGelenFaturaTablosu")
        Catch ex As Exception
            MessageBox.Show("Bağlantı hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub SirketBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM SirketTablosu ORDER BY SirketAdi"
        Dim SirketTablosuSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)

        Try
            SqlBaglanti.Open()

            SirketTablosuSqlDA.Fill(BipStokVTDS, "SirketTablosu")
            SirketTablosuBS.DataSource = BipStokVTDS.Tables("SirketTablosu")
        Catch ex As Exception
            MessageBox.Show("Bağlantı hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub StokGirisDetayBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT UrunAdi,BirimCinsi,SGDT.* 
FROM StokGirisDetayTablosu AS SGDT 
INNER JOIN UrunTablosu AS UT ON SGDT.UrunNo=UT.UrunNo 
INNER JOIN BirimCinsiTablosu AS BCT ON UT.BirimCinsiNo=BCT.BirimCinsiNo"
        Dim StokGirisDetaySqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)

        Try
            SqlBaglanti.Open()
            StokGirisDetaySqlDA.Fill(BipStokVTDS, "StokGirisDetayTablosu")

            Dim ToplamAlan As New DataColumn()
            ToplamAlan.ColumnName = "Toplam"
            ToplamAlan.DataType = GetType(Double)
            ToplamAlan.Expression = "Adet * Fiyat"
            BipStokVTDS.Tables("StokGirisDetayTablosu").Columns.Add(ToplamAlan)

            Dim FaturaDetayRelation As New DataRelation("FaturaDetay",
                    BipStokVTDS.Tables("StokGelenFaturaTablosu").Columns("FaturaKayitNo"),
                    BipStokVTDS.Tables("StokGirisDetayTablosu").Columns("FaturaKayitNo"), False)
            FaturaDetayRelation.Nested = False
            BipStokVTDS.Relations.Add(FaturaDetayRelation)


            'StokGirisDetayTablosuBS.DataSource = BipStokVTDS.Tables("StokGirisDetayTablosu")
            StokGirisDetayTablosuBS.DataSource = StokGelenFaturaTablosuBS
            StokGirisDetayTablosuBS.DataMember = "FaturaDetay"
        Catch ex As Exception
            MessageBox.Show("Bağlantı hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        FaturaNoTBox.DataBindings.Add("Text", StokGelenFaturaTablosuBS, "FaturaNo")
        FaturaTarihiDTP.DataBindings.Add("Value", StokGelenFaturaTablosuBS, "FaturaTarihi", True)
        SirketNoCBox.DataBindings.Add("SelectedValue", StokGelenFaturaTablosuBS, "SirketNo")

        SirketNoCBox.DisplayMember = "SirketAdi"
        SirketNoCBox.ValueMember = "SirketNo"
        SirketNoCBox.DataSource = SirketTablosuBS

        TelefonuTBox.DataBindings.Add("Text", SirketTablosuBS, "Telefonu")
        VergiTCKimlikNoTBox.DataBindings.Add("Text", SirketTablosuBS, "VergiTCKimlikNo")
        VergiDairesiTBox.DataBindings.Add("Text", SirketTablosuBS, "VergiDairesi")
        AdresiTBox.DataBindings.Add("Text", SirketTablosuBS, "Adresi")

        StokGirisDetayDGV.AutoGenerateColumns = False
        StokGirisDetayDGV.DataSource = StokGirisDetayTablosuBS
    End Sub

    Private Sub OncekiKayitBtn_Click(sender As Object, e As EventArgs) Handles OncekiKayitBtn.Click
        StokGelenFaturaTablosuBS.MovePrevious()
    End Sub

    Private Sub SonrakiKayitBtn_Click(sender As Object, e As EventArgs) Handles SonrakiKayitBtn.Click
        StokGelenFaturaTablosuBS.MoveNext()
    End Sub

    Private Sub YazdirBtn_Click(sender As Object, e As EventArgs) Handles YazdirBtn.Click
        Dim Satir As DataRowView = StokGelenFaturaTablosuBS.Current
        If Not IsDBNull(Satir("FaturaKayitNo")) Then
            StokGirisFisiFormu.FaturaKayitNo = Satir("FaturaKayitNo")
            StokGirisFisiFormu.ShowDialog()
        End If
    End Sub
End Class