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
        Me.labelnip = New System.Windows.Forms.Label()
        Me.labelnama = New System.Windows.Forms.Label()
        Me.labelfakultas = New System.Windows.Forms.Label()
        Me.labeljurusan = New System.Windows.Forms.Label()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.tbxnip = New System.Windows.Forms.TextBox()
        Me.tbxnama = New System.Windows.Forms.TextBox()
        Me.cmbxfakultas = New System.Windows.Forms.ComboBox()
        Me.cmbxjurusan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'labelnip
        '
        Me.labelnip.AutoSize = True
        Me.labelnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnip.Location = New System.Drawing.Point(32, 25)
        Me.labelnip.Name = "labelnip"
        Me.labelnip.Size = New System.Drawing.Size(44, 25)
        Me.labelnip.TabIndex = 0
        Me.labelnip.Text = "NIP"
        '
        'labelnama
        '
        Me.labelnama.AutoSize = True
        Me.labelnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnama.Location = New System.Drawing.Point(32, 77)
        Me.labelnama.Name = "labelnama"
        Me.labelnama.Size = New System.Drawing.Size(64, 25)
        Me.labelnama.TabIndex = 1
        Me.labelnama.Text = "Nama"
        '
        'labelfakultas
        '
        Me.labelfakultas.AutoSize = True
        Me.labelfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelfakultas.Location = New System.Drawing.Point(32, 134)
        Me.labelfakultas.Name = "labelfakultas"
        Me.labelfakultas.Size = New System.Drawing.Size(86, 25)
        Me.labelfakultas.TabIndex = 2
        Me.labelfakultas.Text = "Fakultas"
        '
        'labeljurusan
        '
        Me.labeljurusan.AutoSize = True
        Me.labeljurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeljurusan.Location = New System.Drawing.Point(32, 188)
        Me.labeljurusan.Name = "labeljurusan"
        Me.labeljurusan.Size = New System.Drawing.Size(83, 25)
        Me.labeljurusan.TabIndex = 3
        Me.labeljurusan.Text = "Jurusan"
        '
        'btnprocess
        '
        Me.btnprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocess.Location = New System.Drawing.Point(37, 238)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(133, 38)
        Me.btnprocess.TabIndex = 4
        Me.btnprocess.Text = "Process"
        Me.btnprocess.UseVisualStyleBackColor = True
        '
        'tbxnip
        '
        Me.tbxnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxnip.Location = New System.Drawing.Point(187, 22)
        Me.tbxnip.Name = "tbxnip"
        Me.tbxnip.Size = New System.Drawing.Size(242, 30)
        Me.tbxnip.TabIndex = 5
        '
        'tbxnama
        '
        Me.tbxnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxnama.Location = New System.Drawing.Point(187, 72)
        Me.tbxnama.Name = "tbxnama"
        Me.tbxnama.Size = New System.Drawing.Size(465, 30)
        Me.tbxnama.TabIndex = 6
        '
        'cmbxfakultas
        '
        Me.cmbxfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxfakultas.FormattingEnabled = True
        Me.cmbxfakultas.Location = New System.Drawing.Point(187, 126)
        Me.cmbxfakultas.Name = "cmbxfakultas"
        Me.cmbxfakultas.Size = New System.Drawing.Size(281, 33)
        Me.cmbxfakultas.TabIndex = 7
        '
        'cmbxjurusan
        '
        Me.cmbxjurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxjurusan.FormattingEnabled = True
        Me.cmbxjurusan.Location = New System.Drawing.Point(187, 180)
        Me.cmbxjurusan.Name = "cmbxjurusan"
        Me.cmbxjurusan.Size = New System.Drawing.Size(345, 33)
        Me.cmbxjurusan.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 299)
        Me.Controls.Add(Me.cmbxjurusan)
        Me.Controls.Add(Me.cmbxfakultas)
        Me.Controls.Add(Me.tbxnama)
        Me.Controls.Add(Me.tbxnip)
        Me.Controls.Add(Me.btnprocess)
        Me.Controls.Add(Me.labeljurusan)
        Me.Controls.Add(Me.labelfakultas)
        Me.Controls.Add(Me.labelnama)
        Me.Controls.Add(Me.labelnip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelnip As System.Windows.Forms.Label
    Friend WithEvents labelnama As System.Windows.Forms.Label
    Friend WithEvents labelfakultas As System.Windows.Forms.Label
    Friend WithEvents labeljurusan As System.Windows.Forms.Label
    Friend WithEvents btnprocess As System.Windows.Forms.Button
    Friend WithEvents tbxnip As System.Windows.Forms.TextBox
    Friend WithEvents tbxnama As System.Windows.Forms.TextBox
    Friend WithEvents cmbxfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxjurusan As System.Windows.Forms.ComboBox

End Class
