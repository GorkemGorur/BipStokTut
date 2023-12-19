<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UrunKayitFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FotoAlbumPanel = New System.Windows.Forms.Panel()
        Me.FotoPanel = New System.Windows.Forms.Panel()
        Me.SonrakiResimBtn = New System.Windows.Forms.Button()
        Me.OncekiResimBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FotografSilBtn = New System.Windows.Forms.Button()
        Me.FotografEkleBtn = New System.Windows.Forms.Button()
        Me.SonKayitBtn = New System.Windows.Forms.Button()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.AciklamaTBox = New System.Windows.Forms.TextBox()
        Me.SonrakiKayitBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.UretimYeriTBox = New System.Windows.Forms.TextBox()
        Me.DuzenleBtn = New System.Windows.Forms.Button()
        Me.BarkodNoTBox = New System.Windows.Forms.TextBox()
        Me.OncekiKayitBtn = New System.Windows.Forms.Button()
        Me.BirimCinsiNoCBox = New System.Windows.Forms.ComboBox()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.UrunGrupNoLBox = New System.Windows.Forms.ListBox()
        Me.ilkKayitBtn = New System.Windows.Forms.Button()
        Me.MarkaNoCBox = New System.Windows.Forms.ComboBox()
        Me.UrunAdiTbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UrunlerDGV = New System.Windows.Forms.DataGridView()
        Me.UrunNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UrunGrupNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BirimCinsiNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BarkodNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UretimYeriC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AciklamaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BipStokVTDS = New System.Data.DataSet()
        Me.UrunTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarkaTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.BirimCinsiTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.UrunGrupTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.FotografTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FotoAlbumPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UrunlerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UrunTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkaTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirimCinsiTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UrunGrupTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotografTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.FotoAlbumPanel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SonKayitBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KaydetBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AciklamaTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SonrakiKayitBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SilBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UretimYeriTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DuzenleBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BarkodNoTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OncekiKayitBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BirimCinsiNoCBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EkleBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UrunGrupNoLBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ilkKayitBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MarkaNoCBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UrunAdiTbox)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.UrunlerDGV)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1204, 703)
        Me.SplitContainer1.SplitterDistance = 550
        Me.SplitContainer1.TabIndex = 0
        '
        'FotoAlbumPanel
        '
        Me.FotoAlbumPanel.BackColor = System.Drawing.Color.White
        Me.FotoAlbumPanel.Controls.Add(Me.FotoPanel)
        Me.FotoAlbumPanel.Controls.Add(Me.SonrakiResimBtn)
        Me.FotoAlbumPanel.Controls.Add(Me.OncekiResimBtn)
        Me.FotoAlbumPanel.Controls.Add(Me.Panel3)
        Me.FotoAlbumPanel.Location = New System.Drawing.Point(282, 149)
        Me.FotoAlbumPanel.Name = "FotoAlbumPanel"
        Me.FotoAlbumPanel.Size = New System.Drawing.Size(244, 125)
        Me.FotoAlbumPanel.TabIndex = 16
        '
        'FotoPanel
        '
        Me.FotoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FotoPanel.Location = New System.Drawing.Point(25, 0)
        Me.FotoPanel.Name = "FotoPanel"
        Me.FotoPanel.Size = New System.Drawing.Size(194, 102)
        Me.FotoPanel.TabIndex = 3
        '
        'SonrakiResimBtn
        '
        Me.SonrakiResimBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.SonrakiResimBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SonrakiResimBtn.Location = New System.Drawing.Point(219, 0)
        Me.SonrakiResimBtn.Name = "SonrakiResimBtn"
        Me.SonrakiResimBtn.Size = New System.Drawing.Size(25, 102)
        Me.SonrakiResimBtn.TabIndex = 2
        Me.SonrakiResimBtn.Text = ">"
        Me.SonrakiResimBtn.UseVisualStyleBackColor = True
        '
        'OncekiResimBtn
        '
        Me.OncekiResimBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.OncekiResimBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OncekiResimBtn.Location = New System.Drawing.Point(0, 0)
        Me.OncekiResimBtn.Name = "OncekiResimBtn"
        Me.OncekiResimBtn.Size = New System.Drawing.Size(25, 102)
        Me.OncekiResimBtn.TabIndex = 1
        Me.OncekiResimBtn.Text = "<"
        Me.OncekiResimBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.FotografSilBtn)
        Me.Panel3.Controls.Add(Me.FotografEkleBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(244, 23)
        Me.Panel3.TabIndex = 0
        '
        'FotografSilBtn
        '
        Me.FotografSilBtn.Location = New System.Drawing.Point(188, 0)
        Me.FotografSilBtn.Name = "FotografSilBtn"
        Me.FotografSilBtn.Size = New System.Drawing.Size(31, 23)
        Me.FotografSilBtn.TabIndex = 16
        Me.FotografSilBtn.Text = "-"
        Me.FotografSilBtn.UseVisualStyleBackColor = True
        '
        'FotografEkleBtn
        '
        Me.FotografEkleBtn.Location = New System.Drawing.Point(153, 0)
        Me.FotografEkleBtn.Name = "FotografEkleBtn"
        Me.FotografEkleBtn.Size = New System.Drawing.Size(31, 23)
        Me.FotografEkleBtn.TabIndex = 15
        Me.FotografEkleBtn.Text = "+"
        Me.FotografEkleBtn.UseVisualStyleBackColor = True
        '
        'SonKayitBtn
        '
        Me.SonKayitBtn.Image = Global.BipStokTut.My.Resources.Resources.Son
        Me.SonKayitBtn.Location = New System.Drawing.Point(476, 3)
        Me.SonKayitBtn.Name = "SonKayitBtn"
        Me.SonKayitBtn.Size = New System.Drawing.Size(68, 64)
        Me.SonKayitBtn.TabIndex = 7
        Me.SonKayitBtn.Text = "So&n Kayıt"
        Me.SonKayitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SonKayitBtn.UseVisualStyleBackColor = True
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Image = Global.BipStokTut.My.Resources.Resources.Kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(204, 3)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(68, 64)
        Me.KaydetBtn.TabIndex = 3
        Me.KaydetBtn.Text = "&Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KaydetBtn.UseVisualStyleBackColor = True
        '
        'AciklamaTBox
        '
        Me.AciklamaTBox.Location = New System.Drawing.Point(99, 328)
        Me.AciklamaTBox.Multiline = True
        Me.AciklamaTBox.Name = "AciklamaTBox"
        Me.AciklamaTBox.Size = New System.Drawing.Size(413, 207)
        Me.AciklamaTBox.TabIndex = 13
        '
        'SonrakiKayitBtn
        '
        Me.SonrakiKayitBtn.Image = Global.BipStokTut.My.Resources.Resources.Sonraki
        Me.SonrakiKayitBtn.Location = New System.Drawing.Point(408, 3)
        Me.SonrakiKayitBtn.Name = "SonrakiKayitBtn"
        Me.SonrakiKayitBtn.Size = New System.Drawing.Size(68, 64)
        Me.SonrakiKayitBtn.TabIndex = 6
        Me.SonrakiKayitBtn.Text = "S&onraki"
        Me.SonrakiKayitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SonrakiKayitBtn.UseVisualStyleBackColor = True
        '
        'SilBtn
        '
        Me.SilBtn.Image = Global.BipStokTut.My.Resources.Resources.Sil
        Me.SilBtn.Location = New System.Drawing.Point(136, 3)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(68, 64)
        Me.SilBtn.TabIndex = 2
        Me.SilBtn.Text = "&Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SilBtn.UseVisualStyleBackColor = True
        '
        'UretimYeriTBox
        '
        Me.UretimYeriTBox.Location = New System.Drawing.Point(99, 302)
        Me.UretimYeriTBox.Name = "UretimYeriTBox"
        Me.UretimYeriTBox.Size = New System.Drawing.Size(177, 20)
        Me.UretimYeriTBox.TabIndex = 12
        '
        'DuzenleBtn
        '
        Me.DuzenleBtn.Image = Global.BipStokTut.My.Resources.Resources.Duzenle
        Me.DuzenleBtn.Location = New System.Drawing.Point(68, 3)
        Me.DuzenleBtn.Name = "DuzenleBtn"
        Me.DuzenleBtn.Size = New System.Drawing.Size(68, 64)
        Me.DuzenleBtn.TabIndex = 1
        Me.DuzenleBtn.Text = "&Düzenle"
        Me.DuzenleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DuzenleBtn.UseVisualStyleBackColor = True
        '
        'BarkodNoTBox
        '
        Me.BarkodNoTBox.Location = New System.Drawing.Point(99, 277)
        Me.BarkodNoTBox.Name = "BarkodNoTBox"
        Me.BarkodNoTBox.Size = New System.Drawing.Size(177, 20)
        Me.BarkodNoTBox.TabIndex = 11
        '
        'OncekiKayitBtn
        '
        Me.OncekiKayitBtn.Image = Global.BipStokTut.My.Resources.Resources.Onceki
        Me.OncekiKayitBtn.Location = New System.Drawing.Point(340, 3)
        Me.OncekiKayitBtn.Name = "OncekiKayitBtn"
        Me.OncekiKayitBtn.Size = New System.Drawing.Size(68, 64)
        Me.OncekiKayitBtn.TabIndex = 5
        Me.OncekiKayitBtn.Text = "&Önceki"
        Me.OncekiKayitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.OncekiKayitBtn.UseVisualStyleBackColor = True
        '
        'BirimCinsiNoCBox
        '
        Me.BirimCinsiNoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BirimCinsiNoCBox.FormattingEnabled = True
        Me.BirimCinsiNoCBox.Location = New System.Drawing.Point(99, 250)
        Me.BirimCinsiNoCBox.Name = "BirimCinsiNoCBox"
        Me.BirimCinsiNoCBox.Size = New System.Drawing.Size(100, 21)
        Me.BirimCinsiNoCBox.TabIndex = 10
        '
        'EkleBtn
        '
        Me.EkleBtn.Image = Global.BipStokTut.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(0, 3)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(68, 64)
        Me.EkleBtn.TabIndex = 0
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.EkleBtn.UseVisualStyleBackColor = True
        '
        'UrunGrupNoLBox
        '
        Me.UrunGrupNoLBox.FormattingEnabled = True
        Me.UrunGrupNoLBox.Location = New System.Drawing.Point(99, 149)
        Me.UrunGrupNoLBox.Name = "UrunGrupNoLBox"
        Me.UrunGrupNoLBox.Size = New System.Drawing.Size(177, 95)
        Me.UrunGrupNoLBox.TabIndex = 9
        '
        'ilkKayitBtn
        '
        Me.ilkKayitBtn.Image = Global.BipStokTut.My.Resources.Resources.ilk
        Me.ilkKayitBtn.Location = New System.Drawing.Point(272, 3)
        Me.ilkKayitBtn.Name = "ilkKayitBtn"
        Me.ilkKayitBtn.Size = New System.Drawing.Size(68, 64)
        Me.ilkKayitBtn.TabIndex = 4
        Me.ilkKayitBtn.Text = "&İlk Kayıt"
        Me.ilkKayitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ilkKayitBtn.UseVisualStyleBackColor = True
        '
        'MarkaNoCBox
        '
        Me.MarkaNoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MarkaNoCBox.FormattingEnabled = True
        Me.MarkaNoCBox.Location = New System.Drawing.Point(98, 122)
        Me.MarkaNoCBox.Name = "MarkaNoCBox"
        Me.MarkaNoCBox.Size = New System.Drawing.Size(199, 21)
        Me.MarkaNoCBox.TabIndex = 8
        '
        'UrunAdiTbox
        '
        Me.UrunAdiTbox.Location = New System.Drawing.Point(98, 96)
        Me.UrunAdiTbox.Name = "UrunAdiTbox"
        Me.UrunAdiTbox.Size = New System.Drawing.Size(414, 20)
        Me.UrunAdiTbox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Açıklama:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Üretim Yeri:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Barkod Numarası:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Birim Cinsi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ürün Grubu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Markası:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ürün Adı:"
        '
        'UrunlerDGV
        '
        Me.UrunlerDGV.AllowUserToAddRows = False
        Me.UrunlerDGV.AllowUserToDeleteRows = False
        Me.UrunlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UrunlerDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UrunNoC, Me.UrunAdiC, Me.MarkaNoC, Me.UrunGrupNoC, Me.BirimCinsiNoC, Me.BarkodNoC, Me.UretimYeriC, Me.AciklamaC})
        Me.UrunlerDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UrunlerDGV.Location = New System.Drawing.Point(10, 10)
        Me.UrunlerDGV.MultiSelect = False
        Me.UrunlerDGV.Name = "UrunlerDGV"
        Me.UrunlerDGV.ReadOnly = True
        Me.UrunlerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UrunlerDGV.Size = New System.Drawing.Size(630, 683)
        Me.UrunlerDGV.TabIndex = 0
        '
        'UrunNoC
        '
        Me.UrunNoC.HeaderText = "Ürün No"
        Me.UrunNoC.Name = "UrunNoC"
        Me.UrunNoC.ReadOnly = True
        Me.UrunNoC.Visible = False
        '
        'UrunAdiC
        '
        Me.UrunAdiC.HeaderText = "Ürün Adı"
        Me.UrunAdiC.Name = "UrunAdiC"
        Me.UrunAdiC.ReadOnly = True
        '
        'MarkaNoC
        '
        Me.MarkaNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MarkaNoC.HeaderText = "Markası"
        Me.MarkaNoC.Name = "MarkaNoC"
        Me.MarkaNoC.ReadOnly = True
        '
        'UrunGrupNoC
        '
        Me.UrunGrupNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.UrunGrupNoC.HeaderText = "Ürün Grubu"
        Me.UrunGrupNoC.Name = "UrunGrupNoC"
        Me.UrunGrupNoC.ReadOnly = True
        '
        'BirimCinsiNoC
        '
        Me.BirimCinsiNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BirimCinsiNoC.HeaderText = "Birim Cinsi"
        Me.BirimCinsiNoC.Name = "BirimCinsiNoC"
        Me.BirimCinsiNoC.ReadOnly = True
        '
        'BarkodNoC
        '
        Me.BarkodNoC.HeaderText = "Barkod Numarası"
        Me.BarkodNoC.Name = "BarkodNoC"
        Me.BarkodNoC.ReadOnly = True
        '
        'UretimYeriC
        '
        Me.UretimYeriC.HeaderText = "Üretim Yeri"
        Me.UretimYeriC.Name = "UretimYeriC"
        Me.UretimYeriC.ReadOnly = True
        '
        'AciklamaC
        '
        Me.AciklamaC.HeaderText = "Açıklama"
        Me.AciklamaC.Name = "AciklamaC"
        Me.AciklamaC.ReadOnly = True
        '
        'BipStokVTDS
        '
        Me.BipStokVTDS.DataSetName = "NewDataSet"
        '
        'UrunTablosuBS
        '
        '
        'UrunKayitFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 703)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UrunKayitFormu"
        Me.ShowIcon = False
        Me.Text = "UrunKayitFormu"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FotoAlbumPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UrunlerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UrunTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkaTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirimCinsiTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UrunGrupTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotografTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents AciklamaTBox As TextBox
    Friend WithEvents UretimYeriTBox As TextBox
    Friend WithEvents BarkodNoTBox As TextBox
    Friend WithEvents BirimCinsiNoCBox As ComboBox
    Friend WithEvents UrunGrupNoLBox As ListBox
    Friend WithEvents MarkaNoCBox As ComboBox
    Friend WithEvents UrunAdiTbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UrunlerDGV As DataGridView
    Friend WithEvents BipStokVTDS As DataSet
    Friend WithEvents UrunTablosuBS As BindingSource
    Friend WithEvents MarkaTablosuBS As BindingSource
    Friend WithEvents BirimCinsiTablosuBS As BindingSource
    Friend WithEvents UrunGrupTablosuBS As BindingSource
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents DuzenleBtn As Button
    Friend WithEvents EkleBtn As Button
    Friend WithEvents SonKayitBtn As Button
    Friend WithEvents SonrakiKayitBtn As Button
    Friend WithEvents OncekiKayitBtn As Button
    Friend WithEvents ilkKayitBtn As Button
    Friend WithEvents UrunNoC As DataGridViewTextBoxColumn
    Friend WithEvents UrunAdiC As DataGridViewTextBoxColumn
    Friend WithEvents MarkaNoC As DataGridViewComboBoxColumn
    Friend WithEvents UrunGrupNoC As DataGridViewComboBoxColumn
    Friend WithEvents BirimCinsiNoC As DataGridViewComboBoxColumn
    Friend WithEvents BarkodNoC As DataGridViewTextBoxColumn
    Friend WithEvents UretimYeriC As DataGridViewTextBoxColumn
    Friend WithEvents AciklamaC As DataGridViewTextBoxColumn
    Friend WithEvents FotografTablosuBS As BindingSource
    Friend WithEvents FotoAlbumPanel As Panel
    Friend WithEvents FotoPanel As Panel
    Friend WithEvents SonrakiResimBtn As Button
    Friend WithEvents OncekiResimBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FotografSilBtn As Button
    Friend WithEvents FotografEkleBtn As Button
End Class
