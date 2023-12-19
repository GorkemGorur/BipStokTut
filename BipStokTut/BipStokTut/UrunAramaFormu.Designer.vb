<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UrunAramaFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.UrunAdiTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UrunTablosuDGV = New System.Windows.Forms.DataGridView()
        Me.BipStokVTDS = New System.Data.DataSet()
        Me.UrunTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.UrunNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunGrupNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirimCinsiNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunGrupAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirimCinsiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarkodNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UretimYeriC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AciklamaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UrunTablosuDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UrunTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 518)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(778, 44)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(383, 38)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Tamam"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(392, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(383, 38)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "&Vazgeç"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.AraBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UrunAdiTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UrunTablosuDGV)
        Me.SplitContainer1.Size = New System.Drawing.Size(778, 518)
        Me.SplitContainer1.SplitterDistance = 120
        Me.SplitContainer1.TabIndex = 1
        '
        'AraBtn
        '
        Me.AraBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.AraBtn.Location = New System.Drawing.Point(693, 10)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(75, 100)
        Me.AraBtn.TabIndex = 2
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.UseVisualStyleBackColor = True
        '
        'UrunAdiTBox
        '
        Me.UrunAdiTBox.Location = New System.Drawing.Point(110, 41)
        Me.UrunAdiTBox.Name = "UrunAdiTBox"
        Me.UrunAdiTBox.Size = New System.Drawing.Size(553, 20)
        Me.UrunAdiTBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ürün Adı:"
        '
        'UrunTablosuDGV
        '
        Me.UrunTablosuDGV.AllowUserToAddRows = False
        Me.UrunTablosuDGV.AllowUserToDeleteRows = False
        Me.UrunTablosuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UrunTablosuDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UrunNoC, Me.MarkaNoC, Me.UrunGrupNoC, Me.BirimCinsiNoC, Me.UrunAdiC, Me.MarkaAdiC, Me.UrunGrupAdiC, Me.BirimCinsiC, Me.BarkodNoC, Me.UretimYeriC, Me.AciklamaC})
        Me.UrunTablosuDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UrunTablosuDGV.Location = New System.Drawing.Point(0, 0)
        Me.UrunTablosuDGV.MultiSelect = False
        Me.UrunTablosuDGV.Name = "UrunTablosuDGV"
        Me.UrunTablosuDGV.ReadOnly = True
        Me.UrunTablosuDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UrunTablosuDGV.Size = New System.Drawing.Size(778, 394)
        Me.UrunTablosuDGV.TabIndex = 0
        '
        'BipStokVTDS
        '
        Me.BipStokVTDS.DataSetName = "NewDataSet"
        '
        'UrunNoC
        '
        Me.UrunNoC.DataPropertyName = "UrunNo"
        Me.UrunNoC.HeaderText = "Ürün No"
        Me.UrunNoC.Name = "UrunNoC"
        Me.UrunNoC.ReadOnly = True
        Me.UrunNoC.Visible = False
        '
        'MarkaNoC
        '
        Me.MarkaNoC.DataPropertyName = "MarkaNo"
        Me.MarkaNoC.HeaderText = "Marka No"
        Me.MarkaNoC.Name = "MarkaNoC"
        Me.MarkaNoC.ReadOnly = True
        Me.MarkaNoC.Visible = False
        '
        'UrunGrupNoC
        '
        Me.UrunGrupNoC.DataPropertyName = "UrunGrupNo"
        Me.UrunGrupNoC.HeaderText = "Ürün Grup No"
        Me.UrunGrupNoC.Name = "UrunGrupNoC"
        Me.UrunGrupNoC.ReadOnly = True
        Me.UrunGrupNoC.Visible = False
        '
        'BirimCinsiNoC
        '
        Me.BirimCinsiNoC.DataPropertyName = "BirimCinsiNo"
        Me.BirimCinsiNoC.HeaderText = "Birim Cinsi No"
        Me.BirimCinsiNoC.Name = "BirimCinsiNoC"
        Me.BirimCinsiNoC.ReadOnly = True
        Me.BirimCinsiNoC.Visible = False
        '
        'UrunAdiC
        '
        Me.UrunAdiC.DataPropertyName = "UrunAdi"
        Me.UrunAdiC.HeaderText = "Ürün Adı"
        Me.UrunAdiC.Name = "UrunAdiC"
        Me.UrunAdiC.ReadOnly = True
        '
        'MarkaAdiC
        '
        Me.MarkaAdiC.DataPropertyName = "MarkaAdi"
        Me.MarkaAdiC.HeaderText = "Marka Adı"
        Me.MarkaAdiC.Name = "MarkaAdiC"
        Me.MarkaAdiC.ReadOnly = True
        '
        'UrunGrupAdiC
        '
        Me.UrunGrupAdiC.DataPropertyName = "UrunGrupAdi"
        Me.UrunGrupAdiC.HeaderText = "Ürün Grubu"
        Me.UrunGrupAdiC.Name = "UrunGrupAdiC"
        Me.UrunGrupAdiC.ReadOnly = True
        '
        'BirimCinsiC
        '
        Me.BirimCinsiC.DataPropertyName = "BirimCinsi"
        Me.BirimCinsiC.HeaderText = "Birim Cinsi"
        Me.BirimCinsiC.Name = "BirimCinsiC"
        Me.BirimCinsiC.ReadOnly = True
        '
        'BarkodNoC
        '
        Me.BarkodNoC.DataPropertyName = "BarkodNo"
        Me.BarkodNoC.HeaderText = "Barkod No"
        Me.BarkodNoC.Name = "BarkodNoC"
        Me.BarkodNoC.ReadOnly = True
        '
        'UretimYeriC
        '
        Me.UretimYeriC.DataPropertyName = "UretimYeri"
        Me.UretimYeriC.HeaderText = "Üretim Yeri"
        Me.UretimYeriC.Name = "UretimYeriC"
        Me.UretimYeriC.ReadOnly = True
        '
        'AciklamaC
        '
        Me.AciklamaC.DataPropertyName = "Aciklama"
        Me.AciklamaC.HeaderText = "Açıklama"
        Me.AciklamaC.Name = "AciklamaC"
        Me.AciklamaC.ReadOnly = True
        '
        'UrunAramaFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(778, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UrunAramaFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ürün Arama"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UrunTablosuDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BipStokVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UrunTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents AraBtn As Button
    Friend WithEvents UrunAdiTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UrunTablosuDGV As DataGridView
    Friend WithEvents BipStokVTDS As DataSet
    Friend WithEvents UrunTablosuBS As BindingSource
    Friend WithEvents UrunNoC As DataGridViewTextBoxColumn
    Friend WithEvents MarkaNoC As DataGridViewTextBoxColumn
    Friend WithEvents UrunGrupNoC As DataGridViewTextBoxColumn
    Friend WithEvents BirimCinsiNoC As DataGridViewTextBoxColumn
    Friend WithEvents UrunAdiC As DataGridViewTextBoxColumn
    Friend WithEvents MarkaAdiC As DataGridViewTextBoxColumn
    Friend WithEvents UrunGrupAdiC As DataGridViewTextBoxColumn
    Friend WithEvents BirimCinsiC As DataGridViewTextBoxColumn
    Friend WithEvents BarkodNoC As DataGridViewTextBoxColumn
    Friend WithEvents UretimYeriC As DataGridViewTextBoxColumn
    Friend WithEvents AciklamaC As DataGridViewTextBoxColumn
End Class
