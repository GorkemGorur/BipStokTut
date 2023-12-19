<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StokGirisFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DurumSS = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.AdresiTBox = New System.Windows.Forms.TextBox()
        Me.VergiDairesiTBox = New System.Windows.Forms.TextBox()
        Me.VergiTCKimlikNoTBox = New System.Windows.Forms.TextBox()
        Me.TelefonuTBox = New System.Windows.Forms.TextBox()
        Me.SirketNoCBox = New System.Windows.Forms.ComboBox()
        Me.FaturaTarihiDTP = New System.Windows.Forms.DateTimePicker()
        Me.FaturaNoTBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StokGirisDetayDGV = New System.Windows.Forms.DataGridView()
        Me.UrunAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdetC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirimCinsiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiyatC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToplamC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UretimTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonKullanmaTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokGirisiTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokGirisDetayNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StoğaÜrünEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeçilenStoğuDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeçilenStoğuSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BipStokVTDS = New System.Data.DataSet()
        Me.YazdirBtn = New System.Windows.Forms.Button()
        Me.SonrakiKayitBtn = New System.Windows.Forms.Button()
        Me.OncekiKayitBtn = New System.Windows.Forms.Button()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.StokGelenFaturaTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.SirketTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.StokGirisDetayTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DurumSS.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.StokGirisDetayDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StokCMS.SuspendLayout()
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StokGelenFaturaTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirketTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StokGirisDetayTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DurumSS
        '
        Me.DurumSS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.DurumSS.Location = New System.Drawing.Point(0, 696)
        Me.DurumSS.Name = "DurumSS"
        Me.DurumSS.Size = New System.Drawing.Size(1342, 22)
        Me.DurumSS.TabIndex = 0
        Me.DurumSS.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(113, 17)
        Me.ToolStripStatusLabel1.Text = "Stoğa Ürün Ekle (F4)"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(146, 17)
        Me.ToolStripStatusLabel2.Text = "Seçilen Stoğu Düzenle (F5)"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel3.Text = "Seçilen Stoğu Sil (Del)"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.YazdirBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SonrakiKayitBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OncekiKayitBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KaydetBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SilBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EkleBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AdresiTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VergiDairesiTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VergiTCKimlikNoTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TelefonuTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SirketNoCBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FaturaTarihiDTP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FaturaNoTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.StokGirisDetayDGV)
        Me.SplitContainer1.Size = New System.Drawing.Size(1342, 696)
        Me.SplitContainer1.SplitterDistance = 150
        Me.SplitContainer1.TabIndex = 1
        '
        'AdresiTBox
        '
        Me.AdresiTBox.Location = New System.Drawing.Point(916, 29)
        Me.AdresiTBox.Multiline = True
        Me.AdresiTBox.Name = "AdresiTBox"
        Me.AdresiTBox.ReadOnly = True
        Me.AdresiTBox.Size = New System.Drawing.Size(266, 101)
        Me.AdresiTBox.TabIndex = 13
        '
        'VergiDairesiTBox
        '
        Me.VergiDairesiTBox.Location = New System.Drawing.Point(525, 110)
        Me.VergiDairesiTBox.Name = "VergiDairesiTBox"
        Me.VergiDairesiTBox.ReadOnly = True
        Me.VergiDairesiTBox.Size = New System.Drawing.Size(192, 20)
        Me.VergiDairesiTBox.TabIndex = 12
        '
        'VergiTCKimlikNoTBox
        '
        Me.VergiTCKimlikNoTBox.Location = New System.Drawing.Point(525, 82)
        Me.VergiTCKimlikNoTBox.Name = "VergiTCKimlikNoTBox"
        Me.VergiTCKimlikNoTBox.ReadOnly = True
        Me.VergiTCKimlikNoTBox.Size = New System.Drawing.Size(135, 20)
        Me.VergiTCKimlikNoTBox.TabIndex = 11
        '
        'TelefonuTBox
        '
        Me.TelefonuTBox.Location = New System.Drawing.Point(525, 56)
        Me.TelefonuTBox.Name = "TelefonuTBox"
        Me.TelefonuTBox.ReadOnly = True
        Me.TelefonuTBox.Size = New System.Drawing.Size(135, 20)
        Me.TelefonuTBox.TabIndex = 10
        '
        'SirketNoCBox
        '
        Me.SirketNoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SirketNoCBox.FormattingEnabled = True
        Me.SirketNoCBox.Location = New System.Drawing.Point(525, 29)
        Me.SirketNoCBox.Name = "SirketNoCBox"
        Me.SirketNoCBox.Size = New System.Drawing.Size(305, 21)
        Me.SirketNoCBox.TabIndex = 9
        '
        'FaturaTarihiDTP
        '
        Me.FaturaTarihiDTP.Location = New System.Drawing.Point(135, 55)
        Me.FaturaTarihiDTP.Name = "FaturaTarihiDTP"
        Me.FaturaTarihiDTP.Size = New System.Drawing.Size(200, 20)
        Me.FaturaTarihiDTP.TabIndex = 8
        '
        'FaturaNoTBox
        '
        Me.FaturaNoTBox.Location = New System.Drawing.Point(135, 29)
        Me.FaturaNoTBox.Name = "FaturaNoTBox"
        Me.FaturaNoTBox.Size = New System.Drawing.Size(148, 20)
        Me.FaturaNoTBox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(871, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Adresi:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(383, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vergi Dairesi:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Vergi Numarası (TC Kimlik):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefonu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Şirket Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fatura Tarihi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fatura No:"
        '
        'StokGirisDetayDGV
        '
        Me.StokGirisDetayDGV.AllowUserToAddRows = False
        Me.StokGirisDetayDGV.AllowUserToDeleteRows = False
        Me.StokGirisDetayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StokGirisDetayDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UrunAdiC, Me.AdetC, Me.BirimCinsiC, Me.FiyatC, Me.ToplamC, Me.UretimTarihiC, Me.SonKullanmaTarihiC, Me.StokGirisiTarihiC, Me.StokGirisDetayNoC})
        Me.StokGirisDetayDGV.ContextMenuStrip = Me.StokCMS
        Me.StokGirisDetayDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StokGirisDetayDGV.Location = New System.Drawing.Point(0, 0)
        Me.StokGirisDetayDGV.MultiSelect = False
        Me.StokGirisDetayDGV.Name = "StokGirisDetayDGV"
        Me.StokGirisDetayDGV.ReadOnly = True
        Me.StokGirisDetayDGV.RowHeadersVisible = False
        Me.StokGirisDetayDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StokGirisDetayDGV.Size = New System.Drawing.Size(1342, 542)
        Me.StokGirisDetayDGV.TabIndex = 0
        '
        'UrunAdiC
        '
        Me.UrunAdiC.DataPropertyName = "UrunAdi"
        Me.UrunAdiC.HeaderText = "Ürün Adı"
        Me.UrunAdiC.Name = "UrunAdiC"
        Me.UrunAdiC.ReadOnly = True
        Me.UrunAdiC.Width = 300
        '
        'AdetC
        '
        Me.AdetC.DataPropertyName = "Adet"
        Me.AdetC.HeaderText = "Miktar"
        Me.AdetC.Name = "AdetC"
        Me.AdetC.ReadOnly = True
        '
        'BirimCinsiC
        '
        Me.BirimCinsiC.DataPropertyName = "BirimCinsi"
        Me.BirimCinsiC.HeaderText = "Birim Cinsi"
        Me.BirimCinsiC.Name = "BirimCinsiC"
        Me.BirimCinsiC.ReadOnly = True
        '
        'FiyatC
        '
        Me.FiyatC.DataPropertyName = "Fiyat"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FiyatC.DefaultCellStyle = DataGridViewCellStyle1
        Me.FiyatC.HeaderText = "Fiyatı"
        Me.FiyatC.Name = "FiyatC"
        Me.FiyatC.ReadOnly = True
        '
        'ToplamC
        '
        Me.ToplamC.DataPropertyName = "Toplam"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ToplamC.DefaultCellStyle = DataGridViewCellStyle2
        Me.ToplamC.HeaderText = "Toplam"
        Me.ToplamC.Name = "ToplamC"
        Me.ToplamC.ReadOnly = True
        '
        'UretimTarihiC
        '
        Me.UretimTarihiC.DataPropertyName = "UretimTarihi"
        Me.UretimTarihiC.HeaderText = "Üretim Tarihi"
        Me.UretimTarihiC.Name = "UretimTarihiC"
        Me.UretimTarihiC.ReadOnly = True
        '
        'SonKullanmaTarihiC
        '
        Me.SonKullanmaTarihiC.DataPropertyName = "SonKullanmaTarihi"
        Me.SonKullanmaTarihiC.HeaderText = "Son Kullanma Tarihi"
        Me.SonKullanmaTarihiC.Name = "SonKullanmaTarihiC"
        Me.SonKullanmaTarihiC.ReadOnly = True
        '
        'StokGirisiTarihiC
        '
        Me.StokGirisiTarihiC.DataPropertyName = "StokGirisiTarihi"
        Me.StokGirisiTarihiC.HeaderText = "Stok Giriş Tarihi"
        Me.StokGirisiTarihiC.Name = "StokGirisiTarihiC"
        Me.StokGirisiTarihiC.ReadOnly = True
        '
        'StokGirisDetayNoC
        '
        Me.StokGirisDetayNoC.DataPropertyName = "StokGirisDetayNo"
        Me.StokGirisDetayNoC.HeaderText = "Stok Giriş Detay No"
        Me.StokGirisDetayNoC.Name = "StokGirisDetayNoC"
        Me.StokGirisDetayNoC.ReadOnly = True
        Me.StokGirisDetayNoC.Visible = False
        '
        'StokCMS
        '
        Me.StokCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StoğaÜrünEkleToolStripMenuItem, Me.SeçilenStoğuDüzenleToolStripMenuItem, Me.SeçilenStoğuSilToolStripMenuItem})
        Me.StokCMS.Name = "StokCMS"
        Me.StokCMS.Size = New System.Drawing.Size(210, 70)
        '
        'StoğaÜrünEkleToolStripMenuItem
        '
        Me.StoğaÜrünEkleToolStripMenuItem.Name = "StoğaÜrünEkleToolStripMenuItem"
        Me.StoğaÜrünEkleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.StoğaÜrünEkleToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StoğaÜrünEkleToolStripMenuItem.Text = "Stoğa Ürün Ekle"
        '
        'SeçilenStoğuDüzenleToolStripMenuItem
        '
        Me.SeçilenStoğuDüzenleToolStripMenuItem.Name = "SeçilenStoğuDüzenleToolStripMenuItem"
        Me.SeçilenStoğuDüzenleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.SeçilenStoğuDüzenleToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SeçilenStoğuDüzenleToolStripMenuItem.Text = "Seçilen Stoğu Düzenle"
        '
        'SeçilenStoğuSilToolStripMenuItem
        '
        Me.SeçilenStoğuSilToolStripMenuItem.Name = "SeçilenStoğuSilToolStripMenuItem"
        Me.SeçilenStoğuSilToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.SeçilenStoğuSilToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SeçilenStoğuSilToolStripMenuItem.Text = "Seçilen Stoğu Sil"
        '
        'BipStokVTDS
        '
        Me.BipStokVTDS.DataSetName = "NewDataSet"
        '
        'YazdirBtn
        '
        Me.YazdirBtn.Image = Global.BipStokTut.My.Resources.Resources.yazdir
        Me.YazdirBtn.Location = New System.Drawing.Point(1199, 81)
        Me.YazdirBtn.Name = "YazdirBtn"
        Me.YazdirBtn.Size = New System.Drawing.Size(68, 64)
        Me.YazdirBtn.TabIndex = 24
        Me.YazdirBtn.Text = "&Yazdır"
        Me.YazdirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.YazdirBtn.UseVisualStyleBackColor = True
        '
        'SonrakiKayitBtn
        '
        Me.SonrakiKayitBtn.Image = Global.BipStokTut.My.Resources.Resources.Sonraki
        Me.SonrakiKayitBtn.Location = New System.Drawing.Point(310, 81)
        Me.SonrakiKayitBtn.Name = "SonrakiKayitBtn"
        Me.SonrakiKayitBtn.Size = New System.Drawing.Size(68, 64)
        Me.SonrakiKayitBtn.TabIndex = 23
        Me.SonrakiKayitBtn.Text = "S&onraki"
        Me.SonrakiKayitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SonrakiKayitBtn.UseVisualStyleBackColor = True
        '
        'OncekiKayitBtn
        '
        Me.OncekiKayitBtn.Image = Global.BipStokTut.My.Resources.Resources.Onceki
        Me.OncekiKayitBtn.Location = New System.Drawing.Point(242, 81)
        Me.OncekiKayitBtn.Name = "OncekiKayitBtn"
        Me.OncekiKayitBtn.Size = New System.Drawing.Size(68, 64)
        Me.OncekiKayitBtn.TabIndex = 22
        Me.OncekiKayitBtn.Text = "&Önceki"
        Me.OncekiKayitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.OncekiKayitBtn.UseVisualStyleBackColor = True
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Image = Global.BipStokTut.My.Resources.Resources.Kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(83, 82)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(68, 64)
        Me.KaydetBtn.TabIndex = 21
        Me.KaydetBtn.Text = "&Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KaydetBtn.UseVisualStyleBackColor = True
        '
        'SilBtn
        '
        Me.SilBtn.Image = Global.BipStokTut.My.Resources.Resources.Sil
        Me.SilBtn.Location = New System.Drawing.Point(151, 82)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(68, 64)
        Me.SilBtn.TabIndex = 20
        Me.SilBtn.Text = "&Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SilBtn.UseVisualStyleBackColor = True
        '
        'EkleBtn
        '
        Me.EkleBtn.Image = Global.BipStokTut.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(15, 82)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(68, 64)
        Me.EkleBtn.TabIndex = 19
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.EkleBtn.UseVisualStyleBackColor = True
        '
        'StokGirisFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 718)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.DurumSS)
        Me.Name = "StokGirisFormu"
        Me.Text = "Stok Girişi"
        Me.DurumSS.ResumeLayout(False)
        Me.DurumSS.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.StokGirisDetayDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StokCMS.ResumeLayout(False)
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StokGelenFaturaTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirketTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StokGirisDetayTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DurumSS As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents AdresiTBox As TextBox
    Friend WithEvents VergiDairesiTBox As TextBox
    Friend WithEvents VergiTCKimlikNoTBox As TextBox
    Friend WithEvents TelefonuTBox As TextBox
    Friend WithEvents SirketNoCBox As ComboBox
    Friend WithEvents FaturaTarihiDTP As DateTimePicker
    Friend WithEvents FaturaNoTBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents EkleBtn As Button
    Friend WithEvents StokGirisDetayDGV As DataGridView
    Friend WithEvents BipStokVTDS As DataSet
    Friend WithEvents StokGelenFaturaTablosuBS As BindingSource
    Friend WithEvents SirketTablosuBS As BindingSource
    Friend WithEvents StokGirisDetayTablosuBS As BindingSource
    Friend WithEvents StokCMS As ContextMenuStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents StoğaÜrünEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeçilenStoğuDüzenleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeçilenStoğuSilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SonrakiKayitBtn As Button
    Friend WithEvents OncekiKayitBtn As Button
    Friend WithEvents UrunAdiC As DataGridViewTextBoxColumn
    Friend WithEvents AdetC As DataGridViewTextBoxColumn
    Friend WithEvents BirimCinsiC As DataGridViewTextBoxColumn
    Friend WithEvents FiyatC As DataGridViewTextBoxColumn
    Friend WithEvents ToplamC As DataGridViewTextBoxColumn
    Friend WithEvents UretimTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents SonKullanmaTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents StokGirisiTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents StokGirisDetayNoC As DataGridViewTextBoxColumn
    Friend WithEvents YazdirBtn As Button
End Class
