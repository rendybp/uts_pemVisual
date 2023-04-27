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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WARNET GGWP GAME CENTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Paket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga / jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 519)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kembalian"
        '
        'jenisPaket
        '
        Me.jenisPaket.FormattingEnabled = True
        Me.jenisPaket.Items.AddRange(New Object() {"REGULER", "VIP", "BATTLE ARENA"})
        Me.jenisPaket.Location = New System.Drawing.Point(236, 135)
        Me.jenisPaket.Name = "jenisPaket"
        Me.jenisPaket.Size = New System.Drawing.Size(249, 28)
        Me.jenisPaket.TabIndex = 9
        '
        'hargaInput
        '
        Me.hargaInput.Location = New System.Drawing.Point(236, 186)
        Me.hargaInput.Name = "hargaInput"
        Me.hargaInput.Size = New System.Drawing.Size(249, 26)
        Me.hargaInput.TabIndex = 10
        '
        'jumlahInput
        '
        Me.jumlahInput.Location = New System.Drawing.Point(236, 244)
        Me.jumlahInput.Name = "jumlahInput"
        Me.jumlahInput.Size = New System.Drawing.Size(249, 26)
        Me.jumlahInput.TabIndex = 11
        '
        'totalHargaOutput
        '
        Me.totalHargaOutput.Location = New System.Drawing.Point(236, 300)
        Me.totalHargaOutput.Name = "totalHargaOutput"
        Me.totalHargaOutput.Size = New System.Drawing.Size(249, 26)
        Me.totalHargaOutput.TabIndex = 12
        '
        'diskonOutput
        '
        Me.diskonOutput.Location = New System.Drawing.Point(236, 352)
        Me.diskonOutput.Name = "diskonOutput"
        Me.diskonOutput.Size = New System.Drawing.Size(249, 26)
        Me.diskonOutput.TabIndex = 13
        '
        'totalBayarOutput
        '
        Me.totalBayarOutput.Location = New System.Drawing.Point(236, 405)
        Me.totalBayarOutput.Name = "totalBayarOutput"
        Me.totalBayarOutput.Size = New System.Drawing.Size(249, 26)
        Me.totalBayarOutput.TabIndex = 14
        '
        'bayarInput
        '
        Me.bayarInput.Location = New System.Drawing.Point(236, 460)
        Me.bayarInput.Name = "bayarInput"
        Me.bayarInput.Size = New System.Drawing.Size(249, 26)
        Me.bayarInput.TabIndex = 15
        '
        'kembalianOutput
        '
        Me.kembalianOutput.Location = New System.Drawing.Point(236, 516)
        Me.kembalianOutput.Name = "kembalianOutput"
        Me.kembalianOutput.Size = New System.Drawing.Size(249, 26)
        Me.kembalianOutput.TabIndex = 16
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(184, 595)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 38)
        Me.btnProses.TabIndex = 17
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnUlangi
        '
        Me.btnUlangi.Location = New System.Drawing.Point(295, 595)
        Me.btnUlangi.Name = "btnUlangi"
        Me.btnUlangi.Size = New System.Drawing.Size(75, 38)
        Me.btnUlangi.TabIndex = 18
        Me.btnUlangi.Text = "Ulangi"
        Me.btnUlangi.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(410, 595)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 659)
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
        Me.Text = "Form1"
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

End Class
