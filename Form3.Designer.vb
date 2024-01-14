<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextNIM = New System.Windows.Forms.TextBox
        Me.TextNama = New System.Windows.Forms.TextBox
        Me.TextTugas = New System.Windows.Forms.TextBox
        Me.TextUTS = New System.Windows.Forms.TextBox
        Me.TextUAS = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextKelas = New System.Windows.Forms.TextBox
        Me.TextAngka = New System.Windows.Forms.TextBox
        Me.BtnHitung = New System.Windows.Forms.Button
        Me.TextHuruf = New System.Windows.Forms.TextBox
        Me.TextKomentar = New System.Windows.Forms.TextBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai UTS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai UAS"
        '
        'TextNIM
        '
        Me.TextNIM.Location = New System.Drawing.Point(107, 28)
        Me.TextNIM.Name = "TextNIM"
        Me.TextNIM.Size = New System.Drawing.Size(100, 20)
        Me.TextNIM.TabIndex = 5
        '
        'TextNama
        '
        Me.TextNama.Location = New System.Drawing.Point(107, 65)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(100, 20)
        Me.TextNama.TabIndex = 6
        '
        'TextTugas
        '
        Me.TextTugas.Location = New System.Drawing.Point(107, 131)
        Me.TextTugas.Name = "TextTugas"
        Me.TextTugas.Size = New System.Drawing.Size(100, 20)
        Me.TextTugas.TabIndex = 7
        '
        'TextUTS
        '
        Me.TextUTS.Location = New System.Drawing.Point(107, 169)
        Me.TextUTS.Name = "TextUTS"
        Me.TextUTS.Size = New System.Drawing.Size(100, 20)
        Me.TextUTS.TabIndex = 8
        '
        'TextUAS
        '
        Me.TextUAS.Location = New System.Drawing.Point(107, 210)
        Me.TextUAS.Name = "TextUAS"
        Me.TextUAS.Size = New System.Drawing.Size(100, 20)
        Me.TextUAS.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Kelas"
        '
        'TextKelas
        '
        Me.TextKelas.Location = New System.Drawing.Point(107, 98)
        Me.TextKelas.Name = "TextKelas"
        Me.TextKelas.Size = New System.Drawing.Size(100, 20)
        Me.TextKelas.TabIndex = 11
        '
        'TextAngka
        '
        Me.TextAngka.Location = New System.Drawing.Point(34, 253)
        Me.TextAngka.Name = "TextAngka"
        Me.TextAngka.Size = New System.Drawing.Size(57, 20)
        Me.TextAngka.TabIndex = 12
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(243, 62)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 67)
        Me.BtnHitung.TabIndex = 13
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TextHuruf
        '
        Me.TextHuruf.Location = New System.Drawing.Point(150, 253)
        Me.TextHuruf.Name = "TextHuruf"
        Me.TextHuruf.Size = New System.Drawing.Size(57, 20)
        Me.TextHuruf.TabIndex = 14
        '
        'TextKomentar
        '
        Me.TextKomentar.Location = New System.Drawing.Point(34, 297)
        Me.TextKomentar.Name = "TextKomentar"
        Me.TextKomentar.Size = New System.Drawing.Size(232, 20)
        Me.TextKomentar.TabIndex = 15
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(243, 138)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 32)
        Me.BtnClear.TabIndex = 16
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(243, 176)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 28)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(553, 329)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TextKomentar)
        Me.Controls.Add(Me.TextHuruf)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TextAngka)
        Me.Controls.Add(Me.TextKelas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextUAS)
        Me.Controls.Add(Me.TextUTS)
        Me.Controls.Add(Me.TextTugas)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.TextNIM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextNIM As System.Windows.Forms.TextBox
    Friend WithEvents TextNama As System.Windows.Forms.TextBox
    Friend WithEvents TextTugas As System.Windows.Forms.TextBox
    Friend WithEvents TextUTS As System.Windows.Forms.TextBox
    Friend WithEvents TextUAS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextKelas As System.Windows.Forms.TextBox
    Friend WithEvents TextAngka As System.Windows.Forms.TextBox
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents TextHuruf As System.Windows.Forms.TextBox
    Friend WithEvents TextKomentar As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
End Class
