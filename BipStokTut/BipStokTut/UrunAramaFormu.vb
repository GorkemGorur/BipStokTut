Imports System.Data.SqlClient

Public Class UrunAramaFormu
    Public UrunNo As Integer = 0
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Not IsNothing(UrunTablosuBS.Current) Then
            Dim Satir As DataRowView = UrunTablosuBS.Current
            UrunNo = Satir("UrunNo")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        UrunNo = 0
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub UrunAramaFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UrunArama()
        UrunTablosuDGV.AutoGenerateColumns = False
        NesneleriBagla()
    End Sub
    Private Sub NesneleriBagla()
        UrunTablosuDGV.DataSource = UrunTablosuBS
    End Sub
    Private Sub UrunArama(Optional UrunAdi As String = Nothing)
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT UrunNo,UrunAdi,UT.MarkaNo,UT.UrunGrupNo,UT.BirimCinsiNo,BarkodNo
        ,UretimYeri,Aciklama,MarkaAdi,UrunGrupAdi,BirimCinsi
        FROM UrunTablosu AS UT 
        INNER JOIN MarkaTablosu AS MT ON UT.MarkaNo=MT.MarkaNo
        INNER JOIN UrunGrupTablosu AS UGT ON UT.UrunGrupNo=UGT.UrunGrupNo
        INNER JOIN BirimCinsiTablosu AS BCT ON UT.BirimCinsiNo=BCT.BirimCinsiNo
        WHERE UrunAdi Like @UrunAdi"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@UrunAdi", SqlDbType.NVarChar, 45).Value = "%" & UrunAdi & "%"

        If BipStokVTDS.Tables.Contains("UrunTablosu") Then
            BipStokVTDS.Tables("UrunTablosu").Clear()
        Else
            BipStokVTDS.Tables.Add("UrunTablosu")
        End If

        Try
            SqlBaglanti.Open()
            BipStokVTDS.Tables("UrunTablosu").Load(SqlKomut.ExecuteReader)
            UrunTablosuBS.DataSource = BipStokVTDS.Tables("UrunTablosu")
        Catch ex As Exception
            MessageBox.Show("Arama hatası. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub

    Private Sub AraBtn_Click(sender As Object, e As EventArgs) Handles AraBtn.Click
        UrunArama(UrunAdiTBox.Text)
    End Sub
End Class
