Public Class addstock
    Protected startdb As startdb = New startdb()
    Protected dtadd As DataTable = New DataTable()
    Private Sub addstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtvendorlist As New DataTable
        Dim dtvendorlistdb As New DataTable
        Try
            cbxvendor.ValueMember = "Vendor Code"
            cbxvendor.DisplayMember = "Vendor Name"
            dtvendorlist.Columns.Add("Vendor Code")
            dtvendorlist.Columns.Add("Vendor Name")
            Dim R As DataRow = dtvendorlist.NewRow
            R("Vendor Code") = "0"
            R("Vendor Name") = "Select Vendor"
            dtvendorlist.Rows.Add(R)
            dtvendorlistdb = startdb.getVendorList(False)
            dtvendorlist.Merge(dtvendorlistdb, True, MissingSchemaAction.Ignore)
            cbxvendor.DataSource = dtvendorlist
            dtadd = startdb.getstock(False)
            dgvStock.DataSource = dtadd
            cbxbaseunit.SelectedIndex = 0
            lblpurchaseno.Text = startdb.getpurchaseno()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim dtgrid As New DataTable
        Dim strtotal As String = 0
        Dim strdiscount As String = 0
        Dim strtax As String = 0
        dtadd.Rows.Add(txtcode.Text.ToString, cbxitemcategory.SelectedItem.ToString, txtproductname.Text.ToString, txtdescription.Text.ToString, txtqty.Text.ToString,
                       cbxbaseunit.SelectedItem.ToString, txtunitprice.Text.ToString, txttax.Text.ToString, txtdiscount.Text.ToString,
                       txtunitprice.Text.ToString * txtqty.Text.ToString - txtdiscount.Text.ToString + txttax.Text.ToString)
        dtgrid = dgvStock.DataSource
        For Each dr As DataRow In dtgrid.Rows
            strtotal = strtotal + dr("Price")
            strdiscount = strdiscount + dr("Discount")
            strtax = strtax + dr("Tax")
        Next
        txttotal.Text = strtotal
        txttotaldiscount.Text = strdiscount
        txttotaltax.Text = strtax
        reset(False)
    End Sub

    Private Sub txttotaltax_TextChanged(sender As Object, e As EventArgs) Handles txttotaltax.Leave
        Dim dtgrid As New DataTable
        Dim strtotal As String = 0
        dtgrid = dgvStock.DataSource
        For Each dr As DataRow In dtgrid.Rows
            strtotal = strtotal + dr("Price")
        Next
        txttotal.Text = Int(strtotal) - Int(txttotaldiscount.Text) + Int(txttotaltax.Text)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim dtitems As New DataTable
        dtitems = dgvStock.DataSource
        For Each dr As DataRow In dtitems.Rows
            startdb.saveStock(dr("Item Code").ToString, lblpurchaseno.Text, cbxvendor.SelectedValue.ToString, txttotal.Text, txtvendorinvoiceno.Text, dr("Item Category").ToString _
                , dr("Product Name").ToString, dr("Description").ToString, dr("Quantity").ToString, dr("Base Unit").ToString, dr("Unit Price").ToString, dr("Tax").ToString,
                              dr("Discount").ToString, dr("Price").ToString, DateTimePicker1.Value.ToString("dd-MM-yyyy"), False)
            Exit For
        Next
        For Each dr As DataRow In dtitems.Rows
            startdb.saveStock(dr("Item Code").ToString, lblpurchaseno.Text, cbxvendor.SelectedValue.ToString, txttotal.Text, txtvendorinvoiceno.Text, dr("Item Category").ToString _
                , dr("Product Name").ToString, dr("Description").ToString, dr("Quantity").ToString, dr("Base Unit").ToString, dr("Unit Price").ToString, dr("Tax").ToString,
                              dr("Discount").ToString, dr("Price").ToString, DateTimePicker1.Value.ToString("dd-MM-yyyy"), True)
        Next
        reset(True)
    End Sub

    Protected Function reset(ByVal resetgrid As Boolean)
        txtcode.Text = ""
        cbxitemcategory.SelectedIndex = 0
        txtproductname.Text = ""
        txtdescription.Text = ""
        txtunitprice.Text = ""
        txtqty.Text = ""
        txtdiscount.Text = 0
        txttax.Text = 0
        If resetgrid Then
            dtadd = startdb.getstock()
            dgvStock.DataSource = dtadd
            txttotal.Text = 0
            txttotaldiscount.Text = 0
            txttotaltax.Text = 0
        End If
    End Function

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        reset(True)
    End Sub
End Class