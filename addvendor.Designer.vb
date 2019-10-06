<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addvendor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtvendoraddress = New System.Windows.Forms.TextBox()
        Me.txtvendorname = New System.Windows.Forms.TextBox()
        Me.txtvendornumber = New System.Windows.Forms.TextBox()
        Me.lblcustomeraddress = New System.Windows.Forms.Label()
        Me.lable6 = New System.Windows.Forms.Label()
        Me.lblvendorname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtvendoremail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtgst = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvvendor = New System.Windows.Forms.DataGridView()
        Me.btnaddvendor = New System.Windows.Forms.Button()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Taskbar1 = New ERP_Trial_1.taskbar()
        CType(Me.dgvvendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(779, 492)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 82
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(860, 492)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 81
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(735, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 73
        '
        'txtvendoraddress
        '
        Me.txtvendoraddress.Location = New System.Drawing.Point(165, 154)
        Me.txtvendoraddress.Multiline = True
        Me.txtvendoraddress.Name = "txtvendoraddress"
        Me.txtvendoraddress.Size = New System.Drawing.Size(122, 41)
        Me.txtvendoraddress.TabIndex = 76
        '
        'txtvendorname
        '
        Me.txtvendorname.Location = New System.Drawing.Point(165, 64)
        Me.txtvendorname.Name = "txtvendorname"
        Me.txtvendorname.Size = New System.Drawing.Size(122, 20)
        Me.txtvendorname.TabIndex = 74
        '
        'txtvendornumber
        '
        Me.txtvendornumber.Location = New System.Drawing.Point(165, 105)
        Me.txtvendornumber.Name = "txtvendornumber"
        Me.txtvendornumber.Size = New System.Drawing.Size(122, 20)
        Me.txtvendornumber.TabIndex = 75
        '
        'lblcustomeraddress
        '
        Me.lblcustomeraddress.AutoSize = True
        Me.lblcustomeraddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomeraddress.Location = New System.Drawing.Point(40, 154)
        Me.lblcustomeraddress.Name = "lblcustomeraddress"
        Me.lblcustomeraddress.Size = New System.Drawing.Size(110, 17)
        Me.lblcustomeraddress.TabIndex = 70
        Me.lblcustomeraddress.Text = "Vendor Address"
        '
        'lable6
        '
        Me.lable6.AutoSize = True
        Me.lable6.Location = New System.Drawing.Point(688, 23)
        Me.lable6.Name = "lable6"
        Me.lable6.Size = New System.Drawing.Size(30, 13)
        Me.lable6.TabIndex = 69
        Me.lable6.Text = "Date"
        '
        'lblvendorname
        '
        Me.lblvendorname.AutoSize = True
        Me.lblvendorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendorname.Location = New System.Drawing.Point(40, 61)
        Me.lblvendorname.Name = "lblvendorname"
        Me.lblvendorname.Size = New System.Drawing.Size(95, 17)
        Me.lblvendorname.TabIndex = 68
        Me.lblvendorname.Text = "Vendor Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Vendor Number"
        '
        'txtvendoremail
        '
        Me.txtvendoremail.Location = New System.Drawing.Point(384, 155)
        Me.txtvendoremail.Name = "txtvendoremail"
        Me.txtvendoremail.Size = New System.Drawing.Size(174, 20)
        Me.txtvendoremail.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Email"
        '
        'txtgst
        '
        Me.txtgst.Location = New System.Drawing.Point(384, 102)
        Me.txtgst.Name = "txtgst"
        Me.txtgst.Size = New System.Drawing.Size(176, 20)
        Me.txtgst.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(326, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "GSTN"
        '
        'dgvvendor
        '
        Me.dgvvendor.AllowUserToAddRows = False
        Me.dgvvendor.AllowUserToDeleteRows = False
        Me.dgvvendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvendor.Location = New System.Drawing.Point(43, 250)
        Me.dgvvendor.Name = "dgvvendor"
        Me.dgvvendor.ReadOnly = True
        Me.dgvvendor.Size = New System.Drawing.Size(613, 133)
        Me.dgvvendor.TabIndex = 80
        '
        'btnaddvendor
        '
        Me.btnaddvendor.Location = New System.Drawing.Point(672, 155)
        Me.btnaddvendor.Name = "btnaddvendor"
        Me.btnaddvendor.Size = New System.Drawing.Size(75, 23)
        Me.btnaddvendor.TabIndex = 79
        Me.btnaddvendor.Text = " ADD"
        Me.btnaddvendor.UseVisualStyleBackColor = True
        '
        'Btnback
        '
        Me.Btnback.Location = New System.Drawing.Point(691, 492)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(75, 23)
        Me.Btnback.TabIndex = 83
        Me.Btnback.Text = "Back"
        Me.Btnback.UseVisualStyleBackColor = True
        '
        'Taskbar1
        '
        Me.Taskbar1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Taskbar1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Taskbar1.Location = New System.Drawing.Point(3, 3)
        Me.Taskbar1.Name = "Taskbar1"
        Me.Taskbar1.Size = New System.Drawing.Size(932, 23)
        Me.Taskbar1.TabIndex = 8
        '
        'addvendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 546)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.dgvvendor)
        Me.Controls.Add(Me.txtgst)
        Me.Controls.Add(Me.txtvendoremail)
        Me.Controls.Add(Me.btnaddvendor)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtvendoraddress)
        Me.Controls.Add(Me.txtvendorname)
        Me.Controls.Add(Me.txtvendornumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcustomeraddress)
        Me.Controls.Add(Me.lable6)
        Me.Controls.Add(Me.lblvendorname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Taskbar1)
        Me.Name = "addvendor"
        Me.Text = "Vendor"
        CType(Me.dgvvendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Taskbar1 As taskbar
    Private WithEvents btnreset As Button
    Private WithEvents btnsave As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtvendoraddress As TextBox
    Friend WithEvents txtvendorname As TextBox
    Friend WithEvents txtvendornumber As TextBox
    Friend WithEvents lblcustomeraddress As Label
    Friend WithEvents lable6 As Label
    Friend WithEvents lblvendorname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtvendoremail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtgst As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvvendor As DataGridView
    Friend WithEvents btnaddvendor As Button
    Friend WithEvents Btnback As Button
End Class
