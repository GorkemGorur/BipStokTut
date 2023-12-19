Public Class AnaForm
    Private Kapat As Boolean = False
    Public KAdi, KSifre As String
    Public Resim As Image
    Public Sub New()
        Dim KGirisFormu As New KullaniciGirisFormu
        If KGirisFormu.ShowDialog <> DialogResult.OK Then
            KAdi = KGirisFormu.Adi
            KSifre = KGirisFormu.Sifre
            Resim = KGirisFormu.Resim
            Kapat = True
        End If
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Kapat Then
            Me.Close()
            Exit Sub
        End If
        ResimPBox.Image = Resim
        'Application title
        If My.Application.Info.Title <> "" Then
            Me.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            Me.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
    End Sub

    Private Sub ProgramıKapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramıKapatToolStripMenuItem.Click
        Me.Close()
        'Application.Exit()
    End Sub

    Private Sub MarkaKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkaKaydıToolStripMenuItem.Click
        MarkaKayitFormu.ShowDialog(Me)
    End Sub

    Private Sub ÜrünKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünKaydıToolStripMenuItem.Click
        UrunKayitFormu.MdiParent = Me
        UrunKayitFormu.Show()
        UrunKayitFormu.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ÜrünAramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünAramaToolStripMenuItem.Click
        UrunAramaFormu.ShowDialog(Me)
        UrunAramaFormu.Dispose()
    End Sub

    Private Sub YeniŞirketKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniŞirketKaydıToolStripMenuItem.Click
        YeniSirketKayitFormu.ShowDialog(Me)
    End Sub

    Private Sub StokGirişiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokGirişiToolStripMenuItem.Click
        StokGirisFormu.MdiParent = Me
        StokGirisFormu.Show()
        StokGirisFormu.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub YeniKullanıcıKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniKullanıcıKaydıToolStripMenuItem.Click
        KullaniciKayitFormu.ShowDialog(Me)
        KullaniciKayitFormu.Dispose()
    End Sub
End Class
