<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KullaniciKayitFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.KullaniciEkleBtn = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AdTBox = New System.Windows.Forms.TextBox()
        Me.SifreTBox = New System.Windows.Forms.TextBox()
        Me.TekrarTBox = New System.Windows.Forms.TextBox()
        Me.SoruTBox = New System.Windows.Forms.TextBox()
        Me.CevapTBox = New System.Windows.Forms.TextBox()
        Me.EPostaTBox = New System.Windows.Forms.TextBox()
        Me.ResimPBox = New System.Windows.Forms.PictureBox()
        Me.ResimEkleBtn = New System.Windows.Forms.Button()
        Me.ResimOFD = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ResimPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.KullaniciEkleBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 192)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(398, 47)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'KullaniciEkleBtn
        '
        Me.KullaniciEkleBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KullaniciEkleBtn.Location = New System.Drawing.Point(3, 3)
        Me.KullaniciEkleBtn.Name = "KullaniciEkleBtn"
        Me.KullaniciEkleBtn.Size = New System.Drawing.Size(193, 41)
        Me.KullaniciEkleBtn.TabIndex = 0
        Me.KullaniciEkleBtn.Text = "Kullanıcıyı Ekle"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(202, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(193, 41)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Vazgeç"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Şifre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Şifre Tekrarı:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Güvenlik Sorusu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cevap:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "E-Posta Adresi:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Resim:"
        '
        'AdTBox
        '
        Me.AdTBox.Location = New System.Drawing.Point(108, 22)
        Me.AdTBox.Name = "AdTBox"
        Me.AdTBox.Size = New System.Drawing.Size(100, 20)
        Me.AdTBox.TabIndex = 8
        '
        'SifreTBox
        '
        Me.SifreTBox.Location = New System.Drawing.Point(108, 48)
        Me.SifreTBox.Name = "SifreTBox"
        Me.SifreTBox.Size = New System.Drawing.Size(100, 20)
        Me.SifreTBox.TabIndex = 9
        Me.SifreTBox.UseSystemPasswordChar = True
        '
        'TekrarTBox
        '
        Me.TekrarTBox.Location = New System.Drawing.Point(108, 74)
        Me.TekrarTBox.Name = "TekrarTBox"
        Me.TekrarTBox.Size = New System.Drawing.Size(100, 20)
        Me.TekrarTBox.TabIndex = 10
        Me.TekrarTBox.UseSystemPasswordChar = True
        '
        'SoruTBox
        '
        Me.SoruTBox.Location = New System.Drawing.Point(108, 100)
        Me.SoruTBox.Name = "SoruTBox"
        Me.SoruTBox.Size = New System.Drawing.Size(153, 20)
        Me.SoruTBox.TabIndex = 11
        '
        'CevapTBox
        '
        Me.CevapTBox.Location = New System.Drawing.Point(108, 126)
        Me.CevapTBox.Name = "CevapTBox"
        Me.CevapTBox.Size = New System.Drawing.Size(153, 20)
        Me.CevapTBox.TabIndex = 12
        '
        'EPostaTBox
        '
        Me.EPostaTBox.Location = New System.Drawing.Point(108, 152)
        Me.EPostaTBox.Name = "EPostaTBox"
        Me.EPostaTBox.Size = New System.Drawing.Size(196, 20)
        Me.EPostaTBox.TabIndex = 13
        '
        'ResimPBox
        '
        Me.ResimPBox.BackColor = System.Drawing.Color.White
        Me.ResimPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResimPBox.Location = New System.Drawing.Point(310, 41)
        Me.ResimPBox.Name = "ResimPBox"
        Me.ResimPBox.Size = New System.Drawing.Size(100, 101)
        Me.ResimPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ResimPBox.TabIndex = 14
        Me.ResimPBox.TabStop = False
        '
        'ResimEkleBtn
        '
        Me.ResimEkleBtn.Location = New System.Drawing.Point(310, 146)
        Me.ResimEkleBtn.Name = "ResimEkleBtn"
        Me.ResimEkleBtn.Size = New System.Drawing.Size(100, 27)
        Me.ResimEkleBtn.TabIndex = 15
        Me.ResimEkleBtn.Text = "Resim Ekle"
        Me.ResimEkleBtn.UseVisualStyleBackColor = True
        '
        'ResimOFD
        '
        Me.ResimOFD.FileName = "OpenFileDialog1"
        '
        'KullaniciKayitFormu
        '
        Me.AcceptButton = Me.KullaniciEkleBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(425, 251)
        Me.Controls.Add(Me.ResimEkleBtn)
        Me.Controls.Add(Me.ResimPBox)
        Me.Controls.Add(Me.EPostaTBox)
        Me.Controls.Add(Me.CevapTBox)
        Me.Controls.Add(Me.SoruTBox)
        Me.Controls.Add(Me.TekrarTBox)
        Me.Controls.Add(Me.SifreTBox)
        Me.Controls.Add(Me.AdTBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KullaniciKayitFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Yeni Kullanıcı Ekle"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ResimPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents KullaniciEkleBtn As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AdTBox As TextBox
    Friend WithEvents SifreTBox As TextBox
    Friend WithEvents TekrarTBox As TextBox
    Friend WithEvents SoruTBox As TextBox
    Friend WithEvents CevapTBox As TextBox
    Friend WithEvents EPostaTBox As TextBox
    Friend WithEvents ResimPBox As PictureBox
    Friend WithEvents ResimEkleBtn As Button
    Friend WithEvents ResimOFD As OpenFileDialog
End Class
