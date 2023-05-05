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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
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
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(33, 346)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 20)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Kembalian     :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(34, 311)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 20)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Bayar             :"
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, 232)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 20)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Total Bayar   :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 20)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Diskon           :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 20)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Total Harga   :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Jml Jam         :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 20)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Paket             :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "User               :"
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
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
