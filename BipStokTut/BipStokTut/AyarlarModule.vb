Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Module AyarlarModule
    Public Function SQLBaglantiCumlesi() As String
        Dim CumleOlusturucu As New SqlConnectionStringBuilder
        CumleOlusturucu.DataSource = "DESKTOP-P5BEV2M" 'Localhost\SQLEXPRESS
        CumleOlusturucu.InitialCatalog = "BipStokVT"
        CumleOlusturucu.IntegratedSecurity = False 'Express için True yapın
        CumleOlusturucu.UserID = "sa"
        CumleOlusturucu.Password = "mmyo"
        Return CumleOlusturucu.ConnectionString
    End Function
    Public Function EPostaKontrol(EPosta As String) As Boolean
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(EPosta)
        Return isValid
    End Function
    Public Function ZorunluAlanlarDolumu(Tablo As DataTable, Zorunlular() As String) As Boolean
        Dim Sonuc As Boolean = True
        For Each Satir As DataRow In Tablo.Rows
            For Each Alan As DataColumn In Tablo.Columns
                If Zorunlular.Contains(Alan.ColumnName) AndAlso IsDBNull(Satir(Alan)) Then
                    Sonuc = False
                    Return Sonuc
                End If
            Next
        Next
        Return Sonuc
    End Function
End Module
