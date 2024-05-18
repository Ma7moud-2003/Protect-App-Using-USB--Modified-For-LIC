<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pervilages
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_usb = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.clb = New System.Windows.Forms.CheckedListBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 621)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_usb)
        Me.GroupBox2.Controls.Add(Me.btn_close)
        Me.GroupBox2.Controls.Add(Me.btn_save)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 521)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controlls"
        '
        'lbl_usb
        '
        Me.lbl_usb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_usb.Location = New System.Drawing.Point(6, 33)
        Me.lbl_usb.Name = "lbl_usb"
        Me.lbl_usb.Size = New System.Drawing.Size(323, 35)
        Me.lbl_usb.TabIndex = 6
        Me.lbl_usb.Text = "USB Serial"
        Me.lbl_usb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_close.Location = New System.Drawing.Point(335, 33)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(118, 37)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_save.Location = New System.Drawing.Point(459, 33)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(118, 37)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 508)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pervilages"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(583, 487)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.clb)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(575, 458)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Applcation Component"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'clb
        '
        Me.clb.CheckOnClick = True
        Me.clb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clb.FormattingEnabled = True
        Me.clb.Items.AddRange(New Object() {"Barcode", "QR", "Borrow Quantities", "Item Coding", "E Verification R", "Elecrtonic Verification", "Expiry Monitoring", "Item Receive", "User Register", "Lot Verification", "Search Lot", "Verify Now", "Lot Track", "Quantity Receive", "Tracking All Quantity Used", "Quantity Loand", "Reagent Registration", "Dashboard Designer", "Descreption", "Lot To Lot Verification", "MSDS", "Web 1", "Backup Database", "Restore Database", "Tracking All Quantity Received", "Create Database", "Configure Database", "Receiving From Other Facility / Company", "Sending  To Other Facility / company ", "Quantitys Statistic", "Leaflets", "Dashboard Details", "Reagent Withdrawals", "MSDS report", "Temp Monitoring", "Themes", "Configure Database icon", "Invoice", "Customers-Suppliers"})
        Me.clb.Location = New System.Drawing.Point(3, 3)
        Me.clb.Name = "clb"
        Me.clb.Size = New System.Drawing.Size(569, 452)
        Me.clb.TabIndex = 0
        '
        'frm_Pervilages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 621)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Pervilages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pervilages"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_usb As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents clb As CheckedListBox
End Class
