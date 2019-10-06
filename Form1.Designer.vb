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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.llblforgot = New System.Windows.Forms.LinkLabel()
        Me.status = New System.Windows.Forms.Label()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(364, 222)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(253, 20)
        Me.txtname.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.AcceptsTab = True
        Me.txtpassword.Location = New System.Drawing.Point(364, 318)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(253, 20)
        Me.txtpassword.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(364, 191)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(60, 13)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "User Name"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(364, 293)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(53, 13)
        Me.lblpassword.TabIndex = 1
        Me.lblpassword.Text = "Password"
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(601, 407)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Sign In"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'llblforgot
        '
        Me.llblforgot.AutoSize = True
        Me.llblforgot.Location = New System.Drawing.Point(329, 417)
        Me.llblforgot.Name = "llblforgot"
        Me.llblforgot.Size = New System.Drawing.Size(95, 13)
        Me.llblforgot.TabIndex = 3
        Me.llblforgot.TabStop = True
        Me.llblforgot.Text = "Forgot Password ?"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(187, 67)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(134, 13)
        Me.status.TabIndex = 4
        Me.status.Text = "WE are under construction"
        '
        'Btnback
        '
        Me.Btnback.Location = New System.Drawing.Point(740, 407)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(75, 23)
        Me.Btnback.TabIndex = 2
        Me.Btnback.Text = "Back"
        Me.Btnback.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 558)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.llblforgot)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtname)
        Me.Name = "Form1"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents llblforgot As LinkLabel
    Friend WithEvents status As Label
    Friend WithEvents Btnback As Button
End Class
