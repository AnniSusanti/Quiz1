﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.cmbKamar = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHarga = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtlayanan = New System.Windows.Forms.TextBox
        Me.txtBiaya = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Keterangan = New System.Windows.Forms.Label
        Me.cmbTambahan = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTambahan = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TanggalBO = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Hotel1 = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'cmbKamar
        '
        Me.cmbKamar.FormattingEnabled = True
        Me.cmbKamar.Location = New System.Drawing.Point(530, 31)
        Me.cmbKamar.Name = "cmbKamar"
        Me.cmbKamar.Size = New System.Drawing.Size(121, 21)
        Me.cmbKamar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis Kamar"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(530, 75)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(121, 20)
        Me.txtHarga.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga Sewa Perhari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipe Layanan"
        '
        'txtlayanan
        '
        Me.txtlayanan.Location = New System.Drawing.Point(530, 111)
        Me.txtlayanan.Name = "txtlayanan"
        Me.txtlayanan.Size = New System.Drawing.Size(121, 20)
        Me.txtlayanan.TabIndex = 5
        '
        'txtBiaya
        '
        Me.txtBiaya.Location = New System.Drawing.Point(788, 27)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(121, 20)
        Me.txtBiaya.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(679, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Biaya"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No Identitas"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(192, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nama "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No Telepon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Alamat"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(192, 127)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(192, 168)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 81)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(530, 151)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(121, 20)
        Me.TextBox5.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(401, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Lama Menginap"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Keterangan
        '
        Me.Keterangan.AutoSize = True
        Me.Keterangan.Location = New System.Drawing.Point(401, 226)
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Size = New System.Drawing.Size(87, 13)
        Me.Keterangan.TabIndex = 20
        Me.Keterangan.Text = "Biaya Tambahan"
        '
        'cmbTambahan
        '
        Me.cmbTambahan.FormattingEnabled = True
        Me.cmbTambahan.Location = New System.Drawing.Point(530, 192)
        Me.cmbTambahan.Name = "cmbTambahan"
        Me.cmbTambahan.Size = New System.Drawing.Size(121, 21)
        Me.cmbTambahan.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(405, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Keterangan"
        '
        'txtTambahan
        '
        Me.txtTambahan.Location = New System.Drawing.Point(530, 226)
        Me.txtTambahan.Name = "txtTambahan"
        Me.txtTambahan.Size = New System.Drawing.Size(121, 20)
        Me.txtTambahan.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(682, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(256, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TanggalBO
        '
        Me.TanggalBO.Location = New System.Drawing.Point(192, 256)
        Me.TanggalBO.Name = "TanggalBO"
        Me.TanggalBO.Size = New System.Drawing.Size(200, 20)
        Me.TanggalBO.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(72, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Tanggal Booking"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(682, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(256, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Simpan Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Hotel1
        '
        Me.Hotel1.Location = New System.Drawing.Point(13, 294)
        Me.Hotel1.Name = "Hotel1"
        Me.Hotel1.Size = New System.Drawing.Size(1044, 215)
        Me.Hotel1.TabIndex = 29
        Me.Hotel1.UseCompatibleStateImageBehavior = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 521)
        Me.Controls.Add(Me.Hotel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TanggalBO)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtTambahan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbTambahan)
        Me.Controls.Add(Me.Keterangan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtlayanan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbKamar)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbKamar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlayanan As System.Windows.Forms.TextBox
    Friend WithEvents txtBiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Keterangan As System.Windows.Forms.Label
    Friend WithEvents cmbTambahan As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTambahan As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TanggalBO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Hotel1 As System.Windows.Forms.ListView
End Class
