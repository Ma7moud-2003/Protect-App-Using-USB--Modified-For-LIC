<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verify_USB
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_com_info = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_perv = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.lbl_gen_code = New System.Windows.Forms.LinkLabel()
        Me.btn_ref = New System.Windows.Forms.Button()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_usb_serial = New System.Windows.Forms.TextBox()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_usb = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_usb = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_usb)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lbl_gen_code)
        Me.Panel1.Controls.Add(Me.btn_ref)
        Me.Panel1.Controls.Add(Me.txt_code)
        Me.Panel1.Controls.Add(Me.txt_usb_serial)
        Me.Panel1.Controls.Add(Me.lbl_code)
        Me.Panel1.Controls.Add(Me.lbl_usb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 302)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_com_info)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.btn_end)
        Me.GroupBox1.Controls.Add(Me.btn_perv)
        Me.GroupBox1.Controls.Add(Me.btn_reset)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 77)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controlls"
        '
        'btn_com_info
        '
        Me.btn_com_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_com_info.Location = New System.Drawing.Point(166, 28)
        Me.btn_com_info.Name = "btn_com_info"
        Me.btn_com_info.Size = New System.Drawing.Size(155, 37)
        Me.btn_com_info.TabIndex = 7
        Me.btn_com_info.Text = "Company_Info"
        Me.btn_com_info.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_save.Location = New System.Drawing.Point(616, 28)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(118, 37)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_end.Location = New System.Drawing.Point(2, 28)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(149, 37)
        Me.btn_end.TabIndex = 6
        Me.btn_end.Text = "End Program"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_perv
        '
        Me.btn_perv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_perv.Location = New System.Drawing.Point(336, 28)
        Me.btn_perv.Name = "btn_perv"
        Me.btn_perv.Size = New System.Drawing.Size(132, 37)
        Me.btn_perv.TabIndex = 1
        Me.btn_perv.Text = "Pervilages"
        Me.btn_perv.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_reset.Location = New System.Drawing.Point(483, 28)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(118, 37)
        Me.btn_reset.TabIndex = 2
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'lbl_gen_code
        '
        Me.lbl_gen_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_gen_code.Location = New System.Drawing.Point(494, 105)
        Me.lbl_gen_code.Name = "lbl_gen_code"
        Me.lbl_gen_code.Size = New System.Drawing.Size(198, 28)
        Me.lbl_gen_code.TabIndex = 5
        Me.lbl_gen_code.TabStop = True
        Me.lbl_gen_code.Text = "Generate Code"
        Me.lbl_gen_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_ref
        '
        Me.btn_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_ref.Location = New System.Drawing.Point(568, 54)
        Me.btn_ref.Name = "btn_ref"
        Me.btn_ref.Size = New System.Drawing.Size(118, 37)
        Me.btn_ref.TabIndex = 0
        Me.btn_ref.Text = "Refresh"
        Me.btn_ref.UseVisualStyleBackColor = True
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txt_code.Location = New System.Drawing.Point(215, 150)
        Me.txt_code.Multiline = True
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(347, 47)
        Me.txt_code.TabIndex = 2
        Me.txt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_usb_serial
        '
        Me.txt_usb_serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txt_usb_serial.Location = New System.Drawing.Point(215, 50)
        Me.txt_usb_serial.Multiline = True
        Me.txt_usb_serial.Name = "txt_usb_serial"
        Me.txt_usb_serial.Size = New System.Drawing.Size(347, 47)
        Me.txt_usb_serial.TabIndex = 2
        Me.txt_usb_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_code
        '
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl_code.Location = New System.Drawing.Point(38, 163)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(140, 34)
        Me.lbl_code.TabIndex = 1
        Me.lbl_code.Text = "Code"
        Me.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_usb
        '
        Me.lbl_usb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl_usb.Location = New System.Drawing.Point(38, 50)
        Me.lbl_usb.Name = "lbl_usb"
        Me.lbl_usb.Size = New System.Drawing.Size(140, 35)
        Me.lbl_usb.TabIndex = 0
        Me.lbl_usb.Text = "USB Serial"
        Me.lbl_usb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_usb
        '
        Me.btn_usb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_usb.Location = New System.Drawing.Point(574, 160)
        Me.btn_usb.Name = "btn_usb"
        Me.btn_usb.Size = New System.Drawing.Size(118, 37)
        Me.btn_usb.TabIndex = 8
        Me.btn_usb.Text = "USB'S"
        Me.btn_usb.UseVisualStyleBackColor = True
        '
        'Verify_USB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 302)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Verify_USB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verify USB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_usb_serial As TextBox
    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_usb As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_perv As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_ref As Button
    Friend WithEvents lbl_gen_code As LinkLabel
    Friend WithEvents btn_end As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_com_info As Button
    Friend WithEvents btn_usb As Button
End Class
