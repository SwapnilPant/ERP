Imports System.IO

Public Class invoiceadd
    Protected startdb As startdb = New startdb()
    Protected dtadd As New DataTable

    Private Sub invoiceadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqldr As SQLite.SQLiteDataReader
        Dim dtprodlist As New DataTable

        startdb.sqlcomm.CommandText = "select stk.description as [Prodcut Name],inv.item_rate as [Unit Price]," _
                                & " inv.item_quantity as [Quantity],inv.discount as [Discount],inv.price as [Total Price] from invoice as inv " _
                                & "inner join tblstock stk on stk.item_code = inv.item_code order by inv.created_date"
        Try
            sqldr = startdb.sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
            startdb.sqlcomm.CommandText = "select item_code as [Product_ID],description as [Product_Description] from tblstock"
            dtprodlist.Load(sqldr)
            ComboBox1.DataSource = dtprodlist
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgitemdetails.DataSource = dtadd

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgitemdetails_CellContentClick(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        'dgitemdetails.Columns("srno").HeaderText = "Sr no."
        'dgitemdetails.Columns("item_code").HeaderText = "Item Code"
        'dgitemdetails.Columns("item_name").HeaderText = "Item Name"
        'dgitemdetails.Columns("item_quantity").HeaderText = "Quantity"
        'dgitemdetails.Columns("item_unit").HeaderText = "MRP"
        'dgitemdetails.Columns("item_unit_price").HeaderText = "Rate"
        'dgitemdetails.Columns("item_price").HeaderText = "Amount"
    End Sub

    Private Sub lblpurchaserate_Click(sender As Object, e As EventArgs) Handles lbltotalprice.Click

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
    dtadd.Rows.Add(cbxproductname.SelectedText.Text.ToString,txtunitprice.Text.ToString,txtquantity.Text.ToString,txtdiscount.Text.ToString,txttotalprice.Text.ToString)
    dgitemdetails.DataSource = dtadd
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim frmmenu As New Menu
        frmmenu.Show()
        Me.Close()
    End Sub
End Class