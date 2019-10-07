<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history
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
        Me.cbxtransaction = New System.Windows.Forms.ComboBox()
        Me.dgresult = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lable6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblvendorname = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.cbxproductname = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblitemcategory = New System.Windows.Forms.Label()
        Me.lblproductname = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txtquantity = New System.Windows.Forms.TextBox()
        Me.Cbxcode = New System.Windows.Forms.ComboBox()
        Me.Cbxitem = New System.Windows.Forms.ComboBox()
        Me.Btnfetch = New System.Windows.Forms.Button()
        Me.Cbxinvoiceno = New System.Windows.Forms.ComboBox()
        Me.Cbxcustomername = New System.Windows.Forms.ComboBox()
        Me.cbxvendorname = New System.Windows.Forms.ComboBox()
        CType(Me.dgresult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxtransaction
        '
        Me.cbxtransaction.FormattingEnabled = True
        Me.cbxtransaction.Location = New System.Drawing.Point(176, 17)
        Me.cbxtransaction.Name = "cbxtransaction"
        Me.cbxtransaction.Size = New System.Drawing.Size(215, 21)
        Me.cbxtransaction.TabIndex = 0
        '
        'dgresult
        '
        Me.dgresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgresult.Location = New System.Drawing.Point(38, 205)
        Me.dgresult.Name = "dgresult"
        Me.dgresult.Size = New System.Drawing.Size(878, 191)
        Me.dgresult.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(642, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 79
        '
        'lable6
        '
        Me.lable6.AutoSize = True
        Me.lable6.Location = New System.Drawing.Point(596, 25)
        Me.lable6.Name = "lable6"
        Me.lable6.Size = New System.Drawing.Size(30, 13)
        Me.lable6.TabIndex = 78
        Me.lable6.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(639, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(642, 59)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(606, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Transaction"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(816, 402)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Invoice no."
        '
        'lblvendorname
        '
        Me.lblvendorname.AutoSize = True
        Me.lblvendorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendorname.Location = New System.Drawing.Point(67, 47)
        Me.lblvendorname.Name = "lblvendorname"
        Me.lblvendorname.Size = New System.Drawing.Size(95, 17)
        Me.lblvendorname.TabIndex = 83
        Me.lblvendorname.Text = "Vendor Name"
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(507, 126)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(109, 17)
        Me.lblcustomername.TabIndex = 85
        Me.lblcustomername.Text = "Customer Name"
        '
        'cbxproductname
        '
        Me.cbxproductname.FormattingEnabled = True
        Me.cbxproductname.Location = New System.Drawing.Point(176, 148)
        Me.cbxproductname.Name = "cbxproductname"
        Me.cbxproductname.Size = New System.Drawing.Size(121, 21)
        Me.cbxproductname.TabIndex = 92
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Product Code"
        '
        'lblitemcategory
        '
        Me.lblitemcategory.AutoSize = True
        Me.lblitemcategory.Location = New System.Drawing.Point(67, 117)
        Me.lblitemcategory.Name = "lblitemcategory"
        Me.lblitemcategory.Size = New System.Drawing.Size(72, 13)
        Me.lblitemcategory.TabIndex = 89
        Me.lblitemcategory.Text = "Item Category"
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Location = New System.Drawing.Point(67, 154)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(75, 13)
        Me.lblproductname.TabIndex = 87
        Me.lblproductname.Text = "Product Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(841, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txtquantity
        '
        Me.Txtquantity.Location = New System.Drawing.Point(676, 402)
        Me.Txtquantity.Name = "Txtquantity"
        Me.Txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.Txtquantity.TabIndex = 82
        '
        'Cbxcode
        '
        Me.Cbxcode.FormattingEnabled = True
        Me.Cbxcode.Location = New System.Drawing.Point(176, 84)
        Me.Cbxcode.Name = "Cbxcode"
        Me.Cbxcode.Size = New System.Drawing.Size(121, 21)
        Me.Cbxcode.TabIndex = 0
        '
        'Cbxitem
        '
        Me.Cbxitem.AutoCompleteCustomSource.AddRange(New String() {"Select Category", "Cloths", "Medicine", "Auto"})
        Me.Cbxitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbxitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbxitem.FormattingEnabled = True
        Me.Cbxitem.Items.AddRange(New Object() {"Select Category", "Cloths", "Medicine", "Auto"})
        Me.Cbxitem.Location = New System.Drawing.Point(176, 117)
        Me.Cbxitem.Name = "Cbxitem"
        Me.Cbxitem.Size = New System.Drawing.Size(121, 21)
        Me.Cbxitem.TabIndex = 92
        '
        'Btnfetch
        '
        Me.Btnfetch.Location = New System.Drawing.Point(796, 146)
        Me.Btnfetch.Name = "Btnfetch"
        Me.Btnfetch.Size = New System.Drawing.Size(75, 23)
        Me.Btnfetch.TabIndex = 93
        Me.Btnfetch.Text = "fetch"
        Me.Btnfetch.UseVisualStyleBackColor = True
        '
        'Cbxinvoiceno
        '
        Me.Cbxinvoiceno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbxinvoiceno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbxinvoiceno.FormattingEnabled = True
        Me.Cbxinvoiceno.Location = New System.Drawing.Point(325, 148)
        Me.Cbxinvoiceno.Name = "Cbxinvoiceno"
        Me.Cbxinvoiceno.Size = New System.Drawing.Size(121, 21)
        Me.Cbxinvoiceno.TabIndex = 92
        '
        'Cbxcustomername
        '
        Me.Cbxcustomername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbxcustomername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbxcustomername.FormattingEnabled = True
        Me.Cbxcustomername.Location = New System.Drawing.Point(510, 154)
        Me.Cbxcustomername.Name = "Cbxcustomername"
        Me.Cbxcustomername.Size = New System.Drawing.Size(121, 21)
        Me.Cbxcustomername.TabIndex = 92
        '
        'cbxvendorname
        '
        Me.cbxvendorname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxvendorname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxvendorname.FormattingEnabled = True
        Me.cbxvendorname.Location = New System.Drawing.Point(176, 47)
        Me.cbxvendorname.Name = "cbxvendorname"
        Me.cbxvendorname.Size = New System.Drawing.Size(121, 21)
        Me.cbxvendorname.TabIndex = 92
        '
        'history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(993, 494)
        Me.Controls.Add(Me.Btnfetch)
        Me.Controls.Add(Me.cbxvendorname)
        Me.Controls.Add(Me.Cbxcustomername)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cbxinvoiceno)
        Me.Controls.Add(Me.Cbxitem)
        Me.Controls.Add(Me.cbxproductname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblitemcategory)
        Me.Controls.Add(Me.lblproductname)
        Me.Controls.Add(Me.lblcustomername)
        Me.Controls.Add(Me.lblvendorname)
        Me.Controls.Add(Me.Txtquantity)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lable6)
        Me.Controls.Add(Me.dgresult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cbxcode)
        Me.Controls.Add(Me.cbxtransaction)
        Me.Name = "history"
        Me.Text = "  "
        CType(Me.dgresult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxtransaction As ComboBox
    Friend WithEvents dgresult As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lable6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents txtsubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblvendorname As Label
    Friend WithEvents lblcustomername As Label
    Private WithEvents cbxproductname As ComboBox
    Private WithEvents Label7 As Label
    Private WithEvents lblitemcategory As Label
    Private WithEvents lblproductname As Label
    Friend WithEvents Button1 As Button
    Private WithEvents Txtquantity As TextBox
    Friend WithEvents Cbxcode As ComboBox
    Private WithEvents Cbxitem As ComboBox
    Friend WithEvents Btnfetch As Button
    Private WithEvents Cbxinvoiceno As ComboBox
    Private WithEvents Cbxcustomername As ComboBox
    Private WithEvents cbxvendorname As ComboBox
End Class
