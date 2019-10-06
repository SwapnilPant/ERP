<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoiceadd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.lable6 = New System.Windows.Forms.Label()
        Me.lblcustomeraddress = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcustomernumber = New System.Windows.Forms.TextBox()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtcustomeraddress = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btncash = New System.Windows.Forms.RadioButton()
        Me.btnonline = New System.Windows.Forms.RadioButton()
        Me.btnmodeofpayment = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblinvoiceno = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtdiscription = New System.Windows.Forms.TextBox()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.lblunitprice = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblproductname = New System.Windows.Forms.Label()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cbxproductname = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbxtax = New System.Windows.Forms.ComboBox()
        Me.dgitemdetails = New System.Windows.Forms.DataGridView()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxbaseunit = New System.Windows.Forms.ComboBox()
        Me.lbltax = New System.Windows.Forms.Label()
        CType(Me.dgitemdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Invoice no."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Number"
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(69, 96)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(122, 17)
        Me.lblcustomername.TabIndex = 6
        Me.lblcustomername.Text = "Customer Name"
        '
        'lable6
        '
        Me.lable6.AutoSize = True
        Me.lable6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable6.Location = New System.Drawing.Point(68, 34)
        Me.lable6.Name = "lable6"
        Me.lable6.Size = New System.Drawing.Size(37, 15)
        Me.lable6.TabIndex = 7
        Me.lable6.Text = "Date"
        '
        'lblcustomeraddress
        '
        Me.lblcustomeraddress.AutoSize = True
        Me.lblcustomeraddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomeraddress.Location = New System.Drawing.Point(69, 174)
        Me.lblcustomeraddress.Name = "lblcustomeraddress"
        Me.lblcustomeraddress.Size = New System.Drawing.Size(140, 17)
        Me.lblcustomeraddress.TabIndex = 9
        Me.lblcustomeraddress.Text = "Customer Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(209, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tax"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(450, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total"
        '
        'txtcustomernumber
        '
        Me.txtcustomernumber.Location = New System.Drawing.Point(230, 134)
        Me.txtcustomernumber.Name = "txtcustomernumber"
        Me.txtcustomernumber.Size = New System.Drawing.Size(122, 20)
        Me.txtcustomernumber.TabIndex = 37
        '
        'txtcustomername
        '
        Me.txtcustomername.Location = New System.Drawing.Point(230, 96)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(122, 20)
        Me.txtcustomername.TabIndex = 36
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(571, 413)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(122, 20)
        Me.txttotal.TabIndex = 48
        '
        'txtcustomeraddress
        '
        Me.txtcustomeraddress.Location = New System.Drawing.Point(230, 173)
        Me.txtcustomeraddress.Multiline = True
        Me.txtcustomeraddress.Name = "txtcustomeraddress"
        Me.txtcustomeraddress.Size = New System.Drawing.Size(122, 46)
        Me.txtcustomeraddress.TabIndex = 38
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(152, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 35
        '
        'btncash
        '
        Me.btncash.AutoSize = True
        Me.btncash.Checked = True
        Me.btncash.Cursor = System.Windows.Forms.Cursors.Default
        Me.btncash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncash.Location = New System.Drawing.Point(65, 18)
        Me.btncash.Name = "btncash"
        Me.btncash.Size = New System.Drawing.Size(58, 21)
        Me.btncash.TabIndex = 37
        Me.btncash.TabStop = True
        Me.btncash.Text = "Cash"
        Me.btncash.UseVisualStyleBackColor = True
        '
        'btnonline
        '
        Me.btnonline.AutoSize = True
        Me.btnonline.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnonline.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnonline.Location = New System.Drawing.Point(65, 53)
        Me.btnonline.Name = "btnonline"
        Me.btnonline.Size = New System.Drawing.Size(67, 21)
        Me.btnonline.TabIndex = 38
        Me.btnonline.TabStop = True
        Me.btnonline.Text = "Online"
        Me.btnonline.UseVisualStyleBackColor = True
        '
        'btnmodeofpayment
        '
        Me.btnmodeofpayment.AutoSize = True
        Me.btnmodeofpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodeofpayment.Location = New System.Drawing.Point(442, 159)
        Me.btnmodeofpayment.Name = "btnmodeofpayment"
        Me.btnmodeofpayment.Size = New System.Drawing.Size(137, 17)
        Me.btnmodeofpayment.TabIndex = 39
        Me.btnmodeofpayment.Text = "Mode of payment:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(427, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 40
        '
        'Lblinvoiceno
        '
        Me.Lblinvoiceno.AutoSize = True
        Me.Lblinvoiceno.Location = New System.Drawing.Point(427, 13)
        Me.Lblinvoiceno.Name = "Lblinvoiceno"
        Me.Lblinvoiceno.Size = New System.Drawing.Size(39, 13)
        Me.Lblinvoiceno.TabIndex = 42
        Me.Lblinvoiceno.Text = "Label4"
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(720, 410)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 50
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(812, 410)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 49
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(459, 267)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(43, 20)
        Me.txtquantity.TabIndex = 42
        Me.txtquantity.Text = "0"
        '
        'txtdiscription
        '
        Me.txtdiscription.Location = New System.Drawing.Point(210, 267)
        Me.txtdiscription.Name = "txtdiscription"
        Me.txtdiscription.Size = New System.Drawing.Size(185, 20)
        Me.txtdiscription.TabIndex = 40
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(401, 267)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(52, 20)
        Me.txtunitprice.TabIndex = 41
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(558, 267)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtdiscount.TabIndex = 44
        Me.txtdiscount.Text = "0"
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscount.Location = New System.Drawing.Point(582, 251)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(57, 13)
        Me.lbldiscount.TabIndex = 52
        Me.lbldiscount.Text = "Discount"
        '
        'lblunitprice
        '
        Me.lblunitprice.AutoSize = True
        Me.lblunitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitprice.Location = New System.Drawing.Point(397, 248)
        Me.lblunitprice.Name = "lblunitprice"
        Me.lblunitprice.Size = New System.Drawing.Size(63, 13)
        Me.lblunitprice.TabIndex = 50
        Me.lblunitprice.Text = "Unit Price"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(466, 249)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(30, 13)
        Me.lblquantity.TabIndex = 49
        Me.lblquantity.Text = "Unit"
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductname.Location = New System.Drawing.Point(46, 248)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(87, 13)
        Me.lblproductname.TabIndex = 48
        Me.lblproductname.Text = "Product Name"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.Location = New System.Drawing.Point(209, 248)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(71, 13)
        Me.lbldescription.TabIndex = 47
        Me.lbldescription.Text = "Description"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(812, 265)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 45
        Me.btnadd.Text = "+ ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cbxproductname
        '
        Me.cbxproductname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxproductname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxproductname.FormattingEnabled = True
        Me.cbxproductname.Location = New System.Drawing.Point(49, 267)
        Me.cbxproductname.Name = "cbxproductname"
        Me.cbxproductname.Size = New System.Drawing.Size(145, 21)
        Me.cbxproductname.TabIndex = 39
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(493, 529)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 26
        '
        'cbxtax
        '
        Me.cbxtax.FormattingEnabled = True
        Me.cbxtax.Items.AddRange(New Object() {"Select Tax", "3%", "5%", "8%", "12%", "18%"})
        Me.cbxtax.Location = New System.Drawing.Point(263, 410)
        Me.cbxtax.Name = "cbxtax"
        Me.cbxtax.Size = New System.Drawing.Size(44, 21)
        Me.cbxtax.TabIndex = 47
        '
        'dgitemdetails
        '
        Me.dgitemdetails.AllowUserToAddRows = False
        Me.dgitemdetails.AllowUserToDeleteRows = False
        Me.dgitemdetails.AllowUserToResizeColumns = False
        Me.dgitemdetails.AllowUserToResizeRows = False
        Me.dgitemdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgitemdetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgitemdetails.Location = New System.Drawing.Point(46, 297)
        Me.dgitemdetails.Name = "dgitemdetails"
        Me.dgitemdetails.ReadOnly = True
        Me.dgitemdetails.Size = New System.Drawing.Size(749, 101)
        Me.dgitemdetails.TabIndex = 46
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(812, 439)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 51
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(453, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(502, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "BaseUnit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncash)
        Me.GroupBox1.Controls.Add(Me.btnonline)
        Me.GroupBox1.Location = New System.Drawing.Point(585, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 100)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        '
        'cbxbaseunit
        '
        Me.cbxbaseunit.FormattingEnabled = True
        Me.cbxbaseunit.Items.AddRange(New Object() {"pcs", "box", "free", "nos", "dozen", "meter", "cm"})
        Me.cbxbaseunit.Location = New System.Drawing.Point(505, 266)
        Me.cbxbaseunit.Name = "cbxbaseunit"
        Me.cbxbaseunit.Size = New System.Drawing.Size(47, 21)
        Me.cbxbaseunit.TabIndex = 43
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Location = New System.Drawing.Point(339, 416)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(13, 13)
        Me.lbltax.TabIndex = 108
        Me.lbltax.Text = "0"
        '
        'invoiceadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 521)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.cbxbaseunit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.dgitemdetails)
        Me.Controls.Add(Me.cbxtax)
        Me.Controls.Add(Me.cbxproductname)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtdiscription)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.lbldiscount)
        Me.Controls.Add(Me.lblunitprice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.lblproductname)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.Lblinvoiceno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnmodeofpayment)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtcustomeraddress)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtcustomername)
        Me.Controls.Add(Me.txtcustomernumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblcustomeraddress)
        Me.Controls.Add(Me.lable6)
        Me.Controls.Add(Me.lblcustomername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "invoiceadd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "invoiceadd"
        CType(Me.dgitemdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcustomername As Label
    Friend WithEvents lable6 As Label
    Friend WithEvents lblcustomeraddress As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcustomernumber As TextBox
    Friend WithEvents txtcustomername As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtcustomeraddress As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btncash As RadioButton
    Friend WithEvents btnonline As RadioButton
    Friend WithEvents btnmodeofpayment As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lblinvoiceno As Label
    Private WithEvents btnreset As Button
    Private WithEvents btnsave As Button
    Private WithEvents txtquantity As TextBox
    Private WithEvents txtdiscription As TextBox
    Private WithEvents txtunitprice As TextBox
    Private WithEvents txtdiscount As TextBox
    Private WithEvents lbldiscount As Label
    Private WithEvents lblunitprice As Label
    Private WithEvents lblquantity As Label
    Private WithEvents lblproductname As Label
    Private WithEvents lbldescription As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents cbxproductname As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cbxtax As ComboBox
    Friend WithEvents dgitemdetails As DataGridView
    Friend WithEvents btnback As Button
    Friend WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxbaseunit As ComboBox
    Friend WithEvents lbltax As Label
End Class
