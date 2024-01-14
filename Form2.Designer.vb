<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Hasil2 = New System.Windows.Forms.Label
        Me.txtbawah = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtatas = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.lsthasil = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batas Atas "
        '
        'Hasil2
        '
        Me.Hasil2.AutoSize = True
        Me.Hasil2.Location = New System.Drawing.Point(12, 72)
        Me.Hasil2.Name = "Hasil2"
        Me.Hasil2.Size = New System.Drawing.Size(73, 13)
        Me.Hasil2.TabIndex = 1
        Me.Hasil2.Text = "Batas Bawah "
        '
        'txtbawah
        '
        Me.txtbawah.Location = New System.Drawing.Point(142, 36)
        Me.txtbawah.Name = "txtbawah"
        Me.txtbawah.Size = New System.Drawing.Size(100, 20)
        Me.txtbawah.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ganjil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtatas
        '
        Me.txtatas.Location = New System.Drawing.Point(142, 72)
        Me.txtatas.Name = "txtatas"
        Me.txtatas.Size = New System.Drawing.Size(100, 20)
        Me.txtatas.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasil"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(417, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 26)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Genap"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(388, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lsthasil
        '
        Me.lsthasil.FormattingEnabled = True
        Me.lsthasil.Location = New System.Drawing.Point(142, 112)
        Me.lsthasil.Name = "lsthasil"
        Me.lsthasil.Size = New System.Drawing.Size(203, 134)
        Me.lsthasil.TabIndex = 9
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 261)
        Me.Controls.Add(Me.lsthasil)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtatas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbawah)
        Me.Controls.Add(Me.Hasil2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Hasil2 As System.Windows.Forms.Label
    Friend WithEvents txtbawah As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtatas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lsthasil As System.Windows.Forms.ListBox
End Class
