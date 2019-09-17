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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.lable6 = New System.Windows.Forms.Label()
        Me.lblcustomeraddress = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btncash = New System.Windows.Forms.RadioButton()
        Me.btnonline = New System.Windows.Forms.RadioButton()
        Me.btnmodeofpayment = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblinvoiceno = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cbxcurrency = New System.Windows.Forms.ComboBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txttotalprice = New System.Windows.Forms.TextBox()
        Me.txtdiscription = New System.Windows.Forms.TextBox()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.lbltotalprice = New System.Windows.Forms.Label()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.lblunitprice = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblproductname = New System.Windows.Forms.Label()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.lblhsn = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cbxproductname = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbxtax = New System.Windows.Forms.ComboBox()
        Me.dgitemdetails = New System.Windows.Forms.DataGridView()
        CType(Me.dgitemdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Number"
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(69, 96)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(109, 17)
        Me.lblcustomername.TabIndex = 6
        Me.lblcustomername.Text = "Customer Name"
        '
        'lable6
        '
        Me.lable6.AutoSize = True
        Me.lable6.Location = New System.Drawing.Point(68, 33)
        Me.lable6.Name = "lable6"
        Me.lable6.Size = New System.Drawing.Size(30, 13)
        Me.lable6.TabIndex = 7
        Me.lable6.Text = "Date"
        '
        'lblcustomeraddress
        '
        Me.lblcustomeraddress.AutoSize = True
        Me.lblcustomeraddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomeraddress.Location = New System.Drawing.Point(69, 174)
        Me.lblcustomeraddress.Name = "lblcustomeraddress"
        Me.lblcustomeraddress.Size = New System.Drawing.Size(124, 17)
        Me.lblcustomeraddress.TabIndex = 9
        Me.lblcustomeraddress.Text = "Customer Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(209, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tax"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(230, 134)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(122, 20)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(230, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(122, 20)
        Me.TextBox3.TabIndex = 22
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(565, 406)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(122, 20)
        Me.txttotal.TabIndex = 30
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(230, 173)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(122, 46)
        Me.TextBox9.TabIndex = 34
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 35
        '
        'btncash
        '
        Me.btncash.AutoSize = True
        Me.btncash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncash.Location = New System.Drawing.Point(593, 155)
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
        Me.btnonline.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnonline.Location = New System.Drawing.Point(593, 182)
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
        Me.btnmodeofpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodeofpayment.Location = New System.Drawing.Point(442, 159)
        Me.btnmodeofpayment.Name = "btnmodeofpayment"
        Me.btnmodeofpayment.Size = New System.Drawing.Size(121, 17)
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
        Me.Lblinvoiceno.Location = New System.Drawing.Point(698, 16)
        Me.Lblinvoiceno.Name = "Lblinvoiceno"
        Me.Lblinvoiceno.Size = New System.Drawing.Size(39, 13)
        Me.Lblinvoiceno.TabIndex = 42
        Me.Lblinvoiceno.Text = "Label4"
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(722, 404)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 64
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(812, 403)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 63
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'cbxcurrency
        '
        Me.cbxcurrency.FormattingEnabled = True
        Me.cbxcurrency.Location = New System.Drawing.Point(722, 270)
        Me.cbxcurrency.Name = "cbxcurrency"
        Me.cbxcurrency.Size = New System.Drawing.Size(48, 21)
        Me.cbxcurrency.TabIndex = 62
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(407, 268)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(43, 20)
        Me.txtquantity.TabIndex = 60
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(600, 270)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(100, 20)
        Me.txttotalprice.TabIndex = 59
        '
        'txtdiscription
        '
        Me.txtdiscription.Location = New System.Drawing.Point(200, 269)
        Me.txtdiscription.Name = "txtdiscription"
        Me.txtdiscription.Size = New System.Drawing.Size(127, 20)
        Me.txtdiscription.TabIndex = 57
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(333, 268)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(52, 20)
        Me.txtunitprice.TabIndex = 56
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(463, 270)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtdiscount.TabIndex = 61
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(507, 49)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(333, 54)
        Me.TextBox12.TabIndex = 55
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(475, 9)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(100, 20)
        Me.txtproductname.TabIndex = 54
        '
        'lbltotalprice
        '
        Me.lbltotalprice.AutoSize = True
        Me.lbltotalprice.Location = New System.Drawing.Point(602, 254)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(58, 13)
        Me.lbltotalprice.TabIndex = 53
        Me.lbltotalprice.Text = "Total Price"
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Location = New System.Drawing.Point(460, 254)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(49, 13)
        Me.lbldiscount.TabIndex = 52
        Me.lbldiscount.Text = "Discount"
        '
        'lblunitprice
        '
        Me.lblunitprice.AutoSize = True
        Me.lblunitprice.Location = New System.Drawing.Point(332, 253)
        Me.lblunitprice.Name = "lblunitprice"
        Me.lblunitprice.Size = New System.Drawing.Size(53, 13)
        Me.lblunitprice.TabIndex = 50
        Me.lblunitprice.Text = "Unit Price"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Location = New System.Drawing.Point(404, 253)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(46, 13)
        Me.lblquantity.TabIndex = 49
        Me.lblquantity.Text = "Quantity"
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Location = New System.Drawing.Point(43, 253)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(75, 13)
        Me.lblproductname.TabIndex = 48
        Me.lblproductname.Text = "Product Name"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Location = New System.Drawing.Point(197, 253)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(60, 13)
        Me.lbldescription.TabIndex = 47
        Me.lbldescription.Text = "Description"
        '
        'lblhsn
        '
        Me.lblhsn.AutoSize = True
        Me.lblhsn.Location = New System.Drawing.Point(78, 216)
        Me.lblhsn.Name = "lblhsn"
        Me.lblhsn.Size = New System.Drawing.Size(30, 13)
        Me.lblhsn.TabIndex = 46
        Me.lblhsn.Text = "HSN"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(812, 268)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 65
        Me.btnadd.Text = "+ ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cbxproductname
        '
        Me.cbxproductname.FormattingEnabled = True
        Me.cbxproductname.Location = New System.Drawing.Point(46, 269)
        Me.cbxproductname.Name = "cbxproductname"
        Me.cbxproductname.Size = New System.Drawing.Size(145, 21)
        Me.cbxproductname.TabIndex = 66
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
        Me.cbxtax.Location = New System.Drawing.Point(255, 412)
        Me.cbxtax.Name = "cbxtax"
        Me.cbxtax.Size = New System.Drawing.Size(145, 21)
        Me.cbxtax.TabIndex = 66
        '
        'dgitemdetails
        '
        Me.dgitemdetails.AllowUserToAddRows = False
        Me.dgitemdetails.AllowUserToDeleteRows = False
        Me.dgitemdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgitemdetails.Location = New System.Drawing.Point(46, 297)
        Me.dgitemdetails.Name = "dgitemdetails"
        Me.dgitemdetails.ReadOnly = True
        Me.dgitemdetails.Size = New System.Drawing.Size(749, 101)
        Me.dgitemdetails.TabIndex = 103
        '
        'invoiceadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 521)
        Me.Controls.Add(Me.dgitemdetails)
        Me.Controls.Add(Me.cbxtax)
        Me.Controls.Add(Me.cbxproductname)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cbxcurrency)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txttotalprice)
        Me.Controls.Add(Me.txtdiscription)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.lbltotalprice)
        Me.Controls.Add(Me.lbldiscount)
        Me.Controls.Add(Me.lblunitprice)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.lblproductname)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lblhsn)
        Me.Controls.Add(Me.Lblinvoiceno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnmodeofpayment)
        Me.Controls.Add(Me.btnonline)
        Me.Controls.Add(Me.btncash)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcustomername As Label
    Friend WithEvents lable6 As Label
    Friend WithEvents lblcustomeraddress As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btncash As RadioButton
    Friend WithEvents btnonline As RadioButton
    Friend WithEvents btnmodeofpayment As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lblinvoiceno As Label
    Private WithEvents btnreset As Button
    Private WithEvents btnsave As Button
    Private WithEvents cbxcurrency As ComboBox
    Private WithEvents txtquantity As TextBox
    Private WithEvents txttotalprice As TextBox
    Private WithEvents txtdiscription As TextBox
    Private WithEvents txtunitprice As TextBox
    Private WithEvents txtdiscount As TextBox
    Private WithEvents TextBox12 As TextBox
    Private WithEvents txtproductname As TextBox
    Private WithEvents lbltotalprice As Label
    Private WithEvents lbldiscount As Label
    Private WithEvents lblunitprice As Label
    Private WithEvents lblquantity As Label
    Private WithEvents lblproductname As Label
    Private WithEvents lbldescription As Label
    Private WithEvents lblhsn As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents cbxproductname As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cbxtax As ComboBox
    Friend WithEvents dgitemdetails As DataGridView
End Class
