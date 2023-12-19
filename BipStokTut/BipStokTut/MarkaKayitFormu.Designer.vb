<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkaKayitFormu
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MarkaAdiTBox = New System.Windows.Forms.TextBox()
        Me.MarkaTablosuDGV = New System.Windows.Forms.DataGridView()
        Me.MarkaNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.DuzenleBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.BipStokVTDS = New System.Data.DataSet()
        Me.MarkaTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MarkaTablosuDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkaTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marka Adı:"
        '
        'MarkaAdiTBox
        '
        Me.MarkaAdiTBox.Location = New System.Drawing.Point(15, 52)
        Me.MarkaAdiTBox.Name = "MarkaAdiTBox"
        Me.MarkaAdiTBox.ReadOnly = True
        Me.MarkaAdiTBox.Size = New System.Drawing.Size(311, 20)
        Me.MarkaAdiTBox.TabIndex = 1
        '
        'MarkaTablosuDGV
        '
        Me.MarkaTablosuDGV.AllowUserToAddRows = False
        Me.MarkaTablosuDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MarkaTablosuDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MarkaTablosuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarkaTablosuDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarkaNoC, Me.MarkaAdiC})
        Me.MarkaTablosuDGV.Location = New System.Drawing.Point(12, 87)
        Me.MarkaTablosuDGV.MultiSelect = False
        Me.MarkaTablosuDGV.Name = "MarkaTablosuDGV"
        Me.MarkaTablosuDGV.ReadOnly = True
        Me.MarkaTablosuDGV.RowHeadersVisible = False
        Me.MarkaTablosuDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MarkaTablosuDGV.Size = New System.Drawing.Size(314, 217)
        Me.MarkaTablosuDGV.TabIndex = 2
        '
        'MarkaNoC
        '
        Me.MarkaNoC.HeaderText = "Marka No"
        Me.MarkaNoC.Name = "MarkaNoC"
        Me.MarkaNoC.ReadOnly = True
        Me.MarkaNoC.Visible = False
        '
        'MarkaAdiC
        '
        Me.MarkaAdiC.HeaderText = "Marka Adı"
        Me.MarkaAdiC.Name = "MarkaAdiC"
        Me.MarkaAdiC.ReadOnly = True
        Me.MarkaAdiC.Width = 250
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.KaydetBtn)
        Me.Panel1.Controls.Add(Me.SilBtn)
        Me.Panel1.Controls.Add(Me.DuzenleBtn)
        Me.Panel1.Controls.Add(Me.EkleBtn)
        Me.Panel1.Location = New System.Drawing.Point(15, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 64)
        Me.Panel1.TabIndex = 3
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.KaydetBtn.Image = Global.BipStokTut.My.Resources.Resources.Kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(225, 0)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(75, 64)
        Me.KaydetBtn.TabIndex = 3
        Me.KaydetBtn.Text = "&Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KaydetBtn.UseVisualStyleBackColor = True
        '
        'SilBtn
        '
        Me.SilBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.SilBtn.Image = Global.BipStokTut.My.Resources.Resources.Sil
        Me.SilBtn.Location = New System.Drawing.Point(150, 0)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(75, 64)
        Me.SilBtn.TabIndex = 2
        Me.SilBtn.Text = "&Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SilBtn.UseVisualStyleBackColor = True
        '
        'DuzenleBtn
        '
        Me.DuzenleBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.DuzenleBtn.Image = Global.BipStokTut.My.Resources.Resources.Duzenle
        Me.DuzenleBtn.Location = New System.Drawing.Point(75, 0)
        Me.DuzenleBtn.Name = "DuzenleBtn"
        Me.DuzenleBtn.Size = New System.Drawing.Size(75, 64)
        Me.DuzenleBtn.TabIndex = 1
        Me.DuzenleBtn.Text = "&Düzenle"
        Me.DuzenleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DuzenleBtn.UseVisualStyleBackColor = True
        '
        'EkleBtn
        '
        Me.EkleBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.EkleBtn.Image = Global.BipStokTut.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(0, 0)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(75, 64)
        Me.EkleBtn.TabIndex = 0
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.EkleBtn.UseVisualStyleBackColor = True
        '
        'BipStokVTDS
        '
        Me.BipStokVTDS.DataSetName = "NewDataSet"
        '
        'MarkaTablosuBS
        '
        '
        'MarkaKayitFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 398)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MarkaTablosuDGV)
        Me.Controls.Add(Me.MarkaAdiTBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MarkaKayitFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Marka Kaydı"
        CType(Me.MarkaTablosuDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkaTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MarkaAdiTBox As TextBox
    Friend WithEvents MarkaTablosuDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EkleBtn As Button
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents DuzenleBtn As Button
    Friend WithEvents BipStokVTDS As DataSet
    Friend WithEvents MarkaTablosuBS As BindingSource
    Friend WithEvents MarkaNoC As DataGridViewTextBoxColumn
    Friend WithEvents MarkaAdiC As DataGridViewTextBoxColumn
End Class
