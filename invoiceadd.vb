Imports System.IO

Public Class invoiceadd
    Protected startdb As startdb = New startdb()
    Private Sub invoiceadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtadd As New DataTable
        Dim sqldr As SQLite.SQLiteDataReader
        startdb.sqlcomm.CommandText = "select stk.description as [Prodcut Name],inv.item_rate as [Unit Price]," _
                                & " inv.item_quantity as [Quantity],inv.discount as [Discount],inv.price as [Total Price] from invoice as inv " _
                                & "inner join tblstock stk on stk.item_code = inv.item_code order by inv.created_date"
        Try
            sqldr = startdb.sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
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

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim frmmenu As New Menu
        frmmenu.Show()
        Me.Close()
    End Sub
End Class