<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addvendor
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
        Me.Taskbar1 = New ERP_Trial_1.taskbar()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblcustomeraddress = New System.Windows.Forms.Label()
        Me.lable6 = New System.Windows.Forms.Label()
        Me.lblvendorname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtgst = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnaddvendor = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(779, 492)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 96
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(860, 492)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 95
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(735, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 77
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(165, 154)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(122, 41)
        Me.TextBox9.TabIndex = 76
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(165, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(122, 20)
        Me.TextBox3.TabIndex = 74
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(122, 20)
        Me.TextBox2.TabIndex = 73
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(384, 155)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 100
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
        Me.txtgst.TabIndex = 100
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(905, 133)
        Me.DataGridView1.TabIndex = 102
        '
        'btnaddvendor
        '
        Me.btnaddvendor.Location = New System.Drawing.Point(672, 155)
        Me.btnaddvendor.Name = "btnaddvendor"
        Me.btnaddvendor.Size = New System.Drawing.Size(75, 23)
        Me.btnaddvendor.TabIndex = 97
        Me.btnaddvendor.Text = " ADD"
        Me.btnaddvendor.UseVisualStyleBackColor = True
        '
        'addvendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 546)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtgst)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnaddvendor)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcustomeraddress)
        Me.Controls.Add(Me.lable6)
        Me.Controls.Add(Me.lblvendorname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Taskbar1)
        Me.Name = "addvendor"
        Me.Text = "Vendor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Taskbar1 As taskbar
    Private WithEvents btnreset As Button
    Private WithEvents btnsave As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblcustomeraddress As Label
    Friend WithEvents lable6 As Label
    Friend WithEvents lblvendorname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtgst As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnaddvendor As Button
End Class
