<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.AnaMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokGirişToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProgramıKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KayıtlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkaKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniKullanıcıKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AramalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünAramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurumStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.KisayolToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.YeniŞirketKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResimPBox = New System.Windows.Forms.PictureBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.StoklarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokGirişiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaMenuStrip.SuspendLayout()
        Me.KisayolToolStrip.SuspendLayout()
        CType(Me.ResimPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnaMenuStrip
        '
        Me.AnaMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.KayıtlarToolStripMenuItem, Me.AramalarToolStripMenuItem, Me.StoklarToolStripMenuItem})
        Me.AnaMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AnaMenuStrip.Name = "AnaMenuStrip"
        Me.AnaMenuStrip.Size = New System.Drawing.Size(1097, 24)
        Me.AnaMenuStrip.TabIndex = 1
        Me.AnaMenuStrip.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StokGirişToolStripMenuItem, Me.StokÇıkışToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProgramıKapatToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'StokGirişToolStripMenuItem
        '
        Me.StokGirişToolStripMenuItem.Name = "StokGirişToolStripMenuItem"
        Me.StokGirişToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.StokGirişToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.StokGirişToolStripMenuItem.Text = "Stok &Giriş"
        '
        'StokÇıkışToolStripMenuItem
        '
        Me.StokÇıkışToolStripMenuItem.Name = "StokÇıkışToolStripMenuItem"
        Me.StokÇıkışToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.StokÇıkışToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.StokÇıkışToolStripMenuItem.Text = "Stok &Çıkış"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 6)
        '
        'ProgramıKapatToolStripMenuItem
        '
        Me.ProgramıKapatToolStripMenuItem.Name = "ProgramıKapatToolStripMenuItem"
        Me.ProgramıKapatToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ProgramıKapatToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ProgramıKapatToolStripMenuItem.Text = "Programı Kapat"
        '
        'KayıtlarToolStripMenuItem
        '
        Me.KayıtlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkaKaydıToolStripMenuItem, Me.ÜrünKaydıToolStripMenuItem, Me.YeniŞirketKaydıToolStripMenuItem, Me.ToolStripMenuItem2, Me.YeniKullanıcıKaydıToolStripMenuItem})
        Me.KayıtlarToolStripMenuItem.Name = "KayıtlarToolStripMenuItem"
        Me.KayıtlarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.KayıtlarToolStripMenuItem.Text = "&Kayıtlar"
        '
        'MarkaKaydıToolStripMenuItem
        '
        Me.MarkaKaydıToolStripMenuItem.Name = "MarkaKaydıToolStripMenuItem"
        Me.MarkaKaydıToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarkaKaydıToolStripMenuItem.Text = "&Marka Kaydı"
        '
        'ÜrünKaydıToolStripMenuItem
        '
        Me.ÜrünKaydıToolStripMenuItem.Name = "ÜrünKaydıToolStripMenuItem"
        Me.ÜrünKaydıToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ÜrünKaydıToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÜrünKaydıToolStripMenuItem.Text = "&Ürün Kaydı"
        '
        'YeniKullanıcıKaydıToolStripMenuItem
        '
        Me.YeniKullanıcıKaydıToolStripMenuItem.Name = "YeniKullanıcıKaydıToolStripMenuItem"
        Me.YeniKullanıcıKaydıToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YeniKullanıcıKaydıToolStripMenuItem.Text = "Yeni Kullanıcı Kaydı"
        '
        'AramalarToolStripMenuItem
        '
        Me.AramalarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜrünAramaToolStripMenuItem})
        Me.AramalarToolStripMenuItem.Name = "AramalarToolStripMenuItem"
        Me.AramalarToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AramalarToolStripMenuItem.Text = "&Aramalar"
        '
        'ÜrünAramaToolStripMenuItem
        '
        Me.ÜrünAramaToolStripMenuItem.Name = "ÜrünAramaToolStripMenuItem"
        Me.ÜrünAramaToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ÜrünAramaToolStripMenuItem.Text = "&Ürün Arama"
        '
        'DurumStatusStrip
        '
        Me.DurumStatusStrip.Location = New System.Drawing.Point(0, 588)
        Me.DurumStatusStrip.Name = "DurumStatusStrip"
        Me.DurumStatusStrip.Size = New System.Drawing.Size(1097, 22)
        Me.DurumStatusStrip.TabIndex = 2
        Me.DurumStatusStrip.Text = "StatusStrip1"
        '
        'KisayolToolStrip
        '
        Me.KisayolToolStrip.AutoSize = False
        Me.KisayolToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.KisayolToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.KisayolToolStrip.Name = "KisayolToolStrip"
        Me.KisayolToolStrip.Size = New System.Drawing.Size(1097, 55)
        Me.KisayolToolStrip.TabIndex = 3
        Me.KisayolToolStrip.Text = "ToolStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'YeniŞirketKaydıToolStripMenuItem
        '
        Me.YeniŞirketKaydıToolStripMenuItem.Name = "YeniŞirketKaydıToolStripMenuItem"
        Me.YeniŞirketKaydıToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YeniŞirketKaydıToolStripMenuItem.Text = "Yeni Şirket Kaydı"
        '
        'ResimPBox
        '
        Me.ResimPBox.Location = New System.Drawing.Point(1028, 24)
        Me.ResimPBox.Name = "ResimPBox"
        Me.ResimPBox.Size = New System.Drawing.Size(57, 50)
        Me.ResimPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ResimPBox.TabIndex = 5
        Me.ResimPBox.TabStop = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(50, 50)
        Me.ToolStripButton1.Text = "Stok Giriş"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(50, 50)
        Me.ToolStripButton2.Text = "Stok Çıkış"
        '
        'StoklarToolStripMenuItem
        '
        Me.StoklarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StokGirişiToolStripMenuItem})
        Me.StoklarToolStripMenuItem.Name = "StoklarToolStripMenuItem"
        Me.StoklarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.StoklarToolStripMenuItem.Text = "&Stoklar"
        '
        'StokGirişiToolStripMenuItem
        '
        Me.StokGirişiToolStripMenuItem.Name = "StokGirişiToolStripMenuItem"
        Me.StokGirişiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.StokGirişiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StokGirişiToolStripMenuItem.Text = "Stok Girişi"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 610)
        Me.Controls.Add(Me.ResimPBox)
        Me.Controls.Add(Me.KisayolToolStrip)
        Me.Controls.Add(Me.DurumStatusStrip)
        Me.Controls.Add(Me.AnaMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AnaMenuStrip
        Me.Name = "AnaForm"
        Me.Text = "Form1"
        Me.AnaMenuStrip.ResumeLayout(False)
        Me.AnaMenuStrip.PerformLayout()
        Me.KisayolToolStrip.ResumeLayout(False)
        Me.KisayolToolStrip.PerformLayout()
        CType(Me.ResimPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AnaMenuStrip As MenuStrip
    Friend WithEvents DurumStatusStrip As StatusStrip
    Friend WithEvents KisayolToolStrip As ToolStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokGirişToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ProgramıKapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KayıtlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkaKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ÜrünKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AramalarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜrünAramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YeniKullanıcıKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResimPBox As PictureBox
    Friend WithEvents YeniŞirketKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents StoklarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokGirişiToolStripMenuItem As ToolStripMenuItem
End Class
