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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.hasilKembalian = New System.Windows.Forms.Label()
        Me.hasilBayar = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.hasilTotalBayar = New System.Windows.Forms.Label()
        Me.hasilDiskon = New System.Windows.Forms.Label()
        Me.hasilTotalHarga = New System.Windows.Forms.Label()
        Me.hasilJam = New System.Windows.Forms.Label()
        Me.hasilPaket = New System.Windows.Forms.Label()
        Me.hasilUser = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WARNET GGWP GAME CENTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Paket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga / jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(79, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 518)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kembalian"
        '
        'jenisPaket
        '
        Me.jenisPaket.FormattingEnabled = True
        Me.jenisPaket.Items.AddRange(New Object() {"REGULER", "VIP", "BATTLE ARENA"})
        Me.jenisPaket.Location = New System.Drawing.Point(228, 97)
        Me.jenisPaket.Name = "jenisPaket"
        Me.jenisPaket.Size = New System.Drawing.Size(249, 28)
        Me.jenisPaket.TabIndex = 9
        '
        'hargaInput
        '
        Me.hargaInput.Location = New System.Drawing.Point(228, 143)
        Me.hargaInput.Name = "hargaInput"
        Me.hargaInput.Size = New System.Drawing.Size(249, 26)
        Me.hargaInput.TabIndex = 10
        '
        'jumlahInput
        '
        Me.jumlahInput.Location = New System.Drawing.Point(228, 229)
        Me.jumlahInput.Name = "jumlahInput"
        Me.jumlahInput.Size = New System.Drawing.Size(249, 26)
        Me.jumlahInput.TabIndex = 11
        '
        'totalHargaOutput
        '
        Me.totalHargaOutput.Location = New System.Drawing.Point(228, 278)
        Me.totalHargaOutput.Name = "totalHargaOutput"
        Me.totalHargaOutput.Size = New System.Drawing.Size(249, 26)
        Me.totalHargaOutput.TabIndex = 12
        '
        'diskonOutput
        '
        Me.diskonOutput.Location = New System.Drawing.Point(228, 327)
        Me.diskonOutput.Name = "diskonOutput"
        Me.diskonOutput.Size = New System.Drawing.Size(249, 26)
        Me.diskonOutput.TabIndex = 13
        '
        'totalBayarOutput
        '
        Me.totalBayarOutput.Location = New System.Drawing.Point(228, 377)
        Me.totalBayarOutput.Name = "totalBayarOutput"
        Me.totalBayarOutput.Size = New System.Drawing.Size(249, 26)
        Me.totalBayarOutput.TabIndex = 14
        '
        'bayarInput
        '
        Me.bayarInput.Location = New System.Drawing.Point(228, 461)
        Me.bayarInput.Name = "bayarInput"
        Me.bayarInput.Size = New System.Drawing.Size(249, 26)
        Me.bayarInput.TabIndex = 15
        '
        'kembalianOutput
        '
        Me.kembalianOutput.Location = New System.Drawing.Point(228, 515)
        Me.kembalianOutput.Name = "kembalianOutput"
        Me.kembalianOutput.Size = New System.Drawing.Size(249, 26)
        Me.kembalianOutput.TabIndex = 16
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(117, 591)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 38)
        Me.btnProses.TabIndex = 17
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnUlangi
        '
        Me.btnUlangi.Location = New System.Drawing.Point(228, 591)
        Me.btnUlangi.Name = "btnUlangi"
        Me.btnUlangi.Size = New System.Drawing.Size(75, 38)
        Me.btnUlangi.TabIndex = 18
        Me.btnUlangi.Text = "Ulangi"
        Me.btnUlangi.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(343, 591)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(79, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Username"
        '
        'userInput
        '
        Me.userInput.Location = New System.Drawing.Point(228, 188)
        Me.userInput.Name = "userInput"
        Me.userInput.Size = New System.Drawing.Size(249, 26)
        Me.userInput.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(113, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(344, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cashback 5Rb Setiap Pembelian Diatas 100Rb"
        '
        'cashbackOutput
        '
        Me.cashbackOutput.AutoSize = True
        Me.cashbackOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashbackOutput.Location = New System.Drawing.Point(128, 422)
        Me.cashbackOutput.Name = "cashbackOutput"
        Me.cashbackOutput.Size = New System.Drawing.Size(290, 20)
        Me.cashbackOutput.TabIndex = 23
        Me.cashbackOutput.Text = "Selamat Anda Mendapat Cash Back 5K"
        Me.cashbackOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.hasilKembalian)
        Me.GroupBox1.Controls.Add(Me.hasilBayar)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.hasilTotalBayar)
        Me.GroupBox1.Controls.Add(Me.hasilDiskon)
        Me.GroupBox1.Controls.Add(Me.hasilTotalHarga)
        Me.GroupBox1.Controls.Add(Me.hasilJam)
        Me.GroupBox1.Controls.Add(Me.hasilPaket)
        Me.GroupBox1.Controls.Add(Me.hasilUser)
        Me.GroupBox1.Location = New System.Drawing.Point(561, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 436)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hasil"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(111, 388)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(131, 20)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Selamat Bermain"
        '
        'hasilKembalian
        '
        Me.hasilKembalian.AutoSize = True
        Me.hasilKembalian.Location = New System.Drawing.Point(33, 346)
        Me.hasilKembalian.Name = "hasilKembalian"
        Me.hasilKembalian.Size = New System.Drawing.Size(107, 20)
        Me.hasilKembalian.TabIndex = 8
        Me.hasilKembalian.Text = "Kembalian     :"
        '
        'hasilBayar
        '
        Me.hasilBayar.AutoSize = True
        Me.hasilBayar.Location = New System.Drawing.Point(34, 311)
        Me.hasilBayar.Name = "hasilBayar"
        Me.hasilBayar.Size = New System.Drawing.Size(106, 20)
        Me.hasilBayar.TabIndex = 7
        Me.hasilBayar.Text = "Bayar             :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(34, 275)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(279, 20)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "=============================="
        '
        'hasilTotalBayar
        '
        Me.hasilTotalBayar.AutoSize = True
        Me.hasilTotalBayar.Location = New System.Drawing.Point(34, 232)
        Me.hasilTotalBayar.Name = "hasilTotalBayar"
        Me.hasilTotalBayar.Size = New System.Drawing.Size(105, 20)
        Me.hasilTotalBayar.TabIndex = 5
        Me.hasilTotalBayar.Text = "Total Bayar   :"
        '
        'hasilDiskon
        '
        Me.hasilDiskon.AutoSize = True
        Me.hasilDiskon.Location = New System.Drawing.Point(33, 194)
        Me.hasilDiskon.Name = "hasilDiskon"
        Me.hasilDiskon.Size = New System.Drawing.Size(106, 20)
        Me.hasilDiskon.TabIndex = 4
        Me.hasilDiskon.Text = "Diskon           :"
        '
        'hasilTotalHarga
        '
        Me.hasilTotalHarga.AutoSize = True
        Me.hasilTotalHarga.Location = New System.Drawing.Point(31, 157)
        Me.hasilTotalHarga.Name = "hasilTotalHarga"
        Me.hasilTotalHarga.Size = New System.Drawing.Size(108, 20)
        Me.hasilTotalHarga.TabIndex = 3
        Me.hasilTotalHarga.Text = "Total Harga   :"
        '
        'hasilJam
        '
        Me.hasilJam.AutoSize = True
        Me.hasilJam.Location = New System.Drawing.Point(32, 119)
        Me.hasilJam.Name = "hasilJam"
        Me.hasilJam.Size = New System.Drawing.Size(107, 20)
        Me.hasilJam.TabIndex = 2
        Me.hasilJam.Text = "Jml Jam         :"
        '
        'hasilPaket
        '
        Me.hasilPaket.AutoSize = True
        Me.hasilPaket.Location = New System.Drawing.Point(33, 82)
        Me.hasilPaket.Name = "hasilPaket"
        Me.hasilPaket.Size = New System.Drawing.Size(106, 20)
        Me.hasilPaket.TabIndex = 1
        Me.hasilPaket.Text = "Paket             :"
        '
        'hasilUser
        '
        Me.hasilUser.AutoSize = True
        Me.hasilUser.Location = New System.Drawing.Point(32, 44)
        Me.hasilUser.Name = "hasilUser"
        Me.hasilUser.Size = New System.Drawing.Size(107, 20)
        Me.hasilUser.TabIndex = 0
        Me.hasilUser.Text = "User               :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 732)
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
        Me.Name = "Form1"
        Me.Text = "Warnet GGWP Game Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents hasilKembalian As System.Windows.Forms.Label
    Friend WithEvents hasilBayar As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
