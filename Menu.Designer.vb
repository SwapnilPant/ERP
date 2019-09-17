<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnaddinvoice = New System.Windows.Forms.Button()
        Me.btnsettings = New System.Windows.Forms.Button()
        Me.btnvendor = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnhistory = New System.Windows.Forms.Button()
        Me.Taskbar1 = New ERP_Trial_1.taskbar()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblinventory = New System.Windows.Forms.Label()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.lv = New System.Windows.Forms.Label()
        Me.btninvoicehistory = New System.Windows.Forms.Button()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvendorhistory = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnaddinvoice
        '
        Me.btnaddinvoice.Location = New System.Drawing.Point(128, 95)
        Me.btnaddinvoice.Name = "btnaddinvoice"
        Me.btnaddinvoice.Size = New System.Drawing.Size(132, 24)
        Me.btnaddinvoice.TabIndex = 0
        Me.btnaddinvoice.Text = "Add Invoice"
        Me.btnaddinvoice.UseVisualStyleBackColor = True
        '
        'btnsettings
        '
        Me.btnsettings.Location = New System.Drawing.Point(392, 312)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Size = New System.Drawing.Size(142, 37)
        Me.btnsettings.TabIndex = 1
        Me.btnsettings.Text = "Settings"
        Me.btnsettings.UseVisualStyleBackColor = True
        '
        'btnvendor
        '
        Me.btnvendor.Location = New System.Drawing.Point(392, 227)
        Me.btnvendor.Name = "btnvendor"
        Me.btnvendor.Size = New System.Drawing.Size(132, 24)
        Me.btnvendor.TabIndex = 2
        Me.btnvendor.Text = "Vendor"
        Me.btnvendor.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(938, 29)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnhistory
        '
        Me.btnhistory.Location = New System.Drawing.Point(128, 312)
        Me.btnhistory.Name = "btnhistory"
        Me.btnhistory.Size = New System.Drawing.Size(184, 37)
        Me.btnhistory.TabIndex = 4
        Me.btnhistory.Text = "Transaction History"
        Me.btnhistory.UseVisualStyleBackColor = True
        '
        'Taskbar1
        '
        Me.Taskbar1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Taskbar1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Taskbar1.Location = New System.Drawing.Point(0, 0)
        Me.Taskbar1.Name = "Taskbar1"
        Me.Taskbar1.Size = New System.Drawing.Size(1037, 23)
        Me.Taskbar1.TabIndex = 6
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(128, 222)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(132, 23)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lblinventory
        '
        Me.lblinventory.AutoSize = True
        Me.lblinventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinventory.Location = New System.Drawing.Point(401, 72)
        Me.lblinventory.Name = "lblinventory"
        Me.lblinventory.Size = New System.Drawing.Size(76, 20)
        Me.lblinventory.TabIndex = 8
        Me.lblinventory.Text = "Inventory"
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(405, 98)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(72, 21)
        Me.btndisplay.TabIndex = 7
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'lv
        '
        Me.lv.AutoSize = True
        Me.lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.Location = New System.Drawing.Point(124, 72)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(61, 20)
        Me.lv.TabIndex = 8
        Me.lv.Text = "Invoice"
        '
        'btninvoicehistory
        '
        Me.btninvoicehistory.Location = New System.Drawing.Point(128, 125)
        Me.btninvoicehistory.Name = "btninvoicehistory"
        Me.btninvoicehistory.Size = New System.Drawing.Size(132, 22)
        Me.btninvoicehistory.TabIndex = 2
        Me.btninvoicehistory.Text = "Invoice History"
        Me.btninvoicehistory.UseVisualStyleBackColor = True
        '
        'btn_Logout
        '
        Me.btn_Logout.Location = New System.Drawing.Point(775, 457)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(142, 37)
        Me.btn_Logout.TabIndex = 1
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Purchase"
        '
        'btnvendorhistory
        '
        Me.btnvendorhistory.Location = New System.Drawing.Point(392, 257)
        Me.btnvendorhistory.Name = "btnvendorhistory"
        Me.btnvendorhistory.Size = New System.Drawing.Size(132, 24)
        Me.btnvendorhistory.TabIndex = 2
        Me.btnvendorhistory.Text = "Vendor History"
        Me.btnvendorhistory.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Vendor"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 521)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblinventory)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Taskbar1)
        Me.Controls.Add(Me.btnhistory)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btninvoicehistory)
        Me.Controls.Add(Me.btnvendorhistory)
        Me.Controls.Add(Me.btnvendor)
        Me.Controls.Add(Me.btn_Logout)
        Me.Controls.Add(Me.btnsettings)
        Me.Controls.Add(Me.btnaddinvoice)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnaddinvoice As Button
    Friend WithEvents btnsettings As Button
    Friend WithEvents btnvendor As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnhistory As Button
    Friend WithEvents Taskbar1 As taskbar
    Friend WithEvents btnadd As Button
    Friend WithEvents lblinventory As Label
    Friend WithEvents btndisplay As Button
    Friend WithEvents lv As Label
    Friend WithEvents btninvoicehistory As Button
    Friend WithEvents btn_Logout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnvendorhistory As Button
    Friend WithEvents Label2 As Label
End Class
