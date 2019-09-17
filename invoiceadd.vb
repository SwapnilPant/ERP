Imports System.IO

Public Class invoiceadd
    Public ds As New DataSet
    Public dt As DataTable

    Private Sub invoiceadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Path As Array = AppDomain.CurrentDomain.BaseDirectory.ToString.Split("bin")
        ds.ReadXml(Path(0) + "/app/files/itemmodel.xml")
        dt = ds.Tables("Items_model")
        dgitemdetails.DataSource = dt
        Lblinvoiceno.Text = 1


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgitemdetails_CellContentClick(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        dgitemdetails.Columns("srno").HeaderText = "Sr no."
        dgitemdetails.Columns("item_code").HeaderText = "Item Code"
        dgitemdetails.Columns("item_name").HeaderText = "Item Name"
        dgitemdetails.Columns("item_quantity").HeaderText = "Quantity"
        dgitemdetails.Columns("item_unit").HeaderText = "MRP"
        dgitemdetails.Columns("item_unit_price").HeaderText = "Rate"
        dgitemdetails.Columns("item_price").HeaderText = "Amount"
    End Sub

    Private Sub lblpurchaserate_Click(sender As Object, e As EventArgs) Handles lbltotalprice.Click

    End Sub
End Class