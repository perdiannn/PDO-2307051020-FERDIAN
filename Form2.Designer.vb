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
        Me.cmbxjurusan = New System.Windows.Forms.ComboBox()
        Me.cmbxfakultas = New System.Windows.Forms.ComboBox()
        Me.tbxnama = New System.Windows.Forms.TextBox()
        Me.tbxnip = New System.Windows.Forms.TextBox()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.labeljurusan = New System.Windows.Forms.Label()
        Me.labelfakultas = New System.Windows.Forms.Label()
        Me.labelnama = New System.Windows.Forms.Label()
        Me.labelnip = New System.Windows.Forms.Label()
        Me.labeljeniskelamin = New System.Windows.Forms.Label()
        Me.rbtnlaki = New System.Windows.Forms.RadioButton()
        Me.rbtnperempuan = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cmbxjurusan
        '
        Me.cmbxjurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxjurusan.FormattingEnabled = True
        Me.cmbxjurusan.Location = New System.Drawing.Point(256, 243)
        Me.cmbxjurusan.Name = "cmbxjurusan"
        Me.cmbxjurusan.Size = New System.Drawing.Size(345, 33)
        Me.cmbxjurusan.TabIndex = 17
        '
        'cmbxfakultas
        '
        Me.cmbxfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxfakultas.FormattingEnabled = True
        Me.cmbxfakultas.Location = New System.Drawing.Point(256, 188)
        Me.cmbxfakultas.Name = "cmbxfakultas"
        Me.cmbxfakultas.Size = New System.Drawing.Size(281, 33)
        Me.cmbxfakultas.TabIndex = 16
        '
        'tbxnama
        '
        Me.tbxnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxnama.Location = New System.Drawing.Point(256, 80)
        Me.tbxnama.Name = "tbxnama"
        Me.tbxnama.Size = New System.Drawing.Size(465, 30)
        Me.tbxnama.TabIndex = 15
        '
        'tbxnip
        '
        Me.tbxnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxnip.Location = New System.Drawing.Point(256, 36)
        Me.tbxnip.Name = "tbxnip"
        Me.tbxnip.Size = New System.Drawing.Size(242, 30)
        Me.tbxnip.TabIndex = 14
        '
        'btnprocess
        '
        Me.btnprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocess.Location = New System.Drawing.Point(44, 295)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(133, 38)
        Me.btnprocess.TabIndex = 13
        Me.btnprocess.Text = "Process"
        Me.btnprocess.UseVisualStyleBackColor = True
        '
        'labeljurusan
        '
        Me.labeljurusan.AutoSize = True
        Me.labeljurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeljurusan.Location = New System.Drawing.Point(39, 251)
        Me.labeljurusan.Name = "labeljurusan"
        Me.labeljurusan.Size = New System.Drawing.Size(83, 25)
        Me.labeljurusan.TabIndex = 12
        Me.labeljurusan.Text = "Jurusan"
        '
        'labelfakultas
        '
        Me.labelfakultas.AutoSize = True
        Me.labelfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelfakultas.Location = New System.Drawing.Point(36, 196)
        Me.labelfakultas.Name = "labelfakultas"
        Me.labelfakultas.Size = New System.Drawing.Size(86, 25)
        Me.labelfakultas.TabIndex = 11
        Me.labelfakultas.Text = "Fakultas"
        '
        'labelnama
        '
        Me.labelnama.AutoSize = True
        Me.labelnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnama.Location = New System.Drawing.Point(36, 80)
        Me.labelnama.Name = "labelnama"
        Me.labelnama.Size = New System.Drawing.Size(64, 25)
        Me.labelnama.TabIndex = 10
        Me.labelnama.Text = "Nama"
        '
        'labelnip
        '
        Me.labelnip.AutoSize = True
        Me.labelnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnip.Location = New System.Drawing.Point(36, 36)
        Me.labelnip.Name = "labelnip"
        Me.labelnip.Size = New System.Drawing.Size(44, 25)
        Me.labelnip.TabIndex = 9
        Me.labelnip.Text = "NIP"
        '
        'labeljeniskelamin
        '
        Me.labeljeniskelamin.AutoSize = True
        Me.labeljeniskelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeljeniskelamin.Location = New System.Drawing.Point(36, 135)
        Me.labeljeniskelamin.Name = "labeljeniskelamin"
        Me.labeljeniskelamin.Size = New System.Drawing.Size(135, 25)
        Me.labeljeniskelamin.TabIndex = 18
        Me.labeljeniskelamin.Text = "Jenis Kelamin"
        '
        'rbtnlaki
        '
        Me.rbtnlaki.AutoSize = True
        Me.rbtnlaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnlaki.Location = New System.Drawing.Point(256, 135)
        Me.rbtnlaki.Name = "rbtnlaki"
        Me.rbtnlaki.Size = New System.Drawing.Size(116, 29)
        Me.rbtnlaki.TabIndex = 19
        Me.rbtnlaki.TabStop = True
        Me.rbtnlaki.Text = "Laki-Laki"
        Me.rbtnlaki.UseVisualStyleBackColor = True
        '
        'rbtnperempuan
        '
        Me.rbtnperempuan.AutoSize = True
        Me.rbtnperempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnperempuan.Location = New System.Drawing.Point(447, 135)
        Me.rbtnperempuan.Name = "rbtnperempuan"
        Me.rbtnperempuan.Size = New System.Drawing.Size(138, 29)
        Me.rbtnperempuan.TabIndex = 20
        Me.rbtnperempuan.TabStop = True
        Me.rbtnperempuan.Text = "Perempuan"
        Me.rbtnperempuan.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 352)
        Me.Controls.Add(Me.rbtnperempuan)
        Me.Controls.Add(Me.rbtnlaki)
        Me.Controls.Add(Me.labeljeniskelamin)
        Me.Controls.Add(Me.cmbxjurusan)
        Me.Controls.Add(Me.cmbxfakultas)
        Me.Controls.Add(Me.tbxnama)
        Me.Controls.Add(Me.tbxnip)
        Me.Controls.Add(Me.btnprocess)
        Me.Controls.Add(Me.labeljurusan)
        Me.Controls.Add(Me.labelfakultas)
        Me.Controls.Add(Me.labelnama)
        Me.Controls.Add(Me.labelnip)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbxjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents tbxnama As System.Windows.Forms.TextBox
    Friend WithEvents tbxnip As System.Windows.Forms.TextBox
    Friend WithEvents btnprocess As System.Windows.Forms.Button
    Friend WithEvents labeljurusan As System.Windows.Forms.Label
    Friend WithEvents labelfakultas As System.Windows.Forms.Label
    Friend WithEvents labelnama As System.Windows.Forms.Label
    Friend WithEvents labelnip As System.Windows.Forms.Label
    Friend WithEvents labeljeniskelamin As System.Windows.Forms.Label
    Friend WithEvents rbtnlaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnperempuan As System.Windows.Forms.RadioButton
End Class
