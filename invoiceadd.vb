Imports System.IO

Public Class invoiceadd
    Protected startdb As startdb = New startdb()
    Protected dtadd As DataTable = New DataTable()

    Private Sub invoiceadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtprodlist As New DataTable
        Dim dtprodlistdb As New DataTable
        cbxtax.Enabled = False
        Try
            dtadd = startdb.setitemstructure()
            dgitemdetails.DataSource = dtadd
            Lblinvoiceno.Text = startdb.getnextinvoiceno()
            cbxproductname.ValueMember = "Product_ID"
            cbxproductname.DisplayMember = "Product_Description"
            dtprodlist.Columns.Add("Product_ID")
            dtprodlist.Columns.Add("Product_Description")
            Dim R As DataRow = dtprodlist.NewRow
            R("Product_ID") = "0"
            R("Product_Description") = "Select Product"
            dtprodlist.Rows.Add(R)
            dtprodlistdb = startdb.getProductList
            dtprodlist.Merge(dtprodlistdb)
            cbxproductname.DataSource = dtprodlist
            txtdiscount.Text = 0
            txtquantity.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        setTotal(True)
        cbxtax.Enabled = True
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim frmmenu As New Menu
        frmmenu.Show()
        Me.Close()
    End Sub

    Private Sub cbxproductname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxproductname.SelectedIndexChanged
        If cbxproductname.SelectedIndex <> 0 Then
            Dim dtdescription As New DataTable
            dtdescription = startdb.getProductDescription(cbxproductname.SelectedValue.ToString)
            txtdiscription.Text = dtdescription(0)("description").ToString
            cbxbaseunit.SelectedItem = dtdescription(0)("base_unit")
            txtunitprice.Text = dtdescription(0)("unit_price")
            txtquantity.Text = 1
        Else
            clearControl()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim dtcustomercode As New DataTable
        Dim dtinvvoice As DataTable = dgitemdetails.DataSource
        Try
            dtcustomercode = startdb.savecustomer(txtcustomername.Text.ToString, txtcustomernumber.Text.ToString, txtcustomeraddress.Text.ToString)
            For Each dr As DataRow In dtinvvoice.Rows
                startdb.saveinvoice(dtcustomercode(0)(0), dr("Item Code").ToString, dr("Quantity").ToString, dr("Unit Price").ToString, dr("Discount").ToString,
                                        lbltax.Text.ToString, If(btncash.Checked, "cash", "online"), dr("Total Price"),
                                          txttotal.Text.ToString, DateTimePicker1.Value.ToString("dd-MM-yyyy"), True, Lblinvoiceno.Text.ToString)
                Exit For
            Next
            For Each dr As DataRow In dtinvvoice.Rows
                startdb.saveinvoice(dtcustomercode(0)(0), dr("Item Code").ToString, dr("Quantity").ToString, dr("Unit Price").ToString, dr("Discount").ToString,
                                    lbltax.Text.ToString, If(btncash.Checked, "cash", "online"), dr("Total Price"),
                                      txttotal.Text.ToString, DateTimePicker1.Value.ToString("dd-MM-yyyy"), False, Lblinvoiceno.Text.ToString)
            Next
        Catch ex As Exception
        End Try
        btnreset_Click(sender, e)
    End Sub

    Protected Function clearControl()
        cbxproductname.SelectedIndex = 0
        txtdiscription.Text = ""
        txtquantity.Text = 0
        txtdiscount.Text = 0
        txtunitprice.Text = ""
        cbxbaseunit.SelectedIndex = 0
    End Function

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        clearControl()
        txtcustomername.Text = ""
        txtcustomernumber.Text = ""
        txtcustomeraddress.Text = ""
        txttotal.Text = ""
        cbxtax.SelectedIndex = 0
        dgitemdetails.DataSource = Nothing
        startdb.setitemstructure()
        lbltax.Text = 0
        txttotal.Text = 0
    End Sub

    Private Sub cbxtax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxtax.SelectedIndexChanged
        setTotal(False)
        If cbxtax.SelectedIndex.ToString <> 0 Then
            lbltax.Text = Int((Int(txttotal.Text.ToString) * Int(cbxtax.SelectedItem.ToString.Split("%")(0).ToString)) / 100)
            txttotal.Text = (Int(txttotal.Text.ToString) + Int((Int(txttotal.Text.ToString) * Int(cbxtax.SelectedItem.ToString.Split("%")(0).ToString)) / 100)).ToString
        End If

    End Sub
    Protected Function setTotal(ByVal isNew As Boolean)
        Dim dtgrid As New DataTable
        Dim strtotal As String = "0"
        Dim dt As New DataTable
        dt = startdb.getProductDescription(cbxproductname.SelectedValue.ToString)
        If isNew Then
            dtadd.Rows.Add(cbxproductname.SelectedValue.ToString, DirectCast(cbxproductname.SelectedItem, System.Data.DataRowView).Row.ItemArray(1).ToString, dt(0)("description").ToString,
                       txtunitprice.Text.ToString, txtquantity.Text.ToString, cbxbaseunit.SelectedItem.ToString,
                       txtdiscount.Text.ToString, ((Int(txtunitprice.Text.ToString) * Int(txtquantity.Text.ToString)) - Int(txtdiscount.Text.ToString)))
            dgitemdetails.DataSource = dtadd
            clearControl()
        End If
        dtgrid = dgitemdetails.DataSource
        For Each dr As DataRow In dtgrid.Rows
            strtotal = strtotal + dr("Total Price")
        Next
        txttotal.Text = strtotal
    End Function

    Private Sub lbltax_Click(sender As Object, e As EventArgs) Handles lbltax.Click

    End Sub
End Class