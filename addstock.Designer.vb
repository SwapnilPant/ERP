<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addstock
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
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cbxitemcategory = New System.Windows.Forms.ComboBox()
        Me.cbxbaseunit = New System.Windows.Forms.ComboBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.lblpurchaserate = New System.Windows.Forms.Label()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.lbluom = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lblunitprice = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblitemcategory = New System.Windows.Forms.Label()
        Me.lblproductname = New System.Windows.Forms.Label()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.lblhsn = New System.Windows.Forms.Label()
        Me.lblproduct = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lable6 = New System.Windows.Forms.Label()
        Me.lblvendorname = New System.Windows.Forms.Label()
        Me.cbxvendor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtvendorinvoiceno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttotaltax = New System.Windows.Forms.TextBox()
        Me.txttotaldiscount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblpurchaseno = New System.Windows.Forms.Label()
        Me.Btnback = New System.Windows.Forms.Button()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(722, 459)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 51
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(803, 459)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 50
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'cbxitemcategory
        '
        Me.cbxitemcategory.AutoCompleteCustomSource.AddRange(New String() {"Cloths", "Medicine", "Auto"})
        Me.cbxitemcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxitemcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxitemcategory.FormattingEnabled = True
        Me.cbxitemcategory.Items.AddRange(New Object() {"Cloths", "Medicine", "Auto"})
        Me.cbxitemcategory.Location = New System.Drawing.Point(173, 112)
        Me.cbxitemcategory.Name = "cbxitemcategory"
        Me.cbxitemcategory.Size = New System.Drawing.Size(121, 21)
        Me.cbxitemcategory.TabIndex = 34
        '
        'cbxbaseunit
        '
        Me.cbxbaseunit.AllowDrop = True
        Me.cbxbaseunit.Items.AddRange(New Object() {"pcs", "box", "free", "nos", "dozen", "meter", "cm"})
        Me.cbxbaseunit.Location = New System.Drawing.Point(463, 211)
        Me.cbxbaseunit.Name = "cbxbaseunit"
        Me.cbxbaseunit.Size = New System.Drawing.Size(66, 21)
        Me.cbxbaseunit.TabIndex = 39
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(342, 211)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(74, 20)
        Me.txtqty.TabIndex = 38
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(587, 459)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 49
        Me.txttotal.Text = "0"
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(173, 210)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(100, 20)
        Me.txtunitprice.TabIndex = 37
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(587, 214)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtdiscount.TabIndex = 41
        Me.txtdiscount.Text = "0"
        '
        'txttax
        '
        Me.txttax.Location = New System.Drawing.Point(739, 216)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(100, 20)
        Me.txttax.TabIndex = 42
        Me.txttax.Text = "0"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(385, 146)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(100, 20)
        Me.textBox4.TabIndex = 40
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(173, 181)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(333, 20)
        Me.txtdescription.TabIndex = 36
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(173, 142)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(100, 20)
        Me.txtproductname.TabIndex = 35
        '
        'lblpurchaserate
        '
        Me.lblpurchaserate.AutoSize = True
        Me.lblpurchaserate.Location = New System.Drawing.Point(460, 462)
        Me.lblpurchaserate.Name = "lblpurchaserate"
        Me.lblpurchaserate.Size = New System.Drawing.Size(121, 13)
        Me.lblpurchaserate.TabIndex = 32
        Me.lblpurchaserate.Text = "Purchase rate                "
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Location = New System.Drawing.Point(532, 217)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(49, 13)
        Me.lbldiscount.TabIndex = 31
        Me.lbldiscount.Text = "Discount"
        '
        'lbluom
        '
        Me.lbluom.AutoSize = True
        Me.lbluom.Location = New System.Drawing.Point(422, 214)
        Me.lbluom.Name = "lbluom"
        Me.lbluom.Size = New System.Drawing.Size(30, 13)
        Me.lbluom.TabIndex = 30
        Me.lbluom.Text = "UoM"
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Location = New System.Drawing.Point(694, 220)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(25, 13)
        Me.lbltax.TabIndex = 29
        Me.lbltax.Text = "Tax"
        '
        'lblunitprice
        '
        Me.lblunitprice.AutoSize = True
        Me.lblunitprice.Location = New System.Drawing.Point(66, 217)
        Me.lblunitprice.Name = "lblunitprice"
        Me.lblunitprice.Size = New System.Drawing.Size(53, 13)
        Me.lblunitprice.TabIndex = 28
        Me.lblunitprice.Text = "Unit Price"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Location = New System.Drawing.Point(279, 214)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(46, 13)
        Me.lblquantity.TabIndex = 27
        Me.lblquantity.Text = "Quantity"
        '
        'lblitemcategory
        '
        Me.lblitemcategory.AutoSize = True
        Me.lblitemcategory.Location = New System.Drawing.Point(64, 112)
        Me.lblitemcategory.Name = "lblitemcategory"
        Me.lblitemcategory.Size = New System.Drawing.Size(72, 13)
        Me.lblitemcategory.TabIndex = 26
        Me.lblitemcategory.Text = "Item Category"
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Location = New System.Drawing.Point(64, 149)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(75, 13)
        Me.lblproductname.TabIndex = 25
        Me.lblproductname.Text = "Product Name"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Location = New System.Drawing.Point(66, 184)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(60, 13)
        Me.lbldescription.TabIndex = 24
        Me.lbldescription.Text = "Description"
        '
        'lblhsn
        '
        Me.lblhsn.AutoSize = True
        Me.lblhsn.Location = New System.Drawing.Point(332, 149)
        Me.lblhsn.Name = "lblhsn"
        Me.lblhsn.Size = New System.Drawing.Size(30, 13)
        Me.lblhsn.TabIndex = 23
        Me.lblhsn.Text = "HSN"
        '
        'lblproduct
        '
        Me.lblproduct.AutoSize = True
        Me.lblproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproduct.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblproduct.Location = New System.Drawing.Point(57, 29)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(67, 18)
        Me.lblproduct.TabIndex = 22
        Me.lblproduct.Text = "Product"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(711, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 32
        '
        'lable6
        '
        Me.lable6.AutoSize = True
        Me.lable6.Location = New System.Drawing.Point(664, 29)
        Me.lable6.Name = "lable6"
        Me.lable6.Size = New System.Drawing.Size(30, 13)
        Me.lable6.TabIndex = 78
        Me.lable6.Text = "Date"
        '
        'lblvendorname
        '
        Me.lblvendorname.AutoSize = True
        Me.lblvendorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendorname.Location = New System.Drawing.Point(584, 84)
        Me.lblvendorname.Name = "lblvendorname"
        Me.lblvendorname.Size = New System.Drawing.Size(95, 17)
        Me.lblvendorname.TabIndex = 80
        Me.lblvendorname.Text = "Vendor Name"
        '
        'cbxvendor
        '
        Me.cbxvendor.FormattingEnabled = True
        Me.cbxvendor.Location = New System.Drawing.Point(690, 84)
        Me.cbxvendor.Name = "cbxvendor"
        Me.cbxvendor.Size = New System.Drawing.Size(244, 21)
        Me.cbxvendor.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Code"
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(173, 81)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 33
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(60, 254)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.Size = New System.Drawing.Size(889, 187)
        Me.dgvStock.TabIndex = 44
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(859, 216)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 43
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtvendorinvoiceno
        '
        Me.txtvendorinvoiceno.Location = New System.Drawing.Point(739, 129)
        Me.txtvendorinvoiceno.Name = "txtvendorinvoiceno"
        Me.txtvendorinvoiceno.Size = New System.Drawing.Size(100, 20)
        Me.txtvendorinvoiceno.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(584, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Vendor Invoice No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 457)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Discount"
        '
        'txttotaltax
        '
        Me.txttotaltax.Location = New System.Drawing.Point(316, 457)
        Me.txttotaltax.Name = "txttotaltax"
        Me.txttotaltax.Size = New System.Drawing.Size(100, 20)
        Me.txttotaltax.TabIndex = 48
        Me.txttotaltax.Text = "0"
        '
        'txttotaldiscount
        '
        Me.txttotaldiscount.Location = New System.Drawing.Point(126, 455)
        Me.txttotaldiscount.Name = "txttotaldiscount"
        Me.txttotaldiscount.Size = New System.Drawing.Size(100, 20)
        Me.txttotaldiscount.TabIndex = 47
        Me.txttotaldiscount.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Purchase No."
        '
        'lblpurchaseno
        '
        Me.lblpurchaseno.AutoSize = True
        Me.lblpurchaseno.Location = New System.Drawing.Point(170, 59)
        Me.lblpurchaseno.Name = "lblpurchaseno"
        Me.lblpurchaseno.Size = New System.Drawing.Size(13, 13)
        Me.lblpurchaseno.TabIndex = 26
        Me.lblpurchaseno.Text = "0"
        '
        'Btnback
        '
        Me.Btnback.Location = New System.Drawing.Point(885, 459)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(75, 23)
        Me.Btnback.TabIndex = 52
        Me.Btnback.Text = "Back"
        Me.Btnback.UseVisualStyleBackColor = True
        '
        'addstock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 503)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dgvStock)
        Me.Controls.Add(Me.cbxvendor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblvendorname)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lable6)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cbxitemcategory)
        Me.Controls.Add(Me.cbxbaseunit)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.txttotaldiscount)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.txttotaltax)
        Me.Controls.Add(Me.txtvendorinvoiceno)
        Me.Controls.Add(Me.txttax)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblpurchaserate)
        Me.Controls.Add(Me.lbldiscount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbluom)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.lblunitprice)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.lblpurchaseno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblitemcategory)
        Me.Controls.Add(Me.lblproductname)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lblhsn)
        Me.Controls.Add(Me.lblproduct)
        Me.Name = "addstock"
        Me.Text = "addstock"
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnreset As Button
    Private WithEvents btnsave As Button
    Private WithEvents cbxitemcategory As ComboBox
    Private WithEvents cbxbaseunit As ComboBox
    Private WithEvents txtqty As TextBox
    Private WithEvents txttotal As TextBox
    Private WithEvents txtunitprice As TextBox
    Private WithEvents txtdiscount As TextBox
    Private WithEvents txttax As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents txtdescription As TextBox
    Private WithEvents txtproductname As TextBox
    Private WithEvents lblpurchaserate As Label
    Private WithEvents lbldiscount As Label
    Private WithEvents lbluom As Label
    Private WithEvents lbltax As Label
    Private WithEvents lblunitprice As Label
    Private WithEvents lblquantity As Label
    Private WithEvents lblitemcategory As Label
    Private WithEvents lblproductname As Label
    Private WithEvents lbldescription As Label
    Private WithEvents lblhsn As Label
    Private WithEvents lblproduct As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lable6 As Label
    Friend WithEvents lblvendorname As Label
    Friend WithEvents cbxvendor As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents txtcode As TextBox
    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents btnadd As Button
    Private WithEvents txtvendorinvoiceno As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents txttotaltax As TextBox
    Private WithEvents txttotaldiscount As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents lblpurchaseno As Label
    Private WithEvents Btnback As Button
End Class
