<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.jenisPaket = New System.Windows.Forms.ComboBox()
        Me.hargaInput = New System.Windows.Forms.TextBox()
        Me.jumlahInput = New System.Windows.Forms.TextBox()
        Me.totalHargaOutput = New System.Windows.Forms.TextBox()
        Me.diskonOutput = New System.Windows.Forms.TextBox()
        Me.totalBayarOutput = New System.Windows.Forms.TextBox()
        Me.bayarInput = New System.Windows.Forms.TextBox()
        Me.kembalianOutput = New System.Windows.Forms.TextBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnUlangi = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.userInput = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cashbackOutput = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucapan = New System.Windows.Forms.Label()
        Me.hasilKembalian = New System.Windows.Forms.Label()
        Me.hasilBayar = New System.Windows.Forms.Label()
        Me.pembatas = New System.Windows.Forms.Label()
        Me.hasilTotalBayar = New System.Windows.Forms.Label()
        Me.hasilDiskon = New System.Windows.Forms.Label()
        Me.hasilTotalHarga = New System.Windows.Forms.Label()
        Me.hasilJam = New System.Windows.Forms.Label()
        Me.hasilPaket = New System.Windows.Forms.Label()
        Me.hasilUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WARNET GGWP GAME CENTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Paket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga / jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 258)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 313)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 348)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kembalian"
        '
        'jenisPaket
        '
        Me.jenisPaket.FormattingEnabled = True
        Me.jenisPaket.Items.AddRange(New Object() {"Reguler", "VIP", "Battle Arena"})
        Me.jenisPaket.Location = New System.Drawing.Point(153, 68)
        Me.jenisPaket.Margin = New System.Windows.Forms.Padding(2)
        Me.jenisPaket.Name = "jenisPaket"
        Me.jenisPaket.Size = New System.Drawing.Size(167, 21)
        Me.jenisPaket.TabIndex = 9
        '
        'hargaInput
        '
        Me.hargaInput.Location = New System.Drawing.Point(153, 98)
        Me.hargaInput.Margin = New System.Windows.Forms.Padding(2)
        Me.hargaInput.Name = "hargaInput"
        Me.hargaInput.Size = New System.Drawing.Size(167, 20)
        Me.hargaInput.TabIndex = 10
        '
        'jumlahInput
        '
        Me.jumlahInput.Location = New System.Drawing.Point(153, 160)
        Me.jumlahInput.Margin = New System.Windows.Forms.Padding(2)
        Me.jumlahInput.Name = "jumlahInput"
        Me.jumlahInput.Size = New System.Drawing.Size(167, 20)
        Me.jumlahInput.TabIndex = 11
        '
        'totalHargaOutput
        '
        Me.totalHargaOutput.Location = New System.Drawing.Point(153, 192)
        Me.totalHargaOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.totalHargaOutput.Name = "totalHargaOutput"
        Me.totalHargaOutput.Size = New System.Drawing.Size(167, 20)
        Me.totalHargaOutput.TabIndex = 12
        '
        'diskonOutput
        '
        Me.diskonOutput.Location = New System.Drawing.Point(153, 224)
        Me.diskonOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.diskonOutput.Name = "diskonOutput"
        Me.diskonOutput.Size = New System.Drawing.Size(167, 20)
        Me.diskonOutput.TabIndex = 13
        '
        'totalBayarOutput
        '
        Me.totalBayarOutput.Location = New System.Drawing.Point(153, 256)
        Me.totalBayarOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.totalBayarOutput.Name = "totalBayarOutput"
        Me.totalBayarOutput.Size = New System.Drawing.Size(167, 20)
        Me.totalBayarOutput.TabIndex = 14
        '
        'bayarInput
        '
        Me.bayarInput.Location = New System.Drawing.Point(153, 311)
        Me.bayarInput.Margin = New System.Windows.Forms.Padding(2)
        Me.bayarInput.Name = "bayarInput"
        Me.bayarInput.Size = New System.Drawing.Size(167, 20)
        Me.bayarInput.TabIndex = 15
        '
        'kembalianOutput
        '
        Me.kembalianOutput.Location = New System.Drawing.Point(153, 346)
        Me.kembalianOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.kembalianOutput.Name = "kembalianOutput"
        Me.kembalianOutput.Size = New System.Drawing.Size(167, 20)
        Me.kembalianOutput.TabIndex = 16
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(87, 384)
        Me.btnProses.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(50, 25)
        Me.btnProses.TabIndex = 17
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnUlangi
        '
        Me.btnUlangi.Location = New System.Drawing.Point(161, 384)
        Me.btnUlangi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUlangi.Name = "btnUlangi"
        Me.btnUlangi.Size = New System.Drawing.Size(50, 25)
        Me.btnUlangi.TabIndex = 18
        Me.btnUlangi.Text = "Ulangi"
        Me.btnUlangi.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(237, 384)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 25)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 133)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Username"
        '
        'userInput
        '
        Me.userInput.Location = New System.Drawing.Point(153, 129)
        Me.userInput.Margin = New System.Windows.Forms.Padding(2)
        Me.userInput.Name = "userInput"
        Me.userInput.Size = New System.Drawing.Size(167, 20)
        Me.userInput.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(76, 39)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(231, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cashback 5Rb Setiap Pembelian Diatas 100Rb"
        '
        'cashbackOutput
        '
        Me.cashbackOutput.AutoSize = True
        Me.cashbackOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashbackOutput.Location = New System.Drawing.Point(87, 285)
        Me.cashbackOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cashbackOutput.Name = "cashbackOutput"
        Me.cashbackOutput.Size = New System.Drawing.Size(195, 13)
        Me.cashbackOutput.TabIndex = 23
        Me.cashbackOutput.Text = "Selamat Anda Mendapat Cash Back 5K"
        Me.cashbackOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucapan)
        Me.GroupBox1.Controls.Add(Me.hasilKembalian)
        Me.GroupBox1.Controls.Add(Me.hasilBayar)
        Me.GroupBox1.Controls.Add(Me.pembatas)
        Me.GroupBox1.Controls.Add(Me.hasilTotalBayar)
        Me.GroupBox1.Controls.Add(Me.hasilDiskon)
        Me.GroupBox1.Controls.Add(Me.hasilTotalHarga)
        Me.GroupBox1.Controls.Add(Me.hasilJam)
        Me.GroupBox1.Controls.Add(Me.hasilPaket)
        Me.GroupBox1.Controls.Add(Me.hasilUser)
        Me.GroupBox1.Location = New System.Drawing.Point(366, 125)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(231, 283)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hasil"
        '
        'ucapan
        '
        Me.ucapan.AutoSize = True
        Me.ucapan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucapan.Location = New System.Drawing.Point(74, 252)
        Me.ucapan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ucapan.Name = "ucapan"
        Me.ucapan.Size = New System.Drawing.Size(86, 13)
        Me.ucapan.TabIndex = 9
        Me.ucapan.Text = "Selamat Bermain"
        '
        'hasilKembalian
        '
        Me.hasilKembalian.AutoSize = True
        Me.hasilKembalian.Location = New System.Drawing.Point(22, 225)
        Me.hasilKembalian.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilKembalian.Name = "hasilKembalian"
        Me.hasilKembalian.Size = New System.Drawing.Size(77, 13)
        Me.hasilKembalian.TabIndex = 8
        Me.hasilKembalian.Text = "Kembalian      :"
        '
        'hasilBayar
        '
        Me.hasilBayar.AutoSize = True
        Me.hasilBayar.Location = New System.Drawing.Point(23, 202)
        Me.hasilBayar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilBayar.Name = "hasilBayar"
        Me.hasilBayar.Size = New System.Drawing.Size(76, 13)
        Me.hasilBayar.TabIndex = 7
        Me.hasilBayar.Text = "Bayar             :"
        '
        'pembatas
        '
        Me.pembatas.AutoSize = True
        Me.pembatas.Location = New System.Drawing.Point(23, 179)
        Me.pembatas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pembatas.Name = "pembatas"
        Me.pembatas.Size = New System.Drawing.Size(187, 13)
        Me.pembatas.TabIndex = 6
        Me.pembatas.Text = "=============================="
        '
        'hasilTotalBayar
        '
        Me.hasilTotalBayar.AutoSize = True
        Me.hasilTotalBayar.Location = New System.Drawing.Point(23, 150)
        Me.hasilTotalBayar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilTotalBayar.Name = "hasilTotalBayar"
        Me.hasilTotalBayar.Size = New System.Drawing.Size(76, 13)
        Me.hasilTotalBayar.TabIndex = 5
        Me.hasilTotalBayar.Text = "Total Bayar    :"
        '
        'hasilDiskon
        '
        Me.hasilDiskon.AutoSize = True
        Me.hasilDiskon.Location = New System.Drawing.Point(23, 125)
        Me.hasilDiskon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilDiskon.Name = "hasilDiskon"
        Me.hasilDiskon.Size = New System.Drawing.Size(76, 13)
        Me.hasilDiskon.TabIndex = 4
        Me.hasilDiskon.Text = "Diskon           :"
        '
        'hasilTotalHarga
        '
        Me.hasilTotalHarga.AutoSize = True
        Me.hasilTotalHarga.Location = New System.Drawing.Point(21, 100)
        Me.hasilTotalHarga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilTotalHarga.Name = "hasilTotalHarga"
        Me.hasilTotalHarga.Size = New System.Drawing.Size(78, 13)
        Me.hasilTotalHarga.TabIndex = 3
        Me.hasilTotalHarga.Text = "Total Harga    :"
        '
        'hasilJam
        '
        Me.hasilJam.AutoSize = True
        Me.hasilJam.Location = New System.Drawing.Point(21, 77)
        Me.hasilJam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilJam.Name = "hasilJam"
        Me.hasilJam.Size = New System.Drawing.Size(80, 13)
        Me.hasilJam.TabIndex = 2
        Me.hasilJam.Text = "Jumlah Jam     :"
        '
        'hasilPaket
        '
        Me.hasilPaket.AutoSize = True
        Me.hasilPaket.Location = New System.Drawing.Point(23, 53)
        Me.hasilPaket.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilPaket.Name = "hasilPaket"
        Me.hasilPaket.Size = New System.Drawing.Size(77, 13)
        Me.hasilPaket.TabIndex = 1
        Me.hasilPaket.Text = "Paket             :"
        '
        'hasilUser
        '
        Me.hasilUser.AutoSize = True
        Me.hasilUser.Location = New System.Drawing.Point(21, 29)
        Me.hasilUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hasilUser.Name = "hasilUser"
        Me.hasilUser.Size = New System.Drawing.Size(77, 13)
        Me.hasilUser.TabIndex = 0
        Me.hasilUser.Text = "User               :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logo_valorant
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(366, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(231, 90)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(637, 435)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cashbackOutput)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.userInput)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUlangi)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.kembalianOutput)
        Me.Controls.Add(Me.bayarInput)
        Me.Controls.Add(Me.totalBayarOutput)
        Me.Controls.Add(Me.diskonOutput)
        Me.Controls.Add(Me.totalHargaOutput)
        Me.Controls.Add(Me.jumlahInput)
        Me.Controls.Add(Me.hargaInput)
        Me.Controls.Add(Me.jenisPaket)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Warnet GGWP Game Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents jenisPaket As System.Windows.Forms.ComboBox
    Friend WithEvents hargaInput As System.Windows.Forms.TextBox
    Friend WithEvents jumlahInput As System.Windows.Forms.TextBox
    Friend WithEvents totalHargaOutput As System.Windows.Forms.TextBox
    Friend WithEvents diskonOutput As System.Windows.Forms.TextBox
    Friend WithEvents totalBayarOutput As System.Windows.Forms.TextBox
    Friend WithEvents bayarInput As System.Windows.Forms.TextBox
    Friend WithEvents kembalianOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnUlangi As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents userInput As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cashbackOutput As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents hasilTotalBayar As System.Windows.Forms.Label
    Friend WithEvents hasilDiskon As System.Windows.Forms.Label
    Friend WithEvents hasilTotalHarga As System.Windows.Forms.Label
    Friend WithEvents hasilJam As System.Windows.Forms.Label
    Friend WithEvents hasilPaket As System.Windows.Forms.Label
    Friend WithEvents hasilUser As System.Windows.Forms.Label
    Friend WithEvents ucapan As System.Windows.Forms.Label
    Friend WithEvents hasilKembalian As System.Windows.Forms.Label
    Friend WithEvents hasilBayar As System.Windows.Forms.Label
    Friend WithEvents pembatas As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
