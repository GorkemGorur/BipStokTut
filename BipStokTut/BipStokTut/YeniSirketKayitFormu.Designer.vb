<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YeniSirketKayitFormu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SirketAdiTBox = New System.Windows.Forms.TextBox()
        Me.TelefonuTBox = New System.Windows.Forms.TextBox()
        Me.FaksTBox = New System.Windows.Forms.TextBox()
        Me.E_PostaTBox = New System.Windows.Forms.TextBox()
        Me.VergiTCKimlikNoTBox = New System.Windows.Forms.TextBox()
        Me.VergiDairesiTBox = New System.Windows.Forms.TextBox()
        Me.AdresiTBox = New System.Windows.Forms.TextBox()
        Me.BipStokVTDS = New System.Data.DataSet()
        Me.SirketTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.SirketlerDGV = New System.Windows.Forms.DataGridView()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.DuzenleBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.SirketNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirketAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirketTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirketlerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Şirket Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Faks:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-Posta Adresi:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Vergi Numarası (TC Kimlik Numarası):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vergi Dairesi:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Adresi:"
        '
        'SirketAdiTBox
        '
        Me.SirketAdiTBox.Location = New System.Drawing.Point(201, 87)
        Me.SirketAdiTBox.Name = "SirketAdiTBox"
        Me.SirketAdiTBox.Size = New System.Drawing.Size(327, 20)
        Me.SirketAdiTBox.TabIndex = 7
        '
        'TelefonuTBox
        '
        Me.TelefonuTBox.Location = New System.Drawing.Point(202, 113)
        Me.TelefonuTBox.Name = "TelefonuTBox"
        Me.TelefonuTBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonuTBox.TabIndex = 8
        '
        'FaksTBox
        '
        Me.FaksTBox.Location = New System.Drawing.Point(202, 139)
        Me.FaksTBox.Name = "FaksTBox"
        Me.FaksTBox.Size = New System.Drawing.Size(100, 20)
        Me.FaksTBox.TabIndex = 9
        '
        'E_PostaTBox
        '
        Me.E_PostaTBox.Location = New System.Drawing.Point(201, 165)
        Me.E_PostaTBox.Name = "E_PostaTBox"
        Me.E_PostaTBox.Size = New System.Drawing.Size(248, 20)
        Me.E_PostaTBox.TabIndex = 10
        '
        'VergiTCKimlikNoTBox
        '
        Me.VergiTCKimlikNoTBox.Location = New System.Drawing.Point(201, 191)
        Me.VergiTCKimlikNoTBox.Name = "VergiTCKimlikNoTBox"
        Me.VergiTCKimlikNoTBox.Size = New System.Drawing.Size(140, 20)
        Me.VergiTCKimlikNoTBox.TabIndex = 11
        '
        'VergiDairesiTBox
        '
        Me.VergiDairesiTBox.Location = New System.Drawing.Point(202, 217)
        Me.VergiDairesiTBox.Name = "VergiDairesiTBox"
        Me.VergiDairesiTBox.Size = New System.Drawing.Size(139, 20)
        Me.VergiDairesiTBox.TabIndex = 12
        '
        'AdresiTBox
        '
        Me.AdresiTBox.Location = New System.Drawing.Point(202, 243)
        Me.AdresiTBox.Multiline = True
        Me.AdresiTBox.Name = "AdresiTBox"
        Me.AdresiTBox.Size = New System.Drawing.Size(326, 92)
        Me.AdresiTBox.TabIndex = 13
        '
        'BipStokVTDS
        '
        Me.BipStokVTDS.DataSetName = "NewDataSet"
        '
        'SirketlerDGV
        '
        Me.SirketlerDGV.AllowUserToAddRows = False
        Me.SirketlerDGV.AllowUserToDeleteRows = False
        Me.SirketlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SirketlerDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SirketNoC, Me.SirketAdiC})
        Me.SirketlerDGV.Location = New System.Drawing.Point(534, 12)
        Me.SirketlerDGV.MultiSelect = False
        Me.SirketlerDGV.Name = "SirketlerDGV"
        Me.SirketlerDGV.ReadOnly = True
        Me.SirketlerDGV.RowHeadersVisible = False
        Me.SirketlerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SirketlerDGV.Size = New System.Drawing.Size(240, 323)
        Me.SirketlerDGV.TabIndex = 14
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Image = Global.BipStokTut.My.Resources.Resources.Kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(219, 12)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(68, 64)
        Me.KaydetBtn.TabIndex = 18
        Me.KaydetBtn.Text = "&Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KaydetBtn.UseVisualStyleBackColor = True
        '
        'SilBtn
        '
        Me.SilBtn.Image = Global.BipStokTut.My.Resources.Resources.Sil
        Me.SilBtn.Location = New System.Drawing.Point(151, 12)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(68, 64)
        Me.SilBtn.TabIndex = 17
        Me.SilBtn.Text = "&Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SilBtn.UseVisualStyleBackColor = True
        '
        'DuzenleBtn
        '
        Me.DuzenleBtn.Image = Global.BipStokTut.My.Resources.Resources.Duzenle
        Me.DuzenleBtn.Location = New System.Drawing.Point(83, 12)
        Me.DuzenleBtn.Name = "DuzenleBtn"
        Me.DuzenleBtn.Size = New System.Drawing.Size(68, 64)
        Me.DuzenleBtn.TabIndex = 16
        Me.DuzenleBtn.Text = "&Düzenle"
        Me.DuzenleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DuzenleBtn.UseVisualStyleBackColor = True
        '
        'EkleBtn
        '
        Me.EkleBtn.Image = Global.BipStokTut.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(15, 12)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(68, 64)
        Me.EkleBtn.TabIndex = 15
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.EkleBtn.UseVisualStyleBackColor = True
        '
        'SirketNoC
        '
        Me.SirketNoC.DataPropertyName = "SirketNo"
        Me.SirketNoC.HeaderText = "Şirket No"
        Me.SirketNoC.Name = "SirketNoC"
        Me.SirketNoC.ReadOnly = True
        Me.SirketNoC.Visible = False
        '
        'SirketAdiC
        '
        Me.SirketAdiC.DataPropertyName = "SirketAdi"
        Me.SirketAdiC.HeaderText = "Şirket Adı"
        Me.SirketAdiC.Name = "SirketAdiC"
        Me.SirketAdiC.ReadOnly = True
        Me.SirketAdiC.Width = 200
        '
        'YeniSirketKayitFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 350)
        Me.Controls.Add(Me.KaydetBtn)
        Me.Controls.Add(Me.SilBtn)
        Me.Controls.Add(Me.DuzenleBtn)
        Me.Controls.Add(Me.EkleBtn)
        Me.Controls.Add(Me.SirketlerDGV)
        Me.Controls.Add(Me.AdresiTBox)
        Me.Controls.Add(Me.VergiDairesiTBox)
        Me.Controls.Add(Me.VergiTCKimlikNoTBox)
        Me.Controls.Add(Me.E_PostaTBox)
        Me.Controls.Add(Me.FaksTBox)
        Me.Controls.Add(Me.TelefonuTBox)
        Me.Controls.Add(Me.SirketAdiTBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "YeniSirketKayitFormu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Yeni Şirket Kaydı"
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirketTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirketlerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SirketAdiTBox As TextBox
    Friend WithEvents TelefonuTBox As TextBox
    Friend WithEvents FaksTBox As TextBox
    Friend WithEvents E_PostaTBox As TextBox
    Friend WithEvents VergiTCKimlikNoTBox As TextBox
    Friend WithEvents VergiDairesiTBox As TextBox
    Friend WithEvents AdresiTBox As TextBox
    Friend WithEvents BipStokVTDS As DataSet
    Friend WithEvents SirketTablosuBS As BindingSource
    Friend WithEvents SirketlerDGV As DataGridView
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents DuzenleBtn As Button
    Friend WithEvents EkleBtn As Button
    Friend WithEvents SirketNoC As DataGridViewTextBoxColumn
    Friend WithEvents SirketAdiC As DataGridViewTextBoxColumn
End Class
